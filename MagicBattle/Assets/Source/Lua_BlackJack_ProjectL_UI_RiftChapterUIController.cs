using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001561 RID: 5473
[Preserve]
public class Lua_BlackJack_ProjectL_UI_RiftChapterUIController : LuaObject
{
	// Token: 0x06020BF4 RID: 134132 RVA: 0x00AF5CE8 File Offset: 0x00AF3EE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Open(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUIController riftChapterUIController = (RiftChapterUIController)LuaObject.checkSelf(l);
			riftChapterUIController.Open();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020BF5 RID: 134133 RVA: 0x00AF5D34 File Offset: 0x00AF3F34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearChapterButtons(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUIController riftChapterUIController = (RiftChapterUIController)LuaObject.checkSelf(l);
			riftChapterUIController.ClearChapterButtons();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020BF6 RID: 134134 RVA: 0x00AF5D80 File Offset: 0x00AF3F80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddChapterButton(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUIController riftChapterUIController = (RiftChapterUIController)LuaObject.checkSelf(l);
			ConfigDataRiftChapterInfo chapterInfo;
			LuaObject.checkType<ConfigDataRiftChapterInfo>(l, 2, out chapterInfo);
			bool locked;
			LuaObject.checkType(l, 3, out locked);
			bool newChapter;
			LuaObject.checkType(l, 4, out newChapter);
			riftChapterUIController.AddChapterButton(chapterInfo, locked, newChapter);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020BF7 RID: 134135 RVA: 0x00AF5DF4 File Offset: 0x00AF3FF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetCurrentChapter(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUIController riftChapterUIController = (RiftChapterUIController)LuaObject.checkSelf(l);
			ConfigDataRiftChapterInfo currentChapter;
			LuaObject.checkType<ConfigDataRiftChapterInfo>(l, 2, out currentChapter);
			riftChapterUIController.SetCurrentChapter(currentChapter);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020BF8 RID: 134136 RVA: 0x00AF5E4C File Offset: 0x00AF404C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowChapterProgress(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUIController riftChapterUIController = (RiftChapterUIController)LuaObject.checkSelf(l);
			ConfigDataRiftChapterInfo chapterInfo;
			LuaObject.checkType<ConfigDataRiftChapterInfo>(l, 2, out chapterInfo);
			int normalStarCount;
			LuaObject.checkType(l, 3, out normalStarCount);
			int normalStarCountMax;
			LuaObject.checkType(l, 4, out normalStarCountMax);
			int normalAchivementCount;
			LuaObject.checkType(l, 5, out normalAchivementCount);
			int normalAchievementCountMax;
			LuaObject.checkType(l, 6, out normalAchievementCountMax);
			int normalTreasureCount;
			LuaObject.checkType(l, 7, out normalTreasureCount);
			int normalTreasureCountMax;
			LuaObject.checkType(l, 8, out normalTreasureCountMax);
			int hardStarCount;
			LuaObject.checkType(l, 9, out hardStarCount);
			int hardStarCountMax;
			LuaObject.checkType(l, 10, out hardStarCountMax);
			int hardAchivementCount;
			LuaObject.checkType(l, 11, out hardAchivementCount);
			int hardAchievementCountMax;
			LuaObject.checkType(l, 12, out hardAchievementCountMax);
			int hardTreasureCount;
			LuaObject.checkType(l, 13, out hardTreasureCount);
			int hardTreasureCountMax;
			LuaObject.checkType(l, 14, out hardTreasureCountMax);
			riftChapterUIController.ShowChapterProgress(chapterInfo, normalStarCount, normalStarCountMax, normalAchivementCount, normalAchievementCountMax, normalTreasureCount, normalTreasureCountMax, hardStarCount, hardStarCountMax, hardAchivementCount, hardAchievementCountMax, hardTreasureCount, hardTreasureCountMax);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020BF9 RID: 134137 RVA: 0x00AF5F3C File Offset: 0x00AF413C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetChapterUnlockConditionClose(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUIController riftChapterUIController = (RiftChapterUIController)LuaObject.checkSelf(l);
			riftChapterUIController.SetChapterUnlockConditionClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020BFA RID: 134138 RVA: 0x00AF5F88 File Offset: 0x00AF4188
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HideChapterProgress(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUIController riftChapterUIController = (RiftChapterUIController)LuaObject.checkSelf(l);
			riftChapterUIController.HideChapterProgress();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020BFB RID: 134139 RVA: 0x00AF5FD4 File Offset: 0x00AF41D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowChapterUnlockConditions(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUIController riftChapterUIController = (RiftChapterUIController)LuaObject.checkSelf(l);
			ConfigDataRiftChapterInfo chapterInfo;
			LuaObject.checkType<ConfigDataRiftChapterInfo>(l, 2, out chapterInfo);
			riftChapterUIController.ShowChapterUnlockConditions(chapterInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020BFC RID: 134140 RVA: 0x00AF602C File Offset: 0x00AF422C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUIController riftChapterUIController = (RiftChapterUIController)LuaObject.checkSelf(l);
			riftChapterUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020BFD RID: 134141 RVA: 0x00AF6080 File Offset: 0x00AF4280
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LateUpdate(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUIController riftChapterUIController = (RiftChapterUIController)LuaObject.checkSelf(l);
			riftChapterUIController.m_luaExportHelper.LateUpdate();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020BFE RID: 134142 RVA: 0x00AF60D4 File Offset: 0x00AF42D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnUnlockConditionBGButtonClick(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUIController riftChapterUIController = (RiftChapterUIController)LuaObject.checkSelf(l);
			riftChapterUIController.m_luaExportHelper.OnUnlockConditionBGButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020BFF RID: 134143 RVA: 0x00AF6128 File Offset: 0x00AF4328
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearRiftLevelUnlockContitionItems(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUIController riftChapterUIController = (RiftChapterUIController)LuaObject.checkSelf(l);
			riftChapterUIController.m_luaExportHelper.ClearRiftLevelUnlockContitionItems();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C00 RID: 134144 RVA: 0x00AF617C File Offset: 0x00AF437C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HideChapterUnlockConditions(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUIController riftChapterUIController = (RiftChapterUIController)LuaObject.checkSelf(l);
			riftChapterUIController.m_luaExportHelper.HideChapterUnlockConditions();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C01 RID: 134145 RVA: 0x00AF61D0 File Offset: 0x00AF43D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnReturnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUIController riftChapterUIController = (RiftChapterUIController)LuaObject.checkSelf(l);
			riftChapterUIController.m_luaExportHelper.OnReturnButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C02 RID: 134146 RVA: 0x00AF6224 File Offset: 0x00AF4424
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnHelpButtonClick(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUIController riftChapterUIController = (RiftChapterUIController)LuaObject.checkSelf(l);
			riftChapterUIController.m_luaExportHelper.OnHelpButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C03 RID: 134147 RVA: 0x00AF6278 File Offset: 0x00AF4478
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnWorldButtonClick(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUIController riftChapterUIController = (RiftChapterUIController)LuaObject.checkSelf(l);
			riftChapterUIController.m_luaExportHelper.OnWorldButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C04 RID: 134148 RVA: 0x00AF62CC File Offset: 0x00AF44CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnChapterButtonClick(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUIController riftChapterUIController = (RiftChapterUIController)LuaObject.checkSelf(l);
			RiftChapterButton b;
			LuaObject.checkType<RiftChapterButton>(l, 2, out b);
			riftChapterUIController.m_luaExportHelper.OnChapterButtonClick(b);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C05 RID: 134149 RVA: 0x00AF6328 File Offset: 0x00AF4528
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUIController riftChapterUIController = (RiftChapterUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			riftChapterUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C06 RID: 134150 RVA: 0x00AF6394 File Offset: 0x00AF4594
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUIController riftChapterUIController = (RiftChapterUIController)LuaObject.checkSelf(l);
			riftChapterUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C07 RID: 134151 RVA: 0x00AF63E8 File Offset: 0x00AF45E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUIController riftChapterUIController = (RiftChapterUIController)LuaObject.checkSelf(l);
			riftChapterUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C08 RID: 134152 RVA: 0x00AF643C File Offset: 0x00AF463C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUIController riftChapterUIController = (RiftChapterUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = riftChapterUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x06020C09 RID: 134153 RVA: 0x00AF64E4 File Offset: 0x00AF46E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUIController riftChapterUIController = (RiftChapterUIController)LuaObject.checkSelf(l);
			riftChapterUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C0A RID: 134154 RVA: 0x00AF6538 File Offset: 0x00AF4738
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUIController riftChapterUIController = (RiftChapterUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			riftChapterUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C0B RID: 134155 RVA: 0x00AF65A4 File Offset: 0x00AF47A4
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
				RiftChapterUIController riftChapterUIController = (RiftChapterUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				riftChapterUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				RiftChapterUIController riftChapterUIController2 = (RiftChapterUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				riftChapterUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x06020C0C RID: 134156 RVA: 0x00AF66B4 File Offset: 0x00AF48B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUIController riftChapterUIController = (RiftChapterUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			riftChapterUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C0D RID: 134157 RVA: 0x00AF6720 File Offset: 0x00AF4920
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUIController riftChapterUIController = (RiftChapterUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			riftChapterUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C0E RID: 134158 RVA: 0x00AF678C File Offset: 0x00AF498C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUIController riftChapterUIController = (RiftChapterUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			riftChapterUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C0F RID: 134159 RVA: 0x00AF67F8 File Offset: 0x00AF49F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUIController riftChapterUIController = (RiftChapterUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			riftChapterUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C10 RID: 134160 RVA: 0x00AF6864 File Offset: 0x00AF4A64
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
				RiftChapterUIController riftChapterUIController = (RiftChapterUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				riftChapterUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				RiftChapterUIController riftChapterUIController2 = (RiftChapterUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				riftChapterUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x06020C11 RID: 134161 RVA: 0x00AF6974 File Offset: 0x00AF4B74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUIController riftChapterUIController = (RiftChapterUIController)LuaObject.checkSelf(l);
			string s = riftChapterUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x06020C12 RID: 134162 RVA: 0x00AF69D0 File Offset: 0x00AF4BD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUIController riftChapterUIController = (RiftChapterUIController)LuaObject.checkSelf(l);
			riftChapterUIController.m_luaExportHelper.__callDele_EventOnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C13 RID: 134163 RVA: 0x00AF6A24 File Offset: 0x00AF4C24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUIController riftChapterUIController = (RiftChapterUIController)LuaObject.checkSelf(l);
			riftChapterUIController.m_luaExportHelper.__clearDele_EventOnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C14 RID: 134164 RVA: 0x00AF6A78 File Offset: 0x00AF4C78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnShowHelp(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUIController riftChapterUIController = (RiftChapterUIController)LuaObject.checkSelf(l);
			riftChapterUIController.m_luaExportHelper.__callDele_EventOnShowHelp();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C15 RID: 134165 RVA: 0x00AF6ACC File Offset: 0x00AF4CCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnShowHelp(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUIController riftChapterUIController = (RiftChapterUIController)LuaObject.checkSelf(l);
			riftChapterUIController.m_luaExportHelper.__clearDele_EventOnShowHelp();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C16 RID: 134166 RVA: 0x00AF6B20 File Offset: 0x00AF4D20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnReturnToWorld(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUIController riftChapterUIController = (RiftChapterUIController)LuaObject.checkSelf(l);
			riftChapterUIController.m_luaExportHelper.__callDele_EventOnReturnToWorld();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C17 RID: 134167 RVA: 0x00AF6B74 File Offset: 0x00AF4D74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnReturnToWorld(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUIController riftChapterUIController = (RiftChapterUIController)LuaObject.checkSelf(l);
			riftChapterUIController.m_luaExportHelper.__clearDele_EventOnReturnToWorld();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C18 RID: 134168 RVA: 0x00AF6BC8 File Offset: 0x00AF4DC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnSelectChapter(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUIController riftChapterUIController = (RiftChapterUIController)LuaObject.checkSelf(l);
			ConfigDataRiftChapterInfo obj;
			LuaObject.checkType<ConfigDataRiftChapterInfo>(l, 2, out obj);
			riftChapterUIController.m_luaExportHelper.__callDele_EventOnSelectChapter(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C19 RID: 134169 RVA: 0x00AF6C24 File Offset: 0x00AF4E24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnSelectChapter(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUIController riftChapterUIController = (RiftChapterUIController)LuaObject.checkSelf(l);
			ConfigDataRiftChapterInfo obj;
			LuaObject.checkType<ConfigDataRiftChapterInfo>(l, 2, out obj);
			riftChapterUIController.m_luaExportHelper.__clearDele_EventOnSelectChapter(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C1A RID: 134170 RVA: 0x00AF6C80 File Offset: 0x00AF4E80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnSwitchChapter(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUIController riftChapterUIController = (RiftChapterUIController)LuaObject.checkSelf(l);
			ConfigDataRiftChapterInfo obj;
			LuaObject.checkType<ConfigDataRiftChapterInfo>(l, 2, out obj);
			riftChapterUIController.m_luaExportHelper.__callDele_EventOnSwitchChapter(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C1B RID: 134171 RVA: 0x00AF6CDC File Offset: 0x00AF4EDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnSwitchChapter(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUIController riftChapterUIController = (RiftChapterUIController)LuaObject.checkSelf(l);
			ConfigDataRiftChapterInfo obj;
			LuaObject.checkType<ConfigDataRiftChapterInfo>(l, 2, out obj);
			riftChapterUIController.m_luaExportHelper.__clearDele_EventOnSwitchChapter(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C1C RID: 134172 RVA: 0x00AF6D38 File Offset: 0x00AF4F38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnGoToScenario(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUIController riftChapterUIController = (RiftChapterUIController)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			riftChapterUIController.m_luaExportHelper.__callDele_EventOnGoToScenario(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C1D RID: 134173 RVA: 0x00AF6D94 File Offset: 0x00AF4F94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnGoToScenario(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUIController riftChapterUIController = (RiftChapterUIController)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			riftChapterUIController.m_luaExportHelper.__clearDele_EventOnGoToScenario(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C1E RID: 134174 RVA: 0x00AF6DF0 File Offset: 0x00AF4FF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUIController riftChapterUIController = (RiftChapterUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					riftChapterUIController.EventOnReturn += value;
				}
				else if (num == 2)
				{
					riftChapterUIController.EventOnReturn -= value;
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

	// Token: 0x06020C1F RID: 134175 RVA: 0x00AF6E70 File Offset: 0x00AF5070
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnShowHelp(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUIController riftChapterUIController = (RiftChapterUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					riftChapterUIController.EventOnShowHelp += value;
				}
				else if (num == 2)
				{
					riftChapterUIController.EventOnShowHelp -= value;
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

	// Token: 0x06020C20 RID: 134176 RVA: 0x00AF6EF0 File Offset: 0x00AF50F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnReturnToWorld(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUIController riftChapterUIController = (RiftChapterUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					riftChapterUIController.EventOnReturnToWorld += value;
				}
				else if (num == 2)
				{
					riftChapterUIController.EventOnReturnToWorld -= value;
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

	// Token: 0x06020C21 RID: 134177 RVA: 0x00AF6F70 File Offset: 0x00AF5170
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnSelectChapter(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUIController riftChapterUIController = (RiftChapterUIController)LuaObject.checkSelf(l);
			Action<ConfigDataRiftChapterInfo> value;
			int num = LuaObject.checkDelegate<Action<ConfigDataRiftChapterInfo>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					riftChapterUIController.EventOnSelectChapter += value;
				}
				else if (num == 2)
				{
					riftChapterUIController.EventOnSelectChapter -= value;
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

	// Token: 0x06020C22 RID: 134178 RVA: 0x00AF6FF0 File Offset: 0x00AF51F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnSwitchChapter(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUIController riftChapterUIController = (RiftChapterUIController)LuaObject.checkSelf(l);
			Action<ConfigDataRiftChapterInfo> value;
			int num = LuaObject.checkDelegate<Action<ConfigDataRiftChapterInfo>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					riftChapterUIController.EventOnSwitchChapter += value;
				}
				else if (num == 2)
				{
					riftChapterUIController.EventOnSwitchChapter -= value;
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

	// Token: 0x06020C23 RID: 134179 RVA: 0x00AF7070 File Offset: 0x00AF5270
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnGoToScenario(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUIController riftChapterUIController = (RiftChapterUIController)LuaObject.checkSelf(l);
			Action<int> value;
			int num = LuaObject.checkDelegate<Action<int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					riftChapterUIController.EventOnGoToScenario += value;
				}
				else if (num == 2)
				{
					riftChapterUIController.EventOnGoToScenario -= value;
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

	// Token: 0x06020C24 RID: 134180 RVA: 0x00AF70F0 File Offset: 0x00AF52F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUIController riftChapterUIController = (RiftChapterUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftChapterUIController.m_luaExportHelper.m_uiStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C25 RID: 134181 RVA: 0x00AF7148 File Offset: 0x00AF5348
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUIController riftChapterUIController = (RiftChapterUIController)LuaObject.checkSelf(l);
			CommonUIStateController uiStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out uiStateController);
			riftChapterUIController.m_luaExportHelper.m_uiStateController = uiStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C26 RID: 134182 RVA: 0x00AF71A4 File Offset: 0x00AF53A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_marginTransform(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUIController riftChapterUIController = (RiftChapterUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftChapterUIController.m_luaExportHelper.m_marginTransform);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C27 RID: 134183 RVA: 0x00AF71FC File Offset: 0x00AF53FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_marginTransform(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUIController riftChapterUIController = (RiftChapterUIController)LuaObject.checkSelf(l);
			RectTransform marginTransform;
			LuaObject.checkType<RectTransform>(l, 2, out marginTransform);
			riftChapterUIController.m_luaExportHelper.m_marginTransform = marginTransform;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C28 RID: 134184 RVA: 0x00AF7258 File Offset: 0x00AF5458
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_returnButton(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUIController riftChapterUIController = (RiftChapterUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftChapterUIController.m_luaExportHelper.m_returnButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C29 RID: 134185 RVA: 0x00AF72B0 File Offset: 0x00AF54B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_returnButton(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUIController riftChapterUIController = (RiftChapterUIController)LuaObject.checkSelf(l);
			Button returnButton;
			LuaObject.checkType<Button>(l, 2, out returnButton);
			riftChapterUIController.m_luaExportHelper.m_returnButton = returnButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C2A RID: 134186 RVA: 0x00AF730C File Offset: 0x00AF550C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_helpButton(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUIController riftChapterUIController = (RiftChapterUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftChapterUIController.m_luaExportHelper.m_helpButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C2B RID: 134187 RVA: 0x00AF7364 File Offset: 0x00AF5564
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_helpButton(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUIController riftChapterUIController = (RiftChapterUIController)LuaObject.checkSelf(l);
			Button helpButton;
			LuaObject.checkType<Button>(l, 2, out helpButton);
			riftChapterUIController.m_luaExportHelper.m_helpButton = helpButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C2C RID: 134188 RVA: 0x00AF73C0 File Offset: 0x00AF55C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_worldButton(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUIController riftChapterUIController = (RiftChapterUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftChapterUIController.m_luaExportHelper.m_worldButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C2D RID: 134189 RVA: 0x00AF7418 File Offset: 0x00AF5618
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_worldButton(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUIController riftChapterUIController = (RiftChapterUIController)LuaObject.checkSelf(l);
			Button worldButton;
			LuaObject.checkType<Button>(l, 2, out worldButton);
			riftChapterUIController.m_luaExportHelper.m_worldButton = worldButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C2E RID: 134190 RVA: 0x00AF7474 File Offset: 0x00AF5674
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_chaptersScrollRect(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUIController riftChapterUIController = (RiftChapterUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftChapterUIController.m_luaExportHelper.m_chaptersScrollRect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C2F RID: 134191 RVA: 0x00AF74CC File Offset: 0x00AF56CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_chaptersScrollRect(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUIController riftChapterUIController = (RiftChapterUIController)LuaObject.checkSelf(l);
			ScrollRect chaptersScrollRect;
			LuaObject.checkType<ScrollRect>(l, 2, out chaptersScrollRect);
			riftChapterUIController.m_luaExportHelper.m_chaptersScrollRect = chaptersScrollRect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C30 RID: 134192 RVA: 0x00AF7528 File Offset: 0x00AF5728
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_unlockConditionUIStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUIController riftChapterUIController = (RiftChapterUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftChapterUIController.m_luaExportHelper.m_unlockConditionUIStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C31 RID: 134193 RVA: 0x00AF7580 File Offset: 0x00AF5780
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_unlockConditionUIStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUIController riftChapterUIController = (RiftChapterUIController)LuaObject.checkSelf(l);
			CommonUIStateController unlockConditionUIStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out unlockConditionUIStateCtrl);
			riftChapterUIController.m_luaExportHelper.m_unlockConditionUIStateCtrl = unlockConditionUIStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C32 RID: 134194 RVA: 0x00AF75DC File Offset: 0x00AF57DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_unlockConditionGameObject(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUIController riftChapterUIController = (RiftChapterUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftChapterUIController.m_luaExportHelper.m_unlockConditionGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C33 RID: 134195 RVA: 0x00AF7634 File Offset: 0x00AF5834
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_unlockConditionGameObject(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUIController riftChapterUIController = (RiftChapterUIController)LuaObject.checkSelf(l);
			GameObject unlockConditionGameObject;
			LuaObject.checkType<GameObject>(l, 2, out unlockConditionGameObject);
			riftChapterUIController.m_luaExportHelper.m_unlockConditionGameObject = unlockConditionGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C34 RID: 134196 RVA: 0x00AF7690 File Offset: 0x00AF5890
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_unlockConditionGroup(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUIController riftChapterUIController = (RiftChapterUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftChapterUIController.m_luaExportHelper.m_unlockConditionGroup);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C35 RID: 134197 RVA: 0x00AF76E8 File Offset: 0x00AF58E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_unlockConditionGroup(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUIController riftChapterUIController = (RiftChapterUIController)LuaObject.checkSelf(l);
			GameObject unlockConditionGroup;
			LuaObject.checkType<GameObject>(l, 2, out unlockConditionGroup);
			riftChapterUIController.m_luaExportHelper.m_unlockConditionGroup = unlockConditionGroup;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C36 RID: 134198 RVA: 0x00AF7744 File Offset: 0x00AF5944
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_unlockConditionBGButton(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUIController riftChapterUIController = (RiftChapterUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftChapterUIController.m_luaExportHelper.m_unlockConditionBGButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C37 RID: 134199 RVA: 0x00AF779C File Offset: 0x00AF599C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_unlockConditionBGButton(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUIController riftChapterUIController = (RiftChapterUIController)LuaObject.checkSelf(l);
			Button unlockConditionBGButton;
			LuaObject.checkType<Button>(l, 2, out unlockConditionBGButton);
			riftChapterUIController.m_luaExportHelper.m_unlockConditionBGButton = unlockConditionBGButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C38 RID: 134200 RVA: 0x00AF77F8 File Offset: 0x00AF59F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_progressGameObject(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUIController riftChapterUIController = (RiftChapterUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftChapterUIController.m_luaExportHelper.m_progressGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C39 RID: 134201 RVA: 0x00AF7850 File Offset: 0x00AF5A50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_progressGameObject(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUIController riftChapterUIController = (RiftChapterUIController)LuaObject.checkSelf(l);
			GameObject progressGameObject;
			LuaObject.checkType<GameObject>(l, 2, out progressGameObject);
			riftChapterUIController.m_luaExportHelper.m_progressGameObject = progressGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C3A RID: 134202 RVA: 0x00AF78AC File Offset: 0x00AF5AAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_progressTitleText(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUIController riftChapterUIController = (RiftChapterUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftChapterUIController.m_luaExportHelper.m_progressTitleText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C3B RID: 134203 RVA: 0x00AF7904 File Offset: 0x00AF5B04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_progressTitleText(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUIController riftChapterUIController = (RiftChapterUIController)LuaObject.checkSelf(l);
			Text progressTitleText;
			LuaObject.checkType<Text>(l, 2, out progressTitleText);
			riftChapterUIController.m_luaExportHelper.m_progressTitleText = progressTitleText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C3C RID: 134204 RVA: 0x00AF7960 File Offset: 0x00AF5B60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_progressNameText(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUIController riftChapterUIController = (RiftChapterUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftChapterUIController.m_luaExportHelper.m_progressNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C3D RID: 134205 RVA: 0x00AF79B8 File Offset: 0x00AF5BB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_progressNameText(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUIController riftChapterUIController = (RiftChapterUIController)LuaObject.checkSelf(l);
			Text progressNameText;
			LuaObject.checkType<Text>(l, 2, out progressNameText);
			riftChapterUIController.m_luaExportHelper.m_progressNameText = progressNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C3E RID: 134206 RVA: 0x00AF7A14 File Offset: 0x00AF5C14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_progressPlaceText(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUIController riftChapterUIController = (RiftChapterUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftChapterUIController.m_luaExportHelper.m_progressPlaceText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C3F RID: 134207 RVA: 0x00AF7A6C File Offset: 0x00AF5C6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_progressPlaceText(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUIController riftChapterUIController = (RiftChapterUIController)LuaObject.checkSelf(l);
			Text progressPlaceText;
			LuaObject.checkType<Text>(l, 2, out progressPlaceText);
			riftChapterUIController.m_luaExportHelper.m_progressPlaceText = progressPlaceText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C40 RID: 134208 RVA: 0x00AF7AC8 File Offset: 0x00AF5CC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_progressNormalStarText(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUIController riftChapterUIController = (RiftChapterUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftChapterUIController.m_luaExportHelper.m_progressNormalStarText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C41 RID: 134209 RVA: 0x00AF7B20 File Offset: 0x00AF5D20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_progressNormalStarText(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUIController riftChapterUIController = (RiftChapterUIController)LuaObject.checkSelf(l);
			Text progressNormalStarText;
			LuaObject.checkType<Text>(l, 2, out progressNormalStarText);
			riftChapterUIController.m_luaExportHelper.m_progressNormalStarText = progressNormalStarText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C42 RID: 134210 RVA: 0x00AF7B7C File Offset: 0x00AF5D7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_progressNormalAchievementText(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUIController riftChapterUIController = (RiftChapterUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftChapterUIController.m_luaExportHelper.m_progressNormalAchievementText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C43 RID: 134211 RVA: 0x00AF7BD4 File Offset: 0x00AF5DD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_progressNormalAchievementText(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUIController riftChapterUIController = (RiftChapterUIController)LuaObject.checkSelf(l);
			Text progressNormalAchievementText;
			LuaObject.checkType<Text>(l, 2, out progressNormalAchievementText);
			riftChapterUIController.m_luaExportHelper.m_progressNormalAchievementText = progressNormalAchievementText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C44 RID: 134212 RVA: 0x00AF7C30 File Offset: 0x00AF5E30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_progressNormalTreasureText(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUIController riftChapterUIController = (RiftChapterUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftChapterUIController.m_luaExportHelper.m_progressNormalTreasureText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C45 RID: 134213 RVA: 0x00AF7C88 File Offset: 0x00AF5E88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_progressNormalTreasureText(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUIController riftChapterUIController = (RiftChapterUIController)LuaObject.checkSelf(l);
			Text progressNormalTreasureText;
			LuaObject.checkType<Text>(l, 2, out progressNormalTreasureText);
			riftChapterUIController.m_luaExportHelper.m_progressNormalTreasureText = progressNormalTreasureText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C46 RID: 134214 RVA: 0x00AF7CE4 File Offset: 0x00AF5EE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_progressHardStarText(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUIController riftChapterUIController = (RiftChapterUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftChapterUIController.m_luaExportHelper.m_progressHardStarText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C47 RID: 134215 RVA: 0x00AF7D3C File Offset: 0x00AF5F3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_progressHardStarText(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUIController riftChapterUIController = (RiftChapterUIController)LuaObject.checkSelf(l);
			Text progressHardStarText;
			LuaObject.checkType<Text>(l, 2, out progressHardStarText);
			riftChapterUIController.m_luaExportHelper.m_progressHardStarText = progressHardStarText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C48 RID: 134216 RVA: 0x00AF7D98 File Offset: 0x00AF5F98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_progressHardAchievementText(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUIController riftChapterUIController = (RiftChapterUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftChapterUIController.m_luaExportHelper.m_progressHardAchievementText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C49 RID: 134217 RVA: 0x00AF7DF0 File Offset: 0x00AF5FF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_progressHardAchievementText(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUIController riftChapterUIController = (RiftChapterUIController)LuaObject.checkSelf(l);
			Text progressHardAchievementText;
			LuaObject.checkType<Text>(l, 2, out progressHardAchievementText);
			riftChapterUIController.m_luaExportHelper.m_progressHardAchievementText = progressHardAchievementText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C4A RID: 134218 RVA: 0x00AF7E4C File Offset: 0x00AF604C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_progressHardTreasureText(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUIController riftChapterUIController = (RiftChapterUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftChapterUIController.m_luaExportHelper.m_progressHardTreasureText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C4B RID: 134219 RVA: 0x00AF7EA4 File Offset: 0x00AF60A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_progressHardTreasureText(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUIController riftChapterUIController = (RiftChapterUIController)LuaObject.checkSelf(l);
			Text progressHardTreasureText;
			LuaObject.checkType<Text>(l, 2, out progressHardTreasureText);
			riftChapterUIController.m_luaExportHelper.m_progressHardTreasureText = progressHardTreasureText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C4C RID: 134220 RVA: 0x00AF7F00 File Offset: 0x00AF6100
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_prefabsGameObject(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUIController riftChapterUIController = (RiftChapterUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftChapterUIController.m_luaExportHelper.m_prefabsGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C4D RID: 134221 RVA: 0x00AF7F58 File Offset: 0x00AF6158
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_prefabsGameObject(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUIController riftChapterUIController = (RiftChapterUIController)LuaObject.checkSelf(l);
			GameObject prefabsGameObject;
			LuaObject.checkType<GameObject>(l, 2, out prefabsGameObject);
			riftChapterUIController.m_luaExportHelper.m_prefabsGameObject = prefabsGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C4E RID: 134222 RVA: 0x00AF7FB4 File Offset: 0x00AF61B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_riftChapterButtonPrefab(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUIController riftChapterUIController = (RiftChapterUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftChapterUIController.m_luaExportHelper.m_riftChapterButtonPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C4F RID: 134223 RVA: 0x00AF800C File Offset: 0x00AF620C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_riftChapterButtonPrefab(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUIController riftChapterUIController = (RiftChapterUIController)LuaObject.checkSelf(l);
			GameObject riftChapterButtonPrefab;
			LuaObject.checkType<GameObject>(l, 2, out riftChapterButtonPrefab);
			riftChapterUIController.m_luaExportHelper.m_riftChapterButtonPrefab = riftChapterButtonPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C50 RID: 134224 RVA: 0x00AF8068 File Offset: 0x00AF6268
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_riftChapterUnlockConditionItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUIController riftChapterUIController = (RiftChapterUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftChapterUIController.m_luaExportHelper.m_riftChapterUnlockConditionItemPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C51 RID: 134225 RVA: 0x00AF80C0 File Offset: 0x00AF62C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_riftChapterUnlockConditionItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUIController riftChapterUIController = (RiftChapterUIController)LuaObject.checkSelf(l);
			GameObject riftChapterUnlockConditionItemPrefab;
			LuaObject.checkType<GameObject>(l, 2, out riftChapterUnlockConditionItemPrefab);
			riftChapterUIController.m_luaExportHelper.m_riftChapterUnlockConditionItemPrefab = riftChapterUnlockConditionItemPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C52 RID: 134226 RVA: 0x00AF811C File Offset: 0x00AF631C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_chapterButtons(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUIController riftChapterUIController = (RiftChapterUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftChapterUIController.m_luaExportHelper.m_chapterButtons);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C53 RID: 134227 RVA: 0x00AF8174 File Offset: 0x00AF6374
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_chapterButtons(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUIController riftChapterUIController = (RiftChapterUIController)LuaObject.checkSelf(l);
			List<RiftChapterButton> chapterButtons;
			LuaObject.checkType<List<RiftChapterButton>>(l, 2, out chapterButtons);
			riftChapterUIController.m_luaExportHelper.m_chapterButtons = chapterButtons;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C54 RID: 134228 RVA: 0x00AF81D0 File Offset: 0x00AF63D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_riftChapterUnlockConditionItems(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUIController riftChapterUIController = (RiftChapterUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftChapterUIController.m_luaExportHelper.m_riftChapterUnlockConditionItems);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C55 RID: 134229 RVA: 0x00AF8228 File Offset: 0x00AF6428
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_riftChapterUnlockConditionItems(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUIController riftChapterUIController = (RiftChapterUIController)LuaObject.checkSelf(l);
			List<RiftChapterUnlockConditionItemUIController> riftChapterUnlockConditionItems;
			LuaObject.checkType<List<RiftChapterUnlockConditionItemUIController>>(l, 2, out riftChapterUnlockConditionItems);
			riftChapterUIController.m_luaExportHelper.m_riftChapterUnlockConditionItems = riftChapterUnlockConditionItems;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C56 RID: 134230 RVA: 0x00AF8284 File Offset: 0x00AF6484
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_curChapterIndex(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUIController riftChapterUIController = (RiftChapterUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftChapterUIController.m_luaExportHelper.m_curChapterIndex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C57 RID: 134231 RVA: 0x00AF82DC File Offset: 0x00AF64DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_curChapterIndex(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUIController riftChapterUIController = (RiftChapterUIController)LuaObject.checkSelf(l);
			int curChapterIndex;
			LuaObject.checkType(l, 2, out curChapterIndex);
			riftChapterUIController.m_luaExportHelper.m_curChapterIndex = curChapterIndex;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C58 RID: 134232 RVA: 0x00AF8338 File Offset: 0x00AF6538
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_chaptersScrollSnapCenter(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUIController riftChapterUIController = (RiftChapterUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftChapterUIController.m_luaExportHelper.m_chaptersScrollSnapCenter);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C59 RID: 134233 RVA: 0x00AF8390 File Offset: 0x00AF6590
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_chaptersScrollSnapCenter(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUIController riftChapterUIController = (RiftChapterUIController)LuaObject.checkSelf(l);
			ScrollSnapCenter chaptersScrollSnapCenter;
			LuaObject.checkType<ScrollSnapCenter>(l, 2, out chaptersScrollSnapCenter);
			riftChapterUIController.m_luaExportHelper.m_chaptersScrollSnapCenter = chaptersScrollSnapCenter;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C5A RID: 134234 RVA: 0x00AF83EC File Offset: 0x00AF65EC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.RiftChapterUIController");
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUIController.Open);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUIController.ClearChapterButtons);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUIController.AddChapterButton);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUIController.SetCurrentChapter);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUIController.ShowChapterProgress);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUIController.SetChapterUnlockConditionClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUIController.HideChapterProgress);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUIController.ShowChapterUnlockConditions);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUIController.LateUpdate);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUIController.OnUnlockConditionBGButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUIController.ClearRiftLevelUnlockContitionItems);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUIController.HideChapterUnlockConditions);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUIController.OnReturnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUIController.OnHelpButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUIController.OnWorldButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUIController.OnChapterButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUIController.__callDele_EventOnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUIController.__clearDele_EventOnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUIController.__callDele_EventOnShowHelp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUIController.__clearDele_EventOnShowHelp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUIController.__callDele_EventOnReturnToWorld);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUIController.__clearDele_EventOnReturnToWorld);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUIController.__callDele_EventOnSelectChapter);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUIController.__clearDele_EventOnSelectChapter);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUIController.__callDele_EventOnSwitchChapter);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUIController.__clearDele_EventOnSwitchChapter);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUIController.__callDele_EventOnGoToScenario);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUIController.__clearDele_EventOnGoToScenario);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache29);
		string name = "EventOnReturn";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUIController.set_EventOnReturn);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache2A, true);
		string name2 = "EventOnShowHelp";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUIController.set_EventOnShowHelp);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache2B, true);
		string name3 = "EventOnReturnToWorld";
		LuaCSFunction get3 = null;
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUIController.set_EventOnReturnToWorld);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache2C, true);
		string name4 = "EventOnSelectChapter";
		LuaCSFunction get4 = null;
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUIController.set_EventOnSelectChapter);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache2D, true);
		string name5 = "EventOnSwitchChapter";
		LuaCSFunction get5 = null;
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUIController.set_EventOnSwitchChapter);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache2E, true);
		string name6 = "EventOnGoToScenario";
		LuaCSFunction get6 = null;
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUIController.set_EventOnGoToScenario);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache2F, true);
		string name7 = "m_uiStateController";
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUIController.get_m_uiStateController);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache30;
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUIController.set_m_uiStateController);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache31, true);
		string name8 = "m_marginTransform";
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUIController.get_m_marginTransform);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache32;
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUIController.set_m_marginTransform);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache33, true);
		string name9 = "m_returnButton";
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUIController.get_m_returnButton);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache34;
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUIController.set_m_returnButton);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache35, true);
		string name10 = "m_helpButton";
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUIController.get_m_helpButton);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache36;
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUIController.set_m_helpButton);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache37, true);
		string name11 = "m_worldButton";
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUIController.get_m_worldButton);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache38;
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUIController.set_m_worldButton);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache39, true);
		string name12 = "m_chaptersScrollRect";
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUIController.get_m_chaptersScrollRect);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache3A;
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUIController.set_m_chaptersScrollRect);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache3B, true);
		string name13 = "m_unlockConditionUIStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUIController.get_m_unlockConditionUIStateCtrl);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache3C;
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUIController.set_m_unlockConditionUIStateCtrl);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache3D, true);
		string name14 = "m_unlockConditionGameObject";
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUIController.get_m_unlockConditionGameObject);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache3E;
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUIController.set_m_unlockConditionGameObject);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache3F, true);
		string name15 = "m_unlockConditionGroup";
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUIController.get_m_unlockConditionGroup);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache40;
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUIController.set_m_unlockConditionGroup);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache41, true);
		string name16 = "m_unlockConditionBGButton";
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUIController.get_m_unlockConditionBGButton);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache42;
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUIController.set_m_unlockConditionBGButton);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache43, true);
		string name17 = "m_progressGameObject";
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUIController.get_m_progressGameObject);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache44;
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUIController.set_m_progressGameObject);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache45, true);
		string name18 = "m_progressTitleText";
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUIController.get_m_progressTitleText);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache46;
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUIController.set_m_progressTitleText);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache47, true);
		string name19 = "m_progressNameText";
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUIController.get_m_progressNameText);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache48;
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUIController.set_m_progressNameText);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache49, true);
		string name20 = "m_progressPlaceText";
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUIController.get_m_progressPlaceText);
		}
		LuaCSFunction get20 = Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache4A;
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUIController.set_m_progressPlaceText);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache4B, true);
		string name21 = "m_progressNormalStarText";
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUIController.get_m_progressNormalStarText);
		}
		LuaCSFunction get21 = Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache4C;
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUIController.set_m_progressNormalStarText);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache4D, true);
		string name22 = "m_progressNormalAchievementText";
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUIController.get_m_progressNormalAchievementText);
		}
		LuaCSFunction get22 = Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache4E;
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUIController.set_m_progressNormalAchievementText);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache4F, true);
		string name23 = "m_progressNormalTreasureText";
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUIController.get_m_progressNormalTreasureText);
		}
		LuaCSFunction get23 = Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache50;
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUIController.set_m_progressNormalTreasureText);
		}
		LuaObject.addMember(l, name23, get23, Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache51, true);
		string name24 = "m_progressHardStarText";
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUIController.get_m_progressHardStarText);
		}
		LuaCSFunction get24 = Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache52;
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUIController.set_m_progressHardStarText);
		}
		LuaObject.addMember(l, name24, get24, Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache53, true);
		string name25 = "m_progressHardAchievementText";
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUIController.get_m_progressHardAchievementText);
		}
		LuaCSFunction get25 = Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache54;
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache55 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache55 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUIController.set_m_progressHardAchievementText);
		}
		LuaObject.addMember(l, name25, get25, Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache55, true);
		string name26 = "m_progressHardTreasureText";
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache56 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache56 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUIController.get_m_progressHardTreasureText);
		}
		LuaCSFunction get26 = Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache56;
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache57 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache57 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUIController.set_m_progressHardTreasureText);
		}
		LuaObject.addMember(l, name26, get26, Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache57, true);
		string name27 = "m_prefabsGameObject";
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache58 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache58 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUIController.get_m_prefabsGameObject);
		}
		LuaCSFunction get27 = Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache58;
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache59 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache59 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUIController.set_m_prefabsGameObject);
		}
		LuaObject.addMember(l, name27, get27, Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache59, true);
		string name28 = "m_riftChapterButtonPrefab";
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache5A == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache5A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUIController.get_m_riftChapterButtonPrefab);
		}
		LuaCSFunction get28 = Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache5A;
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache5B == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache5B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUIController.set_m_riftChapterButtonPrefab);
		}
		LuaObject.addMember(l, name28, get28, Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache5B, true);
		string name29 = "m_riftChapterUnlockConditionItemPrefab";
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache5C == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache5C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUIController.get_m_riftChapterUnlockConditionItemPrefab);
		}
		LuaCSFunction get29 = Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache5C;
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache5D == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache5D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUIController.set_m_riftChapterUnlockConditionItemPrefab);
		}
		LuaObject.addMember(l, name29, get29, Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache5D, true);
		string name30 = "m_chapterButtons";
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache5E == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache5E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUIController.get_m_chapterButtons);
		}
		LuaCSFunction get30 = Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache5E;
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache5F == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache5F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUIController.set_m_chapterButtons);
		}
		LuaObject.addMember(l, name30, get30, Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache5F, true);
		string name31 = "m_riftChapterUnlockConditionItems";
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache60 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache60 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUIController.get_m_riftChapterUnlockConditionItems);
		}
		LuaCSFunction get31 = Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache60;
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache61 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache61 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUIController.set_m_riftChapterUnlockConditionItems);
		}
		LuaObject.addMember(l, name31, get31, Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache61, true);
		string name32 = "m_curChapterIndex";
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache62 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache62 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUIController.get_m_curChapterIndex);
		}
		LuaCSFunction get32 = Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache62;
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache63 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache63 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUIController.set_m_curChapterIndex);
		}
		LuaObject.addMember(l, name32, get32, Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache63, true);
		string name33 = "m_chaptersScrollSnapCenter";
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache64 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache64 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUIController.get_m_chaptersScrollSnapCenter);
		}
		LuaCSFunction get33 = Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache64;
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache65 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache65 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUIController.set_m_chaptersScrollSnapCenter);
		}
		LuaObject.addMember(l, name33, get33, Lua_BlackJack_ProjectL_UI_RiftChapterUIController.<>f__mg$cache65, true);
		LuaObject.createTypeMetatable(l, null, typeof(RiftChapterUIController), typeof(UIControllerBase));
	}

	// Token: 0x04016B14 RID: 92948
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04016B15 RID: 92949
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04016B16 RID: 92950
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04016B17 RID: 92951
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04016B18 RID: 92952
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04016B19 RID: 92953
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04016B1A RID: 92954
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04016B1B RID: 92955
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04016B1C RID: 92956
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04016B1D RID: 92957
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04016B1E RID: 92958
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04016B1F RID: 92959
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04016B20 RID: 92960
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04016B21 RID: 92961
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04016B22 RID: 92962
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04016B23 RID: 92963
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04016B24 RID: 92964
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04016B25 RID: 92965
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04016B26 RID: 92966
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04016B27 RID: 92967
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04016B28 RID: 92968
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04016B29 RID: 92969
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04016B2A RID: 92970
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04016B2B RID: 92971
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04016B2C RID: 92972
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04016B2D RID: 92973
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04016B2E RID: 92974
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04016B2F RID: 92975
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04016B30 RID: 92976
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04016B31 RID: 92977
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04016B32 RID: 92978
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04016B33 RID: 92979
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04016B34 RID: 92980
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04016B35 RID: 92981
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04016B36 RID: 92982
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04016B37 RID: 92983
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04016B38 RID: 92984
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04016B39 RID: 92985
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04016B3A RID: 92986
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04016B3B RID: 92987
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04016B3C RID: 92988
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04016B3D RID: 92989
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04016B3E RID: 92990
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04016B3F RID: 92991
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04016B40 RID: 92992
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04016B41 RID: 92993
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04016B42 RID: 92994
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04016B43 RID: 92995
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04016B44 RID: 92996
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04016B45 RID: 92997
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04016B46 RID: 92998
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04016B47 RID: 92999
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04016B48 RID: 93000
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04016B49 RID: 93001
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04016B4A RID: 93002
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04016B4B RID: 93003
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04016B4C RID: 93004
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04016B4D RID: 93005
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04016B4E RID: 93006
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x04016B4F RID: 93007
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x04016B50 RID: 93008
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x04016B51 RID: 93009
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x04016B52 RID: 93010
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x04016B53 RID: 93011
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x04016B54 RID: 93012
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x04016B55 RID: 93013
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x04016B56 RID: 93014
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x04016B57 RID: 93015
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x04016B58 RID: 93016
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x04016B59 RID: 93017
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x04016B5A RID: 93018
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x04016B5B RID: 93019
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x04016B5C RID: 93020
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x04016B5D RID: 93021
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x04016B5E RID: 93022
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x04016B5F RID: 93023
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x04016B60 RID: 93024
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x04016B61 RID: 93025
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x04016B62 RID: 93026
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x04016B63 RID: 93027
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x04016B64 RID: 93028
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x04016B65 RID: 93029
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x04016B66 RID: 93030
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x04016B67 RID: 93031
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x04016B68 RID: 93032
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x04016B69 RID: 93033
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x04016B6A RID: 93034
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x04016B6B RID: 93035
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x04016B6C RID: 93036
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x04016B6D RID: 93037
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;

	// Token: 0x04016B6E RID: 93038
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5A;

	// Token: 0x04016B6F RID: 93039
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5B;

	// Token: 0x04016B70 RID: 93040
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5C;

	// Token: 0x04016B71 RID: 93041
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5D;

	// Token: 0x04016B72 RID: 93042
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5E;

	// Token: 0x04016B73 RID: 93043
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5F;

	// Token: 0x04016B74 RID: 93044
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache60;

	// Token: 0x04016B75 RID: 93045
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache61;

	// Token: 0x04016B76 RID: 93046
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache62;

	// Token: 0x04016B77 RID: 93047
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache63;

	// Token: 0x04016B78 RID: 93048
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache64;

	// Token: 0x04016B79 RID: 93049
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache65;
}
