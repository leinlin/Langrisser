using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Scene;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x020015A4 RID: 5540
[Preserve]
public class Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController : LuaObject
{
	// Token: 0x0602189D RID: 137373 RVA: 0x00B5B4D0 File Offset: 0x00B596D0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int InitEmojiText(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomPlayerInfoUIController teamRoomPlayerInfoUIController = (TeamRoomPlayerInfoUIController)LuaObject.checkSelf(l);
			int fontSize;
			LuaObject.checkType(l, 2, out fontSize);
			Image image;
			LuaObject.checkType<Image>(l, 3, out image);
			teamRoomPlayerInfoUIController.InitEmojiText(fontSize, image);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602189E RID: 137374 RVA: 0x00B5B534 File Offset: 0x00B59734
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetIndex(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomPlayerInfoUIController teamRoomPlayerInfoUIController = (TeamRoomPlayerInfoUIController)LuaObject.checkSelf(l);
			int index;
			LuaObject.checkType(l, 2, out index);
			teamRoomPlayerInfoUIController.SetIndex(index);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602189F RID: 137375 RVA: 0x00B5B58C File Offset: 0x00B5978C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetIndex(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomPlayerInfoUIController teamRoomPlayerInfoUIController = (TeamRoomPlayerInfoUIController)LuaObject.checkSelf(l);
			int index = teamRoomPlayerInfoUIController.GetIndex();
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

	// Token: 0x060218A0 RID: 137376 RVA: 0x00B5B5E0 File Offset: 0x00B597E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetPlayerIndex(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomPlayerInfoUIController teamRoomPlayerInfoUIController = (TeamRoomPlayerInfoUIController)LuaObject.checkSelf(l);
			int playerIndex;
			LuaObject.checkType(l, 2, out playerIndex);
			teamRoomPlayerInfoUIController.SetPlayerIndex(playerIndex);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060218A1 RID: 137377 RVA: 0x00B5B638 File Offset: 0x00B59838
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetPlayer(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomPlayerInfoUIController teamRoomPlayerInfoUIController = (TeamRoomPlayerInfoUIController)LuaObject.checkSelf(l);
			TeamRoomPlayer player;
			LuaObject.checkType<TeamRoomPlayer>(l, 2, out player);
			teamRoomPlayerInfoUIController.SetPlayer(player);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060218A2 RID: 137378 RVA: 0x00B5B690 File Offset: 0x00B59890
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetPlayer(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomPlayerInfoUIController teamRoomPlayerInfoUIController = (TeamRoomPlayerInfoUIController)LuaObject.checkSelf(l);
			TeamRoomPlayer player = teamRoomPlayerInfoUIController.GetPlayer();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, player);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060218A3 RID: 137379 RVA: 0x00B5B6E4 File Offset: 0x00B598E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetOn(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomPlayerInfoUIController teamRoomPlayerInfoUIController = (TeamRoomPlayerInfoUIController)LuaObject.checkSelf(l);
			bool on;
			LuaObject.checkType(l, 2, out on);
			teamRoomPlayerInfoUIController.SetOn(on);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060218A4 RID: 137380 RVA: 0x00B5B73C File Offset: 0x00B5993C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetEditOn(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomPlayerInfoUIController teamRoomPlayerInfoUIController = (TeamRoomPlayerInfoUIController)LuaObject.checkSelf(l);
			bool editOn;
			LuaObject.checkType(l, 2, out editOn);
			teamRoomPlayerInfoUIController.SetEditOn(editOn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060218A5 RID: 137381 RVA: 0x00B5B794 File Offset: 0x00B59994
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowChat(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomPlayerInfoUIController teamRoomPlayerInfoUIController = (TeamRoomPlayerInfoUIController)LuaObject.checkSelf(l);
			string txt;
			LuaObject.checkType(l, 2, out txt);
			teamRoomPlayerInfoUIController.ShowChat(txt);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060218A6 RID: 137382 RVA: 0x00B5B7EC File Offset: 0x00B599EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowBigExpression(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomPlayerInfoUIController teamRoomPlayerInfoUIController = (TeamRoomPlayerInfoUIController)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			teamRoomPlayerInfoUIController.ShowBigExpression(id);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060218A7 RID: 137383 RVA: 0x00B5B844 File Offset: 0x00B59A44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DestroySpineGraphic(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomPlayerInfoUIController teamRoomPlayerInfoUIController = (TeamRoomPlayerInfoUIController)LuaObject.checkSelf(l);
			teamRoomPlayerInfoUIController.DestroySpineGraphic();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060218A8 RID: 137384 RVA: 0x00B5B890 File Offset: 0x00B59A90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetAnimationTime(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomPlayerInfoUIController teamRoomPlayerInfoUIController = (TeamRoomPlayerInfoUIController)LuaObject.checkSelf(l);
			float animationTime;
			LuaObject.checkType(l, 2, out animationTime);
			teamRoomPlayerInfoUIController.SetAnimationTime(animationTime);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060218A9 RID: 137385 RVA: 0x00B5B8E8 File Offset: 0x00B59AE8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetAnimationTime(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomPlayerInfoUIController teamRoomPlayerInfoUIController = (TeamRoomPlayerInfoUIController)LuaObject.checkSelf(l);
			float animationTime = teamRoomPlayerInfoUIController.GetAnimationTime();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animationTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060218AA RID: 137386 RVA: 0x00B5B93C File Offset: 0x00B59B3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBeginDrag(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomPlayerInfoUIController teamRoomPlayerInfoUIController = (TeamRoomPlayerInfoUIController)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			teamRoomPlayerInfoUIController.OnBeginDrag(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060218AB RID: 137387 RVA: 0x00B5B994 File Offset: 0x00B59B94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnEndDrag(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomPlayerInfoUIController teamRoomPlayerInfoUIController = (TeamRoomPlayerInfoUIController)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			teamRoomPlayerInfoUIController.OnEndDrag(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060218AC RID: 137388 RVA: 0x00B5B9EC File Offset: 0x00B59BEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnDrag(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomPlayerInfoUIController teamRoomPlayerInfoUIController = (TeamRoomPlayerInfoUIController)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			teamRoomPlayerInfoUIController.OnDrag(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060218AD RID: 137389 RVA: 0x00B5BA44 File Offset: 0x00B59C44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnDrop(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomPlayerInfoUIController teamRoomPlayerInfoUIController = (TeamRoomPlayerInfoUIController)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			teamRoomPlayerInfoUIController.OnDrop(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060218AE RID: 137390 RVA: 0x00B5BA9C File Offset: 0x00B59C9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearEvents(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomPlayerInfoUIController teamRoomPlayerInfoUIController = (TeamRoomPlayerInfoUIController)LuaObject.checkSelf(l);
			teamRoomPlayerInfoUIController.ClearEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060218AF RID: 137391 RVA: 0x00B5BAE8 File Offset: 0x00B59CE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomPlayerInfoUIController teamRoomPlayerInfoUIController = (TeamRoomPlayerInfoUIController)LuaObject.checkSelf(l);
			teamRoomPlayerInfoUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060218B0 RID: 137392 RVA: 0x00B5BB3C File Offset: 0x00B59D3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetName(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomPlayerInfoUIController teamRoomPlayerInfoUIController = (TeamRoomPlayerInfoUIController)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			teamRoomPlayerInfoUIController.m_luaExportHelper.SetName(name);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060218B1 RID: 137393 RVA: 0x00B5BB98 File Offset: 0x00B59D98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetLevel(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomPlayerInfoUIController teamRoomPlayerInfoUIController = (TeamRoomPlayerInfoUIController)LuaObject.checkSelf(l);
			int level;
			LuaObject.checkType(l, 2, out level);
			teamRoomPlayerInfoUIController.m_luaExportHelper.SetLevel(level);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060218B2 RID: 137394 RVA: 0x00B5BBF4 File Offset: 0x00B59DF4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetHeadIcon(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomPlayerInfoUIController teamRoomPlayerInfoUIController = (TeamRoomPlayerInfoUIController)LuaObject.checkSelf(l);
			int headIcon;
			LuaObject.checkType(l, 2, out headIcon);
			teamRoomPlayerInfoUIController.m_luaExportHelper.SetHeadIcon(headIcon);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060218B3 RID: 137395 RVA: 0x00B5BC50 File Offset: 0x00B59E50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HideChat(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomPlayerInfoUIController teamRoomPlayerInfoUIController = (TeamRoomPlayerInfoUIController)LuaObject.checkSelf(l);
			teamRoomPlayerInfoUIController.m_luaExportHelper.HideChat();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060218B4 RID: 137396 RVA: 0x00B5BCA4 File Offset: 0x00B59EA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateSpineGraphic(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomPlayerInfoUIController teamRoomPlayerInfoUIController = (TeamRoomPlayerInfoUIController)LuaObject.checkSelf(l);
			ConfigDataJobConnectionInfo jobConnectionInfo;
			LuaObject.checkType<ConfigDataJobConnectionInfo>(l, 2, out jobConnectionInfo);
			ConfigDataModelSkinResourceInfo skinResInfo;
			LuaObject.checkType<ConfigDataModelSkinResourceInfo>(l, 3, out skinResInfo);
			teamRoomPlayerInfoUIController.m_luaExportHelper.CreateSpineGraphic(jobConnectionInfo, skinResInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060218B5 RID: 137397 RVA: 0x00B5BD10 File Offset: 0x00B59F10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnInviteButtonClick(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomPlayerInfoUIController teamRoomPlayerInfoUIController = (TeamRoomPlayerInfoUIController)LuaObject.checkSelf(l);
			teamRoomPlayerInfoUIController.m_luaExportHelper.OnInviteButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060218B6 RID: 137398 RVA: 0x00B5BD64 File Offset: 0x00B59F64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPlayerButtonClick(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomPlayerInfoUIController teamRoomPlayerInfoUIController = (TeamRoomPlayerInfoUIController)LuaObject.checkSelf(l);
			teamRoomPlayerInfoUIController.m_luaExportHelper.OnPlayerButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060218B7 RID: 137399 RVA: 0x00B5BDB8 File Offset: 0x00B59FB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Update(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomPlayerInfoUIController teamRoomPlayerInfoUIController = (TeamRoomPlayerInfoUIController)LuaObject.checkSelf(l);
			teamRoomPlayerInfoUIController.m_luaExportHelper.Update();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060218B8 RID: 137400 RVA: 0x00B5BE0C File Offset: 0x00B5A00C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomPlayerInfoUIController teamRoomPlayerInfoUIController = (TeamRoomPlayerInfoUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			teamRoomPlayerInfoUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060218B9 RID: 137401 RVA: 0x00B5BE78 File Offset: 0x00B5A078
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomPlayerInfoUIController teamRoomPlayerInfoUIController = (TeamRoomPlayerInfoUIController)LuaObject.checkSelf(l);
			teamRoomPlayerInfoUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060218BA RID: 137402 RVA: 0x00B5BECC File Offset: 0x00B5A0CC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomPlayerInfoUIController teamRoomPlayerInfoUIController = (TeamRoomPlayerInfoUIController)LuaObject.checkSelf(l);
			teamRoomPlayerInfoUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060218BB RID: 137403 RVA: 0x00B5BF20 File Offset: 0x00B5A120
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomPlayerInfoUIController teamRoomPlayerInfoUIController = (TeamRoomPlayerInfoUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = teamRoomPlayerInfoUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x060218BC RID: 137404 RVA: 0x00B5BFC8 File Offset: 0x00B5A1C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomPlayerInfoUIController teamRoomPlayerInfoUIController = (TeamRoomPlayerInfoUIController)LuaObject.checkSelf(l);
			teamRoomPlayerInfoUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060218BD RID: 137405 RVA: 0x00B5C01C File Offset: 0x00B5A21C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomPlayerInfoUIController teamRoomPlayerInfoUIController = (TeamRoomPlayerInfoUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			teamRoomPlayerInfoUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060218BE RID: 137406 RVA: 0x00B5C088 File Offset: 0x00B5A288
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
				TeamRoomPlayerInfoUIController teamRoomPlayerInfoUIController = (TeamRoomPlayerInfoUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				teamRoomPlayerInfoUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				TeamRoomPlayerInfoUIController teamRoomPlayerInfoUIController2 = (TeamRoomPlayerInfoUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				teamRoomPlayerInfoUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x060218BF RID: 137407 RVA: 0x00B5C198 File Offset: 0x00B5A398
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomPlayerInfoUIController teamRoomPlayerInfoUIController = (TeamRoomPlayerInfoUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			teamRoomPlayerInfoUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060218C0 RID: 137408 RVA: 0x00B5C204 File Offset: 0x00B5A404
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomPlayerInfoUIController teamRoomPlayerInfoUIController = (TeamRoomPlayerInfoUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			teamRoomPlayerInfoUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060218C1 RID: 137409 RVA: 0x00B5C270 File Offset: 0x00B5A470
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomPlayerInfoUIController teamRoomPlayerInfoUIController = (TeamRoomPlayerInfoUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			teamRoomPlayerInfoUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060218C2 RID: 137410 RVA: 0x00B5C2DC File Offset: 0x00B5A4DC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomPlayerInfoUIController teamRoomPlayerInfoUIController = (TeamRoomPlayerInfoUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			teamRoomPlayerInfoUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060218C3 RID: 137411 RVA: 0x00B5C348 File Offset: 0x00B5A548
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
				TeamRoomPlayerInfoUIController teamRoomPlayerInfoUIController = (TeamRoomPlayerInfoUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				teamRoomPlayerInfoUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				TeamRoomPlayerInfoUIController teamRoomPlayerInfoUIController2 = (TeamRoomPlayerInfoUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				teamRoomPlayerInfoUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x060218C4 RID: 137412 RVA: 0x00B5C458 File Offset: 0x00B5A658
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomPlayerInfoUIController teamRoomPlayerInfoUIController = (TeamRoomPlayerInfoUIController)LuaObject.checkSelf(l);
			string s = teamRoomPlayerInfoUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x060218C5 RID: 137413 RVA: 0x00B5C4B4 File Offset: 0x00B5A6B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnInviteButtonClick(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomPlayerInfoUIController teamRoomPlayerInfoUIController = (TeamRoomPlayerInfoUIController)LuaObject.checkSelf(l);
			TeamRoomPlayerInfoUIController obj;
			LuaObject.checkType<TeamRoomPlayerInfoUIController>(l, 2, out obj);
			teamRoomPlayerInfoUIController.m_luaExportHelper.__callDele_EventOnInviteButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060218C6 RID: 137414 RVA: 0x00B5C510 File Offset: 0x00B5A710
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnInviteButtonClick(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomPlayerInfoUIController teamRoomPlayerInfoUIController = (TeamRoomPlayerInfoUIController)LuaObject.checkSelf(l);
			TeamRoomPlayerInfoUIController obj;
			LuaObject.checkType<TeamRoomPlayerInfoUIController>(l, 2, out obj);
			teamRoomPlayerInfoUIController.m_luaExportHelper.__clearDele_EventOnInviteButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060218C7 RID: 137415 RVA: 0x00B5C56C File Offset: 0x00B5A76C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnPlayerButtonClick(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomPlayerInfoUIController teamRoomPlayerInfoUIController = (TeamRoomPlayerInfoUIController)LuaObject.checkSelf(l);
			TeamRoomPlayerInfoUIController obj;
			LuaObject.checkType<TeamRoomPlayerInfoUIController>(l, 2, out obj);
			teamRoomPlayerInfoUIController.m_luaExportHelper.__callDele_EventOnPlayerButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060218C8 RID: 137416 RVA: 0x00B5C5C8 File Offset: 0x00B5A7C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnPlayerButtonClick(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomPlayerInfoUIController teamRoomPlayerInfoUIController = (TeamRoomPlayerInfoUIController)LuaObject.checkSelf(l);
			TeamRoomPlayerInfoUIController obj;
			LuaObject.checkType<TeamRoomPlayerInfoUIController>(l, 2, out obj);
			teamRoomPlayerInfoUIController.m_luaExportHelper.__clearDele_EventOnPlayerButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060218C9 RID: 137417 RVA: 0x00B5C624 File Offset: 0x00B5A824
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnBeginDrag(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomPlayerInfoUIController teamRoomPlayerInfoUIController = (TeamRoomPlayerInfoUIController)LuaObject.checkSelf(l);
			TeamRoomPlayerInfoUIController arg;
			LuaObject.checkType<TeamRoomPlayerInfoUIController>(l, 2, out arg);
			PointerEventData arg2;
			LuaObject.checkType<PointerEventData>(l, 3, out arg2);
			teamRoomPlayerInfoUIController.m_luaExportHelper.__callDele_EventOnBeginDrag(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060218CA RID: 137418 RVA: 0x00B5C690 File Offset: 0x00B5A890
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnBeginDrag(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomPlayerInfoUIController teamRoomPlayerInfoUIController = (TeamRoomPlayerInfoUIController)LuaObject.checkSelf(l);
			TeamRoomPlayerInfoUIController arg;
			LuaObject.checkType<TeamRoomPlayerInfoUIController>(l, 2, out arg);
			PointerEventData arg2;
			LuaObject.checkType<PointerEventData>(l, 3, out arg2);
			teamRoomPlayerInfoUIController.m_luaExportHelper.__clearDele_EventOnBeginDrag(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060218CB RID: 137419 RVA: 0x00B5C6FC File Offset: 0x00B5A8FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnEndDrag(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomPlayerInfoUIController teamRoomPlayerInfoUIController = (TeamRoomPlayerInfoUIController)LuaObject.checkSelf(l);
			TeamRoomPlayerInfoUIController arg;
			LuaObject.checkType<TeamRoomPlayerInfoUIController>(l, 2, out arg);
			PointerEventData arg2;
			LuaObject.checkType<PointerEventData>(l, 3, out arg2);
			teamRoomPlayerInfoUIController.m_luaExportHelper.__callDele_EventOnEndDrag(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060218CC RID: 137420 RVA: 0x00B5C768 File Offset: 0x00B5A968
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnEndDrag(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomPlayerInfoUIController teamRoomPlayerInfoUIController = (TeamRoomPlayerInfoUIController)LuaObject.checkSelf(l);
			TeamRoomPlayerInfoUIController arg;
			LuaObject.checkType<TeamRoomPlayerInfoUIController>(l, 2, out arg);
			PointerEventData arg2;
			LuaObject.checkType<PointerEventData>(l, 3, out arg2);
			teamRoomPlayerInfoUIController.m_luaExportHelper.__clearDele_EventOnEndDrag(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060218CD RID: 137421 RVA: 0x00B5C7D4 File Offset: 0x00B5A9D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnDrag(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomPlayerInfoUIController teamRoomPlayerInfoUIController = (TeamRoomPlayerInfoUIController)LuaObject.checkSelf(l);
			PointerEventData obj;
			LuaObject.checkType<PointerEventData>(l, 2, out obj);
			teamRoomPlayerInfoUIController.m_luaExportHelper.__callDele_EventOnDrag(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060218CE RID: 137422 RVA: 0x00B5C830 File Offset: 0x00B5AA30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnDrag(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomPlayerInfoUIController teamRoomPlayerInfoUIController = (TeamRoomPlayerInfoUIController)LuaObject.checkSelf(l);
			PointerEventData obj;
			LuaObject.checkType<PointerEventData>(l, 2, out obj);
			teamRoomPlayerInfoUIController.m_luaExportHelper.__clearDele_EventOnDrag(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060218CF RID: 137423 RVA: 0x00B5C88C File Offset: 0x00B5AA8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnDrop(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomPlayerInfoUIController teamRoomPlayerInfoUIController = (TeamRoomPlayerInfoUIController)LuaObject.checkSelf(l);
			PointerEventData obj;
			LuaObject.checkType<PointerEventData>(l, 2, out obj);
			teamRoomPlayerInfoUIController.m_luaExportHelper.__callDele_EventOnDrop(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060218D0 RID: 137424 RVA: 0x00B5C8E8 File Offset: 0x00B5AAE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnDrop(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomPlayerInfoUIController teamRoomPlayerInfoUIController = (TeamRoomPlayerInfoUIController)LuaObject.checkSelf(l);
			PointerEventData obj;
			LuaObject.checkType<PointerEventData>(l, 2, out obj);
			teamRoomPlayerInfoUIController.m_luaExportHelper.__clearDele_EventOnDrop(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060218D1 RID: 137425 RVA: 0x00B5C944 File Offset: 0x00B5AB44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnInviteButtonClick(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomPlayerInfoUIController teamRoomPlayerInfoUIController = (TeamRoomPlayerInfoUIController)LuaObject.checkSelf(l);
			Action<TeamRoomPlayerInfoUIController> value;
			int num = LuaObject.checkDelegate<Action<TeamRoomPlayerInfoUIController>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					teamRoomPlayerInfoUIController.EventOnInviteButtonClick += value;
				}
				else if (num == 2)
				{
					teamRoomPlayerInfoUIController.EventOnInviteButtonClick -= value;
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

	// Token: 0x060218D2 RID: 137426 RVA: 0x00B5C9C4 File Offset: 0x00B5ABC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnPlayerButtonClick(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomPlayerInfoUIController teamRoomPlayerInfoUIController = (TeamRoomPlayerInfoUIController)LuaObject.checkSelf(l);
			Action<TeamRoomPlayerInfoUIController> value;
			int num = LuaObject.checkDelegate<Action<TeamRoomPlayerInfoUIController>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					teamRoomPlayerInfoUIController.EventOnPlayerButtonClick += value;
				}
				else if (num == 2)
				{
					teamRoomPlayerInfoUIController.EventOnPlayerButtonClick -= value;
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

	// Token: 0x060218D3 RID: 137427 RVA: 0x00B5CA44 File Offset: 0x00B5AC44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnBeginDrag(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomPlayerInfoUIController teamRoomPlayerInfoUIController = (TeamRoomPlayerInfoUIController)LuaObject.checkSelf(l);
			Action<TeamRoomPlayerInfoUIController, PointerEventData> value;
			int num = LuaObject.checkDelegate<Action<TeamRoomPlayerInfoUIController, PointerEventData>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					teamRoomPlayerInfoUIController.EventOnBeginDrag += value;
				}
				else if (num == 2)
				{
					teamRoomPlayerInfoUIController.EventOnBeginDrag -= value;
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

	// Token: 0x060218D4 RID: 137428 RVA: 0x00B5CAC4 File Offset: 0x00B5ACC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnEndDrag(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomPlayerInfoUIController teamRoomPlayerInfoUIController = (TeamRoomPlayerInfoUIController)LuaObject.checkSelf(l);
			Action<TeamRoomPlayerInfoUIController, PointerEventData> value;
			int num = LuaObject.checkDelegate<Action<TeamRoomPlayerInfoUIController, PointerEventData>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					teamRoomPlayerInfoUIController.EventOnEndDrag += value;
				}
				else if (num == 2)
				{
					teamRoomPlayerInfoUIController.EventOnEndDrag -= value;
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

	// Token: 0x060218D5 RID: 137429 RVA: 0x00B5CB44 File Offset: 0x00B5AD44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnDrag(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomPlayerInfoUIController teamRoomPlayerInfoUIController = (TeamRoomPlayerInfoUIController)LuaObject.checkSelf(l);
			Action<PointerEventData> value;
			int num = LuaObject.checkDelegate<Action<PointerEventData>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					teamRoomPlayerInfoUIController.EventOnDrag += value;
				}
				else if (num == 2)
				{
					teamRoomPlayerInfoUIController.EventOnDrag -= value;
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

	// Token: 0x060218D6 RID: 137430 RVA: 0x00B5CBC4 File Offset: 0x00B5ADC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnDrop(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomPlayerInfoUIController teamRoomPlayerInfoUIController = (TeamRoomPlayerInfoUIController)LuaObject.checkSelf(l);
			Action<PointerEventData> value;
			int num = LuaObject.checkDelegate<Action<PointerEventData>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					teamRoomPlayerInfoUIController.EventOnDrop += value;
				}
				else if (num == 2)
				{
					teamRoomPlayerInfoUIController.EventOnDrop -= value;
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

	// Token: 0x060218D7 RID: 137431 RVA: 0x00B5CC44 File Offset: 0x00B5AE44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomPlayerInfoUIController teamRoomPlayerInfoUIController = (TeamRoomPlayerInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomPlayerInfoUIController.m_luaExportHelper.m_uiStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060218D8 RID: 137432 RVA: 0x00B5CC9C File Offset: 0x00B5AE9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomPlayerInfoUIController teamRoomPlayerInfoUIController = (TeamRoomPlayerInfoUIController)LuaObject.checkSelf(l);
			CommonUIStateController uiStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out uiStateController);
			teamRoomPlayerInfoUIController.m_luaExportHelper.m_uiStateController = uiStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060218D9 RID: 137433 RVA: 0x00B5CCF8 File Offset: 0x00B5AEF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerButton(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomPlayerInfoUIController teamRoomPlayerInfoUIController = (TeamRoomPlayerInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomPlayerInfoUIController.m_luaExportHelper.m_playerButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060218DA RID: 137434 RVA: 0x00B5CD50 File Offset: 0x00B5AF50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerButton(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomPlayerInfoUIController teamRoomPlayerInfoUIController = (TeamRoomPlayerInfoUIController)LuaObject.checkSelf(l);
			Button playerButton;
			LuaObject.checkType<Button>(l, 2, out playerButton);
			teamRoomPlayerInfoUIController.m_luaExportHelper.m_playerButton = playerButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060218DB RID: 137435 RVA: 0x00B5CDAC File Offset: 0x00B5AFAC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_playerTagImage(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomPlayerInfoUIController teamRoomPlayerInfoUIController = (TeamRoomPlayerInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomPlayerInfoUIController.m_luaExportHelper.m_playerTagImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060218DC RID: 137436 RVA: 0x00B5CE04 File Offset: 0x00B5B004
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_playerTagImage(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomPlayerInfoUIController teamRoomPlayerInfoUIController = (TeamRoomPlayerInfoUIController)LuaObject.checkSelf(l);
			Image playerTagImage;
			LuaObject.checkType<Image>(l, 2, out playerTagImage);
			teamRoomPlayerInfoUIController.m_luaExportHelper.m_playerTagImage = playerTagImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060218DD RID: 137437 RVA: 0x00B5CE60 File Offset: 0x00B5B060
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_nameText(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomPlayerInfoUIController teamRoomPlayerInfoUIController = (TeamRoomPlayerInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomPlayerInfoUIController.m_luaExportHelper.m_nameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060218DE RID: 137438 RVA: 0x00B5CEB8 File Offset: 0x00B5B0B8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_nameText(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomPlayerInfoUIController teamRoomPlayerInfoUIController = (TeamRoomPlayerInfoUIController)LuaObject.checkSelf(l);
			Text nameText;
			LuaObject.checkType<Text>(l, 2, out nameText);
			teamRoomPlayerInfoUIController.m_luaExportHelper.m_nameText = nameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060218DF RID: 137439 RVA: 0x00B5CF14 File Offset: 0x00B5B114
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_levelText(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomPlayerInfoUIController teamRoomPlayerInfoUIController = (TeamRoomPlayerInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomPlayerInfoUIController.m_luaExportHelper.m_levelText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060218E0 RID: 137440 RVA: 0x00B5CF6C File Offset: 0x00B5B16C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_levelText(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomPlayerInfoUIController teamRoomPlayerInfoUIController = (TeamRoomPlayerInfoUIController)LuaObject.checkSelf(l);
			Text levelText;
			LuaObject.checkType<Text>(l, 2, out levelText);
			teamRoomPlayerInfoUIController.m_luaExportHelper.m_levelText = levelText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060218E1 RID: 137441 RVA: 0x00B5CFC8 File Offset: 0x00B5B1C8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_headIconImage(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomPlayerInfoUIController teamRoomPlayerInfoUIController = (TeamRoomPlayerInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomPlayerInfoUIController.m_luaExportHelper.m_headIconImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060218E2 RID: 137442 RVA: 0x00B5D020 File Offset: 0x00B5B220
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_headIconImage(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomPlayerInfoUIController teamRoomPlayerInfoUIController = (TeamRoomPlayerInfoUIController)LuaObject.checkSelf(l);
			Image headIconImage;
			LuaObject.checkType<Image>(l, 2, out headIconImage);
			teamRoomPlayerInfoUIController.m_luaExportHelper.m_headIconImage = headIconImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060218E3 RID: 137443 RVA: 0x00B5D07C File Offset: 0x00B5B27C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_headFrameTransform(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomPlayerInfoUIController teamRoomPlayerInfoUIController = (TeamRoomPlayerInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomPlayerInfoUIController.m_luaExportHelper.m_headFrameTransform);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060218E4 RID: 137444 RVA: 0x00B5D0D4 File Offset: 0x00B5B2D4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_headFrameTransform(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomPlayerInfoUIController teamRoomPlayerInfoUIController = (TeamRoomPlayerInfoUIController)LuaObject.checkSelf(l);
			Transform headFrameTransform;
			LuaObject.checkType<Transform>(l, 2, out headFrameTransform);
			teamRoomPlayerInfoUIController.m_luaExportHelper.m_headFrameTransform = headFrameTransform;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060218E5 RID: 137445 RVA: 0x00B5D130 File Offset: 0x00B5B330
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_graphicGameObject(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomPlayerInfoUIController teamRoomPlayerInfoUIController = (TeamRoomPlayerInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomPlayerInfoUIController.m_luaExportHelper.m_graphicGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060218E6 RID: 137446 RVA: 0x00B5D188 File Offset: 0x00B5B388
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_graphicGameObject(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomPlayerInfoUIController teamRoomPlayerInfoUIController = (TeamRoomPlayerInfoUIController)LuaObject.checkSelf(l);
			GameObject graphicGameObject;
			LuaObject.checkType<GameObject>(l, 2, out graphicGameObject);
			teamRoomPlayerInfoUIController.m_luaExportHelper.m_graphicGameObject = graphicGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060218E7 RID: 137447 RVA: 0x00B5D1E4 File Offset: 0x00B5B3E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_inviteButton(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomPlayerInfoUIController teamRoomPlayerInfoUIController = (TeamRoomPlayerInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomPlayerInfoUIController.m_luaExportHelper.m_inviteButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060218E8 RID: 137448 RVA: 0x00B5D23C File Offset: 0x00B5B43C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_inviteButton(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomPlayerInfoUIController teamRoomPlayerInfoUIController = (TeamRoomPlayerInfoUIController)LuaObject.checkSelf(l);
			Button inviteButton;
			LuaObject.checkType<Button>(l, 2, out inviteButton);
			teamRoomPlayerInfoUIController.m_luaExportHelper.m_inviteButton = inviteButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060218E9 RID: 137449 RVA: 0x00B5D298 File Offset: 0x00B5B498
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_chatUIStateController(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomPlayerInfoUIController teamRoomPlayerInfoUIController = (TeamRoomPlayerInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomPlayerInfoUIController.m_luaExportHelper.m_chatUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060218EA RID: 137450 RVA: 0x00B5D2F0 File Offset: 0x00B5B4F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_chatUIStateController(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomPlayerInfoUIController teamRoomPlayerInfoUIController = (TeamRoomPlayerInfoUIController)LuaObject.checkSelf(l);
			CommonUIStateController chatUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out chatUIStateController);
			teamRoomPlayerInfoUIController.m_luaExportHelper.m_chatUIStateController = chatUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060218EB RID: 137451 RVA: 0x00B5D34C File Offset: 0x00B5B54C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_dialogText(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomPlayerInfoUIController teamRoomPlayerInfoUIController = (TeamRoomPlayerInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomPlayerInfoUIController.m_luaExportHelper.m_dialogText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060218EC RID: 137452 RVA: 0x00B5D3A4 File Offset: 0x00B5B5A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_dialogText(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomPlayerInfoUIController teamRoomPlayerInfoUIController = (TeamRoomPlayerInfoUIController)LuaObject.checkSelf(l);
			EmojiText dialogText;
			LuaObject.checkType<EmojiText>(l, 2, out dialogText);
			teamRoomPlayerInfoUIController.m_luaExportHelper.m_dialogText = dialogText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060218ED RID: 137453 RVA: 0x00B5D400 File Offset: 0x00B5B600
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_dialogBigExpression(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomPlayerInfoUIController teamRoomPlayerInfoUIController = (TeamRoomPlayerInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomPlayerInfoUIController.m_luaExportHelper.m_dialogBigExpression);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060218EE RID: 137454 RVA: 0x00B5D458 File Offset: 0x00B5B658
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_dialogBigExpression(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomPlayerInfoUIController teamRoomPlayerInfoUIController = (TeamRoomPlayerInfoUIController)LuaObject.checkSelf(l);
			Image dialogBigExpression;
			LuaObject.checkType<Image>(l, 2, out dialogBigExpression);
			teamRoomPlayerInfoUIController.m_luaExportHelper.m_dialogBigExpression = dialogBigExpression;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060218EF RID: 137455 RVA: 0x00B5D4B4 File Offset: 0x00B5B6B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_index(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomPlayerInfoUIController teamRoomPlayerInfoUIController = (TeamRoomPlayerInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomPlayerInfoUIController.m_luaExportHelper.m_index);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060218F0 RID: 137456 RVA: 0x00B5D50C File Offset: 0x00B5B70C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_index(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomPlayerInfoUIController teamRoomPlayerInfoUIController = (TeamRoomPlayerInfoUIController)LuaObject.checkSelf(l);
			int index;
			LuaObject.checkType(l, 2, out index);
			teamRoomPlayerInfoUIController.m_luaExportHelper.m_index = index;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060218F1 RID: 137457 RVA: 0x00B5D568 File Offset: 0x00B5B768
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_player(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomPlayerInfoUIController teamRoomPlayerInfoUIController = (TeamRoomPlayerInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomPlayerInfoUIController.m_luaExportHelper.m_player);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060218F2 RID: 137458 RVA: 0x00B5D5C0 File Offset: 0x00B5B7C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_player(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomPlayerInfoUIController teamRoomPlayerInfoUIController = (TeamRoomPlayerInfoUIController)LuaObject.checkSelf(l);
			TeamRoomPlayer player;
			LuaObject.checkType<TeamRoomPlayer>(l, 2, out player);
			teamRoomPlayerInfoUIController.m_luaExportHelper.m_player = player;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060218F3 RID: 137459 RVA: 0x00B5D61C File Offset: 0x00B5B81C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_spineGraphic(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomPlayerInfoUIController teamRoomPlayerInfoUIController = (TeamRoomPlayerInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomPlayerInfoUIController.m_luaExportHelper.m_spineGraphic);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060218F4 RID: 137460 RVA: 0x00B5D674 File Offset: 0x00B5B874
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_spineGraphic(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomPlayerInfoUIController teamRoomPlayerInfoUIController = (TeamRoomPlayerInfoUIController)LuaObject.checkSelf(l);
			UISpineGraphic spineGraphic;
			LuaObject.checkType<UISpineGraphic>(l, 2, out spineGraphic);
			teamRoomPlayerInfoUIController.m_luaExportHelper.m_spineGraphic = spineGraphic;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060218F5 RID: 137461 RVA: 0x00B5D6D0 File Offset: 0x00B5B8D0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_hideChatTime(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomPlayerInfoUIController teamRoomPlayerInfoUIController = (TeamRoomPlayerInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomPlayerInfoUIController.m_luaExportHelper.m_hideChatTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060218F6 RID: 137462 RVA: 0x00B5D728 File Offset: 0x00B5B928
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_hideChatTime(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomPlayerInfoUIController teamRoomPlayerInfoUIController = (TeamRoomPlayerInfoUIController)LuaObject.checkSelf(l);
			float hideChatTime;
			LuaObject.checkType(l, 2, out hideChatTime);
			teamRoomPlayerInfoUIController.m_luaExportHelper.m_hideChatTime = hideChatTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060218F7 RID: 137463 RVA: 0x00B5D784 File Offset: 0x00B5B984
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.TeamRoomPlayerInfoUIController");
		if (Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.InitEmojiText);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.SetIndex);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.GetIndex);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.SetPlayerIndex);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.SetPlayer);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.GetPlayer);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.SetOn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.SetEditOn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.ShowChat);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.ShowBigExpression);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.DestroySpineGraphic);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.SetAnimationTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.GetAnimationTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.OnBeginDrag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.OnEndDrag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.OnDrag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.OnDrop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.ClearEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.SetName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.SetLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.SetHeadIcon);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.HideChat);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.CreateSpineGraphic);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.OnInviteButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.OnPlayerButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.Update);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.__callDele_EventOnInviteButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.__clearDele_EventOnInviteButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache29);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.__callDele_EventOnPlayerButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache2A);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.__clearDele_EventOnPlayerButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache2B);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.__callDele_EventOnBeginDrag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache2C);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.__clearDele_EventOnBeginDrag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache2D);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.__callDele_EventOnEndDrag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache2E);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.__clearDele_EventOnEndDrag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache2F);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.__callDele_EventOnDrag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache30);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.__clearDele_EventOnDrag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache31);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.__callDele_EventOnDrop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache32);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.__clearDele_EventOnDrop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache33);
		string name = "EventOnInviteButtonClick";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.set_EventOnInviteButtonClick);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache34, true);
		string name2 = "EventOnPlayerButtonClick";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.set_EventOnPlayerButtonClick);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache35, true);
		string name3 = "EventOnBeginDrag";
		LuaCSFunction get3 = null;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.set_EventOnBeginDrag);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache36, true);
		string name4 = "EventOnEndDrag";
		LuaCSFunction get4 = null;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.set_EventOnEndDrag);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache37, true);
		string name5 = "EventOnDrag";
		LuaCSFunction get5 = null;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.set_EventOnDrag);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache38, true);
		string name6 = "EventOnDrop";
		LuaCSFunction get6 = null;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.set_EventOnDrop);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache39, true);
		string name7 = "m_uiStateController";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.get_m_uiStateController);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache3A;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.set_m_uiStateController);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache3B, true);
		string name8 = "m_playerButton";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.get_m_playerButton);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache3C;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.set_m_playerButton);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache3D, true);
		string name9 = "m_playerTagImage";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.get_m_playerTagImage);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache3E;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.set_m_playerTagImage);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache3F, true);
		string name10 = "m_nameText";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.get_m_nameText);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache40;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.set_m_nameText);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache41, true);
		string name11 = "m_levelText";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.get_m_levelText);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache42;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.set_m_levelText);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache43, true);
		string name12 = "m_headIconImage";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.get_m_headIconImage);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache44;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.set_m_headIconImage);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache45, true);
		string name13 = "m_headFrameTransform";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.get_m_headFrameTransform);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache46;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.set_m_headFrameTransform);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache47, true);
		string name14 = "m_graphicGameObject";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.get_m_graphicGameObject);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache48;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.set_m_graphicGameObject);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache49, true);
		string name15 = "m_inviteButton";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.get_m_inviteButton);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache4A;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.set_m_inviteButton);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache4B, true);
		string name16 = "m_chatUIStateController";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.get_m_chatUIStateController);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache4C;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.set_m_chatUIStateController);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache4D, true);
		string name17 = "m_dialogText";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.get_m_dialogText);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache4E;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.set_m_dialogText);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache4F, true);
		string name18 = "m_dialogBigExpression";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.get_m_dialogBigExpression);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache50;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.set_m_dialogBigExpression);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache51, true);
		string name19 = "m_index";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.get_m_index);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache52;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.set_m_index);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache53, true);
		string name20 = "m_player";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.get_m_player);
		}
		LuaCSFunction get20 = Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache54;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache55 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache55 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.set_m_player);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache55, true);
		string name21 = "m_spineGraphic";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache56 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache56 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.get_m_spineGraphic);
		}
		LuaCSFunction get21 = Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache56;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache57 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache57 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.set_m_spineGraphic);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache57, true);
		string name22 = "m_hideChatTime";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache58 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache58 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.get_m_hideChatTime);
		}
		LuaCSFunction get22 = Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache58;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache59 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache59 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.set_m_hideChatTime);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.<>f__mg$cache59, true);
		LuaObject.createTypeMetatable(l, null, typeof(TeamRoomPlayerInfoUIController), typeof(UIControllerBase));
	}

	// Token: 0x04017737 RID: 96055
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04017738 RID: 96056
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04017739 RID: 96057
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401773A RID: 96058
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401773B RID: 96059
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0401773C RID: 96060
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0401773D RID: 96061
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0401773E RID: 96062
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0401773F RID: 96063
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04017740 RID: 96064
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04017741 RID: 96065
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04017742 RID: 96066
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04017743 RID: 96067
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04017744 RID: 96068
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04017745 RID: 96069
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04017746 RID: 96070
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04017747 RID: 96071
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04017748 RID: 96072
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04017749 RID: 96073
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0401774A RID: 96074
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0401774B RID: 96075
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0401774C RID: 96076
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0401774D RID: 96077
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0401774E RID: 96078
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0401774F RID: 96079
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04017750 RID: 96080
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04017751 RID: 96081
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04017752 RID: 96082
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04017753 RID: 96083
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04017754 RID: 96084
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04017755 RID: 96085
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04017756 RID: 96086
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04017757 RID: 96087
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04017758 RID: 96088
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04017759 RID: 96089
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0401775A RID: 96090
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0401775B RID: 96091
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0401775C RID: 96092
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0401775D RID: 96093
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0401775E RID: 96094
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0401775F RID: 96095
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04017760 RID: 96096
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04017761 RID: 96097
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04017762 RID: 96098
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04017763 RID: 96099
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04017764 RID: 96100
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04017765 RID: 96101
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04017766 RID: 96102
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04017767 RID: 96103
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04017768 RID: 96104
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04017769 RID: 96105
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x0401776A RID: 96106
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x0401776B RID: 96107
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x0401776C RID: 96108
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x0401776D RID: 96109
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x0401776E RID: 96110
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x0401776F RID: 96111
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04017770 RID: 96112
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04017771 RID: 96113
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x04017772 RID: 96114
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x04017773 RID: 96115
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x04017774 RID: 96116
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x04017775 RID: 96117
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x04017776 RID: 96118
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x04017777 RID: 96119
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x04017778 RID: 96120
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x04017779 RID: 96121
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x0401777A RID: 96122
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x0401777B RID: 96123
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x0401777C RID: 96124
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x0401777D RID: 96125
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x0401777E RID: 96126
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x0401777F RID: 96127
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x04017780 RID: 96128
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x04017781 RID: 96129
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x04017782 RID: 96130
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x04017783 RID: 96131
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x04017784 RID: 96132
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x04017785 RID: 96133
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x04017786 RID: 96134
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x04017787 RID: 96135
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x04017788 RID: 96136
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x04017789 RID: 96137
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x0401778A RID: 96138
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x0401778B RID: 96139
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x0401778C RID: 96140
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x0401778D RID: 96141
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x0401778E RID: 96142
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x0401778F RID: 96143
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x04017790 RID: 96144
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;
}
