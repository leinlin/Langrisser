using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Battle;
using BlackJack.ProjectL.Common;
using FixMath.NET;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020011A8 RID: 4520
[Preserve]
public class Lua_BlackJack_ProjectL_Battle_CombatFlyObject : LuaObject
{
	// Token: 0x060175EE RID: 95726 RVA: 0x0065CD24 File Offset: 0x0065AF24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			CombatFlyObject o = new CombatFlyObject();
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

	// Token: 0x060175EF RID: 95727 RVA: 0x0065CD6C File Offset: 0x0065AF6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Dispose(IntPtr l)
	{
		int result;
		try
		{
			CombatFlyObject combatFlyObject = (CombatFlyObject)LuaObject.checkSelf(l);
			combatFlyObject.Dispose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060175F0 RID: 95728 RVA: 0x0065CDB8 File Offset: 0x0065AFB8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Initialize(IntPtr l)
	{
		int result;
		try
		{
			CombatFlyObject combatFlyObject = (CombatFlyObject)LuaObject.checkSelf(l);
			CombatTeam team;
			LuaObject.checkType<CombatTeam>(l, 2, out team);
			combatFlyObject.Initialize(team);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060175F1 RID: 95729 RVA: 0x0065CE10 File Offset: 0x0065B010
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Setup(IntPtr l)
	{
		int result;
		try
		{
			CombatFlyObject combatFlyObject = (CombatFlyObject)LuaObject.checkSelf(l);
			ConfigDataFlyObjectInfo flyObjInfo;
			LuaObject.checkType<ConfigDataFlyObjectInfo>(l, 2, out flyObjInfo);
			CombatSkillState ss;
			LuaObject.checkType<CombatSkillState>(l, 3, out ss);
			CombatActor sourceActor;
			LuaObject.checkType<CombatActor>(l, 4, out sourceActor);
			CombatActor targetActor;
			LuaObject.checkType<CombatActor>(l, 5, out targetActor);
			combatFlyObject.Setup(flyObjInfo, ss, sourceActor, targetActor);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060175F2 RID: 95730 RVA: 0x0065CE90 File Offset: 0x0065B090
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsHero(IntPtr l)
	{
		int result;
		try
		{
			CombatFlyObject combatFlyObject = (CombatFlyObject)LuaObject.checkSelf(l);
			bool b = combatFlyObject.IsHero();
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

	// Token: 0x060175F3 RID: 95731 RVA: 0x0065CEE4 File Offset: 0x0065B0E4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetGraphicSkillFade(IntPtr l)
	{
		int result;
		try
		{
			CombatFlyObject combatFlyObject = (CombatFlyObject)LuaObject.checkSelf(l);
			bool graphicSkillFade;
			LuaObject.checkType(l, 2, out graphicSkillFade);
			combatFlyObject.SetGraphicSkillFade(graphicSkillFade);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060175F4 RID: 95732 RVA: 0x0065CF3C File Offset: 0x0065B13C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Tick(IntPtr l)
	{
		int result;
		try
		{
			CombatFlyObject combatFlyObject = (CombatFlyObject)LuaObject.checkSelf(l);
			combatFlyObject.Tick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060175F5 RID: 95733 RVA: 0x0065CF88 File Offset: 0x0065B188
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int TickGraphic(IntPtr l)
	{
		int result;
		try
		{
			CombatFlyObject combatFlyObject = (CombatFlyObject)LuaObject.checkSelf(l);
			float dt;
			LuaObject.checkType(l, 2, out dt);
			combatFlyObject.TickGraphic(dt);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060175F6 RID: 95734 RVA: 0x0065CFE0 File Offset: 0x0065B1E0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Draw(IntPtr l)
	{
		int result;
		try
		{
			CombatFlyObject combatFlyObject = (CombatFlyObject)LuaObject.checkSelf(l);
			combatFlyObject.Draw();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060175F7 RID: 95735 RVA: 0x0065D02C File Offset: 0x0065B22C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DoPause(IntPtr l)
	{
		int result;
		try
		{
			CombatFlyObject combatFlyObject = (CombatFlyObject)LuaObject.checkSelf(l);
			bool pause;
			LuaObject.checkType(l, 2, out pause);
			combatFlyObject.DoPause(pause);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060175F8 RID: 95736 RVA: 0x0065D084 File Offset: 0x0065B284
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SearchHitTarget(IntPtr l)
	{
		int result;
		try
		{
			CombatFlyObject combatFlyObject = (CombatFlyObject)LuaObject.checkSelf(l);
			Fix64 x;
			LuaObject.checkValueType<Fix64>(l, 2, out x);
			Fix64 x2;
			LuaObject.checkValueType<Fix64>(l, 3, out x2);
			ushort hitId;
			LuaObject.checkType(l, 4, out hitId);
			CombatActor o = combatFlyObject.m_luaExportHelper.SearchHitTarget(x, x2, hitId);
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

	// Token: 0x060175F9 RID: 95737 RVA: 0x0065D108 File Offset: 0x0065B308
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddSkillDelayHits(IntPtr l)
	{
		int result;
		try
		{
			CombatFlyObject combatFlyObject = (CombatFlyObject)LuaObject.checkSelf(l);
			CombatSkillState ss;
			LuaObject.checkType<CombatSkillState>(l, 2, out ss);
			Fix64 x;
			LuaObject.checkValueType<Fix64>(l, 3, out x);
			Fix64 x2;
			LuaObject.checkValueType<Fix64>(l, 4, out x2);
			combatFlyObject.m_luaExportHelper.AddSkillDelayHits(ss, x, x2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060175FA RID: 95738 RVA: 0x0065D180 File Offset: 0x0065B380
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Attack(IntPtr l)
	{
		int result;
		try
		{
			CombatFlyObject combatFlyObject = (CombatFlyObject)LuaObject.checkSelf(l);
			CombatActor target;
			LuaObject.checkType<CombatActor>(l, 2, out target);
			bool b = combatFlyObject.m_luaExportHelper.Attack(target);
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

	// Token: 0x060175FB RID: 95739 RVA: 0x0065D1E8 File Offset: 0x0065B3E8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AddDelayHit(IntPtr l)
	{
		int result;
		try
		{
			CombatFlyObject combatFlyObject = (CombatFlyObject)LuaObject.checkSelf(l);
			CombatActor target;
			LuaObject.checkType<CombatActor>(l, 2, out target);
			int delay;
			LuaObject.checkType(l, 3, out delay);
			combatFlyObject.m_luaExportHelper.AddDelayHit(target, delay);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060175FC RID: 95740 RVA: 0x0065D254 File Offset: 0x0065B454
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetDelayHitFrameMax(IntPtr l)
	{
		int result;
		try
		{
			CombatFlyObject combatFlyObject = (CombatFlyObject)LuaObject.checkSelf(l);
			int delayHitFrameMax = combatFlyObject.m_luaExportHelper.GetDelayHitFrameMax();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, delayHitFrameMax);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060175FD RID: 95741 RVA: 0x0065D2B0 File Offset: 0x0065B4B0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int HasDelayHit(IntPtr l)
	{
		int result;
		try
		{
			CombatFlyObject combatFlyObject = (CombatFlyObject)LuaObject.checkSelf(l);
			bool b = combatFlyObject.m_luaExportHelper.HasDelayHit();
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

	// Token: 0x060175FE RID: 95742 RVA: 0x0065D30C File Offset: 0x0065B50C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TickDelayHits(IntPtr l)
	{
		int result;
		try
		{
			CombatFlyObject combatFlyObject = (CombatFlyObject)LuaObject.checkSelf(l);
			combatFlyObject.m_luaExportHelper.TickDelayHits();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060175FF RID: 95743 RVA: 0x0065D360 File Offset: 0x0065B560
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ComputeParabolicPosition(IntPtr l)
	{
		int result;
		try
		{
			CombatFlyObject combatFlyObject = (CombatFlyObject)LuaObject.checkSelf(l);
			Fix64 life;
			LuaObject.checkValueType<Fix64>(l, 2, out life);
			Vector2i vector2i;
			Fix64 fix;
			combatFlyObject.m_luaExportHelper.ComputeParabolicPosition(life, out vector2i, out fix);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, vector2i);
			LuaObject.pushValue(l, fix);
			result = 3;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017600 RID: 95744 RVA: 0x0065D3E0 File Offset: 0x0065B5E0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CreateFx(IntPtr l)
	{
		int result;
		try
		{
			CombatFlyObject combatFlyObject = (CombatFlyObject)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			float scale;
			LuaObject.checkType(l, 3, out scale);
			combatFlyObject.m_luaExportHelper.CreateFx(assetName, scale);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017601 RID: 95745 RVA: 0x0065D44C File Offset: 0x0065B64C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Dispose(IntPtr l)
	{
		int result;
		try
		{
			CombatFlyObject combatFlyObject = (CombatFlyObject)LuaObject.checkSelf(l);
			combatFlyObject.m_luaExportHelper.__callBase_Dispose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017602 RID: 95746 RVA: 0x0065D4A0 File Offset: 0x0065B6A0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_Tick(IntPtr l)
	{
		int result;
		try
		{
			CombatFlyObject combatFlyObject = (CombatFlyObject)LuaObject.checkSelf(l);
			combatFlyObject.m_luaExportHelper.__callBase_Tick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017603 RID: 95747 RVA: 0x0065D4F4 File Offset: 0x0065B6F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_TickGraphic(IntPtr l)
	{
		int result;
		try
		{
			CombatFlyObject combatFlyObject = (CombatFlyObject)LuaObject.checkSelf(l);
			float dt;
			LuaObject.checkType(l, 2, out dt);
			combatFlyObject.m_luaExportHelper.__callBase_TickGraphic(dt);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017604 RID: 95748 RVA: 0x0065D550 File Offset: 0x0065B750
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_Draw(IntPtr l)
	{
		int result;
		try
		{
			CombatFlyObject combatFlyObject = (CombatFlyObject)LuaObject.checkSelf(l);
			combatFlyObject.m_luaExportHelper.__callBase_Draw();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017605 RID: 95749 RVA: 0x0065D5A4 File Offset: 0x0065B7A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Pause(IntPtr l)
	{
		int result;
		try
		{
			CombatFlyObject combatFlyObject = (CombatFlyObject)LuaObject.checkSelf(l);
			bool pause;
			LuaObject.checkType(l, 2, out pause);
			combatFlyObject.m_luaExportHelper.__callBase_Pause(pause);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017606 RID: 95750 RVA: 0x0065D600 File Offset: 0x0065B800
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_DoPause(IntPtr l)
	{
		int result;
		try
		{
			CombatFlyObject combatFlyObject = (CombatFlyObject)LuaObject.checkSelf(l);
			bool pause;
			LuaObject.checkType(l, 2, out pause);
			combatFlyObject.m_luaExportHelper.__callBase_DoPause(pause);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017607 RID: 95751 RVA: 0x0065D65C File Offset: 0x0065B85C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_DeleteMe(IntPtr l)
	{
		int result;
		try
		{
			CombatFlyObject combatFlyObject = (CombatFlyObject)LuaObject.checkSelf(l);
			combatFlyObject.m_luaExportHelper.__callBase_DeleteMe();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017608 RID: 95752 RVA: 0x0065D6B0 File Offset: 0x0065B8B0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ComputeTargetScore_s(IntPtr l)
	{
		int result;
		try
		{
			Fix64 x;
			LuaObject.checkValueType<Fix64>(l, 1, out x);
			CombatActor target;
			LuaObject.checkType<CombatActor>(l, 2, out target);
			int i = CombatFlyObject.LuaExportHelper.ComputeTargetScore(x, target);
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

	// Token: 0x06017609 RID: 95753 RVA: 0x0065D710 File Offset: 0x0065B910
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_team(IntPtr l)
	{
		int result;
		try
		{
			CombatFlyObject combatFlyObject = (CombatFlyObject)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatFlyObject.m_luaExportHelper.m_team);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601760A RID: 95754 RVA: 0x0065D768 File Offset: 0x0065B968
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_team(IntPtr l)
	{
		int result;
		try
		{
			CombatFlyObject combatFlyObject = (CombatFlyObject)LuaObject.checkSelf(l);
			CombatTeam team;
			LuaObject.checkType<CombatTeam>(l, 2, out team);
			combatFlyObject.m_luaExportHelper.m_team = team;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601760B RID: 95755 RVA: 0x0065D7C4 File Offset: 0x0065B9C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_startPosition(IntPtr l)
	{
		int result;
		try
		{
			CombatFlyObject combatFlyObject = (CombatFlyObject)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatFlyObject.m_luaExportHelper.m_startPosition);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601760C RID: 95756 RVA: 0x0065D820 File Offset: 0x0065BA20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_startPosition(IntPtr l)
	{
		int result;
		try
		{
			CombatFlyObject combatFlyObject = (CombatFlyObject)LuaObject.checkSelf(l);
			Vector2i startPosition;
			LuaObject.checkValueType<Vector2i>(l, 2, out startPosition);
			combatFlyObject.m_luaExportHelper.m_startPosition = startPosition;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601760D RID: 95757 RVA: 0x0065D87C File Offset: 0x0065BA7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_endPosition(IntPtr l)
	{
		int result;
		try
		{
			CombatFlyObject combatFlyObject = (CombatFlyObject)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatFlyObject.m_luaExportHelper.m_endPosition);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601760E RID: 95758 RVA: 0x0065D8D8 File Offset: 0x0065BAD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_endPosition(IntPtr l)
	{
		int result;
		try
		{
			CombatFlyObject combatFlyObject = (CombatFlyObject)LuaObject.checkSelf(l);
			Vector2i endPosition;
			LuaObject.checkValueType<Vector2i>(l, 2, out endPosition);
			combatFlyObject.m_luaExportHelper.m_endPosition = endPosition;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601760F RID: 95759 RVA: 0x0065D934 File Offset: 0x0065BB34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_startZ(IntPtr l)
	{
		int result;
		try
		{
			CombatFlyObject combatFlyObject = (CombatFlyObject)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatFlyObject.m_luaExportHelper.m_startZ);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017610 RID: 95760 RVA: 0x0065D98C File Offset: 0x0065BB8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_startZ(IntPtr l)
	{
		int result;
		try
		{
			CombatFlyObject combatFlyObject = (CombatFlyObject)LuaObject.checkSelf(l);
			int startZ;
			LuaObject.checkType(l, 2, out startZ);
			combatFlyObject.m_luaExportHelper.m_startZ = startZ;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017611 RID: 95761 RVA: 0x0065D9E8 File Offset: 0x0065BBE8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_endZ(IntPtr l)
	{
		int result;
		try
		{
			CombatFlyObject combatFlyObject = (CombatFlyObject)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatFlyObject.m_luaExportHelper.m_endZ);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017612 RID: 95762 RVA: 0x0065DA40 File Offset: 0x0065BC40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_endZ(IntPtr l)
	{
		int result;
		try
		{
			CombatFlyObject combatFlyObject = (CombatFlyObject)LuaObject.checkSelf(l);
			int endZ;
			LuaObject.checkType(l, 2, out endZ);
			combatFlyObject.m_luaExportHelper.m_endZ = endZ;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017613 RID: 95763 RVA: 0x0065DA9C File Offset: 0x0065BC9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_vz(IntPtr l)
	{
		int result;
		try
		{
			CombatFlyObject combatFlyObject = (CombatFlyObject)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatFlyObject.m_luaExportHelper.m_vz);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017614 RID: 95764 RVA: 0x0065DAF8 File Offset: 0x0065BCF8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_vz(IntPtr l)
	{
		int result;
		try
		{
			CombatFlyObject combatFlyObject = (CombatFlyObject)LuaObject.checkSelf(l);
			Fix64 vz;
			LuaObject.checkValueType<Fix64>(l, 2, out vz);
			combatFlyObject.m_luaExportHelper.m_vz = vz;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017615 RID: 95765 RVA: 0x0065DB54 File Offset: 0x0065BD54
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_life(IntPtr l)
	{
		int result;
		try
		{
			CombatFlyObject combatFlyObject = (CombatFlyObject)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatFlyObject.m_luaExportHelper.m_life);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017616 RID: 95766 RVA: 0x0065DBAC File Offset: 0x0065BDAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_life(IntPtr l)
	{
		int result;
		try
		{
			CombatFlyObject combatFlyObject = (CombatFlyObject)LuaObject.checkSelf(l);
			int life;
			LuaObject.checkType(l, 2, out life);
			combatFlyObject.m_luaExportHelper.m_life = life;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017617 RID: 95767 RVA: 0x0065DC08 File Offset: 0x0065BE08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_lifeMax(IntPtr l)
	{
		int result;
		try
		{
			CombatFlyObject combatFlyObject = (CombatFlyObject)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatFlyObject.m_luaExportHelper.m_lifeMax);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017618 RID: 95768 RVA: 0x0065DC60 File Offset: 0x0065BE60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_lifeMax(IntPtr l)
	{
		int result;
		try
		{
			CombatFlyObject combatFlyObject = (CombatFlyObject)LuaObject.checkSelf(l);
			int lifeMax;
			LuaObject.checkType(l, 2, out lifeMax);
			combatFlyObject.m_luaExportHelper.m_lifeMax = lifeMax;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017619 RID: 95769 RVA: 0x0065DCBC File Offset: 0x0065BEBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_frameCount(IntPtr l)
	{
		int result;
		try
		{
			CombatFlyObject combatFlyObject = (CombatFlyObject)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatFlyObject.m_luaExportHelper.m_frameCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601761A RID: 95770 RVA: 0x0065DD14 File Offset: 0x0065BF14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_frameCount(IntPtr l)
	{
		int result;
		try
		{
			CombatFlyObject combatFlyObject = (CombatFlyObject)LuaObject.checkSelf(l);
			int frameCount;
			LuaObject.checkType(l, 2, out frameCount);
			combatFlyObject.m_luaExportHelper.m_frameCount = frameCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601761B RID: 95771 RVA: 0x0065DD70 File Offset: 0x0065BF70
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_hitId(IntPtr l)
	{
		int result;
		try
		{
			CombatFlyObject combatFlyObject = (CombatFlyObject)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatFlyObject.m_luaExportHelper.m_hitId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601761C RID: 95772 RVA: 0x0065DDC8 File Offset: 0x0065BFC8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_hitId(IntPtr l)
	{
		int result;
		try
		{
			CombatFlyObject combatFlyObject = (CombatFlyObject)LuaObject.checkSelf(l);
			ushort hitId;
			LuaObject.checkType(l, 2, out hitId);
			combatFlyObject.m_luaExportHelper.m_hitId = hitId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601761D RID: 95773 RVA: 0x0065DE24 File Offset: 0x0065C024
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_delayHits(IntPtr l)
	{
		int result;
		try
		{
			CombatFlyObject combatFlyObject = (CombatFlyObject)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatFlyObject.m_luaExportHelper.m_delayHits);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601761E RID: 95774 RVA: 0x0065DE7C File Offset: 0x0065C07C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_delayHits(IntPtr l)
	{
		int result;
		try
		{
			CombatFlyObject combatFlyObject = (CombatFlyObject)LuaObject.checkSelf(l);
			List<DelayHit> delayHits;
			LuaObject.checkType<List<DelayHit>>(l, 2, out delayHits);
			combatFlyObject.m_luaExportHelper.m_delayHits = delayHits;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601761F RID: 95775 RVA: 0x0065DED8 File Offset: 0x0065C0D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_targetActor(IntPtr l)
	{
		int result;
		try
		{
			CombatFlyObject combatFlyObject = (CombatFlyObject)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatFlyObject.m_luaExportHelper.m_targetActor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017620 RID: 95776 RVA: 0x0065DF30 File Offset: 0x0065C130
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_targetActor(IntPtr l)
	{
		int result;
		try
		{
			CombatFlyObject combatFlyObject = (CombatFlyObject)LuaObject.checkSelf(l);
			CombatActor targetActor;
			LuaObject.checkType<CombatActor>(l, 2, out targetActor);
			combatFlyObject.m_luaExportHelper.m_targetActor = targetActor;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017621 RID: 95777 RVA: 0x0065DF8C File Offset: 0x0065C18C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_targetTeamNumber(IntPtr l)
	{
		int result;
		try
		{
			CombatFlyObject combatFlyObject = (CombatFlyObject)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatFlyObject.m_luaExportHelper.m_targetTeamNumber);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017622 RID: 95778 RVA: 0x0065DFE4 File Offset: 0x0065C1E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_targetTeamNumber(IntPtr l)
	{
		int result;
		try
		{
			CombatFlyObject combatFlyObject = (CombatFlyObject)LuaObject.checkSelf(l);
			int targetTeamNumber;
			LuaObject.checkType(l, 2, out targetTeamNumber);
			combatFlyObject.m_luaExportHelper.m_targetTeamNumber = targetTeamNumber;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017623 RID: 95779 RVA: 0x0065E040 File Offset: 0x0065C240
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_sourceActor(IntPtr l)
	{
		int result;
		try
		{
			CombatFlyObject combatFlyObject = (CombatFlyObject)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatFlyObject.m_luaExportHelper.m_sourceActor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017624 RID: 95780 RVA: 0x0065E098 File Offset: 0x0065C298
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_sourceActor(IntPtr l)
	{
		int result;
		try
		{
			CombatFlyObject combatFlyObject = (CombatFlyObject)LuaObject.checkSelf(l);
			CombatActor sourceActor;
			LuaObject.checkType<CombatActor>(l, 2, out sourceActor);
			combatFlyObject.m_luaExportHelper.m_sourceActor = sourceActor;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017625 RID: 95781 RVA: 0x0065E0F4 File Offset: 0x0065C2F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_sourceSkillState(IntPtr l)
	{
		int result;
		try
		{
			CombatFlyObject combatFlyObject = (CombatFlyObject)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatFlyObject.m_luaExportHelper.m_sourceSkillState);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017626 RID: 95782 RVA: 0x0065E14C File Offset: 0x0065C34C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_sourceSkillState(IntPtr l)
	{
		int result;
		try
		{
			CombatFlyObject combatFlyObject = (CombatFlyObject)LuaObject.checkSelf(l);
			CombatSkillState sourceSkillState;
			LuaObject.checkType<CombatSkillState>(l, 2, out sourceSkillState);
			combatFlyObject.m_luaExportHelper.m_sourceSkillState = sourceSkillState;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017627 RID: 95783 RVA: 0x0065E1A8 File Offset: 0x0065C3A8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_configDataFlyObjectInfo(IntPtr l)
	{
		int result;
		try
		{
			CombatFlyObject combatFlyObject = (CombatFlyObject)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatFlyObject.m_luaExportHelper.m_configDataFlyObjectInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017628 RID: 95784 RVA: 0x0065E200 File Offset: 0x0065C400
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataFlyObjectInfo(IntPtr l)
	{
		int result;
		try
		{
			CombatFlyObject combatFlyObject = (CombatFlyObject)LuaObject.checkSelf(l);
			ConfigDataFlyObjectInfo configDataFlyObjectInfo;
			LuaObject.checkType<ConfigDataFlyObjectInfo>(l, 2, out configDataFlyObjectInfo);
			combatFlyObject.m_luaExportHelper.m_configDataFlyObjectInfo = configDataFlyObjectInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017629 RID: 95785 RVA: 0x0065E25C File Offset: 0x0065C45C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_fx(IntPtr l)
	{
		int result;
		try
		{
			CombatFlyObject combatFlyObject = (CombatFlyObject)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatFlyObject.m_luaExportHelper.m_fx);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601762A RID: 95786 RVA: 0x0065E2B4 File Offset: 0x0065C4B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_fx(IntPtr l)
	{
		int result;
		try
		{
			CombatFlyObject combatFlyObject = (CombatFlyObject)LuaObject.checkSelf(l);
			IBattleGraphic fx;
			LuaObject.checkType<IBattleGraphic>(l, 2, out fx);
			combatFlyObject.m_luaExportHelper.m_fx = fx;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601762B RID: 95787 RVA: 0x0065E310 File Offset: 0x0065C510
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_fxLife(IntPtr l)
	{
		int result;
		try
		{
			CombatFlyObject combatFlyObject = (CombatFlyObject)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatFlyObject.m_luaExportHelper.m_fxLife);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601762C RID: 95788 RVA: 0x0065E36C File Offset: 0x0065C56C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_fxLife(IntPtr l)
	{
		int result;
		try
		{
			CombatFlyObject combatFlyObject = (CombatFlyObject)LuaObject.checkSelf(l);
			Fix64 fxLife;
			LuaObject.checkValueType<Fix64>(l, 2, out fxLife);
			combatFlyObject.m_luaExportHelper.m_fxLife = fxLife;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601762D RID: 95789 RVA: 0x0065E3C8 File Offset: 0x0065C5C8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_isGraphicSkillFade(IntPtr l)
	{
		int result;
		try
		{
			CombatFlyObject combatFlyObject = (CombatFlyObject)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatFlyObject.m_luaExportHelper.m_isGraphicSkillFade);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601762E RID: 95790 RVA: 0x0065E420 File Offset: 0x0065C620
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_isGraphicSkillFade(IntPtr l)
	{
		int result;
		try
		{
			CombatFlyObject combatFlyObject = (CombatFlyObject)LuaObject.checkSelf(l);
			bool isGraphicSkillFade;
			LuaObject.checkType(l, 2, out isGraphicSkillFade);
			combatFlyObject.m_luaExportHelper.m_isGraphicSkillFade = isGraphicSkillFade;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601762F RID: 95791 RVA: 0x0065E47C File Offset: 0x0065C67C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Combat(IntPtr l)
	{
		int result;
		try
		{
			CombatFlyObject combatFlyObject = (CombatFlyObject)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatFlyObject.Combat);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017630 RID: 95792 RVA: 0x0065E4D0 File Offset: 0x0065C6D0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Battle.CombatFlyObject");
		if (Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatFlyObject.Dispose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatFlyObject.Initialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatFlyObject.Setup);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatFlyObject.IsHero);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatFlyObject.SetGraphicSkillFade);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatFlyObject.Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatFlyObject.TickGraphic);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatFlyObject.Draw);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatFlyObject.DoPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatFlyObject.SearchHitTarget);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatFlyObject.AddSkillDelayHits);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatFlyObject.Attack);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatFlyObject.AddDelayHit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatFlyObject.GetDelayHitFrameMax);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatFlyObject.HasDelayHit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatFlyObject.TickDelayHits);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatFlyObject.ComputeParabolicPosition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatFlyObject.CreateFx);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatFlyObject.__callBase_Dispose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatFlyObject.__callBase_Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatFlyObject.__callBase_TickGraphic);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatFlyObject.__callBase_Draw);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatFlyObject.__callBase_Pause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatFlyObject.__callBase_DoPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatFlyObject.__callBase_DeleteMe);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatFlyObject.ComputeTargetScore_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache19);
		string name = "m_team";
		if (Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatFlyObject.get_m_team);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache1A;
		if (Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatFlyObject.set_m_team);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache1B, true);
		string name2 = "m_startPosition";
		if (Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatFlyObject.get_m_startPosition);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache1C;
		if (Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatFlyObject.set_m_startPosition);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache1D, true);
		string name3 = "m_endPosition";
		if (Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatFlyObject.get_m_endPosition);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache1E;
		if (Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatFlyObject.set_m_endPosition);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache1F, true);
		string name4 = "m_startZ";
		if (Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatFlyObject.get_m_startZ);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatFlyObject.set_m_startZ);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache21, true);
		string name5 = "m_endZ";
		if (Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatFlyObject.get_m_endZ);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatFlyObject.set_m_endZ);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache23, true);
		string name6 = "m_vz";
		if (Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatFlyObject.get_m_vz);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache24;
		if (Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatFlyObject.set_m_vz);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache25, true);
		string name7 = "m_life";
		if (Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatFlyObject.get_m_life);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache26;
		if (Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatFlyObject.set_m_life);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache27, true);
		string name8 = "m_lifeMax";
		if (Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatFlyObject.get_m_lifeMax);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache28;
		if (Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatFlyObject.set_m_lifeMax);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache29, true);
		string name9 = "m_frameCount";
		if (Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatFlyObject.get_m_frameCount);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache2A;
		if (Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatFlyObject.set_m_frameCount);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache2B, true);
		string name10 = "m_hitId";
		if (Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatFlyObject.get_m_hitId);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache2C;
		if (Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatFlyObject.set_m_hitId);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache2D, true);
		string name11 = "m_delayHits";
		if (Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatFlyObject.get_m_delayHits);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache2E;
		if (Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatFlyObject.set_m_delayHits);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache2F, true);
		string name12 = "m_targetActor";
		if (Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatFlyObject.get_m_targetActor);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache30;
		if (Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatFlyObject.set_m_targetActor);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache31, true);
		string name13 = "m_targetTeamNumber";
		if (Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatFlyObject.get_m_targetTeamNumber);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache32;
		if (Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatFlyObject.set_m_targetTeamNumber);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache33, true);
		string name14 = "m_sourceActor";
		if (Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatFlyObject.get_m_sourceActor);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache34;
		if (Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatFlyObject.set_m_sourceActor);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache35, true);
		string name15 = "m_sourceSkillState";
		if (Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatFlyObject.get_m_sourceSkillState);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache36;
		if (Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatFlyObject.set_m_sourceSkillState);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache37, true);
		string name16 = "m_configDataFlyObjectInfo";
		if (Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatFlyObject.get_m_configDataFlyObjectInfo);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache38;
		if (Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatFlyObject.set_m_configDataFlyObjectInfo);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache39, true);
		string name17 = "m_fx";
		if (Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatFlyObject.get_m_fx);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache3A;
		if (Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatFlyObject.set_m_fx);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache3B, true);
		string name18 = "m_fxLife";
		if (Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatFlyObject.get_m_fxLife);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache3C;
		if (Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatFlyObject.set_m_fxLife);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache3D, true);
		string name19 = "m_isGraphicSkillFade";
		if (Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatFlyObject.get_m_isGraphicSkillFade);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache3E;
		if (Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatFlyObject.set_m_isGraphicSkillFade);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache3F, true);
		string name20 = "Combat";
		if (Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatFlyObject.get_Combat);
		}
		LuaObject.addMember(l, name20, Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache40, null, true);
		if (Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatFlyObject.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Battle_CombatFlyObject.<>f__mg$cache41, typeof(CombatFlyObject), typeof(Entity));
	}

	// Token: 0x0400DC80 RID: 56448
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400DC81 RID: 56449
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400DC82 RID: 56450
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400DC83 RID: 56451
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400DC84 RID: 56452
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400DC85 RID: 56453
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400DC86 RID: 56454
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400DC87 RID: 56455
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400DC88 RID: 56456
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400DC89 RID: 56457
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400DC8A RID: 56458
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400DC8B RID: 56459
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400DC8C RID: 56460
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400DC8D RID: 56461
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400DC8E RID: 56462
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400DC8F RID: 56463
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400DC90 RID: 56464
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400DC91 RID: 56465
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400DC92 RID: 56466
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400DC93 RID: 56467
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400DC94 RID: 56468
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400DC95 RID: 56469
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400DC96 RID: 56470
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400DC97 RID: 56471
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400DC98 RID: 56472
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400DC99 RID: 56473
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400DC9A RID: 56474
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400DC9B RID: 56475
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400DC9C RID: 56476
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400DC9D RID: 56477
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400DC9E RID: 56478
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400DC9F RID: 56479
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400DCA0 RID: 56480
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400DCA1 RID: 56481
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400DCA2 RID: 56482
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400DCA3 RID: 56483
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400DCA4 RID: 56484
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0400DCA5 RID: 56485
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0400DCA6 RID: 56486
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0400DCA7 RID: 56487
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0400DCA8 RID: 56488
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0400DCA9 RID: 56489
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0400DCAA RID: 56490
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0400DCAB RID: 56491
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0400DCAC RID: 56492
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0400DCAD RID: 56493
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0400DCAE RID: 56494
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x0400DCAF RID: 56495
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x0400DCB0 RID: 56496
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x0400DCB1 RID: 56497
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x0400DCB2 RID: 56498
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x0400DCB3 RID: 56499
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x0400DCB4 RID: 56500
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x0400DCB5 RID: 56501
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x0400DCB6 RID: 56502
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x0400DCB7 RID: 56503
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x0400DCB8 RID: 56504
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x0400DCB9 RID: 56505
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x0400DCBA RID: 56506
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x0400DCBB RID: 56507
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x0400DCBC RID: 56508
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x0400DCBD RID: 56509
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x0400DCBE RID: 56510
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x0400DCBF RID: 56511
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x0400DCC0 RID: 56512
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x0400DCC1 RID: 56513
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;
}
