using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001487 RID: 5255
[Preserve]
public class Lua_BlackJack_ProjectL_UI_GuildManagementUIController : LuaObject
{
	// Token: 0x0601E52A RID: 124202 RVA: 0x009C120C File Offset: 0x009BF40C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Open(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			guildManagementUIController.Open();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E52B RID: 124203 RVA: 0x009C1258 File Offset: 0x009BF458
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Close(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			guildManagementUIController.Close();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E52C RID: 124204 RVA: 0x009C12A4 File Offset: 0x009BF4A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateView(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			Guild guild;
			LuaObject.checkType<Guild>(l, 2, out guild);
			guildManagementUIController.UpdateView(guild);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E52D RID: 124205 RVA: 0x009C12FC File Offset: 0x009BF4FC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetMessageRedPoint(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			bool messageRedPoint;
			LuaObject.checkType(l, 2, out messageRedPoint);
			guildManagementUIController.SetMessageRedPoint(messageRedPoint);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E52E RID: 124206 RVA: 0x009C1354 File Offset: 0x009BF554
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			guildManagementUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E52F RID: 124207 RVA: 0x009C13A8 File Offset: 0x009BF5A8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int RefreshGuildTitle(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			guildManagementUIController.m_luaExportHelper.RefreshGuildTitle();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E530 RID: 124208 RVA: 0x009C13FC File Offset: 0x009BF5FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetStateByGuildTitle(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			guildManagementUIController.m_luaExportHelper.SetStateByGuildTitle();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E531 RID: 124209 RVA: 0x009C1450 File Offset: 0x009BF650
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetSociatyInfoPanel(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			guildManagementUIController.m_luaExportHelper.SetSociatyInfoPanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E532 RID: 124210 RVA: 0x009C14A4 File Offset: 0x009BF6A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetSociatyListPanel(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			List<GuildMemberCacheObject> sociatyListPanel;
			LuaObject.checkType<List<GuildMemberCacheObject>>(l, 2, out sociatyListPanel);
			guildManagementUIController.m_luaExportHelper.SetSociatyListPanel(sociatyListPanel);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E533 RID: 124211 RVA: 0x009C1500 File Offset: 0x009BF700
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnGuildManagementListPlayeItemClick(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			GuildMemberInfoItemUIController ctrl;
			LuaObject.checkType<GuildMemberInfoItemUIController>(l, 2, out ctrl);
			guildManagementUIController.m_luaExportHelper.OnGuildManagementListPlayeItemClick(ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E534 RID: 124212 RVA: 0x009C155C File Offset: 0x009BF75C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnReturnImgButtonClick(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			guildManagementUIController.m_luaExportHelper.OnReturnImgButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E535 RID: 124213 RVA: 0x009C15B0 File Offset: 0x009BF7B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnInfoButtonClick(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			guildManagementUIController.m_luaExportHelper.OnInfoButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E536 RID: 124214 RVA: 0x009C1604 File Offset: 0x009BF804
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnGuildCoinButtonClick(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			guildManagementUIController.m_luaExportHelper.OnGuildCoinButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E537 RID: 124215 RVA: 0x009C1658 File Offset: 0x009BF858
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearData(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			guildManagementUIController.m_luaExportHelper.ClearData();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E538 RID: 124216 RVA: 0x009C16AC File Offset: 0x009BF8AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CloseAllSmallPanel(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			guildManagementUIController.m_luaExportHelper.CloseAllSmallPanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E539 RID: 124217 RVA: 0x009C1700 File Offset: 0x009BF900
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnOnlineButtonClick(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			guildManagementUIController.m_luaExportHelper.OnOnlineButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E53A RID: 124218 RVA: 0x009C1754 File Offset: 0x009BF954
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnActiveButtonClick(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			guildManagementUIController.m_luaExportHelper.OnActiveButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E53B RID: 124219 RVA: 0x009C17A8 File Offset: 0x009BF9A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPowerButtonClick(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			guildManagementUIController.m_luaExportHelper.OnPowerButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E53C RID: 124220 RVA: 0x009C17FC File Offset: 0x009BF9FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetSortButtonState(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			GuildManagementUIController.GuildListSortType sortButtonState;
			LuaObject.checkEnum<GuildManagementUIController.GuildListSortType>(l, 2, out sortButtonState);
			guildManagementUIController.m_luaExportHelper.SetSortButtonState(sortButtonState);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E53D RID: 124221 RVA: 0x009C1858 File Offset: 0x009BFA58
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SortByTitle(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			GuildMemberCacheObject a;
			LuaObject.checkType<GuildMemberCacheObject>(l, 2, out a);
			GuildMemberCacheObject b;
			LuaObject.checkType<GuildMemberCacheObject>(l, 3, out b);
			int i = guildManagementUIController.m_luaExportHelper.SortByTitle(a, b);
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

	// Token: 0x0601E53E RID: 124222 RVA: 0x009C18CC File Offset: 0x009BFACC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SortByPower(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			GuildMemberCacheObject a;
			LuaObject.checkType<GuildMemberCacheObject>(l, 2, out a);
			GuildMemberCacheObject b;
			LuaObject.checkType<GuildMemberCacheObject>(l, 3, out b);
			int i = guildManagementUIController.m_luaExportHelper.SortByPower(a, b);
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

	// Token: 0x0601E53F RID: 124223 RVA: 0x009C1940 File Offset: 0x009BFB40
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SortByActive(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			GuildMemberCacheObject a;
			LuaObject.checkType<GuildMemberCacheObject>(l, 2, out a);
			GuildMemberCacheObject b;
			LuaObject.checkType<GuildMemberCacheObject>(l, 3, out b);
			int i = guildManagementUIController.m_luaExportHelper.SortByActive(a, b);
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

	// Token: 0x0601E540 RID: 124224 RVA: 0x009C19B4 File Offset: 0x009BFBB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SortGuildListByDefault(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			List<GuildMemberCacheObject> guildList;
			LuaObject.checkType<List<GuildMemberCacheObject>>(l, 2, out guildList);
			guildManagementUIController.m_luaExportHelper.SortGuildListByDefault(guildList);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E541 RID: 124225 RVA: 0x009C1A10 File Offset: 0x009BFC10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SortByDefaultType(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			GuildMemberCacheObject a;
			LuaObject.checkType<GuildMemberCacheObject>(l, 2, out a);
			GuildMemberCacheObject b;
			LuaObject.checkType<GuildMemberCacheObject>(l, 3, out b);
			int i = guildManagementUIController.m_luaExportHelper.SortByDefaultType(a, b);
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

	// Token: 0x0601E542 RID: 124226 RVA: 0x009C1A84 File Offset: 0x009BFC84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SortByActiveType(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			GuildMemberCacheObject a;
			LuaObject.checkType<GuildMemberCacheObject>(l, 2, out a);
			GuildMemberCacheObject b;
			LuaObject.checkType<GuildMemberCacheObject>(l, 3, out b);
			int i = guildManagementUIController.m_luaExportHelper.SortByActiveType(a, b);
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

	// Token: 0x0601E543 RID: 124227 RVA: 0x009C1AF8 File Offset: 0x009BFCF8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SortByBattlePowerType(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			GuildMemberCacheObject a;
			LuaObject.checkType<GuildMemberCacheObject>(l, 2, out a);
			GuildMemberCacheObject b;
			LuaObject.checkType<GuildMemberCacheObject>(l, 3, out b);
			int i = guildManagementUIController.m_luaExportHelper.SortByBattlePowerType(a, b);
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

	// Token: 0x0601E544 RID: 124228 RVA: 0x009C1B6C File Offset: 0x009BFD6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnSociatyNameChangeButtonClick(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			guildManagementUIController.m_luaExportHelper.OnSociatyNameChangeButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E545 RID: 124229 RVA: 0x009C1BC0 File Offset: 0x009BFDC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnGuildChangeNamePanelChangeNameButtonClick(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			guildManagementUIController.m_luaExportHelper.OnGuildChangeNamePanelChangeNameButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E546 RID: 124230 RVA: 0x009C1C14 File Offset: 0x009BFE14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnGuildChangeNamePanelBackButtonClick(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			guildManagementUIController.m_luaExportHelper.OnGuildChangeNamePanelBackButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E547 RID: 124231 RVA: 0x009C1C68 File Offset: 0x009BFE68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnDeclarationButtonClick(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			guildManagementUIController.m_luaExportHelper.OnDeclarationButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E548 RID: 124232 RVA: 0x009C1CBC File Offset: 0x009BFEBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnDeclarationChangePanelSaveButtonClick(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			guildManagementUIController.m_luaExportHelper.OnDeclarationChangePanelSaveButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E549 RID: 124233 RVA: 0x009C1D10 File Offset: 0x009BFF10
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnDeclarationChangePanelBackButtonClick(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			guildManagementUIController.m_luaExportHelper.OnDeclarationChangePanelBackButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E54A RID: 124234 RVA: 0x009C1D64 File Offset: 0x009BFF64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnQuitButtonClick(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			guildManagementUIController.m_luaExportHelper.OnQuitButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E54B RID: 124235 RVA: 0x009C1DB8 File Offset: 0x009BFFB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnQuitGuildConfirmButtonClick(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			guildManagementUIController.m_luaExportHelper.OnQuitGuildConfirmButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E54C RID: 124236 RVA: 0x009C1E0C File Offset: 0x009C000C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CloseQuitGuildConfirmPanel(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			guildManagementUIController.m_luaExportHelper.CloseQuitGuildConfirmPanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E54D RID: 124237 RVA: 0x009C1E60 File Offset: 0x009C0060
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnSociatyPlayButtonClick(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			guildManagementUIController.m_luaExportHelper.OnSociatyPlayButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E54E RID: 124238 RVA: 0x009C1EB4 File Offset: 0x009C00B4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnShopButtonClick(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			guildManagementUIController.m_luaExportHelper.OnShopButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E54F RID: 124239 RVA: 0x009C1F08 File Offset: 0x009C0108
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnWealButtonClick(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			guildManagementUIController.m_luaExportHelper.OnWealButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E550 RID: 124240 RVA: 0x009C1F5C File Offset: 0x009C015C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnMessageButtonClick(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			guildManagementUIController.m_luaExportHelper.OnMessageButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E551 RID: 124241 RVA: 0x009C1FB0 File Offset: 0x009C01B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SendNtfBeforeOpenMessagePanel(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			bool isManager;
			LuaObject.checkType(l, 2, out isManager);
			Action onEnd;
			LuaObject.checkDelegate<Action>(l, 3, out onEnd);
			guildManagementUIController.m_luaExportHelper.SendNtfBeforeOpenMessagePanel(isManager, onEnd);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E552 RID: 124242 RVA: 0x009C201C File Offset: 0x009C021C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetMessageApplyPanel(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			List<UserSummary> messageApplyPanel;
			LuaObject.checkType<List<UserSummary>>(l, 2, out messageApplyPanel);
			guildManagementUIController.m_luaExportHelper.SetMessageApplyPanel(messageApplyPanel);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E553 RID: 124243 RVA: 0x009C2078 File Offset: 0x009C0278
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnGuildApplyMemberAcceptResult(IntPtr l)
	{
		int result2;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			GuildApplyMemberInfoItemUIController ctrl;
			LuaObject.checkType<GuildApplyMemberInfoItemUIController>(l, 2, out ctrl);
			bool result;
			LuaObject.checkType(l, 3, out result);
			guildManagementUIController.m_luaExportHelper.OnGuildApplyMemberAcceptResult(ctrl, result);
			LuaObject.pushValue(l, true);
			result2 = 1;
		}
		catch (Exception e)
		{
			result2 = LuaObject.error(l, e);
		}
		return result2;
	}

	// Token: 0x0601E554 RID: 124244 RVA: 0x009C20E4 File Offset: 0x009C02E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetMessageJournalPanel(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			List<GuildLog> messageJournalPanel;
			LuaObject.checkType<List<GuildLog>>(l, 2, out messageJournalPanel);
			guildManagementUIController.m_luaExportHelper.SetMessageJournalPanel(messageJournalPanel);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E555 RID: 124245 RVA: 0x009C2140 File Offset: 0x009C0340
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnMssageApplyPanelPowerButtonClick(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			guildManagementUIController.m_luaExportHelper.OnMssageApplyPanelPowerButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E556 RID: 124246 RVA: 0x009C2194 File Offset: 0x009C0394
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnMessagePanelBackButtonClick(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			guildManagementUIController.m_luaExportHelper.OnMessagePanelBackButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E557 RID: 124247 RVA: 0x009C21E8 File Offset: 0x009C03E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CloseMessagePanel(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			Action onEnd;
			LuaObject.checkDelegate<Action>(l, 2, out onEnd);
			guildManagementUIController.m_luaExportHelper.CloseMessagePanel(onEnd);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E558 RID: 124248 RVA: 0x009C2244 File Offset: 0x009C0444
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnMessagePanelApplyToggleValueChanged(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			bool isOn;
			LuaObject.checkType(l, 2, out isOn);
			guildManagementUIController.m_luaExportHelper.OnMessagePanelApplyToggleValueChanged(isOn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E559 RID: 124249 RVA: 0x009C22A0 File Offset: 0x009C04A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnMessagePanelJournalToggleValueChanged(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			bool isOn;
			LuaObject.checkType(l, 2, out isOn);
			guildManagementUIController.m_luaExportHelper.OnMessagePanelJournalToggleValueChanged(isOn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E55A RID: 124250 RVA: 0x009C22FC File Offset: 0x009C04FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnMessageApplyPanelAllRefuseButtonClick(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			guildManagementUIController.m_luaExportHelper.OnMessageApplyPanelAllRefuseButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E55B RID: 124251 RVA: 0x009C2350 File Offset: 0x009C0550
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnInviteButtonClick(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			guildManagementUIController.m_luaExportHelper.OnInviteButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E55C RID: 124252 RVA: 0x009C23A4 File Offset: 0x009C05A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetInvitePanel(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			List<UserSummary> invitePanel;
			LuaObject.checkType<List<UserSummary>>(l, 2, out invitePanel);
			guildManagementUIController.m_luaExportHelper.SetInvitePanel(invitePanel);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E55D RID: 124253 RVA: 0x009C2400 File Offset: 0x009C0600
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetInviteInfoPanel(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			guildManagementUIController.m_luaExportHelper.SetInviteInfoPanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E55E RID: 124254 RVA: 0x009C2454 File Offset: 0x009C0654
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetInviteListPanel(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			guildManagementUIController.m_luaExportHelper.SetInviteListPanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E55F RID: 124255 RVA: 0x009C24A8 File Offset: 0x009C06A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnInviteMemberInfoItemClick(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			GuildInviteMemberInfoItemUIController ctrl;
			LuaObject.checkType<GuildInviteMemberInfoItemUIController>(l, 2, out ctrl);
			guildManagementUIController.m_luaExportHelper.OnInviteMemberInfoItemClick(ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E560 RID: 124256 RVA: 0x009C2504 File Offset: 0x009C0704
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnInviteListPanelPowerButtonClick(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			guildManagementUIController.m_luaExportHelper.OnInviteListPanelPowerButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E561 RID: 124257 RVA: 0x009C2558 File Offset: 0x009C0758
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnInvitePanelChangeListButtonClick(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			guildManagementUIController.m_luaExportHelper.OnInvitePanelChangeListButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E562 RID: 124258 RVA: 0x009C25AC File Offset: 0x009C07AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnInvitePanelBackButton(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			guildManagementUIController.m_luaExportHelper.OnInvitePanelBackButton();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E563 RID: 124259 RVA: 0x009C2600 File Offset: 0x009C0800
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CloseInvitePanel(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			Action onEnd;
			LuaObject.checkDelegate<Action>(l, 2, out onEnd);
			guildManagementUIController.m_luaExportHelper.CloseInvitePanel(onEnd);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E564 RID: 124260 RVA: 0x009C265C File Offset: 0x009C085C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnInviteInfoPanelDeclarationChangeButtonClick(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			guildManagementUIController.m_luaExportHelper.OnInviteInfoPanelDeclarationChangeButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E565 RID: 124261 RVA: 0x009C26B0 File Offset: 0x009C08B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetRecruitChangeSubPanelInfo(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			guildManagementUIController.m_luaExportHelper.SetRecruitChangeSubPanelInfo();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E566 RID: 124262 RVA: 0x009C2704 File Offset: 0x009C0904
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnRecruitPanelSaveButtonClick(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			guildManagementUIController.m_luaExportHelper.OnRecruitPanelSaveButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E567 RID: 124263 RVA: 0x009C2758 File Offset: 0x009C0958
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnRecruitPanelBackButtonClick(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			guildManagementUIController.m_luaExportHelper.OnRecruitPanelBackButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E568 RID: 124264 RVA: 0x009C27AC File Offset: 0x009C09AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnInvitePanelSetButtonClick(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			guildManagementUIController.m_luaExportHelper.OnInvitePanelSetButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E569 RID: 124265 RVA: 0x009C2800 File Offset: 0x009C0A00
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetGuildSetSubPanel(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			guildManagementUIController.m_luaExportHelper.SetGuildSetSubPanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E56A RID: 124266 RVA: 0x009C2854 File Offset: 0x009C0A54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnGuildSetPanelChairmanToggleClick(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			bool isOn;
			LuaObject.checkType(l, 2, out isOn);
			guildManagementUIController.m_luaExportHelper.OnGuildSetPanelChairmanToggleClick(isOn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E56B RID: 124267 RVA: 0x009C28B0 File Offset: 0x009C0AB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnGuildSetPanelAutoToggleClick(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			bool isOn;
			LuaObject.checkType(l, 2, out isOn);
			guildManagementUIController.m_luaExportHelper.OnGuildSetPanelAutoToggleClick(isOn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E56C RID: 124268 RVA: 0x009C290C File Offset: 0x009C0B0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnGuildSetPanelLevelInputFieldRightButtonClick(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			guildManagementUIController.m_luaExportHelper.OnGuildSetPanelLevelInputFieldRightButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E56D RID: 124269 RVA: 0x009C2960 File Offset: 0x009C0B60
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnGuildSetPanelLevelInputFieldLeftButtonClick(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			guildManagementUIController.m_luaExportHelper.OnGuildSetPanelLevelInputFieldLeftButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E56E RID: 124270 RVA: 0x009C29B4 File Offset: 0x009C0BB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnGuildSetPanelLevelInputFieldEditEnd(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			string inputStr;
			LuaObject.checkType(l, 2, out inputStr);
			guildManagementUIController.m_luaExportHelper.OnGuildSetPanelLevelInputFieldEditEnd(inputStr);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E56F RID: 124271 RVA: 0x009C2A10 File Offset: 0x009C0C10
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnGuildSetPanelSaveButtonClick(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			guildManagementUIController.m_luaExportHelper.OnGuildSetPanelSaveButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E570 RID: 124272 RVA: 0x009C2A64 File Offset: 0x009C0C64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnGuildSetPanelBackButtonClick(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			guildManagementUIController.m_luaExportHelper.OnGuildSetPanelBackButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E571 RID: 124273 RVA: 0x009C2AB8 File Offset: 0x009C0CB8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CloseGuildSetPanel(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			Action onEnd;
			LuaObject.checkDelegate<Action>(l, 2, out onEnd);
			guildManagementUIController.m_luaExportHelper.CloseGuildSetPanel(onEnd);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E572 RID: 124274 RVA: 0x009C2B14 File Offset: 0x009C0D14
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			guildManagementUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E573 RID: 124275 RVA: 0x009C2B80 File Offset: 0x009C0D80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			guildManagementUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E574 RID: 124276 RVA: 0x009C2BD4 File Offset: 0x009C0DD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			guildManagementUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E575 RID: 124277 RVA: 0x009C2C28 File Offset: 0x009C0E28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = guildManagementUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601E576 RID: 124278 RVA: 0x009C2CD0 File Offset: 0x009C0ED0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			guildManagementUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E577 RID: 124279 RVA: 0x009C2D24 File Offset: 0x009C0F24
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			guildManagementUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E578 RID: 124280 RVA: 0x009C2D90 File Offset: 0x009C0F90
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonClickListener(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(string[]), typeof(Action<UIControllerBase>)))
			{
				GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				guildManagementUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				GuildManagementUIController guildManagementUIController2 = (GuildManagementUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				guildManagementUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601E579 RID: 124281 RVA: 0x009C2EA0 File Offset: 0x009C10A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			guildManagementUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E57A RID: 124282 RVA: 0x009C2F0C File Offset: 0x009C110C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			guildManagementUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E57B RID: 124283 RVA: 0x009C2F78 File Offset: 0x009C1178
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			guildManagementUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E57C RID: 124284 RVA: 0x009C2FE4 File Offset: 0x009C11E4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			guildManagementUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E57D RID: 124285 RVA: 0x009C3050 File Offset: 0x009C1250
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
				GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				guildManagementUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				GuildManagementUIController guildManagementUIController2 = (GuildManagementUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				guildManagementUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601E57E RID: 124286 RVA: 0x009C3160 File Offset: 0x009C1360
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			string s = guildManagementUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601E57F RID: 124287 RVA: 0x009C31BC File Offset: 0x009C13BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			guildManagementUIController.m_luaExportHelper.__callDele_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E580 RID: 124288 RVA: 0x009C3210 File Offset: 0x009C1410
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			guildManagementUIController.m_luaExportHelper.__clearDele_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E581 RID: 124289 RVA: 0x009C3264 File Offset: 0x009C1464
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnChangeGuildName(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			string arg;
			LuaObject.checkType(l, 2, out arg);
			Action arg2;
			LuaObject.checkDelegate<Action>(l, 3, out arg2);
			guildManagementUIController.m_luaExportHelper.__callDele_EventOnChangeGuildName(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E582 RID: 124290 RVA: 0x009C32D0 File Offset: 0x009C14D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnChangeGuildName(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			string arg;
			LuaObject.checkType(l, 2, out arg);
			Action arg2;
			LuaObject.checkDelegate<Action>(l, 3, out arg2);
			guildManagementUIController.m_luaExportHelper.__clearDele_EventOnChangeGuildName(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E583 RID: 124291 RVA: 0x009C333C File Offset: 0x009C153C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnGuildAnnouncementSet(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			string arg;
			LuaObject.checkType(l, 2, out arg);
			Action arg2;
			LuaObject.checkDelegate<Action>(l, 3, out arg2);
			guildManagementUIController.m_luaExportHelper.__callDele_EventOnGuildAnnouncementSet(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E584 RID: 124292 RVA: 0x009C33A8 File Offset: 0x009C15A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnGuildAnnouncementSet(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			string arg;
			LuaObject.checkType(l, 2, out arg);
			Action arg2;
			LuaObject.checkDelegate<Action>(l, 3, out arg2);
			guildManagementUIController.m_luaExportHelper.__clearDele_EventOnGuildAnnouncementSet(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E585 RID: 124293 RVA: 0x009C3414 File Offset: 0x009C1614
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnQuitGuild(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			Action obj;
			LuaObject.checkDelegate<Action>(l, 2, out obj);
			guildManagementUIController.m_luaExportHelper.__callDele_EventOnQuitGuild(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E586 RID: 124294 RVA: 0x009C3470 File Offset: 0x009C1670
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_EventOnQuitGuild(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			Action obj;
			LuaObject.checkDelegate<Action>(l, 2, out obj);
			guildManagementUIController.m_luaExportHelper.__clearDele_EventOnQuitGuild(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E587 RID: 124295 RVA: 0x009C34CC File Offset: 0x009C16CC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_EventOnGetCanInvitePlayerList(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			Action<List<UserSummary>> arg;
			LuaObject.checkDelegate<Action<List<UserSummary>>>(l, 2, out arg);
			bool arg2;
			LuaObject.checkType(l, 3, out arg2);
			guildManagementUIController.m_luaExportHelper.__callDele_EventOnGetCanInvitePlayerList(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E588 RID: 124296 RVA: 0x009C3538 File Offset: 0x009C1738
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_EventOnGetCanInvitePlayerList(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			Action<List<UserSummary>> arg;
			LuaObject.checkDelegate<Action<List<UserSummary>>>(l, 2, out arg);
			bool arg2;
			LuaObject.checkType(l, 3, out arg2);
			guildManagementUIController.m_luaExportHelper.__clearDele_EventOnGetCanInvitePlayerList(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E589 RID: 124297 RVA: 0x009C35A4 File Offset: 0x009C17A4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_EventOnGuildHiringDeclarationSet(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			string arg;
			LuaObject.checkType(l, 2, out arg);
			Action arg2;
			LuaObject.checkDelegate<Action>(l, 3, out arg2);
			guildManagementUIController.m_luaExportHelper.__callDele_EventOnGuildHiringDeclarationSet(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E58A RID: 124298 RVA: 0x009C3610 File Offset: 0x009C1810
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnGuildHiringDeclarationSet(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			string arg;
			LuaObject.checkType(l, 2, out arg);
			Action arg2;
			LuaObject.checkDelegate<Action>(l, 3, out arg2);
			guildManagementUIController.m_luaExportHelper.__clearDele_EventOnGuildHiringDeclarationSet(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E58B RID: 124299 RVA: 0x009C367C File Offset: 0x009C187C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_EventOnGuildInfoSet(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			bool arg;
			LuaObject.checkType(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			string arg3;
			LuaObject.checkType(l, 4, out arg3);
			Action arg4;
			LuaObject.checkDelegate<Action>(l, 5, out arg4);
			guildManagementUIController.m_luaExportHelper.__callDele_EventOnGuildInfoSet(arg, arg2, arg3, arg4);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E58C RID: 124300 RVA: 0x009C3700 File Offset: 0x009C1900
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnGuildInfoSet(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			bool arg;
			LuaObject.checkType(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			string arg3;
			LuaObject.checkType(l, 4, out arg3);
			Action arg4;
			LuaObject.checkDelegate<Action>(l, 5, out arg4);
			guildManagementUIController.m_luaExportHelper.__clearDele_EventOnGuildInfoSet(arg, arg2, arg3, arg4);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E58D RID: 124301 RVA: 0x009C3784 File Offset: 0x009C1984
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_EventOnGetGuildJoinApply(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			Action<List<UserSummary>> obj;
			LuaObject.checkDelegate<Action<List<UserSummary>>>(l, 2, out obj);
			guildManagementUIController.m_luaExportHelper.__callDele_EventOnGetGuildJoinApply(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E58E RID: 124302 RVA: 0x009C37E0 File Offset: 0x009C19E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnGetGuildJoinApply(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			Action<List<UserSummary>> obj;
			LuaObject.checkDelegate<Action<List<UserSummary>>>(l, 2, out obj);
			guildManagementUIController.m_luaExportHelper.__clearDele_EventOnGetGuildJoinApply(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E58F RID: 124303 RVA: 0x009C383C File Offset: 0x009C1A3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnGetGuildJournal(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			Action<List<GuildLog>> obj;
			LuaObject.checkDelegate<Action<List<GuildLog>>>(l, 2, out obj);
			guildManagementUIController.m_luaExportHelper.__callDele_EventOnGetGuildJournal(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E590 RID: 124304 RVA: 0x009C3898 File Offset: 0x009C1A98
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_EventOnGetGuildJournal(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			Action<List<GuildLog>> obj;
			LuaObject.checkDelegate<Action<List<GuildLog>>>(l, 2, out obj);
			guildManagementUIController.m_luaExportHelper.__clearDele_EventOnGetGuildJournal(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E591 RID: 124305 RVA: 0x009C38F4 File Offset: 0x009C1AF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnGuildJoinConfirmOrRefuse(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			string arg;
			LuaObject.checkType(l, 2, out arg);
			bool arg2;
			LuaObject.checkType(l, 3, out arg2);
			Action arg3;
			LuaObject.checkDelegate<Action>(l, 4, out arg3);
			guildManagementUIController.m_luaExportHelper.__callDele_EventOnGuildJoinConfirmOrRefuse(arg, arg2, arg3);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E592 RID: 124306 RVA: 0x009C396C File Offset: 0x009C1B6C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_EventOnGuildJoinConfirmOrRefuse(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			string arg;
			LuaObject.checkType(l, 2, out arg);
			bool arg2;
			LuaObject.checkType(l, 3, out arg2);
			Action arg3;
			LuaObject.checkDelegate<Action>(l, 4, out arg3);
			guildManagementUIController.m_luaExportHelper.__clearDele_EventOnGuildJoinConfirmOrRefuse(arg, arg2, arg3);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E593 RID: 124307 RVA: 0x009C39E4 File Offset: 0x009C1BE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnGuildInviteMember(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			string arg;
			LuaObject.checkType(l, 2, out arg);
			Action arg2;
			LuaObject.checkDelegate<Action>(l, 3, out arg2);
			guildManagementUIController.m_luaExportHelper.__callDele_EventOnGuildInviteMember(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E594 RID: 124308 RVA: 0x009C3A50 File Offset: 0x009C1C50
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_EventOnGuildInviteMember(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			string arg;
			LuaObject.checkType(l, 2, out arg);
			Action arg2;
			LuaObject.checkDelegate<Action>(l, 3, out arg2);
			guildManagementUIController.m_luaExportHelper.__clearDele_EventOnGuildInviteMember(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E595 RID: 124309 RVA: 0x009C3ABC File Offset: 0x009C1CBC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_EventOnGuildMemberClick(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			string arg;
			LuaObject.checkType(l, 2, out arg);
			Vector3 arg2;
			LuaObject.checkType(l, 3, out arg2);
			PlayerSimpleInfoUITask.PostionType arg3;
			LuaObject.checkEnum<PlayerSimpleInfoUITask.PostionType>(l, 4, out arg3);
			guildManagementUIController.m_luaExportHelper.__callDele_EventOnGuildMemberClick(arg, arg2, arg3);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E596 RID: 124310 RVA: 0x009C3B34 File Offset: 0x009C1D34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnGuildMemberClick(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			string arg;
			LuaObject.checkType(l, 2, out arg);
			Vector3 arg2;
			LuaObject.checkType(l, 3, out arg2);
			PlayerSimpleInfoUITask.PostionType arg3;
			LuaObject.checkEnum<PlayerSimpleInfoUITask.PostionType>(l, 4, out arg3);
			guildManagementUIController.m_luaExportHelper.__clearDele_EventOnGuildMemberClick(arg, arg2, arg3);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E597 RID: 124311 RVA: 0x009C3BAC File Offset: 0x009C1DAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnAllRefuseButtonClick(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			Action obj;
			LuaObject.checkDelegate<Action>(l, 2, out obj);
			guildManagementUIController.m_luaExportHelper.__callDele_EventOnAllRefuseButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E598 RID: 124312 RVA: 0x009C3C08 File Offset: 0x009C1E08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnAllRefuseButtonClick(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			Action obj;
			LuaObject.checkDelegate<Action>(l, 2, out obj);
			guildManagementUIController.m_luaExportHelper.__clearDele_EventOnAllRefuseButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E599 RID: 124313 RVA: 0x009C3C64 File Offset: 0x009C1E64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnGotoGuildStore(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			guildManagementUIController.m_luaExportHelper.__callDele_EventOnGotoGuildStore();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E59A RID: 124314 RVA: 0x009C3CB8 File Offset: 0x009C1EB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnGotoGuildStore(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			guildManagementUIController.m_luaExportHelper.__clearDele_EventOnGotoGuildStore();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E59B RID: 124315 RVA: 0x009C3D0C File Offset: 0x009C1F0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnGotoGuildGameListPanel(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			guildManagementUIController.m_luaExportHelper.__callDele_EventOnGotoGuildGameListPanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E59C RID: 124316 RVA: 0x009C3D60 File Offset: 0x009C1F60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnGotoGuildGameListPanel(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			guildManagementUIController.m_luaExportHelper.__clearDele_EventOnGotoGuildGameListPanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E59D RID: 124317 RVA: 0x009C3DB4 File Offset: 0x009C1FB4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					guildManagementUIController.EventOnClose += value;
				}
				else if (num == 2)
				{
					guildManagementUIController.EventOnClose -= value;
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

	// Token: 0x0601E59E RID: 124318 RVA: 0x009C3E34 File Offset: 0x009C2034
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_EventOnChangeGuildName(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			Action<string, Action> value;
			int num = LuaObject.checkDelegate<Action<string, Action>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					guildManagementUIController.EventOnChangeGuildName += value;
				}
				else if (num == 2)
				{
					guildManagementUIController.EventOnChangeGuildName -= value;
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

	// Token: 0x0601E59F RID: 124319 RVA: 0x009C3EB4 File Offset: 0x009C20B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnGuildAnnouncementSet(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			Action<string, Action> value;
			int num = LuaObject.checkDelegate<Action<string, Action>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					guildManagementUIController.EventOnGuildAnnouncementSet += value;
				}
				else if (num == 2)
				{
					guildManagementUIController.EventOnGuildAnnouncementSet -= value;
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

	// Token: 0x0601E5A0 RID: 124320 RVA: 0x009C3F34 File Offset: 0x009C2134
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_EventOnQuitGuild(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			Action<Action> value;
			int num = LuaObject.checkDelegate<Action<Action>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					guildManagementUIController.EventOnQuitGuild += value;
				}
				else if (num == 2)
				{
					guildManagementUIController.EventOnQuitGuild -= value;
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

	// Token: 0x0601E5A1 RID: 124321 RVA: 0x009C3FB4 File Offset: 0x009C21B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnGetCanInvitePlayerList(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			Action<Action<List<UserSummary>>, bool> value;
			int num = LuaObject.checkDelegate<Action<Action<List<UserSummary>>, bool>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					guildManagementUIController.EventOnGetCanInvitePlayerList += value;
				}
				else if (num == 2)
				{
					guildManagementUIController.EventOnGetCanInvitePlayerList -= value;
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

	// Token: 0x0601E5A2 RID: 124322 RVA: 0x009C4034 File Offset: 0x009C2234
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_EventOnGuildHiringDeclarationSet(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			Action<string, Action> value;
			int num = LuaObject.checkDelegate<Action<string, Action>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					guildManagementUIController.EventOnGuildHiringDeclarationSet += value;
				}
				else if (num == 2)
				{
					guildManagementUIController.EventOnGuildHiringDeclarationSet -= value;
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

	// Token: 0x0601E5A3 RID: 124323 RVA: 0x009C40B4 File Offset: 0x009C22B4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_EventOnGuildInfoSet(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			Action<bool, int, string, Action> value;
			int num = LuaObject.checkDelegate<Action<bool, int, string, Action>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					guildManagementUIController.EventOnGuildInfoSet += value;
				}
				else if (num == 2)
				{
					guildManagementUIController.EventOnGuildInfoSet -= value;
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

	// Token: 0x0601E5A4 RID: 124324 RVA: 0x009C4134 File Offset: 0x009C2334
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnGetGuildJoinApply(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			Action<Action<List<UserSummary>>> value;
			int num = LuaObject.checkDelegate<Action<Action<List<UserSummary>>>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					guildManagementUIController.EventOnGetGuildJoinApply += value;
				}
				else if (num == 2)
				{
					guildManagementUIController.EventOnGetGuildJoinApply -= value;
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

	// Token: 0x0601E5A5 RID: 124325 RVA: 0x009C41B4 File Offset: 0x009C23B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnGetGuildJournal(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			Action<Action<List<GuildLog>>> value;
			int num = LuaObject.checkDelegate<Action<Action<List<GuildLog>>>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					guildManagementUIController.EventOnGetGuildJournal += value;
				}
				else if (num == 2)
				{
					guildManagementUIController.EventOnGetGuildJournal -= value;
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

	// Token: 0x0601E5A6 RID: 124326 RVA: 0x009C4234 File Offset: 0x009C2434
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnGuildJoinConfirmOrRefuse(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			Action<string, bool, Action> value;
			int num = LuaObject.checkDelegate<Action<string, bool, Action>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					guildManagementUIController.EventOnGuildJoinConfirmOrRefuse += value;
				}
				else if (num == 2)
				{
					guildManagementUIController.EventOnGuildJoinConfirmOrRefuse -= value;
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

	// Token: 0x0601E5A7 RID: 124327 RVA: 0x009C42B4 File Offset: 0x009C24B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnGuildInviteMember(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			Action<string, Action> value;
			int num = LuaObject.checkDelegate<Action<string, Action>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					guildManagementUIController.EventOnGuildInviteMember += value;
				}
				else if (num == 2)
				{
					guildManagementUIController.EventOnGuildInviteMember -= value;
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

	// Token: 0x0601E5A8 RID: 124328 RVA: 0x009C4334 File Offset: 0x009C2534
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnGuildMemberClick(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			Action<string, Vector3, PlayerSimpleInfoUITask.PostionType> value;
			int num = LuaObject.checkDelegate<Action<string, Vector3, PlayerSimpleInfoUITask.PostionType>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					guildManagementUIController.EventOnGuildMemberClick += value;
				}
				else if (num == 2)
				{
					guildManagementUIController.EventOnGuildMemberClick -= value;
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

	// Token: 0x0601E5A9 RID: 124329 RVA: 0x009C43B4 File Offset: 0x009C25B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnAllRefuseButtonClick(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			Action<Action> value;
			int num = LuaObject.checkDelegate<Action<Action>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					guildManagementUIController.EventOnAllRefuseButtonClick += value;
				}
				else if (num == 2)
				{
					guildManagementUIController.EventOnAllRefuseButtonClick -= value;
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

	// Token: 0x0601E5AA RID: 124330 RVA: 0x009C4434 File Offset: 0x009C2634
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnGotoGuildStore(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					guildManagementUIController.EventOnGotoGuildStore += value;
				}
				else if (num == 2)
				{
					guildManagementUIController.EventOnGotoGuildStore -= value;
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

	// Token: 0x0601E5AB RID: 124331 RVA: 0x009C44B4 File Offset: 0x009C26B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnGotoGuildGameListPanel(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					guildManagementUIController.EventOnGotoGuildGameListPanel += value;
				}
				else if (num == 2)
				{
					guildManagementUIController.EventOnGotoGuildGameListPanel -= value;
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

	// Token: 0x0601E5AC RID: 124332 RVA: 0x009C4534 File Offset: 0x009C2734
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_commonUIStateController(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUIController.m_luaExportHelper.m_commonUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E5AD RID: 124333 RVA: 0x009C458C File Offset: 0x009C278C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_commonUIStateController(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			CommonUIStateController commonUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out commonUIStateController);
			guildManagementUIController.m_luaExportHelper.m_commonUIStateController = commonUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E5AE RID: 124334 RVA: 0x009C45E8 File Offset: 0x009C27E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_returnButton(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUIController.m_luaExportHelper.m_returnButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E5AF RID: 124335 RVA: 0x009C4640 File Offset: 0x009C2840
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_returnButton(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			Button returnButton;
			LuaObject.checkType<Button>(l, 2, out returnButton);
			guildManagementUIController.m_luaExportHelper.m_returnButton = returnButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E5B0 RID: 124336 RVA: 0x009C469C File Offset: 0x009C289C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_infoButton(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUIController.m_luaExportHelper.m_infoButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E5B1 RID: 124337 RVA: 0x009C46F4 File Offset: 0x009C28F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_infoButton(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			Button infoButton;
			LuaObject.checkType<Button>(l, 2, out infoButton);
			guildManagementUIController.m_luaExportHelper.m_infoButton = infoButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E5B2 RID: 124338 RVA: 0x009C4750 File Offset: 0x009C2950
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_sociatyName(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUIController.m_luaExportHelper.m_sociatyName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E5B3 RID: 124339 RVA: 0x009C47A8 File Offset: 0x009C29A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_sociatyName(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			Text sociatyName;
			LuaObject.checkType<Text>(l, 2, out sociatyName);
			guildManagementUIController.m_luaExportHelper.m_sociatyName = sociatyName;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E5B4 RID: 124340 RVA: 0x009C4804 File Offset: 0x009C2A04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_sociatyNameChangeButton(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUIController.m_luaExportHelper.m_sociatyNameChangeButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E5B5 RID: 124341 RVA: 0x009C485C File Offset: 0x009C2A5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_sociatyNameChangeButton(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			Button sociatyNameChangeButton;
			LuaObject.checkType<Button>(l, 2, out sociatyNameChangeButton);
			guildManagementUIController.m_luaExportHelper.m_sociatyNameChangeButton = sociatyNameChangeButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E5B6 RID: 124342 RVA: 0x009C48B8 File Offset: 0x009C2AB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_mainPanelStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUIController.m_luaExportHelper.m_mainPanelStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E5B7 RID: 124343 RVA: 0x009C4910 File Offset: 0x009C2B10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_mainPanelStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			CommonUIStateController mainPanelStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out mainPanelStateCtrl);
			guildManagementUIController.m_luaExportHelper.m_mainPanelStateCtrl = mainPanelStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E5B8 RID: 124344 RVA: 0x009C496C File Offset: 0x009C2B6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_guildCoinText(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUIController.m_luaExportHelper.m_guildCoinText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E5B9 RID: 124345 RVA: 0x009C49C4 File Offset: 0x009C2BC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_guildCoinText(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			Text guildCoinText;
			LuaObject.checkType<Text>(l, 2, out guildCoinText);
			guildManagementUIController.m_luaExportHelper.m_guildCoinText = guildCoinText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E5BA RID: 124346 RVA: 0x009C4A20 File Offset: 0x009C2C20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_guildCoinDescButton(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUIController.m_luaExportHelper.m_guildCoinDescButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E5BB RID: 124347 RVA: 0x009C4A78 File Offset: 0x009C2C78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_guildCoinDescButton(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			Button guildCoinDescButton;
			LuaObject.checkType<Button>(l, 2, out guildCoinDescButton);
			guildManagementUIController.m_luaExportHelper.m_guildCoinDescButton = guildCoinDescButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E5BC RID: 124348 RVA: 0x009C4AD4 File Offset: 0x009C2CD4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_sociatyListScrollRect(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUIController.m_luaExportHelper.m_sociatyListScrollRect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E5BD RID: 124349 RVA: 0x009C4B2C File Offset: 0x009C2D2C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_sociatyListScrollRect(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			ScrollRect sociatyListScrollRect;
			LuaObject.checkType<ScrollRect>(l, 2, out sociatyListScrollRect);
			guildManagementUIController.m_luaExportHelper.m_sociatyListScrollRect = sociatyListScrollRect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E5BE RID: 124350 RVA: 0x009C4B88 File Offset: 0x009C2D88
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_sociatyListScrollContent(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUIController.m_luaExportHelper.m_sociatyListScrollContent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E5BF RID: 124351 RVA: 0x009C4BE0 File Offset: 0x009C2DE0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_sociatyListScrollContent(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			GameObject sociatyListScrollContent;
			LuaObject.checkType<GameObject>(l, 2, out sociatyListScrollContent);
			guildManagementUIController.m_luaExportHelper.m_sociatyListScrollContent = sociatyListScrollContent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E5C0 RID: 124352 RVA: 0x009C4C3C File Offset: 0x009C2E3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_sociatyListPowerButton(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUIController.m_luaExportHelper.m_sociatyListPowerButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E5C1 RID: 124353 RVA: 0x009C4C94 File Offset: 0x009C2E94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_sociatyListPowerButton(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			Button sociatyListPowerButton;
			LuaObject.checkType<Button>(l, 2, out sociatyListPowerButton);
			guildManagementUIController.m_luaExportHelper.m_sociatyListPowerButton = sociatyListPowerButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E5C2 RID: 124354 RVA: 0x009C4CF0 File Offset: 0x009C2EF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_sociatyListPowerButtonStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUIController.m_luaExportHelper.m_sociatyListPowerButtonStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E5C3 RID: 124355 RVA: 0x009C4D48 File Offset: 0x009C2F48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_sociatyListPowerButtonStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			CommonUIStateController sociatyListPowerButtonStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out sociatyListPowerButtonStateCtrl);
			guildManagementUIController.m_luaExportHelper.m_sociatyListPowerButtonStateCtrl = sociatyListPowerButtonStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E5C4 RID: 124356 RVA: 0x009C4DA4 File Offset: 0x009C2FA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_sociatyListActiveButton(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUIController.m_luaExportHelper.m_sociatyListActiveButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E5C5 RID: 124357 RVA: 0x009C4DFC File Offset: 0x009C2FFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_sociatyListActiveButton(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			Button sociatyListActiveButton;
			LuaObject.checkType<Button>(l, 2, out sociatyListActiveButton);
			guildManagementUIController.m_luaExportHelper.m_sociatyListActiveButton = sociatyListActiveButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E5C6 RID: 124358 RVA: 0x009C4E58 File Offset: 0x009C3058
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_sociatyListActiveButtonStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUIController.m_luaExportHelper.m_sociatyListActiveButtonStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E5C7 RID: 124359 RVA: 0x009C4EB0 File Offset: 0x009C30B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_sociatyListActiveButtonStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			CommonUIStateController sociatyListActiveButtonStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out sociatyListActiveButtonStateCtrl);
			guildManagementUIController.m_luaExportHelper.m_sociatyListActiveButtonStateCtrl = sociatyListActiveButtonStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E5C8 RID: 124360 RVA: 0x009C4F0C File Offset: 0x009C310C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_sociatyListOnlineButton(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUIController.m_luaExportHelper.m_sociatyListOnlineButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E5C9 RID: 124361 RVA: 0x009C4F64 File Offset: 0x009C3164
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_sociatyListOnlineButton(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			Button sociatyListOnlineButton;
			LuaObject.checkType<Button>(l, 2, out sociatyListOnlineButton);
			guildManagementUIController.m_luaExportHelper.m_sociatyListOnlineButton = sociatyListOnlineButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E5CA RID: 124362 RVA: 0x009C4FC0 File Offset: 0x009C31C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_sociatyListOnlineValueText(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUIController.m_luaExportHelper.m_sociatyListOnlineValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E5CB RID: 124363 RVA: 0x009C5018 File Offset: 0x009C3218
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_sociatyListOnlineValueText(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			Text sociatyListOnlineValueText;
			LuaObject.checkType<Text>(l, 2, out sociatyListOnlineValueText);
			guildManagementUIController.m_luaExportHelper.m_sociatyListOnlineValueText = sociatyListOnlineValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E5CC RID: 124364 RVA: 0x009C5074 File Offset: 0x009C3274
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerInfoPrefabItem(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUIController.m_luaExportHelper.m_playerInfoPrefabItem);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E5CD RID: 124365 RVA: 0x009C50CC File Offset: 0x009C32CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerInfoPrefabItem(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			GameObject playerInfoPrefabItem;
			LuaObject.checkType<GameObject>(l, 2, out playerInfoPrefabItem);
			guildManagementUIController.m_luaExportHelper.m_playerInfoPrefabItem = playerInfoPrefabItem;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E5CE RID: 124366 RVA: 0x009C5128 File Offset: 0x009C3328
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_infoSociatyIDText(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUIController.m_luaExportHelper.m_infoSociatyIDText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E5CF RID: 124367 RVA: 0x009C5180 File Offset: 0x009C3380
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_infoSociatyIDText(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			Text infoSociatyIDText;
			LuaObject.checkType<Text>(l, 2, out infoSociatyIDText);
			guildManagementUIController.m_luaExportHelper.m_infoSociatyIDText = infoSociatyIDText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E5D0 RID: 124368 RVA: 0x009C51DC File Offset: 0x009C33DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_infoPeopleNumberText(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUIController.m_luaExportHelper.m_infoPeopleNumberText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E5D1 RID: 124369 RVA: 0x009C5234 File Offset: 0x009C3434
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_infoPeopleNumberText(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			Text infoPeopleNumberText;
			LuaObject.checkType<Text>(l, 2, out infoPeopleNumberText);
			guildManagementUIController.m_luaExportHelper.m_infoPeopleNumberText = infoPeopleNumberText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E5D2 RID: 124370 RVA: 0x009C5290 File Offset: 0x009C3490
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_infoPowerText(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUIController.m_luaExportHelper.m_infoPowerText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E5D3 RID: 124371 RVA: 0x009C52E8 File Offset: 0x009C34E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_infoPowerText(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			Text infoPowerText;
			LuaObject.checkType<Text>(l, 2, out infoPowerText);
			guildManagementUIController.m_luaExportHelper.m_infoPowerText = infoPowerText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E5D4 RID: 124372 RVA: 0x009C5344 File Offset: 0x009C3544
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_infoActiveText(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUIController.m_luaExportHelper.m_infoActiveText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E5D5 RID: 124373 RVA: 0x009C539C File Offset: 0x009C359C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_infoActiveText(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			Text infoActiveText;
			LuaObject.checkType<Text>(l, 2, out infoActiveText);
			guildManagementUIController.m_luaExportHelper.m_infoActiveText = infoActiveText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E5D6 RID: 124374 RVA: 0x009C53F8 File Offset: 0x009C35F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_infoCoinText(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUIController.m_luaExportHelper.m_infoCoinText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E5D7 RID: 124375 RVA: 0x009C5450 File Offset: 0x009C3650
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_infoCoinText(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			Text infoCoinText;
			LuaObject.checkType<Text>(l, 2, out infoCoinText);
			guildManagementUIController.m_luaExportHelper.m_infoCoinText = infoCoinText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E5D8 RID: 124376 RVA: 0x009C54AC File Offset: 0x009C36AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_infoDeclarationText(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUIController.m_luaExportHelper.m_infoDeclarationText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E5D9 RID: 124377 RVA: 0x009C5504 File Offset: 0x009C3704
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_infoDeclarationText(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			Text infoDeclarationText;
			LuaObject.checkType<Text>(l, 2, out infoDeclarationText);
			guildManagementUIController.m_luaExportHelper.m_infoDeclarationText = infoDeclarationText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E5DA RID: 124378 RVA: 0x009C5560 File Offset: 0x009C3760
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_infoDeclarationButton(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUIController.m_luaExportHelper.m_infoDeclarationButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E5DB RID: 124379 RVA: 0x009C55B8 File Offset: 0x009C37B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_infoDeclarationButton(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			Button infoDeclarationButton;
			LuaObject.checkType<Button>(l, 2, out infoDeclarationButton);
			guildManagementUIController.m_luaExportHelper.m_infoDeclarationButton = infoDeclarationButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E5DC RID: 124380 RVA: 0x009C5614 File Offset: 0x009C3814
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_messageButton(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUIController.m_luaExportHelper.m_messageButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E5DD RID: 124381 RVA: 0x009C566C File Offset: 0x009C386C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_messageButton(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			Button messageButton;
			LuaObject.checkType<Button>(l, 2, out messageButton);
			guildManagementUIController.m_luaExportHelper.m_messageButton = messageButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E5DE RID: 124382 RVA: 0x009C56C8 File Offset: 0x009C38C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_messageButtonRedPoint(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUIController.m_luaExportHelper.m_messageButtonRedPoint);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E5DF RID: 124383 RVA: 0x009C5720 File Offset: 0x009C3920
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_messageButtonRedPoint(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			GameObject messageButtonRedPoint;
			LuaObject.checkType<GameObject>(l, 2, out messageButtonRedPoint);
			guildManagementUIController.m_luaExportHelper.m_messageButtonRedPoint = messageButtonRedPoint;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E5E0 RID: 124384 RVA: 0x009C577C File Offset: 0x009C397C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_quitButton(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUIController.m_luaExportHelper.m_quitButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E5E1 RID: 124385 RVA: 0x009C57D4 File Offset: 0x009C39D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_quitButton(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			Button quitButton;
			LuaObject.checkType<Button>(l, 2, out quitButton);
			guildManagementUIController.m_luaExportHelper.m_quitButton = quitButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E5E2 RID: 124386 RVA: 0x009C5830 File Offset: 0x009C3A30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_inviteButton(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUIController.m_luaExportHelper.m_inviteButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E5E3 RID: 124387 RVA: 0x009C5888 File Offset: 0x009C3A88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_inviteButton(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			Button inviteButton;
			LuaObject.checkType<Button>(l, 2, out inviteButton);
			guildManagementUIController.m_luaExportHelper.m_inviteButton = inviteButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E5E4 RID: 124388 RVA: 0x009C58E4 File Offset: 0x009C3AE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_wealButton(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUIController.m_luaExportHelper.m_wealButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E5E5 RID: 124389 RVA: 0x009C593C File Offset: 0x009C3B3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_wealButton(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			Button wealButton;
			LuaObject.checkType<Button>(l, 2, out wealButton);
			guildManagementUIController.m_luaExportHelper.m_wealButton = wealButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E5E6 RID: 124390 RVA: 0x009C5998 File Offset: 0x009C3B98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_shopButton(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUIController.m_luaExportHelper.m_shopButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E5E7 RID: 124391 RVA: 0x009C59F0 File Offset: 0x009C3BF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_shopButton(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			Button shopButton;
			LuaObject.checkType<Button>(l, 2, out shopButton);
			guildManagementUIController.m_luaExportHelper.m_shopButton = shopButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E5E8 RID: 124392 RVA: 0x009C5A4C File Offset: 0x009C3C4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_sociatyPlayButton(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUIController.m_luaExportHelper.m_sociatyPlayButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E5E9 RID: 124393 RVA: 0x009C5AA4 File Offset: 0x009C3CA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_sociatyPlayButton(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			Button sociatyPlayButton;
			LuaObject.checkType<Button>(l, 2, out sociatyPlayButton);
			guildManagementUIController.m_luaExportHelper.m_sociatyPlayButton = sociatyPlayButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E5EA RID: 124394 RVA: 0x009C5B00 File Offset: 0x009C3D00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_declarationChangePanelStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUIController.m_luaExportHelper.m_declarationChangePanelStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E5EB RID: 124395 RVA: 0x009C5B58 File Offset: 0x009C3D58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_declarationChangePanelStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			CommonUIStateController declarationChangePanelStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out declarationChangePanelStateCtrl);
			guildManagementUIController.m_luaExportHelper.m_declarationChangePanelStateCtrl = declarationChangePanelStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E5EC RID: 124396 RVA: 0x009C5BB4 File Offset: 0x009C3DB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_declarationChangePanelBackButton(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUIController.m_luaExportHelper.m_declarationChangePanelBackButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E5ED RID: 124397 RVA: 0x009C5C0C File Offset: 0x009C3E0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_declarationChangePanelBackButton(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			Button declarationChangePanelBackButton;
			LuaObject.checkType<Button>(l, 2, out declarationChangePanelBackButton);
			guildManagementUIController.m_luaExportHelper.m_declarationChangePanelBackButton = declarationChangePanelBackButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E5EE RID: 124398 RVA: 0x009C5C68 File Offset: 0x009C3E68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_declarationChangePanelCloseButton(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUIController.m_luaExportHelper.m_declarationChangePanelCloseButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E5EF RID: 124399 RVA: 0x009C5CC0 File Offset: 0x009C3EC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_declarationChangePanelCloseButton(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			Button declarationChangePanelCloseButton;
			LuaObject.checkType<Button>(l, 2, out declarationChangePanelCloseButton);
			guildManagementUIController.m_luaExportHelper.m_declarationChangePanelCloseButton = declarationChangePanelCloseButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E5F0 RID: 124400 RVA: 0x009C5D1C File Offset: 0x009C3F1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_declarationChangePanelSaveButton(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUIController.m_luaExportHelper.m_declarationChangePanelSaveButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E5F1 RID: 124401 RVA: 0x009C5D74 File Offset: 0x009C3F74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_declarationChangePanelSaveButton(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			Button declarationChangePanelSaveButton;
			LuaObject.checkType<Button>(l, 2, out declarationChangePanelSaveButton);
			guildManagementUIController.m_luaExportHelper.m_declarationChangePanelSaveButton = declarationChangePanelSaveButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E5F2 RID: 124402 RVA: 0x009C5DD0 File Offset: 0x009C3FD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_declarationChangePanelInputField(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUIController.m_luaExportHelper.m_declarationChangePanelInputField);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E5F3 RID: 124403 RVA: 0x009C5E28 File Offset: 0x009C4028
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_declarationChangePanelInputField(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			InputField declarationChangePanelInputField;
			LuaObject.checkType<InputField>(l, 2, out declarationChangePanelInputField);
			guildManagementUIController.m_luaExportHelper.m_declarationChangePanelInputField = declarationChangePanelInputField;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E5F4 RID: 124404 RVA: 0x009C5E84 File Offset: 0x009C4084
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_recruitPanelStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUIController.m_luaExportHelper.m_recruitPanelStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E5F5 RID: 124405 RVA: 0x009C5EDC File Offset: 0x009C40DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_recruitPanelStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			CommonUIStateController recruitPanelStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out recruitPanelStateCtrl);
			guildManagementUIController.m_luaExportHelper.m_recruitPanelStateCtrl = recruitPanelStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E5F6 RID: 124406 RVA: 0x009C5F38 File Offset: 0x009C4138
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_recruitPanelBackButton(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUIController.m_luaExportHelper.m_recruitPanelBackButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E5F7 RID: 124407 RVA: 0x009C5F90 File Offset: 0x009C4190
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_recruitPanelBackButton(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			Button recruitPanelBackButton;
			LuaObject.checkType<Button>(l, 2, out recruitPanelBackButton);
			guildManagementUIController.m_luaExportHelper.m_recruitPanelBackButton = recruitPanelBackButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E5F8 RID: 124408 RVA: 0x009C5FEC File Offset: 0x009C41EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_recruitPanelCloseButton(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUIController.m_luaExportHelper.m_recruitPanelCloseButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E5F9 RID: 124409 RVA: 0x009C6044 File Offset: 0x009C4244
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_recruitPanelCloseButton(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			Button recruitPanelCloseButton;
			LuaObject.checkType<Button>(l, 2, out recruitPanelCloseButton);
			guildManagementUIController.m_luaExportHelper.m_recruitPanelCloseButton = recruitPanelCloseButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E5FA RID: 124410 RVA: 0x009C60A0 File Offset: 0x009C42A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_recruitPanelSaveButton(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUIController.m_luaExportHelper.m_recruitPanelSaveButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E5FB RID: 124411 RVA: 0x009C60F8 File Offset: 0x009C42F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_recruitPanelSaveButton(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			Button recruitPanelSaveButton;
			LuaObject.checkType<Button>(l, 2, out recruitPanelSaveButton);
			guildManagementUIController.m_luaExportHelper.m_recruitPanelSaveButton = recruitPanelSaveButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E5FC RID: 124412 RVA: 0x009C6154 File Offset: 0x009C4354
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_recruitPanelInputField(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUIController.m_luaExportHelper.m_recruitPanelInputField);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E5FD RID: 124413 RVA: 0x009C61AC File Offset: 0x009C43AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_recruitPanelInputField(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			InputField recruitPanelInputField;
			LuaObject.checkType<InputField>(l, 2, out recruitPanelInputField);
			guildManagementUIController.m_luaExportHelper.m_recruitPanelInputField = recruitPanelInputField;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E5FE RID: 124414 RVA: 0x009C6208 File Offset: 0x009C4408
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_invitePanelSetButton(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUIController.m_luaExportHelper.m_invitePanelSetButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E5FF RID: 124415 RVA: 0x009C6260 File Offset: 0x009C4460
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_invitePanelSetButton(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			Button invitePanelSetButton;
			LuaObject.checkType<Button>(l, 2, out invitePanelSetButton);
			guildManagementUIController.m_luaExportHelper.m_invitePanelSetButton = invitePanelSetButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E600 RID: 124416 RVA: 0x009C62BC File Offset: 0x009C44BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_guildSetPanelStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUIController.m_luaExportHelper.m_guildSetPanelStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E601 RID: 124417 RVA: 0x009C6314 File Offset: 0x009C4514
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_guildSetPanelStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			CommonUIStateController guildSetPanelStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out guildSetPanelStateCtrl);
			guildManagementUIController.m_luaExportHelper.m_guildSetPanelStateCtrl = guildSetPanelStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E602 RID: 124418 RVA: 0x009C6370 File Offset: 0x009C4570
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_guildSetPanelBackButton(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUIController.m_luaExportHelper.m_guildSetPanelBackButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E603 RID: 124419 RVA: 0x009C63C8 File Offset: 0x009C45C8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_guildSetPanelBackButton(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			Button guildSetPanelBackButton;
			LuaObject.checkType<Button>(l, 2, out guildSetPanelBackButton);
			guildManagementUIController.m_luaExportHelper.m_guildSetPanelBackButton = guildSetPanelBackButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E604 RID: 124420 RVA: 0x009C6424 File Offset: 0x009C4624
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_guildSetPanelCloseButton(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUIController.m_luaExportHelper.m_guildSetPanelCloseButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E605 RID: 124421 RVA: 0x009C647C File Offset: 0x009C467C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_guildSetPanelCloseButton(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			Button guildSetPanelCloseButton;
			LuaObject.checkType<Button>(l, 2, out guildSetPanelCloseButton);
			guildManagementUIController.m_luaExportHelper.m_guildSetPanelCloseButton = guildSetPanelCloseButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E606 RID: 124422 RVA: 0x009C64D8 File Offset: 0x009C46D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_guildSetPanelSaveButton(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUIController.m_luaExportHelper.m_guildSetPanelSaveButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E607 RID: 124423 RVA: 0x009C6530 File Offset: 0x009C4730
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_guildSetPanelSaveButton(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			Button guildSetPanelSaveButton;
			LuaObject.checkType<Button>(l, 2, out guildSetPanelSaveButton);
			guildManagementUIController.m_luaExportHelper.m_guildSetPanelSaveButton = guildSetPanelSaveButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E608 RID: 124424 RVA: 0x009C658C File Offset: 0x009C478C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_guildSetPanelHireDeclarationInputField(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUIController.m_luaExportHelper.m_guildSetPanelHireDeclarationInputField);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E609 RID: 124425 RVA: 0x009C65E4 File Offset: 0x009C47E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_guildSetPanelHireDeclarationInputField(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			InputField guildSetPanelHireDeclarationInputField;
			LuaObject.checkType<InputField>(l, 2, out guildSetPanelHireDeclarationInputField);
			guildManagementUIController.m_luaExportHelper.m_guildSetPanelHireDeclarationInputField = guildSetPanelHireDeclarationInputField;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E60A RID: 124426 RVA: 0x009C6640 File Offset: 0x009C4840
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_guildSetPanelLevelInputField(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUIController.m_luaExportHelper.m_guildSetPanelLevelInputField);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E60B RID: 124427 RVA: 0x009C6698 File Offset: 0x009C4898
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_guildSetPanelLevelInputField(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			InputField guildSetPanelLevelInputField;
			LuaObject.checkType<InputField>(l, 2, out guildSetPanelLevelInputField);
			guildManagementUIController.m_luaExportHelper.m_guildSetPanelLevelInputField = guildSetPanelLevelInputField;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E60C RID: 124428 RVA: 0x009C66F4 File Offset: 0x009C48F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_guildSetPanelLevelInputFieldLeftButton(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUIController.m_luaExportHelper.m_guildSetPanelLevelInputFieldLeftButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E60D RID: 124429 RVA: 0x009C674C File Offset: 0x009C494C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_guildSetPanelLevelInputFieldLeftButton(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			Button guildSetPanelLevelInputFieldLeftButton;
			LuaObject.checkType<Button>(l, 2, out guildSetPanelLevelInputFieldLeftButton);
			guildManagementUIController.m_luaExportHelper.m_guildSetPanelLevelInputFieldLeftButton = guildSetPanelLevelInputFieldLeftButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E60E RID: 124430 RVA: 0x009C67A8 File Offset: 0x009C49A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_guildSetPanelLevelInputFieldRightButton(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUIController.m_luaExportHelper.m_guildSetPanelLevelInputFieldRightButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E60F RID: 124431 RVA: 0x009C6800 File Offset: 0x009C4A00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_guildSetPanelLevelInputFieldRightButton(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			Button guildSetPanelLevelInputFieldRightButton;
			LuaObject.checkType<Button>(l, 2, out guildSetPanelLevelInputFieldRightButton);
			guildManagementUIController.m_luaExportHelper.m_guildSetPanelLevelInputFieldRightButton = guildSetPanelLevelInputFieldRightButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E610 RID: 124432 RVA: 0x009C685C File Offset: 0x009C4A5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_guildSetPanelApproveGroupAutoToggle(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUIController.m_luaExportHelper.m_guildSetPanelApproveGroupAutoToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E611 RID: 124433 RVA: 0x009C68B4 File Offset: 0x009C4AB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_guildSetPanelApproveGroupAutoToggle(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			Toggle guildSetPanelApproveGroupAutoToggle;
			LuaObject.checkType<Toggle>(l, 2, out guildSetPanelApproveGroupAutoToggle);
			guildManagementUIController.m_luaExportHelper.m_guildSetPanelApproveGroupAutoToggle = guildSetPanelApproveGroupAutoToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E612 RID: 124434 RVA: 0x009C6910 File Offset: 0x009C4B10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_guildSetPanelApproveGroupChairmanToggle(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUIController.m_luaExportHelper.m_guildSetPanelApproveGroupChairmanToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E613 RID: 124435 RVA: 0x009C6968 File Offset: 0x009C4B68
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_guildSetPanelApproveGroupChairmanToggle(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			Toggle guildSetPanelApproveGroupChairmanToggle;
			LuaObject.checkType<Toggle>(l, 2, out guildSetPanelApproveGroupChairmanToggle);
			guildManagementUIController.m_luaExportHelper.m_guildSetPanelApproveGroupChairmanToggle = guildSetPanelApproveGroupChairmanToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E614 RID: 124436 RVA: 0x009C69C4 File Offset: 0x009C4BC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_guildChangeNamePanelStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUIController.m_luaExportHelper.m_guildChangeNamePanelStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E615 RID: 124437 RVA: 0x009C6A1C File Offset: 0x009C4C1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_guildChangeNamePanelStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			CommonUIStateController guildChangeNamePanelStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out guildChangeNamePanelStateCtrl);
			guildManagementUIController.m_luaExportHelper.m_guildChangeNamePanelStateCtrl = guildChangeNamePanelStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E616 RID: 124438 RVA: 0x009C6A78 File Offset: 0x009C4C78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_guildChangeNamePanelBackButton(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUIController.m_luaExportHelper.m_guildChangeNamePanelBackButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E617 RID: 124439 RVA: 0x009C6AD0 File Offset: 0x009C4CD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_guildChangeNamePanelBackButton(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			Button guildChangeNamePanelBackButton;
			LuaObject.checkType<Button>(l, 2, out guildChangeNamePanelBackButton);
			guildManagementUIController.m_luaExportHelper.m_guildChangeNamePanelBackButton = guildChangeNamePanelBackButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E618 RID: 124440 RVA: 0x009C6B2C File Offset: 0x009C4D2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_guildChangeNamePanelChangeNameButton(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUIController.m_luaExportHelper.m_guildChangeNamePanelChangeNameButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E619 RID: 124441 RVA: 0x009C6B84 File Offset: 0x009C4D84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_guildChangeNamePanelChangeNameButton(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			Button guildChangeNamePanelChangeNameButton;
			LuaObject.checkType<Button>(l, 2, out guildChangeNamePanelChangeNameButton);
			guildManagementUIController.m_luaExportHelper.m_guildChangeNamePanelChangeNameButton = guildChangeNamePanelChangeNameButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E61A RID: 124442 RVA: 0x009C6BE0 File Offset: 0x009C4DE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_guildChangeNamePanelChangeNameButtonStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUIController.m_luaExportHelper.m_guildChangeNamePanelChangeNameButtonStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E61B RID: 124443 RVA: 0x009C6C38 File Offset: 0x009C4E38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_guildChangeNamePanelChangeNameButtonStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			CommonUIStateController guildChangeNamePanelChangeNameButtonStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out guildChangeNamePanelChangeNameButtonStateCtrl);
			guildManagementUIController.m_luaExportHelper.m_guildChangeNamePanelChangeNameButtonStateCtrl = guildChangeNamePanelChangeNameButtonStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E61C RID: 124444 RVA: 0x009C6C94 File Offset: 0x009C4E94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_guildChangeNamePanelInputField(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUIController.m_luaExportHelper.m_guildChangeNamePanelInputField);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E61D RID: 124445 RVA: 0x009C6CEC File Offset: 0x009C4EEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_guildChangeNamePanelInputField(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			InputField guildChangeNamePanelInputField;
			LuaObject.checkType<InputField>(l, 2, out guildChangeNamePanelInputField);
			guildManagementUIController.m_luaExportHelper.m_guildChangeNamePanelInputField = guildChangeNamePanelInputField;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E61E RID: 124446 RVA: 0x009C6D48 File Offset: 0x009C4F48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_guildChangeNamePanelValueText(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUIController.m_luaExportHelper.m_guildChangeNamePanelValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E61F RID: 124447 RVA: 0x009C6DA0 File Offset: 0x009C4FA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_guildChangeNamePanelValueText(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			Text guildChangeNamePanelValueText;
			LuaObject.checkType<Text>(l, 2, out guildChangeNamePanelValueText);
			guildManagementUIController.m_luaExportHelper.m_guildChangeNamePanelValueText = guildChangeNamePanelValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E620 RID: 124448 RVA: 0x009C6DFC File Offset: 0x009C4FFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_messagePanelStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUIController.m_luaExportHelper.m_messagePanelStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E621 RID: 124449 RVA: 0x009C6E54 File Offset: 0x009C5054
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_messagePanelStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			CommonUIStateController messagePanelStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out messagePanelStateCtrl);
			guildManagementUIController.m_luaExportHelper.m_messagePanelStateCtrl = messagePanelStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E622 RID: 124450 RVA: 0x009C6EB0 File Offset: 0x009C50B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_messagePanelBackButton(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUIController.m_luaExportHelper.m_messagePanelBackButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E623 RID: 124451 RVA: 0x009C6F08 File Offset: 0x009C5108
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_messagePanelBackButton(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			Button messagePanelBackButton;
			LuaObject.checkType<Button>(l, 2, out messagePanelBackButton);
			guildManagementUIController.m_luaExportHelper.m_messagePanelBackButton = messagePanelBackButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E624 RID: 124452 RVA: 0x009C6F64 File Offset: 0x009C5164
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_messagePanelApplyToggle(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUIController.m_luaExportHelper.m_messagePanelApplyToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E625 RID: 124453 RVA: 0x009C6FBC File Offset: 0x009C51BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_messagePanelApplyToggle(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			Toggle messagePanelApplyToggle;
			LuaObject.checkType<Toggle>(l, 2, out messagePanelApplyToggle);
			guildManagementUIController.m_luaExportHelper.m_messagePanelApplyToggle = messagePanelApplyToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E626 RID: 124454 RVA: 0x009C7018 File Offset: 0x009C5218
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_messagePanelJournalToggle(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUIController.m_luaExportHelper.m_messagePanelJournalToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E627 RID: 124455 RVA: 0x009C7070 File Offset: 0x009C5270
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_messagePanelJournalToggle(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			Toggle messagePanelJournalToggle;
			LuaObject.checkType<Toggle>(l, 2, out messagePanelJournalToggle);
			guildManagementUIController.m_luaExportHelper.m_messagePanelJournalToggle = messagePanelJournalToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E628 RID: 124456 RVA: 0x009C70CC File Offset: 0x009C52CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_messageApplyPanelPowerButton(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUIController.m_luaExportHelper.m_messageApplyPanelPowerButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E629 RID: 124457 RVA: 0x009C7124 File Offset: 0x009C5324
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_messageApplyPanelPowerButton(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			Button messageApplyPanelPowerButton;
			LuaObject.checkType<Button>(l, 2, out messageApplyPanelPowerButton);
			guildManagementUIController.m_luaExportHelper.m_messageApplyPanelPowerButton = messageApplyPanelPowerButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E62A RID: 124458 RVA: 0x009C7180 File Offset: 0x009C5380
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_messageApplyPanelPowerButtonStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUIController.m_luaExportHelper.m_messageApplyPanelPowerButtonStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E62B RID: 124459 RVA: 0x009C71D8 File Offset: 0x009C53D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_messageApplyPanelPowerButtonStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			CommonUIStateController messageApplyPanelPowerButtonStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out messageApplyPanelPowerButtonStateCtrl);
			guildManagementUIController.m_luaExportHelper.m_messageApplyPanelPowerButtonStateCtrl = messageApplyPanelPowerButtonStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E62C RID: 124460 RVA: 0x009C7234 File Offset: 0x009C5434
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_messageApplyPanelMessageListScrollRect(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUIController.m_luaExportHelper.m_messageApplyPanelMessageListScrollRect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E62D RID: 124461 RVA: 0x009C728C File Offset: 0x009C548C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_messageApplyPanelMessageListScrollRect(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			ScrollRect messageApplyPanelMessageListScrollRect;
			LuaObject.checkType<ScrollRect>(l, 2, out messageApplyPanelMessageListScrollRect);
			guildManagementUIController.m_luaExportHelper.m_messageApplyPanelMessageListScrollRect = messageApplyPanelMessageListScrollRect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E62E RID: 124462 RVA: 0x009C72E8 File Offset: 0x009C54E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_messageApplyPanelMessageListScrollContent(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUIController.m_luaExportHelper.m_messageApplyPanelMessageListScrollContent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E62F RID: 124463 RVA: 0x009C7340 File Offset: 0x009C5540
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_messageApplyPanelMessageListScrollContent(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			GameObject messageApplyPanelMessageListScrollContent;
			LuaObject.checkType<GameObject>(l, 2, out messageApplyPanelMessageListScrollContent);
			guildManagementUIController.m_luaExportHelper.m_messageApplyPanelMessageListScrollContent = messageApplyPanelMessageListScrollContent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E630 RID: 124464 RVA: 0x009C739C File Offset: 0x009C559C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_messagePlayerItemPrafeb(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUIController.m_luaExportHelper.m_messagePlayerItemPrafeb);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E631 RID: 124465 RVA: 0x009C73F4 File Offset: 0x009C55F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_messagePlayerItemPrafeb(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			GameObject messagePlayerItemPrafeb;
			LuaObject.checkType<GameObject>(l, 2, out messagePlayerItemPrafeb);
			guildManagementUIController.m_luaExportHelper.m_messagePlayerItemPrafeb = messagePlayerItemPrafeb;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E632 RID: 124466 RVA: 0x009C7450 File Offset: 0x009C5650
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_messageApplyPanelAllRefuseButton(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUIController.m_luaExportHelper.m_messageApplyPanelAllRefuseButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E633 RID: 124467 RVA: 0x009C74A8 File Offset: 0x009C56A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_messageApplyPanelAllRefuseButton(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			Button messageApplyPanelAllRefuseButton;
			LuaObject.checkType<Button>(l, 2, out messageApplyPanelAllRefuseButton);
			guildManagementUIController.m_luaExportHelper.m_messageApplyPanelAllRefuseButton = messageApplyPanelAllRefuseButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E634 RID: 124468 RVA: 0x009C7504 File Offset: 0x009C5704
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_messageApplyPanelApplyTotalCountValueText(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUIController.m_luaExportHelper.m_messageApplyPanelApplyTotalCountValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E635 RID: 124469 RVA: 0x009C755C File Offset: 0x009C575C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_messageApplyPanelApplyTotalCountValueText(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			Text messageApplyPanelApplyTotalCountValueText;
			LuaObject.checkType<Text>(l, 2, out messageApplyPanelApplyTotalCountValueText);
			guildManagementUIController.m_luaExportHelper.m_messageApplyPanelApplyTotalCountValueText = messageApplyPanelApplyTotalCountValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E636 RID: 124470 RVA: 0x009C75B8 File Offset: 0x009C57B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_messageApplyPanelTotalPeopleNumberValueText(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUIController.m_luaExportHelper.m_messageApplyPanelTotalPeopleNumberValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E637 RID: 124471 RVA: 0x009C7610 File Offset: 0x009C5810
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_messageApplyPanelTotalPeopleNumberValueText(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			Text messageApplyPanelTotalPeopleNumberValueText;
			LuaObject.checkType<Text>(l, 2, out messageApplyPanelTotalPeopleNumberValueText);
			guildManagementUIController.m_luaExportHelper.m_messageApplyPanelTotalPeopleNumberValueText = messageApplyPanelTotalPeopleNumberValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E638 RID: 124472 RVA: 0x009C766C File Offset: 0x009C586C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_messageJournalPanelListScrollRect(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUIController.m_luaExportHelper.m_messageJournalPanelListScrollRect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E639 RID: 124473 RVA: 0x009C76C4 File Offset: 0x009C58C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_messageJournalPanelListScrollRect(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			ScrollRect messageJournalPanelListScrollRect;
			LuaObject.checkType<ScrollRect>(l, 2, out messageJournalPanelListScrollRect);
			guildManagementUIController.m_luaExportHelper.m_messageJournalPanelListScrollRect = messageJournalPanelListScrollRect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E63A RID: 124474 RVA: 0x009C7720 File Offset: 0x009C5920
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_messageJournalPanelListScrollContent(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUIController.m_luaExportHelper.m_messageJournalPanelListScrollContent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E63B RID: 124475 RVA: 0x009C7778 File Offset: 0x009C5978
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_messageJournalPanelListScrollContent(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			GameObject messageJournalPanelListScrollContent;
			LuaObject.checkType<GameObject>(l, 2, out messageJournalPanelListScrollContent);
			guildManagementUIController.m_luaExportHelper.m_messageJournalPanelListScrollContent = messageJournalPanelListScrollContent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E63C RID: 124476 RVA: 0x009C77D4 File Offset: 0x009C59D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_messageNoItemGameObject(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUIController.m_luaExportHelper.m_messageNoItemGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E63D RID: 124477 RVA: 0x009C782C File Offset: 0x009C5A2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_messageNoItemGameObject(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			GameObject messageNoItemGameObject;
			LuaObject.checkType<GameObject>(l, 2, out messageNoItemGameObject);
			guildManagementUIController.m_luaExportHelper.m_messageNoItemGameObject = messageNoItemGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E63E RID: 124478 RVA: 0x009C7888 File Offset: 0x009C5A88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_messageJournalItemPrafeb(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUIController.m_luaExportHelper.m_messageJournalItemPrafeb);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E63F RID: 124479 RVA: 0x009C78E0 File Offset: 0x009C5AE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_messageJournalItemPrafeb(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			GameObject messageJournalItemPrafeb;
			LuaObject.checkType<GameObject>(l, 2, out messageJournalItemPrafeb);
			guildManagementUIController.m_luaExportHelper.m_messageJournalItemPrafeb = messageJournalItemPrafeb;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E640 RID: 124480 RVA: 0x009C793C File Offset: 0x009C5B3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_invitePanelStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUIController.m_luaExportHelper.m_invitePanelStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E641 RID: 124481 RVA: 0x009C7994 File Offset: 0x009C5B94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_invitePanelStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			CommonUIStateController invitePanelStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out invitePanelStateCtrl);
			guildManagementUIController.m_luaExportHelper.m_invitePanelStateCtrl = invitePanelStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E642 RID: 124482 RVA: 0x009C79F0 File Offset: 0x009C5BF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_invitePanelBackButton(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUIController.m_luaExportHelper.m_invitePanelBackButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E643 RID: 124483 RVA: 0x009C7A48 File Offset: 0x009C5C48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_invitePanelBackButton(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			Button invitePanelBackButton;
			LuaObject.checkType<Button>(l, 2, out invitePanelBackButton);
			guildManagementUIController.m_luaExportHelper.m_invitePanelBackButton = invitePanelBackButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E644 RID: 124484 RVA: 0x009C7AA4 File Offset: 0x009C5CA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_invitePanelCloseButton(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUIController.m_luaExportHelper.m_invitePanelCloseButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E645 RID: 124485 RVA: 0x009C7AFC File Offset: 0x009C5CFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_invitePanelCloseButton(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			Button invitePanelCloseButton;
			LuaObject.checkType<Button>(l, 2, out invitePanelCloseButton);
			guildManagementUIController.m_luaExportHelper.m_invitePanelCloseButton = invitePanelCloseButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E646 RID: 124486 RVA: 0x009C7B58 File Offset: 0x009C5D58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_invitePanelChangeListButton(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUIController.m_luaExportHelper.m_invitePanelChangeListButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E647 RID: 124487 RVA: 0x009C7BB0 File Offset: 0x009C5DB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_invitePanelChangeListButton(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			Button invitePanelChangeListButton;
			LuaObject.checkType<Button>(l, 2, out invitePanelChangeListButton);
			guildManagementUIController.m_luaExportHelper.m_invitePanelChangeListButton = invitePanelChangeListButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E648 RID: 124488 RVA: 0x009C7C0C File Offset: 0x009C5E0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_inviteInfoPanelPeopleNumberText(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUIController.m_luaExportHelper.m_inviteInfoPanelPeopleNumberText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E649 RID: 124489 RVA: 0x009C7C64 File Offset: 0x009C5E64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_inviteInfoPanelPeopleNumberText(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			Text inviteInfoPanelPeopleNumberText;
			LuaObject.checkType<Text>(l, 2, out inviteInfoPanelPeopleNumberText);
			guildManagementUIController.m_luaExportHelper.m_inviteInfoPanelPeopleNumberText = inviteInfoPanelPeopleNumberText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E64A RID: 124490 RVA: 0x009C7CC0 File Offset: 0x009C5EC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_inviteInfoPanelActiveText(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUIController.m_luaExportHelper.m_inviteInfoPanelActiveText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E64B RID: 124491 RVA: 0x009C7D18 File Offset: 0x009C5F18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_inviteInfoPanelActiveText(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			Text inviteInfoPanelActiveText;
			LuaObject.checkType<Text>(l, 2, out inviteInfoPanelActiveText);
			guildManagementUIController.m_luaExportHelper.m_inviteInfoPanelActiveText = inviteInfoPanelActiveText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E64C RID: 124492 RVA: 0x009C7D74 File Offset: 0x009C5F74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_inviteInfoPanelLevelText(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUIController.m_luaExportHelper.m_inviteInfoPanelLevelText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E64D RID: 124493 RVA: 0x009C7DCC File Offset: 0x009C5FCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_inviteInfoPanelLevelText(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			Text inviteInfoPanelLevelText;
			LuaObject.checkType<Text>(l, 2, out inviteInfoPanelLevelText);
			guildManagementUIController.m_luaExportHelper.m_inviteInfoPanelLevelText = inviteInfoPanelLevelText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E64E RID: 124494 RVA: 0x009C7E28 File Offset: 0x009C6028
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_inviteInfoPanelDeclarationText(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUIController.m_luaExportHelper.m_inviteInfoPanelDeclarationText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E64F RID: 124495 RVA: 0x009C7E80 File Offset: 0x009C6080
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_inviteInfoPanelDeclarationText(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			Text inviteInfoPanelDeclarationText;
			LuaObject.checkType<Text>(l, 2, out inviteInfoPanelDeclarationText);
			guildManagementUIController.m_luaExportHelper.m_inviteInfoPanelDeclarationText = inviteInfoPanelDeclarationText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E650 RID: 124496 RVA: 0x009C7EDC File Offset: 0x009C60DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_inviteInfoPanelDeclarationChangeButton(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUIController.m_luaExportHelper.m_inviteInfoPanelDeclarationChangeButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E651 RID: 124497 RVA: 0x009C7F34 File Offset: 0x009C6134
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_inviteInfoPanelDeclarationChangeButton(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			Button inviteInfoPanelDeclarationChangeButton;
			LuaObject.checkType<Button>(l, 2, out inviteInfoPanelDeclarationChangeButton);
			guildManagementUIController.m_luaExportHelper.m_inviteInfoPanelDeclarationChangeButton = inviteInfoPanelDeclarationChangeButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E652 RID: 124498 RVA: 0x009C7F90 File Offset: 0x009C6190
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_inviteListPanelSociatyListScrollRect(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUIController.m_luaExportHelper.m_inviteListPanelSociatyListScrollRect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E653 RID: 124499 RVA: 0x009C7FE8 File Offset: 0x009C61E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_inviteListPanelSociatyListScrollRect(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			ScrollRect inviteListPanelSociatyListScrollRect;
			LuaObject.checkType<ScrollRect>(l, 2, out inviteListPanelSociatyListScrollRect);
			guildManagementUIController.m_luaExportHelper.m_inviteListPanelSociatyListScrollRect = inviteListPanelSociatyListScrollRect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E654 RID: 124500 RVA: 0x009C8044 File Offset: 0x009C6244
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_inviteListPanelSociatyListScrollContent(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUIController.m_luaExportHelper.m_inviteListPanelSociatyListScrollContent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E655 RID: 124501 RVA: 0x009C809C File Offset: 0x009C629C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_inviteListPanelSociatyListScrollContent(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			GameObject inviteListPanelSociatyListScrollContent;
			LuaObject.checkType<GameObject>(l, 2, out inviteListPanelSociatyListScrollContent);
			guildManagementUIController.m_luaExportHelper.m_inviteListPanelSociatyListScrollContent = inviteListPanelSociatyListScrollContent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E656 RID: 124502 RVA: 0x009C80F8 File Offset: 0x009C62F8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_inviteListPanelPowerButton(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUIController.m_luaExportHelper.m_inviteListPanelPowerButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E657 RID: 124503 RVA: 0x009C8150 File Offset: 0x009C6350
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_inviteListPanelPowerButton(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			Button inviteListPanelPowerButton;
			LuaObject.checkType<Button>(l, 2, out inviteListPanelPowerButton);
			guildManagementUIController.m_luaExportHelper.m_inviteListPanelPowerButton = inviteListPanelPowerButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E658 RID: 124504 RVA: 0x009C81AC File Offset: 0x009C63AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_inviteListPanelPowerButtonStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUIController.m_luaExportHelper.m_inviteListPanelPowerButtonStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E659 RID: 124505 RVA: 0x009C8204 File Offset: 0x009C6404
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_inviteListPanelPowerButtonStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			CommonUIStateController inviteListPanelPowerButtonStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out inviteListPanelPowerButtonStateCtrl);
			guildManagementUIController.m_luaExportHelper.m_inviteListPanelPowerButtonStateCtrl = inviteListPanelPowerButtonStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E65A RID: 124506 RVA: 0x009C8260 File Offset: 0x009C6460
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_invitePlayerInfoItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUIController.m_luaExportHelper.m_invitePlayerInfoItemPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E65B RID: 124507 RVA: 0x009C82B8 File Offset: 0x009C64B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_invitePlayerInfoItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			GameObject invitePlayerInfoItemPrefab;
			LuaObject.checkType<GameObject>(l, 2, out invitePlayerInfoItemPrefab);
			guildManagementUIController.m_luaExportHelper.m_invitePlayerInfoItemPrefab = invitePlayerInfoItemPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E65C RID: 124508 RVA: 0x009C8314 File Offset: 0x009C6514
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_quitDialogStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUIController.m_luaExportHelper.m_quitDialogStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E65D RID: 124509 RVA: 0x009C836C File Offset: 0x009C656C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_quitDialogStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			CommonUIStateController quitDialogStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out quitDialogStateCtrl);
			guildManagementUIController.m_luaExportHelper.m_quitDialogStateCtrl = quitDialogStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E65E RID: 124510 RVA: 0x009C83C8 File Offset: 0x009C65C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_quitDialogTitleText(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUIController.m_luaExportHelper.m_quitDialogTitleText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E65F RID: 124511 RVA: 0x009C8420 File Offset: 0x009C6620
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_quitDialogTitleText(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			Text quitDialogTitleText;
			LuaObject.checkType<Text>(l, 2, out quitDialogTitleText);
			guildManagementUIController.m_luaExportHelper.m_quitDialogTitleText = quitDialogTitleText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E660 RID: 124512 RVA: 0x009C847C File Offset: 0x009C667C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_quitDialogTipText(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUIController.m_luaExportHelper.m_quitDialogTipText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E661 RID: 124513 RVA: 0x009C84D4 File Offset: 0x009C66D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_quitDialogTipText(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			Text quitDialogTipText;
			LuaObject.checkType<Text>(l, 2, out quitDialogTipText);
			guildManagementUIController.m_luaExportHelper.m_quitDialogTipText = quitDialogTipText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E662 RID: 124514 RVA: 0x009C8530 File Offset: 0x009C6730
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_quitDialogConfirmButton(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUIController.m_luaExportHelper.m_quitDialogConfirmButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E663 RID: 124515 RVA: 0x009C8588 File Offset: 0x009C6788
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_quitDialogConfirmButton(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			Button quitDialogConfirmButton;
			LuaObject.checkType<Button>(l, 2, out quitDialogConfirmButton);
			guildManagementUIController.m_luaExportHelper.m_quitDialogConfirmButton = quitDialogConfirmButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E664 RID: 124516 RVA: 0x009C85E4 File Offset: 0x009C67E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_quitDialogCancelButton(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUIController.m_luaExportHelper.m_quitDialogCancelButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E665 RID: 124517 RVA: 0x009C863C File Offset: 0x009C683C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_quitDialogCancelButton(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			Button quitDialogCancelButton;
			LuaObject.checkType<Button>(l, 2, out quitDialogCancelButton);
			guildManagementUIController.m_luaExportHelper.m_quitDialogCancelButton = quitDialogCancelButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E666 RID: 124518 RVA: 0x009C8698 File Offset: 0x009C6898
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUIController.m_luaExportHelper.m_playerContext);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E667 RID: 124519 RVA: 0x009C86F0 File Offset: 0x009C68F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			ProjectLPlayerContext playerContext;
			LuaObject.checkType<ProjectLPlayerContext>(l, 2, out playerContext);
			guildManagementUIController.m_luaExportHelper.m_playerContext = playerContext;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E668 RID: 124520 RVA: 0x009C874C File Offset: 0x009C694C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUIController.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E669 RID: 124521 RVA: 0x009C87A4 File Offset: 0x009C69A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			guildManagementUIController.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E66A RID: 124522 RVA: 0x009C8800 File Offset: 0x009C6A00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_StateName_Up(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, GuildManagementUIController.LuaExportHelper.StateName_Up);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E66B RID: 124523 RVA: 0x009C8848 File Offset: 0x009C6A48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_StateName_Down(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, GuildManagementUIController.LuaExportHelper.StateName_Down);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E66C RID: 124524 RVA: 0x009C8890 File Offset: 0x009C6A90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_StateName_Hide(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, GuildManagementUIController.LuaExportHelper.StateName_Hide);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E66D RID: 124525 RVA: 0x009C88D8 File Offset: 0x009C6AD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isManageListPowerAscend(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUIController.m_luaExportHelper.m_isManageListPowerAscend);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E66E RID: 124526 RVA: 0x009C8930 File Offset: 0x009C6B30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isManageListPowerAscend(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			bool isManageListPowerAscend;
			LuaObject.checkType(l, 2, out isManageListPowerAscend);
			guildManagementUIController.m_luaExportHelper.m_isManageListPowerAscend = isManageListPowerAscend;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E66F RID: 124527 RVA: 0x009C898C File Offset: 0x009C6B8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isManageListActiveAscend(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUIController.m_luaExportHelper.m_isManageListActiveAscend);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E670 RID: 124528 RVA: 0x009C89E4 File Offset: 0x009C6BE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isManageListActiveAscend(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			bool isManageListActiveAscend;
			LuaObject.checkType(l, 2, out isManageListActiveAscend);
			guildManagementUIController.m_luaExportHelper.m_isManageListActiveAscend = isManageListActiveAscend;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E671 RID: 124529 RVA: 0x009C8A40 File Offset: 0x009C6C40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isMessageApplyListPowerAscend(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUIController.m_luaExportHelper.m_isMessageApplyListPowerAscend);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E672 RID: 124530 RVA: 0x009C8A98 File Offset: 0x009C6C98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isMessageApplyListPowerAscend(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			bool isMessageApplyListPowerAscend;
			LuaObject.checkType(l, 2, out isMessageApplyListPowerAscend);
			guildManagementUIController.m_luaExportHelper.m_isMessageApplyListPowerAscend = isMessageApplyListPowerAscend;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E673 RID: 124531 RVA: 0x009C8AF4 File Offset: 0x009C6CF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isInviteListPanelPowerAscend(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUIController.m_luaExportHelper.m_isInviteListPanelPowerAscend);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E674 RID: 124532 RVA: 0x009C8B4C File Offset: 0x009C6D4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isInviteListPanelPowerAscend(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			bool isInviteListPanelPowerAscend;
			LuaObject.checkType(l, 2, out isInviteListPanelPowerAscend);
			guildManagementUIController.m_luaExportHelper.m_isInviteListPanelPowerAscend = isInviteListPanelPowerAscend;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E675 RID: 124533 RVA: 0x009C8BA8 File Offset: 0x009C6DA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isMessageApplyPanelSortByPower(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUIController.m_luaExportHelper.m_isMessageApplyPanelSortByPower);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E676 RID: 124534 RVA: 0x009C8C00 File Offset: 0x009C6E00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isMessageApplyPanelSortByPower(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			bool isMessageApplyPanelSortByPower;
			LuaObject.checkType(l, 2, out isMessageApplyPanelSortByPower);
			guildManagementUIController.m_luaExportHelper.m_isMessageApplyPanelSortByPower = isMessageApplyPanelSortByPower;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E677 RID: 124535 RVA: 0x009C8C5C File Offset: 0x009C6E5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerInfoCtrlList(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUIController.m_luaExportHelper.m_playerInfoCtrlList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E678 RID: 124536 RVA: 0x009C8CB4 File Offset: 0x009C6EB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerInfoCtrlList(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			List<GuildMemberInfoItemUIController> playerInfoCtrlList;
			LuaObject.checkType<List<GuildMemberInfoItemUIController>>(l, 2, out playerInfoCtrlList);
			guildManagementUIController.m_luaExportHelper.m_playerInfoCtrlList = playerInfoCtrlList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E679 RID: 124537 RVA: 0x009C8D10 File Offset: 0x009C6F10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_applyPlayerInfoCtrlList(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUIController.m_luaExportHelper.m_applyPlayerInfoCtrlList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E67A RID: 124538 RVA: 0x009C8D68 File Offset: 0x009C6F68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_applyPlayerInfoCtrlList(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			List<GuildApplyMemberInfoItemUIController> applyPlayerInfoCtrlList;
			LuaObject.checkType<List<GuildApplyMemberInfoItemUIController>>(l, 2, out applyPlayerInfoCtrlList);
			guildManagementUIController.m_luaExportHelper.m_applyPlayerInfoCtrlList = applyPlayerInfoCtrlList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E67B RID: 124539 RVA: 0x009C8DC4 File Offset: 0x009C6FC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_guildJournalItemCtrlList(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUIController.m_luaExportHelper.m_guildJournalItemCtrlList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E67C RID: 124540 RVA: 0x009C8E1C File Offset: 0x009C701C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_guildJournalItemCtrlList(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			List<GuildJournalItemUIController> guildJournalItemCtrlList;
			LuaObject.checkType<List<GuildJournalItemUIController>>(l, 2, out guildJournalItemCtrlList);
			guildManagementUIController.m_luaExportHelper.m_guildJournalItemCtrlList = guildJournalItemCtrlList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E67D RID: 124541 RVA: 0x009C8E78 File Offset: 0x009C7078
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_inviteMemberInfoCtrlList(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUIController.m_luaExportHelper.m_inviteMemberInfoCtrlList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E67E RID: 124542 RVA: 0x009C8ED0 File Offset: 0x009C70D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_inviteMemberInfoCtrlList(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			List<GuildInviteMemberInfoItemUIController> inviteMemberInfoCtrlList;
			LuaObject.checkType<List<GuildInviteMemberInfoItemUIController>>(l, 2, out inviteMemberInfoCtrlList);
			guildManagementUIController.m_luaExportHelper.m_inviteMemberInfoCtrlList = inviteMemberInfoCtrlList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E67F RID: 124543 RVA: 0x009C8F2C File Offset: 0x009C712C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_guild(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUIController.m_luaExportHelper.m_guild);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E680 RID: 124544 RVA: 0x009C8F84 File Offset: 0x009C7184
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_guild(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			Guild guild;
			LuaObject.checkType<Guild>(l, 2, out guild);
			guildManagementUIController.m_luaExportHelper.m_guild = guild;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E681 RID: 124545 RVA: 0x009C8FE0 File Offset: 0x009C71E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_guildTitle(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)guildManagementUIController.m_luaExportHelper.m_guildTitle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E682 RID: 124546 RVA: 0x009C9038 File Offset: 0x009C7238
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_guildTitle(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			GuildTitle guildTitle;
			LuaObject.checkEnum<GuildTitle>(l, 2, out guildTitle);
			guildManagementUIController.m_luaExportHelper.m_guildTitle = guildTitle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E683 RID: 124547 RVA: 0x009C9094 File Offset: 0x009C7294
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_canInvitePlayerList(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUIController.m_luaExportHelper.m_canInvitePlayerList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E684 RID: 124548 RVA: 0x009C90EC File Offset: 0x009C72EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_canInvitePlayerList(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			List<UserSummary> canInvitePlayerList;
			LuaObject.checkType<List<UserSummary>>(l, 2, out canInvitePlayerList);
			guildManagementUIController.m_luaExportHelper.m_canInvitePlayerList = canInvitePlayerList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E685 RID: 124549 RVA: 0x009C9148 File Offset: 0x009C7348
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isGuildAutoJoin(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUIController.m_luaExportHelper.m_isGuildAutoJoin);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E686 RID: 124550 RVA: 0x009C91A0 File Offset: 0x009C73A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isGuildAutoJoin(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			bool isGuildAutoJoin;
			LuaObject.checkType(l, 2, out isGuildAutoJoin);
			guildManagementUIController.m_luaExportHelper.m_isGuildAutoJoin = isGuildAutoJoin;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E687 RID: 124551 RVA: 0x009C91FC File Offset: 0x009C73FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_guildJoinLevel(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUIController.m_luaExportHelper.m_guildJoinLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E688 RID: 124552 RVA: 0x009C9254 File Offset: 0x009C7454
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_guildJoinLevel(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			int guildJoinLevel;
			LuaObject.checkType(l, 2, out guildJoinLevel);
			guildManagementUIController.m_luaExportHelper.m_guildJoinLevel = guildJoinLevel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E689 RID: 124553 RVA: 0x009C92B0 File Offset: 0x009C74B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_messageApplyUserSummarys(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUIController.m_luaExportHelper.m_messageApplyUserSummarys);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E68A RID: 124554 RVA: 0x009C9308 File Offset: 0x009C7508
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_messageApplyUserSummarys(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			List<UserSummary> messageApplyUserSummarys;
			LuaObject.checkType<List<UserSummary>>(l, 2, out messageApplyUserSummarys);
			guildManagementUIController.m_luaExportHelper.m_messageApplyUserSummarys = messageApplyUserSummarys;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E68B RID: 124555 RVA: 0x009C9364 File Offset: 0x009C7564
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_guildListSortType(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)guildManagementUIController.m_luaExportHelper.m_guildListSortType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E68C RID: 124556 RVA: 0x009C93BC File Offset: 0x009C75BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_guildListSortType(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUIController guildManagementUIController = (GuildManagementUIController)LuaObject.checkSelf(l);
			GuildManagementUIController.GuildListSortType guildListSortType;
			LuaObject.checkEnum<GuildManagementUIController.GuildListSortType>(l, 2, out guildListSortType);
			guildManagementUIController.m_luaExportHelper.m_guildListSortType = guildListSortType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E68D RID: 124557 RVA: 0x009C9418 File Offset: 0x009C7618
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.GuildManagementUIController");
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.Open);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.Close);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.UpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.SetMessageRedPoint);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.RefreshGuildTitle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.SetStateByGuildTitle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.SetSociatyInfoPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.SetSociatyListPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.OnGuildManagementListPlayeItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.OnReturnImgButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.OnInfoButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.OnGuildCoinButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.ClearData);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.CloseAllSmallPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.OnOnlineButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.OnActiveButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.OnPowerButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.SetSortButtonState);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.SortByTitle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.SortByPower);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.SortByActive);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.SortGuildListByDefault);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.SortByDefaultType);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.SortByActiveType);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.SortByBattlePowerType);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.OnSociatyNameChangeButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.OnGuildChangeNamePanelChangeNameButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.OnGuildChangeNamePanelBackButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.OnDeclarationButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.OnDeclarationChangePanelSaveButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.OnDeclarationChangePanelBackButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.OnQuitButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.OnQuitGuildConfirmButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.CloseQuitGuildConfirmPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.OnSociatyPlayButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.OnShopButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.OnWealButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.OnMessageButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.SendNtfBeforeOpenMessagePanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.SetMessageApplyPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.OnGuildApplyMemberAcceptResult);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache29);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.SetMessageJournalPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache2A);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.OnMssageApplyPanelPowerButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache2B);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.OnMessagePanelBackButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache2C);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.CloseMessagePanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache2D);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.OnMessagePanelApplyToggleValueChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache2E);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.OnMessagePanelJournalToggleValueChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache2F);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.OnMessageApplyPanelAllRefuseButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache30);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.OnInviteButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache31);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.SetInvitePanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache32);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.SetInviteInfoPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache33);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.SetInviteListPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache34);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.OnInviteMemberInfoItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache35);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.OnInviteListPanelPowerButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache36);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.OnInvitePanelChangeListButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache37);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.OnInvitePanelBackButton);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache38);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.CloseInvitePanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache39);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.OnInviteInfoPanelDeclarationChangeButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache3A);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.SetRecruitChangeSubPanelInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache3B);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.OnRecruitPanelSaveButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache3C);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.OnRecruitPanelBackButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache3D);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.OnInvitePanelSetButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache3E);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.SetGuildSetSubPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache3F);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.OnGuildSetPanelChairmanToggleClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache40);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.OnGuildSetPanelAutoToggleClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache41);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.OnGuildSetPanelLevelInputFieldRightButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache42);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.OnGuildSetPanelLevelInputFieldLeftButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache43);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.OnGuildSetPanelLevelInputFieldEditEnd);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache44);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.OnGuildSetPanelSaveButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache45);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.OnGuildSetPanelBackButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache46);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.CloseGuildSetPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache47);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache48);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache49);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache4A);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache4B);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache4C);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache4D);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache4E);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache4F);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache50);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache51);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache52);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache53);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache54);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache55 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache55 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.__callDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache55);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache56 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache56 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.__clearDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache56);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache57 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache57 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.__callDele_EventOnChangeGuildName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache57);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache58 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache58 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.__clearDele_EventOnChangeGuildName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache58);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache59 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache59 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.__callDele_EventOnGuildAnnouncementSet);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache59);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache5A == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache5A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.__clearDele_EventOnGuildAnnouncementSet);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache5A);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache5B == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache5B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.__callDele_EventOnQuitGuild);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache5B);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache5C == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache5C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.__clearDele_EventOnQuitGuild);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache5C);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache5D == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache5D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.__callDele_EventOnGetCanInvitePlayerList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache5D);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache5E == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache5E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.__clearDele_EventOnGetCanInvitePlayerList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache5E);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache5F == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache5F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.__callDele_EventOnGuildHiringDeclarationSet);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache5F);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache60 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache60 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.__clearDele_EventOnGuildHiringDeclarationSet);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache60);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache61 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache61 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.__callDele_EventOnGuildInfoSet);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache61);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache62 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache62 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.__clearDele_EventOnGuildInfoSet);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache62);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache63 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache63 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.__callDele_EventOnGetGuildJoinApply);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache63);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache64 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache64 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.__clearDele_EventOnGetGuildJoinApply);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache64);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache65 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache65 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.__callDele_EventOnGetGuildJournal);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache65);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache66 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache66 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.__clearDele_EventOnGetGuildJournal);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache66);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache67 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache67 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.__callDele_EventOnGuildJoinConfirmOrRefuse);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache67);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache68 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache68 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.__clearDele_EventOnGuildJoinConfirmOrRefuse);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache68);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache69 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache69 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.__callDele_EventOnGuildInviteMember);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache69);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache6A == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache6A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.__clearDele_EventOnGuildInviteMember);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache6A);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache6B == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache6B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.__callDele_EventOnGuildMemberClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache6B);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache6C == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache6C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.__clearDele_EventOnGuildMemberClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache6C);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache6D == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache6D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.__callDele_EventOnAllRefuseButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache6D);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache6E == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache6E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.__clearDele_EventOnAllRefuseButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache6E);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache6F == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache6F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.__callDele_EventOnGotoGuildStore);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache6F);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache70 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache70 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.__clearDele_EventOnGotoGuildStore);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache70);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache71 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache71 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.__callDele_EventOnGotoGuildGameListPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache71);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache72 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache72 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.__clearDele_EventOnGotoGuildGameListPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache72);
		string name = "EventOnClose";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache73 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache73 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_EventOnClose);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache73, true);
		string name2 = "EventOnChangeGuildName";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache74 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache74 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_EventOnChangeGuildName);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache74, true);
		string name3 = "EventOnGuildAnnouncementSet";
		LuaCSFunction get3 = null;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache75 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache75 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_EventOnGuildAnnouncementSet);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache75, true);
		string name4 = "EventOnQuitGuild";
		LuaCSFunction get4 = null;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache76 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache76 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_EventOnQuitGuild);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache76, true);
		string name5 = "EventOnGetCanInvitePlayerList";
		LuaCSFunction get5 = null;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache77 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache77 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_EventOnGetCanInvitePlayerList);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache77, true);
		string name6 = "EventOnGuildHiringDeclarationSet";
		LuaCSFunction get6 = null;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache78 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache78 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_EventOnGuildHiringDeclarationSet);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache78, true);
		string name7 = "EventOnGuildInfoSet";
		LuaCSFunction get7 = null;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache79 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache79 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_EventOnGuildInfoSet);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache79, true);
		string name8 = "EventOnGetGuildJoinApply";
		LuaCSFunction get8 = null;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache7A == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache7A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_EventOnGetGuildJoinApply);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache7A, true);
		string name9 = "EventOnGetGuildJournal";
		LuaCSFunction get9 = null;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache7B == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache7B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_EventOnGetGuildJournal);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache7B, true);
		string name10 = "EventOnGuildJoinConfirmOrRefuse";
		LuaCSFunction get10 = null;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache7C == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache7C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_EventOnGuildJoinConfirmOrRefuse);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache7C, true);
		string name11 = "EventOnGuildInviteMember";
		LuaCSFunction get11 = null;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache7D == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache7D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_EventOnGuildInviteMember);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache7D, true);
		string name12 = "EventOnGuildMemberClick";
		LuaCSFunction get12 = null;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache7E == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache7E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_EventOnGuildMemberClick);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache7E, true);
		string name13 = "EventOnAllRefuseButtonClick";
		LuaCSFunction get13 = null;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache7F == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache7F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_EventOnAllRefuseButtonClick);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache7F, true);
		string name14 = "EventOnGotoGuildStore";
		LuaCSFunction get14 = null;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache80 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache80 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_EventOnGotoGuildStore);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache80, true);
		string name15 = "EventOnGotoGuildGameListPanel";
		LuaCSFunction get15 = null;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache81 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache81 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_EventOnGotoGuildGameListPanel);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache81, true);
		string name16 = "m_commonUIStateController";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache82 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache82 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_commonUIStateController);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache82;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache83 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache83 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_commonUIStateController);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache83, true);
		string name17 = "m_returnButton";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache84 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache84 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_returnButton);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache84;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache85 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache85 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_returnButton);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache85, true);
		string name18 = "m_infoButton";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache86 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache86 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_infoButton);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache86;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache87 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache87 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_infoButton);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache87, true);
		string name19 = "m_sociatyName";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache88 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache88 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_sociatyName);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache88;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache89 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache89 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_sociatyName);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache89, true);
		string name20 = "m_sociatyNameChangeButton";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache8A == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache8A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_sociatyNameChangeButton);
		}
		LuaCSFunction get20 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache8A;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache8B == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache8B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_sociatyNameChangeButton);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache8B, true);
		string name21 = "m_mainPanelStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache8C == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache8C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_mainPanelStateCtrl);
		}
		LuaCSFunction get21 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache8C;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache8D == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache8D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_mainPanelStateCtrl);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache8D, true);
		string name22 = "m_guildCoinText";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache8E == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache8E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_guildCoinText);
		}
		LuaCSFunction get22 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache8E;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache8F == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache8F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_guildCoinText);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache8F, true);
		string name23 = "m_guildCoinDescButton";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache90 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache90 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_guildCoinDescButton);
		}
		LuaCSFunction get23 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache90;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache91 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache91 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_guildCoinDescButton);
		}
		LuaObject.addMember(l, name23, get23, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache91, true);
		string name24 = "m_sociatyListScrollRect";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache92 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache92 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_sociatyListScrollRect);
		}
		LuaCSFunction get24 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache92;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache93 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache93 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_sociatyListScrollRect);
		}
		LuaObject.addMember(l, name24, get24, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache93, true);
		string name25 = "m_sociatyListScrollContent";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache94 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache94 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_sociatyListScrollContent);
		}
		LuaCSFunction get25 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache94;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache95 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache95 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_sociatyListScrollContent);
		}
		LuaObject.addMember(l, name25, get25, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache95, true);
		string name26 = "m_sociatyListPowerButton";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache96 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache96 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_sociatyListPowerButton);
		}
		LuaCSFunction get26 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache96;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache97 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache97 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_sociatyListPowerButton);
		}
		LuaObject.addMember(l, name26, get26, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache97, true);
		string name27 = "m_sociatyListPowerButtonStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache98 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache98 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_sociatyListPowerButtonStateCtrl);
		}
		LuaCSFunction get27 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache98;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache99 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache99 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_sociatyListPowerButtonStateCtrl);
		}
		LuaObject.addMember(l, name27, get27, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache99, true);
		string name28 = "m_sociatyListActiveButton";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache9A == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache9A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_sociatyListActiveButton);
		}
		LuaCSFunction get28 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache9A;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache9B == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache9B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_sociatyListActiveButton);
		}
		LuaObject.addMember(l, name28, get28, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache9B, true);
		string name29 = "m_sociatyListActiveButtonStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache9C == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache9C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_sociatyListActiveButtonStateCtrl);
		}
		LuaCSFunction get29 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache9C;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache9D == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache9D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_sociatyListActiveButtonStateCtrl);
		}
		LuaObject.addMember(l, name29, get29, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache9D, true);
		string name30 = "m_sociatyListOnlineButton";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache9E == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache9E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_sociatyListOnlineButton);
		}
		LuaCSFunction get30 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache9E;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache9F == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache9F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_sociatyListOnlineButton);
		}
		LuaObject.addMember(l, name30, get30, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache9F, true);
		string name31 = "m_sociatyListOnlineValueText";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheA0 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheA0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_sociatyListOnlineValueText);
		}
		LuaCSFunction get31 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheA0;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheA1 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheA1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_sociatyListOnlineValueText);
		}
		LuaObject.addMember(l, name31, get31, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheA1, true);
		string name32 = "m_playerInfoPrefabItem";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheA2 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheA2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_playerInfoPrefabItem);
		}
		LuaCSFunction get32 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheA2;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheA3 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheA3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_playerInfoPrefabItem);
		}
		LuaObject.addMember(l, name32, get32, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheA3, true);
		string name33 = "m_infoSociatyIDText";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheA4 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheA4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_infoSociatyIDText);
		}
		LuaCSFunction get33 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheA4;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheA5 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheA5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_infoSociatyIDText);
		}
		LuaObject.addMember(l, name33, get33, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheA5, true);
		string name34 = "m_infoPeopleNumberText";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheA6 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheA6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_infoPeopleNumberText);
		}
		LuaCSFunction get34 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheA6;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheA7 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheA7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_infoPeopleNumberText);
		}
		LuaObject.addMember(l, name34, get34, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheA7, true);
		string name35 = "m_infoPowerText";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheA8 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheA8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_infoPowerText);
		}
		LuaCSFunction get35 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheA8;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheA9 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheA9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_infoPowerText);
		}
		LuaObject.addMember(l, name35, get35, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheA9, true);
		string name36 = "m_infoActiveText";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheAA == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheAA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_infoActiveText);
		}
		LuaCSFunction get36 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheAA;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheAB == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheAB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_infoActiveText);
		}
		LuaObject.addMember(l, name36, get36, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheAB, true);
		string name37 = "m_infoCoinText";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheAC == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheAC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_infoCoinText);
		}
		LuaCSFunction get37 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheAC;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheAD == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheAD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_infoCoinText);
		}
		LuaObject.addMember(l, name37, get37, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheAD, true);
		string name38 = "m_infoDeclarationText";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheAE == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheAE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_infoDeclarationText);
		}
		LuaCSFunction get38 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheAE;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheAF == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheAF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_infoDeclarationText);
		}
		LuaObject.addMember(l, name38, get38, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheAF, true);
		string name39 = "m_infoDeclarationButton";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheB0 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheB0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_infoDeclarationButton);
		}
		LuaCSFunction get39 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheB0;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheB1 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheB1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_infoDeclarationButton);
		}
		LuaObject.addMember(l, name39, get39, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheB1, true);
		string name40 = "m_messageButton";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheB2 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheB2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_messageButton);
		}
		LuaCSFunction get40 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheB2;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheB3 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheB3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_messageButton);
		}
		LuaObject.addMember(l, name40, get40, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheB3, true);
		string name41 = "m_messageButtonRedPoint";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheB4 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheB4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_messageButtonRedPoint);
		}
		LuaCSFunction get41 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheB4;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheB5 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheB5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_messageButtonRedPoint);
		}
		LuaObject.addMember(l, name41, get41, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheB5, true);
		string name42 = "m_quitButton";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheB6 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheB6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_quitButton);
		}
		LuaCSFunction get42 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheB6;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheB7 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheB7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_quitButton);
		}
		LuaObject.addMember(l, name42, get42, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheB7, true);
		string name43 = "m_inviteButton";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheB8 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheB8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_inviteButton);
		}
		LuaCSFunction get43 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheB8;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheB9 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheB9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_inviteButton);
		}
		LuaObject.addMember(l, name43, get43, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheB9, true);
		string name44 = "m_wealButton";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheBA == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheBA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_wealButton);
		}
		LuaCSFunction get44 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheBA;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheBB == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheBB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_wealButton);
		}
		LuaObject.addMember(l, name44, get44, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheBB, true);
		string name45 = "m_shopButton";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheBC == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheBC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_shopButton);
		}
		LuaCSFunction get45 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheBC;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheBD == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheBD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_shopButton);
		}
		LuaObject.addMember(l, name45, get45, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheBD, true);
		string name46 = "m_sociatyPlayButton";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheBE == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheBE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_sociatyPlayButton);
		}
		LuaCSFunction get46 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheBE;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheBF == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheBF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_sociatyPlayButton);
		}
		LuaObject.addMember(l, name46, get46, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheBF, true);
		string name47 = "m_declarationChangePanelStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheC0 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheC0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_declarationChangePanelStateCtrl);
		}
		LuaCSFunction get47 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheC0;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheC1 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheC1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_declarationChangePanelStateCtrl);
		}
		LuaObject.addMember(l, name47, get47, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheC1, true);
		string name48 = "m_declarationChangePanelBackButton";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheC2 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheC2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_declarationChangePanelBackButton);
		}
		LuaCSFunction get48 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheC2;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheC3 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheC3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_declarationChangePanelBackButton);
		}
		LuaObject.addMember(l, name48, get48, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheC3, true);
		string name49 = "m_declarationChangePanelCloseButton";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheC4 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheC4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_declarationChangePanelCloseButton);
		}
		LuaCSFunction get49 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheC4;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheC5 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheC5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_declarationChangePanelCloseButton);
		}
		LuaObject.addMember(l, name49, get49, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheC5, true);
		string name50 = "m_declarationChangePanelSaveButton";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheC6 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheC6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_declarationChangePanelSaveButton);
		}
		LuaCSFunction get50 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheC6;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheC7 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheC7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_declarationChangePanelSaveButton);
		}
		LuaObject.addMember(l, name50, get50, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheC7, true);
		string name51 = "m_declarationChangePanelInputField";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheC8 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheC8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_declarationChangePanelInputField);
		}
		LuaCSFunction get51 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheC8;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheC9 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheC9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_declarationChangePanelInputField);
		}
		LuaObject.addMember(l, name51, get51, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheC9, true);
		string name52 = "m_recruitPanelStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheCA == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheCA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_recruitPanelStateCtrl);
		}
		LuaCSFunction get52 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheCA;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheCB == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheCB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_recruitPanelStateCtrl);
		}
		LuaObject.addMember(l, name52, get52, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheCB, true);
		string name53 = "m_recruitPanelBackButton";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheCC == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheCC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_recruitPanelBackButton);
		}
		LuaCSFunction get53 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheCC;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheCD == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheCD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_recruitPanelBackButton);
		}
		LuaObject.addMember(l, name53, get53, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheCD, true);
		string name54 = "m_recruitPanelCloseButton";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheCE == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheCE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_recruitPanelCloseButton);
		}
		LuaCSFunction get54 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheCE;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheCF == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheCF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_recruitPanelCloseButton);
		}
		LuaObject.addMember(l, name54, get54, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheCF, true);
		string name55 = "m_recruitPanelSaveButton";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheD0 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheD0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_recruitPanelSaveButton);
		}
		LuaCSFunction get55 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheD0;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheD1 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheD1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_recruitPanelSaveButton);
		}
		LuaObject.addMember(l, name55, get55, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheD1, true);
		string name56 = "m_recruitPanelInputField";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheD2 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheD2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_recruitPanelInputField);
		}
		LuaCSFunction get56 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheD2;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheD3 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheD3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_recruitPanelInputField);
		}
		LuaObject.addMember(l, name56, get56, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheD3, true);
		string name57 = "m_invitePanelSetButton";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheD4 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheD4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_invitePanelSetButton);
		}
		LuaCSFunction get57 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheD4;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheD5 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheD5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_invitePanelSetButton);
		}
		LuaObject.addMember(l, name57, get57, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheD5, true);
		string name58 = "m_guildSetPanelStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheD6 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheD6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_guildSetPanelStateCtrl);
		}
		LuaCSFunction get58 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheD6;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheD7 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheD7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_guildSetPanelStateCtrl);
		}
		LuaObject.addMember(l, name58, get58, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheD7, true);
		string name59 = "m_guildSetPanelBackButton";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheD8 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheD8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_guildSetPanelBackButton);
		}
		LuaCSFunction get59 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheD8;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheD9 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheD9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_guildSetPanelBackButton);
		}
		LuaObject.addMember(l, name59, get59, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheD9, true);
		string name60 = "m_guildSetPanelCloseButton";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheDA == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheDA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_guildSetPanelCloseButton);
		}
		LuaCSFunction get60 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheDA;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheDB == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheDB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_guildSetPanelCloseButton);
		}
		LuaObject.addMember(l, name60, get60, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheDB, true);
		string name61 = "m_guildSetPanelSaveButton";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheDC == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheDC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_guildSetPanelSaveButton);
		}
		LuaCSFunction get61 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheDC;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheDD == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheDD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_guildSetPanelSaveButton);
		}
		LuaObject.addMember(l, name61, get61, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheDD, true);
		string name62 = "m_guildSetPanelHireDeclarationInputField";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheDE == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheDE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_guildSetPanelHireDeclarationInputField);
		}
		LuaCSFunction get62 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheDE;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheDF == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheDF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_guildSetPanelHireDeclarationInputField);
		}
		LuaObject.addMember(l, name62, get62, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheDF, true);
		string name63 = "m_guildSetPanelLevelInputField";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheE0 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheE0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_guildSetPanelLevelInputField);
		}
		LuaCSFunction get63 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheE0;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheE1 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheE1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_guildSetPanelLevelInputField);
		}
		LuaObject.addMember(l, name63, get63, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheE1, true);
		string name64 = "m_guildSetPanelLevelInputFieldLeftButton";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheE2 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheE2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_guildSetPanelLevelInputFieldLeftButton);
		}
		LuaCSFunction get64 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheE2;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheE3 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheE3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_guildSetPanelLevelInputFieldLeftButton);
		}
		LuaObject.addMember(l, name64, get64, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheE3, true);
		string name65 = "m_guildSetPanelLevelInputFieldRightButton";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheE4 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheE4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_guildSetPanelLevelInputFieldRightButton);
		}
		LuaCSFunction get65 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheE4;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheE5 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheE5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_guildSetPanelLevelInputFieldRightButton);
		}
		LuaObject.addMember(l, name65, get65, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheE5, true);
		string name66 = "m_guildSetPanelApproveGroupAutoToggle";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheE6 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheE6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_guildSetPanelApproveGroupAutoToggle);
		}
		LuaCSFunction get66 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheE6;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheE7 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheE7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_guildSetPanelApproveGroupAutoToggle);
		}
		LuaObject.addMember(l, name66, get66, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheE7, true);
		string name67 = "m_guildSetPanelApproveGroupChairmanToggle";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheE8 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheE8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_guildSetPanelApproveGroupChairmanToggle);
		}
		LuaCSFunction get67 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheE8;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheE9 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheE9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_guildSetPanelApproveGroupChairmanToggle);
		}
		LuaObject.addMember(l, name67, get67, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheE9, true);
		string name68 = "m_guildChangeNamePanelStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheEA == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheEA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_guildChangeNamePanelStateCtrl);
		}
		LuaCSFunction get68 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheEA;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheEB == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheEB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_guildChangeNamePanelStateCtrl);
		}
		LuaObject.addMember(l, name68, get68, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheEB, true);
		string name69 = "m_guildChangeNamePanelBackButton";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheEC == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheEC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_guildChangeNamePanelBackButton);
		}
		LuaCSFunction get69 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheEC;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheED == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheED = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_guildChangeNamePanelBackButton);
		}
		LuaObject.addMember(l, name69, get69, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheED, true);
		string name70 = "m_guildChangeNamePanelChangeNameButton";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheEE == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheEE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_guildChangeNamePanelChangeNameButton);
		}
		LuaCSFunction get70 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheEE;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheEF == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheEF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_guildChangeNamePanelChangeNameButton);
		}
		LuaObject.addMember(l, name70, get70, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheEF, true);
		string name71 = "m_guildChangeNamePanelChangeNameButtonStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheF0 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheF0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_guildChangeNamePanelChangeNameButtonStateCtrl);
		}
		LuaCSFunction get71 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheF0;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheF1 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheF1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_guildChangeNamePanelChangeNameButtonStateCtrl);
		}
		LuaObject.addMember(l, name71, get71, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheF1, true);
		string name72 = "m_guildChangeNamePanelInputField";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheF2 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheF2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_guildChangeNamePanelInputField);
		}
		LuaCSFunction get72 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheF2;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheF3 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheF3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_guildChangeNamePanelInputField);
		}
		LuaObject.addMember(l, name72, get72, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheF3, true);
		string name73 = "m_guildChangeNamePanelValueText";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheF4 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheF4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_guildChangeNamePanelValueText);
		}
		LuaCSFunction get73 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheF4;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheF5 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheF5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_guildChangeNamePanelValueText);
		}
		LuaObject.addMember(l, name73, get73, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheF5, true);
		string name74 = "m_messagePanelStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheF6 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheF6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_messagePanelStateCtrl);
		}
		LuaCSFunction get74 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheF6;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheF7 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheF7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_messagePanelStateCtrl);
		}
		LuaObject.addMember(l, name74, get74, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheF7, true);
		string name75 = "m_messagePanelBackButton";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheF8 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheF8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_messagePanelBackButton);
		}
		LuaCSFunction get75 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheF8;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheF9 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheF9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_messagePanelBackButton);
		}
		LuaObject.addMember(l, name75, get75, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheF9, true);
		string name76 = "m_messagePanelApplyToggle";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheFA == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheFA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_messagePanelApplyToggle);
		}
		LuaCSFunction get76 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheFA;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheFB == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheFB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_messagePanelApplyToggle);
		}
		LuaObject.addMember(l, name76, get76, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheFB, true);
		string name77 = "m_messagePanelJournalToggle";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheFC == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheFC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_messagePanelJournalToggle);
		}
		LuaCSFunction get77 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheFC;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheFD == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheFD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_messagePanelJournalToggle);
		}
		LuaObject.addMember(l, name77, get77, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheFD, true);
		string name78 = "m_messageApplyPanelPowerButton";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheFE == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheFE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_messageApplyPanelPowerButton);
		}
		LuaCSFunction get78 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheFE;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheFF == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheFF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_messageApplyPanelPowerButton);
		}
		LuaObject.addMember(l, name78, get78, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cacheFF, true);
		string name79 = "m_messageApplyPanelPowerButtonStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache100 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache100 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_messageApplyPanelPowerButtonStateCtrl);
		}
		LuaCSFunction get79 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache100;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache101 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache101 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_messageApplyPanelPowerButtonStateCtrl);
		}
		LuaObject.addMember(l, name79, get79, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache101, true);
		string name80 = "m_messageApplyPanelMessageListScrollRect";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache102 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache102 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_messageApplyPanelMessageListScrollRect);
		}
		LuaCSFunction get80 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache102;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache103 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache103 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_messageApplyPanelMessageListScrollRect);
		}
		LuaObject.addMember(l, name80, get80, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache103, true);
		string name81 = "m_messageApplyPanelMessageListScrollContent";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache104 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache104 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_messageApplyPanelMessageListScrollContent);
		}
		LuaCSFunction get81 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache104;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache105 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache105 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_messageApplyPanelMessageListScrollContent);
		}
		LuaObject.addMember(l, name81, get81, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache105, true);
		string name82 = "m_messagePlayerItemPrafeb";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache106 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache106 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_messagePlayerItemPrafeb);
		}
		LuaCSFunction get82 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache106;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache107 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache107 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_messagePlayerItemPrafeb);
		}
		LuaObject.addMember(l, name82, get82, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache107, true);
		string name83 = "m_messageApplyPanelAllRefuseButton";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache108 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache108 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_messageApplyPanelAllRefuseButton);
		}
		LuaCSFunction get83 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache108;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache109 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache109 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_messageApplyPanelAllRefuseButton);
		}
		LuaObject.addMember(l, name83, get83, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache109, true);
		string name84 = "m_messageApplyPanelApplyTotalCountValueText";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache10A == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache10A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_messageApplyPanelApplyTotalCountValueText);
		}
		LuaCSFunction get84 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache10A;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache10B == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache10B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_messageApplyPanelApplyTotalCountValueText);
		}
		LuaObject.addMember(l, name84, get84, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache10B, true);
		string name85 = "m_messageApplyPanelTotalPeopleNumberValueText";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache10C == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache10C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_messageApplyPanelTotalPeopleNumberValueText);
		}
		LuaCSFunction get85 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache10C;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache10D == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache10D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_messageApplyPanelTotalPeopleNumberValueText);
		}
		LuaObject.addMember(l, name85, get85, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache10D, true);
		string name86 = "m_messageJournalPanelListScrollRect";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache10E == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache10E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_messageJournalPanelListScrollRect);
		}
		LuaCSFunction get86 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache10E;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache10F == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache10F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_messageJournalPanelListScrollRect);
		}
		LuaObject.addMember(l, name86, get86, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache10F, true);
		string name87 = "m_messageJournalPanelListScrollContent";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache110 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache110 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_messageJournalPanelListScrollContent);
		}
		LuaCSFunction get87 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache110;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache111 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache111 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_messageJournalPanelListScrollContent);
		}
		LuaObject.addMember(l, name87, get87, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache111, true);
		string name88 = "m_messageNoItemGameObject";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache112 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache112 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_messageNoItemGameObject);
		}
		LuaCSFunction get88 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache112;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache113 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache113 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_messageNoItemGameObject);
		}
		LuaObject.addMember(l, name88, get88, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache113, true);
		string name89 = "m_messageJournalItemPrafeb";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache114 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache114 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_messageJournalItemPrafeb);
		}
		LuaCSFunction get89 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache114;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache115 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache115 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_messageJournalItemPrafeb);
		}
		LuaObject.addMember(l, name89, get89, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache115, true);
		string name90 = "m_invitePanelStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache116 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache116 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_invitePanelStateCtrl);
		}
		LuaCSFunction get90 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache116;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache117 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache117 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_invitePanelStateCtrl);
		}
		LuaObject.addMember(l, name90, get90, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache117, true);
		string name91 = "m_invitePanelBackButton";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache118 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache118 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_invitePanelBackButton);
		}
		LuaCSFunction get91 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache118;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache119 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache119 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_invitePanelBackButton);
		}
		LuaObject.addMember(l, name91, get91, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache119, true);
		string name92 = "m_invitePanelCloseButton";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache11A == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache11A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_invitePanelCloseButton);
		}
		LuaCSFunction get92 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache11A;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache11B == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache11B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_invitePanelCloseButton);
		}
		LuaObject.addMember(l, name92, get92, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache11B, true);
		string name93 = "m_invitePanelChangeListButton";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache11C == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache11C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_invitePanelChangeListButton);
		}
		LuaCSFunction get93 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache11C;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache11D == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache11D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_invitePanelChangeListButton);
		}
		LuaObject.addMember(l, name93, get93, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache11D, true);
		string name94 = "m_inviteInfoPanelPeopleNumberText";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache11E == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache11E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_inviteInfoPanelPeopleNumberText);
		}
		LuaCSFunction get94 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache11E;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache11F == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache11F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_inviteInfoPanelPeopleNumberText);
		}
		LuaObject.addMember(l, name94, get94, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache11F, true);
		string name95 = "m_inviteInfoPanelActiveText";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache120 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache120 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_inviteInfoPanelActiveText);
		}
		LuaCSFunction get95 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache120;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache121 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache121 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_inviteInfoPanelActiveText);
		}
		LuaObject.addMember(l, name95, get95, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache121, true);
		string name96 = "m_inviteInfoPanelLevelText";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache122 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache122 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_inviteInfoPanelLevelText);
		}
		LuaCSFunction get96 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache122;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache123 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache123 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_inviteInfoPanelLevelText);
		}
		LuaObject.addMember(l, name96, get96, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache123, true);
		string name97 = "m_inviteInfoPanelDeclarationText";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache124 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache124 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_inviteInfoPanelDeclarationText);
		}
		LuaCSFunction get97 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache124;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache125 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache125 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_inviteInfoPanelDeclarationText);
		}
		LuaObject.addMember(l, name97, get97, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache125, true);
		string name98 = "m_inviteInfoPanelDeclarationChangeButton";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache126 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache126 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_inviteInfoPanelDeclarationChangeButton);
		}
		LuaCSFunction get98 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache126;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache127 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache127 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_inviteInfoPanelDeclarationChangeButton);
		}
		LuaObject.addMember(l, name98, get98, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache127, true);
		string name99 = "m_inviteListPanelSociatyListScrollRect";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache128 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache128 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_inviteListPanelSociatyListScrollRect);
		}
		LuaCSFunction get99 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache128;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache129 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache129 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_inviteListPanelSociatyListScrollRect);
		}
		LuaObject.addMember(l, name99, get99, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache129, true);
		string name100 = "m_inviteListPanelSociatyListScrollContent";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache12A == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache12A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_inviteListPanelSociatyListScrollContent);
		}
		LuaCSFunction get100 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache12A;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache12B == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache12B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_inviteListPanelSociatyListScrollContent);
		}
		LuaObject.addMember(l, name100, get100, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache12B, true);
		string name101 = "m_inviteListPanelPowerButton";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache12C == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache12C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_inviteListPanelPowerButton);
		}
		LuaCSFunction get101 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache12C;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache12D == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache12D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_inviteListPanelPowerButton);
		}
		LuaObject.addMember(l, name101, get101, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache12D, true);
		string name102 = "m_inviteListPanelPowerButtonStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache12E == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache12E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_inviteListPanelPowerButtonStateCtrl);
		}
		LuaCSFunction get102 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache12E;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache12F == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache12F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_inviteListPanelPowerButtonStateCtrl);
		}
		LuaObject.addMember(l, name102, get102, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache12F, true);
		string name103 = "m_invitePlayerInfoItemPrefab";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache130 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache130 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_invitePlayerInfoItemPrefab);
		}
		LuaCSFunction get103 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache130;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache131 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache131 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_invitePlayerInfoItemPrefab);
		}
		LuaObject.addMember(l, name103, get103, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache131, true);
		string name104 = "m_quitDialogStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache132 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache132 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_quitDialogStateCtrl);
		}
		LuaCSFunction get104 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache132;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache133 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache133 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_quitDialogStateCtrl);
		}
		LuaObject.addMember(l, name104, get104, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache133, true);
		string name105 = "m_quitDialogTitleText";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache134 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache134 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_quitDialogTitleText);
		}
		LuaCSFunction get105 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache134;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache135 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache135 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_quitDialogTitleText);
		}
		LuaObject.addMember(l, name105, get105, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache135, true);
		string name106 = "m_quitDialogTipText";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache136 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache136 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_quitDialogTipText);
		}
		LuaCSFunction get106 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache136;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache137 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache137 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_quitDialogTipText);
		}
		LuaObject.addMember(l, name106, get106, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache137, true);
		string name107 = "m_quitDialogConfirmButton";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache138 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache138 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_quitDialogConfirmButton);
		}
		LuaCSFunction get107 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache138;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache139 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache139 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_quitDialogConfirmButton);
		}
		LuaObject.addMember(l, name107, get107, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache139, true);
		string name108 = "m_quitDialogCancelButton";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache13A == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache13A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_quitDialogCancelButton);
		}
		LuaCSFunction get108 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache13A;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache13B == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache13B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_quitDialogCancelButton);
		}
		LuaObject.addMember(l, name108, get108, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache13B, true);
		string name109 = "m_playerContext";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache13C == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache13C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_playerContext);
		}
		LuaCSFunction get109 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache13C;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache13D == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache13D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_playerContext);
		}
		LuaObject.addMember(l, name109, get109, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache13D, true);
		string name110 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache13E == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache13E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_configDataLoader);
		}
		LuaCSFunction get110 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache13E;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache13F == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache13F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name110, get110, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache13F, true);
		string name111 = "StateName_Up";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache140 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache140 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_StateName_Up);
		}
		LuaObject.addMember(l, name111, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache140, null, false);
		string name112 = "StateName_Down";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache141 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache141 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_StateName_Down);
		}
		LuaObject.addMember(l, name112, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache141, null, false);
		string name113 = "StateName_Hide";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache142 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache142 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_StateName_Hide);
		}
		LuaObject.addMember(l, name113, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache142, null, false);
		string name114 = "m_isManageListPowerAscend";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache143 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache143 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_isManageListPowerAscend);
		}
		LuaCSFunction get111 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache143;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache144 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache144 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_isManageListPowerAscend);
		}
		LuaObject.addMember(l, name114, get111, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache144, true);
		string name115 = "m_isManageListActiveAscend";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache145 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache145 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_isManageListActiveAscend);
		}
		LuaCSFunction get112 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache145;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache146 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache146 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_isManageListActiveAscend);
		}
		LuaObject.addMember(l, name115, get112, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache146, true);
		string name116 = "m_isMessageApplyListPowerAscend";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache147 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache147 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_isMessageApplyListPowerAscend);
		}
		LuaCSFunction get113 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache147;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache148 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache148 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_isMessageApplyListPowerAscend);
		}
		LuaObject.addMember(l, name116, get113, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache148, true);
		string name117 = "m_isInviteListPanelPowerAscend";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache149 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache149 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_isInviteListPanelPowerAscend);
		}
		LuaCSFunction get114 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache149;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache14A == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache14A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_isInviteListPanelPowerAscend);
		}
		LuaObject.addMember(l, name117, get114, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache14A, true);
		string name118 = "m_isMessageApplyPanelSortByPower";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache14B == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache14B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_isMessageApplyPanelSortByPower);
		}
		LuaCSFunction get115 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache14B;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache14C == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache14C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_isMessageApplyPanelSortByPower);
		}
		LuaObject.addMember(l, name118, get115, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache14C, true);
		string name119 = "m_playerInfoCtrlList";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache14D == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache14D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_playerInfoCtrlList);
		}
		LuaCSFunction get116 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache14D;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache14E == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache14E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_playerInfoCtrlList);
		}
		LuaObject.addMember(l, name119, get116, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache14E, true);
		string name120 = "m_applyPlayerInfoCtrlList";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache14F == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache14F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_applyPlayerInfoCtrlList);
		}
		LuaCSFunction get117 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache14F;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache150 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache150 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_applyPlayerInfoCtrlList);
		}
		LuaObject.addMember(l, name120, get117, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache150, true);
		string name121 = "m_guildJournalItemCtrlList";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache151 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache151 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_guildJournalItemCtrlList);
		}
		LuaCSFunction get118 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache151;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache152 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache152 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_guildJournalItemCtrlList);
		}
		LuaObject.addMember(l, name121, get118, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache152, true);
		string name122 = "m_inviteMemberInfoCtrlList";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache153 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache153 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_inviteMemberInfoCtrlList);
		}
		LuaCSFunction get119 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache153;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache154 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache154 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_inviteMemberInfoCtrlList);
		}
		LuaObject.addMember(l, name122, get119, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache154, true);
		string name123 = "m_guild";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache155 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache155 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_guild);
		}
		LuaCSFunction get120 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache155;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache156 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache156 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_guild);
		}
		LuaObject.addMember(l, name123, get120, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache156, true);
		string name124 = "m_guildTitle";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache157 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache157 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_guildTitle);
		}
		LuaCSFunction get121 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache157;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache158 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache158 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_guildTitle);
		}
		LuaObject.addMember(l, name124, get121, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache158, true);
		string name125 = "m_canInvitePlayerList";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache159 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache159 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_canInvitePlayerList);
		}
		LuaCSFunction get122 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache159;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache15A == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache15A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_canInvitePlayerList);
		}
		LuaObject.addMember(l, name125, get122, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache15A, true);
		string name126 = "m_isGuildAutoJoin";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache15B == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache15B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_isGuildAutoJoin);
		}
		LuaCSFunction get123 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache15B;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache15C == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache15C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_isGuildAutoJoin);
		}
		LuaObject.addMember(l, name126, get123, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache15C, true);
		string name127 = "m_guildJoinLevel";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache15D == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache15D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_guildJoinLevel);
		}
		LuaCSFunction get124 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache15D;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache15E == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache15E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_guildJoinLevel);
		}
		LuaObject.addMember(l, name127, get124, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache15E, true);
		string name128 = "m_messageApplyUserSummarys";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache15F == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache15F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_messageApplyUserSummarys);
		}
		LuaCSFunction get125 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache15F;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache160 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache160 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_messageApplyUserSummarys);
		}
		LuaObject.addMember(l, name128, get125, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache160, true);
		string name129 = "m_guildListSortType";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache161 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache161 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.get_m_guildListSortType);
		}
		LuaCSFunction get126 = Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache161;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache162 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache162 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.set_m_guildListSortType);
		}
		LuaObject.addMember(l, name129, get126, Lua_BlackJack_ProjectL_UI_GuildManagementUIController.<>f__mg$cache162, true);
		LuaObject.createTypeMetatable(l, null, typeof(GuildManagementUIController), typeof(UIControllerBase));
	}

	// Token: 0x040145FE RID: 83454
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040145FF RID: 83455
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04014600 RID: 83456
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04014601 RID: 83457
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04014602 RID: 83458
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04014603 RID: 83459
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04014604 RID: 83460
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04014605 RID: 83461
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04014606 RID: 83462
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04014607 RID: 83463
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04014608 RID: 83464
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04014609 RID: 83465
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0401460A RID: 83466
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0401460B RID: 83467
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0401460C RID: 83468
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0401460D RID: 83469
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0401460E RID: 83470
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0401460F RID: 83471
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04014610 RID: 83472
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04014611 RID: 83473
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04014612 RID: 83474
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04014613 RID: 83475
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04014614 RID: 83476
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04014615 RID: 83477
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04014616 RID: 83478
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04014617 RID: 83479
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04014618 RID: 83480
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04014619 RID: 83481
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0401461A RID: 83482
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0401461B RID: 83483
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0401461C RID: 83484
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0401461D RID: 83485
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0401461E RID: 83486
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0401461F RID: 83487
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04014620 RID: 83488
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04014621 RID: 83489
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04014622 RID: 83490
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04014623 RID: 83491
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04014624 RID: 83492
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04014625 RID: 83493
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04014626 RID: 83494
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04014627 RID: 83495
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04014628 RID: 83496
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04014629 RID: 83497
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0401462A RID: 83498
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0401462B RID: 83499
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0401462C RID: 83500
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x0401462D RID: 83501
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x0401462E RID: 83502
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x0401462F RID: 83503
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04014630 RID: 83504
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04014631 RID: 83505
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04014632 RID: 83506
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04014633 RID: 83507
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04014634 RID: 83508
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04014635 RID: 83509
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04014636 RID: 83510
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04014637 RID: 83511
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04014638 RID: 83512
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x04014639 RID: 83513
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x0401463A RID: 83514
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x0401463B RID: 83515
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x0401463C RID: 83516
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x0401463D RID: 83517
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x0401463E RID: 83518
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x0401463F RID: 83519
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x04014640 RID: 83520
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x04014641 RID: 83521
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x04014642 RID: 83522
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x04014643 RID: 83523
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x04014644 RID: 83524
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x04014645 RID: 83525
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x04014646 RID: 83526
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x04014647 RID: 83527
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x04014648 RID: 83528
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x04014649 RID: 83529
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x0401464A RID: 83530
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x0401464B RID: 83531
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x0401464C RID: 83532
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x0401464D RID: 83533
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x0401464E RID: 83534
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x0401464F RID: 83535
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x04014650 RID: 83536
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x04014651 RID: 83537
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x04014652 RID: 83538
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x04014653 RID: 83539
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x04014654 RID: 83540
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x04014655 RID: 83541
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x04014656 RID: 83542
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x04014657 RID: 83543
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;

	// Token: 0x04014658 RID: 83544
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5A;

	// Token: 0x04014659 RID: 83545
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5B;

	// Token: 0x0401465A RID: 83546
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5C;

	// Token: 0x0401465B RID: 83547
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5D;

	// Token: 0x0401465C RID: 83548
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5E;

	// Token: 0x0401465D RID: 83549
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5F;

	// Token: 0x0401465E RID: 83550
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache60;

	// Token: 0x0401465F RID: 83551
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache61;

	// Token: 0x04014660 RID: 83552
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache62;

	// Token: 0x04014661 RID: 83553
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache63;

	// Token: 0x04014662 RID: 83554
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache64;

	// Token: 0x04014663 RID: 83555
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache65;

	// Token: 0x04014664 RID: 83556
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache66;

	// Token: 0x04014665 RID: 83557
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache67;

	// Token: 0x04014666 RID: 83558
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache68;

	// Token: 0x04014667 RID: 83559
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache69;

	// Token: 0x04014668 RID: 83560
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6A;

	// Token: 0x04014669 RID: 83561
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6B;

	// Token: 0x0401466A RID: 83562
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6C;

	// Token: 0x0401466B RID: 83563
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6D;

	// Token: 0x0401466C RID: 83564
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6E;

	// Token: 0x0401466D RID: 83565
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6F;

	// Token: 0x0401466E RID: 83566
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache70;

	// Token: 0x0401466F RID: 83567
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache71;

	// Token: 0x04014670 RID: 83568
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache72;

	// Token: 0x04014671 RID: 83569
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache73;

	// Token: 0x04014672 RID: 83570
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache74;

	// Token: 0x04014673 RID: 83571
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache75;

	// Token: 0x04014674 RID: 83572
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache76;

	// Token: 0x04014675 RID: 83573
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache77;

	// Token: 0x04014676 RID: 83574
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache78;

	// Token: 0x04014677 RID: 83575
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache79;

	// Token: 0x04014678 RID: 83576
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7A;

	// Token: 0x04014679 RID: 83577
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7B;

	// Token: 0x0401467A RID: 83578
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7C;

	// Token: 0x0401467B RID: 83579
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7D;

	// Token: 0x0401467C RID: 83580
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7E;

	// Token: 0x0401467D RID: 83581
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7F;

	// Token: 0x0401467E RID: 83582
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache80;

	// Token: 0x0401467F RID: 83583
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache81;

	// Token: 0x04014680 RID: 83584
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache82;

	// Token: 0x04014681 RID: 83585
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache83;

	// Token: 0x04014682 RID: 83586
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache84;

	// Token: 0x04014683 RID: 83587
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache85;

	// Token: 0x04014684 RID: 83588
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache86;

	// Token: 0x04014685 RID: 83589
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache87;

	// Token: 0x04014686 RID: 83590
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache88;

	// Token: 0x04014687 RID: 83591
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache89;

	// Token: 0x04014688 RID: 83592
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8A;

	// Token: 0x04014689 RID: 83593
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8B;

	// Token: 0x0401468A RID: 83594
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8C;

	// Token: 0x0401468B RID: 83595
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8D;

	// Token: 0x0401468C RID: 83596
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8E;

	// Token: 0x0401468D RID: 83597
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8F;

	// Token: 0x0401468E RID: 83598
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache90;

	// Token: 0x0401468F RID: 83599
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache91;

	// Token: 0x04014690 RID: 83600
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache92;

	// Token: 0x04014691 RID: 83601
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache93;

	// Token: 0x04014692 RID: 83602
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache94;

	// Token: 0x04014693 RID: 83603
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache95;

	// Token: 0x04014694 RID: 83604
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache96;

	// Token: 0x04014695 RID: 83605
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache97;

	// Token: 0x04014696 RID: 83606
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache98;

	// Token: 0x04014697 RID: 83607
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache99;

	// Token: 0x04014698 RID: 83608
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9A;

	// Token: 0x04014699 RID: 83609
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9B;

	// Token: 0x0401469A RID: 83610
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9C;

	// Token: 0x0401469B RID: 83611
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9D;

	// Token: 0x0401469C RID: 83612
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9E;

	// Token: 0x0401469D RID: 83613
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9F;

	// Token: 0x0401469E RID: 83614
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA0;

	// Token: 0x0401469F RID: 83615
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA1;

	// Token: 0x040146A0 RID: 83616
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA2;

	// Token: 0x040146A1 RID: 83617
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA3;

	// Token: 0x040146A2 RID: 83618
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA4;

	// Token: 0x040146A3 RID: 83619
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA5;

	// Token: 0x040146A4 RID: 83620
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA6;

	// Token: 0x040146A5 RID: 83621
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA7;

	// Token: 0x040146A6 RID: 83622
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA8;

	// Token: 0x040146A7 RID: 83623
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA9;

	// Token: 0x040146A8 RID: 83624
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAA;

	// Token: 0x040146A9 RID: 83625
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAB;

	// Token: 0x040146AA RID: 83626
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAC;

	// Token: 0x040146AB RID: 83627
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAD;

	// Token: 0x040146AC RID: 83628
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAE;

	// Token: 0x040146AD RID: 83629
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAF;

	// Token: 0x040146AE RID: 83630
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB0;

	// Token: 0x040146AF RID: 83631
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB1;

	// Token: 0x040146B0 RID: 83632
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB2;

	// Token: 0x040146B1 RID: 83633
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB3;

	// Token: 0x040146B2 RID: 83634
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB4;

	// Token: 0x040146B3 RID: 83635
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB5;

	// Token: 0x040146B4 RID: 83636
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB6;

	// Token: 0x040146B5 RID: 83637
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB7;

	// Token: 0x040146B6 RID: 83638
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB8;

	// Token: 0x040146B7 RID: 83639
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB9;

	// Token: 0x040146B8 RID: 83640
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBA;

	// Token: 0x040146B9 RID: 83641
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBB;

	// Token: 0x040146BA RID: 83642
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBC;

	// Token: 0x040146BB RID: 83643
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBD;

	// Token: 0x040146BC RID: 83644
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBE;

	// Token: 0x040146BD RID: 83645
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBF;

	// Token: 0x040146BE RID: 83646
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC0;

	// Token: 0x040146BF RID: 83647
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC1;

	// Token: 0x040146C0 RID: 83648
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC2;

	// Token: 0x040146C1 RID: 83649
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC3;

	// Token: 0x040146C2 RID: 83650
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC4;

	// Token: 0x040146C3 RID: 83651
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC5;

	// Token: 0x040146C4 RID: 83652
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC6;

	// Token: 0x040146C5 RID: 83653
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC7;

	// Token: 0x040146C6 RID: 83654
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC8;

	// Token: 0x040146C7 RID: 83655
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC9;

	// Token: 0x040146C8 RID: 83656
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCA;

	// Token: 0x040146C9 RID: 83657
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCB;

	// Token: 0x040146CA RID: 83658
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCC;

	// Token: 0x040146CB RID: 83659
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCD;

	// Token: 0x040146CC RID: 83660
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCE;

	// Token: 0x040146CD RID: 83661
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCF;

	// Token: 0x040146CE RID: 83662
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD0;

	// Token: 0x040146CF RID: 83663
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD1;

	// Token: 0x040146D0 RID: 83664
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD2;

	// Token: 0x040146D1 RID: 83665
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD3;

	// Token: 0x040146D2 RID: 83666
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD4;

	// Token: 0x040146D3 RID: 83667
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD5;

	// Token: 0x040146D4 RID: 83668
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD6;

	// Token: 0x040146D5 RID: 83669
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD7;

	// Token: 0x040146D6 RID: 83670
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD8;

	// Token: 0x040146D7 RID: 83671
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD9;

	// Token: 0x040146D8 RID: 83672
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDA;

	// Token: 0x040146D9 RID: 83673
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDB;

	// Token: 0x040146DA RID: 83674
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDC;

	// Token: 0x040146DB RID: 83675
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDD;

	// Token: 0x040146DC RID: 83676
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDE;

	// Token: 0x040146DD RID: 83677
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDF;

	// Token: 0x040146DE RID: 83678
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE0;

	// Token: 0x040146DF RID: 83679
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE1;

	// Token: 0x040146E0 RID: 83680
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE2;

	// Token: 0x040146E1 RID: 83681
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE3;

	// Token: 0x040146E2 RID: 83682
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE4;

	// Token: 0x040146E3 RID: 83683
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE5;

	// Token: 0x040146E4 RID: 83684
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE6;

	// Token: 0x040146E5 RID: 83685
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE7;

	// Token: 0x040146E6 RID: 83686
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE8;

	// Token: 0x040146E7 RID: 83687
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE9;

	// Token: 0x040146E8 RID: 83688
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheEA;

	// Token: 0x040146E9 RID: 83689
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheEB;

	// Token: 0x040146EA RID: 83690
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheEC;

	// Token: 0x040146EB RID: 83691
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheED;

	// Token: 0x040146EC RID: 83692
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheEE;

	// Token: 0x040146ED RID: 83693
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheEF;

	// Token: 0x040146EE RID: 83694
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF0;

	// Token: 0x040146EF RID: 83695
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF1;

	// Token: 0x040146F0 RID: 83696
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF2;

	// Token: 0x040146F1 RID: 83697
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF3;

	// Token: 0x040146F2 RID: 83698
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF4;

	// Token: 0x040146F3 RID: 83699
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF5;

	// Token: 0x040146F4 RID: 83700
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF6;

	// Token: 0x040146F5 RID: 83701
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF7;

	// Token: 0x040146F6 RID: 83702
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF8;

	// Token: 0x040146F7 RID: 83703
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF9;

	// Token: 0x040146F8 RID: 83704
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheFA;

	// Token: 0x040146F9 RID: 83705
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheFB;

	// Token: 0x040146FA RID: 83706
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheFC;

	// Token: 0x040146FB RID: 83707
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheFD;

	// Token: 0x040146FC RID: 83708
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheFE;

	// Token: 0x040146FD RID: 83709
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheFF;

	// Token: 0x040146FE RID: 83710
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache100;

	// Token: 0x040146FF RID: 83711
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache101;

	// Token: 0x04014700 RID: 83712
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache102;

	// Token: 0x04014701 RID: 83713
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache103;

	// Token: 0x04014702 RID: 83714
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache104;

	// Token: 0x04014703 RID: 83715
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache105;

	// Token: 0x04014704 RID: 83716
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache106;

	// Token: 0x04014705 RID: 83717
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache107;

	// Token: 0x04014706 RID: 83718
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache108;

	// Token: 0x04014707 RID: 83719
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache109;

	// Token: 0x04014708 RID: 83720
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10A;

	// Token: 0x04014709 RID: 83721
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10B;

	// Token: 0x0401470A RID: 83722
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10C;

	// Token: 0x0401470B RID: 83723
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10D;

	// Token: 0x0401470C RID: 83724
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10E;

	// Token: 0x0401470D RID: 83725
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10F;

	// Token: 0x0401470E RID: 83726
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache110;

	// Token: 0x0401470F RID: 83727
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache111;

	// Token: 0x04014710 RID: 83728
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache112;

	// Token: 0x04014711 RID: 83729
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache113;

	// Token: 0x04014712 RID: 83730
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache114;

	// Token: 0x04014713 RID: 83731
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache115;

	// Token: 0x04014714 RID: 83732
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache116;

	// Token: 0x04014715 RID: 83733
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache117;

	// Token: 0x04014716 RID: 83734
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache118;

	// Token: 0x04014717 RID: 83735
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache119;

	// Token: 0x04014718 RID: 83736
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11A;

	// Token: 0x04014719 RID: 83737
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11B;

	// Token: 0x0401471A RID: 83738
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11C;

	// Token: 0x0401471B RID: 83739
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11D;

	// Token: 0x0401471C RID: 83740
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11E;

	// Token: 0x0401471D RID: 83741
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11F;

	// Token: 0x0401471E RID: 83742
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache120;

	// Token: 0x0401471F RID: 83743
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache121;

	// Token: 0x04014720 RID: 83744
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache122;

	// Token: 0x04014721 RID: 83745
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache123;

	// Token: 0x04014722 RID: 83746
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache124;

	// Token: 0x04014723 RID: 83747
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache125;

	// Token: 0x04014724 RID: 83748
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache126;

	// Token: 0x04014725 RID: 83749
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache127;

	// Token: 0x04014726 RID: 83750
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache128;

	// Token: 0x04014727 RID: 83751
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache129;

	// Token: 0x04014728 RID: 83752
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12A;

	// Token: 0x04014729 RID: 83753
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12B;

	// Token: 0x0401472A RID: 83754
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12C;

	// Token: 0x0401472B RID: 83755
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12D;

	// Token: 0x0401472C RID: 83756
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12E;

	// Token: 0x0401472D RID: 83757
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12F;

	// Token: 0x0401472E RID: 83758
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache130;

	// Token: 0x0401472F RID: 83759
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache131;

	// Token: 0x04014730 RID: 83760
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache132;

	// Token: 0x04014731 RID: 83761
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache133;

	// Token: 0x04014732 RID: 83762
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache134;

	// Token: 0x04014733 RID: 83763
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache135;

	// Token: 0x04014734 RID: 83764
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache136;

	// Token: 0x04014735 RID: 83765
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache137;

	// Token: 0x04014736 RID: 83766
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache138;

	// Token: 0x04014737 RID: 83767
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache139;

	// Token: 0x04014738 RID: 83768
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13A;

	// Token: 0x04014739 RID: 83769
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13B;

	// Token: 0x0401473A RID: 83770
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13C;

	// Token: 0x0401473B RID: 83771
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13D;

	// Token: 0x0401473C RID: 83772
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13E;

	// Token: 0x0401473D RID: 83773
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13F;

	// Token: 0x0401473E RID: 83774
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache140;

	// Token: 0x0401473F RID: 83775
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache141;

	// Token: 0x04014740 RID: 83776
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache142;

	// Token: 0x04014741 RID: 83777
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache143;

	// Token: 0x04014742 RID: 83778
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache144;

	// Token: 0x04014743 RID: 83779
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache145;

	// Token: 0x04014744 RID: 83780
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache146;

	// Token: 0x04014745 RID: 83781
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache147;

	// Token: 0x04014746 RID: 83782
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache148;

	// Token: 0x04014747 RID: 83783
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache149;

	// Token: 0x04014748 RID: 83784
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14A;

	// Token: 0x04014749 RID: 83785
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14B;

	// Token: 0x0401474A RID: 83786
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14C;

	// Token: 0x0401474B RID: 83787
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14D;

	// Token: 0x0401474C RID: 83788
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14E;

	// Token: 0x0401474D RID: 83789
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14F;

	// Token: 0x0401474E RID: 83790
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache150;

	// Token: 0x0401474F RID: 83791
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache151;

	// Token: 0x04014750 RID: 83792
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache152;

	// Token: 0x04014751 RID: 83793
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache153;

	// Token: 0x04014752 RID: 83794
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache154;

	// Token: 0x04014753 RID: 83795
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache155;

	// Token: 0x04014754 RID: 83796
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache156;

	// Token: 0x04014755 RID: 83797
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache157;

	// Token: 0x04014756 RID: 83798
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache158;

	// Token: 0x04014757 RID: 83799
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache159;

	// Token: 0x04014758 RID: 83800
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15A;

	// Token: 0x04014759 RID: 83801
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15B;

	// Token: 0x0401475A RID: 83802
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15C;

	// Token: 0x0401475B RID: 83803
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15D;

	// Token: 0x0401475C RID: 83804
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15E;

	// Token: 0x0401475D RID: 83805
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15F;

	// Token: 0x0401475E RID: 83806
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache160;

	// Token: 0x0401475F RID: 83807
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache161;

	// Token: 0x04014760 RID: 83808
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache162;
}
