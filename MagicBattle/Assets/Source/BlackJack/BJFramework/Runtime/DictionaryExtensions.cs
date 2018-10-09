using System;
using System.Collections;
using System.Text;

namespace BlackJack.BJFramework.Runtime
{
	// Token: 0x02000121 RID: 289
	internal static class DictionaryExtensions
	{
		// Token: 0x06000BEE RID: 3054 RVA: 0x00032ED8 File Offset: 0x000310D8
		public static void Merge(this IDictionary target, IDictionary addHash)
		{
			if (addHash == null || target.Equals(addHash))
			{
				return;
			}
			IEnumerator enumerator = addHash.Keys.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					object key = enumerator.Current;
					target[key] = addHash[key];
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
		}

		// Token: 0x06000BEF RID: 3055 RVA: 0x00032F54 File Offset: 0x00031154
		public static void MergeStringKeys(this IDictionary target, IDictionary addHash)
		{
			if (addHash == null || target.Equals(addHash))
			{
				return;
			}
			IEnumerator enumerator = addHash.Keys.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					if (obj is string)
					{
						target[obj] = addHash[obj];
					}
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
		}

		// Token: 0x06000BF0 RID: 3056 RVA: 0x00032FDC File Offset: 0x000311DC
		public static string ToStringFull(this IDictionary dict)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("Dictionary (Count = " + dict.Count + ") {");
			IDictionaryEnumerator enumerator = dict.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					DictionaryEntry dictionaryEntry = (DictionaryEntry)obj;
					stringBuilder.Append(string.Concat(new object[]
					{
						" {",
						dictionaryEntry.Key,
						", ",
						dictionaryEntry.Value,
						"},"
					}));
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
			stringBuilder.Append(" };");
			return stringBuilder.ToString();
		}

		// Token: 0x06000BF1 RID: 3057 RVA: 0x000330AC File Offset: 0x000312AC
		public static Hashtable StripToStringKeys(this IDictionary original)
		{
			Hashtable hashtable = new Hashtable();
			IDictionaryEnumerator enumerator = original.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					DictionaryEntry dictionaryEntry = (DictionaryEntry)obj;
					if (dictionaryEntry.Key is string)
					{
						hashtable[dictionaryEntry.Key] = dictionaryEntry.Value;
					}
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
			return hashtable;
		}

		// Token: 0x06000BF2 RID: 3058 RVA: 0x00033134 File Offset: 0x00031334
		public static void StripKeysWithNullValues(this IDictionary original)
		{
			object[] array = new object[original.Count];
			original.Keys.CopyTo(array, 0);
			foreach (object key in array)
			{
				if (original[key] == null)
				{
					original.Remove(key);
				}
			}
		}
	}
}
