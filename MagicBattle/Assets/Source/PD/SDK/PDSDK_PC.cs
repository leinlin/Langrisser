using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using Awesomium.Core;
using Awesomium.Unity;
using Ionic.Zip;
using UnityEngine;

namespace PD.SDK
{
	// Token: 0x020010A8 RID: 4264
	public class PDSDK_PC
	{
		// Token: 0x17003EBB RID: 16059
		// (get) Token: 0x06015820 RID: 88096 RVA: 0x00577D8C File Offset: 0x00575F8C
		private static string LoginUrl
		{
			get
			{
				if (PDSDK_PC.getCommonProperty("debug_mode", "0") == "1")
				{
					if (PDSDK_PC.getCommonProperty("platform", "Zlongame") == "GameBeans")
					{
						return PDSDK_PC.getCommonProperty("debug_account_url", string.Empty) + "/passport/main.game-beans?action=qr";
					}
					return PDSDK_PC.getCommonProperty("debug_account_url", string.Empty) + "/passport/main.zlongame?action=qr";
				}
				else
				{
					if (PDSDK_PC.getCommonProperty("platform", "Zlongame") == "GameBeans")
					{
						return "https://member.game-beans.com/passport/main.game-beans?action=qr";
					}
					return "https://member.zlongame.com/passport/main.zlongame?action=qr";
				}
			}
		}

		// Token: 0x17003EBC RID: 16060
		// (get) Token: 0x06015821 RID: 88097 RVA: 0x00577E34 File Offset: 0x00576034
		private static string UsercenterUrl
		{
			get
			{
				if (PDSDK_PC.getCommonProperty("debug_mode", "0") == "1")
				{
					if (PDSDK_PC.getCommonProperty("platform", "Zlongame") == "GameBeans")
					{
						return PDSDK_PC.getCommonProperty("debug_account_url", string.Empty) + "/passport/profile.game-beans?action=index";
					}
					return PDSDK_PC.getCommonProperty("debug_account_url", string.Empty) + "/passport/profile_ball.zlongame?action=index";
				}
				else
				{
					if (PDSDK_PC.getCommonProperty("platform", "Zlongame") == "GameBeans")
					{
						return "https://member.game-beans.com/passport/profile.game-beans?action=index";
					}
					return "https://member.zlongame.com/passport/profile_ball.zlongame?action=index";
				}
			}
		}

		// Token: 0x17003EBD RID: 16061
		// (get) Token: 0x06015822 RID: 88098 RVA: 0x00577EDC File Offset: 0x005760DC
		private static string WebInvestigationUrl
		{
			get
			{
				if (PDSDK_PC.getCommonProperty("debug_mode", "0") == "1")
				{
					return PDSDK_PC.getCommonProperty("debug_webview_url", string.Empty) + "/html/dispatch/list.html";
				}
				if (PDSDK_PC.getCommonProperty("platform", "Zlongame") == "GameBeans")
				{
					return "http://www.game-beans.com/html/dispatch/list.html";
				}
				return "http://www.zlongame.com/html/dispatch/list.html";
			}
		}

		// Token: 0x17003EBE RID: 16062
		// (get) Token: 0x06015823 RID: 88099 RVA: 0x00577F4C File Offset: 0x0057614C
		private static string BaseWebUrl
		{
			get
			{
				if (PDSDK_PC.getCommonProperty("debug_mode", "0") == "1")
				{
					return PDSDK_PC.getCommonProperty("debug_webview_url", string.Empty) + "/html/dispatch/list.html";
				}
				if (PDSDK_PC.getCommonProperty("platform", "Zlongame") == "GameBeans")
				{
					return "https://www.game-beans.com/html/dispatch/list.html";
				}
				return "https://www.zlongame.com/html/dispatch/list.html";
			}
		}

		// Token: 0x17003EBF RID: 16063
		// (get) Token: 0x06015824 RID: 88100 RVA: 0x00577FBC File Offset: 0x005761BC
		private static string GetProductsListUrl
		{
			get
			{
				string text = string.Empty;
				if (PDSDK_PC.getCommonProperty("app_key", string.Empty) != PDSDK_PC.qqhAppkey)
				{
					text = "/" + PDSDK_PC.getCommonProperty("app_key", string.Empty);
				}
				if (PDSDK_PC.getCommonProperty("debug_mode", "0") == "1")
				{
					return PDSDK_PC.getCommonProperty("debug_billing_url", string.Empty) + "/sdk-service" + text + "/goods/goodslist.json";
				}
				if (PDSDK_PC.getCommonProperty("platform", "Zlongame") == "GameBeans")
				{
					return "http://billing.game-beans.com:8081/sdk-service" + text + "/goods/goodslist.json";
				}
				return "http://billing.zlongame.com:8081/sdk-service" + text + "/goods/goodslist.json";
			}
		}

		// Token: 0x17003EC0 RID: 16064
		// (get) Token: 0x06015825 RID: 88101 RVA: 0x00578084 File Offset: 0x00576284
		private static string BillingCreateOrderUrl
		{
			get
			{
				string text = string.Empty;
				if (PDSDK_PC.getCommonProperty("app_key", string.Empty) != PDSDK_PC.qqhAppkey)
				{
					text = "/" + PDSDK_PC.getCommonProperty("app_key", string.Empty);
				}
				if (PDSDK_PC.getCommonProperty("debug_mode", "0") == "1")
				{
					return PDSDK_PC.getCommonProperty("debug_billing_url", string.Empty) + "/sdk-service" + text + "/order/serverCreate.json";
				}
				if (PDSDK_PC.getCommonProperty("platform", "Zlongame") == "GameBeans")
				{
					return "http://billing.game-beans.com:8081/sdk-service" + text + "/order/serverCreate.json";
				}
				return "http://billing.zlongame.com:8081/sdk-service" + text + "/order/serverCreate.json";
			}
		}

		// Token: 0x17003EC1 RID: 16065
		// (get) Token: 0x06015826 RID: 88102 RVA: 0x0057814C File Offset: 0x0057634C
		private static string OrderPayUrl
		{
			get
			{
				if (PDSDK_PC.getCommonProperty("debug_mode", "0") == "1")
				{
					return string.Concat(new string[]
					{
						PDSDK_PC.getCommonProperty("debug_pay_url", string.Empty),
						"/pay-service/pcpay/create/",
						PDSDK_PC.getCommonProperty("app_key", string.Empty),
						"/",
						PDSDK_PC.getCommonProperty("channel_id", string.Empty)
					});
				}
				if (PDSDK_PC.getCommonProperty("platform", "Zlongame") == "GameBeans")
				{
					return "http://pay.game-beans.com:8081/pay-service/pcpay/create/" + PDSDK_PC.getCommonProperty("app_key", string.Empty) + "/" + PDSDK_PC.getCommonProperty("channel_id", string.Empty);
				}
				return "http://pay.zlongame.com:8081/pay-service/pcpay/create/" + PDSDK_PC.getCommonProperty("app_key", string.Empty) + "/" + PDSDK_PC.getCommonProperty("channel_id", string.Empty);
			}
		}

		// Token: 0x17003EC2 RID: 16066
		// (get) Token: 0x06015827 RID: 88103 RVA: 0x00578244 File Offset: 0x00576444
		private static string GetNewVersionUrl
		{
			get
			{
				string text = string.Empty;
				if (PDSDK_PC.getCommonProperty("app_key", string.Empty) != PDSDK_PC.qqhAppkey)
				{
					text = "/" + PDSDK_PC.getCommonProperty("app_key", string.Empty);
				}
				if (PDSDK_PC.getCommonProperty("debug_mode", "0") == "1")
				{
					return PDSDK_PC.getCommonProperty("debug_billing_url", string.Empty) + "/sdk-service" + text + "/version/getNewVersion.json";
				}
				if (PDSDK_PC.getCommonProperty("platform", "Zlongame") == "GameBeans")
				{
					return "http://billing.game-beans.com:8081/sdk-service" + text + "/version/getNewVersion.json";
				}
				return "http://billing.zlongame.com:8081/sdk-service" + text + "/version/getNewVersion.json";
			}
		}

		// Token: 0x17003EC3 RID: 16067
		// (get) Token: 0x06015828 RID: 88104 RVA: 0x0057830C File Offset: 0x0057650C
		private static string WxCreateOrderUrl
		{
			get
			{
				string text = "/" + PDSDK_PC.getCommonProperty("app_key", string.Empty);
				if (PDSDK_PC.getCommonProperty("debug_mode", "0") == "1")
				{
					return PDSDK_PC.getCommonProperty("debug_pay_url", string.Empty) + "/pay-service/pay/create" + text + "/wechatweb";
				}
				if (PDSDK_PC.getCommonProperty("platform", "Zlongame") == "GameBeans")
				{
					return "http://pay.game-beans.com:8081/pay-service/pay/create" + text + "/wechatweb";
				}
				return "http://pay.zlongame.com:8081/pay-service/pay/create" + text + "/wechatweb";
			}
		}

		// Token: 0x17003EC4 RID: 16068
		// (get) Token: 0x06015829 RID: 88105 RVA: 0x005783B0 File Offset: 0x005765B0
		private static string WxQrcodeUrl
		{
			get
			{
				if (PDSDK_PC.getCommonProperty("debug_mode", "0") == "1")
				{
					return PDSDK_PC.getCommonProperty("debug_account_url", string.Empty) + "/passport/redirect_login.zlongame?action=payPage";
				}
				if (PDSDK_PC.getCommonProperty("platform", "Zlongame") == "GameBeans")
				{
					return "http://account.game-beans.com:9080/passport/redirect_login.zlongame?action=payPage";
				}
				return "http://account.zlongame.com:9080/passport/redirect_login.zlongame?action=payPage";
			}
		}

		// Token: 0x17003EC5 RID: 16069
		// (get) Token: 0x0601582A RID: 88106 RVA: 0x00578420 File Offset: 0x00576620
		private static WebUIComponent WebBrowser
		{
			get
			{
				if (PDSDK_PC.webBrowser == null)
				{
					GameObject gameObject = GameObject.Find("loginwebui");
					if (gameObject)
					{
						PDSDK_PC.webBrowser = gameObject.GetComponent<WebUIComponent>();
					}
				}
				return PDSDK_PC.webBrowser;
			}
		}

		// Token: 0x0601582B RID: 88107 RVA: 0x00578464 File Offset: 0x00576664
		private static void OpenWebBrowser(string url, int w, int h)
		{
			if (PDSDK_PC.webViewEnable == 0)
			{
				return;
			}
			global::Debug.Log("PDSDk_PC.OpenWebBrowser : " + url);
			PDSDK_PC.WebBrowser.Width = w;
			PDSDK_PC.WebBrowser.Height = h;
			PDSDK_PC.WebBrowser.Source = url.ToUri();
			PDSDK_PC.WebBrowser.Visible = true;
			PDSDK_PC.WebBrowser.Focus();
			PDSDK.Instance.onWebViewOpen();
		}

		// Token: 0x0601582C RID: 88108 RVA: 0x005784D4 File Offset: 0x005766D4
		public static void EncryptCommonProperty()
		{
			byte[] array = File.ReadAllBytes(PDSDK_PC.config_path_d);
			global::Debug.Log("PDSDk_PC.EncryptCommonProperty : " + array);
			if (array != null)
			{
				for (int i = 0; i <= array.Length - 1; i++)
				{
					if (i % 2 == 0)
					{
						byte[] array2 = array;
						int num = i;
						array2[num] ^= 100;
					}
					else
					{
						byte[] array3 = array;
						int num2 = i;
						array3[num2] ^= 55;
					}
				}
				File.WriteAllBytes(PDSDK_PC.config_path, array);
			}
		}

		// Token: 0x0601582D RID: 88109 RVA: 0x0057854C File Offset: 0x0057674C
		public static void Init()
		{
			byte[] array = null;
			try
			{
				array = File.ReadAllBytes(PDSDK_PC.config_path_d);
			}
			catch (FileNotFoundException)
			{
				global::Debug.Log("PDSDk_PC.Init FileNotFoundException : " + PDSDK_PC.config_path_d);
				try
				{
					array = File.ReadAllBytes(PDSDK_PC.config_path);
					for (int i = 0; i <= array.Length - 1; i++)
					{
						if (i % 2 == 0)
						{
							byte[] array2 = array;
							int num = i;
							array2[num] ^= 100;
						}
						else
						{
							byte[] array3 = array;
							int num2 = i;
							array3[num2] ^= 55;
						}
					}
				}
				catch (FileNotFoundException)
				{
					global::Debug.Log("PDSDk_PC.Init FileNotFoundException : " + PDSDK_PC.config_path);
					array = null;
				}
				finally
				{
				}
			}
			finally
			{
			}
			if (array == null)
			{
				return;
			}
			string @string = Encoding.UTF8.GetString(array);
			PDSDK_PC.commonPropertyJson = JsonMapper.ToObject(@string);
			PDSDK_PC.PrintActiveLog();
			PDSDK.DoCoroutine(PDSDK_PC.GET_NEWVERSION(PDSDK_PC.GetNewVersionUrl), null);
			JsonData jsonData = new JsonData();
			jsonData["state_code"] = "400";
			jsonData["message"] = "pcinitsuccess";
			jsonData["data"] = string.Empty;
			PDSDK.Instance.onInitSuccess(jsonData.ToJson());
		}

		// Token: 0x0601582E RID: 88110 RVA: 0x005786B0 File Offset: 0x005768B0
		public static void setCommonProperty(string pKey, string pValue)
		{
			PDSDK_PC.commonPropertyJson[pKey] = pValue;
		}

		// Token: 0x0601582F RID: 88111 RVA: 0x005786C4 File Offset: 0x005768C4
		public static string getCommonProperty(string pKey, string defaultValue)
		{
			if (PDSDK_PC.commonPropertyJson != null && ((IDictionary)PDSDK_PC.commonPropertyJson).Contains(pKey))
			{
				return (string)PDSDK_PC.commonPropertyJson[pKey];
			}
			return defaultValue;
		}

		// Token: 0x06015830 RID: 88112 RVA: 0x005786F4 File Offset: 0x005768F4
		public static void Login(string customparams)
		{
			global::Debug.Log("PDSDk_PC.Login ");
			string text = PDSDK_PC.LoginUrl;
			text += "&deviceId=";
			text += PDSDK_PC.GetDeviceID();
			text += "&appKey=";
			text += PDSDK_PC.getCommonProperty("app_key", string.Empty);
			text += "&customParams=";
			text += customparams;
			PDSDK_PC.OpenWebBrowser(text, 456, 623);
		}

		// Token: 0x06015831 RID: 88113 RVA: 0x00578770 File Offset: 0x00576970
		public static void Logout(string customparams)
		{
			global::Debug.Log("PDSDk_PC.Logout ");
			JsonData jsonData = new JsonData();
			jsonData["customparams"] = customparams;
			PDSDK.Instance.onLogoutSuccess(jsonData.ToJson());
		}

		// Token: 0x06015832 RID: 88114 RVA: 0x005787B0 File Offset: 0x005769B0
		public static void StartGame(string gameparams)
		{
			global::Debug.Log("PDSDk_PC.StartGame : " + gameparams);
			PDSDK_PC.gameInfo = gameparams;
			PDSDK_PC.PrintLoginLog();
		}

		// Token: 0x06015833 RID: 88115 RVA: 0x005787D0 File Offset: 0x005769D0
		public static void GetProductsList()
		{
			global::Debug.Log("PDSDk_PC.GetProductsList  ");
			PDSDK.DoCoroutine(PDSDK_PC.GET_GOODSLIST(PDSDK_PC.GetProductsListUrl), null);
		}

		// Token: 0x06015834 RID: 88116 RVA: 0x005787EC File Offset: 0x005769EC
		public static void DoPay(string goodsName, int goodsNumber, string goodsId, string goodsRegisterId, double goodsPrice, string customparams, string goodsDes)
		{
			global::Debug.Log("PDSDk_PC.DoPay ");
			PDSDK_PC._goodsName = goodsName;
			PDSDK_PC._goodsNumber = goodsNumber;
			PDSDK_PC._goodsId = goodsId;
			PDSDK_PC._goodsRegisterId = goodsRegisterId;
			PDSDK_PC._goodsPrice = goodsPrice;
			PDSDK_PC._customparams = customparams;
			PDSDK_PC._goodsDes = goodsDes;
			PDSDK.DoCoroutine(PDSDK_PC.GET_CREATORDER(PDSDK_PC.BillingCreateOrderUrl), null);
		}

		// Token: 0x06015835 RID: 88117 RVA: 0x00578840 File Offset: 0x00576A40
		public static void UserCenter()
		{
			global::Debug.Log("PDSDk_PC.UserCenter ");
			if (PDSDK_PC.gameInfo == null || PDSDK_PC.gameInfo.Length == 0)
			{
				return;
			}
			JsonData jsonData = JsonMapper.ToObject(PDSDK_PC.gameInfo);
			string text = string.Empty;
			if (((IDictionary)jsonData).Contains("GameUid"))
			{
				text = (string)jsonData["GameUid"];
				if (PDSDK_PC.testUserId != string.Empty)
				{
					text = PDSDK_PC.testUserId;
				}
			}
			string str = string.Empty;
			if (((IDictionary)jsonData).Contains("RoleId"))
			{
				str = (string)jsonData["RoleId"];
			}
			string str2 = string.Empty;
			if (((IDictionary)jsonData).Contains("RoleLevel"))
			{
				str2 = (string)jsonData["RoleLevel"];
			}
			string str3 = string.Empty;
			if (((IDictionary)jsonData).Contains("ServerId"))
			{
				str3 = (string)jsonData["ServerId"];
			}
			string s = string.Empty;
			if (((IDictionary)jsonData).Contains("ServerName"))
			{
				s = (string)jsonData["ServerName"];
				s = WWW.EscapeURL(s);
			}
			string s2 = string.Empty;
			if (((IDictionary)jsonData).Contains("GameName"))
			{
				s2 = (string)jsonData["GameName"];
				s2 = WWW.EscapeURL(s2);
			}
			int num = 0;
			if (((IDictionary)jsonData).Contains("Balance"))
			{
				num = (int)jsonData["Balance"];
			}
			string s3 = string.Empty;
			if (((IDictionary)jsonData).Contains("PartyName"))
			{
				s3 = (string)jsonData["PartyName"];
				s3 = WWW.EscapeURL(s3);
			}
			int num2 = 0;
			if (((IDictionary)jsonData).Contains("VipLevel"))
			{
				num2 = (int)jsonData["VipLevel"];
			}
			string text2 = PDSDK_PC.UsercenterUrl;
			text2 += "&userid=";
			text2 += text.Substring(12);
			text2 += "&device=";
			text2 += PDSDK_PC.GetDeviceID();
			text2 += "&token=";
			text2 += PDSDK_PC.userToken;
			text2 += "&channelId=";
			text2 += PDSDK_PC.getCommonProperty("channel_id", string.Empty);
			text2 += "&roleid=";
			text2 += str;
			text2 += "&rolelevel=";
			text2 += str2;
			text2 += "&serverid=";
			text2 += str3;
			text2 += "&servername=";
			text2 += WWW.EscapeURL(s);
			text2 += "&gamename=";
			text2 += WWW.EscapeURL(s2);
			text2 += "&balance=";
			text2 += num;
			text2 += "&partyname=";
			text2 += WWW.EscapeURL(s3);
			text2 += "&viplevel=";
			text2 += num2;
			PDSDK_PC.OpenWebBrowser(text2, 1136, 640);
		}

		// Token: 0x06015836 RID: 88118 RVA: 0x00578B88 File Offset: 0x00576D88
		public static void Exit()
		{
			global::Debug.Log("PDSDk_PC.Exit ");
			PDSDK.Instance.onExitSuccess("{\"data\":\"\",\"message\":\"\"}");
		}

		// Token: 0x06015837 RID: 88119 RVA: 0x00578BA4 File Offset: 0x00576DA4
		public static string GetDeviceID()
		{
			if (PDSDK_PC.deviceId == null)
			{
				PDSDK_PC.deviceId = "UNITYPC" + PDSDK_PC.INNER_SEPARATOR + SystemInfo.deviceUniqueIdentifier;
			}
			return PDSDK_PC.deviceId;
		}

		// Token: 0x06015838 RID: 88120 RVA: 0x00578BD0 File Offset: 0x00576DD0
		public static void WebInvestigation()
		{
			if (PDSDK_PC.gameInfo == null || PDSDK_PC.gameInfo.Length == 0)
			{
				return;
			}
			JsonData jsonData = JsonMapper.ToObject(PDSDK_PC.gameInfo);
			string text = string.Empty;
			if (((IDictionary)jsonData).Contains("GameUid"))
			{
				text = (string)jsonData["GameUid"];
				if (PDSDK_PC.testUserId != string.Empty)
				{
					text = PDSDK_PC.testUserId;
				}
			}
			string text2 = string.Empty;
			if (((IDictionary)jsonData).Contains("RoleId"))
			{
				text2 = (string)jsonData["RoleId"];
			}
			string text3 = string.Empty;
			if (((IDictionary)jsonData).Contains("RoleLevel"))
			{
				text3 = (string)jsonData["RoleLevel"];
			}
			string text4 = PDSDK_PC.WebInvestigationUrl;
			string text5 = DateTime.Now.ToString("MM/dd/yy HH:mm:ss");
			string text6 = "ecDzNFx-:$^/ E})K]'#CIXiV";
			string src = PDSDK_PC.Encrypt_MD5(string.Concat(new string[]
			{
				text,
				text2,
				text3,
				text5,
				text6
			}));
			text4 += "?a=";
			text4 += WWW.EscapeURL(WWW.EscapeURL(PDSDK_PC.decode(text, 120)));
			text4 += "&r=";
			text4 += WWW.EscapeURL(WWW.EscapeURL(PDSDK_PC.decode(text2, 8)));
			text4 += "&l=";
			text4 += WWW.EscapeURL(WWW.EscapeURL(PDSDK_PC.decode(text3, 15)));
			text4 += "&s=";
			text4 += WWW.EscapeURL(WWW.EscapeURL(PDSDK_PC.decode(src, 64)));
			text4 += "&t=";
			text4 += WWW.EscapeURL(WWW.EscapeURL(PDSDK_PC.decode(text5, 19)));
			text4 += "&k=";
			text4 += PDSDK_PC.getCommonProperty("app_key", string.Empty);
			text4 += "&c=";
			text4 += PDSDK_PC.getCommonProperty("channel_id", string.Empty);
			PDSDK_PC.OpenWebBrowser(text4, 1136, 640);
		}

		// Token: 0x06015839 RID: 88121 RVA: 0x00578E08 File Offset: 0x00577008
		public static void CallWebView(string title, int fullscreen_flag, int title_flag, string action, string customparams)
		{
			global::Debug.Log("PDSDk_PC.CallWebView ");
			if (PDSDK_PC.gameInfo == null || PDSDK_PC.gameInfo.Length == 0)
			{
				return;
			}
			JsonData jsonData = JsonMapper.ToObject(PDSDK_PC.gameInfo);
			string text = string.Empty;
			if (((IDictionary)jsonData).Contains("GameUid"))
			{
				text = (string)jsonData["GameUid"];
				if (PDSDK_PC.testUserId != string.Empty)
				{
					text = PDSDK_PC.testUserId;
				}
			}
			string text2 = string.Empty;
			if (((IDictionary)jsonData).Contains("RoleId"))
			{
				text2 = (string)jsonData["RoleId"];
			}
			string text3 = string.Empty;
			if (((IDictionary)jsonData).Contains("RoleLevel"))
			{
				text3 = (string)jsonData["RoleLevel"];
			}
			string text4 = string.Empty;
			if (((IDictionary)jsonData).Contains("ServerId"))
			{
				text4 = (string)jsonData["ServerId"];
			}
			string s = string.Empty;
			if (((IDictionary)jsonData).Contains("ServerName"))
			{
				s = (string)jsonData["ServerName"];
				s = WWW.EscapeURL(s);
			}
			string s2 = string.Empty;
			if (((IDictionary)jsonData).Contains("GameName"))
			{
				s2 = (string)jsonData["GameName"];
				s2 = WWW.EscapeURL(s2);
			}
			int num = 0;
			if (((IDictionary)jsonData).Contains("Balance"))
			{
				num = (int)jsonData["Balance"];
			}
			string s3 = string.Empty;
			if (((IDictionary)jsonData).Contains("PartyName"))
			{
				s3 = (string)jsonData["PartyName"];
				s3 = WWW.EscapeURL(s3);
			}
			int num2 = 0;
			if (((IDictionary)jsonData).Contains("VipLevel"))
			{
				num2 = (int)jsonData["VipLevel"];
			}
			string text5 = PDSDK_PC.BaseWebUrl;
			string text6 = DateTime.Now.ToString("MM/dd/yy HH:mm:ss");
			string text7 = "UIwf 8-08e30P)*_)@$e;l23r";
			DateTime d = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));
			long num3 = (long)(DateTime.Now - d).TotalMilliseconds;
			string strPwd = string.Concat(new object[]
			{
				num,
				PDSDK_PC.getCommonProperty("channel_id", string.Empty),
				text2,
				text3,
				text4,
				num2
			});
			string text8 = PDSDK_PC.Encrypt_MD5(strPwd);
			string str = PDSDK_PC.Encrypt_MD5(string.Concat(new object[]
			{
				action,
				num3,
				text8,
				text,
				text7
			}));
			text5 += "?action=";
			text5 += action;
			text5 += "&balance=";
			text5 += num;
			text5 += "&channelId=";
			text5 += PDSDK_PC.getCommonProperty("channel_id", string.Empty);
			text5 += "&device=";
			text5 += PDSDK_PC.GetDeviceID();
			text5 += "&rolename=";
			text5 += WWW.EscapeURL(s2);
			text5 += "&userid=";
			text5 += text;
			text5 += "&roleid=";
			text5 += text2;
			text5 += "&rolelevel=";
			text5 += text3;
			text5 += "&serverid=";
			text5 += text4;
			text5 += "&servername=";
			text5 += WWW.EscapeURL(s);
			text5 += "&viplevel=";
			text5 += num2;
			text5 += "&partyname=";
			text5 += WWW.EscapeURL(s3);
			text5 += "&customparams=";
			text5 += WWW.EscapeURL(customparams);
			text5 += "&t=";
			text5 += num3;
			text5 += "&sign=";
			text5 += str;
			PDSDK_PC._webviewAction = action;
			PDSDK_PC.OpenWebBrowser(text5, 1136, 640);
		}

		// Token: 0x0601583A RID: 88122 RVA: 0x00579264 File Offset: 0x00577464
		public static void callCustomerServiceWeb()
		{
			if (PDSDK_PC.getCommonProperty("platform", "Zlongame") == "GameBeans")
			{
				Application.OpenURL("http://www.game-beans.com/service.html");
			}
			else
			{
				Application.OpenURL("http://www.zlongame.com/html/service.html");
			}
		}

		// Token: 0x0601583B RID: 88123 RVA: 0x005792A0 File Offset: 0x005774A0
		public static void PrintGameEventLog(string eventID, string remark)
		{
			global::Debug.Log("PDSDk_PC.PrintGameEventLog ");
			JsonData jsonData = JsonMapper.ToObject(PDSDK_PC.gameInfo);
			string str = string.Empty;
			if (((IDictionary)jsonData).Contains("GameUid"))
			{
				str = (string)jsonData["GameUid"];
				if (PDSDK_PC.testUserId != string.Empty)
				{
					str = PDSDK_PC.testUserId;
				}
			}
			string str2 = string.Empty;
			if (((IDictionary)jsonData).Contains("ServerId"))
			{
				str2 = (string)jsonData["ServerId"];
			}
			string str3 = DateTime.Now.ToString("yyyyMMddHHmmss");
			string text = string.Empty;
			text = text + PDSDK_PC.getCommonProperty("app_key", string.Empty) + PDSDK_PC.SEPARATOR;
			text = text + PDSDK_PC.mbi_version + PDSDK_PC.SEPARATOR;
			text = text + "win" + PDSDK_PC.SEPARATOR;
			text = text + str2 + PDSDK_PC.SEPARATOR;
			text = text + PDSDK_PC.getCommonProperty("cmbi_channel_id", string.Empty) + PDSDK_PC.SEPARATOR;
			text = text + PDSDK_PC.GetDeviceID() + PDSDK_PC.SEPARATOR;
			text = text + str + PDSDK_PC.SEPARATOR;
			text = text + "V" + PDSDK_PC.mbi_version + PDSDK_PC.SEPARATOR;
			text = text + str3 + PDSDK_PC.SEPARATOR;
			text = text + eventID + PDSDK_PC.SEPARATOR;
			text = text + "winpc" + PDSDK_PC.SEPARATOR;
			text += remark;
			PDSDK_PC.PrintLineToFile(PDSDK_PC.mbi_gameevent, text);
			long ticks = DateTime.Now.Ticks;
			if (ticks > PDSDK_PC.lastSentTicks + 600000000L)
			{
				PDSDK_PC.MakeLogZipAndSend();
			}
		}

		// Token: 0x0601583C RID: 88124 RVA: 0x00579460 File Offset: 0x00577660
		public static void PrintActiveLog()
		{
			global::Debug.Log("PDSDk_PC.PrintActiveLog ");
			string str = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
			string text = string.Empty;
			text = text + str + PDSDK_PC.SEPARATOR;
			text = text + PDSDK_PC.GetDeviceID() + PDSDK_PC.SEPARATOR;
			text = text + PDSDK_PC.getCommonProperty("cmbi_channel_id", string.Empty) + PDSDK_PC.SEPARATOR;
			text = text + PDSDK_PC.mbi_version + PDSDK_PC.SEPARATOR;
			text = text + "0" + PDSDK_PC.SEPARATOR;
			text = text + "0" + PDSDK_PC.SEPARATOR;
			text = text + "0" + PDSDK_PC.SEPARATOR;
			text = text + "800*600" + PDSDK_PC.SEPARATOR;
			text = text + "LAN" + PDSDK_PC.SEPARATOR;
			text = text + "0" + PDSDK_PC.SEPARATOR;
			text = text + "1001" + PDSDK_PC.SEPARATOR;
			text += PDSDK_PC.mbi_version;
			PDSDK_PC.PrintLineToFile(PDSDK_PC.mbi_active, text);
			PDSDK_PC.MakeLogZipAndSend();
		}

		// Token: 0x0601583D RID: 88125 RVA: 0x00579570 File Offset: 0x00577770
		public static void PrintLoginLog()
		{
			global::Debug.Log("PDSDk_PC.PrintLoginLog ");
			string str = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
			string text = string.Empty;
			text = text + str + PDSDK_PC.SEPARATOR;
			text = text + PDSDK_PC.GetDeviceID() + PDSDK_PC.SEPARATOR;
			text = text + PDSDK_PC.getCommonProperty("cmbi_channel_id", string.Empty) + PDSDK_PC.SEPARATOR;
			text = text + PDSDK_PC.mbi_version + PDSDK_PC.SEPARATOR;
			text = text + "0" + PDSDK_PC.SEPARATOR;
			text = text + "0" + PDSDK_PC.SEPARATOR;
			text = text + "0" + PDSDK_PC.SEPARATOR;
			text = text + "800*600" + PDSDK_PC.SEPARATOR;
			text = text + "LAN" + PDSDK_PC.SEPARATOR;
			text = text + "0" + PDSDK_PC.SEPARATOR;
			JsonData jsonData = JsonMapper.ToObject(PDSDK_PC.gameInfo);
			string str2 = string.Empty;
			if (((IDictionary)jsonData).Contains("GameUid"))
			{
				str2 = (string)jsonData["GameUid"];
				if (PDSDK_PC.testUserId != string.Empty)
				{
					str2 = PDSDK_PC.testUserId;
				}
			}
			text = text + str2 + PDSDK_PC.SEPARATOR;
			string str3 = string.Empty;
			if (((IDictionary)jsonData).Contains("ServerId"))
			{
				str3 = (string)jsonData["ServerId"];
			}
			text = text + str3 + PDSDK_PC.SEPARATOR;
			text = text + str2 + PDSDK_PC.SEPARATOR;
			text = text + "2060" + PDSDK_PC.SEPARATOR;
			text += PDSDK_PC.mbi_version;
			PDSDK_PC.PrintLineToFile(PDSDK_PC.mbi_login, text);
			long ticks = DateTime.Now.Ticks;
			if (ticks > PDSDK_PC.lastSentTicks + 600000000L)
			{
				PDSDK_PC.MakeLogZipAndSend();
			}
		}

		// Token: 0x0601583E RID: 88126 RVA: 0x00579744 File Offset: 0x00577944
		public static void PrintOnlineLog()
		{
			string str = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
			string text = string.Empty;
			text = text + str + PDSDK_PC.SEPARATOR;
			text = text + PDSDK_PC.GetDeviceID() + PDSDK_PC.SEPARATOR;
			text = text + PDSDK_PC.getCommonProperty("cmbi_channel_id", string.Empty) + PDSDK_PC.SEPARATOR;
			text = text + PDSDK_PC.mbi_version + PDSDK_PC.SEPARATOR;
			text = text + "0" + PDSDK_PC.SEPARATOR;
			text = text + "0" + PDSDK_PC.SEPARATOR;
			text = text + "0" + PDSDK_PC.SEPARATOR;
			text = text + "800*600" + PDSDK_PC.SEPARATOR;
			text = text + "LAN" + PDSDK_PC.SEPARATOR;
			text = text + "0" + PDSDK_PC.SEPARATOR;
			JsonData jsonData = JsonMapper.ToObject(PDSDK_PC.gameInfo);
			string str2 = string.Empty;
			if (((IDictionary)jsonData).Contains("ServerId"))
			{
				str2 = (string)jsonData["ServerId"];
			}
			text = text + str2 + PDSDK_PC.SEPARATOR;
			string str3 = string.Empty;
			if (((IDictionary)jsonData).Contains("GameUid"))
			{
				str3 = (string)jsonData["GameUid"];
				if (PDSDK_PC.testUserId != string.Empty)
				{
					str3 = PDSDK_PC.testUserId;
				}
			}
			text = text + str3 + PDSDK_PC.SEPARATOR;
			text = text + "9950" + PDSDK_PC.SEPARATOR;
			text = text + PDSDK_PC.mbi_version + PDSDK_PC.SEPARATOR;
			text = text + "0" + PDSDK_PC.SEPARATOR;
			text = text + "0" + PDSDK_PC.SEPARATOR;
			text = text + "0" + PDSDK_PC.SEPARATOR;
			text = text + "0" + PDSDK_PC.SEPARATOR;
			text += "0";
			PDSDK_PC.PrintLineToFile(PDSDK_PC.mbi_online, text);
		}

		// Token: 0x0601583F RID: 88127 RVA: 0x0057992C File Offset: 0x00577B2C
		public static void PrintStartLog()
		{
			global::Debug.Log("PDSDk_PC.PrintStartLog ");
			string str = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
			string text = string.Empty;
			text = text + str + PDSDK_PC.SEPARATOR;
			text = text + PDSDK_PC.GetDeviceID() + PDSDK_PC.SEPARATOR;
			text = text + PDSDK_PC.getCommonProperty("cmbi_channel_id", string.Empty) + PDSDK_PC.SEPARATOR;
			text = text + PDSDK_PC.mbi_version + PDSDK_PC.SEPARATOR;
			text = text + "0" + PDSDK_PC.SEPARATOR;
			text = text + "0" + PDSDK_PC.SEPARATOR;
			text = text + "0" + PDSDK_PC.SEPARATOR;
			text = text + "800*600" + PDSDK_PC.SEPARATOR;
			text = text + "LAN" + PDSDK_PC.SEPARATOR;
			text = text + "0" + PDSDK_PC.SEPARATOR;
			text = text + "1000" + PDSDK_PC.SEPARATOR;
			text += PDSDK_PC.mbi_version;
			PDSDK_PC.PrintLineToFile(PDSDK_PC.mbi_start, text);
			long ticks = DateTime.Now.Ticks;
			if (ticks > PDSDK_PC.lastSentTicks + 600000000L)
			{
				PDSDK_PC.MakeLogZipAndSend();
			}
		}

		// Token: 0x06015840 RID: 88128 RVA: 0x00579A5C File Offset: 0x00577C5C
		public static void PrintLineToFile(string fileName, string content)
		{
			try
			{
				global::Debug.Log("PDSDk_PC.PrintLineToFile : " + fileName + " " + content);
				Directory.CreateDirectory(PDSDK_PC.mbi_path);
				FileInfo fileInfo = new FileInfo(PDSDK_PC.mbi_path + fileName);
				StreamWriter streamWriter;
				if (!fileInfo.Exists)
				{
					streamWriter = fileInfo.CreateText();
				}
				else
				{
					streamWriter = fileInfo.AppendText();
				}
				streamWriter.WriteLine(content);
				streamWriter.Close();
				streamWriter.Dispose();
			}
			catch (ArgumentException)
			{
				global::Debug.Log("PDSDk_PC.PrintLineToFile ArgumentException: ");
			}
			catch (IOException)
			{
				global::Debug.Log("PDSDk_PC.PrintLineToFile IOException: ");
			}
			catch (NullReferenceException)
			{
				global::Debug.Log("PDSDk_PC.PrintLineToFile NullReferenceException: ");
			}
			finally
			{
				global::Debug.Log("PDSDk_PC.PrintLineToFile finally: ");
			}
		}

		// Token: 0x06015841 RID: 88129 RVA: 0x00579B40 File Offset: 0x00577D40
		public static bool MakeLogZipAndSend()
		{
			try
			{
				PDSDK_PC.lastSentTicks = DateTime.Now.Ticks;
				Directory.CreateDirectory(PDSDK_PC.mbi_zip_path);
				if (Directory.Exists(PDSDK_PC.mbi_path))
				{
					string text = DateTime.Now.ToString("yyyyMMddHHmm");
					string str = string.Concat(new string[]
					{
						"MBI001_",
						PDSDK_PC.getCommonProperty("cmbi_app_key", string.Empty),
						"_",
						text,
						"_v1.4.zip"
					});
					string text2 = PDSDK_PC.mbi_zip_path + str;
					if (!File.Exists(text2))
					{
						ZipFile zipFile = new ZipFile(text2);
						zipFile.AddDirectory(PDSDK_PC.mbi_path, string.Empty);
						zipFile.Save();
						Directory.Delete(PDSDK_PC.mbi_path, true);
					}
				}
			}
			catch (ArgumentException)
			{
				global::Debug.Log("PDSDk_PC.MakeLogZipAndSend ArgumentException: ");
			}
			catch (IOException)
			{
				global::Debug.Log("PDSDk_PC.MakeLogZipAndSend IOException: ");
			}
			catch (NullReferenceException)
			{
				global::Debug.Log("PDSDk_PC.MakeLogZipAndSend NullReferenceException: ");
			}
			finally
			{
				global::Debug.Log("PDSDk_PC.MakeLogZipAndSend finally: ");
			}
			PDSDK_PC.SendZipFile();
			return true;
		}

		// Token: 0x06015842 RID: 88130 RVA: 0x00579C88 File Offset: 0x00577E88
		public static void SendZipFile()
		{
			try
			{
				int num = 3;
				foreach (string text in Directory.GetFileSystemEntries(PDSDK_PC.mbi_zip_path))
				{
					if (num <= 0)
					{
						break;
					}
					if (File.Exists(text) && text.IndexOf("MBI001") >= 0)
					{
						num--;
						string zipFileNameRaw = text.Substring(text.LastIndexOf("/") + 1, text.Length - text.LastIndexOf("/") - 1);
						if (PDSDK_PC.getCommonProperty("platform", "Zlongame") == "GameBeans")
						{
							PDSDK.DoCoroutine(PDSDK_PC.POST_SENDZIPFILE(PDSDK_PC.mbi_upload_gamebeans, zipFileNameRaw), null);
						}
						else
						{
							PDSDK.DoCoroutine(PDSDK_PC.POST_SENDZIPFILE(PDSDK_PC.mbi_upload, zipFileNameRaw), null);
						}
					}
				}
			}
			catch (ArgumentException)
			{
				global::Debug.Log("PDSDk_PC.SendZipFile ArgumentException: ");
			}
			catch (IOException)
			{
				global::Debug.Log("PDSDk_PC.SendZipFile IOException: ");
			}
			catch (NullReferenceException)
			{
				global::Debug.Log("PDSDk_PC.SendZipFile NullReferenceException: ");
			}
			finally
			{
				global::Debug.Log("PDSDk_PC.SendZipFile finally: ");
			}
		}

		// Token: 0x06015843 RID: 88131 RVA: 0x00579DCC File Offset: 0x00577FCC
		private static IEnumerator POST_SENDZIPFILE(string url, string zipFileNameRaw)
		{
			global::Debug.Log("PDSDk_PC.POST_SENDZIPFILE " + url + "   " + zipFileNameRaw);
			string zipFileName = PDSDK_PC.mbi_zip_path + zipFileNameRaw;
			string BOUNDARY = "A52F733B0E51D9A568FABABBC8D3A518";
			WWWForm form = new WWWForm();
			form.AddField("Content-Type", "multipart/form-data;boundary=" + BOUNDARY);
			form.AddField("connection", "keep-alive");
			form.AddField("Charsert", "UTF-8");
			form.AddField("project", "MBI001");
			FileStream fs = File.OpenRead(zipFileName);
			int len = (int)fs.Length;
			byte[] b = new byte[len];
			fs.Read(b, 0, len);
			fs.Close();
			form.AddBinaryData("file", b, zipFileNameRaw);
			WWW www = new WWW(url, form);
			yield return www;
			if (www.error != null)
			{
				global::Debug.Log("PDSDk_PC.error is :" + www.error);
			}
			else
			{
				global::Debug.Log("PDSDk_PC.request ok : " + www.text);
				JsonData jsonData = JsonMapper.ToObject(www.text);
				bool flag = (bool)jsonData["success"];
				if (flag)
				{
					File.Delete(zipFileName);
				}
			}
			yield break;
		}

		// Token: 0x06015844 RID: 88132 RVA: 0x00579DF0 File Offset: 0x00577FF0
		public static void verifyToken(string msg)
		{
			JsonData jsonData = JsonMapper.ToObject(msg);
			string data = (string)jsonData["data"];
			string opcode = (string)jsonData["opcode"];
			string channelid = (string)jsonData["channel_id"];
			string text = (string)jsonData["customparams"];
			if (PDSDK_PC.getCommonProperty("platform", "Zlongame") == "GameBeans")
			{
				PDSDK.DoCoroutine(PDSDK_PC.GET_SUPERME("http://billingtest.game-beans.com:8081/sdk-gameserver/" + PDSDK_PC.getCommonProperty("app_key", string.Empty) + "/superme", data, opcode, channelid), null);
			}
			else
			{
				PDSDK.DoCoroutine(PDSDK_PC.GET_SUPERME("http://billingtest.zlongame.com:8081/sdk-gameserver/" + PDSDK_PC.getCommonProperty("app_key", string.Empty) + "/superme", data, opcode, channelid), null);
			}
		}

		// Token: 0x06015845 RID: 88133 RVA: 0x00579EC4 File Offset: 0x005780C4
		public static void onLoginSuccess(string msg)
		{
			global::Debug.Log("PDSDk_PC.onLoginSuccess : " + msg);
			JsonData jsonData = JsonMapper.ToObject(msg);
			int num = int.Parse(jsonData["status"].ToJson());
			if (num == 1)
			{
				string data = jsonData["opcode"].ToString();
				string text = jsonData["channel_id"].ToString();
				string data2 = jsonData["customparams"].ToString();
				PDSDK_PC.userToken = jsonData["data"]["token"].ToString();
				string data3 = jsonData["data"]["userid"].ToString();
				JsonData jsonData2 = new JsonData();
				jsonData2["userip"] = "127.0.0.1";
				jsonData2["deviceid"] = PDSDK_PC.GetDeviceID();
				jsonData2["isdebug"] = PDSDK_PC.getCommonProperty("debug_mode", "0");
				jsonData2["channel_id"] = text;
				jsonData2["opcode"] = data;
				jsonData2["token"] = PDSDK_PC.userToken;
				jsonData2["oid"] = data3;
				jsonData2["sdkversion"] = PDSDK_PC.getCommonProperty("sdk_version_name", "1.0");
				jsonData2["system"] = "UNITYPC";
				jsonData2["gamechannel"] = text;
				jsonData2["app_key"] = PDSDK_PC.getCommonProperty("app_key", string.Empty);
				jsonData2["channel_id"] = text;
				PDSDK_PC.setCommonProperty("channel_id", text);
				PDSDK_PC.setCommonProperty("cmbi_channel_id", text);
				string data4 = PDSDK_PC.Encode_DES(jsonData2.ToJson(), "cyou-mrd");
				JsonData jsonData3 = new JsonData();
				jsonData3["validateInfo"] = data4;
				JsonData jsonData4 = new JsonData();
				jsonData4["state_code"] = "300";
				jsonData4["message"] = "pcloginsuccess";
				jsonData4["channel_id"] = text;
				jsonData4["opcode"] = data;
				jsonData4["data"] = jsonData3.ToJson();
				jsonData4["customparams"] = data2;
				PDSDK.Instance.onLoginSuccess(jsonData4.ToJson());
				PDSDK_PC.PrintStartLog();
			}
			else
			{
				PDSDK_PC.onLoginFailed("pcloginfailed");
			}
		}

		// Token: 0x06015846 RID: 88134 RVA: 0x0057A178 File Offset: 0x00578378
		public static void onLoginFailed(string msg)
		{
			global::Debug.Log("pcsss onLoginFailed : " + msg);
			JsonData jsonData = new JsonData();
			jsonData["state_code"] = "301";
			jsonData["message"] = "pcloginfailed";
			jsonData["customparams"] = string.Empty;
			PDSDK.Instance.onLoginFailed(jsonData.ToJson());
		}

		// Token: 0x06015847 RID: 88135 RVA: 0x0057A1EC File Offset: 0x005783EC
		public static void onLoginCancel(string msg)
		{
			global::Debug.Log("pcsss onLoginCancel : " + msg);
			JsonData jsonData = new JsonData();
			jsonData["state_code"] = "302";
			jsonData["message"] = "pclogincancel";
			jsonData["customparams"] = string.Empty;
			PDSDK.Instance.onLoginCancel(jsonData.ToJson());
		}

		// Token: 0x06015848 RID: 88136 RVA: 0x0057A260 File Offset: 0x00578460
		public static void onCallWebviewSuccess(string msg)
		{
			global::Debug.Log("pcsss onCallWebviewSuccess : " + msg);
			JsonData jsonData = new JsonData();
			jsonData["state_code"] = "1600";
			jsonData["message"] = "onCallWebviewSuccess";
			JsonData jsonData2 = new JsonData();
			jsonData2["action"] = PDSDK_PC._webviewAction;
			jsonData2["res"] = msg;
			if (PDSDK_PC.getCommonProperty("app_key", string.Empty) == PDSDK_PC.hxsyAppkey)
			{
				jsonData["data"] = jsonData2;
			}
			else
			{
				jsonData["data"] = jsonData2.ToJson();
			}
			PDSDK.Instance.oncallWebViewSuccess(jsonData.ToJson());
		}

		// Token: 0x06015849 RID: 88137 RVA: 0x0057A330 File Offset: 0x00578530
		public static void onCallWebviewCancel()
		{
			global::Debug.Log("pcsss onCallWebviewCancel ");
			JsonData jsonData = new JsonData();
			jsonData["state_code"] = "1602";
			jsonData["message"] = "onCallWebviewCancel";
			JsonData jsonData2 = new JsonData();
			jsonData2["action"] = PDSDK_PC._webviewAction;
			if (PDSDK_PC.getCommonProperty("app_key", string.Empty) == PDSDK_PC.hxsyAppkey)
			{
				jsonData["data"] = jsonData2;
			}
			else
			{
				jsonData["data"] = jsonData2.ToJson();
			}
			PDSDK.Instance.oncallWebViewCancel(jsonData.ToJson());
		}

		// Token: 0x0601584A RID: 88138 RVA: 0x0057A3E8 File Offset: 0x005785E8
		public static void onPcPaySuccess(string msg)
		{
			global::Debug.Log("pcsss onPcPaySuccess : " + msg);
			JsonData jsonData = new JsonData();
			jsonData["state_code"] = "100";
			jsonData["message"] = "onPcPaySuccess";
			PDSDK.Instance.onPaySuccess(jsonData.ToJson());
		}

		// Token: 0x0601584B RID: 88139 RVA: 0x0057A448 File Offset: 0x00578648
		public static void onPcPayFailed(string msg)
		{
			global::Debug.Log("pcsss onPcPayFailed : " + msg);
			JsonData jsonData = new JsonData();
			jsonData["state_code"] = "101";
			jsonData["message"] = "onPcPayFailed";
			PDSDK.Instance.onPayFailed(jsonData.ToJson());
		}

		// Token: 0x0601584C RID: 88140 RVA: 0x0057A4A8 File Offset: 0x005786A8
		public static void onPcPayCancel(string msg)
		{
			global::Debug.Log("pcsss onPcPayCancel : " + msg);
			JsonData jsonData = new JsonData();
			jsonData["state_code"] = "102";
			jsonData["message"] = "onPcPayCancel";
			PDSDK.Instance.onPayCancel(jsonData.ToJson());
		}

		// Token: 0x0601584D RID: 88141 RVA: 0x0057A508 File Offset: 0x00578708
		public static string Encode_DES(string str, string key)
		{
			DESCryptoServiceProvider descryptoServiceProvider = new DESCryptoServiceProvider();
			descryptoServiceProvider.Mode = CipherMode.ECB;
			byte[] bytes = Encoding.UTF8.GetBytes(key);
			byte[] bytes2 = Encoding.UTF8.GetBytes(str);
			MemoryStream memoryStream = new MemoryStream();
			CryptoStream cryptoStream = new CryptoStream(memoryStream, descryptoServiceProvider.CreateEncryptor(bytes, bytes), CryptoStreamMode.Write);
			cryptoStream.Write(bytes2, 0, bytes2.Length);
			cryptoStream.FlushFinalBlock();
			StringBuilder stringBuilder = new StringBuilder();
			foreach (byte b in memoryStream.ToArray())
			{
				stringBuilder.AppendFormat("{0:x2}", b);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x0601584E RID: 88142 RVA: 0x0057A5B0 File Offset: 0x005787B0
		public static string Encrypt_MD5(string strPwd)
		{
			MD5 md = new MD5CryptoServiceProvider();
			byte[] bytes = Encoding.Default.GetBytes(strPwd);
			byte[] array = md.ComputeHash(bytes);
			md.Clear();
			string text = string.Empty;
			for (int i = 0; i < array.Length; i++)
			{
				text += array[i].ToString("x").PadLeft(2, '0');
			}
			return text;
		}

		// Token: 0x0601584F RID: 88143 RVA: 0x0057A620 File Offset: 0x00578820
		private static IEnumerator GET_SUPERME(string url, string data, string opcode, string channelid)
		{
			global::Debug.Log(url);
			WWWForm form = new WWWForm();
			form.AddField("data", data);
			form.AddField("opcode", opcode);
			form.AddField("channelid", channelid);
			WWW www = new WWW(url, form);
			yield return www;
			if (www.error != null)
			{
				global::Debug.Log("error is :" + www.error);
			}
			else
			{
				global::Debug.Log("request ok : " + www.text);
				JsonData jsonData = JsonMapper.ToObject(www.text);
				PDSDK_PC.testUserId = jsonData["data"]["userid"].ToString();
			}
			yield break;
		}

		// Token: 0x06015850 RID: 88144 RVA: 0x0057A650 File Offset: 0x00578850
		private static IEnumerator GET_WXORDER(string url)
		{
			global::Debug.Log(url);
			WWWForm form = new WWWForm();
			form.AddField("app_id", PDSDK_PC.getCommonProperty("app_key", string.Empty));
			form.AddField("subject", PDSDK_PC._goodsName);
			form.AddField("body", PDSDK_PC._goodsName);
			form.AddField("total_fee", ((int)(PDSDK_PC._goodsPrice * 100.0)).ToString());
			form.AddField("pd_device_id", PDSDK_PC.GetDeviceID());
			form.AddField("extra", PDSDK_PC._orderId);
			WWW www = new WWW(url, form);
			yield return www;
			if (www.error != null)
			{
				global::Debug.Log("error is :" + www.error);
				JsonData jsonData = new JsonData();
				jsonData["message"] = "payFailed-wxorder";
				PDSDK.Instance.onGetPayHistoryFailed(jsonData.ToJson());
			}
			else
			{
				global::Debug.Log("request ok : " + www.text);
				JsonData jsonData2 = JsonMapper.ToObject(www.text);
				int num = (int)jsonData2["status"];
				JsonData jsonData3 = jsonData2["data"];
				if (num == 1)
				{
					string str = (string)jsonData3["totalFee"];
					string s = (string)jsonData3["subject"];
					string s2 = (string)jsonData3["codeUrl"];
					string str2 = (string)jsonData3["orderId"];
					string text = PDSDK_PC.WxQrcodeUrl;
					text += "&orderId=";
					text += str2;
					text += "&subject=";
					text += WWW.EscapeURL(s);
					text += "&totalFee=";
					text += str;
					text += "&codeUrl=";
					text += WWW.EscapeURL(s2);
					PDSDK_PC.OpenWebBrowser(text, 456, 623);
				}
				else
				{
					JsonData jsonData4 = new JsonData();
					jsonData4["message"] = "payFailed-wxorder-status " + num.ToString();
					PDSDK.Instance.onGetPayHistoryFailed(jsonData4.ToJson());
				}
			}
			yield break;
		}

		// Token: 0x06015851 RID: 88145 RVA: 0x0057A66C File Offset: 0x0057886C
		private static IEnumerator GET_CREATORDER(string url)
		{
			global::Debug.Log(url);
			JsonData json = JsonMapper.ToObject(PDSDK_PC.gameInfo);
			string userId = string.Empty;
			if (((IDictionary)json).Contains("GameUid"))
			{
				userId = (string)json["GameUid"];
				if (PDSDK_PC.testUserId != string.Empty)
				{
					userId = PDSDK_PC.testUserId;
				}
			}
			string roleId = string.Empty;
			if (((IDictionary)json).Contains("RoleId"))
			{
				roleId = (string)json["RoleId"];
			}
			string pushInfo = string.Empty;
			if (((IDictionary)json).Contains("PushInfo"))
			{
				pushInfo = (string)json["PushInfo"];
			}
			string serverId = string.Empty;
			if (((IDictionary)json).Contains("ServerId"))
			{
				serverId = (string)json["ServerId"];
			}
			string serverName = string.Empty;
			if (((IDictionary)json).Contains("ServerName"))
			{
				serverName = (string)json["ServerName"];
				serverName = WWW.EscapeURL(serverName);
			}
			JsonData createOrderJson = new JsonData();
			createOrderJson["account_id"] = userId;
			createOrderJson["user_id"] = userId;
			createOrderJson["goods_id"] = PDSDK_PC._goodsId;
			createOrderJson["goods_register_id"] = PDSDK_PC._goodsRegisterId;
			createOrderJson["goods_number"] = PDSDK_PC._goodsNumber.ToString();
			createOrderJson["goods_price"] = PDSDK_PC._goodsPrice.ToString();
			createOrderJson["push_info"] = pushInfo;
			createOrderJson["game_channel"] = PDSDK_PC.getCommonProperty("cmbi_app_key", string.Empty);
			createOrderJson["customparams"] = PDSDK_PC._customparams;
			createOrderJson["role_id"] = roleId;
			createOrderJson["group_id"] = serverId;
			createOrderJson["group_name"] = serverName;
			Dictionary<string, string> myhear = new Dictionary<string, string>();
			myhear.Add("Content-Type", "application/json;charset=utf-8");
			myhear.Add("debug", PDSDK_PC.getCommonProperty("debug_mode", "0"));
			myhear.Add("tag", "123456");
			myhear.Add("app_key", PDSDK_PC.getCommonProperty("app_key", string.Empty));
			myhear.Add("media_channel_id", PDSDK_PC.getCommonProperty("cmbi_channel_id", string.Empty));
			myhear.Add("channel_id", PDSDK_PC.getCommonProperty("channel_id", string.Empty));
			myhear.Add("clientVersion", PDSDK_PC.getCommonProperty("sdk_version_name", "1.0"));
			myhear.Add("sign", "b694fd55b8107149");
			string str_params = createOrderJson.ToJson();
			byte[] post_data = Encoding.UTF8.GetBytes(str_params);
			WWW www = new WWW(url, post_data, myhear);
			yield return www;
			if (www.error != null)
			{
				global::Debug.Log("error is :" + www.error);
				JsonData jsonData = new JsonData();
				jsonData["message"] = "payFailed-createorder";
				PDSDK.Instance.onGetPayHistoryFailed(jsonData.ToJson());
			}
			else
			{
				global::Debug.Log("request ok : " + www.text);
				JsonData jsonData2 = JsonMapper.ToObject(www.text);
				PDSDK_PC._orderId = (string)jsonData2["order_id"];
				string text = (string)jsonData2["orderSign"];
				string text2 = PDSDK_PC.Encrypt_MD5(string.Concat(new string[]
				{
					userId,
					"|",
					PDSDK_PC._orderId,
					"|",
					PDSDK_PC.getCommonProperty("channel_id", string.Empty)
				}));
				string value = PDSDK_PC.Encrypt_MD5(text2.Substring(0, 10));
				if (text.Equals(value))
				{
					JsonData jsonData3 = new JsonData();
					DateTime d = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));
					long num = (long)(DateTime.Now - d).TotalMilliseconds;
					jsonData3["timestamp"] = num.ToString();
					jsonData3["appKey"] = PDSDK_PC.getCommonProperty("app_key", string.Empty);
					jsonData3["transactionId"] = PDSDK_PC._orderId;
					jsonData3["channelId"] = PDSDK_PC.getCommonProperty("channel_id", string.Empty);
					jsonData3["subject"] = PDSDK_PC._goodsName;
					jsonData3["body"] = PDSDK_PC._goodsName;
					jsonData3["pd_device_id"] = PDSDK_PC.GetDeviceID();
					jsonData3["total_fee"] = PDSDK_PC._goodsPrice;
					jsonData3["userId"] = userId;
					jsonData3["roleId"] = roleId;
					jsonData3["serverId"] = serverId;
					jsonData3["goodsId"] = PDSDK_PC._goodsId;
					string strPwd = string.Concat(new string[]
					{
						num.ToString(),
						PDSDK_PC.getCommonProperty("app_key", string.Empty),
						PDSDK_PC._orderId,
						PDSDK_PC.getCommonProperty("channel_id", string.Empty),
						userId,
						serverId,
						roleId,
						PDSDK_PC._goodsId,
						PDSDK_PC._goodsPrice.ToString("0.00")
					});
					string data = PDSDK_PC.Encrypt_MD5(strPwd);
					jsonData3["sign"] = data;
					string text3 = jsonData3.ToJson();
					string s = string.Empty;
					byte[] bytes = Encoding.UTF8.GetBytes(text3);
					try
					{
						s = Convert.ToBase64String(bytes);
					}
					catch
					{
						s = text3;
					}
					string str = WWW.EscapeURL(s);
					string text4 = PDSDK_PC.OrderPayUrl;
					text4 += "?data=";
					text4 += str;
					PDSDK_PC.OpenWebBrowser(text4, 456, 478);
				}
				else
				{
					JsonData jsonData4 = new JsonData();
					jsonData4["message"] = "payFailed-createorder-sign";
					PDSDK.Instance.onGetPayHistoryFailed(jsonData4.ToJson());
				}
			}
			yield break;
		}

		// Token: 0x06015852 RID: 88146 RVA: 0x0057A688 File Offset: 0x00578888
		private static IEnumerator GET_GOODSLIST(string url)
		{
			global::Debug.Log(url);
			WWW www = new WWW(url, null, new Dictionary<string, string>
			{
				{
					"debug",
					PDSDK_PC.getCommonProperty("debug_mode", "0")
				},
				{
					"tag",
					"123456"
				},
				{
					"app_key",
					PDSDK_PC.getCommonProperty("app_key", string.Empty)
				},
				{
					"media_channel_id",
					PDSDK_PC.getCommonProperty("cmbi_channel_id", string.Empty)
				},
				{
					"channel_id",
					PDSDK_PC.getCommonProperty("channel_id", string.Empty)
				},
				{
					"clientVersion",
					PDSDK_PC.getCommonProperty("sdk_version_name", "1.0")
				},
				{
					"sign",
					PDSDK_PC.Encrypt_MD5(PDSDK_PC.getCommonProperty("app_key", string.Empty)).Substring(8, 16)
				}
			});
			yield return www;
			if (www.error != null)
			{
				global::Debug.Log("error is :" + www.error);
				JsonData jsonData = new JsonData();
				jsonData["message"] = "GetProductsListFailed";
				PDSDK.Instance.onGetProductsListFailed(jsonData.ToJson());
			}
			else
			{
				global::Debug.Log("request ok : " + www.text);
				JsonData jsonData2 = new JsonData();
				jsonData2["state_code"] = "800";
				jsonData2["message"] = string.Empty;
				jsonData2["data"] = www.text;
				string msg = jsonData2.ToJson();
				PDSDK.Instance.onGetProductsListSuccess(msg);
			}
			yield break;
		}

		// Token: 0x06015853 RID: 88147 RVA: 0x0057A6A4 File Offset: 0x005788A4
		private static IEnumerator GET_NEWVERSION(string url)
		{
			global::Debug.Log(url);
			Dictionary<string, string> headers = new Dictionary<string, string>();
			headers.Add("debug", PDSDK_PC.getCommonProperty("debug_mode", "0"));
			headers.Add("tag", "123456");
			headers.Add("app_key", PDSDK_PC.getCommonProperty("app_key", string.Empty));
			headers.Add("media_channel_id", PDSDK_PC.getCommonProperty("cmbi_channel_id", string.Empty));
			headers.Add("channel_id", PDSDK_PC.getCommonProperty("channel_id", string.Empty));
			headers.Add("clientVersion", PDSDK_PC.getCommonProperty("sdk_version_name", "1.0"));
			headers.Add("sign", PDSDK_PC.Encrypt_MD5(PDSDK_PC.getCommonProperty("app_key", string.Empty) + "app_version=" + PDSDK_PC.getCommonProperty("version_name", "1.0.0")).Substring(8, 16));
			WWW www = new WWW(url + "?app_version=" + PDSDK_PC.getCommonProperty("version_name", "1.0.0"), null, headers);
			yield return www;
			if (www.error != null)
			{
				global::Debug.Log("error is :" + www.error);
			}
			else
			{
				global::Debug.Log("request ok : " + www.text);
				JsonData jsonData = JsonMapper.ToObject(www.text);
				int num = (int)jsonData["update_level"];
				if (num >= 1)
				{
					string url2 = (string)jsonData["download_url"];
					PDSDK_PC.OpenWebBrowser(url2, 1136, 640);
					PDSDK_PC.webViewEnable = 0;
				}
			}
			yield break;
		}

		// Token: 0x06015854 RID: 88148 RVA: 0x0057A6C0 File Offset: 0x005788C0
		private static string decode(string src, byte key)
		{
			byte[] bytes = Encoding.UTF8.GetBytes(src);
			for (int i = 0; i < bytes.Length; i++)
			{
				bytes[i] ^= key;
			}
			return Encoding.UTF8.GetString(bytes);
		}

		// Token: 0x0400BBE7 RID: 48103
		private static WebUIComponent webBrowser;

		// Token: 0x0400BBE8 RID: 48104
		private static int webViewEnable = 1;

		// Token: 0x0400BBE9 RID: 48105
		private static string gameInfo = string.Empty;

		// Token: 0x0400BBEA RID: 48106
		private static JsonData commonPropertyJson;

		// Token: 0x0400BBEB RID: 48107
		private static string userToken;

		// Token: 0x0400BBEC RID: 48108
		private static string deviceId;

		// Token: 0x0400BBED RID: 48109
		private static string testUserId = string.Empty;

		// Token: 0x0400BBEE RID: 48110
		private static string _goodsName;

		// Token: 0x0400BBEF RID: 48111
		private static int _goodsNumber;

		// Token: 0x0400BBF0 RID: 48112
		private static string _goodsId;

		// Token: 0x0400BBF1 RID: 48113
		private static string _goodsRegisterId;

		// Token: 0x0400BBF2 RID: 48114
		private static double _goodsPrice;

		// Token: 0x0400BBF3 RID: 48115
		private static string _customparams;

		// Token: 0x0400BBF4 RID: 48116
		private static string _goodsDes;

		// Token: 0x0400BBF5 RID: 48117
		private static string _orderId;

		// Token: 0x0400BBF6 RID: 48118
		private static string qqhAppkey = "1448278612076";

		// Token: 0x0400BBF7 RID: 48119
		private static string hxsyAppkey = "1480042163929";

		// Token: 0x0400BBF8 RID: 48120
		private static string _webviewAction = string.Empty;

		// Token: 0x0400BBF9 RID: 48121
		private static string SEPARATOR = Encoding.ASCII.GetString(new byte[]
		{
			1
		});

		// Token: 0x0400BBFA RID: 48122
		private static string INNER_SEPARATOR = Encoding.ASCII.GetString(new byte[]
		{
			2
		});

		// Token: 0x0400BBFB RID: 48123
		private static string mbi_version = "1.0";

		// Token: 0x0400BBFC RID: 48124
		private static string mbi_active = "active.log";

		// Token: 0x0400BBFD RID: 48125
		private static string mbi_gameevent = "gameevent.log";

		// Token: 0x0400BBFE RID: 48126
		private static string mbi_login = "login.log";

		// Token: 0x0400BBFF RID: 48127
		private static string mbi_online = "online.log";

		// Token: 0x0400BC00 RID: 48128
		private static string mbi_start = "start.log";

		// Token: 0x0400BC01 RID: 48129
		private static string mbi_path = Application.dataPath + "/mbi/";

		// Token: 0x0400BC02 RID: 48130
		private static string mbi_zip_path = Application.dataPath + "/mbi_zip/";

		// Token: 0x0400BC03 RID: 48131
		private static long lastSentTicks = DateTime.Now.Ticks;

		// Token: 0x0400BC04 RID: 48132
		private static string mbi_upload = "http://sdkbi.zlongame.com:9080/pd-bi-log-service/UploadFileServlet";

		// Token: 0x0400BC05 RID: 48133
		private static string mbi_upload_gamebeans = "http://tw-sdkbi.game-beans.com:9080/pd-bi-log-service/UploadFileServlet";

		// Token: 0x0400BC06 RID: 48134
		private static string config_path = Application.dataPath + "/StreamingAssets/commonProperty";

		// Token: 0x0400BC07 RID: 48135
		private static string config_path_d = Application.dataPath + "/StreamingAssets/commonPropertyD";
	}
}
