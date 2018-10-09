using System;
using System.Collections;
using System.Runtime.CompilerServices;
using PD.SDK;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001600 RID: 5632
[Preserve]
public class Lua_PD_SDK_PDSDK : LuaObject
{
	// Token: 0x0602284F RID: 141391 RVA: 0x00BD6D60 File Offset: 0x00BD4F60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int onWebViewOpen(IntPtr l)
	{
		int result;
		try
		{
			PDSDK pdsdk = (PDSDK)LuaObject.checkSelf(l);
			pdsdk.onWebViewOpen();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022850 RID: 141392 RVA: 0x00BD6DAC File Offset: 0x00BD4FAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int onWebViewClose(IntPtr l)
	{
		int result;
		try
		{
			PDSDK pdsdk = (PDSDK)LuaObject.checkSelf(l);
			pdsdk.onWebViewClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022851 RID: 141393 RVA: 0x00BD6DF8 File Offset: 0x00BD4FF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Init(IntPtr l)
	{
		int result;
		try
		{
			PDSDK pdsdk = (PDSDK)LuaObject.checkSelf(l);
			pdsdk.Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022852 RID: 141394 RVA: 0x00BD6E44 File Offset: 0x00BD5044
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Login(IntPtr l)
	{
		int result;
		try
		{
			PDSDK pdsdk = (PDSDK)LuaObject.checkSelf(l);
			string customparams;
			LuaObject.checkType(l, 2, out customparams);
			pdsdk.Login(customparams);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022853 RID: 141395 RVA: 0x00BD6E9C File Offset: 0x00BD509C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Logout(IntPtr l)
	{
		int result;
		try
		{
			PDSDK pdsdk = (PDSDK)LuaObject.checkSelf(l);
			string customparams;
			LuaObject.checkType(l, 2, out customparams);
			pdsdk.Logout(customparams);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022854 RID: 141396 RVA: 0x00BD6EF4 File Offset: 0x00BD50F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartGame(IntPtr l)
	{
		int result;
		try
		{
			PDSDK pdsdk = (PDSDK)LuaObject.checkSelf(l);
			string gameparams;
			LuaObject.checkType(l, 2, out gameparams);
			pdsdk.StartGame(gameparams);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022855 RID: 141397 RVA: 0x00BD6F4C File Offset: 0x00BD514C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetProductsList(IntPtr l)
	{
		int result;
		try
		{
			PDSDK pdsdk = (PDSDK)LuaObject.checkSelf(l);
			pdsdk.GetProductsList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022856 RID: 141398 RVA: 0x00BD6F98 File Offset: 0x00BD5198
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DoPromotingPay(IntPtr l)
	{
		int result;
		try
		{
			PDSDK pdsdk = (PDSDK)LuaObject.checkSelf(l);
			string goodsName;
			LuaObject.checkType(l, 2, out goodsName);
			int goodsNumber;
			LuaObject.checkType(l, 3, out goodsNumber);
			string goodsId;
			LuaObject.checkType(l, 4, out goodsId);
			string goodsRegisterId;
			LuaObject.checkType(l, 5, out goodsRegisterId);
			double goodsPrice;
			LuaObject.checkType(l, 6, out goodsPrice);
			string customparams;
			LuaObject.checkType(l, 7, out customparams);
			string goodsDes;
			LuaObject.checkType(l, 8, out goodsDes);
			pdsdk.DoPromotingPay(goodsName, goodsNumber, goodsId, goodsRegisterId, goodsPrice, customparams, goodsDes);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022857 RID: 141399 RVA: 0x00BD703C File Offset: 0x00BD523C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int onSDKPromotingPaySuccess(IntPtr l)
	{
		int result;
		try
		{
			PDSDK pdsdk = (PDSDK)LuaObject.checkSelf(l);
			string msg;
			LuaObject.checkType(l, 2, out msg);
			pdsdk.onSDKPromotingPaySuccess(msg);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022858 RID: 141400 RVA: 0x00BD7094 File Offset: 0x00BD5294
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int onSDKPromotingPayFailed(IntPtr l)
	{
		int result;
		try
		{
			PDSDK pdsdk = (PDSDK)LuaObject.checkSelf(l);
			string msg;
			LuaObject.checkType(l, 2, out msg);
			pdsdk.onSDKPromotingPayFailed(msg);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022859 RID: 141401 RVA: 0x00BD70EC File Offset: 0x00BD52EC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int onSDKPromotingPayCancel(IntPtr l)
	{
		int result;
		try
		{
			PDSDK pdsdk = (PDSDK)LuaObject.checkSelf(l);
			string msg;
			LuaObject.checkType(l, 2, out msg);
			pdsdk.onSDKPromotingPayCancel(msg);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602285A RID: 141402 RVA: 0x00BD7144 File Offset: 0x00BD5344
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DoPay(IntPtr l)
	{
		int result;
		try
		{
			PDSDK pdsdk = (PDSDK)LuaObject.checkSelf(l);
			string goodsName;
			LuaObject.checkType(l, 2, out goodsName);
			int goodsNumber;
			LuaObject.checkType(l, 3, out goodsNumber);
			string goodsId;
			LuaObject.checkType(l, 4, out goodsId);
			string goodsRegisterId;
			LuaObject.checkType(l, 5, out goodsRegisterId);
			double goodsPrice;
			LuaObject.checkType(l, 6, out goodsPrice);
			string customparams;
			LuaObject.checkType(l, 7, out customparams);
			string goodsDes;
			LuaObject.checkType(l, 8, out goodsDes);
			pdsdk.DoPay(goodsName, goodsNumber, goodsId, goodsRegisterId, goodsPrice, customparams, goodsDes);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602285B RID: 141403 RVA: 0x00BD71E8 File Offset: 0x00BD53E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int doAddLocalPush(IntPtr l)
	{
		int result;
		try
		{
			PDSDK pdsdk = (PDSDK)LuaObject.checkSelf(l);
			string title;
			LuaObject.checkType(l, 2, out title);
			string content;
			LuaObject.checkType(l, 3, out content);
			string date;
			LuaObject.checkType(l, 4, out date);
			string hour;
			LuaObject.checkType(l, 5, out hour);
			string min;
			LuaObject.checkType(l, 6, out min);
			pdsdk.doAddLocalPush(title, content, date, hour, min);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602285C RID: 141404 RVA: 0x00BD7274 File Offset: 0x00BD5474
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int doFirstScreen(IntPtr l)
	{
		int result;
		try
		{
			PDSDK pdsdk = (PDSDK)LuaObject.checkSelf(l);
			pdsdk.doFirstScreen();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602285D RID: 141405 RVA: 0x00BD72C0 File Offset: 0x00BD54C0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SwitchUser(IntPtr l)
	{
		int result;
		try
		{
			PDSDK pdsdk = (PDSDK)LuaObject.checkSelf(l);
			pdsdk.SwitchUser();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602285E RID: 141406 RVA: 0x00BD730C File Offset: 0x00BD550C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int userCenter(IntPtr l)
	{
		int result;
		try
		{
			PDSDK pdsdk = (PDSDK)LuaObject.checkSelf(l);
			pdsdk.userCenter();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602285F RID: 141407 RVA: 0x00BD7358 File Offset: 0x00BD5558
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int exit(IntPtr l)
	{
		int result;
		try
		{
			PDSDK pdsdk = (PDSDK)LuaObject.checkSelf(l);
			pdsdk.exit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022860 RID: 141408 RVA: 0x00BD73A4 File Offset: 0x00BD55A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetPustToken(IntPtr l)
	{
		int result;
		try
		{
			PDSDK pdsdk = (PDSDK)LuaObject.checkSelf(l);
			string pustToken = pdsdk.GetPustToken();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pustToken);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022861 RID: 141409 RVA: 0x00BD73F8 File Offset: 0x00BD55F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetDeviceID(IntPtr l)
	{
		int result;
		try
		{
			PDSDK pdsdk = (PDSDK)LuaObject.checkSelf(l);
			string deviceID = pdsdk.GetDeviceID();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, deviceID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022862 RID: 141410 RVA: 0x00BD744C File Offset: 0x00BD564C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetBattery(IntPtr l)
	{
		int result;
		try
		{
			PDSDK pdsdk = (PDSDK)LuaObject.checkSelf(l);
			int battery = pdsdk.GetBattery();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battery);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022863 RID: 141411 RVA: 0x00BD74A0 File Offset: 0x00BD56A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OpenInvestigation(IntPtr l)
	{
		int result;
		try
		{
			PDSDK pdsdk = (PDSDK)LuaObject.checkSelf(l);
			int enqId;
			LuaObject.checkType(l, 2, out enqId);
			pdsdk.OpenInvestigation(enqId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022864 RID: 141412 RVA: 0x00BD74F8 File Offset: 0x00BD56F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PathOrder(IntPtr l)
	{
		int result;
		try
		{
			PDSDK pdsdk = (PDSDK)LuaObject.checkSelf(l);
			pdsdk.PathOrder();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022865 RID: 141413 RVA: 0x00BD7544 File Offset: 0x00BD5744
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ShowPayHelp(IntPtr l)
	{
		int result;
		try
		{
			PDSDK pdsdk = (PDSDK)LuaObject.checkSelf(l);
			pdsdk.ShowPayHelp();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022866 RID: 141414 RVA: 0x00BD7590 File Offset: 0x00BD5790
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int printGameEventLog(IntPtr l)
	{
		int result;
		try
		{
			PDSDK pdsdk = (PDSDK)LuaObject.checkSelf(l);
			string eventID;
			LuaObject.checkType(l, 2, out eventID);
			string remark;
			LuaObject.checkType(l, 3, out remark);
			pdsdk.printGameEventLog(eventID, remark);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022867 RID: 141415 RVA: 0x00BD75F4 File Offset: 0x00BD57F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int doSetExtData(IntPtr l)
	{
		int result;
		try
		{
			PDSDK pdsdk = (PDSDK)LuaObject.checkSelf(l);
			string data;
			LuaObject.checkType(l, 2, out data);
			string type;
			LuaObject.checkType(l, 3, out type);
			string s = pdsdk.doSetExtData(data, type);
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

	// Token: 0x06022868 RID: 141416 RVA: 0x00BD7664 File Offset: 0x00BD5864
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int doStartQRLogin(IntPtr l)
	{
		int result;
		try
		{
			PDSDK pdsdk = (PDSDK)LuaObject.checkSelf(l);
			string customParams;
			LuaObject.checkType(l, 2, out customParams);
			pdsdk.doStartQRLogin(customParams);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022869 RID: 141417 RVA: 0x00BD76BC File Offset: 0x00BD58BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int getChannelID(IntPtr l)
	{
		int result;
		try
		{
			PDSDK pdsdk = (PDSDK)LuaObject.checkSelf(l);
			string channelID = pdsdk.getChannelID();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, channelID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602286A RID: 141418 RVA: 0x00BD7710 File Offset: 0x00BD5910
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int doSaveImageToPhotoLibrary(IntPtr l)
	{
		int result;
		try
		{
			PDSDK pdsdk = (PDSDK)LuaObject.checkSelf(l);
			string data;
			LuaObject.checkType(l, 2, out data);
			pdsdk.doSaveImageToPhotoLibrary(data);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602286B RID: 141419 RVA: 0x00BD7768 File Offset: 0x00BD5968
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int doQQVIP(IntPtr l)
	{
		int result;
		try
		{
			PDSDK pdsdk = (PDSDK)LuaObject.checkSelf(l);
			pdsdk.doQQVIP();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602286C RID: 141420 RVA: 0x00BD77B4 File Offset: 0x00BD59B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int callWebView(IntPtr l)
	{
		int result;
		try
		{
			PDSDK pdsdk = (PDSDK)LuaObject.checkSelf(l);
			string title;
			LuaObject.checkType(l, 2, out title);
			int fullscreen_flag;
			LuaObject.checkType(l, 3, out fullscreen_flag);
			int title_flag;
			LuaObject.checkType(l, 4, out title_flag);
			string action;
			LuaObject.checkType(l, 5, out action);
			string customparams;
			LuaObject.checkType(l, 6, out customparams);
			pdsdk.callWebView(title, fullscreen_flag, title_flag, action, customparams);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602286D RID: 141421 RVA: 0x00BD7840 File Offset: 0x00BD5A40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int clearLocalNotifications(IntPtr l)
	{
		int result;
		try
		{
			PDSDK pdsdk = (PDSDK)LuaObject.checkSelf(l);
			pdsdk.clearLocalNotifications();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602286E RID: 141422 RVA: 0x00BD788C File Offset: 0x00BD5A8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int callCustomerServiceWeb(IntPtr l)
	{
		int result;
		try
		{
			PDSDK pdsdk = (PDSDK)LuaObject.checkSelf(l);
			pdsdk.callCustomerServiceWeb();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602286F RID: 141423 RVA: 0x00BD78D8 File Offset: 0x00BD5AD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int doshare(IntPtr l)
	{
		int result;
		try
		{
			PDSDK pdsdk = (PDSDK)LuaObject.checkSelf(l);
			string data;
			LuaObject.checkType(l, 2, out data);
			pdsdk.doshare(data);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022870 RID: 141424 RVA: 0x00BD7930 File Offset: 0x00BD5B30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int doStartRecord(IntPtr l)
	{
		int result;
		try
		{
			PDSDK pdsdk = (PDSDK)LuaObject.checkSelf(l);
			pdsdk.doStartRecord();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022871 RID: 141425 RVA: 0x00BD797C File Offset: 0x00BD5B7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int doStopRecord(IntPtr l)
	{
		int result;
		try
		{
			PDSDK pdsdk = (PDSDK)LuaObject.checkSelf(l);
			pdsdk.doStopRecord();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022872 RID: 141426 RVA: 0x00BD79C8 File Offset: 0x00BD5BC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int doBoradcast(IntPtr l)
	{
		int result;
		try
		{
			PDSDK pdsdk = (PDSDK)LuaObject.checkSelf(l);
			pdsdk.doBoradcast();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022873 RID: 141427 RVA: 0x00BD7A14 File Offset: 0x00BD5C14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int doOpenRequestReview(IntPtr l)
	{
		int result;
		try
		{
			PDSDK pdsdk = (PDSDK)LuaObject.checkSelf(l);
			pdsdk.doOpenRequestReview();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022874 RID: 141428 RVA: 0x00BD7A60 File Offset: 0x00BD5C60
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int onLoginSuccess(IntPtr l)
	{
		int result;
		try
		{
			PDSDK pdsdk = (PDSDK)LuaObject.checkSelf(l);
			string msg;
			LuaObject.checkType(l, 2, out msg);
			pdsdk.onLoginSuccess(msg);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022875 RID: 141429 RVA: 0x00BD7AB8 File Offset: 0x00BD5CB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int onLoginFailed(IntPtr l)
	{
		int result;
		try
		{
			PDSDK pdsdk = (PDSDK)LuaObject.checkSelf(l);
			string msg;
			LuaObject.checkType(l, 2, out msg);
			pdsdk.onLoginFailed(msg);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022876 RID: 141430 RVA: 0x00BD7B10 File Offset: 0x00BD5D10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int onLoginCancel(IntPtr l)
	{
		int result;
		try
		{
			PDSDK pdsdk = (PDSDK)LuaObject.checkSelf(l);
			string msg;
			LuaObject.checkType(l, 2, out msg);
			pdsdk.onLoginCancel(msg);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022877 RID: 141431 RVA: 0x00BD7B68 File Offset: 0x00BD5D68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int onLogoutSuccess(IntPtr l)
	{
		int result;
		try
		{
			PDSDK pdsdk = (PDSDK)LuaObject.checkSelf(l);
			string msg;
			LuaObject.checkType(l, 2, out msg);
			pdsdk.onLogoutSuccess(msg);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022878 RID: 141432 RVA: 0x00BD7BC0 File Offset: 0x00BD5DC0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int onLogoutFailed(IntPtr l)
	{
		int result;
		try
		{
			PDSDK pdsdk = (PDSDK)LuaObject.checkSelf(l);
			string msg;
			LuaObject.checkType(l, 2, out msg);
			pdsdk.onLogoutFailed(msg);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022879 RID: 141433 RVA: 0x00BD7C18 File Offset: 0x00BD5E18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int onLogoutCancel(IntPtr l)
	{
		int result;
		try
		{
			PDSDK pdsdk = (PDSDK)LuaObject.checkSelf(l);
			string msg;
			LuaObject.checkType(l, 2, out msg);
			pdsdk.onLogoutCancel(msg);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602287A RID: 141434 RVA: 0x00BD7C70 File Offset: 0x00BD5E70
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int onGetProductsListSuccess(IntPtr l)
	{
		int result;
		try
		{
			PDSDK pdsdk = (PDSDK)LuaObject.checkSelf(l);
			string msg;
			LuaObject.checkType(l, 2, out msg);
			pdsdk.onGetProductsListSuccess(msg);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602287B RID: 141435 RVA: 0x00BD7CC8 File Offset: 0x00BD5EC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int onGetProductsListFailed(IntPtr l)
	{
		int result;
		try
		{
			PDSDK pdsdk = (PDSDK)LuaObject.checkSelf(l);
			string msg;
			LuaObject.checkType(l, 2, out msg);
			pdsdk.onGetProductsListFailed(msg);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602287C RID: 141436 RVA: 0x00BD7D20 File Offset: 0x00BD5F20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int onPaySuccess(IntPtr l)
	{
		int result;
		try
		{
			PDSDK pdsdk = (PDSDK)LuaObject.checkSelf(l);
			string msg;
			LuaObject.checkType(l, 2, out msg);
			pdsdk.onPaySuccess(msg);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602287D RID: 141437 RVA: 0x00BD7D78 File Offset: 0x00BD5F78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int onPayFailed(IntPtr l)
	{
		int result;
		try
		{
			PDSDK pdsdk = (PDSDK)LuaObject.checkSelf(l);
			string msg;
			LuaObject.checkType(l, 2, out msg);
			pdsdk.onPayFailed(msg);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602287E RID: 141438 RVA: 0x00BD7DD0 File Offset: 0x00BD5FD0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int onPayCancel(IntPtr l)
	{
		int result;
		try
		{
			PDSDK pdsdk = (PDSDK)LuaObject.checkSelf(l);
			string msg;
			LuaObject.checkType(l, 2, out msg);
			pdsdk.onPayCancel(msg);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602287F RID: 141439 RVA: 0x00BD7E28 File Offset: 0x00BD6028
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int onGetPayHistorySuccess(IntPtr l)
	{
		int result;
		try
		{
			PDSDK pdsdk = (PDSDK)LuaObject.checkSelf(l);
			string msg;
			LuaObject.checkType(l, 2, out msg);
			pdsdk.onGetPayHistorySuccess(msg);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022880 RID: 141440 RVA: 0x00BD7E80 File Offset: 0x00BD6080
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int onGetPayHistoryFailed(IntPtr l)
	{
		int result;
		try
		{
			PDSDK pdsdk = (PDSDK)LuaObject.checkSelf(l);
			string msg;
			LuaObject.checkType(l, 2, out msg);
			pdsdk.onGetPayHistoryFailed(msg);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022881 RID: 141441 RVA: 0x00BD7ED8 File Offset: 0x00BD60D8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int onInitSuccess(IntPtr l)
	{
		int result;
		try
		{
			PDSDK pdsdk = (PDSDK)LuaObject.checkSelf(l);
			string msg;
			LuaObject.checkType(l, 2, out msg);
			pdsdk.onInitSuccess(msg);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022882 RID: 141442 RVA: 0x00BD7F30 File Offset: 0x00BD6130
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int onInitFailed(IntPtr l)
	{
		int result;
		try
		{
			PDSDK pdsdk = (PDSDK)LuaObject.checkSelf(l);
			string msg;
			LuaObject.checkType(l, 2, out msg);
			pdsdk.onInitFailed(msg);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022883 RID: 141443 RVA: 0x00BD7F88 File Offset: 0x00BD6188
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int onswitchUserSuccess(IntPtr l)
	{
		int result;
		try
		{
			PDSDK pdsdk = (PDSDK)LuaObject.checkSelf(l);
			string msg;
			LuaObject.checkType(l, 2, out msg);
			pdsdk.onswitchUserSuccess(msg);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022884 RID: 141444 RVA: 0x00BD7FE0 File Offset: 0x00BD61E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int onswitchUserFailed(IntPtr l)
	{
		int result;
		try
		{
			PDSDK pdsdk = (PDSDK)LuaObject.checkSelf(l);
			string msg;
			LuaObject.checkType(l, 2, out msg);
			pdsdk.onswitchUserFailed(msg);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022885 RID: 141445 RVA: 0x00BD8038 File Offset: 0x00BD6238
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int onswitchUserCancel(IntPtr l)
	{
		int result;
		try
		{
			PDSDK pdsdk = (PDSDK)LuaObject.checkSelf(l);
			string msg;
			LuaObject.checkType(l, 2, out msg);
			pdsdk.onswitchUserCancel(msg);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022886 RID: 141446 RVA: 0x00BD8090 File Offset: 0x00BD6290
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int onVerifyTokenSuccess(IntPtr l)
	{
		int result;
		try
		{
			PDSDK pdsdk = (PDSDK)LuaObject.checkSelf(l);
			string msg;
			LuaObject.checkType(l, 2, out msg);
			pdsdk.onVerifyTokenSuccess(msg);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022887 RID: 141447 RVA: 0x00BD80E8 File Offset: 0x00BD62E8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int onVerifyTokenFailed(IntPtr l)
	{
		int result;
		try
		{
			PDSDK pdsdk = (PDSDK)LuaObject.checkSelf(l);
			string msg;
			LuaObject.checkType(l, 2, out msg);
			pdsdk.onVerifyTokenFailed(msg);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022888 RID: 141448 RVA: 0x00BD8140 File Offset: 0x00BD6340
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int onDoSetExtDataSuccess(IntPtr l)
	{
		int result;
		try
		{
			PDSDK pdsdk = (PDSDK)LuaObject.checkSelf(l);
			string msg;
			LuaObject.checkType(l, 2, out msg);
			pdsdk.onDoSetExtDataSuccess(msg);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022889 RID: 141449 RVA: 0x00BD8198 File Offset: 0x00BD6398
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int onDoSetExtDataFailed(IntPtr l)
	{
		int result;
		try
		{
			PDSDK pdsdk = (PDSDK)LuaObject.checkSelf(l);
			string msg;
			LuaObject.checkType(l, 2, out msg);
			pdsdk.onDoSetExtDataFailed(msg);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602288A RID: 141450 RVA: 0x00BD81F0 File Offset: 0x00BD63F0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int onExitSuccess(IntPtr l)
	{
		int result;
		try
		{
			PDSDK pdsdk = (PDSDK)LuaObject.checkSelf(l);
			string msg;
			LuaObject.checkType(l, 2, out msg);
			pdsdk.onExitSuccess(msg);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602288B RID: 141451 RVA: 0x00BD8248 File Offset: 0x00BD6448
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int onExitFailed(IntPtr l)
	{
		int result;
		try
		{
			PDSDK pdsdk = (PDSDK)LuaObject.checkSelf(l);
			string msg;
			LuaObject.checkType(l, 2, out msg);
			pdsdk.onExitFailed(msg);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602288C RID: 141452 RVA: 0x00BD82A0 File Offset: 0x00BD64A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int onMemoryWarning(IntPtr l)
	{
		int result;
		try
		{
			PDSDK pdsdk = (PDSDK)LuaObject.checkSelf(l);
			string recode;
			LuaObject.checkType(l, 2, out recode);
			pdsdk.onMemoryWarning(recode);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602288D RID: 141453 RVA: 0x00BD82F8 File Offset: 0x00BD64F8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int onShareSuccess(IntPtr l)
	{
		int result;
		try
		{
			PDSDK pdsdk = (PDSDK)LuaObject.checkSelf(l);
			string msg;
			LuaObject.checkType(l, 2, out msg);
			pdsdk.onShareSuccess(msg);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602288E RID: 141454 RVA: 0x00BD8350 File Offset: 0x00BD6550
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int onShareFailed(IntPtr l)
	{
		int result;
		try
		{
			PDSDK pdsdk = (PDSDK)LuaObject.checkSelf(l);
			string msg;
			LuaObject.checkType(l, 2, out msg);
			pdsdk.onShareFailed(msg);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602288F RID: 141455 RVA: 0x00BD83A8 File Offset: 0x00BD65A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int onShareCancel(IntPtr l)
	{
		int result;
		try
		{
			PDSDK pdsdk = (PDSDK)LuaObject.checkSelf(l);
			string msg;
			LuaObject.checkType(l, 2, out msg);
			pdsdk.onShareCancel(msg);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022890 RID: 141456 RVA: 0x00BD8400 File Offset: 0x00BD6600
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int onRecordStartSuccess(IntPtr l)
	{
		int result;
		try
		{
			PDSDK pdsdk = (PDSDK)LuaObject.checkSelf(l);
			string msg;
			LuaObject.checkType(l, 2, out msg);
			pdsdk.onRecordStartSuccess(msg);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022891 RID: 141457 RVA: 0x00BD8458 File Offset: 0x00BD6658
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int onRecordStartFail(IntPtr l)
	{
		int result;
		try
		{
			PDSDK pdsdk = (PDSDK)LuaObject.checkSelf(l);
			string msg;
			LuaObject.checkType(l, 2, out msg);
			pdsdk.onRecordStartFail(msg);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022892 RID: 141458 RVA: 0x00BD84B0 File Offset: 0x00BD66B0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int onRecordStopSuccess(IntPtr l)
	{
		int result;
		try
		{
			PDSDK pdsdk = (PDSDK)LuaObject.checkSelf(l);
			string msg;
			LuaObject.checkType(l, 2, out msg);
			pdsdk.onRecordStopSuccess(msg);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022893 RID: 141459 RVA: 0x00BD8508 File Offset: 0x00BD6708
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int onRecordStopFail(IntPtr l)
	{
		int result;
		try
		{
			PDSDK pdsdk = (PDSDK)LuaObject.checkSelf(l);
			string msg;
			LuaObject.checkType(l, 2, out msg);
			pdsdk.onRecordStopFail(msg);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022894 RID: 141460 RVA: 0x00BD8560 File Offset: 0x00BD6760
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int onBoradcastSuccess(IntPtr l)
	{
		int result;
		try
		{
			PDSDK pdsdk = (PDSDK)LuaObject.checkSelf(l);
			string msg;
			LuaObject.checkType(l, 2, out msg);
			pdsdk.onBoradcastSuccess(msg);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022895 RID: 141461 RVA: 0x00BD85B8 File Offset: 0x00BD67B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int onBoradcastFail(IntPtr l)
	{
		int result;
		try
		{
			PDSDK pdsdk = (PDSDK)LuaObject.checkSelf(l);
			string msg;
			LuaObject.checkType(l, 2, out msg);
			pdsdk.onBoradcastFail(msg);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022896 RID: 141462 RVA: 0x00BD8610 File Offset: 0x00BD6810
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int onDoQuestionSuccess(IntPtr l)
	{
		int result;
		try
		{
			PDSDK pdsdk = (PDSDK)LuaObject.checkSelf(l);
			string msg;
			LuaObject.checkType(l, 2, out msg);
			pdsdk.onDoQuestionSuccess(msg);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022897 RID: 141463 RVA: 0x00BD8668 File Offset: 0x00BD6868
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int onDoQuestionFailed(IntPtr l)
	{
		int result;
		try
		{
			PDSDK pdsdk = (PDSDK)LuaObject.checkSelf(l);
			string msg;
			LuaObject.checkType(l, 2, out msg);
			pdsdk.onDoQuestionFailed(msg);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022898 RID: 141464 RVA: 0x00BD86C0 File Offset: 0x00BD68C0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int oncallWebViewSuccess(IntPtr l)
	{
		int result;
		try
		{
			PDSDK pdsdk = (PDSDK)LuaObject.checkSelf(l);
			string msg;
			LuaObject.checkType(l, 2, out msg);
			pdsdk.oncallWebViewSuccess(msg);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022899 RID: 141465 RVA: 0x00BD8718 File Offset: 0x00BD6918
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int oncallWebViewFailed(IntPtr l)
	{
		int result;
		try
		{
			PDSDK pdsdk = (PDSDK)LuaObject.checkSelf(l);
			string msg;
			LuaObject.checkType(l, 2, out msg);
			pdsdk.oncallWebViewFailed(msg);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602289A RID: 141466 RVA: 0x00BD8770 File Offset: 0x00BD6970
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int oncallWebViewCancel(IntPtr l)
	{
		int result;
		try
		{
			PDSDK pdsdk = (PDSDK)LuaObject.checkSelf(l);
			string msg;
			LuaObject.checkType(l, 2, out msg);
			pdsdk.oncallWebViewCancel(msg);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602289B RID: 141467 RVA: 0x00BD87C8 File Offset: 0x00BD69C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int onDoSaveImageToPhotoLibrarySuccess(IntPtr l)
	{
		int result;
		try
		{
			PDSDK pdsdk = (PDSDK)LuaObject.checkSelf(l);
			string msg;
			LuaObject.checkType(l, 2, out msg);
			pdsdk.onDoSaveImageToPhotoLibrarySuccess(msg);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602289C RID: 141468 RVA: 0x00BD8820 File Offset: 0x00BD6A20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int onDoSaveImageToPhotoLibraryFailed(IntPtr l)
	{
		int result;
		try
		{
			PDSDK pdsdk = (PDSDK)LuaObject.checkSelf(l);
			string msg;
			LuaObject.checkType(l, 2, out msg);
			pdsdk.onDoSaveImageToPhotoLibraryFailed(msg);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602289D RID: 141469 RVA: 0x00BD8878 File Offset: 0x00BD6A78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int showAndroidToast(IntPtr l)
	{
		int result;
		try
		{
			PDSDK pdsdk = (PDSDK)LuaObject.checkSelf(l);
			string info;
			LuaObject.checkType(l, 2, out info);
			pdsdk.showAndroidToast(info);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602289E RID: 141470 RVA: 0x00BD88D0 File Offset: 0x00BD6AD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int verifyToken(IntPtr l)
	{
		int result;
		try
		{
			PDSDK pdsdk = (PDSDK)LuaObject.checkSelf(l);
			string info;
			LuaObject.checkType(l, 2, out info);
			pdsdk.verifyToken(info);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602289F RID: 141471 RVA: 0x00BD8928 File Offset: 0x00BD6B28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnGUI(IntPtr l)
	{
		int result;
		try
		{
			PDSDK pdsdk = (PDSDK)LuaObject.checkSelf(l);
			pdsdk.OnGUI();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060228A0 RID: 141472 RVA: 0x00BD8974 File Offset: 0x00BD6B74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DoCoroutine_s(IntPtr l)
	{
		int result;
		try
		{
			IEnumerator coroutine;
			LuaObject.checkType<IEnumerator>(l, 1, out coroutine);
			Action onComplete;
			LuaObject.checkDelegate<Action>(l, 2, out onComplete);
			PDSDK.DoCoroutine(coroutine, onComplete);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060228A1 RID: 141473 RVA: 0x00BD89CC File Offset: 0x00BD6BCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Perform(IntPtr l)
	{
		int result;
		try
		{
			PDSDK pdsdk = (PDSDK)LuaObject.checkSelf(l);
			IEnumerator coroutine;
			LuaObject.checkType<IEnumerator>(l, 2, out coroutine);
			Action onComplete;
			LuaObject.checkDelegate<Action>(l, 3, out onComplete);
			IEnumerator o = pdsdk.m_luaExportHelper.Perform(coroutine, onComplete);
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

	// Token: 0x060228A2 RID: 141474 RVA: 0x00BD8A40 File Offset: 0x00BD6C40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Awake(IntPtr l)
	{
		int result;
		try
		{
			PDSDK pdsdk = (PDSDK)LuaObject.checkSelf(l);
			pdsdk.m_luaExportHelper.Awake();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060228A3 RID: 141475 RVA: 0x00BD8A94 File Offset: 0x00BD6C94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Update(IntPtr l)
	{
		int result;
		try
		{
			PDSDK pdsdk = (PDSDK)LuaObject.checkSelf(l);
			pdsdk.m_luaExportHelper.Update();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060228A4 RID: 141476 RVA: 0x00BD8AE8 File Offset: 0x00BD6CE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int onQRLoginSuccess(IntPtr l)
	{
		int result;
		try
		{
			PDSDK pdsdk = (PDSDK)LuaObject.checkSelf(l);
			string msg;
			LuaObject.checkType(l, 2, out msg);
			pdsdk.m_luaExportHelper.onQRLoginSuccess(msg);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060228A5 RID: 141477 RVA: 0x00BD8B44 File Offset: 0x00BD6D44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int onQRLoginFailed(IntPtr l)
	{
		int result;
		try
		{
			PDSDK pdsdk = (PDSDK)LuaObject.checkSelf(l);
			string msg;
			LuaObject.checkType(l, 2, out msg);
			pdsdk.m_luaExportHelper.onQRLoginFailed(msg);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060228A6 RID: 141478 RVA: 0x00BD8BA0 File Offset: 0x00BD6DA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int onQRLoginCancel(IntPtr l)
	{
		int result;
		try
		{
			PDSDK pdsdk = (PDSDK)LuaObject.checkSelf(l);
			string msg;
			LuaObject.checkType(l, 2, out msg);
			pdsdk.m_luaExportHelper.onQRLoginCancel(msg);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060228A7 RID: 141479 RVA: 0x00BD8BFC File Offset: 0x00BD6DFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_isDebug(IntPtr l)
	{
		int result;
		try
		{
			PDSDK pdsdk = (PDSDK)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pdsdk.isDebug);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060228A8 RID: 141480 RVA: 0x00BD8C50 File Offset: 0x00BD6E50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_isDebug(IntPtr l)
	{
		int result;
		try
		{
			PDSDK pdsdk = (PDSDK)LuaObject.checkSelf(l);
			bool isDebug;
			LuaObject.checkType(l, 2, out isDebug);
			pdsdk.isDebug = isDebug;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060228A9 RID: 141481 RVA: 0x00BD8CA8 File Offset: 0x00BD6EA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_isVerfy(IntPtr l)
	{
		int result;
		try
		{
			PDSDK pdsdk = (PDSDK)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pdsdk.isVerfy);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060228AA RID: 141482 RVA: 0x00BD8CFC File Offset: 0x00BD6EFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_isVerfy(IntPtr l)
	{
		int result;
		try
		{
			PDSDK pdsdk = (PDSDK)LuaObject.checkSelf(l);
			bool isVerfy;
			LuaObject.checkType(l, 2, out isVerfy);
			pdsdk.isVerfy = isVerfy;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060228AB RID: 141483 RVA: 0x00BD8D54 File Offset: 0x00BD6F54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_goodlistjson(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, PDSDK.goodlistjson);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060228AC RID: 141484 RVA: 0x00BD8D9C File Offset: 0x00BD6F9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_goodlistjson(IntPtr l)
	{
		int result;
		try
		{
			JsonData goodlistjson;
			LuaObject.checkType<JsonData>(l, 2, out goodlistjson);
			PDSDK.goodlistjson = goodlistjson;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060228AD RID: 141485 RVA: 0x00BD8DE8 File Offset: 0x00BD6FE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_promotingPayGoodsRegisterID(IntPtr l)
	{
		int result;
		try
		{
			PDSDK pdsdk = (PDSDK)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pdsdk.promotingPayGoodsRegisterID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060228AE RID: 141486 RVA: 0x00BD8E3C File Offset: 0x00BD703C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_promotingPayGoodsRegisterID(IntPtr l)
	{
		int result;
		try
		{
			PDSDK pdsdk = (PDSDK)LuaObject.checkSelf(l);
			string promotingPayGoodsRegisterID;
			LuaObject.checkType(l, 2, out promotingPayGoodsRegisterID);
			pdsdk.promotingPayGoodsRegisterID = promotingPayGoodsRegisterID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060228AF RID: 141487 RVA: 0x00BD8E94 File Offset: 0x00BD7094
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_stringToEdit(IntPtr l)
	{
		int result;
		try
		{
			PDSDK pdsdk = (PDSDK)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pdsdk.stringToEdit);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060228B0 RID: 141488 RVA: 0x00BD8EE8 File Offset: 0x00BD70E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_stringToEdit(IntPtr l)
	{
		int result;
		try
		{
			PDSDK pdsdk = (PDSDK)LuaObject.checkSelf(l);
			string stringToEdit;
			LuaObject.checkType(l, 2, out stringToEdit);
			pdsdk.stringToEdit = stringToEdit;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060228B1 RID: 141489 RVA: 0x00BD8F40 File Offset: 0x00BD7140
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_isExitSuccess(IntPtr l)
	{
		int result;
		try
		{
			PDSDK pdsdk = (PDSDK)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pdsdk.isExitSuccess);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060228B2 RID: 141490 RVA: 0x00BD8F94 File Offset: 0x00BD7194
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_isExitSuccess(IntPtr l)
	{
		int result;
		try
		{
			PDSDK pdsdk = (PDSDK)LuaObject.checkSelf(l);
			bool isExitSuccess;
			LuaObject.checkType(l, 2, out isExitSuccess);
			pdsdk.isExitSuccess = isExitSuccess;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060228B3 RID: 141491 RVA: 0x00BD8FEC File Offset: 0x00BD71EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isCallWebView(IntPtr l)
	{
		int result;
		try
		{
			PDSDK pdsdk = (PDSDK)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pdsdk.m_isCallWebView);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060228B4 RID: 141492 RVA: 0x00BD9040 File Offset: 0x00BD7240
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isCallWebView(IntPtr l)
	{
		int result;
		try
		{
			PDSDK pdsdk = (PDSDK)LuaObject.checkSelf(l);
			bool isCallWebView;
			LuaObject.checkType(l, 2, out isCallWebView);
			pdsdk.m_isCallWebView = isCallWebView;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060228B5 RID: 141493 RVA: 0x00BD9098 File Offset: 0x00BD7298
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_isLogin(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, PDSDK.LuaExportHelper.isLogin);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060228B6 RID: 141494 RVA: 0x00BD90E0 File Offset: 0x00BD72E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_isLogin(IntPtr l)
	{
		int result;
		try
		{
			bool isLogin;
			LuaObject.checkType(l, 2, out isLogin);
			PDSDK.LuaExportHelper.isLogin = isLogin;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060228B7 RID: 141495 RVA: 0x00BD912C File Offset: 0x00BD732C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get__isLogining(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, PDSDK.LuaExportHelper._isLogining);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060228B8 RID: 141496 RVA: 0x00BD9174 File Offset: 0x00BD7374
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set__isLogining(IntPtr l)
	{
		int result;
		try
		{
			bool isLogining;
			LuaObject.checkType(l, 2, out isLogining);
			PDSDK.LuaExportHelper._isLogining = isLogining;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060228B9 RID: 141497 RVA: 0x00BD91C0 File Offset: 0x00BD73C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get__isLogouting(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, PDSDK.LuaExportHelper._isLogouting);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060228BA RID: 141498 RVA: 0x00BD9208 File Offset: 0x00BD7408
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set__isLogouting(IntPtr l)
	{
		int result;
		try
		{
			bool isLogouting;
			LuaObject.checkType(l, 2, out isLogouting);
			PDSDK.LuaExportHelper._isLogouting = isLogouting;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060228BB RID: 141499 RVA: 0x00BD9254 File Offset: 0x00BD7454
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_isInit(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, PDSDK.LuaExportHelper.isInit);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060228BC RID: 141500 RVA: 0x00BD929C File Offset: 0x00BD749C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_isInit(IntPtr l)
	{
		int result;
		try
		{
			bool isInit;
			LuaObject.checkType(l, 2, out isInit);
			PDSDK.LuaExportHelper.isInit = isInit;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060228BD RID: 141501 RVA: 0x00BD92E8 File Offset: 0x00BD74E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get__isIosReview(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, PDSDK.LuaExportHelper._isIosReview);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060228BE RID: 141502 RVA: 0x00BD9330 File Offset: 0x00BD7530
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set__isIosReview(IntPtr l)
	{
		int result;
		try
		{
			bool isIosReview;
			LuaObject.checkType(l, 2, out isIosReview);
			PDSDK.LuaExportHelper._isIosReview = isIosReview;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060228BF RID: 141503 RVA: 0x00BD937C File Offset: 0x00BD757C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get__instance(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, PDSDK.LuaExportHelper._instance);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060228C0 RID: 141504 RVA: 0x00BD93C4 File Offset: 0x00BD75C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set__instance(IntPtr l)
	{
		int result;
		try
		{
			PDSDK instance;
			LuaObject.checkType<PDSDK>(l, 2, out instance);
			PDSDK.LuaExportHelper._instance = instance;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060228C1 RID: 141505 RVA: 0x00BD9410 File Offset: 0x00BD7610
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_eventLoginSuccess(IntPtr l)
	{
		int result;
		try
		{
			Action<LoginSuccessMsg> action;
			int num = LuaObject.checkDelegate<Action<LoginSuccessMsg>>(l, 2, out action);
			if (num == 0)
			{
				PDSDK.m_eventLoginSuccess = action;
			}
			else if (num == 1)
			{
				PDSDK.m_eventLoginSuccess = (Action<LoginSuccessMsg>)Delegate.Combine(PDSDK.m_eventLoginSuccess, action);
			}
			else if (num == 2)
			{
				PDSDK.m_eventLoginSuccess = (Action<LoginSuccessMsg>)Delegate.Remove(PDSDK.m_eventLoginSuccess, action);
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

	// Token: 0x060228C2 RID: 141506 RVA: 0x00BD94A4 File Offset: 0x00BD76A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_eventOnSwitchUserSuccess(IntPtr l)
	{
		int result;
		try
		{
			Action<LoginSuccessMsg> action;
			int num = LuaObject.checkDelegate<Action<LoginSuccessMsg>>(l, 2, out action);
			if (num == 0)
			{
				PDSDK.m_eventOnSwitchUserSuccess = action;
			}
			else if (num == 1)
			{
				PDSDK.m_eventOnSwitchUserSuccess = (Action<LoginSuccessMsg>)Delegate.Combine(PDSDK.m_eventOnSwitchUserSuccess, action);
			}
			else if (num == 2)
			{
				PDSDK.m_eventOnSwitchUserSuccess = (Action<LoginSuccessMsg>)Delegate.Remove(PDSDK.m_eventOnSwitchUserSuccess, action);
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

	// Token: 0x060228C3 RID: 141507 RVA: 0x00BD9538 File Offset: 0x00BD7738
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_eventLoginFailed(IntPtr l)
	{
		int result;
		try
		{
			Action action;
			int num = LuaObject.checkDelegate<Action>(l, 2, out action);
			if (num == 0)
			{
				PDSDK.m_eventLoginFailed = action;
			}
			else if (num == 1)
			{
				PDSDK.m_eventLoginFailed = (Action)Delegate.Combine(PDSDK.m_eventLoginFailed, action);
			}
			else if (num == 2)
			{
				PDSDK.m_eventLoginFailed = (Action)Delegate.Remove(PDSDK.m_eventLoginFailed, action);
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

	// Token: 0x060228C4 RID: 141508 RVA: 0x00BD95CC File Offset: 0x00BD77CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_eventLogoutSuccess(IntPtr l)
	{
		int result;
		try
		{
			Action action;
			int num = LuaObject.checkDelegate<Action>(l, 2, out action);
			if (num == 0)
			{
				PDSDK.m_eventLogoutSuccess = action;
			}
			else if (num == 1)
			{
				PDSDK.m_eventLogoutSuccess = (Action)Delegate.Combine(PDSDK.m_eventLogoutSuccess, action);
			}
			else if (num == 2)
			{
				PDSDK.m_eventLogoutSuccess = (Action)Delegate.Remove(PDSDK.m_eventLogoutSuccess, action);
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

	// Token: 0x060228C5 RID: 141509 RVA: 0x00BD9660 File Offset: 0x00BD7860
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_eventInitSuccess(IntPtr l)
	{
		int result;
		try
		{
			Action action;
			int num = LuaObject.checkDelegate<Action>(l, 2, out action);
			if (num == 0)
			{
				PDSDK.m_eventInitSuccess = action;
			}
			else if (num == 1)
			{
				PDSDK.m_eventInitSuccess = (Action)Delegate.Combine(PDSDK.m_eventInitSuccess, action);
			}
			else if (num == 2)
			{
				PDSDK.m_eventInitSuccess = (Action)Delegate.Remove(PDSDK.m_eventInitSuccess, action);
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

	// Token: 0x060228C6 RID: 141510 RVA: 0x00BD96F4 File Offset: 0x00BD78F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_eventInitFailed(IntPtr l)
	{
		int result;
		try
		{
			Action action;
			int num = LuaObject.checkDelegate<Action>(l, 2, out action);
			if (num == 0)
			{
				PDSDK.m_eventInitFailed = action;
			}
			else if (num == 1)
			{
				PDSDK.m_eventInitFailed = (Action)Delegate.Combine(PDSDK.m_eventInitFailed, action);
			}
			else if (num == 2)
			{
				PDSDK.m_eventInitFailed = (Action)Delegate.Remove(PDSDK.m_eventInitFailed, action);
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

	// Token: 0x060228C7 RID: 141511 RVA: 0x00BD9788 File Offset: 0x00BD7988
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_eventDoQuestionSucceed(IntPtr l)
	{
		int result;
		try
		{
			Action action;
			int num = LuaObject.checkDelegate<Action>(l, 2, out action);
			if (num == 0)
			{
				PDSDK.m_eventDoQuestionSucceed = action;
			}
			else if (num == 1)
			{
				PDSDK.m_eventDoQuestionSucceed = (Action)Delegate.Combine(PDSDK.m_eventDoQuestionSucceed, action);
			}
			else if (num == 2)
			{
				PDSDK.m_eventDoQuestionSucceed = (Action)Delegate.Remove(PDSDK.m_eventDoQuestionSucceed, action);
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

	// Token: 0x060228C8 RID: 141512 RVA: 0x00BD981C File Offset: 0x00BD7A1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_eventDoQuestionFailed(IntPtr l)
	{
		int result;
		try
		{
			Action action;
			int num = LuaObject.checkDelegate<Action>(l, 2, out action);
			if (num == 0)
			{
				PDSDK.m_eventDoQuestionFailed = action;
			}
			else if (num == 1)
			{
				PDSDK.m_eventDoQuestionFailed = (Action)Delegate.Combine(PDSDK.m_eventDoQuestionFailed, action);
			}
			else if (num == 2)
			{
				PDSDK.m_eventDoQuestionFailed = (Action)Delegate.Remove(PDSDK.m_eventDoQuestionFailed, action);
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

	// Token: 0x060228C9 RID: 141513 RVA: 0x00BD98B0 File Offset: 0x00BD7AB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_eventOnGetProductsListAck(IntPtr l)
	{
		int result;
		try
		{
			Action<bool> action;
			int num = LuaObject.checkDelegate<Action<bool>>(l, 2, out action);
			if (num == 0)
			{
				PDSDK.m_eventOnGetProductsListAck = action;
			}
			else if (num == 1)
			{
				PDSDK.m_eventOnGetProductsListAck = (Action<bool>)Delegate.Combine(PDSDK.m_eventOnGetProductsListAck, action);
			}
			else if (num == 2)
			{
				PDSDK.m_eventOnGetProductsListAck = (Action<bool>)Delegate.Remove(PDSDK.m_eventOnGetProductsListAck, action);
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

	// Token: 0x060228CA RID: 141514 RVA: 0x00BD9944 File Offset: 0x00BD7B44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_eventOnPaySuccess(IntPtr l)
	{
		int result;
		try
		{
			Action action;
			int num = LuaObject.checkDelegate<Action>(l, 2, out action);
			if (num == 0)
			{
				PDSDK.m_eventOnPaySuccess = action;
			}
			else if (num == 1)
			{
				PDSDK.m_eventOnPaySuccess = (Action)Delegate.Combine(PDSDK.m_eventOnPaySuccess, action);
			}
			else if (num == 2)
			{
				PDSDK.m_eventOnPaySuccess = (Action)Delegate.Remove(PDSDK.m_eventOnPaySuccess, action);
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

	// Token: 0x060228CB RID: 141515 RVA: 0x00BD99D8 File Offset: 0x00BD7BD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_eventOnPayFailed(IntPtr l)
	{
		int result;
		try
		{
			Action action;
			int num = LuaObject.checkDelegate<Action>(l, 2, out action);
			if (num == 0)
			{
				PDSDK.m_eventOnPayFailed = action;
			}
			else if (num == 1)
			{
				PDSDK.m_eventOnPayFailed = (Action)Delegate.Combine(PDSDK.m_eventOnPayFailed, action);
			}
			else if (num == 2)
			{
				PDSDK.m_eventOnPayFailed = (Action)Delegate.Remove(PDSDK.m_eventOnPayFailed, action);
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

	// Token: 0x060228CC RID: 141516 RVA: 0x00BD9A6C File Offset: 0x00BD7C6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_eventOnPayCancel(IntPtr l)
	{
		int result;
		try
		{
			Action action;
			int num = LuaObject.checkDelegate<Action>(l, 2, out action);
			if (num == 0)
			{
				PDSDK.m_eventOnPayCancel = action;
			}
			else if (num == 1)
			{
				PDSDK.m_eventOnPayCancel = (Action)Delegate.Combine(PDSDK.m_eventOnPayCancel, action);
			}
			else if (num == 2)
			{
				PDSDK.m_eventOnPayCancel = (Action)Delegate.Remove(PDSDK.m_eventOnPayCancel, action);
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

	// Token: 0x060228CD RID: 141517 RVA: 0x00BD9B00 File Offset: 0x00BD7D00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_eventOnSDKPromotingPaySuccess(IntPtr l)
	{
		int result;
		try
		{
			PDSDK pdsdk = (PDSDK)LuaObject.checkSelf(l);
			Action<string> action;
			int num = LuaObject.checkDelegate<Action<string>>(l, 2, out action);
			if (num == 0)
			{
				pdsdk.m_eventOnSDKPromotingPaySuccess = action;
			}
			else if (num == 1)
			{
				PDSDK pdsdk2 = pdsdk;
				pdsdk2.m_eventOnSDKPromotingPaySuccess = (Action<string>)Delegate.Combine(pdsdk2.m_eventOnSDKPromotingPaySuccess, action);
			}
			else if (num == 2)
			{
				PDSDK pdsdk3 = pdsdk;
				pdsdk3.m_eventOnSDKPromotingPaySuccess = (Action<string>)Delegate.Remove(pdsdk3.m_eventOnSDKPromotingPaySuccess, action);
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

	// Token: 0x060228CE RID: 141518 RVA: 0x00BD9BA8 File Offset: 0x00BD7DA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_eventQRLoginSuccess(IntPtr l)
	{
		int result;
		try
		{
			Action<string> action;
			int num = LuaObject.checkDelegate<Action<string>>(l, 2, out action);
			if (num == 0)
			{
				PDSDK.m_eventQRLoginSuccess = action;
			}
			else if (num == 1)
			{
				PDSDK.m_eventQRLoginSuccess = (Action<string>)Delegate.Combine(PDSDK.m_eventQRLoginSuccess, action);
			}
			else if (num == 2)
			{
				PDSDK.m_eventQRLoginSuccess = (Action<string>)Delegate.Remove(PDSDK.m_eventQRLoginSuccess, action);
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

	// Token: 0x060228CF RID: 141519 RVA: 0x00BD9C3C File Offset: 0x00BD7E3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_eventQRLoginFailed(IntPtr l)
	{
		int result;
		try
		{
			Action<string> action;
			int num = LuaObject.checkDelegate<Action<string>>(l, 2, out action);
			if (num == 0)
			{
				PDSDK.m_eventQRLoginFailed = action;
			}
			else if (num == 1)
			{
				PDSDK.m_eventQRLoginFailed = (Action<string>)Delegate.Combine(PDSDK.m_eventQRLoginFailed, action);
			}
			else if (num == 2)
			{
				PDSDK.m_eventQRLoginFailed = (Action<string>)Delegate.Remove(PDSDK.m_eventQRLoginFailed, action);
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

	// Token: 0x060228D0 RID: 141520 RVA: 0x00BD9CD0 File Offset: 0x00BD7ED0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_eventQRLoginCancel(IntPtr l)
	{
		int result;
		try
		{
			Action<string> action;
			int num = LuaObject.checkDelegate<Action<string>>(l, 2, out action);
			if (num == 0)
			{
				PDSDK.m_eventQRLoginCancel = action;
			}
			else if (num == 1)
			{
				PDSDK.m_eventQRLoginCancel = (Action<string>)Delegate.Combine(PDSDK.m_eventQRLoginCancel, action);
			}
			else if (num == 2)
			{
				PDSDK.m_eventQRLoginCancel = (Action<string>)Delegate.Remove(PDSDK.m_eventQRLoginCancel, action);
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

	// Token: 0x060228D1 RID: 141521 RVA: 0x00BD9D64 File Offset: 0x00BD7F64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_eventOnWebViewOpen(IntPtr l)
	{
		int result;
		try
		{
			Action action;
			int num = LuaObject.checkDelegate<Action>(l, 2, out action);
			if (num == 0)
			{
				PDSDK.m_eventOnWebViewOpen = action;
			}
			else if (num == 1)
			{
				PDSDK.m_eventOnWebViewOpen = (Action)Delegate.Combine(PDSDK.m_eventOnWebViewOpen, action);
			}
			else if (num == 2)
			{
				PDSDK.m_eventOnWebViewOpen = (Action)Delegate.Remove(PDSDK.m_eventOnWebViewOpen, action);
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

	// Token: 0x060228D2 RID: 141522 RVA: 0x00BD9DF8 File Offset: 0x00BD7FF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_eventOnWebViewClose(IntPtr l)
	{
		int result;
		try
		{
			Action action;
			int num = LuaObject.checkDelegate<Action>(l, 2, out action);
			if (num == 0)
			{
				PDSDK.m_eventOnWebViewClose = action;
			}
			else if (num == 1)
			{
				PDSDK.m_eventOnWebViewClose = (Action)Delegate.Combine(PDSDK.m_eventOnWebViewClose, action);
			}
			else if (num == 2)
			{
				PDSDK.m_eventOnWebViewClose = (Action)Delegate.Remove(PDSDK.m_eventOnWebViewClose, action);
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

	// Token: 0x060228D3 RID: 141523 RVA: 0x00BD9E8C File Offset: 0x00BD808C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_eventOnLowMemoryWarning(IntPtr l)
	{
		int result;
		try
		{
			Action action;
			int num = LuaObject.checkDelegate<Action>(l, 2, out action);
			if (num == 0)
			{
				PDSDK.m_eventOnLowMemoryWarning = action;
			}
			else if (num == 1)
			{
				PDSDK.m_eventOnLowMemoryWarning = (Action)Delegate.Combine(PDSDK.m_eventOnLowMemoryWarning, action);
			}
			else if (num == 2)
			{
				PDSDK.m_eventOnLowMemoryWarning = (Action)Delegate.Remove(PDSDK.m_eventOnLowMemoryWarning, action);
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

	// Token: 0x060228D4 RID: 141524 RVA: 0x00BD9F20 File Offset: 0x00BD8120
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_IsLogin(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, PDSDK.IsLogin);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060228D5 RID: 141525 RVA: 0x00BD9F68 File Offset: 0x00BD8168
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_IsInit(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, PDSDK.IsInit);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060228D6 RID: 141526 RVA: 0x00BD9FB0 File Offset: 0x00BD81B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_IsLogouting(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, PDSDK.IsLogouting);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060228D7 RID: 141527 RVA: 0x00BD9FF8 File Offset: 0x00BD81F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_IsIosReview(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, PDSDK.IsIosReview);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060228D8 RID: 141528 RVA: 0x00BDA040 File Offset: 0x00BD8240
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Instance(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, PDSDK.Instance);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060228D9 RID: 141529 RVA: 0x00BDA088 File Offset: 0x00BD8288
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_IsIosLoginWindowsPlayer(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, PDSDK.IsIosLoginWindowsPlayer);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060228DA RID: 141530 RVA: 0x00BDA0D0 File Offset: 0x00BD82D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PDAndroidChannelID(IntPtr l)
	{
		int result;
		try
		{
			PDSDK pdsdk = (PDSDK)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pdsdk.PDAndroidChannelID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060228DB RID: 141531 RVA: 0x00BDA124 File Offset: 0x00BD8324
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PDYingYongBaoChannelID(IntPtr l)
	{
		int result;
		try
		{
			PDSDK pdsdk = (PDSDK)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pdsdk.PDYingYongBaoChannelID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060228DC RID: 141532 RVA: 0x00BDA178 File Offset: 0x00BD8378
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PDOppoChannelID(IntPtr l)
	{
		int result;
		try
		{
			PDSDK pdsdk = (PDSDK)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pdsdk.PDOppoChannelID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060228DD RID: 141533 RVA: 0x00BDA1CC File Offset: 0x00BD83CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_IOSChannelID(IntPtr l)
	{
		int result;
		try
		{
			PDSDK pdsdk = (PDSDK)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pdsdk.IOSChannelID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060228DE RID: 141534 RVA: 0x00BDA220 File Offset: 0x00BD8420
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_DownloadClientURL(IntPtr l)
	{
		int result;
		try
		{
			PDSDK pdsdk = (PDSDK)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pdsdk.DownloadClientURL);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060228DF RID: 141535 RVA: 0x00BDA274 File Offset: 0x00BD8474
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "PD.SDK.PDSDK");
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache0 == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache0 = new LuaCSFunction(Lua_PD_SDK_PDSDK.onWebViewOpen);
		}
		LuaObject.addMember(l, Lua_PD_SDK_PDSDK.<>f__mg$cache0);
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache1 == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache1 = new LuaCSFunction(Lua_PD_SDK_PDSDK.onWebViewClose);
		}
		LuaObject.addMember(l, Lua_PD_SDK_PDSDK.<>f__mg$cache1);
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache2 == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache2 = new LuaCSFunction(Lua_PD_SDK_PDSDK.Init);
		}
		LuaObject.addMember(l, Lua_PD_SDK_PDSDK.<>f__mg$cache2);
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache3 == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache3 = new LuaCSFunction(Lua_PD_SDK_PDSDK.Login);
		}
		LuaObject.addMember(l, Lua_PD_SDK_PDSDK.<>f__mg$cache3);
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache4 == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache4 = new LuaCSFunction(Lua_PD_SDK_PDSDK.Logout);
		}
		LuaObject.addMember(l, Lua_PD_SDK_PDSDK.<>f__mg$cache4);
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache5 == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache5 = new LuaCSFunction(Lua_PD_SDK_PDSDK.StartGame);
		}
		LuaObject.addMember(l, Lua_PD_SDK_PDSDK.<>f__mg$cache5);
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache6 == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache6 = new LuaCSFunction(Lua_PD_SDK_PDSDK.GetProductsList);
		}
		LuaObject.addMember(l, Lua_PD_SDK_PDSDK.<>f__mg$cache6);
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache7 == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache7 = new LuaCSFunction(Lua_PD_SDK_PDSDK.DoPromotingPay);
		}
		LuaObject.addMember(l, Lua_PD_SDK_PDSDK.<>f__mg$cache7);
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache8 == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache8 = new LuaCSFunction(Lua_PD_SDK_PDSDK.onSDKPromotingPaySuccess);
		}
		LuaObject.addMember(l, Lua_PD_SDK_PDSDK.<>f__mg$cache8);
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache9 == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache9 = new LuaCSFunction(Lua_PD_SDK_PDSDK.onSDKPromotingPayFailed);
		}
		LuaObject.addMember(l, Lua_PD_SDK_PDSDK.<>f__mg$cache9);
		if (Lua_PD_SDK_PDSDK.<>f__mg$cacheA == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cacheA = new LuaCSFunction(Lua_PD_SDK_PDSDK.onSDKPromotingPayCancel);
		}
		LuaObject.addMember(l, Lua_PD_SDK_PDSDK.<>f__mg$cacheA);
		if (Lua_PD_SDK_PDSDK.<>f__mg$cacheB == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cacheB = new LuaCSFunction(Lua_PD_SDK_PDSDK.DoPay);
		}
		LuaObject.addMember(l, Lua_PD_SDK_PDSDK.<>f__mg$cacheB);
		if (Lua_PD_SDK_PDSDK.<>f__mg$cacheC == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cacheC = new LuaCSFunction(Lua_PD_SDK_PDSDK.doAddLocalPush);
		}
		LuaObject.addMember(l, Lua_PD_SDK_PDSDK.<>f__mg$cacheC);
		if (Lua_PD_SDK_PDSDK.<>f__mg$cacheD == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cacheD = new LuaCSFunction(Lua_PD_SDK_PDSDK.doFirstScreen);
		}
		LuaObject.addMember(l, Lua_PD_SDK_PDSDK.<>f__mg$cacheD);
		if (Lua_PD_SDK_PDSDK.<>f__mg$cacheE == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cacheE = new LuaCSFunction(Lua_PD_SDK_PDSDK.SwitchUser);
		}
		LuaObject.addMember(l, Lua_PD_SDK_PDSDK.<>f__mg$cacheE);
		if (Lua_PD_SDK_PDSDK.<>f__mg$cacheF == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cacheF = new LuaCSFunction(Lua_PD_SDK_PDSDK.userCenter);
		}
		LuaObject.addMember(l, Lua_PD_SDK_PDSDK.<>f__mg$cacheF);
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache10 == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache10 = new LuaCSFunction(Lua_PD_SDK_PDSDK.exit);
		}
		LuaObject.addMember(l, Lua_PD_SDK_PDSDK.<>f__mg$cache10);
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache11 == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache11 = new LuaCSFunction(Lua_PD_SDK_PDSDK.GetPustToken);
		}
		LuaObject.addMember(l, Lua_PD_SDK_PDSDK.<>f__mg$cache11);
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache12 == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache12 = new LuaCSFunction(Lua_PD_SDK_PDSDK.GetDeviceID);
		}
		LuaObject.addMember(l, Lua_PD_SDK_PDSDK.<>f__mg$cache12);
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache13 == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache13 = new LuaCSFunction(Lua_PD_SDK_PDSDK.GetBattery);
		}
		LuaObject.addMember(l, Lua_PD_SDK_PDSDK.<>f__mg$cache13);
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache14 == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache14 = new LuaCSFunction(Lua_PD_SDK_PDSDK.OpenInvestigation);
		}
		LuaObject.addMember(l, Lua_PD_SDK_PDSDK.<>f__mg$cache14);
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache15 == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache15 = new LuaCSFunction(Lua_PD_SDK_PDSDK.PathOrder);
		}
		LuaObject.addMember(l, Lua_PD_SDK_PDSDK.<>f__mg$cache15);
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache16 == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache16 = new LuaCSFunction(Lua_PD_SDK_PDSDK.ShowPayHelp);
		}
		LuaObject.addMember(l, Lua_PD_SDK_PDSDK.<>f__mg$cache16);
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache17 == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache17 = new LuaCSFunction(Lua_PD_SDK_PDSDK.printGameEventLog);
		}
		LuaObject.addMember(l, Lua_PD_SDK_PDSDK.<>f__mg$cache17);
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache18 == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache18 = new LuaCSFunction(Lua_PD_SDK_PDSDK.doSetExtData);
		}
		LuaObject.addMember(l, Lua_PD_SDK_PDSDK.<>f__mg$cache18);
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache19 == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache19 = new LuaCSFunction(Lua_PD_SDK_PDSDK.doStartQRLogin);
		}
		LuaObject.addMember(l, Lua_PD_SDK_PDSDK.<>f__mg$cache19);
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache1A == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache1A = new LuaCSFunction(Lua_PD_SDK_PDSDK.getChannelID);
		}
		LuaObject.addMember(l, Lua_PD_SDK_PDSDK.<>f__mg$cache1A);
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache1B == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache1B = new LuaCSFunction(Lua_PD_SDK_PDSDK.doSaveImageToPhotoLibrary);
		}
		LuaObject.addMember(l, Lua_PD_SDK_PDSDK.<>f__mg$cache1B);
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache1C == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache1C = new LuaCSFunction(Lua_PD_SDK_PDSDK.doQQVIP);
		}
		LuaObject.addMember(l, Lua_PD_SDK_PDSDK.<>f__mg$cache1C);
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache1D == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache1D = new LuaCSFunction(Lua_PD_SDK_PDSDK.callWebView);
		}
		LuaObject.addMember(l, Lua_PD_SDK_PDSDK.<>f__mg$cache1D);
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache1E == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache1E = new LuaCSFunction(Lua_PD_SDK_PDSDK.clearLocalNotifications);
		}
		LuaObject.addMember(l, Lua_PD_SDK_PDSDK.<>f__mg$cache1E);
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache1F == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache1F = new LuaCSFunction(Lua_PD_SDK_PDSDK.callCustomerServiceWeb);
		}
		LuaObject.addMember(l, Lua_PD_SDK_PDSDK.<>f__mg$cache1F);
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache20 == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache20 = new LuaCSFunction(Lua_PD_SDK_PDSDK.doshare);
		}
		LuaObject.addMember(l, Lua_PD_SDK_PDSDK.<>f__mg$cache20);
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache21 == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache21 = new LuaCSFunction(Lua_PD_SDK_PDSDK.doStartRecord);
		}
		LuaObject.addMember(l, Lua_PD_SDK_PDSDK.<>f__mg$cache21);
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache22 == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache22 = new LuaCSFunction(Lua_PD_SDK_PDSDK.doStopRecord);
		}
		LuaObject.addMember(l, Lua_PD_SDK_PDSDK.<>f__mg$cache22);
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache23 == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache23 = new LuaCSFunction(Lua_PD_SDK_PDSDK.doBoradcast);
		}
		LuaObject.addMember(l, Lua_PD_SDK_PDSDK.<>f__mg$cache23);
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache24 == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache24 = new LuaCSFunction(Lua_PD_SDK_PDSDK.doOpenRequestReview);
		}
		LuaObject.addMember(l, Lua_PD_SDK_PDSDK.<>f__mg$cache24);
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache25 == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache25 = new LuaCSFunction(Lua_PD_SDK_PDSDK.onLoginSuccess);
		}
		LuaObject.addMember(l, Lua_PD_SDK_PDSDK.<>f__mg$cache25);
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache26 == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache26 = new LuaCSFunction(Lua_PD_SDK_PDSDK.onLoginFailed);
		}
		LuaObject.addMember(l, Lua_PD_SDK_PDSDK.<>f__mg$cache26);
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache27 == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache27 = new LuaCSFunction(Lua_PD_SDK_PDSDK.onLoginCancel);
		}
		LuaObject.addMember(l, Lua_PD_SDK_PDSDK.<>f__mg$cache27);
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache28 == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache28 = new LuaCSFunction(Lua_PD_SDK_PDSDK.onLogoutSuccess);
		}
		LuaObject.addMember(l, Lua_PD_SDK_PDSDK.<>f__mg$cache28);
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache29 == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache29 = new LuaCSFunction(Lua_PD_SDK_PDSDK.onLogoutFailed);
		}
		LuaObject.addMember(l, Lua_PD_SDK_PDSDK.<>f__mg$cache29);
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache2A == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache2A = new LuaCSFunction(Lua_PD_SDK_PDSDK.onLogoutCancel);
		}
		LuaObject.addMember(l, Lua_PD_SDK_PDSDK.<>f__mg$cache2A);
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache2B == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache2B = new LuaCSFunction(Lua_PD_SDK_PDSDK.onGetProductsListSuccess);
		}
		LuaObject.addMember(l, Lua_PD_SDK_PDSDK.<>f__mg$cache2B);
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache2C == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache2C = new LuaCSFunction(Lua_PD_SDK_PDSDK.onGetProductsListFailed);
		}
		LuaObject.addMember(l, Lua_PD_SDK_PDSDK.<>f__mg$cache2C);
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache2D == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache2D = new LuaCSFunction(Lua_PD_SDK_PDSDK.onPaySuccess);
		}
		LuaObject.addMember(l, Lua_PD_SDK_PDSDK.<>f__mg$cache2D);
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache2E == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache2E = new LuaCSFunction(Lua_PD_SDK_PDSDK.onPayFailed);
		}
		LuaObject.addMember(l, Lua_PD_SDK_PDSDK.<>f__mg$cache2E);
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache2F == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache2F = new LuaCSFunction(Lua_PD_SDK_PDSDK.onPayCancel);
		}
		LuaObject.addMember(l, Lua_PD_SDK_PDSDK.<>f__mg$cache2F);
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache30 == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache30 = new LuaCSFunction(Lua_PD_SDK_PDSDK.onGetPayHistorySuccess);
		}
		LuaObject.addMember(l, Lua_PD_SDK_PDSDK.<>f__mg$cache30);
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache31 == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache31 = new LuaCSFunction(Lua_PD_SDK_PDSDK.onGetPayHistoryFailed);
		}
		LuaObject.addMember(l, Lua_PD_SDK_PDSDK.<>f__mg$cache31);
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache32 == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache32 = new LuaCSFunction(Lua_PD_SDK_PDSDK.onInitSuccess);
		}
		LuaObject.addMember(l, Lua_PD_SDK_PDSDK.<>f__mg$cache32);
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache33 == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache33 = new LuaCSFunction(Lua_PD_SDK_PDSDK.onInitFailed);
		}
		LuaObject.addMember(l, Lua_PD_SDK_PDSDK.<>f__mg$cache33);
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache34 == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache34 = new LuaCSFunction(Lua_PD_SDK_PDSDK.onswitchUserSuccess);
		}
		LuaObject.addMember(l, Lua_PD_SDK_PDSDK.<>f__mg$cache34);
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache35 == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache35 = new LuaCSFunction(Lua_PD_SDK_PDSDK.onswitchUserFailed);
		}
		LuaObject.addMember(l, Lua_PD_SDK_PDSDK.<>f__mg$cache35);
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache36 == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache36 = new LuaCSFunction(Lua_PD_SDK_PDSDK.onswitchUserCancel);
		}
		LuaObject.addMember(l, Lua_PD_SDK_PDSDK.<>f__mg$cache36);
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache37 == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache37 = new LuaCSFunction(Lua_PD_SDK_PDSDK.onVerifyTokenSuccess);
		}
		LuaObject.addMember(l, Lua_PD_SDK_PDSDK.<>f__mg$cache37);
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache38 == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache38 = new LuaCSFunction(Lua_PD_SDK_PDSDK.onVerifyTokenFailed);
		}
		LuaObject.addMember(l, Lua_PD_SDK_PDSDK.<>f__mg$cache38);
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache39 == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache39 = new LuaCSFunction(Lua_PD_SDK_PDSDK.onDoSetExtDataSuccess);
		}
		LuaObject.addMember(l, Lua_PD_SDK_PDSDK.<>f__mg$cache39);
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache3A == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache3A = new LuaCSFunction(Lua_PD_SDK_PDSDK.onDoSetExtDataFailed);
		}
		LuaObject.addMember(l, Lua_PD_SDK_PDSDK.<>f__mg$cache3A);
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache3B == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache3B = new LuaCSFunction(Lua_PD_SDK_PDSDK.onExitSuccess);
		}
		LuaObject.addMember(l, Lua_PD_SDK_PDSDK.<>f__mg$cache3B);
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache3C == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache3C = new LuaCSFunction(Lua_PD_SDK_PDSDK.onExitFailed);
		}
		LuaObject.addMember(l, Lua_PD_SDK_PDSDK.<>f__mg$cache3C);
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache3D == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache3D = new LuaCSFunction(Lua_PD_SDK_PDSDK.onMemoryWarning);
		}
		LuaObject.addMember(l, Lua_PD_SDK_PDSDK.<>f__mg$cache3D);
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache3E == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache3E = new LuaCSFunction(Lua_PD_SDK_PDSDK.onShareSuccess);
		}
		LuaObject.addMember(l, Lua_PD_SDK_PDSDK.<>f__mg$cache3E);
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache3F == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache3F = new LuaCSFunction(Lua_PD_SDK_PDSDK.onShareFailed);
		}
		LuaObject.addMember(l, Lua_PD_SDK_PDSDK.<>f__mg$cache3F);
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache40 == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache40 = new LuaCSFunction(Lua_PD_SDK_PDSDK.onShareCancel);
		}
		LuaObject.addMember(l, Lua_PD_SDK_PDSDK.<>f__mg$cache40);
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache41 == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache41 = new LuaCSFunction(Lua_PD_SDK_PDSDK.onRecordStartSuccess);
		}
		LuaObject.addMember(l, Lua_PD_SDK_PDSDK.<>f__mg$cache41);
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache42 == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache42 = new LuaCSFunction(Lua_PD_SDK_PDSDK.onRecordStartFail);
		}
		LuaObject.addMember(l, Lua_PD_SDK_PDSDK.<>f__mg$cache42);
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache43 == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache43 = new LuaCSFunction(Lua_PD_SDK_PDSDK.onRecordStopSuccess);
		}
		LuaObject.addMember(l, Lua_PD_SDK_PDSDK.<>f__mg$cache43);
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache44 == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache44 = new LuaCSFunction(Lua_PD_SDK_PDSDK.onRecordStopFail);
		}
		LuaObject.addMember(l, Lua_PD_SDK_PDSDK.<>f__mg$cache44);
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache45 == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache45 = new LuaCSFunction(Lua_PD_SDK_PDSDK.onBoradcastSuccess);
		}
		LuaObject.addMember(l, Lua_PD_SDK_PDSDK.<>f__mg$cache45);
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache46 == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache46 = new LuaCSFunction(Lua_PD_SDK_PDSDK.onBoradcastFail);
		}
		LuaObject.addMember(l, Lua_PD_SDK_PDSDK.<>f__mg$cache46);
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache47 == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache47 = new LuaCSFunction(Lua_PD_SDK_PDSDK.onDoQuestionSuccess);
		}
		LuaObject.addMember(l, Lua_PD_SDK_PDSDK.<>f__mg$cache47);
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache48 == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache48 = new LuaCSFunction(Lua_PD_SDK_PDSDK.onDoQuestionFailed);
		}
		LuaObject.addMember(l, Lua_PD_SDK_PDSDK.<>f__mg$cache48);
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache49 == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache49 = new LuaCSFunction(Lua_PD_SDK_PDSDK.oncallWebViewSuccess);
		}
		LuaObject.addMember(l, Lua_PD_SDK_PDSDK.<>f__mg$cache49);
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache4A == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache4A = new LuaCSFunction(Lua_PD_SDK_PDSDK.oncallWebViewFailed);
		}
		LuaObject.addMember(l, Lua_PD_SDK_PDSDK.<>f__mg$cache4A);
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache4B == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache4B = new LuaCSFunction(Lua_PD_SDK_PDSDK.oncallWebViewCancel);
		}
		LuaObject.addMember(l, Lua_PD_SDK_PDSDK.<>f__mg$cache4B);
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache4C == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache4C = new LuaCSFunction(Lua_PD_SDK_PDSDK.onDoSaveImageToPhotoLibrarySuccess);
		}
		LuaObject.addMember(l, Lua_PD_SDK_PDSDK.<>f__mg$cache4C);
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache4D == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache4D = new LuaCSFunction(Lua_PD_SDK_PDSDK.onDoSaveImageToPhotoLibraryFailed);
		}
		LuaObject.addMember(l, Lua_PD_SDK_PDSDK.<>f__mg$cache4D);
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache4E == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache4E = new LuaCSFunction(Lua_PD_SDK_PDSDK.showAndroidToast);
		}
		LuaObject.addMember(l, Lua_PD_SDK_PDSDK.<>f__mg$cache4E);
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache4F == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache4F = new LuaCSFunction(Lua_PD_SDK_PDSDK.verifyToken);
		}
		LuaObject.addMember(l, Lua_PD_SDK_PDSDK.<>f__mg$cache4F);
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache50 == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache50 = new LuaCSFunction(Lua_PD_SDK_PDSDK.OnGUI);
		}
		LuaObject.addMember(l, Lua_PD_SDK_PDSDK.<>f__mg$cache50);
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache51 == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache51 = new LuaCSFunction(Lua_PD_SDK_PDSDK.DoCoroutine_s);
		}
		LuaObject.addMember(l, Lua_PD_SDK_PDSDK.<>f__mg$cache51);
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache52 == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache52 = new LuaCSFunction(Lua_PD_SDK_PDSDK.Perform);
		}
		LuaObject.addMember(l, Lua_PD_SDK_PDSDK.<>f__mg$cache52);
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache53 == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache53 = new LuaCSFunction(Lua_PD_SDK_PDSDK.Awake);
		}
		LuaObject.addMember(l, Lua_PD_SDK_PDSDK.<>f__mg$cache53);
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache54 == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache54 = new LuaCSFunction(Lua_PD_SDK_PDSDK.Update);
		}
		LuaObject.addMember(l, Lua_PD_SDK_PDSDK.<>f__mg$cache54);
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache55 == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache55 = new LuaCSFunction(Lua_PD_SDK_PDSDK.onQRLoginSuccess);
		}
		LuaObject.addMember(l, Lua_PD_SDK_PDSDK.<>f__mg$cache55);
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache56 == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache56 = new LuaCSFunction(Lua_PD_SDK_PDSDK.onQRLoginFailed);
		}
		LuaObject.addMember(l, Lua_PD_SDK_PDSDK.<>f__mg$cache56);
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache57 == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache57 = new LuaCSFunction(Lua_PD_SDK_PDSDK.onQRLoginCancel);
		}
		LuaObject.addMember(l, Lua_PD_SDK_PDSDK.<>f__mg$cache57);
		string name = "isDebug";
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache58 == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache58 = new LuaCSFunction(Lua_PD_SDK_PDSDK.get_isDebug);
		}
		LuaCSFunction get = Lua_PD_SDK_PDSDK.<>f__mg$cache58;
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache59 == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache59 = new LuaCSFunction(Lua_PD_SDK_PDSDK.set_isDebug);
		}
		LuaObject.addMember(l, name, get, Lua_PD_SDK_PDSDK.<>f__mg$cache59, true);
		string name2 = "isVerfy";
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache5A == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache5A = new LuaCSFunction(Lua_PD_SDK_PDSDK.get_isVerfy);
		}
		LuaCSFunction get2 = Lua_PD_SDK_PDSDK.<>f__mg$cache5A;
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache5B == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache5B = new LuaCSFunction(Lua_PD_SDK_PDSDK.set_isVerfy);
		}
		LuaObject.addMember(l, name2, get2, Lua_PD_SDK_PDSDK.<>f__mg$cache5B, true);
		string name3 = "goodlistjson";
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache5C == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache5C = new LuaCSFunction(Lua_PD_SDK_PDSDK.get_goodlistjson);
		}
		LuaCSFunction get3 = Lua_PD_SDK_PDSDK.<>f__mg$cache5C;
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache5D == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache5D = new LuaCSFunction(Lua_PD_SDK_PDSDK.set_goodlistjson);
		}
		LuaObject.addMember(l, name3, get3, Lua_PD_SDK_PDSDK.<>f__mg$cache5D, false);
		string name4 = "promotingPayGoodsRegisterID";
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache5E == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache5E = new LuaCSFunction(Lua_PD_SDK_PDSDK.get_promotingPayGoodsRegisterID);
		}
		LuaCSFunction get4 = Lua_PD_SDK_PDSDK.<>f__mg$cache5E;
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache5F == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache5F = new LuaCSFunction(Lua_PD_SDK_PDSDK.set_promotingPayGoodsRegisterID);
		}
		LuaObject.addMember(l, name4, get4, Lua_PD_SDK_PDSDK.<>f__mg$cache5F, true);
		string name5 = "stringToEdit";
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache60 == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache60 = new LuaCSFunction(Lua_PD_SDK_PDSDK.get_stringToEdit);
		}
		LuaCSFunction get5 = Lua_PD_SDK_PDSDK.<>f__mg$cache60;
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache61 == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache61 = new LuaCSFunction(Lua_PD_SDK_PDSDK.set_stringToEdit);
		}
		LuaObject.addMember(l, name5, get5, Lua_PD_SDK_PDSDK.<>f__mg$cache61, true);
		string name6 = "isExitSuccess";
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache62 == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache62 = new LuaCSFunction(Lua_PD_SDK_PDSDK.get_isExitSuccess);
		}
		LuaCSFunction get6 = Lua_PD_SDK_PDSDK.<>f__mg$cache62;
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache63 == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache63 = new LuaCSFunction(Lua_PD_SDK_PDSDK.set_isExitSuccess);
		}
		LuaObject.addMember(l, name6, get6, Lua_PD_SDK_PDSDK.<>f__mg$cache63, true);
		string name7 = "m_isCallWebView";
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache64 == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache64 = new LuaCSFunction(Lua_PD_SDK_PDSDK.get_m_isCallWebView);
		}
		LuaCSFunction get7 = Lua_PD_SDK_PDSDK.<>f__mg$cache64;
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache65 == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache65 = new LuaCSFunction(Lua_PD_SDK_PDSDK.set_m_isCallWebView);
		}
		LuaObject.addMember(l, name7, get7, Lua_PD_SDK_PDSDK.<>f__mg$cache65, true);
		string name8 = "isLogin";
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache66 == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache66 = new LuaCSFunction(Lua_PD_SDK_PDSDK.get_isLogin);
		}
		LuaCSFunction get8 = Lua_PD_SDK_PDSDK.<>f__mg$cache66;
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache67 == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache67 = new LuaCSFunction(Lua_PD_SDK_PDSDK.set_isLogin);
		}
		LuaObject.addMember(l, name8, get8, Lua_PD_SDK_PDSDK.<>f__mg$cache67, false);
		string name9 = "_isLogining";
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache68 == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache68 = new LuaCSFunction(Lua_PD_SDK_PDSDK.get__isLogining);
		}
		LuaCSFunction get9 = Lua_PD_SDK_PDSDK.<>f__mg$cache68;
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache69 == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache69 = new LuaCSFunction(Lua_PD_SDK_PDSDK.set__isLogining);
		}
		LuaObject.addMember(l, name9, get9, Lua_PD_SDK_PDSDK.<>f__mg$cache69, false);
		string name10 = "_isLogouting";
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache6A == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache6A = new LuaCSFunction(Lua_PD_SDK_PDSDK.get__isLogouting);
		}
		LuaCSFunction get10 = Lua_PD_SDK_PDSDK.<>f__mg$cache6A;
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache6B == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache6B = new LuaCSFunction(Lua_PD_SDK_PDSDK.set__isLogouting);
		}
		LuaObject.addMember(l, name10, get10, Lua_PD_SDK_PDSDK.<>f__mg$cache6B, false);
		string name11 = "isInit";
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache6C == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache6C = new LuaCSFunction(Lua_PD_SDK_PDSDK.get_isInit);
		}
		LuaCSFunction get11 = Lua_PD_SDK_PDSDK.<>f__mg$cache6C;
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache6D == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache6D = new LuaCSFunction(Lua_PD_SDK_PDSDK.set_isInit);
		}
		LuaObject.addMember(l, name11, get11, Lua_PD_SDK_PDSDK.<>f__mg$cache6D, false);
		string name12 = "_isIosReview";
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache6E == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache6E = new LuaCSFunction(Lua_PD_SDK_PDSDK.get__isIosReview);
		}
		LuaCSFunction get12 = Lua_PD_SDK_PDSDK.<>f__mg$cache6E;
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache6F == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache6F = new LuaCSFunction(Lua_PD_SDK_PDSDK.set__isIosReview);
		}
		LuaObject.addMember(l, name12, get12, Lua_PD_SDK_PDSDK.<>f__mg$cache6F, false);
		string name13 = "_instance";
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache70 == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache70 = new LuaCSFunction(Lua_PD_SDK_PDSDK.get__instance);
		}
		LuaCSFunction get13 = Lua_PD_SDK_PDSDK.<>f__mg$cache70;
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache71 == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache71 = new LuaCSFunction(Lua_PD_SDK_PDSDK.set__instance);
		}
		LuaObject.addMember(l, name13, get13, Lua_PD_SDK_PDSDK.<>f__mg$cache71, false);
		string name14 = "m_eventLoginSuccess";
		LuaCSFunction get14 = null;
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache72 == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache72 = new LuaCSFunction(Lua_PD_SDK_PDSDK.set_m_eventLoginSuccess);
		}
		LuaObject.addMember(l, name14, get14, Lua_PD_SDK_PDSDK.<>f__mg$cache72, false);
		string name15 = "m_eventOnSwitchUserSuccess";
		LuaCSFunction get15 = null;
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache73 == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache73 = new LuaCSFunction(Lua_PD_SDK_PDSDK.set_m_eventOnSwitchUserSuccess);
		}
		LuaObject.addMember(l, name15, get15, Lua_PD_SDK_PDSDK.<>f__mg$cache73, false);
		string name16 = "m_eventLoginFailed";
		LuaCSFunction get16 = null;
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache74 == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache74 = new LuaCSFunction(Lua_PD_SDK_PDSDK.set_m_eventLoginFailed);
		}
		LuaObject.addMember(l, name16, get16, Lua_PD_SDK_PDSDK.<>f__mg$cache74, false);
		string name17 = "m_eventLogoutSuccess";
		LuaCSFunction get17 = null;
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache75 == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache75 = new LuaCSFunction(Lua_PD_SDK_PDSDK.set_m_eventLogoutSuccess);
		}
		LuaObject.addMember(l, name17, get17, Lua_PD_SDK_PDSDK.<>f__mg$cache75, false);
		string name18 = "m_eventInitSuccess";
		LuaCSFunction get18 = null;
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache76 == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache76 = new LuaCSFunction(Lua_PD_SDK_PDSDK.set_m_eventInitSuccess);
		}
		LuaObject.addMember(l, name18, get18, Lua_PD_SDK_PDSDK.<>f__mg$cache76, false);
		string name19 = "m_eventInitFailed";
		LuaCSFunction get19 = null;
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache77 == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache77 = new LuaCSFunction(Lua_PD_SDK_PDSDK.set_m_eventInitFailed);
		}
		LuaObject.addMember(l, name19, get19, Lua_PD_SDK_PDSDK.<>f__mg$cache77, false);
		string name20 = "m_eventDoQuestionSucceed";
		LuaCSFunction get20 = null;
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache78 == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache78 = new LuaCSFunction(Lua_PD_SDK_PDSDK.set_m_eventDoQuestionSucceed);
		}
		LuaObject.addMember(l, name20, get20, Lua_PD_SDK_PDSDK.<>f__mg$cache78, false);
		string name21 = "m_eventDoQuestionFailed";
		LuaCSFunction get21 = null;
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache79 == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache79 = new LuaCSFunction(Lua_PD_SDK_PDSDK.set_m_eventDoQuestionFailed);
		}
		LuaObject.addMember(l, name21, get21, Lua_PD_SDK_PDSDK.<>f__mg$cache79, false);
		string name22 = "m_eventOnGetProductsListAck";
		LuaCSFunction get22 = null;
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache7A == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache7A = new LuaCSFunction(Lua_PD_SDK_PDSDK.set_m_eventOnGetProductsListAck);
		}
		LuaObject.addMember(l, name22, get22, Lua_PD_SDK_PDSDK.<>f__mg$cache7A, false);
		string name23 = "m_eventOnPaySuccess";
		LuaCSFunction get23 = null;
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache7B == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache7B = new LuaCSFunction(Lua_PD_SDK_PDSDK.set_m_eventOnPaySuccess);
		}
		LuaObject.addMember(l, name23, get23, Lua_PD_SDK_PDSDK.<>f__mg$cache7B, false);
		string name24 = "m_eventOnPayFailed";
		LuaCSFunction get24 = null;
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache7C == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache7C = new LuaCSFunction(Lua_PD_SDK_PDSDK.set_m_eventOnPayFailed);
		}
		LuaObject.addMember(l, name24, get24, Lua_PD_SDK_PDSDK.<>f__mg$cache7C, false);
		string name25 = "m_eventOnPayCancel";
		LuaCSFunction get25 = null;
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache7D == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache7D = new LuaCSFunction(Lua_PD_SDK_PDSDK.set_m_eventOnPayCancel);
		}
		LuaObject.addMember(l, name25, get25, Lua_PD_SDK_PDSDK.<>f__mg$cache7D, false);
		string name26 = "m_eventOnSDKPromotingPaySuccess";
		LuaCSFunction get26 = null;
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache7E == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache7E = new LuaCSFunction(Lua_PD_SDK_PDSDK.set_m_eventOnSDKPromotingPaySuccess);
		}
		LuaObject.addMember(l, name26, get26, Lua_PD_SDK_PDSDK.<>f__mg$cache7E, true);
		string name27 = "m_eventQRLoginSuccess";
		LuaCSFunction get27 = null;
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache7F == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache7F = new LuaCSFunction(Lua_PD_SDK_PDSDK.set_m_eventQRLoginSuccess);
		}
		LuaObject.addMember(l, name27, get27, Lua_PD_SDK_PDSDK.<>f__mg$cache7F, false);
		string name28 = "m_eventQRLoginFailed";
		LuaCSFunction get28 = null;
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache80 == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache80 = new LuaCSFunction(Lua_PD_SDK_PDSDK.set_m_eventQRLoginFailed);
		}
		LuaObject.addMember(l, name28, get28, Lua_PD_SDK_PDSDK.<>f__mg$cache80, false);
		string name29 = "m_eventQRLoginCancel";
		LuaCSFunction get29 = null;
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache81 == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache81 = new LuaCSFunction(Lua_PD_SDK_PDSDK.set_m_eventQRLoginCancel);
		}
		LuaObject.addMember(l, name29, get29, Lua_PD_SDK_PDSDK.<>f__mg$cache81, false);
		string name30 = "m_eventOnWebViewOpen";
		LuaCSFunction get30 = null;
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache82 == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache82 = new LuaCSFunction(Lua_PD_SDK_PDSDK.set_m_eventOnWebViewOpen);
		}
		LuaObject.addMember(l, name30, get30, Lua_PD_SDK_PDSDK.<>f__mg$cache82, false);
		string name31 = "m_eventOnWebViewClose";
		LuaCSFunction get31 = null;
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache83 == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache83 = new LuaCSFunction(Lua_PD_SDK_PDSDK.set_m_eventOnWebViewClose);
		}
		LuaObject.addMember(l, name31, get31, Lua_PD_SDK_PDSDK.<>f__mg$cache83, false);
		string name32 = "m_eventOnLowMemoryWarning";
		LuaCSFunction get32 = null;
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache84 == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache84 = new LuaCSFunction(Lua_PD_SDK_PDSDK.set_m_eventOnLowMemoryWarning);
		}
		LuaObject.addMember(l, name32, get32, Lua_PD_SDK_PDSDK.<>f__mg$cache84, false);
		string name33 = "IsLogin";
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache85 == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache85 = new LuaCSFunction(Lua_PD_SDK_PDSDK.get_IsLogin);
		}
		LuaObject.addMember(l, name33, Lua_PD_SDK_PDSDK.<>f__mg$cache85, null, false);
		string name34 = "IsInit";
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache86 == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache86 = new LuaCSFunction(Lua_PD_SDK_PDSDK.get_IsInit);
		}
		LuaObject.addMember(l, name34, Lua_PD_SDK_PDSDK.<>f__mg$cache86, null, false);
		string name35 = "IsLogouting";
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache87 == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache87 = new LuaCSFunction(Lua_PD_SDK_PDSDK.get_IsLogouting);
		}
		LuaObject.addMember(l, name35, Lua_PD_SDK_PDSDK.<>f__mg$cache87, null, false);
		string name36 = "IsIosReview";
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache88 == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache88 = new LuaCSFunction(Lua_PD_SDK_PDSDK.get_IsIosReview);
		}
		LuaObject.addMember(l, name36, Lua_PD_SDK_PDSDK.<>f__mg$cache88, null, false);
		string name37 = "Instance";
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache89 == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache89 = new LuaCSFunction(Lua_PD_SDK_PDSDK.get_Instance);
		}
		LuaObject.addMember(l, name37, Lua_PD_SDK_PDSDK.<>f__mg$cache89, null, false);
		string name38 = "IsIosLoginWindowsPlayer";
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache8A == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache8A = new LuaCSFunction(Lua_PD_SDK_PDSDK.get_IsIosLoginWindowsPlayer);
		}
		LuaObject.addMember(l, name38, Lua_PD_SDK_PDSDK.<>f__mg$cache8A, null, false);
		string name39 = "PDAndroidChannelID";
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache8B == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache8B = new LuaCSFunction(Lua_PD_SDK_PDSDK.get_PDAndroidChannelID);
		}
		LuaObject.addMember(l, name39, Lua_PD_SDK_PDSDK.<>f__mg$cache8B, null, true);
		string name40 = "PDYingYongBaoChannelID";
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache8C == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache8C = new LuaCSFunction(Lua_PD_SDK_PDSDK.get_PDYingYongBaoChannelID);
		}
		LuaObject.addMember(l, name40, Lua_PD_SDK_PDSDK.<>f__mg$cache8C, null, true);
		string name41 = "PDOppoChannelID";
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache8D == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache8D = new LuaCSFunction(Lua_PD_SDK_PDSDK.get_PDOppoChannelID);
		}
		LuaObject.addMember(l, name41, Lua_PD_SDK_PDSDK.<>f__mg$cache8D, null, true);
		string name42 = "IOSChannelID";
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache8E == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache8E = new LuaCSFunction(Lua_PD_SDK_PDSDK.get_IOSChannelID);
		}
		LuaObject.addMember(l, name42, Lua_PD_SDK_PDSDK.<>f__mg$cache8E, null, true);
		string name43 = "DownloadClientURL";
		if (Lua_PD_SDK_PDSDK.<>f__mg$cache8F == null)
		{
			Lua_PD_SDK_PDSDK.<>f__mg$cache8F = new LuaCSFunction(Lua_PD_SDK_PDSDK.get_DownloadClientURL);
		}
		LuaObject.addMember(l, name43, Lua_PD_SDK_PDSDK.<>f__mg$cache8F, null, true);
		LuaObject.createTypeMetatable(l, null, typeof(PDSDK), typeof(MonoBehaviour));
	}

	// Token: 0x04018631 RID: 99889
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018632 RID: 99890
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04018633 RID: 99891
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04018634 RID: 99892
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04018635 RID: 99893
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04018636 RID: 99894
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04018637 RID: 99895
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04018638 RID: 99896
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04018639 RID: 99897
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0401863A RID: 99898
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0401863B RID: 99899
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0401863C RID: 99900
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0401863D RID: 99901
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0401863E RID: 99902
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0401863F RID: 99903
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04018640 RID: 99904
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04018641 RID: 99905
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04018642 RID: 99906
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04018643 RID: 99907
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04018644 RID: 99908
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04018645 RID: 99909
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04018646 RID: 99910
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04018647 RID: 99911
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04018648 RID: 99912
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04018649 RID: 99913
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0401864A RID: 99914
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0401864B RID: 99915
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0401864C RID: 99916
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0401864D RID: 99917
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0401864E RID: 99918
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0401864F RID: 99919
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04018650 RID: 99920
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04018651 RID: 99921
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04018652 RID: 99922
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04018653 RID: 99923
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04018654 RID: 99924
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04018655 RID: 99925
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04018656 RID: 99926
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04018657 RID: 99927
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04018658 RID: 99928
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04018659 RID: 99929
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0401865A RID: 99930
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0401865B RID: 99931
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0401865C RID: 99932
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0401865D RID: 99933
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0401865E RID: 99934
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0401865F RID: 99935
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04018660 RID: 99936
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04018661 RID: 99937
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04018662 RID: 99938
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04018663 RID: 99939
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04018664 RID: 99940
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04018665 RID: 99941
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04018666 RID: 99942
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04018667 RID: 99943
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04018668 RID: 99944
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04018669 RID: 99945
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x0401866A RID: 99946
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x0401866B RID: 99947
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x0401866C RID: 99948
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x0401866D RID: 99949
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x0401866E RID: 99950
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x0401866F RID: 99951
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x04018670 RID: 99952
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x04018671 RID: 99953
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x04018672 RID: 99954
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x04018673 RID: 99955
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x04018674 RID: 99956
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x04018675 RID: 99957
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x04018676 RID: 99958
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x04018677 RID: 99959
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x04018678 RID: 99960
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x04018679 RID: 99961
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x0401867A RID: 99962
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x0401867B RID: 99963
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x0401867C RID: 99964
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x0401867D RID: 99965
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x0401867E RID: 99966
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x0401867F RID: 99967
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x04018680 RID: 99968
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x04018681 RID: 99969
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x04018682 RID: 99970
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x04018683 RID: 99971
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x04018684 RID: 99972
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x04018685 RID: 99973
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x04018686 RID: 99974
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x04018687 RID: 99975
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x04018688 RID: 99976
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x04018689 RID: 99977
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x0401868A RID: 99978
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;

	// Token: 0x0401868B RID: 99979
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5A;

	// Token: 0x0401868C RID: 99980
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5B;

	// Token: 0x0401868D RID: 99981
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5C;

	// Token: 0x0401868E RID: 99982
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5D;

	// Token: 0x0401868F RID: 99983
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5E;

	// Token: 0x04018690 RID: 99984
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5F;

	// Token: 0x04018691 RID: 99985
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache60;

	// Token: 0x04018692 RID: 99986
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache61;

	// Token: 0x04018693 RID: 99987
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache62;

	// Token: 0x04018694 RID: 99988
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache63;

	// Token: 0x04018695 RID: 99989
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache64;

	// Token: 0x04018696 RID: 99990
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache65;

	// Token: 0x04018697 RID: 99991
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache66;

	// Token: 0x04018698 RID: 99992
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache67;

	// Token: 0x04018699 RID: 99993
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache68;

	// Token: 0x0401869A RID: 99994
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache69;

	// Token: 0x0401869B RID: 99995
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6A;

	// Token: 0x0401869C RID: 99996
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6B;

	// Token: 0x0401869D RID: 99997
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6C;

	// Token: 0x0401869E RID: 99998
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6D;

	// Token: 0x0401869F RID: 99999
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6E;

	// Token: 0x040186A0 RID: 100000
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6F;

	// Token: 0x040186A1 RID: 100001
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache70;

	// Token: 0x040186A2 RID: 100002
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache71;

	// Token: 0x040186A3 RID: 100003
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache72;

	// Token: 0x040186A4 RID: 100004
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache73;

	// Token: 0x040186A5 RID: 100005
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache74;

	// Token: 0x040186A6 RID: 100006
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache75;

	// Token: 0x040186A7 RID: 100007
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache76;

	// Token: 0x040186A8 RID: 100008
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache77;

	// Token: 0x040186A9 RID: 100009
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache78;

	// Token: 0x040186AA RID: 100010
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache79;

	// Token: 0x040186AB RID: 100011
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7A;

	// Token: 0x040186AC RID: 100012
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7B;

	// Token: 0x040186AD RID: 100013
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7C;

	// Token: 0x040186AE RID: 100014
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7D;

	// Token: 0x040186AF RID: 100015
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7E;

	// Token: 0x040186B0 RID: 100016
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7F;

	// Token: 0x040186B1 RID: 100017
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache80;

	// Token: 0x040186B2 RID: 100018
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache81;

	// Token: 0x040186B3 RID: 100019
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache82;

	// Token: 0x040186B4 RID: 100020
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache83;

	// Token: 0x040186B5 RID: 100021
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache84;

	// Token: 0x040186B6 RID: 100022
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache85;

	// Token: 0x040186B7 RID: 100023
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache86;

	// Token: 0x040186B8 RID: 100024
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache87;

	// Token: 0x040186B9 RID: 100025
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache88;

	// Token: 0x040186BA RID: 100026
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache89;

	// Token: 0x040186BB RID: 100027
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8A;

	// Token: 0x040186BC RID: 100028
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8B;

	// Token: 0x040186BD RID: 100029
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8C;

	// Token: 0x040186BE RID: 100030
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8D;

	// Token: 0x040186BF RID: 100031
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8E;

	// Token: 0x040186C0 RID: 100032
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8F;
}
