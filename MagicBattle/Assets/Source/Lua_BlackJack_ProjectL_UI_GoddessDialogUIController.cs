using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x0200146B RID: 5227
[Preserve]
public class Lua_BlackJack_ProjectL_UI_GoddessDialogUIController : LuaObject
{
	// Token: 0x0601E2E4 RID: 123620 RVA: 0x009AF954 File Offset: 0x009ADB54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateChar(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			ConfigDataCharImageInfo charImageInfo;
			LuaObject.checkType<ConfigDataCharImageInfo>(l, 2, out charImageInfo);
			goddessDialogUIController.CreateChar(charImageInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E2E5 RID: 123621 RVA: 0x009AF9AC File Offset: 0x009ADBAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetDialog(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			ConfigDataGoddessDialogInfo dialog;
			LuaObject.checkType<ConfigDataGoddessDialogInfo>(l, 2, out dialog);
			goddessDialogUIController.SetDialog(dialog);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E2E6 RID: 123622 RVA: 0x009AFA04 File Offset: 0x009ADC04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CloseDialog(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			goddessDialogUIController.CloseDialog();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E2E7 RID: 123623 RVA: 0x009AFA50 File Offset: 0x009ADC50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowJobs(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			ConfigDataHeroInfo heroInfo;
			LuaObject.checkType<ConfigDataHeroInfo>(l, 2, out heroInfo);
			List<ConfigDataJobConnectionInfo> jobConnectionInfos;
			LuaObject.checkType<List<ConfigDataJobConnectionInfo>>(l, 3, out jobConnectionInfos);
			bool hasPrev;
			LuaObject.checkType(l, 4, out hasPrev);
			bool hasNext;
			LuaObject.checkType(l, 5, out hasNext);
			goddessDialogUIController.ShowJobs(heroInfo, jobConnectionInfos, hasPrev, hasNext);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E2E8 RID: 123624 RVA: 0x009AFAD0 File Offset: 0x009ADCD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HideJobConnections(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			goddessDialogUIController.HideJobConnections();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E2E9 RID: 123625 RVA: 0x009AFB1C File Offset: 0x009ADD1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Start(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			goddessDialogUIController.m_luaExportHelper.Start();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E2EA RID: 123626 RVA: 0x009AFB70 File Offset: 0x009ADD70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			goddessDialogUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E2EB RID: 123627 RVA: 0x009AFBC4 File Offset: 0x009ADDC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Co_CloseDialog(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			IEnumerator o = goddessDialogUIController.m_luaExportHelper.Co_CloseDialog();
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

	// Token: 0x0601E2EC RID: 123628 RVA: 0x009AFC20 File Offset: 0x009ADE20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Co_ShowWords(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			float delay;
			LuaObject.checkType(l, 2, out delay);
			IEnumerator o = goddessDialogUIController.m_luaExportHelper.Co_ShowWords(delay);
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

	// Token: 0x0601E2ED RID: 123629 RVA: 0x009AFC88 File Offset: 0x009ADE88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowChoice(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			goddessDialogUIController.m_luaExportHelper.ShowChoice();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E2EE RID: 123630 RVA: 0x009AFCDC File Offset: 0x009ADEDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Co_DoChoice(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			int idx;
			LuaObject.checkType(l, 2, out idx);
			IEnumerator o = goddessDialogUIController.m_luaExportHelper.Co_DoChoice(idx);
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

	// Token: 0x0601E2EF RID: 123631 RVA: 0x009AFD44 File Offset: 0x009ADF44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Co_WaitForSecondsOrClick(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			float time;
			LuaObject.checkType(l, 2, out time);
			IEnumerator o = goddessDialogUIController.m_luaExportHelper.Co_WaitForSecondsOrClick(time);
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

	// Token: 0x0601E2F0 RID: 123632 RVA: 0x009AFDAC File Offset: 0x009ADFAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Co_WaitForClick(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			IEnumerator o = goddessDialogUIController.m_luaExportHelper.Co_WaitForClick();
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

	// Token: 0x0601E2F1 RID: 123633 RVA: 0x009AFE08 File Offset: 0x009AE008
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Co_WaitForAllWordsDisplayed(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			IEnumerator o = goddessDialogUIController.m_luaExportHelper.Co_WaitForAllWordsDisplayed();
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

	// Token: 0x0601E2F2 RID: 123634 RVA: 0x009AFE64 File Offset: 0x009AE064
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HasChoice(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			bool b = goddessDialogUIController.m_luaExportHelper.HasChoice();
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

	// Token: 0x0601E2F3 RID: 123635 RVA: 0x009AFEC0 File Offset: 0x009AE0C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayVoice(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			IAudioPlayback o = goddessDialogUIController.m_luaExportHelper.PlayVoice(name);
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

	// Token: 0x0601E2F4 RID: 123636 RVA: 0x009AFF28 File Offset: 0x009AE128
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBackgroundButtonClick(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			goddessDialogUIController.m_luaExportHelper.OnBackgroundButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E2F5 RID: 123637 RVA: 0x009AFF7C File Offset: 0x009AE17C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnAcceptButtonClick(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			goddessDialogUIController.m_luaExportHelper.OnAcceptButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E2F6 RID: 123638 RVA: 0x009AFFD0 File Offset: 0x009AE1D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnRetryButtonClick(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			goddessDialogUIController.m_luaExportHelper.OnRetryButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E2F7 RID: 123639 RVA: 0x009B0024 File Offset: 0x009AE224
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnSelectButtonClick(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			goddessDialogUIController.m_luaExportHelper.OnSelectButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E2F8 RID: 123640 RVA: 0x009B0078 File Offset: 0x009AE278
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnConfirmButtonClick(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			goddessDialogUIController.m_luaExportHelper.OnConfirmButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E2F9 RID: 123641 RVA: 0x009B00CC File Offset: 0x009AE2CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnRetryButton2Click(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			goddessDialogUIController.m_luaExportHelper.OnRetryButton2Click();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E2FA RID: 123642 RVA: 0x009B0120 File Offset: 0x009AE320
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPrevButtonClick(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			goddessDialogUIController.m_luaExportHelper.OnPrevButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E2FB RID: 123643 RVA: 0x009B0174 File Offset: 0x009AE374
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnNextButtonClick(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			goddessDialogUIController.m_luaExportHelper.OnNextButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E2FC RID: 123644 RVA: 0x009B01C8 File Offset: 0x009AE3C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnChoiceButtonClick(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			GoddessDialogChoiceButton b;
			LuaObject.checkType<GoddessDialogChoiceButton>(l, 2, out b);
			goddessDialogUIController.m_luaExportHelper.OnChoiceButtonClick(b);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E2FD RID: 123645 RVA: 0x009B0224 File Offset: 0x009AE424
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnJobButtonClick(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			GoddessDialogJobButton b;
			LuaObject.checkType<GoddessDialogJobButton>(l, 2, out b);
			goddessDialogUIController.m_luaExportHelper.OnJobButtonClick(b);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E2FE RID: 123646 RVA: 0x009B0280 File Offset: 0x009AE480
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			goddessDialogUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E2FF RID: 123647 RVA: 0x009B02EC File Offset: 0x009AE4EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			goddessDialogUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E300 RID: 123648 RVA: 0x009B0340 File Offset: 0x009AE540
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			goddessDialogUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E301 RID: 123649 RVA: 0x009B0394 File Offset: 0x009AE594
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = goddessDialogUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601E302 RID: 123650 RVA: 0x009B043C File Offset: 0x009AE63C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			goddessDialogUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E303 RID: 123651 RVA: 0x009B0490 File Offset: 0x009AE690
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			goddessDialogUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E304 RID: 123652 RVA: 0x009B04FC File Offset: 0x009AE6FC
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
				GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				goddessDialogUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				GoddessDialogUIController goddessDialogUIController2 = (GoddessDialogUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				goddessDialogUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601E305 RID: 123653 RVA: 0x009B060C File Offset: 0x009AE80C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			goddessDialogUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E306 RID: 123654 RVA: 0x009B0678 File Offset: 0x009AE878
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			goddessDialogUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E307 RID: 123655 RVA: 0x009B06E4 File Offset: 0x009AE8E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			goddessDialogUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E308 RID: 123656 RVA: 0x009B0750 File Offset: 0x009AE950
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			goddessDialogUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E309 RID: 123657 RVA: 0x009B07BC File Offset: 0x009AE9BC
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
				GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				goddessDialogUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				GoddessDialogUIController goddessDialogUIController2 = (GoddessDialogUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				goddessDialogUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601E30A RID: 123658 RVA: 0x009B08CC File Offset: 0x009AEACC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			string s = goddessDialogUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601E30B RID: 123659 RVA: 0x009B0928 File Offset: 0x009AEB28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnNext(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			goddessDialogUIController.m_luaExportHelper.__callDele_EventOnNext();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E30C RID: 123660 RVA: 0x009B097C File Offset: 0x009AEB7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnNext(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			goddessDialogUIController.m_luaExportHelper.__clearDele_EventOnNext();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E30D RID: 123661 RVA: 0x009B09D0 File Offset: 0x009AEBD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			goddessDialogUIController.m_luaExportHelper.__callDele_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E30E RID: 123662 RVA: 0x009B0A24 File Offset: 0x009AEC24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			goddessDialogUIController.m_luaExportHelper.__clearDele_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E30F RID: 123663 RVA: 0x009B0A78 File Offset: 0x009AEC78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnChoose(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			goddessDialogUIController.m_luaExportHelper.__callDele_EventOnChoose(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E310 RID: 123664 RVA: 0x009B0AD4 File Offset: 0x009AECD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnChoose(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			goddessDialogUIController.m_luaExportHelper.__clearDele_EventOnChoose(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E311 RID: 123665 RVA: 0x009B0B30 File Offset: 0x009AED30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnShowJobInfo(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			ConfigDataJobConnectionInfo obj;
			LuaObject.checkType<ConfigDataJobConnectionInfo>(l, 2, out obj);
			goddessDialogUIController.m_luaExportHelper.__callDele_EventOnShowJobInfo(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E312 RID: 123666 RVA: 0x009B0B8C File Offset: 0x009AED8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnShowJobInfo(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			ConfigDataJobConnectionInfo obj;
			LuaObject.checkType<ConfigDataJobConnectionInfo>(l, 2, out obj);
			goddessDialogUIController.m_luaExportHelper.__clearDele_EventOnShowJobInfo(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E313 RID: 123667 RVA: 0x009B0BE8 File Offset: 0x009AEDE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnConfirmJob(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			goddessDialogUIController.m_luaExportHelper.__callDele_EventOnConfirmJob();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E314 RID: 123668 RVA: 0x009B0C3C File Offset: 0x009AEE3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnConfirmJob(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			goddessDialogUIController.m_luaExportHelper.__clearDele_EventOnConfirmJob();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E315 RID: 123669 RVA: 0x009B0C90 File Offset: 0x009AEE90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnRetry(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			goddessDialogUIController.m_luaExportHelper.__callDele_EventOnRetry();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E316 RID: 123670 RVA: 0x009B0CE4 File Offset: 0x009AEEE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnRetry(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			goddessDialogUIController.m_luaExportHelper.__clearDele_EventOnRetry();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E317 RID: 123671 RVA: 0x009B0D38 File Offset: 0x009AEF38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnSelectJob(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			goddessDialogUIController.m_luaExportHelper.__callDele_EventOnSelectJob();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E318 RID: 123672 RVA: 0x009B0D8C File Offset: 0x009AEF8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnSelectJob(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			goddessDialogUIController.m_luaExportHelper.__clearDele_EventOnSelectJob();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E319 RID: 123673 RVA: 0x009B0DE0 File Offset: 0x009AEFE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnPrevJob(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			goddessDialogUIController.m_luaExportHelper.__callDele_EventOnPrevJob();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E31A RID: 123674 RVA: 0x009B0E34 File Offset: 0x009AF034
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnPrevJob(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			goddessDialogUIController.m_luaExportHelper.__clearDele_EventOnPrevJob();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E31B RID: 123675 RVA: 0x009B0E88 File Offset: 0x009AF088
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnNextJob(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			goddessDialogUIController.m_luaExportHelper.__callDele_EventOnNextJob();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E31C RID: 123676 RVA: 0x009B0EDC File Offset: 0x009AF0DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnNextJob(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			goddessDialogUIController.m_luaExportHelper.__clearDele_EventOnNextJob();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E31D RID: 123677 RVA: 0x009B0F30 File Offset: 0x009AF130
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnNext(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					goddessDialogUIController.EventOnNext += value;
				}
				else if (num == 2)
				{
					goddessDialogUIController.EventOnNext -= value;
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

	// Token: 0x0601E31E RID: 123678 RVA: 0x009B0FB0 File Offset: 0x009AF1B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					goddessDialogUIController.EventOnClose += value;
				}
				else if (num == 2)
				{
					goddessDialogUIController.EventOnClose -= value;
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

	// Token: 0x0601E31F RID: 123679 RVA: 0x009B1030 File Offset: 0x009AF230
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnChoose(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			Action<int> value;
			int num = LuaObject.checkDelegate<Action<int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					goddessDialogUIController.EventOnChoose += value;
				}
				else if (num == 2)
				{
					goddessDialogUIController.EventOnChoose -= value;
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

	// Token: 0x0601E320 RID: 123680 RVA: 0x009B10B0 File Offset: 0x009AF2B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnShowJobInfo(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			Action<ConfigDataJobConnectionInfo> value;
			int num = LuaObject.checkDelegate<Action<ConfigDataJobConnectionInfo>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					goddessDialogUIController.EventOnShowJobInfo += value;
				}
				else if (num == 2)
				{
					goddessDialogUIController.EventOnShowJobInfo -= value;
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

	// Token: 0x0601E321 RID: 123681 RVA: 0x009B1130 File Offset: 0x009AF330
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnConfirmJob(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					goddessDialogUIController.EventOnConfirmJob += value;
				}
				else if (num == 2)
				{
					goddessDialogUIController.EventOnConfirmJob -= value;
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

	// Token: 0x0601E322 RID: 123682 RVA: 0x009B11B0 File Offset: 0x009AF3B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnRetry(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					goddessDialogUIController.EventOnRetry += value;
				}
				else if (num == 2)
				{
					goddessDialogUIController.EventOnRetry -= value;
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

	// Token: 0x0601E323 RID: 123683 RVA: 0x009B1230 File Offset: 0x009AF430
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnSelectJob(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					goddessDialogUIController.EventOnSelectJob += value;
				}
				else if (num == 2)
				{
					goddessDialogUIController.EventOnSelectJob -= value;
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

	// Token: 0x0601E324 RID: 123684 RVA: 0x009B12B0 File Offset: 0x009AF4B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnPrevJob(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					goddessDialogUIController.EventOnPrevJob += value;
				}
				else if (num == 2)
				{
					goddessDialogUIController.EventOnPrevJob -= value;
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

	// Token: 0x0601E325 RID: 123685 RVA: 0x009B1330 File Offset: 0x009AF530
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnNextJob(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					goddessDialogUIController.EventOnNextJob += value;
				}
				else if (num == 2)
				{
					goddessDialogUIController.EventOnNextJob -= value;
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

	// Token: 0x0601E326 RID: 123686 RVA: 0x009B13B0 File Offset: 0x009AF5B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_backgroundButton(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, goddessDialogUIController.m_luaExportHelper.m_backgroundButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E327 RID: 123687 RVA: 0x009B1408 File Offset: 0x009AF608
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_backgroundButton(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			Button backgroundButton;
			LuaObject.checkType<Button>(l, 2, out backgroundButton);
			goddessDialogUIController.m_luaExportHelper.m_backgroundButton = backgroundButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E328 RID: 123688 RVA: 0x009B1464 File Offset: 0x009AF664
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_wordsGameObject(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, goddessDialogUIController.m_luaExportHelper.m_wordsGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E329 RID: 123689 RVA: 0x009B14BC File Offset: 0x009AF6BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_wordsGameObject(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			GameObject wordsGameObject;
			LuaObject.checkType<GameObject>(l, 2, out wordsGameObject);
			goddessDialogUIController.m_luaExportHelper.m_wordsGameObject = wordsGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E32A RID: 123690 RVA: 0x009B1518 File Offset: 0x009AF718
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_charGameObject(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, goddessDialogUIController.m_luaExportHelper.m_charGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E32B RID: 123691 RVA: 0x009B1570 File Offset: 0x009AF770
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_charGameObject(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			GameObject charGameObject;
			LuaObject.checkType<GameObject>(l, 2, out charGameObject);
			goddessDialogUIController.m_luaExportHelper.m_charGameObject = charGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E32C RID: 123692 RVA: 0x009B15CC File Offset: 0x009AF7CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_choiceUIStateController(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, goddessDialogUIController.m_luaExportHelper.m_choiceUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E32D RID: 123693 RVA: 0x009B1624 File Offset: 0x009AF824
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_choiceUIStateController(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			CommonUIStateController choiceUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out choiceUIStateController);
			goddessDialogUIController.m_luaExportHelper.m_choiceUIStateController = choiceUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E32E RID: 123694 RVA: 0x009B1680 File Offset: 0x009AF880
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_choice1GameObject(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, goddessDialogUIController.m_luaExportHelper.m_choice1GameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E32F RID: 123695 RVA: 0x009B16D8 File Offset: 0x009AF8D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_choice1GameObject(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			GameObject choice1GameObject;
			LuaObject.checkType<GameObject>(l, 2, out choice1GameObject);
			goddessDialogUIController.m_luaExportHelper.m_choice1GameObject = choice1GameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E330 RID: 123696 RVA: 0x009B1734 File Offset: 0x009AF934
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_choice2GameObject(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, goddessDialogUIController.m_luaExportHelper.m_choice2GameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E331 RID: 123697 RVA: 0x009B178C File Offset: 0x009AF98C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_choice2GameObject(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			GameObject choice2GameObject;
			LuaObject.checkType<GameObject>(l, 2, out choice2GameObject);
			goddessDialogUIController.m_luaExportHelper.m_choice2GameObject = choice2GameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E332 RID: 123698 RVA: 0x009B17E8 File Offset: 0x009AF9E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_choice3GameObject(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, goddessDialogUIController.m_luaExportHelper.m_choice3GameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E333 RID: 123699 RVA: 0x009B1840 File Offset: 0x009AFA40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_choice3GameObject(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			GameObject choice3GameObject;
			LuaObject.checkType<GameObject>(l, 2, out choice3GameObject);
			goddessDialogUIController.m_luaExportHelper.m_choice3GameObject = choice3GameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E334 RID: 123700 RVA: 0x009B189C File Offset: 0x009AFA9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_jobGameObject(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, goddessDialogUIController.m_luaExportHelper.m_jobGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E335 RID: 123701 RVA: 0x009B18F4 File Offset: 0x009AFAF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_jobGameObject(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			GameObject jobGameObject;
			LuaObject.checkType<GameObject>(l, 2, out jobGameObject);
			goddessDialogUIController.m_luaExportHelper.m_jobGameObject = jobGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E336 RID: 123702 RVA: 0x009B1950 File Offset: 0x009AFB50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_jobUIStateController(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, goddessDialogUIController.m_luaExportHelper.m_jobUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E337 RID: 123703 RVA: 0x009B19A8 File Offset: 0x009AFBA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_jobUIStateController(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			CommonUIStateController jobUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out jobUIStateController);
			goddessDialogUIController.m_luaExportHelper.m_jobUIStateController = jobUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E338 RID: 123704 RVA: 0x009B1A04 File Offset: 0x009AFC04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroIconImage(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, goddessDialogUIController.m_luaExportHelper.m_heroIconImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E339 RID: 123705 RVA: 0x009B1A5C File Offset: 0x009AFC5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroIconImage(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			Image heroIconImage;
			LuaObject.checkType<Image>(l, 2, out heroIconImage);
			goddessDialogUIController.m_luaExportHelper.m_heroIconImage = heroIconImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E33A RID: 123706 RVA: 0x009B1AB8 File Offset: 0x009AFCB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroNameText(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, goddessDialogUIController.m_luaExportHelper.m_heroNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E33B RID: 123707 RVA: 0x009B1B10 File Offset: 0x009AFD10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroNameText(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			Text heroNameText;
			LuaObject.checkType<Text>(l, 2, out heroNameText);
			goddessDialogUIController.m_luaExportHelper.m_heroNameText = heroNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E33C RID: 123708 RVA: 0x009B1B6C File Offset: 0x009AFD6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_job1GameObject(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, goddessDialogUIController.m_luaExportHelper.m_job1GameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E33D RID: 123709 RVA: 0x009B1BC4 File Offset: 0x009AFDC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_job1GameObject(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			GameObject job1GameObject;
			LuaObject.checkType<GameObject>(l, 2, out job1GameObject);
			goddessDialogUIController.m_luaExportHelper.m_job1GameObject = job1GameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E33E RID: 123710 RVA: 0x009B1C20 File Offset: 0x009AFE20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_job2GameObject(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, goddessDialogUIController.m_luaExportHelper.m_job2GameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E33F RID: 123711 RVA: 0x009B1C78 File Offset: 0x009AFE78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_job2GameObject(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			GameObject job2GameObject;
			LuaObject.checkType<GameObject>(l, 2, out job2GameObject);
			goddessDialogUIController.m_luaExportHelper.m_job2GameObject = job2GameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E340 RID: 123712 RVA: 0x009B1CD4 File Offset: 0x009AFED4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_jobButtonGroup1GameObject(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, goddessDialogUIController.m_luaExportHelper.m_jobButtonGroup1GameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E341 RID: 123713 RVA: 0x009B1D2C File Offset: 0x009AFF2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_jobButtonGroup1GameObject(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			GameObject jobButtonGroup1GameObject;
			LuaObject.checkType<GameObject>(l, 2, out jobButtonGroup1GameObject);
			goddessDialogUIController.m_luaExportHelper.m_jobButtonGroup1GameObject = jobButtonGroup1GameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E342 RID: 123714 RVA: 0x009B1D88 File Offset: 0x009AFF88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_acceptButton(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, goddessDialogUIController.m_luaExportHelper.m_acceptButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E343 RID: 123715 RVA: 0x009B1DE0 File Offset: 0x009AFFE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_acceptButton(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			Button acceptButton;
			LuaObject.checkType<Button>(l, 2, out acceptButton);
			goddessDialogUIController.m_luaExportHelper.m_acceptButton = acceptButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E344 RID: 123716 RVA: 0x009B1E3C File Offset: 0x009B003C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_retryButton(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, goddessDialogUIController.m_luaExportHelper.m_retryButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E345 RID: 123717 RVA: 0x009B1E94 File Offset: 0x009B0094
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_retryButton(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			Button retryButton;
			LuaObject.checkType<Button>(l, 2, out retryButton);
			goddessDialogUIController.m_luaExportHelper.m_retryButton = retryButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E346 RID: 123718 RVA: 0x009B1EF0 File Offset: 0x009B00F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_selectButton(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, goddessDialogUIController.m_luaExportHelper.m_selectButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E347 RID: 123719 RVA: 0x009B1F48 File Offset: 0x009B0148
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_selectButton(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			Button selectButton;
			LuaObject.checkType<Button>(l, 2, out selectButton);
			goddessDialogUIController.m_luaExportHelper.m_selectButton = selectButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E348 RID: 123720 RVA: 0x009B1FA4 File Offset: 0x009B01A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_jobButtonGroup2GameObject(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, goddessDialogUIController.m_luaExportHelper.m_jobButtonGroup2GameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E349 RID: 123721 RVA: 0x009B1FFC File Offset: 0x009B01FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_jobButtonGroup2GameObject(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			GameObject jobButtonGroup2GameObject;
			LuaObject.checkType<GameObject>(l, 2, out jobButtonGroup2GameObject);
			goddessDialogUIController.m_luaExportHelper.m_jobButtonGroup2GameObject = jobButtonGroup2GameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E34A RID: 123722 RVA: 0x009B2058 File Offset: 0x009B0258
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_confirmButton(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, goddessDialogUIController.m_luaExportHelper.m_confirmButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E34B RID: 123723 RVA: 0x009B20B0 File Offset: 0x009B02B0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_confirmButton(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			Button confirmButton;
			LuaObject.checkType<Button>(l, 2, out confirmButton);
			goddessDialogUIController.m_luaExportHelper.m_confirmButton = confirmButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E34C RID: 123724 RVA: 0x009B210C File Offset: 0x009B030C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_retryButton2(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, goddessDialogUIController.m_luaExportHelper.m_retryButton2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E34D RID: 123725 RVA: 0x009B2164 File Offset: 0x009B0364
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_retryButton2(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			Button retryButton;
			LuaObject.checkType<Button>(l, 2, out retryButton);
			goddessDialogUIController.m_luaExportHelper.m_retryButton2 = retryButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E34E RID: 123726 RVA: 0x009B21C0 File Offset: 0x009B03C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_prevButton(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, goddessDialogUIController.m_luaExportHelper.m_prevButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E34F RID: 123727 RVA: 0x009B2218 File Offset: 0x009B0418
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_prevButton(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			Button prevButton;
			LuaObject.checkType<Button>(l, 2, out prevButton);
			goddessDialogUIController.m_luaExportHelper.m_prevButton = prevButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E350 RID: 123728 RVA: 0x009B2274 File Offset: 0x009B0474
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_nextButton(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, goddessDialogUIController.m_luaExportHelper.m_nextButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E351 RID: 123729 RVA: 0x009B22CC File Offset: 0x009B04CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_nextButton(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			Button nextButton;
			LuaObject.checkType<Button>(l, 2, out nextButton);
			goddessDialogUIController.m_luaExportHelper.m_nextButton = nextButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E352 RID: 123730 RVA: 0x009B2328 File Offset: 0x009B0528
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_prefabsGameObject(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, goddessDialogUIController.m_luaExportHelper.m_prefabsGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E353 RID: 123731 RVA: 0x009B2380 File Offset: 0x009B0580
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_prefabsGameObject(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			GameObject prefabsGameObject;
			LuaObject.checkType<GameObject>(l, 2, out prefabsGameObject);
			goddessDialogUIController.m_luaExportHelper.m_prefabsGameObject = prefabsGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E354 RID: 123732 RVA: 0x009B23DC File Offset: 0x009B05DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_dialogCharUIController(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, goddessDialogUIController.m_luaExportHelper.m_dialogCharUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E355 RID: 123733 RVA: 0x009B2434 File Offset: 0x009B0634
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_dialogCharUIController(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			DialogCharUIController dialogCharUIController;
			LuaObject.checkType<DialogCharUIController>(l, 2, out dialogCharUIController);
			goddessDialogUIController.m_luaExportHelper.m_dialogCharUIController = dialogCharUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E356 RID: 123734 RVA: 0x009B2490 File Offset: 0x009B0690
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_dialogBoxUIController(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, goddessDialogUIController.m_luaExportHelper.m_dialogBoxUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E357 RID: 123735 RVA: 0x009B24E8 File Offset: 0x009B06E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_dialogBoxUIController(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			GoddessDialogBoxUIController dialogBoxUIController;
			LuaObject.checkType<GoddessDialogBoxUIController>(l, 2, out dialogBoxUIController);
			goddessDialogUIController.m_luaExportHelper.m_dialogBoxUIController = dialogBoxUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E358 RID: 123736 RVA: 0x009B2544 File Offset: 0x009B0744
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_choiceButtons(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, goddessDialogUIController.m_luaExportHelper.m_choiceButtons);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E359 RID: 123737 RVA: 0x009B259C File Offset: 0x009B079C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_choiceButtons(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			GoddessDialogChoiceButton[] choiceButtons;
			LuaObject.checkArray<GoddessDialogChoiceButton>(l, 2, out choiceButtons);
			goddessDialogUIController.m_luaExportHelper.m_choiceButtons = choiceButtons;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E35A RID: 123738 RVA: 0x009B25F8 File Offset: 0x009B07F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_jobButtons(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, goddessDialogUIController.m_luaExportHelper.m_jobButtons);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E35B RID: 123739 RVA: 0x009B2650 File Offset: 0x009B0850
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_jobButtons(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			GoddessDialogJobButton[] jobButtons;
			LuaObject.checkArray<GoddessDialogJobButton>(l, 2, out jobButtons);
			goddessDialogUIController.m_luaExportHelper.m_jobButtons = jobButtons;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E35C RID: 123740 RVA: 0x009B26AC File Offset: 0x009B08AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_dialogInfo(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, goddessDialogUIController.m_luaExportHelper.m_dialogInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E35D RID: 123741 RVA: 0x009B2704 File Offset: 0x009B0904
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_dialogInfo(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			ConfigDataGoddessDialogInfo dialogInfo;
			LuaObject.checkType<ConfigDataGoddessDialogInfo>(l, 2, out dialogInfo);
			goddessDialogUIController.m_luaExportHelper.m_dialogInfo = dialogInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E35E RID: 123742 RVA: 0x009B2760 File Offset: 0x009B0960
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_feedbackVoices(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, goddessDialogUIController.m_luaExportHelper.m_feedbackVoices);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E35F RID: 123743 RVA: 0x009B27B8 File Offset: 0x009B09B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_feedbackVoices(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			List<string> feedbackVoices;
			LuaObject.checkType<List<string>>(l, 2, out feedbackVoices);
			goddessDialogUIController.m_luaExportHelper.m_feedbackVoices = feedbackVoices;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E360 RID: 123744 RVA: 0x009B2814 File Offset: 0x009B0A14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_feedbackTexts(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, goddessDialogUIController.m_luaExportHelper.m_feedbackTexts);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E361 RID: 123745 RVA: 0x009B286C File Offset: 0x009B0A6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_feedbackTexts(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			List<string> feedbackTexts;
			LuaObject.checkType<List<string>>(l, 2, out feedbackTexts);
			goddessDialogUIController.m_luaExportHelper.m_feedbackTexts = feedbackTexts;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E362 RID: 123746 RVA: 0x009B28C8 File Offset: 0x009B0AC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isClickBackground(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, goddessDialogUIController.m_luaExportHelper.m_isClickBackground);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E363 RID: 123747 RVA: 0x009B2920 File Offset: 0x009B0B20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isClickBackground(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			bool isClickBackground;
			LuaObject.checkType(l, 2, out isClickBackground);
			goddessDialogUIController.m_luaExportHelper.m_isClickBackground = isClickBackground;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E364 RID: 123748 RVA: 0x009B297C File Offset: 0x009B0B7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isDoingChoose(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, goddessDialogUIController.m_luaExportHelper.m_isDoingChoose);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E365 RID: 123749 RVA: 0x009B29D4 File Offset: 0x009B0BD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isDoingChoose(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUIController goddessDialogUIController = (GoddessDialogUIController)LuaObject.checkSelf(l);
			bool isDoingChoose;
			LuaObject.checkType(l, 2, out isDoingChoose);
			goddessDialogUIController.m_luaExportHelper.m_isDoingChoose = isDoingChoose;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E366 RID: 123750 RVA: 0x009B2A30 File Offset: 0x009B0C30
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.GoddessDialogUIController");
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.CreateChar);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.SetDialog);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.CloseDialog);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.ShowJobs);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.HideJobConnections);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.Start);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.Co_CloseDialog);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.Co_ShowWords);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.ShowChoice);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.Co_DoChoice);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.Co_WaitForSecondsOrClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.Co_WaitForClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.Co_WaitForAllWordsDisplayed);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.HasChoice);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.PlayVoice);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.OnBackgroundButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.OnAcceptButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.OnRetryButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.OnSelectButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.OnConfirmButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.OnRetryButton2Click);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.OnPrevButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.OnNextButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.OnChoiceButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.OnJobButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.__callDele_EventOnNext);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.__clearDele_EventOnNext);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.__callDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache29);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.__clearDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache2A);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.__callDele_EventOnChoose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache2B);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.__clearDele_EventOnChoose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache2C);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.__callDele_EventOnShowJobInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache2D);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.__clearDele_EventOnShowJobInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache2E);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.__callDele_EventOnConfirmJob);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache2F);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.__clearDele_EventOnConfirmJob);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache30);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.__callDele_EventOnRetry);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache31);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.__clearDele_EventOnRetry);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache32);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.__callDele_EventOnSelectJob);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache33);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.__clearDele_EventOnSelectJob);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache34);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.__callDele_EventOnPrevJob);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache35);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.__clearDele_EventOnPrevJob);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache36);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.__callDele_EventOnNextJob);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache37);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.__clearDele_EventOnNextJob);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache38);
		string name = "EventOnNext";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.set_EventOnNext);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache39, true);
		string name2 = "EventOnClose";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.set_EventOnClose);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache3A, true);
		string name3 = "EventOnChoose";
		LuaCSFunction get3 = null;
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.set_EventOnChoose);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache3B, true);
		string name4 = "EventOnShowJobInfo";
		LuaCSFunction get4 = null;
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.set_EventOnShowJobInfo);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache3C, true);
		string name5 = "EventOnConfirmJob";
		LuaCSFunction get5 = null;
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.set_EventOnConfirmJob);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache3D, true);
		string name6 = "EventOnRetry";
		LuaCSFunction get6 = null;
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.set_EventOnRetry);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache3E, true);
		string name7 = "EventOnSelectJob";
		LuaCSFunction get7 = null;
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.set_EventOnSelectJob);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache3F, true);
		string name8 = "EventOnPrevJob";
		LuaCSFunction get8 = null;
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.set_EventOnPrevJob);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache40, true);
		string name9 = "EventOnNextJob";
		LuaCSFunction get9 = null;
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.set_EventOnNextJob);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache41, true);
		string name10 = "m_backgroundButton";
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.get_m_backgroundButton);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache42;
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.set_m_backgroundButton);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache43, true);
		string name11 = "m_wordsGameObject";
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.get_m_wordsGameObject);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache44;
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.set_m_wordsGameObject);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache45, true);
		string name12 = "m_charGameObject";
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.get_m_charGameObject);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache46;
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.set_m_charGameObject);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache47, true);
		string name13 = "m_choiceUIStateController";
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.get_m_choiceUIStateController);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache48;
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.set_m_choiceUIStateController);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache49, true);
		string name14 = "m_choice1GameObject";
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.get_m_choice1GameObject);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache4A;
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.set_m_choice1GameObject);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache4B, true);
		string name15 = "m_choice2GameObject";
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.get_m_choice2GameObject);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache4C;
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.set_m_choice2GameObject);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache4D, true);
		string name16 = "m_choice3GameObject";
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.get_m_choice3GameObject);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache4E;
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.set_m_choice3GameObject);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache4F, true);
		string name17 = "m_jobGameObject";
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.get_m_jobGameObject);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache50;
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.set_m_jobGameObject);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache51, true);
		string name18 = "m_jobUIStateController";
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.get_m_jobUIStateController);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache52;
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.set_m_jobUIStateController);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache53, true);
		string name19 = "m_heroIconImage";
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.get_m_heroIconImage);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache54;
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache55 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache55 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.set_m_heroIconImage);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache55, true);
		string name20 = "m_heroNameText";
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache56 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache56 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.get_m_heroNameText);
		}
		LuaCSFunction get20 = Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache56;
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache57 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache57 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.set_m_heroNameText);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache57, true);
		string name21 = "m_job1GameObject";
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache58 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache58 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.get_m_job1GameObject);
		}
		LuaCSFunction get21 = Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache58;
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache59 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache59 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.set_m_job1GameObject);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache59, true);
		string name22 = "m_job2GameObject";
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache5A == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache5A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.get_m_job2GameObject);
		}
		LuaCSFunction get22 = Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache5A;
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache5B == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache5B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.set_m_job2GameObject);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache5B, true);
		string name23 = "m_jobButtonGroup1GameObject";
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache5C == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache5C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.get_m_jobButtonGroup1GameObject);
		}
		LuaCSFunction get23 = Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache5C;
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache5D == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache5D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.set_m_jobButtonGroup1GameObject);
		}
		LuaObject.addMember(l, name23, get23, Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache5D, true);
		string name24 = "m_acceptButton";
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache5E == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache5E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.get_m_acceptButton);
		}
		LuaCSFunction get24 = Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache5E;
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache5F == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache5F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.set_m_acceptButton);
		}
		LuaObject.addMember(l, name24, get24, Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache5F, true);
		string name25 = "m_retryButton";
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache60 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache60 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.get_m_retryButton);
		}
		LuaCSFunction get25 = Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache60;
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache61 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache61 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.set_m_retryButton);
		}
		LuaObject.addMember(l, name25, get25, Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache61, true);
		string name26 = "m_selectButton";
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache62 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache62 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.get_m_selectButton);
		}
		LuaCSFunction get26 = Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache62;
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache63 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache63 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.set_m_selectButton);
		}
		LuaObject.addMember(l, name26, get26, Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache63, true);
		string name27 = "m_jobButtonGroup2GameObject";
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache64 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache64 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.get_m_jobButtonGroup2GameObject);
		}
		LuaCSFunction get27 = Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache64;
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache65 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache65 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.set_m_jobButtonGroup2GameObject);
		}
		LuaObject.addMember(l, name27, get27, Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache65, true);
		string name28 = "m_confirmButton";
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache66 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache66 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.get_m_confirmButton);
		}
		LuaCSFunction get28 = Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache66;
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache67 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache67 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.set_m_confirmButton);
		}
		LuaObject.addMember(l, name28, get28, Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache67, true);
		string name29 = "m_retryButton2";
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache68 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache68 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.get_m_retryButton2);
		}
		LuaCSFunction get29 = Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache68;
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache69 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache69 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.set_m_retryButton2);
		}
		LuaObject.addMember(l, name29, get29, Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache69, true);
		string name30 = "m_prevButton";
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache6A == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache6A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.get_m_prevButton);
		}
		LuaCSFunction get30 = Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache6A;
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache6B == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache6B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.set_m_prevButton);
		}
		LuaObject.addMember(l, name30, get30, Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache6B, true);
		string name31 = "m_nextButton";
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache6C == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache6C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.get_m_nextButton);
		}
		LuaCSFunction get31 = Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache6C;
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache6D == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache6D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.set_m_nextButton);
		}
		LuaObject.addMember(l, name31, get31, Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache6D, true);
		string name32 = "m_prefabsGameObject";
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache6E == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache6E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.get_m_prefabsGameObject);
		}
		LuaCSFunction get32 = Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache6E;
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache6F == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache6F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.set_m_prefabsGameObject);
		}
		LuaObject.addMember(l, name32, get32, Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache6F, true);
		string name33 = "m_dialogCharUIController";
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache70 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache70 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.get_m_dialogCharUIController);
		}
		LuaCSFunction get33 = Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache70;
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache71 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache71 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.set_m_dialogCharUIController);
		}
		LuaObject.addMember(l, name33, get33, Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache71, true);
		string name34 = "m_dialogBoxUIController";
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache72 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache72 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.get_m_dialogBoxUIController);
		}
		LuaCSFunction get34 = Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache72;
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache73 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache73 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.set_m_dialogBoxUIController);
		}
		LuaObject.addMember(l, name34, get34, Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache73, true);
		string name35 = "m_choiceButtons";
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache74 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache74 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.get_m_choiceButtons);
		}
		LuaCSFunction get35 = Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache74;
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache75 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache75 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.set_m_choiceButtons);
		}
		LuaObject.addMember(l, name35, get35, Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache75, true);
		string name36 = "m_jobButtons";
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache76 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache76 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.get_m_jobButtons);
		}
		LuaCSFunction get36 = Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache76;
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache77 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache77 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.set_m_jobButtons);
		}
		LuaObject.addMember(l, name36, get36, Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache77, true);
		string name37 = "m_dialogInfo";
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache78 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache78 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.get_m_dialogInfo);
		}
		LuaCSFunction get37 = Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache78;
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache79 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache79 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.set_m_dialogInfo);
		}
		LuaObject.addMember(l, name37, get37, Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache79, true);
		string name38 = "m_feedbackVoices";
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache7A == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache7A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.get_m_feedbackVoices);
		}
		LuaCSFunction get38 = Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache7A;
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache7B == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache7B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.set_m_feedbackVoices);
		}
		LuaObject.addMember(l, name38, get38, Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache7B, true);
		string name39 = "m_feedbackTexts";
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache7C == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache7C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.get_m_feedbackTexts);
		}
		LuaCSFunction get39 = Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache7C;
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache7D == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache7D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.set_m_feedbackTexts);
		}
		LuaObject.addMember(l, name39, get39, Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache7D, true);
		string name40 = "m_isClickBackground";
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache7E == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache7E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.get_m_isClickBackground);
		}
		LuaCSFunction get40 = Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache7E;
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache7F == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache7F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.set_m_isClickBackground);
		}
		LuaObject.addMember(l, name40, get40, Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache7F, true);
		string name41 = "m_isDoingChoose";
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache80 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache80 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.get_m_isDoingChoose);
		}
		LuaCSFunction get41 = Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache80;
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache81 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache81 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.set_m_isDoingChoose);
		}
		LuaObject.addMember(l, name41, get41, Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.<>f__mg$cache81, true);
		LuaObject.createTypeMetatable(l, null, typeof(GoddessDialogUIController), typeof(UIControllerBase));
	}

	// Token: 0x040143F0 RID: 82928
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040143F1 RID: 82929
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040143F2 RID: 82930
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040143F3 RID: 82931
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040143F4 RID: 82932
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040143F5 RID: 82933
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040143F6 RID: 82934
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040143F7 RID: 82935
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040143F8 RID: 82936
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040143F9 RID: 82937
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040143FA RID: 82938
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040143FB RID: 82939
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040143FC RID: 82940
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040143FD RID: 82941
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040143FE RID: 82942
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040143FF RID: 82943
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04014400 RID: 82944
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04014401 RID: 82945
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04014402 RID: 82946
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04014403 RID: 82947
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04014404 RID: 82948
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04014405 RID: 82949
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04014406 RID: 82950
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04014407 RID: 82951
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04014408 RID: 82952
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04014409 RID: 82953
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0401440A RID: 82954
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0401440B RID: 82955
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0401440C RID: 82956
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0401440D RID: 82957
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0401440E RID: 82958
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0401440F RID: 82959
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04014410 RID: 82960
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04014411 RID: 82961
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04014412 RID: 82962
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04014413 RID: 82963
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04014414 RID: 82964
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04014415 RID: 82965
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04014416 RID: 82966
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04014417 RID: 82967
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04014418 RID: 82968
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04014419 RID: 82969
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0401441A RID: 82970
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0401441B RID: 82971
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0401441C RID: 82972
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0401441D RID: 82973
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0401441E RID: 82974
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x0401441F RID: 82975
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04014420 RID: 82976
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04014421 RID: 82977
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04014422 RID: 82978
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04014423 RID: 82979
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04014424 RID: 82980
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04014425 RID: 82981
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04014426 RID: 82982
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04014427 RID: 82983
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04014428 RID: 82984
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04014429 RID: 82985
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x0401442A RID: 82986
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x0401442B RID: 82987
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x0401442C RID: 82988
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x0401442D RID: 82989
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x0401442E RID: 82990
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x0401442F RID: 82991
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x04014430 RID: 82992
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x04014431 RID: 82993
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x04014432 RID: 82994
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x04014433 RID: 82995
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x04014434 RID: 82996
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x04014435 RID: 82997
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x04014436 RID: 82998
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x04014437 RID: 82999
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x04014438 RID: 83000
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x04014439 RID: 83001
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x0401443A RID: 83002
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x0401443B RID: 83003
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x0401443C RID: 83004
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x0401443D RID: 83005
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x0401443E RID: 83006
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x0401443F RID: 83007
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x04014440 RID: 83008
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x04014441 RID: 83009
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x04014442 RID: 83010
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x04014443 RID: 83011
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x04014444 RID: 83012
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x04014445 RID: 83013
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x04014446 RID: 83014
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x04014447 RID: 83015
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x04014448 RID: 83016
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x04014449 RID: 83017
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;

	// Token: 0x0401444A RID: 83018
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5A;

	// Token: 0x0401444B RID: 83019
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5B;

	// Token: 0x0401444C RID: 83020
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5C;

	// Token: 0x0401444D RID: 83021
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5D;

	// Token: 0x0401444E RID: 83022
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5E;

	// Token: 0x0401444F RID: 83023
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5F;

	// Token: 0x04014450 RID: 83024
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache60;

	// Token: 0x04014451 RID: 83025
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache61;

	// Token: 0x04014452 RID: 83026
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache62;

	// Token: 0x04014453 RID: 83027
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache63;

	// Token: 0x04014454 RID: 83028
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache64;

	// Token: 0x04014455 RID: 83029
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache65;

	// Token: 0x04014456 RID: 83030
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache66;

	// Token: 0x04014457 RID: 83031
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache67;

	// Token: 0x04014458 RID: 83032
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache68;

	// Token: 0x04014459 RID: 83033
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache69;

	// Token: 0x0401445A RID: 83034
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6A;

	// Token: 0x0401445B RID: 83035
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6B;

	// Token: 0x0401445C RID: 83036
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6C;

	// Token: 0x0401445D RID: 83037
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6D;

	// Token: 0x0401445E RID: 83038
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6E;

	// Token: 0x0401445F RID: 83039
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6F;

	// Token: 0x04014460 RID: 83040
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache70;

	// Token: 0x04014461 RID: 83041
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache71;

	// Token: 0x04014462 RID: 83042
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache72;

	// Token: 0x04014463 RID: 83043
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache73;

	// Token: 0x04014464 RID: 83044
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache74;

	// Token: 0x04014465 RID: 83045
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache75;

	// Token: 0x04014466 RID: 83046
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache76;

	// Token: 0x04014467 RID: 83047
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache77;

	// Token: 0x04014468 RID: 83048
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache78;

	// Token: 0x04014469 RID: 83049
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache79;

	// Token: 0x0401446A RID: 83050
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7A;

	// Token: 0x0401446B RID: 83051
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7B;

	// Token: 0x0401446C RID: 83052
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7C;

	// Token: 0x0401446D RID: 83053
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7D;

	// Token: 0x0401446E RID: 83054
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7E;

	// Token: 0x0401446F RID: 83055
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7F;

	// Token: 0x04014470 RID: 83056
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache80;

	// Token: 0x04014471 RID: 83057
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache81;
}
