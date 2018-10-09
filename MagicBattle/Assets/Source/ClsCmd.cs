using System;

// Token: 0x02001074 RID: 4212
public class ClsCmd : IDebugCmd
{
	// Token: 0x060155A5 RID: 87461 RVA: 0x0056AF6C File Offset: 0x0056916C
	public void Execute(string strParams)
	{
		DebugConsoleMode.instance.ClearLog();
	}

	// Token: 0x060155A6 RID: 87462 RVA: 0x0056AF78 File Offset: 0x00569178
	public string GetHelpDesc()
	{
		return "cls: clear console screen.";
	}

	// Token: 0x060155A7 RID: 87463 RVA: 0x0056AF80 File Offset: 0x00569180
	public string GetName()
	{
		return "cls";
	}

	// Token: 0x0400BA37 RID: 47671
	private const string _NAME = "cls";

	// Token: 0x0400BA38 RID: 47672
	private const string _DESC = "cls: clear console screen.";
}
