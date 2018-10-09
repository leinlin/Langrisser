using System;

// Token: 0x02001077 RID: 4215
public class HelpCmd : IDebugCmd
{
	// Token: 0x060155BE RID: 87486 RVA: 0x0056B5A4 File Offset: 0x005697A4
	public void Execute(string strParams)
	{
		DebugCmdManager.instance.PringAllCmdDescription();
	}

	// Token: 0x060155BF RID: 87487 RVA: 0x0056B5B0 File Offset: 0x005697B0
	public string GetHelpDesc()
	{
		return "help: print all command's description";
	}

	// Token: 0x060155C0 RID: 87488 RVA: 0x0056B5B8 File Offset: 0x005697B8
	public string GetName()
	{
		return "help";
	}

	// Token: 0x0400BA40 RID: 47680
	public const string _NAME = "help";

	// Token: 0x0400BA41 RID: 47681
	public const string _DESC = "help: print all command's description";
}
