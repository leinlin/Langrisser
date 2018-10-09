using System;

// Token: 0x0200106E RID: 4206
public class Int32ArgumentMarshaler : IArgumentMarshaler
{
	// Token: 0x06015589 RID: 87433 RVA: 0x0056A970 File Offset: 0x00568B70
	public void Set(string currentArgument)
	{
		if (string.IsNullOrEmpty(currentArgument))
		{
			throw new ArgsException(ArgsException.ErrorCode.MISSING_INTEGER32);
		}
		try
		{
			this._int32Value = int.Parse(currentArgument);
		}
		catch (OverflowException ex)
		{
			throw new ArgsException(ex.Message);
		}
		catch (FormatException ex2)
		{
			throw new ArgsException(ex2.Message + " | " + currentArgument);
		}
	}

	// Token: 0x0601558A RID: 87434 RVA: 0x0056A9E4 File Offset: 0x00568BE4
	public static int GetValue(IArgumentMarshaler am)
	{
		if (am != null && am is Int32ArgumentMarshaler)
		{
			return ((Int32ArgumentMarshaler)am)._int32Value;
		}
		return 0;
	}

	// Token: 0x0400BA2D RID: 47661
	private int _int32Value;
}
