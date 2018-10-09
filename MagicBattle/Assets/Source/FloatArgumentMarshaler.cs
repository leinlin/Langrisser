using System;

// Token: 0x02001070 RID: 4208
public class FloatArgumentMarshaler : IArgumentMarshaler
{
	// Token: 0x0601558F RID: 87439 RVA: 0x0056AAAC File Offset: 0x00568CAC
	public void Set(string currentArgument)
	{
		if (string.IsNullOrEmpty(currentArgument))
		{
			throw new ArgsException(ArgsException.ErrorCode.MISSING_FLOAT);
		}
		try
		{
			this._floatValue = float.Parse(currentArgument);
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

	// Token: 0x06015590 RID: 87440 RVA: 0x0056AB20 File Offset: 0x00568D20
	public static float GetValue(IArgumentMarshaler am)
	{
		if (am != null && am is FloatArgumentMarshaler)
		{
			return ((FloatArgumentMarshaler)am)._floatValue;
		}
		return 0f;
	}

	// Token: 0x0400BA2F RID: 47663
	private float _floatValue;
}
