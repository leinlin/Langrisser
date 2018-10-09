using System;
using System.Collections.Generic;
using System.IO;
using BlackJack.ProjectL.UI;
using BlackJack.ProjectLBasic;
using PD.SDK;
using UnityEngine;

namespace DebugConsole
{
	// Token: 0x020005A2 RID: 1442
	public class RunTestCodeCmd : IDebugCmd
	{
		// Token: 0x06005246 RID: 21062 RVA: 0x001864F0 File Offset: 0x001846F0
		public void Execute(string strParams)
		{
			this.Test(strParams);
		}

		// Token: 0x06005247 RID: 21063 RVA: 0x001864FC File Offset: 0x001846FC
		public string GetHelpDesc()
		{
			return "Rtc 1 : 执行测试代码，输入参数为：1.";
		}

		// Token: 0x06005248 RID: 21064 RVA: 0x00186504 File Offset: 0x00184704
		public string GetName()
		{
			return "Rtc";
		}

		// Token: 0x06005249 RID: 21065 RVA: 0x0018650C File Offset: 0x0018470C
		private void Test(string str)
		{
			string[] array = str.Split(new char[]
			{
				' '
			});
			if (array.Length == 0)
			{
				return;
			}
			if (array[0].ToLower() == "logout")
			{
				if (PDSDK.Instance != null)
				{
					PDSDK.Instance.onLogoutSuccess("{\"customparams\":\"\"}");
				}
			}
			else if (array[0].ToLower() == "lua")
			{
				if (PDSDK.m_eventLoginSuccess != null)
				{
					PDSDK.m_eventLoginSuccess(new LoginSuccessMsg("t1", "t2", "t3", "t4"));
				}
				if (PDSDK.m_eventLoginFailed != null)
				{
					PDSDK.m_eventLoginFailed();
				}
				if (PDSDK.m_eventLogoutSuccess != null)
				{
					PDSDK.m_eventLogoutSuccess();
				}
				if (PDSDK.m_eventInitSuccess != null)
				{
					PDSDK.m_eventInitSuccess();
				}
				if (PDSDK.m_eventInitFailed != null)
				{
					PDSDK.m_eventInitFailed();
				}
			}
			else if (array[0].ToLower() == "ei")
			{
				CommonUIController.Instance.PDSDKEnableInput(true);
			}
			else if (array[0].ToLower() == "di")
			{
				CommonUIController.Instance.PDSDKEnableInput(false);
			}
			else if (array[0].ToLower() == "get")
			{
				List<PDSDKGood> list = StoreUITask.PDSDKGetGoods();
				foreach (PDSDKGood pdsdkgood in list)
				{
					global::Debug.Log(string.Format("id={0} regID={1} name={2} type={3} price={4} desc={5}", new object[]
					{
						pdsdkgood.m_ID,
						pdsdkgood.m_registerID,
						pdsdkgood.m_name,
						pdsdkgood.m_type,
						pdsdkgood.m_price,
						pdsdkgood.m_desc
					}));
				}
			}
			else if (array[0].ToLower() == "req")
			{
				StoreUITask.PDSDKRequestGoods();
			}
			else if (array[0].ToLower() == "buy")
			{
				if (array.Length < 4)
				{
					return;
				}
				string goodID = array[1];
				PDSDKGoodType goodType = PDSDKGoodType.Normal;
				int number = int.Parse(array[3]);
				StoreUITask.PDSDKRequestBuyGoods(goodID, goodType, number);
			}
			else if (array[0].ToLower() == "capture")
			{
				Texture2D texture2D = ScreenCapture.CaptureScreenshotAsTexture(1);
				File.WriteAllBytes(Application.persistentDataPath + "/ShareImage.jpg", texture2D.EncodeToJPG(100));
				Texture2D tex = Utility.ResizeTexture(texture2D, ImageFilterMode.Average, 300f / (float)texture2D.width);
				File.WriteAllBytes(Application.persistentDataPath + "/thumbShareImage.jpg", tex.EncodeToJPG(100));
				JsonData jsonData = new JsonData();
				jsonData["Title"] = "这是分享的标题";
				jsonData["TitleUrl"] = "http://q.zilongame.com/";
				jsonData["Text"] = "这是分享的正文";
				jsonData["ImagePath"] = Application.persistentDataPath + "/ShareImage.jpg";
				jsonData["thumbImagePath"] = Application.persistentDataPath + "/thumbShareImage.jpg";
				jsonData["SiteUrl"] = "http://q.zilongame.com/";
				jsonData["Url"] = "http://q.zilongame.com/";
				jsonData["shareType"] = 2;
				jsonData["sharePlatform"] = 2;
				if (array.Length > 1)
				{
					jsonData["sharePlatform"] = int.Parse(array[1]);
				}
				PDSDK.Instance.doshare(jsonData.ToJson());
			}
		}
	}
}
