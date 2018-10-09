using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Battle;
using BlackJack.ProjectL.Common;
using FixMath.NET;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020011A6 RID: 4518
[Preserve]
public class Lua_BlackJack_ProjectL_Battle_CombatActor : LuaObject
{
	// Token: 0x06017531 RID: 95537 RVA: 0x00657238 File Offset: 0x00655438
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			CombatActor o = new CombatActor();
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

	// Token: 0x06017532 RID: 95538 RVA: 0x00657280 File Offset: 0x00655480
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Dispose(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			combatActor.Dispose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017533 RID: 95539 RVA: 0x006572CC File Offset: 0x006554CC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Initialize(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			CombatTeam team;
			LuaObject.checkType<CombatTeam>(l, 2, out team);
			bool isHero;
			LuaObject.checkType(l, 3, out isHero);
			combatActor.Initialize(team, isHero);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017534 RID: 95540 RVA: 0x00657330 File Offset: 0x00655530
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Tick(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			combatActor.Tick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017535 RID: 95541 RVA: 0x0065737C File Offset: 0x0065557C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int TickGraphic(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			float dt;
			LuaObject.checkType(l, 2, out dt);
			combatActor.TickGraphic(dt);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017536 RID: 95542 RVA: 0x006573D4 File Offset: 0x006555D4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Draw(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			combatActor.Draw();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017537 RID: 95543 RVA: 0x00657420 File Offset: 0x00655620
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DoPause(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			bool pause;
			LuaObject.checkType(l, 2, out pause);
			combatActor.DoPause(pause);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017538 RID: 95544 RVA: 0x00657478 File Offset: 0x00655678
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int EnterCombat(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			combatActor.EnterCombat();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017539 RID: 95545 RVA: 0x006574C4 File Offset: 0x006556C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartCombat(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			combatActor.StartCombat();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601753A RID: 95546 RVA: 0x00657510 File Offset: 0x00655710
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int StopCombat(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			combatActor.StopCombat();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601753B RID: 95547 RVA: 0x0065755C File Offset: 0x0065575C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanStopCombat(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			bool b = combatActor.CanStopCombat();
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

	// Token: 0x0601753C RID: 95548 RVA: 0x006575B0 File Offset: 0x006557B0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int LogCanNotStopCombat(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			combatActor.LogCanNotStopCombat();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601753D RID: 95549 RVA: 0x006575FC File Offset: 0x006557FC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetCanStopFrame(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			int canStopFrame;
			LuaObject.checkType(l, 2, out canStopFrame);
			combatActor.SetCanStopFrame(canStopFrame);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601753E RID: 95550 RVA: 0x00657654 File Offset: 0x00655854
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetPosition(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
				Vector2i position;
				LuaObject.checkValueType<Vector2i>(l, 2, out position);
				combatActor.SetPosition(position);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 3)
			{
				CombatActor combatActor2 = (CombatActor)LuaObject.checkSelf(l);
				int x;
				LuaObject.checkType(l, 2, out x);
				int y;
				LuaObject.checkType(l, 3, out y);
				combatActor2.SetPosition(x, y);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function SetPosition to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601753F RID: 95551 RVA: 0x00657718 File Offset: 0x00655918
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetDirection(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			int direction;
			LuaObject.checkType(l, 2, out direction);
			combatActor.SetDirection(direction);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017540 RID: 95552 RVA: 0x00657770 File Offset: 0x00655970
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetFormationLine(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			int formationLine;
			LuaObject.checkType(l, 2, out formationLine);
			combatActor.SetFormationLine(formationLine);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017541 RID: 95553 RVA: 0x006577C8 File Offset: 0x006559C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FaceTo(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			Vector2i pos;
			LuaObject.checkValueType<Vector2i>(l, 2, out pos);
			combatActor.FaceTo(pos);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017542 RID: 95554 RVA: 0x00657820 File Offset: 0x00655A20
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetGraphicSkillFade(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			bool graphicSkillFade;
			LuaObject.checkType(l, 2, out graphicSkillFade);
			combatActor.SetGraphicSkillFade(graphicSkillFade);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017543 RID: 95555 RVA: 0x00657878 File Offset: 0x00655A78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsDead(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			bool b = combatActor.IsDead();
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

	// Token: 0x06017544 RID: 95556 RVA: 0x006578CC File Offset: 0x00655ACC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetVisible(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			bool visible;
			LuaObject.checkType(l, 2, out visible);
			combatActor.SetVisible(visible);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017545 RID: 95557 RVA: 0x00657924 File Offset: 0x00655B24
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsVisible(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			bool b = combatActor.IsVisible();
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

	// Token: 0x06017546 RID: 95558 RVA: 0x00657978 File Offset: 0x00655B78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsHero(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			bool b = combatActor.IsHero();
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

	// Token: 0x06017547 RID: 95559 RVA: 0x006579CC File Offset: 0x00655BCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetArmyInfo(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			ConfigDataArmyInfo armyInfo = combatActor.GetArmyInfo();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, armyInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017548 RID: 95560 RVA: 0x00657A20 File Offset: 0x00655C20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetGraphic(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			IBattleGraphic graphic = combatActor.GetGraphic();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, graphic);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017549 RID: 95561 RVA: 0x00657A74 File Offset: 0x00655C74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AttackBy(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			CombatActor attacker;
			LuaObject.checkType<CombatActor>(l, 2, out attacker);
			ConfigDataSkillInfo skillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 3, out skillInfo);
			bool isCritical;
			LuaObject.checkType(l, 4, out isCritical);
			combatActor.AttackBy(attacker, skillInfo, isCritical);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601754A RID: 95562 RVA: 0x00657AE8 File Offset: 0x00655CE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetHealthPoint(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			int healthPoint;
			LuaObject.checkType(l, 2, out healthPoint);
			combatActor.SetHealthPoint(healthPoint);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601754B RID: 95563 RVA: 0x00657B40 File Offset: 0x00655D40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PreAttack(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			CombatActor target;
			LuaObject.checkType<CombatActor>(l, 2, out target);
			ConfigDataSkillInfo skillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 3, out skillInfo);
			bool isCritical;
			LuaObject.checkType(l, 4, out isCritical);
			combatActor.PreAttack(target, skillInfo, isCritical);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601754C RID: 95564 RVA: 0x00657BB4 File Offset: 0x00655DB4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetPreAttackHealthPoint(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			int preAttackHealthPoint = combatActor.GetPreAttackHealthPoint();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, preAttackHealthPoint);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601754D RID: 95565 RVA: 0x00657C08 File Offset: 0x00655E08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddBeHitId(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			ushort id;
			LuaObject.checkType(l, 2, out id);
			combatActor.AddBeHitId(id);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601754E RID: 95566 RVA: 0x00657C60 File Offset: 0x00655E60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HasBeHitId(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			ushort id;
			LuaObject.checkType(l, 2, out id);
			bool b = combatActor.HasBeHitId(id);
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

	// Token: 0x0601754F RID: 95567 RVA: 0x00657CC4 File Offset: 0x00655EC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanBeTarget(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			bool b = combatActor.CanBeTarget();
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

	// Token: 0x06017550 RID: 95568 RVA: 0x00657D18 File Offset: 0x00655F18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Move(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			Vector2i dir;
			LuaObject.checkValueType<Vector2i>(l, 2, out dir);
			Fix64 distance;
			LuaObject.checkValueType<Fix64>(l, 3, out distance);
			bool changeDirection;
			LuaObject.checkType(l, 4, out changeDirection);
			combatActor.m_luaExportHelper.Move(dir, distance, changeDirection);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017551 RID: 95569 RVA: 0x00657D90 File Offset: 0x00655F90
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int MoveX(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			int dir;
			LuaObject.checkType(l, 2, out dir);
			Fix64 distance;
			LuaObject.checkValueType<Fix64>(l, 3, out distance);
			bool changeDirection;
			LuaObject.checkType(l, 4, out changeDirection);
			combatActor.m_luaExportHelper.MoveX(dir, distance, changeDirection);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017552 RID: 95570 RVA: 0x00657E08 File Offset: 0x00656008
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateGraphic(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			float scale;
			LuaObject.checkType(l, 3, out scale);
			float height;
			LuaObject.checkType(l, 4, out height);
			float footHeight;
			LuaObject.checkType(l, 5, out footHeight);
			string name;
			LuaObject.checkType(l, 6, out name);
			List<ReplaceAnim> replaceAnims;
			LuaObject.checkType<List<ReplaceAnim>>(l, 7, out replaceAnims);
			combatActor.m_luaExportHelper.CreateGraphic(assetName, scale, height, footHeight, name, replaceAnims);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017553 RID: 95571 RVA: 0x00657EA4 File Offset: 0x006560A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayAnimation(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			bool loop;
			LuaObject.checkType(l, 3, out loop);
			combatActor.m_luaExportHelper.PlayAnimation(name, loop);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017554 RID: 95572 RVA: 0x00657F10 File Offset: 0x00656110
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PlayDeathAnimation(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			int deathType;
			LuaObject.checkType(l, 2, out deathType);
			combatActor.m_luaExportHelper.PlayDeathAnimation(deathType);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017555 RID: 95573 RVA: 0x00657F6C File Offset: 0x0065616C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayFx(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			int tag;
			LuaObject.checkType(l, 3, out tag);
			combatActor.m_luaExportHelper.PlayFx(name, tag);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017556 RID: 95574 RVA: 0x00657FD8 File Offset: 0x006561D8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PlaySkillFx(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			string nameFar;
			LuaObject.checkType(l, 3, out nameFar);
			combatActor.m_luaExportHelper.PlaySkillFx(name, nameFar);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017557 RID: 95575 RVA: 0x00658044 File Offset: 0x00656244
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlaySound(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			combatActor.m_luaExportHelper.PlaySound(name);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017558 RID: 95576 RVA: 0x006580A0 File Offset: 0x006562A0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetGraphicEffect(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			GraphicEffect e;
			LuaObject.checkEnum<GraphicEffect>(l, 2, out e);
			float param;
			LuaObject.checkType(l, 3, out param);
			float param2;
			LuaObject.checkType(l, 4, out param2);
			combatActor.m_luaExportHelper.SetGraphicEffect(e, param, param2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e2)
		{
			result = LuaObject.error(l, e2);
		}
		return result;
	}

	// Token: 0x06017559 RID: 95577 RVA: 0x00658118 File Offset: 0x00656318
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ClearGraphicEffect(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			GraphicEffect e;
			LuaObject.checkEnum<GraphicEffect>(l, 2, out e);
			combatActor.m_luaExportHelper.ClearGraphicEffect(e);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e2)
		{
			result = LuaObject.error(l, e2);
		}
		return result;
	}

	// Token: 0x0601755A RID: 95578 RVA: 0x00658174 File Offset: 0x00656374
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ClearAttachFxs(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			int tagMask;
			LuaObject.checkType(l, 2, out tagMask);
			combatActor.m_luaExportHelper.ClearAttachFxs(tagMask);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601755B RID: 95579 RVA: 0x006581D0 File Offset: 0x006563D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetBattleProperty(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			BattleProperty battleProperty = combatActor.m_luaExportHelper.GetBattleProperty();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleProperty);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601755C RID: 95580 RVA: 0x0065822C File Offset: 0x0065642C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetMoveSpeed(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			int moveSpeed = combatActor.m_luaExportHelper.GetMoveSpeed();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, moveSpeed);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601755D RID: 95581 RVA: 0x00658288 File Offset: 0x00656488
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetAttackDistance(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			int attackDistance = combatActor.m_luaExportHelper.GetAttackDistance();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, attackDistance);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601755E RID: 95582 RVA: 0x006582E4 File Offset: 0x006564E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetMoveType(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			MoveType moveType = combatActor.m_luaExportHelper.GetMoveType();
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)moveType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601755F RID: 95583 RVA: 0x00658340 File Offset: 0x00656540
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int TickSkillStates(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			combatActor.m_luaExportHelper.TickSkillStates();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017560 RID: 95584 RVA: 0x00658394 File Offset: 0x00656594
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int TickSkillHits(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			CombatSkillState ss;
			LuaObject.checkType<CombatSkillState>(l, 2, out ss);
			combatActor.m_luaExportHelper.TickSkillHits(ss);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017561 RID: 95585 RVA: 0x006583F0 File Offset: 0x006565F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Attack(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			CombatActor target;
			LuaObject.checkType<CombatActor>(l, 2, out target);
			ConfigDataSkillInfo skillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 3, out skillInfo);
			bool isCritical;
			LuaObject.checkType(l, 4, out isCritical);
			bool b = combatActor.m_luaExportHelper.Attack(target, skillInfo, isCritical);
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

	// Token: 0x06017562 RID: 95586 RVA: 0x00658474 File Offset: 0x00656674
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Shoot(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			CombatSkillState ss;
			LuaObject.checkType<CombatSkillState>(l, 2, out ss);
			CombatActor target;
			LuaObject.checkType<CombatActor>(l, 3, out target);
			bool b = combatActor.m_luaExportHelper.Shoot(ss, target);
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

	// Token: 0x06017563 RID: 95587 RVA: 0x006584E8 File Offset: 0x006566E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateSkillState(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			ConfigDataSkillInfo skillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 2, out skillInfo);
			CombatSkillState o = combatActor.m_luaExportHelper.CreateSkillState(skillInfo);
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

	// Token: 0x06017564 RID: 95588 RVA: 0x00658550 File Offset: 0x00656750
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddSkillDelayHit(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			CombatSkillState ss;
			LuaObject.checkType<CombatSkillState>(l, 2, out ss);
			CombatActor target;
			LuaObject.checkType<CombatActor>(l, 3, out target);
			int delay;
			LuaObject.checkType(l, 4, out delay);
			combatActor.m_luaExportHelper.AddSkillDelayHit(ss, target, delay);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017565 RID: 95589 RVA: 0x006585C8 File Offset: 0x006567C8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AddMagicDamageSkillDelayHits(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			CombatSkillState ss;
			LuaObject.checkType<CombatSkillState>(l, 2, out ss);
			combatActor.m_luaExportHelper.AddMagicDamageSkillDelayHits(ss);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017566 RID: 95590 RVA: 0x00658624 File Offset: 0x00656824
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddChargeSkillDelayHits(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			CombatSkillState ss;
			LuaObject.checkType<CombatSkillState>(l, 2, out ss);
			combatActor.m_luaExportHelper.AddChargeSkillDelayHits(ss);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017567 RID: 95591 RVA: 0x00658680 File Offset: 0x00656880
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ChangeFightTarget(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			CombatActor target;
			LuaObject.checkType<CombatActor>(l, 2, out target);
			combatActor.m_luaExportHelper.ChangeFightTarget(target);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017568 RID: 95592 RVA: 0x006586DC File Offset: 0x006568DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SearchTarget(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			CombatActor o = combatActor.m_luaExportHelper.SearchTarget();
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

	// Token: 0x06017569 RID: 95593 RVA: 0x00658738 File Offset: 0x00656938
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SearchRangeTarget(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			Vector2i pos;
			LuaObject.checkValueType<Vector2i>(l, 2, out pos);
			int maxDistance;
			LuaObject.checkType(l, 3, out maxDistance);
			CombatActor o = combatActor.m_luaExportHelper.SearchRangeTarget(pos, maxDistance);
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

	// Token: 0x0601756A RID: 95594 RVA: 0x006587AC File Offset: 0x006569AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SearchHitTarget(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			int attackDistance;
			LuaObject.checkType(l, 2, out attackDistance);
			ushort hitId;
			LuaObject.checkType(l, 3, out hitId);
			CombatActor o = combatActor.m_luaExportHelper.SearchHitTarget(attackDistance, hitId);
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

	// Token: 0x0601756B RID: 95595 RVA: 0x00658820 File Offset: 0x00656A20
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SearchRandomHitTarget(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			ushort hitId;
			LuaObject.checkType(l, 2, out hitId);
			int targetType;
			LuaObject.checkType(l, 3, out targetType);
			CombatActor o = combatActor.m_luaExportHelper.SearchRandomHitTarget(hitId, targetType);
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

	// Token: 0x0601756C RID: 95596 RVA: 0x00658894 File Offset: 0x00656A94
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsTargetInAttackDistance(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			CombatActor target;
			LuaObject.checkType<CombatActor>(l, 2, out target);
			int attackDistance;
			LuaObject.checkType(l, 3, out attackDistance);
			bool b = combatActor.m_luaExportHelper.IsTargetInAttackDistance(target, attackDistance);
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

	// Token: 0x0601756D RID: 95597 RVA: 0x00658908 File Offset: 0x00656B08
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int TickState(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			combatActor.m_luaExportHelper.TickState();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601756E RID: 95598 RVA: 0x0065895C File Offset: 0x00656B5C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ChangeState(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			CombatActorState state;
			LuaObject.checkEnum<CombatActorState>(l, 2, out state);
			combatActor.m_luaExportHelper.ChangeState(state);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601756F RID: 95599 RVA: 0x006589B8 File Offset: 0x00656BB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StateEnter(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			combatActor.m_luaExportHelper.StateEnter();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017570 RID: 95600 RVA: 0x00658A0C File Offset: 0x00656C0C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int StateExit(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			combatActor.m_luaExportHelper.StateExit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017571 RID: 95601 RVA: 0x00658A60 File Offset: 0x00656C60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StateIdle(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			combatActor.m_luaExportHelper.StateIdle();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017572 RID: 95602 RVA: 0x00658AB4 File Offset: 0x00656CB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StateFight(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			combatActor.m_luaExportHelper.StateFight();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017573 RID: 95603 RVA: 0x00658B08 File Offset: 0x00656D08
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int StateFightEnd(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			combatActor.m_luaExportHelper.StateFightEnd();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017574 RID: 95604 RVA: 0x00658B5C File Offset: 0x00656D5C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int StateFightAgain(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			combatActor.m_luaExportHelper.StateFightAgain();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017575 RID: 95605 RVA: 0x00658BB0 File Offset: 0x00656DB0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int StateSkill(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			combatActor.m_luaExportHelper.StateSkill();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017576 RID: 95606 RVA: 0x00658C04 File Offset: 0x00656E04
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int StateDie(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			combatActor.m_luaExportHelper.StateDie();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017577 RID: 95607 RVA: 0x00658C58 File Offset: 0x00656E58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StateReturn(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			combatActor.m_luaExportHelper.StateReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017578 RID: 95608 RVA: 0x00658CAC File Offset: 0x00656EAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StateStop(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			combatActor.m_luaExportHelper.StateStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017579 RID: 95609 RVA: 0x00658D00 File Offset: 0x00656F00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Dispose(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			combatActor.m_luaExportHelper.__callBase_Dispose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601757A RID: 95610 RVA: 0x00658D54 File Offset: 0x00656F54
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_Tick(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			combatActor.m_luaExportHelper.__callBase_Tick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601757B RID: 95611 RVA: 0x00658DA8 File Offset: 0x00656FA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_TickGraphic(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			float dt;
			LuaObject.checkType(l, 2, out dt);
			combatActor.m_luaExportHelper.__callBase_TickGraphic(dt);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601757C RID: 95612 RVA: 0x00658E04 File Offset: 0x00657004
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Draw(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			combatActor.m_luaExportHelper.__callBase_Draw();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601757D RID: 95613 RVA: 0x00658E58 File Offset: 0x00657058
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Pause(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			bool pause;
			LuaObject.checkType(l, 2, out pause);
			combatActor.m_luaExportHelper.__callBase_Pause(pause);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601757E RID: 95614 RVA: 0x00658EB4 File Offset: 0x006570B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_DoPause(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			bool pause;
			LuaObject.checkType(l, 2, out pause);
			combatActor.m_luaExportHelper.__callBase_DoPause(pause);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601757F RID: 95615 RVA: 0x00658F10 File Offset: 0x00657110
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_DeleteMe(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			combatActor.m_luaExportHelper.__callBase_DeleteMe();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017580 RID: 95616 RVA: 0x00658F64 File Offset: 0x00657164
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ComputeTargetScore_s(IntPtr l)
	{
		int result;
		try
		{
			Vector2i pos;
			LuaObject.checkValueType<Vector2i>(l, 1, out pos);
			CombatActor target;
			LuaObject.checkType<CombatActor>(l, 2, out target);
			int i = CombatActor.LuaExportHelper.ComputeTargetScore(pos, target);
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

	// Token: 0x06017581 RID: 95617 RVA: 0x00658FC4 File Offset: 0x006571C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_position(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatActor.m_luaExportHelper.m_position);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017582 RID: 95618 RVA: 0x00659020 File Offset: 0x00657220
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_position(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			Vector2i position;
			LuaObject.checkValueType<Vector2i>(l, 2, out position);
			combatActor.m_luaExportHelper.m_position = position;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017583 RID: 95619 RVA: 0x0065907C File Offset: 0x0065727C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_initPosition(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatActor.m_luaExportHelper.m_initPosition);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017584 RID: 95620 RVA: 0x006590D8 File Offset: 0x006572D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_initPosition(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			Vector2i initPosition;
			LuaObject.checkValueType<Vector2i>(l, 2, out initPosition);
			combatActor.m_luaExportHelper.m_initPosition = initPosition;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017585 RID: 95621 RVA: 0x00659134 File Offset: 0x00657334
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_direction(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatActor.m_luaExportHelper.m_direction);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017586 RID: 95622 RVA: 0x0065918C File Offset: 0x0065738C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_direction(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			int direction;
			LuaObject.checkType(l, 2, out direction);
			combatActor.m_luaExportHelper.m_direction = direction;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017587 RID: 95623 RVA: 0x006591E8 File Offset: 0x006573E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_initDirection(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatActor.m_luaExportHelper.m_initDirection);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017588 RID: 95624 RVA: 0x00659240 File Offset: 0x00657440
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_initDirection(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			int initDirection;
			LuaObject.checkType(l, 2, out initDirection);
			combatActor.m_luaExportHelper.m_initDirection = initDirection;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017589 RID: 95625 RVA: 0x0065929C File Offset: 0x0065749C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_formationLine(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatActor.m_luaExportHelper.m_formationLine);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601758A RID: 95626 RVA: 0x006592F4 File Offset: 0x006574F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_formationLine(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			int formationLine;
			LuaObject.checkType(l, 2, out formationLine);
			combatActor.m_luaExportHelper.m_formationLine = formationLine;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601758B RID: 95627 RVA: 0x00659350 File Offset: 0x00657550
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_team(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatActor.m_luaExportHelper.m_team);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601758C RID: 95628 RVA: 0x006593A8 File Offset: 0x006575A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_team(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			CombatTeam team;
			LuaObject.checkType<CombatTeam>(l, 2, out team);
			combatActor.m_luaExportHelper.m_team = team;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601758D RID: 95629 RVA: 0x00659404 File Offset: 0x00657604
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_isHero(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatActor.m_luaExportHelper.m_isHero);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601758E RID: 95630 RVA: 0x0065945C File Offset: 0x0065765C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_isHero(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			bool isHero;
			LuaObject.checkType(l, 2, out isHero);
			combatActor.m_luaExportHelper.m_isHero = isHero;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601758F RID: 95631 RVA: 0x006594B8 File Offset: 0x006576B8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_state(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)combatActor.m_luaExportHelper.m_state);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017590 RID: 95632 RVA: 0x00659510 File Offset: 0x00657710
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_state(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			CombatActorState state;
			LuaObject.checkEnum<CombatActorState>(l, 2, out state);
			combatActor.m_luaExportHelper.m_state = state;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017591 RID: 95633 RVA: 0x0065956C File Offset: 0x0065776C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_stateFrame(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatActor.m_luaExportHelper.m_stateFrame);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017592 RID: 95634 RVA: 0x006595C4 File Offset: 0x006577C4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_stateFrame(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			int stateFrame;
			LuaObject.checkType(l, 2, out stateFrame);
			combatActor.m_luaExportHelper.m_stateFrame = stateFrame;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017593 RID: 95635 RVA: 0x00659620 File Offset: 0x00657820
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_isStateChanged(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatActor.m_luaExportHelper.m_isStateChanged);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017594 RID: 95636 RVA: 0x00659678 File Offset: 0x00657878
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isStateChanged(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			bool isStateChanged;
			LuaObject.checkType(l, 2, out isStateChanged);
			combatActor.m_luaExportHelper.m_isStateChanged = isStateChanged;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017595 RID: 95637 RVA: 0x006596D4 File Offset: 0x006578D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_stateWaitFrame(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatActor.m_luaExportHelper.m_stateWaitFrame);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017596 RID: 95638 RVA: 0x0065972C File Offset: 0x0065792C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_stateWaitFrame(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			int stateWaitFrame;
			LuaObject.checkType(l, 2, out stateWaitFrame);
			combatActor.m_luaExportHelper.m_stateWaitFrame = stateWaitFrame;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017597 RID: 95639 RVA: 0x00659788 File Offset: 0x00657988
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_stateMoveDistance(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatActor.m_luaExportHelper.m_stateMoveDistance);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017598 RID: 95640 RVA: 0x006597E0 File Offset: 0x006579E0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_stateMoveDistance(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			int stateMoveDistance;
			LuaObject.checkType(l, 2, out stateMoveDistance);
			combatActor.m_luaExportHelper.m_stateMoveDistance = stateMoveDistance;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017599 RID: 95641 RVA: 0x0065983C File Offset: 0x00657A3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_frameCount(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatActor.m_luaExportHelper.m_frameCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601759A RID: 95642 RVA: 0x00659894 File Offset: 0x00657A94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_frameCount(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			int frameCount;
			LuaObject.checkType(l, 2, out frameCount);
			combatActor.m_luaExportHelper.m_frameCount = frameCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601759B RID: 95643 RVA: 0x006598F0 File Offset: 0x00657AF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_canStopFrame(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatActor.m_luaExportHelper.m_canStopFrame);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601759C RID: 95644 RVA: 0x00659948 File Offset: 0x00657B48
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_canStopFrame(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			int canStopFrame;
			LuaObject.checkType(l, 2, out canStopFrame);
			combatActor.m_luaExportHelper.m_canStopFrame = canStopFrame;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601759D RID: 95645 RVA: 0x006599A4 File Offset: 0x00657BA4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_isVisible(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatActor.m_luaExportHelper.m_isVisible);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601759E RID: 95646 RVA: 0x006599FC File Offset: 0x00657BFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isVisible(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			bool isVisible;
			LuaObject.checkType(l, 2, out isVisible);
			combatActor.m_luaExportHelper.m_isVisible = isVisible;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601759F RID: 95647 RVA: 0x00659A58 File Offset: 0x00657C58
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_targetActor(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatActor.m_luaExportHelper.m_targetActor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060175A0 RID: 95648 RVA: 0x00659AB0 File Offset: 0x00657CB0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_targetActor(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			CombatActor targetActor;
			LuaObject.checkType<CombatActor>(l, 2, out targetActor);
			combatActor.m_luaExportHelper.m_targetActor = targetActor;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060175A1 RID: 95649 RVA: 0x00659B0C File Offset: 0x00657D0C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_preAttackHp(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatActor.m_luaExportHelper.m_preAttackHp);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060175A2 RID: 95650 RVA: 0x00659B64 File Offset: 0x00657D64
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_preAttackHp(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			int preAttackHp;
			LuaObject.checkType(l, 2, out preAttackHp);
			combatActor.m_luaExportHelper.m_preAttackHp = preAttackHp;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060175A3 RID: 95651 RVA: 0x00659BC0 File Offset: 0x00657DC0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_beHitIds(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatActor.m_luaExportHelper.m_beHitIds);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060175A4 RID: 95652 RVA: 0x00659C18 File Offset: 0x00657E18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_beHitIds(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			ushort[] beHitIds;
			LuaObject.checkArray<ushort>(l, 2, out beHitIds);
			combatActor.m_luaExportHelper.m_beHitIds = beHitIds;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060175A5 RID: 95653 RVA: 0x00659C74 File Offset: 0x00657E74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillInfo(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatActor.m_luaExportHelper.m_skillInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060175A6 RID: 95654 RVA: 0x00659CCC File Offset: 0x00657ECC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillInfo(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			ConfigDataSkillInfo skillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 2, out skillInfo);
			combatActor.m_luaExportHelper.m_skillInfo = skillInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060175A7 RID: 95655 RVA: 0x00659D28 File Offset: 0x00657F28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_curSkillState(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatActor.m_luaExportHelper.m_curSkillState);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060175A8 RID: 95656 RVA: 0x00659D80 File Offset: 0x00657F80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_curSkillState(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			CombatSkillState curSkillState;
			LuaObject.checkType<CombatSkillState>(l, 2, out curSkillState);
			combatActor.m_luaExportHelper.m_curSkillState = curSkillState;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060175A9 RID: 95657 RVA: 0x00659DDC File Offset: 0x00657FDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillStates(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatActor.m_luaExportHelper.m_skillStates);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060175AA RID: 95658 RVA: 0x00659E34 File Offset: 0x00658034
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillStates(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			List<CombatSkillState> skillStates;
			LuaObject.checkType<List<CombatSkillState>>(l, 2, out skillStates);
			combatActor.m_luaExportHelper.m_skillStates = skillStates;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060175AB RID: 95659 RVA: 0x00659E90 File Offset: 0x00658090
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillUseCount(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatActor.m_luaExportHelper.m_skillUseCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060175AC RID: 95660 RVA: 0x00659EE8 File Offset: 0x006580E8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_skillUseCount(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			int skillUseCount;
			LuaObject.checkType(l, 2, out skillUseCount);
			combatActor.m_luaExportHelper.m_skillUseCount = skillUseCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060175AD RID: 95661 RVA: 0x00659F44 File Offset: 0x00658144
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isDoubleAttacked(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatActor.m_luaExportHelper.m_isDoubleAttacked);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060175AE RID: 95662 RVA: 0x00659F9C File Offset: 0x0065819C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_isDoubleAttacked(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			bool isDoubleAttacked;
			LuaObject.checkType(l, 2, out isDoubleAttacked);
			combatActor.m_luaExportHelper.m_isDoubleAttacked = isDoubleAttacked;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060175AF RID: 95663 RVA: 0x00659FF8 File Offset: 0x006581F8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_healthPoint(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatActor.m_luaExportHelper.m_healthPoint);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060175B0 RID: 95664 RVA: 0x0065A050 File Offset: 0x00658250
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_healthPoint(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			int healthPoint;
			LuaObject.checkType(l, 2, out healthPoint);
			combatActor.m_luaExportHelper.m_healthPoint = healthPoint;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060175B1 RID: 95665 RVA: 0x0065A0AC File Offset: 0x006582AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_healthPointMax(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatActor.m_luaExportHelper.m_healthPointMax);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060175B2 RID: 95666 RVA: 0x0065A104 File Offset: 0x00658304
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_healthPointMax(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			int healthPointMax;
			LuaObject.checkType(l, 2, out healthPointMax);
			combatActor.m_luaExportHelper.m_healthPointMax = healthPointMax;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060175B3 RID: 95667 RVA: 0x0065A160 File Offset: 0x00658360
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_radius(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatActor.m_luaExportHelper.m_radius);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060175B4 RID: 95668 RVA: 0x0065A1B8 File Offset: 0x006583B8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_radius(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			int radius;
			LuaObject.checkType(l, 2, out radius);
			combatActor.m_luaExportHelper.m_radius = radius;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060175B5 RID: 95669 RVA: 0x0065A214 File Offset: 0x00658414
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_height(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatActor.m_luaExportHelper.m_height);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060175B6 RID: 95670 RVA: 0x0065A26C File Offset: 0x0065846C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_height(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			int height;
			LuaObject.checkType(l, 2, out height);
			combatActor.m_luaExportHelper.m_height = height;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060175B7 RID: 95671 RVA: 0x0065A2C8 File Offset: 0x006584C8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_footHeight(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatActor.m_luaExportHelper.m_footHeight);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060175B8 RID: 95672 RVA: 0x0065A320 File Offset: 0x00658520
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_footHeight(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			int footHeight;
			LuaObject.checkType(l, 2, out footHeight);
			combatActor.m_luaExportHelper.m_footHeight = footHeight;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060175B9 RID: 95673 RVA: 0x0065A37C File Offset: 0x0065857C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_graphic(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatActor.m_luaExportHelper.m_graphic);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060175BA RID: 95674 RVA: 0x0065A3D4 File Offset: 0x006585D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_graphic(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			IBattleGraphic graphic;
			LuaObject.checkType<IBattleGraphic>(l, 2, out graphic);
			combatActor.m_luaExportHelper.m_graphic = graphic;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060175BB RID: 95675 RVA: 0x0065A430 File Offset: 0x00658630
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_graphicPrevPosition(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatActor.m_luaExportHelper.m_graphicPrevPosition);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060175BC RID: 95676 RVA: 0x0065A48C File Offset: 0x0065868C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_graphicPrevPosition(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			Vector2i graphicPrevPosition;
			LuaObject.checkValueType<Vector2i>(l, 2, out graphicPrevPosition);
			combatActor.m_luaExportHelper.m_graphicPrevPosition = graphicPrevPosition;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060175BD RID: 95677 RVA: 0x0065A4E8 File Offset: 0x006586E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_graphicMoveDistance(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatActor.m_luaExportHelper.m_graphicMoveDistance);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060175BE RID: 95678 RVA: 0x0065A544 File Offset: 0x00658744
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_graphicMoveDistance(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			Fix64 graphicMoveDistance;
			LuaObject.checkValueType<Fix64>(l, 2, out graphicMoveDistance);
			combatActor.m_luaExportHelper.m_graphicMoveDistance = graphicMoveDistance;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060175BF RID: 95679 RVA: 0x0065A5A0 File Offset: 0x006587A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isGraphicSkillFade(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatActor.m_luaExportHelper.m_isGraphicSkillFade);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060175C0 RID: 95680 RVA: 0x0065A5F8 File Offset: 0x006587F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isGraphicSkillFade(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			bool isGraphicSkillFade;
			LuaObject.checkType(l, 2, out isGraphicSkillFade);
			combatActor.m_luaExportHelper.m_isGraphicSkillFade = isGraphicSkillFade;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060175C1 RID: 95681 RVA: 0x0065A654 File Offset: 0x00658854
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_deathAnimType(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatActor.m_luaExportHelper.m_deathAnimType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060175C2 RID: 95682 RVA: 0x0065A6AC File Offset: 0x006588AC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_deathAnimType(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			int deathAnimType;
			LuaObject.checkType(l, 2, out deathAnimType);
			combatActor.m_luaExportHelper.m_deathAnimType = deathAnimType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060175C3 RID: 95683 RVA: 0x0065A708 File Offset: 0x00658908
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Position(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatActor.Position);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060175C4 RID: 95684 RVA: 0x0065A760 File Offset: 0x00658960
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Direction(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatActor.Direction);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060175C5 RID: 95685 RVA: 0x0065A7B4 File Offset: 0x006589B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_FormationLine(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatActor.FormationLine);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060175C6 RID: 95686 RVA: 0x0065A808 File Offset: 0x00658A08
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Radius(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatActor.Radius);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060175C7 RID: 95687 RVA: 0x0065A85C File Offset: 0x00658A5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Height(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatActor.Height);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060175C8 RID: 95688 RVA: 0x0065A8B0 File Offset: 0x00658AB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_FootHeight(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatActor.FootHeight);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060175C9 RID: 95689 RVA: 0x0065A904 File Offset: 0x00658B04
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_HealthPoint(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatActor.HealthPoint);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060175CA RID: 95690 RVA: 0x0065A958 File Offset: 0x00658B58
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_HealthPointMax(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatActor.HealthPointMax);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060175CB RID: 95691 RVA: 0x0065A9AC File Offset: 0x00658BAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_State(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)combatActor.State);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060175CC RID: 95692 RVA: 0x0065AA00 File Offset: 0x00658C00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_StateFrame(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatActor.StateFrame);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060175CD RID: 95693 RVA: 0x0065AA54 File Offset: 0x00658C54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Team(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatActor.Team);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060175CE RID: 95694 RVA: 0x0065AAA8 File Offset: 0x00658CA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_TeamNumber(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatActor.TeamNumber);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060175CF RID: 95695 RVA: 0x0065AAFC File Offset: 0x00658CFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Combat(IntPtr l)
	{
		int result;
		try
		{
			CombatActor combatActor = (CombatActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatActor.Combat);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060175D0 RID: 95696 RVA: 0x0065AB50 File Offset: 0x00658D50
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Battle.CombatActor");
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.Dispose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.Initialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.TickGraphic);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.Draw);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.DoPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.EnterCombat);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.StartCombat);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.StopCombat);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.CanStopCombat);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.LogCanNotStopCombat);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.SetCanStopFrame);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.SetPosition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.SetDirection);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.SetFormationLine);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.FaceTo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.SetGraphicSkillFade);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.IsDead);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.SetVisible);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.IsVisible);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.IsHero);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.GetArmyInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.GetGraphic);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.AttackBy);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.SetHealthPoint);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.PreAttack);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.GetPreAttackHealthPoint);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.AddBeHitId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.HasBeHitId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.CanBeTarget);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.Move);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.MoveX);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.CreateGraphic);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.PlayAnimation);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.PlayDeathAnimation);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.PlayFx);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.PlaySkillFx);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.PlaySound);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.SetGraphicEffect);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.ClearGraphicEffect);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.ClearAttachFxs);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.GetBattleProperty);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache29);
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.GetMoveSpeed);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache2A);
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.GetAttackDistance);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache2B);
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.GetMoveType);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache2C);
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.TickSkillStates);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache2D);
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.TickSkillHits);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache2E);
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.Attack);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache2F);
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.Shoot);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache30);
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.CreateSkillState);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache31);
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.AddSkillDelayHit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache32);
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.AddMagicDamageSkillDelayHits);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache33);
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.AddChargeSkillDelayHits);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache34);
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.ChangeFightTarget);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache35);
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.SearchTarget);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache36);
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.SearchRangeTarget);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache37);
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.SearchHitTarget);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache38);
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.SearchRandomHitTarget);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache39);
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.IsTargetInAttackDistance);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache3A);
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.TickState);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache3B);
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.ChangeState);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache3C);
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.StateEnter);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache3D);
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.StateExit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache3E);
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.StateIdle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache3F);
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.StateFight);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache40);
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.StateFightEnd);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache41);
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.StateFightAgain);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache42);
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.StateSkill);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache43);
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.StateDie);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache44);
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.StateReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache45);
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.StateStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache46);
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.__callBase_Dispose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache47);
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.__callBase_Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache48);
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.__callBase_TickGraphic);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache49);
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.__callBase_Draw);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache4A);
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.__callBase_Pause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache4B);
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.__callBase_DoPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache4C);
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.__callBase_DeleteMe);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache4D);
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.ComputeTargetScore_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache4E);
		string name = "m_position";
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.get_m_position);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache4F;
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.set_m_position);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache50, true);
		string name2 = "m_initPosition";
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.get_m_initPosition);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache51;
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.set_m_initPosition);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache52, true);
		string name3 = "m_direction";
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.get_m_direction);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache53;
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.set_m_direction);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache54, true);
		string name4 = "m_initDirection";
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache55 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache55 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.get_m_initDirection);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache55;
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache56 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache56 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.set_m_initDirection);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache56, true);
		string name5 = "m_formationLine";
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache57 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache57 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.get_m_formationLine);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache57;
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache58 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache58 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.set_m_formationLine);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache58, true);
		string name6 = "m_team";
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache59 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache59 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.get_m_team);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache59;
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache5A == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache5A = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.set_m_team);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache5A, true);
		string name7 = "m_isHero";
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache5B == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache5B = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.get_m_isHero);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache5B;
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache5C == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache5C = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.set_m_isHero);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache5C, true);
		string name8 = "m_state";
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache5D == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache5D = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.get_m_state);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache5D;
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache5E == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache5E = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.set_m_state);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache5E, true);
		string name9 = "m_stateFrame";
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache5F == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache5F = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.get_m_stateFrame);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache5F;
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache60 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache60 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.set_m_stateFrame);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache60, true);
		string name10 = "m_isStateChanged";
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache61 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache61 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.get_m_isStateChanged);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache61;
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache62 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache62 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.set_m_isStateChanged);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache62, true);
		string name11 = "m_stateWaitFrame";
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache63 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache63 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.get_m_stateWaitFrame);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache63;
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache64 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache64 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.set_m_stateWaitFrame);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache64, true);
		string name12 = "m_stateMoveDistance";
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache65 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache65 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.get_m_stateMoveDistance);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache65;
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache66 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache66 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.set_m_stateMoveDistance);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache66, true);
		string name13 = "m_frameCount";
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache67 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache67 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.get_m_frameCount);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache67;
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache68 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache68 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.set_m_frameCount);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache68, true);
		string name14 = "m_canStopFrame";
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache69 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache69 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.get_m_canStopFrame);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache69;
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache6A == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache6A = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.set_m_canStopFrame);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache6A, true);
		string name15 = "m_isVisible";
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache6B == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache6B = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.get_m_isVisible);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache6B;
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache6C == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache6C = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.set_m_isVisible);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache6C, true);
		string name16 = "m_targetActor";
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache6D == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache6D = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.get_m_targetActor);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache6D;
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache6E == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache6E = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.set_m_targetActor);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache6E, true);
		string name17 = "m_preAttackHp";
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache6F == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache6F = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.get_m_preAttackHp);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache6F;
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache70 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache70 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.set_m_preAttackHp);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache70, true);
		string name18 = "m_beHitIds";
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache71 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache71 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.get_m_beHitIds);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache71;
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache72 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache72 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.set_m_beHitIds);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache72, true);
		string name19 = "m_skillInfo";
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache73 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache73 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.get_m_skillInfo);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache73;
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache74 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache74 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.set_m_skillInfo);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache74, true);
		string name20 = "m_curSkillState";
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache75 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache75 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.get_m_curSkillState);
		}
		LuaCSFunction get20 = Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache75;
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache76 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache76 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.set_m_curSkillState);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache76, true);
		string name21 = "m_skillStates";
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache77 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache77 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.get_m_skillStates);
		}
		LuaCSFunction get21 = Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache77;
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache78 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache78 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.set_m_skillStates);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache78, true);
		string name22 = "m_skillUseCount";
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache79 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache79 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.get_m_skillUseCount);
		}
		LuaCSFunction get22 = Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache79;
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache7A == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache7A = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.set_m_skillUseCount);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache7A, true);
		string name23 = "m_isDoubleAttacked";
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache7B == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache7B = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.get_m_isDoubleAttacked);
		}
		LuaCSFunction get23 = Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache7B;
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache7C == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache7C = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.set_m_isDoubleAttacked);
		}
		LuaObject.addMember(l, name23, get23, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache7C, true);
		string name24 = "m_healthPoint";
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache7D == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache7D = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.get_m_healthPoint);
		}
		LuaCSFunction get24 = Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache7D;
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache7E == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache7E = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.set_m_healthPoint);
		}
		LuaObject.addMember(l, name24, get24, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache7E, true);
		string name25 = "m_healthPointMax";
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache7F == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache7F = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.get_m_healthPointMax);
		}
		LuaCSFunction get25 = Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache7F;
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache80 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache80 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.set_m_healthPointMax);
		}
		LuaObject.addMember(l, name25, get25, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache80, true);
		string name26 = "m_radius";
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache81 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache81 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.get_m_radius);
		}
		LuaCSFunction get26 = Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache81;
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache82 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache82 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.set_m_radius);
		}
		LuaObject.addMember(l, name26, get26, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache82, true);
		string name27 = "m_height";
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache83 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache83 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.get_m_height);
		}
		LuaCSFunction get27 = Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache83;
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache84 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache84 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.set_m_height);
		}
		LuaObject.addMember(l, name27, get27, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache84, true);
		string name28 = "m_footHeight";
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache85 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache85 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.get_m_footHeight);
		}
		LuaCSFunction get28 = Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache85;
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache86 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache86 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.set_m_footHeight);
		}
		LuaObject.addMember(l, name28, get28, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache86, true);
		string name29 = "m_graphic";
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache87 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache87 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.get_m_graphic);
		}
		LuaCSFunction get29 = Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache87;
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache88 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache88 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.set_m_graphic);
		}
		LuaObject.addMember(l, name29, get29, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache88, true);
		string name30 = "m_graphicPrevPosition";
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache89 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache89 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.get_m_graphicPrevPosition);
		}
		LuaCSFunction get30 = Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache89;
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache8A == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache8A = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.set_m_graphicPrevPosition);
		}
		LuaObject.addMember(l, name30, get30, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache8A, true);
		string name31 = "m_graphicMoveDistance";
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache8B == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache8B = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.get_m_graphicMoveDistance);
		}
		LuaCSFunction get31 = Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache8B;
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache8C == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache8C = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.set_m_graphicMoveDistance);
		}
		LuaObject.addMember(l, name31, get31, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache8C, true);
		string name32 = "m_isGraphicSkillFade";
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache8D == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache8D = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.get_m_isGraphicSkillFade);
		}
		LuaCSFunction get32 = Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache8D;
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache8E == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache8E = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.set_m_isGraphicSkillFade);
		}
		LuaObject.addMember(l, name32, get32, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache8E, true);
		string name33 = "m_deathAnimType";
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache8F == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache8F = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.get_m_deathAnimType);
		}
		LuaCSFunction get33 = Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache8F;
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache90 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache90 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.set_m_deathAnimType);
		}
		LuaObject.addMember(l, name33, get33, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache90, true);
		string name34 = "Position";
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache91 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache91 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.get_Position);
		}
		LuaObject.addMember(l, name34, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache91, null, true);
		string name35 = "Direction";
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache92 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache92 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.get_Direction);
		}
		LuaObject.addMember(l, name35, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache92, null, true);
		string name36 = "FormationLine";
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache93 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache93 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.get_FormationLine);
		}
		LuaObject.addMember(l, name36, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache93, null, true);
		string name37 = "Radius";
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache94 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache94 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.get_Radius);
		}
		LuaObject.addMember(l, name37, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache94, null, true);
		string name38 = "Height";
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache95 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache95 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.get_Height);
		}
		LuaObject.addMember(l, name38, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache95, null, true);
		string name39 = "FootHeight";
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache96 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache96 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.get_FootHeight);
		}
		LuaObject.addMember(l, name39, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache96, null, true);
		string name40 = "HealthPoint";
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache97 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache97 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.get_HealthPoint);
		}
		LuaObject.addMember(l, name40, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache97, null, true);
		string name41 = "HealthPointMax";
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache98 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache98 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.get_HealthPointMax);
		}
		LuaObject.addMember(l, name41, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache98, null, true);
		string name42 = "State";
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache99 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache99 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.get_State);
		}
		LuaObject.addMember(l, name42, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache99, null, true);
		string name43 = "StateFrame";
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache9A == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache9A = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.get_StateFrame);
		}
		LuaObject.addMember(l, name43, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache9A, null, true);
		string name44 = "Team";
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache9B == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache9B = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.get_Team);
		}
		LuaObject.addMember(l, name44, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache9B, null, true);
		string name45 = "TeamNumber";
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache9C == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache9C = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.get_TeamNumber);
		}
		LuaObject.addMember(l, name45, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache9C, null, true);
		string name46 = "Combat";
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache9D == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache9D = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.get_Combat);
		}
		LuaObject.addMember(l, name46, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache9D, null, true);
		if (Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache9E == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache9E = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatActor.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Battle_CombatActor.<>f__mg$cache9E, typeof(CombatActor), typeof(Entity));
	}

	// Token: 0x0400DBC7 RID: 56263
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400DBC8 RID: 56264
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400DBC9 RID: 56265
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400DBCA RID: 56266
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400DBCB RID: 56267
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400DBCC RID: 56268
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400DBCD RID: 56269
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400DBCE RID: 56270
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400DBCF RID: 56271
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400DBD0 RID: 56272
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400DBD1 RID: 56273
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400DBD2 RID: 56274
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400DBD3 RID: 56275
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400DBD4 RID: 56276
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400DBD5 RID: 56277
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400DBD6 RID: 56278
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400DBD7 RID: 56279
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400DBD8 RID: 56280
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400DBD9 RID: 56281
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400DBDA RID: 56282
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400DBDB RID: 56283
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400DBDC RID: 56284
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400DBDD RID: 56285
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400DBDE RID: 56286
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400DBDF RID: 56287
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400DBE0 RID: 56288
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400DBE1 RID: 56289
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400DBE2 RID: 56290
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400DBE3 RID: 56291
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400DBE4 RID: 56292
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400DBE5 RID: 56293
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400DBE6 RID: 56294
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400DBE7 RID: 56295
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400DBE8 RID: 56296
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400DBE9 RID: 56297
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400DBEA RID: 56298
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400DBEB RID: 56299
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0400DBEC RID: 56300
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0400DBED RID: 56301
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0400DBEE RID: 56302
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0400DBEF RID: 56303
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0400DBF0 RID: 56304
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0400DBF1 RID: 56305
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0400DBF2 RID: 56306
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0400DBF3 RID: 56307
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0400DBF4 RID: 56308
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0400DBF5 RID: 56309
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x0400DBF6 RID: 56310
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x0400DBF7 RID: 56311
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x0400DBF8 RID: 56312
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x0400DBF9 RID: 56313
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x0400DBFA RID: 56314
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x0400DBFB RID: 56315
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x0400DBFC RID: 56316
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x0400DBFD RID: 56317
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x0400DBFE RID: 56318
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x0400DBFF RID: 56319
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x0400DC00 RID: 56320
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x0400DC01 RID: 56321
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x0400DC02 RID: 56322
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x0400DC03 RID: 56323
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x0400DC04 RID: 56324
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x0400DC05 RID: 56325
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x0400DC06 RID: 56326
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x0400DC07 RID: 56327
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x0400DC08 RID: 56328
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x0400DC09 RID: 56329
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x0400DC0A RID: 56330
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x0400DC0B RID: 56331
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x0400DC0C RID: 56332
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x0400DC0D RID: 56333
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x0400DC0E RID: 56334
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x0400DC0F RID: 56335
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x0400DC10 RID: 56336
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x0400DC11 RID: 56337
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x0400DC12 RID: 56338
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x0400DC13 RID: 56339
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x0400DC14 RID: 56340
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x0400DC15 RID: 56341
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x0400DC16 RID: 56342
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x0400DC17 RID: 56343
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x0400DC18 RID: 56344
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x0400DC19 RID: 56345
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x0400DC1A RID: 56346
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x0400DC1B RID: 56347
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x0400DC1C RID: 56348
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x0400DC1D RID: 56349
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x0400DC1E RID: 56350
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x0400DC1F RID: 56351
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x0400DC20 RID: 56352
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;

	// Token: 0x0400DC21 RID: 56353
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5A;

	// Token: 0x0400DC22 RID: 56354
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5B;

	// Token: 0x0400DC23 RID: 56355
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5C;

	// Token: 0x0400DC24 RID: 56356
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5D;

	// Token: 0x0400DC25 RID: 56357
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5E;

	// Token: 0x0400DC26 RID: 56358
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5F;

	// Token: 0x0400DC27 RID: 56359
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache60;

	// Token: 0x0400DC28 RID: 56360
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache61;

	// Token: 0x0400DC29 RID: 56361
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache62;

	// Token: 0x0400DC2A RID: 56362
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache63;

	// Token: 0x0400DC2B RID: 56363
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache64;

	// Token: 0x0400DC2C RID: 56364
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache65;

	// Token: 0x0400DC2D RID: 56365
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache66;

	// Token: 0x0400DC2E RID: 56366
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache67;

	// Token: 0x0400DC2F RID: 56367
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache68;

	// Token: 0x0400DC30 RID: 56368
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache69;

	// Token: 0x0400DC31 RID: 56369
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6A;

	// Token: 0x0400DC32 RID: 56370
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6B;

	// Token: 0x0400DC33 RID: 56371
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6C;

	// Token: 0x0400DC34 RID: 56372
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6D;

	// Token: 0x0400DC35 RID: 56373
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6E;

	// Token: 0x0400DC36 RID: 56374
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6F;

	// Token: 0x0400DC37 RID: 56375
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache70;

	// Token: 0x0400DC38 RID: 56376
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache71;

	// Token: 0x0400DC39 RID: 56377
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache72;

	// Token: 0x0400DC3A RID: 56378
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache73;

	// Token: 0x0400DC3B RID: 56379
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache74;

	// Token: 0x0400DC3C RID: 56380
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache75;

	// Token: 0x0400DC3D RID: 56381
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache76;

	// Token: 0x0400DC3E RID: 56382
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache77;

	// Token: 0x0400DC3F RID: 56383
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache78;

	// Token: 0x0400DC40 RID: 56384
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache79;

	// Token: 0x0400DC41 RID: 56385
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7A;

	// Token: 0x0400DC42 RID: 56386
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7B;

	// Token: 0x0400DC43 RID: 56387
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7C;

	// Token: 0x0400DC44 RID: 56388
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7D;

	// Token: 0x0400DC45 RID: 56389
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7E;

	// Token: 0x0400DC46 RID: 56390
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7F;

	// Token: 0x0400DC47 RID: 56391
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache80;

	// Token: 0x0400DC48 RID: 56392
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache81;

	// Token: 0x0400DC49 RID: 56393
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache82;

	// Token: 0x0400DC4A RID: 56394
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache83;

	// Token: 0x0400DC4B RID: 56395
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache84;

	// Token: 0x0400DC4C RID: 56396
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache85;

	// Token: 0x0400DC4D RID: 56397
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache86;

	// Token: 0x0400DC4E RID: 56398
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache87;

	// Token: 0x0400DC4F RID: 56399
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache88;

	// Token: 0x0400DC50 RID: 56400
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache89;

	// Token: 0x0400DC51 RID: 56401
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8A;

	// Token: 0x0400DC52 RID: 56402
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8B;

	// Token: 0x0400DC53 RID: 56403
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8C;

	// Token: 0x0400DC54 RID: 56404
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8D;

	// Token: 0x0400DC55 RID: 56405
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8E;

	// Token: 0x0400DC56 RID: 56406
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8F;

	// Token: 0x0400DC57 RID: 56407
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache90;

	// Token: 0x0400DC58 RID: 56408
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache91;

	// Token: 0x0400DC59 RID: 56409
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache92;

	// Token: 0x0400DC5A RID: 56410
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache93;

	// Token: 0x0400DC5B RID: 56411
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache94;

	// Token: 0x0400DC5C RID: 56412
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache95;

	// Token: 0x0400DC5D RID: 56413
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache96;

	// Token: 0x0400DC5E RID: 56414
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache97;

	// Token: 0x0400DC5F RID: 56415
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache98;

	// Token: 0x0400DC60 RID: 56416
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache99;

	// Token: 0x0400DC61 RID: 56417
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9A;

	// Token: 0x0400DC62 RID: 56418
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9B;

	// Token: 0x0400DC63 RID: 56419
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9C;

	// Token: 0x0400DC64 RID: 56420
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9D;

	// Token: 0x0400DC65 RID: 56421
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9E;
}
