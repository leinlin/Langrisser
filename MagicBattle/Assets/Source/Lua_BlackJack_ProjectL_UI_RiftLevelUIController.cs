using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001567 RID: 5479
[Preserve]
public class Lua_BlackJack_ProjectL_UI_RiftLevelUIController : LuaObject
{
	// Token: 0x06020CB8 RID: 134328 RVA: 0x00AFC024 File Offset: 0x00AFA224
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Open(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			riftLevelUIController.Open();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020CB9 RID: 134329 RVA: 0x00AFC070 File Offset: 0x00AFA270
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetChapter(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			ConfigDataRiftChapterInfo chapterInfo;
			LuaObject.checkType<ConfigDataRiftChapterInfo>(l, 2, out chapterInfo);
			bool canSwitchHard;
			LuaObject.checkType(l, 3, out canSwitchHard);
			riftLevelUIController.SetChapter(chapterInfo, canSwitchHard);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020CBA RID: 134330 RVA: 0x00AFC0D4 File Offset: 0x00AFA2D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetStarRewardStatus(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			int idx;
			LuaObject.checkType(l, 2, out idx);
			GainRewardStatus status;
			LuaObject.checkEnum<GainRewardStatus>(l, 3, out status);
			riftLevelUIController.SetStarRewardStatus(idx, status);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020CBB RID: 134331 RVA: 0x00AFC138 File Offset: 0x00AFA338
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetStarRewardProress(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			int star;
			LuaObject.checkType(l, 2, out star);
			int allStar;
			LuaObject.checkType(l, 3, out allStar);
			riftLevelUIController.SetStarRewardProress(star, allStar);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020CBC RID: 134332 RVA: 0x00AFC19C File Offset: 0x00AFA39C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearRiftLevelButtons(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			riftLevelUIController.ClearRiftLevelButtons();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020CBD RID: 134333 RVA: 0x00AFC1E8 File Offset: 0x00AFA3E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearEventRiftLevelButtons(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			riftLevelUIController.ClearEventRiftLevelButtons();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020CBE RID: 134334 RVA: 0x00AFC234 File Offset: 0x00AFA434
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddRiftLevelButton(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			ConfigDataRiftLevelInfo riftLevelInfo;
			LuaObject.checkType<ConfigDataRiftLevelInfo>(l, 2, out riftLevelInfo);
			RiftLevelStatus status;
			LuaObject.checkEnum<RiftLevelStatus>(l, 3, out status);
			int challengeCount;
			LuaObject.checkType(l, 4, out challengeCount);
			int challengeCountMax;
			LuaObject.checkType(l, 5, out challengeCountMax);
			bool challenged;
			LuaObject.checkType(l, 6, out challenged);
			int star;
			LuaObject.checkType(l, 7, out star);
			int achievementCount;
			LuaObject.checkType(l, 8, out achievementCount);
			int treasureCount;
			LuaObject.checkType(l, 9, out treasureCount);
			int treasureCountMax;
			LuaObject.checkType(l, 10, out treasureCountMax);
			riftLevelUIController.AddRiftLevelButton(riftLevelInfo, status, challengeCount, challengeCountMax, challenged, star, achievementCount, treasureCount, treasureCountMax);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020CBF RID: 134335 RVA: 0x00AFC2F0 File Offset: 0x00AFA4F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddEventRiftLevelButton(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			ConfigDataRiftLevelInfo riftLevelInfo;
			LuaObject.checkType<ConfigDataRiftLevelInfo>(l, 2, out riftLevelInfo);
			RiftLevelStatus status;
			LuaObject.checkEnum<RiftLevelStatus>(l, 3, out status);
			riftLevelUIController.AddEventRiftLevelButton(riftLevelInfo, status);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020CC0 RID: 134336 RVA: 0x00AFC354 File Offset: 0x00AFA554
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddEventRiftLevelDummys(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			riftLevelUIController.AddEventRiftLevelDummys();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020CC1 RID: 134337 RVA: 0x00AFC3A0 File Offset: 0x00AFA5A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnRiftLevelButtonClick(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			RiftLevelButton b;
			LuaObject.checkType<RiftLevelButton>(l, 2, out b);
			riftLevelUIController.OnRiftLevelButtonClick(b);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020CC2 RID: 134338 RVA: 0x00AFC3F8 File Offset: 0x00AFA5F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetUnlockConditionClose(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			riftLevelUIController.SetUnlockConditionClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020CC3 RID: 134339 RVA: 0x00AFC444 File Offset: 0x00AFA644
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			riftLevelUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020CC4 RID: 134340 RVA: 0x00AFC498 File Offset: 0x00AFA698
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearRiftLevelUnlockContitionItems(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			riftLevelUIController.m_luaExportHelper.ClearRiftLevelUnlockContitionItems();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020CC5 RID: 134341 RVA: 0x00AFC4EC File Offset: 0x00AFA6EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddRiftLevelUnlockContitionItems(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			ConfigDataRiftLevelInfo riftLevelInfo;
			LuaObject.checkType<ConfigDataRiftLevelInfo>(l, 2, out riftLevelInfo);
			riftLevelUIController.m_luaExportHelper.AddRiftLevelUnlockContitionItems(riftLevelInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020CC6 RID: 134342 RVA: 0x00AFC548 File Offset: 0x00AFA748
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GoToRiftLevel(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			int chapterID;
			LuaObject.checkType(l, 2, out chapterID);
			int levelID;
			LuaObject.checkType(l, 3, out levelID);
			riftLevelUIController.m_luaExportHelper.GoToRiftLevel(chapterID, levelID);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020CC7 RID: 134343 RVA: 0x00AFC5B4 File Offset: 0x00AFA7B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Co_ShowRiftLevel(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			ConfigDataRiftChapterInfo riftChapterInfo;
			LuaObject.checkType<ConfigDataRiftChapterInfo>(l, 2, out riftChapterInfo);
			ConfigDataRiftLevelInfo riftLevelInfo;
			LuaObject.checkType<ConfigDataRiftLevelInfo>(l, 3, out riftLevelInfo);
			IEnumerator o = riftLevelUIController.m_luaExportHelper.Co_ShowRiftLevel(riftChapterInfo, riftLevelInfo);
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

	// Token: 0x06020CC8 RID: 134344 RVA: 0x00AFC628 File Offset: 0x00AFA828
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddStarRewardPreviewGoods(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			ConfigDataRiftChapterInfo chapterInfo;
			LuaObject.checkType<ConfigDataRiftChapterInfo>(l, 2, out chapterInfo);
			int idx;
			LuaObject.checkType(l, 3, out idx);
			riftLevelUIController.m_luaExportHelper.AddStarRewardPreviewGoods(chapterInfo, idx);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020CC9 RID: 134345 RVA: 0x00AFC694 File Offset: 0x00AFA894
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnReturnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			riftLevelUIController.m_luaExportHelper.OnReturnButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020CCA RID: 134346 RVA: 0x00AFC6E8 File Offset: 0x00AFA8E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnHelpButtonClick(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			riftLevelUIController.m_luaExportHelper.OnHelpButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020CCB RID: 134347 RVA: 0x00AFC73C File Offset: 0x00AFA93C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnWorldButtonClick(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			riftLevelUIController.m_luaExportHelper.OnWorldButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020CCC RID: 134348 RVA: 0x00AFC790 File Offset: 0x00AFA990
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnHardButtonClick(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			riftLevelUIController.m_luaExportHelper.OnHardButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020CCD RID: 134349 RVA: 0x00AFC7E4 File Offset: 0x00AFA9E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStarRewardButtonClick(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			GainRewardButton b;
			LuaObject.checkType<GainRewardButton>(l, 2, out b);
			riftLevelUIController.m_luaExportHelper.OnStarRewardButtonClick(b);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020CCE RID: 134350 RVA: 0x00AFC840 File Offset: 0x00AFAA40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnEventRiftLevelButtonClick(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			EventRiftLevelButton b;
			LuaObject.checkType<EventRiftLevelButton>(l, 2, out b);
			riftLevelUIController.m_luaExportHelper.OnEventRiftLevelButtonClick(b);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020CCF RID: 134351 RVA: 0x00AFC89C File Offset: 0x00AFAA9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnUnlockConditionBackgroundButtonClick(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			riftLevelUIController.m_luaExportHelper.OnUnlockConditionBackgroundButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020CD0 RID: 134352 RVA: 0x00AFC8F0 File Offset: 0x00AFAAF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStarRewardPreviewBackgroundButtonClick(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			riftLevelUIController.m_luaExportHelper.OnStarRewardPreviewBackgroundButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020CD1 RID: 134353 RVA: 0x00AFC944 File Offset: 0x00AFAB44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			riftLevelUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020CD2 RID: 134354 RVA: 0x00AFC9B0 File Offset: 0x00AFABB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			riftLevelUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020CD3 RID: 134355 RVA: 0x00AFCA04 File Offset: 0x00AFAC04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			riftLevelUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020CD4 RID: 134356 RVA: 0x00AFCA58 File Offset: 0x00AFAC58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = riftLevelUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x06020CD5 RID: 134357 RVA: 0x00AFCB00 File Offset: 0x00AFAD00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			riftLevelUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020CD6 RID: 134358 RVA: 0x00AFCB54 File Offset: 0x00AFAD54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			riftLevelUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020CD7 RID: 134359 RVA: 0x00AFCBC0 File Offset: 0x00AFADC0
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
				RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				riftLevelUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				RiftLevelUIController riftLevelUIController2 = (RiftLevelUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				riftLevelUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x06020CD8 RID: 134360 RVA: 0x00AFCCD0 File Offset: 0x00AFAED0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			riftLevelUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020CD9 RID: 134361 RVA: 0x00AFCD3C File Offset: 0x00AFAF3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			riftLevelUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020CDA RID: 134362 RVA: 0x00AFCDA8 File Offset: 0x00AFAFA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			riftLevelUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020CDB RID: 134363 RVA: 0x00AFCE14 File Offset: 0x00AFB014
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			riftLevelUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020CDC RID: 134364 RVA: 0x00AFCE80 File Offset: 0x00AFB080
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
				RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				riftLevelUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				RiftLevelUIController riftLevelUIController2 = (RiftLevelUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				riftLevelUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x06020CDD RID: 134365 RVA: 0x00AFCF90 File Offset: 0x00AFB190
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			string s = riftLevelUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x06020CDE RID: 134366 RVA: 0x00AFCFEC File Offset: 0x00AFB1EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			riftLevelUIController.m_luaExportHelper.__callDele_EventOnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020CDF RID: 134367 RVA: 0x00AFD040 File Offset: 0x00AFB240
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			riftLevelUIController.m_luaExportHelper.__clearDele_EventOnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020CE0 RID: 134368 RVA: 0x00AFD094 File Offset: 0x00AFB294
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnShowHelp(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			riftLevelUIController.m_luaExportHelper.__callDele_EventOnShowHelp();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020CE1 RID: 134369 RVA: 0x00AFD0E8 File Offset: 0x00AFB2E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnShowHelp(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			riftLevelUIController.m_luaExportHelper.__clearDele_EventOnShowHelp();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020CE2 RID: 134370 RVA: 0x00AFD13C File Offset: 0x00AFB33C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnReturnToWorld(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			riftLevelUIController.m_luaExportHelper.__callDele_EventOnReturnToWorld();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020CE3 RID: 134371 RVA: 0x00AFD190 File Offset: 0x00AFB390
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnReturnToWorld(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			riftLevelUIController.m_luaExportHelper.__clearDele_EventOnReturnToWorld();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020CE4 RID: 134372 RVA: 0x00AFD1E4 File Offset: 0x00AFB3E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnChangeHard(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			riftLevelUIController.m_luaExportHelper.__callDele_EventOnChangeHard();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020CE5 RID: 134373 RVA: 0x00AFD238 File Offset: 0x00AFB438
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnChangeHard(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			riftLevelUIController.m_luaExportHelper.__clearDele_EventOnChangeHard();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020CE6 RID: 134374 RVA: 0x00AFD28C File Offset: 0x00AFB48C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnSelectRiftLevel(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			ConfigDataRiftLevelInfo arg;
			LuaObject.checkType<ConfigDataRiftLevelInfo>(l, 2, out arg);
			NeedGoods arg2;
			LuaObject.checkType<NeedGoods>(l, 3, out arg2);
			riftLevelUIController.m_luaExportHelper.__callDele_EventOnSelectRiftLevel(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020CE7 RID: 134375 RVA: 0x00AFD2F8 File Offset: 0x00AFB4F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnSelectRiftLevel(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			ConfigDataRiftLevelInfo arg;
			LuaObject.checkType<ConfigDataRiftLevelInfo>(l, 2, out arg);
			NeedGoods arg2;
			LuaObject.checkType<NeedGoods>(l, 3, out arg2);
			riftLevelUIController.m_luaExportHelper.__clearDele_EventOnSelectRiftLevel(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020CE8 RID: 134376 RVA: 0x00AFD364 File Offset: 0x00AFB564
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnGetStarReward(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			riftLevelUIController.m_luaExportHelper.__callDele_EventOnGetStarReward(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020CE9 RID: 134377 RVA: 0x00AFD3C0 File Offset: 0x00AFB5C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnGetStarReward(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			riftLevelUIController.m_luaExportHelper.__clearDele_EventOnGetStarReward(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020CEA RID: 134378 RVA: 0x00AFD41C File Offset: 0x00AFB61C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnGoToScenario(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			riftLevelUIController.m_luaExportHelper.__callDele_EventOnGoToScenario(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020CEB RID: 134379 RVA: 0x00AFD478 File Offset: 0x00AFB678
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnGoToScenario(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			riftLevelUIController.m_luaExportHelper.__clearDele_EventOnGoToScenario(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020CEC RID: 134380 RVA: 0x00AFD4D4 File Offset: 0x00AFB6D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnSelectChapter(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			ConfigDataRiftChapterInfo obj;
			LuaObject.checkType<ConfigDataRiftChapterInfo>(l, 2, out obj);
			riftLevelUIController.m_luaExportHelper.__callDele_EventOnSelectChapter(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020CED RID: 134381 RVA: 0x00AFD530 File Offset: 0x00AFB730
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnSelectChapter(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			ConfigDataRiftChapterInfo obj;
			LuaObject.checkType<ConfigDataRiftChapterInfo>(l, 2, out obj);
			riftLevelUIController.m_luaExportHelper.__clearDele_EventOnSelectChapter(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020CEE RID: 134382 RVA: 0x00AFD58C File Offset: 0x00AFB78C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					riftLevelUIController.EventOnReturn += value;
				}
				else if (num == 2)
				{
					riftLevelUIController.EventOnReturn -= value;
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

	// Token: 0x06020CEF RID: 134383 RVA: 0x00AFD60C File Offset: 0x00AFB80C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnShowHelp(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					riftLevelUIController.EventOnShowHelp += value;
				}
				else if (num == 2)
				{
					riftLevelUIController.EventOnShowHelp -= value;
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

	// Token: 0x06020CF0 RID: 134384 RVA: 0x00AFD68C File Offset: 0x00AFB88C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnReturnToWorld(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					riftLevelUIController.EventOnReturnToWorld += value;
				}
				else if (num == 2)
				{
					riftLevelUIController.EventOnReturnToWorld -= value;
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

	// Token: 0x06020CF1 RID: 134385 RVA: 0x00AFD70C File Offset: 0x00AFB90C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnChangeHard(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					riftLevelUIController.EventOnChangeHard += value;
				}
				else if (num == 2)
				{
					riftLevelUIController.EventOnChangeHard -= value;
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

	// Token: 0x06020CF2 RID: 134386 RVA: 0x00AFD78C File Offset: 0x00AFB98C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnSelectRiftLevel(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			Action<ConfigDataRiftLevelInfo, NeedGoods> value;
			int num = LuaObject.checkDelegate<Action<ConfigDataRiftLevelInfo, NeedGoods>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					riftLevelUIController.EventOnSelectRiftLevel += value;
				}
				else if (num == 2)
				{
					riftLevelUIController.EventOnSelectRiftLevel -= value;
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

	// Token: 0x06020CF3 RID: 134387 RVA: 0x00AFD80C File Offset: 0x00AFBA0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnGetStarReward(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			Action<int> value;
			int num = LuaObject.checkDelegate<Action<int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					riftLevelUIController.EventOnGetStarReward += value;
				}
				else if (num == 2)
				{
					riftLevelUIController.EventOnGetStarReward -= value;
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

	// Token: 0x06020CF4 RID: 134388 RVA: 0x00AFD88C File Offset: 0x00AFBA8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnGoToScenario(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			Action<int> value;
			int num = LuaObject.checkDelegate<Action<int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					riftLevelUIController.EventOnGoToScenario += value;
				}
				else if (num == 2)
				{
					riftLevelUIController.EventOnGoToScenario -= value;
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

	// Token: 0x06020CF5 RID: 134389 RVA: 0x00AFD90C File Offset: 0x00AFBB0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnSelectChapter(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			Action<ConfigDataRiftChapterInfo> value;
			int num = LuaObject.checkDelegate<Action<ConfigDataRiftChapterInfo>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					riftLevelUIController.EventOnSelectChapter += value;
				}
				else if (num == 2)
				{
					riftLevelUIController.EventOnSelectChapter -= value;
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

	// Token: 0x06020CF6 RID: 134390 RVA: 0x00AFD98C File Offset: 0x00AFBB8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftLevelUIController.m_luaExportHelper.m_uiStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020CF7 RID: 134391 RVA: 0x00AFD9E4 File Offset: 0x00AFBBE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			CommonUIStateController uiStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out uiStateController);
			riftLevelUIController.m_luaExportHelper.m_uiStateController = uiStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020CF8 RID: 134392 RVA: 0x00AFDA40 File Offset: 0x00AFBC40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_marginTransform(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftLevelUIController.m_luaExportHelper.m_marginTransform);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020CF9 RID: 134393 RVA: 0x00AFDA98 File Offset: 0x00AFBC98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_marginTransform(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			RectTransform marginTransform;
			LuaObject.checkType<RectTransform>(l, 2, out marginTransform);
			riftLevelUIController.m_luaExportHelper.m_marginTransform = marginTransform;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020CFA RID: 134394 RVA: 0x00AFDAF4 File Offset: 0x00AFBCF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_chapterBGObject(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftLevelUIController.m_luaExportHelper.m_chapterBGObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020CFB RID: 134395 RVA: 0x00AFDB4C File Offset: 0x00AFBD4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_chapterBGObject(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			GameObject chapterBGObject;
			LuaObject.checkType<GameObject>(l, 2, out chapterBGObject);
			riftLevelUIController.m_luaExportHelper.m_chapterBGObject = chapterBGObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020CFC RID: 134396 RVA: 0x00AFDBA8 File Offset: 0x00AFBDA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_returnButton(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftLevelUIController.m_luaExportHelper.m_returnButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020CFD RID: 134397 RVA: 0x00AFDC00 File Offset: 0x00AFBE00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_returnButton(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			Button returnButton;
			LuaObject.checkType<Button>(l, 2, out returnButton);
			riftLevelUIController.m_luaExportHelper.m_returnButton = returnButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020CFE RID: 134398 RVA: 0x00AFDC5C File Offset: 0x00AFBE5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_helpButton(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftLevelUIController.m_luaExportHelper.m_helpButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020CFF RID: 134399 RVA: 0x00AFDCB4 File Offset: 0x00AFBEB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_helpButton(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			Button helpButton;
			LuaObject.checkType<Button>(l, 2, out helpButton);
			riftLevelUIController.m_luaExportHelper.m_helpButton = helpButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D00 RID: 134400 RVA: 0x00AFDD10 File Offset: 0x00AFBF10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_worldButton(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftLevelUIController.m_luaExportHelper.m_worldButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D01 RID: 134401 RVA: 0x00AFDD68 File Offset: 0x00AFBF68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_worldButton(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			Button worldButton;
			LuaObject.checkType<Button>(l, 2, out worldButton);
			riftLevelUIController.m_luaExportHelper.m_worldButton = worldButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D02 RID: 134402 RVA: 0x00AFDDC4 File Offset: 0x00AFBFC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_hardUIStateController(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftLevelUIController.m_luaExportHelper.m_hardUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D03 RID: 134403 RVA: 0x00AFDE1C File Offset: 0x00AFC01C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_hardUIStateController(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			CommonUIStateController hardUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out hardUIStateController);
			riftLevelUIController.m_luaExportHelper.m_hardUIStateController = hardUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D04 RID: 134404 RVA: 0x00AFDE78 File Offset: 0x00AFC078
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_hardButton(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftLevelUIController.m_luaExportHelper.m_hardButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D05 RID: 134405 RVA: 0x00AFDED0 File Offset: 0x00AFC0D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_hardButton(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			Button hardButton;
			LuaObject.checkType<Button>(l, 2, out hardButton);
			riftLevelUIController.m_luaExportHelper.m_hardButton = hardButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D06 RID: 134406 RVA: 0x00AFDF2C File Offset: 0x00AFC12C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_hardButtonUIStateController(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftLevelUIController.m_luaExportHelper.m_hardButtonUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D07 RID: 134407 RVA: 0x00AFDF84 File Offset: 0x00AFC184
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_hardButtonUIStateController(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			CommonUIStateController hardButtonUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out hardButtonUIStateController);
			riftLevelUIController.m_luaExportHelper.m_hardButtonUIStateController = hardButtonUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D08 RID: 134408 RVA: 0x00AFDFE0 File Offset: 0x00AFC1E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_starRewardButton1GameObject(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftLevelUIController.m_luaExportHelper.m_starRewardButton1GameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D09 RID: 134409 RVA: 0x00AFE038 File Offset: 0x00AFC238
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_starRewardButton1GameObject(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			GameObject starRewardButton1GameObject;
			LuaObject.checkType<GameObject>(l, 2, out starRewardButton1GameObject);
			riftLevelUIController.m_luaExportHelper.m_starRewardButton1GameObject = starRewardButton1GameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D0A RID: 134410 RVA: 0x00AFE094 File Offset: 0x00AFC294
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_starRewardButton2GameObject(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftLevelUIController.m_luaExportHelper.m_starRewardButton2GameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D0B RID: 134411 RVA: 0x00AFE0EC File Offset: 0x00AFC2EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_starRewardButton2GameObject(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			GameObject starRewardButton2GameObject;
			LuaObject.checkType<GameObject>(l, 2, out starRewardButton2GameObject);
			riftLevelUIController.m_luaExportHelper.m_starRewardButton2GameObject = starRewardButton2GameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D0C RID: 134412 RVA: 0x00AFE148 File Offset: 0x00AFC348
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_starRewardButton3GameObject(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftLevelUIController.m_luaExportHelper.m_starRewardButton3GameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D0D RID: 134413 RVA: 0x00AFE1A0 File Offset: 0x00AFC3A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_starRewardButton3GameObject(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			GameObject starRewardButton3GameObject;
			LuaObject.checkType<GameObject>(l, 2, out starRewardButton3GameObject);
			riftLevelUIController.m_luaExportHelper.m_starRewardButton3GameObject = starRewardButton3GameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D0E RID: 134414 RVA: 0x00AFE1FC File Offset: 0x00AFC3FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_starRewardGotText(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftLevelUIController.m_luaExportHelper.m_starRewardGotText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D0F RID: 134415 RVA: 0x00AFE254 File Offset: 0x00AFC454
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_starRewardGotText(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			Text starRewardGotText;
			LuaObject.checkType<Text>(l, 2, out starRewardGotText);
			riftLevelUIController.m_luaExportHelper.m_starRewardGotText = starRewardGotText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D10 RID: 134416 RVA: 0x00AFE2B0 File Offset: 0x00AFC4B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_progressBarImage(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftLevelUIController.m_luaExportHelper.m_progressBarImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D11 RID: 134417 RVA: 0x00AFE308 File Offset: 0x00AFC508
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_progressBarImage(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			Image progressBarImage;
			LuaObject.checkType<Image>(l, 2, out progressBarImage);
			riftLevelUIController.m_luaExportHelper.m_progressBarImage = progressBarImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D12 RID: 134418 RVA: 0x00AFE364 File Offset: 0x00AFC564
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_starRewardPreviewUIStateController(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftLevelUIController.m_luaExportHelper.m_starRewardPreviewUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D13 RID: 134419 RVA: 0x00AFE3BC File Offset: 0x00AFC5BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_starRewardPreviewUIStateController(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			CommonUIStateController starRewardPreviewUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out starRewardPreviewUIStateController);
			riftLevelUIController.m_luaExportHelper.m_starRewardPreviewUIStateController = starRewardPreviewUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D14 RID: 134420 RVA: 0x00AFE418 File Offset: 0x00AFC618
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_starRewardPreviewBackgroundButton(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftLevelUIController.m_luaExportHelper.m_starRewardPreviewBackgroundButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D15 RID: 134421 RVA: 0x00AFE470 File Offset: 0x00AFC670
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_starRewardPreviewBackgroundButton(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			Button starRewardPreviewBackgroundButton;
			LuaObject.checkType<Button>(l, 2, out starRewardPreviewBackgroundButton);
			riftLevelUIController.m_luaExportHelper.m_starRewardPreviewBackgroundButton = starRewardPreviewBackgroundButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D16 RID: 134422 RVA: 0x00AFE4CC File Offset: 0x00AFC6CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_starRewardPreviewScrollRect(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftLevelUIController.m_luaExportHelper.m_starRewardPreviewScrollRect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D17 RID: 134423 RVA: 0x00AFE524 File Offset: 0x00AFC724
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_starRewardPreviewScrollRect(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			ScrollRect starRewardPreviewScrollRect;
			LuaObject.checkType<ScrollRect>(l, 2, out starRewardPreviewScrollRect);
			riftLevelUIController.m_luaExportHelper.m_starRewardPreviewScrollRect = starRewardPreviewScrollRect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D18 RID: 134424 RVA: 0x00AFE580 File Offset: 0x00AFC780
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_unlockConditionUIStateController(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftLevelUIController.m_luaExportHelper.m_unlockConditionUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D19 RID: 134425 RVA: 0x00AFE5D8 File Offset: 0x00AFC7D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_unlockConditionUIStateController(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			CommonUIStateController unlockConditionUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out unlockConditionUIStateController);
			riftLevelUIController.m_luaExportHelper.m_unlockConditionUIStateController = unlockConditionUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D1A RID: 134426 RVA: 0x00AFE634 File Offset: 0x00AFC834
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_unlockConditionBackgroundButton(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftLevelUIController.m_luaExportHelper.m_unlockConditionBackgroundButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D1B RID: 134427 RVA: 0x00AFE68C File Offset: 0x00AFC88C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_unlockConditionBackgroundButton(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			Button unlockConditionBackgroundButton;
			LuaObject.checkType<Button>(l, 2, out unlockConditionBackgroundButton);
			riftLevelUIController.m_luaExportHelper.m_unlockConditionBackgroundButton = unlockConditionBackgroundButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D1C RID: 134428 RVA: 0x00AFE6E8 File Offset: 0x00AFC8E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_unlockConditionGroupGameObject(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftLevelUIController.m_luaExportHelper.m_unlockConditionGroupGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D1D RID: 134429 RVA: 0x00AFE740 File Offset: 0x00AFC940
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_unlockConditionGroupGameObject(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			GameObject unlockConditionGroupGameObject;
			LuaObject.checkType<GameObject>(l, 2, out unlockConditionGroupGameObject);
			riftLevelUIController.m_luaExportHelper.m_unlockConditionGroupGameObject = unlockConditionGroupGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D1E RID: 134430 RVA: 0x00AFE79C File Offset: 0x00AFC99C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_prefabsGameObject(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftLevelUIController.m_luaExportHelper.m_prefabsGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D1F RID: 134431 RVA: 0x00AFE7F4 File Offset: 0x00AFC9F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_prefabsGameObject(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			GameObject prefabsGameObject;
			LuaObject.checkType<GameObject>(l, 2, out prefabsGameObject);
			riftLevelUIController.m_luaExportHelper.m_prefabsGameObject = prefabsGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D20 RID: 134432 RVA: 0x00AFE850 File Offset: 0x00AFCA50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_riftLevelUnlockConditionItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftLevelUIController.m_luaExportHelper.m_riftLevelUnlockConditionItemPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D21 RID: 134433 RVA: 0x00AFE8A8 File Offset: 0x00AFCAA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_riftLevelUnlockConditionItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			GameObject riftLevelUnlockConditionItemPrefab;
			LuaObject.checkType<GameObject>(l, 2, out riftLevelUnlockConditionItemPrefab);
			riftLevelUIController.m_luaExportHelper.m_riftLevelUnlockConditionItemPrefab = riftLevelUnlockConditionItemPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D22 RID: 134434 RVA: 0x00AFE904 File Offset: 0x00AFCB04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_riftLevelButtonPrefab(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftLevelUIController.m_luaExportHelper.m_riftLevelButtonPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D23 RID: 134435 RVA: 0x00AFE95C File Offset: 0x00AFCB5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_riftLevelButtonPrefab(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			GameObject riftLevelButtonPrefab;
			LuaObject.checkType<GameObject>(l, 2, out riftLevelButtonPrefab);
			riftLevelUIController.m_luaExportHelper.m_riftLevelButtonPrefab = riftLevelButtonPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D24 RID: 134436 RVA: 0x00AFE9B8 File Offset: 0x00AFCBB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_eventRiftLevelButtonPrefab(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftLevelUIController.m_luaExportHelper.m_eventRiftLevelButtonPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D25 RID: 134437 RVA: 0x00AFEA10 File Offset: 0x00AFCC10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_eventRiftLevelButtonPrefab(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			GameObject eventRiftLevelButtonPrefab;
			LuaObject.checkType<GameObject>(l, 2, out eventRiftLevelButtonPrefab);
			riftLevelUIController.m_luaExportHelper.m_eventRiftLevelButtonPrefab = eventRiftLevelButtonPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D26 RID: 134438 RVA: 0x00AFEA6C File Offset: 0x00AFCC6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_eventRiftLevelDummyPrefab(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftLevelUIController.m_luaExportHelper.m_eventRiftLevelDummyPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D27 RID: 134439 RVA: 0x00AFEAC4 File Offset: 0x00AFCCC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_eventRiftLevelDummyPrefab(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			GameObject eventRiftLevelDummyPrefab;
			LuaObject.checkType<GameObject>(l, 2, out eventRiftLevelDummyPrefab);
			riftLevelUIController.m_luaExportHelper.m_eventRiftLevelDummyPrefab = eventRiftLevelDummyPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D28 RID: 134440 RVA: 0x00AFEB20 File Offset: 0x00AFCD20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_riftLevelButtons(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftLevelUIController.m_luaExportHelper.m_riftLevelButtons);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D29 RID: 134441 RVA: 0x00AFEB78 File Offset: 0x00AFCD78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_riftLevelButtons(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			List<RiftLevelButton> riftLevelButtons;
			LuaObject.checkType<List<RiftLevelButton>>(l, 2, out riftLevelButtons);
			riftLevelUIController.m_luaExportHelper.m_riftLevelButtons = riftLevelButtons;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D2A RID: 134442 RVA: 0x00AFEBD4 File Offset: 0x00AFCDD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_eventRiftLevelButtons(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftLevelUIController.m_luaExportHelper.m_eventRiftLevelButtons);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D2B RID: 134443 RVA: 0x00AFEC2C File Offset: 0x00AFCE2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_eventRiftLevelButtons(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			List<EventRiftLevelButton> eventRiftLevelButtons;
			LuaObject.checkType<List<EventRiftLevelButton>>(l, 2, out eventRiftLevelButtons);
			riftLevelUIController.m_luaExportHelper.m_eventRiftLevelButtons = eventRiftLevelButtons;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D2C RID: 134444 RVA: 0x00AFEC88 File Offset: 0x00AFCE88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_riftLevelUnlockConditionItems(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftLevelUIController.m_luaExportHelper.m_riftLevelUnlockConditionItems);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D2D RID: 134445 RVA: 0x00AFECE0 File Offset: 0x00AFCEE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_riftLevelUnlockConditionItems(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			List<RiftLevelUnlockConditionItemUIController> riftLevelUnlockConditionItems;
			LuaObject.checkType<List<RiftLevelUnlockConditionItemUIController>>(l, 2, out riftLevelUnlockConditionItems);
			riftLevelUIController.m_luaExportHelper.m_riftLevelUnlockConditionItems = riftLevelUnlockConditionItems;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D2E RID: 134446 RVA: 0x00AFED3C File Offset: 0x00AFCF3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_createChapterBGObject(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftLevelUIController.m_luaExportHelper.m_createChapterBGObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D2F RID: 134447 RVA: 0x00AFED94 File Offset: 0x00AFCF94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_createChapterBGObject(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			GameObject createChapterBGObject;
			LuaObject.checkType<GameObject>(l, 2, out createChapterBGObject);
			riftLevelUIController.m_luaExportHelper.m_createChapterBGObject = createChapterBGObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D30 RID: 134448 RVA: 0x00AFEDF0 File Offset: 0x00AFCFF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_starRewardButtons(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftLevelUIController.m_luaExportHelper.m_starRewardButtons);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D31 RID: 134449 RVA: 0x00AFEE48 File Offset: 0x00AFD048
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_starRewardButtons(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			GainRewardButton[] starRewardButtons;
			LuaObject.checkArray<GainRewardButton>(l, 2, out starRewardButtons);
			riftLevelUIController.m_luaExportHelper.m_starRewardButtons = starRewardButtons;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D32 RID: 134450 RVA: 0x00AFEEA4 File Offset: 0x00AFD0A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_chapterInfo(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftLevelUIController.m_luaExportHelper.m_chapterInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D33 RID: 134451 RVA: 0x00AFEEFC File Offset: 0x00AFD0FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_chapterInfo(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			ConfigDataRiftChapterInfo chapterInfo;
			LuaObject.checkType<ConfigDataRiftChapterInfo>(l, 2, out chapterInfo);
			riftLevelUIController.m_luaExportHelper.m_chapterInfo = chapterInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D34 RID: 134452 RVA: 0x00AFEF58 File Offset: 0x00AFD158
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftLevelUIController.m_luaExportHelper.m_playerContext);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D35 RID: 134453 RVA: 0x00AFEFB0 File Offset: 0x00AFD1B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			ProjectLPlayerContext playerContext;
			LuaObject.checkType<ProjectLPlayerContext>(l, 2, out playerContext);
			riftLevelUIController.m_luaExportHelper.m_playerContext = playerContext;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D36 RID: 134454 RVA: 0x00AFF00C File Offset: 0x00AFD20C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftLevelUIController.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D37 RID: 134455 RVA: 0x00AFF064 File Offset: 0x00AFD264
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUIController riftLevelUIController = (RiftLevelUIController)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			riftLevelUIController.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D38 RID: 134456 RVA: 0x00AFF0C0 File Offset: 0x00AFD2C0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.RiftLevelUIController");
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.Open);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.SetChapter);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.SetStarRewardStatus);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.SetStarRewardProress);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.ClearRiftLevelButtons);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.ClearEventRiftLevelButtons);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.AddRiftLevelButton);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.AddEventRiftLevelButton);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.AddEventRiftLevelDummys);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.OnRiftLevelButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.SetUnlockConditionClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.ClearRiftLevelUnlockContitionItems);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.AddRiftLevelUnlockContitionItems);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.GoToRiftLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.Co_ShowRiftLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.AddStarRewardPreviewGoods);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.OnReturnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.OnHelpButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.OnWorldButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.OnHardButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.OnStarRewardButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.OnEventRiftLevelButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.OnUnlockConditionBackgroundButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.OnStarRewardPreviewBackgroundButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.__callDele_EventOnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.__clearDele_EventOnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.__callDele_EventOnShowHelp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.__clearDele_EventOnShowHelp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache29);
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.__callDele_EventOnReturnToWorld);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache2A);
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.__clearDele_EventOnReturnToWorld);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache2B);
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.__callDele_EventOnChangeHard);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache2C);
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.__clearDele_EventOnChangeHard);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache2D);
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.__callDele_EventOnSelectRiftLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache2E);
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.__clearDele_EventOnSelectRiftLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache2F);
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.__callDele_EventOnGetStarReward);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache30);
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.__clearDele_EventOnGetStarReward);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache31);
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.__callDele_EventOnGoToScenario);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache32);
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.__clearDele_EventOnGoToScenario);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache33);
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.__callDele_EventOnSelectChapter);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache34);
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.__clearDele_EventOnSelectChapter);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache35);
		string name = "EventOnReturn";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.set_EventOnReturn);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache36, true);
		string name2 = "EventOnShowHelp";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.set_EventOnShowHelp);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache37, true);
		string name3 = "EventOnReturnToWorld";
		LuaCSFunction get3 = null;
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.set_EventOnReturnToWorld);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache38, true);
		string name4 = "EventOnChangeHard";
		LuaCSFunction get4 = null;
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.set_EventOnChangeHard);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache39, true);
		string name5 = "EventOnSelectRiftLevel";
		LuaCSFunction get5 = null;
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.set_EventOnSelectRiftLevel);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache3A, true);
		string name6 = "EventOnGetStarReward";
		LuaCSFunction get6 = null;
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.set_EventOnGetStarReward);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache3B, true);
		string name7 = "EventOnGoToScenario";
		LuaCSFunction get7 = null;
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.set_EventOnGoToScenario);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache3C, true);
		string name8 = "EventOnSelectChapter";
		LuaCSFunction get8 = null;
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.set_EventOnSelectChapter);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache3D, true);
		string name9 = "m_uiStateController";
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.get_m_uiStateController);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache3E;
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.set_m_uiStateController);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache3F, true);
		string name10 = "m_marginTransform";
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.get_m_marginTransform);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache40;
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.set_m_marginTransform);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache41, true);
		string name11 = "m_chapterBGObject";
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.get_m_chapterBGObject);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache42;
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.set_m_chapterBGObject);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache43, true);
		string name12 = "m_returnButton";
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.get_m_returnButton);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache44;
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.set_m_returnButton);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache45, true);
		string name13 = "m_helpButton";
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.get_m_helpButton);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache46;
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.set_m_helpButton);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache47, true);
		string name14 = "m_worldButton";
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.get_m_worldButton);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache48;
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.set_m_worldButton);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache49, true);
		string name15 = "m_hardUIStateController";
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.get_m_hardUIStateController);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache4A;
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.set_m_hardUIStateController);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache4B, true);
		string name16 = "m_hardButton";
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.get_m_hardButton);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache4C;
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.set_m_hardButton);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache4D, true);
		string name17 = "m_hardButtonUIStateController";
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.get_m_hardButtonUIStateController);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache4E;
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.set_m_hardButtonUIStateController);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache4F, true);
		string name18 = "m_starRewardButton1GameObject";
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.get_m_starRewardButton1GameObject);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache50;
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.set_m_starRewardButton1GameObject);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache51, true);
		string name19 = "m_starRewardButton2GameObject";
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.get_m_starRewardButton2GameObject);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache52;
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.set_m_starRewardButton2GameObject);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache53, true);
		string name20 = "m_starRewardButton3GameObject";
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.get_m_starRewardButton3GameObject);
		}
		LuaCSFunction get20 = Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache54;
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache55 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache55 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.set_m_starRewardButton3GameObject);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache55, true);
		string name21 = "m_starRewardGotText";
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache56 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache56 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.get_m_starRewardGotText);
		}
		LuaCSFunction get21 = Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache56;
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache57 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache57 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.set_m_starRewardGotText);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache57, true);
		string name22 = "m_progressBarImage";
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache58 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache58 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.get_m_progressBarImage);
		}
		LuaCSFunction get22 = Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache58;
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache59 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache59 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.set_m_progressBarImage);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache59, true);
		string name23 = "m_starRewardPreviewUIStateController";
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache5A == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache5A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.get_m_starRewardPreviewUIStateController);
		}
		LuaCSFunction get23 = Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache5A;
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache5B == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache5B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.set_m_starRewardPreviewUIStateController);
		}
		LuaObject.addMember(l, name23, get23, Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache5B, true);
		string name24 = "m_starRewardPreviewBackgroundButton";
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache5C == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache5C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.get_m_starRewardPreviewBackgroundButton);
		}
		LuaCSFunction get24 = Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache5C;
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache5D == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache5D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.set_m_starRewardPreviewBackgroundButton);
		}
		LuaObject.addMember(l, name24, get24, Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache5D, true);
		string name25 = "m_starRewardPreviewScrollRect";
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache5E == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache5E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.get_m_starRewardPreviewScrollRect);
		}
		LuaCSFunction get25 = Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache5E;
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache5F == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache5F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.set_m_starRewardPreviewScrollRect);
		}
		LuaObject.addMember(l, name25, get25, Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache5F, true);
		string name26 = "m_unlockConditionUIStateController";
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache60 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache60 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.get_m_unlockConditionUIStateController);
		}
		LuaCSFunction get26 = Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache60;
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache61 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache61 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.set_m_unlockConditionUIStateController);
		}
		LuaObject.addMember(l, name26, get26, Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache61, true);
		string name27 = "m_unlockConditionBackgroundButton";
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache62 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache62 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.get_m_unlockConditionBackgroundButton);
		}
		LuaCSFunction get27 = Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache62;
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache63 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache63 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.set_m_unlockConditionBackgroundButton);
		}
		LuaObject.addMember(l, name27, get27, Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache63, true);
		string name28 = "m_unlockConditionGroupGameObject";
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache64 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache64 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.get_m_unlockConditionGroupGameObject);
		}
		LuaCSFunction get28 = Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache64;
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache65 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache65 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.set_m_unlockConditionGroupGameObject);
		}
		LuaObject.addMember(l, name28, get28, Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache65, true);
		string name29 = "m_prefabsGameObject";
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache66 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache66 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.get_m_prefabsGameObject);
		}
		LuaCSFunction get29 = Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache66;
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache67 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache67 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.set_m_prefabsGameObject);
		}
		LuaObject.addMember(l, name29, get29, Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache67, true);
		string name30 = "m_riftLevelUnlockConditionItemPrefab";
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache68 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache68 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.get_m_riftLevelUnlockConditionItemPrefab);
		}
		LuaCSFunction get30 = Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache68;
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache69 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache69 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.set_m_riftLevelUnlockConditionItemPrefab);
		}
		LuaObject.addMember(l, name30, get30, Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache69, true);
		string name31 = "m_riftLevelButtonPrefab";
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache6A == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache6A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.get_m_riftLevelButtonPrefab);
		}
		LuaCSFunction get31 = Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache6A;
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache6B == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache6B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.set_m_riftLevelButtonPrefab);
		}
		LuaObject.addMember(l, name31, get31, Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache6B, true);
		string name32 = "m_eventRiftLevelButtonPrefab";
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache6C == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache6C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.get_m_eventRiftLevelButtonPrefab);
		}
		LuaCSFunction get32 = Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache6C;
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache6D == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache6D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.set_m_eventRiftLevelButtonPrefab);
		}
		LuaObject.addMember(l, name32, get32, Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache6D, true);
		string name33 = "m_eventRiftLevelDummyPrefab";
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache6E == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache6E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.get_m_eventRiftLevelDummyPrefab);
		}
		LuaCSFunction get33 = Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache6E;
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache6F == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache6F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.set_m_eventRiftLevelDummyPrefab);
		}
		LuaObject.addMember(l, name33, get33, Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache6F, true);
		string name34 = "m_riftLevelButtons";
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache70 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache70 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.get_m_riftLevelButtons);
		}
		LuaCSFunction get34 = Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache70;
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache71 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache71 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.set_m_riftLevelButtons);
		}
		LuaObject.addMember(l, name34, get34, Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache71, true);
		string name35 = "m_eventRiftLevelButtons";
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache72 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache72 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.get_m_eventRiftLevelButtons);
		}
		LuaCSFunction get35 = Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache72;
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache73 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache73 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.set_m_eventRiftLevelButtons);
		}
		LuaObject.addMember(l, name35, get35, Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache73, true);
		string name36 = "m_riftLevelUnlockConditionItems";
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache74 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache74 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.get_m_riftLevelUnlockConditionItems);
		}
		LuaCSFunction get36 = Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache74;
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache75 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache75 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.set_m_riftLevelUnlockConditionItems);
		}
		LuaObject.addMember(l, name36, get36, Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache75, true);
		string name37 = "m_createChapterBGObject";
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache76 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache76 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.get_m_createChapterBGObject);
		}
		LuaCSFunction get37 = Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache76;
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache77 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache77 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.set_m_createChapterBGObject);
		}
		LuaObject.addMember(l, name37, get37, Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache77, true);
		string name38 = "m_starRewardButtons";
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache78 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache78 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.get_m_starRewardButtons);
		}
		LuaCSFunction get38 = Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache78;
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache79 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache79 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.set_m_starRewardButtons);
		}
		LuaObject.addMember(l, name38, get38, Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache79, true);
		string name39 = "m_chapterInfo";
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache7A == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache7A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.get_m_chapterInfo);
		}
		LuaCSFunction get39 = Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache7A;
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache7B == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache7B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.set_m_chapterInfo);
		}
		LuaObject.addMember(l, name39, get39, Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache7B, true);
		string name40 = "m_playerContext";
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache7C == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache7C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.get_m_playerContext);
		}
		LuaCSFunction get40 = Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache7C;
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache7D == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache7D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.set_m_playerContext);
		}
		LuaObject.addMember(l, name40, get40, Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache7D, true);
		string name41 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache7E == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache7E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.get_m_configDataLoader);
		}
		LuaCSFunction get41 = Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache7E;
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache7F == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache7F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name41, get41, Lua_BlackJack_ProjectL_UI_RiftLevelUIController.<>f__mg$cache7F, true);
		LuaObject.createTypeMetatable(l, null, typeof(RiftLevelUIController), typeof(UIControllerBase));
	}

	// Token: 0x04016BCC RID: 93132
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04016BCD RID: 93133
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04016BCE RID: 93134
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04016BCF RID: 93135
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04016BD0 RID: 93136
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04016BD1 RID: 93137
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04016BD2 RID: 93138
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04016BD3 RID: 93139
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04016BD4 RID: 93140
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04016BD5 RID: 93141
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04016BD6 RID: 93142
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04016BD7 RID: 93143
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04016BD8 RID: 93144
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04016BD9 RID: 93145
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04016BDA RID: 93146
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04016BDB RID: 93147
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04016BDC RID: 93148
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04016BDD RID: 93149
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04016BDE RID: 93150
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04016BDF RID: 93151
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04016BE0 RID: 93152
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04016BE1 RID: 93153
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04016BE2 RID: 93154
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04016BE3 RID: 93155
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04016BE4 RID: 93156
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04016BE5 RID: 93157
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04016BE6 RID: 93158
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04016BE7 RID: 93159
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04016BE8 RID: 93160
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04016BE9 RID: 93161
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04016BEA RID: 93162
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04016BEB RID: 93163
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04016BEC RID: 93164
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04016BED RID: 93165
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04016BEE RID: 93166
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04016BEF RID: 93167
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04016BF0 RID: 93168
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04016BF1 RID: 93169
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04016BF2 RID: 93170
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04016BF3 RID: 93171
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04016BF4 RID: 93172
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04016BF5 RID: 93173
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04016BF6 RID: 93174
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04016BF7 RID: 93175
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04016BF8 RID: 93176
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04016BF9 RID: 93177
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04016BFA RID: 93178
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04016BFB RID: 93179
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04016BFC RID: 93180
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04016BFD RID: 93181
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04016BFE RID: 93182
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04016BFF RID: 93183
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04016C00 RID: 93184
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04016C01 RID: 93185
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04016C02 RID: 93186
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04016C03 RID: 93187
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04016C04 RID: 93188
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04016C05 RID: 93189
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04016C06 RID: 93190
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x04016C07 RID: 93191
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x04016C08 RID: 93192
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x04016C09 RID: 93193
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x04016C0A RID: 93194
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x04016C0B RID: 93195
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x04016C0C RID: 93196
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x04016C0D RID: 93197
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x04016C0E RID: 93198
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x04016C0F RID: 93199
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x04016C10 RID: 93200
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x04016C11 RID: 93201
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x04016C12 RID: 93202
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x04016C13 RID: 93203
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x04016C14 RID: 93204
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x04016C15 RID: 93205
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x04016C16 RID: 93206
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x04016C17 RID: 93207
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x04016C18 RID: 93208
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x04016C19 RID: 93209
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x04016C1A RID: 93210
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x04016C1B RID: 93211
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x04016C1C RID: 93212
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x04016C1D RID: 93213
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x04016C1E RID: 93214
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x04016C1F RID: 93215
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x04016C20 RID: 93216
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x04016C21 RID: 93217
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x04016C22 RID: 93218
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x04016C23 RID: 93219
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x04016C24 RID: 93220
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x04016C25 RID: 93221
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;

	// Token: 0x04016C26 RID: 93222
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5A;

	// Token: 0x04016C27 RID: 93223
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5B;

	// Token: 0x04016C28 RID: 93224
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5C;

	// Token: 0x04016C29 RID: 93225
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5D;

	// Token: 0x04016C2A RID: 93226
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5E;

	// Token: 0x04016C2B RID: 93227
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5F;

	// Token: 0x04016C2C RID: 93228
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache60;

	// Token: 0x04016C2D RID: 93229
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache61;

	// Token: 0x04016C2E RID: 93230
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache62;

	// Token: 0x04016C2F RID: 93231
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache63;

	// Token: 0x04016C30 RID: 93232
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache64;

	// Token: 0x04016C31 RID: 93233
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache65;

	// Token: 0x04016C32 RID: 93234
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache66;

	// Token: 0x04016C33 RID: 93235
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache67;

	// Token: 0x04016C34 RID: 93236
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache68;

	// Token: 0x04016C35 RID: 93237
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache69;

	// Token: 0x04016C36 RID: 93238
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6A;

	// Token: 0x04016C37 RID: 93239
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6B;

	// Token: 0x04016C38 RID: 93240
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6C;

	// Token: 0x04016C39 RID: 93241
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6D;

	// Token: 0x04016C3A RID: 93242
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6E;

	// Token: 0x04016C3B RID: 93243
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6F;

	// Token: 0x04016C3C RID: 93244
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache70;

	// Token: 0x04016C3D RID: 93245
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache71;

	// Token: 0x04016C3E RID: 93246
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache72;

	// Token: 0x04016C3F RID: 93247
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache73;

	// Token: 0x04016C40 RID: 93248
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache74;

	// Token: 0x04016C41 RID: 93249
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache75;

	// Token: 0x04016C42 RID: 93250
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache76;

	// Token: 0x04016C43 RID: 93251
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache77;

	// Token: 0x04016C44 RID: 93252
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache78;

	// Token: 0x04016C45 RID: 93253
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache79;

	// Token: 0x04016C46 RID: 93254
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7A;

	// Token: 0x04016C47 RID: 93255
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7B;

	// Token: 0x04016C48 RID: 93256
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7C;

	// Token: 0x04016C49 RID: 93257
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7D;

	// Token: 0x04016C4A RID: 93258
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7E;

	// Token: 0x04016C4B RID: 93259
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7F;
}
