using System;
using System.Collections.Generic;

// Token: 0x02001072 RID: 4210
public class ArgumentsParser
{
	// Token: 0x06015594 RID: 87444 RVA: 0x0056ABE8 File Offset: 0x00568DE8
	public ArgumentsParser(string schema, string args)
	{
		this._marshalers = new Dictionary<string, IArgumentMarshaler>();
		string[] argsArray = args.Split(new char[]
		{
			' '
		});
		string[] array = schema.Split(new char[]
		{
			' '
		});
		if (!this._ValidArgumentsNumber(array, argsArray))
		{
			throw new ArgsException(ArgsException.ErrorCode.INVALID_ARGUMENTS_NUMBER);
		}
		this._schemaElementNum = array.Length;
		this._ParseSchema(array);
		this._ParseArguments(argsArray);
	}

	// Token: 0x17003E56 RID: 15958
	// (get) Token: 0x06015595 RID: 87445 RVA: 0x0056AC58 File Offset: 0x00568E58
	public int SchemaElementNum
	{
		get
		{
			return this._schemaElementNum;
		}
	}

	// Token: 0x06015596 RID: 87446 RVA: 0x0056AC60 File Offset: 0x00568E60
	private bool _ValidArgumentsNumber(string[] schemaElementArray, string[] argsArray)
	{
		return argsArray.Length <= schemaElementArray.Length && (schemaElementArray.Length != 1 || !string.IsNullOrEmpty(schemaElementArray[0]));
	}

	// Token: 0x06015597 RID: 87447 RVA: 0x0056AC88 File Offset: 0x00568E88
	private void _ParseSchema(string[] schemaElementArray)
	{
		for (int i = 0; i < schemaElementArray.Length; i++)
		{
			this._ParseSchemaElement(i, schemaElementArray[i].Trim());
		}
	}

	// Token: 0x06015598 RID: 87448 RVA: 0x0056ACB8 File Offset: 0x00568EB8
	private void _ParseSchemaElement(int index, string element)
	{
		string key = index.ToString();
		if (string.Equals(element, "b"))
		{
			this._marshalers.Add(key, new BooleanArgumentMarshaler());
		}
		else if (string.Equals(element, "i"))
		{
			this._marshalers.Add(key, new Int32ArgumentMarshaler());
		}
		else if (string.Equals(element, "l"))
		{
			this._marshalers.Add(key, new Int64ArgumentMarshaler());
		}
		else if (string.Equals(element, "f"))
		{
			this._marshalers.Add(key, new FloatArgumentMarshaler());
		}
		else if (string.Equals(element, "d"))
		{
			this._marshalers.Add(key, new DoubleArgumentMarshaler());
		}
		else
		{
			if (!string.Equals(element, "s"))
			{
				throw new ArgsException(ArgsException.ErrorCode.INVALID_ARGUMENT_FORMAT, element);
			}
			this._marshalers.Add(key, new StringArgumentMarshaler());
		}
	}

	// Token: 0x06015599 RID: 87449 RVA: 0x0056ADC0 File Offset: 0x00568FC0
	private void _ParseArguments(string[] argsArray)
	{
		for (int i = 0; i < argsArray.Length; i++)
		{
			IArgumentMarshaler argumentMarshaler = this._marshalers[i.ToString()];
			if (argumentMarshaler == null)
			{
				throw new ArgsException(ArgsException.ErrorCode.UNEXPECTED_ARGUMENT, i.ToString(), null);
			}
			try
			{
				argumentMarshaler.Set(argsArray[i]);
			}
			catch (ArgsException ex)
			{
				ex.ErrorArgumentId = i.ToString();
				throw ex;
			}
		}
	}

	// Token: 0x0601559A RID: 87450 RVA: 0x0056AE4C File Offset: 0x0056904C
	public bool GetBoolean(int index)
	{
		return BooleanArgumentMarshaler.GetValue(this._marshalers[index.ToString()]);
	}

	// Token: 0x0601559B RID: 87451 RVA: 0x0056AE6C File Offset: 0x0056906C
	public int GetInt32(int index)
	{
		return Int32ArgumentMarshaler.GetValue(this._marshalers[index.ToString()]);
	}

	// Token: 0x0601559C RID: 87452 RVA: 0x0056AE8C File Offset: 0x0056908C
	public long GetInt64(int index)
	{
		return Int64ArgumentMarshaler.GetValue(this._marshalers[index.ToString()]);
	}

	// Token: 0x0601559D RID: 87453 RVA: 0x0056AEAC File Offset: 0x005690AC
	public float GetFloat(int index)
	{
		return FloatArgumentMarshaler.GetValue(this._marshalers[index.ToString()]);
	}

	// Token: 0x0601559E RID: 87454 RVA: 0x0056AECC File Offset: 0x005690CC
	public double GetDouble(int index)
	{
		return DoubleArgumentMarshaler.GetValue(this._marshalers[index.ToString()]);
	}

	// Token: 0x0601559F RID: 87455 RVA: 0x0056AEEC File Offset: 0x005690EC
	public string GetString(int index)
	{
		return StringArgumentMarshaler.GetValue(this._marshalers[index.ToString()]);
	}

	// Token: 0x0400BA31 RID: 47665
	private Dictionary<string, IArgumentMarshaler> _marshalers;

	// Token: 0x0400BA32 RID: 47666
	private int _schemaElementNum;

	// Token: 0x0400BA33 RID: 47667
	private const char ARG_SEPARATOR = ' ';
}
