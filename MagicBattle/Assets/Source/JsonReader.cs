using System;
using System.Collections.Generic;
using System.IO;

// Token: 0x0200109C RID: 4252
public class JsonReader
{
	// Token: 0x06015732 RID: 87858 RVA: 0x00570490 File Offset: 0x0056E690
	static JsonReader()
	{
		JsonReader.PopulateParseTable();
	}

	// Token: 0x06015733 RID: 87859 RVA: 0x00570498 File Offset: 0x0056E698
	public JsonReader(string json_text) : this(new StringReader(json_text), true)
	{
	}

	// Token: 0x06015734 RID: 87860 RVA: 0x005704A8 File Offset: 0x0056E6A8
	public JsonReader(TextReader reader) : this(reader, false)
	{
	}

	// Token: 0x06015735 RID: 87861 RVA: 0x005704B4 File Offset: 0x0056E6B4
	private JsonReader(TextReader reader, bool owned)
	{
		if (reader == null)
		{
			throw new ArgumentNullException("reader");
		}
		this.parser_in_string = false;
		this.parser_return = false;
		this.read_started = false;
		this.automaton_stack = new Stack<int>();
		this.automaton_stack.Push(65553);
		this.automaton_stack.Push(65543);
		this.lexer = new Lexer(reader);
		this.end_of_input = false;
		this.end_of_json = false;
		this.reader = reader;
		this.reader_is_owned = owned;
	}

	// Token: 0x17003E98 RID: 16024
	// (get) Token: 0x06015736 RID: 87862 RVA: 0x00570540 File Offset: 0x0056E740
	// (set) Token: 0x06015737 RID: 87863 RVA: 0x00570550 File Offset: 0x0056E750
	public bool AllowComments
	{
		get
		{
			return this.lexer.AllowComments;
		}
		set
		{
			this.lexer.AllowComments = value;
		}
	}

	// Token: 0x17003E99 RID: 16025
	// (get) Token: 0x06015738 RID: 87864 RVA: 0x00570560 File Offset: 0x0056E760
	// (set) Token: 0x06015739 RID: 87865 RVA: 0x00570570 File Offset: 0x0056E770
	public bool AllowSingleQuotedStrings
	{
		get
		{
			return this.lexer.AllowSingleQuotedStrings;
		}
		set
		{
			this.lexer.AllowSingleQuotedStrings = value;
		}
	}

	// Token: 0x17003E9A RID: 16026
	// (get) Token: 0x0601573A RID: 87866 RVA: 0x00570580 File Offset: 0x0056E780
	public bool EndOfInput
	{
		get
		{
			return this.end_of_input;
		}
	}

	// Token: 0x17003E9B RID: 16027
	// (get) Token: 0x0601573B RID: 87867 RVA: 0x00570588 File Offset: 0x0056E788
	public bool EndOfJson
	{
		get
		{
			return this.end_of_json;
		}
	}

	// Token: 0x17003E9C RID: 16028
	// (get) Token: 0x0601573C RID: 87868 RVA: 0x00570590 File Offset: 0x0056E790
	public JsonToken Token
	{
		get
		{
			return this.token;
		}
	}

	// Token: 0x17003E9D RID: 16029
	// (get) Token: 0x0601573D RID: 87869 RVA: 0x00570598 File Offset: 0x0056E798
	public object Value
	{
		get
		{
			return this.token_value;
		}
	}

	// Token: 0x0601573E RID: 87870 RVA: 0x005705A0 File Offset: 0x0056E7A0
	private static void PopulateParseTable()
	{
		JsonReader.parse_table = new Dictionary<int, IDictionary<int, int[]>>();
		JsonReader.TableAddRow(ParserToken.Array);
		JsonReader.TableAddCol(ParserToken.Array, 91, new int[]
		{
			91,
			65549
		});
		JsonReader.TableAddRow(ParserToken.ArrayPrime);
		JsonReader.TableAddCol(ParserToken.ArrayPrime, 34, new int[]
		{
			65550,
			65551,
			93
		});
		JsonReader.TableAddCol(ParserToken.ArrayPrime, 91, new int[]
		{
			65550,
			65551,
			93
		});
		JsonReader.TableAddCol(ParserToken.ArrayPrime, 93, new int[]
		{
			93
		});
		JsonReader.TableAddCol(ParserToken.ArrayPrime, 123, new int[]
		{
			65550,
			65551,
			93
		});
		JsonReader.TableAddCol(ParserToken.ArrayPrime, 65537, new int[]
		{
			65550,
			65551,
			93
		});
		JsonReader.TableAddCol(ParserToken.ArrayPrime, 65538, new int[]
		{
			65550,
			65551,
			93
		});
		JsonReader.TableAddCol(ParserToken.ArrayPrime, 65539, new int[]
		{
			65550,
			65551,
			93
		});
		JsonReader.TableAddCol(ParserToken.ArrayPrime, 65540, new int[]
		{
			65550,
			65551,
			93
		});
		JsonReader.TableAddRow(ParserToken.Object);
		JsonReader.TableAddCol(ParserToken.Object, 123, new int[]
		{
			123,
			65545
		});
		JsonReader.TableAddRow(ParserToken.ObjectPrime);
		JsonReader.TableAddCol(ParserToken.ObjectPrime, 34, new int[]
		{
			65546,
			65547,
			125
		});
		JsonReader.TableAddCol(ParserToken.ObjectPrime, 125, new int[]
		{
			125
		});
		JsonReader.TableAddRow(ParserToken.Pair);
		JsonReader.TableAddCol(ParserToken.Pair, 34, new int[]
		{
			65552,
			58,
			65550
		});
		JsonReader.TableAddRow(ParserToken.PairRest);
		JsonReader.TableAddCol(ParserToken.PairRest, 44, new int[]
		{
			44,
			65546,
			65547
		});
		JsonReader.TableAddCol(ParserToken.PairRest, 125, new int[]
		{
			65554
		});
		JsonReader.TableAddRow(ParserToken.String);
		JsonReader.TableAddCol(ParserToken.String, 34, new int[]
		{
			34,
			65541,
			34
		});
		JsonReader.TableAddRow(ParserToken.Text);
		JsonReader.TableAddCol(ParserToken.Text, 91, new int[]
		{
			65548
		});
		JsonReader.TableAddCol(ParserToken.Text, 123, new int[]
		{
			65544
		});
		JsonReader.TableAddRow(ParserToken.Value);
		JsonReader.TableAddCol(ParserToken.Value, 34, new int[]
		{
			65552
		});
		JsonReader.TableAddCol(ParserToken.Value, 91, new int[]
		{
			65548
		});
		JsonReader.TableAddCol(ParserToken.Value, 123, new int[]
		{
			65544
		});
		JsonReader.TableAddCol(ParserToken.Value, 65537, new int[]
		{
			65537
		});
		JsonReader.TableAddCol(ParserToken.Value, 65538, new int[]
		{
			65538
		});
		JsonReader.TableAddCol(ParserToken.Value, 65539, new int[]
		{
			65539
		});
		JsonReader.TableAddCol(ParserToken.Value, 65540, new int[]
		{
			65540
		});
		JsonReader.TableAddRow(ParserToken.ValueRest);
		JsonReader.TableAddCol(ParserToken.ValueRest, 44, new int[]
		{
			44,
			65550,
			65551
		});
		JsonReader.TableAddCol(ParserToken.ValueRest, 93, new int[]
		{
			65554
		});
	}

	// Token: 0x0601573F RID: 87871 RVA: 0x0057091C File Offset: 0x0056EB1C
	private static void TableAddCol(ParserToken row, int col, params int[] symbols)
	{
		JsonReader.parse_table[(int)row].Add(col, symbols);
	}

	// Token: 0x06015740 RID: 87872 RVA: 0x00570930 File Offset: 0x0056EB30
	private static void TableAddRow(ParserToken rule)
	{
		JsonReader.parse_table.Add((int)rule, new Dictionary<int, int[]>());
	}

	// Token: 0x06015741 RID: 87873 RVA: 0x00570944 File Offset: 0x0056EB44
	private void ProcessNumber(string number)
	{
		double num;
		if ((number.IndexOf('.') != -1 || number.IndexOf('e') != -1 || number.IndexOf('E') != -1) && double.TryParse(number, out num))
		{
			this.token = JsonToken.Double;
			this.token_value = num;
			return;
		}
		int num2;
		if (int.TryParse(number, out num2))
		{
			this.token = JsonToken.Int;
			this.token_value = num2;
			return;
		}
		long num3;
		if (long.TryParse(number, out num3))
		{
			this.token = JsonToken.Long;
			this.token_value = num3;
			return;
		}
		this.token = JsonToken.Int;
		this.token_value = 0;
	}

	// Token: 0x06015742 RID: 87874 RVA: 0x005709F4 File Offset: 0x0056EBF4
	private void ProcessSymbol()
	{
		if (this.current_symbol == 91)
		{
			this.token = JsonToken.ArrayStart;
			this.parser_return = true;
		}
		else if (this.current_symbol == 93)
		{
			this.token = JsonToken.ArrayEnd;
			this.parser_return = true;
		}
		else if (this.current_symbol == 123)
		{
			this.token = JsonToken.ObjectStart;
			this.parser_return = true;
		}
		else if (this.current_symbol == 125)
		{
			this.token = JsonToken.ObjectEnd;
			this.parser_return = true;
		}
		else if (this.current_symbol == 34)
		{
			if (this.parser_in_string)
			{
				this.parser_in_string = false;
				this.parser_return = true;
			}
			else
			{
				if (this.token == JsonToken.None)
				{
					this.token = JsonToken.String;
				}
				this.parser_in_string = true;
			}
		}
		else if (this.current_symbol == 65541)
		{
			this.token_value = this.lexer.StringValue;
		}
		else if (this.current_symbol == 65539)
		{
			this.token = JsonToken.Boolean;
			this.token_value = false;
			this.parser_return = true;
		}
		else if (this.current_symbol == 65540)
		{
			this.token = JsonToken.Null;
			this.parser_return = true;
		}
		else if (this.current_symbol == 65537)
		{
			this.ProcessNumber(this.lexer.StringValue);
			this.parser_return = true;
		}
		else if (this.current_symbol == 65546)
		{
			this.token = JsonToken.PropertyName;
		}
		else if (this.current_symbol == 65538)
		{
			this.token = JsonToken.Boolean;
			this.token_value = true;
			this.parser_return = true;
		}
	}

	// Token: 0x06015743 RID: 87875 RVA: 0x00570BBC File Offset: 0x0056EDBC
	private bool ReadToken()
	{
		if (this.end_of_input)
		{
			return false;
		}
		this.lexer.NextToken();
		if (this.lexer.EndOfInput)
		{
			this.Close();
			return false;
		}
		this.current_input = this.lexer.Token;
		return true;
	}

	// Token: 0x06015744 RID: 87876 RVA: 0x00570C0C File Offset: 0x0056EE0C
	public void Close()
	{
		if (this.end_of_input)
		{
			return;
		}
		this.end_of_input = true;
		this.end_of_json = true;
		if (this.reader_is_owned)
		{
			this.reader.Close();
		}
		this.reader = null;
	}

	// Token: 0x06015745 RID: 87877 RVA: 0x00570C48 File Offset: 0x0056EE48
	public bool Read()
	{
		if (this.end_of_input)
		{
			return false;
		}
		if (this.end_of_json)
		{
			this.end_of_json = false;
			this.automaton_stack.Clear();
			this.automaton_stack.Push(65553);
			this.automaton_stack.Push(65543);
		}
		this.parser_in_string = false;
		this.parser_return = false;
		this.token = JsonToken.None;
		this.token_value = null;
		if (!this.read_started)
		{
			this.read_started = true;
			if (!this.ReadToken())
			{
				return false;
			}
		}
		while (!this.parser_return)
		{
			this.current_symbol = this.automaton_stack.Pop();
			this.ProcessSymbol();
			if (this.current_symbol == this.current_input)
			{
				if (!this.ReadToken())
				{
					if (this.automaton_stack.Peek() != 65553)
					{
						throw new JsonException("Input doesn't evaluate to proper JSON text");
					}
					return this.parser_return;
				}
			}
			else
			{
				int[] array;
				try
				{
					array = JsonReader.parse_table[this.current_symbol][this.current_input];
				}
				catch (KeyNotFoundException inner_exception)
				{
					throw new JsonException((ParserToken)this.current_input, inner_exception);
				}
				if (array[0] != 65554)
				{
					for (int i = array.Length - 1; i >= 0; i--)
					{
						this.automaton_stack.Push(array[i]);
					}
				}
			}
		}
		if (this.automaton_stack.Peek() == 65553)
		{
			this.end_of_json = true;
		}
		return true;
	}

	// Token: 0x0400BAF6 RID: 47862
	private static IDictionary<int, IDictionary<int, int[]>> parse_table;

	// Token: 0x0400BAF7 RID: 47863
	private Stack<int> automaton_stack;

	// Token: 0x0400BAF8 RID: 47864
	private int current_input;

	// Token: 0x0400BAF9 RID: 47865
	private int current_symbol;

	// Token: 0x0400BAFA RID: 47866
	private bool end_of_json;

	// Token: 0x0400BAFB RID: 47867
	private bool end_of_input;

	// Token: 0x0400BAFC RID: 47868
	private Lexer lexer;

	// Token: 0x0400BAFD RID: 47869
	private bool parser_in_string;

	// Token: 0x0400BAFE RID: 47870
	private bool parser_return;

	// Token: 0x0400BAFF RID: 47871
	private bool read_started;

	// Token: 0x0400BB00 RID: 47872
	private TextReader reader;

	// Token: 0x0400BB01 RID: 47873
	private bool reader_is_owned;

	// Token: 0x0400BB02 RID: 47874
	private object token_value;

	// Token: 0x0400BB03 RID: 47875
	private JsonToken token;
}
