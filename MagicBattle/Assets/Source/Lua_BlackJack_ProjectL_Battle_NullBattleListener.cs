using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Battle;
using BlackJack.ProjectL.Common;
using FixMath.NET;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020011AD RID: 4525
[Preserve]
public class Lua_BlackJack_ProjectL_Battle_NullBattleListener : LuaObject
{
	// Token: 0x060176CB RID: 95947 RVA: 0x006634C8 File Offset: 0x006616C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			NullBattleListener o = new NullBattleListener();
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

	// Token: 0x060176CC RID: 95948 RVA: 0x00663510 File Offset: 0x00661710
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBattleActorCreate(IntPtr l)
	{
		int result;
		try
		{
			NullBattleListener nullBattleListener = (NullBattleListener)LuaObject.checkSelf(l);
			BattleActor a;
			LuaObject.checkType<BattleActor>(l, 2, out a);
			bool visible;
			LuaObject.checkType(l, 3, out visible);
			nullBattleListener.OnBattleActorCreate(a, visible);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060176CD RID: 95949 RVA: 0x00663574 File Offset: 0x00661774
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBattleActorCreateEnd(IntPtr l)
	{
		int result;
		try
		{
			NullBattleListener nullBattleListener = (NullBattleListener)LuaObject.checkSelf(l);
			BattleActor a;
			LuaObject.checkType<BattleActor>(l, 2, out a);
			nullBattleListener.OnBattleActorCreateEnd(a);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060176CE RID: 95950 RVA: 0x006635CC File Offset: 0x006617CC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnBattleActorActive(IntPtr l)
	{
		int result;
		try
		{
			NullBattleListener nullBattleListener = (NullBattleListener)LuaObject.checkSelf(l);
			BattleActor a;
			LuaObject.checkType<BattleActor>(l, 2, out a);
			bool autoSelect;
			LuaObject.checkType(l, 3, out autoSelect);
			nullBattleListener.OnBattleActorActive(a, autoSelect);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060176CF RID: 95951 RVA: 0x00663630 File Offset: 0x00661830
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBattleActorActionBegin(IntPtr l)
	{
		int result;
		try
		{
			NullBattleListener nullBattleListener = (NullBattleListener)LuaObject.checkSelf(l);
			BattleActor a;
			LuaObject.checkType<BattleActor>(l, 2, out a);
			nullBattleListener.OnBattleActorActionBegin(a);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060176D0 RID: 95952 RVA: 0x00663688 File Offset: 0x00661888
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnBattleActorActionEnd(IntPtr l)
	{
		int result;
		try
		{
			NullBattleListener nullBattleListener = (NullBattleListener)LuaObject.checkSelf(l);
			BattleActor a;
			LuaObject.checkType<BattleActor>(l, 2, out a);
			nullBattleListener.OnBattleActorActionEnd(a);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060176D1 RID: 95953 RVA: 0x006636E0 File Offset: 0x006618E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBattleActorMove(IntPtr l)
	{
		int result;
		try
		{
			NullBattleListener nullBattleListener = (NullBattleListener)LuaObject.checkSelf(l);
			BattleActor a;
			LuaObject.checkType<BattleActor>(l, 2, out a);
			GridPosition p;
			LuaObject.checkValueType<GridPosition>(l, 3, out p);
			int dir;
			LuaObject.checkType(l, 4, out dir);
			nullBattleListener.OnBattleActorMove(a, p, dir);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060176D2 RID: 95954 RVA: 0x00663754 File Offset: 0x00661954
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBattleActorPerformMove(IntPtr l)
	{
		int result;
		try
		{
			NullBattleListener nullBattleListener = (NullBattleListener)LuaObject.checkSelf(l);
			BattleActor a;
			LuaObject.checkType<BattleActor>(l, 2, out a);
			GridPosition p;
			LuaObject.checkValueType<GridPosition>(l, 3, out p);
			int dir;
			LuaObject.checkType(l, 4, out dir);
			bool cameraFollow;
			LuaObject.checkType(l, 5, out cameraFollow);
			nullBattleListener.OnBattleActorPerformMove(a, p, dir, cameraFollow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060176D3 RID: 95955 RVA: 0x006637D4 File Offset: 0x006619D4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnBattleActorPunchMove(IntPtr l)
	{
		int result;
		try
		{
			NullBattleListener nullBattleListener = (NullBattleListener)LuaObject.checkSelf(l);
			BattleActor a;
			LuaObject.checkType<BattleActor>(l, 2, out a);
			string fxName;
			LuaObject.checkType(l, 3, out fxName);
			bool isDragExchange;
			LuaObject.checkType(l, 4, out isDragExchange);
			nullBattleListener.OnBattleActorPunchMove(a, fxName, isDragExchange);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060176D4 RID: 95956 RVA: 0x00663848 File Offset: 0x00661A48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBattleActorExchangeMove(IntPtr l)
	{
		int result;
		try
		{
			NullBattleListener nullBattleListener = (NullBattleListener)LuaObject.checkSelf(l);
			BattleActor a;
			LuaObject.checkType<BattleActor>(l, 2, out a);
			BattleActor b;
			LuaObject.checkType<BattleActor>(l, 3, out b);
			int moveType;
			LuaObject.checkType(l, 4, out moveType);
			string fxName;
			LuaObject.checkType(l, 5, out fxName);
			nullBattleListener.OnBattleActorExchangeMove(a, b, moveType, fxName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060176D5 RID: 95957 RVA: 0x006638C8 File Offset: 0x00661AC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBattleActorSetDir(IntPtr l)
	{
		int result;
		try
		{
			NullBattleListener nullBattleListener = (NullBattleListener)LuaObject.checkSelf(l);
			BattleActor a;
			LuaObject.checkType<BattleActor>(l, 2, out a);
			int dir;
			LuaObject.checkType(l, 3, out dir);
			nullBattleListener.OnBattleActorSetDir(a, dir);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060176D6 RID: 95958 RVA: 0x0066392C File Offset: 0x00661B2C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnBattleActorPlayFx(IntPtr l)
	{
		int result;
		try
		{
			NullBattleListener nullBattleListener = (NullBattleListener)LuaObject.checkSelf(l);
			BattleActor a;
			LuaObject.checkType<BattleActor>(l, 2, out a);
			string fxName;
			LuaObject.checkType(l, 3, out fxName);
			int attachMode;
			LuaObject.checkType(l, 4, out attachMode);
			nullBattleListener.OnBattleActorPlayFx(a, fxName, attachMode);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060176D7 RID: 95959 RVA: 0x006639A0 File Offset: 0x00661BA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBattleActorPlayAnimation(IntPtr l)
	{
		int result;
		try
		{
			NullBattleListener nullBattleListener = (NullBattleListener)LuaObject.checkSelf(l);
			BattleActor a;
			LuaObject.checkType<BattleActor>(l, 2, out a);
			string animationName;
			LuaObject.checkType(l, 3, out animationName);
			int animationTime;
			LuaObject.checkType(l, 4, out animationTime);
			nullBattleListener.OnBattleActorPlayAnimation(a, animationName, animationTime);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060176D8 RID: 95960 RVA: 0x00663A14 File Offset: 0x00661C14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBattleActorChangeIdleAnimation(IntPtr l)
	{
		int result;
		try
		{
			NullBattleListener nullBattleListener = (NullBattleListener)LuaObject.checkSelf(l);
			BattleActor a;
			LuaObject.checkType<BattleActor>(l, 2, out a);
			string idleAnimationName;
			LuaObject.checkType(l, 3, out idleAnimationName);
			nullBattleListener.OnBattleActorChangeIdleAnimation(a, idleAnimationName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060176D9 RID: 95961 RVA: 0x00663A78 File Offset: 0x00661C78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBattleActorSkill(IntPtr l)
	{
		int result;
		try
		{
			NullBattleListener nullBattleListener = (NullBattleListener)LuaObject.checkSelf(l);
			BattleActor a;
			LuaObject.checkType<BattleActor>(l, 2, out a);
			ConfigDataSkillInfo skillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 3, out skillInfo);
			GridPosition p;
			LuaObject.checkValueType<GridPosition>(l, 4, out p);
			nullBattleListener.OnBattleActorSkill(a, skillInfo, p);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060176DA RID: 95962 RVA: 0x00663AEC File Offset: 0x00661CEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBattleActorSkillHitBegin(IntPtr l)
	{
		int result;
		try
		{
			NullBattleListener nullBattleListener = (NullBattleListener)LuaObject.checkSelf(l);
			BattleActor a;
			LuaObject.checkType<BattleActor>(l, 2, out a);
			ConfigDataSkillInfo skillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 3, out skillInfo);
			bool isRebound;
			LuaObject.checkType(l, 4, out isRebound);
			nullBattleListener.OnBattleActorSkillHitBegin(a, skillInfo, isRebound);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060176DB RID: 95963 RVA: 0x00663B60 File Offset: 0x00661D60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBattleActorSkillHit(IntPtr l)
	{
		int result;
		try
		{
			NullBattleListener nullBattleListener = (NullBattleListener)LuaObject.checkSelf(l);
			BattleActor a;
			LuaObject.checkType<BattleActor>(l, 2, out a);
			ConfigDataSkillInfo skillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 3, out skillInfo);
			int heroHpModify;
			LuaObject.checkType(l, 4, out heroHpModify);
			int soldierHpModify;
			LuaObject.checkType(l, 5, out soldierHpModify);
			DamageNumberType damageNumberType;
			LuaObject.checkEnum<DamageNumberType>(l, 6, out damageNumberType);
			bool isRebound;
			LuaObject.checkType(l, 7, out isRebound);
			nullBattleListener.OnBattleActorSkillHit(a, skillInfo, heroHpModify, soldierHpModify, damageNumberType, isRebound);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060176DC RID: 95964 RVA: 0x00663BF8 File Offset: 0x00661DF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBattleActorSkillHitEnd(IntPtr l)
	{
		int result;
		try
		{
			NullBattleListener nullBattleListener = (NullBattleListener)LuaObject.checkSelf(l);
			BattleActor a;
			LuaObject.checkType<BattleActor>(l, 2, out a);
			ConfigDataSkillInfo skillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 3, out skillInfo);
			bool isRebound;
			LuaObject.checkType(l, 4, out isRebound);
			nullBattleListener.OnBattleActorSkillHitEnd(a, skillInfo, isRebound);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060176DD RID: 95965 RVA: 0x00663C6C File Offset: 0x00661E6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBattleActorAttachBuff(IntPtr l)
	{
		int result;
		try
		{
			NullBattleListener nullBattleListener = (NullBattleListener)LuaObject.checkSelf(l);
			BattleActor a;
			LuaObject.checkType<BattleActor>(l, 2, out a);
			BuffState buffState;
			LuaObject.checkType<BuffState>(l, 3, out buffState);
			nullBattleListener.OnBattleActorAttachBuff(a, buffState);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060176DE RID: 95966 RVA: 0x00663CD0 File Offset: 0x00661ED0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBattleActorDetachBuff(IntPtr l)
	{
		int result;
		try
		{
			NullBattleListener nullBattleListener = (NullBattleListener)LuaObject.checkSelf(l);
			BattleActor a;
			LuaObject.checkType<BattleActor>(l, 2, out a);
			BuffState buffState;
			LuaObject.checkType<BuffState>(l, 3, out buffState);
			nullBattleListener.OnBattleActorDetachBuff(a, buffState);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060176DF RID: 95967 RVA: 0x00663D34 File Offset: 0x00661F34
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnBattleActorImmune(IntPtr l)
	{
		int result;
		try
		{
			NullBattleListener nullBattleListener = (NullBattleListener)LuaObject.checkSelf(l);
			BattleActor a;
			LuaObject.checkType<BattleActor>(l, 2, out a);
			nullBattleListener.OnBattleActorImmune(a);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060176E0 RID: 95968 RVA: 0x00663D8C File Offset: 0x00661F8C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnBattleActorPassiveSkill(IntPtr l)
	{
		int result;
		try
		{
			NullBattleListener nullBattleListener = (NullBattleListener)LuaObject.checkSelf(l);
			BattleActor a;
			LuaObject.checkType<BattleActor>(l, 2, out a);
			BattleActor target;
			LuaObject.checkType<BattleActor>(l, 3, out target);
			BuffState sourceBuffState;
			LuaObject.checkType<BuffState>(l, 4, out sourceBuffState);
			nullBattleListener.OnBattleActorPassiveSkill(a, target, sourceBuffState);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060176E1 RID: 95969 RVA: 0x00663E00 File Offset: 0x00662000
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBattleActorBuffHit(IntPtr l)
	{
		int result;
		try
		{
			NullBattleListener nullBattleListener = (NullBattleListener)LuaObject.checkSelf(l);
			BattleActor a;
			LuaObject.checkType<BattleActor>(l, 2, out a);
			BuffState buffState;
			LuaObject.checkType<BuffState>(l, 3, out buffState);
			int heroHpModify;
			LuaObject.checkType(l, 4, out heroHpModify);
			int soldierHpModify;
			LuaObject.checkType(l, 5, out soldierHpModify);
			DamageNumberType damageNumberType;
			LuaObject.checkEnum<DamageNumberType>(l, 6, out damageNumberType);
			nullBattleListener.OnBattleActorBuffHit(a, buffState, heroHpModify, soldierHpModify, damageNumberType);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060176E2 RID: 95970 RVA: 0x00663E8C File Offset: 0x0066208C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBattleActorTerrainHit(IntPtr l)
	{
		int result;
		try
		{
			NullBattleListener nullBattleListener = (NullBattleListener)LuaObject.checkSelf(l);
			BattleActor a;
			LuaObject.checkType<BattleActor>(l, 2, out a);
			ConfigDataTerrainInfo terrainInfo;
			LuaObject.checkType<ConfigDataTerrainInfo>(l, 3, out terrainInfo);
			int heroHpModify;
			LuaObject.checkType(l, 4, out heroHpModify);
			int soldierHpModify;
			LuaObject.checkType(l, 5, out soldierHpModify);
			DamageNumberType damageNumberType;
			LuaObject.checkEnum<DamageNumberType>(l, 6, out damageNumberType);
			nullBattleListener.OnBattleActorTerrainHit(a, terrainInfo, heroHpModify, soldierHpModify, damageNumberType);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060176E3 RID: 95971 RVA: 0x00663F18 File Offset: 0x00662118
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBattleActorTeleport(IntPtr l)
	{
		int result;
		try
		{
			NullBattleListener nullBattleListener = (NullBattleListener)LuaObject.checkSelf(l);
			BattleActor a;
			LuaObject.checkType<BattleActor>(l, 2, out a);
			ConfigDataSkillInfo skillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 3, out skillInfo);
			GridPosition p;
			LuaObject.checkValueType<GridPosition>(l, 4, out p);
			nullBattleListener.OnBattleActorTeleport(a, skillInfo, p);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060176E4 RID: 95972 RVA: 0x00663F8C File Offset: 0x0066218C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnBattleActorSummon(IntPtr l)
	{
		int result;
		try
		{
			NullBattleListener nullBattleListener = (NullBattleListener)LuaObject.checkSelf(l);
			BattleActor a;
			LuaObject.checkType<BattleActor>(l, 2, out a);
			ConfigDataSkillInfo skillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 3, out skillInfo);
			nullBattleListener.OnBattleActorSummon(a, skillInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060176E5 RID: 95973 RVA: 0x00663FF0 File Offset: 0x006621F0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnBattleActorDie(IntPtr l)
	{
		int result;
		try
		{
			NullBattleListener nullBattleListener = (NullBattleListener)LuaObject.checkSelf(l);
			BattleActor actor;
			LuaObject.checkType<BattleActor>(l, 2, out actor);
			bool isAfterCombat;
			LuaObject.checkType(l, 3, out isAfterCombat);
			nullBattleListener.OnBattleActorDie(actor, isAfterCombat);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060176E6 RID: 95974 RVA: 0x00664054 File Offset: 0x00662254
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnBattleActorAppear(IntPtr l)
	{
		int result;
		try
		{
			NullBattleListener nullBattleListener = (NullBattleListener)LuaObject.checkSelf(l);
			BattleActor a;
			LuaObject.checkType<BattleActor>(l, 2, out a);
			int effectType;
			LuaObject.checkType(l, 3, out effectType);
			string fxName;
			LuaObject.checkType(l, 4, out fxName);
			nullBattleListener.OnBattleActorAppear(a, effectType, fxName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060176E7 RID: 95975 RVA: 0x006640C8 File Offset: 0x006622C8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnBattleActorDisappear(IntPtr l)
	{
		int result;
		try
		{
			NullBattleListener nullBattleListener = (NullBattleListener)LuaObject.checkSelf(l);
			BattleActor actor;
			LuaObject.checkType<BattleActor>(l, 2, out actor);
			int effectType;
			LuaObject.checkType(l, 3, out effectType);
			string fxName;
			LuaObject.checkType(l, 4, out fxName);
			nullBattleListener.OnBattleActorDisappear(actor, effectType, fxName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060176E8 RID: 95976 RVA: 0x0066413C File Offset: 0x0066233C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBattleActorChangeTeam(IntPtr l)
	{
		int result;
		try
		{
			NullBattleListener nullBattleListener = (NullBattleListener)LuaObject.checkSelf(l);
			BattleActor a;
			LuaObject.checkType<BattleActor>(l, 2, out a);
			nullBattleListener.OnBattleActorChangeTeam(a);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060176E9 RID: 95977 RVA: 0x00664194 File Offset: 0x00662394
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBattleActorChangeArmy(IntPtr l)
	{
		int result;
		try
		{
			NullBattleListener nullBattleListener = (NullBattleListener)LuaObject.checkSelf(l);
			BattleActor a;
			LuaObject.checkType<BattleActor>(l, 2, out a);
			nullBattleListener.OnBattleActorChangeArmy(a);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060176EA RID: 95978 RVA: 0x006641EC File Offset: 0x006623EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBattleActorReplace(IntPtr l)
	{
		int result;
		try
		{
			NullBattleListener nullBattleListener = (NullBattleListener)LuaObject.checkSelf(l);
			BattleActor a;
			LuaObject.checkType<BattleActor>(l, 2, out a);
			BattleActor a2;
			LuaObject.checkType<BattleActor>(l, 3, out a2);
			string fxName;
			LuaObject.checkType(l, 4, out fxName);
			nullBattleListener.OnBattleActorReplace(a, a2, fxName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060176EB RID: 95979 RVA: 0x00664260 File Offset: 0x00662460
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBattleActorCameraFocus(IntPtr l)
	{
		int result;
		try
		{
			NullBattleListener nullBattleListener = (NullBattleListener)LuaObject.checkSelf(l);
			BattleActor a;
			LuaObject.checkType<BattleActor>(l, 2, out a);
			nullBattleListener.OnBattleActorCameraFocus(a);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060176EC RID: 95980 RVA: 0x006642B8 File Offset: 0x006624B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBattleActorGainBattleTreasure(IntPtr l)
	{
		int result;
		try
		{
			NullBattleListener nullBattleListener = (NullBattleListener)LuaObject.checkSelf(l);
			BattleActor a;
			LuaObject.checkType<BattleActor>(l, 2, out a);
			ConfigDataBattleTreasureInfo t;
			LuaObject.checkType<ConfigDataBattleTreasureInfo>(l, 3, out t);
			nullBattleListener.OnBattleActorGainBattleTreasure(a, t);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060176ED RID: 95981 RVA: 0x0066431C File Offset: 0x0066251C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStartGuard(IntPtr l)
	{
		int result;
		try
		{
			NullBattleListener nullBattleListener = (NullBattleListener)LuaObject.checkSelf(l);
			BattleActor a;
			LuaObject.checkType<BattleActor>(l, 2, out a);
			BattleActor target;
			LuaObject.checkType<BattleActor>(l, 3, out target);
			nullBattleListener.OnStartGuard(a, target);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060176EE RID: 95982 RVA: 0x00664380 File Offset: 0x00662580
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStopGuard(IntPtr l)
	{
		int result;
		try
		{
			NullBattleListener nullBattleListener = (NullBattleListener)LuaObject.checkSelf(l);
			BattleActor a;
			LuaObject.checkType<BattleActor>(l, 2, out a);
			BattleActor target;
			LuaObject.checkType<BattleActor>(l, 3, out target);
			nullBattleListener.OnStopGuard(a, target);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060176EF RID: 95983 RVA: 0x006643E4 File Offset: 0x006625E4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnBeforeStartCombat(IntPtr l)
	{
		int result;
		try
		{
			NullBattleListener nullBattleListener = (NullBattleListener)LuaObject.checkSelf(l);
			BattleActor a;
			LuaObject.checkType<BattleActor>(l, 2, out a);
			BattleActor b;
			LuaObject.checkType<BattleActor>(l, 3, out b);
			ConfigDataSkillInfo attackerSkillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 4, out attackerSkillInfo);
			nullBattleListener.OnBeforeStartCombat(a, b, attackerSkillInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060176F0 RID: 95984 RVA: 0x00664458 File Offset: 0x00662658
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnCancelCombat(IntPtr l)
	{
		int result;
		try
		{
			NullBattleListener nullBattleListener = (NullBattleListener)LuaObject.checkSelf(l);
			nullBattleListener.OnCancelCombat();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060176F1 RID: 95985 RVA: 0x006644A4 File Offset: 0x006626A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStartCombat(IntPtr l)
	{
		int result;
		try
		{
			NullBattleListener nullBattleListener = (NullBattleListener)LuaObject.checkSelf(l);
			BattleActor a;
			LuaObject.checkType<BattleActor>(l, 2, out a);
			BattleActor b;
			LuaObject.checkType<BattleActor>(l, 3, out b);
			ConfigDataSkillInfo attackerSkillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 4, out attackerSkillInfo);
			nullBattleListener.OnStartCombat(a, b, attackerSkillInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060176F2 RID: 95986 RVA: 0x00664518 File Offset: 0x00662718
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPreStopCombat(IntPtr l)
	{
		int result;
		try
		{
			NullBattleListener nullBattleListener = (NullBattleListener)LuaObject.checkSelf(l);
			nullBattleListener.OnPreStopCombat();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060176F3 RID: 95987 RVA: 0x00664564 File Offset: 0x00662764
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStopCombat(IntPtr l)
	{
		int result;
		try
		{
			NullBattleListener nullBattleListener = (NullBattleListener)LuaObject.checkSelf(l);
			int teamAHeroTotalDamage;
			LuaObject.checkType(l, 2, out teamAHeroTotalDamage);
			int teamASoldierTotalDamage;
			LuaObject.checkType(l, 3, out teamASoldierTotalDamage);
			bool teamACriticalAttack;
			LuaObject.checkType(l, 4, out teamACriticalAttack);
			int teamBHeroTotalDamage;
			LuaObject.checkType(l, 5, out teamBHeroTotalDamage);
			int teamBSoldierTotalDamage;
			LuaObject.checkType(l, 6, out teamBSoldierTotalDamage);
			bool teamBCriticalAttack;
			LuaObject.checkType(l, 7, out teamBCriticalAttack);
			nullBattleListener.OnStopCombat(teamAHeroTotalDamage, teamASoldierTotalDamage, teamACriticalAttack, teamBHeroTotalDamage, teamBSoldierTotalDamage, teamBCriticalAttack);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060176F4 RID: 95988 RVA: 0x006645FC File Offset: 0x006627FC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnBattleNextTurn(IntPtr l)
	{
		int result;
		try
		{
			NullBattleListener nullBattleListener = (NullBattleListener)LuaObject.checkSelf(l);
			int turn;
			LuaObject.checkType(l, 2, out turn);
			nullBattleListener.OnBattleNextTurn(turn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060176F5 RID: 95989 RVA: 0x00664654 File Offset: 0x00662854
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBattleNextTeam(IntPtr l)
	{
		int result;
		try
		{
			NullBattleListener nullBattleListener = (NullBattleListener)LuaObject.checkSelf(l);
			int team;
			LuaObject.checkType(l, 2, out team);
			bool isNpc;
			LuaObject.checkType(l, 3, out isNpc);
			nullBattleListener.OnBattleNextTeam(team, isNpc);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060176F6 RID: 95990 RVA: 0x006646B8 File Offset: 0x006628B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBattleNextPlayer(IntPtr l)
	{
		int result;
		try
		{
			NullBattleListener nullBattleListener = (NullBattleListener)LuaObject.checkSelf(l);
			int prevPlayerIndex;
			LuaObject.checkType(l, 2, out prevPlayerIndex);
			int playerIndex;
			LuaObject.checkType(l, 3, out playerIndex);
			nullBattleListener.OnBattleNextPlayer(prevPlayerIndex, playerIndex);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060176F7 RID: 95991 RVA: 0x0066471C File Offset: 0x0066291C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnBattleNextActor(IntPtr l)
	{
		int result;
		try
		{
			NullBattleListener nullBattleListener = (NullBattleListener)LuaObject.checkSelf(l);
			BattleActor actor;
			LuaObject.checkType<BattleActor>(l, 2, out actor);
			nullBattleListener.OnBattleNextActor(actor);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060176F8 RID: 95992 RVA: 0x00664774 File Offset: 0x00662974
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnCombatActorSkill(IntPtr l)
	{
		int result;
		try
		{
			NullBattleListener nullBattleListener = (NullBattleListener)LuaObject.checkSelf(l);
			CombatActor a;
			LuaObject.checkType<CombatActor>(l, 2, out a);
			ConfigDataSkillInfo skillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 3, out skillInfo);
			nullBattleListener.OnCombatActorSkill(a, skillInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060176F9 RID: 95993 RVA: 0x006647D8 File Offset: 0x006629D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnCombatActorHit(IntPtr l)
	{
		int result;
		try
		{
			NullBattleListener nullBattleListener = (NullBattleListener)LuaObject.checkSelf(l);
			CombatActor a;
			LuaObject.checkType<CombatActor>(l, 2, out a);
			CombatActor attacker;
			LuaObject.checkType<CombatActor>(l, 3, out attacker);
			ConfigDataSkillInfo skillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 4, out skillInfo);
			int hpModify;
			LuaObject.checkType(l, 5, out hpModify);
			int totalDamage;
			LuaObject.checkType(l, 6, out totalDamage);
			DamageNumberType damageNumberType;
			LuaObject.checkEnum<DamageNumberType>(l, 7, out damageNumberType);
			nullBattleListener.OnCombatActorHit(a, attacker, skillInfo, hpModify, totalDamage, damageNumberType);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060176FA RID: 95994 RVA: 0x00664870 File Offset: 0x00662A70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnCombatActorDie(IntPtr l)
	{
		int result;
		try
		{
			NullBattleListener nullBattleListener = (NullBattleListener)LuaObject.checkSelf(l);
			CombatActor a;
			LuaObject.checkType<CombatActor>(l, 2, out a);
			nullBattleListener.OnCombatActorDie(a);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060176FB RID: 95995 RVA: 0x006648C8 File Offset: 0x00662AC8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnStartSkillCutscene(IntPtr l)
	{
		int result;
		try
		{
			NullBattleListener nullBattleListener = (NullBattleListener)LuaObject.checkSelf(l);
			ConfigDataSkillInfo skillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 2, out skillInfo);
			ConfigDataCutsceneInfo cutsceneInfo;
			LuaObject.checkType<ConfigDataCutsceneInfo>(l, 3, out cutsceneInfo);
			int team;
			LuaObject.checkType(l, 4, out team);
			nullBattleListener.OnStartSkillCutscene(skillInfo, cutsceneInfo, team);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060176FC RID: 95996 RVA: 0x0066493C File Offset: 0x00662B3C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnStartPassiveSkillCutscene(IntPtr l)
	{
		int result;
		try
		{
			NullBattleListener nullBattleListener = (NullBattleListener)LuaObject.checkSelf(l);
			BuffState sourceBuffState;
			LuaObject.checkType<BuffState>(l, 2, out sourceBuffState);
			int team;
			LuaObject.checkType(l, 3, out team);
			nullBattleListener.OnStartPassiveSkillCutscene(sourceBuffState, team);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060176FD RID: 95997 RVA: 0x006649A0 File Offset: 0x00662BA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStopSkillCutscene(IntPtr l)
	{
		int result;
		try
		{
			NullBattleListener nullBattleListener = (NullBattleListener)LuaObject.checkSelf(l);
			nullBattleListener.OnStopSkillCutscene();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060176FE RID: 95998 RVA: 0x006649EC File Offset: 0x00662BEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStartBattleDialog(IntPtr l)
	{
		int result;
		try
		{
			NullBattleListener nullBattleListener = (NullBattleListener)LuaObject.checkSelf(l);
			ConfigDataBattleDialogInfo dialogInfo;
			LuaObject.checkType<ConfigDataBattleDialogInfo>(l, 2, out dialogInfo);
			nullBattleListener.OnStartBattleDialog(dialogInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060176FF RID: 95999 RVA: 0x00664A44 File Offset: 0x00662C44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStartBattlePerform(IntPtr l)
	{
		int result;
		try
		{
			NullBattleListener nullBattleListener = (NullBattleListener)LuaObject.checkSelf(l);
			ConfigDataBattlePerformInfo performInfo;
			LuaObject.checkType<ConfigDataBattlePerformInfo>(l, 2, out performInfo);
			nullBattleListener.OnStartBattlePerform(performInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017700 RID: 96000 RVA: 0x00664A9C File Offset: 0x00662C9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStopBattlePerform(IntPtr l)
	{
		int result;
		try
		{
			NullBattleListener nullBattleListener = (NullBattleListener)LuaObject.checkSelf(l);
			nullBattleListener.OnStopBattlePerform();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017701 RID: 96001 RVA: 0x00664AE8 File Offset: 0x00662CE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnChangeMapTerrain(IntPtr l)
	{
		int result;
		try
		{
			NullBattleListener nullBattleListener = (NullBattleListener)LuaObject.checkSelf(l);
			GridPosition p;
			LuaObject.checkValueType<GridPosition>(l, 2, out p);
			ConfigDataTerrainInfo terrainInfo;
			LuaObject.checkType<ConfigDataTerrainInfo>(l, 3, out terrainInfo);
			nullBattleListener.OnChangeMapTerrain(p, terrainInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017702 RID: 96002 RVA: 0x00664B4C File Offset: 0x00662D4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnCameraFocus(IntPtr l)
	{
		int result;
		try
		{
			NullBattleListener nullBattleListener = (NullBattleListener)LuaObject.checkSelf(l);
			GridPosition p;
			LuaObject.checkValueType<GridPosition>(l, 2, out p);
			nullBattleListener.OnCameraFocus(p);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017703 RID: 96003 RVA: 0x00664BA4 File Offset: 0x00662DA4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnPlayMusic(IntPtr l)
	{
		int result;
		try
		{
			NullBattleListener nullBattleListener = (NullBattleListener)LuaObject.checkSelf(l);
			string musicName;
			LuaObject.checkType(l, 2, out musicName);
			nullBattleListener.OnPlayMusic(musicName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017704 RID: 96004 RVA: 0x00664BFC File Offset: 0x00662DFC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnPlaySound(IntPtr l)
	{
		int result;
		try
		{
			NullBattleListener nullBattleListener = (NullBattleListener)LuaObject.checkSelf(l);
			string soundName;
			LuaObject.checkType(l, 2, out soundName);
			nullBattleListener.OnPlaySound(soundName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017705 RID: 96005 RVA: 0x00664C54 File Offset: 0x00662E54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPlayFx(IntPtr l)
	{
		int result;
		try
		{
			NullBattleListener nullBattleListener = (NullBattleListener)LuaObject.checkSelf(l);
			string fxName;
			LuaObject.checkType(l, 2, out fxName);
			GridPosition p;
			LuaObject.checkValueType<GridPosition>(l, 3, out p);
			nullBattleListener.OnPlayFx(fxName, p);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017706 RID: 96006 RVA: 0x00664CB8 File Offset: 0x00662EB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnWaitTime(IntPtr l)
	{
		int result;
		try
		{
			NullBattleListener nullBattleListener = (NullBattleListener)LuaObject.checkSelf(l);
			int timeInMs;
			LuaObject.checkType(l, 2, out timeInMs);
			nullBattleListener.OnWaitTime(timeInMs);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017707 RID: 96007 RVA: 0x00664D10 File Offset: 0x00662F10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBattleTreasureCreate(IntPtr l)
	{
		int result;
		try
		{
			NullBattleListener nullBattleListener = (NullBattleListener)LuaObject.checkSelf(l);
			ConfigDataBattleTreasureInfo treasureInfo;
			LuaObject.checkType<ConfigDataBattleTreasureInfo>(l, 2, out treasureInfo);
			bool isOpened;
			LuaObject.checkType(l, 3, out isOpened);
			nullBattleListener.OnBattleTreasureCreate(treasureInfo, isOpened);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017708 RID: 96008 RVA: 0x00664D74 File Offset: 0x00662F74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateCombatGraphic(IntPtr l)
	{
		int result;
		try
		{
			NullBattleListener nullBattleListener = (NullBattleListener)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			float scale;
			LuaObject.checkType(l, 3, out scale);
			IBattleGraphic o = nullBattleListener.CreateCombatGraphic(assetName, scale);
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

	// Token: 0x06017709 RID: 96009 RVA: 0x00664DE4 File Offset: 0x00662FE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DestroyCombatGraphic(IntPtr l)
	{
		int result;
		try
		{
			NullBattleListener nullBattleListener = (NullBattleListener)LuaObject.checkSelf(l);
			IBattleGraphic model;
			LuaObject.checkType<IBattleGraphic>(l, 2, out model);
			nullBattleListener.DestroyCombatGraphic(model);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601770A RID: 96010 RVA: 0x00664E3C File Offset: 0x0066303C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayFx(IntPtr l)
	{
		int result;
		try
		{
			NullBattleListener nullBattleListener = (NullBattleListener)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			float scale;
			LuaObject.checkType(l, 3, out scale);
			IBattleGraphic o = nullBattleListener.PlayFx(assetName, scale);
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

	// Token: 0x0601770B RID: 96011 RVA: 0x00664EAC File Offset: 0x006630AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlaySound(IntPtr l)
	{
		int result;
		try
		{
			NullBattleListener nullBattleListener = (NullBattleListener)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			nullBattleListener.PlaySound(name);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601770C RID: 96012 RVA: 0x00664F04 File Offset: 0x00663104
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DrawLine(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 4)
			{
				NullBattleListener nullBattleListener = (NullBattleListener)LuaObject.checkSelf(l);
				Vector2i p;
				LuaObject.checkValueType<Vector2i>(l, 2, out p);
				Vector2i p2;
				LuaObject.checkValueType<Vector2i>(l, 3, out p2);
				Colori color;
				LuaObject.checkValueType<Colori>(l, 4, out color);
				nullBattleListener.DrawLine(p, p2, color);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 6)
			{
				NullBattleListener nullBattleListener2 = (NullBattleListener)LuaObject.checkSelf(l);
				Vector2i p3;
				LuaObject.checkValueType<Vector2i>(l, 2, out p3);
				Fix64 z;
				LuaObject.checkValueType<Fix64>(l, 3, out z);
				Vector2i p4;
				LuaObject.checkValueType<Vector2i>(l, 4, out p4);
				Fix64 z2;
				LuaObject.checkValueType<Fix64>(l, 5, out z2);
				Colori color2;
				LuaObject.checkValueType<Colori>(l, 6, out color2);
				nullBattleListener2.DrawLine(p3, z, p4, z2, color2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function DrawLine to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601770D RID: 96013 RVA: 0x00665008 File Offset: 0x00663208
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LogBattleStart(IntPtr l)
	{
		int result;
		try
		{
			NullBattleListener nullBattleListener = (NullBattleListener)LuaObject.checkSelf(l);
			nullBattleListener.LogBattleStart();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601770E RID: 96014 RVA: 0x00665054 File Offset: 0x00663254
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LogBattleStop(IntPtr l)
	{
		int result;
		try
		{
			NullBattleListener nullBattleListener = (NullBattleListener)LuaObject.checkSelf(l);
			bool isWin;
			LuaObject.checkType(l, 2, out isWin);
			nullBattleListener.LogBattleStop(isWin);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601770F RID: 96015 RVA: 0x006650AC File Offset: 0x006632AC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int LogBattleTeam(IntPtr l)
	{
		int result;
		try
		{
			NullBattleListener nullBattleListener = (NullBattleListener)LuaObject.checkSelf(l);
			BattleTeam team;
			LuaObject.checkType<BattleTeam>(l, 2, out team);
			BattleTeam team2;
			LuaObject.checkType<BattleTeam>(l, 3, out team2);
			nullBattleListener.LogBattleTeam(team, team2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017710 RID: 96016 RVA: 0x00665110 File Offset: 0x00663310
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LogActorMove(IntPtr l)
	{
		int result;
		try
		{
			NullBattleListener nullBattleListener = (NullBattleListener)LuaObject.checkSelf(l);
			BattleActor actor;
			LuaObject.checkType<BattleActor>(l, 2, out actor);
			GridPosition fromPos;
			LuaObject.checkValueType<GridPosition>(l, 3, out fromPos);
			GridPosition toPos;
			LuaObject.checkValueType<GridPosition>(l, 4, out toPos);
			nullBattleListener.LogActorMove(actor, fromPos, toPos);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017711 RID: 96017 RVA: 0x00665184 File Offset: 0x00663384
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LogActorStandby(IntPtr l)
	{
		int result;
		try
		{
			NullBattleListener nullBattleListener = (NullBattleListener)LuaObject.checkSelf(l);
			BattleActor actor;
			LuaObject.checkType<BattleActor>(l, 2, out actor);
			nullBattleListener.LogActorStandby(actor);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017712 RID: 96018 RVA: 0x006651DC File Offset: 0x006633DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LogActorAttack(IntPtr l)
	{
		int result;
		try
		{
			NullBattleListener nullBattleListener = (NullBattleListener)LuaObject.checkSelf(l);
			BattleActor actor;
			LuaObject.checkType<BattleActor>(l, 2, out actor);
			BattleActor targetActor;
			LuaObject.checkType<BattleActor>(l, 3, out targetActor);
			nullBattleListener.LogActorAttack(actor, targetActor);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017713 RID: 96019 RVA: 0x00665240 File Offset: 0x00663440
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int LogActorSkill(IntPtr l)
	{
		int result;
		try
		{
			NullBattleListener nullBattleListener = (NullBattleListener)LuaObject.checkSelf(l);
			BattleActor actor;
			LuaObject.checkType<BattleActor>(l, 2, out actor);
			ConfigDataSkillInfo skillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 3, out skillInfo);
			BattleActor targetActor;
			LuaObject.checkType<BattleActor>(l, 4, out targetActor);
			GridPosition targetPos;
			LuaObject.checkValueType<GridPosition>(l, 5, out targetPos);
			nullBattleListener.LogActorSkill(actor, skillInfo, targetActor, targetPos);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017714 RID: 96020 RVA: 0x006652C0 File Offset: 0x006634C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LogActorDie(IntPtr l)
	{
		int result;
		try
		{
			NullBattleListener nullBattleListener = (NullBattleListener)LuaObject.checkSelf(l);
			BattleActor actor;
			LuaObject.checkType<BattleActor>(l, 2, out actor);
			BattleActor killerActor;
			LuaObject.checkType<BattleActor>(l, 3, out killerActor);
			nullBattleListener.LogActorDie(actor, killerActor);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017715 RID: 96021 RVA: 0x00665324 File Offset: 0x00663524
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Battle.NullBattleListener");
		if (Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_NullBattleListener.OnBattleActorCreate);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_NullBattleListener.OnBattleActorCreateEnd);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_NullBattleListener.OnBattleActorActive);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_NullBattleListener.OnBattleActorActionBegin);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_NullBattleListener.OnBattleActorActionEnd);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_NullBattleListener.OnBattleActorMove);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_NullBattleListener.OnBattleActorPerformMove);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_NullBattleListener.OnBattleActorPunchMove);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_NullBattleListener.OnBattleActorExchangeMove);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_NullBattleListener.OnBattleActorSetDir);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_NullBattleListener.OnBattleActorPlayFx);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_NullBattleListener.OnBattleActorPlayAnimation);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_NullBattleListener.OnBattleActorChangeIdleAnimation);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_NullBattleListener.OnBattleActorSkill);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_NullBattleListener.OnBattleActorSkillHitBegin);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_NullBattleListener.OnBattleActorSkillHit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_NullBattleListener.OnBattleActorSkillHitEnd);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_NullBattleListener.OnBattleActorAttachBuff);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_NullBattleListener.OnBattleActorDetachBuff);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_NullBattleListener.OnBattleActorImmune);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_NullBattleListener.OnBattleActorPassiveSkill);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_NullBattleListener.OnBattleActorBuffHit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_NullBattleListener.OnBattleActorTerrainHit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_NullBattleListener.OnBattleActorTeleport);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_NullBattleListener.OnBattleActorSummon);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_NullBattleListener.OnBattleActorDie);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_NullBattleListener.OnBattleActorAppear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_NullBattleListener.OnBattleActorDisappear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_NullBattleListener.OnBattleActorChangeTeam);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_NullBattleListener.OnBattleActorChangeArmy);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_NullBattleListener.OnBattleActorReplace);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_NullBattleListener.OnBattleActorCameraFocus);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_NullBattleListener.OnBattleActorGainBattleTreasure);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_NullBattleListener.OnStartGuard);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_NullBattleListener.OnStopGuard);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_NullBattleListener.OnBeforeStartCombat);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_NullBattleListener.OnCancelCombat);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_NullBattleListener.OnStartCombat);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_NullBattleListener.OnPreStopCombat);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_NullBattleListener.OnStopCombat);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_NullBattleListener.OnBattleNextTurn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_NullBattleListener.OnBattleNextTeam);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache29);
		if (Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_NullBattleListener.OnBattleNextPlayer);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache2A);
		if (Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_NullBattleListener.OnBattleNextActor);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache2B);
		if (Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_NullBattleListener.OnCombatActorSkill);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache2C);
		if (Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_NullBattleListener.OnCombatActorHit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache2D);
		if (Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_NullBattleListener.OnCombatActorDie);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache2E);
		if (Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_NullBattleListener.OnStartSkillCutscene);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache2F);
		if (Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_NullBattleListener.OnStartPassiveSkillCutscene);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache30);
		if (Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_NullBattleListener.OnStopSkillCutscene);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache31);
		if (Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_NullBattleListener.OnStartBattleDialog);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache32);
		if (Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_NullBattleListener.OnStartBattlePerform);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache33);
		if (Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_NullBattleListener.OnStopBattlePerform);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache34);
		if (Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_NullBattleListener.OnChangeMapTerrain);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache35);
		if (Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_NullBattleListener.OnCameraFocus);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache36);
		if (Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_NullBattleListener.OnPlayMusic);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache37);
		if (Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_NullBattleListener.OnPlaySound);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache38);
		if (Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_NullBattleListener.OnPlayFx);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache39);
		if (Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_NullBattleListener.OnWaitTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache3A);
		if (Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_NullBattleListener.OnBattleTreasureCreate);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache3B);
		if (Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_NullBattleListener.CreateCombatGraphic);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache3C);
		if (Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_NullBattleListener.DestroyCombatGraphic);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache3D);
		if (Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_NullBattleListener.PlayFx);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache3E);
		if (Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_NullBattleListener.PlaySound);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache3F);
		if (Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_NullBattleListener.DrawLine);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache40);
		if (Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_NullBattleListener.LogBattleStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache41);
		if (Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_NullBattleListener.LogBattleStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache42);
		if (Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_NullBattleListener.LogBattleTeam);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache43);
		if (Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_NullBattleListener.LogActorMove);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache44);
		if (Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_NullBattleListener.LogActorStandby);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache45);
		if (Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_NullBattleListener.LogActorAttack);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache46);
		if (Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_NullBattleListener.LogActorSkill);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache47);
		if (Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_NullBattleListener.LogActorDie);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache48);
		if (Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_NullBattleListener.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Battle_NullBattleListener.<>f__mg$cache49, typeof(NullBattleListener));
	}

	// Token: 0x0400DD53 RID: 56659
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400DD54 RID: 56660
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400DD55 RID: 56661
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400DD56 RID: 56662
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400DD57 RID: 56663
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400DD58 RID: 56664
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400DD59 RID: 56665
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400DD5A RID: 56666
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400DD5B RID: 56667
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400DD5C RID: 56668
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400DD5D RID: 56669
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400DD5E RID: 56670
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400DD5F RID: 56671
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400DD60 RID: 56672
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400DD61 RID: 56673
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400DD62 RID: 56674
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400DD63 RID: 56675
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400DD64 RID: 56676
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400DD65 RID: 56677
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400DD66 RID: 56678
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400DD67 RID: 56679
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400DD68 RID: 56680
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400DD69 RID: 56681
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400DD6A RID: 56682
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400DD6B RID: 56683
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400DD6C RID: 56684
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400DD6D RID: 56685
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400DD6E RID: 56686
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400DD6F RID: 56687
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400DD70 RID: 56688
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400DD71 RID: 56689
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400DD72 RID: 56690
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400DD73 RID: 56691
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400DD74 RID: 56692
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400DD75 RID: 56693
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400DD76 RID: 56694
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400DD77 RID: 56695
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0400DD78 RID: 56696
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0400DD79 RID: 56697
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0400DD7A RID: 56698
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0400DD7B RID: 56699
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0400DD7C RID: 56700
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0400DD7D RID: 56701
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0400DD7E RID: 56702
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0400DD7F RID: 56703
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0400DD80 RID: 56704
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0400DD81 RID: 56705
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x0400DD82 RID: 56706
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x0400DD83 RID: 56707
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x0400DD84 RID: 56708
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x0400DD85 RID: 56709
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x0400DD86 RID: 56710
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x0400DD87 RID: 56711
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x0400DD88 RID: 56712
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x0400DD89 RID: 56713
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x0400DD8A RID: 56714
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x0400DD8B RID: 56715
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x0400DD8C RID: 56716
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x0400DD8D RID: 56717
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x0400DD8E RID: 56718
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x0400DD8F RID: 56719
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x0400DD90 RID: 56720
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x0400DD91 RID: 56721
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x0400DD92 RID: 56722
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x0400DD93 RID: 56723
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x0400DD94 RID: 56724
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x0400DD95 RID: 56725
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x0400DD96 RID: 56726
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x0400DD97 RID: 56727
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x0400DD98 RID: 56728
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x0400DD99 RID: 56729
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x0400DD9A RID: 56730
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x0400DD9B RID: 56731
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x0400DD9C RID: 56732
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;
}
