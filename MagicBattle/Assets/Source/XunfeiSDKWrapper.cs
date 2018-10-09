using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using UnityEngine;

// Token: 0x020010D3 RID: 4307
public class XunfeiSDKWrapper : MonoBehaviour
{
	// Token: 0x06015978 RID: 88440
	[DllImport("XunfeiWin")]
	private static extern bool XFWinInit(string appid, int sampleRate);

	// Token: 0x06015979 RID: 88441
	[DllImport("XunfeiWin")]
	private static extern void XFWinTickRecognize(float time, float deltaTime);

	// Token: 0x0601597A RID: 88442
	[DllImport("XunfeiWin")]
	private static extern bool XFWinRequestRecognize(string audioFilepath);

	// Token: 0x0601597B RID: 88443
	[DllImport("XunfeiWin")]
	private static extern int XFWinGetRecognizeIntState();

	// Token: 0x0601597C RID: 88444
	[DllImport("XunfeiWin")]
	private static extern IntPtr XFWinGetRecognizeResultPtr();

	// Token: 0x0601597D RID: 88445
	[DllImport("XunfeiWin")]
	private static extern IntPtr XFWinGetErrorPtr();

	// Token: 0x0601597E RID: 88446 RVA: 0x0057FF88 File Offset: 0x0057E188
	private XunfeiSDKWrapper.XFWinStatus XFWinGetRecognizeState()
	{
		return (XunfeiSDKWrapper.XFWinStatus)XunfeiSDKWrapper.XFWinGetRecognizeIntState();
	}

	// Token: 0x0601597F RID: 88447 RVA: 0x0057FF90 File Offset: 0x0057E190
	private string XFWinGetRecognizeResult()
	{
		return Marshal.PtrToStringAnsi(XunfeiSDKWrapper.XFWinGetRecognizeResultPtr());
	}

	// Token: 0x06015980 RID: 88448 RVA: 0x0057FF9C File Offset: 0x0057E19C
	private string XFWinGetError()
	{
		return Marshal.PtrToStringAnsi(XunfeiSDKWrapper.XFWinGetErrorPtr());
	}

	// Token: 0x06015981 RID: 88449 RVA: 0x0057FFA8 File Offset: 0x0057E1A8
	public void InitSDK(string appID, int sampleRate)
	{
		try
		{
			if (!XunfeiSDKWrapper.XFWinInit(appID, sampleRate))
			{
				global::Debug.LogError(string.Format("XunfeiSDKWrapper.InitSDK XFWinInit failed, {0}", this.XFWinGetError()));
			}
			else
			{
				XunfeiSDKWrapper.m_isXFInit = true;
			}
		}
		catch (Exception ex)
		{
			global::Debug.LogError(string.Format("XFWinInit exception: {0}", ex.Message));
		}
	}

	// Token: 0x06015982 RID: 88450 RVA: 0x00580014 File Offset: 0x0057E214
	public void StartRecord()
	{
		if (!XunfeiSDKWrapper.m_isXFInit)
		{
			return;
		}
	}

	// Token: 0x06015983 RID: 88451 RVA: 0x00580024 File Offset: 0x0057E224
	public void StopRecord(string audioFilePath)
	{
		if (!XunfeiSDKWrapper.m_isXFInit)
		{
			this.OnSpeechRecognizeFailed();
			return;
		}
		if (XunfeiSDKWrapper.m_isXFInit)
		{
			if (!XunfeiSDKWrapper.XFWinRequestRecognize(audioFilePath))
			{
				this.OnRecognizeFailed(this.XFWinGetError());
			}
		}
		else
		{
			this.OnRecognizeFailed("m_isXFWinInit = false.");
		}
	}

	// Token: 0x06015984 RID: 88452 RVA: 0x00580078 File Offset: 0x0057E278
	public void OnAudioRecognized(string rst)
	{
		global::Debug.Log(string.Format("XunfeiSDKWrapper.OnAduioRecognized {0}", rst));
		if (this.OnSpeechRecognized != null)
		{
			this.OnSpeechRecognized(rst);
		}
	}

	// Token: 0x06015985 RID: 88453 RVA: 0x005800A4 File Offset: 0x0057E2A4
	public void OnRecognizeFailed(string rst)
	{
		global::Debug.LogError(string.Format("XunfeiSDKWrapper.OnRecognizeFailed {0}", rst));
		if (this.OnSpeechRecognizeFailed != null)
		{
			this.OnSpeechRecognizeFailed();
		}
	}

	// Token: 0x06015986 RID: 88454 RVA: 0x005800CC File Offset: 0x0057E2CC
	private void Update()
	{
		if (!XunfeiSDKWrapper.m_isXFInit)
		{
			return;
		}
		XunfeiSDKWrapper.XFWinStatus xfwinStatus = this.XFWinGetRecognizeState();
		if (xfwinStatus == XunfeiSDKWrapper.XFWinStatus.COMPLETE)
		{
			return;
		}
		XunfeiSDKWrapper.XFWinTickRecognize(Time.unscaledTime, Time.unscaledDeltaTime);
		xfwinStatus = this.XFWinGetRecognizeState();
		string text = this.XFWinGetError();
		if (xfwinStatus == XunfeiSDKWrapper.XFWinStatus.COMPLETE)
		{
			this.OnAudioRecognized(this.XFWinGetRecognizeResult());
		}
		else if (!string.IsNullOrEmpty(text))
		{
			this.OnRecognizeFailed(text);
		}
	}

	// Token: 0x140004D3 RID: 1235
	// (add) Token: 0x06015987 RID: 88455 RVA: 0x0058013C File Offset: 0x0057E33C
	// (remove) Token: 0x06015988 RID: 88456 RVA: 0x00580174 File Offset: 0x0057E374
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public event Action<string> OnSpeechRecognized;

	// Token: 0x140004D4 RID: 1236
	// (add) Token: 0x06015989 RID: 88457 RVA: 0x005801AC File Offset: 0x0057E3AC
	// (remove) Token: 0x0601598A RID: 88458 RVA: 0x005801E4 File Offset: 0x0057E3E4
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public event Action OnSpeechRecognizeFailed;

	// Token: 0x0400BCAD RID: 48301
	private static bool m_isXFInit;

	// Token: 0x020010D4 RID: 4308
	private enum XFWinStatus
	{
		// Token: 0x0400BCB1 RID: 48305
		SUCCESS,
		// Token: 0x0400BCB2 RID: 48306
		NO_MATCH,
		// Token: 0x0400BCB3 RID: 48307
		INCOMPLETE,
		// Token: 0x0400BCB4 RID: 48308
		NON_SPEECH_DETECTED,
		// Token: 0x0400BCB5 RID: 48309
		SPEECH_DETECTED,
		// Token: 0x0400BCB6 RID: 48310
		COMPLETE,
		// Token: 0x0400BCB7 RID: 48311
		MAX_CPU_TIME,
		// Token: 0x0400BCB8 RID: 48312
		MAX_SPEECH,
		// Token: 0x0400BCB9 RID: 48313
		STOPPED,
		// Token: 0x0400BCBA RID: 48314
		REJECTED,
		// Token: 0x0400BCBB RID: 48315
		NO_SPEECH_FOUND,
		// Token: 0x0400BCBC RID: 48316
		FAILURE = 1
	}
}
