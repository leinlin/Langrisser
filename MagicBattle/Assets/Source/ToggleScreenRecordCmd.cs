using System;
using BlackJack.ProjectL.UI;

// Token: 0x020005A5 RID: 1445
public class ToggleScreenRecordCmd : IDebugCmd
{
	// Token: 0x06005255 RID: 21077 RVA: 0x001869F0 File Offset: 0x00184BF0
	public void Execute(string strParams)
	{
		if (CommonUIController.Instance == null)
		{
			return;
		}
		CommonUIController.Instance.EnableScreenRecordFunction = !CommonUIController.Instance.EnableScreenRecordFunction;
	}

	// Token: 0x06005256 RID: 21078 RVA: 0x00186A1C File Offset: 0x00184C1C
	public string GetHelpDesc()
	{
		return "tsr : 切换IOS录屏功能开关.";
	}

	// Token: 0x06005257 RID: 21079 RVA: 0x00186A24 File Offset: 0x00184C24
	public string GetName()
	{
		return "tsr";
	}
}
