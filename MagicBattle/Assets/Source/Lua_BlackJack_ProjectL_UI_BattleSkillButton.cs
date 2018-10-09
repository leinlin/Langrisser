using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x020013C3 RID: 5059
[Preserve]
public class Lua_BlackJack_ProjectL_UI_BattleSkillButton : LuaObject
{
	// Token: 0x0601BFF2 RID: 114674 RVA: 0x0089920C File Offset: 0x0089740C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetIndex(IntPtr l)
	{
		int result;
		try
		{
			BattleSkillButton battleSkillButton = (BattleSkillButton)LuaObject.checkSelf(l);
			int index;
			LuaObject.checkType(l, 2, out index);
			battleSkillButton.SetIndex(index);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BFF3 RID: 114675 RVA: 0x00899264 File Offset: 0x00897464
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetIndex(IntPtr l)
	{
		int result;
		try
		{
			BattleSkillButton battleSkillButton = (BattleSkillButton)LuaObject.checkSelf(l);
			int index = battleSkillButton.GetIndex();
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

	// Token: 0x0601BFF4 RID: 114676 RVA: 0x008992B8 File Offset: 0x008974B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetSkillInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleSkillButton battleSkillButton = (BattleSkillButton)LuaObject.checkSelf(l);
			ConfigDataSkillInfo skillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 2, out skillInfo);
			battleSkillButton.SetSkillInfo(skillInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BFF5 RID: 114677 RVA: 0x00899310 File Offset: 0x00897510
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetSkillInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleSkillButton battleSkillButton = (BattleSkillButton)LuaObject.checkSelf(l);
			ConfigDataSkillInfo skillInfo = battleSkillButton.GetSkillInfo();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, skillInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BFF6 RID: 114678 RVA: 0x00899364 File Offset: 0x00897564
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetCooldown(IntPtr l)
	{
		int result;
		try
		{
			BattleSkillButton battleSkillButton = (BattleSkillButton)LuaObject.checkSelf(l);
			int cooldown;
			LuaObject.checkType(l, 2, out cooldown);
			battleSkillButton.SetCooldown(cooldown);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BFF7 RID: 114679 RVA: 0x008993BC File Offset: 0x008975BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetSelected(IntPtr l)
	{
		int result;
		try
		{
			BattleSkillButton battleSkillButton = (BattleSkillButton)LuaObject.checkSelf(l);
			bool selected;
			LuaObject.checkType(l, 2, out selected);
			battleSkillButton.SetSelected(selected);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BFF8 RID: 114680 RVA: 0x00899414 File Offset: 0x00897614
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsSelected(IntPtr l)
	{
		int result;
		try
		{
			BattleSkillButton battleSkillButton = (BattleSkillButton)LuaObject.checkSelf(l);
			bool b = battleSkillButton.IsSelected();
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

	// Token: 0x0601BFF9 RID: 114681 RVA: 0x00899468 File Offset: 0x00897668
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowCost(IntPtr l)
	{
		int result;
		try
		{
			BattleSkillButton battleSkillButton = (BattleSkillButton)LuaObject.checkSelf(l);
			bool isShow;
			LuaObject.checkType(l, 2, out isShow);
			battleSkillButton.ShowCost(isShow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BFFA RID: 114682 RVA: 0x008994C0 File Offset: 0x008976C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowFrame(IntPtr l)
	{
		int result;
		try
		{
			BattleSkillButton battleSkillButton = (BattleSkillButton)LuaObject.checkSelf(l);
			bool isShow;
			LuaObject.checkType(l, 2, out isShow);
			battleSkillButton.ShowFrame(isShow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BFFB RID: 114683 RVA: 0x00899518 File Offset: 0x00897718
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetBanned(IntPtr l)
	{
		int result;
		try
		{
			BattleSkillButton battleSkillButton = (BattleSkillButton)LuaObject.checkSelf(l);
			bool banned;
			LuaObject.checkType(l, 2, out banned);
			battleSkillButton.SetBanned(banned);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BFFC RID: 114684 RVA: 0x00899570 File Offset: 0x00897770
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsBanned(IntPtr l)
	{
		int result;
		try
		{
			BattleSkillButton battleSkillButton = (BattleSkillButton)LuaObject.checkSelf(l);
			bool b = battleSkillButton.IsBanned();
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

	// Token: 0x0601BFFD RID: 114685 RVA: 0x008995C4 File Offset: 0x008977C4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetHandleLongDown(IntPtr l)
	{
		int result;
		try
		{
			BattleSkillButton battleSkillButton = (BattleSkillButton)LuaObject.checkSelf(l);
			bool handleLongDown;
			LuaObject.checkType(l, 2, out handleLongDown);
			battleSkillButton.SetHandleLongDown(handleLongDown);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BFFE RID: 114686 RVA: 0x0089961C File Offset: 0x0089781C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetDescGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleSkillButton battleSkillButton = (BattleSkillButton)LuaObject.checkSelf(l);
			GameObject descGameObject;
			LuaObject.checkType<GameObject>(l, 2, out descGameObject);
			battleSkillButton.SetDescGameObject(descGameObject);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BFFF RID: 114687 RVA: 0x00899674 File Offset: 0x00897874
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPointerDown(IntPtr l)
	{
		int result;
		try
		{
			BattleSkillButton battleSkillButton = (BattleSkillButton)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			battleSkillButton.OnPointerDown(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C000 RID: 114688 RVA: 0x008996CC File Offset: 0x008978CC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnPointerUp(IntPtr l)
	{
		int result;
		try
		{
			BattleSkillButton battleSkillButton = (BattleSkillButton)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			battleSkillButton.OnPointerUp(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C001 RID: 114689 RVA: 0x00899724 File Offset: 0x00897924
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnPointerClick(IntPtr l)
	{
		int result;
		try
		{
			BattleSkillButton battleSkillButton = (BattleSkillButton)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			battleSkillButton.OnPointerClick(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C002 RID: 114690 RVA: 0x0089977C File Offset: 0x0089797C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int InvokeClickEvent(IntPtr l)
	{
		int result;
		try
		{
			BattleSkillButton battleSkillButton = (BattleSkillButton)LuaObject.checkSelf(l);
			bool b = battleSkillButton.InvokeClickEvent();
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

	// Token: 0x0601C003 RID: 114691 RVA: 0x008997D0 File Offset: 0x008979D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Awake(IntPtr l)
	{
		int result;
		try
		{
			BattleSkillButton battleSkillButton = (BattleSkillButton)LuaObject.checkSelf(l);
			battleSkillButton.m_luaExportHelper.Awake();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C004 RID: 114692 RVA: 0x00899824 File Offset: 0x00897A24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowDesc(IntPtr l)
	{
		int result;
		try
		{
			BattleSkillButton battleSkillButton = (BattleSkillButton)LuaObject.checkSelf(l);
			battleSkillButton.m_luaExportHelper.ShowDesc();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C005 RID: 114693 RVA: 0x00899878 File Offset: 0x00897A78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HideDesc(IntPtr l)
	{
		int result;
		try
		{
			BattleSkillButton battleSkillButton = (BattleSkillButton)LuaObject.checkSelf(l);
			battleSkillButton.m_luaExportHelper.HideDesc();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C006 RID: 114694 RVA: 0x008998CC File Offset: 0x00897ACC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Update(IntPtr l)
	{
		int result;
		try
		{
			BattleSkillButton battleSkillButton = (BattleSkillButton)LuaObject.checkSelf(l);
			battleSkillButton.m_luaExportHelper.Update();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C007 RID: 114695 RVA: 0x00899920 File Offset: 0x00897B20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnClick(IntPtr l)
	{
		int result;
		try
		{
			BattleSkillButton battleSkillButton = (BattleSkillButton)LuaObject.checkSelf(l);
			battleSkillButton.m_luaExportHelper.__callDele_EventOnClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C008 RID: 114696 RVA: 0x00899974 File Offset: 0x00897B74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnClick(IntPtr l)
	{
		int result;
		try
		{
			BattleSkillButton battleSkillButton = (BattleSkillButton)LuaObject.checkSelf(l);
			battleSkillButton.m_luaExportHelper.__clearDele_EventOnClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C009 RID: 114697 RVA: 0x008999C8 File Offset: 0x00897BC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isPointerLongDown(IntPtr l)
	{
		int result;
		try
		{
			BattleSkillButton battleSkillButton = (BattleSkillButton)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleSkillButton.m_luaExportHelper.m_isPointerLongDown);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C00A RID: 114698 RVA: 0x00899A20 File Offset: 0x00897C20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isPointerLongDown(IntPtr l)
	{
		int result;
		try
		{
			BattleSkillButton battleSkillButton = (BattleSkillButton)LuaObject.checkSelf(l);
			bool isPointerLongDown;
			LuaObject.checkType(l, 2, out isPointerLongDown);
			battleSkillButton.m_luaExportHelper.m_isPointerLongDown = isPointerLongDown;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C00B RID: 114699 RVA: 0x00899A7C File Offset: 0x00897C7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_ignoreClick(IntPtr l)
	{
		int result;
		try
		{
			BattleSkillButton battleSkillButton = (BattleSkillButton)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleSkillButton.m_luaExportHelper.m_ignoreClick);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C00C RID: 114700 RVA: 0x00899AD4 File Offset: 0x00897CD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_ignoreClick(IntPtr l)
	{
		int result;
		try
		{
			BattleSkillButton battleSkillButton = (BattleSkillButton)LuaObject.checkSelf(l);
			bool ignoreClick;
			LuaObject.checkType(l, 2, out ignoreClick);
			battleSkillButton.m_luaExportHelper.m_ignoreClick = ignoreClick;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C00D RID: 114701 RVA: 0x00899B30 File Offset: 0x00897D30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_pointerLongDownCountdown(IntPtr l)
	{
		int result;
		try
		{
			BattleSkillButton battleSkillButton = (BattleSkillButton)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleSkillButton.m_luaExportHelper.m_pointerLongDownCountdown);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C00E RID: 114702 RVA: 0x00899B88 File Offset: 0x00897D88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_pointerLongDownCountdown(IntPtr l)
	{
		int result;
		try
		{
			BattleSkillButton battleSkillButton = (BattleSkillButton)LuaObject.checkSelf(l);
			float pointerLongDownCountdown;
			LuaObject.checkType(l, 2, out pointerLongDownCountdown);
			battleSkillButton.m_luaExportHelper.m_pointerLongDownCountdown = pointerLongDownCountdown;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C00F RID: 114703 RVA: 0x00899BE4 File Offset: 0x00897DE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_cooldownText(IntPtr l)
	{
		int result;
		try
		{
			BattleSkillButton battleSkillButton = (BattleSkillButton)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleSkillButton.m_luaExportHelper.m_cooldownText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C010 RID: 114704 RVA: 0x00899C3C File Offset: 0x00897E3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_cooldownText(IntPtr l)
	{
		int result;
		try
		{
			BattleSkillButton battleSkillButton = (BattleSkillButton)LuaObject.checkSelf(l);
			Text cooldownText;
			LuaObject.checkType<Text>(l, 2, out cooldownText);
			battleSkillButton.m_luaExportHelper.m_cooldownText = cooldownText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C011 RID: 114705 RVA: 0x00899C98 File Offset: 0x00897E98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_iconImage(IntPtr l)
	{
		int result;
		try
		{
			BattleSkillButton battleSkillButton = (BattleSkillButton)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleSkillButton.m_luaExportHelper.m_iconImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C012 RID: 114706 RVA: 0x00899CF0 File Offset: 0x00897EF0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_iconImage(IntPtr l)
	{
		int result;
		try
		{
			BattleSkillButton battleSkillButton = (BattleSkillButton)LuaObject.checkSelf(l);
			Image iconImage;
			LuaObject.checkType<Image>(l, 2, out iconImage);
			battleSkillButton.m_luaExportHelper.m_iconImage = iconImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C013 RID: 114707 RVA: 0x00899D4C File Offset: 0x00897F4C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_frameImage(IntPtr l)
	{
		int result;
		try
		{
			BattleSkillButton battleSkillButton = (BattleSkillButton)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleSkillButton.m_luaExportHelper.m_frameImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C014 RID: 114708 RVA: 0x00899DA4 File Offset: 0x00897FA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_frameImage(IntPtr l)
	{
		int result;
		try
		{
			BattleSkillButton battleSkillButton = (BattleSkillButton)LuaObject.checkSelf(l);
			Image frameImage;
			LuaObject.checkType<Image>(l, 2, out frameImage);
			battleSkillButton.m_luaExportHelper.m_frameImage = frameImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C015 RID: 114709 RVA: 0x00899E00 File Offset: 0x00898000
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_cooldownGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleSkillButton battleSkillButton = (BattleSkillButton)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleSkillButton.m_luaExportHelper.m_cooldownGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C016 RID: 114710 RVA: 0x00899E58 File Offset: 0x00898058
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_cooldownGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleSkillButton battleSkillButton = (BattleSkillButton)LuaObject.checkSelf(l);
			GameObject cooldownGameObject;
			LuaObject.checkType<GameObject>(l, 2, out cooldownGameObject);
			battleSkillButton.m_luaExportHelper.m_cooldownGameObject = cooldownGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C017 RID: 114711 RVA: 0x00899EB4 File Offset: 0x008980B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_selectedGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleSkillButton battleSkillButton = (BattleSkillButton)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleSkillButton.m_luaExportHelper.m_selectedGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C018 RID: 114712 RVA: 0x00899F0C File Offset: 0x0089810C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_selectedGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleSkillButton battleSkillButton = (BattleSkillButton)LuaObject.checkSelf(l);
			GameObject selectedGameObject;
			LuaObject.checkType<GameObject>(l, 2, out selectedGameObject);
			battleSkillButton.m_luaExportHelper.m_selectedGameObject = selectedGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C019 RID: 114713 RVA: 0x00899F68 File Offset: 0x00898168
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_descGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleSkillButton battleSkillButton = (BattleSkillButton)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleSkillButton.m_luaExportHelper.m_descGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C01A RID: 114714 RVA: 0x00899FC0 File Offset: 0x008981C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_descGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleSkillButton battleSkillButton = (BattleSkillButton)LuaObject.checkSelf(l);
			GameObject descGameObject;
			LuaObject.checkType<GameObject>(l, 2, out descGameObject);
			battleSkillButton.m_luaExportHelper.m_descGameObject = descGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C01B RID: 114715 RVA: 0x0089A01C File Offset: 0x0089821C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_costGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleSkillButton battleSkillButton = (BattleSkillButton)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleSkillButton.m_luaExportHelper.m_costGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C01C RID: 114716 RVA: 0x0089A074 File Offset: 0x00898274
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_costGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleSkillButton battleSkillButton = (BattleSkillButton)LuaObject.checkSelf(l);
			GameObject costGameObject;
			LuaObject.checkType<GameObject>(l, 2, out costGameObject);
			battleSkillButton.m_luaExportHelper.m_costGameObject = costGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C01D RID: 114717 RVA: 0x0089A0D0 File Offset: 0x008982D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_passiveGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleSkillButton battleSkillButton = (BattleSkillButton)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleSkillButton.m_luaExportHelper.m_passiveGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C01E RID: 114718 RVA: 0x0089A128 File Offset: 0x00898328
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_passiveGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleSkillButton battleSkillButton = (BattleSkillButton)LuaObject.checkSelf(l);
			GameObject passiveGameObject;
			LuaObject.checkType<GameObject>(l, 2, out passiveGameObject);
			battleSkillButton.m_luaExportHelper.m_passiveGameObject = passiveGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C01F RID: 114719 RVA: 0x0089A184 File Offset: 0x00898384
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_banGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleSkillButton battleSkillButton = (BattleSkillButton)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleSkillButton.m_luaExportHelper.m_banGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C020 RID: 114720 RVA: 0x0089A1DC File Offset: 0x008983DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_banGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleSkillButton battleSkillButton = (BattleSkillButton)LuaObject.checkSelf(l);
			GameObject banGameObject;
			LuaObject.checkType<GameObject>(l, 2, out banGameObject);
			battleSkillButton.m_luaExportHelper.m_banGameObject = banGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C021 RID: 114721 RVA: 0x0089A238 File Offset: 0x00898438
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleSkillButton battleSkillButton = (BattleSkillButton)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleSkillButton.m_luaExportHelper.m_skillInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C022 RID: 114722 RVA: 0x0089A290 File Offset: 0x00898490
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleSkillButton battleSkillButton = (BattleSkillButton)LuaObject.checkSelf(l);
			ConfigDataSkillInfo skillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 2, out skillInfo);
			battleSkillButton.m_luaExportHelper.m_skillInfo = skillInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C023 RID: 114723 RVA: 0x0089A2EC File Offset: 0x008984EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_index(IntPtr l)
	{
		int result;
		try
		{
			BattleSkillButton battleSkillButton = (BattleSkillButton)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleSkillButton.m_luaExportHelper.m_index);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C024 RID: 114724 RVA: 0x0089A344 File Offset: 0x00898544
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_index(IntPtr l)
	{
		int result;
		try
		{
			BattleSkillButton battleSkillButton = (BattleSkillButton)LuaObject.checkSelf(l);
			int index;
			LuaObject.checkType(l, 2, out index);
			battleSkillButton.m_luaExportHelper.m_index = index;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C025 RID: 114725 RVA: 0x0089A3A0 File Offset: 0x008985A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isSelected(IntPtr l)
	{
		int result;
		try
		{
			BattleSkillButton battleSkillButton = (BattleSkillButton)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleSkillButton.m_luaExportHelper.m_isSelected);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C026 RID: 114726 RVA: 0x0089A3F8 File Offset: 0x008985F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isSelected(IntPtr l)
	{
		int result;
		try
		{
			BattleSkillButton battleSkillButton = (BattleSkillButton)LuaObject.checkSelf(l);
			bool isSelected;
			LuaObject.checkType(l, 2, out isSelected);
			battleSkillButton.m_luaExportHelper.m_isSelected = isSelected;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C027 RID: 114727 RVA: 0x0089A454 File Offset: 0x00898654
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_isBanned(IntPtr l)
	{
		int result;
		try
		{
			BattleSkillButton battleSkillButton = (BattleSkillButton)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleSkillButton.m_luaExportHelper.m_isBanned);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C028 RID: 114728 RVA: 0x0089A4AC File Offset: 0x008986AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isBanned(IntPtr l)
	{
		int result;
		try
		{
			BattleSkillButton battleSkillButton = (BattleSkillButton)LuaObject.checkSelf(l);
			bool isBanned;
			LuaObject.checkType(l, 2, out isBanned);
			battleSkillButton.m_luaExportHelper.m_isBanned = isBanned;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C029 RID: 114729 RVA: 0x0089A508 File Offset: 0x00898708
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isHandleLongDown(IntPtr l)
	{
		int result;
		try
		{
			BattleSkillButton battleSkillButton = (BattleSkillButton)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleSkillButton.m_luaExportHelper.m_isHandleLongDown);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C02A RID: 114730 RVA: 0x0089A560 File Offset: 0x00898760
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isHandleLongDown(IntPtr l)
	{
		int result;
		try
		{
			BattleSkillButton battleSkillButton = (BattleSkillButton)LuaObject.checkSelf(l);
			bool isHandleLongDown;
			LuaObject.checkType(l, 2, out isHandleLongDown);
			battleSkillButton.m_luaExportHelper.m_isHandleLongDown = isHandleLongDown;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C02B RID: 114731 RVA: 0x0089A5BC File Offset: 0x008987BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnClick(IntPtr l)
	{
		int result;
		try
		{
			BattleSkillButton battleSkillButton = (BattleSkillButton)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					battleSkillButton.EventOnClick += value;
				}
				else if (num == 2)
				{
					battleSkillButton.EventOnClick -= value;
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

	// Token: 0x0601C02C RID: 114732 RVA: 0x0089A63C File Offset: 0x0089883C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_descStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			BattleSkillButton battleSkillButton = (BattleSkillButton)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleSkillButton.m_luaExportHelper.m_descStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C02D RID: 114733 RVA: 0x0089A694 File Offset: 0x00898894
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_descStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			BattleSkillButton battleSkillButton = (BattleSkillButton)LuaObject.checkSelf(l);
			CommonUIStateController descStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out descStateCtrl);
			battleSkillButton.m_luaExportHelper.m_descStateCtrl = descStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C02E RID: 114734 RVA: 0x0089A6F0 File Offset: 0x008988F0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.BattleSkillButton");
		if (Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSkillButton.SetIndex);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSkillButton.GetIndex);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSkillButton.SetSkillInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSkillButton.GetSkillInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSkillButton.SetCooldown);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSkillButton.SetSelected);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSkillButton.IsSelected);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSkillButton.ShowCost);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSkillButton.ShowFrame);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSkillButton.SetBanned);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSkillButton.IsBanned);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSkillButton.SetHandleLongDown);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSkillButton.SetDescGameObject);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSkillButton.OnPointerDown);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSkillButton.OnPointerUp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSkillButton.OnPointerClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSkillButton.InvokeClickEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSkillButton.Awake);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSkillButton.ShowDesc);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSkillButton.HideDesc);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSkillButton.Update);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSkillButton.__callDele_EventOnClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSkillButton.__clearDele_EventOnClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache16);
		string name = "m_isPointerLongDown";
		if (Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSkillButton.get_m_isPointerLongDown);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache17;
		if (Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSkillButton.set_m_isPointerLongDown);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache18, true);
		string name2 = "m_ignoreClick";
		if (Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSkillButton.get_m_ignoreClick);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache19;
		if (Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSkillButton.set_m_ignoreClick);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache1A, true);
		string name3 = "m_pointerLongDownCountdown";
		if (Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSkillButton.get_m_pointerLongDownCountdown);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache1B;
		if (Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSkillButton.set_m_pointerLongDownCountdown);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache1C, true);
		string name4 = "m_cooldownText";
		if (Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSkillButton.get_m_cooldownText);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache1D;
		if (Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSkillButton.set_m_cooldownText);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache1E, true);
		string name5 = "m_iconImage";
		if (Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSkillButton.get_m_iconImage);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache1F;
		if (Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSkillButton.set_m_iconImage);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache20, true);
		string name6 = "m_frameImage";
		if (Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSkillButton.get_m_frameImage);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache21;
		if (Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSkillButton.set_m_frameImage);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache22, true);
		string name7 = "m_cooldownGameObject";
		if (Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSkillButton.get_m_cooldownGameObject);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache23;
		if (Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSkillButton.set_m_cooldownGameObject);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache24, true);
		string name8 = "m_selectedGameObject";
		if (Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSkillButton.get_m_selectedGameObject);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache25;
		if (Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSkillButton.set_m_selectedGameObject);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache26, true);
		string name9 = "m_descGameObject";
		if (Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSkillButton.get_m_descGameObject);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache27;
		if (Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSkillButton.set_m_descGameObject);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache28, true);
		string name10 = "m_costGameObject";
		if (Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSkillButton.get_m_costGameObject);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache29;
		if (Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSkillButton.set_m_costGameObject);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache2A, true);
		string name11 = "m_passiveGameObject";
		if (Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSkillButton.get_m_passiveGameObject);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache2B;
		if (Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSkillButton.set_m_passiveGameObject);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache2C, true);
		string name12 = "m_banGameObject";
		if (Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSkillButton.get_m_banGameObject);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache2D;
		if (Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSkillButton.set_m_banGameObject);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache2E, true);
		string name13 = "m_skillInfo";
		if (Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSkillButton.get_m_skillInfo);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache2F;
		if (Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSkillButton.set_m_skillInfo);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache30, true);
		string name14 = "m_index";
		if (Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSkillButton.get_m_index);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache31;
		if (Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSkillButton.set_m_index);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache32, true);
		string name15 = "m_isSelected";
		if (Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSkillButton.get_m_isSelected);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache33;
		if (Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSkillButton.set_m_isSelected);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache34, true);
		string name16 = "m_isBanned";
		if (Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSkillButton.get_m_isBanned);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache35;
		if (Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSkillButton.set_m_isBanned);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache36, true);
		string name17 = "m_isHandleLongDown";
		if (Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSkillButton.get_m_isHandleLongDown);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache37;
		if (Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSkillButton.set_m_isHandleLongDown);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache38, true);
		string name18 = "EventOnClick";
		LuaCSFunction get18 = null;
		if (Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSkillButton.set_EventOnClick);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache39, true);
		string name19 = "m_descStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSkillButton.get_m_descStateCtrl);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache3A;
		if (Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSkillButton.set_m_descStateCtrl);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_UI_BattleSkillButton.<>f__mg$cache3B, true);
		LuaObject.createTypeMetatable(l, null, typeof(BattleSkillButton), typeof(MonoBehaviour));
	}

	// Token: 0x0401224E RID: 74318
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401224F RID: 74319
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04012250 RID: 74320
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04012251 RID: 74321
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04012252 RID: 74322
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04012253 RID: 74323
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04012254 RID: 74324
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04012255 RID: 74325
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04012256 RID: 74326
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04012257 RID: 74327
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04012258 RID: 74328
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04012259 RID: 74329
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0401225A RID: 74330
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0401225B RID: 74331
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0401225C RID: 74332
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0401225D RID: 74333
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0401225E RID: 74334
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0401225F RID: 74335
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04012260 RID: 74336
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04012261 RID: 74337
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04012262 RID: 74338
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04012263 RID: 74339
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04012264 RID: 74340
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04012265 RID: 74341
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04012266 RID: 74342
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04012267 RID: 74343
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04012268 RID: 74344
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04012269 RID: 74345
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0401226A RID: 74346
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0401226B RID: 74347
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0401226C RID: 74348
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0401226D RID: 74349
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0401226E RID: 74350
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0401226F RID: 74351
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04012270 RID: 74352
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04012271 RID: 74353
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04012272 RID: 74354
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04012273 RID: 74355
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04012274 RID: 74356
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04012275 RID: 74357
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04012276 RID: 74358
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04012277 RID: 74359
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04012278 RID: 74360
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04012279 RID: 74361
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0401227A RID: 74362
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0401227B RID: 74363
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0401227C RID: 74364
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x0401227D RID: 74365
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x0401227E RID: 74366
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x0401227F RID: 74367
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04012280 RID: 74368
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04012281 RID: 74369
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04012282 RID: 74370
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04012283 RID: 74371
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04012284 RID: 74372
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04012285 RID: 74373
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04012286 RID: 74374
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04012287 RID: 74375
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04012288 RID: 74376
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x04012289 RID: 74377
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;
}
