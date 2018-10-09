using System;

// Token: 0x02001073 RID: 4211
public class AddCmd : IDebugCmd
{
	// Token: 0x060155A1 RID: 87457 RVA: 0x0056AF14 File Offset: 0x00569114
	public void Execute(string strParams)
	{
		ArgumentsParser argumentsParser = new ArgumentsParser("i i", strParams);
		int @int = argumentsParser.GetInt32(0);
		int int2 = argumentsParser.GetInt32(1);
		Debug.Log((@int + int2).ToString());
	}

	// Token: 0x060155A2 RID: 87458 RVA: 0x0056AF54 File Offset: 0x00569154
	public string GetHelpDesc()
	{
		return "intadd [int] [int]: add two int num.";
	}

	// Token: 0x060155A3 RID: 87459 RVA: 0x0056AF5C File Offset: 0x0056915C
	public string GetName()
	{
		return "intadd";
	}

	// Token: 0x0400BA34 RID: 47668
	private const string _NAME = "intadd";

	// Token: 0x0400BA35 RID: 47669
	private const string _DESC = "intadd [int] [int]: add two int num.";

	// Token: 0x0400BA36 RID: 47670
	private const string _SCHEMA = "i i";
}
