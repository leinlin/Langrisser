using System;

// Token: 0x02001069 RID: 4201
public class ArgsException : Exception
{
	// Token: 0x06015575 RID: 87413 RVA: 0x0056A608 File Offset: 0x00568808
	public ArgsException()
	{
	}

	// Token: 0x06015576 RID: 87414 RVA: 0x0056A61C File Offset: 0x0056881C
	public ArgsException(string message) : base(message)
	{
	}

	// Token: 0x06015577 RID: 87415 RVA: 0x0056A630 File Offset: 0x00568830
	public ArgsException(ArgsException.ErrorCode errorCode)
	{
		this._errorCode = errorCode;
	}

	// Token: 0x06015578 RID: 87416 RVA: 0x0056A64C File Offset: 0x0056884C
	public ArgsException(ArgsException.ErrorCode errorCode, string errorParameter)
	{
		this._errorCode = errorCode;
		this._errorParameter = errorParameter;
	}

	// Token: 0x06015579 RID: 87417 RVA: 0x0056A670 File Offset: 0x00568870
	public ArgsException(ArgsException.ErrorCode errorCode, string errorArgumentId, string errorParameter)
	{
		this._errorCode = errorCode;
		this._errorArgumentId = errorArgumentId;
		this._errorParameter = errorParameter;
	}

	// Token: 0x17003E54 RID: 15956
	// (get) Token: 0x0601557A RID: 87418 RVA: 0x0056A698 File Offset: 0x00568898
	// (set) Token: 0x0601557B RID: 87419 RVA: 0x0056A6A0 File Offset: 0x005688A0
	public string ErrorArgumentId
	{
		get
		{
			return this._errorArgumentId;
		}
		set
		{
			this._errorArgumentId = value;
		}
	}

	// Token: 0x17003E55 RID: 15957
	// (get) Token: 0x0601557C RID: 87420 RVA: 0x0056A6AC File Offset: 0x005688AC
	// (set) Token: 0x0601557D RID: 87421 RVA: 0x0056A6B4 File Offset: 0x005688B4
	public string ErrorParameter
	{
		get
		{
			return this._errorParameter;
		}
		set
		{
			this._errorParameter = value;
		}
	}

	// Token: 0x0601557E RID: 87422 RVA: 0x0056A6C0 File Offset: 0x005688C0
	public ArgsException.ErrorCode GetErrorCode()
	{
		return this._errorCode;
	}

	// Token: 0x0601557F RID: 87423 RVA: 0x0056A6C8 File Offset: 0x005688C8
	public void SetErrorCode(ArgsException.ErrorCode errorCode)
	{
		this._errorCode = errorCode;
	}

	// Token: 0x06015580 RID: 87424 RVA: 0x0056A6D4 File Offset: 0x005688D4
	public string ErrorMessage()
	{
		switch (this._errorCode)
		{
		case ArgsException.ErrorCode.OK:
			return "TILT: Should not get here";
		case ArgsException.ErrorCode.INVALID_ARGUMENT_FORMAT:
			return string.Format("'{0}' is not a valid argument format.", this._errorParameter);
		case ArgsException.ErrorCode.UNEXPECTED_ARGUMENT:
			return string.Format("Argument -{0} unexpected.", this._errorArgumentId);
		case ArgsException.ErrorCode.INVALID_ARGUMENT_NAME:
			return string.Format("'{0}' is not a valid argument name.", this._errorArgumentId);
		case ArgsException.ErrorCode.INVALID_ARGUMENTS_NUMBER:
			return string.Format("Invalid Arguments Number.", new object[0]);
		case ArgsException.ErrorCode.INVALID_BOOLEAN:
			return string.Format("Argument -{0} expects an boolean but was '{1}'.", this._errorArgumentId, this._errorParameter);
		case ArgsException.ErrorCode.MISSING_BOOLEAN:
			return string.Format("Could not find boolean parameter for paramIndex-{0}.", this._errorArgumentId);
		case ArgsException.ErrorCode.OVERFLOW_INTEGER32:
			return string.Format("integer32 parameter -{0} is overflow.", this._errorArgumentId);
		case ArgsException.ErrorCode.INVALID_INTEGER32:
			return string.Format("Argument -{0} expects an integer32 but was '{1}'.", this._errorArgumentId, this._errorParameter);
		case ArgsException.ErrorCode.MISSING_INTEGER32:
			return string.Format("Could not find integer32 parameter for paramIndex-{0}", this._errorArgumentId);
		case ArgsException.ErrorCode.OVERFLOW_INTEGER64:
			return string.Format("integer64 parameter -{0} is overflow.", this._errorArgumentId);
		case ArgsException.ErrorCode.INVALID_INTEGER64:
			return string.Format("Argument -{0} expects an integer64 but was '{1}'.", this._errorArgumentId, this._errorParameter);
		case ArgsException.ErrorCode.MISSING_INTEGER64:
			return string.Format("Could not find integer64 parameter for paramIndex-{0}", this._errorArgumentId);
		case ArgsException.ErrorCode.OVERFLOW_FLOAT:
			return string.Format("float parameter -{0} is overflow.", this._errorArgumentId);
		case ArgsException.ErrorCode.INVALID_FLOAT:
			return string.Format("Argument -{0} expects a float but was '{1}'", this._errorArgumentId, this._errorParameter);
		case ArgsException.ErrorCode.MISSING_FLOAT:
			return string.Format("Could not find float parameter for paramIndex-{0}", this._errorArgumentId);
		case ArgsException.ErrorCode.OVERFLOW_DOUBLE:
			return string.Format("double parameter -{0} is overflow.", this._errorArgumentId);
		case ArgsException.ErrorCode.INVALID_DOUBLE:
			return string.Format("Argument -{0} expects a double but was '{1}'", this._errorArgumentId, this._errorParameter);
		case ArgsException.ErrorCode.MISSING_DOUBLE:
			return string.Format("Could not find double parameter for paramIndex-{0}", this._errorArgumentId);
		default:
			return string.Empty;
		}
	}

	// Token: 0x0400BA14 RID: 47636
	private string _errorArgumentId = "\0";

	// Token: 0x0400BA15 RID: 47637
	private string _errorParameter;

	// Token: 0x0400BA16 RID: 47638
	private ArgsException.ErrorCode _errorCode;

	// Token: 0x0200106A RID: 4202
	public enum ErrorCode
	{
		// Token: 0x0400BA18 RID: 47640
		OK,
		// Token: 0x0400BA19 RID: 47641
		INVALID_ARGUMENT_FORMAT,
		// Token: 0x0400BA1A RID: 47642
		UNEXPECTED_ARGUMENT,
		// Token: 0x0400BA1B RID: 47643
		INVALID_ARGUMENT_NAME,
		// Token: 0x0400BA1C RID: 47644
		INVALID_ARGUMENTS_NUMBER,
		// Token: 0x0400BA1D RID: 47645
		INVALID_BOOLEAN,
		// Token: 0x0400BA1E RID: 47646
		MISSING_BOOLEAN,
		// Token: 0x0400BA1F RID: 47647
		OVERFLOW_INTEGER32,
		// Token: 0x0400BA20 RID: 47648
		INVALID_INTEGER32,
		// Token: 0x0400BA21 RID: 47649
		MISSING_INTEGER32,
		// Token: 0x0400BA22 RID: 47650
		OVERFLOW_INTEGER64,
		// Token: 0x0400BA23 RID: 47651
		INVALID_INTEGER64,
		// Token: 0x0400BA24 RID: 47652
		MISSING_INTEGER64,
		// Token: 0x0400BA25 RID: 47653
		OVERFLOW_FLOAT,
		// Token: 0x0400BA26 RID: 47654
		INVALID_FLOAT,
		// Token: 0x0400BA27 RID: 47655
		MISSING_FLOAT,
		// Token: 0x0400BA28 RID: 47656
		OVERFLOW_DOUBLE,
		// Token: 0x0400BA29 RID: 47657
		INVALID_DOUBLE,
		// Token: 0x0400BA2A RID: 47658
		MISSING_DOUBLE
	}
}
