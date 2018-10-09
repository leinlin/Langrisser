using System;

// Token: 0x0200107A RID: 4218
public class SetFontSizeCmd : IDebugCmd
{
	// Token: 0x060155C9 RID: 87497 RVA: 0x0056B5EC File Offset: 0x005697EC
	public void Execute(string strParams)
	{
		ArgumentsParser argumentsParser = new ArgumentsParser("i", strParams);
		DebugConsoleView.instance.SetFontSize(argumentsParser.GetInt32(0));
	}

	// Token: 0x060155CA RID: 87498 RVA: 0x0056B618 File Offset: 0x00569818
	public string GetHelpDesc()
	{
		return "sfs [int]: set the font size of debug console.";
	}

	// Token: 0x060155CB RID: 87499 RVA: 0x0056B620 File Offset: 0x00569820
	public string GetName()
	{
		return "sfs";
	}

	// Token: 0x0400BA42 RID: 47682
	private const string _NAME = "sfs";

	// Token: 0x0400BA43 RID: 47683
	private const string _DESC = "sfs [int]: set the font size of debug console.";

	// Token: 0x0400BA44 RID: 47684
	private const string _SCHEMA = "i";
}
