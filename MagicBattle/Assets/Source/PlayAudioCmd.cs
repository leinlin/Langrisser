using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.Misc;

// Token: 0x0200059F RID: 1439
public class PlayAudioCmd : IDebugCmd
{
	// Token: 0x0600523A RID: 21050 RVA: 0x00186450 File Offset: 0x00184650
	public void Execute(string strParams)
	{
		ArgumentsParser argumentsParser = new ArgumentsParser("s", strParams);
		IAudioPlayback audioPlayback = AudioUtility.PlaySound(argumentsParser.GetString(0));
		if (audioPlayback != null)
		{
			Debug.Log(string.Format("sound length: {0} seconds.", audioPlayback.Seconds));
		}
	}

	// Token: 0x0600523B RID: 21051 RVA: 0x00186498 File Offset: 0x00184698
	public string GetHelpDesc()
	{
		return "pa Music_Login_1 : 播放音乐.";
	}

	// Token: 0x0600523C RID: 21052 RVA: 0x001864A0 File Offset: 0x001846A0
	public string GetName()
	{
		return "pa";
	}
}
