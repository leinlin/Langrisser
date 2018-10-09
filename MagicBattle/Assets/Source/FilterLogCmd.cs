using System;
using System.Collections.Generic;

// Token: 0x02001076 RID: 4214
public class FilterLogCmd : IDebugCmd
{
	// Token: 0x060155BA RID: 87482 RVA: 0x0056B4BC File Offset: 0x005696BC
	public void Execute(string strParams)
	{
		ArgumentsParser argumentsParser = new ArgumentsParser("s s", strParams);
		string @string = argumentsParser.GetString(0);
		string string2 = argumentsParser.GetString(1);
		if (@string.ToLower() == "include")
		{
			List<string> includeStrings = new List<string>(string2.Split(new char[]
			{
				';'
			}));
			DebugConsoleMode.instance.SetFilterString(includeStrings, null);
		}
		else if (@string.ToLower() == "exclude")
		{
			List<string> excludeStrings = new List<string>(string2.Split(new char[]
			{
				';'
			}));
			DebugConsoleMode.instance.SetFilterString(null, excludeStrings);
		}
		else if (@string.ToLower() == "clear")
		{
			DebugConsoleMode.instance.SetFilterString(new List<string>(), new List<string>());
		}
	}

	// Token: 0x060155BB RID: 87483 RVA: 0x0056B58C File Offset: 0x0056978C
	public string GetHelpDesc()
	{
		return "filter include [string]: set include filter string,\n filter exclude [string]: set exclude filter string\nfilter clear: clear all filters.\n filter string format: s1;s2;s3...";
	}

	// Token: 0x060155BC RID: 87484 RVA: 0x0056B594 File Offset: 0x00569794
	public string GetName()
	{
		return "filter";
	}

	// Token: 0x0400BA3D RID: 47677
	private const string _NAME = "filter";

	// Token: 0x0400BA3E RID: 47678
	private const string _DESC = "filter include [string]: set include filter string,\n filter exclude [string]: set exclude filter string\nfilter clear: clear all filters.\n filter string format: s1;s2;s3...";

	// Token: 0x0400BA3F RID: 47679
	private const string _SCHEMA = "s s";
}
