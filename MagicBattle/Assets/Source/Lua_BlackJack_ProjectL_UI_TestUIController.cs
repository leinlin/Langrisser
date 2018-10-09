using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.UI;
using MarchingBytes;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x020015AD RID: 5549
[Preserve]
public class Lua_BlackJack_ProjectL_UI_TestUIController : LuaObject
{
	// Token: 0x06021A59 RID: 137817 RVA: 0x00B6927C File Offset: 0x00B6747C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetTestListType(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			TestListType testListType;
			LuaObject.checkEnum<TestListType>(l, 2, out testListType);
			testUIController.SetTestListType(testListType);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A5A RID: 137818 RVA: 0x00B692D4 File Offset: 0x00B674D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddTestListItem(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			string name;
			LuaObject.checkType(l, 3, out name);
			testUIController.AddTestListItem(id, name);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A5B RID: 137819 RVA: 0x00B69338 File Offset: 0x00B67538
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearTestList(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			testUIController.ClearTestList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A5C RID: 137820 RVA: 0x00B69384 File Offset: 0x00B67584
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetMonsterLevel(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			int monsterLevel;
			LuaObject.checkType(l, 2, out monsterLevel);
			testUIController.SetMonsterLevel(monsterLevel);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A5D RID: 137821 RVA: 0x00B693DC File Offset: 0x00B675DC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetMonsterLevel(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			int monsterLevel = testUIController.GetMonsterLevel();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, monsterLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A5E RID: 137822 RVA: 0x00B69430 File Offset: 0x00B67630
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetServerDataTime(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			DateTime serverDataTime;
			LuaObject.checkValueType<DateTime>(l, 2, out serverDataTime);
			testUIController.SetServerDataTime(serverDataTime);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A5F RID: 137823 RVA: 0x00B69488 File Offset: 0x00B67688
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ShowSystemInfo(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			testUIController.ShowSystemInfo();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A60 RID: 137824 RVA: 0x00B694D4 File Offset: 0x00B676D4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int HideSystemInfo(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			testUIController.HideSystemInfo();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A61 RID: 137825 RVA: 0x00B69520 File Offset: 0x00B67720
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int RefreshLoopVerticalScrollView(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			TestListType listType;
			LuaObject.checkEnum<TestListType>(l, 2, out listType);
			testUIController.RefreshLoopVerticalScrollView(listType);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A62 RID: 137826 RVA: 0x00B69578 File Offset: 0x00B67778
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BuildSystemInfoText_s(IntPtr l)
	{
		int result;
		try
		{
			bool textColor;
			LuaObject.checkType(l, 1, out textColor);
			string s = TestUIController.BuildSystemInfoText(textColor);
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

	// Token: 0x06021A63 RID: 137827 RVA: 0x00B695CC File Offset: 0x00B677CC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetEnchantProperty_s(IntPtr l)
	{
		int result;
		try
		{
			ulong equipmentInstanceId;
			LuaObject.checkType(l, 1, out equipmentInstanceId);
			string values;
			LuaObject.checkType(l, 2, out values);
			Action onEnd;
			LuaObject.checkDelegate<Action>(l, 3, out onEnd);
			IEnumerator o = TestUIController.SetEnchantProperty(equipmentInstanceId, values, onEnd);
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

	// Token: 0x06021A64 RID: 137828 RVA: 0x00B6963C File Offset: 0x00B6783C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TenLevelUpEquipment_s(IntPtr l)
	{
		int result;
		try
		{
			ulong equipmentInstanceId;
			LuaObject.checkType(l, 1, out equipmentInstanceId);
			Action onEnd;
			LuaObject.checkDelegate<Action>(l, 2, out onEnd);
			IEnumerator o = TestUIController.TenLevelUpEquipment(equipmentInstanceId, onEnd);
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

	// Token: 0x06021A65 RID: 137829 RVA: 0x00B6969C File Offset: 0x00B6789C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SpeedUpHero_s(IntPtr l)
	{
		int result;
		try
		{
			int heroID;
			LuaObject.checkType(l, 1, out heroID);
			int targetHeroLevel;
			LuaObject.checkType(l, 2, out targetHeroLevel);
			int targetStarLevel;
			LuaObject.checkType(l, 3, out targetStarLevel);
			IEnumerator o = TestUIController.SpeedUpHero(heroID, targetHeroLevel, targetStarLevel);
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

	// Token: 0x06021A66 RID: 137830 RVA: 0x00B6970C File Offset: 0x00B6790C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ResetHero_s(IntPtr l)
	{
		int result;
		try
		{
			int heroID;
			LuaObject.checkType(l, 1, out heroID);
			IEnumerator o = TestUIController.ResetHero(heroID);
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

	// Token: 0x06021A67 RID: 137831 RVA: 0x00B69760 File Offset: 0x00B67960
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			testUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A68 RID: 137832 RVA: 0x00B697B4 File Offset: 0x00B679B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetSelectedTestListItemUIController(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			TestListItemUIController selectedTestListItemUIController = testUIController.m_luaExportHelper.GetSelectedTestListItemUIController();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectedTestListItemUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A69 RID: 137833 RVA: 0x00B69810 File Offset: 0x00B67A10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitLoopScrollViewRect(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			testUIController.m_luaExportHelper.InitLoopScrollViewRect();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A6A RID: 137834 RVA: 0x00B69864 File Offset: 0x00B67A64
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnTestItemFill(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			UIControllerBase ctrl;
			LuaObject.checkType<UIControllerBase>(l, 2, out ctrl);
			testUIController.m_luaExportHelper.OnTestItemFill(ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A6B RID: 137835 RVA: 0x00B698C0 File Offset: 0x00B67AC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnTestItemClick(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			UIControllerBase ctrl;
			LuaObject.checkType<UIControllerBase>(l, 2, out ctrl);
			testUIController.m_luaExportHelper.OnTestItemClick(ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A6C RID: 137836 RVA: 0x00B6991C File Offset: 0x00B67B1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DoToggle(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			bool on;
			LuaObject.checkType(l, 2, out on);
			TestListType listType;
			LuaObject.checkEnum<TestListType>(l, 3, out listType);
			testUIController.m_luaExportHelper.DoToggle(on, listType);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A6D RID: 137837 RVA: 0x00B69988 File Offset: 0x00B67B88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBattleToggle(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			bool on;
			LuaObject.checkType(l, 2, out on);
			testUIController.m_luaExportHelper.OnBattleToggle(on);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A6E RID: 137838 RVA: 0x00B699E4 File Offset: 0x00B67BE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnDialogToggle(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			bool on;
			LuaObject.checkType(l, 2, out on);
			testUIController.m_luaExportHelper.OnDialogToggle(on);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A6F RID: 137839 RVA: 0x00B69A40 File Offset: 0x00B67C40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBattleDialogToggle(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			bool on;
			LuaObject.checkType(l, 2, out on);
			testUIController.m_luaExportHelper.OnBattleDialogToggle(on);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A70 RID: 137840 RVA: 0x00B69A9C File Offset: 0x00B67C9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnUserGuideDialogToggle(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			bool on;
			LuaObject.checkType(l, 2, out on);
			testUIController.m_luaExportHelper.OnUserGuideDialogToggle(on);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A71 RID: 137841 RVA: 0x00B69AF8 File Offset: 0x00B67CF8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnTestListHomeBtnClick(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			testUIController.m_luaExportHelper.OnTestListHomeBtnClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A72 RID: 137842 RVA: 0x00B69B4C File Offset: 0x00B67D4C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnTestIdNextBtnClick(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			testUIController.m_luaExportHelper.OnTestIdNextBtnClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A73 RID: 137843 RVA: 0x00B69BA0 File Offset: 0x00B67DA0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnTestIdInput(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			string value;
			LuaObject.checkType(l, 2, out value);
			testUIController.m_luaExportHelper.OnTestIdInput(value);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A74 RID: 137844 RVA: 0x00B69BFC File Offset: 0x00B67DFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStartTestButtonClick(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			testUIController.m_luaExportHelper.OnStartTestButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A75 RID: 137845 RVA: 0x00B69C50 File Offset: 0x00B67E50
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnReturnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			testUIController.m_luaExportHelper.OnReturnButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A76 RID: 137846 RVA: 0x00B69CA4 File Offset: 0x00B67EA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnSystemInfoButtonClick(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			testUIController.m_luaExportHelper.OnSystemInfoButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A77 RID: 137847 RVA: 0x00B69CF8 File Offset: 0x00B67EF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnGoddessDialogButtonClick(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			testUIController.m_luaExportHelper.OnGoddessDialogButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A78 RID: 137848 RVA: 0x00B69D4C File Offset: 0x00B67F4C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnClearUserGuideButtonClick(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			testUIController.m_luaExportHelper.OnClearUserGuideButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A79 RID: 137849 RVA: 0x00B69DA0 File Offset: 0x00B67FA0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnBecomeStrongButtonClick(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			testUIController.m_luaExportHelper.OnBecomeStrongButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A7A RID: 137850 RVA: 0x00B69DF4 File Offset: 0x00B67FF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnFinishAllTasksButtonClick(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			testUIController.m_luaExportHelper.OnFinishAllTasksButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A7B RID: 137851 RVA: 0x00B69E48 File Offset: 0x00B68048
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FinishAllTasks(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			IEnumerator o = testUIController.m_luaExportHelper.FinishAllTasks();
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

	// Token: 0x06021A7C RID: 137852 RVA: 0x00B69EA4 File Offset: 0x00B680A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnCancelReportBugButtonClick(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			testUIController.m_luaExportHelper.OnCancelReportBugButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A7D RID: 137853 RVA: 0x00B69EF8 File Offset: 0x00B680F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OniPhoneXToggleValueChanged(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			bool isOn;
			LuaObject.checkType(l, 2, out isOn);
			testUIController.m_luaExportHelper.OniPhoneXToggleValueChanged(isOn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A7E RID: 137854 RVA: 0x00B69F54 File Offset: 0x00B68154
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnReportBugButtonClick(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			testUIController.m_luaExportHelper.OnReportBugButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A7F RID: 137855 RVA: 0x00B69FA8 File Offset: 0x00B681A8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetReportBugLogHours(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			double reportBugLogHours = testUIController.m_luaExportHelper.GetReportBugLogHours();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, reportBugLogHours);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A80 RID: 137856 RVA: 0x00B6A004 File Offset: 0x00B68204
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnOpenReportBugPanelButtonClick(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			testUIController.m_luaExportHelper.OnOpenReportBugPanelButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A81 RID: 137857 RVA: 0x00B6A058 File Offset: 0x00B68258
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnCompleteUserGuideButtonClick(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			testUIController.m_luaExportHelper.OnCompleteUserGuideButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A82 RID: 137858 RVA: 0x00B6A0AC File Offset: 0x00B682AC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnClearStageButtonClick(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			testUIController.m_luaExportHelper.OnClearStageButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A83 RID: 137859 RVA: 0x00B6A100 File Offset: 0x00B68300
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnSystemInfoBackgroundButtonClick(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			testUIController.m_luaExportHelper.OnSystemInfoBackgroundButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A84 RID: 137860 RVA: 0x00B6A154 File Offset: 0x00B68354
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			testUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A85 RID: 137861 RVA: 0x00B6A1C0 File Offset: 0x00B683C0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			testUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A86 RID: 137862 RVA: 0x00B6A214 File Offset: 0x00B68414
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			testUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A87 RID: 137863 RVA: 0x00B6A268 File Offset: 0x00B68468
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = testUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x06021A88 RID: 137864 RVA: 0x00B6A310 File Offset: 0x00B68510
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			testUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A89 RID: 137865 RVA: 0x00B6A364 File Offset: 0x00B68564
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			testUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A8A RID: 137866 RVA: 0x00B6A3D0 File Offset: 0x00B685D0
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
				TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				testUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				TestUIController testUIController2 = (TestUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				testUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x06021A8B RID: 137867 RVA: 0x00B6A4E0 File Offset: 0x00B686E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			testUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A8C RID: 137868 RVA: 0x00B6A54C File Offset: 0x00B6874C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			testUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A8D RID: 137869 RVA: 0x00B6A5B8 File Offset: 0x00B687B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			testUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A8E RID: 137870 RVA: 0x00B6A624 File Offset: 0x00B68824
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			testUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A8F RID: 137871 RVA: 0x00B6A690 File Offset: 0x00B68890
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
				TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				testUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				TestUIController testUIController2 = (TestUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				testUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x06021A90 RID: 137872 RVA: 0x00B6A7A0 File Offset: 0x00B689A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			string s = testUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x06021A91 RID: 137873 RVA: 0x00B6A7FC File Offset: 0x00B689FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnChangeTestList(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			TestListType obj;
			LuaObject.checkEnum<TestListType>(l, 2, out obj);
			testUIController.m_luaExportHelper.__callDele_EventOnChangeTestList(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A92 RID: 137874 RVA: 0x00B6A858 File Offset: 0x00B68A58
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_EventOnChangeTestList(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			TestListType obj;
			LuaObject.checkEnum<TestListType>(l, 2, out obj);
			testUIController.m_luaExportHelper.__clearDele_EventOnChangeTestList(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A93 RID: 137875 RVA: 0x00B6A8B4 File Offset: 0x00B68AB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnStartTest(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			testUIController.m_luaExportHelper.__callDele_EventOnStartTest(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A94 RID: 137876 RVA: 0x00B6A910 File Offset: 0x00B68B10
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_EventOnStartTest(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			testUIController.m_luaExportHelper.__clearDele_EventOnStartTest(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A95 RID: 137877 RVA: 0x00B6A96C File Offset: 0x00B68B6C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_EventOnShowSystemInfo(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			testUIController.m_luaExportHelper.__callDele_EventOnShowSystemInfo();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A96 RID: 137878 RVA: 0x00B6A9C0 File Offset: 0x00B68BC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnShowSystemInfo(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			testUIController.m_luaExportHelper.__clearDele_EventOnShowSystemInfo();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A97 RID: 137879 RVA: 0x00B6AA14 File Offset: 0x00B68C14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnCloseSystemInfo(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			testUIController.m_luaExportHelper.__callDele_EventOnCloseSystemInfo();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A98 RID: 137880 RVA: 0x00B6AA68 File Offset: 0x00B68C68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnCloseSystemInfo(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			testUIController.m_luaExportHelper.__clearDele_EventOnCloseSystemInfo();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A99 RID: 137881 RVA: 0x00B6AABC File Offset: 0x00B68CBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnShowGoddessDialog(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			testUIController.m_luaExportHelper.__callDele_EventOnShowGoddessDialog();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A9A RID: 137882 RVA: 0x00B6AB10 File Offset: 0x00B68D10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnShowGoddessDialog(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			testUIController.m_luaExportHelper.__clearDele_EventOnShowGoddessDialog();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A9B RID: 137883 RVA: 0x00B6AB64 File Offset: 0x00B68D64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnClearUserGuide(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			testUIController.m_luaExportHelper.__callDele_EventOnClearUserGuide();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A9C RID: 137884 RVA: 0x00B6ABB8 File Offset: 0x00B68DB8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_EventOnClearUserGuide(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			testUIController.m_luaExportHelper.__clearDele_EventOnClearUserGuide();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A9D RID: 137885 RVA: 0x00B6AC0C File Offset: 0x00B68E0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnCompleteUserGuide(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			testUIController.m_luaExportHelper.__callDele_EventOnCompleteUserGuide();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A9E RID: 137886 RVA: 0x00B6AC60 File Offset: 0x00B68E60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnCompleteUserGuide(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			testUIController.m_luaExportHelper.__clearDele_EventOnCompleteUserGuide();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A9F RID: 137887 RVA: 0x00B6ACB4 File Offset: 0x00B68EB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnClearStage(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			testUIController.m_luaExportHelper.__callDele_EventOnClearStage();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021AA0 RID: 137888 RVA: 0x00B6AD08 File Offset: 0x00B68F08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnClearStage(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			testUIController.m_luaExportHelper.__clearDele_EventOnClearStage();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021AA1 RID: 137889 RVA: 0x00B6AD5C File Offset: 0x00B68F5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			testUIController.m_luaExportHelper.__callDele_EventOnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021AA2 RID: 137890 RVA: 0x00B6ADB0 File Offset: 0x00B68FB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			testUIController.m_luaExportHelper.__clearDele_EventOnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021AA3 RID: 137891 RVA: 0x00B6AE04 File Offset: 0x00B69004
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_EventOnReportBug(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			string arg;
			LuaObject.checkType(l, 2, out arg);
			double arg2;
			LuaObject.checkType(l, 3, out arg2);
			testUIController.m_luaExportHelper.__callDele_EventOnReportBug(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021AA4 RID: 137892 RVA: 0x00B6AE70 File Offset: 0x00B69070
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_EventOnReportBug(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			string arg;
			LuaObject.checkType(l, 2, out arg);
			double arg2;
			LuaObject.checkType(l, 3, out arg2);
			testUIController.m_luaExportHelper.__clearDele_EventOnReportBug(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021AA5 RID: 137893 RVA: 0x00B6AEDC File Offset: 0x00B690DC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ScrollToItem_s(IntPtr l)
	{
		int result;
		try
		{
			ScrollRect scrollRect;
			LuaObject.checkType<ScrollRect>(l, 1, out scrollRect);
			int itemCount;
			LuaObject.checkType(l, 2, out itemCount);
			int idx;
			LuaObject.checkType(l, 3, out idx);
			TestUIController.LuaExportHelper.ScrollToItem(scrollRect, itemCount, idx);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021AA6 RID: 137894 RVA: 0x00B6AF40 File Offset: 0x00B69140
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AppendLine_s(IntPtr l)
	{
		int result;
		try
		{
			StringBuilder sb;
			LuaObject.checkType<StringBuilder>(l, 1, out sb);
			bool textColor;
			LuaObject.checkType(l, 2, out textColor);
			string name;
			LuaObject.checkType(l, 3, out name);
			string value;
			LuaObject.checkType(l, 4, out value);
			TestUIController.LuaExportHelper.AppendLine(sb, textColor, name, value);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021AA7 RID: 137895 RVA: 0x00B6AFB0 File Offset: 0x00B691B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpgradePlayerLevel_s(IntPtr l)
	{
		int result;
		try
		{
			int targetPlayerLevel;
			LuaObject.checkType(l, 1, out targetPlayerLevel);
			IEnumerator o = TestUIController.LuaExportHelper.UpgradePlayerLevel(targetPlayerLevel);
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

	// Token: 0x06021AA8 RID: 137896 RVA: 0x00B6B004 File Offset: 0x00B69204
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SpeedUpAllHeros_s(IntPtr l)
	{
		int result;
		try
		{
			int targetHeroLevel;
			LuaObject.checkType(l, 1, out targetHeroLevel);
			int targetStarLevel;
			LuaObject.checkType(l, 2, out targetStarLevel);
			IEnumerator o = TestUIController.LuaExportHelper.SpeedUpAllHeros(targetHeroLevel, targetStarLevel);
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

	// Token: 0x06021AA9 RID: 137897 RVA: 0x00B6B064 File Offset: 0x00B69264
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int BecomeStrong_s(IntPtr l)
	{
		int result;
		try
		{
			int targetPlayerLevel;
			LuaObject.checkType(l, 1, out targetPlayerLevel);
			int targetStarLevel;
			LuaObject.checkType(l, 2, out targetStarLevel);
			int targetEquipmentLevel;
			LuaObject.checkType(l, 3, out targetEquipmentLevel);
			IEnumerator o = TestUIController.LuaExportHelper.BecomeStrong(targetPlayerLevel, targetStarLevel, targetEquipmentLevel);
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

	// Token: 0x06021AAA RID: 137898 RVA: 0x00B6B0D4 File Offset: 0x00B692D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetHeroJobConnSequence_s(IntPtr l)
	{
		int result;
		try
		{
			int heroID;
			LuaObject.checkType(l, 1, out heroID);
			List<int> heroJobConnSequence = TestUIController.LuaExportHelper.GetHeroJobConnSequence(heroID);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobConnSequence);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021AAB RID: 137899 RVA: 0x00B6B128 File Offset: 0x00B69328
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetJobSequence_s(IntPtr l)
	{
		int result;
		try
		{
			int rootJobConnectionID;
			LuaObject.checkType(l, 1, out rootJobConnectionID);
			List<int> jobSequence = TestUIController.LuaExportHelper.GetJobSequence(rootJobConnectionID);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, jobSequence);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021AAC RID: 137900 RVA: 0x00B6B17C File Offset: 0x00B6937C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetEquipmentLevelLimit_s(IntPtr l)
	{
		int result;
		try
		{
			int equipmentStarLevel;
			LuaObject.checkType(l, 1, out equipmentStarLevel);
			int equipmentLevelLimit = TestUIController.LuaExportHelper.GetEquipmentLevelLimit(equipmentStarLevel);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentLevelLimit);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021AAD RID: 137901 RVA: 0x00B6B1D0 File Offset: 0x00B693D0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsEquipismentMaxLevel_s(IntPtr l)
	{
		int result;
		try
		{
			EquipmentBagItem equipment;
			LuaObject.checkType<EquipmentBagItem>(l, 1, out equipment);
			bool b = TestUIController.LuaExportHelper.IsEquipismentMaxLevel(equipment);
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

	// Token: 0x06021AAE RID: 137902 RVA: 0x00B6B224 File Offset: 0x00B69424
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StarLevelUpTopRankEquipments_s(IntPtr l)
	{
		int result;
		try
		{
			int ssrMaterialEquipmentId;
			LuaObject.checkType(l, 1, out ssrMaterialEquipmentId);
			int srMaterialEquipmentId;
			LuaObject.checkType(l, 2, out srMaterialEquipmentId);
			IEnumerator o = TestUIController.LuaExportHelper.StarLevelUpTopRankEquipments(ssrMaterialEquipmentId, srMaterialEquipmentId);
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

	// Token: 0x06021AAF RID: 137903 RVA: 0x00B6B284 File Offset: 0x00B69484
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddItem4StarLevelUpEquipment_s(IntPtr l)
	{
		int result;
		try
		{
			ulong instanceId;
			LuaObject.checkType(l, 1, out instanceId);
			IEnumerator o = TestUIController.LuaExportHelper.AddItem4StarLevelUpEquipment(instanceId);
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

	// Token: 0x06021AB0 RID: 137904 RVA: 0x00B6B2D8 File Offset: 0x00B694D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddGoods_s(IntPtr l)
	{
		int result;
		try
		{
			List<Goods> goods;
			LuaObject.checkType<List<Goods>>(l, 1, out goods);
			IEnumerator o = TestUIController.LuaExportHelper.AddGoods(goods);
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

	// Token: 0x06021AB1 RID: 137905 RVA: 0x00B6B32C File Offset: 0x00B6952C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int StarLevelUpEquipment_s(IntPtr l)
	{
		int result;
		try
		{
			ulong instanceId;
			LuaObject.checkType(l, 1, out instanceId);
			ulong materialId;
			LuaObject.checkType(l, 2, out materialId);
			IEnumerator o = TestUIController.LuaExportHelper.StarLevelUpEquipment(instanceId, materialId);
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

	// Token: 0x06021AB2 RID: 137906 RVA: 0x00B6B38C File Offset: 0x00B6958C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int EnhanceAllTopRankEquipments_s(IntPtr l)
	{
		int result;
		try
		{
			int targetLevel;
			LuaObject.checkType(l, 1, out targetLevel);
			IEnumerator o = TestUIController.LuaExportHelper.EnhanceAllTopRankEquipments(targetLevel);
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

	// Token: 0x06021AB3 RID: 137907 RVA: 0x00B6B3E0 File Offset: 0x00B695E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int EnhanceEquipment_s(IntPtr l)
	{
		int result;
		try
		{
			ulong instanceId;
			LuaObject.checkType(l, 1, out instanceId);
			List<ulong> materialIds;
			LuaObject.checkType<List<ulong>>(l, 2, out materialIds);
			IEnumerator o = TestUIController.LuaExportHelper.EnhanceEquipment(instanceId, materialIds);
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

	// Token: 0x06021AB4 RID: 137908 RVA: 0x00B6B440 File Offset: 0x00B69640
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AddAllTopRankEquipments_s(IntPtr l)
	{
		int result;
		try
		{
			IEnumerator o = TestUIController.LuaExportHelper.AddAllTopRankEquipments();
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

	// Token: 0x06021AB5 RID: 137909 RVA: 0x00B6B488 File Offset: 0x00B69688
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddAllHeros_s(IntPtr l)
	{
		int result;
		try
		{
			IEnumerator o = TestUIController.LuaExportHelper.AddAllHeros();
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

	// Token: 0x06021AB6 RID: 137910 RVA: 0x00B6B4D0 File Offset: 0x00B696D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddHero_s(IntPtr l)
	{
		int result;
		try
		{
			List<int> heros;
			LuaObject.checkType<List<int>>(l, 1, out heros);
			IEnumerator o = TestUIController.LuaExportHelper.AddHero(heros);
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

	// Token: 0x06021AB7 RID: 137911 RVA: 0x00B6B524 File Offset: 0x00B69724
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroBreak_s(IntPtr l)
	{
		int result;
		try
		{
			int id;
			LuaObject.checkType(l, 1, out id);
			IEnumerator o = TestUIController.LuaExportHelper.HeroBreak(id);
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

	// Token: 0x06021AB8 RID: 137912 RVA: 0x00B6B578 File Offset: 0x00B69778
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BuyFixedStoreItem_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				int fixedStoreID;
				LuaObject.checkType(l, 1, out fixedStoreID);
				int fixedStoreItemGoodsID;
				LuaObject.checkType(l, 2, out fixedStoreItemGoodsID);
				IEnumerator o = TestUIController.LuaExportHelper.BuyFixedStoreItem(fixedStoreID, fixedStoreItemGoodsID);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (num == 3)
			{
				int fixedStoreID2;
				LuaObject.checkType(l, 1, out fixedStoreID2);
				int fixedStoreItemGoodsID2;
				LuaObject.checkType(l, 2, out fixedStoreItemGoodsID2);
				int count;
				LuaObject.checkType(l, 3, out count);
				IEnumerator o2 = TestUIController.LuaExportHelper.BuyFixedStoreItem(fixedStoreID2, fixedStoreItemGoodsID2, count);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function BuyFixedStoreItem to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021AB9 RID: 137913 RVA: 0x00B6B64C File Offset: 0x00B6984C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TransferHeroJob_s(IntPtr l)
	{
		int result;
		try
		{
			int heroId;
			LuaObject.checkType(l, 1, out heroId);
			int jobConnectionId;
			LuaObject.checkType(l, 2, out jobConnectionId);
			IEnumerator o = TestUIController.LuaExportHelper.TransferHeroJob(heroId, jobConnectionId);
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

	// Token: 0x06021ABA RID: 137914 RVA: 0x00B6B6AC File Offset: 0x00B698AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddAllItem_s(IntPtr l)
	{
		int result;
		try
		{
			int count;
			LuaObject.checkType(l, 1, out count);
			IEnumerator o = TestUIController.LuaExportHelper.AddAllItem(count);
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

	// Token: 0x06021ABB RID: 137915 RVA: 0x00B6B700 File Offset: 0x00B69900
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpgradeHeroJobLevel_s(IntPtr l)
	{
		int result;
		try
		{
			Hero hero;
			LuaObject.checkType<Hero>(l, 1, out hero);
			int jobConnectionId;
			LuaObject.checkType(l, 2, out jobConnectionId);
			IEnumerator o = TestUIController.LuaExportHelper.UpgradeHeroJobLevel(hero, jobConnectionId);
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

	// Token: 0x06021ABC RID: 137916 RVA: 0x00B6B760 File Offset: 0x00B69960
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SendGMCommand_s(IntPtr l)
	{
		int result;
		try
		{
			string cmd;
			LuaObject.checkType(l, 1, out cmd);
			IEnumerator o = TestUIController.LuaExportHelper.SendGMCommand(cmd);
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

	// Token: 0x06021ABD RID: 137917 RVA: 0x00B6B7B4 File Offset: 0x00B699B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UseItem_s(IntPtr l)
	{
		int result;
		try
		{
			GoodsType type;
			LuaObject.checkEnum<GoodsType>(l, 1, out type);
			int id;
			LuaObject.checkType(l, 2, out id);
			int count;
			LuaObject.checkType(l, 3, out count);
			IEnumerator o = TestUIController.LuaExportHelper.UseItem(type, id, count);
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

	// Token: 0x06021ABE RID: 137918 RVA: 0x00B6B824 File Offset: 0x00B69A24
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AddHeroExp_s(IntPtr l)
	{
		int result;
		try
		{
			int heroId;
			LuaObject.checkType(l, 1, out heroId);
			GoodsType itemType;
			LuaObject.checkEnum<GoodsType>(l, 2, out itemType);
			int itemID;
			LuaObject.checkType(l, 3, out itemID);
			int count;
			LuaObject.checkType(l, 4, out count);
			IEnumerator o = TestUIController.LuaExportHelper.AddHeroExp(heroId, itemType, itemID, count);
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

	// Token: 0x06021ABF RID: 137919 RVA: 0x00B6B8A0 File Offset: 0x00B69AA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ErrorCodeToMessage_s(IntPtr l)
	{
		int result;
		try
		{
			int code;
			LuaObject.checkType(l, 1, out code);
			string s = TestUIController.LuaExportHelper.ErrorCodeToMessage(code);
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

	// Token: 0x06021AC0 RID: 137920 RVA: 0x00B6B8F4 File Offset: 0x00B69AF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnChangeTestList(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			Action<TestListType> value;
			int num = LuaObject.checkDelegate<Action<TestListType>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					testUIController.EventOnChangeTestList += value;
				}
				else if (num == 2)
				{
					testUIController.EventOnChangeTestList -= value;
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

	// Token: 0x06021AC1 RID: 137921 RVA: 0x00B6B974 File Offset: 0x00B69B74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnStartTest(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			Action<int> value;
			int num = LuaObject.checkDelegate<Action<int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					testUIController.EventOnStartTest += value;
				}
				else if (num == 2)
				{
					testUIController.EventOnStartTest -= value;
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

	// Token: 0x06021AC2 RID: 137922 RVA: 0x00B6B9F4 File Offset: 0x00B69BF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnShowSystemInfo(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					testUIController.EventOnShowSystemInfo += value;
				}
				else if (num == 2)
				{
					testUIController.EventOnShowSystemInfo -= value;
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

	// Token: 0x06021AC3 RID: 137923 RVA: 0x00B6BA74 File Offset: 0x00B69C74
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_EventOnCloseSystemInfo(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					testUIController.EventOnCloseSystemInfo += value;
				}
				else if (num == 2)
				{
					testUIController.EventOnCloseSystemInfo -= value;
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

	// Token: 0x06021AC4 RID: 137924 RVA: 0x00B6BAF4 File Offset: 0x00B69CF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnShowGoddessDialog(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					testUIController.EventOnShowGoddessDialog += value;
				}
				else if (num == 2)
				{
					testUIController.EventOnShowGoddessDialog -= value;
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

	// Token: 0x06021AC5 RID: 137925 RVA: 0x00B6BB74 File Offset: 0x00B69D74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnClearUserGuide(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					testUIController.EventOnClearUserGuide += value;
				}
				else if (num == 2)
				{
					testUIController.EventOnClearUserGuide -= value;
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

	// Token: 0x06021AC6 RID: 137926 RVA: 0x00B6BBF4 File Offset: 0x00B69DF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnCompleteUserGuide(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					testUIController.EventOnCompleteUserGuide += value;
				}
				else if (num == 2)
				{
					testUIController.EventOnCompleteUserGuide -= value;
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

	// Token: 0x06021AC7 RID: 137927 RVA: 0x00B6BC74 File Offset: 0x00B69E74
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_EventOnClearStage(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					testUIController.EventOnClearStage += value;
				}
				else if (num == 2)
				{
					testUIController.EventOnClearStage -= value;
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

	// Token: 0x06021AC8 RID: 137928 RVA: 0x00B6BCF4 File Offset: 0x00B69EF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					testUIController.EventOnReturn += value;
				}
				else if (num == 2)
				{
					testUIController.EventOnReturn -= value;
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

	// Token: 0x06021AC9 RID: 137929 RVA: 0x00B6BD74 File Offset: 0x00B69F74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnReportBug(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			Action<string, double> value;
			int num = LuaObject.checkDelegate<Action<string, double>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					testUIController.EventOnReportBug += value;
				}
				else if (num == 2)
				{
					testUIController.EventOnReportBug -= value;
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

	// Token: 0x06021ACA RID: 137930 RVA: 0x00B6BDF4 File Offset: 0x00B69FF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_returnButton(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, testUIController.m_luaExportHelper.m_returnButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021ACB RID: 137931 RVA: 0x00B6BE4C File Offset: 0x00B6A04C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_returnButton(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			Button returnButton;
			LuaObject.checkType<Button>(l, 2, out returnButton);
			testUIController.m_luaExportHelper.m_returnButton = returnButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021ACC RID: 137932 RVA: 0x00B6BEA8 File Offset: 0x00B6A0A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_systemInfoButton(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, testUIController.m_luaExportHelper.m_systemInfoButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021ACD RID: 137933 RVA: 0x00B6BF00 File Offset: 0x00B6A100
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_systemInfoButton(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			Button systemInfoButton;
			LuaObject.checkType<Button>(l, 2, out systemInfoButton);
			testUIController.m_luaExportHelper.m_systemInfoButton = systemInfoButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021ACE RID: 137934 RVA: 0x00B6BF5C File Offset: 0x00B6A15C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_goddessDialogButton(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, testUIController.m_luaExportHelper.m_goddessDialogButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021ACF RID: 137935 RVA: 0x00B6BFB4 File Offset: 0x00B6A1B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_goddessDialogButton(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			Button goddessDialogButton;
			LuaObject.checkType<Button>(l, 2, out goddessDialogButton);
			testUIController.m_luaExportHelper.m_goddessDialogButton = goddessDialogButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021AD0 RID: 137936 RVA: 0x00B6C010 File Offset: 0x00B6A210
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_clearUserGuideButton(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, testUIController.m_luaExportHelper.m_clearUserGuideButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021AD1 RID: 137937 RVA: 0x00B6C068 File Offset: 0x00B6A268
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_clearUserGuideButton(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			Button clearUserGuideButton;
			LuaObject.checkType<Button>(l, 2, out clearUserGuideButton);
			testUIController.m_luaExportHelper.m_clearUserGuideButton = clearUserGuideButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021AD2 RID: 137938 RVA: 0x00B6C0C4 File Offset: 0x00B6A2C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_completeUserGuideButton(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, testUIController.m_luaExportHelper.m_completeUserGuideButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021AD3 RID: 137939 RVA: 0x00B6C11C File Offset: 0x00B6A31C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_completeUserGuideButton(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			Button completeUserGuideButton;
			LuaObject.checkType<Button>(l, 2, out completeUserGuideButton);
			testUIController.m_luaExportHelper.m_completeUserGuideButton = completeUserGuideButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021AD4 RID: 137940 RVA: 0x00B6C178 File Offset: 0x00B6A378
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_becomeStrongButton(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, testUIController.m_luaExportHelper.m_becomeStrongButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021AD5 RID: 137941 RVA: 0x00B6C1D0 File Offset: 0x00B6A3D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_becomeStrongButton(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			Button becomeStrongButton;
			LuaObject.checkType<Button>(l, 2, out becomeStrongButton);
			testUIController.m_luaExportHelper.m_becomeStrongButton = becomeStrongButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021AD6 RID: 137942 RVA: 0x00B6C22C File Offset: 0x00B6A42C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_becomeStrongPlayerLevelInput(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, testUIController.m_luaExportHelper.m_becomeStrongPlayerLevelInput);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021AD7 RID: 137943 RVA: 0x00B6C284 File Offset: 0x00B6A484
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_becomeStrongPlayerLevelInput(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			InputField becomeStrongPlayerLevelInput;
			LuaObject.checkType<InputField>(l, 2, out becomeStrongPlayerLevelInput);
			testUIController.m_luaExportHelper.m_becomeStrongPlayerLevelInput = becomeStrongPlayerLevelInput;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021AD8 RID: 137944 RVA: 0x00B6C2E0 File Offset: 0x00B6A4E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_becomeStrongHeroStarLevelInput(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, testUIController.m_luaExportHelper.m_becomeStrongHeroStarLevelInput);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021AD9 RID: 137945 RVA: 0x00B6C338 File Offset: 0x00B6A538
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_becomeStrongHeroStarLevelInput(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			InputField becomeStrongHeroStarLevelInput;
			LuaObject.checkType<InputField>(l, 2, out becomeStrongHeroStarLevelInput);
			testUIController.m_luaExportHelper.m_becomeStrongHeroStarLevelInput = becomeStrongHeroStarLevelInput;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021ADA RID: 137946 RVA: 0x00B6C394 File Offset: 0x00B6A594
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_becomeStrongEquipmentLevelInput(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, testUIController.m_luaExportHelper.m_becomeStrongEquipmentLevelInput);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021ADB RID: 137947 RVA: 0x00B6C3EC File Offset: 0x00B6A5EC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_becomeStrongEquipmentLevelInput(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			InputField becomeStrongEquipmentLevelInput;
			LuaObject.checkType<InputField>(l, 2, out becomeStrongEquipmentLevelInput);
			testUIController.m_luaExportHelper.m_becomeStrongEquipmentLevelInput = becomeStrongEquipmentLevelInput;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021ADC RID: 137948 RVA: 0x00B6C448 File Offset: 0x00B6A648
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_clearStageButton(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, testUIController.m_luaExportHelper.m_clearStageButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021ADD RID: 137949 RVA: 0x00B6C4A0 File Offset: 0x00B6A6A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_clearStageButton(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			Button clearStageButton;
			LuaObject.checkType<Button>(l, 2, out clearStageButton);
			testUIController.m_luaExportHelper.m_clearStageButton = clearStageButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021ADE RID: 137950 RVA: 0x00B6C4FC File Offset: 0x00B6A6FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_openReportBugPanelButton(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, testUIController.m_luaExportHelper.m_openReportBugPanelButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021ADF RID: 137951 RVA: 0x00B6C554 File Offset: 0x00B6A754
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_openReportBugPanelButton(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			Button openReportBugPanelButton;
			LuaObject.checkType<Button>(l, 2, out openReportBugPanelButton);
			testUIController.m_luaExportHelper.m_openReportBugPanelButton = openReportBugPanelButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021AE0 RID: 137952 RVA: 0x00B6C5B0 File Offset: 0x00B6A7B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_iPhoneXToggle(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, testUIController.m_luaExportHelper.m_iPhoneXToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021AE1 RID: 137953 RVA: 0x00B6C608 File Offset: 0x00B6A808
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_iPhoneXToggle(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			Toggle iPhoneXToggle;
			LuaObject.checkType<Toggle>(l, 2, out iPhoneXToggle);
			testUIController.m_luaExportHelper.m_iPhoneXToggle = iPhoneXToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021AE2 RID: 137954 RVA: 0x00B6C664 File Offset: 0x00B6A864
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_battleToggle(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, testUIController.m_luaExportHelper.m_battleToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021AE3 RID: 137955 RVA: 0x00B6C6BC File Offset: 0x00B6A8BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battleToggle(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			Toggle battleToggle;
			LuaObject.checkType<Toggle>(l, 2, out battleToggle);
			testUIController.m_luaExportHelper.m_battleToggle = battleToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021AE4 RID: 137956 RVA: 0x00B6C718 File Offset: 0x00B6A918
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_dialogToggle(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, testUIController.m_luaExportHelper.m_dialogToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021AE5 RID: 137957 RVA: 0x00B6C770 File Offset: 0x00B6A970
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_dialogToggle(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			Toggle dialogToggle;
			LuaObject.checkType<Toggle>(l, 2, out dialogToggle);
			testUIController.m_luaExportHelper.m_dialogToggle = dialogToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021AE6 RID: 137958 RVA: 0x00B6C7CC File Offset: 0x00B6A9CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battleDialogToggle(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, testUIController.m_luaExportHelper.m_battleDialogToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021AE7 RID: 137959 RVA: 0x00B6C824 File Offset: 0x00B6AA24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battleDialogToggle(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			Toggle battleDialogToggle;
			LuaObject.checkType<Toggle>(l, 2, out battleDialogToggle);
			testUIController.m_luaExportHelper.m_battleDialogToggle = battleDialogToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021AE8 RID: 137960 RVA: 0x00B6C880 File Offset: 0x00B6AA80
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_userGuideDialogToggle(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, testUIController.m_luaExportHelper.m_userGuideDialogToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021AE9 RID: 137961 RVA: 0x00B6C8D8 File Offset: 0x00B6AAD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_userGuideDialogToggle(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			Toggle userGuideDialogToggle;
			LuaObject.checkType<Toggle>(l, 2, out userGuideDialogToggle);
			testUIController.m_luaExportHelper.m_userGuideDialogToggle = userGuideDialogToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021AEA RID: 137962 RVA: 0x00B6C934 File Offset: 0x00B6AB34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_ListItemPool(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, testUIController.m_luaExportHelper.m_ListItemPool);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021AEB RID: 137963 RVA: 0x00B6C98C File Offset: 0x00B6AB8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_ListItemPool(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			EasyObjectPool listItemPool;
			LuaObject.checkType<EasyObjectPool>(l, 2, out listItemPool);
			testUIController.m_luaExportHelper.m_ListItemPool = listItemPool;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021AEC RID: 137964 RVA: 0x00B6C9E8 File Offset: 0x00B6ABE8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_LoopScroolRect(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, testUIController.m_luaExportHelper.m_LoopScroolRect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021AED RID: 137965 RVA: 0x00B6CA40 File Offset: 0x00B6AC40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_LoopScroolRect(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			LoopVerticalScrollRect loopScroolRect;
			LuaObject.checkType<LoopVerticalScrollRect>(l, 2, out loopScroolRect);
			testUIController.m_luaExportHelper.m_LoopScroolRect = loopScroolRect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021AEE RID: 137966 RVA: 0x00B6CA9C File Offset: 0x00B6AC9C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_monsterLevelGameObject(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, testUIController.m_luaExportHelper.m_monsterLevelGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021AEF RID: 137967 RVA: 0x00B6CAF4 File Offset: 0x00B6ACF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_monsterLevelGameObject(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			GameObject monsterLevelGameObject;
			LuaObject.checkType<GameObject>(l, 2, out monsterLevelGameObject);
			testUIController.m_luaExportHelper.m_monsterLevelGameObject = monsterLevelGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021AF0 RID: 137968 RVA: 0x00B6CB50 File Offset: 0x00B6AD50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_monsterLevelInputField(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, testUIController.m_luaExportHelper.m_monsterLevelInputField);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021AF1 RID: 137969 RVA: 0x00B6CBA8 File Offset: 0x00B6ADA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_monsterLevelInputField(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			InputField monsterLevelInputField;
			LuaObject.checkType<InputField>(l, 2, out monsterLevelInputField);
			testUIController.m_luaExportHelper.m_monsterLevelInputField = monsterLevelInputField;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021AF2 RID: 137970 RVA: 0x00B6CC04 File Offset: 0x00B6AE04
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_startTestBattleButton(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, testUIController.m_luaExportHelper.m_startTestBattleButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021AF3 RID: 137971 RVA: 0x00B6CC5C File Offset: 0x00B6AE5C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_startTestBattleButton(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			Button startTestBattleButton;
			LuaObject.checkType<Button>(l, 2, out startTestBattleButton);
			testUIController.m_luaExportHelper.m_startTestBattleButton = startTestBattleButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021AF4 RID: 137972 RVA: 0x00B6CCB8 File Offset: 0x00B6AEB8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_TestIdInputField(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, testUIController.m_luaExportHelper.m_TestIdInputField);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021AF5 RID: 137973 RVA: 0x00B6CD10 File Offset: 0x00B6AF10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_TestIdInputField(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			InputField testIdInputField;
			LuaObject.checkType<InputField>(l, 2, out testIdInputField);
			testUIController.m_luaExportHelper.m_TestIdInputField = testIdInputField;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021AF6 RID: 137974 RVA: 0x00B6CD6C File Offset: 0x00B6AF6C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_TestIdNextSearch(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, testUIController.m_luaExportHelper.m_TestIdNextSearch);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021AF7 RID: 137975 RVA: 0x00B6CDC4 File Offset: 0x00B6AFC4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_TestIdNextSearch(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			Button testIdNextSearch;
			LuaObject.checkType<Button>(l, 2, out testIdNextSearch);
			testUIController.m_luaExportHelper.m_TestIdNextSearch = testIdNextSearch;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021AF8 RID: 137976 RVA: 0x00B6CE20 File Offset: 0x00B6B020
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_TestListHomeBtn(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, testUIController.m_luaExportHelper.m_TestListHomeBtn);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021AF9 RID: 137977 RVA: 0x00B6CE78 File Offset: 0x00B6B078
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_TestListHomeBtn(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			Button testListHomeBtn;
			LuaObject.checkType<Button>(l, 2, out testListHomeBtn);
			testUIController.m_luaExportHelper.m_TestListHomeBtn = testListHomeBtn;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021AFA RID: 137978 RVA: 0x00B6CED4 File Offset: 0x00B6B0D4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_systemInfoGameObject(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, testUIController.m_luaExportHelper.m_systemInfoGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021AFB RID: 137979 RVA: 0x00B6CF2C File Offset: 0x00B6B12C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_systemInfoGameObject(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			GameObject systemInfoGameObject;
			LuaObject.checkType<GameObject>(l, 2, out systemInfoGameObject);
			testUIController.m_luaExportHelper.m_systemInfoGameObject = systemInfoGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021AFC RID: 137980 RVA: 0x00B6CF88 File Offset: 0x00B6B188
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_systemInfoBackgroundButton(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, testUIController.m_luaExportHelper.m_systemInfoBackgroundButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021AFD RID: 137981 RVA: 0x00B6CFE0 File Offset: 0x00B6B1E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_systemInfoBackgroundButton(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			Button systemInfoBackgroundButton;
			LuaObject.checkType<Button>(l, 2, out systemInfoBackgroundButton);
			testUIController.m_luaExportHelper.m_systemInfoBackgroundButton = systemInfoBackgroundButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021AFE RID: 137982 RVA: 0x00B6D03C File Offset: 0x00B6B23C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_systemInfoText(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, testUIController.m_luaExportHelper.m_systemInfoText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021AFF RID: 137983 RVA: 0x00B6D094 File Offset: 0x00B6B294
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_systemInfoText(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			Text systemInfoText;
			LuaObject.checkType<Text>(l, 2, out systemInfoText);
			testUIController.m_luaExportHelper.m_systemInfoText = systemInfoText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B00 RID: 137984 RVA: 0x00B6D0F0 File Offset: 0x00B6B2F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_prefabsGameObject(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, testUIController.m_luaExportHelper.m_prefabsGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B01 RID: 137985 RVA: 0x00B6D148 File Offset: 0x00B6B348
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_prefabsGameObject(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			GameObject prefabsGameObject;
			LuaObject.checkType<GameObject>(l, 2, out prefabsGameObject);
			testUIController.m_luaExportHelper.m_prefabsGameObject = prefabsGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B02 RID: 137986 RVA: 0x00B6D1A4 File Offset: 0x00B6B3A4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_testListItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, testUIController.m_luaExportHelper.m_testListItemPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B03 RID: 137987 RVA: 0x00B6D1FC File Offset: 0x00B6B3FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_testListItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			GameObject testListItemPrefab;
			LuaObject.checkType<GameObject>(l, 2, out testListItemPrefab);
			testUIController.m_luaExportHelper.m_testListItemPrefab = testListItemPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B04 RID: 137988 RVA: 0x00B6D258 File Offset: 0x00B6B458
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_serverDateTimeText(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, testUIController.m_luaExportHelper.m_serverDateTimeText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B05 RID: 137989 RVA: 0x00B6D2B0 File Offset: 0x00B6B4B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_serverDateTimeText(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			Text serverDateTimeText;
			LuaObject.checkType<Text>(l, 2, out serverDateTimeText);
			testUIController.m_luaExportHelper.m_serverDateTimeText = serverDateTimeText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B06 RID: 137990 RVA: 0x00B6D30C File Offset: 0x00B6B50C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_closeReportBugPanelButton(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, testUIController.m_luaExportHelper.m_closeReportBugPanelButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B07 RID: 137991 RVA: 0x00B6D364 File Offset: 0x00B6B564
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_closeReportBugPanelButton(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			Button closeReportBugPanelButton;
			LuaObject.checkType<Button>(l, 2, out closeReportBugPanelButton);
			testUIController.m_luaExportHelper.m_closeReportBugPanelButton = closeReportBugPanelButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B08 RID: 137992 RVA: 0x00B6D3C0 File Offset: 0x00B6B5C0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_reportBugPanelGameObject(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, testUIController.m_luaExportHelper.m_reportBugPanelGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B09 RID: 137993 RVA: 0x00B6D418 File Offset: 0x00B6B618
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_reportBugPanelGameObject(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			GameObject reportBugPanelGameObject;
			LuaObject.checkType<GameObject>(l, 2, out reportBugPanelGameObject);
			testUIController.m_luaExportHelper.m_reportBugPanelGameObject = reportBugPanelGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B0A RID: 137994 RVA: 0x00B6D474 File Offset: 0x00B6B674
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_oneHourLogTime(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, testUIController.m_luaExportHelper.m_oneHourLogTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B0B RID: 137995 RVA: 0x00B6D4CC File Offset: 0x00B6B6CC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_oneHourLogTime(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			Toggle oneHourLogTime;
			LuaObject.checkType<Toggle>(l, 2, out oneHourLogTime);
			testUIController.m_luaExportHelper.m_oneHourLogTime = oneHourLogTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B0C RID: 137996 RVA: 0x00B6D528 File Offset: 0x00B6B728
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_oneDayLogTime(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, testUIController.m_luaExportHelper.m_oneDayLogTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B0D RID: 137997 RVA: 0x00B6D580 File Offset: 0x00B6B780
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_oneDayLogTime(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			Toggle oneDayLogTime;
			LuaObject.checkType<Toggle>(l, 2, out oneDayLogTime);
			testUIController.m_luaExportHelper.m_oneDayLogTime = oneDayLogTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B0E RID: 137998 RVA: 0x00B6D5DC File Offset: 0x00B6B7DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_oneWeekLogTime(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, testUIController.m_luaExportHelper.m_oneWeekLogTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B0F RID: 137999 RVA: 0x00B6D634 File Offset: 0x00B6B834
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_oneWeekLogTime(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			Toggle oneWeekLogTime;
			LuaObject.checkType<Toggle>(l, 2, out oneWeekLogTime);
			testUIController.m_luaExportHelper.m_oneWeekLogTime = oneWeekLogTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B10 RID: 138000 RVA: 0x00B6D690 File Offset: 0x00B6B890
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_bugDescriptionInputField(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, testUIController.m_luaExportHelper.m_bugDescriptionInputField);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B11 RID: 138001 RVA: 0x00B6D6E8 File Offset: 0x00B6B8E8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_bugDescriptionInputField(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			InputField bugDescriptionInputField;
			LuaObject.checkType<InputField>(l, 2, out bugDescriptionInputField);
			testUIController.m_luaExportHelper.m_bugDescriptionInputField = bugDescriptionInputField;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B12 RID: 138002 RVA: 0x00B6D744 File Offset: 0x00B6B944
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_cancelReportBugButton(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, testUIController.m_luaExportHelper.m_cancelReportBugButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B13 RID: 138003 RVA: 0x00B6D79C File Offset: 0x00B6B99C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_cancelReportBugButton(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			Button cancelReportBugButton;
			LuaObject.checkType<Button>(l, 2, out cancelReportBugButton);
			testUIController.m_luaExportHelper.m_cancelReportBugButton = cancelReportBugButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B14 RID: 138004 RVA: 0x00B6D7F8 File Offset: 0x00B6B9F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_reportBugButton(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, testUIController.m_luaExportHelper.m_reportBugButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B15 RID: 138005 RVA: 0x00B6D850 File Offset: 0x00B6BA50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_reportBugButton(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			Button reportBugButton;
			LuaObject.checkType<Button>(l, 2, out reportBugButton);
			testUIController.m_luaExportHelper.m_reportBugButton = reportBugButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B16 RID: 138006 RVA: 0x00B6D8AC File Offset: 0x00B6BAAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_finishAllTasksButton(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, testUIController.m_luaExportHelper.m_finishAllTasksButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B17 RID: 138007 RVA: 0x00B6D904 File Offset: 0x00B6BB04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_finishAllTasksButton(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			Button finishAllTasksButton;
			LuaObject.checkType<Button>(l, 2, out finishAllTasksButton);
			testUIController.m_luaExportHelper.m_finishAllTasksButton = finishAllTasksButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B18 RID: 138008 RVA: 0x00B6D960 File Offset: 0x00B6BB60
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_testListItemUIControllers(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, testUIController.m_luaExportHelper.m_testListItemUIControllers);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B19 RID: 138009 RVA: 0x00B6D9B8 File Offset: 0x00B6BBB8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_testListItemUIControllers(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			List<TestListItemUIController> testListItemUIControllers;
			LuaObject.checkType<List<TestListItemUIController>>(l, 2, out testListItemUIControllers);
			testUIController.m_luaExportHelper.m_testListItemUIControllers = testListItemUIControllers;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B1A RID: 138010 RVA: 0x00B6DA14 File Offset: 0x00B6BC14
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_isIgnoreToggleEvent(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, testUIController.m_luaExportHelper.m_isIgnoreToggleEvent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B1B RID: 138011 RVA: 0x00B6DA6C File Offset: 0x00B6BC6C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_isIgnoreToggleEvent(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			bool isIgnoreToggleEvent;
			LuaObject.checkType(l, 2, out isIgnoreToggleEvent);
			testUIController.m_luaExportHelper.m_isIgnoreToggleEvent = isIgnoreToggleEvent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B1C RID: 138012 RVA: 0x00B6DAC8 File Offset: 0x00B6BCC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_CacheTestList(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, testUIController.m_luaExportHelper.m_CacheTestList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B1D RID: 138013 RVA: 0x00B6DB20 File Offset: 0x00B6BD20
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_CacheTestList(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			List<KeyValuePair<int, string>> cacheTestList;
			LuaObject.checkType<List<KeyValuePair<int, string>>>(l, 2, out cacheTestList);
			testUIController.m_luaExportHelper.m_CacheTestList = cacheTestList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B1E RID: 138014 RVA: 0x00B6DB7C File Offset: 0x00B6BD7C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_CurrSelectCtrl(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, testUIController.m_luaExportHelper.m_CurrSelectCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B1F RID: 138015 RVA: 0x00B6DBD4 File Offset: 0x00B6BDD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_CurrSelectCtrl(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			TestListItemUIController currSelectCtrl;
			LuaObject.checkType<TestListItemUIController>(l, 2, out currSelectCtrl);
			testUIController.m_luaExportHelper.m_CurrSelectCtrl = currSelectCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B20 RID: 138016 RVA: 0x00B6DC30 File Offset: 0x00B6BE30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_nSearchTestListId(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, testUIController.m_luaExportHelper.m_nSearchTestListId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B21 RID: 138017 RVA: 0x00B6DC88 File Offset: 0x00B6BE88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_nSearchTestListId(IntPtr l)
	{
		int result;
		try
		{
			TestUIController testUIController = (TestUIController)LuaObject.checkSelf(l);
			int nSearchTestListId;
			LuaObject.checkType(l, 2, out nSearchTestListId);
			testUIController.m_luaExportHelper.m_nSearchTestListId = nSearchTestListId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B22 RID: 138018 RVA: 0x00B6DCE4 File Offset: 0x00B6BEE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_MaxPlayerLevel(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, TestUIController.MaxPlayerLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B23 RID: 138019 RVA: 0x00B6DD2C File Offset: 0x00B6BF2C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.TestUIController");
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.SetTestListType);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.AddTestListItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.ClearTestList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.SetMonsterLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.GetMonsterLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.SetServerDataTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.ShowSystemInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.HideSystemInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.RefreshLoopVerticalScrollView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.BuildSystemInfoText_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.SetEnchantProperty_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.TenLevelUpEquipment_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.SpeedUpHero_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.ResetHero_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.GetSelectedTestListItemUIController);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.InitLoopScrollViewRect);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.OnTestItemFill);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.OnTestItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.DoToggle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.OnBattleToggle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.OnDialogToggle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.OnBattleDialogToggle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.OnUserGuideDialogToggle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.OnTestListHomeBtnClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.OnTestIdNextBtnClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.OnTestIdInput);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.OnStartTestButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.OnReturnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.OnSystemInfoButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.OnGoddessDialogButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.OnClearUserGuideButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.OnBecomeStrongButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.OnFinishAllTasksButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.FinishAllTasks);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.OnCancelReportBugButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.OniPhoneXToggleValueChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.OnReportBugButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.GetReportBugLogHours);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.OnOpenReportBugPanelButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.OnCompleteUserGuideButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.OnClearStageButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache29);
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.OnSystemInfoBackgroundButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache2A);
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache2B);
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache2C);
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache2D);
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache2E);
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache2F);
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache30);
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache31);
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache32);
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache33);
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache34);
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache35);
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache36);
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache37);
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.__callDele_EventOnChangeTestList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache38);
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.__clearDele_EventOnChangeTestList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache39);
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.__callDele_EventOnStartTest);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache3A);
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.__clearDele_EventOnStartTest);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache3B);
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.__callDele_EventOnShowSystemInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache3C);
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.__clearDele_EventOnShowSystemInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache3D);
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.__callDele_EventOnCloseSystemInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache3E);
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.__clearDele_EventOnCloseSystemInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache3F);
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.__callDele_EventOnShowGoddessDialog);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache40);
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.__clearDele_EventOnShowGoddessDialog);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache41);
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.__callDele_EventOnClearUserGuide);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache42);
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.__clearDele_EventOnClearUserGuide);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache43);
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.__callDele_EventOnCompleteUserGuide);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache44);
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.__clearDele_EventOnCompleteUserGuide);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache45);
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.__callDele_EventOnClearStage);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache46);
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.__clearDele_EventOnClearStage);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache47);
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.__callDele_EventOnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache48);
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.__clearDele_EventOnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache49);
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.__callDele_EventOnReportBug);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache4A);
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.__clearDele_EventOnReportBug);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache4B);
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.ScrollToItem_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache4C);
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.AppendLine_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache4D);
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.UpgradePlayerLevel_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache4E);
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.SpeedUpAllHeros_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache4F);
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.BecomeStrong_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache50);
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.GetHeroJobConnSequence_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache51);
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.GetJobSequence_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache52);
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.GetEquipmentLevelLimit_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache53);
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.IsEquipismentMaxLevel_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache54);
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache55 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache55 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.StarLevelUpTopRankEquipments_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache55);
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache56 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache56 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.AddItem4StarLevelUpEquipment_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache56);
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache57 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache57 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.AddGoods_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache57);
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache58 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache58 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.StarLevelUpEquipment_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache58);
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache59 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache59 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.EnhanceAllTopRankEquipments_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache59);
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache5A == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache5A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.EnhanceEquipment_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache5A);
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache5B == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache5B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.AddAllTopRankEquipments_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache5B);
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache5C == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache5C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.AddAllHeros_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache5C);
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache5D == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache5D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.AddHero_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache5D);
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache5E == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache5E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.HeroBreak_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache5E);
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache5F == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache5F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.BuyFixedStoreItem_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache5F);
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache60 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache60 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.TransferHeroJob_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache60);
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache61 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache61 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.AddAllItem_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache61);
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache62 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache62 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.UpgradeHeroJobLevel_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache62);
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache63 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache63 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.SendGMCommand_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache63);
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache64 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache64 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.UseItem_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache64);
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache65 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache65 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.AddHeroExp_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache65);
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache66 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache66 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.ErrorCodeToMessage_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache66);
		string name = "EventOnChangeTestList";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache67 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache67 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.set_EventOnChangeTestList);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache67, true);
		string name2 = "EventOnStartTest";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache68 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache68 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.set_EventOnStartTest);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache68, true);
		string name3 = "EventOnShowSystemInfo";
		LuaCSFunction get3 = null;
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache69 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache69 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.set_EventOnShowSystemInfo);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache69, true);
		string name4 = "EventOnCloseSystemInfo";
		LuaCSFunction get4 = null;
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache6A == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache6A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.set_EventOnCloseSystemInfo);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache6A, true);
		string name5 = "EventOnShowGoddessDialog";
		LuaCSFunction get5 = null;
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache6B == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache6B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.set_EventOnShowGoddessDialog);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache6B, true);
		string name6 = "EventOnClearUserGuide";
		LuaCSFunction get6 = null;
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache6C == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache6C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.set_EventOnClearUserGuide);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache6C, true);
		string name7 = "EventOnCompleteUserGuide";
		LuaCSFunction get7 = null;
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache6D == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache6D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.set_EventOnCompleteUserGuide);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache6D, true);
		string name8 = "EventOnClearStage";
		LuaCSFunction get8 = null;
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache6E == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache6E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.set_EventOnClearStage);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache6E, true);
		string name9 = "EventOnReturn";
		LuaCSFunction get9 = null;
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache6F == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache6F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.set_EventOnReturn);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache6F, true);
		string name10 = "EventOnReportBug";
		LuaCSFunction get10 = null;
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache70 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache70 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.set_EventOnReportBug);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache70, true);
		string name11 = "m_returnButton";
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache71 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache71 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.get_m_returnButton);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache71;
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache72 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache72 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.set_m_returnButton);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache72, true);
		string name12 = "m_systemInfoButton";
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache73 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache73 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.get_m_systemInfoButton);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache73;
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache74 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache74 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.set_m_systemInfoButton);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache74, true);
		string name13 = "m_goddessDialogButton";
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache75 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache75 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.get_m_goddessDialogButton);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache75;
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache76 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache76 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.set_m_goddessDialogButton);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache76, true);
		string name14 = "m_clearUserGuideButton";
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache77 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache77 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.get_m_clearUserGuideButton);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache77;
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache78 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache78 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.set_m_clearUserGuideButton);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache78, true);
		string name15 = "m_completeUserGuideButton";
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache79 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache79 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.get_m_completeUserGuideButton);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache79;
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache7A == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache7A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.set_m_completeUserGuideButton);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache7A, true);
		string name16 = "m_becomeStrongButton";
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache7B == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache7B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.get_m_becomeStrongButton);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache7B;
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache7C == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache7C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.set_m_becomeStrongButton);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache7C, true);
		string name17 = "m_becomeStrongPlayerLevelInput";
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache7D == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache7D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.get_m_becomeStrongPlayerLevelInput);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache7D;
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache7E == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache7E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.set_m_becomeStrongPlayerLevelInput);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache7E, true);
		string name18 = "m_becomeStrongHeroStarLevelInput";
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache7F == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache7F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.get_m_becomeStrongHeroStarLevelInput);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache7F;
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache80 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache80 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.set_m_becomeStrongHeroStarLevelInput);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache80, true);
		string name19 = "m_becomeStrongEquipmentLevelInput";
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache81 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache81 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.get_m_becomeStrongEquipmentLevelInput);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache81;
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache82 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache82 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.set_m_becomeStrongEquipmentLevelInput);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache82, true);
		string name20 = "m_clearStageButton";
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache83 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache83 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.get_m_clearStageButton);
		}
		LuaCSFunction get20 = Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache83;
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache84 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache84 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.set_m_clearStageButton);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache84, true);
		string name21 = "m_openReportBugPanelButton";
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache85 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache85 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.get_m_openReportBugPanelButton);
		}
		LuaCSFunction get21 = Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache85;
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache86 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache86 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.set_m_openReportBugPanelButton);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache86, true);
		string name22 = "m_iPhoneXToggle";
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache87 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache87 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.get_m_iPhoneXToggle);
		}
		LuaCSFunction get22 = Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache87;
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache88 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache88 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.set_m_iPhoneXToggle);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache88, true);
		string name23 = "m_battleToggle";
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache89 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache89 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.get_m_battleToggle);
		}
		LuaCSFunction get23 = Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache89;
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache8A == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache8A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.set_m_battleToggle);
		}
		LuaObject.addMember(l, name23, get23, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache8A, true);
		string name24 = "m_dialogToggle";
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache8B == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache8B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.get_m_dialogToggle);
		}
		LuaCSFunction get24 = Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache8B;
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache8C == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache8C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.set_m_dialogToggle);
		}
		LuaObject.addMember(l, name24, get24, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache8C, true);
		string name25 = "m_battleDialogToggle";
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache8D == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache8D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.get_m_battleDialogToggle);
		}
		LuaCSFunction get25 = Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache8D;
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache8E == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache8E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.set_m_battleDialogToggle);
		}
		LuaObject.addMember(l, name25, get25, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache8E, true);
		string name26 = "m_userGuideDialogToggle";
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache8F == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache8F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.get_m_userGuideDialogToggle);
		}
		LuaCSFunction get26 = Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache8F;
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache90 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache90 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.set_m_userGuideDialogToggle);
		}
		LuaObject.addMember(l, name26, get26, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache90, true);
		string name27 = "m_ListItemPool";
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache91 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache91 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.get_m_ListItemPool);
		}
		LuaCSFunction get27 = Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache91;
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache92 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache92 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.set_m_ListItemPool);
		}
		LuaObject.addMember(l, name27, get27, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache92, true);
		string name28 = "m_LoopScroolRect";
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache93 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache93 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.get_m_LoopScroolRect);
		}
		LuaCSFunction get28 = Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache93;
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache94 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache94 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.set_m_LoopScroolRect);
		}
		LuaObject.addMember(l, name28, get28, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache94, true);
		string name29 = "m_monsterLevelGameObject";
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache95 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache95 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.get_m_monsterLevelGameObject);
		}
		LuaCSFunction get29 = Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache95;
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache96 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache96 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.set_m_monsterLevelGameObject);
		}
		LuaObject.addMember(l, name29, get29, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache96, true);
		string name30 = "m_monsterLevelInputField";
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache97 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache97 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.get_m_monsterLevelInputField);
		}
		LuaCSFunction get30 = Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache97;
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache98 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache98 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.set_m_monsterLevelInputField);
		}
		LuaObject.addMember(l, name30, get30, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache98, true);
		string name31 = "m_startTestBattleButton";
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache99 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache99 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.get_m_startTestBattleButton);
		}
		LuaCSFunction get31 = Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache99;
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache9A == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache9A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.set_m_startTestBattleButton);
		}
		LuaObject.addMember(l, name31, get31, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache9A, true);
		string name32 = "m_TestIdInputField";
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache9B == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache9B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.get_m_TestIdInputField);
		}
		LuaCSFunction get32 = Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache9B;
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache9C == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache9C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.set_m_TestIdInputField);
		}
		LuaObject.addMember(l, name32, get32, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache9C, true);
		string name33 = "m_TestIdNextSearch";
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache9D == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache9D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.get_m_TestIdNextSearch);
		}
		LuaCSFunction get33 = Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache9D;
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache9E == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache9E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.set_m_TestIdNextSearch);
		}
		LuaObject.addMember(l, name33, get33, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache9E, true);
		string name34 = "m_TestListHomeBtn";
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache9F == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache9F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.get_m_TestListHomeBtn);
		}
		LuaCSFunction get34 = Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cache9F;
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheA0 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheA0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.set_m_TestListHomeBtn);
		}
		LuaObject.addMember(l, name34, get34, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheA0, true);
		string name35 = "m_systemInfoGameObject";
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheA1 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheA1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.get_m_systemInfoGameObject);
		}
		LuaCSFunction get35 = Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheA1;
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheA2 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheA2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.set_m_systemInfoGameObject);
		}
		LuaObject.addMember(l, name35, get35, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheA2, true);
		string name36 = "m_systemInfoBackgroundButton";
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheA3 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheA3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.get_m_systemInfoBackgroundButton);
		}
		LuaCSFunction get36 = Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheA3;
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheA4 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheA4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.set_m_systemInfoBackgroundButton);
		}
		LuaObject.addMember(l, name36, get36, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheA4, true);
		string name37 = "m_systemInfoText";
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheA5 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheA5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.get_m_systemInfoText);
		}
		LuaCSFunction get37 = Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheA5;
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheA6 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheA6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.set_m_systemInfoText);
		}
		LuaObject.addMember(l, name37, get37, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheA6, true);
		string name38 = "m_prefabsGameObject";
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheA7 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheA7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.get_m_prefabsGameObject);
		}
		LuaCSFunction get38 = Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheA7;
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheA8 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheA8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.set_m_prefabsGameObject);
		}
		LuaObject.addMember(l, name38, get38, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheA8, true);
		string name39 = "m_testListItemPrefab";
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheA9 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheA9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.get_m_testListItemPrefab);
		}
		LuaCSFunction get39 = Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheA9;
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheAA == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheAA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.set_m_testListItemPrefab);
		}
		LuaObject.addMember(l, name39, get39, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheAA, true);
		string name40 = "m_serverDateTimeText";
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheAB == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheAB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.get_m_serverDateTimeText);
		}
		LuaCSFunction get40 = Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheAB;
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheAC == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheAC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.set_m_serverDateTimeText);
		}
		LuaObject.addMember(l, name40, get40, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheAC, true);
		string name41 = "m_closeReportBugPanelButton";
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheAD == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheAD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.get_m_closeReportBugPanelButton);
		}
		LuaCSFunction get41 = Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheAD;
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheAE == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheAE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.set_m_closeReportBugPanelButton);
		}
		LuaObject.addMember(l, name41, get41, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheAE, true);
		string name42 = "m_reportBugPanelGameObject";
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheAF == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheAF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.get_m_reportBugPanelGameObject);
		}
		LuaCSFunction get42 = Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheAF;
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheB0 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheB0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.set_m_reportBugPanelGameObject);
		}
		LuaObject.addMember(l, name42, get42, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheB0, true);
		string name43 = "m_oneHourLogTime";
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheB1 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheB1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.get_m_oneHourLogTime);
		}
		LuaCSFunction get43 = Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheB1;
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheB2 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheB2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.set_m_oneHourLogTime);
		}
		LuaObject.addMember(l, name43, get43, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheB2, true);
		string name44 = "m_oneDayLogTime";
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheB3 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheB3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.get_m_oneDayLogTime);
		}
		LuaCSFunction get44 = Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheB3;
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheB4 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheB4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.set_m_oneDayLogTime);
		}
		LuaObject.addMember(l, name44, get44, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheB4, true);
		string name45 = "m_oneWeekLogTime";
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheB5 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheB5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.get_m_oneWeekLogTime);
		}
		LuaCSFunction get45 = Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheB5;
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheB6 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheB6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.set_m_oneWeekLogTime);
		}
		LuaObject.addMember(l, name45, get45, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheB6, true);
		string name46 = "m_bugDescriptionInputField";
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheB7 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheB7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.get_m_bugDescriptionInputField);
		}
		LuaCSFunction get46 = Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheB7;
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheB8 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheB8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.set_m_bugDescriptionInputField);
		}
		LuaObject.addMember(l, name46, get46, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheB8, true);
		string name47 = "m_cancelReportBugButton";
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheB9 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheB9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.get_m_cancelReportBugButton);
		}
		LuaCSFunction get47 = Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheB9;
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheBA == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheBA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.set_m_cancelReportBugButton);
		}
		LuaObject.addMember(l, name47, get47, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheBA, true);
		string name48 = "m_reportBugButton";
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheBB == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheBB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.get_m_reportBugButton);
		}
		LuaCSFunction get48 = Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheBB;
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheBC == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheBC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.set_m_reportBugButton);
		}
		LuaObject.addMember(l, name48, get48, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheBC, true);
		string name49 = "m_finishAllTasksButton";
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheBD == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheBD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.get_m_finishAllTasksButton);
		}
		LuaCSFunction get49 = Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheBD;
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheBE == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheBE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.set_m_finishAllTasksButton);
		}
		LuaObject.addMember(l, name49, get49, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheBE, true);
		string name50 = "m_testListItemUIControllers";
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheBF == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheBF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.get_m_testListItemUIControllers);
		}
		LuaCSFunction get50 = Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheBF;
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheC0 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheC0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.set_m_testListItemUIControllers);
		}
		LuaObject.addMember(l, name50, get50, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheC0, true);
		string name51 = "m_isIgnoreToggleEvent";
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheC1 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheC1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.get_m_isIgnoreToggleEvent);
		}
		LuaCSFunction get51 = Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheC1;
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheC2 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheC2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.set_m_isIgnoreToggleEvent);
		}
		LuaObject.addMember(l, name51, get51, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheC2, true);
		string name52 = "m_CacheTestList";
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheC3 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheC3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.get_m_CacheTestList);
		}
		LuaCSFunction get52 = Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheC3;
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheC4 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheC4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.set_m_CacheTestList);
		}
		LuaObject.addMember(l, name52, get52, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheC4, true);
		string name53 = "m_CurrSelectCtrl";
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheC5 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheC5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.get_m_CurrSelectCtrl);
		}
		LuaCSFunction get53 = Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheC5;
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheC6 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheC6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.set_m_CurrSelectCtrl);
		}
		LuaObject.addMember(l, name53, get53, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheC6, true);
		string name54 = "m_nSearchTestListId";
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheC7 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheC7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.get_m_nSearchTestListId);
		}
		LuaCSFunction get54 = Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheC7;
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheC8 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheC8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.set_m_nSearchTestListId);
		}
		LuaObject.addMember(l, name54, get54, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheC8, true);
		string name55 = "MaxPlayerLevel";
		if (Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheC9 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheC9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUIController.get_MaxPlayerLevel);
		}
		LuaObject.addMember(l, name55, Lua_BlackJack_ProjectL_UI_TestUIController.<>f__mg$cacheC9, null, false);
		LuaObject.createTypeMetatable(l, null, typeof(TestUIController), typeof(UIControllerBase));
	}

	// Token: 0x040178E1 RID: 96481
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040178E2 RID: 96482
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040178E3 RID: 96483
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040178E4 RID: 96484
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040178E5 RID: 96485
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040178E6 RID: 96486
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040178E7 RID: 96487
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040178E8 RID: 96488
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040178E9 RID: 96489
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040178EA RID: 96490
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040178EB RID: 96491
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040178EC RID: 96492
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040178ED RID: 96493
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040178EE RID: 96494
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040178EF RID: 96495
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040178F0 RID: 96496
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040178F1 RID: 96497
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040178F2 RID: 96498
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040178F3 RID: 96499
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040178F4 RID: 96500
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x040178F5 RID: 96501
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x040178F6 RID: 96502
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x040178F7 RID: 96503
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x040178F8 RID: 96504
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x040178F9 RID: 96505
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x040178FA RID: 96506
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x040178FB RID: 96507
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x040178FC RID: 96508
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x040178FD RID: 96509
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x040178FE RID: 96510
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x040178FF RID: 96511
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04017900 RID: 96512
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04017901 RID: 96513
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04017902 RID: 96514
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04017903 RID: 96515
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04017904 RID: 96516
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04017905 RID: 96517
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04017906 RID: 96518
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04017907 RID: 96519
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04017908 RID: 96520
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04017909 RID: 96521
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0401790A RID: 96522
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0401790B RID: 96523
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0401790C RID: 96524
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0401790D RID: 96525
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0401790E RID: 96526
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0401790F RID: 96527
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04017910 RID: 96528
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04017911 RID: 96529
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04017912 RID: 96530
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04017913 RID: 96531
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04017914 RID: 96532
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04017915 RID: 96533
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04017916 RID: 96534
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04017917 RID: 96535
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04017918 RID: 96536
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04017919 RID: 96537
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x0401791A RID: 96538
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x0401791B RID: 96539
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x0401791C RID: 96540
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x0401791D RID: 96541
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x0401791E RID: 96542
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x0401791F RID: 96543
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x04017920 RID: 96544
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x04017921 RID: 96545
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x04017922 RID: 96546
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x04017923 RID: 96547
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x04017924 RID: 96548
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x04017925 RID: 96549
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x04017926 RID: 96550
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x04017927 RID: 96551
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x04017928 RID: 96552
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x04017929 RID: 96553
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x0401792A RID: 96554
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x0401792B RID: 96555
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x0401792C RID: 96556
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x0401792D RID: 96557
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x0401792E RID: 96558
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x0401792F RID: 96559
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x04017930 RID: 96560
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x04017931 RID: 96561
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x04017932 RID: 96562
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x04017933 RID: 96563
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x04017934 RID: 96564
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x04017935 RID: 96565
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x04017936 RID: 96566
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x04017937 RID: 96567
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x04017938 RID: 96568
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x04017939 RID: 96569
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x0401793A RID: 96570
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;

	// Token: 0x0401793B RID: 96571
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5A;

	// Token: 0x0401793C RID: 96572
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5B;

	// Token: 0x0401793D RID: 96573
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5C;

	// Token: 0x0401793E RID: 96574
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5D;

	// Token: 0x0401793F RID: 96575
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5E;

	// Token: 0x04017940 RID: 96576
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5F;

	// Token: 0x04017941 RID: 96577
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache60;

	// Token: 0x04017942 RID: 96578
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache61;

	// Token: 0x04017943 RID: 96579
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache62;

	// Token: 0x04017944 RID: 96580
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache63;

	// Token: 0x04017945 RID: 96581
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache64;

	// Token: 0x04017946 RID: 96582
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache65;

	// Token: 0x04017947 RID: 96583
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache66;

	// Token: 0x04017948 RID: 96584
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache67;

	// Token: 0x04017949 RID: 96585
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache68;

	// Token: 0x0401794A RID: 96586
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache69;

	// Token: 0x0401794B RID: 96587
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6A;

	// Token: 0x0401794C RID: 96588
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6B;

	// Token: 0x0401794D RID: 96589
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6C;

	// Token: 0x0401794E RID: 96590
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6D;

	// Token: 0x0401794F RID: 96591
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6E;

	// Token: 0x04017950 RID: 96592
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6F;

	// Token: 0x04017951 RID: 96593
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache70;

	// Token: 0x04017952 RID: 96594
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache71;

	// Token: 0x04017953 RID: 96595
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache72;

	// Token: 0x04017954 RID: 96596
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache73;

	// Token: 0x04017955 RID: 96597
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache74;

	// Token: 0x04017956 RID: 96598
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache75;

	// Token: 0x04017957 RID: 96599
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache76;

	// Token: 0x04017958 RID: 96600
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache77;

	// Token: 0x04017959 RID: 96601
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache78;

	// Token: 0x0401795A RID: 96602
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache79;

	// Token: 0x0401795B RID: 96603
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7A;

	// Token: 0x0401795C RID: 96604
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7B;

	// Token: 0x0401795D RID: 96605
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7C;

	// Token: 0x0401795E RID: 96606
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7D;

	// Token: 0x0401795F RID: 96607
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7E;

	// Token: 0x04017960 RID: 96608
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7F;

	// Token: 0x04017961 RID: 96609
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache80;

	// Token: 0x04017962 RID: 96610
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache81;

	// Token: 0x04017963 RID: 96611
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache82;

	// Token: 0x04017964 RID: 96612
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache83;

	// Token: 0x04017965 RID: 96613
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache84;

	// Token: 0x04017966 RID: 96614
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache85;

	// Token: 0x04017967 RID: 96615
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache86;

	// Token: 0x04017968 RID: 96616
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache87;

	// Token: 0x04017969 RID: 96617
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache88;

	// Token: 0x0401796A RID: 96618
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache89;

	// Token: 0x0401796B RID: 96619
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8A;

	// Token: 0x0401796C RID: 96620
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8B;

	// Token: 0x0401796D RID: 96621
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8C;

	// Token: 0x0401796E RID: 96622
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8D;

	// Token: 0x0401796F RID: 96623
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8E;

	// Token: 0x04017970 RID: 96624
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8F;

	// Token: 0x04017971 RID: 96625
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache90;

	// Token: 0x04017972 RID: 96626
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache91;

	// Token: 0x04017973 RID: 96627
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache92;

	// Token: 0x04017974 RID: 96628
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache93;

	// Token: 0x04017975 RID: 96629
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache94;

	// Token: 0x04017976 RID: 96630
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache95;

	// Token: 0x04017977 RID: 96631
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache96;

	// Token: 0x04017978 RID: 96632
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache97;

	// Token: 0x04017979 RID: 96633
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache98;

	// Token: 0x0401797A RID: 96634
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache99;

	// Token: 0x0401797B RID: 96635
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9A;

	// Token: 0x0401797C RID: 96636
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9B;

	// Token: 0x0401797D RID: 96637
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9C;

	// Token: 0x0401797E RID: 96638
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9D;

	// Token: 0x0401797F RID: 96639
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9E;

	// Token: 0x04017980 RID: 96640
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9F;

	// Token: 0x04017981 RID: 96641
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA0;

	// Token: 0x04017982 RID: 96642
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA1;

	// Token: 0x04017983 RID: 96643
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA2;

	// Token: 0x04017984 RID: 96644
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA3;

	// Token: 0x04017985 RID: 96645
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA4;

	// Token: 0x04017986 RID: 96646
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA5;

	// Token: 0x04017987 RID: 96647
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA6;

	// Token: 0x04017988 RID: 96648
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA7;

	// Token: 0x04017989 RID: 96649
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA8;

	// Token: 0x0401798A RID: 96650
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA9;

	// Token: 0x0401798B RID: 96651
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAA;

	// Token: 0x0401798C RID: 96652
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAB;

	// Token: 0x0401798D RID: 96653
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAC;

	// Token: 0x0401798E RID: 96654
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAD;

	// Token: 0x0401798F RID: 96655
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAE;

	// Token: 0x04017990 RID: 96656
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAF;

	// Token: 0x04017991 RID: 96657
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB0;

	// Token: 0x04017992 RID: 96658
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB1;

	// Token: 0x04017993 RID: 96659
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB2;

	// Token: 0x04017994 RID: 96660
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB3;

	// Token: 0x04017995 RID: 96661
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB4;

	// Token: 0x04017996 RID: 96662
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB5;

	// Token: 0x04017997 RID: 96663
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB6;

	// Token: 0x04017998 RID: 96664
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB7;

	// Token: 0x04017999 RID: 96665
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB8;

	// Token: 0x0401799A RID: 96666
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB9;

	// Token: 0x0401799B RID: 96667
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBA;

	// Token: 0x0401799C RID: 96668
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBB;

	// Token: 0x0401799D RID: 96669
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBC;

	// Token: 0x0401799E RID: 96670
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBD;

	// Token: 0x0401799F RID: 96671
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBE;

	// Token: 0x040179A0 RID: 96672
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBF;

	// Token: 0x040179A1 RID: 96673
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC0;

	// Token: 0x040179A2 RID: 96674
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC1;

	// Token: 0x040179A3 RID: 96675
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC2;

	// Token: 0x040179A4 RID: 96676
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC3;

	// Token: 0x040179A5 RID: 96677
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC4;

	// Token: 0x040179A6 RID: 96678
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC5;

	// Token: 0x040179A7 RID: 96679
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC6;

	// Token: 0x040179A8 RID: 96680
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC7;

	// Token: 0x040179A9 RID: 96681
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC8;

	// Token: 0x040179AA RID: 96682
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC9;
}
