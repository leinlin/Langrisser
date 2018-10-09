using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001507 RID: 5383
[Preserve]
public class Lua_BlackJack_ProjectL_UI_MailUITask : LuaObject
{
	// Token: 0x0601FDEE RID: 130542 RVA: 0x00A861D4 File Offset: 0x00A843D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string name;
			LuaObject.checkType(l, 2, out name);
			MailUITask o = new MailUITask(name);
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

	// Token: 0x0601FDEF RID: 130543 RVA: 0x00A86228 File Offset: 0x00A84428
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PrepareForStartOrResume(IntPtr l)
	{
		int result;
		try
		{
			MailUITask mailUITask = (MailUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			Action<bool> onPrepareEnd;
			LuaObject.checkDelegate<Action<bool>>(l, 3, out onPrepareEnd);
			mailUITask.PrepareForStartOrResume(intent, onPrepareEnd);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FDF0 RID: 130544 RVA: 0x00A8628C File Offset: 0x00A8448C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStart(IntPtr l)
	{
		int result;
		try
		{
			MailUITask mailUITask = (MailUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = mailUITask.m_luaExportHelper.OnStart(intent);
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

	// Token: 0x0601FDF1 RID: 130545 RVA: 0x00A862F4 File Offset: 0x00A844F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsNeedUpdateDataCache(IntPtr l)
	{
		int result;
		try
		{
			MailUITask mailUITask = (MailUITask)LuaObject.checkSelf(l);
			bool b = mailUITask.m_luaExportHelper.IsNeedUpdateDataCache();
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

	// Token: 0x0601FDF2 RID: 130546 RVA: 0x00A86350 File Offset: 0x00A84550
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateDataCache(IntPtr l)
	{
		int result;
		try
		{
			MailUITask mailUITask = (MailUITask)LuaObject.checkSelf(l);
			mailUITask.m_luaExportHelper.UpdateDataCache();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FDF3 RID: 130547 RVA: 0x00A863A4 File Offset: 0x00A845A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			MailUITask mailUITask = (MailUITask)LuaObject.checkSelf(l);
			bool b = mailUITask.m_luaExportHelper.IsNeedLoadDynamicRes();
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

	// Token: 0x0601FDF4 RID: 130548 RVA: 0x00A86400 File Offset: 0x00A84600
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int MailCompare(IntPtr l)
	{
		int result;
		try
		{
			MailUITask mailUITask = (MailUITask)LuaObject.checkSelf(l);
			Mail mailA;
			LuaObject.checkType<Mail>(l, 2, out mailA);
			Mail mailB;
			LuaObject.checkType<Mail>(l, 3, out mailB);
			int i = mailUITask.m_luaExportHelper.MailCompare(mailA, mailB);
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

	// Token: 0x0601FDF5 RID: 130549 RVA: 0x00A86474 File Offset: 0x00A84674
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitAllUIControllers(IntPtr l)
	{
		int result;
		try
		{
			MailUITask mailUITask = (MailUITask)LuaObject.checkSelf(l);
			mailUITask.m_luaExportHelper.InitAllUIControllers();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FDF6 RID: 130550 RVA: 0x00A864C8 File Offset: 0x00A846C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearAllContextAndRes(IntPtr l)
	{
		int result;
		try
		{
			MailUITask mailUITask = (MailUITask)LuaObject.checkSelf(l);
			mailUITask.m_luaExportHelper.ClearAllContextAndRes();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FDF7 RID: 130551 RVA: 0x00A8651C File Offset: 0x00A8471C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateView(IntPtr l)
	{
		int result;
		try
		{
			MailUITask mailUITask = (MailUITask)LuaObject.checkSelf(l);
			mailUITask.m_luaExportHelper.UpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FDF8 RID: 130552 RVA: 0x00A86570 File Offset: 0x00A84770
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnResume(IntPtr l)
	{
		int result;
		try
		{
			MailUITask mailUITask = (MailUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = mailUITask.m_luaExportHelper.OnResume(intent);
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

	// Token: 0x0601FDF9 RID: 130553 RVA: 0x00A865D8 File Offset: 0x00A847D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int MailListUIController_OnMailItemButtonClick(IntPtr l)
	{
		int result;
		try
		{
			MailUITask mailUITask = (MailUITask)LuaObject.checkSelf(l);
			Mail mail;
			LuaObject.checkType<Mail>(l, 2, out mail);
			mailUITask.m_luaExportHelper.MailListUIController_OnMailItemButtonClick(mail);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FDFA RID: 130554 RVA: 0x00A86634 File Offset: 0x00A84834
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int MailListUIController_OnCloseButtonClick(IntPtr l)
	{
		int result;
		try
		{
			MailUITask mailUITask = (MailUITask)LuaObject.checkSelf(l);
			mailUITask.m_luaExportHelper.MailListUIController_OnCloseButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FDFB RID: 130555 RVA: 0x00A86688 File Offset: 0x00A84888
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int MailListUIController_OnGetAllAttachments(IntPtr l)
	{
		int result;
		try
		{
			MailUITask mailUITask = (MailUITask)LuaObject.checkSelf(l);
			mailUITask.m_luaExportHelper.MailListUIController_OnGetAllAttachments();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FDFC RID: 130556 RVA: 0x00A866DC File Offset: 0x00A848DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int MailDetailUIController_OnGotoButtonClick(IntPtr l)
	{
		int result;
		try
		{
			MailUITask mailUITask = (MailUITask)LuaObject.checkSelf(l);
			Mail obj;
			LuaObject.checkType<Mail>(l, 2, out obj);
			mailUITask.m_luaExportHelper.MailDetailUIController_OnGotoButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FDFD RID: 130557 RVA: 0x00A86738 File Offset: 0x00A84938
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int MailDetailUIController_OnGetAttachmentButtonClick(IntPtr l)
	{
		int result;
		try
		{
			MailUITask mailUITask = (MailUITask)LuaObject.checkSelf(l);
			Mail mail;
			LuaObject.checkType<Mail>(l, 2, out mail);
			mailUITask.m_luaExportHelper.MailDetailUIController_OnGetAttachmentButtonClick(mail);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FDFE RID: 130558 RVA: 0x00A86794 File Offset: 0x00A84994
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HandleGetMailError(IntPtr l)
	{
		int result2;
		try
		{
			MailUITask mailUITask = (MailUITask)LuaObject.checkSelf(l);
			int result;
			LuaObject.checkType(l, 2, out result);
			mailUITask.m_luaExportHelper.HandleGetMailError(result);
			LuaObject.pushValue(l, true);
			result2 = 1;
		}
		catch (Exception e)
		{
			result2 = LuaObject.error(l, e);
		}
		return result2;
	}

	// Token: 0x0601FDFF RID: 130559 RVA: 0x00A867F0 File Offset: 0x00A849F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnMailsChangedNtf(IntPtr l)
	{
		int result;
		try
		{
			MailUITask mailUITask = (MailUITask)LuaObject.checkSelf(l);
			mailUITask.m_luaExportHelper.OnMailsChangedNtf();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE00 RID: 130560 RVA: 0x00A86844 File Offset: 0x00A84A44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnMailReadAck(IntPtr l)
	{
		int result2;
		try
		{
			MailUITask mailUITask = (MailUITask)LuaObject.checkSelf(l);
			int result;
			LuaObject.checkType(l, 2, out result);
			mailUITask.m_luaExportHelper.OnMailReadAck(result);
			LuaObject.pushValue(l, true);
			result2 = 1;
		}
		catch (Exception e)
		{
			result2 = LuaObject.error(l, e);
		}
		return result2;
	}

	// Token: 0x0601FE01 RID: 130561 RVA: 0x00A868A0 File Offset: 0x00A84AA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsPipelineStateMaskNeedUpdate(IntPtr l)
	{
		int result;
		try
		{
			MailUITask mailUITask = (MailUITask)LuaObject.checkSelf(l);
			MailUITask.PipeLineStateMaskType state;
			LuaObject.checkEnum<MailUITask.PipeLineStateMaskType>(l, 2, out state);
			bool b = mailUITask.m_luaExportHelper.IsPipelineStateMaskNeedUpdate(state);
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

	// Token: 0x0601FE02 RID: 130562 RVA: 0x00A86908 File Offset: 0x00A84B08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int EnablePipelineStateMask(IntPtr l)
	{
		int result;
		try
		{
			MailUITask mailUITask = (MailUITask)LuaObject.checkSelf(l);
			MailUITask.PipeLineStateMaskType state;
			LuaObject.checkEnum<MailUITask.PipeLineStateMaskType>(l, 2, out state);
			mailUITask.m_luaExportHelper.EnablePipelineStateMask(state);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE03 RID: 130563 RVA: 0x00A86964 File Offset: 0x00A84B64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStart(IntPtr l)
	{
		int result;
		try
		{
			MailUITask mailUITask = (MailUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = mailUITask.m_luaExportHelper.__callBase_OnStart(intent);
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

	// Token: 0x0601FE04 RID: 130564 RVA: 0x00A869CC File Offset: 0x00A84BCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStop(IntPtr l)
	{
		int result;
		try
		{
			MailUITask mailUITask = (MailUITask)LuaObject.checkSelf(l);
			mailUITask.m_luaExportHelper.__callBase_OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE05 RID: 130565 RVA: 0x00A86A20 File Offset: 0x00A84C20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnPause(IntPtr l)
	{
		int result;
		try
		{
			MailUITask mailUITask = (MailUITask)LuaObject.checkSelf(l);
			mailUITask.m_luaExportHelper.__callBase_OnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE06 RID: 130566 RVA: 0x00A86A74 File Offset: 0x00A84C74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnResume(IntPtr l)
	{
		int result;
		try
		{
			MailUITask mailUITask = (MailUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = mailUITask.m_luaExportHelper.__callBase_OnResume(intent);
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

	// Token: 0x0601FE07 RID: 130567 RVA: 0x00A86ADC File Offset: 0x00A84CDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnNewIntent(IntPtr l)
	{
		int result;
		try
		{
			MailUITask mailUITask = (MailUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = mailUITask.m_luaExportHelper.__callBase_OnNewIntent(intent);
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

	// Token: 0x0601FE08 RID: 130568 RVA: 0x00A86B44 File Offset: 0x00A84D44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_EnableUIInput(IntPtr l)
	{
		int result;
		try
		{
			MailUITask mailUITask = (MailUITask)LuaObject.checkSelf(l);
			bool isEnable;
			LuaObject.checkType(l, 2, out isEnable);
			bool? isGlobalEnable;
			LuaObject.checkNullable<bool>(l, 3, out isGlobalEnable);
			mailUITask.m_luaExportHelper.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE09 RID: 130569 RVA: 0x00A86BB0 File Offset: 0x00A84DB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			MailUITask mailUITask = (MailUITask)LuaObject.checkSelf(l);
			bool b = mailUITask.m_luaExportHelper.__callBase_IsNeedLoadDynamicRes();
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

	// Token: 0x0601FE0A RID: 130570 RVA: 0x00A86C0C File Offset: 0x00A84E0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAllDynamicResForLoad(IntPtr l)
	{
		int result;
		try
		{
			MailUITask mailUITask = (MailUITask)LuaObject.checkSelf(l);
			List<string> o = mailUITask.m_luaExportHelper.__callBase_CollectAllDynamicResForLoad();
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

	// Token: 0x0601FE0B RID: 130571 RVA: 0x00A86C68 File Offset: 0x00A84E68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_RegisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			MailUITask mailUITask = (MailUITask)LuaObject.checkSelf(l);
			mailUITask.m_luaExportHelper.__callBase_RegisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE0C RID: 130572 RVA: 0x00A86CBC File Offset: 0x00A84EBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_UnregisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			MailUITask mailUITask = (MailUITask)LuaObject.checkSelf(l);
			mailUITask.m_luaExportHelper.__callBase_UnregisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE0D RID: 130573 RVA: 0x00A86D10 File Offset: 0x00A84F10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostUpdateView(IntPtr l)
	{
		int result;
		try
		{
			MailUITask mailUITask = (MailUITask)LuaObject.checkSelf(l);
			mailUITask.m_luaExportHelper.__callBase_PostUpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE0E RID: 130574 RVA: 0x00A86D64 File Offset: 0x00A84F64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectPreloadResourceList(IntPtr l)
	{
		int result;
		try
		{
			MailUITask mailUITask = (MailUITask)LuaObject.checkSelf(l);
			mailUITask.m_luaExportHelper.__callBase_CollectPreloadResourceList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE0F RID: 130575 RVA: 0x00A86DB8 File Offset: 0x00A84FB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearAssetList(IntPtr l)
	{
		int result;
		try
		{
			MailUITask mailUITask = (MailUITask)LuaObject.checkSelf(l);
			mailUITask.m_luaExportHelper.__callBase_ClearAssetList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE10 RID: 130576 RVA: 0x00A86E0C File Offset: 0x00A8500C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAsset(IntPtr l)
	{
		int result;
		try
		{
			MailUITask mailUITask = (MailUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			mailUITask.m_luaExportHelper.__callBase_CollectAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE11 RID: 130577 RVA: 0x00A86E68 File Offset: 0x00A85068
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectSpriteAsset(IntPtr l)
	{
		int result;
		try
		{
			MailUITask mailUITask = (MailUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			mailUITask.m_luaExportHelper.__callBase_CollectSpriteAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE12 RID: 130578 RVA: 0x00A86EC4 File Offset: 0x00A850C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectFxAsset(IntPtr l)
	{
		int result;
		try
		{
			MailUITask mailUITask = (MailUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			mailUITask.m_luaExportHelper.__callBase_CollectFxAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE13 RID: 130579 RVA: 0x00A86F20 File Offset: 0x00A85120
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_StartLoadCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			MailUITask mailUITask = (MailUITask)LuaObject.checkSelf(l);
			Action onLoadCompleted;
			LuaObject.checkDelegate<Action>(l, 2, out onLoadCompleted);
			mailUITask.m_luaExportHelper.__callBase_StartLoadCustomAssets(onLoadCompleted);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE14 RID: 130580 RVA: 0x00A86F7C File Offset: 0x00A8517C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsLoadingCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			MailUITask mailUITask = (MailUITask)LuaObject.checkSelf(l);
			bool b = mailUITask.m_luaExportHelper.__callBase_IsLoadingCustomAssets();
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

	// Token: 0x0601FE15 RID: 130581 RVA: 0x00A86FD8 File Offset: 0x00A851D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsPipeLineRunning(IntPtr l)
	{
		int result;
		try
		{
			MailUITask mailUITask = (MailUITask)LuaObject.checkSelf(l);
			bool b = mailUITask.m_luaExportHelper.__callBase_IsPipeLineRunning();
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

	// Token: 0x0601FE16 RID: 130582 RVA: 0x00A87034 File Offset: 0x00A85234
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsOpeningUI(IntPtr l)
	{
		int result;
		try
		{
			MailUITask mailUITask = (MailUITask)LuaObject.checkSelf(l);
			bool b = mailUITask.m_luaExportHelper.__callBase_IsOpeningUI();
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

	// Token: 0x0601FE17 RID: 130583 RVA: 0x00A87090 File Offset: 0x00A85290
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ReturnPrevUITask(IntPtr l)
	{
		int result;
		try
		{
			MailUITask mailUITask = (MailUITask)LuaObject.checkSelf(l);
			UITaskBase o = mailUITask.m_luaExportHelper.__callBase_ReturnPrevUITask();
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

	// Token: 0x0601FE18 RID: 130584 RVA: 0x00A870EC File Offset: 0x00A852EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearUnusedDynamicResourceCache(IntPtr l)
	{
		int result;
		try
		{
			MailUITask mailUITask = (MailUITask)LuaObject.checkSelf(l);
			mailUITask.m_luaExportHelper.__callBase_ClearUnusedDynamicResourceCache();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE19 RID: 130585 RVA: 0x00A87140 File Offset: 0x00A85340
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnMemoryWarning(IntPtr l)
	{
		int result;
		try
		{
			MailUITask mailUITask = (MailUITask)LuaObject.checkSelf(l);
			mailUITask.m_luaExportHelper.__callBase_OnMemoryWarning();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE1A RID: 130586 RVA: 0x00A87194 File Offset: 0x00A85394
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AppendGoodsToList_s(IntPtr l)
	{
		int result;
		try
		{
			Goods goods;
			LuaObject.checkType<Goods>(l, 1, out goods);
			List<Goods> goodsList;
			LuaObject.checkType<List<Goods>>(l, 2, out goodsList);
			MailUITask.LuaExportHelper.AppendGoodsToList(goods, goodsList);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE1B RID: 130587 RVA: 0x00A871EC File Offset: 0x00A853EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerCtx(IntPtr l)
	{
		int result;
		try
		{
			MailUITask mailUITask = (MailUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mailUITask.m_luaExportHelper.m_playerCtx);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE1C RID: 130588 RVA: 0x00A87244 File Offset: 0x00A85444
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerCtx(IntPtr l)
	{
		int result;
		try
		{
			MailUITask mailUITask = (MailUITask)LuaObject.checkSelf(l);
			ProjectLPlayerContext playerCtx;
			LuaObject.checkType<ProjectLPlayerContext>(l, 2, out playerCtx);
			mailUITask.m_luaExportHelper.m_playerCtx = playerCtx;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE1D RID: 130589 RVA: 0x00A872A0 File Offset: 0x00A854A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_mailListUICtrl(IntPtr l)
	{
		int result;
		try
		{
			MailUITask mailUITask = (MailUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mailUITask.m_luaExportHelper.m_mailListUICtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE1E RID: 130590 RVA: 0x00A872F8 File Offset: 0x00A854F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_mailListUICtrl(IntPtr l)
	{
		int result;
		try
		{
			MailUITask mailUITask = (MailUITask)LuaObject.checkSelf(l);
			MailListUIController mailListUICtrl;
			LuaObject.checkType<MailListUIController>(l, 2, out mailListUICtrl);
			mailUITask.m_luaExportHelper.m_mailListUICtrl = mailListUICtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE1F RID: 130591 RVA: 0x00A87354 File Offset: 0x00A85554
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_mailInfoCache(IntPtr l)
	{
		int result;
		try
		{
			MailUITask mailUITask = (MailUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mailUITask.m_luaExportHelper.m_mailInfoCache);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE20 RID: 130592 RVA: 0x00A873AC File Offset: 0x00A855AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_mailInfoCache(IntPtr l)
	{
		int result;
		try
		{
			MailUITask mailUITask = (MailUITask)LuaObject.checkSelf(l);
			List<Mail> mailInfoCache;
			LuaObject.checkType<List<Mail>>(l, 2, out mailInfoCache);
			mailUITask.m_luaExportHelper.m_mailInfoCache = mailInfoCache;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE21 RID: 130593 RVA: 0x00A87408 File Offset: 0x00A85608
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_currentSelectedMail(IntPtr l)
	{
		int result;
		try
		{
			MailUITask mailUITask = (MailUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mailUITask.m_luaExportHelper.m_currentSelectedMail);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE22 RID: 130594 RVA: 0x00A87460 File Offset: 0x00A85660
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_currentSelectedMail(IntPtr l)
	{
		int result;
		try
		{
			MailUITask mailUITask = (MailUITask)LuaObject.checkSelf(l);
			Mail currentSelectedMail;
			LuaObject.checkType<Mail>(l, 2, out currentSelectedMail);
			mailUITask.m_luaExportHelper.m_currentSelectedMail = currentSelectedMail;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE23 RID: 130595 RVA: 0x00A874BC File Offset: 0x00A856BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			MailUITask mailUITask = (MailUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mailUITask.m_luaExportHelper.m_layerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE24 RID: 130596 RVA: 0x00A87514 File Offset: 0x00A85714
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			MailUITask mailUITask = (MailUITask)LuaObject.checkSelf(l);
			UITaskBase.LayerDesc[] layerDescArray;
			LuaObject.checkArray<UITaskBase.LayerDesc>(l, 2, out layerDescArray);
			mailUITask.m_luaExportHelper.m_layerDescArray = layerDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE25 RID: 130597 RVA: 0x00A87570 File Offset: 0x00A85770
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			MailUITask mailUITask = (MailUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mailUITask.m_luaExportHelper.m_uiCtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE26 RID: 130598 RVA: 0x00A875C8 File Offset: 0x00A857C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			MailUITask mailUITask = (MailUITask)LuaObject.checkSelf(l);
			UITaskBase.UIControllerDesc[] uiCtrlDescArray;
			LuaObject.checkArray<UITaskBase.UIControllerDesc>(l, 2, out uiCtrlDescArray);
			mailUITask.m_luaExportHelper.m_uiCtrlDescArray = uiCtrlDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE27 RID: 130599 RVA: 0x00A87624 File Offset: 0x00A85824
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LayerDescArray(IntPtr l)
	{
		int result;
		try
		{
			MailUITask mailUITask = (MailUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mailUITask.m_luaExportHelper.LayerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE28 RID: 130600 RVA: 0x00A8767C File Offset: 0x00A8587C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UICtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			MailUITask mailUITask = (MailUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mailUITask.m_luaExportHelper.UICtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE29 RID: 130601 RVA: 0x00A876D4 File Offset: 0x00A858D4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.MailUITask");
		if (Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailUITask.PrepareForStartOrResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailUITask.OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailUITask.IsNeedUpdateDataCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailUITask.UpdateDataCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailUITask.IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailUITask.MailCompare);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailUITask.InitAllUIControllers);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailUITask.ClearAllContextAndRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailUITask.UpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailUITask.OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailUITask.MailListUIController_OnMailItemButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailUITask.MailListUIController_OnCloseButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailUITask.MailListUIController_OnGetAllAttachments);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailUITask.MailDetailUIController_OnGotoButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailUITask.MailDetailUIController_OnGetAttachmentButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailUITask.HandleGetMailError);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailUITask.OnMailsChangedNtf);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailUITask.OnMailReadAck);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailUITask.IsPipelineStateMaskNeedUpdate);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailUITask.EnablePipelineStateMask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailUITask.__callBase_OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailUITask.__callBase_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailUITask.__callBase_OnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailUITask.__callBase_OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailUITask.__callBase_OnNewIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailUITask.__callBase_EnableUIInput);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailUITask.__callBase_IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailUITask.__callBase_CollectAllDynamicResForLoad);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailUITask.__callBase_RegisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailUITask.__callBase_UnregisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailUITask.__callBase_PostUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailUITask.__callBase_CollectPreloadResourceList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailUITask.__callBase_ClearAssetList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailUITask.__callBase_CollectAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailUITask.__callBase_CollectSpriteAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailUITask.__callBase_CollectFxAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailUITask.__callBase_StartLoadCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailUITask.__callBase_IsLoadingCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailUITask.__callBase_IsPipeLineRunning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailUITask.__callBase_IsOpeningUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailUITask.__callBase_ReturnPrevUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailUITask.__callBase_ClearUnusedDynamicResourceCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache29);
		if (Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailUITask.__callBase_OnMemoryWarning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache2A);
		if (Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailUITask.AppendGoodsToList_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache2B);
		string name = "m_playerCtx";
		if (Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailUITask.get_m_playerCtx);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache2C;
		if (Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailUITask.set_m_playerCtx);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache2D, true);
		string name2 = "m_mailListUICtrl";
		if (Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailUITask.get_m_mailListUICtrl);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache2E;
		if (Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailUITask.set_m_mailListUICtrl);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache2F, true);
		string name3 = "m_mailInfoCache";
		if (Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailUITask.get_m_mailInfoCache);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache30;
		if (Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailUITask.set_m_mailInfoCache);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache31, true);
		string name4 = "m_currentSelectedMail";
		if (Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailUITask.get_m_currentSelectedMail);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache32;
		if (Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailUITask.set_m_currentSelectedMail);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache33, true);
		string name5 = "m_layerDescArray";
		if (Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailUITask.get_m_layerDescArray);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache34;
		if (Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailUITask.set_m_layerDescArray);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache35, true);
		string name6 = "m_uiCtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailUITask.get_m_uiCtrlDescArray);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache36;
		if (Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailUITask.set_m_uiCtrlDescArray);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache37, true);
		string name7 = "LayerDescArray";
		if (Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailUITask.get_LayerDescArray);
		}
		LuaObject.addMember(l, name7, Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache38, null, true);
		string name8 = "UICtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailUITask.get_UICtrlDescArray);
		}
		LuaObject.addMember(l, name8, Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache39, null, true);
		if (Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailUITask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_MailUITask.<>f__mg$cache3A, typeof(MailUITask), typeof(UITask));
	}

	// Token: 0x04015DC2 RID: 89538
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04015DC3 RID: 89539
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04015DC4 RID: 89540
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04015DC5 RID: 89541
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04015DC6 RID: 89542
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04015DC7 RID: 89543
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04015DC8 RID: 89544
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04015DC9 RID: 89545
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04015DCA RID: 89546
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04015DCB RID: 89547
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04015DCC RID: 89548
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04015DCD RID: 89549
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04015DCE RID: 89550
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04015DCF RID: 89551
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04015DD0 RID: 89552
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04015DD1 RID: 89553
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04015DD2 RID: 89554
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04015DD3 RID: 89555
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04015DD4 RID: 89556
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04015DD5 RID: 89557
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04015DD6 RID: 89558
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04015DD7 RID: 89559
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04015DD8 RID: 89560
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04015DD9 RID: 89561
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04015DDA RID: 89562
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04015DDB RID: 89563
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04015DDC RID: 89564
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04015DDD RID: 89565
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04015DDE RID: 89566
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04015DDF RID: 89567
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04015DE0 RID: 89568
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04015DE1 RID: 89569
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04015DE2 RID: 89570
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04015DE3 RID: 89571
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04015DE4 RID: 89572
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04015DE5 RID: 89573
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04015DE6 RID: 89574
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04015DE7 RID: 89575
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04015DE8 RID: 89576
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04015DE9 RID: 89577
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04015DEA RID: 89578
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04015DEB RID: 89579
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04015DEC RID: 89580
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04015DED RID: 89581
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04015DEE RID: 89582
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04015DEF RID: 89583
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04015DF0 RID: 89584
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04015DF1 RID: 89585
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04015DF2 RID: 89586
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04015DF3 RID: 89587
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04015DF4 RID: 89588
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04015DF5 RID: 89589
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04015DF6 RID: 89590
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04015DF7 RID: 89591
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04015DF8 RID: 89592
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04015DF9 RID: 89593
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04015DFA RID: 89594
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04015DFB RID: 89595
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04015DFC RID: 89596
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;
}
