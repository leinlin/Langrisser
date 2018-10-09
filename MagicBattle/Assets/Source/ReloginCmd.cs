using System;
using BlackJack.ProjectL.UI;

// Token: 0x020005A0 RID: 1440
public class ReloginCmd : IDebugCmd
{
	// Token: 0x0600523E RID: 21054 RVA: 0x001864B0 File Offset: 0x001846B0
	public void Execute(string strParams)
	{
		LoginUITask.Relogin();
	}

	// Token: 0x0600523F RID: 21055 RVA: 0x001864B8 File Offset: 0x001846B8
	public string GetHelpDesc()
	{
		return "Relogin : 重新登陆.";
	}

	// Token: 0x06005240 RID: 21056 RVA: 0x001864C0 File Offset: 0x001846C0
	public string GetName()
	{
		return "Relogin";
	}
}
