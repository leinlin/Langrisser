using System;

// Token: 0x0200106C RID: 4204
public class BooleanArgumentMarshaler : IArgumentMarshaler
{
	// Token: 0x06015583 RID: 87427 RVA: 0x0056A8A4 File Offset: 0x00568AA4
	public void Set(string currentArgument)
	{
		if (string.IsNullOrEmpty(currentArgument))
		{
			throw new ArgsException(ArgsException.ErrorCode.MISSING_BOOLEAN);
		}
		try
		{
			int value = int.Parse(currentArgument);
			this._booleanValue = Convert.ToBoolean(value);
		}
		catch (FormatException ex)
		{
			throw new ArgsException(ex.Message + " | " + currentArgument);
		}
	}

	// Token: 0x06015584 RID: 87428 RVA: 0x0056A904 File Offset: 0x00568B04
	public static bool GetValue(IArgumentMarshaler am)
	{
		return am != null && am is BooleanArgumentMarshaler && ((BooleanArgumentMarshaler)am)._booleanValue;
	}

	// Token: 0x0400BA2B RID: 47659
	private bool _booleanValue;
}
