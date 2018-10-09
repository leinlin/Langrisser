using System;

// Token: 0x02001079 RID: 4217
public class SaveCmd : IDebugCmd
{
	// Token: 0x060155C5 RID: 87493 RVA: 0x0056B5C8 File Offset: 0x005697C8
	public void Execute(string strParams)
	{
		DebugConsoleMode.instance.Save();
	}

	// Token: 0x060155C6 RID: 87494 RVA: 0x0056B5D4 File Offset: 0x005697D4
	public string GetHelpDesc()
	{
		return "save : Save the current log";
	}

	// Token: 0x060155C7 RID: 87495 RVA: 0x0056B5DC File Offset: 0x005697DC
	public string GetName()
	{
		return "Save";
	}
}
