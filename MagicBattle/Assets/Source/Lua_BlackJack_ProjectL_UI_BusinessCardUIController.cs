using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Scene;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x020013DC RID: 5084
[Preserve]
public class Lua_BlackJack_ProjectL_UI_BusinessCardUIController : LuaObject
{
	// Token: 0x0601C6ED RID: 116461 RVA: 0x008D1424 File Offset: 0x008CF624
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowOpenState(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			businessCardUIController.ShowOpenState();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C6EE RID: 116462 RVA: 0x008D1470 File Offset: 0x008CF670
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetPlayerInfo(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			BusinessCard businessCard;
			LuaObject.checkType<BusinessCard>(l, 2, out businessCard);
			bool isMe;
			LuaObject.checkType(l, 3, out isMe);
			bool canSendLike;
			LuaObject.checkType(l, 4, out canSendLike);
			bool isRandomShow;
			LuaObject.checkType(l, 5, out isRandomShow);
			businessCardUIController.SetPlayerInfo(businessCard, isMe, canSendLike, isRandomShow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C6EF RID: 116463 RVA: 0x008D14F0 File Offset: 0x008CF6F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetRandomShowToggleOff(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			businessCardUIController.SetRandomShowToggleOff();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C6F0 RID: 116464 RVA: 0x008D153C File Offset: 0x008CF73C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerSignUpdateSuccess(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			string sign;
			LuaObject.checkType(l, 2, out sign);
			businessCardUIController.PlayerSignUpdateSuccess(sign);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C6F1 RID: 116465 RVA: 0x008D1594 File Offset: 0x008CF794
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerSignUpdateEnd(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			businessCardUIController.PlayerSignUpdateEnd();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C6F2 RID: 116466 RVA: 0x008D15E0 File Offset: 0x008CF7E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			businessCardUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C6F3 RID: 116467 RVA: 0x008D1634 File Offset: 0x008CF834
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CheckARState(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			bool b = businessCardUIController.m_luaExportHelper.CheckARState();
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

	// Token: 0x0601C6F4 RID: 116468 RVA: 0x008D1690 File Offset: 0x008CF890
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetTeam(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			BusinessCard businessCard;
			LuaObject.checkType<BusinessCard>(l, 2, out businessCard);
			bool isRandomShow;
			LuaObject.checkType(l, 3, out isRandomShow);
			businessCardUIController.m_luaExportHelper.SetTeam(businessCard, isRandomShow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C6F5 RID: 116469 RVA: 0x008D16FC File Offset: 0x008CF8FC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnHeroCharClick(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			BusinessCardHeroCharItemUIController ctrl;
			LuaObject.checkType<BusinessCardHeroCharItemUIController>(l, 2, out ctrl);
			businessCardUIController.m_luaExportHelper.OnHeroCharClick(ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C6F6 RID: 116470 RVA: 0x008D1758 File Offset: 0x008CF958
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearTeam(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			businessCardUIController.m_luaExportHelper.ClearTeam();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C6F7 RID: 116471 RVA: 0x008D17AC File Offset: 0x008CF9AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetHeroInfoPanel(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			BattleHero hero;
			LuaObject.checkType<BattleHero>(l, 2, out hero);
			bool canSetAndChange;
			LuaObject.checkType(l, 3, out canSetAndChange);
			businessCardUIController.m_luaExportHelper.SetHeroInfoPanel(hero, canSetAndChange);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C6F8 RID: 116472 RVA: 0x008D1818 File Offset: 0x008CFA18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetHeroTalent(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			BattleHero heroTalent;
			LuaObject.checkType<BattleHero>(l, 2, out heroTalent);
			businessCardUIController.m_luaExportHelper.SetHeroTalent(heroTalent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C6F9 RID: 116473 RVA: 0x008D1874 File Offset: 0x008CFA74
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetHeroProperty(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			BattleHero heroProperty;
			LuaObject.checkType<BattleHero>(l, 2, out heroProperty);
			businessCardUIController.m_luaExportHelper.SetHeroProperty(heroProperty);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C6FA RID: 116474 RVA: 0x008D18D0 File Offset: 0x008CFAD0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetCurSelectSkills(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			BattleHero curSelectSkills;
			LuaObject.checkType<BattleHero>(l, 2, out curSelectSkills);
			businessCardUIController.m_luaExportHelper.SetCurSelectSkills(curSelectSkills);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C6FB RID: 116475 RVA: 0x008D192C File Offset: 0x008CFB2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnSkillItemClick(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			HeroSkillItemUIController skillCtrl;
			LuaObject.checkType<HeroSkillItemUIController>(l, 2, out skillCtrl);
			businessCardUIController.m_luaExportHelper.OnSkillItemClick(skillCtrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C6FC RID: 116476 RVA: 0x008D1988 File Offset: 0x008CFB88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnTalentItemClick(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			businessCardUIController.m_luaExportHelper.OnTalentItemClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C6FD RID: 116477 RVA: 0x008D19DC File Offset: 0x008CFBDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetEquipment(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			List<BattleHeroEquipment> equipment;
			LuaObject.checkType<List<BattleHeroEquipment>>(l, 2, out equipment);
			businessCardUIController.m_luaExportHelper.SetEquipment(equipment);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C6FE RID: 116478 RVA: 0x008D1A38 File Offset: 0x008CFC38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearEquipmentItem(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			businessCardUIController.m_luaExportHelper.ClearEquipmentItem();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C6FF RID: 116479 RVA: 0x008D1A8C File Offset: 0x008CFC8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetEquipmentItemInfo(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			BattleHeroEquipment equipment;
			LuaObject.checkType<BattleHeroEquipment>(l, 2, out equipment);
			GameObject parent;
			LuaObject.checkType<GameObject>(l, 3, out parent);
			businessCardUIController.m_luaExportHelper.SetEquipmentItemInfo(equipment, parent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C700 RID: 116480 RVA: 0x008D1AF8 File Offset: 0x008CFCF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnEquipmentItemClick(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			BusinessCardHeroEquipmentItemController ctrl;
			LuaObject.checkType<BusinessCardHeroEquipmentItemController>(l, 2, out ctrl);
			businessCardUIController.m_luaExportHelper.OnEquipmentItemClick(ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C701 RID: 116481 RVA: 0x008D1B54 File Offset: 0x008CFD54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnEquipmentItemBGButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			businessCardUIController.m_luaExportHelper.OnEquipmentItemBGButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C702 RID: 116482 RVA: 0x008D1BA8 File Offset: 0x008CFDA8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetEquipmentItemDesc(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			BattleHeroEquipment equipmentItemDesc;
			LuaObject.checkType<BattleHeroEquipment>(l, 2, out equipmentItemDesc);
			businessCardUIController.m_luaExportHelper.SetEquipmentItemDesc(equipmentItemDesc);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C703 RID: 116483 RVA: 0x008D1C04 File Offset: 0x008CFE04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetPropItems(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			PropertyModifyType type;
			LuaObject.checkEnum<PropertyModifyType>(l, 2, out type);
			int value;
			LuaObject.checkType(l, 3, out value);
			int addValue;
			LuaObject.checkType(l, 4, out addValue);
			int level;
			LuaObject.checkType(l, 5, out level);
			businessCardUIController.m_luaExportHelper.SetPropItems(type, value, addValue, level);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C704 RID: 116484 RVA: 0x008D1C88 File Offset: 0x008CFE88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetCharInfoPanel(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			BattleHero hero;
			LuaObject.checkType<BattleHero>(l, 2, out hero);
			int positionIndex;
			LuaObject.checkType(l, 3, out positionIndex);
			businessCardUIController.m_luaExportHelper.SetCharInfoPanel(hero, positionIndex);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C705 RID: 116485 RVA: 0x008D1CF4 File Offset: 0x008CFEF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnCharDiretionValueChanged(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			int direction;
			LuaObject.checkType(l, 2, out direction);
			businessCardUIController.m_luaExportHelper.OnCharDiretionValueChanged(direction);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C706 RID: 116486 RVA: 0x008D1D50 File Offset: 0x008CFF50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnCharAnimationValueChanged(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			int animation;
			LuaObject.checkType(l, 2, out animation);
			businessCardUIController.m_luaExportHelper.OnCharAnimationValueChanged(animation);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C707 RID: 116487 RVA: 0x008D1DAC File Offset: 0x008CFFAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateSpineGraphic(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			ConfigDataJobConnectionInfo jobConnectionInfo;
			LuaObject.checkType<ConfigDataJobConnectionInfo>(l, 2, out jobConnectionInfo);
			ConfigDataModelSkinResourceInfo heroSkinResInfo;
			LuaObject.checkType<ConfigDataModelSkinResourceInfo>(l, 3, out heroSkinResInfo);
			bool isUIModelScale;
			LuaObject.checkType(l, 4, out isUIModelScale);
			HeroDirectionType directionType;
			LuaObject.checkEnum<HeroDirectionType>(l, 5, out directionType);
			HeroActionType actionType;
			LuaObject.checkEnum<HeroActionType>(l, 6, out actionType);
			UISpineGraphic o = businessCardUIController.m_luaExportHelper.CreateSpineGraphic(jobConnectionInfo, heroSkinResInfo, isUIModelScale, directionType, actionType);
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

	// Token: 0x0601C708 RID: 116488 RVA: 0x008D1E48 File Offset: 0x008D0048
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetCharAction(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			UISpineGraphic g;
			LuaObject.checkType<UISpineGraphic>(l, 2, out g);
			HeroDirectionType direction;
			LuaObject.checkEnum<HeroDirectionType>(l, 3, out direction);
			HeroActionType animation;
			LuaObject.checkEnum<HeroActionType>(l, 4, out animation);
			businessCardUIController.m_luaExportHelper.SetCharAction(g, direction, animation);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C709 RID: 116489 RVA: 0x008D1EC0 File Offset: 0x008D00C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetHeroSelectPanel(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			BusinessCard heroSelectPanel;
			LuaObject.checkType<BusinessCard>(l, 2, out heroSelectPanel);
			businessCardUIController.m_luaExportHelper.SetHeroSelectPanel(heroSelectPanel);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C70A RID: 116490 RVA: 0x008D1F1C File Offset: 0x008D011C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroListItemCompare(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			Hero h;
			LuaObject.checkType<Hero>(l, 2, out h);
			Hero h2;
			LuaObject.checkType<Hero>(l, 3, out h2);
			int i = businessCardUIController.m_luaExportHelper.HeroListItemCompare(h, h2);
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

	// Token: 0x0601C70B RID: 116491 RVA: 0x008D1F90 File Offset: 0x008D0190
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnReturnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			businessCardUIController.m_luaExportHelper.OnReturnButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C70C RID: 116492 RVA: 0x008D1FE4 File Offset: 0x008D01E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnLikeButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			businessCardUIController.m_luaExportHelper.OnLikeButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C70D RID: 116493 RVA: 0x008D2038 File Offset: 0x008D0238
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnRandowShowToggleValueChanged(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			bool isOn;
			LuaObject.checkType(l, 2, out isOn);
			businessCardUIController.m_luaExportHelper.OnRandowShowToggleValueChanged(isOn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C70E RID: 116494 RVA: 0x008D2094 File Offset: 0x008D0294
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnSetPanelBGButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			businessCardUIController.m_luaExportHelper.OnSetPanelBGButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C70F RID: 116495 RVA: 0x008D20E8 File Offset: 0x008D02E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnChangeSignButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			businessCardUIController.m_luaExportHelper.OnChangeSignButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C710 RID: 116496 RVA: 0x008D213C File Offset: 0x008D033C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnArButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			businessCardUIController.m_luaExportHelper.OnArButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C711 RID: 116497 RVA: 0x008D2190 File Offset: 0x008D0390
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPlayerSignEditEnd(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			InputField input;
			LuaObject.checkType<InputField>(l, 2, out input);
			businessCardUIController.m_luaExportHelper.OnPlayerSignEditEnd(input);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C712 RID: 116498 RVA: 0x008D21EC File Offset: 0x008D03EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnHeroItemClick(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			BusinessCardHeroListItemUIController ctrl;
			LuaObject.checkType<BusinessCardHeroListItemUIController>(l, 2, out ctrl);
			businessCardUIController.m_luaExportHelper.OnHeroItemClick(ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C713 RID: 116499 RVA: 0x008D2248 File Offset: 0x008D0448
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnHeroInfoPanelSettingButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			businessCardUIController.m_luaExportHelper.OnHeroInfoPanelSettingButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C714 RID: 116500 RVA: 0x008D229C File Offset: 0x008D049C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnHeroInfoPanelChangeButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			businessCardUIController.m_luaExportHelper.OnHeroInfoPanelChangeButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C715 RID: 116501 RVA: 0x008D22F0 File Offset: 0x008D04F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnSetCharPanelConfirmButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			businessCardUIController.m_luaExportHelper.OnSetCharPanelConfirmButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C716 RID: 116502 RVA: 0x008D2344 File Offset: 0x008D0544
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnHeroSelectPanelConfirmButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			businessCardUIController.m_luaExportHelper.OnHeroSelectPanelConfirmButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C717 RID: 116503 RVA: 0x008D2398 File Offset: 0x008D0598
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Update(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			businessCardUIController.m_luaExportHelper.Update();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C718 RID: 116504 RVA: 0x008D23EC File Offset: 0x008D05EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			businessCardUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C719 RID: 116505 RVA: 0x008D2458 File Offset: 0x008D0658
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			businessCardUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C71A RID: 116506 RVA: 0x008D24AC File Offset: 0x008D06AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			businessCardUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C71B RID: 116507 RVA: 0x008D2500 File Offset: 0x008D0700
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = businessCardUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601C71C RID: 116508 RVA: 0x008D25A8 File Offset: 0x008D07A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			businessCardUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C71D RID: 116509 RVA: 0x008D25FC File Offset: 0x008D07FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			businessCardUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C71E RID: 116510 RVA: 0x008D2668 File Offset: 0x008D0868
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
				BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				businessCardUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				BusinessCardUIController businessCardUIController2 = (BusinessCardUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				businessCardUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601C71F RID: 116511 RVA: 0x008D2778 File Offset: 0x008D0978
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			businessCardUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C720 RID: 116512 RVA: 0x008D27E4 File Offset: 0x008D09E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			businessCardUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C721 RID: 116513 RVA: 0x008D2850 File Offset: 0x008D0A50
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			businessCardUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C722 RID: 116514 RVA: 0x008D28BC File Offset: 0x008D0ABC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			businessCardUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C723 RID: 116515 RVA: 0x008D2928 File Offset: 0x008D0B28
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
				BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				businessCardUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				BusinessCardUIController businessCardUIController2 = (BusinessCardUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				businessCardUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601C724 RID: 116516 RVA: 0x008D2A38 File Offset: 0x008D0C38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			string s = businessCardUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601C725 RID: 116517 RVA: 0x008D2A94 File Offset: 0x008D0C94
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_EventOnArClick(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			businessCardUIController.m_luaExportHelper.__callDele_EventOnArClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C726 RID: 116518 RVA: 0x008D2AE8 File Offset: 0x008D0CE8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_EventOnArClick(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			businessCardUIController.m_luaExportHelper.__clearDele_EventOnArClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C727 RID: 116519 RVA: 0x008D2B3C File Offset: 0x008D0D3C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			bool obj;
			LuaObject.checkType(l, 2, out obj);
			businessCardUIController.m_luaExportHelper.__callDele_EventOnReturn(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C728 RID: 116520 RVA: 0x008D2B98 File Offset: 0x008D0D98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			bool obj;
			LuaObject.checkType(l, 2, out obj);
			businessCardUIController.m_luaExportHelper.__clearDele_EventOnReturn(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C729 RID: 116521 RVA: 0x008D2BF4 File Offset: 0x008D0DF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnLike(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			string obj;
			LuaObject.checkType(l, 2, out obj);
			businessCardUIController.m_luaExportHelper.__callDele_EventOnLike(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C72A RID: 116522 RVA: 0x008D2C50 File Offset: 0x008D0E50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnLike(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			string obj;
			LuaObject.checkType(l, 2, out obj);
			businessCardUIController.m_luaExportHelper.__clearDele_EventOnLike(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C72B RID: 116523 RVA: 0x008D2CAC File Offset: 0x008D0EAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnChangeSign(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			string obj;
			LuaObject.checkType(l, 2, out obj);
			businessCardUIController.m_luaExportHelper.__callDele_EventOnChangeSign(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C72C RID: 116524 RVA: 0x008D2D08 File Offset: 0x008D0F08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnChangeSign(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			string obj;
			LuaObject.checkType(l, 2, out obj);
			businessCardUIController.m_luaExportHelper.__clearDele_EventOnChangeSign(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C72D RID: 116525 RVA: 0x008D2D64 File Offset: 0x008D0F64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnUpdateHeroSet(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			List<BusinessCardHeroSet> obj;
			LuaObject.checkType<List<BusinessCardHeroSet>>(l, 2, out obj);
			businessCardUIController.m_luaExportHelper.__callDele_EventOnUpdateHeroSet(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C72E RID: 116526 RVA: 0x008D2DC0 File Offset: 0x008D0FC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnUpdateHeroSet(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			List<BusinessCardHeroSet> obj;
			LuaObject.checkType<List<BusinessCardHeroSet>>(l, 2, out obj);
			businessCardUIController.m_luaExportHelper.__clearDele_EventOnUpdateHeroSet(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C72F RID: 116527 RVA: 0x008D2E1C File Offset: 0x008D101C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnArClick(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					businessCardUIController.EventOnArClick += value;
				}
				else if (num == 2)
				{
					businessCardUIController.EventOnArClick -= value;
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

	// Token: 0x0601C730 RID: 116528 RVA: 0x008D2E9C File Offset: 0x008D109C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			Action<bool> value;
			int num = LuaObject.checkDelegate<Action<bool>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					businessCardUIController.EventOnReturn += value;
				}
				else if (num == 2)
				{
					businessCardUIController.EventOnReturn -= value;
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

	// Token: 0x0601C731 RID: 116529 RVA: 0x008D2F1C File Offset: 0x008D111C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnLike(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			Action<string> value;
			int num = LuaObject.checkDelegate<Action<string>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					businessCardUIController.EventOnLike += value;
				}
				else if (num == 2)
				{
					businessCardUIController.EventOnLike -= value;
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

	// Token: 0x0601C732 RID: 116530 RVA: 0x008D2F9C File Offset: 0x008D119C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnChangeSign(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			Action<string> value;
			int num = LuaObject.checkDelegate<Action<string>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					businessCardUIController.EventOnChangeSign += value;
				}
				else if (num == 2)
				{
					businessCardUIController.EventOnChangeSign -= value;
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

	// Token: 0x0601C733 RID: 116531 RVA: 0x008D301C File Offset: 0x008D121C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnUpdateHeroSet(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			Action<List<BusinessCardHeroSet>> value;
			int num = LuaObject.checkDelegate<Action<List<BusinessCardHeroSet>>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					businessCardUIController.EventOnUpdateHeroSet += value;
				}
				else if (num == 2)
				{
					businessCardUIController.EventOnUpdateHeroSet -= value;
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

	// Token: 0x0601C734 RID: 116532 RVA: 0x008D309C File Offset: 0x008D129C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_commonUIStateController(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_commonUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C735 RID: 116533 RVA: 0x008D30F4 File Offset: 0x008D12F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_commonUIStateController(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			CommonUIStateController commonUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out commonUIStateController);
			businessCardUIController.m_luaExportHelper.m_commonUIStateController = commonUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C736 RID: 116534 RVA: 0x008D3150 File Offset: 0x008D1350
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerHeadIcon(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_playerHeadIcon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C737 RID: 116535 RVA: 0x008D31A8 File Offset: 0x008D13A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerHeadIcon(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			Image playerHeadIcon;
			LuaObject.checkType<Image>(l, 2, out playerHeadIcon);
			businessCardUIController.m_luaExportHelper.m_playerHeadIcon = playerHeadIcon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C738 RID: 116536 RVA: 0x008D3204 File Offset: 0x008D1404
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerNameText(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_playerNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C739 RID: 116537 RVA: 0x008D325C File Offset: 0x008D145C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerNameText(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			Text playerNameText;
			LuaObject.checkType<Text>(l, 2, out playerNameText);
			businessCardUIController.m_luaExportHelper.m_playerNameText = playerNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C73A RID: 116538 RVA: 0x008D32B8 File Offset: 0x008D14B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerLevelText(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_playerLevelText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C73B RID: 116539 RVA: 0x008D3310 File Offset: 0x008D1510
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerLevelText(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			Text playerLevelText;
			LuaObject.checkType<Text>(l, 2, out playerLevelText);
			businessCardUIController.m_luaExportHelper.m_playerLevelText = playerLevelText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C73C RID: 116540 RVA: 0x008D336C File Offset: 0x008D156C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerPointText(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_playerPointText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C73D RID: 116541 RVA: 0x008D33C4 File Offset: 0x008D15C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerPointText(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			Text playerPointText;
			LuaObject.checkType<Text>(l, 2, out playerPointText);
			businessCardUIController.m_luaExportHelper.m_playerPointText = playerPointText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C73E RID: 116542 RVA: 0x008D3420 File Offset: 0x008D1620
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerLikesCountText(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_playerLikesCountText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C73F RID: 116543 RVA: 0x008D3478 File Offset: 0x008D1678
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerLikesCountText(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			Text playerLikesCountText;
			LuaObject.checkType<Text>(l, 2, out playerLikesCountText);
			businessCardUIController.m_luaExportHelper.m_playerLikesCountText = playerLikesCountText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C740 RID: 116544 RVA: 0x008D34D4 File Offset: 0x008D16D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_randomShowToggle(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_randomShowToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C741 RID: 116545 RVA: 0x008D352C File Offset: 0x008D172C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_randomShowToggle(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			Toggle randomShowToggle;
			LuaObject.checkType<Toggle>(l, 2, out randomShowToggle);
			businessCardUIController.m_luaExportHelper.m_randomShowToggle = randomShowToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C742 RID: 116546 RVA: 0x008D3588 File Offset: 0x008D1788
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_likeButton(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_likeButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C743 RID: 116547 RVA: 0x008D35E0 File Offset: 0x008D17E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_likeButton(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			Button likeButton;
			LuaObject.checkType<Button>(l, 2, out likeButton);
			businessCardUIController.m_luaExportHelper.m_likeButton = likeButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C744 RID: 116548 RVA: 0x008D363C File Offset: 0x008D183C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_likeUIStateController(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_likeUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C745 RID: 116549 RVA: 0x008D3694 File Offset: 0x008D1894
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_likeUIStateController(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			CommonUIStateController likeUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out likeUIStateController);
			businessCardUIController.m_luaExportHelper.m_likeUIStateController = likeUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C746 RID: 116550 RVA: 0x008D36F0 File Offset: 0x008D18F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_teamGraphicsParentGameObject(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_teamGraphicsParentGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C747 RID: 116551 RVA: 0x008D3748 File Offset: 0x008D1948
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_teamGraphicsParentGameObject(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			GameObject teamGraphicsParentGameObject;
			LuaObject.checkType<GameObject>(l, 2, out teamGraphicsParentGameObject);
			businessCardUIController.m_luaExportHelper.m_teamGraphicsParentGameObject = teamGraphicsParentGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C748 RID: 116552 RVA: 0x008D37A4 File Offset: 0x008D19A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_char0Dummy(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_char0Dummy);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C749 RID: 116553 RVA: 0x008D37FC File Offset: 0x008D19FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_char0Dummy(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			GameObject char0Dummy;
			LuaObject.checkType<GameObject>(l, 2, out char0Dummy);
			businessCardUIController.m_luaExportHelper.m_char0Dummy = char0Dummy;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C74A RID: 116554 RVA: 0x008D3858 File Offset: 0x008D1A58
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_char1Dummy(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_char1Dummy);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C74B RID: 116555 RVA: 0x008D38B0 File Offset: 0x008D1AB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_char1Dummy(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			GameObject char1Dummy;
			LuaObject.checkType<GameObject>(l, 2, out char1Dummy);
			businessCardUIController.m_luaExportHelper.m_char1Dummy = char1Dummy;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C74C RID: 116556 RVA: 0x008D390C File Offset: 0x008D1B0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_char2Dummy(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_char2Dummy);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C74D RID: 116557 RVA: 0x008D3964 File Offset: 0x008D1B64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_char2Dummy(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			GameObject char2Dummy;
			LuaObject.checkType<GameObject>(l, 2, out char2Dummy);
			businessCardUIController.m_luaExportHelper.m_char2Dummy = char2Dummy;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C74E RID: 116558 RVA: 0x008D39C0 File Offset: 0x008D1BC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_char3Dummy(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_char3Dummy);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C74F RID: 116559 RVA: 0x008D3A18 File Offset: 0x008D1C18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_char3Dummy(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			GameObject char3Dummy;
			LuaObject.checkType<GameObject>(l, 2, out char3Dummy);
			businessCardUIController.m_luaExportHelper.m_char3Dummy = char3Dummy;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C750 RID: 116560 RVA: 0x008D3A74 File Offset: 0x008D1C74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_char4Dummy(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_char4Dummy);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C751 RID: 116561 RVA: 0x008D3ACC File Offset: 0x008D1CCC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_char4Dummy(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			GameObject char4Dummy;
			LuaObject.checkType<GameObject>(l, 2, out char4Dummy);
			businessCardUIController.m_luaExportHelper.m_char4Dummy = char4Dummy;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C752 RID: 116562 RVA: 0x008D3B28 File Offset: 0x008D1D28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerSignText(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_playerSignText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C753 RID: 116563 RVA: 0x008D3B80 File Offset: 0x008D1D80
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_playerSignText(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			Text playerSignText;
			LuaObject.checkType<Text>(l, 2, out playerSignText);
			businessCardUIController.m_luaExportHelper.m_playerSignText = playerSignText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C754 RID: 116564 RVA: 0x008D3BDC File Offset: 0x008D1DDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerInputField(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_playerInputField);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C755 RID: 116565 RVA: 0x008D3C34 File Offset: 0x008D1E34
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_playerInputField(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			InputField playerInputField;
			LuaObject.checkType<InputField>(l, 2, out playerInputField);
			businessCardUIController.m_luaExportHelper.m_playerInputField = playerInputField;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C756 RID: 116566 RVA: 0x008D3C90 File Offset: 0x008D1E90
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_changeSignButton(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_changeSignButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C757 RID: 116567 RVA: 0x008D3CE8 File Offset: 0x008D1EE8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_changeSignButton(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			Button changeSignButton;
			LuaObject.checkType<Button>(l, 2, out changeSignButton);
			businessCardUIController.m_luaExportHelper.m_changeSignButton = changeSignButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C758 RID: 116568 RVA: 0x008D3D44 File Offset: 0x008D1F44
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_heroGroupObj(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_heroGroupObj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C759 RID: 116569 RVA: 0x008D3D9C File Offset: 0x008D1F9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroGroupObj(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			GameObject heroGroupObj;
			LuaObject.checkType<GameObject>(l, 2, out heroGroupObj);
			businessCardUIController.m_luaExportHelper.m_heroGroupObj = heroGroupObj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C75A RID: 116570 RVA: 0x008D3DF8 File Offset: 0x008D1FF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerAllHeroPowerText(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_playerAllHeroPowerText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C75B RID: 116571 RVA: 0x008D3E50 File Offset: 0x008D2050
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerAllHeroPowerText(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			Text playerAllHeroPowerText;
			LuaObject.checkType<Text>(l, 2, out playerAllHeroPowerText);
			businessCardUIController.m_luaExportHelper.m_playerAllHeroPowerText = playerAllHeroPowerText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C75C RID: 116572 RVA: 0x008D3EAC File Offset: 0x008D20AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerReachedAchievementText(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_playerReachedAchievementText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C75D RID: 116573 RVA: 0x008D3F04 File Offset: 0x008D2104
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerReachedAchievementText(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			Text playerReachedAchievementText;
			LuaObject.checkType<Text>(l, 2, out playerReachedAchievementText);
			businessCardUIController.m_luaExportHelper.m_playerReachedAchievementText = playerReachedAchievementText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C75E RID: 116574 RVA: 0x008D3F60 File Offset: 0x008D2160
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerMasterJobCountText(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_playerMasterJobCountText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C75F RID: 116575 RVA: 0x008D3FB8 File Offset: 0x008D21B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerMasterJobCountText(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			Text playerMasterJobCountText;
			LuaObject.checkType<Text>(l, 2, out playerMasterJobCountText);
			businessCardUIController.m_luaExportHelper.m_playerMasterJobCountText = playerMasterJobCountText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C760 RID: 116576 RVA: 0x008D4014 File Offset: 0x008D2214
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_stageGoalText(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_stageGoalText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C761 RID: 116577 RVA: 0x008D406C File Offset: 0x008D226C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_stageGoalText(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			Text stageGoalText;
			LuaObject.checkType<Text>(l, 2, out stageGoalText);
			businessCardUIController.m_luaExportHelper.m_stageGoalText = stageGoalText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C762 RID: 116578 RVA: 0x008D40C8 File Offset: 0x008D22C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_riftGoalText(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_riftGoalText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C763 RID: 116579 RVA: 0x008D4120 File Offset: 0x008D2320
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_riftGoalText(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			Text riftGoalText;
			LuaObject.checkType<Text>(l, 2, out riftGoalText);
			businessCardUIController.m_luaExportHelper.m_riftGoalText = riftGoalText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C764 RID: 116580 RVA: 0x008D417C File Offset: 0x008D237C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_returnButton(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_returnButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C765 RID: 116581 RVA: 0x008D41D4 File Offset: 0x008D23D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_returnButton(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			Button returnButton;
			LuaObject.checkType<Button>(l, 2, out returnButton);
			businessCardUIController.m_luaExportHelper.m_returnButton = returnButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C766 RID: 116582 RVA: 0x008D4230 File Offset: 0x008D2430
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_arHeroListPanel(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_arHeroListPanel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C767 RID: 116583 RVA: 0x008D4288 File Offset: 0x008D2488
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_arHeroListPanel(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			GameObject arHeroListPanel;
			LuaObject.checkType<GameObject>(l, 2, out arHeroListPanel);
			businessCardUIController.m_luaExportHelper.m_arHeroListPanel = arHeroListPanel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C768 RID: 116584 RVA: 0x008D42E4 File Offset: 0x008D24E4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_arButton(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_arButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C769 RID: 116585 RVA: 0x008D433C File Offset: 0x008D253C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_arButton(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			ButtonEx arButton;
			LuaObject.checkType<ButtonEx>(l, 2, out arButton);
			businessCardUIController.m_luaExportHelper.m_arButton = arButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C76A RID: 116586 RVA: 0x008D4398 File Offset: 0x008D2598
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_setPanelUIStateController(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_setPanelUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C76B RID: 116587 RVA: 0x008D43F0 File Offset: 0x008D25F0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_setPanelUIStateController(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			CommonUIStateController setPanelUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out setPanelUIStateController);
			businessCardUIController.m_luaExportHelper.m_setPanelUIStateController = setPanelUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C76C RID: 116588 RVA: 0x008D444C File Offset: 0x008D264C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_setPanelBGButton(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_setPanelBGButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C76D RID: 116589 RVA: 0x008D44A4 File Offset: 0x008D26A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_setPanelBGButton(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			Button setPanelBGButton;
			LuaObject.checkType<Button>(l, 2, out setPanelBGButton);
			businessCardUIController.m_luaExportHelper.m_setPanelBGButton = setPanelBGButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C76E RID: 116590 RVA: 0x008D4500 File Offset: 0x008D2700
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroInfoPanelUIStateController(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_heroInfoPanelUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C76F RID: 116591 RVA: 0x008D4558 File Offset: 0x008D2758
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_heroInfoPanelUIStateController(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			CommonUIStateController heroInfoPanelUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out heroInfoPanelUIStateController);
			businessCardUIController.m_luaExportHelper.m_heroInfoPanelUIStateController = heroInfoPanelUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C770 RID: 116592 RVA: 0x008D45B4 File Offset: 0x008D27B4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_heroInfoPanelSettingButton(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_heroInfoPanelSettingButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C771 RID: 116593 RVA: 0x008D460C File Offset: 0x008D280C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroInfoPanelSettingButton(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			Button heroInfoPanelSettingButton;
			LuaObject.checkType<Button>(l, 2, out heroInfoPanelSettingButton);
			businessCardUIController.m_luaExportHelper.m_heroInfoPanelSettingButton = heroInfoPanelSettingButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C772 RID: 116594 RVA: 0x008D4668 File Offset: 0x008D2868
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_heroInfoPanelChangeButton(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_heroInfoPanelChangeButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C773 RID: 116595 RVA: 0x008D46C0 File Offset: 0x008D28C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroInfoPanelChangeButton(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			Button heroInfoPanelChangeButton;
			LuaObject.checkType<Button>(l, 2, out heroInfoPanelChangeButton);
			businessCardUIController.m_luaExportHelper.m_heroInfoPanelChangeButton = heroInfoPanelChangeButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C774 RID: 116596 RVA: 0x008D471C File Offset: 0x008D291C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_heroInfoArmyImage(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_heroInfoArmyImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C775 RID: 116597 RVA: 0x008D4774 File Offset: 0x008D2974
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroInfoArmyImage(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			Image heroInfoArmyImage;
			LuaObject.checkType<Image>(l, 2, out heroInfoArmyImage);
			businessCardUIController.m_luaExportHelper.m_heroInfoArmyImage = heroInfoArmyImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C776 RID: 116598 RVA: 0x008D47D0 File Offset: 0x008D29D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroInfoLevelText(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_heroInfoLevelText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C777 RID: 116599 RVA: 0x008D4828 File Offset: 0x008D2A28
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_heroInfoLevelText(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			Text heroInfoLevelText;
			LuaObject.checkType<Text>(l, 2, out heroInfoLevelText);
			businessCardUIController.m_luaExportHelper.m_heroInfoLevelText = heroInfoLevelText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C778 RID: 116600 RVA: 0x008D4884 File Offset: 0x008D2A84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroInfoNameText(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_heroInfoNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C779 RID: 116601 RVA: 0x008D48DC File Offset: 0x008D2ADC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_heroInfoNameText(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			Text heroInfoNameText;
			LuaObject.checkType<Text>(l, 2, out heroInfoNameText);
			businessCardUIController.m_luaExportHelper.m_heroInfoNameText = heroInfoNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C77A RID: 116602 RVA: 0x008D4938 File Offset: 0x008D2B38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroInfoJobText(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_heroInfoJobText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C77B RID: 116603 RVA: 0x008D4990 File Offset: 0x008D2B90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroInfoJobText(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			Text heroInfoJobText;
			LuaObject.checkType<Text>(l, 2, out heroInfoJobText);
			businessCardUIController.m_luaExportHelper.m_heroInfoJobText = heroInfoJobText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C77C RID: 116604 RVA: 0x008D49EC File Offset: 0x008D2BEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroInfoPowerText(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_heroInfoPowerText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C77D RID: 116605 RVA: 0x008D4A44 File Offset: 0x008D2C44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroInfoPowerText(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			Text heroInfoPowerText;
			LuaObject.checkType<Text>(l, 2, out heroInfoPowerText);
			businessCardUIController.m_luaExportHelper.m_heroInfoPowerText = heroInfoPowerText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C77E RID: 116606 RVA: 0x008D4AA0 File Offset: 0x008D2CA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroInfoGraphicDummy(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_heroInfoGraphicDummy);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C77F RID: 116607 RVA: 0x008D4AF8 File Offset: 0x008D2CF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroInfoGraphicDummy(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			GameObject heroInfoGraphicDummy;
			LuaObject.checkType<GameObject>(l, 2, out heroInfoGraphicDummy);
			businessCardUIController.m_luaExportHelper.m_heroInfoGraphicDummy = heroInfoGraphicDummy;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C780 RID: 116608 RVA: 0x008D4B54 File Offset: 0x008D2D54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipment1Dummy(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_equipment1Dummy);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C781 RID: 116609 RVA: 0x008D4BAC File Offset: 0x008D2DAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipment1Dummy(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			GameObject equipment1Dummy;
			LuaObject.checkType<GameObject>(l, 2, out equipment1Dummy);
			businessCardUIController.m_luaExportHelper.m_equipment1Dummy = equipment1Dummy;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C782 RID: 116610 RVA: 0x008D4C08 File Offset: 0x008D2E08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipment2Dummy(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_equipment2Dummy);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C783 RID: 116611 RVA: 0x008D4C60 File Offset: 0x008D2E60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipment2Dummy(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			GameObject equipment2Dummy;
			LuaObject.checkType<GameObject>(l, 2, out equipment2Dummy);
			businessCardUIController.m_luaExportHelper.m_equipment2Dummy = equipment2Dummy;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C784 RID: 116612 RVA: 0x008D4CBC File Offset: 0x008D2EBC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_equipment3Dummy(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_equipment3Dummy);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C785 RID: 116613 RVA: 0x008D4D14 File Offset: 0x008D2F14
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_equipment3Dummy(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			GameObject equipment3Dummy;
			LuaObject.checkType<GameObject>(l, 2, out equipment3Dummy);
			businessCardUIController.m_luaExportHelper.m_equipment3Dummy = equipment3Dummy;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C786 RID: 116614 RVA: 0x008D4D70 File Offset: 0x008D2F70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipment4Dummy(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_equipment4Dummy);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C787 RID: 116615 RVA: 0x008D4DC8 File Offset: 0x008D2FC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipment4Dummy(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			GameObject equipment4Dummy;
			LuaObject.checkType<GameObject>(l, 2, out equipment4Dummy);
			businessCardUIController.m_luaExportHelper.m_equipment4Dummy = equipment4Dummy;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C788 RID: 116616 RVA: 0x008D4E24 File Offset: 0x008D3024
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroInfoPropHPImg(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_heroInfoPropHPImg);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C789 RID: 116617 RVA: 0x008D4E7C File Offset: 0x008D307C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroInfoPropHPImg(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			Image heroInfoPropHPImg;
			LuaObject.checkType<Image>(l, 2, out heroInfoPropHPImg);
			businessCardUIController.m_luaExportHelper.m_heroInfoPropHPImg = heroInfoPropHPImg;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C78A RID: 116618 RVA: 0x008D4ED8 File Offset: 0x008D30D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroInfoPropDFImg(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_heroInfoPropDFImg);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C78B RID: 116619 RVA: 0x008D4F30 File Offset: 0x008D3130
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroInfoPropDFImg(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			Image heroInfoPropDFImg;
			LuaObject.checkType<Image>(l, 2, out heroInfoPropDFImg);
			businessCardUIController.m_luaExportHelper.m_heroInfoPropDFImg = heroInfoPropDFImg;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C78C RID: 116620 RVA: 0x008D4F8C File Offset: 0x008D318C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroInfoPropATImg(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_heroInfoPropATImg);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C78D RID: 116621 RVA: 0x008D4FE4 File Offset: 0x008D31E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroInfoPropATImg(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			Image heroInfoPropATImg;
			LuaObject.checkType<Image>(l, 2, out heroInfoPropATImg);
			businessCardUIController.m_luaExportHelper.m_heroInfoPropATImg = heroInfoPropATImg;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C78E RID: 116622 RVA: 0x008D5040 File Offset: 0x008D3240
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_heroInfoPropMagicDFImg(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_heroInfoPropMagicDFImg);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C78F RID: 116623 RVA: 0x008D5098 File Offset: 0x008D3298
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroInfoPropMagicDFImg(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			Image heroInfoPropMagicDFImg;
			LuaObject.checkType<Image>(l, 2, out heroInfoPropMagicDFImg);
			businessCardUIController.m_luaExportHelper.m_heroInfoPropMagicDFImg = heroInfoPropMagicDFImg;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C790 RID: 116624 RVA: 0x008D50F4 File Offset: 0x008D32F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroInfoPropMagicImg(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_heroInfoPropMagicImg);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C791 RID: 116625 RVA: 0x008D514C File Offset: 0x008D334C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroInfoPropMagicImg(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			Image heroInfoPropMagicImg;
			LuaObject.checkType<Image>(l, 2, out heroInfoPropMagicImg);
			businessCardUIController.m_luaExportHelper.m_heroInfoPropMagicImg = heroInfoPropMagicImg;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C792 RID: 116626 RVA: 0x008D51A8 File Offset: 0x008D33A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroInfoPropDEXImg(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_heroInfoPropDEXImg);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C793 RID: 116627 RVA: 0x008D5200 File Offset: 0x008D3400
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroInfoPropDEXImg(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			Image heroInfoPropDEXImg;
			LuaObject.checkType<Image>(l, 2, out heroInfoPropDEXImg);
			businessCardUIController.m_luaExportHelper.m_heroInfoPropDEXImg = heroInfoPropDEXImg;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C794 RID: 116628 RVA: 0x008D525C File Offset: 0x008D345C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_heroInfoPropHPValueText(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_heroInfoPropHPValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C795 RID: 116629 RVA: 0x008D52B4 File Offset: 0x008D34B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroInfoPropHPValueText(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			Text heroInfoPropHPValueText;
			LuaObject.checkType<Text>(l, 2, out heroInfoPropHPValueText);
			businessCardUIController.m_luaExportHelper.m_heroInfoPropHPValueText = heroInfoPropHPValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C796 RID: 116630 RVA: 0x008D5310 File Offset: 0x008D3510
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_heroInfoPropDFValueText(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_heroInfoPropDFValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C797 RID: 116631 RVA: 0x008D5368 File Offset: 0x008D3568
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroInfoPropDFValueText(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			Text heroInfoPropDFValueText;
			LuaObject.checkType<Text>(l, 2, out heroInfoPropDFValueText);
			businessCardUIController.m_luaExportHelper.m_heroInfoPropDFValueText = heroInfoPropDFValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C798 RID: 116632 RVA: 0x008D53C4 File Offset: 0x008D35C4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_heroInfoPropATValueText(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_heroInfoPropATValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C799 RID: 116633 RVA: 0x008D541C File Offset: 0x008D361C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroInfoPropATValueText(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			Text heroInfoPropATValueText;
			LuaObject.checkType<Text>(l, 2, out heroInfoPropATValueText);
			businessCardUIController.m_luaExportHelper.m_heroInfoPropATValueText = heroInfoPropATValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C79A RID: 116634 RVA: 0x008D5478 File Offset: 0x008D3678
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroInfoPropMagicDFValueText(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_heroInfoPropMagicDFValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C79B RID: 116635 RVA: 0x008D54D0 File Offset: 0x008D36D0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_heroInfoPropMagicDFValueText(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			Text heroInfoPropMagicDFValueText;
			LuaObject.checkType<Text>(l, 2, out heroInfoPropMagicDFValueText);
			businessCardUIController.m_luaExportHelper.m_heroInfoPropMagicDFValueText = heroInfoPropMagicDFValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C79C RID: 116636 RVA: 0x008D552C File Offset: 0x008D372C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_heroInfoPropMagicValueText(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_heroInfoPropMagicValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C79D RID: 116637 RVA: 0x008D5584 File Offset: 0x008D3784
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroInfoPropMagicValueText(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			Text heroInfoPropMagicValueText;
			LuaObject.checkType<Text>(l, 2, out heroInfoPropMagicValueText);
			businessCardUIController.m_luaExportHelper.m_heroInfoPropMagicValueText = heroInfoPropMagicValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C79E RID: 116638 RVA: 0x008D55E0 File Offset: 0x008D37E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroInfoPropDEXValueText(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_heroInfoPropDEXValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C79F RID: 116639 RVA: 0x008D5638 File Offset: 0x008D3838
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroInfoPropDEXValueText(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			Text heroInfoPropDEXValueText;
			LuaObject.checkType<Text>(l, 2, out heroInfoPropDEXValueText);
			businessCardUIController.m_luaExportHelper.m_heroInfoPropDEXValueText = heroInfoPropDEXValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C7A0 RID: 116640 RVA: 0x008D5694 File Offset: 0x008D3894
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroInfoPropHPAddText(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_heroInfoPropHPAddText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C7A1 RID: 116641 RVA: 0x008D56EC File Offset: 0x008D38EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroInfoPropHPAddText(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			Text heroInfoPropHPAddText;
			LuaObject.checkType<Text>(l, 2, out heroInfoPropHPAddText);
			businessCardUIController.m_luaExportHelper.m_heroInfoPropHPAddText = heroInfoPropHPAddText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C7A2 RID: 116642 RVA: 0x008D5748 File Offset: 0x008D3948
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroInfoPropDFAddText(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_heroInfoPropDFAddText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C7A3 RID: 116643 RVA: 0x008D57A0 File Offset: 0x008D39A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroInfoPropDFAddText(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			Text heroInfoPropDFAddText;
			LuaObject.checkType<Text>(l, 2, out heroInfoPropDFAddText);
			businessCardUIController.m_luaExportHelper.m_heroInfoPropDFAddText = heroInfoPropDFAddText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C7A4 RID: 116644 RVA: 0x008D57FC File Offset: 0x008D39FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroInfoPropATAddText(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_heroInfoPropATAddText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C7A5 RID: 116645 RVA: 0x008D5854 File Offset: 0x008D3A54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroInfoPropATAddText(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			Text heroInfoPropATAddText;
			LuaObject.checkType<Text>(l, 2, out heroInfoPropATAddText);
			businessCardUIController.m_luaExportHelper.m_heroInfoPropATAddText = heroInfoPropATAddText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C7A6 RID: 116646 RVA: 0x008D58B0 File Offset: 0x008D3AB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroInfoPropMagicDFAddText(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_heroInfoPropMagicDFAddText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C7A7 RID: 116647 RVA: 0x008D5908 File Offset: 0x008D3B08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroInfoPropMagicDFAddText(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			Text heroInfoPropMagicDFAddText;
			LuaObject.checkType<Text>(l, 2, out heroInfoPropMagicDFAddText);
			businessCardUIController.m_luaExportHelper.m_heroInfoPropMagicDFAddText = heroInfoPropMagicDFAddText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C7A8 RID: 116648 RVA: 0x008D5964 File Offset: 0x008D3B64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroInfoPropMagicAddText(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_heroInfoPropMagicAddText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C7A9 RID: 116649 RVA: 0x008D59BC File Offset: 0x008D3BBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroInfoPropMagicAddText(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			Text heroInfoPropMagicAddText;
			LuaObject.checkType<Text>(l, 2, out heroInfoPropMagicAddText);
			businessCardUIController.m_luaExportHelper.m_heroInfoPropMagicAddText = heroInfoPropMagicAddText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C7AA RID: 116650 RVA: 0x008D5A18 File Offset: 0x008D3C18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroInfoPropDEXAddText(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_heroInfoPropDEXAddText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C7AB RID: 116651 RVA: 0x008D5A70 File Offset: 0x008D3C70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroInfoPropDEXAddText(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			Text heroInfoPropDEXAddText;
			LuaObject.checkType<Text>(l, 2, out heroInfoPropDEXAddText);
			businessCardUIController.m_luaExportHelper.m_heroInfoPropDEXAddText = heroInfoPropDEXAddText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C7AC RID: 116652 RVA: 0x008D5ACC File Offset: 0x008D3CCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipmentItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_equipmentItemPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C7AD RID: 116653 RVA: 0x008D5B24 File Offset: 0x008D3D24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipmentItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			GameObject equipmentItemPrefab;
			LuaObject.checkType<GameObject>(l, 2, out equipmentItemPrefab);
			businessCardUIController.m_luaExportHelper.m_equipmentItemPrefab = equipmentItemPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C7AE RID: 116654 RVA: 0x008D5B80 File Offset: 0x008D3D80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipItemDescBGButton(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_equipItemDescBGButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C7AF RID: 116655 RVA: 0x008D5BD8 File Offset: 0x008D3DD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipItemDescBGButton(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			Button equipItemDescBGButton;
			LuaObject.checkType<Button>(l, 2, out equipItemDescBGButton);
			businessCardUIController.m_luaExportHelper.m_equipItemDescBGButton = equipItemDescBGButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C7B0 RID: 116656 RVA: 0x008D5C34 File Offset: 0x008D3E34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipItemDescStateController(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_equipItemDescStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C7B1 RID: 116657 RVA: 0x008D5C8C File Offset: 0x008D3E8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipItemDescStateController(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			CommonUIStateController equipItemDescStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out equipItemDescStateController);
			businessCardUIController.m_luaExportHelper.m_equipItemDescStateController = equipItemDescStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C7B2 RID: 116658 RVA: 0x008D5CE8 File Offset: 0x008D3EE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipItemDescTitleText(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_equipItemDescTitleText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C7B3 RID: 116659 RVA: 0x008D5D40 File Offset: 0x008D3F40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipItemDescTitleText(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			Text equipItemDescTitleText;
			LuaObject.checkType<Text>(l, 2, out equipItemDescTitleText);
			businessCardUIController.m_luaExportHelper.m_equipItemDescTitleText = equipItemDescTitleText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C7B4 RID: 116660 RVA: 0x008D5D9C File Offset: 0x008D3F9C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_equipItemDescLvText(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_equipItemDescLvText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C7B5 RID: 116661 RVA: 0x008D5DF4 File Offset: 0x008D3FF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipItemDescLvText(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			Text equipItemDescLvText;
			LuaObject.checkType<Text>(l, 2, out equipItemDescLvText);
			businessCardUIController.m_luaExportHelper.m_equipItemDescLvText = equipItemDescLvText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C7B6 RID: 116662 RVA: 0x008D5E50 File Offset: 0x008D4050
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipItemDescExpText(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_equipItemDescExpText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C7B7 RID: 116663 RVA: 0x008D5EA8 File Offset: 0x008D40A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipItemDescExpText(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			Text equipItemDescExpText;
			LuaObject.checkType<Text>(l, 2, out equipItemDescExpText);
			businessCardUIController.m_luaExportHelper.m_equipItemDescExpText = equipItemDescExpText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C7B8 RID: 116664 RVA: 0x008D5F04 File Offset: 0x008D4104
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipItemDescIconImage(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_equipItemDescIconImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C7B9 RID: 116665 RVA: 0x008D5F5C File Offset: 0x008D415C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipItemDescIconImage(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			Image equipItemDescIconImage;
			LuaObject.checkType<Image>(l, 2, out equipItemDescIconImage);
			businessCardUIController.m_luaExportHelper.m_equipItemDescIconImage = equipItemDescIconImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C7BA RID: 116666 RVA: 0x008D5FB8 File Offset: 0x008D41B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipItemDescIconBg(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_equipItemDescIconBg);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C7BB RID: 116667 RVA: 0x008D6010 File Offset: 0x008D4210
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipItemDescIconBg(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			Image equipItemDescIconBg;
			LuaObject.checkType<Image>(l, 2, out equipItemDescIconBg);
			businessCardUIController.m_luaExportHelper.m_equipItemDescIconBg = equipItemDescIconBg;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C7BC RID: 116668 RVA: 0x008D606C File Offset: 0x008D426C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipItemDescSSREffect(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_equipItemDescSSREffect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C7BD RID: 116669 RVA: 0x008D60C4 File Offset: 0x008D42C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipItemDescSSREffect(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			GameObject equipItemDescSSREffect;
			LuaObject.checkType<GameObject>(l, 2, out equipItemDescSSREffect);
			businessCardUIController.m_luaExportHelper.m_equipItemDescSSREffect = equipItemDescSSREffect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C7BE RID: 116670 RVA: 0x008D6120 File Offset: 0x008D4320
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipItemDescProgressImage(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_equipItemDescProgressImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C7BF RID: 116671 RVA: 0x008D6178 File Offset: 0x008D4378
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipItemDescProgressImage(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			Image equipItemDescProgressImage;
			LuaObject.checkType<Image>(l, 2, out equipItemDescProgressImage);
			businessCardUIController.m_luaExportHelper.m_equipItemDescProgressImage = equipItemDescProgressImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C7C0 RID: 116672 RVA: 0x008D61D4 File Offset: 0x008D43D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipItemDescStarGroup(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_equipItemDescStarGroup);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C7C1 RID: 116673 RVA: 0x008D622C File Offset: 0x008D442C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipItemDescStarGroup(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			GameObject equipItemDescStarGroup;
			LuaObject.checkType<GameObject>(l, 2, out equipItemDescStarGroup);
			businessCardUIController.m_luaExportHelper.m_equipItemDescStarGroup = equipItemDescStarGroup;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C7C2 RID: 116674 RVA: 0x008D6288 File Offset: 0x008D4488
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipItemDescEquipLimitContent(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_equipItemDescEquipLimitContent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C7C3 RID: 116675 RVA: 0x008D62E0 File Offset: 0x008D44E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipItemDescEquipLimitContent(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			GameObject equipItemDescEquipLimitContent;
			LuaObject.checkType<GameObject>(l, 2, out equipItemDescEquipLimitContent);
			businessCardUIController.m_luaExportHelper.m_equipItemDescEquipLimitContent = equipItemDescEquipLimitContent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C7C4 RID: 116676 RVA: 0x008D633C File Offset: 0x008D453C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipItemDescPropContent(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_equipItemDescPropContent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C7C5 RID: 116677 RVA: 0x008D6394 File Offset: 0x008D4594
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipItemDescPropContent(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			GameObject equipItemDescPropContent;
			LuaObject.checkType<GameObject>(l, 2, out equipItemDescPropContent);
			businessCardUIController.m_luaExportHelper.m_equipItemDescPropContent = equipItemDescPropContent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C7C6 RID: 116678 RVA: 0x008D63F0 File Offset: 0x008D45F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipItemDescPropATGo(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_equipItemDescPropATGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C7C7 RID: 116679 RVA: 0x008D6448 File Offset: 0x008D4648
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipItemDescPropATGo(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			GameObject equipItemDescPropATGo;
			LuaObject.checkType<GameObject>(l, 2, out equipItemDescPropATGo);
			businessCardUIController.m_luaExportHelper.m_equipItemDescPropATGo = equipItemDescPropATGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C7C8 RID: 116680 RVA: 0x008D64A4 File Offset: 0x008D46A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipItemDescPropATValueText(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_equipItemDescPropATValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C7C9 RID: 116681 RVA: 0x008D64FC File Offset: 0x008D46FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipItemDescPropATValueText(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			Text equipItemDescPropATValueText;
			LuaObject.checkType<Text>(l, 2, out equipItemDescPropATValueText);
			businessCardUIController.m_luaExportHelper.m_equipItemDescPropATValueText = equipItemDescPropATValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C7CA RID: 116682 RVA: 0x008D6558 File Offset: 0x008D4758
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipItemDescPropDFGo(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_equipItemDescPropDFGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C7CB RID: 116683 RVA: 0x008D65B0 File Offset: 0x008D47B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipItemDescPropDFGo(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			GameObject equipItemDescPropDFGo;
			LuaObject.checkType<GameObject>(l, 2, out equipItemDescPropDFGo);
			businessCardUIController.m_luaExportHelper.m_equipItemDescPropDFGo = equipItemDescPropDFGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C7CC RID: 116684 RVA: 0x008D660C File Offset: 0x008D480C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipItemDescPropDFValueText(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_equipItemDescPropDFValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C7CD RID: 116685 RVA: 0x008D6664 File Offset: 0x008D4864
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipItemDescPropDFValueText(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			Text equipItemDescPropDFValueText;
			LuaObject.checkType<Text>(l, 2, out equipItemDescPropDFValueText);
			businessCardUIController.m_luaExportHelper.m_equipItemDescPropDFValueText = equipItemDescPropDFValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C7CE RID: 116686 RVA: 0x008D66C0 File Offset: 0x008D48C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipItemDescPropHPGo(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_equipItemDescPropHPGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C7CF RID: 116687 RVA: 0x008D6718 File Offset: 0x008D4918
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipItemDescPropHPGo(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			GameObject equipItemDescPropHPGo;
			LuaObject.checkType<GameObject>(l, 2, out equipItemDescPropHPGo);
			businessCardUIController.m_luaExportHelper.m_equipItemDescPropHPGo = equipItemDescPropHPGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C7D0 RID: 116688 RVA: 0x008D6774 File Offset: 0x008D4974
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipItemDescPropHPValueText(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_equipItemDescPropHPValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C7D1 RID: 116689 RVA: 0x008D67CC File Offset: 0x008D49CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipItemDescPropHPValueText(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			Text equipItemDescPropHPValueText;
			LuaObject.checkType<Text>(l, 2, out equipItemDescPropHPValueText);
			businessCardUIController.m_luaExportHelper.m_equipItemDescPropHPValueText = equipItemDescPropHPValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C7D2 RID: 116690 RVA: 0x008D6828 File Offset: 0x008D4A28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipItemDescPropMagiccGo(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_equipItemDescPropMagiccGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C7D3 RID: 116691 RVA: 0x008D6880 File Offset: 0x008D4A80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipItemDescPropMagiccGo(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			GameObject equipItemDescPropMagiccGo;
			LuaObject.checkType<GameObject>(l, 2, out equipItemDescPropMagiccGo);
			businessCardUIController.m_luaExportHelper.m_equipItemDescPropMagiccGo = equipItemDescPropMagiccGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C7D4 RID: 116692 RVA: 0x008D68DC File Offset: 0x008D4ADC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipItemDescPropMagicValueText(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_equipItemDescPropMagicValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C7D5 RID: 116693 RVA: 0x008D6934 File Offset: 0x008D4B34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipItemDescPropMagicValueText(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			Text equipItemDescPropMagicValueText;
			LuaObject.checkType<Text>(l, 2, out equipItemDescPropMagicValueText);
			businessCardUIController.m_luaExportHelper.m_equipItemDescPropMagicValueText = equipItemDescPropMagicValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C7D6 RID: 116694 RVA: 0x008D6990 File Offset: 0x008D4B90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipItemDescPropMagicDFGo(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_equipItemDescPropMagicDFGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C7D7 RID: 116695 RVA: 0x008D69E8 File Offset: 0x008D4BE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipItemDescPropMagicDFGo(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			GameObject equipItemDescPropMagicDFGo;
			LuaObject.checkType<GameObject>(l, 2, out equipItemDescPropMagicDFGo);
			businessCardUIController.m_luaExportHelper.m_equipItemDescPropMagicDFGo = equipItemDescPropMagicDFGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C7D8 RID: 116696 RVA: 0x008D6A44 File Offset: 0x008D4C44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipItemDescPropMagicDFValueText(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_equipItemDescPropMagicDFValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C7D9 RID: 116697 RVA: 0x008D6A9C File Offset: 0x008D4C9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipItemDescPropMagicDFValueText(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			Text equipItemDescPropMagicDFValueText;
			LuaObject.checkType<Text>(l, 2, out equipItemDescPropMagicDFValueText);
			businessCardUIController.m_luaExportHelper.m_equipItemDescPropMagicDFValueText = equipItemDescPropMagicDFValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C7DA RID: 116698 RVA: 0x008D6AF8 File Offset: 0x008D4CF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipItemDescPropDexGo(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_equipItemDescPropDexGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C7DB RID: 116699 RVA: 0x008D6B50 File Offset: 0x008D4D50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipItemDescPropDexGo(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			GameObject equipItemDescPropDexGo;
			LuaObject.checkType<GameObject>(l, 2, out equipItemDescPropDexGo);
			businessCardUIController.m_luaExportHelper.m_equipItemDescPropDexGo = equipItemDescPropDexGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C7DC RID: 116700 RVA: 0x008D6BAC File Offset: 0x008D4DAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipItemDescPropDexValueText(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_equipItemDescPropDexValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C7DD RID: 116701 RVA: 0x008D6C04 File Offset: 0x008D4E04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipItemDescPropDexValueText(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			Text equipItemDescPropDexValueText;
			LuaObject.checkType<Text>(l, 2, out equipItemDescPropDexValueText);
			businessCardUIController.m_luaExportHelper.m_equipItemDescPropDexValueText = equipItemDescPropDexValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C7DE RID: 116702 RVA: 0x008D6C60 File Offset: 0x008D4E60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipItemDescSkillContent(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_equipItemDescSkillContent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C7DF RID: 116703 RVA: 0x008D6CB8 File Offset: 0x008D4EB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipItemDescSkillContent(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			GameObject equipItemDescSkillContent;
			LuaObject.checkType<GameObject>(l, 2, out equipItemDescSkillContent);
			businessCardUIController.m_luaExportHelper.m_equipItemDescSkillContent = equipItemDescSkillContent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C7E0 RID: 116704 RVA: 0x008D6D14 File Offset: 0x008D4F14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipItemDescSkillNameText(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_equipItemDescSkillNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C7E1 RID: 116705 RVA: 0x008D6D6C File Offset: 0x008D4F6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipItemDescSkillNameText(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			Text equipItemDescSkillNameText;
			LuaObject.checkType<Text>(l, 2, out equipItemDescSkillNameText);
			businessCardUIController.m_luaExportHelper.m_equipItemDescSkillNameText = equipItemDescSkillNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C7E2 RID: 116706 RVA: 0x008D6DC8 File Offset: 0x008D4FC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipItemDescSkillLvText(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_equipItemDescSkillLvText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C7E3 RID: 116707 RVA: 0x008D6E20 File Offset: 0x008D5020
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipItemDescSkillLvText(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			Text equipItemDescSkillLvText;
			LuaObject.checkType<Text>(l, 2, out equipItemDescSkillLvText);
			businessCardUIController.m_luaExportHelper.m_equipItemDescSkillLvText = equipItemDescSkillLvText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C7E4 RID: 116708 RVA: 0x008D6E7C File Offset: 0x008D507C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipItemDescSkillOwnerText(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_equipItemDescSkillOwnerText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C7E5 RID: 116709 RVA: 0x008D6ED4 File Offset: 0x008D50D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipItemDescSkillOwnerText(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			Text equipItemDescSkillOwnerText;
			LuaObject.checkType<Text>(l, 2, out equipItemDescSkillOwnerText);
			businessCardUIController.m_luaExportHelper.m_equipItemDescSkillOwnerText = equipItemDescSkillOwnerText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C7E6 RID: 116710 RVA: 0x008D6F30 File Offset: 0x008D5130
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipItemDescSkillDescText(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_equipItemDescSkillDescText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C7E7 RID: 116711 RVA: 0x008D6F88 File Offset: 0x008D5188
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipItemDescSkillDescText(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			Text equipItemDescSkillDescText;
			LuaObject.checkType<Text>(l, 2, out equipItemDescSkillDescText);
			businessCardUIController.m_luaExportHelper.m_equipItemDescSkillDescText = equipItemDescSkillDescText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C7E8 RID: 116712 RVA: 0x008D6FE4 File Offset: 0x008D51E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipItemDescNotEquipSkillTip(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_equipItemDescNotEquipSkillTip);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C7E9 RID: 116713 RVA: 0x008D703C File Offset: 0x008D523C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipItemDescNotEquipSkillTip(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			GameObject equipItemDescNotEquipSkillTip;
			LuaObject.checkType<GameObject>(l, 2, out equipItemDescNotEquipSkillTip);
			businessCardUIController.m_luaExportHelper.m_equipItemDescNotEquipSkillTip = equipItemDescNotEquipSkillTip;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C7EA RID: 116714 RVA: 0x008D7098 File Offset: 0x008D5298
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_talentIconImage(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_talentIconImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C7EB RID: 116715 RVA: 0x008D70F0 File Offset: 0x008D52F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_talentIconImage(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			Image talentIconImage;
			LuaObject.checkType<Image>(l, 2, out talentIconImage);
			businessCardUIController.m_luaExportHelper.m_talentIconImage = talentIconImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C7EC RID: 116716 RVA: 0x008D714C File Offset: 0x008D534C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_talentButton(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_talentButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C7ED RID: 116717 RVA: 0x008D71A4 File Offset: 0x008D53A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_talentButton(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			Button talentButton;
			LuaObject.checkType<Button>(l, 2, out talentButton);
			businessCardUIController.m_luaExportHelper.m_talentButton = talentButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C7EE RID: 116718 RVA: 0x008D7200 File Offset: 0x008D5400
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroCurSkillGroup(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_heroCurSkillGroup);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C7EF RID: 116719 RVA: 0x008D7258 File Offset: 0x008D5458
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroCurSkillGroup(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			GameObject heroCurSkillGroup;
			LuaObject.checkType<GameObject>(l, 2, out heroCurSkillGroup);
			businessCardUIController.m_luaExportHelper.m_heroCurSkillGroup = heroCurSkillGroup;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C7F0 RID: 116720 RVA: 0x008D72B4 File Offset: 0x008D54B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroInfoCurSkillDescPanel(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_heroInfoCurSkillDescPanel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C7F1 RID: 116721 RVA: 0x008D730C File Offset: 0x008D550C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroInfoCurSkillDescPanel(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			GameObject heroInfoCurSkillDescPanel;
			LuaObject.checkType<GameObject>(l, 2, out heroInfoCurSkillDescPanel);
			businessCardUIController.m_luaExportHelper.m_heroInfoCurSkillDescPanel = heroInfoCurSkillDescPanel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C7F2 RID: 116722 RVA: 0x008D7368 File Offset: 0x008D5568
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_setCharInfoPanelUIStateController(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_setCharInfoPanelUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C7F3 RID: 116723 RVA: 0x008D73C0 File Offset: 0x008D55C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_setCharInfoPanelUIStateController(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			CommonUIStateController setCharInfoPanelUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out setCharInfoPanelUIStateController);
			businessCardUIController.m_luaExportHelper.m_setCharInfoPanelUIStateController = setCharInfoPanelUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C7F4 RID: 116724 RVA: 0x008D741C File Offset: 0x008D561C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_setCharInfoPanelConfirmButton(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_setCharInfoPanelConfirmButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C7F5 RID: 116725 RVA: 0x008D7474 File Offset: 0x008D5674
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_setCharInfoPanelConfirmButton(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			Button setCharInfoPanelConfirmButton;
			LuaObject.checkType<Button>(l, 2, out setCharInfoPanelConfirmButton);
			businessCardUIController.m_luaExportHelper.m_setCharInfoPanelConfirmButton = setCharInfoPanelConfirmButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C7F6 RID: 116726 RVA: 0x008D74D0 File Offset: 0x008D56D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_charFaceDropdown(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_charFaceDropdown);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C7F7 RID: 116727 RVA: 0x008D7528 File Offset: 0x008D5728
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_charFaceDropdown(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			Dropdown charFaceDropdown;
			LuaObject.checkType<Dropdown>(l, 2, out charFaceDropdown);
			businessCardUIController.m_luaExportHelper.m_charFaceDropdown = charFaceDropdown;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C7F8 RID: 116728 RVA: 0x008D7584 File Offset: 0x008D5784
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_charActiveDropdown(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_charActiveDropdown);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C7F9 RID: 116729 RVA: 0x008D75DC File Offset: 0x008D57DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_charActiveDropdown(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			Dropdown charActiveDropdown;
			LuaObject.checkType<Dropdown>(l, 2, out charActiveDropdown);
			businessCardUIController.m_luaExportHelper.m_charActiveDropdown = charActiveDropdown;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C7FA RID: 116730 RVA: 0x008D7638 File Offset: 0x008D5838
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_charGraphicParentDummy(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_charGraphicParentDummy);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C7FB RID: 116731 RVA: 0x008D7690 File Offset: 0x008D5890
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_charGraphicParentDummy(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			GameObject charGraphicParentDummy;
			LuaObject.checkType<GameObject>(l, 2, out charGraphicParentDummy);
			businessCardUIController.m_luaExportHelper.m_charGraphicParentDummy = charGraphicParentDummy;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C7FC RID: 116732 RVA: 0x008D76EC File Offset: 0x008D58EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_charNameText(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_charNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C7FD RID: 116733 RVA: 0x008D7744 File Offset: 0x008D5944
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_charNameText(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			Text charNameText;
			LuaObject.checkType<Text>(l, 2, out charNameText);
			businessCardUIController.m_luaExportHelper.m_charNameText = charNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C7FE RID: 116734 RVA: 0x008D77A0 File Offset: 0x008D59A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroSelectPanelUIStateController(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_heroSelectPanelUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C7FF RID: 116735 RVA: 0x008D77F8 File Offset: 0x008D59F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroSelectPanelUIStateController(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			CommonUIStateController heroSelectPanelUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out heroSelectPanelUIStateController);
			businessCardUIController.m_luaExportHelper.m_heroSelectPanelUIStateController = heroSelectPanelUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C800 RID: 116736 RVA: 0x008D7854 File Offset: 0x008D5A54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroListContent(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_heroListContent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C801 RID: 116737 RVA: 0x008D78AC File Offset: 0x008D5AAC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_heroListContent(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			GameObject heroListContent;
			LuaObject.checkType<GameObject>(l, 2, out heroListContent);
			businessCardUIController.m_luaExportHelper.m_heroListContent = heroListContent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C802 RID: 116738 RVA: 0x008D7908 File Offset: 0x008D5B08
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_heroSelectPanelConfirmButton(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_heroSelectPanelConfirmButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C803 RID: 116739 RVA: 0x008D7960 File Offset: 0x008D5B60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroSelectPanelConfirmButton(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			Button heroSelectPanelConfirmButton;
			LuaObject.checkType<Button>(l, 2, out heroSelectPanelConfirmButton);
			businessCardUIController.m_luaExportHelper.m_heroSelectPanelConfirmButton = heroSelectPanelConfirmButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C804 RID: 116740 RVA: 0x008D79BC File Offset: 0x008D5BBC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_heroListItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_heroListItemPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C805 RID: 116741 RVA: 0x008D7A14 File Offset: 0x008D5C14
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_heroListItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			GameObject heroListItemPrefab;
			LuaObject.checkType<GameObject>(l, 2, out heroListItemPrefab);
			businessCardUIController.m_luaExportHelper.m_heroListItemPrefab = heroListItemPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C806 RID: 116742 RVA: 0x008D7A70 File Offset: 0x008D5C70
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_heroCharItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_heroCharItemPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C807 RID: 116743 RVA: 0x008D7AC8 File Offset: 0x008D5CC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroCharItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			GameObject heroCharItemPrefab;
			LuaObject.checkType<GameObject>(l, 2, out heroCharItemPrefab);
			businessCardUIController.m_luaExportHelper.m_heroCharItemPrefab = heroCharItemPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C808 RID: 116744 RVA: 0x008D7B24 File Offset: 0x008D5D24
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_heroGroupItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_heroGroupItemPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C809 RID: 116745 RVA: 0x008D7B7C File Offset: 0x008D5D7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroGroupItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			GameObject heroGroupItemPrefab;
			LuaObject.checkType<GameObject>(l, 2, out heroGroupItemPrefab);
			businessCardUIController.m_luaExportHelper.m_heroGroupItemPrefab = heroGroupItemPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C80A RID: 116746 RVA: 0x008D7BD8 File Offset: 0x008D5DD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_currentCharSpineGraphic(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_currentCharSpineGraphic);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C80B RID: 116747 RVA: 0x008D7C30 File Offset: 0x008D5E30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_currentCharSpineGraphic(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			UISpineGraphic currentCharSpineGraphic;
			LuaObject.checkType<UISpineGraphic>(l, 2, out currentCharSpineGraphic);
			businessCardUIController.m_luaExportHelper.m_currentCharSpineGraphic = currentCharSpineGraphic;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C80C RID: 116748 RVA: 0x008D7C8C File Offset: 0x008D5E8C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_currentHeroDirectionType(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)businessCardUIController.m_luaExportHelper.m_currentHeroDirectionType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C80D RID: 116749 RVA: 0x008D7CE4 File Offset: 0x008D5EE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_currentHeroDirectionType(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			HeroDirectionType currentHeroDirectionType;
			LuaObject.checkEnum<HeroDirectionType>(l, 2, out currentHeroDirectionType);
			businessCardUIController.m_luaExportHelper.m_currentHeroDirectionType = currentHeroDirectionType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C80E RID: 116750 RVA: 0x008D7D40 File Offset: 0x008D5F40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_currentHeroAnimationType(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)businessCardUIController.m_luaExportHelper.m_currentHeroAnimationType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C80F RID: 116751 RVA: 0x008D7D98 File Offset: 0x008D5F98
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_currentHeroAnimationType(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			HeroActionType currentHeroAnimationType;
			LuaObject.checkEnum<HeroActionType>(l, 2, out currentHeroAnimationType);
			businessCardUIController.m_luaExportHelper.m_currentHeroAnimationType = currentHeroAnimationType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C810 RID: 116752 RVA: 0x008D7DF4 File Offset: 0x008D5FF4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_businessCard(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_businessCard);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C811 RID: 116753 RVA: 0x008D7E4C File Offset: 0x008D604C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_businessCard(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			BusinessCard businessCard;
			LuaObject.checkType<BusinessCard>(l, 2, out businessCard);
			businessCardUIController.m_luaExportHelper.m_businessCard = businessCard;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C812 RID: 116754 RVA: 0x008D7EA8 File Offset: 0x008D60A8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_isMe(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_isMe);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C813 RID: 116755 RVA: 0x008D7F00 File Offset: 0x008D6100
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isMe(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			bool isMe;
			LuaObject.checkType(l, 2, out isMe);
			businessCardUIController.m_luaExportHelper.m_isMe = isMe;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C814 RID: 116756 RVA: 0x008D7F5C File Offset: 0x008D615C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_currentSelectPositionIndex(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_currentSelectPositionIndex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C815 RID: 116757 RVA: 0x008D7FB4 File Offset: 0x008D61B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_currentSelectPositionIndex(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			int currentSelectPositionIndex;
			LuaObject.checkType(l, 2, out currentSelectPositionIndex);
			businessCardUIController.m_luaExportHelper.m_currentSelectPositionIndex = currentSelectPositionIndex;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C816 RID: 116758 RVA: 0x008D8010 File Offset: 0x008D6210
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_currentSelectBattleHero(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_currentSelectBattleHero);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C817 RID: 116759 RVA: 0x008D8068 File Offset: 0x008D6268
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_currentSelectBattleHero(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			BattleHero currentSelectBattleHero;
			LuaObject.checkType<BattleHero>(l, 2, out currentSelectBattleHero);
			businessCardUIController.m_luaExportHelper.m_currentSelectBattleHero = currentSelectBattleHero;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C818 RID: 116760 RVA: 0x008D80C4 File Offset: 0x008D62C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillDummyList(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_skillDummyList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C819 RID: 116761 RVA: 0x008D811C File Offset: 0x008D631C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillDummyList(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			List<GameObject> skillDummyList;
			LuaObject.checkType<List<GameObject>>(l, 2, out skillDummyList);
			businessCardUIController.m_luaExportHelper.m_skillDummyList = skillDummyList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C81A RID: 116762 RVA: 0x008D8178 File Offset: 0x008D6378
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_currentHeroSetList(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_currentHeroSetList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C81B RID: 116763 RVA: 0x008D81D0 File Offset: 0x008D63D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_currentHeroSetList(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			List<BusinessCardHeroSet> currentHeroSetList;
			LuaObject.checkType<List<BusinessCardHeroSet>>(l, 2, out currentHeroSetList);
			businessCardUIController.m_luaExportHelper.m_currentHeroSetList = currentHeroSetList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C81C RID: 116764 RVA: 0x008D822C File Offset: 0x008D642C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_graphicList(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_graphicList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C81D RID: 116765 RVA: 0x008D8284 File Offset: 0x008D6484
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_graphicList(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			List<BusinessCardUIController.GraphicInfo> graphicList;
			LuaObject.checkType<List<BusinessCardUIController.GraphicInfo>>(l, 2, out graphicList);
			businessCardUIController.m_luaExportHelper.m_graphicList = graphicList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C81E RID: 116766 RVA: 0x008D82E0 File Offset: 0x008D64E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroSortList(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_heroSortList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C81F RID: 116767 RVA: 0x008D8338 File Offset: 0x008D6538
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroSortList(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			List<Hero> heroSortList;
			LuaObject.checkType<List<Hero>>(l, 2, out heroSortList);
			businessCardUIController.m_luaExportHelper.m_heroSortList = heroSortList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C820 RID: 116768 RVA: 0x008D8394 File Offset: 0x008D6594
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isSelectArray(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_isSelectArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C821 RID: 116769 RVA: 0x008D83EC File Offset: 0x008D65EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isSelectArray(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			bool[] isSelectArray;
			LuaObject.checkArray<bool>(l, 2, out isSelectArray);
			businessCardUIController.m_luaExportHelper.m_isSelectArray = isSelectArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C822 RID: 116770 RVA: 0x008D8448 File Offset: 0x008D6648
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_HeroTeamMaxCount(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, BusinessCardUIController.LuaExportHelper.HeroTeamMaxCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C823 RID: 116771 RVA: 0x008D8490 File Offset: 0x008D6690
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_fDebugReportTime(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_fDebugReportTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C824 RID: 116772 RVA: 0x008D84E8 File Offset: 0x008D66E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_fDebugReportTime(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			float fDebugReportTime;
			LuaObject.checkType(l, 2, out fDebugReportTime);
			businessCardUIController.m_luaExportHelper.m_fDebugReportTime = fDebugReportTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C825 RID: 116773 RVA: 0x008D8544 File Offset: 0x008D6744
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_playerContext);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C826 RID: 116774 RVA: 0x008D859C File Offset: 0x008D679C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			ProjectLPlayerContext playerContext;
			LuaObject.checkType<ProjectLPlayerContext>(l, 2, out playerContext);
			businessCardUIController.m_luaExportHelper.m_playerContext = playerContext;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C827 RID: 116775 RVA: 0x008D85F8 File Offset: 0x008D67F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUIController.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C828 RID: 116776 RVA: 0x008D8650 File Offset: 0x008D6850
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController businessCardUIController = (BusinessCardUIController)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			businessCardUIController.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C829 RID: 116777 RVA: 0x008D86AC File Offset: 0x008D68AC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.BusinessCardUIController");
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.ShowOpenState);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.SetPlayerInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.SetRandomShowToggleOff);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.PlayerSignUpdateSuccess);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.PlayerSignUpdateEnd);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.CheckARState);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.SetTeam);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.OnHeroCharClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.ClearTeam);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.SetHeroInfoPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.SetHeroTalent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.SetHeroProperty);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.SetCurSelectSkills);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.OnSkillItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.OnTalentItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.SetEquipment);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.ClearEquipmentItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.SetEquipmentItemInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.OnEquipmentItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.OnEquipmentItemBGButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.SetEquipmentItemDesc);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.SetPropItems);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.SetCharInfoPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.OnCharDiretionValueChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.OnCharAnimationValueChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.CreateSpineGraphic);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.SetCharAction);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.SetHeroSelectPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.HeroListItemCompare);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.OnReturnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.OnLikeButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.OnRandowShowToggleValueChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.OnSetPanelBGButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.OnChangeSignButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.OnArButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.OnPlayerSignEditEnd);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.OnHeroItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.OnHeroInfoPanelSettingButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.OnHeroInfoPanelChangeButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.OnSetCharPanelConfirmButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.OnHeroSelectPanelConfirmButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache29);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.Update);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache2A);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache2B);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache2C);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache2D);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache2E);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache2F);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache30);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache31);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache32);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache33);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache34);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache35);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache36);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache37);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.__callDele_EventOnArClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache38);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.__clearDele_EventOnArClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache39);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.__callDele_EventOnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache3A);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.__clearDele_EventOnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache3B);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.__callDele_EventOnLike);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache3C);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.__clearDele_EventOnLike);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache3D);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.__callDele_EventOnChangeSign);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache3E);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.__clearDele_EventOnChangeSign);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache3F);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.__callDele_EventOnUpdateHeroSet);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache40);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.__clearDele_EventOnUpdateHeroSet);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache41);
		string name = "EventOnArClick";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_EventOnArClick);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache42, true);
		string name2 = "EventOnReturn";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_EventOnReturn);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache43, true);
		string name3 = "EventOnLike";
		LuaCSFunction get3 = null;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_EventOnLike);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache44, true);
		string name4 = "EventOnChangeSign";
		LuaCSFunction get4 = null;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_EventOnChangeSign);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache45, true);
		string name5 = "EventOnUpdateHeroSet";
		LuaCSFunction get5 = null;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_EventOnUpdateHeroSet);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache46, true);
		string name6 = "m_commonUIStateController";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_commonUIStateController);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache47;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_commonUIStateController);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache48, true);
		string name7 = "m_playerHeadIcon";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_playerHeadIcon);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache49;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_playerHeadIcon);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache4A, true);
		string name8 = "m_playerNameText";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_playerNameText);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache4B;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_playerNameText);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache4C, true);
		string name9 = "m_playerLevelText";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_playerLevelText);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache4D;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_playerLevelText);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache4E, true);
		string name10 = "m_playerPointText";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_playerPointText);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache4F;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_playerPointText);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache50, true);
		string name11 = "m_playerLikesCountText";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_playerLikesCountText);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache51;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_playerLikesCountText);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache52, true);
		string name12 = "m_randomShowToggle";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_randomShowToggle);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache53;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_randomShowToggle);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache54, true);
		string name13 = "m_likeButton";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache55 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache55 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_likeButton);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache55;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache56 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache56 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_likeButton);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache56, true);
		string name14 = "m_likeUIStateController";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache57 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache57 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_likeUIStateController);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache57;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache58 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache58 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_likeUIStateController);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache58, true);
		string name15 = "m_teamGraphicsParentGameObject";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache59 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache59 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_teamGraphicsParentGameObject);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache59;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache5A == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache5A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_teamGraphicsParentGameObject);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache5A, true);
		string name16 = "m_char0Dummy";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache5B == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache5B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_char0Dummy);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache5B;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache5C == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache5C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_char0Dummy);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache5C, true);
		string name17 = "m_char1Dummy";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache5D == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache5D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_char1Dummy);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache5D;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache5E == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache5E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_char1Dummy);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache5E, true);
		string name18 = "m_char2Dummy";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache5F == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache5F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_char2Dummy);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache5F;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache60 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache60 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_char2Dummy);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache60, true);
		string name19 = "m_char3Dummy";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache61 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache61 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_char3Dummy);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache61;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache62 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache62 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_char3Dummy);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache62, true);
		string name20 = "m_char4Dummy";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache63 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache63 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_char4Dummy);
		}
		LuaCSFunction get20 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache63;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache64 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache64 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_char4Dummy);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache64, true);
		string name21 = "m_playerSignText";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache65 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache65 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_playerSignText);
		}
		LuaCSFunction get21 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache65;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache66 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache66 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_playerSignText);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache66, true);
		string name22 = "m_playerInputField";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache67 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache67 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_playerInputField);
		}
		LuaCSFunction get22 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache67;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache68 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache68 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_playerInputField);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache68, true);
		string name23 = "m_changeSignButton";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache69 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache69 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_changeSignButton);
		}
		LuaCSFunction get23 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache69;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache6A == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache6A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_changeSignButton);
		}
		LuaObject.addMember(l, name23, get23, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache6A, true);
		string name24 = "m_heroGroupObj";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache6B == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache6B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_heroGroupObj);
		}
		LuaCSFunction get24 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache6B;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache6C == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache6C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_heroGroupObj);
		}
		LuaObject.addMember(l, name24, get24, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache6C, true);
		string name25 = "m_playerAllHeroPowerText";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache6D == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache6D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_playerAllHeroPowerText);
		}
		LuaCSFunction get25 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache6D;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache6E == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache6E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_playerAllHeroPowerText);
		}
		LuaObject.addMember(l, name25, get25, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache6E, true);
		string name26 = "m_playerReachedAchievementText";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache6F == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache6F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_playerReachedAchievementText);
		}
		LuaCSFunction get26 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache6F;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache70 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache70 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_playerReachedAchievementText);
		}
		LuaObject.addMember(l, name26, get26, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache70, true);
		string name27 = "m_playerMasterJobCountText";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache71 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache71 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_playerMasterJobCountText);
		}
		LuaCSFunction get27 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache71;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache72 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache72 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_playerMasterJobCountText);
		}
		LuaObject.addMember(l, name27, get27, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache72, true);
		string name28 = "m_stageGoalText";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache73 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache73 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_stageGoalText);
		}
		LuaCSFunction get28 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache73;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache74 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache74 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_stageGoalText);
		}
		LuaObject.addMember(l, name28, get28, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache74, true);
		string name29 = "m_riftGoalText";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache75 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache75 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_riftGoalText);
		}
		LuaCSFunction get29 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache75;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache76 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache76 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_riftGoalText);
		}
		LuaObject.addMember(l, name29, get29, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache76, true);
		string name30 = "m_returnButton";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache77 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache77 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_returnButton);
		}
		LuaCSFunction get30 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache77;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache78 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache78 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_returnButton);
		}
		LuaObject.addMember(l, name30, get30, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache78, true);
		string name31 = "m_arHeroListPanel";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache79 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache79 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_arHeroListPanel);
		}
		LuaCSFunction get31 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache79;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache7A == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache7A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_arHeroListPanel);
		}
		LuaObject.addMember(l, name31, get31, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache7A, true);
		string name32 = "m_arButton";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache7B == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache7B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_arButton);
		}
		LuaCSFunction get32 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache7B;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache7C == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache7C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_arButton);
		}
		LuaObject.addMember(l, name32, get32, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache7C, true);
		string name33 = "m_setPanelUIStateController";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache7D == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache7D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_setPanelUIStateController);
		}
		LuaCSFunction get33 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache7D;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache7E == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache7E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_setPanelUIStateController);
		}
		LuaObject.addMember(l, name33, get33, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache7E, true);
		string name34 = "m_setPanelBGButton";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache7F == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache7F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_setPanelBGButton);
		}
		LuaCSFunction get34 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache7F;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache80 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache80 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_setPanelBGButton);
		}
		LuaObject.addMember(l, name34, get34, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache80, true);
		string name35 = "m_heroInfoPanelUIStateController";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache81 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache81 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_heroInfoPanelUIStateController);
		}
		LuaCSFunction get35 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache81;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache82 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache82 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_heroInfoPanelUIStateController);
		}
		LuaObject.addMember(l, name35, get35, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache82, true);
		string name36 = "m_heroInfoPanelSettingButton";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache83 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache83 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_heroInfoPanelSettingButton);
		}
		LuaCSFunction get36 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache83;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache84 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache84 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_heroInfoPanelSettingButton);
		}
		LuaObject.addMember(l, name36, get36, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache84, true);
		string name37 = "m_heroInfoPanelChangeButton";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache85 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache85 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_heroInfoPanelChangeButton);
		}
		LuaCSFunction get37 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache85;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache86 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache86 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_heroInfoPanelChangeButton);
		}
		LuaObject.addMember(l, name37, get37, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache86, true);
		string name38 = "m_heroInfoArmyImage";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache87 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache87 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_heroInfoArmyImage);
		}
		LuaCSFunction get38 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache87;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache88 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache88 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_heroInfoArmyImage);
		}
		LuaObject.addMember(l, name38, get38, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache88, true);
		string name39 = "m_heroInfoLevelText";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache89 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache89 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_heroInfoLevelText);
		}
		LuaCSFunction get39 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache89;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache8A == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache8A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_heroInfoLevelText);
		}
		LuaObject.addMember(l, name39, get39, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache8A, true);
		string name40 = "m_heroInfoNameText";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache8B == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache8B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_heroInfoNameText);
		}
		LuaCSFunction get40 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache8B;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache8C == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache8C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_heroInfoNameText);
		}
		LuaObject.addMember(l, name40, get40, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache8C, true);
		string name41 = "m_heroInfoJobText";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache8D == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache8D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_heroInfoJobText);
		}
		LuaCSFunction get41 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache8D;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache8E == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache8E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_heroInfoJobText);
		}
		LuaObject.addMember(l, name41, get41, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache8E, true);
		string name42 = "m_heroInfoPowerText";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache8F == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache8F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_heroInfoPowerText);
		}
		LuaCSFunction get42 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache8F;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache90 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache90 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_heroInfoPowerText);
		}
		LuaObject.addMember(l, name42, get42, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache90, true);
		string name43 = "m_heroInfoGraphicDummy";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache91 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache91 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_heroInfoGraphicDummy);
		}
		LuaCSFunction get43 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache91;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache92 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache92 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_heroInfoGraphicDummy);
		}
		LuaObject.addMember(l, name43, get43, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache92, true);
		string name44 = "m_equipment1Dummy";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache93 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache93 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_equipment1Dummy);
		}
		LuaCSFunction get44 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache93;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache94 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache94 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_equipment1Dummy);
		}
		LuaObject.addMember(l, name44, get44, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache94, true);
		string name45 = "m_equipment2Dummy";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache95 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache95 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_equipment2Dummy);
		}
		LuaCSFunction get45 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache95;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache96 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache96 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_equipment2Dummy);
		}
		LuaObject.addMember(l, name45, get45, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache96, true);
		string name46 = "m_equipment3Dummy";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache97 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache97 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_equipment3Dummy);
		}
		LuaCSFunction get46 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache97;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache98 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache98 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_equipment3Dummy);
		}
		LuaObject.addMember(l, name46, get46, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache98, true);
		string name47 = "m_equipment4Dummy";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache99 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache99 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_equipment4Dummy);
		}
		LuaCSFunction get47 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache99;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache9A == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache9A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_equipment4Dummy);
		}
		LuaObject.addMember(l, name47, get47, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache9A, true);
		string name48 = "m_heroInfoPropHPImg";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache9B == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache9B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_heroInfoPropHPImg);
		}
		LuaCSFunction get48 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache9B;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache9C == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache9C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_heroInfoPropHPImg);
		}
		LuaObject.addMember(l, name48, get48, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache9C, true);
		string name49 = "m_heroInfoPropDFImg";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache9D == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache9D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_heroInfoPropDFImg);
		}
		LuaCSFunction get49 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache9D;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache9E == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache9E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_heroInfoPropDFImg);
		}
		LuaObject.addMember(l, name49, get49, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache9E, true);
		string name50 = "m_heroInfoPropATImg";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache9F == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache9F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_heroInfoPropATImg);
		}
		LuaCSFunction get50 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache9F;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheA0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheA0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_heroInfoPropATImg);
		}
		LuaObject.addMember(l, name50, get50, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheA0, true);
		string name51 = "m_heroInfoPropMagicDFImg";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheA1 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheA1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_heroInfoPropMagicDFImg);
		}
		LuaCSFunction get51 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheA1;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheA2 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheA2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_heroInfoPropMagicDFImg);
		}
		LuaObject.addMember(l, name51, get51, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheA2, true);
		string name52 = "m_heroInfoPropMagicImg";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheA3 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheA3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_heroInfoPropMagicImg);
		}
		LuaCSFunction get52 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheA3;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheA4 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheA4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_heroInfoPropMagicImg);
		}
		LuaObject.addMember(l, name52, get52, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheA4, true);
		string name53 = "m_heroInfoPropDEXImg";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheA5 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheA5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_heroInfoPropDEXImg);
		}
		LuaCSFunction get53 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheA5;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheA6 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheA6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_heroInfoPropDEXImg);
		}
		LuaObject.addMember(l, name53, get53, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheA6, true);
		string name54 = "m_heroInfoPropHPValueText";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheA7 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheA7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_heroInfoPropHPValueText);
		}
		LuaCSFunction get54 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheA7;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheA8 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheA8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_heroInfoPropHPValueText);
		}
		LuaObject.addMember(l, name54, get54, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheA8, true);
		string name55 = "m_heroInfoPropDFValueText";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheA9 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheA9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_heroInfoPropDFValueText);
		}
		LuaCSFunction get55 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheA9;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheAA == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheAA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_heroInfoPropDFValueText);
		}
		LuaObject.addMember(l, name55, get55, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheAA, true);
		string name56 = "m_heroInfoPropATValueText";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheAB == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheAB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_heroInfoPropATValueText);
		}
		LuaCSFunction get56 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheAB;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheAC == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheAC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_heroInfoPropATValueText);
		}
		LuaObject.addMember(l, name56, get56, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheAC, true);
		string name57 = "m_heroInfoPropMagicDFValueText";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheAD == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheAD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_heroInfoPropMagicDFValueText);
		}
		LuaCSFunction get57 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheAD;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheAE == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheAE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_heroInfoPropMagicDFValueText);
		}
		LuaObject.addMember(l, name57, get57, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheAE, true);
		string name58 = "m_heroInfoPropMagicValueText";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheAF == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheAF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_heroInfoPropMagicValueText);
		}
		LuaCSFunction get58 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheAF;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheB0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheB0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_heroInfoPropMagicValueText);
		}
		LuaObject.addMember(l, name58, get58, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheB0, true);
		string name59 = "m_heroInfoPropDEXValueText";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheB1 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheB1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_heroInfoPropDEXValueText);
		}
		LuaCSFunction get59 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheB1;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheB2 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheB2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_heroInfoPropDEXValueText);
		}
		LuaObject.addMember(l, name59, get59, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheB2, true);
		string name60 = "m_heroInfoPropHPAddText";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheB3 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheB3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_heroInfoPropHPAddText);
		}
		LuaCSFunction get60 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheB3;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheB4 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheB4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_heroInfoPropHPAddText);
		}
		LuaObject.addMember(l, name60, get60, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheB4, true);
		string name61 = "m_heroInfoPropDFAddText";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheB5 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheB5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_heroInfoPropDFAddText);
		}
		LuaCSFunction get61 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheB5;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheB6 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheB6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_heroInfoPropDFAddText);
		}
		LuaObject.addMember(l, name61, get61, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheB6, true);
		string name62 = "m_heroInfoPropATAddText";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheB7 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheB7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_heroInfoPropATAddText);
		}
		LuaCSFunction get62 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheB7;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheB8 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheB8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_heroInfoPropATAddText);
		}
		LuaObject.addMember(l, name62, get62, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheB8, true);
		string name63 = "m_heroInfoPropMagicDFAddText";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheB9 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheB9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_heroInfoPropMagicDFAddText);
		}
		LuaCSFunction get63 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheB9;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheBA == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheBA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_heroInfoPropMagicDFAddText);
		}
		LuaObject.addMember(l, name63, get63, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheBA, true);
		string name64 = "m_heroInfoPropMagicAddText";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheBB == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheBB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_heroInfoPropMagicAddText);
		}
		LuaCSFunction get64 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheBB;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheBC == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheBC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_heroInfoPropMagicAddText);
		}
		LuaObject.addMember(l, name64, get64, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheBC, true);
		string name65 = "m_heroInfoPropDEXAddText";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheBD == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheBD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_heroInfoPropDEXAddText);
		}
		LuaCSFunction get65 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheBD;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheBE == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheBE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_heroInfoPropDEXAddText);
		}
		LuaObject.addMember(l, name65, get65, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheBE, true);
		string name66 = "m_equipmentItemPrefab";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheBF == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheBF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_equipmentItemPrefab);
		}
		LuaCSFunction get66 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheBF;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheC0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheC0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_equipmentItemPrefab);
		}
		LuaObject.addMember(l, name66, get66, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheC0, true);
		string name67 = "m_equipItemDescBGButton";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheC1 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheC1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_equipItemDescBGButton);
		}
		LuaCSFunction get67 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheC1;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheC2 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheC2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_equipItemDescBGButton);
		}
		LuaObject.addMember(l, name67, get67, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheC2, true);
		string name68 = "m_equipItemDescStateController";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheC3 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheC3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_equipItemDescStateController);
		}
		LuaCSFunction get68 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheC3;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheC4 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheC4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_equipItemDescStateController);
		}
		LuaObject.addMember(l, name68, get68, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheC4, true);
		string name69 = "m_equipItemDescTitleText";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheC5 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheC5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_equipItemDescTitleText);
		}
		LuaCSFunction get69 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheC5;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheC6 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheC6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_equipItemDescTitleText);
		}
		LuaObject.addMember(l, name69, get69, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheC6, true);
		string name70 = "m_equipItemDescLvText";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheC7 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheC7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_equipItemDescLvText);
		}
		LuaCSFunction get70 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheC7;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheC8 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheC8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_equipItemDescLvText);
		}
		LuaObject.addMember(l, name70, get70, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheC8, true);
		string name71 = "m_equipItemDescExpText";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheC9 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheC9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_equipItemDescExpText);
		}
		LuaCSFunction get71 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheC9;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheCA == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheCA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_equipItemDescExpText);
		}
		LuaObject.addMember(l, name71, get71, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheCA, true);
		string name72 = "m_equipItemDescIconImage";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheCB == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheCB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_equipItemDescIconImage);
		}
		LuaCSFunction get72 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheCB;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheCC == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheCC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_equipItemDescIconImage);
		}
		LuaObject.addMember(l, name72, get72, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheCC, true);
		string name73 = "m_equipItemDescIconBg";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheCD == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheCD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_equipItemDescIconBg);
		}
		LuaCSFunction get73 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheCD;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheCE == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheCE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_equipItemDescIconBg);
		}
		LuaObject.addMember(l, name73, get73, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheCE, true);
		string name74 = "m_equipItemDescSSREffect";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheCF == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheCF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_equipItemDescSSREffect);
		}
		LuaCSFunction get74 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheCF;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheD0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheD0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_equipItemDescSSREffect);
		}
		LuaObject.addMember(l, name74, get74, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheD0, true);
		string name75 = "m_equipItemDescProgressImage";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheD1 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheD1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_equipItemDescProgressImage);
		}
		LuaCSFunction get75 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheD1;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheD2 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheD2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_equipItemDescProgressImage);
		}
		LuaObject.addMember(l, name75, get75, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheD2, true);
		string name76 = "m_equipItemDescStarGroup";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheD3 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheD3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_equipItemDescStarGroup);
		}
		LuaCSFunction get76 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheD3;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheD4 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheD4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_equipItemDescStarGroup);
		}
		LuaObject.addMember(l, name76, get76, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheD4, true);
		string name77 = "m_equipItemDescEquipLimitContent";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheD5 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheD5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_equipItemDescEquipLimitContent);
		}
		LuaCSFunction get77 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheD5;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheD6 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheD6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_equipItemDescEquipLimitContent);
		}
		LuaObject.addMember(l, name77, get77, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheD6, true);
		string name78 = "m_equipItemDescPropContent";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheD7 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheD7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_equipItemDescPropContent);
		}
		LuaCSFunction get78 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheD7;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheD8 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheD8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_equipItemDescPropContent);
		}
		LuaObject.addMember(l, name78, get78, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheD8, true);
		string name79 = "m_equipItemDescPropATGo";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheD9 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheD9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_equipItemDescPropATGo);
		}
		LuaCSFunction get79 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheD9;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheDA == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheDA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_equipItemDescPropATGo);
		}
		LuaObject.addMember(l, name79, get79, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheDA, true);
		string name80 = "m_equipItemDescPropATValueText";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheDB == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheDB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_equipItemDescPropATValueText);
		}
		LuaCSFunction get80 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheDB;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheDC == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheDC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_equipItemDescPropATValueText);
		}
		LuaObject.addMember(l, name80, get80, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheDC, true);
		string name81 = "m_equipItemDescPropDFGo";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheDD == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheDD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_equipItemDescPropDFGo);
		}
		LuaCSFunction get81 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheDD;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheDE == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheDE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_equipItemDescPropDFGo);
		}
		LuaObject.addMember(l, name81, get81, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheDE, true);
		string name82 = "m_equipItemDescPropDFValueText";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheDF == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheDF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_equipItemDescPropDFValueText);
		}
		LuaCSFunction get82 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheDF;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheE0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheE0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_equipItemDescPropDFValueText);
		}
		LuaObject.addMember(l, name82, get82, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheE0, true);
		string name83 = "m_equipItemDescPropHPGo";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheE1 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheE1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_equipItemDescPropHPGo);
		}
		LuaCSFunction get83 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheE1;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheE2 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheE2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_equipItemDescPropHPGo);
		}
		LuaObject.addMember(l, name83, get83, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheE2, true);
		string name84 = "m_equipItemDescPropHPValueText";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheE3 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheE3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_equipItemDescPropHPValueText);
		}
		LuaCSFunction get84 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheE3;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheE4 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheE4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_equipItemDescPropHPValueText);
		}
		LuaObject.addMember(l, name84, get84, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheE4, true);
		string name85 = "m_equipItemDescPropMagiccGo";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheE5 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheE5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_equipItemDescPropMagiccGo);
		}
		LuaCSFunction get85 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheE5;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheE6 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheE6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_equipItemDescPropMagiccGo);
		}
		LuaObject.addMember(l, name85, get85, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheE6, true);
		string name86 = "m_equipItemDescPropMagicValueText";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheE7 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheE7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_equipItemDescPropMagicValueText);
		}
		LuaCSFunction get86 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheE7;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheE8 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheE8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_equipItemDescPropMagicValueText);
		}
		LuaObject.addMember(l, name86, get86, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheE8, true);
		string name87 = "m_equipItemDescPropMagicDFGo";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheE9 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheE9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_equipItemDescPropMagicDFGo);
		}
		LuaCSFunction get87 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheE9;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheEA == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheEA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_equipItemDescPropMagicDFGo);
		}
		LuaObject.addMember(l, name87, get87, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheEA, true);
		string name88 = "m_equipItemDescPropMagicDFValueText";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheEB == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheEB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_equipItemDescPropMagicDFValueText);
		}
		LuaCSFunction get88 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheEB;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheEC == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheEC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_equipItemDescPropMagicDFValueText);
		}
		LuaObject.addMember(l, name88, get88, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheEC, true);
		string name89 = "m_equipItemDescPropDexGo";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheED == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheED = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_equipItemDescPropDexGo);
		}
		LuaCSFunction get89 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheED;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheEE == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheEE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_equipItemDescPropDexGo);
		}
		LuaObject.addMember(l, name89, get89, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheEE, true);
		string name90 = "m_equipItemDescPropDexValueText";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheEF == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheEF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_equipItemDescPropDexValueText);
		}
		LuaCSFunction get90 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheEF;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheF0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheF0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_equipItemDescPropDexValueText);
		}
		LuaObject.addMember(l, name90, get90, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheF0, true);
		string name91 = "m_equipItemDescSkillContent";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheF1 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheF1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_equipItemDescSkillContent);
		}
		LuaCSFunction get91 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheF1;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheF2 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheF2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_equipItemDescSkillContent);
		}
		LuaObject.addMember(l, name91, get91, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheF2, true);
		string name92 = "m_equipItemDescSkillNameText";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheF3 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheF3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_equipItemDescSkillNameText);
		}
		LuaCSFunction get92 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheF3;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheF4 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheF4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_equipItemDescSkillNameText);
		}
		LuaObject.addMember(l, name92, get92, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheF4, true);
		string name93 = "m_equipItemDescSkillLvText";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheF5 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheF5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_equipItemDescSkillLvText);
		}
		LuaCSFunction get93 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheF5;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheF6 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheF6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_equipItemDescSkillLvText);
		}
		LuaObject.addMember(l, name93, get93, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheF6, true);
		string name94 = "m_equipItemDescSkillOwnerText";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheF7 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheF7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_equipItemDescSkillOwnerText);
		}
		LuaCSFunction get94 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheF7;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheF8 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheF8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_equipItemDescSkillOwnerText);
		}
		LuaObject.addMember(l, name94, get94, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheF8, true);
		string name95 = "m_equipItemDescSkillDescText";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheF9 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheF9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_equipItemDescSkillDescText);
		}
		LuaCSFunction get95 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheF9;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheFA == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheFA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_equipItemDescSkillDescText);
		}
		LuaObject.addMember(l, name95, get95, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheFA, true);
		string name96 = "m_equipItemDescNotEquipSkillTip";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheFB == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheFB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_equipItemDescNotEquipSkillTip);
		}
		LuaCSFunction get96 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheFB;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheFC == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheFC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_equipItemDescNotEquipSkillTip);
		}
		LuaObject.addMember(l, name96, get96, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheFC, true);
		string name97 = "m_talentIconImage";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheFD == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheFD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_talentIconImage);
		}
		LuaCSFunction get97 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheFD;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheFE == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheFE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_talentIconImage);
		}
		LuaObject.addMember(l, name97, get97, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheFE, true);
		string name98 = "m_talentButton";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheFF == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheFF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_talentButton);
		}
		LuaCSFunction get98 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cacheFF;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache100 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache100 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_talentButton);
		}
		LuaObject.addMember(l, name98, get98, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache100, true);
		string name99 = "m_heroCurSkillGroup";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache101 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache101 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_heroCurSkillGroup);
		}
		LuaCSFunction get99 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache101;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache102 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache102 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_heroCurSkillGroup);
		}
		LuaObject.addMember(l, name99, get99, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache102, true);
		string name100 = "m_heroInfoCurSkillDescPanel";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache103 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache103 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_heroInfoCurSkillDescPanel);
		}
		LuaCSFunction get100 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache103;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache104 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache104 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_heroInfoCurSkillDescPanel);
		}
		LuaObject.addMember(l, name100, get100, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache104, true);
		string name101 = "m_setCharInfoPanelUIStateController";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache105 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache105 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_setCharInfoPanelUIStateController);
		}
		LuaCSFunction get101 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache105;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache106 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache106 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_setCharInfoPanelUIStateController);
		}
		LuaObject.addMember(l, name101, get101, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache106, true);
		string name102 = "m_setCharInfoPanelConfirmButton";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache107 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache107 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_setCharInfoPanelConfirmButton);
		}
		LuaCSFunction get102 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache107;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache108 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache108 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_setCharInfoPanelConfirmButton);
		}
		LuaObject.addMember(l, name102, get102, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache108, true);
		string name103 = "m_charFaceDropdown";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache109 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache109 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_charFaceDropdown);
		}
		LuaCSFunction get103 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache109;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache10A == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache10A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_charFaceDropdown);
		}
		LuaObject.addMember(l, name103, get103, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache10A, true);
		string name104 = "m_charActiveDropdown";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache10B == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache10B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_charActiveDropdown);
		}
		LuaCSFunction get104 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache10B;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache10C == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache10C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_charActiveDropdown);
		}
		LuaObject.addMember(l, name104, get104, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache10C, true);
		string name105 = "m_charGraphicParentDummy";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache10D == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache10D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_charGraphicParentDummy);
		}
		LuaCSFunction get105 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache10D;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache10E == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache10E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_charGraphicParentDummy);
		}
		LuaObject.addMember(l, name105, get105, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache10E, true);
		string name106 = "m_charNameText";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache10F == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache10F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_charNameText);
		}
		LuaCSFunction get106 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache10F;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache110 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache110 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_charNameText);
		}
		LuaObject.addMember(l, name106, get106, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache110, true);
		string name107 = "m_heroSelectPanelUIStateController";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache111 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache111 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_heroSelectPanelUIStateController);
		}
		LuaCSFunction get107 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache111;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache112 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache112 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_heroSelectPanelUIStateController);
		}
		LuaObject.addMember(l, name107, get107, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache112, true);
		string name108 = "m_heroListContent";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache113 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache113 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_heroListContent);
		}
		LuaCSFunction get108 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache113;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache114 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache114 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_heroListContent);
		}
		LuaObject.addMember(l, name108, get108, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache114, true);
		string name109 = "m_heroSelectPanelConfirmButton";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache115 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache115 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_heroSelectPanelConfirmButton);
		}
		LuaCSFunction get109 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache115;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache116 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache116 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_heroSelectPanelConfirmButton);
		}
		LuaObject.addMember(l, name109, get109, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache116, true);
		string name110 = "m_heroListItemPrefab";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache117 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache117 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_heroListItemPrefab);
		}
		LuaCSFunction get110 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache117;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache118 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache118 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_heroListItemPrefab);
		}
		LuaObject.addMember(l, name110, get110, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache118, true);
		string name111 = "m_heroCharItemPrefab";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache119 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache119 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_heroCharItemPrefab);
		}
		LuaCSFunction get111 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache119;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache11A == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache11A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_heroCharItemPrefab);
		}
		LuaObject.addMember(l, name111, get111, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache11A, true);
		string name112 = "m_heroGroupItemPrefab";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache11B == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache11B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_heroGroupItemPrefab);
		}
		LuaCSFunction get112 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache11B;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache11C == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache11C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_heroGroupItemPrefab);
		}
		LuaObject.addMember(l, name112, get112, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache11C, true);
		string name113 = "m_currentCharSpineGraphic";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache11D == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache11D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_currentCharSpineGraphic);
		}
		LuaCSFunction get113 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache11D;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache11E == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache11E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_currentCharSpineGraphic);
		}
		LuaObject.addMember(l, name113, get113, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache11E, true);
		string name114 = "m_currentHeroDirectionType";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache11F == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache11F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_currentHeroDirectionType);
		}
		LuaCSFunction get114 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache11F;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache120 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache120 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_currentHeroDirectionType);
		}
		LuaObject.addMember(l, name114, get114, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache120, true);
		string name115 = "m_currentHeroAnimationType";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache121 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache121 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_currentHeroAnimationType);
		}
		LuaCSFunction get115 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache121;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache122 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache122 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_currentHeroAnimationType);
		}
		LuaObject.addMember(l, name115, get115, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache122, true);
		string name116 = "m_businessCard";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache123 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache123 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_businessCard);
		}
		LuaCSFunction get116 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache123;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache124 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache124 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_businessCard);
		}
		LuaObject.addMember(l, name116, get116, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache124, true);
		string name117 = "m_isMe";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache125 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache125 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_isMe);
		}
		LuaCSFunction get117 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache125;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache126 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache126 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_isMe);
		}
		LuaObject.addMember(l, name117, get117, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache126, true);
		string name118 = "m_currentSelectPositionIndex";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache127 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache127 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_currentSelectPositionIndex);
		}
		LuaCSFunction get118 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache127;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache128 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache128 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_currentSelectPositionIndex);
		}
		LuaObject.addMember(l, name118, get118, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache128, true);
		string name119 = "m_currentSelectBattleHero";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache129 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache129 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_currentSelectBattleHero);
		}
		LuaCSFunction get119 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache129;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache12A == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache12A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_currentSelectBattleHero);
		}
		LuaObject.addMember(l, name119, get119, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache12A, true);
		string name120 = "m_skillDummyList";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache12B == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache12B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_skillDummyList);
		}
		LuaCSFunction get120 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache12B;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache12C == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache12C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_skillDummyList);
		}
		LuaObject.addMember(l, name120, get120, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache12C, true);
		string name121 = "m_currentHeroSetList";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache12D == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache12D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_currentHeroSetList);
		}
		LuaCSFunction get121 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache12D;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache12E == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache12E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_currentHeroSetList);
		}
		LuaObject.addMember(l, name121, get121, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache12E, true);
		string name122 = "m_graphicList";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache12F == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache12F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_graphicList);
		}
		LuaCSFunction get122 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache12F;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache130 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache130 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_graphicList);
		}
		LuaObject.addMember(l, name122, get122, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache130, true);
		string name123 = "m_heroSortList";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache131 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache131 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_heroSortList);
		}
		LuaCSFunction get123 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache131;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache132 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache132 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_heroSortList);
		}
		LuaObject.addMember(l, name123, get123, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache132, true);
		string name124 = "m_isSelectArray";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache133 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache133 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_isSelectArray);
		}
		LuaCSFunction get124 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache133;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache134 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache134 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_isSelectArray);
		}
		LuaObject.addMember(l, name124, get124, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache134, true);
		string name125 = "HeroTeamMaxCount";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache135 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache135 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_HeroTeamMaxCount);
		}
		LuaObject.addMember(l, name125, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache135, null, false);
		string name126 = "m_fDebugReportTime";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache136 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache136 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_fDebugReportTime);
		}
		LuaCSFunction get125 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache136;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache137 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache137 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_fDebugReportTime);
		}
		LuaObject.addMember(l, name126, get125, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache137, true);
		string name127 = "m_playerContext";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache138 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache138 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_playerContext);
		}
		LuaCSFunction get126 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache138;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache139 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache139 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_playerContext);
		}
		LuaObject.addMember(l, name127, get126, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache139, true);
		string name128 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache13A == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache13A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.get_m_configDataLoader);
		}
		LuaCSFunction get127 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache13A;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache13B == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache13B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name128, get127, Lua_BlackJack_ProjectL_UI_BusinessCardUIController.<>f__mg$cache13B, true);
		LuaObject.createTypeMetatable(l, null, typeof(BusinessCardUIController), typeof(UIControllerBase));
	}

	// Token: 0x04012917 RID: 76055
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04012918 RID: 76056
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04012919 RID: 76057
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401291A RID: 76058
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401291B RID: 76059
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0401291C RID: 76060
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0401291D RID: 76061
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0401291E RID: 76062
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0401291F RID: 76063
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04012920 RID: 76064
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04012921 RID: 76065
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04012922 RID: 76066
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04012923 RID: 76067
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04012924 RID: 76068
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04012925 RID: 76069
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04012926 RID: 76070
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04012927 RID: 76071
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04012928 RID: 76072
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04012929 RID: 76073
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0401292A RID: 76074
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0401292B RID: 76075
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0401292C RID: 76076
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0401292D RID: 76077
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0401292E RID: 76078
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0401292F RID: 76079
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04012930 RID: 76080
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04012931 RID: 76081
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04012932 RID: 76082
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04012933 RID: 76083
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04012934 RID: 76084
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04012935 RID: 76085
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04012936 RID: 76086
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04012937 RID: 76087
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04012938 RID: 76088
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04012939 RID: 76089
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0401293A RID: 76090
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0401293B RID: 76091
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0401293C RID: 76092
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0401293D RID: 76093
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0401293E RID: 76094
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0401293F RID: 76095
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04012940 RID: 76096
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04012941 RID: 76097
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04012942 RID: 76098
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04012943 RID: 76099
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04012944 RID: 76100
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04012945 RID: 76101
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04012946 RID: 76102
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04012947 RID: 76103
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04012948 RID: 76104
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04012949 RID: 76105
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x0401294A RID: 76106
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x0401294B RID: 76107
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x0401294C RID: 76108
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x0401294D RID: 76109
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x0401294E RID: 76110
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x0401294F RID: 76111
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04012950 RID: 76112
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04012951 RID: 76113
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x04012952 RID: 76114
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x04012953 RID: 76115
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x04012954 RID: 76116
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x04012955 RID: 76117
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x04012956 RID: 76118
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x04012957 RID: 76119
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x04012958 RID: 76120
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x04012959 RID: 76121
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x0401295A RID: 76122
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x0401295B RID: 76123
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x0401295C RID: 76124
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x0401295D RID: 76125
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x0401295E RID: 76126
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x0401295F RID: 76127
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x04012960 RID: 76128
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x04012961 RID: 76129
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x04012962 RID: 76130
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x04012963 RID: 76131
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x04012964 RID: 76132
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x04012965 RID: 76133
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x04012966 RID: 76134
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x04012967 RID: 76135
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x04012968 RID: 76136
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x04012969 RID: 76137
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x0401296A RID: 76138
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x0401296B RID: 76139
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x0401296C RID: 76140
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x0401296D RID: 76141
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x0401296E RID: 76142
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x0401296F RID: 76143
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x04012970 RID: 76144
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;

	// Token: 0x04012971 RID: 76145
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5A;

	// Token: 0x04012972 RID: 76146
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5B;

	// Token: 0x04012973 RID: 76147
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5C;

	// Token: 0x04012974 RID: 76148
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5D;

	// Token: 0x04012975 RID: 76149
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5E;

	// Token: 0x04012976 RID: 76150
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5F;

	// Token: 0x04012977 RID: 76151
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache60;

	// Token: 0x04012978 RID: 76152
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache61;

	// Token: 0x04012979 RID: 76153
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache62;

	// Token: 0x0401297A RID: 76154
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache63;

	// Token: 0x0401297B RID: 76155
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache64;

	// Token: 0x0401297C RID: 76156
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache65;

	// Token: 0x0401297D RID: 76157
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache66;

	// Token: 0x0401297E RID: 76158
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache67;

	// Token: 0x0401297F RID: 76159
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache68;

	// Token: 0x04012980 RID: 76160
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache69;

	// Token: 0x04012981 RID: 76161
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6A;

	// Token: 0x04012982 RID: 76162
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6B;

	// Token: 0x04012983 RID: 76163
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6C;

	// Token: 0x04012984 RID: 76164
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6D;

	// Token: 0x04012985 RID: 76165
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6E;

	// Token: 0x04012986 RID: 76166
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6F;

	// Token: 0x04012987 RID: 76167
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache70;

	// Token: 0x04012988 RID: 76168
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache71;

	// Token: 0x04012989 RID: 76169
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache72;

	// Token: 0x0401298A RID: 76170
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache73;

	// Token: 0x0401298B RID: 76171
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache74;

	// Token: 0x0401298C RID: 76172
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache75;

	// Token: 0x0401298D RID: 76173
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache76;

	// Token: 0x0401298E RID: 76174
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache77;

	// Token: 0x0401298F RID: 76175
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache78;

	// Token: 0x04012990 RID: 76176
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache79;

	// Token: 0x04012991 RID: 76177
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7A;

	// Token: 0x04012992 RID: 76178
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7B;

	// Token: 0x04012993 RID: 76179
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7C;

	// Token: 0x04012994 RID: 76180
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7D;

	// Token: 0x04012995 RID: 76181
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7E;

	// Token: 0x04012996 RID: 76182
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7F;

	// Token: 0x04012997 RID: 76183
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache80;

	// Token: 0x04012998 RID: 76184
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache81;

	// Token: 0x04012999 RID: 76185
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache82;

	// Token: 0x0401299A RID: 76186
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache83;

	// Token: 0x0401299B RID: 76187
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache84;

	// Token: 0x0401299C RID: 76188
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache85;

	// Token: 0x0401299D RID: 76189
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache86;

	// Token: 0x0401299E RID: 76190
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache87;

	// Token: 0x0401299F RID: 76191
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache88;

	// Token: 0x040129A0 RID: 76192
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache89;

	// Token: 0x040129A1 RID: 76193
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8A;

	// Token: 0x040129A2 RID: 76194
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8B;

	// Token: 0x040129A3 RID: 76195
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8C;

	// Token: 0x040129A4 RID: 76196
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8D;

	// Token: 0x040129A5 RID: 76197
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8E;

	// Token: 0x040129A6 RID: 76198
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8F;

	// Token: 0x040129A7 RID: 76199
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache90;

	// Token: 0x040129A8 RID: 76200
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache91;

	// Token: 0x040129A9 RID: 76201
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache92;

	// Token: 0x040129AA RID: 76202
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache93;

	// Token: 0x040129AB RID: 76203
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache94;

	// Token: 0x040129AC RID: 76204
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache95;

	// Token: 0x040129AD RID: 76205
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache96;

	// Token: 0x040129AE RID: 76206
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache97;

	// Token: 0x040129AF RID: 76207
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache98;

	// Token: 0x040129B0 RID: 76208
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache99;

	// Token: 0x040129B1 RID: 76209
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9A;

	// Token: 0x040129B2 RID: 76210
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9B;

	// Token: 0x040129B3 RID: 76211
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9C;

	// Token: 0x040129B4 RID: 76212
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9D;

	// Token: 0x040129B5 RID: 76213
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9E;

	// Token: 0x040129B6 RID: 76214
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9F;

	// Token: 0x040129B7 RID: 76215
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA0;

	// Token: 0x040129B8 RID: 76216
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA1;

	// Token: 0x040129B9 RID: 76217
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA2;

	// Token: 0x040129BA RID: 76218
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA3;

	// Token: 0x040129BB RID: 76219
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA4;

	// Token: 0x040129BC RID: 76220
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA5;

	// Token: 0x040129BD RID: 76221
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA6;

	// Token: 0x040129BE RID: 76222
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA7;

	// Token: 0x040129BF RID: 76223
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA8;

	// Token: 0x040129C0 RID: 76224
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA9;

	// Token: 0x040129C1 RID: 76225
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAA;

	// Token: 0x040129C2 RID: 76226
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAB;

	// Token: 0x040129C3 RID: 76227
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAC;

	// Token: 0x040129C4 RID: 76228
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAD;

	// Token: 0x040129C5 RID: 76229
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAE;

	// Token: 0x040129C6 RID: 76230
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAF;

	// Token: 0x040129C7 RID: 76231
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB0;

	// Token: 0x040129C8 RID: 76232
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB1;

	// Token: 0x040129C9 RID: 76233
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB2;

	// Token: 0x040129CA RID: 76234
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB3;

	// Token: 0x040129CB RID: 76235
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB4;

	// Token: 0x040129CC RID: 76236
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB5;

	// Token: 0x040129CD RID: 76237
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB6;

	// Token: 0x040129CE RID: 76238
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB7;

	// Token: 0x040129CF RID: 76239
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB8;

	// Token: 0x040129D0 RID: 76240
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB9;

	// Token: 0x040129D1 RID: 76241
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBA;

	// Token: 0x040129D2 RID: 76242
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBB;

	// Token: 0x040129D3 RID: 76243
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBC;

	// Token: 0x040129D4 RID: 76244
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBD;

	// Token: 0x040129D5 RID: 76245
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBE;

	// Token: 0x040129D6 RID: 76246
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBF;

	// Token: 0x040129D7 RID: 76247
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC0;

	// Token: 0x040129D8 RID: 76248
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC1;

	// Token: 0x040129D9 RID: 76249
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC2;

	// Token: 0x040129DA RID: 76250
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC3;

	// Token: 0x040129DB RID: 76251
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC4;

	// Token: 0x040129DC RID: 76252
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC5;

	// Token: 0x040129DD RID: 76253
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC6;

	// Token: 0x040129DE RID: 76254
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC7;

	// Token: 0x040129DF RID: 76255
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC8;

	// Token: 0x040129E0 RID: 76256
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC9;

	// Token: 0x040129E1 RID: 76257
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCA;

	// Token: 0x040129E2 RID: 76258
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCB;

	// Token: 0x040129E3 RID: 76259
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCC;

	// Token: 0x040129E4 RID: 76260
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCD;

	// Token: 0x040129E5 RID: 76261
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCE;

	// Token: 0x040129E6 RID: 76262
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCF;

	// Token: 0x040129E7 RID: 76263
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD0;

	// Token: 0x040129E8 RID: 76264
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD1;

	// Token: 0x040129E9 RID: 76265
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD2;

	// Token: 0x040129EA RID: 76266
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD3;

	// Token: 0x040129EB RID: 76267
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD4;

	// Token: 0x040129EC RID: 76268
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD5;

	// Token: 0x040129ED RID: 76269
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD6;

	// Token: 0x040129EE RID: 76270
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD7;

	// Token: 0x040129EF RID: 76271
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD8;

	// Token: 0x040129F0 RID: 76272
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD9;

	// Token: 0x040129F1 RID: 76273
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDA;

	// Token: 0x040129F2 RID: 76274
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDB;

	// Token: 0x040129F3 RID: 76275
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDC;

	// Token: 0x040129F4 RID: 76276
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDD;

	// Token: 0x040129F5 RID: 76277
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDE;

	// Token: 0x040129F6 RID: 76278
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDF;

	// Token: 0x040129F7 RID: 76279
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE0;

	// Token: 0x040129F8 RID: 76280
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE1;

	// Token: 0x040129F9 RID: 76281
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE2;

	// Token: 0x040129FA RID: 76282
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE3;

	// Token: 0x040129FB RID: 76283
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE4;

	// Token: 0x040129FC RID: 76284
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE5;

	// Token: 0x040129FD RID: 76285
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE6;

	// Token: 0x040129FE RID: 76286
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE7;

	// Token: 0x040129FF RID: 76287
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE8;

	// Token: 0x04012A00 RID: 76288
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE9;

	// Token: 0x04012A01 RID: 76289
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheEA;

	// Token: 0x04012A02 RID: 76290
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheEB;

	// Token: 0x04012A03 RID: 76291
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheEC;

	// Token: 0x04012A04 RID: 76292
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheED;

	// Token: 0x04012A05 RID: 76293
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheEE;

	// Token: 0x04012A06 RID: 76294
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheEF;

	// Token: 0x04012A07 RID: 76295
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF0;

	// Token: 0x04012A08 RID: 76296
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF1;

	// Token: 0x04012A09 RID: 76297
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF2;

	// Token: 0x04012A0A RID: 76298
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF3;

	// Token: 0x04012A0B RID: 76299
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF4;

	// Token: 0x04012A0C RID: 76300
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF5;

	// Token: 0x04012A0D RID: 76301
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF6;

	// Token: 0x04012A0E RID: 76302
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF7;

	// Token: 0x04012A0F RID: 76303
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF8;

	// Token: 0x04012A10 RID: 76304
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF9;

	// Token: 0x04012A11 RID: 76305
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheFA;

	// Token: 0x04012A12 RID: 76306
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheFB;

	// Token: 0x04012A13 RID: 76307
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheFC;

	// Token: 0x04012A14 RID: 76308
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheFD;

	// Token: 0x04012A15 RID: 76309
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheFE;

	// Token: 0x04012A16 RID: 76310
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheFF;

	// Token: 0x04012A17 RID: 76311
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache100;

	// Token: 0x04012A18 RID: 76312
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache101;

	// Token: 0x04012A19 RID: 76313
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache102;

	// Token: 0x04012A1A RID: 76314
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache103;

	// Token: 0x04012A1B RID: 76315
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache104;

	// Token: 0x04012A1C RID: 76316
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache105;

	// Token: 0x04012A1D RID: 76317
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache106;

	// Token: 0x04012A1E RID: 76318
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache107;

	// Token: 0x04012A1F RID: 76319
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache108;

	// Token: 0x04012A20 RID: 76320
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache109;

	// Token: 0x04012A21 RID: 76321
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10A;

	// Token: 0x04012A22 RID: 76322
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10B;

	// Token: 0x04012A23 RID: 76323
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10C;

	// Token: 0x04012A24 RID: 76324
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10D;

	// Token: 0x04012A25 RID: 76325
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10E;

	// Token: 0x04012A26 RID: 76326
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10F;

	// Token: 0x04012A27 RID: 76327
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache110;

	// Token: 0x04012A28 RID: 76328
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache111;

	// Token: 0x04012A29 RID: 76329
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache112;

	// Token: 0x04012A2A RID: 76330
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache113;

	// Token: 0x04012A2B RID: 76331
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache114;

	// Token: 0x04012A2C RID: 76332
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache115;

	// Token: 0x04012A2D RID: 76333
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache116;

	// Token: 0x04012A2E RID: 76334
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache117;

	// Token: 0x04012A2F RID: 76335
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache118;

	// Token: 0x04012A30 RID: 76336
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache119;

	// Token: 0x04012A31 RID: 76337
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11A;

	// Token: 0x04012A32 RID: 76338
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11B;

	// Token: 0x04012A33 RID: 76339
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11C;

	// Token: 0x04012A34 RID: 76340
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11D;

	// Token: 0x04012A35 RID: 76341
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11E;

	// Token: 0x04012A36 RID: 76342
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11F;

	// Token: 0x04012A37 RID: 76343
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache120;

	// Token: 0x04012A38 RID: 76344
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache121;

	// Token: 0x04012A39 RID: 76345
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache122;

	// Token: 0x04012A3A RID: 76346
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache123;

	// Token: 0x04012A3B RID: 76347
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache124;

	// Token: 0x04012A3C RID: 76348
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache125;

	// Token: 0x04012A3D RID: 76349
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache126;

	// Token: 0x04012A3E RID: 76350
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache127;

	// Token: 0x04012A3F RID: 76351
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache128;

	// Token: 0x04012A40 RID: 76352
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache129;

	// Token: 0x04012A41 RID: 76353
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12A;

	// Token: 0x04012A42 RID: 76354
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12B;

	// Token: 0x04012A43 RID: 76355
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12C;

	// Token: 0x04012A44 RID: 76356
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12D;

	// Token: 0x04012A45 RID: 76357
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12E;

	// Token: 0x04012A46 RID: 76358
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12F;

	// Token: 0x04012A47 RID: 76359
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache130;

	// Token: 0x04012A48 RID: 76360
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache131;

	// Token: 0x04012A49 RID: 76361
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache132;

	// Token: 0x04012A4A RID: 76362
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache133;

	// Token: 0x04012A4B RID: 76363
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache134;

	// Token: 0x04012A4C RID: 76364
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache135;

	// Token: 0x04012A4D RID: 76365
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache136;

	// Token: 0x04012A4E RID: 76366
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache137;

	// Token: 0x04012A4F RID: 76367
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache138;

	// Token: 0x04012A50 RID: 76368
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache139;

	// Token: 0x04012A51 RID: 76369
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13A;

	// Token: 0x04012A52 RID: 76370
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13B;
}
