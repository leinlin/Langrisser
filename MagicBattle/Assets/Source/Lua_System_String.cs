using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001606 RID: 5638
[Preserve]
public class Lua_System_String : LuaObject
{
	// Token: 0x06022982 RID: 141698 RVA: 0x00BE1EF4 File Offset: 0x00BE00F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 4)
			{
				char[] value;
				LuaObject.checkArray(l, 2, out value);
				int startIndex;
				LuaObject.checkType(l, 3, out startIndex);
				int length;
				LuaObject.checkType(l, 4, out length);
				string o = new string(value, startIndex, length);
				LuaObject.pushValue(l, true);
				LuaObject.pushObject(l, o);
				result = 2;
			}
			else if (num == 2)
			{
				char[] value2;
				LuaObject.checkArray(l, 2, out value2);
				string o = new string(value2);
				LuaObject.pushValue(l, true);
				LuaObject.pushObject(l, o);
				result = 2;
			}
			else if (num == 3)
			{
				char c;
				LuaObject.checkType(l, 2, out c);
				int count;
				LuaObject.checkType(l, 3, out count);
				string o = new string(c, count);
				LuaObject.pushValue(l, true);
				LuaObject.pushObject(l, o);
				result = 2;
			}
			else
			{
				result = LuaObject.error(l, "New object failed.");
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022983 RID: 141699 RVA: 0x00BE1FEC File Offset: 0x00BE01EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetTypeCode(IntPtr l)
	{
		int result;
		try
		{
			string text = (string)LuaObject.checkSelf(l);
			TypeCode typeCode = text.GetTypeCode();
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)typeCode);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022984 RID: 141700 RVA: 0x00BE2040 File Offset: 0x00BE0240
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ToCharArray(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				string text = (string)LuaObject.checkSelf(l);
				char[] a = text.ToCharArray();
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, a);
				result = 2;
			}
			else if (num == 3)
			{
				string text2 = (string)LuaObject.checkSelf(l);
				int startIndex;
				LuaObject.checkType(l, 2, out startIndex);
				int length;
				LuaObject.checkType(l, 3, out length);
				char[] a2 = text2.ToCharArray(startIndex, length);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, a2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function ToCharArray to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022985 RID: 141701 RVA: 0x00BE2108 File Offset: 0x00BE0308
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Split(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				string text = (string)LuaObject.checkSelf(l);
				char[] separator;
				LuaObject.checkParams(l, 2, out separator);
				string[] a = text.Split(separator);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, a);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(char[]), typeof(StringSplitOptions)))
			{
				string text2 = (string)LuaObject.checkSelf(l);
				char[] separator2;
				LuaObject.checkArray(l, 2, out separator2);
				StringSplitOptions options;
				LuaObject.checkEnum<StringSplitOptions>(l, 3, out options);
				string[] a2 = text2.Split(separator2, options);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, a2);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(string[]), typeof(StringSplitOptions)))
			{
				string text3 = (string)LuaObject.checkSelf(l);
				string[] separator3;
				LuaObject.checkArray<string>(l, 2, out separator3);
				StringSplitOptions options2;
				LuaObject.checkEnum<StringSplitOptions>(l, 3, out options2);
				string[] a3 = text3.Split(separator3, options2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, a3);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(char[]), typeof(int)))
			{
				string text4 = (string)LuaObject.checkSelf(l);
				char[] separator4;
				LuaObject.checkArray(l, 2, out separator4);
				int count;
				LuaObject.checkType(l, 3, out count);
				string[] a4 = text4.Split(separator4, count);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, a4);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(char[]), typeof(int), typeof(StringSplitOptions)))
			{
				string text5 = (string)LuaObject.checkSelf(l);
				char[] separator5;
				LuaObject.checkArray(l, 2, out separator5);
				int count2;
				LuaObject.checkType(l, 3, out count2);
				StringSplitOptions options3;
				LuaObject.checkEnum<StringSplitOptions>(l, 4, out options3);
				string[] a5 = text5.Split(separator5, count2, options3);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, a5);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(string[]), typeof(int), typeof(StringSplitOptions)))
			{
				string text6 = (string)LuaObject.checkSelf(l);
				string[] separator6;
				LuaObject.checkArray<string>(l, 2, out separator6);
				int count3;
				LuaObject.checkType(l, 3, out count3);
				StringSplitOptions options4;
				LuaObject.checkEnum<StringSplitOptions>(l, 4, out options4);
				string[] a6 = text6.Split(separator6, count3, options4);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, a6);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function Split to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022986 RID: 141702 RVA: 0x00BE23CC File Offset: 0x00BE05CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Substring(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				string text = (string)LuaObject.checkSelf(l);
				int startIndex;
				LuaObject.checkType(l, 2, out startIndex);
				string s = text.Substring(startIndex);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, s);
				result = 2;
			}
			else if (num == 3)
			{
				string text2 = (string)LuaObject.checkSelf(l);
				int startIndex2;
				LuaObject.checkType(l, 2, out startIndex2);
				int length;
				LuaObject.checkType(l, 3, out length);
				string s2 = text2.Substring(startIndex2, length);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, s2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function Substring to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022987 RID: 141703 RVA: 0x00BE24A4 File Offset: 0x00BE06A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Trim(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				string text = (string)LuaObject.checkSelf(l);
				string s = text.Trim();
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, s);
				result = 2;
			}
			else if (num == 2)
			{
				string text2 = (string)LuaObject.checkSelf(l);
				char[] trimChars;
				LuaObject.checkParams(l, 2, out trimChars);
				string s2 = text2.Trim(trimChars);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, s2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function Trim to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022988 RID: 141704 RVA: 0x00BE2560 File Offset: 0x00BE0760
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TrimStart(IntPtr l)
	{
		int result;
		try
		{
			string text = (string)LuaObject.checkSelf(l);
			char[] trimChars;
			LuaObject.checkParams(l, 2, out trimChars);
			string s = text.TrimStart(trimChars);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, s);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022989 RID: 141705 RVA: 0x00BE25C4 File Offset: 0x00BE07C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TrimEnd(IntPtr l)
	{
		int result;
		try
		{
			string text = (string)LuaObject.checkSelf(l);
			char[] trimChars;
			LuaObject.checkParams(l, 2, out trimChars);
			string s = text.TrimEnd(trimChars);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, s);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602298A RID: 141706 RVA: 0x00BE2628 File Offset: 0x00BE0828
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CompareTo(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(object)))
			{
				string text = (string)LuaObject.checkSelf(l);
				object value;
				LuaObject.checkType<object>(l, 2, out value);
				int i = text.CompareTo(value);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string)))
			{
				string text2 = (string)LuaObject.checkSelf(l);
				string strB;
				LuaObject.checkType(l, 2, out strB);
				int i2 = text2.CompareTo(strB);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function CompareTo to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602298B RID: 141707 RVA: 0x00BE2714 File Offset: 0x00BE0914
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int EndsWith(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				string text = (string)LuaObject.checkSelf(l);
				string value;
				LuaObject.checkType(l, 2, out value);
				bool b = text.EndsWith(value);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b);
				result = 2;
			}
			else if (num == 3)
			{
				string text2 = (string)LuaObject.checkSelf(l);
				string value2;
				LuaObject.checkType(l, 2, out value2);
				StringComparison comparisonType;
				LuaObject.checkEnum<StringComparison>(l, 3, out comparisonType);
				bool b2 = text2.EndsWith(value2, comparisonType);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b2);
				result = 2;
			}
			else if (num == 4)
			{
				string text3 = (string)LuaObject.checkSelf(l);
				string value3;
				LuaObject.checkType(l, 2, out value3);
				bool ignoreCase;
				LuaObject.checkType(l, 3, out ignoreCase);
				CultureInfo culture;
				LuaObject.checkType<CultureInfo>(l, 4, out culture);
				bool b3 = text3.EndsWith(value3, ignoreCase, culture);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b3);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function EndsWith to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602298C RID: 141708 RVA: 0x00BE2850 File Offset: 0x00BE0A50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IndexOfAny(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				string text = (string)LuaObject.checkSelf(l);
				char[] anyOf;
				LuaObject.checkArray(l, 2, out anyOf);
				int i = text.IndexOfAny(anyOf);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i);
				result = 2;
			}
			else if (num == 3)
			{
				string text2 = (string)LuaObject.checkSelf(l);
				char[] anyOf2;
				LuaObject.checkArray(l, 2, out anyOf2);
				int startIndex;
				LuaObject.checkType(l, 3, out startIndex);
				int i2 = text2.IndexOfAny(anyOf2, startIndex);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i2);
				result = 2;
			}
			else if (num == 4)
			{
				string text3 = (string)LuaObject.checkSelf(l);
				char[] anyOf3;
				LuaObject.checkArray(l, 2, out anyOf3);
				int startIndex2;
				LuaObject.checkType(l, 3, out startIndex2);
				int count;
				LuaObject.checkType(l, 4, out count);
				int i3 = text3.IndexOfAny(anyOf3, startIndex2, count);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i3);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function IndexOfAny to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602298D RID: 141709 RVA: 0x00BE298C File Offset: 0x00BE0B8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IndexOf(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, num, 2, typeof(string), typeof(int)))
			{
				string text = (string)LuaObject.checkSelf(l);
				string value;
				LuaObject.checkType(l, 2, out value);
				int startIndex;
				LuaObject.checkType(l, 3, out startIndex);
				int i = text.IndexOf(value, startIndex);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(string)))
			{
				string text2 = (string)LuaObject.checkSelf(l);
				string value2;
				LuaObject.checkType(l, 2, out value2);
				int i2 = text2.IndexOf(value2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i2);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(char)))
			{
				string text3 = (string)LuaObject.checkSelf(l);
				char value3;
				LuaObject.checkType(l, 2, out value3);
				int i3 = text3.IndexOf(value3);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i3);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(char), typeof(int)))
			{
				string text4 = (string)LuaObject.checkSelf(l);
				char value4;
				LuaObject.checkType(l, 2, out value4);
				int startIndex2;
				LuaObject.checkType(l, 3, out startIndex2);
				int i4 = text4.IndexOf(value4, startIndex2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i4);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(string), typeof(StringComparison)))
			{
				string text5 = (string)LuaObject.checkSelf(l);
				string value5;
				LuaObject.checkType(l, 2, out value5);
				StringComparison comparisonType;
				LuaObject.checkEnum<StringComparison>(l, 3, out comparisonType);
				int i5 = text5.IndexOf(value5, comparisonType);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i5);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(string), typeof(int), typeof(int)))
			{
				string text6 = (string)LuaObject.checkSelf(l);
				string value6;
				LuaObject.checkType(l, 2, out value6);
				int startIndex3;
				LuaObject.checkType(l, 3, out startIndex3);
				int count;
				LuaObject.checkType(l, 4, out count);
				int i6 = text6.IndexOf(value6, startIndex3, count);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i6);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(string), typeof(int), typeof(StringComparison)))
			{
				string text7 = (string)LuaObject.checkSelf(l);
				string value7;
				LuaObject.checkType(l, 2, out value7);
				int startIndex4;
				LuaObject.checkType(l, 3, out startIndex4);
				StringComparison comparisonType2;
				LuaObject.checkEnum<StringComparison>(l, 4, out comparisonType2);
				int i7 = text7.IndexOf(value7, startIndex4, comparisonType2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i7);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(char), typeof(int), typeof(int)))
			{
				string text8 = (string)LuaObject.checkSelf(l);
				char value8;
				LuaObject.checkType(l, 2, out value8);
				int startIndex5;
				LuaObject.checkType(l, 3, out startIndex5);
				int count2;
				LuaObject.checkType(l, 4, out count2);
				int i8 = text8.IndexOf(value8, startIndex5, count2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i8);
				result = 2;
			}
			else if (num == 5)
			{
				string text9 = (string)LuaObject.checkSelf(l);
				string value9;
				LuaObject.checkType(l, 2, out value9);
				int startIndex6;
				LuaObject.checkType(l, 3, out startIndex6);
				int count3;
				LuaObject.checkType(l, 4, out count3);
				StringComparison comparisonType3;
				LuaObject.checkEnum<StringComparison>(l, 5, out comparisonType3);
				int i9 = text9.IndexOf(value9, startIndex6, count3, comparisonType3);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i9);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function IndexOf to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602298E RID: 141710 RVA: 0x00BE2D90 File Offset: 0x00BE0F90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LastIndexOf(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, num, 2, typeof(string), typeof(int)))
			{
				string text = (string)LuaObject.checkSelf(l);
				string value;
				LuaObject.checkType(l, 2, out value);
				int startIndex;
				LuaObject.checkType(l, 3, out startIndex);
				int i = text.LastIndexOf(value, startIndex);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(string)))
			{
				string text2 = (string)LuaObject.checkSelf(l);
				string value2;
				LuaObject.checkType(l, 2, out value2);
				int i2 = text2.LastIndexOf(value2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i2);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(char)))
			{
				string text3 = (string)LuaObject.checkSelf(l);
				char value3;
				LuaObject.checkType(l, 2, out value3);
				int i3 = text3.LastIndexOf(value3);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i3);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(char), typeof(int)))
			{
				string text4 = (string)LuaObject.checkSelf(l);
				char value4;
				LuaObject.checkType(l, 2, out value4);
				int startIndex2;
				LuaObject.checkType(l, 3, out startIndex2);
				int i4 = text4.LastIndexOf(value4, startIndex2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i4);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(string), typeof(StringComparison)))
			{
				string text5 = (string)LuaObject.checkSelf(l);
				string value5;
				LuaObject.checkType(l, 2, out value5);
				StringComparison comparisonType;
				LuaObject.checkEnum<StringComparison>(l, 3, out comparisonType);
				int i5 = text5.LastIndexOf(value5, comparisonType);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i5);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(string), typeof(int), typeof(int)))
			{
				string text6 = (string)LuaObject.checkSelf(l);
				string value6;
				LuaObject.checkType(l, 2, out value6);
				int startIndex3;
				LuaObject.checkType(l, 3, out startIndex3);
				int count;
				LuaObject.checkType(l, 4, out count);
				int i6 = text6.LastIndexOf(value6, startIndex3, count);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i6);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(string), typeof(int), typeof(StringComparison)))
			{
				string text7 = (string)LuaObject.checkSelf(l);
				string value7;
				LuaObject.checkType(l, 2, out value7);
				int startIndex4;
				LuaObject.checkType(l, 3, out startIndex4);
				StringComparison comparisonType2;
				LuaObject.checkEnum<StringComparison>(l, 4, out comparisonType2);
				int i7 = text7.LastIndexOf(value7, startIndex4, comparisonType2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i7);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(char), typeof(int), typeof(int)))
			{
				string text8 = (string)LuaObject.checkSelf(l);
				char value8;
				LuaObject.checkType(l, 2, out value8);
				int startIndex5;
				LuaObject.checkType(l, 3, out startIndex5);
				int count2;
				LuaObject.checkType(l, 4, out count2);
				int i8 = text8.LastIndexOf(value8, startIndex5, count2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i8);
				result = 2;
			}
			else if (num == 5)
			{
				string text9 = (string)LuaObject.checkSelf(l);
				string value9;
				LuaObject.checkType(l, 2, out value9);
				int startIndex6;
				LuaObject.checkType(l, 3, out startIndex6);
				int count3;
				LuaObject.checkType(l, 4, out count3);
				StringComparison comparisonType3;
				LuaObject.checkEnum<StringComparison>(l, 5, out comparisonType3);
				int i9 = text9.LastIndexOf(value9, startIndex6, count3, comparisonType3);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i9);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function LastIndexOf to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602298F RID: 141711 RVA: 0x00BE3194 File Offset: 0x00BE1394
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LastIndexOfAny(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				string text = (string)LuaObject.checkSelf(l);
				char[] anyOf;
				LuaObject.checkArray(l, 2, out anyOf);
				int i = text.LastIndexOfAny(anyOf);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i);
				result = 2;
			}
			else if (num == 3)
			{
				string text2 = (string)LuaObject.checkSelf(l);
				char[] anyOf2;
				LuaObject.checkArray(l, 2, out anyOf2);
				int startIndex;
				LuaObject.checkType(l, 3, out startIndex);
				int i2 = text2.LastIndexOfAny(anyOf2, startIndex);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i2);
				result = 2;
			}
			else if (num == 4)
			{
				string text3 = (string)LuaObject.checkSelf(l);
				char[] anyOf3;
				LuaObject.checkArray(l, 2, out anyOf3);
				int startIndex2;
				LuaObject.checkType(l, 3, out startIndex2);
				int count;
				LuaObject.checkType(l, 4, out count);
				int i3 = text3.LastIndexOfAny(anyOf3, startIndex2, count);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i3);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function LastIndexOfAny to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022990 RID: 141712 RVA: 0x00BE32D0 File Offset: 0x00BE14D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Contains(IntPtr l)
	{
		int result;
		try
		{
			string text = (string)LuaObject.checkSelf(l);
			string value;
			LuaObject.checkType(l, 2, out value);
			bool b = text.Contains(value);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022991 RID: 141713 RVA: 0x00BE3334 File Offset: 0x00BE1534
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Normalize(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				string text = (string)LuaObject.checkSelf(l);
				string s = text.Normalize();
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, s);
				result = 2;
			}
			else if (num == 2)
			{
				string text2 = (string)LuaObject.checkSelf(l);
				NormalizationForm normalizationForm;
				LuaObject.checkEnum<NormalizationForm>(l, 2, out normalizationForm);
				string s2 = text2.Normalize(normalizationForm);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, s2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function Normalize to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022992 RID: 141714 RVA: 0x00BE33F0 File Offset: 0x00BE15F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsNormalized(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				string text = (string)LuaObject.checkSelf(l);
				bool b = text.IsNormalized();
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b);
				result = 2;
			}
			else if (num == 2)
			{
				string text2 = (string)LuaObject.checkSelf(l);
				NormalizationForm normalizationForm;
				LuaObject.checkEnum<NormalizationForm>(l, 2, out normalizationForm);
				bool b2 = text2.IsNormalized(normalizationForm);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function IsNormalized to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022993 RID: 141715 RVA: 0x00BE34AC File Offset: 0x00BE16AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Remove(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				string text = (string)LuaObject.checkSelf(l);
				int startIndex;
				LuaObject.checkType(l, 2, out startIndex);
				string s = text.Remove(startIndex);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, s);
				result = 2;
			}
			else if (num == 3)
			{
				string text2 = (string)LuaObject.checkSelf(l);
				int startIndex2;
				LuaObject.checkType(l, 2, out startIndex2);
				int count;
				LuaObject.checkType(l, 3, out count);
				string s2 = text2.Remove(startIndex2, count);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, s2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function Remove to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022994 RID: 141716 RVA: 0x00BE3584 File Offset: 0x00BE1784
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PadLeft(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				string text = (string)LuaObject.checkSelf(l);
				int totalWidth;
				LuaObject.checkType(l, 2, out totalWidth);
				string s = text.PadLeft(totalWidth);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, s);
				result = 2;
			}
			else if (num == 3)
			{
				string text2 = (string)LuaObject.checkSelf(l);
				int totalWidth2;
				LuaObject.checkType(l, 2, out totalWidth2);
				char paddingChar;
				LuaObject.checkType(l, 3, out paddingChar);
				string s2 = text2.PadLeft(totalWidth2, paddingChar);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, s2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function PadLeft to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022995 RID: 141717 RVA: 0x00BE365C File Offset: 0x00BE185C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PadRight(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				string text = (string)LuaObject.checkSelf(l);
				int totalWidth;
				LuaObject.checkType(l, 2, out totalWidth);
				string s = text.PadRight(totalWidth);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, s);
				result = 2;
			}
			else if (num == 3)
			{
				string text2 = (string)LuaObject.checkSelf(l);
				int totalWidth2;
				LuaObject.checkType(l, 2, out totalWidth2);
				char paddingChar;
				LuaObject.checkType(l, 3, out paddingChar);
				string s2 = text2.PadRight(totalWidth2, paddingChar);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, s2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function PadRight to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022996 RID: 141718 RVA: 0x00BE3734 File Offset: 0x00BE1934
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartsWith(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				string text = (string)LuaObject.checkSelf(l);
				string value;
				LuaObject.checkType(l, 2, out value);
				bool b = text.StartsWith(value);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b);
				result = 2;
			}
			else if (num == 3)
			{
				string text2 = (string)LuaObject.checkSelf(l);
				string value2;
				LuaObject.checkType(l, 2, out value2);
				StringComparison comparisonType;
				LuaObject.checkEnum<StringComparison>(l, 3, out comparisonType);
				bool b2 = text2.StartsWith(value2, comparisonType);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b2);
				result = 2;
			}
			else if (num == 4)
			{
				string text3 = (string)LuaObject.checkSelf(l);
				string value3;
				LuaObject.checkType(l, 2, out value3);
				bool ignoreCase;
				LuaObject.checkType(l, 3, out ignoreCase);
				CultureInfo culture;
				LuaObject.checkType<CultureInfo>(l, 4, out culture);
				bool b3 = text3.StartsWith(value3, ignoreCase, culture);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b3);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function StartsWith to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022997 RID: 141719 RVA: 0x00BE3870 File Offset: 0x00BE1A70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Replace(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(string), typeof(string)))
			{
				string text = (string)LuaObject.checkSelf(l);
				string oldValue;
				LuaObject.checkType(l, 2, out oldValue);
				string newValue;
				LuaObject.checkType(l, 3, out newValue);
				string s = text.Replace(oldValue, newValue);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, s);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(char), typeof(char)))
			{
				string text2 = (string)LuaObject.checkSelf(l);
				char oldChar;
				LuaObject.checkType(l, 2, out oldChar);
				char newChar;
				LuaObject.checkType(l, 3, out newChar);
				string s2 = text2.Replace(oldChar, newChar);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, s2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function Replace to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022998 RID: 141720 RVA: 0x00BE398C File Offset: 0x00BE1B8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ToLower(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				string text = (string)LuaObject.checkSelf(l);
				string s = text.ToLower();
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, s);
				result = 2;
			}
			else if (num == 2)
			{
				string text2 = (string)LuaObject.checkSelf(l);
				CultureInfo culture;
				LuaObject.checkType<CultureInfo>(l, 2, out culture);
				string s2 = text2.ToLower(culture);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, s2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function ToLower to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022999 RID: 141721 RVA: 0x00BE3A48 File Offset: 0x00BE1C48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ToLowerInvariant(IntPtr l)
	{
		int result;
		try
		{
			string text = (string)LuaObject.checkSelf(l);
			string s = text.ToLowerInvariant();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, s);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602299A RID: 141722 RVA: 0x00BE3A9C File Offset: 0x00BE1C9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ToUpper(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				string text = (string)LuaObject.checkSelf(l);
				string s = text.ToUpper();
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, s);
				result = 2;
			}
			else if (num == 2)
			{
				string text2 = (string)LuaObject.checkSelf(l);
				CultureInfo culture;
				LuaObject.checkType<CultureInfo>(l, 2, out culture);
				string s2 = text2.ToUpper(culture);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, s2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function ToUpper to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602299B RID: 141723 RVA: 0x00BE3B58 File Offset: 0x00BE1D58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ToUpperInvariant(IntPtr l)
	{
		int result;
		try
		{
			string text = (string)LuaObject.checkSelf(l);
			string s = text.ToUpperInvariant();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, s);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602299C RID: 141724 RVA: 0x00BE3BAC File Offset: 0x00BE1DAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Insert(IntPtr l)
	{
		int result;
		try
		{
			string text = (string)LuaObject.checkSelf(l);
			int startIndex;
			LuaObject.checkType(l, 2, out startIndex);
			string value;
			LuaObject.checkType(l, 3, out value);
			string s = text.Insert(startIndex, value);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, s);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602299D RID: 141725 RVA: 0x00BE3C1C File Offset: 0x00BE1E1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsValidName(IntPtr l)
	{
		int result;
		try
		{
			string name = (string)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			int i = name.IsValidName(configDataLoader);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602299E RID: 141726 RVA: 0x00BE3C80 File Offset: 0x00BE1E80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Compare_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				string strA;
				LuaObject.checkType(l, 1, out strA);
				string strB;
				LuaObject.checkType(l, 2, out strB);
				int i = string.Compare(strA, strB);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(string), typeof(string), typeof(StringComparison)))
			{
				string strA2;
				LuaObject.checkType(l, 1, out strA2);
				string strB2;
				LuaObject.checkType(l, 2, out strB2);
				StringComparison comparisonType;
				LuaObject.checkEnum<StringComparison>(l, 3, out comparisonType);
				int i2 = string.Compare(strA2, strB2, comparisonType);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i2);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(string), typeof(string), typeof(bool)))
			{
				string strA3;
				LuaObject.checkType(l, 1, out strA3);
				string strB3;
				LuaObject.checkType(l, 2, out strB3);
				bool ignoreCase;
				LuaObject.checkType(l, 3, out ignoreCase);
				int i3 = string.Compare(strA3, strB3, ignoreCase);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i3);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(string), typeof(string), typeof(CultureInfo), typeof(CompareOptions)))
			{
				string strA4;
				LuaObject.checkType(l, 1, out strA4);
				string strB4;
				LuaObject.checkType(l, 2, out strB4);
				CultureInfo culture;
				LuaObject.checkType<CultureInfo>(l, 3, out culture);
				CompareOptions options;
				LuaObject.checkEnum<CompareOptions>(l, 4, out options);
				int i4 = string.Compare(strA4, strB4, culture, options);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i4);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(string), typeof(string), typeof(bool), typeof(CultureInfo)))
			{
				string strA5;
				LuaObject.checkType(l, 1, out strA5);
				string strB5;
				LuaObject.checkType(l, 2, out strB5);
				bool ignoreCase2;
				LuaObject.checkType(l, 3, out ignoreCase2);
				CultureInfo culture2;
				LuaObject.checkType<CultureInfo>(l, 4, out culture2);
				int i5 = string.Compare(strA5, strB5, ignoreCase2, culture2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i5);
				result = 2;
			}
			else if (num == 5)
			{
				string strA6;
				LuaObject.checkType(l, 1, out strA6);
				int indexA;
				LuaObject.checkType(l, 2, out indexA);
				string strB6;
				LuaObject.checkType(l, 3, out strB6);
				int indexB;
				LuaObject.checkType(l, 4, out indexB);
				int length;
				LuaObject.checkType(l, 5, out length);
				int i6 = string.Compare(strA6, indexA, strB6, indexB, length);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i6);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(string), typeof(int), typeof(string), typeof(int), typeof(int), typeof(StringComparison)))
			{
				string strA7;
				LuaObject.checkType(l, 1, out strA7);
				int indexA2;
				LuaObject.checkType(l, 2, out indexA2);
				string strB7;
				LuaObject.checkType(l, 3, out strB7);
				int indexB2;
				LuaObject.checkType(l, 4, out indexB2);
				int length2;
				LuaObject.checkType(l, 5, out length2);
				StringComparison comparisonType2;
				LuaObject.checkEnum<StringComparison>(l, 6, out comparisonType2);
				int i7 = string.Compare(strA7, indexA2, strB7, indexB2, length2, comparisonType2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i7);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(string), typeof(int), typeof(string), typeof(int), typeof(int), typeof(bool)))
			{
				string strA8;
				LuaObject.checkType(l, 1, out strA8);
				int indexA3;
				LuaObject.checkType(l, 2, out indexA3);
				string strB8;
				LuaObject.checkType(l, 3, out strB8);
				int indexB3;
				LuaObject.checkType(l, 4, out indexB3);
				int length3;
				LuaObject.checkType(l, 5, out length3);
				bool ignoreCase3;
				LuaObject.checkType(l, 6, out ignoreCase3);
				int i8 = string.Compare(strA8, indexA3, strB8, indexB3, length3, ignoreCase3);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i8);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(string), typeof(int), typeof(string), typeof(int), typeof(int), typeof(CultureInfo), typeof(CompareOptions)))
			{
				string strA9;
				LuaObject.checkType(l, 1, out strA9);
				int indexA4;
				LuaObject.checkType(l, 2, out indexA4);
				string strB9;
				LuaObject.checkType(l, 3, out strB9);
				int indexB4;
				LuaObject.checkType(l, 4, out indexB4);
				int length4;
				LuaObject.checkType(l, 5, out length4);
				CultureInfo culture3;
				LuaObject.checkType<CultureInfo>(l, 6, out culture3);
				CompareOptions options2;
				LuaObject.checkEnum<CompareOptions>(l, 7, out options2);
				int i9 = string.Compare(strA9, indexA4, strB9, indexB4, length4, culture3, options2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i9);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(string), typeof(int), typeof(string), typeof(int), typeof(int), typeof(bool), typeof(CultureInfo)))
			{
				string strA10;
				LuaObject.checkType(l, 1, out strA10);
				int indexA5;
				LuaObject.checkType(l, 2, out indexA5);
				string strB10;
				LuaObject.checkType(l, 3, out strB10);
				int indexB5;
				LuaObject.checkType(l, 4, out indexB5);
				int length5;
				LuaObject.checkType(l, 5, out length5);
				bool ignoreCase4;
				LuaObject.checkType(l, 6, out ignoreCase4);
				CultureInfo culture4;
				LuaObject.checkType<CultureInfo>(l, 7, out culture4);
				int i10 = string.Compare(strA10, indexA5, strB10, indexB5, length5, ignoreCase4, culture4);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i10);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function Compare to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602299F RID: 141727 RVA: 0x00BE4240 File Offset: 0x00BE2440
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CompareOrdinal_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				string strA;
				LuaObject.checkType(l, 1, out strA);
				string strB;
				LuaObject.checkType(l, 2, out strB);
				int i = string.CompareOrdinal(strA, strB);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i);
				result = 2;
			}
			else if (num == 5)
			{
				string strA2;
				LuaObject.checkType(l, 1, out strA2);
				int indexA;
				LuaObject.checkType(l, 2, out indexA);
				string strB2;
				LuaObject.checkType(l, 3, out strB2);
				int indexB;
				LuaObject.checkType(l, 4, out indexB);
				int length;
				LuaObject.checkType(l, 5, out length);
				int i2 = string.CompareOrdinal(strA2, indexA, strB2, indexB, length);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function CompareOrdinal to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060229A0 RID: 141728 RVA: 0x00BE432C File Offset: 0x00BE252C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsNullOrEmpty_s(IntPtr l)
	{
		int result;
		try
		{
			string value;
			LuaObject.checkType(l, 1, out value);
			bool b = string.IsNullOrEmpty(value);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060229A1 RID: 141729 RVA: 0x00BE4380 File Offset: 0x00BE2580
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Format_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, num, 1, typeof(string), typeof(object[])))
			{
				string format;
				LuaObject.checkType(l, 1, out format);
				object[] args;
				LuaObject.checkParams<object>(l, 2, out args);
				string s = string.Format(format, args);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, s);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(string), typeof(object)))
			{
				string format2;
				LuaObject.checkType(l, 1, out format2);
				object arg;
				LuaObject.checkType<object>(l, 2, out arg);
				string s2 = string.Format(format2, arg);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, s2);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(IFormatProvider), typeof(string), typeof(object[])))
			{
				IFormatProvider provider;
				LuaObject.checkType<IFormatProvider>(l, 1, out provider);
				string format3;
				LuaObject.checkType(l, 2, out format3);
				object[] args2;
				LuaObject.checkParams<object>(l, 3, out args2);
				string s3 = string.Format(provider, format3, args2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, s3);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(string), typeof(object), typeof(object)))
			{
				string format4;
				LuaObject.checkType(l, 1, out format4);
				object arg2;
				LuaObject.checkType<object>(l, 2, out arg2);
				object arg3;
				LuaObject.checkType<object>(l, 3, out arg3);
				string s4 = string.Format(format4, arg2, arg3);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, s4);
				result = 2;
			}
			else if (num == 4)
			{
				string format5;
				LuaObject.checkType(l, 1, out format5);
				object arg4;
				LuaObject.checkType<object>(l, 2, out arg4);
				object arg5;
				LuaObject.checkType<object>(l, 3, out arg5);
				object arg6;
				LuaObject.checkType<object>(l, 4, out arg6);
				string s5 = string.Format(format5, arg4, arg5, arg6);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, s5);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function Format to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060229A2 RID: 141730 RVA: 0x00BE45B8 File Offset: 0x00BE27B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Copy_s(IntPtr l)
	{
		int result;
		try
		{
			string str;
			LuaObject.checkType(l, 1, out str);
			string s = string.Copy(str);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, s);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060229A3 RID: 141731 RVA: 0x00BE460C File Offset: 0x00BE280C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Concat_s(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 1, typeof(object)))
			{
				object arg;
				LuaObject.checkType<object>(l, 1, out arg);
				string s = string.Concat(arg);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, s);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(string[])))
			{
				string[] values;
				LuaObject.checkParams(l, 1, out values);
				string s2 = string.Concat(values);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, s2);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(object[])))
			{
				object[] args;
				LuaObject.checkParams<object>(l, 1, out args);
				string s3 = string.Concat(args);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, s3);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(string), typeof(string)))
			{
				string str;
				LuaObject.checkType(l, 1, out str);
				string str2;
				LuaObject.checkType(l, 2, out str2);
				string s4 = str + str2;
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, s4);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(object), typeof(object)))
			{
				object arg2;
				LuaObject.checkType<object>(l, 1, out arg2);
				object arg3;
				LuaObject.checkType<object>(l, 2, out arg3);
				string s5 = arg2 + arg3;
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, s5);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(object), typeof(object), typeof(object)))
			{
				object arg4;
				LuaObject.checkType<object>(l, 1, out arg4);
				object arg5;
				LuaObject.checkType<object>(l, 2, out arg5);
				object arg6;
				LuaObject.checkType<object>(l, 3, out arg6);
				string s6 = arg4 + arg5 + arg6;
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, s6);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(string), typeof(string), typeof(string)))
			{
				string str3;
				LuaObject.checkType(l, 1, out str3);
				string str4;
				LuaObject.checkType(l, 2, out str4);
				string str5;
				LuaObject.checkType(l, 3, out str5);
				string s7 = str3 + str4 + str5;
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, s7);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(object), typeof(object), typeof(object), typeof(object)))
			{
				object obj;
				LuaObject.checkType<object>(l, 1, out obj);
				object obj2;
				LuaObject.checkType<object>(l, 2, out obj2);
				object obj3;
				LuaObject.checkType<object>(l, 3, out obj3);
				object obj4;
				LuaObject.checkType<object>(l, 4, out obj4);
				string s8 = string.Concat(new object[]
				{
					obj,
					obj2,
					obj3,
					obj4
				});
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, s8);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(string), typeof(string), typeof(string), typeof(string)))
			{
				string str6;
				LuaObject.checkType(l, 1, out str6);
				string str7;
				LuaObject.checkType(l, 2, out str7);
				string str8;
				LuaObject.checkType(l, 3, out str8);
				string str9;
				LuaObject.checkType(l, 4, out str9);
				string s9 = str6 + str7 + str8 + str9;
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, s9);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function Concat to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060229A4 RID: 141732 RVA: 0x00BE49C0 File Offset: 0x00BE2BC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Intern_s(IntPtr l)
	{
		int result;
		try
		{
			string str;
			LuaObject.checkType(l, 1, out str);
			string s = string.Intern(str);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, s);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060229A5 RID: 141733 RVA: 0x00BE4A14 File Offset: 0x00BE2C14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsInterned_s(IntPtr l)
	{
		int result;
		try
		{
			string str;
			LuaObject.checkType(l, 1, out str);
			string s = string.IsInterned(str);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, s);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060229A6 RID: 141734 RVA: 0x00BE4A68 File Offset: 0x00BE2C68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Join_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				string separator;
				LuaObject.checkType(l, 1, out separator);
				string[] value;
				LuaObject.checkArray<string>(l, 2, out value);
				string s = string.Join(separator, value);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, s);
				result = 2;
			}
			else if (num == 4)
			{
				string separator2;
				LuaObject.checkType(l, 1, out separator2);
				string[] value2;
				LuaObject.checkArray<string>(l, 2, out value2);
				int startIndex;
				LuaObject.checkType(l, 3, out startIndex);
				int count;
				LuaObject.checkType(l, 4, out count);
				string s2 = string.Join(separator2, value2, startIndex, count);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, s2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function Join to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060229A7 RID: 141735 RVA: 0x00BE4B48 File Offset: 0x00BE2D48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int op_Equality(IntPtr l)
	{
		int result;
		try
		{
			string a;
			LuaObject.checkType(l, 1, out a);
			string b;
			LuaObject.checkType(l, 2, out b);
			bool b2 = a == b;
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060229A8 RID: 141736 RVA: 0x00BE4BA8 File Offset: 0x00BE2DA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int op_Inequality(IntPtr l)
	{
		int result;
		try
		{
			string a;
			LuaObject.checkType(l, 1, out a);
			string b;
			LuaObject.checkType(l, 2, out b);
			bool b2 = a != b;
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060229A9 RID: 141737 RVA: 0x00BE4C08 File Offset: 0x00BE2E08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Empty(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, string.Empty);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060229AA RID: 141738 RVA: 0x00BE4C50 File Offset: 0x00BE2E50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Length(IntPtr l)
	{
		int result;
		try
		{
			string text = (string)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, text.Length);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060229AB RID: 141739 RVA: 0x00BE4CA4 File Offset: 0x00BE2EA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int getItem(IntPtr l)
	{
		int result;
		try
		{
			string text = (string)LuaObject.checkSelf(l);
			int index;
			LuaObject.checkType(l, 2, out index);
			char v = text[index];
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, v);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060229AC RID: 141740 RVA: 0x00BE4D08 File Offset: 0x00BE2F08
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "String");
		if (Lua_System_String.<>f__mg$cache0 == null)
		{
			Lua_System_String.<>f__mg$cache0 = new LuaCSFunction(Lua_System_String.GetTypeCode);
		}
		LuaObject.addMember(l, Lua_System_String.<>f__mg$cache0);
		if (Lua_System_String.<>f__mg$cache1 == null)
		{
			Lua_System_String.<>f__mg$cache1 = new LuaCSFunction(Lua_System_String.ToCharArray);
		}
		LuaObject.addMember(l, Lua_System_String.<>f__mg$cache1);
		if (Lua_System_String.<>f__mg$cache2 == null)
		{
			Lua_System_String.<>f__mg$cache2 = new LuaCSFunction(Lua_System_String.Split);
		}
		LuaObject.addMember(l, Lua_System_String.<>f__mg$cache2);
		if (Lua_System_String.<>f__mg$cache3 == null)
		{
			Lua_System_String.<>f__mg$cache3 = new LuaCSFunction(Lua_System_String.Substring);
		}
		LuaObject.addMember(l, Lua_System_String.<>f__mg$cache3);
		if (Lua_System_String.<>f__mg$cache4 == null)
		{
			Lua_System_String.<>f__mg$cache4 = new LuaCSFunction(Lua_System_String.Trim);
		}
		LuaObject.addMember(l, Lua_System_String.<>f__mg$cache4);
		if (Lua_System_String.<>f__mg$cache5 == null)
		{
			Lua_System_String.<>f__mg$cache5 = new LuaCSFunction(Lua_System_String.TrimStart);
		}
		LuaObject.addMember(l, Lua_System_String.<>f__mg$cache5);
		if (Lua_System_String.<>f__mg$cache6 == null)
		{
			Lua_System_String.<>f__mg$cache6 = new LuaCSFunction(Lua_System_String.TrimEnd);
		}
		LuaObject.addMember(l, Lua_System_String.<>f__mg$cache6);
		if (Lua_System_String.<>f__mg$cache7 == null)
		{
			Lua_System_String.<>f__mg$cache7 = new LuaCSFunction(Lua_System_String.CompareTo);
		}
		LuaObject.addMember(l, Lua_System_String.<>f__mg$cache7);
		if (Lua_System_String.<>f__mg$cache8 == null)
		{
			Lua_System_String.<>f__mg$cache8 = new LuaCSFunction(Lua_System_String.EndsWith);
		}
		LuaObject.addMember(l, Lua_System_String.<>f__mg$cache8);
		if (Lua_System_String.<>f__mg$cache9 == null)
		{
			Lua_System_String.<>f__mg$cache9 = new LuaCSFunction(Lua_System_String.IndexOfAny);
		}
		LuaObject.addMember(l, Lua_System_String.<>f__mg$cache9);
		if (Lua_System_String.<>f__mg$cacheA == null)
		{
			Lua_System_String.<>f__mg$cacheA = new LuaCSFunction(Lua_System_String.IndexOf);
		}
		LuaObject.addMember(l, Lua_System_String.<>f__mg$cacheA);
		if (Lua_System_String.<>f__mg$cacheB == null)
		{
			Lua_System_String.<>f__mg$cacheB = new LuaCSFunction(Lua_System_String.LastIndexOf);
		}
		LuaObject.addMember(l, Lua_System_String.<>f__mg$cacheB);
		if (Lua_System_String.<>f__mg$cacheC == null)
		{
			Lua_System_String.<>f__mg$cacheC = new LuaCSFunction(Lua_System_String.LastIndexOfAny);
		}
		LuaObject.addMember(l, Lua_System_String.<>f__mg$cacheC);
		if (Lua_System_String.<>f__mg$cacheD == null)
		{
			Lua_System_String.<>f__mg$cacheD = new LuaCSFunction(Lua_System_String.Contains);
		}
		LuaObject.addMember(l, Lua_System_String.<>f__mg$cacheD);
		if (Lua_System_String.<>f__mg$cacheE == null)
		{
			Lua_System_String.<>f__mg$cacheE = new LuaCSFunction(Lua_System_String.Normalize);
		}
		LuaObject.addMember(l, Lua_System_String.<>f__mg$cacheE);
		if (Lua_System_String.<>f__mg$cacheF == null)
		{
			Lua_System_String.<>f__mg$cacheF = new LuaCSFunction(Lua_System_String.IsNormalized);
		}
		LuaObject.addMember(l, Lua_System_String.<>f__mg$cacheF);
		if (Lua_System_String.<>f__mg$cache10 == null)
		{
			Lua_System_String.<>f__mg$cache10 = new LuaCSFunction(Lua_System_String.Remove);
		}
		LuaObject.addMember(l, Lua_System_String.<>f__mg$cache10);
		if (Lua_System_String.<>f__mg$cache11 == null)
		{
			Lua_System_String.<>f__mg$cache11 = new LuaCSFunction(Lua_System_String.PadLeft);
		}
		LuaObject.addMember(l, Lua_System_String.<>f__mg$cache11);
		if (Lua_System_String.<>f__mg$cache12 == null)
		{
			Lua_System_String.<>f__mg$cache12 = new LuaCSFunction(Lua_System_String.PadRight);
		}
		LuaObject.addMember(l, Lua_System_String.<>f__mg$cache12);
		if (Lua_System_String.<>f__mg$cache13 == null)
		{
			Lua_System_String.<>f__mg$cache13 = new LuaCSFunction(Lua_System_String.StartsWith);
		}
		LuaObject.addMember(l, Lua_System_String.<>f__mg$cache13);
		if (Lua_System_String.<>f__mg$cache14 == null)
		{
			Lua_System_String.<>f__mg$cache14 = new LuaCSFunction(Lua_System_String.Replace);
		}
		LuaObject.addMember(l, Lua_System_String.<>f__mg$cache14);
		if (Lua_System_String.<>f__mg$cache15 == null)
		{
			Lua_System_String.<>f__mg$cache15 = new LuaCSFunction(Lua_System_String.ToLower);
		}
		LuaObject.addMember(l, Lua_System_String.<>f__mg$cache15);
		if (Lua_System_String.<>f__mg$cache16 == null)
		{
			Lua_System_String.<>f__mg$cache16 = new LuaCSFunction(Lua_System_String.ToLowerInvariant);
		}
		LuaObject.addMember(l, Lua_System_String.<>f__mg$cache16);
		if (Lua_System_String.<>f__mg$cache17 == null)
		{
			Lua_System_String.<>f__mg$cache17 = new LuaCSFunction(Lua_System_String.ToUpper);
		}
		LuaObject.addMember(l, Lua_System_String.<>f__mg$cache17);
		if (Lua_System_String.<>f__mg$cache18 == null)
		{
			Lua_System_String.<>f__mg$cache18 = new LuaCSFunction(Lua_System_String.ToUpperInvariant);
		}
		LuaObject.addMember(l, Lua_System_String.<>f__mg$cache18);
		if (Lua_System_String.<>f__mg$cache19 == null)
		{
			Lua_System_String.<>f__mg$cache19 = new LuaCSFunction(Lua_System_String.Insert);
		}
		LuaObject.addMember(l, Lua_System_String.<>f__mg$cache19);
		if (Lua_System_String.<>f__mg$cache1A == null)
		{
			Lua_System_String.<>f__mg$cache1A = new LuaCSFunction(Lua_System_String.IsValidName);
		}
		LuaObject.addMember(l, Lua_System_String.<>f__mg$cache1A);
		if (Lua_System_String.<>f__mg$cache1B == null)
		{
			Lua_System_String.<>f__mg$cache1B = new LuaCSFunction(Lua_System_String.Compare_s);
		}
		LuaObject.addMember(l, Lua_System_String.<>f__mg$cache1B);
		if (Lua_System_String.<>f__mg$cache1C == null)
		{
			Lua_System_String.<>f__mg$cache1C = new LuaCSFunction(Lua_System_String.CompareOrdinal_s);
		}
		LuaObject.addMember(l, Lua_System_String.<>f__mg$cache1C);
		if (Lua_System_String.<>f__mg$cache1D == null)
		{
			Lua_System_String.<>f__mg$cache1D = new LuaCSFunction(Lua_System_String.IsNullOrEmpty_s);
		}
		LuaObject.addMember(l, Lua_System_String.<>f__mg$cache1D);
		if (Lua_System_String.<>f__mg$cache1E == null)
		{
			Lua_System_String.<>f__mg$cache1E = new LuaCSFunction(Lua_System_String.Format_s);
		}
		LuaObject.addMember(l, Lua_System_String.<>f__mg$cache1E);
		if (Lua_System_String.<>f__mg$cache1F == null)
		{
			Lua_System_String.<>f__mg$cache1F = new LuaCSFunction(Lua_System_String.Copy_s);
		}
		LuaObject.addMember(l, Lua_System_String.<>f__mg$cache1F);
		if (Lua_System_String.<>f__mg$cache20 == null)
		{
			Lua_System_String.<>f__mg$cache20 = new LuaCSFunction(Lua_System_String.Concat_s);
		}
		LuaObject.addMember(l, Lua_System_String.<>f__mg$cache20);
		if (Lua_System_String.<>f__mg$cache21 == null)
		{
			Lua_System_String.<>f__mg$cache21 = new LuaCSFunction(Lua_System_String.Intern_s);
		}
		LuaObject.addMember(l, Lua_System_String.<>f__mg$cache21);
		if (Lua_System_String.<>f__mg$cache22 == null)
		{
			Lua_System_String.<>f__mg$cache22 = new LuaCSFunction(Lua_System_String.IsInterned_s);
		}
		LuaObject.addMember(l, Lua_System_String.<>f__mg$cache22);
		if (Lua_System_String.<>f__mg$cache23 == null)
		{
			Lua_System_String.<>f__mg$cache23 = new LuaCSFunction(Lua_System_String.Join_s);
		}
		LuaObject.addMember(l, Lua_System_String.<>f__mg$cache23);
		if (Lua_System_String.<>f__mg$cache24 == null)
		{
			Lua_System_String.<>f__mg$cache24 = new LuaCSFunction(Lua_System_String.op_Equality);
		}
		LuaObject.addMember(l, Lua_System_String.<>f__mg$cache24);
		if (Lua_System_String.<>f__mg$cache25 == null)
		{
			Lua_System_String.<>f__mg$cache25 = new LuaCSFunction(Lua_System_String.op_Inequality);
		}
		LuaObject.addMember(l, Lua_System_String.<>f__mg$cache25);
		if (Lua_System_String.<>f__mg$cache26 == null)
		{
			Lua_System_String.<>f__mg$cache26 = new LuaCSFunction(Lua_System_String.getItem);
		}
		LuaObject.addMember(l, Lua_System_String.<>f__mg$cache26);
		string name = "Empty";
		if (Lua_System_String.<>f__mg$cache27 == null)
		{
			Lua_System_String.<>f__mg$cache27 = new LuaCSFunction(Lua_System_String.get_Empty);
		}
		LuaObject.addMember(l, name, Lua_System_String.<>f__mg$cache27, null, false);
		string name2 = "Length";
		if (Lua_System_String.<>f__mg$cache28 == null)
		{
			Lua_System_String.<>f__mg$cache28 = new LuaCSFunction(Lua_System_String.get_Length);
		}
		LuaObject.addMember(l, name2, Lua_System_String.<>f__mg$cache28, null, true);
		if (Lua_System_String.<>f__mg$cache29 == null)
		{
			Lua_System_String.<>f__mg$cache29 = new LuaCSFunction(Lua_System_String.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_System_String.<>f__mg$cache29, typeof(string));
	}

	// Token: 0x04018758 RID: 100184
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018759 RID: 100185
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401875A RID: 100186
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401875B RID: 100187
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401875C RID: 100188
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0401875D RID: 100189
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0401875E RID: 100190
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0401875F RID: 100191
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04018760 RID: 100192
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04018761 RID: 100193
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04018762 RID: 100194
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04018763 RID: 100195
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04018764 RID: 100196
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04018765 RID: 100197
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04018766 RID: 100198
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04018767 RID: 100199
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04018768 RID: 100200
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04018769 RID: 100201
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0401876A RID: 100202
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0401876B RID: 100203
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0401876C RID: 100204
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0401876D RID: 100205
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0401876E RID: 100206
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0401876F RID: 100207
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04018770 RID: 100208
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04018771 RID: 100209
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04018772 RID: 100210
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04018773 RID: 100211
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04018774 RID: 100212
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04018775 RID: 100213
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04018776 RID: 100214
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04018777 RID: 100215
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04018778 RID: 100216
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04018779 RID: 100217
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0401877A RID: 100218
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0401877B RID: 100219
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0401877C RID: 100220
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0401877D RID: 100221
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0401877E RID: 100222
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0401877F RID: 100223
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04018780 RID: 100224
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04018781 RID: 100225
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;
}
