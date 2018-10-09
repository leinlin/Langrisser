using System;
using System.Collections;
using System.Collections.Generic;

// Token: 0x0200108E RID: 4238
internal class OrderedDictionaryEnumerator : IDictionaryEnumerator, IEnumerator
{
	// Token: 0x060156CE RID: 87758 RVA: 0x0056EB1C File Offset: 0x0056CD1C
	public OrderedDictionaryEnumerator(IEnumerator<KeyValuePair<string, JsonData>> enumerator)
	{
		this.list_enumerator = enumerator;
	}

	// Token: 0x17003E8E RID: 16014
	// (get) Token: 0x060156CF RID: 87759 RVA: 0x0056EB2C File Offset: 0x0056CD2C
	public object Current
	{
		get
		{
			return this.Entry;
		}
	}

	// Token: 0x17003E8F RID: 16015
	// (get) Token: 0x060156D0 RID: 87760 RVA: 0x0056EB3C File Offset: 0x0056CD3C
	public DictionaryEntry Entry
	{
		get
		{
			KeyValuePair<string, JsonData> keyValuePair = this.list_enumerator.Current;
			return new DictionaryEntry(keyValuePair.Key, keyValuePair.Value);
		}
	}

	// Token: 0x17003E90 RID: 16016
	// (get) Token: 0x060156D1 RID: 87761 RVA: 0x0056EB68 File Offset: 0x0056CD68
	public object Key
	{
		get
		{
			KeyValuePair<string, JsonData> keyValuePair = this.list_enumerator.Current;
			return keyValuePair.Key;
		}
	}

	// Token: 0x17003E91 RID: 16017
	// (get) Token: 0x060156D2 RID: 87762 RVA: 0x0056EB88 File Offset: 0x0056CD88
	public object Value
	{
		get
		{
			KeyValuePair<string, JsonData> keyValuePair = this.list_enumerator.Current;
			return keyValuePair.Value;
		}
	}

	// Token: 0x060156D3 RID: 87763 RVA: 0x0056EBA8 File Offset: 0x0056CDA8
	public bool MoveNext()
	{
		return this.list_enumerator.MoveNext();
	}

	// Token: 0x060156D4 RID: 87764 RVA: 0x0056EBB8 File Offset: 0x0056CDB8
	public void Reset()
	{
		this.list_enumerator.Reset();
	}

	// Token: 0x0400BAB5 RID: 47797
	private IEnumerator<KeyValuePair<string, JsonData>> list_enumerator;
}
