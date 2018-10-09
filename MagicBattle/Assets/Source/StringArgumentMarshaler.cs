using System;

// Token: 0x0200106D RID: 4205
public class StringArgumentMarshaler : IArgumentMarshaler
{
	// Token: 0x06015586 RID: 87430 RVA: 0x0056A938 File Offset: 0x00568B38
	public void Set(string currentArgument)
	{
		this._stringValue = currentArgument;
	}

	// Token: 0x06015587 RID: 87431 RVA: 0x0056A944 File Offset: 0x00568B44
	public static string GetValue(IArgumentMarshaler am)
	{
		if (am != null && am is StringArgumentMarshaler)
		{
			return ((StringArgumentMarshaler)am)._stringValue;
		}
		return string.Empty;
	}

	// Token: 0x0400BA2C RID: 47660
	private string _stringValue = string.Empty;
}
