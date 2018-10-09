using System;

// Token: 0x0200106F RID: 4207
public class Int64ArgumentMarshaler : IArgumentMarshaler
{
	// Token: 0x0601558C RID: 87436 RVA: 0x0056AA0C File Offset: 0x00568C0C
	public void Set(string currentArgument)
	{
		if (string.IsNullOrEmpty(currentArgument))
		{
			throw new ArgsException(ArgsException.ErrorCode.MISSING_INTEGER64);
		}
		try
		{
			this._int64Value = long.Parse(currentArgument);
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

	// Token: 0x0601558D RID: 87437 RVA: 0x0056AA80 File Offset: 0x00568C80
	public static long GetValue(IArgumentMarshaler am)
	{
		if (am != null && am is Int64ArgumentMarshaler)
		{
			return ((Int64ArgumentMarshaler)am)._int64Value;
		}
		return 0L;
	}

	// Token: 0x0400BA2E RID: 47662
	private long _int64Value;
}
