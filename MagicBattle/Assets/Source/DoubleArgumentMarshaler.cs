using System;

// Token: 0x02001071 RID: 4209
public class DoubleArgumentMarshaler : IArgumentMarshaler
{
	// Token: 0x06015592 RID: 87442 RVA: 0x0056AB4C File Offset: 0x00568D4C
	public void Set(string currentArgument)
	{
		if (string.IsNullOrEmpty(currentArgument))
		{
			throw new ArgsException(ArgsException.ErrorCode.MISSING_DOUBLE);
		}
		try
		{
			this._doubleValue = double.Parse(currentArgument);
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

	// Token: 0x06015593 RID: 87443 RVA: 0x0056ABC0 File Offset: 0x00568DC0
	public static double GetValue(IArgumentMarshaler am)
	{
		if (am != null && am is DoubleArgumentMarshaler)
		{
			return ((DoubleArgumentMarshaler)am)._doubleValue;
		}
		return 0.0;
	}

	// Token: 0x0400BA30 RID: 47664
	private double _doubleValue;
}
