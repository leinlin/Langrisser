using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.Serialization;
using System.Text;
using SimpleJson.Reflection;

namespace SimpleJson
{
	// Token: 0x020010C3 RID: 4291
	[GeneratedCode("simple-json", "1.0.0")]
	public static class SimpleJson
	{
		// Token: 0x060158F7 RID: 88311 RVA: 0x0057DA20 File Offset: 0x0057BC20
		static SimpleJson()
		{
			SimpleJson.EscapeTable = new char[93];
			SimpleJson.EscapeTable[34] = '"';
			SimpleJson.EscapeTable[92] = '\\';
			SimpleJson.EscapeTable[8] = 'b';
			SimpleJson.EscapeTable[12] = 'f';
			SimpleJson.EscapeTable[10] = 'n';
			SimpleJson.EscapeTable[13] = 'r';
			SimpleJson.EscapeTable[9] = 't';
		}

		// Token: 0x060158F8 RID: 88312 RVA: 0x0057DA94 File Offset: 0x0057BC94
		public static object DeserializeObject(string json)
		{
			object result;
			if (SimpleJson.TryDeserializeObject(json, out result))
			{
				return result;
			}
			throw new SerializationException("Invalid JSON string");
		}

		// Token: 0x060158F9 RID: 88313 RVA: 0x0057DABC File Offset: 0x0057BCBC
		public static bool TryDeserializeObject(string json, out object obj)
		{
			bool result = true;
			if (json != null)
			{
				char[] json2 = json.ToCharArray();
				int num = 0;
				obj = SimpleJson.ParseValue(json2, ref num, ref result);
			}
			else
			{
				obj = null;
			}
			return result;
		}

		// Token: 0x060158FA RID: 88314 RVA: 0x0057DAF0 File Offset: 0x0057BCF0
		public static object DeserializeObject(string json, Type type, IJsonSerializerStrategy jsonSerializerStrategy)
		{
			object obj = SimpleJson.DeserializeObject(json);
			return (type != null && (obj == null || !ReflectionUtils.IsAssignableFrom(obj.GetType(), type))) ? (jsonSerializerStrategy ?? SimpleJson.CurrentJsonSerializerStrategy).DeserializeObject(obj, type) : obj;
		}

		// Token: 0x060158FB RID: 88315 RVA: 0x0057DB3C File Offset: 0x0057BD3C
		public static object DeserializeObject(string json, Type type)
		{
			return SimpleJson.DeserializeObject(json, type, null);
		}

		// Token: 0x060158FC RID: 88316 RVA: 0x0057DB48 File Offset: 0x0057BD48
		public static T DeserializeObject<T>(string json, IJsonSerializerStrategy jsonSerializerStrategy)
		{
			return (T)((object)SimpleJson.DeserializeObject(json, typeof(T), jsonSerializerStrategy));
		}

		// Token: 0x060158FD RID: 88317 RVA: 0x0057DB60 File Offset: 0x0057BD60
		public static T DeserializeObject<T>(string json)
		{
			return (T)((object)SimpleJson.DeserializeObject(json, typeof(T), null));
		}

		// Token: 0x060158FE RID: 88318 RVA: 0x0057DB78 File Offset: 0x0057BD78
		public static string SerializeObject(object json, IJsonSerializerStrategy jsonSerializerStrategy)
		{
			StringBuilder stringBuilder = new StringBuilder(2000);
			bool flag = SimpleJson.SerializeValue(jsonSerializerStrategy, json, stringBuilder);
			return (!flag) ? null : stringBuilder.ToString();
		}

		// Token: 0x060158FF RID: 88319 RVA: 0x0057DBAC File Offset: 0x0057BDAC
		public static string SerializeObject(object json)
		{
			return SimpleJson.SerializeObject(json, SimpleJson.CurrentJsonSerializerStrategy);
		}

		// Token: 0x06015900 RID: 88320 RVA: 0x0057DBBC File Offset: 0x0057BDBC
		public static string EscapeToJavascriptString(string jsonString)
		{
			if (string.IsNullOrEmpty(jsonString))
			{
				return jsonString;
			}
			StringBuilder stringBuilder = new StringBuilder();
			int i = 0;
			while (i < jsonString.Length)
			{
				char c = jsonString[i++];
				if (c == '\\')
				{
					int num = jsonString.Length - i;
					if (num >= 2)
					{
						char c2 = jsonString[i];
						if (c2 == '\\')
						{
							stringBuilder.Append('\\');
							i++;
						}
						else if (c2 == '"')
						{
							stringBuilder.Append("\"");
							i++;
						}
						else if (c2 == 't')
						{
							stringBuilder.Append('\t');
							i++;
						}
						else if (c2 == 'b')
						{
							stringBuilder.Append('\b');
							i++;
						}
						else if (c2 == 'n')
						{
							stringBuilder.Append('\n');
							i++;
						}
						else if (c2 == 'r')
						{
							stringBuilder.Append('\r');
							i++;
						}
					}
				}
				else
				{
					stringBuilder.Append(c);
				}
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06015901 RID: 88321 RVA: 0x0057DCD0 File Offset: 0x0057BED0
		private static IDictionary<string, object> ParseObject(char[] json, ref int index, ref bool success)
		{
			IDictionary<string, object> dictionary = new JsonObject();
			SimpleJson.NextToken(json, ref index);
			bool flag = false;
			while (!flag)
			{
				int num = SimpleJson.LookAhead(json, index);
				if (num == 0)
				{
					success = false;
					return null;
				}
				if (num == 6)
				{
					SimpleJson.NextToken(json, ref index);
				}
				else
				{
					if (num == 2)
					{
						SimpleJson.NextToken(json, ref index);
						return dictionary;
					}
					string key = SimpleJson.ParseString(json, ref index, ref success);
					if (!success)
					{
						success = false;
						return null;
					}
					num = SimpleJson.NextToken(json, ref index);
					if (num != 5)
					{
						success = false;
						return null;
					}
					object value = SimpleJson.ParseValue(json, ref index, ref success);
					if (!success)
					{
						success = false;
						return null;
					}
					dictionary[key] = value;
				}
			}
			return dictionary;
		}

		// Token: 0x06015902 RID: 88322 RVA: 0x0057DD7C File Offset: 0x0057BF7C
		private static JsonArray ParseArray(char[] json, ref int index, ref bool success)
		{
			JsonArray jsonArray = new JsonArray();
			SimpleJson.NextToken(json, ref index);
			bool flag = false;
			while (!flag)
			{
				int num = SimpleJson.LookAhead(json, index);
				if (num == 0)
				{
					success = false;
					return null;
				}
				if (num == 6)
				{
					SimpleJson.NextToken(json, ref index);
				}
				else
				{
					if (num == 4)
					{
						SimpleJson.NextToken(json, ref index);
						break;
					}
					object item = SimpleJson.ParseValue(json, ref index, ref success);
					if (!success)
					{
						return null;
					}
					jsonArray.Add(item);
				}
			}
			return jsonArray;
		}

		// Token: 0x06015903 RID: 88323 RVA: 0x0057DDFC File Offset: 0x0057BFFC
		private static object ParseValue(char[] json, ref int index, ref bool success)
		{
			switch (SimpleJson.LookAhead(json, index))
			{
			case 1:
				return SimpleJson.ParseObject(json, ref index, ref success);
			case 3:
				return SimpleJson.ParseArray(json, ref index, ref success);
			case 7:
				return SimpleJson.ParseString(json, ref index, ref success);
			case 8:
				return SimpleJson.ParseNumber(json, ref index, ref success);
			case 9:
				SimpleJson.NextToken(json, ref index);
				return true;
			case 10:
				SimpleJson.NextToken(json, ref index);
				return false;
			case 11:
				SimpleJson.NextToken(json, ref index);
				return null;
			}
			success = false;
			return null;
		}

		// Token: 0x06015904 RID: 88324 RVA: 0x0057DEA4 File Offset: 0x0057C0A4
		private static string ParseString(char[] json, ref int index, ref bool success)
		{
			StringBuilder stringBuilder = new StringBuilder(2000);
			SimpleJson.EatWhitespace(json, ref index);
			char c = json[index++];
			bool flag = false;
			while (!flag)
			{
				if (index == json.Length)
				{
					break;
				}
				c = json[index++];
				if (c == '"')
				{
					flag = true;
					break;
				}
				if (c == '\\')
				{
					if (index == json.Length)
					{
						break;
					}
					c = json[index++];
					if (c == '"')
					{
						stringBuilder.Append('"');
					}
					else if (c == '\\')
					{
						stringBuilder.Append('\\');
					}
					else if (c == '/')
					{
						stringBuilder.Append('/');
					}
					else if (c == 'b')
					{
						stringBuilder.Append('\b');
					}
					else if (c == 'f')
					{
						stringBuilder.Append('\f');
					}
					else if (c == 'n')
					{
						stringBuilder.Append('\n');
					}
					else if (c == 'r')
					{
						stringBuilder.Append('\r');
					}
					else if (c == 't')
					{
						stringBuilder.Append('\t');
					}
					else if (c == 'u')
					{
						int num = json.Length - index;
						if (num < 4)
						{
							break;
						}
						uint num2;
						if (!(success = uint.TryParse(new string(json, index, 4), NumberStyles.HexNumber, CultureInfo.InvariantCulture, out num2)))
						{
							return string.Empty;
						}
						if (55296u <= num2 && num2 <= 56319u)
						{
							index += 4;
							num = json.Length - index;
							uint num3;
							if (num < 6 || !(new string(json, index, 2) == "\\u") || !uint.TryParse(new string(json, index + 2, 4), NumberStyles.HexNumber, CultureInfo.InvariantCulture, out num3) || 56320u > num3 || num3 > 57343u)
							{
								success = false;
								return string.Empty;
							}
							stringBuilder.Append((char)num2);
							stringBuilder.Append((char)num3);
							index += 6;
						}
						else
						{
							stringBuilder.Append(SimpleJson.ConvertFromUtf32((int)num2));
							index += 4;
						}
					}
				}
				else
				{
					stringBuilder.Append(c);
				}
			}
			if (!flag)
			{
				success = false;
				return null;
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06015905 RID: 88325 RVA: 0x0057E100 File Offset: 0x0057C300
		private static string ConvertFromUtf32(int utf32)
		{
			if (utf32 < 0 || utf32 > 1114111)
			{
				throw new ArgumentOutOfRangeException("utf32", "The argument must be from 0 to 0x10FFFF.");
			}
			if (55296 <= utf32 && utf32 <= 57343)
			{
				throw new ArgumentOutOfRangeException("utf32", "The argument must not be in surrogate pair range.");
			}
			if (utf32 < 65536)
			{
				return new string((char)utf32, 1);
			}
			utf32 -= 65536;
			return new string(new char[]
			{
				(char)((utf32 >> 10) + 55296),
				(char)(utf32 % 1024 + 56320)
			});
		}

		// Token: 0x06015906 RID: 88326 RVA: 0x0057E19C File Offset: 0x0057C39C
		private static object ParseNumber(char[] json, ref int index, ref bool success)
		{
			SimpleJson.EatWhitespace(json, ref index);
			int lastIndexOfNumber = SimpleJson.GetLastIndexOfNumber(json, index);
			int length = lastIndexOfNumber - index + 1;
			string text = new string(json, index, length);
			object result;
			if (text.IndexOf(".", StringComparison.OrdinalIgnoreCase) != -1 || text.IndexOf("e", StringComparison.OrdinalIgnoreCase) != -1)
			{
				double num;
				success = double.TryParse(new string(json, index, length), NumberStyles.Any, CultureInfo.InvariantCulture, out num);
				result = num;
			}
			else
			{
				long num2;
				success = long.TryParse(new string(json, index, length), NumberStyles.Any, CultureInfo.InvariantCulture, out num2);
				result = num2;
			}
			index = lastIndexOfNumber + 1;
			return result;
		}

		// Token: 0x06015907 RID: 88327 RVA: 0x0057E244 File Offset: 0x0057C444
		private static int GetLastIndexOfNumber(char[] json, int index)
		{
			int i;
			for (i = index; i < json.Length; i++)
			{
				if ("0123456789+-.eE".IndexOf(json[i]) == -1)
				{
					break;
				}
			}
			return i - 1;
		}

		// Token: 0x06015908 RID: 88328 RVA: 0x0057E280 File Offset: 0x0057C480
		private static void EatWhitespace(char[] json, ref int index)
		{
			while (index < json.Length)
			{
				if (" \t\n\r\b\f".IndexOf(json[index]) == -1)
				{
					break;
				}
				index++;
			}
		}

		// Token: 0x06015909 RID: 88329 RVA: 0x0057E2B0 File Offset: 0x0057C4B0
		private static int LookAhead(char[] json, int index)
		{
			int num = index;
			return SimpleJson.NextToken(json, ref num);
		}

		// Token: 0x0601590A RID: 88330 RVA: 0x0057E2C8 File Offset: 0x0057C4C8
		private static int NextToken(char[] json, ref int index)
		{
			SimpleJson.EatWhitespace(json, ref index);
			if (index == json.Length)
			{
				return 0;
			}
			char c = json[index];
			index++;
			switch (c)
			{
			case ',':
				return 6;
			case '-':
			case '0':
			case '1':
			case '2':
			case '3':
			case '4':
			case '5':
			case '6':
			case '7':
			case '8':
			case '9':
				return 8;
			default:
				switch (c)
				{
				case '[':
					return 3;
				default:
					switch (c)
					{
					case '{':
						return 1;
					default:
					{
						if (c == '"')
						{
							return 7;
						}
						index--;
						int num = json.Length - index;
						if (num >= 5 && json[index] == 'f' && json[index + 1] == 'a' && json[index + 2] == 'l' && json[index + 3] == 's' && json[index + 4] == 'e')
						{
							index += 5;
							return 10;
						}
						if (num >= 4 && json[index] == 't' && json[index + 1] == 'r' && json[index + 2] == 'u' && json[index + 3] == 'e')
						{
							index += 4;
							return 9;
						}
						if (num >= 4 && json[index] == 'n' && json[index + 1] == 'u' && json[index + 2] == 'l' && json[index + 3] == 'l')
						{
							index += 4;
							return 11;
						}
						return 0;
					}
					case '}':
						return 2;
					}
					break;
				case ']':
					return 4;
				}
				break;
			case ':':
				return 5;
			}
		}

		// Token: 0x0601590B RID: 88331 RVA: 0x0057E460 File Offset: 0x0057C660
		private static bool SerializeValue(IJsonSerializerStrategy jsonSerializerStrategy, object value, StringBuilder builder)
		{
			bool flag = true;
			string text = value as string;
			if (text != null)
			{
				flag = SimpleJson.SerializeString(text, builder);
			}
			else
			{
				IDictionary<string, object> dictionary = value as IDictionary<string, object>;
				if (dictionary != null)
				{
					flag = SimpleJson.SerializeObject(jsonSerializerStrategy, dictionary.Keys, dictionary.Values, builder);
				}
				else
				{
					IDictionary<string, string> dictionary2 = value as IDictionary<string, string>;
					if (dictionary2 != null)
					{
						flag = SimpleJson.SerializeObject(jsonSerializerStrategy, dictionary2.Keys, dictionary2.Values, builder);
					}
					else
					{
						IEnumerable enumerable = value as IEnumerable;
						if (enumerable != null)
						{
							flag = SimpleJson.SerializeArray(jsonSerializerStrategy, enumerable, builder);
						}
						else if (SimpleJson.IsNumeric(value))
						{
							flag = SimpleJson.SerializeNumber(value, builder);
						}
						else if (value is bool)
						{
							builder.Append((!(bool)value) ? "false" : "true");
						}
						else if (value == null)
						{
							builder.Append("null");
						}
						else
						{
							object value2;
							flag = jsonSerializerStrategy.TrySerializeNonPrimitiveObject(value, out value2);
							if (flag)
							{
								SimpleJson.SerializeValue(jsonSerializerStrategy, value2, builder);
							}
						}
					}
				}
			}
			return flag;
		}

		// Token: 0x0601590C RID: 88332 RVA: 0x0057E570 File Offset: 0x0057C770
		private static bool SerializeObject(IJsonSerializerStrategy jsonSerializerStrategy, IEnumerable keys, IEnumerable values, StringBuilder builder)
		{
			builder.Append("{");
			IEnumerator enumerator = keys.GetEnumerator();
			IEnumerator enumerator2 = values.GetEnumerator();
			bool flag = true;
			while (enumerator.MoveNext() && enumerator2.MoveNext())
			{
				object obj = enumerator.Current;
				object value = enumerator2.Current;
				if (!flag)
				{
					builder.Append(",");
				}
				string text = obj as string;
				if (text != null)
				{
					SimpleJson.SerializeString(text, builder);
				}
				else if (!SimpleJson.SerializeValue(jsonSerializerStrategy, value, builder))
				{
					return false;
				}
				builder.Append(":");
				if (!SimpleJson.SerializeValue(jsonSerializerStrategy, value, builder))
				{
					return false;
				}
				flag = false;
			}
			builder.Append("}");
			return true;
		}

		// Token: 0x0601590D RID: 88333 RVA: 0x0057E630 File Offset: 0x0057C830
		private static bool SerializeArray(IJsonSerializerStrategy jsonSerializerStrategy, IEnumerable anArray, StringBuilder builder)
		{
			builder.Append("[");
			bool flag = true;
			IEnumerator enumerator = anArray.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					object value = enumerator.Current;
					if (!flag)
					{
						builder.Append(",");
					}
					if (!SimpleJson.SerializeValue(jsonSerializerStrategy, value, builder))
					{
						return false;
					}
					flag = false;
				}
			}
			finally
			{
				IDisposable disposable;
				if ((disposable = (enumerator as IDisposable)) != null)
				{
					disposable.Dispose();
				}
			}
			builder.Append("]");
			return true;
		}

		// Token: 0x0601590E RID: 88334 RVA: 0x0057E6CC File Offset: 0x0057C8CC
		private static bool SerializeString(string aString, StringBuilder builder)
		{
			if (aString.IndexOfAny(SimpleJson.EscapeCharacters) == -1)
			{
				builder.Append('"');
				builder.Append(aString);
				builder.Append('"');
				return true;
			}
			builder.Append('"');
			int num = 0;
			char[] array = aString.ToCharArray();
			for (int i = 0; i < array.Length; i++)
			{
				char c = array[i];
				if ((int)c >= SimpleJson.EscapeTable.Length || SimpleJson.EscapeTable[(int)c] == '\0')
				{
					num++;
				}
				else
				{
					if (num > 0)
					{
						builder.Append(array, i - num, num);
						num = 0;
					}
					builder.Append('\\');
					builder.Append(SimpleJson.EscapeTable[(int)c]);
				}
			}
			if (num > 0)
			{
				builder.Append(array, array.Length - num, num);
			}
			builder.Append('"');
			return true;
		}

		// Token: 0x0601590F RID: 88335 RVA: 0x0057E7A0 File Offset: 0x0057C9A0
		private static bool SerializeNumber(object number, StringBuilder builder)
		{
			if (number is long)
			{
				builder.Append(((long)number).ToString(CultureInfo.InvariantCulture));
			}
			else if (number is ulong)
			{
				builder.Append(((ulong)number).ToString(CultureInfo.InvariantCulture));
			}
			else if (number is int)
			{
				builder.Append(((int)number).ToString(CultureInfo.InvariantCulture));
			}
			else if (number is uint)
			{
				builder.Append(((uint)number).ToString(CultureInfo.InvariantCulture));
			}
			else if (number is decimal)
			{
				builder.Append(((decimal)number).ToString(CultureInfo.InvariantCulture));
			}
			else if (number is float)
			{
				builder.Append(((float)number).ToString(CultureInfo.InvariantCulture));
			}
			else
			{
				builder.Append(Convert.ToDouble(number, CultureInfo.InvariantCulture).ToString("r", CultureInfo.InvariantCulture));
			}
			return true;
		}

		// Token: 0x06015910 RID: 88336 RVA: 0x0057E8D4 File Offset: 0x0057CAD4
		private static bool IsNumeric(object value)
		{
			return value is sbyte || value is byte || value is short || value is ushort || value is int || value is uint || value is long || value is ulong || value is float || value is double || value is decimal;
		}

		// Token: 0x17003EE5 RID: 16101
		// (get) Token: 0x06015911 RID: 88337 RVA: 0x0057E974 File Offset: 0x0057CB74
		// (set) Token: 0x06015912 RID: 88338 RVA: 0x0057E990 File Offset: 0x0057CB90
		public static IJsonSerializerStrategy CurrentJsonSerializerStrategy
		{
			get
			{
				IJsonSerializerStrategy result;
				if ((result = SimpleJson._currentJsonSerializerStrategy) == null)
				{
					result = (SimpleJson._currentJsonSerializerStrategy = SimpleJson.PocoJsonSerializerStrategy);
				}
				return result;
			}
			set
			{
				SimpleJson._currentJsonSerializerStrategy = value;
			}
		}

		// Token: 0x17003EE6 RID: 16102
		// (get) Token: 0x06015913 RID: 88339 RVA: 0x0057E998 File Offset: 0x0057CB98
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static PocoJsonSerializerStrategy PocoJsonSerializerStrategy
		{
			get
			{
				PocoJsonSerializerStrategy result;
				if ((result = SimpleJson._pocoJsonSerializerStrategy) == null)
				{
					result = (SimpleJson._pocoJsonSerializerStrategy = new PocoJsonSerializerStrategy());
				}
				return result;
			}
		}

		// Token: 0x0400BC88 RID: 48264
		private const int TOKEN_NONE = 0;

		// Token: 0x0400BC89 RID: 48265
		private const int TOKEN_CURLY_OPEN = 1;

		// Token: 0x0400BC8A RID: 48266
		private const int TOKEN_CURLY_CLOSE = 2;

		// Token: 0x0400BC8B RID: 48267
		private const int TOKEN_SQUARED_OPEN = 3;

		// Token: 0x0400BC8C RID: 48268
		private const int TOKEN_SQUARED_CLOSE = 4;

		// Token: 0x0400BC8D RID: 48269
		private const int TOKEN_COLON = 5;

		// Token: 0x0400BC8E RID: 48270
		private const int TOKEN_COMMA = 6;

		// Token: 0x0400BC8F RID: 48271
		private const int TOKEN_STRING = 7;

		// Token: 0x0400BC90 RID: 48272
		private const int TOKEN_NUMBER = 8;

		// Token: 0x0400BC91 RID: 48273
		private const int TOKEN_TRUE = 9;

		// Token: 0x0400BC92 RID: 48274
		private const int TOKEN_FALSE = 10;

		// Token: 0x0400BC93 RID: 48275
		private const int TOKEN_NULL = 11;

		// Token: 0x0400BC94 RID: 48276
		private const int BUILDER_CAPACITY = 2000;

		// Token: 0x0400BC95 RID: 48277
		private static readonly char[] EscapeTable;

		// Token: 0x0400BC96 RID: 48278
		private static readonly char[] EscapeCharacters = new char[]
		{
			'"',
			'\\',
			'\b',
			'\f',
			'\n',
			'\r',
			'\t'
		};

		// Token: 0x0400BC97 RID: 48279
		private static IJsonSerializerStrategy _currentJsonSerializerStrategy;

		// Token: 0x0400BC98 RID: 48280
		private static PocoJsonSerializerStrategy _pocoJsonSerializerStrategy;
	}
}
