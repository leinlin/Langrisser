using System;

// Token: 0x0200108F RID: 4239
public class JsonException : ApplicationException
{
	// Token: 0x060156D5 RID: 87765 RVA: 0x0056EBC8 File Offset: 0x0056CDC8
	public JsonException()
	{
	}

	// Token: 0x060156D6 RID: 87766 RVA: 0x0056EBD0 File Offset: 0x0056CDD0
	internal JsonException(ParserToken token) : base(string.Format("Invalid token '{0}' in input string", token))
	{
	}

	// Token: 0x060156D7 RID: 87767 RVA: 0x0056EBE8 File Offset: 0x0056CDE8
	internal JsonException(ParserToken token, Exception inner_exception) : base(string.Format("Invalid token '{0}' in input string", token), inner_exception)
	{
	}

	// Token: 0x060156D8 RID: 87768 RVA: 0x0056EC04 File Offset: 0x0056CE04
	internal JsonException(int c) : base(string.Format("Invalid character '{0}' in input string", (char)c))
	{
	}

	// Token: 0x060156D9 RID: 87769 RVA: 0x0056EC20 File Offset: 0x0056CE20
	internal JsonException(int c, Exception inner_exception) : base(string.Format("Invalid character '{0}' in input string", (char)c), inner_exception)
	{
	}

	// Token: 0x060156DA RID: 87770 RVA: 0x0056EC3C File Offset: 0x0056CE3C
	public JsonException(string message) : base(message)
	{
	}

	// Token: 0x060156DB RID: 87771 RVA: 0x0056EC48 File Offset: 0x0056CE48
	public JsonException(string message, Exception inner_exception) : base(message, inner_exception)
	{
	}
}
