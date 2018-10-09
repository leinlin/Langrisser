using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001603 RID: 5635
[Preserve]
public class Lua_System_Collections_Generic_List_1_int : LuaObject
{
	// Token: 0x060228FA RID: 141562 RVA: 0x00BDC368 File Offset: 0x00BDA568
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
				List<int> o = new List<int>();
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(IEnumerable<int>)))
			{
				IEnumerable<int> collection;
				LuaObject.checkType<IEnumerable<int>>(l, 2, out collection);
				List<int> o = new List<int>(collection);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(int)))
			{
				int capacity;
				LuaObject.checkType(l, 2, out capacity);
				List<int> o = new List<int>(capacity);
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

	// Token: 0x060228FB RID: 141563 RVA: 0x00BDC44C File Offset: 0x00BDA64C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Add(IntPtr l)
	{
		int result;
		try
		{
			List<int> list = (List<int>)LuaObject.checkSelf(l);
			int item;
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

	// Token: 0x060228FC RID: 141564 RVA: 0x00BDC4A4 File Offset: 0x00BDA6A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddRange(IntPtr l)
	{
		int result;
		try
		{
			List<int> list = (List<int>)LuaObject.checkSelf(l);
			IEnumerable<int> collection;
			LuaObject.checkType<IEnumerable<int>>(l, 2, out collection);
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

	// Token: 0x060228FD RID: 141565 RVA: 0x00BDC4FC File Offset: 0x00BDA6FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AsReadOnly(IntPtr l)
	{
		int result;
		try
		{
			List<int> list = (List<int>)LuaObject.checkSelf(l);
			ReadOnlyCollection<int> o = list.AsReadOnly();
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

	// Token: 0x060228FE RID: 141566 RVA: 0x00BDC550 File Offset: 0x00BDA750
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
				List<int> list = (List<int>)LuaObject.checkSelf(l);
				int item;
				LuaObject.checkType(l, 2, out item);
				int i = list.BinarySearch(item);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i);
				result = 2;
			}
			else if (num == 3)
			{
				List<int> list2 = (List<int>)LuaObject.checkSelf(l);
				int item2;
				LuaObject.checkType(l, 2, out item2);
				IComparer<int> comparer;
				LuaObject.checkType<IComparer<int>>(l, 3, out comparer);
				int i2 = list2.BinarySearch(item2, comparer);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i2);
				result = 2;
			}
			else if (num == 5)
			{
				List<int> list3 = (List<int>)LuaObject.checkSelf(l);
				int index;
				LuaObject.checkType(l, 2, out index);
				int count;
				LuaObject.checkType(l, 3, out count);
				int item3;
				LuaObject.checkType(l, 4, out item3);
				IComparer<int> comparer2;
				LuaObject.checkType<IComparer<int>>(l, 5, out comparer2);
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

	// Token: 0x060228FF RID: 141567 RVA: 0x00BDC698 File Offset: 0x00BDA898
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Clear(IntPtr l)
	{
		int result;
		try
		{
			List<int> list = (List<int>)LuaObject.checkSelf(l);
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

	// Token: 0x06022900 RID: 141568 RVA: 0x00BDC6E4 File Offset: 0x00BDA8E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Contains(IntPtr l)
	{
		int result;
		try
		{
			List<int> list = (List<int>)LuaObject.checkSelf(l);
			int item;
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

	// Token: 0x06022901 RID: 141569 RVA: 0x00BDC748 File Offset: 0x00BDA948
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Exists(IntPtr l)
	{
		int result;
		try
		{
			List<int> list = (List<int>)LuaObject.checkSelf(l);
			Predicate<int> match;
			LuaObject.checkDelegate<Predicate<int>>(l, 2, out match);
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

	// Token: 0x06022902 RID: 141570 RVA: 0x00BDC7AC File Offset: 0x00BDA9AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Find(IntPtr l)
	{
		int result;
		try
		{
			List<int> list = (List<int>)LuaObject.checkSelf(l);
			Predicate<int> match;
			LuaObject.checkDelegate<Predicate<int>>(l, 2, out match);
			int i = list.Find(match);
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

	// Token: 0x06022903 RID: 141571 RVA: 0x00BDC810 File Offset: 0x00BDAA10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FindAll(IntPtr l)
	{
		int result;
		try
		{
			List<int> list = (List<int>)LuaObject.checkSelf(l);
			Predicate<int> match;
			LuaObject.checkDelegate<Predicate<int>>(l, 2, out match);
			List<int> o = list.FindAll(match);
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

	// Token: 0x06022904 RID: 141572 RVA: 0x00BDC874 File Offset: 0x00BDAA74
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
				List<int> list = (List<int>)LuaObject.checkSelf(l);
				Predicate<int> match;
				LuaObject.checkDelegate<Predicate<int>>(l, 2, out match);
				int i = list.FindIndex(match);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i);
				result = 2;
			}
			else if (num == 3)
			{
				List<int> list2 = (List<int>)LuaObject.checkSelf(l);
				int startIndex;
				LuaObject.checkType(l, 2, out startIndex);
				Predicate<int> match2;
				LuaObject.checkDelegate<Predicate<int>>(l, 3, out match2);
				int i2 = list2.FindIndex(startIndex, match2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i2);
				result = 2;
			}
			else if (num == 4)
			{
				List<int> list3 = (List<int>)LuaObject.checkSelf(l);
				int startIndex2;
				LuaObject.checkType(l, 2, out startIndex2);
				int count;
				LuaObject.checkType(l, 3, out count);
				Predicate<int> match3;
				LuaObject.checkDelegate<Predicate<int>>(l, 4, out match3);
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

	// Token: 0x06022905 RID: 141573 RVA: 0x00BDC9B0 File Offset: 0x00BDABB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FindLast(IntPtr l)
	{
		int result;
		try
		{
			List<int> list = (List<int>)LuaObject.checkSelf(l);
			Predicate<int> match;
			LuaObject.checkDelegate<Predicate<int>>(l, 2, out match);
			int i = list.FindLast(match);
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

	// Token: 0x06022906 RID: 141574 RVA: 0x00BDCA14 File Offset: 0x00BDAC14
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
				List<int> list = (List<int>)LuaObject.checkSelf(l);
				Predicate<int> match;
				LuaObject.checkDelegate<Predicate<int>>(l, 2, out match);
				int i = list.FindLastIndex(match);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i);
				result = 2;
			}
			else if (num == 3)
			{
				List<int> list2 = (List<int>)LuaObject.checkSelf(l);
				int startIndex;
				LuaObject.checkType(l, 2, out startIndex);
				Predicate<int> match2;
				LuaObject.checkDelegate<Predicate<int>>(l, 3, out match2);
				int i2 = list2.FindLastIndex(startIndex, match2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i2);
				result = 2;
			}
			else if (num == 4)
			{
				List<int> list3 = (List<int>)LuaObject.checkSelf(l);
				int startIndex2;
				LuaObject.checkType(l, 2, out startIndex2);
				int count;
				LuaObject.checkType(l, 3, out count);
				Predicate<int> match3;
				LuaObject.checkDelegate<Predicate<int>>(l, 4, out match3);
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

	// Token: 0x06022907 RID: 141575 RVA: 0x00BDCB50 File Offset: 0x00BDAD50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ForEach(IntPtr l)
	{
		int result;
		try
		{
			List<int> list = (List<int>)LuaObject.checkSelf(l);
			Action<int> action;
			LuaObject.checkDelegate<Action<int>>(l, 2, out action);
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

	// Token: 0x06022908 RID: 141576 RVA: 0x00BDCBA8 File Offset: 0x00BDADA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetRange(IntPtr l)
	{
		int result;
		try
		{
			List<int> list = (List<int>)LuaObject.checkSelf(l);
			int index;
			LuaObject.checkType(l, 2, out index);
			int count;
			LuaObject.checkType(l, 3, out count);
			List<int> range = list.GetRange(index, count);
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

	// Token: 0x06022909 RID: 141577 RVA: 0x00BDCC18 File Offset: 0x00BDAE18
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
				List<int> list = (List<int>)LuaObject.checkSelf(l);
				int item;
				LuaObject.checkType(l, 2, out item);
				int i = list.IndexOf(item);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i);
				result = 2;
			}
			else if (num == 3)
			{
				List<int> list2 = (List<int>)LuaObject.checkSelf(l);
				int item2;
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
				List<int> list3 = (List<int>)LuaObject.checkSelf(l);
				int item3;
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

	// Token: 0x0602290A RID: 141578 RVA: 0x00BDCD54 File Offset: 0x00BDAF54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Insert(IntPtr l)
	{
		int result;
		try
		{
			List<int> list = (List<int>)LuaObject.checkSelf(l);
			int index;
			LuaObject.checkType(l, 2, out index);
			int item;
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

	// Token: 0x0602290B RID: 141579 RVA: 0x00BDCDB8 File Offset: 0x00BDAFB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InsertRange(IntPtr l)
	{
		int result;
		try
		{
			List<int> list = (List<int>)LuaObject.checkSelf(l);
			int index;
			LuaObject.checkType(l, 2, out index);
			IEnumerable<int> collection;
			LuaObject.checkType<IEnumerable<int>>(l, 3, out collection);
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

	// Token: 0x0602290C RID: 141580 RVA: 0x00BDCE1C File Offset: 0x00BDB01C
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
				List<int> list = (List<int>)LuaObject.checkSelf(l);
				int item;
				LuaObject.checkType(l, 2, out item);
				int i = list.LastIndexOf(item);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i);
				result = 2;
			}
			else if (num == 3)
			{
				List<int> list2 = (List<int>)LuaObject.checkSelf(l);
				int item2;
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
				List<int> list3 = (List<int>)LuaObject.checkSelf(l);
				int item3;
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

	// Token: 0x0602290D RID: 141581 RVA: 0x00BDCF58 File Offset: 0x00BDB158
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Remove(IntPtr l)
	{
		int result;
		try
		{
			List<int> list = (List<int>)LuaObject.checkSelf(l);
			int item;
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

	// Token: 0x0602290E RID: 141582 RVA: 0x00BDCFBC File Offset: 0x00BDB1BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RemoveAll(IntPtr l)
	{
		int result;
		try
		{
			List<int> list = (List<int>)LuaObject.checkSelf(l);
			Predicate<int> match;
			LuaObject.checkDelegate<Predicate<int>>(l, 2, out match);
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

	// Token: 0x0602290F RID: 141583 RVA: 0x00BDD020 File Offset: 0x00BDB220
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RemoveAt(IntPtr l)
	{
		int result;
		try
		{
			List<int> list = (List<int>)LuaObject.checkSelf(l);
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

	// Token: 0x06022910 RID: 141584 RVA: 0x00BDD078 File Offset: 0x00BDB278
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RemoveRange(IntPtr l)
	{
		int result;
		try
		{
			List<int> list = (List<int>)LuaObject.checkSelf(l);
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

	// Token: 0x06022911 RID: 141585 RVA: 0x00BDD0DC File Offset: 0x00BDB2DC
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
				List<int> list = (List<int>)LuaObject.checkSelf(l);
				list.Reverse();
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 3)
			{
				List<int> list2 = (List<int>)LuaObject.checkSelf(l);
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

	// Token: 0x06022912 RID: 141586 RVA: 0x00BDD190 File Offset: 0x00BDB390
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
				List<int> list = (List<int>)LuaObject.checkSelf(l);
				list.Sort();
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(IComparer<int>)))
			{
				List<int> list2 = (List<int>)LuaObject.checkSelf(l);
				IComparer<int> comparer;
				LuaObject.checkType<IComparer<int>>(l, 2, out comparer);
				list2.Sort(comparer);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(Comparison<int>)))
			{
				List<int> list3 = (List<int>)LuaObject.checkSelf(l);
				Comparison<int> comparison;
				LuaObject.checkDelegate<Comparison<int>>(l, 2, out comparison);
				list3.Sort(comparison);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 4)
			{
				List<int> list4 = (List<int>)LuaObject.checkSelf(l);
				int index;
				LuaObject.checkType(l, 2, out index);
				int count;
				LuaObject.checkType(l, 3, out count);
				IComparer<int> comparer2;
				LuaObject.checkType<IComparer<int>>(l, 4, out comparer2);
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

	// Token: 0x06022913 RID: 141587 RVA: 0x00BDD2E8 File Offset: 0x00BDB4E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ToArray(IntPtr l)
	{
		int result;
		try
		{
			List<int> list = (List<int>)LuaObject.checkSelf(l);
			int[] a = list.ToArray();
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

	// Token: 0x06022914 RID: 141588 RVA: 0x00BDD33C File Offset: 0x00BDB53C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TrimExcess(IntPtr l)
	{
		int result;
		try
		{
			List<int> list = (List<int>)LuaObject.checkSelf(l);
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

	// Token: 0x06022915 RID: 141589 RVA: 0x00BDD388 File Offset: 0x00BDB588
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TrueForAll(IntPtr l)
	{
		int result;
		try
		{
			List<int> list = (List<int>)LuaObject.checkSelf(l);
			Predicate<int> match;
			LuaObject.checkDelegate<Predicate<int>>(l, 2, out match);
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

	// Token: 0x06022916 RID: 141590 RVA: 0x00BDD3EC File Offset: 0x00BDB5EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Capacity(IntPtr l)
	{
		int result;
		try
		{
			List<int> list = (List<int>)LuaObject.checkSelf(l);
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

	// Token: 0x06022917 RID: 141591 RVA: 0x00BDD440 File Offset: 0x00BDB640
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Capacity(IntPtr l)
	{
		int result;
		try
		{
			List<int> list = (List<int>)LuaObject.checkSelf(l);
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

	// Token: 0x06022918 RID: 141592 RVA: 0x00BDD498 File Offset: 0x00BDB698
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Count(IntPtr l)
	{
		int result;
		try
		{
			List<int> list = (List<int>)LuaObject.checkSelf(l);
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

	// Token: 0x06022919 RID: 141593 RVA: 0x00BDD4EC File Offset: 0x00BDB6EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int getItem(IntPtr l)
	{
		int result;
		try
		{
			List<int> list = (List<int>)LuaObject.checkSelf(l);
			int index;
			LuaObject.checkType(l, 2, out index);
			int i = list[index];
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

	// Token: 0x0602291A RID: 141594 RVA: 0x00BDD550 File Offset: 0x00BDB750
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int setItem(IntPtr l)
	{
		int result;
		try
		{
			List<int> list = (List<int>)LuaObject.checkSelf(l);
			int index;
			LuaObject.checkType(l, 2, out index);
			int value;
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

	// Token: 0x0602291B RID: 141595 RVA: 0x00BDD5B4 File Offset: 0x00BDB7B4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "ListInt");
		if (Lua_System_Collections_Generic_List_1_int.<>f__mg$cache0 == null)
		{
			Lua_System_Collections_Generic_List_1_int.<>f__mg$cache0 = new LuaCSFunction(Lua_System_Collections_Generic_List_1_int.Add);
		}
		LuaObject.addMember(l, Lua_System_Collections_Generic_List_1_int.<>f__mg$cache0);
		if (Lua_System_Collections_Generic_List_1_int.<>f__mg$cache1 == null)
		{
			Lua_System_Collections_Generic_List_1_int.<>f__mg$cache1 = new LuaCSFunction(Lua_System_Collections_Generic_List_1_int.AddRange);
		}
		LuaObject.addMember(l, Lua_System_Collections_Generic_List_1_int.<>f__mg$cache1);
		if (Lua_System_Collections_Generic_List_1_int.<>f__mg$cache2 == null)
		{
			Lua_System_Collections_Generic_List_1_int.<>f__mg$cache2 = new LuaCSFunction(Lua_System_Collections_Generic_List_1_int.AsReadOnly);
		}
		LuaObject.addMember(l, Lua_System_Collections_Generic_List_1_int.<>f__mg$cache2);
		if (Lua_System_Collections_Generic_List_1_int.<>f__mg$cache3 == null)
		{
			Lua_System_Collections_Generic_List_1_int.<>f__mg$cache3 = new LuaCSFunction(Lua_System_Collections_Generic_List_1_int.BinarySearch);
		}
		LuaObject.addMember(l, Lua_System_Collections_Generic_List_1_int.<>f__mg$cache3);
		if (Lua_System_Collections_Generic_List_1_int.<>f__mg$cache4 == null)
		{
			Lua_System_Collections_Generic_List_1_int.<>f__mg$cache4 = new LuaCSFunction(Lua_System_Collections_Generic_List_1_int.Clear);
		}
		LuaObject.addMember(l, Lua_System_Collections_Generic_List_1_int.<>f__mg$cache4);
		if (Lua_System_Collections_Generic_List_1_int.<>f__mg$cache5 == null)
		{
			Lua_System_Collections_Generic_List_1_int.<>f__mg$cache5 = new LuaCSFunction(Lua_System_Collections_Generic_List_1_int.Contains);
		}
		LuaObject.addMember(l, Lua_System_Collections_Generic_List_1_int.<>f__mg$cache5);
		if (Lua_System_Collections_Generic_List_1_int.<>f__mg$cache6 == null)
		{
			Lua_System_Collections_Generic_List_1_int.<>f__mg$cache6 = new LuaCSFunction(Lua_System_Collections_Generic_List_1_int.Exists);
		}
		LuaObject.addMember(l, Lua_System_Collections_Generic_List_1_int.<>f__mg$cache6);
		if (Lua_System_Collections_Generic_List_1_int.<>f__mg$cache7 == null)
		{
			Lua_System_Collections_Generic_List_1_int.<>f__mg$cache7 = new LuaCSFunction(Lua_System_Collections_Generic_List_1_int.Find);
		}
		LuaObject.addMember(l, Lua_System_Collections_Generic_List_1_int.<>f__mg$cache7);
		if (Lua_System_Collections_Generic_List_1_int.<>f__mg$cache8 == null)
		{
			Lua_System_Collections_Generic_List_1_int.<>f__mg$cache8 = new LuaCSFunction(Lua_System_Collections_Generic_List_1_int.FindAll);
		}
		LuaObject.addMember(l, Lua_System_Collections_Generic_List_1_int.<>f__mg$cache8);
		if (Lua_System_Collections_Generic_List_1_int.<>f__mg$cache9 == null)
		{
			Lua_System_Collections_Generic_List_1_int.<>f__mg$cache9 = new LuaCSFunction(Lua_System_Collections_Generic_List_1_int.FindIndex);
		}
		LuaObject.addMember(l, Lua_System_Collections_Generic_List_1_int.<>f__mg$cache9);
		if (Lua_System_Collections_Generic_List_1_int.<>f__mg$cacheA == null)
		{
			Lua_System_Collections_Generic_List_1_int.<>f__mg$cacheA = new LuaCSFunction(Lua_System_Collections_Generic_List_1_int.FindLast);
		}
		LuaObject.addMember(l, Lua_System_Collections_Generic_List_1_int.<>f__mg$cacheA);
		if (Lua_System_Collections_Generic_List_1_int.<>f__mg$cacheB == null)
		{
			Lua_System_Collections_Generic_List_1_int.<>f__mg$cacheB = new LuaCSFunction(Lua_System_Collections_Generic_List_1_int.FindLastIndex);
		}
		LuaObject.addMember(l, Lua_System_Collections_Generic_List_1_int.<>f__mg$cacheB);
		if (Lua_System_Collections_Generic_List_1_int.<>f__mg$cacheC == null)
		{
			Lua_System_Collections_Generic_List_1_int.<>f__mg$cacheC = new LuaCSFunction(Lua_System_Collections_Generic_List_1_int.ForEach);
		}
		LuaObject.addMember(l, Lua_System_Collections_Generic_List_1_int.<>f__mg$cacheC);
		if (Lua_System_Collections_Generic_List_1_int.<>f__mg$cacheD == null)
		{
			Lua_System_Collections_Generic_List_1_int.<>f__mg$cacheD = new LuaCSFunction(Lua_System_Collections_Generic_List_1_int.GetRange);
		}
		LuaObject.addMember(l, Lua_System_Collections_Generic_List_1_int.<>f__mg$cacheD);
		if (Lua_System_Collections_Generic_List_1_int.<>f__mg$cacheE == null)
		{
			Lua_System_Collections_Generic_List_1_int.<>f__mg$cacheE = new LuaCSFunction(Lua_System_Collections_Generic_List_1_int.IndexOf);
		}
		LuaObject.addMember(l, Lua_System_Collections_Generic_List_1_int.<>f__mg$cacheE);
		if (Lua_System_Collections_Generic_List_1_int.<>f__mg$cacheF == null)
		{
			Lua_System_Collections_Generic_List_1_int.<>f__mg$cacheF = new LuaCSFunction(Lua_System_Collections_Generic_List_1_int.Insert);
		}
		LuaObject.addMember(l, Lua_System_Collections_Generic_List_1_int.<>f__mg$cacheF);
		if (Lua_System_Collections_Generic_List_1_int.<>f__mg$cache10 == null)
		{
			Lua_System_Collections_Generic_List_1_int.<>f__mg$cache10 = new LuaCSFunction(Lua_System_Collections_Generic_List_1_int.InsertRange);
		}
		LuaObject.addMember(l, Lua_System_Collections_Generic_List_1_int.<>f__mg$cache10);
		if (Lua_System_Collections_Generic_List_1_int.<>f__mg$cache11 == null)
		{
			Lua_System_Collections_Generic_List_1_int.<>f__mg$cache11 = new LuaCSFunction(Lua_System_Collections_Generic_List_1_int.LastIndexOf);
		}
		LuaObject.addMember(l, Lua_System_Collections_Generic_List_1_int.<>f__mg$cache11);
		if (Lua_System_Collections_Generic_List_1_int.<>f__mg$cache12 == null)
		{
			Lua_System_Collections_Generic_List_1_int.<>f__mg$cache12 = new LuaCSFunction(Lua_System_Collections_Generic_List_1_int.Remove);
		}
		LuaObject.addMember(l, Lua_System_Collections_Generic_List_1_int.<>f__mg$cache12);
		if (Lua_System_Collections_Generic_List_1_int.<>f__mg$cache13 == null)
		{
			Lua_System_Collections_Generic_List_1_int.<>f__mg$cache13 = new LuaCSFunction(Lua_System_Collections_Generic_List_1_int.RemoveAll);
		}
		LuaObject.addMember(l, Lua_System_Collections_Generic_List_1_int.<>f__mg$cache13);
		if (Lua_System_Collections_Generic_List_1_int.<>f__mg$cache14 == null)
		{
			Lua_System_Collections_Generic_List_1_int.<>f__mg$cache14 = new LuaCSFunction(Lua_System_Collections_Generic_List_1_int.RemoveAt);
		}
		LuaObject.addMember(l, Lua_System_Collections_Generic_List_1_int.<>f__mg$cache14);
		if (Lua_System_Collections_Generic_List_1_int.<>f__mg$cache15 == null)
		{
			Lua_System_Collections_Generic_List_1_int.<>f__mg$cache15 = new LuaCSFunction(Lua_System_Collections_Generic_List_1_int.RemoveRange);
		}
		LuaObject.addMember(l, Lua_System_Collections_Generic_List_1_int.<>f__mg$cache15);
		if (Lua_System_Collections_Generic_List_1_int.<>f__mg$cache16 == null)
		{
			Lua_System_Collections_Generic_List_1_int.<>f__mg$cache16 = new LuaCSFunction(Lua_System_Collections_Generic_List_1_int.Reverse);
		}
		LuaObject.addMember(l, Lua_System_Collections_Generic_List_1_int.<>f__mg$cache16);
		if (Lua_System_Collections_Generic_List_1_int.<>f__mg$cache17 == null)
		{
			Lua_System_Collections_Generic_List_1_int.<>f__mg$cache17 = new LuaCSFunction(Lua_System_Collections_Generic_List_1_int.Sort);
		}
		LuaObject.addMember(l, Lua_System_Collections_Generic_List_1_int.<>f__mg$cache17);
		if (Lua_System_Collections_Generic_List_1_int.<>f__mg$cache18 == null)
		{
			Lua_System_Collections_Generic_List_1_int.<>f__mg$cache18 = new LuaCSFunction(Lua_System_Collections_Generic_List_1_int.ToArray);
		}
		LuaObject.addMember(l, Lua_System_Collections_Generic_List_1_int.<>f__mg$cache18);
		if (Lua_System_Collections_Generic_List_1_int.<>f__mg$cache19 == null)
		{
			Lua_System_Collections_Generic_List_1_int.<>f__mg$cache19 = new LuaCSFunction(Lua_System_Collections_Generic_List_1_int.TrimExcess);
		}
		LuaObject.addMember(l, Lua_System_Collections_Generic_List_1_int.<>f__mg$cache19);
		if (Lua_System_Collections_Generic_List_1_int.<>f__mg$cache1A == null)
		{
			Lua_System_Collections_Generic_List_1_int.<>f__mg$cache1A = new LuaCSFunction(Lua_System_Collections_Generic_List_1_int.TrueForAll);
		}
		LuaObject.addMember(l, Lua_System_Collections_Generic_List_1_int.<>f__mg$cache1A);
		if (Lua_System_Collections_Generic_List_1_int.<>f__mg$cache1B == null)
		{
			Lua_System_Collections_Generic_List_1_int.<>f__mg$cache1B = new LuaCSFunction(Lua_System_Collections_Generic_List_1_int.getItem);
		}
		LuaObject.addMember(l, Lua_System_Collections_Generic_List_1_int.<>f__mg$cache1B);
		if (Lua_System_Collections_Generic_List_1_int.<>f__mg$cache1C == null)
		{
			Lua_System_Collections_Generic_List_1_int.<>f__mg$cache1C = new LuaCSFunction(Lua_System_Collections_Generic_List_1_int.setItem);
		}
		LuaObject.addMember(l, Lua_System_Collections_Generic_List_1_int.<>f__mg$cache1C);
		string name = "Capacity";
		if (Lua_System_Collections_Generic_List_1_int.<>f__mg$cache1D == null)
		{
			Lua_System_Collections_Generic_List_1_int.<>f__mg$cache1D = new LuaCSFunction(Lua_System_Collections_Generic_List_1_int.get_Capacity);
		}
		LuaCSFunction get = Lua_System_Collections_Generic_List_1_int.<>f__mg$cache1D;
		if (Lua_System_Collections_Generic_List_1_int.<>f__mg$cache1E == null)
		{
			Lua_System_Collections_Generic_List_1_int.<>f__mg$cache1E = new LuaCSFunction(Lua_System_Collections_Generic_List_1_int.set_Capacity);
		}
		LuaObject.addMember(l, name, get, Lua_System_Collections_Generic_List_1_int.<>f__mg$cache1E, true);
		string name2 = "Count";
		if (Lua_System_Collections_Generic_List_1_int.<>f__mg$cache1F == null)
		{
			Lua_System_Collections_Generic_List_1_int.<>f__mg$cache1F = new LuaCSFunction(Lua_System_Collections_Generic_List_1_int.get_Count);
		}
		LuaObject.addMember(l, name2, Lua_System_Collections_Generic_List_1_int.<>f__mg$cache1F, null, true);
		if (Lua_System_Collections_Generic_List_1_int.<>f__mg$cache20 == null)
		{
			Lua_System_Collections_Generic_List_1_int.<>f__mg$cache20 = new LuaCSFunction(Lua_System_Collections_Generic_List_1_int.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_System_Collections_Generic_List_1_int.<>f__mg$cache20, typeof(List<int>));
	}

	// Token: 0x040186D6 RID: 100054
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040186D7 RID: 100055
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040186D8 RID: 100056
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040186D9 RID: 100057
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040186DA RID: 100058
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040186DB RID: 100059
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040186DC RID: 100060
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040186DD RID: 100061
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040186DE RID: 100062
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040186DF RID: 100063
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040186E0 RID: 100064
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040186E1 RID: 100065
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040186E2 RID: 100066
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040186E3 RID: 100067
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040186E4 RID: 100068
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040186E5 RID: 100069
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040186E6 RID: 100070
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040186E7 RID: 100071
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040186E8 RID: 100072
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040186E9 RID: 100073
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x040186EA RID: 100074
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x040186EB RID: 100075
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x040186EC RID: 100076
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x040186ED RID: 100077
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x040186EE RID: 100078
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x040186EF RID: 100079
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x040186F0 RID: 100080
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x040186F1 RID: 100081
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x040186F2 RID: 100082
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x040186F3 RID: 100083
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x040186F4 RID: 100084
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x040186F5 RID: 100085
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x040186F6 RID: 100086
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;
}
