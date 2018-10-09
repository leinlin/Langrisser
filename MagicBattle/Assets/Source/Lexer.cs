using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

// Token: 0x020010A1 RID: 4257
internal class Lexer
{
	// Token: 0x0601576A RID: 87914 RVA: 0x005717AC File Offset: 0x0056F9AC
	static Lexer()
	{
		Lexer.PopulateFsmTables();
	}

	// Token: 0x0601576B RID: 87915 RVA: 0x005717B4 File Offset: 0x0056F9B4
	public Lexer(TextReader reader)
	{
		this.allow_comments = true;
		this.allow_single_quoted_strings = true;
		this.input_buffer = 0;
		this.string_buffer = new StringBuilder(128);
		this.state = 1;
		this.end_of_input = false;
		this.reader = reader;
		this.fsm_context = new FsmContext();
		this.fsm_context.L = this;
	}

	// Token: 0x17003EA2 RID: 16034
	// (get) Token: 0x0601576C RID: 87916 RVA: 0x00571818 File Offset: 0x0056FA18
	// (set) Token: 0x0601576D RID: 87917 RVA: 0x00571820 File Offset: 0x0056FA20
	public bool AllowComments
	{
		get
		{
			return this.allow_comments;
		}
		set
		{
			this.allow_comments = value;
		}
	}

	// Token: 0x17003EA3 RID: 16035
	// (get) Token: 0x0601576E RID: 87918 RVA: 0x0057182C File Offset: 0x0056FA2C
	// (set) Token: 0x0601576F RID: 87919 RVA: 0x00571834 File Offset: 0x0056FA34
	public bool AllowSingleQuotedStrings
	{
		get
		{
			return this.allow_single_quoted_strings;
		}
		set
		{
			this.allow_single_quoted_strings = value;
		}
	}

	// Token: 0x17003EA4 RID: 16036
	// (get) Token: 0x06015770 RID: 87920 RVA: 0x00571840 File Offset: 0x0056FA40
	public bool EndOfInput
	{
		get
		{
			return this.end_of_input;
		}
	}

	// Token: 0x17003EA5 RID: 16037
	// (get) Token: 0x06015771 RID: 87921 RVA: 0x00571848 File Offset: 0x0056FA48
	public int Token
	{
		get
		{
			return this.token;
		}
	}

	// Token: 0x17003EA6 RID: 16038
	// (get) Token: 0x06015772 RID: 87922 RVA: 0x00571850 File Offset: 0x0056FA50
	public string StringValue
	{
		get
		{
			return this.string_value;
		}
	}

	// Token: 0x06015773 RID: 87923 RVA: 0x00571858 File Offset: 0x0056FA58
	private static int HexValue(int digit)
	{
		switch (digit)
		{
		case 65:
			break;
		case 66:
			return 11;
		case 67:
			return 12;
		case 68:
			return 13;
		case 69:
			return 14;
		case 70:
			return 15;
		default:
			switch (digit)
			{
			case 97:
				break;
			case 98:
				return 11;
			case 99:
				return 12;
			case 100:
				return 13;
			case 101:
				return 14;
			case 102:
				return 15;
			default:
				return digit - 48;
			}
			break;
		}
		return 10;
	}

	// Token: 0x06015774 RID: 87924 RVA: 0x005718C4 File Offset: 0x0056FAC4
	private static void PopulateFsmTables()
	{
		Lexer.StateHandler[] array = new Lexer.StateHandler[28];
		int num = 0;
		if (Lexer.<>f__mg$cache0 == null)
		{
			Lexer.<>f__mg$cache0 = new Lexer.StateHandler(Lexer.State1);
		}
		array[num] = Lexer.<>f__mg$cache0;
		int num2 = 1;
		if (Lexer.<>f__mg$cache1 == null)
		{
			Lexer.<>f__mg$cache1 = new Lexer.StateHandler(Lexer.State2);
		}
		array[num2] = Lexer.<>f__mg$cache1;
		int num3 = 2;
		if (Lexer.<>f__mg$cache2 == null)
		{
			Lexer.<>f__mg$cache2 = new Lexer.StateHandler(Lexer.State3);
		}
		array[num3] = Lexer.<>f__mg$cache2;
		int num4 = 3;
		if (Lexer.<>f__mg$cache3 == null)
		{
			Lexer.<>f__mg$cache3 = new Lexer.StateHandler(Lexer.State4);
		}
		array[num4] = Lexer.<>f__mg$cache3;
		int num5 = 4;
		if (Lexer.<>f__mg$cache4 == null)
		{
			Lexer.<>f__mg$cache4 = new Lexer.StateHandler(Lexer.State5);
		}
		array[num5] = Lexer.<>f__mg$cache4;
		int num6 = 5;
		if (Lexer.<>f__mg$cache5 == null)
		{
			Lexer.<>f__mg$cache5 = new Lexer.StateHandler(Lexer.State6);
		}
		array[num6] = Lexer.<>f__mg$cache5;
		int num7 = 6;
		if (Lexer.<>f__mg$cache6 == null)
		{
			Lexer.<>f__mg$cache6 = new Lexer.StateHandler(Lexer.State7);
		}
		array[num7] = Lexer.<>f__mg$cache6;
		int num8 = 7;
		if (Lexer.<>f__mg$cache7 == null)
		{
			Lexer.<>f__mg$cache7 = new Lexer.StateHandler(Lexer.State8);
		}
		array[num8] = Lexer.<>f__mg$cache7;
		int num9 = 8;
		if (Lexer.<>f__mg$cache8 == null)
		{
			Lexer.<>f__mg$cache8 = new Lexer.StateHandler(Lexer.State9);
		}
		array[num9] = Lexer.<>f__mg$cache8;
		int num10 = 9;
		if (Lexer.<>f__mg$cache9 == null)
		{
			Lexer.<>f__mg$cache9 = new Lexer.StateHandler(Lexer.State10);
		}
		array[num10] = Lexer.<>f__mg$cache9;
		int num11 = 10;
		if (Lexer.<>f__mg$cacheA == null)
		{
			Lexer.<>f__mg$cacheA = new Lexer.StateHandler(Lexer.State11);
		}
		array[num11] = Lexer.<>f__mg$cacheA;
		int num12 = 11;
		if (Lexer.<>f__mg$cacheB == null)
		{
			Lexer.<>f__mg$cacheB = new Lexer.StateHandler(Lexer.State12);
		}
		array[num12] = Lexer.<>f__mg$cacheB;
		int num13 = 12;
		if (Lexer.<>f__mg$cacheC == null)
		{
			Lexer.<>f__mg$cacheC = new Lexer.StateHandler(Lexer.State13);
		}
		array[num13] = Lexer.<>f__mg$cacheC;
		int num14 = 13;
		if (Lexer.<>f__mg$cacheD == null)
		{
			Lexer.<>f__mg$cacheD = new Lexer.StateHandler(Lexer.State14);
		}
		array[num14] = Lexer.<>f__mg$cacheD;
		int num15 = 14;
		if (Lexer.<>f__mg$cacheE == null)
		{
			Lexer.<>f__mg$cacheE = new Lexer.StateHandler(Lexer.State15);
		}
		array[num15] = Lexer.<>f__mg$cacheE;
		int num16 = 15;
		if (Lexer.<>f__mg$cacheF == null)
		{
			Lexer.<>f__mg$cacheF = new Lexer.StateHandler(Lexer.State16);
		}
		array[num16] = Lexer.<>f__mg$cacheF;
		int num17 = 16;
		if (Lexer.<>f__mg$cache10 == null)
		{
			Lexer.<>f__mg$cache10 = new Lexer.StateHandler(Lexer.State17);
		}
		array[num17] = Lexer.<>f__mg$cache10;
		int num18 = 17;
		if (Lexer.<>f__mg$cache11 == null)
		{
			Lexer.<>f__mg$cache11 = new Lexer.StateHandler(Lexer.State18);
		}
		array[num18] = Lexer.<>f__mg$cache11;
		int num19 = 18;
		if (Lexer.<>f__mg$cache12 == null)
		{
			Lexer.<>f__mg$cache12 = new Lexer.StateHandler(Lexer.State19);
		}
		array[num19] = Lexer.<>f__mg$cache12;
		int num20 = 19;
		if (Lexer.<>f__mg$cache13 == null)
		{
			Lexer.<>f__mg$cache13 = new Lexer.StateHandler(Lexer.State20);
		}
		array[num20] = Lexer.<>f__mg$cache13;
		int num21 = 20;
		if (Lexer.<>f__mg$cache14 == null)
		{
			Lexer.<>f__mg$cache14 = new Lexer.StateHandler(Lexer.State21);
		}
		array[num21] = Lexer.<>f__mg$cache14;
		int num22 = 21;
		if (Lexer.<>f__mg$cache15 == null)
		{
			Lexer.<>f__mg$cache15 = new Lexer.StateHandler(Lexer.State22);
		}
		array[num22] = Lexer.<>f__mg$cache15;
		int num23 = 22;
		if (Lexer.<>f__mg$cache16 == null)
		{
			Lexer.<>f__mg$cache16 = new Lexer.StateHandler(Lexer.State23);
		}
		array[num23] = Lexer.<>f__mg$cache16;
		int num24 = 23;
		if (Lexer.<>f__mg$cache17 == null)
		{
			Lexer.<>f__mg$cache17 = new Lexer.StateHandler(Lexer.State24);
		}
		array[num24] = Lexer.<>f__mg$cache17;
		int num25 = 24;
		if (Lexer.<>f__mg$cache18 == null)
		{
			Lexer.<>f__mg$cache18 = new Lexer.StateHandler(Lexer.State25);
		}
		array[num25] = Lexer.<>f__mg$cache18;
		int num26 = 25;
		if (Lexer.<>f__mg$cache19 == null)
		{
			Lexer.<>f__mg$cache19 = new Lexer.StateHandler(Lexer.State26);
		}
		array[num26] = Lexer.<>f__mg$cache19;
		int num27 = 26;
		if (Lexer.<>f__mg$cache1A == null)
		{
			Lexer.<>f__mg$cache1A = new Lexer.StateHandler(Lexer.State27);
		}
		array[num27] = Lexer.<>f__mg$cache1A;
		int num28 = 27;
		if (Lexer.<>f__mg$cache1B == null)
		{
			Lexer.<>f__mg$cache1B = new Lexer.StateHandler(Lexer.State28);
		}
		array[num28] = Lexer.<>f__mg$cache1B;
		Lexer.fsm_handler_table = array;
		Lexer.fsm_return_table = new int[]
		{
			65542,
			0,
			65537,
			65537,
			0,
			65537,
			0,
			65537,
			0,
			0,
			65538,
			0,
			0,
			0,
			65539,
			0,
			0,
			65540,
			65541,
			65542,
			0,
			0,
			65541,
			65542,
			0,
			0,
			0,
			0
		};
	}

	// Token: 0x06015775 RID: 87925 RVA: 0x00571C88 File Offset: 0x0056FE88
	private static char ProcessEscChar(int esc_char)
	{
		switch (esc_char)
		{
		case 114:
			return '\r';
		default:
			if (esc_char == 34 || esc_char == 39 || esc_char == 47 || esc_char == 92)
			{
				return Convert.ToChar(esc_char);
			}
			if (esc_char == 98)
			{
				return '\b';
			}
			if (esc_char == 102)
			{
				return '\f';
			}
			if (esc_char != 110)
			{
				return '?';
			}
			return '\n';
		case 116:
			return '\t';
		}
	}

	// Token: 0x06015776 RID: 87926 RVA: 0x00571D00 File Offset: 0x0056FF00
	private static bool State1(FsmContext ctx)
	{
		while (ctx.L.GetChar())
		{
			if (ctx.L.input_char != 32 && (ctx.L.input_char < 9 || ctx.L.input_char > 13))
			{
				if (ctx.L.input_char >= 49 && ctx.L.input_char <= 57)
				{
					ctx.L.string_buffer.Append((char)ctx.L.input_char);
					ctx.NextState = 3;
					return true;
				}
				int num = ctx.L.input_char;
				switch (num)
				{
				case 44:
					break;
				case 45:
					ctx.L.string_buffer.Append((char)ctx.L.input_char);
					ctx.NextState = 2;
					return true;
				default:
					switch (num)
					{
					case 91:
					case 93:
						break;
					default:
						switch (num)
						{
						case 123:
						case 125:
							break;
						default:
							if (num == 34)
							{
								ctx.NextState = 19;
								ctx.Return = true;
								return true;
							}
							if (num != 39)
							{
								if (num != 58)
								{
									if (num == 102)
									{
										ctx.NextState = 12;
										return true;
									}
									if (num == 110)
									{
										ctx.NextState = 16;
										return true;
									}
									if (num != 116)
									{
										return false;
									}
									ctx.NextState = 9;
									return true;
								}
							}
							else
							{
								if (!ctx.L.allow_single_quoted_strings)
								{
									return false;
								}
								ctx.L.input_char = 34;
								ctx.NextState = 23;
								ctx.Return = true;
								return true;
							}
							break;
						}
						break;
					}
					break;
				case 47:
					if (!ctx.L.allow_comments)
					{
						return false;
					}
					ctx.NextState = 25;
					return true;
				case 48:
					ctx.L.string_buffer.Append((char)ctx.L.input_char);
					ctx.NextState = 4;
					return true;
				}
				ctx.NextState = 1;
				ctx.Return = true;
				return true;
			}
		}
		return true;
	}

	// Token: 0x06015777 RID: 87927 RVA: 0x00571F0C File Offset: 0x0057010C
	private static bool State2(FsmContext ctx)
	{
		ctx.L.GetChar();
		if (ctx.L.input_char >= 49 && ctx.L.input_char <= 57)
		{
			ctx.L.string_buffer.Append((char)ctx.L.input_char);
			ctx.NextState = 3;
			return true;
		}
		int num = ctx.L.input_char;
		if (num != 48)
		{
			return false;
		}
		ctx.L.string_buffer.Append((char)ctx.L.input_char);
		ctx.NextState = 4;
		return true;
	}

	// Token: 0x06015778 RID: 87928 RVA: 0x00571FB0 File Offset: 0x005701B0
	private static bool State3(FsmContext ctx)
	{
		while (ctx.L.GetChar())
		{
			if (ctx.L.input_char >= 48 && ctx.L.input_char <= 57)
			{
				ctx.L.string_buffer.Append((char)ctx.L.input_char);
			}
			else
			{
				if (ctx.L.input_char == 32 || (ctx.L.input_char >= 9 && ctx.L.input_char <= 13))
				{
					ctx.Return = true;
					ctx.NextState = 1;
					return true;
				}
				int num = ctx.L.input_char;
				switch (num)
				{
				case 44:
					break;
				default:
					if (num != 69)
					{
						if (num == 93)
						{
							break;
						}
						if (num != 101)
						{
							if (num != 125)
							{
								return false;
							}
							break;
						}
					}
					ctx.L.string_buffer.Append((char)ctx.L.input_char);
					ctx.NextState = 7;
					return true;
				case 46:
					ctx.L.string_buffer.Append((char)ctx.L.input_char);
					ctx.NextState = 5;
					return true;
				}
				ctx.L.UngetChar();
				ctx.Return = true;
				ctx.NextState = 1;
				return true;
			}
		}
		return true;
	}

	// Token: 0x06015779 RID: 87929 RVA: 0x00572110 File Offset: 0x00570310
	private static bool State4(FsmContext ctx)
	{
		ctx.L.GetChar();
		if (ctx.L.input_char == 32 || (ctx.L.input_char >= 9 && ctx.L.input_char <= 13))
		{
			ctx.Return = true;
			ctx.NextState = 1;
			return true;
		}
		int num = ctx.L.input_char;
		switch (num)
		{
		case 44:
			break;
		default:
			if (num != 69)
			{
				if (num == 93)
				{
					break;
				}
				if (num != 101)
				{
					if (num != 125)
					{
						return false;
					}
					break;
				}
			}
			ctx.L.string_buffer.Append((char)ctx.L.input_char);
			ctx.NextState = 7;
			return true;
		case 46:
			ctx.L.string_buffer.Append((char)ctx.L.input_char);
			ctx.NextState = 5;
			return true;
		}
		ctx.L.UngetChar();
		ctx.Return = true;
		ctx.NextState = 1;
		return true;
	}

	// Token: 0x0601577A RID: 87930 RVA: 0x00572220 File Offset: 0x00570420
	private static bool State5(FsmContext ctx)
	{
		ctx.L.GetChar();
		if (ctx.L.input_char >= 48 && ctx.L.input_char <= 57)
		{
			ctx.L.string_buffer.Append((char)ctx.L.input_char);
			ctx.NextState = 6;
			return true;
		}
		return false;
	}

	// Token: 0x0601577B RID: 87931 RVA: 0x00572284 File Offset: 0x00570484
	private static bool State6(FsmContext ctx)
	{
		while (ctx.L.GetChar())
		{
			if (ctx.L.input_char >= 48 && ctx.L.input_char <= 57)
			{
				ctx.L.string_buffer.Append((char)ctx.L.input_char);
			}
			else
			{
				if (ctx.L.input_char == 32 || (ctx.L.input_char >= 9 && ctx.L.input_char <= 13))
				{
					ctx.Return = true;
					ctx.NextState = 1;
					return true;
				}
				int num = ctx.L.input_char;
				if (num != 44)
				{
					if (num != 69)
					{
						if (num == 93)
						{
							goto IL_CA;
						}
						if (num != 101)
						{
							if (num != 125)
							{
								return false;
							}
							goto IL_CA;
						}
					}
					ctx.L.string_buffer.Append((char)ctx.L.input_char);
					ctx.NextState = 7;
					return true;
				}
				IL_CA:
				ctx.L.UngetChar();
				ctx.Return = true;
				ctx.NextState = 1;
				return true;
			}
		}
		return true;
	}

	// Token: 0x0601577C RID: 87932 RVA: 0x005723B0 File Offset: 0x005705B0
	private static bool State7(FsmContext ctx)
	{
		ctx.L.GetChar();
		if (ctx.L.input_char >= 48 && ctx.L.input_char <= 57)
		{
			ctx.L.string_buffer.Append((char)ctx.L.input_char);
			ctx.NextState = 8;
			return true;
		}
		int num = ctx.L.input_char;
		if (num != 43 && num != 45)
		{
			return false;
		}
		ctx.L.string_buffer.Append((char)ctx.L.input_char);
		ctx.NextState = 8;
		return true;
	}

	// Token: 0x0601577D RID: 87933 RVA: 0x0057245C File Offset: 0x0057065C
	private static bool State8(FsmContext ctx)
	{
		while (ctx.L.GetChar())
		{
			if (ctx.L.input_char >= 48 && ctx.L.input_char <= 57)
			{
				ctx.L.string_buffer.Append((char)ctx.L.input_char);
			}
			else
			{
				if (ctx.L.input_char == 32 || (ctx.L.input_char >= 9 && ctx.L.input_char <= 13))
				{
					ctx.Return = true;
					ctx.NextState = 1;
					return true;
				}
				int num = ctx.L.input_char;
				if (num != 44 && num != 93 && num != 125)
				{
					return false;
				}
				ctx.L.UngetChar();
				ctx.Return = true;
				ctx.NextState = 1;
				return true;
			}
		}
		return true;
	}

	// Token: 0x0601577E RID: 87934 RVA: 0x00572554 File Offset: 0x00570754
	private static bool State9(FsmContext ctx)
	{
		ctx.L.GetChar();
		int num = ctx.L.input_char;
		if (num != 114)
		{
			return false;
		}
		ctx.NextState = 10;
		return true;
	}

	// Token: 0x0601577F RID: 87935 RVA: 0x00572594 File Offset: 0x00570794
	private static bool State10(FsmContext ctx)
	{
		ctx.L.GetChar();
		int num = ctx.L.input_char;
		if (num != 117)
		{
			return false;
		}
		ctx.NextState = 11;
		return true;
	}

	// Token: 0x06015780 RID: 87936 RVA: 0x005725D4 File Offset: 0x005707D4
	private static bool State11(FsmContext ctx)
	{
		ctx.L.GetChar();
		int num = ctx.L.input_char;
		if (num != 101)
		{
			return false;
		}
		ctx.Return = true;
		ctx.NextState = 1;
		return true;
	}

	// Token: 0x06015781 RID: 87937 RVA: 0x00572618 File Offset: 0x00570818
	private static bool State12(FsmContext ctx)
	{
		ctx.L.GetChar();
		int num = ctx.L.input_char;
		if (num != 97)
		{
			return false;
		}
		ctx.NextState = 13;
		return true;
	}

	// Token: 0x06015782 RID: 87938 RVA: 0x00572658 File Offset: 0x00570858
	private static bool State13(FsmContext ctx)
	{
		ctx.L.GetChar();
		int num = ctx.L.input_char;
		if (num != 108)
		{
			return false;
		}
		ctx.NextState = 14;
		return true;
	}

	// Token: 0x06015783 RID: 87939 RVA: 0x00572698 File Offset: 0x00570898
	private static bool State14(FsmContext ctx)
	{
		ctx.L.GetChar();
		int num = ctx.L.input_char;
		if (num != 115)
		{
			return false;
		}
		ctx.NextState = 15;
		return true;
	}

	// Token: 0x06015784 RID: 87940 RVA: 0x005726D8 File Offset: 0x005708D8
	private static bool State15(FsmContext ctx)
	{
		ctx.L.GetChar();
		int num = ctx.L.input_char;
		if (num != 101)
		{
			return false;
		}
		ctx.Return = true;
		ctx.NextState = 1;
		return true;
	}

	// Token: 0x06015785 RID: 87941 RVA: 0x0057271C File Offset: 0x0057091C
	private static bool State16(FsmContext ctx)
	{
		ctx.L.GetChar();
		int num = ctx.L.input_char;
		if (num != 117)
		{
			return false;
		}
		ctx.NextState = 17;
		return true;
	}

	// Token: 0x06015786 RID: 87942 RVA: 0x0057275C File Offset: 0x0057095C
	private static bool State17(FsmContext ctx)
	{
		ctx.L.GetChar();
		int num = ctx.L.input_char;
		if (num != 108)
		{
			return false;
		}
		ctx.NextState = 18;
		return true;
	}

	// Token: 0x06015787 RID: 87943 RVA: 0x0057279C File Offset: 0x0057099C
	private static bool State18(FsmContext ctx)
	{
		ctx.L.GetChar();
		int num = ctx.L.input_char;
		if (num != 108)
		{
			return false;
		}
		ctx.Return = true;
		ctx.NextState = 1;
		return true;
	}

	// Token: 0x06015788 RID: 87944 RVA: 0x005727E0 File Offset: 0x005709E0
	private static bool State19(FsmContext ctx)
	{
		while (ctx.L.GetChar())
		{
			int num = ctx.L.input_char;
			if (num == 34)
			{
				ctx.L.UngetChar();
				ctx.Return = true;
				ctx.NextState = 20;
				return true;
			}
			if (num == 92)
			{
				ctx.StateStack = 19;
				ctx.NextState = 21;
				return true;
			}
			ctx.L.string_buffer.Append((char)ctx.L.input_char);
		}
		return true;
	}

	// Token: 0x06015789 RID: 87945 RVA: 0x00572874 File Offset: 0x00570A74
	private static bool State20(FsmContext ctx)
	{
		ctx.L.GetChar();
		int num = ctx.L.input_char;
		if (num != 34)
		{
			return false;
		}
		ctx.Return = true;
		ctx.NextState = 1;
		return true;
	}

	// Token: 0x0601578A RID: 87946 RVA: 0x005728B8 File Offset: 0x00570AB8
	private static bool State21(FsmContext ctx)
	{
		ctx.L.GetChar();
		int num = ctx.L.input_char;
		switch (num)
		{
		case 114:
		case 116:
			break;
		default:
			if (num != 34 && num != 39 && num != 47 && num != 92 && num != 98 && num != 102 && num != 110)
			{
				return false;
			}
			break;
		case 117:
			ctx.NextState = 22;
			return true;
		}
		ctx.L.string_buffer.Append(Lexer.ProcessEscChar(ctx.L.input_char));
		ctx.NextState = ctx.StateStack;
		return true;
	}

	// Token: 0x0601578B RID: 87947 RVA: 0x00572970 File Offset: 0x00570B70
	private static bool State22(FsmContext ctx)
	{
		int num = 0;
		int num2 = 4096;
		ctx.L.unichar = 0;
		while (ctx.L.GetChar())
		{
			if ((ctx.L.input_char < 48 || ctx.L.input_char > 57) && (ctx.L.input_char < 65 || ctx.L.input_char > 70) && (ctx.L.input_char < 97 || ctx.L.input_char > 102))
			{
				return false;
			}
			ctx.L.unichar += Lexer.HexValue(ctx.L.input_char) * num2;
			num++;
			num2 /= 16;
			if (num == 4)
			{
				ctx.L.string_buffer.Append(Convert.ToChar(ctx.L.unichar));
				ctx.NextState = ctx.StateStack;
				return true;
			}
		}
		return true;
	}

	// Token: 0x0601578C RID: 87948 RVA: 0x00572A80 File Offset: 0x00570C80
	private static bool State23(FsmContext ctx)
	{
		while (ctx.L.GetChar())
		{
			int num = ctx.L.input_char;
			if (num == 39)
			{
				ctx.L.UngetChar();
				ctx.Return = true;
				ctx.NextState = 24;
				return true;
			}
			if (num == 92)
			{
				ctx.StateStack = 23;
				ctx.NextState = 21;
				return true;
			}
			ctx.L.string_buffer.Append((char)ctx.L.input_char);
		}
		return true;
	}

	// Token: 0x0601578D RID: 87949 RVA: 0x00572B14 File Offset: 0x00570D14
	private static bool State24(FsmContext ctx)
	{
		ctx.L.GetChar();
		int num = ctx.L.input_char;
		if (num != 39)
		{
			return false;
		}
		ctx.L.input_char = 34;
		ctx.Return = true;
		ctx.NextState = 1;
		return true;
	}

	// Token: 0x0601578E RID: 87950 RVA: 0x00572B64 File Offset: 0x00570D64
	private static bool State25(FsmContext ctx)
	{
		ctx.L.GetChar();
		int num = ctx.L.input_char;
		if (num == 42)
		{
			ctx.NextState = 27;
			return true;
		}
		if (num != 47)
		{
			return false;
		}
		ctx.NextState = 26;
		return true;
	}

	// Token: 0x0601578F RID: 87951 RVA: 0x00572BB4 File Offset: 0x00570DB4
	private static bool State26(FsmContext ctx)
	{
		while (ctx.L.GetChar())
		{
			if (ctx.L.input_char == 10)
			{
				ctx.NextState = 1;
				return true;
			}
		}
		return true;
	}

	// Token: 0x06015790 RID: 87952 RVA: 0x00572BE8 File Offset: 0x00570DE8
	private static bool State27(FsmContext ctx)
	{
		while (ctx.L.GetChar())
		{
			if (ctx.L.input_char == 42)
			{
				ctx.NextState = 28;
				return true;
			}
		}
		return true;
	}

	// Token: 0x06015791 RID: 87953 RVA: 0x00572C1C File Offset: 0x00570E1C
	private static bool State28(FsmContext ctx)
	{
		while (ctx.L.GetChar())
		{
			if (ctx.L.input_char != 42)
			{
				if (ctx.L.input_char == 47)
				{
					ctx.NextState = 1;
					return true;
				}
				ctx.NextState = 27;
				return true;
			}
		}
		return true;
	}

	// Token: 0x06015792 RID: 87954 RVA: 0x00572C7C File Offset: 0x00570E7C
	private bool GetChar()
	{
		if ((this.input_char = this.NextChar()) != -1)
		{
			return true;
		}
		this.end_of_input = true;
		return false;
	}

	// Token: 0x06015793 RID: 87955 RVA: 0x00572CA8 File Offset: 0x00570EA8
	private int NextChar()
	{
		if (this.input_buffer != 0)
		{
			int result = this.input_buffer;
			this.input_buffer = 0;
			return result;
		}
		return this.reader.Read();
	}

	// Token: 0x06015794 RID: 87956 RVA: 0x00572CDC File Offset: 0x00570EDC
	public bool NextToken()
	{
		this.fsm_context.Return = false;
		for (;;)
		{
			Lexer.StateHandler stateHandler = Lexer.fsm_handler_table[this.state - 1];
			if (!stateHandler(this.fsm_context))
			{
				break;
			}
			if (this.end_of_input)
			{
				return false;
			}
			if (this.fsm_context.Return)
			{
				goto Block_3;
			}
			this.state = this.fsm_context.NextState;
		}
		throw new JsonException(this.input_char);
		Block_3:
		this.string_value = this.string_buffer.ToString();
		this.string_buffer.Remove(0, this.string_buffer.Length);
		this.token = Lexer.fsm_return_table[this.state - 1];
		if (this.token == 65542)
		{
			this.token = this.input_char;
		}
		this.state = this.fsm_context.NextState;
		return true;
	}

	// Token: 0x06015795 RID: 87957 RVA: 0x00572DC0 File Offset: 0x00570FC0
	private void UngetChar()
	{
		this.input_buffer = this.input_char;
	}

	// Token: 0x0400BB1E RID: 47902
	private static int[] fsm_return_table;

	// Token: 0x0400BB1F RID: 47903
	private static Lexer.StateHandler[] fsm_handler_table;

	// Token: 0x0400BB20 RID: 47904
	private bool allow_comments;

	// Token: 0x0400BB21 RID: 47905
	private bool allow_single_quoted_strings;

	// Token: 0x0400BB22 RID: 47906
	private bool end_of_input;

	// Token: 0x0400BB23 RID: 47907
	private FsmContext fsm_context;

	// Token: 0x0400BB24 RID: 47908
	private int input_buffer;

	// Token: 0x0400BB25 RID: 47909
	private int input_char;

	// Token: 0x0400BB26 RID: 47910
	private TextReader reader;

	// Token: 0x0400BB27 RID: 47911
	private int state;

	// Token: 0x0400BB28 RID: 47912
	private StringBuilder string_buffer;

	// Token: 0x0400BB29 RID: 47913
	private string string_value;

	// Token: 0x0400BB2A RID: 47914
	private int token;

	// Token: 0x0400BB2B RID: 47915
	private int unichar;

	// Token: 0x0400BB2C RID: 47916
	[CompilerGenerated]
	private static Lexer.StateHandler <>f__mg$cache0;

	// Token: 0x0400BB2D RID: 47917
	[CompilerGenerated]
	private static Lexer.StateHandler <>f__mg$cache1;

	// Token: 0x0400BB2E RID: 47918
	[CompilerGenerated]
	private static Lexer.StateHandler <>f__mg$cache2;

	// Token: 0x0400BB2F RID: 47919
	[CompilerGenerated]
	private static Lexer.StateHandler <>f__mg$cache3;

	// Token: 0x0400BB30 RID: 47920
	[CompilerGenerated]
	private static Lexer.StateHandler <>f__mg$cache4;

	// Token: 0x0400BB31 RID: 47921
	[CompilerGenerated]
	private static Lexer.StateHandler <>f__mg$cache5;

	// Token: 0x0400BB32 RID: 47922
	[CompilerGenerated]
	private static Lexer.StateHandler <>f__mg$cache6;

	// Token: 0x0400BB33 RID: 47923
	[CompilerGenerated]
	private static Lexer.StateHandler <>f__mg$cache7;

	// Token: 0x0400BB34 RID: 47924
	[CompilerGenerated]
	private static Lexer.StateHandler <>f__mg$cache8;

	// Token: 0x0400BB35 RID: 47925
	[CompilerGenerated]
	private static Lexer.StateHandler <>f__mg$cache9;

	// Token: 0x0400BB36 RID: 47926
	[CompilerGenerated]
	private static Lexer.StateHandler <>f__mg$cacheA;

	// Token: 0x0400BB37 RID: 47927
	[CompilerGenerated]
	private static Lexer.StateHandler <>f__mg$cacheB;

	// Token: 0x0400BB38 RID: 47928
	[CompilerGenerated]
	private static Lexer.StateHandler <>f__mg$cacheC;

	// Token: 0x0400BB39 RID: 47929
	[CompilerGenerated]
	private static Lexer.StateHandler <>f__mg$cacheD;

	// Token: 0x0400BB3A RID: 47930
	[CompilerGenerated]
	private static Lexer.StateHandler <>f__mg$cacheE;

	// Token: 0x0400BB3B RID: 47931
	[CompilerGenerated]
	private static Lexer.StateHandler <>f__mg$cacheF;

	// Token: 0x0400BB3C RID: 47932
	[CompilerGenerated]
	private static Lexer.StateHandler <>f__mg$cache10;

	// Token: 0x0400BB3D RID: 47933
	[CompilerGenerated]
	private static Lexer.StateHandler <>f__mg$cache11;

	// Token: 0x0400BB3E RID: 47934
	[CompilerGenerated]
	private static Lexer.StateHandler <>f__mg$cache12;

	// Token: 0x0400BB3F RID: 47935
	[CompilerGenerated]
	private static Lexer.StateHandler <>f__mg$cache13;

	// Token: 0x0400BB40 RID: 47936
	[CompilerGenerated]
	private static Lexer.StateHandler <>f__mg$cache14;

	// Token: 0x0400BB41 RID: 47937
	[CompilerGenerated]
	private static Lexer.StateHandler <>f__mg$cache15;

	// Token: 0x0400BB42 RID: 47938
	[CompilerGenerated]
	private static Lexer.StateHandler <>f__mg$cache16;

	// Token: 0x0400BB43 RID: 47939
	[CompilerGenerated]
	private static Lexer.StateHandler <>f__mg$cache17;

	// Token: 0x0400BB44 RID: 47940
	[CompilerGenerated]
	private static Lexer.StateHandler <>f__mg$cache18;

	// Token: 0x0400BB45 RID: 47941
	[CompilerGenerated]
	private static Lexer.StateHandler <>f__mg$cache19;

	// Token: 0x0400BB46 RID: 47942
	[CompilerGenerated]
	private static Lexer.StateHandler <>f__mg$cache1A;

	// Token: 0x0400BB47 RID: 47943
	[CompilerGenerated]
	private static Lexer.StateHandler <>f__mg$cache1B;

	// Token: 0x020010A2 RID: 4258
	// (Invoke) Token: 0x06015797 RID: 87959
	private delegate bool StateHandler(FsmContext ctx);
}
