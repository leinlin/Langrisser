using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001604 RID: 5636
[Preserve]
public class Lua_System_Collections_Generic_List_1_string : LuaObject
{
	// Token: 0x0602291D RID: 141597 RVA: 0x00BDDA68 File Offset: 0x00BDBC68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				List<string> o = new List<string>();
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(IEnumerable<string>)))
			{
				IEnumerable<string> collection;
				LuaObject.checkType<IEnumerable<string>>(l, 2, out collection);
				List<string> o = new List<string>(collection);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(int)))
			{
				int capacity;
				LuaObject.checkType(l, 2, out capacity);
				List<string> o = new List<string>(capacity);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
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

	// Token: 0x0602291E RID: 141598 RVA: 0x00BDDB4C File Offset: 0x00BDBD4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Add(IntPtr l)
	{
		int result;
		try
		{
			List<string> list = (List<string>)LuaObject.checkSelf(l);
			string item;
			LuaObject.checkType(l, 2, out item);
			list.Add(item);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602291F RID: 141599 RVA: 0x00BDDBA4 File Offset: 0x00BDBDA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddRange(IntPtr l)
	{
		int result;
		try
		{
			List<string> list = (List<string>)LuaObject.checkSelf(l);
			IEnumerable<string> collection;
			LuaObject.checkType<IEnumerable<string>>(l, 2, out collection);
			list.AddRange(collection);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022920 RID: 141600 RVA: 0x00BDDBFC File Offset: 0x00BDBDFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AsReadOnly(IntPtr l)
	{
		int result;
		try
		{
			List<string> list = (List<string>)LuaObject.checkSelf(l);
			ReadOnlyCollection<string> o = list.AsReadOnly();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, o);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022921 RID: 141601 RVA: 0x00BDDC50 File Offset: 0x00BDBE50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BinarySearch(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				List<string> list = (List<string>)LuaObject.checkSelf(l);
				string item;
				LuaObject.checkType(l, 2, out item);
				int i = list.BinarySearch(item);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i);
				result = 2;
			}
			else if (num == 3)
			{
				List<string> list2 = (List<string>)LuaObject.checkSelf(l);
				string item2;
				LuaObject.checkType(l, 2, out item2);
				IComparer<string> comparer;
				LuaObject.checkType<IComparer<string>>(l, 3, out comparer);
				int i2 = list2.BinarySearch(item2, comparer);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i2);
				result = 2;
			}
			else if (num == 5)
			{
				List<string> list3 = (List<string>)LuaObject.checkSelf(l);
				int index;
				LuaObject.checkType(l, 2, out index);
				int count;
				LuaObject.checkType(l, 3, out count);
				string item3;
				LuaObject.checkType(l, 4, out item3);
				IComparer<string> comparer2;
				LuaObject.checkType<IComparer<string>>(l, 5, out comparer2);
				int i3 = list3.BinarySearch(index, count, item3, comparer2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i3);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function BinarySearch to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022922 RID: 141602 RVA: 0x00BDDD98 File Offset: 0x00BDBF98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Clear(IntPtr l)
	{
		int result;
		try
		{
			List<string> list = (List<string>)LuaObject.checkSelf(l);
			list.Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022923 RID: 141603 RVA: 0x00BDDDE4 File Offset: 0x00BDBFE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Contains(IntPtr l)
	{
		int result;
		try
		{
			List<string> list = (List<string>)LuaObject.checkSelf(l);
			string item;
			LuaObject.checkType(l, 2, out item);
			bool b = list.Contains(item);
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

	// Token: 0x06022924 RID: 141604 RVA: 0x00BDDE48 File Offset: 0x00BDC048
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Exists(IntPtr l)
	{
		int result;
		try
		{
			List<string> list = (List<string>)LuaObject.checkSelf(l);
			Predicate<string> match;
			LuaObject.checkDelegate<Predicate<string>>(l, 2, out match);
			bool b = list.Exists(match);
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

	// Token: 0x06022925 RID: 141605 RVA: 0x00BDDEAC File Offset: 0x00BDC0AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Find(IntPtr l)
	{
		int result;
		try
		{
			List<string> list = (List<string>)LuaObject.checkSelf(l);
			Predicate<string> match;
			LuaObject.checkDelegate<Predicate<string>>(l, 2, out match);
			string s = list.Find(match);
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

	// Token: 0x06022926 RID: 141606 RVA: 0x00BDDF10 File Offset: 0x00BDC110
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FindAll(IntPtr l)
	{
		int result;
		try
		{
			List<string> list = (List<string>)LuaObject.checkSelf(l);
			Predicate<string> match;
			LuaObject.checkDelegate<Predicate<string>>(l, 2, out match);
			List<string> o = list.FindAll(match);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, o);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022927 RID: 141607 RVA: 0x00BDDF74 File Offset: 0x00BDC174
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FindIndex(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				List<string> list = (List<string>)LuaObject.checkSelf(l);
				Predicate<string> match;
				LuaObject.checkDelegate<Predicate<string>>(l, 2, out match);
				int i = list.FindIndex(match);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i);
				result = 2;
			}
			else if (num == 3)
			{
				List<string> list2 = (List<string>)LuaObject.checkSelf(l);
				int startIndex;
				LuaObject.checkType(l, 2, out startIndex);
				Predicate<string> match2;
				LuaObject.checkDelegate<Predicate<string>>(l, 3, out match2);
				int i2 = list2.FindIndex(startIndex, match2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i2);
				result = 2;
			}
			else if (num == 4)
			{
				List<string> list3 = (List<string>)LuaObject.checkSelf(l);
				int startIndex2;
				LuaObject.checkType(l, 2, out startIndex2);
				int count;
				LuaObject.checkType(l, 3, out count);
				Predicate<string> match3;
				LuaObject.checkDelegate<Predicate<string>>(l, 4, out match3);
				int i3 = list3.FindIndex(startIndex2, count, match3);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i3);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function FindIndex to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022928 RID: 141608 RVA: 0x00BDE0B0 File Offset: 0x00BDC2B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FindLast(IntPtr l)
	{
		int result;
		try
		{
			List<string> list = (List<string>)LuaObject.checkSelf(l);
			Predicate<string> match;
			LuaObject.checkDelegate<Predicate<string>>(l, 2, out match);
			string s = list.FindLast(match);
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

	// Token: 0x06022929 RID: 141609 RVA: 0x00BDE114 File Offset: 0x00BDC314
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FindLastIndex(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				List<string> list = (List<string>)LuaObject.checkSelf(l);
				Predicate<string> match;
				LuaObject.checkDelegate<Predicate<string>>(l, 2, out match);
				int i = list.FindLastIndex(match);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i);
				result = 2;
			}
			else if (num == 3)
			{
				List<string> list2 = (List<string>)LuaObject.checkSelf(l);
				int startIndex;
				LuaObject.checkType(l, 2, out startIndex);
				Predicate<string> match2;
				LuaObject.checkDelegate<Predicate<string>>(l, 3, out match2);
				int i2 = list2.FindLastIndex(startIndex, match2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i2);
				result = 2;
			}
			else if (num == 4)
			{
				List<string> list3 = (List<string>)LuaObject.checkSelf(l);
				int startIndex2;
				LuaObject.checkType(l, 2, out startIndex2);
				int count;
				LuaObject.checkType(l, 3, out count);
				Predicate<string> match3;
				LuaObject.checkDelegate<Predicate<string>>(l, 4, out match3);
				int i3 = list3.FindLastIndex(startIndex2, count, match3);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i3);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function FindLastIndex to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602292A RID: 141610 RVA: 0x00BDE250 File Offset: 0x00BDC450
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ForEach(IntPtr l)
	{
		int result;
		try
		{
			List<string> list = (List<string>)LuaObject.checkSelf(l);
			Action<string> action;
			LuaObject.checkDelegate<Action<string>>(l, 2, out action);
			list.ForEach(action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602292B RID: 141611 RVA: 0x00BDE2A8 File Offset: 0x00BDC4A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetRange(IntPtr l)
	{
		int result;
		try
		{
			List<string> list = (List<string>)LuaObject.checkSelf(l);
			int index;
			LuaObject.checkType(l, 2, out index);
			int count;
			LuaObject.checkType(l, 3, out count);
			List<string> range = list.GetRange(index, count);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, range);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602292C RID: 141612 RVA: 0x00BDE318 File Offset: 0x00BDC518
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IndexOf(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				List<string> list = (List<string>)LuaObject.checkSelf(l);
				string item;
				LuaObject.checkType(l, 2, out item);
				int i = list.IndexOf(item);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i);
				result = 2;
			}
			else if (num == 3)
			{
				List<string> list2 = (List<string>)LuaObject.checkSelf(l);
				string item2;
				LuaObject.checkType(l, 2, out item2);
				int index;
				LuaObject.checkType(l, 3, out index);
				int i2 = list2.IndexOf(item2, index);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i2);
				result = 2;
			}
			else if (num == 4)
			{
				List<string> list3 = (List<string>)LuaObject.checkSelf(l);
				string item3;
				LuaObject.checkType(l, 2, out item3);
				int index2;
				LuaObject.checkType(l, 3, out index2);
				int count;
				LuaObject.checkType(l, 4, out count);
				int i3 = list3.IndexOf(item3, index2, count);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i3);
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

	// Token: 0x0602292D RID: 141613 RVA: 0x00BDE454 File Offset: 0x00BDC654
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Insert(IntPtr l)
	{
		int result;
		try
		{
			List<string> list = (List<string>)LuaObject.checkSelf(l);
			int index;
			LuaObject.checkType(l, 2, out index);
			string item;
			LuaObject.checkType(l, 3, out item);
			list.Insert(index, item);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602292E RID: 141614 RVA: 0x00BDE4B8 File Offset: 0x00BDC6B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InsertRange(IntPtr l)
	{
		int result;
		try
		{
			List<string> list = (List<string>)LuaObject.checkSelf(l);
			int index;
			LuaObject.checkType(l, 2, out index);
			IEnumerable<string> collection;
			LuaObject.checkType<IEnumerable<string>>(l, 3, out collection);
			list.InsertRange(index, collection);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602292F RID: 141615 RVA: 0x00BDE51C File Offset: 0x00BDC71C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LastIndexOf(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				List<string> list = (List<string>)LuaObject.checkSelf(l);
				string item;
				LuaObject.checkType(l, 2, out item);
				int i = list.LastIndexOf(item);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i);
				result = 2;
			}
			else if (num == 3)
			{
				List<string> list2 = (List<string>)LuaObject.checkSelf(l);
				string item2;
				LuaObject.checkType(l, 2, out item2);
				int index;
				LuaObject.checkType(l, 3, out index);
				int i2 = list2.LastIndexOf(item2, index);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i2);
				result = 2;
			}
			else if (num == 4)
			{
				List<string> list3 = (List<string>)LuaObject.checkSelf(l);
				string item3;
				LuaObject.checkType(l, 2, out item3);
				int index2;
				LuaObject.checkType(l, 3, out index2);
				int count;
				LuaObject.checkType(l, 4, out count);
				int i3 = list3.LastIndexOf(item3, index2, count);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i3);
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

	// Token: 0x06022930 RID: 141616 RVA: 0x00BDE658 File Offset: 0x00BDC858
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Remove(IntPtr l)
	{
		int result;
		try
		{
			List<string> list = (List<string>)LuaObject.checkSelf(l);
			string item;
			LuaObject.checkType(l, 2, out item);
			bool b = list.Remove(item);
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

	// Token: 0x06022931 RID: 141617 RVA: 0x00BDE6BC File Offset: 0x00BDC8BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RemoveAll(IntPtr l)
	{
		int result;
		try
		{
			List<string> list = (List<string>)LuaObject.checkSelf(l);
			Predicate<string> match;
			LuaObject.checkDelegate<Predicate<string>>(l, 2, out match);
			int i = list.RemoveAll(match);
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

	// Token: 0x06022932 RID: 141618 RVA: 0x00BDE720 File Offset: 0x00BDC920
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RemoveAt(IntPtr l)
	{
		int result;
		try
		{
			List<string> list = (List<string>)LuaObject.checkSelf(l);
			int index;
			LuaObject.checkType(l, 2, out index);
			list.RemoveAt(index);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022933 RID: 141619 RVA: 0x00BDE778 File Offset: 0x00BDC978
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RemoveRange(IntPtr l)
	{
		int result;
		try
		{
			List<string> list = (List<string>)LuaObject.checkSelf(l);
			int index;
			LuaObject.checkType(l, 2, out index);
			int count;
			LuaObject.checkType(l, 3, out count);
			list.RemoveRange(index, count);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022934 RID: 141620 RVA: 0x00BDE7DC File Offset: 0x00BDC9DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Reverse(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				List<string> list = (List<string>)LuaObject.checkSelf(l);
				list.Reverse();
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 3)
			{
				List<string> list2 = (List<string>)LuaObject.checkSelf(l);
				int index;
				LuaObject.checkType(l, 2, out index);
				int count;
				LuaObject.checkType(l, 3, out count);
				list2.Reverse(index, count);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function Reverse to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022935 RID: 141621 RVA: 0x00BDE890 File Offset: 0x00BDCA90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Sort(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				List<string> list = (List<string>)LuaObject.checkSelf(l);
				list.Sort();
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(IComparer<string>)))
			{
				List<string> list2 = (List<string>)LuaObject.checkSelf(l);
				IComparer<string> comparer;
				LuaObject.checkType<IComparer<string>>(l, 2, out comparer);
				list2.Sort(comparer);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(Comparison<string>)))
			{
				List<string> list3 = (List<string>)LuaObject.checkSelf(l);
				Comparison<string> comparison;
				LuaObject.checkDelegate<Comparison<string>>(l, 2, out comparison);
				list3.Sort(comparison);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 4)
			{
				List<string> list4 = (List<string>)LuaObject.checkSelf(l);
				int index;
				LuaObject.checkType(l, 2, out index);
				int count;
				LuaObject.checkType(l, 3, out count);
				IComparer<string> comparer2;
				LuaObject.checkType<IComparer<string>>(l, 4, out comparer2);
				list4.Sort(index, count, comparer2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function Sort to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022936 RID: 141622 RVA: 0x00BDE9E8 File Offset: 0x00BDCBE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ToArray(IntPtr l)
	{
		int result;
		try
		{
			List<string> list = (List<string>)LuaObject.checkSelf(l);
			string[] a = list.ToArray();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, a);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022937 RID: 141623 RVA: 0x00BDEA3C File Offset: 0x00BDCC3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TrimExcess(IntPtr l)
	{
		int result;
		try
		{
			List<string> list = (List<string>)LuaObject.checkSelf(l);
			list.TrimExcess();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022938 RID: 141624 RVA: 0x00BDEA88 File Offset: 0x00BDCC88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TrueForAll(IntPtr l)
	{
		int result;
		try
		{
			List<string> list = (List<string>)LuaObject.checkSelf(l);
			Predicate<string> match;
			LuaObject.checkDelegate<Predicate<string>>(l, 2, out match);
			bool b = list.TrueForAll(match);
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

	// Token: 0x06022939 RID: 141625 RVA: 0x00BDEAEC File Offset: 0x00BDCCEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Capacity(IntPtr l)
	{
		int result;
		try
		{
			List<string> list = (List<string>)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, list.Capacity);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602293A RID: 141626 RVA: 0x00BDEB40 File Offset: 0x00BDCD40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Capacity(IntPtr l)
	{
		int result;
		try
		{
			List<string> list = (List<string>)LuaObject.checkSelf(l);
			int capacity;
			LuaObject.checkType(l, 2, out capacity);
			list.Capacity = capacity;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602293B RID: 141627 RVA: 0x00BDEB98 File Offset: 0x00BDCD98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Count(IntPtr l)
	{
		int result;
		try
		{
			List<string> list = (List<string>)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, list.Count);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602293C RID: 141628 RVA: 0x00BDEBEC File Offset: 0x00BDCDEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int getItem(IntPtr l)
	{
		int result;
		try
		{
			List<string> list = (List<string>)LuaObject.checkSelf(l);
			int index;
			LuaObject.checkType(l, 2, out index);
			string s = list[index];
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

	// Token: 0x0602293D RID: 141629 RVA: 0x00BDEC50 File Offset: 0x00BDCE50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int setItem(IntPtr l)
	{
		int result;
		try
		{
			List<string> list = (List<string>)LuaObject.checkSelf(l);
			int index;
			LuaObject.checkType(l, 2, out index);
			string value;
			LuaObject.checkType(l, 3, out value);
			list[index] = value;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602293E RID: 141630 RVA: 0x00BDECB4 File Offset: 0x00BDCEB4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "ListString");
		if (Lua_System_Collections_Generic_List_1_string.<>f__mg$cache0 == null)
		{
			Lua_System_Collections_Generic_List_1_string.<>f__mg$cache0 = new LuaCSFunction(Lua_System_Collections_Generic_List_1_string.Add);
		}
		LuaObject.addMember(l, Lua_System_Collections_Generic_List_1_string.<>f__mg$cache0);
		if (Lua_System_Collections_Generic_List_1_string.<>f__mg$cache1 == null)
		{
			Lua_System_Collections_Generic_List_1_string.<>f__mg$cache1 = new LuaCSFunction(Lua_System_Collections_Generic_List_1_string.AddRange);
		}
		LuaObject.addMember(l, Lua_System_Collections_Generic_List_1_string.<>f__mg$cache1);
		if (Lua_System_Collections_Generic_List_1_string.<>f__mg$cache2 == null)
		{
			Lua_System_Collections_Generic_List_1_string.<>f__mg$cache2 = new LuaCSFunction(Lua_System_Collections_Generic_List_1_string.AsReadOnly);
		}
		LuaObject.addMember(l, Lua_System_Collections_Generic_List_1_string.<>f__mg$cache2);
		if (Lua_System_Collections_Generic_List_1_string.<>f__mg$cache3 == null)
		{
			Lua_System_Collections_Generic_List_1_string.<>f__mg$cache3 = new LuaCSFunction(Lua_System_Collections_Generic_List_1_string.BinarySearch);
		}
		LuaObject.addMember(l, Lua_System_Collections_Generic_List_1_string.<>f__mg$cache3);
		if (Lua_System_Collections_Generic_List_1_string.<>f__mg$cache4 == null)
		{
			Lua_System_Collections_Generic_List_1_string.<>f__mg$cache4 = new LuaCSFunction(Lua_System_Collections_Generic_List_1_string.Clear);
		}
		LuaObject.addMember(l, Lua_System_Collections_Generic_List_1_string.<>f__mg$cache4);
		if (Lua_System_Collections_Generic_List_1_string.<>f__mg$cache5 == null)
		{
			Lua_System_Collections_Generic_List_1_string.<>f__mg$cache5 = new LuaCSFunction(Lua_System_Collections_Generic_List_1_string.Contains);
		}
		LuaObject.addMember(l, Lua_System_Collections_Generic_List_1_string.<>f__mg$cache5);
		if (Lua_System_Collections_Generic_List_1_string.<>f__mg$cache6 == null)
		{
			Lua_System_Collections_Generic_List_1_string.<>f__mg$cache6 = new LuaCSFunction(Lua_System_Collections_Generic_List_1_string.Exists);
		}
		LuaObject.addMember(l, Lua_System_Collections_Generic_List_1_string.<>f__mg$cache6);
		if (Lua_System_Collections_Generic_List_1_string.<>f__mg$cache7 == null)
		{
			Lua_System_Collections_Generic_List_1_string.<>f__mg$cache7 = new LuaCSFunction(Lua_System_Collections_Generic_List_1_string.Find);
		}
		LuaObject.addMember(l, Lua_System_Collections_Generic_List_1_string.<>f__mg$cache7);
		if (Lua_System_Collections_Generic_List_1_string.<>f__mg$cache8 == null)
		{
			Lua_System_Collections_Generic_List_1_string.<>f__mg$cache8 = new LuaCSFunction(Lua_System_Collections_Generic_List_1_string.FindAll);
		}
		LuaObject.addMember(l, Lua_System_Collections_Generic_List_1_string.<>f__mg$cache8);
		if (Lua_System_Collections_Generic_List_1_string.<>f__mg$cache9 == null)
		{
			Lua_System_Collections_Generic_List_1_string.<>f__mg$cache9 = new LuaCSFunction(Lua_System_Collections_Generic_List_1_string.FindIndex);
		}
		LuaObject.addMember(l, Lua_System_Collections_Generic_List_1_string.<>f__mg$cache9);
		if (Lua_System_Collections_Generic_List_1_string.<>f__mg$cacheA == null)
		{
			Lua_System_Collections_Generic_List_1_string.<>f__mg$cacheA = new LuaCSFunction(Lua_System_Collections_Generic_List_1_string.FindLast);
		}
		LuaObject.addMember(l, Lua_System_Collections_Generic_List_1_string.<>f__mg$cacheA);
		if (Lua_System_Collections_Generic_List_1_string.<>f__mg$cacheB == null)
		{
			Lua_System_Collections_Generic_List_1_string.<>f__mg$cacheB = new LuaCSFunction(Lua_System_Collections_Generic_List_1_string.FindLastIndex);
		}
		LuaObject.addMember(l, Lua_System_Collections_Generic_List_1_string.<>f__mg$cacheB);
		if (Lua_System_Collections_Generic_List_1_string.<>f__mg$cacheC == null)
		{
			Lua_System_Collections_Generic_List_1_string.<>f__mg$cacheC = new LuaCSFunction(Lua_System_Collections_Generic_List_1_string.ForEach);
		}
		LuaObject.addMember(l, Lua_System_Collections_Generic_List_1_string.<>f__mg$cacheC);
		if (Lua_System_Collections_Generic_List_1_string.<>f__mg$cacheD == null)
		{
			Lua_System_Collections_Generic_List_1_string.<>f__mg$cacheD = new LuaCSFunction(Lua_System_Collections_Generic_List_1_string.GetRange);
		}
		LuaObject.addMember(l, Lua_System_Collections_Generic_List_1_string.<>f__mg$cacheD);
		if (Lua_System_Collections_Generic_List_1_string.<>f__mg$cacheE == null)
		{
			Lua_System_Collections_Generic_List_1_string.<>f__mg$cacheE = new LuaCSFunction(Lua_System_Collections_Generic_List_1_string.IndexOf);
		}
		LuaObject.addMember(l, Lua_System_Collections_Generic_List_1_string.<>f__mg$cacheE);
		if (Lua_System_Collections_Generic_List_1_string.<>f__mg$cacheF == null)
		{
			Lua_System_Collections_Generic_List_1_string.<>f__mg$cacheF = new LuaCSFunction(Lua_System_Collections_Generic_List_1_string.Insert);
		}
		LuaObject.addMember(l, Lua_System_Collections_Generic_List_1_string.<>f__mg$cacheF);
		if (Lua_System_Collections_Generic_List_1_string.<>f__mg$cache10 == null)
		{
			Lua_System_Collections_Generic_List_1_string.<>f__mg$cache10 = new LuaCSFunction(Lua_System_Collections_Generic_List_1_string.InsertRange);
		}
		LuaObject.addMember(l, Lua_System_Collections_Generic_List_1_string.<>f__mg$cache10);
		if (Lua_System_Collections_Generic_List_1_string.<>f__mg$cache11 == null)
		{
			Lua_System_Collections_Generic_List_1_string.<>f__mg$cache11 = new LuaCSFunction(Lua_System_Collections_Generic_List_1_string.LastIndexOf);
		}
		LuaObject.addMember(l, Lua_System_Collections_Generic_List_1_string.<>f__mg$cache11);
		if (Lua_System_Collections_Generic_List_1_string.<>f__mg$cache12 == null)
		{
			Lua_System_Collections_Generic_List_1_string.<>f__mg$cache12 = new LuaCSFunction(Lua_System_Collections_Generic_List_1_string.Remove);
		}
		LuaObject.addMember(l, Lua_System_Collections_Generic_List_1_string.<>f__mg$cache12);
		if (Lua_System_Collections_Generic_List_1_string.<>f__mg$cache13 == null)
		{
			Lua_System_Collections_Generic_List_1_string.<>f__mg$cache13 = new LuaCSFunction(Lua_System_Collections_Generic_List_1_string.RemoveAll);
		}
		LuaObject.addMember(l, Lua_System_Collections_Generic_List_1_string.<>f__mg$cache13);
		if (Lua_System_Collections_Generic_List_1_string.<>f__mg$cache14 == null)
		{
			Lua_System_Collections_Generic_List_1_string.<>f__mg$cache14 = new LuaCSFunction(Lua_System_Collections_Generic_List_1_string.RemoveAt);
		}
		LuaObject.addMember(l, Lua_System_Collections_Generic_List_1_string.<>f__mg$cache14);
		if (Lua_System_Collections_Generic_List_1_string.<>f__mg$cache15 == null)
		{
			Lua_System_Collections_Generic_List_1_string.<>f__mg$cache15 = new LuaCSFunction(Lua_System_Collections_Generic_List_1_string.RemoveRange);
		}
		LuaObject.addMember(l, Lua_System_Collections_Generic_List_1_string.<>f__mg$cache15);
		if (Lua_System_Collections_Generic_List_1_string.<>f__mg$cache16 == null)
		{
			Lua_System_Collections_Generic_List_1_string.<>f__mg$cache16 = new LuaCSFunction(Lua_System_Collections_Generic_List_1_string.Reverse);
		}
		LuaObject.addMember(l, Lua_System_Collections_Generic_List_1_string.<>f__mg$cache16);
		if (Lua_System_Collections_Generic_List_1_string.<>f__mg$cache17 == null)
		{
			Lua_System_Collections_Generic_List_1_string.<>f__mg$cache17 = new LuaCSFunction(Lua_System_Collections_Generic_List_1_string.Sort);
		}
		LuaObject.addMember(l, Lua_System_Collections_Generic_List_1_string.<>f__mg$cache17);
		if (Lua_System_Collections_Generic_List_1_string.<>f__mg$cache18 == null)
		{
			Lua_System_Collections_Generic_List_1_string.<>f__mg$cache18 = new LuaCSFunction(Lua_System_Collections_Generic_List_1_string.ToArray);
		}
		LuaObject.addMember(l, Lua_System_Collections_Generic_List_1_string.<>f__mg$cache18);
		if (Lua_System_Collections_Generic_List_1_string.<>f__mg$cache19 == null)
		{
			Lua_System_Collections_Generic_List_1_string.<>f__mg$cache19 = new LuaCSFunction(Lua_System_Collections_Generic_List_1_string.TrimExcess);
		}
		LuaObject.addMember(l, Lua_System_Collections_Generic_List_1_string.<>f__mg$cache19);
		if (Lua_System_Collections_Generic_List_1_string.<>f__mg$cache1A == null)
		{
			Lua_System_Collections_Generic_List_1_string.<>f__mg$cache1A = new LuaCSFunction(Lua_System_Collections_Generic_List_1_string.TrueForAll);
		}
		LuaObject.addMember(l, Lua_System_Collections_Generic_List_1_string.<>f__mg$cache1A);
		if (Lua_System_Collections_Generic_List_1_string.<>f__mg$cache1B == null)
		{
			Lua_System_Collections_Generic_List_1_string.<>f__mg$cache1B = new LuaCSFunction(Lua_System_Collections_Generic_List_1_string.getItem);
		}
		LuaObject.addMember(l, Lua_System_Collections_Generic_List_1_string.<>f__mg$cache1B);
		if (Lua_System_Collections_Generic_List_1_string.<>f__mg$cache1C == null)
		{
			Lua_System_Collections_Generic_List_1_string.<>f__mg$cache1C = new LuaCSFunction(Lua_System_Collections_Generic_List_1_string.setItem);
		}
		LuaObject.addMember(l, Lua_System_Collections_Generic_List_1_string.<>f__mg$cache1C);
		string name = "Capacity";
		if (Lua_System_Collections_Generic_List_1_string.<>f__mg$cache1D == null)
		{
			Lua_System_Collections_Generic_List_1_string.<>f__mg$cache1D = new LuaCSFunction(Lua_System_Collections_Generic_List_1_string.get_Capacity);
		}
		LuaCSFunction get = Lua_System_Collections_Generic_List_1_string.<>f__mg$cache1D;
		if (Lua_System_Collections_Generic_List_1_string.<>f__mg$cache1E == null)
		{
			Lua_System_Collections_Generic_List_1_string.<>f__mg$cache1E = new LuaCSFunction(Lua_System_Collections_Generic_List_1_string.set_Capacity);
		}
		LuaObject.addMember(l, name, get, Lua_System_Collections_Generic_List_1_string.<>f__mg$cache1E, true);
		string name2 = "Count";
		if (Lua_System_Collections_Generic_List_1_string.<>f__mg$cache1F == null)
		{
			Lua_System_Collections_Generic_List_1_string.<>f__mg$cache1F = new LuaCSFunction(Lua_System_Collections_Generic_List_1_string.get_Count);
		}
		LuaObject.addMember(l, name2, Lua_System_Collections_Generic_List_1_string.<>f__mg$cache1F, null, true);
		if (Lua_System_Collections_Generic_List_1_string.<>f__mg$cache20 == null)
		{
			Lua_System_Collections_Generic_List_1_string.<>f__mg$cache20 = new LuaCSFunction(Lua_System_Collections_Generic_List_1_string.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_System_Collections_Generic_List_1_string.<>f__mg$cache20, typeof(List<string>));
	}

	// Token: 0x040186F7 RID: 100087
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040186F8 RID: 100088
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040186F9 RID: 100089
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040186FA RID: 100090
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040186FB RID: 100091
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040186FC RID: 100092
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040186FD RID: 100093
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040186FE RID: 100094
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040186FF RID: 100095
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04018700 RID: 100096
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04018701 RID: 100097
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04018702 RID: 100098
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04018703 RID: 100099
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04018704 RID: 100100
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04018705 RID: 100101
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04018706 RID: 100102
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04018707 RID: 100103
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04018708 RID: 100104
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04018709 RID: 100105
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0401870A RID: 100106
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0401870B RID: 100107
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0401870C RID: 100108
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0401870D RID: 100109
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0401870E RID: 100110
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0401870F RID: 100111
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04018710 RID: 100112
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04018711 RID: 100113
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04018712 RID: 100114
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04018713 RID: 100115
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04018714 RID: 100116
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04018715 RID: 100117
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04018716 RID: 100118
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04018717 RID: 100119
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;
}
