using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

// Token: 0x0200109F RID: 4255
public class JsonWriter
{
	// Token: 0x06015748 RID: 87880 RVA: 0x00570DF8 File Offset: 0x0056EFF8
	public JsonWriter()
	{
		this.inst_string_builder = new StringBuilder();
		this.writer = new StringWriter(this.inst_string_builder);
		this.Init();
	}

	// Token: 0x06015749 RID: 87881 RVA: 0x00570E24 File Offset: 0x0056F024
	public JsonWriter(StringBuilder sb) : this(new StringWriter(sb))
	{
	}

	// Token: 0x0601574A RID: 87882 RVA: 0x00570E34 File Offset: 0x0056F034
	public JsonWriter(TextWriter writer)
	{
		if (writer == null)
		{
			throw new ArgumentNullException("writer");
		}
		this.writer = writer;
		this.Init();
	}

	// Token: 0x17003E9E RID: 16030
	// (get) Token: 0x0601574B RID: 87883 RVA: 0x00570E5C File Offset: 0x0056F05C
	// (set) Token: 0x0601574C RID: 87884 RVA: 0x00570E64 File Offset: 0x0056F064
	public int IndentValue
	{
		get
		{
			return this.indent_value;
		}
		set
		{
			this.indentation = this.indentation / this.indent_value * value;
			this.indent_value = value;
		}
	}

	// Token: 0x17003E9F RID: 16031
	// (get) Token: 0x0601574D RID: 87885 RVA: 0x00570E84 File Offset: 0x0056F084
	// (set) Token: 0x0601574E RID: 87886 RVA: 0x00570E8C File Offset: 0x0056F08C
	public bool PrettyPrint
	{
		get
		{
			return this.pretty_print;
		}
		set
		{
			this.pretty_print = value;
		}
	}

	// Token: 0x17003EA0 RID: 16032
	// (get) Token: 0x0601574F RID: 87887 RVA: 0x00570E98 File Offset: 0x0056F098
	public TextWriter TextWriter
	{
		get
		{
			return this.writer;
		}
	}

	// Token: 0x17003EA1 RID: 16033
	// (get) Token: 0x06015750 RID: 87888 RVA: 0x00570EA0 File Offset: 0x0056F0A0
	// (set) Token: 0x06015751 RID: 87889 RVA: 0x00570EA8 File Offset: 0x0056F0A8
	public bool Validate
	{
		get
		{
			return this.validate;
		}
		set
		{
			this.validate = value;
		}
	}

	// Token: 0x06015752 RID: 87890 RVA: 0x00570EB4 File Offset: 0x0056F0B4
	private void DoValidation(Condition cond)
	{
		if (!this.context.ExpectingValue)
		{
			this.context.Count++;
		}
		if (!this.validate)
		{
			return;
		}
		if (this.has_reached_end)
		{
			throw new JsonException("A complete JSON symbol has already been written");
		}
		switch (cond)
		{
		case Condition.InArray:
			if (!this.context.InArray)
			{
				throw new JsonException("Can't close an array here");
			}
			break;
		case Condition.InObject:
			if (!this.context.InObject || this.context.ExpectingValue)
			{
				throw new JsonException("Can't close an object here");
			}
			break;
		case Condition.NotAProperty:
			if (this.context.InObject && !this.context.ExpectingValue)
			{
				throw new JsonException("Expected a property");
			}
			break;
		case Condition.Property:
			if (!this.context.InObject || this.context.ExpectingValue)
			{
				throw new JsonException("Can't add a property here");
			}
			break;
		case Condition.Value:
			if (!this.context.InArray && (!this.context.InObject || !this.context.ExpectingValue))
			{
				throw new JsonException("Can't add a value here");
			}
			break;
		}
	}

	// Token: 0x06015753 RID: 87891 RVA: 0x00571018 File Offset: 0x0056F218
	private void Init()
	{
		this.has_reached_end = false;
		this.hex_seq = new char[4];
		this.indentation = 0;
		this.indent_value = 4;
		this.pretty_print = false;
		this.validate = true;
		this.ctx_stack = new Stack<WriterContext>();
		this.context = new WriterContext();
		this.ctx_stack.Push(this.context);
	}

	// Token: 0x06015754 RID: 87892 RVA: 0x0057107C File Offset: 0x0056F27C
	private static void IntToHex(int n, char[] hex)
	{
		for (int i = 0; i < 4; i++)
		{
			int num = n % 16;
			if (num < 10)
			{
				hex[3 - i] = (char)(48 + num);
			}
			else
			{
				hex[3 - i] = (char)(65 + (num - 10));
			}
			n >>= 4;
		}
	}

	// Token: 0x06015755 RID: 87893 RVA: 0x005710CC File Offset: 0x0056F2CC
	private void Indent()
	{
		if (this.pretty_print)
		{
			this.indentation += this.indent_value;
		}
	}

	// Token: 0x06015756 RID: 87894 RVA: 0x005710EC File Offset: 0x0056F2EC
	private void Put(string str)
	{
		if (this.pretty_print && !this.context.ExpectingValue)
		{
			for (int i = 0; i < this.indentation; i++)
			{
				this.writer.Write(' ');
			}
		}
		this.writer.Write(str);
	}

	// Token: 0x06015757 RID: 87895 RVA: 0x00571144 File Offset: 0x0056F344
	private void PutNewline()
	{
		this.PutNewline(true);
	}

	// Token: 0x06015758 RID: 87896 RVA: 0x00571150 File Offset: 0x0056F350
	private void PutNewline(bool add_comma)
	{
		if (add_comma && !this.context.ExpectingValue && this.context.Count > 1)
		{
			this.writer.Write(',');
		}
		if (this.pretty_print && !this.context.ExpectingValue)
		{
			this.writer.Write('\n');
		}
	}

	// Token: 0x06015759 RID: 87897 RVA: 0x005711BC File Offset: 0x0056F3BC
	private void PutString(string str)
	{
		this.Put(string.Empty);
		this.writer.Write('"');
		int length = str.Length;
		for (int i = 0; i < length; i++)
		{
			char c = str[i];
			switch (c)
			{
			case '\b':
				this.writer.Write("\\b");
				break;
			case '\t':
				this.writer.Write("\\t");
				break;
			case '\n':
				this.writer.Write("\\n");
				break;
			default:
				if (c != '"' && c != '\\')
				{
					if (str[i] >= ' ' && str[i] <= '~')
					{
						this.writer.Write(str[i]);
					}
					else
					{
						JsonWriter.IntToHex((int)str[i], this.hex_seq);
						this.writer.Write("\\u");
						this.writer.Write(this.hex_seq);
					}
				}
				else
				{
					this.writer.Write('\\');
					this.writer.Write(str[i]);
				}
				break;
			case '\f':
				this.writer.Write("\\f");
				break;
			case '\r':
				this.writer.Write("\\r");
				break;
			}
		}
		this.writer.Write('"');
	}

	// Token: 0x0601575A RID: 87898 RVA: 0x00571338 File Offset: 0x0056F538
	private void Unindent()
	{
		if (this.pretty_print)
		{
			this.indentation -= this.indent_value;
		}
	}

	// Token: 0x0601575B RID: 87899 RVA: 0x00571358 File Offset: 0x0056F558
	public override string ToString()
	{
		if (this.inst_string_builder == null)
		{
			return string.Empty;
		}
		return this.inst_string_builder.ToString();
	}

	// Token: 0x0601575C RID: 87900 RVA: 0x00571378 File Offset: 0x0056F578
	public void Reset()
	{
		this.has_reached_end = false;
		this.ctx_stack.Clear();
		this.context = new WriterContext();
		this.ctx_stack.Push(this.context);
		if (this.inst_string_builder != null)
		{
			this.inst_string_builder.Remove(0, this.inst_string_builder.Length);
		}
	}

	// Token: 0x0601575D RID: 87901 RVA: 0x005713D8 File Offset: 0x0056F5D8
	public void Write(bool boolean)
	{
		this.DoValidation(Condition.Value);
		this.PutNewline();
		this.Put((!boolean) ? "false" : "true");
		this.context.ExpectingValue = false;
	}

	// Token: 0x0601575E RID: 87902 RVA: 0x00571410 File Offset: 0x0056F610
	public void Write(decimal number)
	{
		this.DoValidation(Condition.Value);
		this.PutNewline();
		this.Put(Convert.ToString(number, JsonWriter.number_format));
		this.context.ExpectingValue = false;
	}

	// Token: 0x0601575F RID: 87903 RVA: 0x0057143C File Offset: 0x0056F63C
	public void Write(double number)
	{
		this.DoValidation(Condition.Value);
		this.PutNewline();
		string text = Convert.ToString(number, JsonWriter.number_format);
		this.Put(text);
		if (text.IndexOf('.') == -1 && text.IndexOf('E') == -1)
		{
			this.writer.Write(".0");
		}
		this.context.ExpectingValue = false;
	}

	// Token: 0x06015760 RID: 87904 RVA: 0x005714A4 File Offset: 0x0056F6A4
	public void Write(int number)
	{
		this.DoValidation(Condition.Value);
		this.PutNewline();
		this.Put(Convert.ToString(number, JsonWriter.number_format));
		this.context.ExpectingValue = false;
	}

	// Token: 0x06015761 RID: 87905 RVA: 0x005714D0 File Offset: 0x0056F6D0
	public void Write(long number)
	{
		this.DoValidation(Condition.Value);
		this.PutNewline();
		this.Put(Convert.ToString(number, JsonWriter.number_format));
		this.context.ExpectingValue = false;
	}

	// Token: 0x06015762 RID: 87906 RVA: 0x005714FC File Offset: 0x0056F6FC
	public void Write(string str)
	{
		this.DoValidation(Condition.Value);
		this.PutNewline();
		if (str == null)
		{
			this.Put("null");
		}
		else
		{
			this.PutString(str);
		}
		this.context.ExpectingValue = false;
	}

	// Token: 0x06015763 RID: 87907 RVA: 0x00571534 File Offset: 0x0056F734
	public void Write(ulong number)
	{
		this.DoValidation(Condition.Value);
		this.PutNewline();
		this.Put(Convert.ToString(number, JsonWriter.number_format));
		this.context.ExpectingValue = false;
	}

	// Token: 0x06015764 RID: 87908 RVA: 0x00571560 File Offset: 0x0056F760
	public void WriteArrayEnd()
	{
		this.DoValidation(Condition.InArray);
		this.PutNewline(false);
		this.ctx_stack.Pop();
		if (this.ctx_stack.Count == 1)
		{
			this.has_reached_end = true;
		}
		else
		{
			this.context = this.ctx_stack.Peek();
			this.context.ExpectingValue = false;
		}
		this.Unindent();
		this.Put("]");
	}

	// Token: 0x06015765 RID: 87909 RVA: 0x005715D4 File Offset: 0x0056F7D4
	public void WriteArrayStart()
	{
		this.DoValidation(Condition.NotAProperty);
		this.PutNewline();
		this.Put("[");
		this.context = new WriterContext();
		this.context.InArray = true;
		this.ctx_stack.Push(this.context);
		this.Indent();
	}

	// Token: 0x06015766 RID: 87910 RVA: 0x00571628 File Offset: 0x0056F828
	public void WriteObjectEnd()
	{
		this.DoValidation(Condition.InObject);
		this.PutNewline(false);
		this.ctx_stack.Pop();
		if (this.ctx_stack.Count == 1)
		{
			this.has_reached_end = true;
		}
		else
		{
			this.context = this.ctx_stack.Peek();
			this.context.ExpectingValue = false;
		}
		this.Unindent();
		this.Put("}");
	}

	// Token: 0x06015767 RID: 87911 RVA: 0x0057169C File Offset: 0x0056F89C
	public void WriteObjectStart()
	{
		this.DoValidation(Condition.NotAProperty);
		this.PutNewline();
		this.Put("{");
		this.context = new WriterContext();
		this.context.InObject = true;
		this.ctx_stack.Push(this.context);
		this.Indent();
	}

	// Token: 0x06015768 RID: 87912 RVA: 0x005716F0 File Offset: 0x0056F8F0
	public void WritePropertyName(string property_name)
	{
		this.DoValidation(Condition.Property);
		this.PutNewline();
		this.PutString(property_name);
		if (this.pretty_print)
		{
			if (property_name.Length > this.context.Padding)
			{
				this.context.Padding = property_name.Length;
			}
			for (int i = this.context.Padding - property_name.Length; i >= 0; i--)
			{
				this.writer.Write(' ');
			}
			this.writer.Write(": ");
		}
		else
		{
			this.writer.Write(':');
		}
		this.context.ExpectingValue = true;
	}

	// Token: 0x0400BB0F RID: 47887
	private static NumberFormatInfo number_format = NumberFormatInfo.InvariantInfo;

	// Token: 0x0400BB10 RID: 47888
	private WriterContext context;

	// Token: 0x0400BB11 RID: 47889
	private Stack<WriterContext> ctx_stack;

	// Token: 0x0400BB12 RID: 47890
	private bool has_reached_end;

	// Token: 0x0400BB13 RID: 47891
	private char[] hex_seq;

	// Token: 0x0400BB14 RID: 47892
	private int indentation;

	// Token: 0x0400BB15 RID: 47893
	private int indent_value;

	// Token: 0x0400BB16 RID: 47894
	private StringBuilder inst_string_builder;

	// Token: 0x0400BB17 RID: 47895
	private bool pretty_print;

	// Token: 0x0400BB18 RID: 47896
	private bool validate;

	// Token: 0x0400BB19 RID: 47897
	private TextWriter writer;
}
