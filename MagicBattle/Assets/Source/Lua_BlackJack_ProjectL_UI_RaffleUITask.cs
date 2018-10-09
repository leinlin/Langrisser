using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Scene;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.UI;
using BlackJack.ProjectLBasic;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001544 RID: 5444
[Preserve]
public class Lua_BlackJack_ProjectL_UI_RaffleUITask : LuaObject
{
	// Token: 0x0602085A RID: 133210 RVA: 0x00AD9838 File Offset: 0x00AD7A38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string name;
			LuaObject.checkType(l, 2, out name);
			RaffleUITask o = new RaffleUITask(name);
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

	// Token: 0x0602085B RID: 133211 RVA: 0x00AD988C File Offset: 0x00AD7A8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStart(IntPtr l)
	{
		int result;
		try
		{
			RaffleUITask raffleUITask = (RaffleUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = raffleUITask.m_luaExportHelper.OnStart(intent);
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

	// Token: 0x0602085C RID: 133212 RVA: 0x00AD98F4 File Offset: 0x00AD7AF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStop(IntPtr l)
	{
		int result;
		try
		{
			RaffleUITask raffleUITask = (RaffleUITask)LuaObject.checkSelf(l);
			raffleUITask.m_luaExportHelper.OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602085D RID: 133213 RVA: 0x00AD9948 File Offset: 0x00AD7B48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPause(IntPtr l)
	{
		int result;
		try
		{
			RaffleUITask raffleUITask = (RaffleUITask)LuaObject.checkSelf(l);
			raffleUITask.m_luaExportHelper.OnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602085E RID: 133214 RVA: 0x00AD999C File Offset: 0x00AD7B9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnResume(IntPtr l)
	{
		int result;
		try
		{
			RaffleUITask raffleUITask = (RaffleUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = raffleUITask.m_luaExportHelper.OnResume(intent);
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

	// Token: 0x0602085F RID: 133215 RVA: 0x00AD9A04 File Offset: 0x00AD7C04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsNeedUpdateDataCache(IntPtr l)
	{
		int result;
		try
		{
			RaffleUITask raffleUITask = (RaffleUITask)LuaObject.checkSelf(l);
			bool b = raffleUITask.m_luaExportHelper.IsNeedUpdateDataCache();
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

	// Token: 0x06020860 RID: 133216 RVA: 0x00AD9A60 File Offset: 0x00AD7C60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateDataCache(IntPtr l)
	{
		int result;
		try
		{
			RaffleUITask raffleUITask = (RaffleUITask)LuaObject.checkSelf(l);
			raffleUITask.m_luaExportHelper.UpdateDataCache();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020861 RID: 133217 RVA: 0x00AD9AB4 File Offset: 0x00AD7CB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			RaffleUITask raffleUITask = (RaffleUITask)LuaObject.checkSelf(l);
			bool b = raffleUITask.m_luaExportHelper.IsNeedLoadDynamicRes();
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

	// Token: 0x06020862 RID: 133218 RVA: 0x00AD9B10 File Offset: 0x00AD7D10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitLayerStateOnLoadAllResCompleted(IntPtr l)
	{
		int result;
		try
		{
			RaffleUITask raffleUITask = (RaffleUITask)LuaObject.checkSelf(l);
			raffleUITask.m_luaExportHelper.InitLayerStateOnLoadAllResCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020863 RID: 133219 RVA: 0x00AD9B64 File Offset: 0x00AD7D64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitLayerStateOnResume(IntPtr l)
	{
		int result;
		try
		{
			RaffleUITask raffleUITask = (RaffleUITask)LuaObject.checkSelf(l);
			raffleUITask.m_luaExportHelper.InitLayerStateOnResume();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020864 RID: 133220 RVA: 0x00AD9BB8 File Offset: 0x00AD7DB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitAllUIControllers(IntPtr l)
	{
		int result;
		try
		{
			RaffleUITask raffleUITask = (RaffleUITask)LuaObject.checkSelf(l);
			raffleUITask.m_luaExportHelper.InitAllUIControllers();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020865 RID: 133221 RVA: 0x00AD9C0C File Offset: 0x00AD7E0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateView(IntPtr l)
	{
		int result;
		try
		{
			RaffleUITask raffleUITask = (RaffleUITask)LuaObject.checkSelf(l);
			raffleUITask.m_luaExportHelper.UpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020866 RID: 133222 RVA: 0x00AD9C60 File Offset: 0x00AD7E60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateDrawAnimation(IntPtr l)
	{
		int result;
		try
		{
			RaffleUITask raffleUITask = (RaffleUITask)LuaObject.checkSelf(l);
			raffleUITask.m_luaExportHelper.UpdateDrawAnimation();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020867 RID: 133223 RVA: 0x00AD9CB4 File Offset: 0x00AD7EB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearContextOnPause(IntPtr l)
	{
		int result;
		try
		{
			RaffleUITask raffleUITask = (RaffleUITask)LuaObject.checkSelf(l);
			raffleUITask.m_luaExportHelper.ClearContextOnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020868 RID: 133224 RVA: 0x00AD9D08 File Offset: 0x00AD7F08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBgButtonClick(IntPtr l)
	{
		int result;
		try
		{
			RaffleUITask raffleUITask = (RaffleUITask)LuaObject.checkSelf(l);
			raffleUITask.m_luaExportHelper.OnBgButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020869 RID: 133225 RVA: 0x00AD9D5C File Offset: 0x00AD7F5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnShowHelpButtonClick(IntPtr l)
	{
		int result;
		try
		{
			RaffleUITask raffleUITask = (RaffleUITask)LuaObject.checkSelf(l);
			raffleUITask.m_luaExportHelper.OnShowHelpButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602086A RID: 133226 RVA: 0x00AD9DB0 File Offset: 0x00AD7FB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnRewardPanelButtonClick(IntPtr l)
	{
		int result;
		try
		{
			RaffleUITask raffleUITask = (RaffleUITask)LuaObject.checkSelf(l);
			raffleUITask.m_luaExportHelper.OnRewardPanelButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602086B RID: 133227 RVA: 0x00AD9E04 File Offset: 0x00AD8004
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnDoRaffleButtonClick(IntPtr l)
	{
		int result;
		try
		{
			RaffleUITask raffleUITask = (RaffleUITask)LuaObject.checkSelf(l);
			raffleUITask.m_luaExportHelper.OnDoRaffleButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602086C RID: 133228 RVA: 0x00AD9E58 File Offset: 0x00AD8058
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartDrawAnimation(IntPtr l)
	{
		int result;
		try
		{
			RaffleUITask raffleUITask = (RaffleUITask)LuaObject.checkSelf(l);
			int raffleId;
			LuaObject.checkType(l, 2, out raffleId);
			List<Goods> goods;
			LuaObject.checkType<List<Goods>>(l, 3, out goods);
			raffleUITask.m_luaExportHelper.StartDrawAnimation(raffleId, goods);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602086D RID: 133229 RVA: 0x00AD9EC4 File Offset: 0x00AD80C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OpenSrBox(IntPtr l)
	{
		int result;
		try
		{
			RaffleUITask raffleUITask = (RaffleUITask)LuaObject.checkSelf(l);
			Goods goods;
			LuaObject.checkType<Goods>(l, 2, out goods);
			Action<List<Goods>> onEnd;
			LuaObject.checkDelegate<Action<List<Goods>>>(l, 3, out onEnd);
			raffleUITask.m_luaExportHelper.OpenSrBox(goods, onEnd);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602086E RID: 133230 RVA: 0x00AD9F30 File Offset: 0x00AD8130
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsSrBox(IntPtr l)
	{
		int result;
		try
		{
			RaffleUITask raffleUITask = (RaffleUITask)LuaObject.checkSelf(l);
			Goods goods;
			LuaObject.checkType<Goods>(l, 2, out goods);
			bool b = raffleUITask.m_luaExportHelper.IsSrBox(goods);
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

	// Token: 0x0602086F RID: 133231 RVA: 0x00AD9F98 File Offset: 0x00AD8198
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnRechargeDialogResult(IntPtr l)
	{
		int result2;
		try
		{
			RaffleUITask raffleUITask = (RaffleUITask)LuaObject.checkSelf(l);
			DialogBoxResult result;
			LuaObject.checkEnum<DialogBoxResult>(l, 2, out result);
			raffleUITask.m_luaExportHelper.OnRechargeDialogResult(result);
			LuaObject.pushValue(l, true);
			result2 = 1;
		}
		catch (Exception e)
		{
			result2 = LuaObject.error(l, e);
		}
		return result2;
	}

	// Token: 0x06020870 RID: 133232 RVA: 0x00AD9FF4 File Offset: 0x00AD81F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnNotEnoughItemDialogResult(IntPtr l)
	{
		int result2;
		try
		{
			RaffleUITask raffleUITask = (RaffleUITask)LuaObject.checkSelf(l);
			DialogBoxResult result;
			LuaObject.checkEnum<DialogBoxResult>(l, 2, out result);
			raffleUITask.m_luaExportHelper.OnNotEnoughItemDialogResult(result);
			LuaObject.pushValue(l, true);
			result2 = 1;
		}
		catch (Exception e)
		{
			result2 = LuaObject.error(l, e);
		}
		return result2;
	}

	// Token: 0x06020871 RID: 133233 RVA: 0x00ADA050 File Offset: 0x00AD8250
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnRewardPanelCloseButtonClick(IntPtr l)
	{
		int result;
		try
		{
			RaffleUITask raffleUITask = (RaffleUITask)LuaObject.checkSelf(l);
			raffleUITask.m_luaExportHelper.OnRewardPanelCloseButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020872 RID: 133234 RVA: 0x00ADA0A4 File Offset: 0x00AD82A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnLevelEffectBgButtonClick(IntPtr l)
	{
		int result;
		try
		{
			RaffleUITask raffleUITask = (RaffleUITask)LuaObject.checkSelf(l);
			raffleUITask.m_luaExportHelper.OnLevelEffectBgButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020873 RID: 133235 RVA: 0x00ADA0F8 File Offset: 0x00AD82F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnRewardGoodsUITaskClose(IntPtr l)
	{
		int result;
		try
		{
			RaffleUITask raffleUITask = (RaffleUITask)LuaObject.checkSelf(l);
			raffleUITask.m_luaExportHelper.OnRewardGoodsUITaskClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020874 RID: 133236 RVA: 0x00ADA14C File Offset: 0x00AD834C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowErrorTipWnd(IntPtr l)
	{
		int result;
		try
		{
			RaffleUITask raffleUITask = (RaffleUITask)LuaObject.checkSelf(l);
			int errorCode;
			LuaObject.checkType(l, 2, out errorCode);
			raffleUITask.m_luaExportHelper.ShowErrorTipWnd(errorCode);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020875 RID: 133237 RVA: 0x00ADA1A8 File Offset: 0x00AD83A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsPipelineStateMaskNeedUpdate(IntPtr l)
	{
		int result;
		try
		{
			RaffleUITask raffleUITask = (RaffleUITask)LuaObject.checkSelf(l);
			RaffleUITask.PipeLineStateMaskType state;
			LuaObject.checkEnum<RaffleUITask.PipeLineStateMaskType>(l, 2, out state);
			bool b = raffleUITask.m_luaExportHelper.IsPipelineStateMaskNeedUpdate(state);
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

	// Token: 0x06020876 RID: 133238 RVA: 0x00ADA210 File Offset: 0x00AD8410
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int EnablePipelineStateMask(IntPtr l)
	{
		int result;
		try
		{
			RaffleUITask raffleUITask = (RaffleUITask)LuaObject.checkSelf(l);
			RaffleUITask.PipeLineStateMaskType state;
			LuaObject.checkEnum<RaffleUITask.PipeLineStateMaskType>(l, 2, out state);
			raffleUITask.m_luaExportHelper.EnablePipelineStateMask(state);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020877 RID: 133239 RVA: 0x00ADA26C File Offset: 0x00AD846C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowNotEnoughCrystalMsgBox(IntPtr l)
	{
		int result;
		try
		{
			RaffleUITask raffleUITask = (RaffleUITask)LuaObject.checkSelf(l);
			raffleUITask.m_luaExportHelper.ShowNotEnoughCrystalMsgBox();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020878 RID: 133240 RVA: 0x00ADA2C0 File Offset: 0x00AD84C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowNotEoughItemMsgBox(IntPtr l)
	{
		int result;
		try
		{
			RaffleUITask raffleUITask = (RaffleUITask)LuaObject.checkSelf(l);
			raffleUITask.m_luaExportHelper.ShowNotEoughItemMsgBox();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020879 RID: 133241 RVA: 0x00ADA314 File Offset: 0x00AD8514
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStart(IntPtr l)
	{
		int result;
		try
		{
			RaffleUITask raffleUITask = (RaffleUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = raffleUITask.m_luaExportHelper.__callBase_OnStart(intent);
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

	// Token: 0x0602087A RID: 133242 RVA: 0x00ADA37C File Offset: 0x00AD857C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStop(IntPtr l)
	{
		int result;
		try
		{
			RaffleUITask raffleUITask = (RaffleUITask)LuaObject.checkSelf(l);
			raffleUITask.m_luaExportHelper.__callBase_OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602087B RID: 133243 RVA: 0x00ADA3D0 File Offset: 0x00AD85D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnPause(IntPtr l)
	{
		int result;
		try
		{
			RaffleUITask raffleUITask = (RaffleUITask)LuaObject.checkSelf(l);
			raffleUITask.m_luaExportHelper.__callBase_OnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602087C RID: 133244 RVA: 0x00ADA424 File Offset: 0x00AD8624
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnResume(IntPtr l)
	{
		int result;
		try
		{
			RaffleUITask raffleUITask = (RaffleUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = raffleUITask.m_luaExportHelper.__callBase_OnResume(intent);
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

	// Token: 0x0602087D RID: 133245 RVA: 0x00ADA48C File Offset: 0x00AD868C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnNewIntent(IntPtr l)
	{
		int result;
		try
		{
			RaffleUITask raffleUITask = (RaffleUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = raffleUITask.m_luaExportHelper.__callBase_OnNewIntent(intent);
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

	// Token: 0x0602087E RID: 133246 RVA: 0x00ADA4F4 File Offset: 0x00AD86F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_EnableUIInput(IntPtr l)
	{
		int result;
		try
		{
			RaffleUITask raffleUITask = (RaffleUITask)LuaObject.checkSelf(l);
			bool isEnable;
			LuaObject.checkType(l, 2, out isEnable);
			bool? isGlobalEnable;
			LuaObject.checkNullable<bool>(l, 3, out isGlobalEnable);
			raffleUITask.m_luaExportHelper.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602087F RID: 133247 RVA: 0x00ADA560 File Offset: 0x00AD8760
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			RaffleUITask raffleUITask = (RaffleUITask)LuaObject.checkSelf(l);
			bool b = raffleUITask.m_luaExportHelper.__callBase_IsNeedLoadDynamicRes();
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

	// Token: 0x06020880 RID: 133248 RVA: 0x00ADA5BC File Offset: 0x00AD87BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAllDynamicResForLoad(IntPtr l)
	{
		int result;
		try
		{
			RaffleUITask raffleUITask = (RaffleUITask)LuaObject.checkSelf(l);
			List<string> o = raffleUITask.m_luaExportHelper.__callBase_CollectAllDynamicResForLoad();
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

	// Token: 0x06020881 RID: 133249 RVA: 0x00ADA618 File Offset: 0x00AD8818
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_RegisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			RaffleUITask raffleUITask = (RaffleUITask)LuaObject.checkSelf(l);
			raffleUITask.m_luaExportHelper.__callBase_RegisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020882 RID: 133250 RVA: 0x00ADA66C File Offset: 0x00AD886C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_UnregisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			RaffleUITask raffleUITask = (RaffleUITask)LuaObject.checkSelf(l);
			raffleUITask.m_luaExportHelper.__callBase_UnregisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020883 RID: 133251 RVA: 0x00ADA6C0 File Offset: 0x00AD88C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostUpdateView(IntPtr l)
	{
		int result;
		try
		{
			RaffleUITask raffleUITask = (RaffleUITask)LuaObject.checkSelf(l);
			raffleUITask.m_luaExportHelper.__callBase_PostUpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020884 RID: 133252 RVA: 0x00ADA714 File Offset: 0x00AD8914
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectPreloadResourceList(IntPtr l)
	{
		int result;
		try
		{
			RaffleUITask raffleUITask = (RaffleUITask)LuaObject.checkSelf(l);
			raffleUITask.m_luaExportHelper.__callBase_CollectPreloadResourceList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020885 RID: 133253 RVA: 0x00ADA768 File Offset: 0x00AD8968
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearAssetList(IntPtr l)
	{
		int result;
		try
		{
			RaffleUITask raffleUITask = (RaffleUITask)LuaObject.checkSelf(l);
			raffleUITask.m_luaExportHelper.__callBase_ClearAssetList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020886 RID: 133254 RVA: 0x00ADA7BC File Offset: 0x00AD89BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAsset(IntPtr l)
	{
		int result;
		try
		{
			RaffleUITask raffleUITask = (RaffleUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			raffleUITask.m_luaExportHelper.__callBase_CollectAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020887 RID: 133255 RVA: 0x00ADA818 File Offset: 0x00AD8A18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectSpriteAsset(IntPtr l)
	{
		int result;
		try
		{
			RaffleUITask raffleUITask = (RaffleUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			raffleUITask.m_luaExportHelper.__callBase_CollectSpriteAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020888 RID: 133256 RVA: 0x00ADA874 File Offset: 0x00AD8A74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectFxAsset(IntPtr l)
	{
		int result;
		try
		{
			RaffleUITask raffleUITask = (RaffleUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			raffleUITask.m_luaExportHelper.__callBase_CollectFxAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020889 RID: 133257 RVA: 0x00ADA8D0 File Offset: 0x00AD8AD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_StartLoadCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			RaffleUITask raffleUITask = (RaffleUITask)LuaObject.checkSelf(l);
			Action onLoadCompleted;
			LuaObject.checkDelegate<Action>(l, 2, out onLoadCompleted);
			raffleUITask.m_luaExportHelper.__callBase_StartLoadCustomAssets(onLoadCompleted);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602088A RID: 133258 RVA: 0x00ADA92C File Offset: 0x00AD8B2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsLoadingCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			RaffleUITask raffleUITask = (RaffleUITask)LuaObject.checkSelf(l);
			bool b = raffleUITask.m_luaExportHelper.__callBase_IsLoadingCustomAssets();
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

	// Token: 0x0602088B RID: 133259 RVA: 0x00ADA988 File Offset: 0x00AD8B88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsPipeLineRunning(IntPtr l)
	{
		int result;
		try
		{
			RaffleUITask raffleUITask = (RaffleUITask)LuaObject.checkSelf(l);
			bool b = raffleUITask.m_luaExportHelper.__callBase_IsPipeLineRunning();
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

	// Token: 0x0602088C RID: 133260 RVA: 0x00ADA9E4 File Offset: 0x00AD8BE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsOpeningUI(IntPtr l)
	{
		int result;
		try
		{
			RaffleUITask raffleUITask = (RaffleUITask)LuaObject.checkSelf(l);
			bool b = raffleUITask.m_luaExportHelper.__callBase_IsOpeningUI();
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

	// Token: 0x0602088D RID: 133261 RVA: 0x00ADAA40 File Offset: 0x00AD8C40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ReturnPrevUITask(IntPtr l)
	{
		int result;
		try
		{
			RaffleUITask raffleUITask = (RaffleUITask)LuaObject.checkSelf(l);
			UITaskBase o = raffleUITask.m_luaExportHelper.__callBase_ReturnPrevUITask();
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

	// Token: 0x0602088E RID: 133262 RVA: 0x00ADAA9C File Offset: 0x00AD8C9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearUnusedDynamicResourceCache(IntPtr l)
	{
		int result;
		try
		{
			RaffleUITask raffleUITask = (RaffleUITask)LuaObject.checkSelf(l);
			raffleUITask.m_luaExportHelper.__callBase_ClearUnusedDynamicResourceCache();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602088F RID: 133263 RVA: 0x00ADAAF0 File Offset: 0x00AD8CF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnMemoryWarning(IntPtr l)
	{
		int result;
		try
		{
			RaffleUITask raffleUITask = (RaffleUITask)LuaObject.checkSelf(l);
			raffleUITask.m_luaExportHelper.__callBase_OnMemoryWarning();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020890 RID: 133264 RVA: 0x00ADAB44 File Offset: 0x00AD8D44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_getRewardGoodsUITask(IntPtr l)
	{
		int result;
		try
		{
			RaffleUITask raffleUITask = (RaffleUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raffleUITask.m_luaExportHelper.m_getRewardGoodsUITask);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020891 RID: 133265 RVA: 0x00ADAB9C File Offset: 0x00AD8D9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_getRewardGoodsUITask(IntPtr l)
	{
		int result;
		try
		{
			RaffleUITask raffleUITask = (RaffleUITask)LuaObject.checkSelf(l);
			GetRewardGoodsUITask getRewardGoodsUITask;
			LuaObject.checkType<GetRewardGoodsUITask>(l, 2, out getRewardGoodsUITask);
			raffleUITask.m_luaExportHelper.m_getRewardGoodsUITask = getRewardGoodsUITask;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020892 RID: 133266 RVA: 0x00ADABF8 File Offset: 0x00AD8DF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rewardPanelLayer(IntPtr l)
	{
		int result;
		try
		{
			RaffleUITask raffleUITask = (RaffleUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raffleUITask.m_luaExportHelper.m_rewardPanelLayer);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020893 RID: 133267 RVA: 0x00ADAC50 File Offset: 0x00AD8E50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rewardPanelLayer(IntPtr l)
	{
		int result;
		try
		{
			RaffleUITask raffleUITask = (RaffleUITask)LuaObject.checkSelf(l);
			SceneLayerBase rewardPanelLayer;
			LuaObject.checkType<SceneLayerBase>(l, 2, out rewardPanelLayer);
			raffleUITask.m_luaExportHelper.m_rewardPanelLayer = rewardPanelLayer;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020894 RID: 133268 RVA: 0x00ADACAC File Offset: 0x00AD8EAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_mainCtrl(IntPtr l)
	{
		int result;
		try
		{
			RaffleUITask raffleUITask = (RaffleUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raffleUITask.m_luaExportHelper.m_mainCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020895 RID: 133269 RVA: 0x00ADAD04 File Offset: 0x00AD8F04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_mainCtrl(IntPtr l)
	{
		int result;
		try
		{
			RaffleUITask raffleUITask = (RaffleUITask)LuaObject.checkSelf(l);
			RaffleUIController mainCtrl;
			LuaObject.checkType<RaffleUIController>(l, 2, out mainCtrl);
			raffleUITask.m_luaExportHelper.m_mainCtrl = mainCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020896 RID: 133270 RVA: 0x00ADAD60 File Offset: 0x00AD8F60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_raffle3dUICtrl(IntPtr l)
	{
		int result;
		try
		{
			RaffleUITask raffleUITask = (RaffleUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raffleUITask.m_luaExportHelper.m_raffle3dUICtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020897 RID: 133271 RVA: 0x00ADADB8 File Offset: 0x00AD8FB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_raffle3dUICtrl(IntPtr l)
	{
		int result;
		try
		{
			RaffleUITask raffleUITask = (RaffleUITask)LuaObject.checkSelf(l);
			Raffle3DUIController raffle3dUICtrl;
			LuaObject.checkType<Raffle3DUIController>(l, 2, out raffle3dUICtrl);
			raffleUITask.m_luaExportHelper.m_raffle3dUICtrl = raffle3dUICtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020898 RID: 133272 RVA: 0x00ADAE14 File Offset: 0x00AD9014
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rewardPanelCtrl(IntPtr l)
	{
		int result;
		try
		{
			RaffleUITask raffleUITask = (RaffleUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raffleUITask.m_luaExportHelper.m_rewardPanelCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020899 RID: 133273 RVA: 0x00ADAE6C File Offset: 0x00AD906C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rewardPanelCtrl(IntPtr l)
	{
		int result;
		try
		{
			RaffleUITask raffleUITask = (RaffleUITask)LuaObject.checkSelf(l);
			RaffleRewardUIController rewardPanelCtrl;
			LuaObject.checkType<RaffleRewardUIController>(l, 2, out rewardPanelCtrl);
			raffleUITask.m_luaExportHelper.m_rewardPanelCtrl = rewardPanelCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602089A RID: 133274 RVA: 0x00ADAEC8 File Offset: 0x00AD90C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rafflePool(IntPtr l)
	{
		int result;
		try
		{
			RaffleUITask raffleUITask = (RaffleUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raffleUITask.m_luaExportHelper.m_rafflePool);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602089B RID: 133275 RVA: 0x00ADAF20 File Offset: 0x00AD9120
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rafflePool(IntPtr l)
	{
		int result;
		try
		{
			RaffleUITask raffleUITask = (RaffleUITask)LuaObject.checkSelf(l);
			RafflePool rafflePool;
			LuaObject.checkType<RafflePool>(l, 2, out rafflePool);
			raffleUITask.m_luaExportHelper.m_rafflePool = rafflePool;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602089C RID: 133276 RVA: 0x00ADAF7C File Offset: 0x00AD917C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_drawAniamtionState(IntPtr l)
	{
		int result;
		try
		{
			RaffleUITask raffleUITask = (RaffleUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)raffleUITask.m_luaExportHelper.m_drawAniamtionState);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602089D RID: 133277 RVA: 0x00ADAFD4 File Offset: 0x00AD91D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_drawAniamtionState(IntPtr l)
	{
		int result;
		try
		{
			RaffleUITask raffleUITask = (RaffleUITask)LuaObject.checkSelf(l);
			RaffleUITask.DrawAnimationState drawAniamtionState;
			LuaObject.checkEnum<RaffleUITask.DrawAnimationState>(l, 2, out drawAniamtionState);
			raffleUITask.m_luaExportHelper.m_drawAniamtionState = drawAniamtionState;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602089E RID: 133278 RVA: 0x00ADB030 File Offset: 0x00AD9230
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_drawnRaffleId(IntPtr l)
	{
		int result;
		try
		{
			RaffleUITask raffleUITask = (RaffleUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raffleUITask.m_luaExportHelper.m_drawnRaffleId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602089F RID: 133279 RVA: 0x00ADB088 File Offset: 0x00AD9288
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_drawnRaffleId(IntPtr l)
	{
		int result;
		try
		{
			RaffleUITask raffleUITask = (RaffleUITask)LuaObject.checkSelf(l);
			int drawnRaffleId;
			LuaObject.checkType(l, 2, out drawnRaffleId);
			raffleUITask.m_luaExportHelper.m_drawnRaffleId = drawnRaffleId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060208A0 RID: 133280 RVA: 0x00ADB0E4 File Offset: 0x00AD92E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_drawnGoods(IntPtr l)
	{
		int result;
		try
		{
			RaffleUITask raffleUITask = (RaffleUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raffleUITask.m_luaExportHelper.m_drawnGoods);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060208A1 RID: 133281 RVA: 0x00ADB13C File Offset: 0x00AD933C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_drawnGoods(IntPtr l)
	{
		int result;
		try
		{
			RaffleUITask raffleUITask = (RaffleUITask)LuaObject.checkSelf(l);
			List<Goods> drawnGoods;
			LuaObject.checkType<List<Goods>>(l, 2, out drawnGoods);
			raffleUITask.m_luaExportHelper.m_drawnGoods = drawnGoods;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060208A2 RID: 133282 RVA: 0x00ADB198 File Offset: 0x00AD9398
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			RaffleUITask raffleUITask = (RaffleUITask)LuaObject.checkSelf(l);
			Action action;
			int num = LuaObject.checkDelegate<Action>(l, 2, out action);
			if (num == 0)
			{
				raffleUITask.EventOnClose = action;
			}
			else if (num == 1)
			{
				RaffleUITask raffleUITask2 = raffleUITask;
				raffleUITask2.EventOnClose = (Action)Delegate.Combine(raffleUITask2.EventOnClose, action);
			}
			else if (num == 2)
			{
				RaffleUITask raffleUITask3 = raffleUITask;
				raffleUITask3.EventOnClose = (Action)Delegate.Remove(raffleUITask3.EventOnClose, action);
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

	// Token: 0x060208A3 RID: 133283 RVA: 0x00ADB240 File Offset: 0x00AD9440
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ParamKey_PoolId(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, RaffleUITask.ParamKey_PoolId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060208A4 RID: 133284 RVA: 0x00ADB288 File Offset: 0x00AD9488
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ParamKey_PoolId(IntPtr l)
	{
		int result;
		try
		{
			string paramKey_PoolId;
			LuaObject.checkType(l, 2, out paramKey_PoolId);
			RaffleUITask.ParamKey_PoolId = paramKey_PoolId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060208A5 RID: 133285 RVA: 0x00ADB2D4 File Offset: 0x00AD94D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			RaffleUITask raffleUITask = (RaffleUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raffleUITask.m_luaExportHelper.m_layerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060208A6 RID: 133286 RVA: 0x00ADB32C File Offset: 0x00AD952C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			RaffleUITask raffleUITask = (RaffleUITask)LuaObject.checkSelf(l);
			UITaskBase.LayerDesc[] layerDescArray;
			LuaObject.checkArray<UITaskBase.LayerDesc>(l, 2, out layerDescArray);
			raffleUITask.m_luaExportHelper.m_layerDescArray = layerDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060208A7 RID: 133287 RVA: 0x00ADB388 File Offset: 0x00AD9588
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			RaffleUITask raffleUITask = (RaffleUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raffleUITask.m_luaExportHelper.m_uiCtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060208A8 RID: 133288 RVA: 0x00ADB3E0 File Offset: 0x00AD95E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			RaffleUITask raffleUITask = (RaffleUITask)LuaObject.checkSelf(l);
			UITaskBase.UIControllerDesc[] uiCtrlDescArray;
			LuaObject.checkArray<UITaskBase.UIControllerDesc>(l, 2, out uiCtrlDescArray);
			raffleUITask.m_luaExportHelper.m_uiCtrlDescArray = uiCtrlDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060208A9 RID: 133289 RVA: 0x00ADB43C File Offset: 0x00AD963C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PlayerCtx(IntPtr l)
	{
		int result;
		try
		{
			RaffleUITask raffleUITask = (RaffleUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raffleUITask.m_luaExportHelper.PlayerCtx);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060208AA RID: 133290 RVA: 0x00ADB494 File Offset: 0x00AD9694
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ConfigDataLoader(IntPtr l)
	{
		int result;
		try
		{
			RaffleUITask raffleUITask = (RaffleUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raffleUITask.m_luaExportHelper.ConfigDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060208AB RID: 133291 RVA: 0x00ADB4EC File Offset: 0x00AD96EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LayerDescArray(IntPtr l)
	{
		int result;
		try
		{
			RaffleUITask raffleUITask = (RaffleUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raffleUITask.m_luaExportHelper.LayerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060208AC RID: 133292 RVA: 0x00ADB544 File Offset: 0x00AD9744
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UICtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			RaffleUITask raffleUITask = (RaffleUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raffleUITask.m_luaExportHelper.UICtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060208AD RID: 133293 RVA: 0x00ADB59C File Offset: 0x00AD979C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.RaffleUITask");
		if (Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUITask.OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUITask.OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUITask.OnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUITask.OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUITask.IsNeedUpdateDataCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUITask.UpdateDataCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUITask.IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUITask.InitLayerStateOnLoadAllResCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUITask.InitLayerStateOnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUITask.InitAllUIControllers);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUITask.UpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUITask.UpdateDrawAnimation);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUITask.ClearContextOnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUITask.OnBgButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUITask.OnShowHelpButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUITask.OnRewardPanelButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUITask.OnDoRaffleButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUITask.StartDrawAnimation);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUITask.OpenSrBox);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUITask.IsSrBox);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUITask.OnRechargeDialogResult);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUITask.OnNotEnoughItemDialogResult);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUITask.OnRewardPanelCloseButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUITask.OnLevelEffectBgButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUITask.OnRewardGoodsUITaskClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUITask.ShowErrorTipWnd);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUITask.IsPipelineStateMaskNeedUpdate);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUITask.EnablePipelineStateMask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUITask.ShowNotEnoughCrystalMsgBox);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUITask.ShowNotEoughItemMsgBox);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUITask.__callBase_OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUITask.__callBase_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUITask.__callBase_OnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUITask.__callBase_OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUITask.__callBase_OnNewIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUITask.__callBase_EnableUIInput);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUITask.__callBase_IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUITask.__callBase_CollectAllDynamicResForLoad);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUITask.__callBase_RegisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUITask.__callBase_UnregisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUITask.__callBase_PostUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUITask.__callBase_CollectPreloadResourceList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache29);
		if (Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUITask.__callBase_ClearAssetList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache2A);
		if (Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUITask.__callBase_CollectAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache2B);
		if (Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUITask.__callBase_CollectSpriteAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache2C);
		if (Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUITask.__callBase_CollectFxAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache2D);
		if (Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUITask.__callBase_StartLoadCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache2E);
		if (Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUITask.__callBase_IsLoadingCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache2F);
		if (Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUITask.__callBase_IsPipeLineRunning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache30);
		if (Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUITask.__callBase_IsOpeningUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache31);
		if (Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUITask.__callBase_ReturnPrevUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache32);
		if (Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUITask.__callBase_ClearUnusedDynamicResourceCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache33);
		if (Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUITask.__callBase_OnMemoryWarning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache34);
		string name = "m_getRewardGoodsUITask";
		if (Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUITask.get_m_getRewardGoodsUITask);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache35;
		if (Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUITask.set_m_getRewardGoodsUITask);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache36, true);
		string name2 = "m_rewardPanelLayer";
		if (Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUITask.get_m_rewardPanelLayer);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache37;
		if (Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUITask.set_m_rewardPanelLayer);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache38, true);
		string name3 = "m_mainCtrl";
		if (Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUITask.get_m_mainCtrl);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache39;
		if (Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUITask.set_m_mainCtrl);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache3A, true);
		string name4 = "m_raffle3dUICtrl";
		if (Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUITask.get_m_raffle3dUICtrl);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache3B;
		if (Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUITask.set_m_raffle3dUICtrl);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache3C, true);
		string name5 = "m_rewardPanelCtrl";
		if (Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUITask.get_m_rewardPanelCtrl);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache3D;
		if (Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUITask.set_m_rewardPanelCtrl);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache3E, true);
		string name6 = "m_rafflePool";
		if (Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUITask.get_m_rafflePool);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache3F;
		if (Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUITask.set_m_rafflePool);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache40, true);
		string name7 = "m_drawAniamtionState";
		if (Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUITask.get_m_drawAniamtionState);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache41;
		if (Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUITask.set_m_drawAniamtionState);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache42, true);
		string name8 = "m_drawnRaffleId";
		if (Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUITask.get_m_drawnRaffleId);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache43;
		if (Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUITask.set_m_drawnRaffleId);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache44, true);
		string name9 = "m_drawnGoods";
		if (Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUITask.get_m_drawnGoods);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache45;
		if (Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUITask.set_m_drawnGoods);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache46, true);
		string name10 = "EventOnClose";
		LuaCSFunction get10 = null;
		if (Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUITask.set_EventOnClose);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache47, true);
		string name11 = "ParamKey_PoolId";
		if (Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUITask.get_ParamKey_PoolId);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache48;
		if (Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUITask.set_ParamKey_PoolId);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache49, false);
		string name12 = "m_layerDescArray";
		if (Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUITask.get_m_layerDescArray);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache4A;
		if (Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUITask.set_m_layerDescArray);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache4B, true);
		string name13 = "m_uiCtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUITask.get_m_uiCtrlDescArray);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache4C;
		if (Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUITask.set_m_uiCtrlDescArray);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache4D, true);
		string name14 = "PlayerCtx";
		if (Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUITask.get_PlayerCtx);
		}
		LuaObject.addMember(l, name14, Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache4E, null, true);
		string name15 = "ConfigDataLoader";
		if (Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUITask.get_ConfigDataLoader);
		}
		LuaObject.addMember(l, name15, Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache4F, null, true);
		string name16 = "LayerDescArray";
		if (Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUITask.get_LayerDescArray);
		}
		LuaObject.addMember(l, name16, Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache50, null, true);
		string name17 = "UICtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUITask.get_UICtrlDescArray);
		}
		LuaObject.addMember(l, name17, Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache51, null, true);
		if (Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUITask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_RaffleUITask.<>f__mg$cache52, typeof(RaffleUITask), typeof(UITask));
	}

	// Token: 0x040167B4 RID: 92084
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040167B5 RID: 92085
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040167B6 RID: 92086
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040167B7 RID: 92087
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040167B8 RID: 92088
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040167B9 RID: 92089
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040167BA RID: 92090
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040167BB RID: 92091
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040167BC RID: 92092
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040167BD RID: 92093
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040167BE RID: 92094
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040167BF RID: 92095
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040167C0 RID: 92096
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040167C1 RID: 92097
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040167C2 RID: 92098
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040167C3 RID: 92099
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040167C4 RID: 92100
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040167C5 RID: 92101
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040167C6 RID: 92102
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040167C7 RID: 92103
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x040167C8 RID: 92104
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x040167C9 RID: 92105
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x040167CA RID: 92106
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x040167CB RID: 92107
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x040167CC RID: 92108
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x040167CD RID: 92109
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x040167CE RID: 92110
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x040167CF RID: 92111
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x040167D0 RID: 92112
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x040167D1 RID: 92113
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x040167D2 RID: 92114
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x040167D3 RID: 92115
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x040167D4 RID: 92116
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x040167D5 RID: 92117
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x040167D6 RID: 92118
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x040167D7 RID: 92119
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x040167D8 RID: 92120
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x040167D9 RID: 92121
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x040167DA RID: 92122
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x040167DB RID: 92123
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x040167DC RID: 92124
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x040167DD RID: 92125
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x040167DE RID: 92126
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x040167DF RID: 92127
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x040167E0 RID: 92128
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x040167E1 RID: 92129
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x040167E2 RID: 92130
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x040167E3 RID: 92131
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x040167E4 RID: 92132
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x040167E5 RID: 92133
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x040167E6 RID: 92134
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x040167E7 RID: 92135
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x040167E8 RID: 92136
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x040167E9 RID: 92137
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x040167EA RID: 92138
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x040167EB RID: 92139
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x040167EC RID: 92140
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x040167ED RID: 92141
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x040167EE RID: 92142
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x040167EF RID: 92143
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x040167F0 RID: 92144
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x040167F1 RID: 92145
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x040167F2 RID: 92146
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x040167F3 RID: 92147
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x040167F4 RID: 92148
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x040167F5 RID: 92149
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x040167F6 RID: 92150
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x040167F7 RID: 92151
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x040167F8 RID: 92152
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x040167F9 RID: 92153
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x040167FA RID: 92154
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x040167FB RID: 92155
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x040167FC RID: 92156
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x040167FD RID: 92157
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x040167FE RID: 92158
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x040167FF RID: 92159
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x04016800 RID: 92160
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x04016801 RID: 92161
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x04016802 RID: 92162
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x04016803 RID: 92163
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x04016804 RID: 92164
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x04016805 RID: 92165
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x04016806 RID: 92166
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;
}
