using System;
using BlackJack.ProjectL.UI;

// Token: 0x020005A1 RID: 1441
public class RunGMCommandCmd : IDebugCmd
{
	// Token: 0x06005242 RID: 21058 RVA: 0x001864D0 File Offset: 0x001846D0
	public void Execute(string strParams)
	{
		TestUI.SendGMCommand(strParams);
	}

	// Token: 0x06005243 RID: 21059 RVA: 0x001864D8 File Offset: 0x001846D8
	public string GetHelpDesc()
	{
		return "Rgc CLEAN_USER_GUIDE 1,2,3 : 执行管理员指令";
	}

	// Token: 0x06005244 RID: 21060 RVA: 0x001864E0 File Offset: 0x001846E0
	public string GetName()
	{
		return "Rgc";
	}
}
