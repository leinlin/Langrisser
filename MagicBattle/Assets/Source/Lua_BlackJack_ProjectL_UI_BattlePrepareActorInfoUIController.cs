using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Scene;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x020013AC RID: 5036
[Preserve]
public class Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController : LuaObject
{
	// Token: 0x0601BAD5 RID: 113365 RVA: 0x00870A20 File Offset: 0x0086EC20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Open(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			bool left;
			LuaObject.checkType(l, 2, out left);
			battlePrepareActorInfoUIController.Open(left);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BAD6 RID: 113366 RVA: 0x00870A78 File Offset: 0x0086EC78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Close(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			battlePrepareActorInfoUIController.Close();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BAD7 RID: 113367 RVA: 0x00870AC4 File Offset: 0x0086ECC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsOpened(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			bool b = battlePrepareActorInfoUIController.IsOpened();
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

	// Token: 0x0601BAD8 RID: 113368 RVA: 0x00870B18 File Offset: 0x0086ED18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetActorInfo(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			BattleHero hero;
			LuaObject.checkType<BattleHero>(l, 2, out hero);
			List<TrainingTech> techs;
			LuaObject.checkType<List<TrainingTech>>(l, 3, out techs);
			int team;
			LuaObject.checkType(l, 4, out team);
			bool isNpc;
			LuaObject.checkType(l, 5, out isNpc);
			bool canChangeSoldier;
			LuaObject.checkType(l, 6, out canChangeSoldier);
			ConfigDataSkillInfo extraTalentSkillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 7, out extraTalentSkillInfo);
			int heroHp;
			LuaObject.checkType(l, 8, out heroHp);
			int soldierHp;
			LuaObject.checkType(l, 9, out soldierHp);
			battlePrepareActorInfoUIController.SetActorInfo(hero, techs, team, isNpc, canChangeSoldier, extraTalentSkillInfo, heroHp, soldierHp);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BAD9 RID: 113369 RVA: 0x00870BC8 File Offset: 0x0086EDC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetHeroId(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			int heroId = battlePrepareActorInfoUIController.GetHeroId();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BADA RID: 113370 RVA: 0x00870C1C File Offset: 0x0086EE1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetTeam(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			int team = battlePrepareActorInfoUIController.GetTeam();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, team);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BADB RID: 113371 RVA: 0x00870C70 File Offset: 0x0086EE70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanChangeSoldier(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			bool b = battlePrepareActorInfoUIController.CanChangeSoldier();
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

	// Token: 0x0601BADC RID: 113372 RVA: 0x00870CC4 File Offset: 0x0086EEC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetSkills(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			battlePrepareActorInfoUIController.SetSkills();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BADD RID: 113373 RVA: 0x00870D10 File Offset: 0x0086EF10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetSoldier(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			battlePrepareActorInfoUIController.SetSoldier();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BADE RID: 113374 RVA: 0x00870D5C File Offset: 0x0086EF5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowSelectSoldierPanel(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			battlePrepareActorInfoUIController.ShowSelectSoldierPanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BADF RID: 113375 RVA: 0x00870DA8 File Offset: 0x0086EFA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetSoliderSelectButtonRectTransform(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			int index;
			LuaObject.checkType(l, 2, out index);
			RectTransform soliderSelectButtonRectTransform = battlePrepareActorInfoUIController.GetSoliderSelectButtonRectTransform(index);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, soliderSelectButtonRectTransform);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BAE0 RID: 113376 RVA: 0x00870E0C File Offset: 0x0086F00C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SelectSolider(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			int index;
			LuaObject.checkType(l, 2, out index);
			battlePrepareActorInfoUIController.SelectSolider(index);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BAE1 RID: 113377 RVA: 0x00870E64 File Offset: 0x0086F064
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			battlePrepareActorInfoUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BAE2 RID: 113378 RVA: 0x00870EB8 File Offset: 0x0086F0B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnDisable(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			battlePrepareActorInfoUIController.m_luaExportHelper.OnDisable();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BAE3 RID: 113379 RVA: 0x00870F0C File Offset: 0x0086F10C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetSkillsAndTalentList(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			battlePrepareActorInfoUIController.m_luaExportHelper.SetSkillsAndTalentList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BAE4 RID: 113380 RVA: 0x00870F60 File Offset: 0x0086F160
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowSelectSkillPanel(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			battlePrepareActorInfoUIController.m_luaExportHelper.ShowSelectSkillPanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BAE5 RID: 113381 RVA: 0x00870FB4 File Offset: 0x0086F1B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CloseSelectSkillPanel(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			battlePrepareActorInfoUIController.m_luaExportHelper.CloseSelectSkillPanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BAE6 RID: 113382 RVA: 0x00871008 File Offset: 0x0086F208
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnSkillItemClick(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			HeroSkillItemUIController skillCtrl;
			LuaObject.checkType<HeroSkillItemUIController>(l, 2, out skillCtrl);
			battlePrepareActorInfoUIController.m_luaExportHelper.OnSkillItemClick(skillCtrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BAE7 RID: 113383 RVA: 0x00871064 File Offset: 0x0086F264
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnConfirmSelectSkillsButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			battlePrepareActorInfoUIController.m_luaExportHelper.OnConfirmSelectSkillsButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BAE8 RID: 113384 RVA: 0x008710B8 File Offset: 0x0086F2B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetCostFromSkillList(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			List<int> skillIds;
			LuaObject.checkType<List<int>>(l, 2, out skillIds);
			int costFromSkillList = battlePrepareActorInfoUIController.m_luaExportHelper.GetCostFromSkillList(skillIds);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, costFromSkillList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BAE9 RID: 113385 RVA: 0x00871120 File Offset: 0x0086F320
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetSoldierDetailPanel(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			battlePrepareActorInfoUIController.m_luaExportHelper.SetSoldierDetailPanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BAEA RID: 113386 RVA: 0x00871174 File Offset: 0x0086F374
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CloseSelectSoldierPanel(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			battlePrepareActorInfoUIController.m_luaExportHelper.CloseSelectSoldierPanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BAEB RID: 113387 RVA: 0x008711C8 File Offset: 0x0086F3C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnSoldierDetailSelectButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			BattleSoldierItemUIController ctrl;
			LuaObject.checkType<BattleSoldierItemUIController>(l, 2, out ctrl);
			battlePrepareActorInfoUIController.m_luaExportHelper.OnSoldierDetailSelectButtonClick(ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BAEC RID: 113388 RVA: 0x00871224 File Offset: 0x0086F424
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnSoldierItemClick(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			BattleSoldierItemUIController ctrl;
			LuaObject.checkType<BattleSoldierItemUIController>(l, 2, out ctrl);
			battlePrepareActorInfoUIController.m_luaExportHelper.OnSoldierItemClick(ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BAED RID: 113389 RVA: 0x00871280 File Offset: 0x0086F480
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CalcPropAddValue(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			int v;
			LuaObject.checkType(l, 2, out v);
			int v2;
			LuaObject.checkType(l, 3, out v2);
			string s = battlePrepareActorInfoUIController.m_luaExportHelper.CalcPropAddValue(v, v2);
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

	// Token: 0x0601BAEE RID: 113390 RVA: 0x008712F4 File Offset: 0x0086F4F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetPropLevelItemImg(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			Image img;
			LuaObject.checkType<Image>(l, 2, out img);
			char level;
			LuaObject.checkType(l, 3, out level);
			battlePrepareActorInfoUIController.m_luaExportHelper.SetPropLevelItemImg(img, level);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BAEF RID: 113391 RVA: 0x00871360 File Offset: 0x0086F560
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateSpineGraphic(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			float scale;
			LuaObject.checkType(l, 3, out scale);
			Vector2 offset;
			LuaObject.checkType(l, 4, out offset);
			GameObject parent;
			LuaObject.checkType<GameObject>(l, 5, out parent);
			List<ReplaceAnim> replaceAnims;
			LuaObject.checkType<List<ReplaceAnim>>(l, 6, out replaceAnims);
			UISpineGraphic o = battlePrepareActorInfoUIController.m_luaExportHelper.CreateSpineGraphic(assetName, scale, offset, parent, replaceAnims);
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

	// Token: 0x0601BAF0 RID: 113392 RVA: 0x008713FC File Offset: 0x0086F5FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DestroySpineGraphic(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			UISpineGraphic g;
			LuaObject.checkType<UISpineGraphic>(l, 2, out g);
			battlePrepareActorInfoUIController.m_luaExportHelper.DestroySpineGraphic(g);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BAF1 RID: 113393 RVA: 0x00871458 File Offset: 0x0086F658
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnChangeSkillButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			battlePrepareActorInfoUIController.m_luaExportHelper.OnChangeSkillButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BAF2 RID: 113394 RVA: 0x008714AC File Offset: 0x0086F6AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnChangeSoldierButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			battlePrepareActorInfoUIController.m_luaExportHelper.OnChangeSoldierButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BAF3 RID: 113395 RVA: 0x00871500 File Offset: 0x0086F700
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			battlePrepareActorInfoUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BAF4 RID: 113396 RVA: 0x0087156C File Offset: 0x0086F76C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			battlePrepareActorInfoUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BAF5 RID: 113397 RVA: 0x008715C0 File Offset: 0x0086F7C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			battlePrepareActorInfoUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BAF6 RID: 113398 RVA: 0x00871614 File Offset: 0x0086F814
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = battlePrepareActorInfoUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601BAF7 RID: 113399 RVA: 0x008716BC File Offset: 0x0086F8BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			battlePrepareActorInfoUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BAF8 RID: 113400 RVA: 0x00871710 File Offset: 0x0086F910
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			battlePrepareActorInfoUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BAF9 RID: 113401 RVA: 0x0087177C File Offset: 0x0086F97C
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
				BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				battlePrepareActorInfoUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				BattlePrepareActorInfoUIController battlePrepareActorInfoUIController2 = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				battlePrepareActorInfoUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601BAFA RID: 113402 RVA: 0x0087188C File Offset: 0x0086FA8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			battlePrepareActorInfoUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BAFB RID: 113403 RVA: 0x008718F8 File Offset: 0x0086FAF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			battlePrepareActorInfoUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BAFC RID: 113404 RVA: 0x00871964 File Offset: 0x0086FB64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			battlePrepareActorInfoUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BAFD RID: 113405 RVA: 0x008719D0 File Offset: 0x0086FBD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			battlePrepareActorInfoUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BAFE RID: 113406 RVA: 0x00871A3C File Offset: 0x0086FC3C
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
				BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				battlePrepareActorInfoUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				BattlePrepareActorInfoUIController battlePrepareActorInfoUIController2 = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				battlePrepareActorInfoUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601BAFF RID: 113407 RVA: 0x00871B4C File Offset: 0x0086FD4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			string s = battlePrepareActorInfoUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601BB00 RID: 113408 RVA: 0x00871BA8 File Offset: 0x0086FDA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnShowSelectSoldierPanel(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			BattleHero obj;
			LuaObject.checkType<BattleHero>(l, 2, out obj);
			battlePrepareActorInfoUIController.m_luaExportHelper.__callDele_EventOnShowSelectSoldierPanel(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB01 RID: 113409 RVA: 0x00871C04 File Offset: 0x0086FE04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnShowSelectSoldierPanel(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			BattleHero obj;
			LuaObject.checkType<BattleHero>(l, 2, out obj);
			battlePrepareActorInfoUIController.m_luaExportHelper.__clearDele_EventOnShowSelectSoldierPanel(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB02 RID: 113410 RVA: 0x00871C60 File Offset: 0x0086FE60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnChangeSkill(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			BattleHero arg;
			LuaObject.checkType<BattleHero>(l, 2, out arg);
			List<int> arg2;
			LuaObject.checkType<List<int>>(l, 3, out arg2);
			battlePrepareActorInfoUIController.m_luaExportHelper.__callDele_EventOnChangeSkill(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB03 RID: 113411 RVA: 0x00871CCC File Offset: 0x0086FECC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnChangeSkill(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			BattleHero arg;
			LuaObject.checkType<BattleHero>(l, 2, out arg);
			List<int> arg2;
			LuaObject.checkType<List<int>>(l, 3, out arg2);
			battlePrepareActorInfoUIController.m_luaExportHelper.__clearDele_EventOnChangeSkill(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB04 RID: 113412 RVA: 0x00871D38 File Offset: 0x0086FF38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnChangeSoldier(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			BattleHero arg;
			LuaObject.checkType<BattleHero>(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			battlePrepareActorInfoUIController.m_luaExportHelper.__callDele_EventOnChangeSoldier(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB05 RID: 113413 RVA: 0x00871DA4 File Offset: 0x0086FFA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnChangeSoldier(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			BattleHero arg;
			LuaObject.checkType<BattleHero>(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			battlePrepareActorInfoUIController.m_luaExportHelper.__clearDele_EventOnChangeSoldier(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB06 RID: 113414 RVA: 0x00871E10 File Offset: 0x00870010
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnShowSelectSoldierPanel(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			Action<BattleHero> value;
			int num = LuaObject.checkDelegate<Action<BattleHero>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					battlePrepareActorInfoUIController.EventOnShowSelectSoldierPanel += value;
				}
				else if (num == 2)
				{
					battlePrepareActorInfoUIController.EventOnShowSelectSoldierPanel -= value;
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

	// Token: 0x0601BB07 RID: 113415 RVA: 0x00871E90 File Offset: 0x00870090
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnChangeSkill(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			Action<BattleHero, List<int>> value;
			int num = LuaObject.checkDelegate<Action<BattleHero, List<int>>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					battlePrepareActorInfoUIController.EventOnChangeSkill += value;
				}
				else if (num == 2)
				{
					battlePrepareActorInfoUIController.EventOnChangeSkill -= value;
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

	// Token: 0x0601BB08 RID: 113416 RVA: 0x00871F10 File Offset: 0x00870110
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnChangeSoldier(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			Action<BattleHero, int> value;
			int num = LuaObject.checkDelegate<Action<BattleHero, int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					battlePrepareActorInfoUIController.EventOnChangeSoldier += value;
				}
				else if (num == 2)
				{
					battlePrepareActorInfoUIController.EventOnChangeSoldier -= value;
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

	// Token: 0x0601BB09 RID: 113417 RVA: 0x00871F90 File Offset: 0x00870190
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareActorInfoUIController.m_luaExportHelper.m_heroGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB0A RID: 113418 RVA: 0x00871FE8 File Offset: 0x008701E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			GameObject heroGameObject;
			LuaObject.checkType<GameObject>(l, 2, out heroGameObject);
			battlePrepareActorInfoUIController.m_luaExportHelper.m_heroGameObject = heroGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB0B RID: 113419 RVA: 0x00872044 File Offset: 0x00870244
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroNameText(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareActorInfoUIController.m_luaExportHelper.m_heroNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB0C RID: 113420 RVA: 0x0087209C File Offset: 0x0087029C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroNameText(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			Text heroNameText;
			LuaObject.checkType<Text>(l, 2, out heroNameText);
			battlePrepareActorInfoUIController.m_luaExportHelper.m_heroNameText = heroNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB0D RID: 113421 RVA: 0x008720F8 File Offset: 0x008702F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroArmyIcon(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareActorInfoUIController.m_luaExportHelper.m_heroArmyIcon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB0E RID: 113422 RVA: 0x00872150 File Offset: 0x00870350
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroArmyIcon(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			Image heroArmyIcon;
			LuaObject.checkType<Image>(l, 2, out heroArmyIcon);
			battlePrepareActorInfoUIController.m_luaExportHelper.m_heroArmyIcon = heroArmyIcon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB0F RID: 113423 RVA: 0x008721AC File Offset: 0x008703AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroJobText(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareActorInfoUIController.m_luaExportHelper.m_heroJobText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB10 RID: 113424 RVA: 0x00872204 File Offset: 0x00870404
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroJobText(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			Text heroJobText;
			LuaObject.checkType<Text>(l, 2, out heroJobText);
			battlePrepareActorInfoUIController.m_luaExportHelper.m_heroJobText = heroJobText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB11 RID: 113425 RVA: 0x00872260 File Offset: 0x00870460
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroLevelText(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareActorInfoUIController.m_luaExportHelper.m_heroLevelText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB12 RID: 113426 RVA: 0x008722B8 File Offset: 0x008704B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroLevelText(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			Text heroLevelText;
			LuaObject.checkType<Text>(l, 2, out heroLevelText);
			battlePrepareActorInfoUIController.m_luaExportHelper.m_heroLevelText = heroLevelText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB13 RID: 113427 RVA: 0x00872314 File Offset: 0x00870514
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroRangeText(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareActorInfoUIController.m_luaExportHelper.m_heroRangeText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB14 RID: 113428 RVA: 0x0087236C File Offset: 0x0087056C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroRangeText(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			Text heroRangeText;
			LuaObject.checkType<Text>(l, 2, out heroRangeText);
			battlePrepareActorInfoUIController.m_luaExportHelper.m_heroRangeText = heroRangeText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB15 RID: 113429 RVA: 0x008723C8 File Offset: 0x008705C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroMoveText(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareActorInfoUIController.m_luaExportHelper.m_heroMoveText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB16 RID: 113430 RVA: 0x00872420 File Offset: 0x00870620
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroMoveText(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			Text heroMoveText;
			LuaObject.checkType<Text>(l, 2, out heroMoveText);
			battlePrepareActorInfoUIController.m_luaExportHelper.m_heroMoveText = heroMoveText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB17 RID: 113431 RVA: 0x0087247C File Offset: 0x0087067C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroPanelGroupCtrl(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareActorInfoUIController.m_luaExportHelper.m_heroPanelGroupCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB18 RID: 113432 RVA: 0x008724D4 File Offset: 0x008706D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroPanelGroupCtrl(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			CommonUIStateController heroPanelGroupCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out heroPanelGroupCtrl);
			battlePrepareActorInfoUIController.m_luaExportHelper.m_heroPanelGroupCtrl = heroPanelGroupCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB19 RID: 113433 RVA: 0x00872530 File Offset: 0x00870730
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroIcon(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareActorInfoUIController.m_luaExportHelper.m_heroIcon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB1A RID: 113434 RVA: 0x00872588 File Offset: 0x00870788
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroIcon(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			Image heroIcon;
			LuaObject.checkType<Image>(l, 2, out heroIcon);
			battlePrepareActorInfoUIController.m_luaExportHelper.m_heroIcon = heroIcon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB1B RID: 113435 RVA: 0x008725E4 File Offset: 0x008707E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroHPText(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareActorInfoUIController.m_luaExportHelper.m_heroHPText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB1C RID: 113436 RVA: 0x0087263C File Offset: 0x0087083C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroHPText(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			Text heroHPText;
			LuaObject.checkType<Text>(l, 2, out heroHPText);
			battlePrepareActorInfoUIController.m_luaExportHelper.m_heroHPText = heroHPText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB1D RID: 113437 RVA: 0x00872698 File Offset: 0x00870898
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroHPImage(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareActorInfoUIController.m_luaExportHelper.m_heroHPImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB1E RID: 113438 RVA: 0x008726F0 File Offset: 0x008708F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroHPImage(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			Image heroHPImage;
			LuaObject.checkType<Image>(l, 2, out heroHPImage);
			battlePrepareActorInfoUIController.m_luaExportHelper.m_heroHPImage = heroHPImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB1F RID: 113439 RVA: 0x0087274C File Offset: 0x0087094C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroDEXText(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareActorInfoUIController.m_luaExportHelper.m_heroDEXText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB20 RID: 113440 RVA: 0x008727A4 File Offset: 0x008709A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroDEXText(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			Text heroDEXText;
			LuaObject.checkType<Text>(l, 2, out heroDEXText);
			battlePrepareActorInfoUIController.m_luaExportHelper.m_heroDEXText = heroDEXText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB21 RID: 113441 RVA: 0x00872800 File Offset: 0x00870A00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroAttackText(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareActorInfoUIController.m_luaExportHelper.m_heroAttackText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB22 RID: 113442 RVA: 0x00872858 File Offset: 0x00870A58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroAttackText(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			Text heroAttackText;
			LuaObject.checkType<Text>(l, 2, out heroAttackText);
			battlePrepareActorInfoUIController.m_luaExportHelper.m_heroAttackText = heroAttackText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB23 RID: 113443 RVA: 0x008728B4 File Offset: 0x00870AB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroDefenseText(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareActorInfoUIController.m_luaExportHelper.m_heroDefenseText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB24 RID: 113444 RVA: 0x0087290C File Offset: 0x00870B0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroDefenseText(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			Text heroDefenseText;
			LuaObject.checkType<Text>(l, 2, out heroDefenseText);
			battlePrepareActorInfoUIController.m_luaExportHelper.m_heroDefenseText = heroDefenseText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB25 RID: 113445 RVA: 0x00872968 File Offset: 0x00870B68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroMagicText(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareActorInfoUIController.m_luaExportHelper.m_heroMagicText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB26 RID: 113446 RVA: 0x008729C0 File Offset: 0x00870BC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroMagicText(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			Text heroMagicText;
			LuaObject.checkType<Text>(l, 2, out heroMagicText);
			battlePrepareActorInfoUIController.m_luaExportHelper.m_heroMagicText = heroMagicText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB27 RID: 113447 RVA: 0x00872A1C File Offset: 0x00870C1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroMagicDefenseText(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareActorInfoUIController.m_luaExportHelper.m_heroMagicDefenseText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB28 RID: 113448 RVA: 0x00872A74 File Offset: 0x00870C74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroMagicDefenseText(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			Text heroMagicDefenseText;
			LuaObject.checkType<Text>(l, 2, out heroMagicDefenseText);
			battlePrepareActorInfoUIController.m_luaExportHelper.m_heroMagicDefenseText = heroMagicDefenseText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB29 RID: 113449 RVA: 0x00872AD0 File Offset: 0x00870CD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroSkillInfoButton(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareActorInfoUIController.m_luaExportHelper.m_heroSkillInfoButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB2A RID: 113450 RVA: 0x00872B28 File Offset: 0x00870D28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroSkillInfoButton(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			Button heroSkillInfoButton;
			LuaObject.checkType<Button>(l, 2, out heroSkillInfoButton);
			battlePrepareActorInfoUIController.m_luaExportHelper.m_heroSkillInfoButton = heroSkillInfoButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB2B RID: 113451 RVA: 0x00872B84 File Offset: 0x00870D84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillInfoGroupTalentSkillImage(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareActorInfoUIController.m_luaExportHelper.m_skillInfoGroupTalentSkillImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB2C RID: 113452 RVA: 0x00872BDC File Offset: 0x00870DDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillInfoGroupTalentSkillImage(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			Image skillInfoGroupTalentSkillImage;
			LuaObject.checkType<Image>(l, 2, out skillInfoGroupTalentSkillImage);
			battlePrepareActorInfoUIController.m_luaExportHelper.m_skillInfoGroupTalentSkillImage = skillInfoGroupTalentSkillImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB2D RID: 113453 RVA: 0x00872C38 File Offset: 0x00870E38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillInfoGroupSkillGo(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareActorInfoUIController.m_luaExportHelper.m_skillInfoGroupSkillGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB2E RID: 113454 RVA: 0x00872C90 File Offset: 0x00870E90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillInfoGroupSkillGo(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			GameObject skillInfoGroupSkillGo;
			LuaObject.checkType<GameObject>(l, 2, out skillInfoGroupSkillGo);
			battlePrepareActorInfoUIController.m_luaExportHelper.m_skillInfoGroupSkillGo = skillInfoGroupSkillGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB2F RID: 113455 RVA: 0x00872CEC File Offset: 0x00870EEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillInfoGroupSkillGo2(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareActorInfoUIController.m_luaExportHelper.m_skillInfoGroupSkillGo2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB30 RID: 113456 RVA: 0x00872D44 File Offset: 0x00870F44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillInfoGroupSkillGo2(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			GameObject skillInfoGroupSkillGo;
			LuaObject.checkType<GameObject>(l, 2, out skillInfoGroupSkillGo);
			battlePrepareActorInfoUIController.m_luaExportHelper.m_skillInfoGroupSkillGo2 = skillInfoGroupSkillGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB31 RID: 113457 RVA: 0x00872DA0 File Offset: 0x00870FA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillInfoGroupSkillGo3(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareActorInfoUIController.m_luaExportHelper.m_skillInfoGroupSkillGo3);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB32 RID: 113458 RVA: 0x00872DF8 File Offset: 0x00870FF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillInfoGroupSkillGo3(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			GameObject skillInfoGroupSkillGo;
			LuaObject.checkType<GameObject>(l, 2, out skillInfoGroupSkillGo);
			battlePrepareActorInfoUIController.m_luaExportHelper.m_skillInfoGroupSkillGo3 = skillInfoGroupSkillGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB33 RID: 113459 RVA: 0x00872E54 File Offset: 0x00871054
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillChangeButton(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareActorInfoUIController.m_luaExportHelper.m_skillChangeButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB34 RID: 113460 RVA: 0x00872EAC File Offset: 0x008710AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillChangeButton(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			Button skillChangeButton;
			LuaObject.checkType<Button>(l, 2, out skillChangeButton);
			battlePrepareActorInfoUIController.m_luaExportHelper.m_skillChangeButton = skillChangeButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB35 RID: 113461 RVA: 0x00872F08 File Offset: 0x00871108
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_selectSkillPanelGo(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareActorInfoUIController.m_luaExportHelper.m_selectSkillPanelGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB36 RID: 113462 RVA: 0x00872F60 File Offset: 0x00871160
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_selectSkillPanelGo(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			GameObject selectSkillPanelGo;
			LuaObject.checkType<GameObject>(l, 2, out selectSkillPanelGo);
			battlePrepareActorInfoUIController.m_luaExportHelper.m_selectSkillPanelGo = selectSkillPanelGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB37 RID: 113463 RVA: 0x00872FBC File Offset: 0x008711BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_allSkillsContent(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareActorInfoUIController.m_luaExportHelper.m_allSkillsContent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB38 RID: 113464 RVA: 0x00873014 File Offset: 0x00871214
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_allSkillsContent(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			GameObject allSkillsContent;
			LuaObject.checkType<GameObject>(l, 2, out allSkillsContent);
			battlePrepareActorInfoUIController.m_luaExportHelper.m_allSkillsContent = allSkillsContent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB39 RID: 113465 RVA: 0x00873070 File Offset: 0x00871270
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_selectSkillsContent(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareActorInfoUIController.m_luaExportHelper.m_selectSkillsContent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB3A RID: 113466 RVA: 0x008730C8 File Offset: 0x008712C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_selectSkillsContent(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			GameObject selectSkillsContent;
			LuaObject.checkType<GameObject>(l, 2, out selectSkillsContent);
			battlePrepareActorInfoUIController.m_luaExportHelper.m_selectSkillsContent = selectSkillsContent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB3B RID: 113467 RVA: 0x00873124 File Offset: 0x00871324
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_selectSkillsCost(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareActorInfoUIController.m_luaExportHelper.m_selectSkillsCost);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB3C RID: 113468 RVA: 0x0087317C File Offset: 0x0087137C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_selectSkillsCost(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			GameObject selectSkillsCost;
			LuaObject.checkType<GameObject>(l, 2, out selectSkillsCost);
			battlePrepareActorInfoUIController.m_luaExportHelper.m_selectSkillsCost = selectSkillsCost;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB3D RID: 113469 RVA: 0x008731D8 File Offset: 0x008713D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_closeSelectSkillButton(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareActorInfoUIController.m_luaExportHelper.m_closeSelectSkillButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB3E RID: 113470 RVA: 0x00873230 File Offset: 0x00871430
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_closeSelectSkillButton(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			Button closeSelectSkillButton;
			LuaObject.checkType<Button>(l, 2, out closeSelectSkillButton);
			battlePrepareActorInfoUIController.m_luaExportHelper.m_closeSelectSkillButton = closeSelectSkillButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB3F RID: 113471 RVA: 0x0087328C File Offset: 0x0087148C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_selectSkillConfirmButton(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareActorInfoUIController.m_luaExportHelper.m_selectSkillConfirmButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB40 RID: 113472 RVA: 0x008732E4 File Offset: 0x008714E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_selectSkillConfirmButton(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			Button selectSkillConfirmButton;
			LuaObject.checkType<Button>(l, 2, out selectSkillConfirmButton);
			battlePrepareActorInfoUIController.m_luaExportHelper.m_selectSkillConfirmButton = selectSkillConfirmButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB41 RID: 113473 RVA: 0x00873340 File Offset: 0x00871540
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillDetailObj(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareActorInfoUIController.m_luaExportHelper.m_skillDetailObj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB42 RID: 113474 RVA: 0x00873398 File Offset: 0x00871598
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillDetailObj(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			GameObject skillDetailObj;
			LuaObject.checkType<GameObject>(l, 2, out skillDetailObj);
			battlePrepareActorInfoUIController.m_luaExportHelper.m_skillDetailObj = skillDetailObj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB43 RID: 113475 RVA: 0x008733F4 File Offset: 0x008715F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillDetailListObj(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareActorInfoUIController.m_luaExportHelper.m_skillDetailListObj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB44 RID: 113476 RVA: 0x0087344C File Offset: 0x0087164C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillDetailListObj(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			GameObject skillDetailListObj;
			LuaObject.checkType<GameObject>(l, 2, out skillDetailListObj);
			battlePrepareActorInfoUIController.m_luaExportHelper.m_skillDetailListObj = skillDetailListObj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB45 RID: 113477 RVA: 0x008734A8 File Offset: 0x008716A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillListContentTalentObj(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareActorInfoUIController.m_luaExportHelper.m_skillListContentTalentObj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB46 RID: 113478 RVA: 0x00873500 File Offset: 0x00871700
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillListContentTalentObj(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			GameObject skillListContentTalentObj;
			LuaObject.checkType<GameObject>(l, 2, out skillListContentTalentObj);
			battlePrepareActorInfoUIController.m_luaExportHelper.m_skillListContentTalentObj = skillListContentTalentObj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB47 RID: 113479 RVA: 0x0087355C File Offset: 0x0087175C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillListContentTalentIcon(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareActorInfoUIController.m_luaExportHelper.m_skillListContentTalentIcon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB48 RID: 113480 RVA: 0x008735B4 File Offset: 0x008717B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillListContentTalentIcon(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			Image skillListContentTalentIcon;
			LuaObject.checkType<Image>(l, 2, out skillListContentTalentIcon);
			battlePrepareActorInfoUIController.m_luaExportHelper.m_skillListContentTalentIcon = skillListContentTalentIcon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB49 RID: 113481 RVA: 0x00873610 File Offset: 0x00871810
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillListContentTalentNameText(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareActorInfoUIController.m_luaExportHelper.m_skillListContentTalentNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB4A RID: 113482 RVA: 0x00873668 File Offset: 0x00871868
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillListContentTalentNameText(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			Text skillListContentTalentNameText;
			LuaObject.checkType<Text>(l, 2, out skillListContentTalentNameText);
			battlePrepareActorInfoUIController.m_luaExportHelper.m_skillListContentTalentNameText = skillListContentTalentNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB4B RID: 113483 RVA: 0x008736C4 File Offset: 0x008718C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillListContentTalentDescText(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareActorInfoUIController.m_luaExportHelper.m_skillListContentTalentDescText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB4C RID: 113484 RVA: 0x0087371C File Offset: 0x0087191C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillListContentTalentDescText(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			Text skillListContentTalentDescText;
			LuaObject.checkType<Text>(l, 2, out skillListContentTalentDescText);
			battlePrepareActorInfoUIController.m_luaExportHelper.m_skillListContentTalentDescText = skillListContentTalentDescText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB4D RID: 113485 RVA: 0x00873778 File Offset: 0x00871978
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillListContentLineImage(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareActorInfoUIController.m_luaExportHelper.m_skillListContentLineImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB4E RID: 113486 RVA: 0x008737D0 File Offset: 0x008719D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillListContentLineImage(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			Image skillListContentLineImage;
			LuaObject.checkType<Image>(l, 2, out skillListContentLineImage);
			battlePrepareActorInfoUIController.m_luaExportHelper.m_skillListContentLineImage = skillListContentLineImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB4F RID: 113487 RVA: 0x0087382C File Offset: 0x00871A2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillListContentListObj(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareActorInfoUIController.m_luaExportHelper.m_skillListContentListObj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB50 RID: 113488 RVA: 0x00873884 File Offset: 0x00871A84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillListContentListObj(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			GameObject skillListContentListObj;
			LuaObject.checkType<GameObject>(l, 2, out skillListContentListObj);
			battlePrepareActorInfoUIController.m_luaExportHelper.m_skillListContentListObj = skillListContentListObj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB51 RID: 113489 RVA: 0x008738E0 File Offset: 0x00871AE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillListContentObj(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareActorInfoUIController.m_luaExportHelper.m_skillListContentObj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB52 RID: 113490 RVA: 0x00873938 File Offset: 0x00871B38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillListContentObj(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			GameObject skillListContentObj;
			LuaObject.checkType<GameObject>(l, 2, out skillListContentObj);
			battlePrepareActorInfoUIController.m_luaExportHelper.m_skillListContentObj = skillListContentObj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB53 RID: 113491 RVA: 0x00873994 File Offset: 0x00871B94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillListNoSkillsObj(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareActorInfoUIController.m_luaExportHelper.m_skillListNoSkillsObj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB54 RID: 113492 RVA: 0x008739EC File Offset: 0x00871BEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillListNoSkillsObj(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			GameObject skillListNoSkillsObj;
			LuaObject.checkType<GameObject>(l, 2, out skillListNoSkillsObj);
			battlePrepareActorInfoUIController.m_luaExportHelper.m_skillListNoSkillsObj = skillListNoSkillsObj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB55 RID: 113493 RVA: 0x00873A48 File Offset: 0x00871C48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillDescPrefabObj(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareActorInfoUIController.m_luaExportHelper.m_skillDescPrefabObj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB56 RID: 113494 RVA: 0x00873AA0 File Offset: 0x00871CA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillDescPrefabObj(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			GameObject skillDescPrefabObj;
			LuaObject.checkType<GameObject>(l, 2, out skillDescPrefabObj);
			battlePrepareActorInfoUIController.m_luaExportHelper.m_skillDescPrefabObj = skillDescPrefabObj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB57 RID: 113495 RVA: 0x00873AFC File Offset: 0x00871CFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillItemDetailPanel(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareActorInfoUIController.m_luaExportHelper.m_skillItemDetailPanel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB58 RID: 113496 RVA: 0x00873B54 File Offset: 0x00871D54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillItemDetailPanel(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			GameObject skillItemDetailPanel;
			LuaObject.checkType<GameObject>(l, 2, out skillItemDetailPanel);
			battlePrepareActorInfoUIController.m_luaExportHelper.m_skillItemDetailPanel = skillItemDetailPanel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB59 RID: 113497 RVA: 0x00873BB0 File Offset: 0x00871DB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierGo(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareActorInfoUIController.m_luaExportHelper.m_soldierGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB5A RID: 113498 RVA: 0x00873C08 File Offset: 0x00871E08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierGo(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			GameObject soldierGo;
			LuaObject.checkType<GameObject>(l, 2, out soldierGo);
			battlePrepareActorInfoUIController.m_luaExportHelper.m_soldierGo = soldierGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB5B RID: 113499 RVA: 0x00873C64 File Offset: 0x00871E64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierChangeButton(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareActorInfoUIController.m_luaExportHelper.m_soldierChangeButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB5C RID: 113500 RVA: 0x00873CBC File Offset: 0x00871EBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierChangeButton(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			Button soldierChangeButton;
			LuaObject.checkType<Button>(l, 2, out soldierChangeButton);
			battlePrepareActorInfoUIController.m_luaExportHelper.m_soldierChangeButton = soldierChangeButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB5D RID: 113501 RVA: 0x00873D18 File Offset: 0x00871F18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_closeSelectSoldierButton(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareActorInfoUIController.m_luaExportHelper.m_closeSelectSoldierButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB5E RID: 113502 RVA: 0x00873D70 File Offset: 0x00871F70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_closeSelectSoldierButton(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			Button closeSelectSoldierButton;
			LuaObject.checkType<Button>(l, 2, out closeSelectSoldierButton);
			battlePrepareActorInfoUIController.m_luaExportHelper.m_closeSelectSoldierButton = closeSelectSoldierButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB5F RID: 113503 RVA: 0x00873DCC File Offset: 0x00871FCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_selectSoldierPanelUIStateController(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareActorInfoUIController.m_luaExportHelper.m_selectSoldierPanelUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB60 RID: 113504 RVA: 0x00873E24 File Offset: 0x00872024
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_selectSoldierPanelUIStateController(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			CommonUIStateController selectSoldierPanelUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out selectSoldierPanelUIStateController);
			battlePrepareActorInfoUIController.m_luaExportHelper.m_selectSoldierPanelUIStateController = selectSoldierPanelUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB61 RID: 113505 RVA: 0x00873E80 File Offset: 0x00872080
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldiersContent(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareActorInfoUIController.m_luaExportHelper.m_soldiersContent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB62 RID: 113506 RVA: 0x00873ED8 File Offset: 0x008720D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldiersContent(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			GameObject soldiersContent;
			LuaObject.checkType<GameObject>(l, 2, out soldiersContent);
			battlePrepareActorInfoUIController.m_luaExportHelper.m_soldiersContent = soldiersContent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB63 RID: 113507 RVA: 0x00873F34 File Offset: 0x00872134
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_selectSoldierDetailPanel(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareActorInfoUIController.m_luaExportHelper.m_selectSoldierDetailPanel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB64 RID: 113508 RVA: 0x00873F8C File Offset: 0x0087218C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_selectSoldierDetailPanel(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			GameObject selectSoldierDetailPanel;
			LuaObject.checkType<GameObject>(l, 2, out selectSoldierDetailPanel);
			battlePrepareActorInfoUIController.m_luaExportHelper.m_selectSoldierDetailPanel = selectSoldierDetailPanel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB65 RID: 113509 RVA: 0x00873FE8 File Offset: 0x008721E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierGraphicGo(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareActorInfoUIController.m_luaExportHelper.m_soldierGraphicGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB66 RID: 113510 RVA: 0x00874040 File Offset: 0x00872240
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierGraphicGo(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			GameObject soldierGraphicGo;
			LuaObject.checkType<GameObject>(l, 2, out soldierGraphicGo);
			battlePrepareActorInfoUIController.m_luaExportHelper.m_soldierGraphicGo = soldierGraphicGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB67 RID: 113511 RVA: 0x0087409C File Offset: 0x0087229C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierArmyTypeImg(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareActorInfoUIController.m_luaExportHelper.m_soldierArmyTypeImg);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB68 RID: 113512 RVA: 0x008740F4 File Offset: 0x008722F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierArmyTypeImg(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			Image soldierArmyTypeImg;
			LuaObject.checkType<Image>(l, 2, out soldierArmyTypeImg);
			battlePrepareActorInfoUIController.m_luaExportHelper.m_soldierArmyTypeImg = soldierArmyTypeImg;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB69 RID: 113513 RVA: 0x00874150 File Offset: 0x00872350
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierNameText(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareActorInfoUIController.m_luaExportHelper.m_soldierNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB6A RID: 113514 RVA: 0x008741A8 File Offset: 0x008723A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierNameText(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			Text soldierNameText;
			LuaObject.checkType<Text>(l, 2, out soldierNameText);
			battlePrepareActorInfoUIController.m_luaExportHelper.m_soldierNameText = soldierNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB6B RID: 113515 RVA: 0x00874204 File Offset: 0x00872404
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierInfoBtn(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareActorInfoUIController.m_luaExportHelper.m_soldierInfoBtn);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB6C RID: 113516 RVA: 0x0087425C File Offset: 0x0087245C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierInfoBtn(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			Button soldierInfoBtn;
			LuaObject.checkType<Button>(l, 2, out soldierInfoBtn);
			battlePrepareActorInfoUIController.m_luaExportHelper.m_soldierInfoBtn = soldierInfoBtn;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB6D RID: 113517 RVA: 0x008742B8 File Offset: 0x008724B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierPropHPText(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareActorInfoUIController.m_luaExportHelper.m_soldierPropHPText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB6E RID: 113518 RVA: 0x00874310 File Offset: 0x00872510
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierPropHPText(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			Text soldierPropHPText;
			LuaObject.checkType<Text>(l, 2, out soldierPropHPText);
			battlePrepareActorInfoUIController.m_luaExportHelper.m_soldierPropHPText = soldierPropHPText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB6F RID: 113519 RVA: 0x0087436C File Offset: 0x0087256C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierPropHPImage(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareActorInfoUIController.m_luaExportHelper.m_soldierPropHPImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB70 RID: 113520 RVA: 0x008743C4 File Offset: 0x008725C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierPropHPImage(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			Image soldierPropHPImage;
			LuaObject.checkType<Image>(l, 2, out soldierPropHPImage);
			battlePrepareActorInfoUIController.m_luaExportHelper.m_soldierPropHPImage = soldierPropHPImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB71 RID: 113521 RVA: 0x00874420 File Offset: 0x00872620
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierPropDFText(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareActorInfoUIController.m_luaExportHelper.m_soldierPropDFText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB72 RID: 113522 RVA: 0x00874478 File Offset: 0x00872678
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierPropDFText(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			Text soldierPropDFText;
			LuaObject.checkType<Text>(l, 2, out soldierPropDFText);
			battlePrepareActorInfoUIController.m_luaExportHelper.m_soldierPropDFText = soldierPropDFText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB73 RID: 113523 RVA: 0x008744D4 File Offset: 0x008726D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierPropATText(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareActorInfoUIController.m_luaExportHelper.m_soldierPropATText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB74 RID: 113524 RVA: 0x0087452C File Offset: 0x0087272C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierPropATText(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			Text soldierPropATText;
			LuaObject.checkType<Text>(l, 2, out soldierPropATText);
			battlePrepareActorInfoUIController.m_luaExportHelper.m_soldierPropATText = soldierPropATText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB75 RID: 113525 RVA: 0x00874588 File Offset: 0x00872788
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierMagicDFText(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareActorInfoUIController.m_luaExportHelper.m_soldierMagicDFText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB76 RID: 113526 RVA: 0x008745E0 File Offset: 0x008727E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierMagicDFText(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			Text soldierMagicDFText;
			LuaObject.checkType<Text>(l, 2, out soldierMagicDFText);
			battlePrepareActorInfoUIController.m_luaExportHelper.m_soldierMagicDFText = soldierMagicDFText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB77 RID: 113527 RVA: 0x0087463C File Offset: 0x0087283C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierDFAddText(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareActorInfoUIController.m_luaExportHelper.m_soldierDFAddText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB78 RID: 113528 RVA: 0x00874694 File Offset: 0x00872894
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierDFAddText(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			Text soldierDFAddText;
			LuaObject.checkType<Text>(l, 2, out soldierDFAddText);
			battlePrepareActorInfoUIController.m_luaExportHelper.m_soldierDFAddText = soldierDFAddText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB79 RID: 113529 RVA: 0x008746F0 File Offset: 0x008728F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierATAddText(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareActorInfoUIController.m_luaExportHelper.m_soldierATAddText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB7A RID: 113530 RVA: 0x00874748 File Offset: 0x00872948
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierATAddText(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			Text soldierATAddText;
			LuaObject.checkType<Text>(l, 2, out soldierATAddText);
			battlePrepareActorInfoUIController.m_luaExportHelper.m_soldierATAddText = soldierATAddText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB7B RID: 113531 RVA: 0x008747A4 File Offset: 0x008729A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierMagicDFAddText(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareActorInfoUIController.m_luaExportHelper.m_soldierMagicDFAddText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB7C RID: 113532 RVA: 0x008747FC File Offset: 0x008729FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierMagicDFAddText(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			Text soldierMagicDFAddText;
			LuaObject.checkType<Text>(l, 2, out soldierMagicDFAddText);
			battlePrepareActorInfoUIController.m_luaExportHelper.m_soldierMagicDFAddText = soldierMagicDFAddText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB7D RID: 113533 RVA: 0x00874858 File Offset: 0x00872A58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierDetailPanelUIStateController(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareActorInfoUIController.m_luaExportHelper.m_soldierDetailPanelUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB7E RID: 113534 RVA: 0x008748B0 File Offset: 0x00872AB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierDetailPanelUIStateController(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			CommonUIStateController soldierDetailPanelUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out soldierDetailPanelUIStateController);
			battlePrepareActorInfoUIController.m_luaExportHelper.m_soldierDetailPanelUIStateController = soldierDetailPanelUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB7F RID: 113535 RVA: 0x0087490C File Offset: 0x00872B0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierDetailIconImg(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareActorInfoUIController.m_luaExportHelper.m_soldierDetailIconImg);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB80 RID: 113536 RVA: 0x00874964 File Offset: 0x00872B64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierDetailIconImg(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			Image soldierDetailIconImg;
			LuaObject.checkType<Image>(l, 2, out soldierDetailIconImg);
			battlePrepareActorInfoUIController.m_luaExportHelper.m_soldierDetailIconImg = soldierDetailIconImg;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB81 RID: 113537 RVA: 0x008749C0 File Offset: 0x00872BC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierDetailGraphicGo(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareActorInfoUIController.m_luaExportHelper.m_soldierDetailGraphicGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB82 RID: 113538 RVA: 0x00874A18 File Offset: 0x00872C18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierDetailGraphicGo(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			GameObject soldierDetailGraphicGo;
			LuaObject.checkType<GameObject>(l, 2, out soldierDetailGraphicGo);
			battlePrepareActorInfoUIController.m_luaExportHelper.m_soldierDetailGraphicGo = soldierDetailGraphicGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB83 RID: 113539 RVA: 0x00874A74 File Offset: 0x00872C74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierDetailRangeText(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareActorInfoUIController.m_luaExportHelper.m_soldierDetailRangeText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB84 RID: 113540 RVA: 0x00874ACC File Offset: 0x00872CCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierDetailRangeText(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			Text soldierDetailRangeText;
			LuaObject.checkType<Text>(l, 2, out soldierDetailRangeText);
			battlePrepareActorInfoUIController.m_luaExportHelper.m_soldierDetailRangeText = soldierDetailRangeText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB85 RID: 113541 RVA: 0x00874B28 File Offset: 0x00872D28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierDetailMoveText(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareActorInfoUIController.m_luaExportHelper.m_soldierDetailMoveText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB86 RID: 113542 RVA: 0x00874B80 File Offset: 0x00872D80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierDetailMoveText(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			Text soldierDetailMoveText;
			LuaObject.checkType<Text>(l, 2, out soldierDetailMoveText);
			battlePrepareActorInfoUIController.m_luaExportHelper.m_soldierDetailMoveText = soldierDetailMoveText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB87 RID: 113543 RVA: 0x00874BDC File Offset: 0x00872DDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierDetailTypeBgImg(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareActorInfoUIController.m_luaExportHelper.m_soldierDetailTypeBgImg);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB88 RID: 113544 RVA: 0x00874C34 File Offset: 0x00872E34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierDetailTypeBgImg(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			Image soldierDetailTypeBgImg;
			LuaObject.checkType<Image>(l, 2, out soldierDetailTypeBgImg);
			battlePrepareActorInfoUIController.m_luaExportHelper.m_soldierDetailTypeBgImg = soldierDetailTypeBgImg;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB89 RID: 113545 RVA: 0x00874C90 File Offset: 0x00872E90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierDetailTypeBgImg2(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareActorInfoUIController.m_luaExportHelper.m_soldierDetailTypeBgImg2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB8A RID: 113546 RVA: 0x00874CE8 File Offset: 0x00872EE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierDetailTypeBgImg2(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			Image soldierDetailTypeBgImg;
			LuaObject.checkType<Image>(l, 2, out soldierDetailTypeBgImg);
			battlePrepareActorInfoUIController.m_luaExportHelper.m_soldierDetailTypeBgImg2 = soldierDetailTypeBgImg;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB8B RID: 113547 RVA: 0x00874D44 File Offset: 0x00872F44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierDetailTitleText(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareActorInfoUIController.m_luaExportHelper.m_soldierDetailTitleText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB8C RID: 113548 RVA: 0x00874D9C File Offset: 0x00872F9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierDetailTitleText(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			Text soldierDetailTitleText;
			LuaObject.checkType<Text>(l, 2, out soldierDetailTitleText);
			battlePrepareActorInfoUIController.m_luaExportHelper.m_soldierDetailTitleText = soldierDetailTitleText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB8D RID: 113549 RVA: 0x00874DF8 File Offset: 0x00872FF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierDetailDescText(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareActorInfoUIController.m_luaExportHelper.m_soldierDetailDescText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB8E RID: 113550 RVA: 0x00874E50 File Offset: 0x00873050
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierDetailDescText(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			Text soldierDetailDescText;
			LuaObject.checkType<Text>(l, 2, out soldierDetailDescText);
			battlePrepareActorInfoUIController.m_luaExportHelper.m_soldierDetailDescText = soldierDetailDescText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB8F RID: 113551 RVA: 0x00874EAC File Offset: 0x008730AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierDetailWeakText(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareActorInfoUIController.m_luaExportHelper.m_soldierDetailWeakText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB90 RID: 113552 RVA: 0x00874F04 File Offset: 0x00873104
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierDetailWeakText(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			Text soldierDetailWeakText;
			LuaObject.checkType<Text>(l, 2, out soldierDetailWeakText);
			battlePrepareActorInfoUIController.m_luaExportHelper.m_soldierDetailWeakText = soldierDetailWeakText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB91 RID: 113553 RVA: 0x00874F60 File Offset: 0x00873160
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierDetailStrongText(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareActorInfoUIController.m_luaExportHelper.m_soldierDetailStrongText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB92 RID: 113554 RVA: 0x00874FB8 File Offset: 0x008731B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierDetailStrongText(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			Text soldierDetailStrongText;
			LuaObject.checkType<Text>(l, 2, out soldierDetailStrongText);
			battlePrepareActorInfoUIController.m_luaExportHelper.m_soldierDetailStrongText = soldierDetailStrongText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB93 RID: 113555 RVA: 0x00875014 File Offset: 0x00873214
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierDetailHPText(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareActorInfoUIController.m_luaExportHelper.m_soldierDetailHPText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB94 RID: 113556 RVA: 0x0087506C File Offset: 0x0087326C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierDetailHPText(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			Text soldierDetailHPText;
			LuaObject.checkType<Text>(l, 2, out soldierDetailHPText);
			battlePrepareActorInfoUIController.m_luaExportHelper.m_soldierDetailHPText = soldierDetailHPText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB95 RID: 113557 RVA: 0x008750C8 File Offset: 0x008732C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierDetailDFText(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareActorInfoUIController.m_luaExportHelper.m_soldierDetailDFText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB96 RID: 113558 RVA: 0x00875120 File Offset: 0x00873320
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierDetailDFText(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			Text soldierDetailDFText;
			LuaObject.checkType<Text>(l, 2, out soldierDetailDFText);
			battlePrepareActorInfoUIController.m_luaExportHelper.m_soldierDetailDFText = soldierDetailDFText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB97 RID: 113559 RVA: 0x0087517C File Offset: 0x0087337C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierDetailATText(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareActorInfoUIController.m_luaExportHelper.m_soldierDetailATText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB98 RID: 113560 RVA: 0x008751D4 File Offset: 0x008733D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierDetailATText(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			Text soldierDetailATText;
			LuaObject.checkType<Text>(l, 2, out soldierDetailATText);
			battlePrepareActorInfoUIController.m_luaExportHelper.m_soldierDetailATText = soldierDetailATText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB99 RID: 113561 RVA: 0x00875230 File Offset: 0x00873430
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierDetailMagicDFText(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareActorInfoUIController.m_luaExportHelper.m_soldierDetailMagicDFText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB9A RID: 113562 RVA: 0x00875288 File Offset: 0x00873488
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierDetailMagicDFText(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			Text soldierDetailMagicDFText;
			LuaObject.checkType<Text>(l, 2, out soldierDetailMagicDFText);
			battlePrepareActorInfoUIController.m_luaExportHelper.m_soldierDetailMagicDFText = soldierDetailMagicDFText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB9B RID: 113563 RVA: 0x008752E4 File Offset: 0x008734E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierDetailHPAddText(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareActorInfoUIController.m_luaExportHelper.m_soldierDetailHPAddText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB9C RID: 113564 RVA: 0x0087533C File Offset: 0x0087353C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierDetailHPAddText(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			Text soldierDetailHPAddText;
			LuaObject.checkType<Text>(l, 2, out soldierDetailHPAddText);
			battlePrepareActorInfoUIController.m_luaExportHelper.m_soldierDetailHPAddText = soldierDetailHPAddText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB9D RID: 113565 RVA: 0x00875398 File Offset: 0x00873598
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierDetailDFAddText(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareActorInfoUIController.m_luaExportHelper.m_soldierDetailDFAddText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB9E RID: 113566 RVA: 0x008753F0 File Offset: 0x008735F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierDetailDFAddText(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			Text soldierDetailDFAddText;
			LuaObject.checkType<Text>(l, 2, out soldierDetailDFAddText);
			battlePrepareActorInfoUIController.m_luaExportHelper.m_soldierDetailDFAddText = soldierDetailDFAddText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BB9F RID: 113567 RVA: 0x0087544C File Offset: 0x0087364C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierDetailATAddText(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareActorInfoUIController.m_luaExportHelper.m_soldierDetailATAddText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BBA0 RID: 113568 RVA: 0x008754A4 File Offset: 0x008736A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierDetailATAddText(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			Text soldierDetailATAddText;
			LuaObject.checkType<Text>(l, 2, out soldierDetailATAddText);
			battlePrepareActorInfoUIController.m_luaExportHelper.m_soldierDetailATAddText = soldierDetailATAddText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BBA1 RID: 113569 RVA: 0x00875500 File Offset: 0x00873700
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierDetailMagicDFAddText(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareActorInfoUIController.m_luaExportHelper.m_soldierDetailMagicDFAddText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BBA2 RID: 113570 RVA: 0x00875558 File Offset: 0x00873758
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierDetailMagicDFAddText(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			Text soldierDetailMagicDFAddText;
			LuaObject.checkType<Text>(l, 2, out soldierDetailMagicDFAddText);
			battlePrepareActorInfoUIController.m_luaExportHelper.m_soldierDetailMagicDFAddText = soldierDetailMagicDFAddText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BBA3 RID: 113571 RVA: 0x008755B4 File Offset: 0x008737B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_hero(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareActorInfoUIController.m_luaExportHelper.m_hero);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BBA4 RID: 113572 RVA: 0x0087560C File Offset: 0x0087380C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_hero(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			BattleHero hero;
			LuaObject.checkType<BattleHero>(l, 2, out hero);
			battlePrepareActorInfoUIController.m_luaExportHelper.m_hero = hero;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BBA5 RID: 113573 RVA: 0x00875668 File Offset: 0x00873868
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_trainingTechs(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareActorInfoUIController.m_luaExportHelper.m_trainingTechs);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BBA6 RID: 113574 RVA: 0x008756C0 File Offset: 0x008738C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_trainingTechs(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			List<TrainingTech> trainingTechs;
			LuaObject.checkType<List<TrainingTech>>(l, 2, out trainingTechs);
			battlePrepareActorInfoUIController.m_luaExportHelper.m_trainingTechs = trainingTechs;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BBA7 RID: 113575 RVA: 0x0087571C File Offset: 0x0087391C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_team(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareActorInfoUIController.m_luaExportHelper.m_team);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BBA8 RID: 113576 RVA: 0x00875774 File Offset: 0x00873974
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_team(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			int team;
			LuaObject.checkType(l, 2, out team);
			battlePrepareActorInfoUIController.m_luaExportHelper.m_team = team;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BBA9 RID: 113577 RVA: 0x008757D0 File Offset: 0x008739D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isNpc(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareActorInfoUIController.m_luaExportHelper.m_isNpc);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BBAA RID: 113578 RVA: 0x00875828 File Offset: 0x00873A28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isNpc(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			bool isNpc;
			LuaObject.checkType(l, 2, out isNpc);
			battlePrepareActorInfoUIController.m_luaExportHelper.m_isNpc = isNpc;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BBAB RID: 113579 RVA: 0x00875884 File Offset: 0x00873A84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_canChangeSoldier(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareActorInfoUIController.m_luaExportHelper.m_canChangeSoldier);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BBAC RID: 113580 RVA: 0x008758DC File Offset: 0x00873ADC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_canChangeSoldier(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			bool canChangeSoldier;
			LuaObject.checkType(l, 2, out canChangeSoldier);
			battlePrepareActorInfoUIController.m_luaExportHelper.m_canChangeSoldier = canChangeSoldier;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BBAD RID: 113581 RVA: 0x00875938 File Offset: 0x00873B38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroHp(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareActorInfoUIController.m_luaExportHelper.m_heroHp);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BBAE RID: 113582 RVA: 0x00875990 File Offset: 0x00873B90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroHp(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			int heroHp;
			LuaObject.checkType(l, 2, out heroHp);
			battlePrepareActorInfoUIController.m_luaExportHelper.m_heroHp = heroHp;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BBAF RID: 113583 RVA: 0x008759EC File Offset: 0x00873BEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierHp(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareActorInfoUIController.m_luaExportHelper.m_soldierHp);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BBB0 RID: 113584 RVA: 0x00875A44 File Offset: 0x00873C44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierHp(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			int soldierHp;
			LuaObject.checkType(l, 2, out soldierHp);
			battlePrepareActorInfoUIController.m_luaExportHelper.m_soldierHp = soldierHp;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BBB1 RID: 113585 RVA: 0x00875AA0 File Offset: 0x00873CA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_extraTalentSkillInfo(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareActorInfoUIController.m_luaExportHelper.m_extraTalentSkillInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BBB2 RID: 113586 RVA: 0x00875AF8 File Offset: 0x00873CF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_extraTalentSkillInfo(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			ConfigDataSkillInfo extraTalentSkillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 2, out extraTalentSkillInfo);
			battlePrepareActorInfoUIController.m_luaExportHelper.m_extraTalentSkillInfo = extraTalentSkillInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BBB3 RID: 113587 RVA: 0x00875B54 File Offset: 0x00873D54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isOpened(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareActorInfoUIController.m_luaExportHelper.m_isOpened);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BBB4 RID: 113588 RVA: 0x00875BAC File Offset: 0x00873DAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isOpened(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			bool isOpened;
			LuaObject.checkType(l, 2, out isOpened);
			battlePrepareActorInfoUIController.m_luaExportHelper.m_isOpened = isOpened;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BBB5 RID: 113589 RVA: 0x00875C08 File Offset: 0x00873E08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareActorInfoUIController.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BBB6 RID: 113590 RVA: 0x00875C60 File Offset: 0x00873E60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			battlePrepareActorInfoUIController.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BBB7 RID: 113591 RVA: 0x00875CBC File Offset: 0x00873EBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareActorInfoUIController.m_luaExportHelper.m_playerContext);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BBB8 RID: 113592 RVA: 0x00875D14 File Offset: 0x00873F14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			ProjectLPlayerContext playerContext;
			LuaObject.checkType<ProjectLPlayerContext>(l, 2, out playerContext);
			battlePrepareActorInfoUIController.m_luaExportHelper.m_playerContext = playerContext;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BBB9 RID: 113593 RVA: 0x00875D70 File Offset: 0x00873F70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_selectSkillIds(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareActorInfoUIController.m_luaExportHelper.m_selectSkillIds);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BBBA RID: 113594 RVA: 0x00875DC8 File Offset: 0x00873FC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_selectSkillIds(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			List<int> selectSkillIds;
			LuaObject.checkType<List<int>>(l, 2, out selectSkillIds);
			battlePrepareActorInfoUIController.m_luaExportHelper.m_selectSkillIds = selectSkillIds;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BBBB RID: 113595 RVA: 0x00875E24 File Offset: 0x00874024
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_lastClickSoldierItem(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareActorInfoUIController.m_luaExportHelper.m_lastClickSoldierItem);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BBBC RID: 113596 RVA: 0x00875E7C File Offset: 0x0087407C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_lastClickSoldierItem(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			BattleSoldierItemUIController lastClickSoldierItem;
			LuaObject.checkType<BattleSoldierItemUIController>(l, 2, out lastClickSoldierItem);
			battlePrepareActorInfoUIController.m_luaExportHelper.m_lastClickSoldierItem = lastClickSoldierItem;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BBBD RID: 113597 RVA: 0x00875ED8 File Offset: 0x008740D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_maxSkillCost(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareActorInfoUIController.m_luaExportHelper.m_maxSkillCost);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BBBE RID: 113598 RVA: 0x00875F30 File Offset: 0x00874130
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_maxSkillCost(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			int maxSkillCost;
			LuaObject.checkType(l, 2, out maxSkillCost);
			battlePrepareActorInfoUIController.m_luaExportHelper.m_maxSkillCost = maxSkillCost;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BBBF RID: 113599 RVA: 0x00875F8C File Offset: 0x0087418C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierGraphic(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareActorInfoUIController.m_luaExportHelper.m_soldierGraphic);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BBC0 RID: 113600 RVA: 0x00875FE4 File Offset: 0x008741E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierGraphic(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			UISpineGraphic soldierGraphic;
			LuaObject.checkType<UISpineGraphic>(l, 2, out soldierGraphic);
			battlePrepareActorInfoUIController.m_luaExportHelper.m_soldierGraphic = soldierGraphic;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BBC1 RID: 113601 RVA: 0x00876040 File Offset: 0x00874240
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierDetailGraphic(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareActorInfoUIController.m_luaExportHelper.m_soldierDetailGraphic);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BBC2 RID: 113602 RVA: 0x00876098 File Offset: 0x00874298
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierDetailGraphic(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			UISpineGraphic soldierDetailGraphic;
			LuaObject.checkType<UISpineGraphic>(l, 2, out soldierDetailGraphic);
			battlePrepareActorInfoUIController.m_luaExportHelper.m_soldierDetailGraphic = soldierDetailGraphic;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BBC3 RID: 113603 RVA: 0x008760F4 File Offset: 0x008742F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillDescPool(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareActorInfoUIController.m_luaExportHelper.m_skillDescPool);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BBC4 RID: 113604 RVA: 0x0087614C File Offset: 0x0087434C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillDescPool(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController = (BattlePrepareActorInfoUIController)LuaObject.checkSelf(l);
			GameObjectPool<SkillDesc> skillDescPool;
			LuaObject.checkType<GameObjectPool<SkillDesc>>(l, 2, out skillDescPool);
			battlePrepareActorInfoUIController.m_luaExportHelper.m_skillDescPool = skillDescPool;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BBC5 RID: 113605 RVA: 0x008761A8 File Offset: 0x008743A8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.BattlePrepareActorInfoUIController");
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.Open);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.Close);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.IsOpened);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.SetActorInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.GetHeroId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.GetTeam);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.CanChangeSoldier);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.SetSkills);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.SetSoldier);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.ShowSelectSoldierPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.GetSoliderSelectButtonRectTransform);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.SelectSolider);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.OnDisable);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.SetSkillsAndTalentList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.ShowSelectSkillPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.CloseSelectSkillPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.OnSkillItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.OnConfirmSelectSkillsButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.GetCostFromSkillList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.SetSoldierDetailPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.CloseSelectSoldierPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.OnSoldierDetailSelectButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.OnSoldierItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.CalcPropAddValue);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.SetPropLevelItemImg);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.CreateSpineGraphic);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.DestroySpineGraphic);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.OnChangeSkillButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.OnChangeSoldierButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache29);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache2A);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.__callDele_EventOnShowSelectSoldierPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache2B);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.__clearDele_EventOnShowSelectSoldierPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache2C);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.__callDele_EventOnChangeSkill);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache2D);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.__clearDele_EventOnChangeSkill);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache2E);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.__callDele_EventOnChangeSoldier);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache2F);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.__clearDele_EventOnChangeSoldier);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache30);
		string name = "EventOnShowSelectSoldierPanel";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.set_EventOnShowSelectSoldierPanel);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache31, true);
		string name2 = "EventOnChangeSkill";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.set_EventOnChangeSkill);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache32, true);
		string name3 = "EventOnChangeSoldier";
		LuaCSFunction get3 = null;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.set_EventOnChangeSoldier);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache33, true);
		string name4 = "m_heroGameObject";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.get_m_heroGameObject);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache34;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.set_m_heroGameObject);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache35, true);
		string name5 = "m_heroNameText";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.get_m_heroNameText);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache36;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.set_m_heroNameText);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache37, true);
		string name6 = "m_heroArmyIcon";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.get_m_heroArmyIcon);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache38;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.set_m_heroArmyIcon);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache39, true);
		string name7 = "m_heroJobText";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.get_m_heroJobText);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache3A;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.set_m_heroJobText);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache3B, true);
		string name8 = "m_heroLevelText";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.get_m_heroLevelText);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache3C;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.set_m_heroLevelText);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache3D, true);
		string name9 = "m_heroRangeText";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.get_m_heroRangeText);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache3E;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.set_m_heroRangeText);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache3F, true);
		string name10 = "m_heroMoveText";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.get_m_heroMoveText);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache40;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.set_m_heroMoveText);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache41, true);
		string name11 = "m_heroPanelGroupCtrl";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.get_m_heroPanelGroupCtrl);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache42;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.set_m_heroPanelGroupCtrl);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache43, true);
		string name12 = "m_heroIcon";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.get_m_heroIcon);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache44;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.set_m_heroIcon);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache45, true);
		string name13 = "m_heroHPText";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.get_m_heroHPText);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache46;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.set_m_heroHPText);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache47, true);
		string name14 = "m_heroHPImage";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.get_m_heroHPImage);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache48;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.set_m_heroHPImage);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache49, true);
		string name15 = "m_heroDEXText";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.get_m_heroDEXText);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache4A;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.set_m_heroDEXText);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache4B, true);
		string name16 = "m_heroAttackText";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.get_m_heroAttackText);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache4C;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.set_m_heroAttackText);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache4D, true);
		string name17 = "m_heroDefenseText";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.get_m_heroDefenseText);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache4E;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.set_m_heroDefenseText);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache4F, true);
		string name18 = "m_heroMagicText";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.get_m_heroMagicText);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache50;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.set_m_heroMagicText);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache51, true);
		string name19 = "m_heroMagicDefenseText";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.get_m_heroMagicDefenseText);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache52;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.set_m_heroMagicDefenseText);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache53, true);
		string name20 = "m_heroSkillInfoButton";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.get_m_heroSkillInfoButton);
		}
		LuaCSFunction get20 = Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache54;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache55 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache55 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.set_m_heroSkillInfoButton);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache55, true);
		string name21 = "m_skillInfoGroupTalentSkillImage";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache56 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache56 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.get_m_skillInfoGroupTalentSkillImage);
		}
		LuaCSFunction get21 = Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache56;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache57 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache57 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.set_m_skillInfoGroupTalentSkillImage);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache57, true);
		string name22 = "m_skillInfoGroupSkillGo";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache58 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache58 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.get_m_skillInfoGroupSkillGo);
		}
		LuaCSFunction get22 = Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache58;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache59 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache59 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.set_m_skillInfoGroupSkillGo);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache59, true);
		string name23 = "m_skillInfoGroupSkillGo2";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache5A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache5A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.get_m_skillInfoGroupSkillGo2);
		}
		LuaCSFunction get23 = Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache5A;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache5B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache5B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.set_m_skillInfoGroupSkillGo2);
		}
		LuaObject.addMember(l, name23, get23, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache5B, true);
		string name24 = "m_skillInfoGroupSkillGo3";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache5C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache5C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.get_m_skillInfoGroupSkillGo3);
		}
		LuaCSFunction get24 = Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache5C;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache5D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache5D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.set_m_skillInfoGroupSkillGo3);
		}
		LuaObject.addMember(l, name24, get24, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache5D, true);
		string name25 = "m_skillChangeButton";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache5E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache5E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.get_m_skillChangeButton);
		}
		LuaCSFunction get25 = Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache5E;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache5F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache5F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.set_m_skillChangeButton);
		}
		LuaObject.addMember(l, name25, get25, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache5F, true);
		string name26 = "m_selectSkillPanelGo";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache60 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache60 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.get_m_selectSkillPanelGo);
		}
		LuaCSFunction get26 = Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache60;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache61 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache61 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.set_m_selectSkillPanelGo);
		}
		LuaObject.addMember(l, name26, get26, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache61, true);
		string name27 = "m_allSkillsContent";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache62 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache62 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.get_m_allSkillsContent);
		}
		LuaCSFunction get27 = Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache62;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache63 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache63 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.set_m_allSkillsContent);
		}
		LuaObject.addMember(l, name27, get27, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache63, true);
		string name28 = "m_selectSkillsContent";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache64 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache64 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.get_m_selectSkillsContent);
		}
		LuaCSFunction get28 = Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache64;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache65 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache65 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.set_m_selectSkillsContent);
		}
		LuaObject.addMember(l, name28, get28, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache65, true);
		string name29 = "m_selectSkillsCost";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache66 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache66 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.get_m_selectSkillsCost);
		}
		LuaCSFunction get29 = Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache66;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache67 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache67 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.set_m_selectSkillsCost);
		}
		LuaObject.addMember(l, name29, get29, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache67, true);
		string name30 = "m_closeSelectSkillButton";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache68 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache68 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.get_m_closeSelectSkillButton);
		}
		LuaCSFunction get30 = Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache68;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache69 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache69 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.set_m_closeSelectSkillButton);
		}
		LuaObject.addMember(l, name30, get30, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache69, true);
		string name31 = "m_selectSkillConfirmButton";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache6A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache6A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.get_m_selectSkillConfirmButton);
		}
		LuaCSFunction get31 = Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache6A;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache6B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache6B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.set_m_selectSkillConfirmButton);
		}
		LuaObject.addMember(l, name31, get31, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache6B, true);
		string name32 = "m_skillDetailObj";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache6C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache6C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.get_m_skillDetailObj);
		}
		LuaCSFunction get32 = Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache6C;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache6D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache6D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.set_m_skillDetailObj);
		}
		LuaObject.addMember(l, name32, get32, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache6D, true);
		string name33 = "m_skillDetailListObj";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache6E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache6E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.get_m_skillDetailListObj);
		}
		LuaCSFunction get33 = Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache6E;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache6F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache6F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.set_m_skillDetailListObj);
		}
		LuaObject.addMember(l, name33, get33, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache6F, true);
		string name34 = "m_skillListContentTalentObj";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache70 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache70 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.get_m_skillListContentTalentObj);
		}
		LuaCSFunction get34 = Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache70;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache71 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache71 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.set_m_skillListContentTalentObj);
		}
		LuaObject.addMember(l, name34, get34, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache71, true);
		string name35 = "m_skillListContentTalentIcon";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache72 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache72 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.get_m_skillListContentTalentIcon);
		}
		LuaCSFunction get35 = Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache72;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache73 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache73 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.set_m_skillListContentTalentIcon);
		}
		LuaObject.addMember(l, name35, get35, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache73, true);
		string name36 = "m_skillListContentTalentNameText";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache74 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache74 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.get_m_skillListContentTalentNameText);
		}
		LuaCSFunction get36 = Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache74;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache75 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache75 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.set_m_skillListContentTalentNameText);
		}
		LuaObject.addMember(l, name36, get36, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache75, true);
		string name37 = "m_skillListContentTalentDescText";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache76 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache76 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.get_m_skillListContentTalentDescText);
		}
		LuaCSFunction get37 = Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache76;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache77 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache77 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.set_m_skillListContentTalentDescText);
		}
		LuaObject.addMember(l, name37, get37, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache77, true);
		string name38 = "m_skillListContentLineImage";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache78 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache78 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.get_m_skillListContentLineImage);
		}
		LuaCSFunction get38 = Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache78;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache79 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache79 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.set_m_skillListContentLineImage);
		}
		LuaObject.addMember(l, name38, get38, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache79, true);
		string name39 = "m_skillListContentListObj";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache7A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache7A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.get_m_skillListContentListObj);
		}
		LuaCSFunction get39 = Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache7A;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache7B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache7B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.set_m_skillListContentListObj);
		}
		LuaObject.addMember(l, name39, get39, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache7B, true);
		string name40 = "m_skillListContentObj";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache7C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache7C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.get_m_skillListContentObj);
		}
		LuaCSFunction get40 = Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache7C;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache7D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache7D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.set_m_skillListContentObj);
		}
		LuaObject.addMember(l, name40, get40, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache7D, true);
		string name41 = "m_skillListNoSkillsObj";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache7E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache7E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.get_m_skillListNoSkillsObj);
		}
		LuaCSFunction get41 = Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache7E;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache7F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache7F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.set_m_skillListNoSkillsObj);
		}
		LuaObject.addMember(l, name41, get41, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache7F, true);
		string name42 = "m_skillDescPrefabObj";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache80 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache80 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.get_m_skillDescPrefabObj);
		}
		LuaCSFunction get42 = Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache80;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache81 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache81 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.set_m_skillDescPrefabObj);
		}
		LuaObject.addMember(l, name42, get42, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache81, true);
		string name43 = "m_skillItemDetailPanel";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache82 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache82 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.get_m_skillItemDetailPanel);
		}
		LuaCSFunction get43 = Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache82;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache83 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache83 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.set_m_skillItemDetailPanel);
		}
		LuaObject.addMember(l, name43, get43, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache83, true);
		string name44 = "m_soldierGo";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache84 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache84 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.get_m_soldierGo);
		}
		LuaCSFunction get44 = Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache84;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache85 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache85 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.set_m_soldierGo);
		}
		LuaObject.addMember(l, name44, get44, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache85, true);
		string name45 = "m_soldierChangeButton";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache86 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache86 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.get_m_soldierChangeButton);
		}
		LuaCSFunction get45 = Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache86;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache87 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache87 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.set_m_soldierChangeButton);
		}
		LuaObject.addMember(l, name45, get45, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache87, true);
		string name46 = "m_closeSelectSoldierButton";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache88 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache88 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.get_m_closeSelectSoldierButton);
		}
		LuaCSFunction get46 = Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache88;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache89 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache89 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.set_m_closeSelectSoldierButton);
		}
		LuaObject.addMember(l, name46, get46, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache89, true);
		string name47 = "m_selectSoldierPanelUIStateController";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache8A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache8A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.get_m_selectSoldierPanelUIStateController);
		}
		LuaCSFunction get47 = Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache8A;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache8B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache8B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.set_m_selectSoldierPanelUIStateController);
		}
		LuaObject.addMember(l, name47, get47, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache8B, true);
		string name48 = "m_soldiersContent";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache8C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache8C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.get_m_soldiersContent);
		}
		LuaCSFunction get48 = Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache8C;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache8D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache8D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.set_m_soldiersContent);
		}
		LuaObject.addMember(l, name48, get48, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache8D, true);
		string name49 = "m_selectSoldierDetailPanel";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache8E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache8E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.get_m_selectSoldierDetailPanel);
		}
		LuaCSFunction get49 = Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache8E;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache8F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache8F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.set_m_selectSoldierDetailPanel);
		}
		LuaObject.addMember(l, name49, get49, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache8F, true);
		string name50 = "m_soldierGraphicGo";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache90 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache90 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.get_m_soldierGraphicGo);
		}
		LuaCSFunction get50 = Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache90;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache91 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache91 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.set_m_soldierGraphicGo);
		}
		LuaObject.addMember(l, name50, get50, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache91, true);
		string name51 = "m_soldierArmyTypeImg";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache92 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache92 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.get_m_soldierArmyTypeImg);
		}
		LuaCSFunction get51 = Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache92;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache93 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache93 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.set_m_soldierArmyTypeImg);
		}
		LuaObject.addMember(l, name51, get51, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache93, true);
		string name52 = "m_soldierNameText";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache94 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache94 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.get_m_soldierNameText);
		}
		LuaCSFunction get52 = Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache94;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache95 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache95 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.set_m_soldierNameText);
		}
		LuaObject.addMember(l, name52, get52, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache95, true);
		string name53 = "m_soldierInfoBtn";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache96 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache96 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.get_m_soldierInfoBtn);
		}
		LuaCSFunction get53 = Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache96;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache97 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache97 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.set_m_soldierInfoBtn);
		}
		LuaObject.addMember(l, name53, get53, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache97, true);
		string name54 = "m_soldierPropHPText";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache98 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache98 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.get_m_soldierPropHPText);
		}
		LuaCSFunction get54 = Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache98;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache99 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache99 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.set_m_soldierPropHPText);
		}
		LuaObject.addMember(l, name54, get54, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache99, true);
		string name55 = "m_soldierPropHPImage";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache9A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache9A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.get_m_soldierPropHPImage);
		}
		LuaCSFunction get55 = Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache9A;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache9B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache9B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.set_m_soldierPropHPImage);
		}
		LuaObject.addMember(l, name55, get55, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache9B, true);
		string name56 = "m_soldierPropDFText";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache9C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache9C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.get_m_soldierPropDFText);
		}
		LuaCSFunction get56 = Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache9C;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache9D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache9D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.set_m_soldierPropDFText);
		}
		LuaObject.addMember(l, name56, get56, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache9D, true);
		string name57 = "m_soldierPropATText";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache9E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache9E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.get_m_soldierPropATText);
		}
		LuaCSFunction get57 = Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache9E;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache9F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache9F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.set_m_soldierPropATText);
		}
		LuaObject.addMember(l, name57, get57, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cache9F, true);
		string name58 = "m_soldierMagicDFText";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheA0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheA0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.get_m_soldierMagicDFText);
		}
		LuaCSFunction get58 = Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheA0;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheA1 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheA1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.set_m_soldierMagicDFText);
		}
		LuaObject.addMember(l, name58, get58, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheA1, true);
		string name59 = "m_soldierDFAddText";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheA2 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheA2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.get_m_soldierDFAddText);
		}
		LuaCSFunction get59 = Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheA2;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheA3 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheA3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.set_m_soldierDFAddText);
		}
		LuaObject.addMember(l, name59, get59, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheA3, true);
		string name60 = "m_soldierATAddText";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheA4 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheA4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.get_m_soldierATAddText);
		}
		LuaCSFunction get60 = Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheA4;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheA5 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheA5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.set_m_soldierATAddText);
		}
		LuaObject.addMember(l, name60, get60, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheA5, true);
		string name61 = "m_soldierMagicDFAddText";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheA6 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheA6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.get_m_soldierMagicDFAddText);
		}
		LuaCSFunction get61 = Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheA6;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheA7 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheA7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.set_m_soldierMagicDFAddText);
		}
		LuaObject.addMember(l, name61, get61, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheA7, true);
		string name62 = "m_soldierDetailPanelUIStateController";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheA8 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheA8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.get_m_soldierDetailPanelUIStateController);
		}
		LuaCSFunction get62 = Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheA8;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheA9 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheA9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.set_m_soldierDetailPanelUIStateController);
		}
		LuaObject.addMember(l, name62, get62, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheA9, true);
		string name63 = "m_soldierDetailIconImg";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheAA == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheAA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.get_m_soldierDetailIconImg);
		}
		LuaCSFunction get63 = Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheAA;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheAB == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheAB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.set_m_soldierDetailIconImg);
		}
		LuaObject.addMember(l, name63, get63, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheAB, true);
		string name64 = "m_soldierDetailGraphicGo";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheAC == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheAC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.get_m_soldierDetailGraphicGo);
		}
		LuaCSFunction get64 = Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheAC;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheAD == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheAD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.set_m_soldierDetailGraphicGo);
		}
		LuaObject.addMember(l, name64, get64, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheAD, true);
		string name65 = "m_soldierDetailRangeText";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheAE == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheAE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.get_m_soldierDetailRangeText);
		}
		LuaCSFunction get65 = Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheAE;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheAF == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheAF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.set_m_soldierDetailRangeText);
		}
		LuaObject.addMember(l, name65, get65, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheAF, true);
		string name66 = "m_soldierDetailMoveText";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheB0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheB0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.get_m_soldierDetailMoveText);
		}
		LuaCSFunction get66 = Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheB0;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheB1 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheB1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.set_m_soldierDetailMoveText);
		}
		LuaObject.addMember(l, name66, get66, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheB1, true);
		string name67 = "m_soldierDetailTypeBgImg";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheB2 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheB2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.get_m_soldierDetailTypeBgImg);
		}
		LuaCSFunction get67 = Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheB2;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheB3 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheB3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.set_m_soldierDetailTypeBgImg);
		}
		LuaObject.addMember(l, name67, get67, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheB3, true);
		string name68 = "m_soldierDetailTypeBgImg2";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheB4 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheB4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.get_m_soldierDetailTypeBgImg2);
		}
		LuaCSFunction get68 = Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheB4;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheB5 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheB5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.set_m_soldierDetailTypeBgImg2);
		}
		LuaObject.addMember(l, name68, get68, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheB5, true);
		string name69 = "m_soldierDetailTitleText";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheB6 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheB6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.get_m_soldierDetailTitleText);
		}
		LuaCSFunction get69 = Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheB6;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheB7 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheB7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.set_m_soldierDetailTitleText);
		}
		LuaObject.addMember(l, name69, get69, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheB7, true);
		string name70 = "m_soldierDetailDescText";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheB8 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheB8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.get_m_soldierDetailDescText);
		}
		LuaCSFunction get70 = Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheB8;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheB9 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheB9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.set_m_soldierDetailDescText);
		}
		LuaObject.addMember(l, name70, get70, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheB9, true);
		string name71 = "m_soldierDetailWeakText";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheBA == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheBA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.get_m_soldierDetailWeakText);
		}
		LuaCSFunction get71 = Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheBA;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheBB == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheBB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.set_m_soldierDetailWeakText);
		}
		LuaObject.addMember(l, name71, get71, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheBB, true);
		string name72 = "m_soldierDetailStrongText";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheBC == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheBC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.get_m_soldierDetailStrongText);
		}
		LuaCSFunction get72 = Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheBC;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheBD == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheBD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.set_m_soldierDetailStrongText);
		}
		LuaObject.addMember(l, name72, get72, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheBD, true);
		string name73 = "m_soldierDetailHPText";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheBE == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheBE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.get_m_soldierDetailHPText);
		}
		LuaCSFunction get73 = Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheBE;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheBF == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheBF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.set_m_soldierDetailHPText);
		}
		LuaObject.addMember(l, name73, get73, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheBF, true);
		string name74 = "m_soldierDetailDFText";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheC0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheC0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.get_m_soldierDetailDFText);
		}
		LuaCSFunction get74 = Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheC0;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheC1 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheC1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.set_m_soldierDetailDFText);
		}
		LuaObject.addMember(l, name74, get74, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheC1, true);
		string name75 = "m_soldierDetailATText";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheC2 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheC2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.get_m_soldierDetailATText);
		}
		LuaCSFunction get75 = Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheC2;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheC3 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheC3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.set_m_soldierDetailATText);
		}
		LuaObject.addMember(l, name75, get75, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheC3, true);
		string name76 = "m_soldierDetailMagicDFText";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheC4 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheC4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.get_m_soldierDetailMagicDFText);
		}
		LuaCSFunction get76 = Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheC4;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheC5 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheC5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.set_m_soldierDetailMagicDFText);
		}
		LuaObject.addMember(l, name76, get76, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheC5, true);
		string name77 = "m_soldierDetailHPAddText";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheC6 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheC6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.get_m_soldierDetailHPAddText);
		}
		LuaCSFunction get77 = Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheC6;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheC7 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheC7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.set_m_soldierDetailHPAddText);
		}
		LuaObject.addMember(l, name77, get77, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheC7, true);
		string name78 = "m_soldierDetailDFAddText";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheC8 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheC8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.get_m_soldierDetailDFAddText);
		}
		LuaCSFunction get78 = Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheC8;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheC9 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheC9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.set_m_soldierDetailDFAddText);
		}
		LuaObject.addMember(l, name78, get78, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheC9, true);
		string name79 = "m_soldierDetailATAddText";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheCA == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheCA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.get_m_soldierDetailATAddText);
		}
		LuaCSFunction get79 = Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheCA;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheCB == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheCB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.set_m_soldierDetailATAddText);
		}
		LuaObject.addMember(l, name79, get79, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheCB, true);
		string name80 = "m_soldierDetailMagicDFAddText";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheCC == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheCC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.get_m_soldierDetailMagicDFAddText);
		}
		LuaCSFunction get80 = Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheCC;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheCD == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheCD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.set_m_soldierDetailMagicDFAddText);
		}
		LuaObject.addMember(l, name80, get80, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheCD, true);
		string name81 = "m_hero";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheCE == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheCE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.get_m_hero);
		}
		LuaCSFunction get81 = Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheCE;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheCF == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheCF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.set_m_hero);
		}
		LuaObject.addMember(l, name81, get81, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheCF, true);
		string name82 = "m_trainingTechs";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheD0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheD0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.get_m_trainingTechs);
		}
		LuaCSFunction get82 = Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheD0;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheD1 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheD1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.set_m_trainingTechs);
		}
		LuaObject.addMember(l, name82, get82, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheD1, true);
		string name83 = "m_team";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheD2 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheD2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.get_m_team);
		}
		LuaCSFunction get83 = Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheD2;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheD3 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheD3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.set_m_team);
		}
		LuaObject.addMember(l, name83, get83, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheD3, true);
		string name84 = "m_isNpc";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheD4 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheD4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.get_m_isNpc);
		}
		LuaCSFunction get84 = Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheD4;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheD5 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheD5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.set_m_isNpc);
		}
		LuaObject.addMember(l, name84, get84, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheD5, true);
		string name85 = "m_canChangeSoldier";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheD6 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheD6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.get_m_canChangeSoldier);
		}
		LuaCSFunction get85 = Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheD6;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheD7 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheD7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.set_m_canChangeSoldier);
		}
		LuaObject.addMember(l, name85, get85, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheD7, true);
		string name86 = "m_heroHp";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheD8 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheD8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.get_m_heroHp);
		}
		LuaCSFunction get86 = Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheD8;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheD9 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheD9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.set_m_heroHp);
		}
		LuaObject.addMember(l, name86, get86, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheD9, true);
		string name87 = "m_soldierHp";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheDA == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheDA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.get_m_soldierHp);
		}
		LuaCSFunction get87 = Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheDA;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheDB == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheDB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.set_m_soldierHp);
		}
		LuaObject.addMember(l, name87, get87, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheDB, true);
		string name88 = "m_extraTalentSkillInfo";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheDC == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheDC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.get_m_extraTalentSkillInfo);
		}
		LuaCSFunction get88 = Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheDC;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheDD == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheDD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.set_m_extraTalentSkillInfo);
		}
		LuaObject.addMember(l, name88, get88, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheDD, true);
		string name89 = "m_isOpened";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheDE == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheDE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.get_m_isOpened);
		}
		LuaCSFunction get89 = Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheDE;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheDF == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheDF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.set_m_isOpened);
		}
		LuaObject.addMember(l, name89, get89, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheDF, true);
		string name90 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheE0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheE0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.get_m_configDataLoader);
		}
		LuaCSFunction get90 = Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheE0;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheE1 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheE1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name90, get90, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheE1, true);
		string name91 = "m_playerContext";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheE2 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheE2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.get_m_playerContext);
		}
		LuaCSFunction get91 = Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheE2;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheE3 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheE3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.set_m_playerContext);
		}
		LuaObject.addMember(l, name91, get91, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheE3, true);
		string name92 = "m_selectSkillIds";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheE4 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheE4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.get_m_selectSkillIds);
		}
		LuaCSFunction get92 = Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheE4;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheE5 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheE5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.set_m_selectSkillIds);
		}
		LuaObject.addMember(l, name92, get92, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheE5, true);
		string name93 = "m_lastClickSoldierItem";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheE6 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheE6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.get_m_lastClickSoldierItem);
		}
		LuaCSFunction get93 = Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheE6;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheE7 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheE7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.set_m_lastClickSoldierItem);
		}
		LuaObject.addMember(l, name93, get93, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheE7, true);
		string name94 = "m_maxSkillCost";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheE8 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheE8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.get_m_maxSkillCost);
		}
		LuaCSFunction get94 = Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheE8;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheE9 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheE9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.set_m_maxSkillCost);
		}
		LuaObject.addMember(l, name94, get94, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheE9, true);
		string name95 = "m_soldierGraphic";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheEA == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheEA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.get_m_soldierGraphic);
		}
		LuaCSFunction get95 = Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheEA;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheEB == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheEB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.set_m_soldierGraphic);
		}
		LuaObject.addMember(l, name95, get95, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheEB, true);
		string name96 = "m_soldierDetailGraphic";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheEC == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheEC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.get_m_soldierDetailGraphic);
		}
		LuaCSFunction get96 = Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheEC;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheED == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheED = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.set_m_soldierDetailGraphic);
		}
		LuaObject.addMember(l, name96, get96, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheED, true);
		string name97 = "m_skillDescPool";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheEE == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheEE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.get_m_skillDescPool);
		}
		LuaCSFunction get97 = Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheEE;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheEF == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheEF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.set_m_skillDescPool);
		}
		LuaObject.addMember(l, name97, get97, Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.<>f__mg$cacheEF, true);
		LuaObject.createTypeMetatable(l, null, typeof(BattlePrepareActorInfoUIController), typeof(UIControllerBase));
	}

	// Token: 0x04011D5F RID: 73055
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04011D60 RID: 73056
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04011D61 RID: 73057
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04011D62 RID: 73058
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04011D63 RID: 73059
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04011D64 RID: 73060
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04011D65 RID: 73061
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04011D66 RID: 73062
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04011D67 RID: 73063
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04011D68 RID: 73064
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04011D69 RID: 73065
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04011D6A RID: 73066
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04011D6B RID: 73067
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04011D6C RID: 73068
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04011D6D RID: 73069
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04011D6E RID: 73070
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04011D6F RID: 73071
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04011D70 RID: 73072
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04011D71 RID: 73073
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04011D72 RID: 73074
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04011D73 RID: 73075
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04011D74 RID: 73076
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04011D75 RID: 73077
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04011D76 RID: 73078
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04011D77 RID: 73079
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04011D78 RID: 73080
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04011D79 RID: 73081
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04011D7A RID: 73082
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04011D7B RID: 73083
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04011D7C RID: 73084
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04011D7D RID: 73085
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04011D7E RID: 73086
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04011D7F RID: 73087
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04011D80 RID: 73088
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04011D81 RID: 73089
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04011D82 RID: 73090
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04011D83 RID: 73091
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04011D84 RID: 73092
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04011D85 RID: 73093
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04011D86 RID: 73094
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04011D87 RID: 73095
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04011D88 RID: 73096
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04011D89 RID: 73097
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04011D8A RID: 73098
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04011D8B RID: 73099
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04011D8C RID: 73100
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04011D8D RID: 73101
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04011D8E RID: 73102
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04011D8F RID: 73103
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04011D90 RID: 73104
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04011D91 RID: 73105
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04011D92 RID: 73106
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04011D93 RID: 73107
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04011D94 RID: 73108
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04011D95 RID: 73109
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04011D96 RID: 73110
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04011D97 RID: 73111
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04011D98 RID: 73112
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04011D99 RID: 73113
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x04011D9A RID: 73114
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x04011D9B RID: 73115
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x04011D9C RID: 73116
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x04011D9D RID: 73117
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x04011D9E RID: 73118
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x04011D9F RID: 73119
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x04011DA0 RID: 73120
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x04011DA1 RID: 73121
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x04011DA2 RID: 73122
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x04011DA3 RID: 73123
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x04011DA4 RID: 73124
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x04011DA5 RID: 73125
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x04011DA6 RID: 73126
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x04011DA7 RID: 73127
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x04011DA8 RID: 73128
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x04011DA9 RID: 73129
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x04011DAA RID: 73130
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x04011DAB RID: 73131
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x04011DAC RID: 73132
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x04011DAD RID: 73133
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x04011DAE RID: 73134
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x04011DAF RID: 73135
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x04011DB0 RID: 73136
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x04011DB1 RID: 73137
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x04011DB2 RID: 73138
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x04011DB3 RID: 73139
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x04011DB4 RID: 73140
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x04011DB5 RID: 73141
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x04011DB6 RID: 73142
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x04011DB7 RID: 73143
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x04011DB8 RID: 73144
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;

	// Token: 0x04011DB9 RID: 73145
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5A;

	// Token: 0x04011DBA RID: 73146
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5B;

	// Token: 0x04011DBB RID: 73147
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5C;

	// Token: 0x04011DBC RID: 73148
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5D;

	// Token: 0x04011DBD RID: 73149
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5E;

	// Token: 0x04011DBE RID: 73150
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5F;

	// Token: 0x04011DBF RID: 73151
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache60;

	// Token: 0x04011DC0 RID: 73152
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache61;

	// Token: 0x04011DC1 RID: 73153
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache62;

	// Token: 0x04011DC2 RID: 73154
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache63;

	// Token: 0x04011DC3 RID: 73155
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache64;

	// Token: 0x04011DC4 RID: 73156
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache65;

	// Token: 0x04011DC5 RID: 73157
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache66;

	// Token: 0x04011DC6 RID: 73158
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache67;

	// Token: 0x04011DC7 RID: 73159
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache68;

	// Token: 0x04011DC8 RID: 73160
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache69;

	// Token: 0x04011DC9 RID: 73161
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6A;

	// Token: 0x04011DCA RID: 73162
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6B;

	// Token: 0x04011DCB RID: 73163
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6C;

	// Token: 0x04011DCC RID: 73164
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6D;

	// Token: 0x04011DCD RID: 73165
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6E;

	// Token: 0x04011DCE RID: 73166
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6F;

	// Token: 0x04011DCF RID: 73167
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache70;

	// Token: 0x04011DD0 RID: 73168
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache71;

	// Token: 0x04011DD1 RID: 73169
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache72;

	// Token: 0x04011DD2 RID: 73170
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache73;

	// Token: 0x04011DD3 RID: 73171
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache74;

	// Token: 0x04011DD4 RID: 73172
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache75;

	// Token: 0x04011DD5 RID: 73173
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache76;

	// Token: 0x04011DD6 RID: 73174
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache77;

	// Token: 0x04011DD7 RID: 73175
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache78;

	// Token: 0x04011DD8 RID: 73176
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache79;

	// Token: 0x04011DD9 RID: 73177
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7A;

	// Token: 0x04011DDA RID: 73178
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7B;

	// Token: 0x04011DDB RID: 73179
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7C;

	// Token: 0x04011DDC RID: 73180
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7D;

	// Token: 0x04011DDD RID: 73181
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7E;

	// Token: 0x04011DDE RID: 73182
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7F;

	// Token: 0x04011DDF RID: 73183
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache80;

	// Token: 0x04011DE0 RID: 73184
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache81;

	// Token: 0x04011DE1 RID: 73185
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache82;

	// Token: 0x04011DE2 RID: 73186
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache83;

	// Token: 0x04011DE3 RID: 73187
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache84;

	// Token: 0x04011DE4 RID: 73188
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache85;

	// Token: 0x04011DE5 RID: 73189
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache86;

	// Token: 0x04011DE6 RID: 73190
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache87;

	// Token: 0x04011DE7 RID: 73191
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache88;

	// Token: 0x04011DE8 RID: 73192
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache89;

	// Token: 0x04011DE9 RID: 73193
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8A;

	// Token: 0x04011DEA RID: 73194
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8B;

	// Token: 0x04011DEB RID: 73195
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8C;

	// Token: 0x04011DEC RID: 73196
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8D;

	// Token: 0x04011DED RID: 73197
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8E;

	// Token: 0x04011DEE RID: 73198
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8F;

	// Token: 0x04011DEF RID: 73199
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache90;

	// Token: 0x04011DF0 RID: 73200
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache91;

	// Token: 0x04011DF1 RID: 73201
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache92;

	// Token: 0x04011DF2 RID: 73202
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache93;

	// Token: 0x04011DF3 RID: 73203
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache94;

	// Token: 0x04011DF4 RID: 73204
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache95;

	// Token: 0x04011DF5 RID: 73205
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache96;

	// Token: 0x04011DF6 RID: 73206
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache97;

	// Token: 0x04011DF7 RID: 73207
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache98;

	// Token: 0x04011DF8 RID: 73208
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache99;

	// Token: 0x04011DF9 RID: 73209
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9A;

	// Token: 0x04011DFA RID: 73210
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9B;

	// Token: 0x04011DFB RID: 73211
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9C;

	// Token: 0x04011DFC RID: 73212
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9D;

	// Token: 0x04011DFD RID: 73213
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9E;

	// Token: 0x04011DFE RID: 73214
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9F;

	// Token: 0x04011DFF RID: 73215
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA0;

	// Token: 0x04011E00 RID: 73216
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA1;

	// Token: 0x04011E01 RID: 73217
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA2;

	// Token: 0x04011E02 RID: 73218
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA3;

	// Token: 0x04011E03 RID: 73219
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA4;

	// Token: 0x04011E04 RID: 73220
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA5;

	// Token: 0x04011E05 RID: 73221
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA6;

	// Token: 0x04011E06 RID: 73222
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA7;

	// Token: 0x04011E07 RID: 73223
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA8;

	// Token: 0x04011E08 RID: 73224
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA9;

	// Token: 0x04011E09 RID: 73225
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAA;

	// Token: 0x04011E0A RID: 73226
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAB;

	// Token: 0x04011E0B RID: 73227
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAC;

	// Token: 0x04011E0C RID: 73228
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAD;

	// Token: 0x04011E0D RID: 73229
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAE;

	// Token: 0x04011E0E RID: 73230
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAF;

	// Token: 0x04011E0F RID: 73231
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB0;

	// Token: 0x04011E10 RID: 73232
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB1;

	// Token: 0x04011E11 RID: 73233
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB2;

	// Token: 0x04011E12 RID: 73234
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB3;

	// Token: 0x04011E13 RID: 73235
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB4;

	// Token: 0x04011E14 RID: 73236
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB5;

	// Token: 0x04011E15 RID: 73237
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB6;

	// Token: 0x04011E16 RID: 73238
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB7;

	// Token: 0x04011E17 RID: 73239
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB8;

	// Token: 0x04011E18 RID: 73240
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB9;

	// Token: 0x04011E19 RID: 73241
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBA;

	// Token: 0x04011E1A RID: 73242
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBB;

	// Token: 0x04011E1B RID: 73243
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBC;

	// Token: 0x04011E1C RID: 73244
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBD;

	// Token: 0x04011E1D RID: 73245
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBE;

	// Token: 0x04011E1E RID: 73246
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBF;

	// Token: 0x04011E1F RID: 73247
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC0;

	// Token: 0x04011E20 RID: 73248
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC1;

	// Token: 0x04011E21 RID: 73249
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC2;

	// Token: 0x04011E22 RID: 73250
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC3;

	// Token: 0x04011E23 RID: 73251
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC4;

	// Token: 0x04011E24 RID: 73252
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC5;

	// Token: 0x04011E25 RID: 73253
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC6;

	// Token: 0x04011E26 RID: 73254
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC7;

	// Token: 0x04011E27 RID: 73255
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC8;

	// Token: 0x04011E28 RID: 73256
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC9;

	// Token: 0x04011E29 RID: 73257
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCA;

	// Token: 0x04011E2A RID: 73258
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCB;

	// Token: 0x04011E2B RID: 73259
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCC;

	// Token: 0x04011E2C RID: 73260
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCD;

	// Token: 0x04011E2D RID: 73261
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCE;

	// Token: 0x04011E2E RID: 73262
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCF;

	// Token: 0x04011E2F RID: 73263
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD0;

	// Token: 0x04011E30 RID: 73264
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD1;

	// Token: 0x04011E31 RID: 73265
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD2;

	// Token: 0x04011E32 RID: 73266
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD3;

	// Token: 0x04011E33 RID: 73267
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD4;

	// Token: 0x04011E34 RID: 73268
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD5;

	// Token: 0x04011E35 RID: 73269
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD6;

	// Token: 0x04011E36 RID: 73270
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD7;

	// Token: 0x04011E37 RID: 73271
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD8;

	// Token: 0x04011E38 RID: 73272
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD9;

	// Token: 0x04011E39 RID: 73273
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDA;

	// Token: 0x04011E3A RID: 73274
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDB;

	// Token: 0x04011E3B RID: 73275
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDC;

	// Token: 0x04011E3C RID: 73276
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDD;

	// Token: 0x04011E3D RID: 73277
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDE;

	// Token: 0x04011E3E RID: 73278
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDF;

	// Token: 0x04011E3F RID: 73279
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE0;

	// Token: 0x04011E40 RID: 73280
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE1;

	// Token: 0x04011E41 RID: 73281
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE2;

	// Token: 0x04011E42 RID: 73282
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE3;

	// Token: 0x04011E43 RID: 73283
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE4;

	// Token: 0x04011E44 RID: 73284
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE5;

	// Token: 0x04011E45 RID: 73285
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE6;

	// Token: 0x04011E46 RID: 73286
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE7;

	// Token: 0x04011E47 RID: 73287
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE8;

	// Token: 0x04011E48 RID: 73288
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE9;

	// Token: 0x04011E49 RID: 73289
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheEA;

	// Token: 0x04011E4A RID: 73290
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheEB;

	// Token: 0x04011E4B RID: 73291
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheEC;

	// Token: 0x04011E4C RID: 73292
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheED;

	// Token: 0x04011E4D RID: 73293
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheEE;

	// Token: 0x04011E4E RID: 73294
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheEF;
}
