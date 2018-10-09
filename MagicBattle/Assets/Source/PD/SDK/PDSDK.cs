using System;
using System.Collections;
using System.Diagnostics;
using Awesomium.Core;
using BlackJack.BJFramework.Runtime.Lua;
using SLua;
using UnityEngine;

namespace PD.SDK
{
	// Token: 0x020010A4 RID: 4260
	[HotFix]
	public class PDSDK : MonoBehaviour
	{
		// Token: 0x17003EA7 RID: 16039
		// (get) Token: 0x0601579B RID: 87963 RVA: 0x00572DFC File Offset: 0x00570FFC
		public static bool IsLogin
		{
			get
			{
				return PDSDK.isLogin;
			}
		}

		// Token: 0x17003EA8 RID: 16040
		// (get) Token: 0x0601579C RID: 87964 RVA: 0x00572E04 File Offset: 0x00571004
		public static bool IsInit
		{
			get
			{
				return PDSDK.isInit;
			}
		}

		// Token: 0x17003EA9 RID: 16041
		// (get) Token: 0x0601579D RID: 87965 RVA: 0x00572E0C File Offset: 0x0057100C
		public static bool IsLogouting
		{
			get
			{
				return PDSDK._isLogouting;
			}
		}

		// Token: 0x17003EAA RID: 16042
		// (get) Token: 0x0601579E RID: 87966 RVA: 0x00572E14 File Offset: 0x00571014
		public static bool IsIosReview
		{
			get
			{
				return PDSDK._isIosReview;
			}
		}

		// Token: 0x17003EAB RID: 16043
		// (get) Token: 0x0601579F RID: 87967 RVA: 0x00572E1C File Offset: 0x0057101C
		public static PDSDK Instance
		{
			get
			{
				if (PDSDK._instance == null)
				{
					global::Debug.LogError("PDSDK _instance is null.");
				}
				return PDSDK._instance;
			}
		}

		// Token: 0x17003EAC RID: 16044
		// (get) Token: 0x060157A0 RID: 87968 RVA: 0x00572E40 File Offset: 0x00571040
		public static bool IsIosLoginWindowsPlayer
		{
			get
			{
				return Application.platform == RuntimePlatform.WindowsPlayer && PDSDK.Instance != null && PDSDK.IsLogin && PDSDK.Instance.getChannelID() == PDSDK.Instance.IOSChannelID;
			}
		}

		// Token: 0x060157A1 RID: 87969 RVA: 0x00572E90 File Offset: 0x00571090
		public static void DoCoroutine(IEnumerator coroutine, Action onComplete = null)
		{
			PDSDK._instance.StartCoroutine(PDSDK._instance.Perform(coroutine, onComplete));
		}

		// Token: 0x17003EAD RID: 16045
		// (get) Token: 0x060157A2 RID: 87970 RVA: 0x00572EAC File Offset: 0x005710AC
		public string PDAndroidChannelID
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_PDAndroidChannelID_hotfix != null)
				{
					return (string)this.m_get_PDAndroidChannelID_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return "2010011001";
			}
		}

		// Token: 0x17003EAE RID: 16046
		// (get) Token: 0x060157A3 RID: 87971 RVA: 0x00572F20 File Offset: 0x00571120
		public string PDYingYongBaoChannelID
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_PDYingYongBaoChannelID_hotfix != null)
				{
					return (string)this.m_get_PDYingYongBaoChannelID_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return "2010571001";
			}
		}

		// Token: 0x17003EAF RID: 16047
		// (get) Token: 0x060157A4 RID: 87972 RVA: 0x00572F94 File Offset: 0x00571194
		public string PDOppoChannelID
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_PDOppoChannelID_hotfix != null)
				{
					return (string)this.m_get_PDOppoChannelID_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return "2010071001";
			}
		}

		// Token: 0x17003EB0 RID: 16048
		// (get) Token: 0x060157A5 RID: 87973 RVA: 0x00573008 File Offset: 0x00571208
		public string IOSChannelID
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_IOSChannelID_hotfix != null)
				{
					return (string)this.m_get_IOSChannelID_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return "1010031002";
			}
		}

		// Token: 0x17003EB1 RID: 16049
		// (get) Token: 0x060157A6 RID: 87974 RVA: 0x0057307C File Offset: 0x0057127C
		public string DownloadClientURL
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_DownloadClientURL_hotfix != null)
				{
					return (string)this.m_get_DownloadClientURL_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				string text = string.Format("http://www.zlongame.com/html/dispatch/download.html?appkey={0}&channel={1}", "1486458782785", this.getChannelID());
				global::Debug.Log(string.Format("PDSDK.{0}.DownloadClientURL return {1}", Application.platform, text));
				return text;
			}
		}

		// Token: 0x060157A7 RID: 87975 RVA: 0x0057311C File Offset: 0x0057131C
		[DebuggerHidden]
		private IEnumerator Perform(IEnumerator coroutine, Action onComplete = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PerformIEnumeratorAction_hotfix != null)
			{
				return (IEnumerator)this.m_PerformIEnumeratorAction_hotfix.call(new object[]
				{
					this,
					coroutine,
					onComplete
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			PDSDK.<Perform>c__Iterator0 <Perform>c__Iterator = new PDSDK.<Perform>c__Iterator0();
			<Perform>c__Iterator.onComplete = onComplete;
			<Perform>c__Iterator.coroutine = coroutine;
			<Perform>c__Iterator.$this = this;
			return <Perform>c__Iterator;
		}

		// Token: 0x060157A8 RID: 87976 RVA: 0x005731C4 File Offset: 0x005713C4
		public void onWebViewOpen()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_onWebViewOpen_hotfix != null)
			{
				this.m_onWebViewOpen_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			global::Debug.Log("PDSDK.onWebViewOpen ");
			if (PDSDK.m_eventOnWebViewOpen != null)
			{
				PDSDK.m_eventOnWebViewOpen();
			}
		}

		// Token: 0x060157A9 RID: 87977 RVA: 0x00573244 File Offset: 0x00571444
		public void onWebViewClose()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_onWebViewClose_hotfix != null)
			{
				this.m_onWebViewClose_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			global::Debug.Log("PDSDK.onWebViewClose ");
			if (PDSDK.m_eventOnWebViewClose != null)
			{
				PDSDK.m_eventOnWebViewClose();
			}
		}

		// Token: 0x060157AA RID: 87978 RVA: 0x005732C4 File Offset: 0x005714C4
		private void Awake()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Awake_hotfix != null)
			{
				this.m_Awake_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			PDSDK._instance = this;
			if (!WebCore.IsInitialized)
			{
				WebCore.Initialize(new WebConfig
				{
					LogLevel = LogLevel.Verbose
				});
			}
		}

		// Token: 0x060157AB RID: 87979 RVA: 0x0057334C File Offset: 0x0057154C
		private void Update()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Update_hotfix != null)
			{
				this.m_Update_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x060157AC RID: 87980 RVA: 0x005733AC File Offset: 0x005715AC
		public void Init()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Init_hotfix != null)
			{
				this.m_Init_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (PDSDK.isInit)
			{
				return;
			}
			global::Debug.Log("Windows PDSDK Init.");
			PDSDK_PC.Init();
			BuglyAgent.EnableExceptionHandler();
		}

		// Token: 0x060157AD RID: 87981 RVA: 0x0057342C File Offset: 0x0057162C
		public void Login(string customparams)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_LoginString_hotfix != null)
			{
				this.m_LoginString_hotfix.call(new object[]
				{
					this,
					customparams
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (PDSDK._isLogining)
			{
				global::Debug.LogWarning("pdsdk _isLogining = true.");
				return;
			}
			PDSDK._isLogining = true;
			global::Debug.Log("Windows PDSDK Login.");
			PDSDK_PC.Login(customparams);
			if (Application.internetReachability == NetworkReachability.NotReachable)
			{
				this.onLoginFailed("Internet is not reachable.");
				return;
			}
		}

		// Token: 0x060157AE RID: 87982 RVA: 0x005734E0 File Offset: 0x005716E0
		public void Logout(string customparams)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_LogoutString_hotfix != null)
			{
				this.m_LogoutString_hotfix.call(new object[]
				{
					this,
					customparams
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			global::Debug.Log("PDSDK.Logout Windows");
			PDSDK._isLogouting = true;
			PDSDK_PC.Logout(customparams);
		}

		// Token: 0x060157AF RID: 87983 RVA: 0x00573568 File Offset: 0x00571768
		public void StartGame(string gameparams)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartGameString_hotfix != null)
			{
				this.m_StartGameString_hotfix.call(new object[]
				{
					this,
					gameparams
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (string.IsNullOrEmpty(gameparams))
			{
				global::Debug.LogError(string.Format("PDSDK StartGame: gameparams is null;", new object[0]));
				return;
			}
			global::Debug.Log(string.Format("PDSDK StartGame: {0}", gameparams));
			PDSDK_PC.StartGame(gameparams);
		}

		// Token: 0x060157B0 RID: 87984 RVA: 0x00573610 File Offset: 0x00571810
		public void GetProductsList()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetProductsList_hotfix != null)
			{
				this.m_GetProductsList_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			global::Debug.Log("PDSDK.GetProductsList");
			PDSDK_PC.GetProductsList();
		}

		// Token: 0x060157B1 RID: 87985 RVA: 0x00573680 File Offset: 0x00571880
		public void DoPromotingPay(string goodsName, int goodsNumber, string goodsId, string goodsRegisterId, double goodsPrice, string customparams, string goodsDes)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DoPromotingPayStringInt32StringStringDoubleStringString_hotfix != null)
			{
				this.m_DoPromotingPayStringInt32StringStringDoubleStringString_hotfix.call(new object[]
				{
					this,
					goodsName,
					goodsNumber,
					goodsId,
					goodsRegisterId,
					goodsPrice,
					customparams,
					goodsDes
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			global::Debug.Log(string.Format("PDSDK.DoPromotingPay goodsName={0} goodsNumber=={1} goodsId=={2} goodsRegisterId={3} goodsPrice={4}, customparams={5}, goodsDes={6}", new object[]
			{
				goodsName,
				goodsNumber,
				goodsId,
				goodsRegisterId,
				goodsPrice,
				customparams,
				goodsDes
			}));
		}

		// Token: 0x060157B2 RID: 87986 RVA: 0x00573790 File Offset: 0x00571990
		public void onSDKPromotingPaySuccess(string msg)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_onSDKPromotingPaySuccessString_hotfix != null)
			{
				this.m_onSDKPromotingPaySuccessString_hotfix.call(new object[]
				{
					this,
					msg
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			global::Debug.Log("PDSDK.onSDKPromotingPaySuccess " + msg);
			JsonData jsonData = JsonMapper.ToObject(msg);
			this.promotingPayGoodsRegisterID = (string)jsonData["goodsRegisterID"];
			if (this.m_eventOnSDKPromotingPaySuccess != null)
			{
				this.m_eventOnSDKPromotingPaySuccess((string)jsonData["goodsRegisterID"]);
			}
		}

		// Token: 0x060157B3 RID: 87987 RVA: 0x00573854 File Offset: 0x00571A54
		public void onSDKPromotingPayFailed(string msg)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_onSDKPromotingPayFailedString_hotfix != null)
			{
				this.m_onSDKPromotingPayFailedString_hotfix.call(new object[]
				{
					this,
					msg
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			global::Debug.Log("PDSDK.onSDKPromotingPayFailed " + msg);
			JsonData jsonData = JsonMapper.ToObject(msg);
			string text = (string)jsonData["message"];
		}

		// Token: 0x060157B4 RID: 87988 RVA: 0x005738EC File Offset: 0x00571AEC
		public void onSDKPromotingPayCancel(string msg)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_onSDKPromotingPayCancelString_hotfix != null)
			{
				this.m_onSDKPromotingPayCancelString_hotfix.call(new object[]
				{
					this,
					msg
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			global::Debug.Log("PDSDK.onSDKPromotingPayCancel " + msg);
			JsonData jsonData = JsonMapper.ToObject(msg);
			string text = (string)jsonData["message"];
		}

		// Token: 0x060157B5 RID: 87989 RVA: 0x00573984 File Offset: 0x00571B84
		public void DoPay(string goodsName, int goodsNumber, string goodsId, string goodsRegisterId, double goodsPrice, string customparams, string goodsDes)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DoPayStringInt32StringStringDoubleStringString_hotfix != null)
			{
				this.m_DoPayStringInt32StringStringDoubleStringString_hotfix.call(new object[]
				{
					this,
					goodsName,
					goodsNumber,
					goodsId,
					goodsRegisterId,
					goodsPrice,
					customparams,
					goodsDes
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			global::Debug.Log(string.Format("PDSDK.DoPay: name={0} number={1} id={2} regId={3} price={4} custom={5} desc={6}", new object[]
			{
				goodsName,
				goodsNumber,
				goodsId,
				goodsRegisterId,
				goodsPrice,
				customparams,
				goodsDes
			}));
			PDSDK_PC.DoPay(goodsName, goodsNumber, goodsId, goodsRegisterId, goodsPrice, customparams, goodsDes);
		}

		// Token: 0x060157B6 RID: 87990 RVA: 0x00573AA4 File Offset: 0x00571CA4
		public void doAddLocalPush(string Title, string Content, string Date, string Hour, string Min)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_doAddLocalPushStringStringStringStringString_hotfix != null)
			{
				this.m_doAddLocalPushStringStringStringStringString_hotfix.call(new object[]
				{
					this,
					Title,
					Content,
					Date,
					Hour,
					Min
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x060157B7 RID: 87991 RVA: 0x00573B54 File Offset: 0x00571D54
		public void doFirstScreen()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_doFirstScreen_hotfix != null)
			{
				this.m_doFirstScreen_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x060157B8 RID: 87992 RVA: 0x00573BB4 File Offset: 0x00571DB4
		public void SwitchUser()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SwitchUser_hotfix != null)
			{
				this.m_SwitchUser_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x060157B9 RID: 87993 RVA: 0x00573C14 File Offset: 0x00571E14
		public void userCenter()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_userCenter_hotfix != null)
			{
				this.m_userCenter_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			global::Debug.Log("PDSDK.userCenter");
			PDSDK_PC.UserCenter();
		}

		// Token: 0x060157BA RID: 87994 RVA: 0x00573C84 File Offset: 0x00571E84
		public void exit()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_exit_hotfix != null)
			{
				this.m_exit_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.isExitSuccess = false;
			PDSDK_PC.Exit();
		}

		// Token: 0x060157BB RID: 87995 RVA: 0x00573CF0 File Offset: 0x00571EF0
		public string GetPustToken()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetPustToken_hotfix != null)
			{
				return (string)this.m_GetPustToken_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return string.Empty;
		}

		// Token: 0x060157BC RID: 87996 RVA: 0x00573D64 File Offset: 0x00571F64
		public string GetDeviceID()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetDeviceID_hotfix != null)
			{
				return (string)this.m_GetDeviceID_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			string empty = string.Empty;
			return PDSDK_PC.GetDeviceID();
		}

		// Token: 0x060157BD RID: 87997 RVA: 0x00573DE0 File Offset: 0x00571FE0
		public int GetBattery()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetBattery_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetBattery_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return 0;
		}

		// Token: 0x060157BE RID: 87998 RVA: 0x00573E50 File Offset: 0x00572050
		public void OpenInvestigation(int enqId = 1)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OpenInvestigationInt32_hotfix != null)
			{
				this.m_OpenInvestigationInt32_hotfix.call(new object[]
				{
					this,
					enqId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			global::Debug.Log("PDSDK.OpenInvestigation()");
			this.callWebView(string.Empty, 1, 0, "enq", "{\"tag\": \"100" + enqId.ToString() + "\"}");
		}

		// Token: 0x060157BF RID: 87999 RVA: 0x00573EF8 File Offset: 0x005720F8
		public void PathOrder()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PathOrder_hotfix != null)
			{
				this.m_PathOrder_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x060157C0 RID: 88000 RVA: 0x00573F58 File Offset: 0x00572158
		public void ShowPayHelp()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowPayHelp_hotfix != null)
			{
				this.m_ShowPayHelp_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x060157C1 RID: 88001 RVA: 0x00573FB8 File Offset: 0x005721B8
		public void printGameEventLog(string eventID, string remark = "")
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_printGameEventLogStringString_hotfix != null)
			{
				this.m_printGameEventLogStringString_hotfix.call(new object[]
				{
					this,
					eventID,
					remark
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (Application.isEditor)
			{
				return;
			}
			PDSDK_PC.PrintGameEventLog(eventID, remark);
		}

		// Token: 0x060157C2 RID: 88002 RVA: 0x0057404C File Offset: 0x0057224C
		public string doSetExtData(string data, string type)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_doSetExtDataStringString_hotfix != null)
			{
				return (string)this.m_doSetExtDataStringString_hotfix.call(new object[]
				{
					this,
					data,
					type
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			global::Debug.Log(string.Format("PDSDK.doSetExtData type={0} data={1}", type, data));
			return string.Empty;
		}

		// Token: 0x060157C3 RID: 88003 RVA: 0x005740F0 File Offset: 0x005722F0
		public void doStartQRLogin(string customParams)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_doStartQRLoginString_hotfix != null)
			{
				this.m_doStartQRLoginString_hotfix.call(new object[]
				{
					this,
					customParams
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x060157C4 RID: 88004 RVA: 0x00574160 File Offset: 0x00572360
		public string getChannelID()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_getChannelID_hotfix != null)
			{
				return (string)this.m_getChannelID_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			string text = string.Empty;
			text = PDSDK_PC.getCommonProperty("channel_id", string.Empty);
			global::Debug.Log("PDSDK.getChannelID = " + text);
			return text;
		}

		// Token: 0x060157C5 RID: 88005 RVA: 0x005741F4 File Offset: 0x005723F4
		public void doSaveImageToPhotoLibrary(string data)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_doSaveImageToPhotoLibraryString_hotfix != null)
			{
				this.m_doSaveImageToPhotoLibraryString_hotfix.call(new object[]
				{
					this,
					data
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x060157C6 RID: 88006 RVA: 0x00574264 File Offset: 0x00572464
		public void doQQVIP()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_doQQVIP_hotfix != null)
			{
				this.m_doQQVIP_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x060157C7 RID: 88007 RVA: 0x005742C4 File Offset: 0x005724C4
		public void callWebView(string title, int fullscreen_flag, int title_flag, string action, string customparams)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_callWebViewStringInt32Int32StringString_hotfix != null)
			{
				this.m_callWebViewStringInt32Int32StringString_hotfix.call(new object[]
				{
					this,
					title,
					fullscreen_flag,
					title_flag,
					action,
					customparams
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			global::Debug.Log(string.Format("PDSDK.callWebView {0}, {1}, {2}, {3}, {4} ", new object[]
			{
				title,
				fullscreen_flag,
				title_flag,
				action,
				customparams
			}));
			PDSDK_PC.CallWebView(title, fullscreen_flag, title_flag, action, customparams);
		}

		// Token: 0x060157C8 RID: 88008 RVA: 0x005743B8 File Offset: 0x005725B8
		public void clearLocalNotifications()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_clearLocalNotifications_hotfix != null)
			{
				this.m_clearLocalNotifications_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x060157C9 RID: 88009 RVA: 0x00574418 File Offset: 0x00572618
		public void callCustomerServiceWeb()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_callCustomerServiceWeb_hotfix != null)
			{
				this.m_callCustomerServiceWeb_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			PDSDK_PC.callCustomerServiceWeb();
		}

		// Token: 0x060157CA RID: 88010 RVA: 0x00574480 File Offset: 0x00572680
		public void doshare(string data)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_doshareString_hotfix != null)
			{
				this.m_doshareString_hotfix.call(new object[]
				{
					this,
					data
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			global::Debug.Log(string.Format("PDSDK.doshare {0}", data));
		}

		// Token: 0x060157CB RID: 88011 RVA: 0x00574500 File Offset: 0x00572700
		public void doStartRecord()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_doStartRecord_hotfix != null)
			{
				this.m_doStartRecord_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x060157CC RID: 88012 RVA: 0x00574560 File Offset: 0x00572760
		public void doStopRecord()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_doStopRecord_hotfix != null)
			{
				this.m_doStopRecord_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x060157CD RID: 88013 RVA: 0x005745C0 File Offset: 0x005727C0
		public void doBoradcast()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_doBoradcast_hotfix != null)
			{
				this.m_doBoradcast_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x060157CE RID: 88014 RVA: 0x00574620 File Offset: 0x00572820
		public void doOpenRequestReview()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_doOpenRequestReview_hotfix != null)
			{
				this.m_doOpenRequestReview_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x060157CF RID: 88015 RVA: 0x00574680 File Offset: 0x00572880
		public void onLoginSuccess(string msg)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_onLoginSuccessString_hotfix != null)
			{
				this.m_onLoginSuccessString_hotfix.call(new object[]
				{
					this,
					msg
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			global::Debug.Log("PDSDK.onLoginSuccess " + msg);
			PDSDK._isLogining = false;
			PDSDK.isLogin = true;
			this.showAndroidToast("login success" + msg);
			if (this.isDebug && this.isVerfy)
			{
				this.verifyToken(msg);
			}
			if (PDSDK.m_eventLoginSuccess != null)
			{
				PDSDK.m_eventLoginSuccess(LoginSuccessMsg.Parse(msg));
			}
		}

		// Token: 0x060157D0 RID: 88016 RVA: 0x00574754 File Offset: 0x00572954
		public void onLoginFailed(string msg)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_onLoginFailedString_hotfix != null)
			{
				this.m_onLoginFailedString_hotfix.call(new object[]
				{
					this,
					msg
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			global::Debug.LogError(string.Format("PDSDK.onLoginFailed {0}", msg));
			PDSDK._isLogining = false;
			if (PDSDK.m_eventLoginFailed != null)
			{
				PDSDK.m_eventLoginFailed();
			}
		}

		// Token: 0x060157D1 RID: 88017 RVA: 0x005747F0 File Offset: 0x005729F0
		public void onLoginCancel(string msg)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_onLoginCancelString_hotfix != null)
			{
				this.m_onLoginCancelString_hotfix.call(new object[]
				{
					this,
					msg
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			global::Debug.Log("PDSDK.onLoginCancel " + msg);
			PDSDK._isLogining = false;
			JsonData jsonData = JsonMapper.ToObject(msg);
			string text = (string)jsonData["message"];
			string text2 = (string)jsonData["customparams"];
			if (PDSDK.m_eventLoginFailed != null)
			{
				PDSDK.m_eventLoginFailed();
			}
		}

		// Token: 0x060157D2 RID: 88018 RVA: 0x005748B4 File Offset: 0x00572AB4
		private void onQRLoginSuccess(string msg)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_onQRLoginSuccessString_hotfix != null)
			{
				this.m_onQRLoginSuccessString_hotfix.call(new object[]
				{
					this,
					msg
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			global::Debug.Log("PDSDK.onQRLoginSuccess " + msg);
			if (PDSDK.m_eventQRLoginSuccess != null)
			{
				PDSDK.m_eventQRLoginSuccess(msg);
			}
		}

		// Token: 0x060157D3 RID: 88019 RVA: 0x0057494C File Offset: 0x00572B4C
		private void onQRLoginFailed(string msg)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_onQRLoginFailedString_hotfix != null)
			{
				this.m_onQRLoginFailedString_hotfix.call(new object[]
				{
					this,
					msg
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			global::Debug.LogError("PDSDK.onQRLoginFailed " + msg);
			if (PDSDK.m_eventQRLoginFailed != null)
			{
				PDSDK.m_eventQRLoginFailed(msg);
			}
		}

		// Token: 0x060157D4 RID: 88020 RVA: 0x005749E4 File Offset: 0x00572BE4
		private void onQRLoginCancel(string msg)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_onQRLoginCancelString_hotfix != null)
			{
				this.m_onQRLoginCancelString_hotfix.call(new object[]
				{
					this,
					msg
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			global::Debug.Log("PDSDK.onQRLoginCancel " + msg);
			if (PDSDK.m_eventQRLoginCancel != null)
			{
				PDSDK.m_eventQRLoginCancel(msg);
			}
		}

		// Token: 0x060157D5 RID: 88021 RVA: 0x00574A7C File Offset: 0x00572C7C
		public void onLogoutSuccess(string msg)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_onLogoutSuccessString_hotfix != null)
			{
				this.m_onLogoutSuccessString_hotfix.call(new object[]
				{
					this,
					msg
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			global::Debug.Log("PDSDK.onLogoutSuccess " + msg);
			PDSDK.isLogin = false;
			try
			{
				JsonData jsonData = JsonMapper.ToObject(msg);
				string text = (string)jsonData["customparams"];
			}
			catch (Exception ex)
			{
				global::Debug.LogError(string.Format("PDSDK.onLogoutSuccess exception: {0}", ex.Message));
			}
			this.showAndroidToast("logout success");
			if (PDSDK.m_eventLogoutSuccess != null)
			{
				PDSDK.m_eventLogoutSuccess();
			}
			PDSDK._isLogouting = false;
		}

		// Token: 0x060157D6 RID: 88022 RVA: 0x00574B70 File Offset: 0x00572D70
		public void onLogoutFailed(string msg)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_onLogoutFailedString_hotfix != null)
			{
				this.m_onLogoutFailedString_hotfix.call(new object[]
				{
					this,
					msg
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			global::Debug.LogError("onLogoutFailed " + msg);
			JsonData jsonData = JsonMapper.ToObject(msg);
			string str = (string)jsonData["message"];
			string text = (string)jsonData["customparams"];
			this.showAndroidToast("logout failed" + str);
			PDSDK._isLogouting = false;
		}

		// Token: 0x060157D7 RID: 88023 RVA: 0x00574C30 File Offset: 0x00572E30
		public void onLogoutCancel(string msg)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_onLogoutCancelString_hotfix != null)
			{
				this.m_onLogoutCancelString_hotfix.call(new object[]
				{
					this,
					msg
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			global::Debug.Log("PDSDK.onLogoutCancel " + msg);
			JsonData jsonData = JsonMapper.ToObject(msg);
			string str = (string)jsonData["message"];
			string text = (string)jsonData["customparams"];
			this.showAndroidToast("logout cancel" + str);
			PDSDK._isLogouting = false;
		}

		// Token: 0x060157D8 RID: 88024 RVA: 0x00574CF0 File Offset: 0x00572EF0
		public void onGetProductsListSuccess(string msg)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_onGetProductsListSuccessString_hotfix != null)
			{
				this.m_onGetProductsListSuccessString_hotfix.call(new object[]
				{
					this,
					msg
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			global::Debug.Log("PDSDK.onGetProductsListSuccess " + msg);
			PDSDK.goodlistjson = JsonMapper.ToObject(JsonMapper.ToObject(msg)["data"].ToString());
			if (PDSDK.m_eventOnGetProductsListAck != null)
			{
				PDSDK.m_eventOnGetProductsListAck(true);
			}
		}

		// Token: 0x060157D9 RID: 88025 RVA: 0x00574DA4 File Offset: 0x00572FA4
		public void onGetProductsListFailed(string msg)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_onGetProductsListFailedString_hotfix != null)
			{
				this.m_onGetProductsListFailedString_hotfix.call(new object[]
				{
					this,
					msg
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			global::Debug.LogError("PDSDK.onGetProductsListFailed " + msg);
			JsonData jsonData = JsonMapper.ToObject(msg);
			string text = (string)jsonData["message"];
			if (PDSDK.m_eventOnGetProductsListAck != null)
			{
				PDSDK.m_eventOnGetProductsListAck(false);
			}
		}

		// Token: 0x060157DA RID: 88026 RVA: 0x00574E54 File Offset: 0x00573054
		public void onPaySuccess(string msg)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_onPaySuccessString_hotfix != null)
			{
				this.m_onPaySuccessString_hotfix.call(new object[]
				{
					this,
					msg
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			global::Debug.Log("PDSDK.onPaySuccess msg= " + msg);
			JsonData jsonData = JsonMapper.ToObject(msg);
			if (PDSDK.m_eventOnPaySuccess != null)
			{
				PDSDK.m_eventOnPaySuccess();
			}
		}

		// Token: 0x060157DB RID: 88027 RVA: 0x00574EF0 File Offset: 0x005730F0
		public void onPayFailed(string msg)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_onPayFailedString_hotfix != null)
			{
				this.m_onPayFailedString_hotfix.call(new object[]
				{
					this,
					msg
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			global::Debug.LogError("PDSDK.onPayFailed msg= " + msg);
			JsonData jsonData = JsonMapper.ToObject(msg);
			string text = (string)jsonData["message"];
			if (PDSDK.m_eventOnPayFailed != null)
			{
				PDSDK.m_eventOnPayFailed();
			}
		}

		// Token: 0x060157DC RID: 88028 RVA: 0x00574F9C File Offset: 0x0057319C
		public void onPayCancel(string msg)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_onPayCancelString_hotfix != null)
			{
				this.m_onPayCancelString_hotfix.call(new object[]
				{
					this,
					msg
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			global::Debug.Log("PDSDK.onPayCancel msg=" + msg);
			JsonData jsonData = JsonMapper.ToObject(msg);
			string text = (string)jsonData["message"];
			if (PDSDK.m_eventOnPayCancel != null)
			{
				PDSDK.m_eventOnPayCancel();
			}
		}

		// Token: 0x060157DD RID: 88029 RVA: 0x00575048 File Offset: 0x00573248
		public void onGetPayHistorySuccess(string msg)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_onGetPayHistorySuccessString_hotfix != null)
			{
				this.m_onGetPayHistorySuccessString_hotfix.call(new object[]
				{
					this,
					msg
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			global::Debug.Log("PDSDK.onGetPayHistorySuccess " + msg);
			JsonData jsonData = JsonMapper.ToObject(msg);
			this.showAndroidToast("GetPayHistory success " + msg);
		}

		// Token: 0x060157DE RID: 88030 RVA: 0x005750E0 File Offset: 0x005732E0
		public void onGetPayHistoryFailed(string msg)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_onGetPayHistoryFailedString_hotfix != null)
			{
				this.m_onGetPayHistoryFailedString_hotfix.call(new object[]
				{
					this,
					msg
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			global::Debug.LogError("onGetPayHistoryFailed " + msg);
			JsonData jsonData = JsonMapper.ToObject(msg);
			string text = (string)jsonData["message"];
			this.showAndroidToast("GetPayHistory failed " + msg);
		}

		// Token: 0x060157DF RID: 88031 RVA: 0x0057518C File Offset: 0x0057338C
		public void onInitSuccess(string msg)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_onInitSuccessString_hotfix != null)
			{
				this.m_onInitSuccessString_hotfix.call(new object[]
				{
					this,
					msg
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			global::Debug.Log("PDSDK.onInitSuccess " + msg);
			if (!string.IsNullOrEmpty(msg))
			{
				JsonData jsonData = JsonMapper.ToObject(msg);
				if (((IDictionary)jsonData).Contains("isReview"))
				{
					PDSDK._isIosReview = (jsonData["isReview"].ToString() == "1");
				}
			}
			global::Debug.Log("PDSDK.onInitSuccess _isIosReview=" + PDSDK._isIosReview.ToString());
			PDSDK.isInit = true;
			if (PDSDK.m_eventInitSuccess != null)
			{
				PDSDK.m_eventInitSuccess();
			}
		}

		// Token: 0x060157E0 RID: 88032 RVA: 0x00575288 File Offset: 0x00573488
		public void onInitFailed(string msg)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_onInitFailedString_hotfix != null)
			{
				this.m_onInitFailedString_hotfix.call(new object[]
				{
					this,
					msg
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			global::Debug.LogError("onInitFailed " + msg);
			this.showAndroidToast("Init failed " + msg);
			if (PDSDK.m_eventInitFailed != null)
			{
				PDSDK.m_eventInitFailed();
			}
		}

		// Token: 0x060157E1 RID: 88033 RVA: 0x00575330 File Offset: 0x00573530
		public void onswitchUserSuccess(string msg)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_onswitchUserSuccessString_hotfix != null)
			{
				this.m_onswitchUserSuccessString_hotfix.call(new object[]
				{
					this,
					msg
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			global::Debug.Log("PDSDK.onswitchUserSuccess " + msg);
			PDSDK._isLogining = false;
			PDSDK.isLogin = true;
			if (PDSDK.m_eventOnSwitchUserSuccess != null)
			{
				PDSDK.m_eventOnSwitchUserSuccess(LoginSuccessMsg.Parse(msg));
			}
		}

		// Token: 0x060157E2 RID: 88034 RVA: 0x005753D8 File Offset: 0x005735D8
		public void onswitchUserFailed(string msg)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_onswitchUserFailedString_hotfix != null)
			{
				this.m_onswitchUserFailedString_hotfix.call(new object[]
				{
					this,
					msg
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			global::Debug.LogError("onswitchUserFailed " + msg);
			this.showAndroidToast("switchUser Failed " + msg);
		}

		// Token: 0x060157E3 RID: 88035 RVA: 0x0057546C File Offset: 0x0057366C
		public void onswitchUserCancel(string msg)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_onswitchUserCancelString_hotfix != null)
			{
				this.m_onswitchUserCancelString_hotfix.call(new object[]
				{
					this,
					msg
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			global::Debug.Log("PDSDK.onswitchUserCancel " + msg);
			this.showAndroidToast("switchUser Cancel " + msg);
		}

		// Token: 0x060157E4 RID: 88036 RVA: 0x00575500 File Offset: 0x00573700
		public void onVerifyTokenSuccess(string msg)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_onVerifyTokenSuccessString_hotfix != null)
			{
				this.m_onVerifyTokenSuccessString_hotfix.call(new object[]
				{
					this,
					msg
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			global::Debug.Log("PDSDK.onVerifyTokenSuccess " + msg);
			this.showAndroidToast("VerifyToken Success " + msg);
		}

		// Token: 0x060157E5 RID: 88037 RVA: 0x00575594 File Offset: 0x00573794
		public void onVerifyTokenFailed(string msg)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_onVerifyTokenFailedString_hotfix != null)
			{
				this.m_onVerifyTokenFailedString_hotfix.call(new object[]
				{
					this,
					msg
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			global::Debug.LogError("onVerifyTokenFailed " + msg);
			this.showAndroidToast("VerifyToken Failed " + msg);
		}

		// Token: 0x060157E6 RID: 88038 RVA: 0x00575628 File Offset: 0x00573828
		public void onDoSetExtDataSuccess(string msg)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_onDoSetExtDataSuccessString_hotfix != null)
			{
				this.m_onDoSetExtDataSuccessString_hotfix.call(new object[]
				{
					this,
					msg
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			global::Debug.Log("PDSDK.onDoSetExtDataSuccess " + msg);
			JsonData jsonData = JsonMapper.ToObject(msg);
			string text = (string)jsonData["data"];
			string text2 = (string)jsonData["message"];
			string text3 = (string)jsonData["type"];
			this.showAndroidToast(string.Concat(new string[]
			{
				"[onDoSetExtDataSuccess] message ：",
				text2,
				" data :",
				text,
				" type ：",
				text3
			}));
		}

		// Token: 0x060157E7 RID: 88039 RVA: 0x00575718 File Offset: 0x00573918
		public void onDoSetExtDataFailed(string msg)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_onDoSetExtDataFailedString_hotfix != null)
			{
				this.m_onDoSetExtDataFailedString_hotfix.call(new object[]
				{
					this,
					msg
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			global::Debug.LogError("onDoSetExtDataFailed " + msg);
			JsonData jsonData = JsonMapper.ToObject(msg);
			string text = (string)jsonData["data"];
			string text2 = (string)jsonData["message"];
			string text3 = (string)jsonData["type"];
			this.showAndroidToast(string.Concat(new string[]
			{
				"[onDoSetExtDataFailed] message ：",
				text2,
				" data :",
				text,
				" type ：",
				text3
			}));
		}

		// Token: 0x060157E8 RID: 88040 RVA: 0x00575808 File Offset: 0x00573A08
		public void onExitSuccess(string msg)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_onExitSuccessString_hotfix != null)
			{
				this.m_onExitSuccessString_hotfix.call(new object[]
				{
					this,
					msg
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			try
			{
				this.isExitSuccess = true;
				global::Debug.Log("PDSDK.onExitSuccess " + msg);
			}
			catch (Exception ex)
			{
				global::Debug.LogError(string.Format("PDSDK onExitSuccess: {0}, error: {1}", msg, ex.Message));
			}
		}

		// Token: 0x060157E9 RID: 88041 RVA: 0x005758C0 File Offset: 0x00573AC0
		public void onExitFailed(string msg)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_onExitFailedString_hotfix != null)
			{
				this.m_onExitFailedString_hotfix.call(new object[]
				{
					this,
					msg
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			global::Debug.LogError("onExitFailed " + msg);
			JsonData jsonData = JsonMapper.ToObject(msg);
			string text = (string)jsonData["data"];
			string text2 = (string)jsonData["message"];
			this.showAndroidToast("onExitFailed " + msg);
		}

		// Token: 0x060157EA RID: 88042 RVA: 0x0057597C File Offset: 0x00573B7C
		public void onMemoryWarning(string recode)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_onMemoryWarningString_hotfix != null)
			{
				this.m_onMemoryWarningString_hotfix.call(new object[]
				{
					this,
					recode
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			global::Debug.Log("PDSDK.onMemoryWarning " + recode);
			if (PDSDK.m_eventOnLowMemoryWarning != null)
			{
				PDSDK.m_eventOnLowMemoryWarning();
			}
		}

		// Token: 0x060157EB RID: 88043 RVA: 0x00575A10 File Offset: 0x00573C10
		public void onShareSuccess(string msg)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_onShareSuccessString_hotfix != null)
			{
				this.m_onShareSuccessString_hotfix.call(new object[]
				{
					this,
					msg
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			global::Debug.Log("PDSDK.onShareSuccess " + msg);
			JsonData jsonData = JsonMapper.ToObject(msg);
			string text = (string)jsonData["message"];
			this.showAndroidToast("onShareSuccess" + msg);
		}

		// Token: 0x060157EC RID: 88044 RVA: 0x00575ABC File Offset: 0x00573CBC
		public void onShareFailed(string msg)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_onShareFailedString_hotfix != null)
			{
				this.m_onShareFailedString_hotfix.call(new object[]
				{
					this,
					msg
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			global::Debug.LogError("PDSDK.onShareFailed " + msg);
			JsonData jsonData = JsonMapper.ToObject(msg);
			string text = (string)jsonData["message"];
			this.showAndroidToast("onShareFailed" + msg);
		}

		// Token: 0x060157ED RID: 88045 RVA: 0x00575B68 File Offset: 0x00573D68
		public void onShareCancel(string msg)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_onShareCancelString_hotfix != null)
			{
				this.m_onShareCancelString_hotfix.call(new object[]
				{
					this,
					msg
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			global::Debug.Log("PDSDK.onShareCancel " + msg);
			JsonData jsonData = JsonMapper.ToObject(msg);
			string text = (string)jsonData["message"];
			this.showAndroidToast("onShareCancel" + msg);
		}

		// Token: 0x060157EE RID: 88046 RVA: 0x00575C14 File Offset: 0x00573E14
		public void onRecordStartSuccess(string msg)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_onRecordStartSuccessString_hotfix != null)
			{
				this.m_onRecordStartSuccessString_hotfix.call(new object[]
				{
					this,
					msg
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			global::Debug.Log("PDSDK.onRecordStartSuccess " + msg);
			JsonData jsonData = JsonMapper.ToObject(msg);
			string text = (string)jsonData["message"];
			this.showAndroidToast("onShareCancel" + msg);
		}

		// Token: 0x060157EF RID: 88047 RVA: 0x00575CC0 File Offset: 0x00573EC0
		public void onRecordStartFail(string msg)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_onRecordStartFailString_hotfix != null)
			{
				this.m_onRecordStartFailString_hotfix.call(new object[]
				{
					this,
					msg
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			global::Debug.Log("PDSDK.onRecordStartFail " + msg);
			JsonData jsonData = JsonMapper.ToObject(msg);
			string text = (string)jsonData["message"];
			this.showAndroidToast("onShareCancel" + msg);
		}

		// Token: 0x060157F0 RID: 88048 RVA: 0x00575D6C File Offset: 0x00573F6C
		public void onRecordStopSuccess(string msg)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_onRecordStopSuccessString_hotfix != null)
			{
				this.m_onRecordStopSuccessString_hotfix.call(new object[]
				{
					this,
					msg
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			global::Debug.Log("PDSDK.onRecordStopSuccess " + msg);
			JsonData jsonData = JsonMapper.ToObject(msg);
			string text = (string)jsonData["message"];
			this.showAndroidToast("onShareCancel" + msg);
		}

		// Token: 0x060157F1 RID: 88049 RVA: 0x00575E18 File Offset: 0x00574018
		public void onRecordStopFail(string msg)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_onRecordStopFailString_hotfix != null)
			{
				this.m_onRecordStopFailString_hotfix.call(new object[]
				{
					this,
					msg
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			global::Debug.Log("PDSDK.onRecordStopFail " + msg);
			JsonData jsonData = JsonMapper.ToObject(msg);
			string text = (string)jsonData["message"];
			this.showAndroidToast("onShareCancel" + msg);
		}

		// Token: 0x060157F2 RID: 88050 RVA: 0x00575EC4 File Offset: 0x005740C4
		public void onBoradcastSuccess(string msg)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_onBoradcastSuccessString_hotfix != null)
			{
				this.m_onBoradcastSuccessString_hotfix.call(new object[]
				{
					this,
					msg
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			global::Debug.Log("PDSDK.onBoradcastSuccess " + msg);
			this.showAndroidToast("onShareCancel" + msg);
		}

		// Token: 0x060157F3 RID: 88051 RVA: 0x00575F58 File Offset: 0x00574158
		public void onBoradcastFail(string msg)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_onBoradcastFailString_hotfix != null)
			{
				this.m_onBoradcastFailString_hotfix.call(new object[]
				{
					this,
					msg
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			global::Debug.Log("PDSDK.onBoradcastFail " + msg);
			this.showAndroidToast("onShareCancel" + msg);
		}

		// Token: 0x060157F4 RID: 88052 RVA: 0x00575FEC File Offset: 0x005741EC
		public void onDoQuestionSuccess(string msg)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_onDoQuestionSuccessString_hotfix != null)
			{
				this.m_onDoQuestionSuccessString_hotfix.call(new object[]
				{
					this,
					msg
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			global::Debug.Log("PDSDK.onDoQuestionSuccess " + msg);
			JsonData jsonData = JsonMapper.ToObject(msg);
			string text = (string)jsonData["message"];
			this.showAndroidToast("onDoQuestionSuccess" + msg);
		}

		// Token: 0x060157F5 RID: 88053 RVA: 0x00576098 File Offset: 0x00574298
		public void onDoQuestionFailed(string msg)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_onDoQuestionFailedString_hotfix != null)
			{
				this.m_onDoQuestionFailedString_hotfix.call(new object[]
				{
					this,
					msg
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			global::Debug.LogError("onDoQuestionFailed " + msg);
			JsonData jsonData = JsonMapper.ToObject(msg);
			string text = (string)jsonData["message"];
			this.showAndroidToast("onDoQuestionFailed" + msg);
		}

		// Token: 0x060157F6 RID: 88054 RVA: 0x00576144 File Offset: 0x00574344
		public void oncallWebViewSuccess(string msg)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_oncallWebViewSuccessString_hotfix != null)
			{
				this.m_oncallWebViewSuccessString_hotfix.call(new object[]
				{
					this,
					msg
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			global::Debug.Log("PDSDK.oncallWebViewSuccess " + msg);
			JsonData jsonData = JsonMapper.ToObject(msg);
			string text = (string)jsonData["message"];
			this.showAndroidToast("oncallWebViewSuccess" + msg);
			try
			{
				JsonData jsonData2 = JsonMapper.ToObject(jsonData["data"].ToString());
				if ((string)jsonData2["action"] == "enq" && PDSDK.m_eventDoQuestionSucceed != null)
				{
					PDSDK.m_eventDoQuestionSucceed();
				}
			}
			catch (Exception ex)
			{
				global::Debug.LogError("PDSDK.oncallWebViewSuccess - Exception: " + ex.ToString());
			}
		}

		// Token: 0x060157F7 RID: 88055 RVA: 0x00576268 File Offset: 0x00574468
		public void oncallWebViewFailed(string msg)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_oncallWebViewFailedString_hotfix != null)
			{
				this.m_oncallWebViewFailedString_hotfix.call(new object[]
				{
					this,
					msg
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			global::Debug.Log("PDSDK.oncallWebViewFailed " + msg);
			JsonData jsonData = JsonMapper.ToObject(msg);
			string text = (string)jsonData["message"];
			this.showAndroidToast("oncallWebViewFailed" + msg);
			try
			{
				JsonData jsonData2 = JsonMapper.ToObject(jsonData["data"].ToString());
				if ((string)jsonData2["action"] == "enq" && PDSDK.m_eventDoQuestionFailed != null)
				{
					PDSDK.m_eventDoQuestionFailed();
				}
			}
			catch (Exception ex)
			{
				global::Debug.LogError("PDSDK.oncallWebViewFailed - Exception: " + ex.ToString());
			}
		}

		// Token: 0x060157F8 RID: 88056 RVA: 0x0057638C File Offset: 0x0057458C
		public void oncallWebViewCancel(string msg)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_oncallWebViewCancelString_hotfix != null)
			{
				this.m_oncallWebViewCancelString_hotfix.call(new object[]
				{
					this,
					msg
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			global::Debug.Log("PDSDK.oncallWebViewCancel " + msg);
			JsonData jsonData = JsonMapper.ToObject(msg);
			string text = (string)jsonData["message"];
			this.showAndroidToast("oncallWebViewCancel" + msg);
			try
			{
				JsonData jsonData2 = JsonMapper.ToObject(jsonData["data"].ToString());
				if ((string)jsonData2["action"] == "enq" && PDSDK.m_eventDoQuestionFailed != null)
				{
					PDSDK.m_eventDoQuestionFailed();
				}
			}
			catch (Exception ex)
			{
				global::Debug.LogError("PDSDK.oncallWebViewCancel - Exception: " + ex.ToString());
			}
		}

		// Token: 0x060157F9 RID: 88057 RVA: 0x005764B0 File Offset: 0x005746B0
		public void onDoSaveImageToPhotoLibrarySuccess(string msg)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_onDoSaveImageToPhotoLibrarySuccessString_hotfix != null)
			{
				this.m_onDoSaveImageToPhotoLibrarySuccessString_hotfix.call(new object[]
				{
					this,
					msg
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			global::Debug.Log("PDSDK.onDoSaveImageToPhotoLibrarySuccess " + msg);
			JsonData jsonData = JsonMapper.ToObject(msg);
			string text = (string)jsonData["message"];
			this.showAndroidToast("onDoSaveImageToPhotoLibrarySuccess" + msg);
		}

		// Token: 0x060157FA RID: 88058 RVA: 0x0057655C File Offset: 0x0057475C
		public void onDoSaveImageToPhotoLibraryFailed(string msg)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_onDoSaveImageToPhotoLibraryFailedString_hotfix != null)
			{
				this.m_onDoSaveImageToPhotoLibraryFailedString_hotfix.call(new object[]
				{
					this,
					msg
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			global::Debug.Log("PDSDK.onDoSaveImageToPhotoLibraryFailed " + msg);
			JsonData jsonData = JsonMapper.ToObject(msg);
			string text = (string)jsonData["message"];
			this.showAndroidToast("onDoSaveImageToPhotoLibraryFailed" + msg);
		}

		// Token: 0x060157FB RID: 88059 RVA: 0x00576608 File Offset: 0x00574808
		public void showAndroidToast(string info)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_showAndroidToastString_hotfix != null)
			{
				this.m_showAndroidToastString_hotfix.call(new object[]
				{
					this,
					info
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x060157FC RID: 88060 RVA: 0x00576678 File Offset: 0x00574878
		public void verifyToken(string info)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_verifyTokenString_hotfix != null)
			{
				this.m_verifyTokenString_hotfix.call(new object[]
				{
					this,
					info
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			PDSDK_PC.verifyToken(info);
		}

		// Token: 0x060157FD RID: 88061 RVA: 0x005766F0 File Offset: 0x005748F0
		public void OnGUI()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnGUI_hotfix != null)
			{
				this.m_OnGUI_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.isDebug)
			{
				if (GUILayout.Button("init", new GUILayoutOption[]
				{
					GUILayout.Height(100f),
					GUILayout.Width(200f)
				}))
				{
					this.stringToEdit += "init\n";
					this.Init();
				}
				GUILayout.BeginHorizontal("button", new GUILayoutOption[0]);
				if (GUILayout.Button("login", new GUILayoutOption[]
				{
					GUILayout.Height(100f),
					GUILayout.Width(200f)
				}))
				{
					this.stringToEdit += "start login \n";
					PDSDK.Instance.Login("loginpara");
				}
				if (GUILayout.Button("logout", new GUILayoutOption[]
				{
					GUILayout.Height(100f),
					GUILayout.Width(200f)
				}))
				{
					PDSDK.Instance.Logout("logoutpara");
				}
				if (GUILayout.Button("start game", new GUILayoutOption[]
				{
					GUILayout.Height(100f),
					GUILayout.Width(200f)
				}))
				{
					PDSDK.Instance.StartGame("{\"RoleId\":\"123213123\", \"GameUid\":\"GameUid\", \"RoleLevel\":\"10\", \"ServerId\":\"001\",\"ServerName\":\"ServerName\", \"GameName\":\"GameName\", \"Balance\":100, \"PartyName\":\"PartyName\", \"VipLevel\":0, \"PushInfo\":\"PushInfo\"}");
				}
				if (GUILayout.Button("get porducts list", new GUILayoutOption[]
				{
					GUILayout.Height(100f),
					GUILayout.Width(200f)
				}))
				{
					PDSDK.Instance.GetProductsList();
				}
				if (GUILayout.Button("getDeviceID", new GUILayoutOption[]
				{
					GUILayout.Height(100f),
					GUILayout.Width(200f)
				}))
				{
					this.stringToEdit = this.stringToEdit + PDSDK.Instance.GetDeviceID() + "\n";
				}
				if (GUILayout.Button("getPushToken", new GUILayoutOption[]
				{
					GUILayout.Height(100f),
					GUILayout.Width(200f)
				}))
				{
					this.stringToEdit = this.stringToEdit + PDSDK.Instance.GetPustToken() + "\n";
				}
				if (GUILayout.Button("doAddLocalPush", new GUILayoutOption[]
				{
					GUILayout.Height(100f),
					GUILayout.Width(200f)
				}))
				{
					string title = "我是标题";
					string content = "我是内容";
					string text = DateTime.Now.AddMinutes(1.0).ToString("yyyyMMdd");
					string text2 = DateTime.Now.AddMinutes(1.0).ToString("HH");
					string text3 = DateTime.Now.AddMinutes(1.0).ToString("mm");
					global::Debug.Log("fwltest is date is " + text);
					global::Debug.Log("fwltest is Hour is " + text2);
					global::Debug.Log("fwltest is Min is " + text3);
					PDSDK.Instance.doAddLocalPush(title, content, text, text2, text3);
				}
				if (GUILayout.Button("用户中心", new GUILayoutOption[]
				{
					GUILayout.Height(100f),
					GUILayout.Width(200f)
				}))
				{
					PDSDK.Instance.userCenter();
				}
				GUILayout.EndHorizontal();
				GUILayout.BeginHorizontal("button", new GUILayoutOption[0]);
				if (GUILayout.Button("switchUser", new GUILayoutOption[]
				{
					GUILayout.Height(100f),
					GUILayout.Width(200f)
				}))
				{
					PDSDK.Instance.SwitchUser();
				}
				if (GUILayout.Button("exit", new GUILayoutOption[]
				{
					GUILayout.Height(100f),
					GUILayout.Width(200f)
				}))
				{
					PDSDK.Instance.exit();
				}
				if (GUILayout.Button("print gameevent", new GUILayoutOption[]
				{
					GUILayout.Height(100f),
					GUILayout.Width(200f)
				}))
				{
					string text4 = "{\"serverid\":\"fwl\"}";
					string text5 = "1";
					PDSDK.Instance.printGameEventLog(text5, text4);
					string text6 = this.stringToEdit;
					this.stringToEdit = string.Concat(new string[]
					{
						text6,
						" printGameEventLog ID is ",
						text5,
						" remark is ",
						text4,
						"\n"
					});
				}
				if (GUILayout.Button("doExtData", new GUILayoutOption[]
				{
					GUILayout.Height(100f),
					GUILayout.Width(200f)
				}))
				{
					JsonData jsonData = new JsonData();
					jsonData["RoleId"] = "112223333";
					jsonData["ServerId"] = "6666666";
					global::Debug.Log(" data is " + jsonData.ToJson());
					PDSDK.Instance.doSetExtData(jsonData.ToJson(), "levelup");
				}
				GUILayout.EndHorizontal();
				GUILayout.BeginHorizontal("button", new GUILayoutOption[0]);
				if (PDSDK.goodlistjson != null)
				{
					for (int i = 0; i < PDSDK.goodlistjson.Count; i++)
					{
						string goodsId = PDSDK.goodlistjson[i]["goods_id"].ToString();
						string text7 = PDSDK.goodlistjson[i]["goods_icon"].ToString();
						int goodsNumber = int.Parse(PDSDK.goodlistjson[i]["goods_number"].ToString());
						string goodsDes = PDSDK.goodlistjson[i]["goods_describe"].ToString();
						double goodsPrice = double.Parse(PDSDK.goodlistjson[i]["goods_price"].ToString());
						int num = int.Parse(PDSDK.goodlistjson[i]["type"].ToString());
						string goodsRegisterId = PDSDK.goodlistjson[i]["goods_register_id"].ToString();
						string text8 = PDSDK.goodlistjson[i]["goods_name"].ToString();
						if (GUILayout.Button("商品名称:" + text8, new GUILayoutOption[]
						{
							GUILayout.Height(100f),
							GUILayout.Width(200f)
						}))
						{
							PDSDK.Instance.DoPay(text8, goodsNumber, goodsId, goodsRegisterId, goodsPrice, "我是透传", goodsDes);
						}
					}
				}
				if (GUILayout.Button("getbattery", new GUILayoutOption[]
				{
					GUILayout.Height(100f),
					GUILayout.Width(200f)
				}))
				{
					global::Debug.Log(" getbattery  begin");
					int battery = PDSDK.Instance.GetBattery();
					string text6 = this.stringToEdit;
					this.stringToEdit = string.Concat(new object[]
					{
						text6,
						" Battery is ",
						battery,
						"\n"
					});
				}
				if (GUILayout.Button("WebInvestigation", new GUILayoutOption[]
				{
					GUILayout.Height(100f),
					GUILayout.Width(200f)
				}))
				{
				}
				if (GUILayout.Button("Doshare", new GUILayoutOption[]
				{
					GUILayout.Height(100f),
					GUILayout.Width(200f)
				}))
				{
					global::Debug.Log(" Doshare  begin");
					JsonData jsonData2 = new JsonData();
					jsonData2["Title"] = "这是分享的标题";
					jsonData2["TitleUrl"] = "http://q.zilongame.com/";
					jsonData2["Text"] = "这是分享的正文";
					jsonData2["ImagePath"] = "sdcard/image.jpg";
					jsonData2["SiteUrl"] = "http://q.zilongame.com/";
					jsonData2["Url"] = "http://q.zilongame.com/";
					jsonData2["shareType"] = 3;
					PDSDK.Instance.doshare(jsonData2.ToJson());
				}
				GUILayout.EndHorizontal();
				GUILayout.BeginHorizontal("button", new GUILayoutOption[0]);
				if (GUILayout.Button("开始录屏", new GUILayoutOption[]
				{
					GUILayout.Height(100f),
					GUILayout.Width(200f)
				}))
				{
					PDSDK.Instance.doStartRecord();
				}
				if (GUILayout.Button("停止录屏", new GUILayoutOption[]
				{
					GUILayout.Height(100f),
					GUILayout.Width(200f)
				}))
				{
					PDSDK.Instance.doStopRecord();
				}
				if (GUILayout.Button("开启直播", new GUILayoutOption[]
				{
					GUILayout.Height(100f),
					GUILayout.Width(200f)
				}))
				{
					PDSDK.Instance.doBoradcast();
				}
				if (GUILayout.Button("获取渠道ID", new GUILayoutOption[]
				{
					GUILayout.Height(100f),
					GUILayout.Width(200f)
				}))
				{
					PDSDK.Instance.getChannelID();
				}
				if (GUILayout.Button("保存图片", new GUILayoutOption[]
				{
					GUILayout.Height(100f),
					GUILayout.Width(200f)
				}))
				{
					PDSDK.Instance.doSaveImageToPhotoLibrary("2222");
				}
				if (GUILayout.Button("通用web接口", new GUILayoutOption[]
				{
					GUILayout.Height(100f),
					GUILayout.Width(200f)
				}))
				{
					string title2 = "测试";
					string action = "index";
					string customparams = "strCm";
					PDSDK.Instance.callWebView(title2, 0, 1, action, customparams);
				}
				GUILayout.EndHorizontal();
				this.stringToEdit = GUILayout.TextField(this.stringToEdit, new GUILayoutOption[]
				{
					GUILayout.Height(700f),
					GUILayout.Width(1080f)
				});
			}
		}

		// Token: 0x17003EB2 RID: 16050
		// (get) Token: 0x060157FE RID: 88062 RVA: 0x0057711C File Offset: 0x0057531C
		// (set) Token: 0x060157FF RID: 88063 RVA: 0x0057713C File Offset: 0x0057533C
		[DoNotToLua]
		public PDSDK.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new PDSDK.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06015801 RID: 88065 RVA: 0x0057714C File Offset: 0x0057534C
		private bool InitHotFix(LuaTable A_1)
		{
			this.m_luaObjHelper = new BJLuaObjHelper();
			this.m_luaObjHelper.InitInCS(this, A_1);
			LuaFunction luaFunction = A_1.RawGet("HotFixObject") as LuaFunction;
			bool result;
			if (luaFunction == null)
			{
				global::Debug.LogError("Can't find HotFixObject Func");
				result = false;
			}
			else
			{
				luaFunction.call(new object[]
				{
					this,
					this.m_luaObjHelper
				});
				LuaTable luaObj = this.m_luaObjHelper.GetLuaObj();
				if (luaObj == null)
				{
					result = false;
				}
				else
				{
					this.m_get_PDAndroidChannelID_hotfix = (luaObj.RawGet("get_PDAndroidChannelID") as LuaFunction);
					this.m_get_PDYingYongBaoChannelID_hotfix = (luaObj.RawGet("get_PDYingYongBaoChannelID") as LuaFunction);
					this.m_get_PDOppoChannelID_hotfix = (luaObj.RawGet("get_PDOppoChannelID") as LuaFunction);
					this.m_get_IOSChannelID_hotfix = (luaObj.RawGet("get_IOSChannelID") as LuaFunction);
					this.m_get_DownloadClientURL_hotfix = (luaObj.RawGet("get_DownloadClientURL") as LuaFunction);
					this.m_PerformIEnumeratorAction_hotfix = (luaObj.RawGet("Perform") as LuaFunction);
					this.m_onWebViewOpen_hotfix = (luaObj.RawGet("onWebViewOpen") as LuaFunction);
					this.m_onWebViewClose_hotfix = (luaObj.RawGet("onWebViewClose") as LuaFunction);
					this.m_Awake_hotfix = (luaObj.RawGet("Awake") as LuaFunction);
					this.m_Update_hotfix = (luaObj.RawGet("Update") as LuaFunction);
					this.m_Init_hotfix = (luaObj.RawGet("Init") as LuaFunction);
					this.m_LoginString_hotfix = (luaObj.RawGet("Login") as LuaFunction);
					this.m_LogoutString_hotfix = (luaObj.RawGet("Logout") as LuaFunction);
					this.m_StartGameString_hotfix = (luaObj.RawGet("StartGame") as LuaFunction);
					this.m_GetProductsList_hotfix = (luaObj.RawGet("GetProductsList") as LuaFunction);
					this.m_DoPromotingPayStringInt32StringStringDoubleStringString_hotfix = (luaObj.RawGet("DoPromotingPay") as LuaFunction);
					this.m_onSDKPromotingPaySuccessString_hotfix = (luaObj.RawGet("onSDKPromotingPaySuccess") as LuaFunction);
					this.m_onSDKPromotingPayFailedString_hotfix = (luaObj.RawGet("onSDKPromotingPayFailed") as LuaFunction);
					this.m_onSDKPromotingPayCancelString_hotfix = (luaObj.RawGet("onSDKPromotingPayCancel") as LuaFunction);
					this.m_DoPayStringInt32StringStringDoubleStringString_hotfix = (luaObj.RawGet("DoPay") as LuaFunction);
					this.m_doAddLocalPushStringStringStringStringString_hotfix = (luaObj.RawGet("doAddLocalPush") as LuaFunction);
					this.m_doFirstScreen_hotfix = (luaObj.RawGet("doFirstScreen") as LuaFunction);
					this.m_SwitchUser_hotfix = (luaObj.RawGet("SwitchUser") as LuaFunction);
					this.m_userCenter_hotfix = (luaObj.RawGet("userCenter") as LuaFunction);
					this.m_exit_hotfix = (luaObj.RawGet("exit") as LuaFunction);
					this.m_GetPustToken_hotfix = (luaObj.RawGet("GetPustToken") as LuaFunction);
					this.m_GetDeviceID_hotfix = (luaObj.RawGet("GetDeviceID") as LuaFunction);
					this.m_GetBattery_hotfix = (luaObj.RawGet("GetBattery") as LuaFunction);
					this.m_OpenInvestigationInt32_hotfix = (luaObj.RawGet("OpenInvestigation") as LuaFunction);
					this.m_PathOrder_hotfix = (luaObj.RawGet("PathOrder") as LuaFunction);
					this.m_ShowPayHelp_hotfix = (luaObj.RawGet("ShowPayHelp") as LuaFunction);
					this.m_printGameEventLogStringString_hotfix = (luaObj.RawGet("printGameEventLog") as LuaFunction);
					this.m_doSetExtDataStringString_hotfix = (luaObj.RawGet("doSetExtData") as LuaFunction);
					this.m_doStartQRLoginString_hotfix = (luaObj.RawGet("doStartQRLogin") as LuaFunction);
					this.m_getChannelID_hotfix = (luaObj.RawGet("getChannelID") as LuaFunction);
					this.m_doSaveImageToPhotoLibraryString_hotfix = (luaObj.RawGet("doSaveImageToPhotoLibrary") as LuaFunction);
					this.m_doQQVIP_hotfix = (luaObj.RawGet("doQQVIP") as LuaFunction);
					this.m_callWebViewStringInt32Int32StringString_hotfix = (luaObj.RawGet("callWebView") as LuaFunction);
					this.m_clearLocalNotifications_hotfix = (luaObj.RawGet("clearLocalNotifications") as LuaFunction);
					this.m_callCustomerServiceWeb_hotfix = (luaObj.RawGet("callCustomerServiceWeb") as LuaFunction);
					this.m_doshareString_hotfix = (luaObj.RawGet("doshare") as LuaFunction);
					this.m_doStartRecord_hotfix = (luaObj.RawGet("doStartRecord") as LuaFunction);
					this.m_doStopRecord_hotfix = (luaObj.RawGet("doStopRecord") as LuaFunction);
					this.m_doBoradcast_hotfix = (luaObj.RawGet("doBoradcast") as LuaFunction);
					this.m_doOpenRequestReview_hotfix = (luaObj.RawGet("doOpenRequestReview") as LuaFunction);
					this.m_onLoginSuccessString_hotfix = (luaObj.RawGet("onLoginSuccess") as LuaFunction);
					this.m_onLoginFailedString_hotfix = (luaObj.RawGet("onLoginFailed") as LuaFunction);
					this.m_onLoginCancelString_hotfix = (luaObj.RawGet("onLoginCancel") as LuaFunction);
					this.m_onQRLoginSuccessString_hotfix = (luaObj.RawGet("onQRLoginSuccess") as LuaFunction);
					this.m_onQRLoginFailedString_hotfix = (luaObj.RawGet("onQRLoginFailed") as LuaFunction);
					this.m_onQRLoginCancelString_hotfix = (luaObj.RawGet("onQRLoginCancel") as LuaFunction);
					this.m_onLogoutSuccessString_hotfix = (luaObj.RawGet("onLogoutSuccess") as LuaFunction);
					this.m_onLogoutFailedString_hotfix = (luaObj.RawGet("onLogoutFailed") as LuaFunction);
					this.m_onLogoutCancelString_hotfix = (luaObj.RawGet("onLogoutCancel") as LuaFunction);
					this.m_onGetProductsListSuccessString_hotfix = (luaObj.RawGet("onGetProductsListSuccess") as LuaFunction);
					this.m_onGetProductsListFailedString_hotfix = (luaObj.RawGet("onGetProductsListFailed") as LuaFunction);
					this.m_onPaySuccessString_hotfix = (luaObj.RawGet("onPaySuccess") as LuaFunction);
					this.m_onPayFailedString_hotfix = (luaObj.RawGet("onPayFailed") as LuaFunction);
					this.m_onPayCancelString_hotfix = (luaObj.RawGet("onPayCancel") as LuaFunction);
					this.m_onGetPayHistorySuccessString_hotfix = (luaObj.RawGet("onGetPayHistorySuccess") as LuaFunction);
					this.m_onGetPayHistoryFailedString_hotfix = (luaObj.RawGet("onGetPayHistoryFailed") as LuaFunction);
					this.m_onInitSuccessString_hotfix = (luaObj.RawGet("onInitSuccess") as LuaFunction);
					this.m_onInitFailedString_hotfix = (luaObj.RawGet("onInitFailed") as LuaFunction);
					this.m_onswitchUserSuccessString_hotfix = (luaObj.RawGet("onswitchUserSuccess") as LuaFunction);
					this.m_onswitchUserFailedString_hotfix = (luaObj.RawGet("onswitchUserFailed") as LuaFunction);
					this.m_onswitchUserCancelString_hotfix = (luaObj.RawGet("onswitchUserCancel") as LuaFunction);
					this.m_onVerifyTokenSuccessString_hotfix = (luaObj.RawGet("onVerifyTokenSuccess") as LuaFunction);
					this.m_onVerifyTokenFailedString_hotfix = (luaObj.RawGet("onVerifyTokenFailed") as LuaFunction);
					this.m_onDoSetExtDataSuccessString_hotfix = (luaObj.RawGet("onDoSetExtDataSuccess") as LuaFunction);
					this.m_onDoSetExtDataFailedString_hotfix = (luaObj.RawGet("onDoSetExtDataFailed") as LuaFunction);
					this.m_onExitSuccessString_hotfix = (luaObj.RawGet("onExitSuccess") as LuaFunction);
					this.m_onExitFailedString_hotfix = (luaObj.RawGet("onExitFailed") as LuaFunction);
					this.m_onMemoryWarningString_hotfix = (luaObj.RawGet("onMemoryWarning") as LuaFunction);
					this.m_onShareSuccessString_hotfix = (luaObj.RawGet("onShareSuccess") as LuaFunction);
					this.m_onShareFailedString_hotfix = (luaObj.RawGet("onShareFailed") as LuaFunction);
					this.m_onShareCancelString_hotfix = (luaObj.RawGet("onShareCancel") as LuaFunction);
					this.m_onRecordStartSuccessString_hotfix = (luaObj.RawGet("onRecordStartSuccess") as LuaFunction);
					this.m_onRecordStartFailString_hotfix = (luaObj.RawGet("onRecordStartFail") as LuaFunction);
					this.m_onRecordStopSuccessString_hotfix = (luaObj.RawGet("onRecordStopSuccess") as LuaFunction);
					this.m_onRecordStopFailString_hotfix = (luaObj.RawGet("onRecordStopFail") as LuaFunction);
					this.m_onBoradcastSuccessString_hotfix = (luaObj.RawGet("onBoradcastSuccess") as LuaFunction);
					this.m_onBoradcastFailString_hotfix = (luaObj.RawGet("onBoradcastFail") as LuaFunction);
					this.m_onDoQuestionSuccessString_hotfix = (luaObj.RawGet("onDoQuestionSuccess") as LuaFunction);
					this.m_onDoQuestionFailedString_hotfix = (luaObj.RawGet("onDoQuestionFailed") as LuaFunction);
					this.m_oncallWebViewSuccessString_hotfix = (luaObj.RawGet("oncallWebViewSuccess") as LuaFunction);
					this.m_oncallWebViewFailedString_hotfix = (luaObj.RawGet("oncallWebViewFailed") as LuaFunction);
					this.m_oncallWebViewCancelString_hotfix = (luaObj.RawGet("oncallWebViewCancel") as LuaFunction);
					this.m_onDoSaveImageToPhotoLibrarySuccessString_hotfix = (luaObj.RawGet("onDoSaveImageToPhotoLibrarySuccess") as LuaFunction);
					this.m_onDoSaveImageToPhotoLibraryFailedString_hotfix = (luaObj.RawGet("onDoSaveImageToPhotoLibraryFailed") as LuaFunction);
					this.m_showAndroidToastString_hotfix = (luaObj.RawGet("showAndroidToast") as LuaFunction);
					this.m_verifyTokenString_hotfix = (luaObj.RawGet("verifyToken") as LuaFunction);
					this.m_OnGUI_hotfix = (luaObj.RawGet("OnGUI") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06015802 RID: 88066 RVA: 0x00577AFC File Offset: 0x00575CFC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(PDSDK));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400BB5C RID: 47964
		public bool isDebug = true;

		// Token: 0x0400BB5D RID: 47965
		public bool isVerfy = true;

		// Token: 0x0400BB5E RID: 47966
		public static JsonData goodlistjson;

		// Token: 0x0400BB5F RID: 47967
		public string promotingPayGoodsRegisterID = string.Empty;

		// Token: 0x0400BB60 RID: 47968
		public string stringToEdit = string.Empty;

		// Token: 0x0400BB61 RID: 47969
		public bool isExitSuccess;

		// Token: 0x0400BB62 RID: 47970
		public bool m_isCallWebView;

		// Token: 0x0400BB63 RID: 47971
		private static bool isLogin;

		// Token: 0x0400BB64 RID: 47972
		private static bool _isLogining;

		// Token: 0x0400BB65 RID: 47973
		private static bool _isLogouting;

		// Token: 0x0400BB66 RID: 47974
		private static bool isInit;

		// Token: 0x0400BB67 RID: 47975
		private static bool _isIosReview;

		// Token: 0x0400BB68 RID: 47976
		private static PDSDK _instance;

		// Token: 0x0400BB69 RID: 47977
		public static Action<LoginSuccessMsg> m_eventLoginSuccess;

		// Token: 0x0400BB6A RID: 47978
		public static Action<LoginSuccessMsg> m_eventOnSwitchUserSuccess;

		// Token: 0x0400BB6B RID: 47979
		public static Action m_eventLoginFailed;

		// Token: 0x0400BB6C RID: 47980
		public static Action m_eventLogoutSuccess;

		// Token: 0x0400BB6D RID: 47981
		public static Action m_eventInitSuccess;

		// Token: 0x0400BB6E RID: 47982
		public static Action m_eventInitFailed;

		// Token: 0x0400BB6F RID: 47983
		public static Action m_eventDoQuestionSucceed;

		// Token: 0x0400BB70 RID: 47984
		public static Action m_eventDoQuestionFailed;

		// Token: 0x0400BB71 RID: 47985
		public static Action<bool> m_eventOnGetProductsListAck;

		// Token: 0x0400BB72 RID: 47986
		public static Action m_eventOnPaySuccess;

		// Token: 0x0400BB73 RID: 47987
		public static Action m_eventOnPayFailed;

		// Token: 0x0400BB74 RID: 47988
		public static Action m_eventOnPayCancel;

		// Token: 0x0400BB75 RID: 47989
		public Action<string> m_eventOnSDKPromotingPaySuccess;

		// Token: 0x0400BB76 RID: 47990
		public static Action<string> m_eventQRLoginSuccess;

		// Token: 0x0400BB77 RID: 47991
		public static Action<string> m_eventQRLoginFailed;

		// Token: 0x0400BB78 RID: 47992
		public static Action<string> m_eventQRLoginCancel;

		// Token: 0x0400BB79 RID: 47993
		public static Action m_eventOnWebViewOpen;

		// Token: 0x0400BB7A RID: 47994
		public static Action m_eventOnWebViewClose;

		// Token: 0x0400BB7B RID: 47995
		public static Action m_eventOnLowMemoryWarning;

		// Token: 0x0400BB7C RID: 47996
		[DoNotToLua]
		private PDSDK.LuaExportHelper luaExportHelper;

		// Token: 0x0400BB7D RID: 47997
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400BB7E RID: 47998
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400BB7F RID: 47999
		private LuaFunction m_get_PDAndroidChannelID_hotfix;

		// Token: 0x0400BB80 RID: 48000
		private LuaFunction m_get_PDYingYongBaoChannelID_hotfix;

		// Token: 0x0400BB81 RID: 48001
		private LuaFunction m_get_PDOppoChannelID_hotfix;

		// Token: 0x0400BB82 RID: 48002
		private LuaFunction m_get_IOSChannelID_hotfix;

		// Token: 0x0400BB83 RID: 48003
		private LuaFunction m_get_DownloadClientURL_hotfix;

		// Token: 0x0400BB84 RID: 48004
		private LuaFunction m_PerformIEnumeratorAction_hotfix;

		// Token: 0x0400BB85 RID: 48005
		private LuaFunction m_onWebViewOpen_hotfix;

		// Token: 0x0400BB86 RID: 48006
		private LuaFunction m_onWebViewClose_hotfix;

		// Token: 0x0400BB87 RID: 48007
		private LuaFunction m_Awake_hotfix;

		// Token: 0x0400BB88 RID: 48008
		private LuaFunction m_Update_hotfix;

		// Token: 0x0400BB89 RID: 48009
		private LuaFunction m_Init_hotfix;

		// Token: 0x0400BB8A RID: 48010
		private LuaFunction m_LoginString_hotfix;

		// Token: 0x0400BB8B RID: 48011
		private LuaFunction m_LogoutString_hotfix;

		// Token: 0x0400BB8C RID: 48012
		private LuaFunction m_StartGameString_hotfix;

		// Token: 0x0400BB8D RID: 48013
		private LuaFunction m_GetProductsList_hotfix;

		// Token: 0x0400BB8E RID: 48014
		private LuaFunction m_DoPromotingPayStringInt32StringStringDoubleStringString_hotfix;

		// Token: 0x0400BB8F RID: 48015
		private LuaFunction m_onSDKPromotingPaySuccessString_hotfix;

		// Token: 0x0400BB90 RID: 48016
		private LuaFunction m_onSDKPromotingPayFailedString_hotfix;

		// Token: 0x0400BB91 RID: 48017
		private LuaFunction m_onSDKPromotingPayCancelString_hotfix;

		// Token: 0x0400BB92 RID: 48018
		private LuaFunction m_DoPayStringInt32StringStringDoubleStringString_hotfix;

		// Token: 0x0400BB93 RID: 48019
		private LuaFunction m_doAddLocalPushStringStringStringStringString_hotfix;

		// Token: 0x0400BB94 RID: 48020
		private LuaFunction m_doFirstScreen_hotfix;

		// Token: 0x0400BB95 RID: 48021
		private LuaFunction m_SwitchUser_hotfix;

		// Token: 0x0400BB96 RID: 48022
		private LuaFunction m_userCenter_hotfix;

		// Token: 0x0400BB97 RID: 48023
		private LuaFunction m_exit_hotfix;

		// Token: 0x0400BB98 RID: 48024
		private LuaFunction m_GetPustToken_hotfix;

		// Token: 0x0400BB99 RID: 48025
		private LuaFunction m_GetDeviceID_hotfix;

		// Token: 0x0400BB9A RID: 48026
		private LuaFunction m_GetBattery_hotfix;

		// Token: 0x0400BB9B RID: 48027
		private LuaFunction m_OpenInvestigationInt32_hotfix;

		// Token: 0x0400BB9C RID: 48028
		private LuaFunction m_PathOrder_hotfix;

		// Token: 0x0400BB9D RID: 48029
		private LuaFunction m_ShowPayHelp_hotfix;

		// Token: 0x0400BB9E RID: 48030
		private LuaFunction m_printGameEventLogStringString_hotfix;

		// Token: 0x0400BB9F RID: 48031
		private LuaFunction m_doSetExtDataStringString_hotfix;

		// Token: 0x0400BBA0 RID: 48032
		private LuaFunction m_doStartQRLoginString_hotfix;

		// Token: 0x0400BBA1 RID: 48033
		private LuaFunction m_getChannelID_hotfix;

		// Token: 0x0400BBA2 RID: 48034
		private LuaFunction m_doSaveImageToPhotoLibraryString_hotfix;

		// Token: 0x0400BBA3 RID: 48035
		private LuaFunction m_doQQVIP_hotfix;

		// Token: 0x0400BBA4 RID: 48036
		private LuaFunction m_callWebViewStringInt32Int32StringString_hotfix;

		// Token: 0x0400BBA5 RID: 48037
		private LuaFunction m_clearLocalNotifications_hotfix;

		// Token: 0x0400BBA6 RID: 48038
		private LuaFunction m_callCustomerServiceWeb_hotfix;

		// Token: 0x0400BBA7 RID: 48039
		private LuaFunction m_doshareString_hotfix;

		// Token: 0x0400BBA8 RID: 48040
		private LuaFunction m_doStartRecord_hotfix;

		// Token: 0x0400BBA9 RID: 48041
		private LuaFunction m_doStopRecord_hotfix;

		// Token: 0x0400BBAA RID: 48042
		private LuaFunction m_doBoradcast_hotfix;

		// Token: 0x0400BBAB RID: 48043
		private LuaFunction m_doOpenRequestReview_hotfix;

		// Token: 0x0400BBAC RID: 48044
		private LuaFunction m_onLoginSuccessString_hotfix;

		// Token: 0x0400BBAD RID: 48045
		private LuaFunction m_onLoginFailedString_hotfix;

		// Token: 0x0400BBAE RID: 48046
		private LuaFunction m_onLoginCancelString_hotfix;

		// Token: 0x0400BBAF RID: 48047
		private LuaFunction m_onQRLoginSuccessString_hotfix;

		// Token: 0x0400BBB0 RID: 48048
		private LuaFunction m_onQRLoginFailedString_hotfix;

		// Token: 0x0400BBB1 RID: 48049
		private LuaFunction m_onQRLoginCancelString_hotfix;

		// Token: 0x0400BBB2 RID: 48050
		private LuaFunction m_onLogoutSuccessString_hotfix;

		// Token: 0x0400BBB3 RID: 48051
		private LuaFunction m_onLogoutFailedString_hotfix;

		// Token: 0x0400BBB4 RID: 48052
		private LuaFunction m_onLogoutCancelString_hotfix;

		// Token: 0x0400BBB5 RID: 48053
		private LuaFunction m_onGetProductsListSuccessString_hotfix;

		// Token: 0x0400BBB6 RID: 48054
		private LuaFunction m_onGetProductsListFailedString_hotfix;

		// Token: 0x0400BBB7 RID: 48055
		private LuaFunction m_onPaySuccessString_hotfix;

		// Token: 0x0400BBB8 RID: 48056
		private LuaFunction m_onPayFailedString_hotfix;

		// Token: 0x0400BBB9 RID: 48057
		private LuaFunction m_onPayCancelString_hotfix;

		// Token: 0x0400BBBA RID: 48058
		private LuaFunction m_onGetPayHistorySuccessString_hotfix;

		// Token: 0x0400BBBB RID: 48059
		private LuaFunction m_onGetPayHistoryFailedString_hotfix;

		// Token: 0x0400BBBC RID: 48060
		private LuaFunction m_onInitSuccessString_hotfix;

		// Token: 0x0400BBBD RID: 48061
		private LuaFunction m_onInitFailedString_hotfix;

		// Token: 0x0400BBBE RID: 48062
		private LuaFunction m_onswitchUserSuccessString_hotfix;

		// Token: 0x0400BBBF RID: 48063
		private LuaFunction m_onswitchUserFailedString_hotfix;

		// Token: 0x0400BBC0 RID: 48064
		private LuaFunction m_onswitchUserCancelString_hotfix;

		// Token: 0x0400BBC1 RID: 48065
		private LuaFunction m_onVerifyTokenSuccessString_hotfix;

		// Token: 0x0400BBC2 RID: 48066
		private LuaFunction m_onVerifyTokenFailedString_hotfix;

		// Token: 0x0400BBC3 RID: 48067
		private LuaFunction m_onDoSetExtDataSuccessString_hotfix;

		// Token: 0x0400BBC4 RID: 48068
		private LuaFunction m_onDoSetExtDataFailedString_hotfix;

		// Token: 0x0400BBC5 RID: 48069
		private LuaFunction m_onExitSuccessString_hotfix;

		// Token: 0x0400BBC6 RID: 48070
		private LuaFunction m_onExitFailedString_hotfix;

		// Token: 0x0400BBC7 RID: 48071
		private LuaFunction m_onMemoryWarningString_hotfix;

		// Token: 0x0400BBC8 RID: 48072
		private LuaFunction m_onShareSuccessString_hotfix;

		// Token: 0x0400BBC9 RID: 48073
		private LuaFunction m_onShareFailedString_hotfix;

		// Token: 0x0400BBCA RID: 48074
		private LuaFunction m_onShareCancelString_hotfix;

		// Token: 0x0400BBCB RID: 48075
		private LuaFunction m_onRecordStartSuccessString_hotfix;

		// Token: 0x0400BBCC RID: 48076
		private LuaFunction m_onRecordStartFailString_hotfix;

		// Token: 0x0400BBCD RID: 48077
		private LuaFunction m_onRecordStopSuccessString_hotfix;

		// Token: 0x0400BBCE RID: 48078
		private LuaFunction m_onRecordStopFailString_hotfix;

		// Token: 0x0400BBCF RID: 48079
		private LuaFunction m_onBoradcastSuccessString_hotfix;

		// Token: 0x0400BBD0 RID: 48080
		private LuaFunction m_onBoradcastFailString_hotfix;

		// Token: 0x0400BBD1 RID: 48081
		private LuaFunction m_onDoQuestionSuccessString_hotfix;

		// Token: 0x0400BBD2 RID: 48082
		private LuaFunction m_onDoQuestionFailedString_hotfix;

		// Token: 0x0400BBD3 RID: 48083
		private LuaFunction m_oncallWebViewSuccessString_hotfix;

		// Token: 0x0400BBD4 RID: 48084
		private LuaFunction m_oncallWebViewFailedString_hotfix;

		// Token: 0x0400BBD5 RID: 48085
		private LuaFunction m_oncallWebViewCancelString_hotfix;

		// Token: 0x0400BBD6 RID: 48086
		private LuaFunction m_onDoSaveImageToPhotoLibrarySuccessString_hotfix;

		// Token: 0x0400BBD7 RID: 48087
		private LuaFunction m_onDoSaveImageToPhotoLibraryFailedString_hotfix;

		// Token: 0x0400BBD8 RID: 48088
		private LuaFunction m_showAndroidToastString_hotfix;

		// Token: 0x0400BBD9 RID: 48089
		private LuaFunction m_verifyTokenString_hotfix;

		// Token: 0x0400BBDA RID: 48090
		private LuaFunction m_OnGUI_hotfix;

		// Token: 0x020010A5 RID: 4261
		public class LuaExportHelper
		{
			// Token: 0x06015803 RID: 88067 RVA: 0x00577B64 File Offset: 0x00575D64
			public LuaExportHelper(PDSDK owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x17003EB3 RID: 16051
			// (get) Token: 0x06015804 RID: 88068 RVA: 0x00577B74 File Offset: 0x00575D74
			// (set) Token: 0x06015805 RID: 88069 RVA: 0x00577B7C File Offset: 0x00575D7C
			public static bool isLogin
			{
				get
				{
					return PDSDK.isLogin;
				}
				set
				{
					PDSDK.isLogin = value;
				}
			}

			// Token: 0x17003EB4 RID: 16052
			// (get) Token: 0x06015806 RID: 88070 RVA: 0x00577B84 File Offset: 0x00575D84
			// (set) Token: 0x06015807 RID: 88071 RVA: 0x00577B8C File Offset: 0x00575D8C
			public static bool _isLogining
			{
				get
				{
					return PDSDK._isLogining;
				}
				set
				{
					PDSDK._isLogining = value;
				}
			}

			// Token: 0x17003EB5 RID: 16053
			// (get) Token: 0x06015808 RID: 88072 RVA: 0x00577B94 File Offset: 0x00575D94
			// (set) Token: 0x06015809 RID: 88073 RVA: 0x00577B9C File Offset: 0x00575D9C
			public static bool _isLogouting
			{
				get
				{
					return PDSDK._isLogouting;
				}
				set
				{
					PDSDK._isLogouting = value;
				}
			}

			// Token: 0x17003EB6 RID: 16054
			// (get) Token: 0x0601580A RID: 88074 RVA: 0x00577BA4 File Offset: 0x00575DA4
			// (set) Token: 0x0601580B RID: 88075 RVA: 0x00577BAC File Offset: 0x00575DAC
			public static bool isInit
			{
				get
				{
					return PDSDK.isInit;
				}
				set
				{
					PDSDK.isInit = value;
				}
			}

			// Token: 0x17003EB7 RID: 16055
			// (get) Token: 0x0601580C RID: 88076 RVA: 0x00577BB4 File Offset: 0x00575DB4
			// (set) Token: 0x0601580D RID: 88077 RVA: 0x00577BBC File Offset: 0x00575DBC
			public static bool _isIosReview
			{
				get
				{
					return PDSDK._isIosReview;
				}
				set
				{
					PDSDK._isIosReview = value;
				}
			}

			// Token: 0x17003EB8 RID: 16056
			// (get) Token: 0x0601580E RID: 88078 RVA: 0x00577BC4 File Offset: 0x00575DC4
			// (set) Token: 0x0601580F RID: 88079 RVA: 0x00577BCC File Offset: 0x00575DCC
			public static PDSDK _instance
			{
				get
				{
					return PDSDK._instance;
				}
				set
				{
					PDSDK._instance = value;
				}
			}

			// Token: 0x06015810 RID: 88080 RVA: 0x00577BD4 File Offset: 0x00575DD4
			public IEnumerator Perform(IEnumerator coroutine, Action onComplete)
			{
				return this.m_owner.Perform(coroutine, onComplete);
			}

			// Token: 0x06015811 RID: 88081 RVA: 0x00577BE4 File Offset: 0x00575DE4
			public void Awake()
			{
				this.m_owner.Awake();
			}

			// Token: 0x06015812 RID: 88082 RVA: 0x00577BF4 File Offset: 0x00575DF4
			public void Update()
			{
				this.m_owner.Update();
			}

			// Token: 0x06015813 RID: 88083 RVA: 0x00577C04 File Offset: 0x00575E04
			public void onQRLoginSuccess(string msg)
			{
				this.m_owner.onQRLoginSuccess(msg);
			}

			// Token: 0x06015814 RID: 88084 RVA: 0x00577C14 File Offset: 0x00575E14
			public void onQRLoginFailed(string msg)
			{
				this.m_owner.onQRLoginFailed(msg);
			}

			// Token: 0x06015815 RID: 88085 RVA: 0x00577C24 File Offset: 0x00575E24
			public void onQRLoginCancel(string msg)
			{
				this.m_owner.onQRLoginCancel(msg);
			}

			// Token: 0x0400BBDB RID: 48091
			private PDSDK m_owner;
		}
	}
}
