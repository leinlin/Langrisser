using System;
using Awesomium.Core;
using Awesomium.Unity;
using PD.SDK;
using UnityEngine;

// Token: 0x020010AF RID: 4271
public class WebUILoginHandler : WebUIScript
{
	// Token: 0x17003ED2 RID: 16082
	// (get) Token: 0x0601587B RID: 88187 RVA: 0x0057BC24 File Offset: 0x00579E24
	private WebUIComponent WebBrowser
	{
		get
		{
			if (this.webBrowser == null)
			{
				GameObject gameObject = GameObject.Find("loginwebui");
				if (gameObject)
				{
					this.webBrowser = gameObject.GetComponent<WebUIComponent>();
				}
			}
			return this.webBrowser;
		}
	}

	// Token: 0x0601587C RID: 88188 RVA: 0x0057BC6C File Offset: 0x00579E6C
	protected override void Awake()
	{
		if (!base.webUI)
		{
			return;
		}
		WebSession webSession;
		if ((webSession = WebCore.Sessions["./Data"]) == null)
		{
			webSession = WebCore.CreateWebSession("./Data", new WebPreferences
			{
				SmoothScrolling = true
			});
		}
		WebSession webSession2 = webSession;
		base.webUI.WebSession = webSession2;
	}

	// Token: 0x0601587D RID: 88189 RVA: 0x0057BCC8 File Offset: 0x00579EC8
	protected override void Start()
	{
		if (base.webUI)
		{
			base.webUI.DocumentReady += this.OnDocumentReady;
		}
	}

	// Token: 0x0601587E RID: 88190 RVA: 0x0057BCF4 File Offset: 0x00579EF4
	protected override void OnShowCreatedWebView(WebUIComponent sender, ShowCreatedWebViewEventArgs e)
	{
		e.Cancel = true;
		if (e.TargetURL != null && string.Compare(e.TargetURL.Host, sender.Source.Host, true) == 0)
		{
			global::Debug.Log(string.Format("Navigating to: {0}", e.TargetURL));
			base.webUI.Source = e.TargetURL;
		}
	}

	// Token: 0x0601587F RID: 88191 RVA: 0x0057BD60 File Offset: 0x00579F60
	private void OnDocumentReady(object sender, UrlEventArgs e)
	{
		JSObject jsobject = base.webUI.CreateGlobalJavascriptObject("UnityWebCore");
		if (jsobject == null)
		{
			return;
		}
		JSObject jsobject2 = jsobject;
		try
		{
			jsobject.Bind("onLoginSuccess", false, new JavascriptMethodEventHandler(this.onLoginSuccess));
			jsobject.Bind("onLoginFailed", false, new JavascriptMethodEventHandler(this.onLoginFailed));
			jsobject.Bind("onLoginCancel", false, new JavascriptMethodEventHandler(this.onLoginCancel));
			jsobject.Bind("gotoUrl", false, new JavascriptMethodEventHandler(this.gotoUrl));
			jsobject.Bind("onClose", false, new JavascriptMethodEventHandler(this.onClose));
			jsobject.Bind("commit", false, new JavascriptMethodEventHandler(this.onCommit));
			jsobject.Bind("onCancel", false, new JavascriptMethodEventHandler(this.onCancel));
			jsobject.Bind("onPcPaySuccess", false, new JavascriptMethodEventHandler(this.onPcPaySuccess));
			jsobject.Bind("onPcPayFailed", false, new JavascriptMethodEventHandler(this.onPcPayFailed));
			jsobject.Bind("onPcPayCancel", false, new JavascriptMethodEventHandler(this.onPcPayCancel));
			jsobject.Bind("onQRClose", false, new JavascriptMethodEventHandler(this.onClose));
		}
		finally
		{
			if (jsobject2 != null)
			{
				((IDisposable)jsobject2).Dispose();
			}
		}
	}

	// Token: 0x06015880 RID: 88192 RVA: 0x0057BED0 File Offset: 0x0057A0D0
	private void CloseWebBrowser()
	{
		if (this.WebBrowser)
		{
			this.WebBrowser.Source = string.Empty.ToUri();
			this.Update();
			this.WebBrowser.Visible = false;
		}
		PDSDK.Instance.onWebViewClose();
	}

	// Token: 0x06015881 RID: 88193 RVA: 0x0057BF20 File Offset: 0x0057A120
	private void onLoginSuccess(object sender, JavascriptMethodEventArgs e)
	{
		global::Debug.Log("webview onLoginSuccess ");
		this.CloseWebBrowser();
		if (e.Arguments.Length > 0)
		{
			PDSDK_PC.onLoginSuccess(e.Arguments[0].ToString());
		}
	}

	// Token: 0x06015882 RID: 88194 RVA: 0x0057BF5C File Offset: 0x0057A15C
	private void onLoginFailed(object sender, JavascriptMethodEventArgs e)
	{
		global::Debug.Log("webview onLoginFailed ");
		this.CloseWebBrowser();
		if (e.Arguments.Length > 0)
		{
			PDSDK_PC.onLoginFailed(e.Arguments[0].ToString());
		}
	}

	// Token: 0x06015883 RID: 88195 RVA: 0x0057BF98 File Offset: 0x0057A198
	private void onLoginCancel(object sender, JavascriptMethodEventArgs e)
	{
		global::Debug.Log("webview onLoginCancel ");
		this.CloseWebBrowser();
		if (e.Arguments.Length > 0)
		{
			PDSDK_PC.onLoginCancel(e.Arguments[0].ToString());
		}
	}

	// Token: 0x06015884 RID: 88196 RVA: 0x0057BFD4 File Offset: 0x0057A1D4
	private void gotoUrl(object sender, JavascriptMethodEventArgs e)
	{
		global::Debug.Log("webview gotoUrl ");
		if (e.Arguments.Length > 0)
		{
			Application.OpenURL(e.Arguments[0].ToString());
		}
	}

	// Token: 0x06015885 RID: 88197 RVA: 0x0057C00C File Offset: 0x0057A20C
	private void onClose(object sender, JavascriptMethodEventArgs e)
	{
		global::Debug.Log("webview onClose ");
		this.CloseWebBrowser();
	}

	// Token: 0x06015886 RID: 88198 RVA: 0x0057C020 File Offset: 0x0057A220
	private void onCommit(object sender, JavascriptMethodEventArgs e)
	{
		global::Debug.Log("webview onCommit ");
		this.CloseWebBrowser();
		if (e.Arguments.Length > 0)
		{
			PDSDK_PC.onCallWebviewSuccess(e.Arguments[0].ToString());
		}
	}

	// Token: 0x06015887 RID: 88199 RVA: 0x0057C05C File Offset: 0x0057A25C
	private void onCancel(object sender, JavascriptMethodEventArgs e)
	{
		global::Debug.Log("webview onCancel ");
		this.CloseWebBrowser();
		PDSDK_PC.onCallWebviewCancel();
	}

	// Token: 0x06015888 RID: 88200 RVA: 0x0057C074 File Offset: 0x0057A274
	private void onPcPaySuccess(object sender, JavascriptMethodEventArgs e)
	{
		global::Debug.Log("webview onPcPaySuccess ");
		this.CloseWebBrowser();
		PDSDK_PC.onPcPaySuccess(string.Empty);
	}

	// Token: 0x06015889 RID: 88201 RVA: 0x0057C090 File Offset: 0x0057A290
	private void onPcPayFailed(object sender, JavascriptMethodEventArgs e)
	{
		global::Debug.Log("webview onPcPayFailed ");
		this.CloseWebBrowser();
		PDSDK_PC.onPcPayFailed(string.Empty);
	}

	// Token: 0x0601588A RID: 88202 RVA: 0x0057C0AC File Offset: 0x0057A2AC
	private void onPcPayCancel(object sender, JavascriptMethodEventArgs e)
	{
		global::Debug.Log("webview onPcPayCancel ");
		this.CloseWebBrowser();
		PDSDK_PC.onPcPayCancel(string.Empty);
	}

	// Token: 0x0400BC41 RID: 48193
	private WebUIComponent webBrowser;
}
