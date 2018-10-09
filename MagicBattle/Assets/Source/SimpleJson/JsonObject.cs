using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace SimpleJson
{
	// Token: 0x020010C2 RID: 4290
	[GeneratedCode("simple-json", "1.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class JsonObject : IDictionary<string, object>, ICollection<KeyValuePair<string, object>>, IEnumerable<KeyValuePair<string, object>>, IEnumerable
	{
		// Token: 0x060158E1 RID: 88289 RVA: 0x0057D790 File Offset: 0x0057B990
		public JsonObject()
		{
			this._members = new Dictionary<string, object>();
		}

		// Token: 0x060158E2 RID: 88290 RVA: 0x0057D7A4 File Offset: 0x0057B9A4
		public JsonObject(IEqualityComparer<string> comparer)
		{
			this._members = new Dictionary<string, object>(comparer);
		}

		// Token: 0x17003EDF RID: 16095
		public object this[int index]
		{
			get
			{
				return JsonObject.GetAtIndex(this._members, index);
			}
		}

		// Token: 0x060158E4 RID: 88292 RVA: 0x0057D7C8 File Offset: 0x0057B9C8
		internal static object GetAtIndex(IDictionary<string, object> obj, int index)
		{
			if (obj == null)
			{
				throw new ArgumentNullException("obj");
			}
			if (index >= obj.Count)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			int num = 0;
			foreach (KeyValuePair<string, object> keyValuePair in obj)
			{
				if (num++ == index)
				{
					return keyValuePair.Value;
				}
			}
			return null;
		}

		// Token: 0x060158E5 RID: 88293 RVA: 0x0057D85C File Offset: 0x0057BA5C
		public void Add(string key, object value)
		{
			this._members.Add(key, value);
		}

		// Token: 0x060158E6 RID: 88294 RVA: 0x0057D86C File Offset: 0x0057BA6C
		public bool ContainsKey(string key)
		{
			return this._members.ContainsKey(key);
		}

		// Token: 0x17003EE0 RID: 16096
		// (get) Token: 0x060158E7 RID: 88295 RVA: 0x0057D87C File Offset: 0x0057BA7C
		public ICollection<string> Keys
		{
			get
			{
				return this._members.Keys;
			}
		}

		// Token: 0x060158E8 RID: 88296 RVA: 0x0057D88C File Offset: 0x0057BA8C
		public bool Remove(string key)
		{
			return this._members.Remove(key);
		}

		// Token: 0x060158E9 RID: 88297 RVA: 0x0057D89C File Offset: 0x0057BA9C
		public bool TryGetValue(string key, out object value)
		{
			return this._members.TryGetValue(key, out value);
		}

		// Token: 0x17003EE1 RID: 16097
		// (get) Token: 0x060158EA RID: 88298 RVA: 0x0057D8AC File Offset: 0x0057BAAC
		public ICollection<object> Values
		{
			get
			{
				return this._members.Values;
			}
		}

		// Token: 0x17003EE2 RID: 16098
		public object this[string key]
		{
			get
			{
				return this._members[key];
			}
			set
			{
				this._members[key] = value;
			}
		}

		// Token: 0x060158ED RID: 88301 RVA: 0x0057D8DC File Offset: 0x0057BADC
		public void Add(KeyValuePair<string, object> item)
		{
			this._members.Add(item.Key, item.Value);
		}

		// Token: 0x060158EE RID: 88302 RVA: 0x0057D8F8 File Offset: 0x0057BAF8
		public void Clear()
		{
			this._members.Clear();
		}

		// Token: 0x060158EF RID: 88303 RVA: 0x0057D908 File Offset: 0x0057BB08
		public bool Contains(KeyValuePair<string, object> item)
		{
			return this._members.ContainsKey(item.Key) && this._members[item.Key] == item.Value;
		}

		// Token: 0x060158F0 RID: 88304 RVA: 0x0057D940 File Offset: 0x0057BB40
		public void CopyTo(KeyValuePair<string, object>[] array, int arrayIndex)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			int num = this.Count;
			foreach (KeyValuePair<string, object> keyValuePair in this)
			{
				array[arrayIndex++] = keyValuePair;
				if (--num <= 0)
				{
					break;
				}
			}
		}

		// Token: 0x17003EE3 RID: 16099
		// (get) Token: 0x060158F1 RID: 88305 RVA: 0x0057D9C8 File Offset: 0x0057BBC8
		public int Count
		{
			get
			{
				return this._members.Count;
			}
		}

		// Token: 0x17003EE4 RID: 16100
		// (get) Token: 0x060158F2 RID: 88306 RVA: 0x0057D9D8 File Offset: 0x0057BBD8
		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060158F3 RID: 88307 RVA: 0x0057D9DC File Offset: 0x0057BBDC
		public bool Remove(KeyValuePair<string, object> item)
		{
			return this._members.Remove(item.Key);
		}

		// Token: 0x060158F4 RID: 88308 RVA: 0x0057D9F0 File Offset: 0x0057BBF0
		public IEnumerator<KeyValuePair<string, object>> GetEnumerator()
		{
			return this._members.GetEnumerator();
		}

		// Token: 0x060158F5 RID: 88309 RVA: 0x0057DA04 File Offset: 0x0057BC04
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this._members.GetEnumerator();
		}

		// Token: 0x060158F6 RID: 88310 RVA: 0x0057DA18 File Offset: 0x0057BC18
		public override string ToString()
		{
			return SimpleJson.SerializeObject(this);
		}

		// Token: 0x0400BC87 RID: 48263
		private readonly Dictionary<string, object> _members;
	}
}
