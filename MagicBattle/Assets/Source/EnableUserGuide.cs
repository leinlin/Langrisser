using System;
using BlackJack.ProjectL.UI;

// Token: 0x0200059E RID: 1438
public class EnableUserGuide : IDebugCmd
{
	// Token: 0x06005236 RID: 21046 RVA: 0x00186428 File Offset: 0x00184628
	public void Execute(string strParams)
	{
		UserGuideUITask.Enable = bool.Parse(strParams);
	}

	// Token: 0x06005237 RID: 21047 RVA: 0x00186438 File Offset: 0x00184638
	public string GetHelpDesc()
	{
		return "eug true : 启用新手引导；eug false : 关闭新手引导；";
	}

	// Token: 0x06005238 RID: 21048 RVA: 0x00186440 File Offset: 0x00184640
	public string GetName()
	{
		return "eug";
	}
}
