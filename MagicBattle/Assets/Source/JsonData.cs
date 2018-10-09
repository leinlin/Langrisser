using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;

// Token: 0x0200108D RID: 4237
public class JsonData : IJsonWrapper, IEquatable<JsonData>, IList, IOrderedDictionary, ICollection, IEnumerable, IDictionary
{
	// Token: 0x06015671 RID: 87665 RVA: 0x0056DBBC File Offset: 0x0056BDBC
	public JsonData()
	{
	}

	// Token: 0x06015672 RID: 87666 RVA: 0x0056DBC4 File Offset: 0x0056BDC4
	public JsonData(bool boolean)
	{
		this.type = JsonType.Boolean;
		this.inst_boolean = boolean;
	}

	// Token: 0x06015673 RID: 87667 RVA: 0x0056DBDC File Offset: 0x0056BDDC
	public JsonData(double number)
	{
		this.type = JsonType.Double;
		this.inst_double = number;
	}

	// Token: 0x06015674 RID: 87668 RVA: 0x0056DBF4 File Offset: 0x0056BDF4
	public JsonData(int number)
	{
		this.type = JsonType.Int;
		this.inst_int = number;
	}

	// Token: 0x06015675 RID: 87669 RVA: 0x0056DC0C File Offset: 0x0056BE0C
	public JsonData(long number)
	{
		this.type = JsonType.Long;
		this.inst_long = number;
	}

	// Token: 0x06015676 RID: 87670 RVA: 0x0056DC24 File Offset: 0x0056BE24
	public JsonData(object obj)
	{
		if (obj is bool)
		{
			this.type = JsonType.Boolean;
			this.inst_boolean = (bool)obj;
			return;
		}
		if (obj is double)
		{
			this.type = JsonType.Double;
			this.inst_double = (double)obj;
			return;
		}
		if (obj is int)
		{
			this.type = JsonType.Int;
			this.inst_int = (int)obj;
			return;
		}
		if (obj is long)
		{
			this.type = JsonType.Long;
			this.inst_long = (long)obj;
			return;
		}
		if (obj is string)
		{
			this.type = JsonType.String;
			this.inst_string = (string)obj;
			return;
		}
		throw new ArgumentException("Unable to wrap the given object with JsonData");
	}

	// Token: 0x06015677 RID: 87671 RVA: 0x0056DCDC File Offset: 0x0056BEDC
	public JsonData(string str)
	{
		this.type = JsonType.String;
		this.inst_string = str;
	}

	// Token: 0x17003E84 RID: 16004
	// (get) Token: 0x06015678 RID: 87672 RVA: 0x0056DCF4 File Offset: 0x0056BEF4
	public int Count
	{
		get
		{
			return this.EnsureCollection().Count;
		}
	}

	// Token: 0x17003E85 RID: 16005
	// (get) Token: 0x06015679 RID: 87673 RVA: 0x0056DD04 File Offset: 0x0056BF04
	public bool IsArray
	{
		get
		{
			return this.type == JsonType.Array;
		}
	}

	// Token: 0x17003E86 RID: 16006
	// (get) Token: 0x0601567A RID: 87674 RVA: 0x0056DD10 File Offset: 0x0056BF10
	public bool IsBoolean
	{
		get
		{
			return this.type == JsonType.Boolean;
		}
	}

	// Token: 0x17003E87 RID: 16007
	// (get) Token: 0x0601567B RID: 87675 RVA: 0x0056DD1C File Offset: 0x0056BF1C
	public bool IsDouble
	{
		get
		{
			return this.type == JsonType.Double;
		}
	}

	// Token: 0x17003E88 RID: 16008
	// (get) Token: 0x0601567C RID: 87676 RVA: 0x0056DD28 File Offset: 0x0056BF28
	public bool IsInt
	{
		get
		{
			return this.type == JsonType.Int;
		}
	}

	// Token: 0x17003E89 RID: 16009
	// (get) Token: 0x0601567D RID: 87677 RVA: 0x0056DD34 File Offset: 0x0056BF34
	public bool IsLong
	{
		get
		{
			return this.type == JsonType.Long;
		}
	}

	// Token: 0x17003E8A RID: 16010
	// (get) Token: 0x0601567E RID: 87678 RVA: 0x0056DD40 File Offset: 0x0056BF40
	public bool IsObject
	{
		get
		{
			return this.type == JsonType.Object;
		}
	}

	// Token: 0x17003E8B RID: 16011
	// (get) Token: 0x0601567F RID: 87679 RVA: 0x0056DD4C File Offset: 0x0056BF4C
	public bool IsString
	{
		get
		{
			return this.type == JsonType.String;
		}
	}

	// Token: 0x17003E71 RID: 15985
	// (get) Token: 0x06015680 RID: 87680 RVA: 0x0056DD58 File Offset: 0x0056BF58
	int ICollection.Count
	{
		get
		{
			return this.Count;
		}
	}

	// Token: 0x17003E72 RID: 15986
	// (get) Token: 0x06015681 RID: 87681 RVA: 0x0056DD60 File Offset: 0x0056BF60
	bool ICollection.IsSynchronized
	{
		get
		{
			return this.EnsureCollection().IsSynchronized;
		}
	}

	// Token: 0x17003E73 RID: 15987
	// (get) Token: 0x06015682 RID: 87682 RVA: 0x0056DD70 File Offset: 0x0056BF70
	object ICollection.SyncRoot
	{
		get
		{
			return this.EnsureCollection().SyncRoot;
		}
	}

	// Token: 0x17003E74 RID: 15988
	// (get) Token: 0x06015683 RID: 87683 RVA: 0x0056DD80 File Offset: 0x0056BF80
	bool IDictionary.IsFixedSize
	{
		get
		{
			return this.EnsureDictionary().IsFixedSize;
		}
	}

	// Token: 0x17003E75 RID: 15989
	// (get) Token: 0x06015684 RID: 87684 RVA: 0x0056DD90 File Offset: 0x0056BF90
	bool IDictionary.IsReadOnly
	{
		get
		{
			return this.EnsureDictionary().IsReadOnly;
		}
	}

	// Token: 0x17003E76 RID: 15990
	// (get) Token: 0x06015685 RID: 87685 RVA: 0x0056DDA0 File Offset: 0x0056BFA0
	ICollection IDictionary.Keys
	{
		get
		{
			this.EnsureDictionary();
			IList<string> list = new List<string>();
			foreach (KeyValuePair<string, JsonData> keyValuePair in this.object_list)
			{
				list.Add(keyValuePair.Key);
			}
			return (ICollection)list;
		}
	}

	// Token: 0x17003E77 RID: 15991
	// (get) Token: 0x06015686 RID: 87686 RVA: 0x0056DE14 File Offset: 0x0056C014
	ICollection IDictionary.Values
	{
		get
		{
			this.EnsureDictionary();
			IList<JsonData> list = new List<JsonData>();
			foreach (KeyValuePair<string, JsonData> keyValuePair in this.object_list)
			{
				list.Add(keyValuePair.Value);
			}
			return (ICollection)list;
		}
	}

	// Token: 0x17003E78 RID: 15992
	// (get) Token: 0x06015687 RID: 87687 RVA: 0x0056DE88 File Offset: 0x0056C088
	bool IJsonWrapper.IsArray
	{
		get
		{
			return this.IsArray;
		}
	}

	// Token: 0x17003E79 RID: 15993
	// (get) Token: 0x06015688 RID: 87688 RVA: 0x0056DE90 File Offset: 0x0056C090
	bool IJsonWrapper.IsBoolean
	{
		get
		{
			return this.IsBoolean;
		}
	}

	// Token: 0x17003E7A RID: 15994
	// (get) Token: 0x06015689 RID: 87689 RVA: 0x0056DE98 File Offset: 0x0056C098
	bool IJsonWrapper.IsDouble
	{
		get
		{
			return this.IsDouble;
		}
	}

	// Token: 0x17003E7B RID: 15995
	// (get) Token: 0x0601568A RID: 87690 RVA: 0x0056DEA0 File Offset: 0x0056C0A0
	bool IJsonWrapper.IsInt
	{
		get
		{
			return this.IsInt;
		}
	}

	// Token: 0x17003E7C RID: 15996
	// (get) Token: 0x0601568B RID: 87691 RVA: 0x0056DEA8 File Offset: 0x0056C0A8
	bool IJsonWrapper.IsLong
	{
		get
		{
			return this.IsLong;
		}
	}

	// Token: 0x17003E7D RID: 15997
	// (get) Token: 0x0601568C RID: 87692 RVA: 0x0056DEB0 File Offset: 0x0056C0B0
	bool IJsonWrapper.IsObject
	{
		get
		{
			return this.IsObject;
		}
	}

	// Token: 0x17003E7E RID: 15998
	// (get) Token: 0x0601568D RID: 87693 RVA: 0x0056DEB8 File Offset: 0x0056C0B8
	bool IJsonWrapper.IsString
	{
		get
		{
			return this.IsString;
		}
	}

	// Token: 0x17003E7F RID: 15999
	// (get) Token: 0x0601568E RID: 87694 RVA: 0x0056DEC0 File Offset: 0x0056C0C0
	bool IList.IsFixedSize
	{
		get
		{
			return this.EnsureList().IsFixedSize;
		}
	}

	// Token: 0x17003E80 RID: 16000
	// (get) Token: 0x0601568F RID: 87695 RVA: 0x0056DED0 File Offset: 0x0056C0D0
	bool IList.IsReadOnly
	{
		get
		{
			return this.EnsureList().IsReadOnly;
		}
	}

	// Token: 0x17003E81 RID: 16001
	object IDictionary.this[object key]
	{
		get
		{
			return this.EnsureDictionary()[key];
		}
		set
		{
			if (!(key is string))
			{
				throw new ArgumentException("The key has to be a string");
			}
			JsonData value2 = this.ToJsonData(value);
			this[(string)key] = value2;
		}
	}

	// Token: 0x17003E82 RID: 16002
	object IOrderedDictionary.this[int idx]
	{
		get
		{
			this.EnsureDictionary();
			return this.object_list[idx].Value;
		}
		set
		{
			this.EnsureDictionary();
			JsonData value2 = this.ToJsonData(value);
			KeyValuePair<string, JsonData> keyValuePair = this.object_list[idx];
			this.inst_object[keyValuePair.Key] = value2;
			KeyValuePair<string, JsonData> value3 = new KeyValuePair<string, JsonData>(keyValuePair.Key, value2);
			this.object_list[idx] = value3;
		}
	}

	// Token: 0x17003E83 RID: 16003
	object IList.this[int index]
	{
		get
		{
			return this.EnsureList()[index];
		}
		set
		{
			this.EnsureList();
			JsonData value2 = this.ToJsonData(value);
			this[index] = value2;
		}
	}

	// Token: 0x17003E8C RID: 16012
	public JsonData this[string prop_name]
	{
		get
		{
			this.EnsureDictionary();
			return this.inst_object[prop_name];
		}
		set
		{
			this.EnsureDictionary();
			KeyValuePair<string, JsonData> keyValuePair = new KeyValuePair<string, JsonData>(prop_name, value);
			if (this.inst_object.ContainsKey(prop_name))
			{
				for (int i = 0; i < this.object_list.Count; i++)
				{
					if (this.object_list[i].Key == prop_name)
					{
						this.object_list[i] = keyValuePair;
						break;
					}
				}
			}
			else
			{
				this.object_list.Add(keyValuePair);
			}
			this.inst_object[prop_name] = value;
			this.json = null;
		}
	}

	// Token: 0x17003E8D RID: 16013
	public JsonData this[int index]
	{
		get
		{
			this.EnsureCollection();
			if (this.type == JsonType.Array)
			{
				return this.inst_array[index];
			}
			return this.object_list[index].Value;
		}
		set
		{
			this.EnsureCollection();
			if (this.type == JsonType.Array)
			{
				this.inst_array[index] = value;
			}
			else
			{
				KeyValuePair<string, JsonData> keyValuePair = this.object_list[index];
				KeyValuePair<string, JsonData> value2 = new KeyValuePair<string, JsonData>(keyValuePair.Key, value);
				this.object_list[index] = value2;
				this.inst_object[keyValuePair.Key] = value;
			}
			this.json = null;
		}
	}

	// Token: 0x0601569A RID: 87706 RVA: 0x0056E150 File Offset: 0x0056C350
	public static implicit operator JsonData(bool data)
	{
		return new JsonData(data);
	}

	// Token: 0x0601569B RID: 87707 RVA: 0x0056E158 File Offset: 0x0056C358
	public static implicit operator JsonData(double data)
	{
		return new JsonData(data);
	}

	// Token: 0x0601569C RID: 87708 RVA: 0x0056E160 File Offset: 0x0056C360
	public static implicit operator JsonData(int data)
	{
		return new JsonData(data);
	}

	// Token: 0x0601569D RID: 87709 RVA: 0x0056E168 File Offset: 0x0056C368
	public static implicit operator JsonData(long data)
	{
		return new JsonData(data);
	}

	// Token: 0x0601569E RID: 87710 RVA: 0x0056E170 File Offset: 0x0056C370
	public static implicit operator JsonData(string data)
	{
		return new JsonData(data);
	}

	// Token: 0x0601569F RID: 87711 RVA: 0x0056E178 File Offset: 0x0056C378
	public static explicit operator bool(JsonData data)
	{
		if (data.type != JsonType.Boolean)
		{
			throw new InvalidCastException("Instance of JsonData doesn't hold a double");
		}
		return data.inst_boolean;
	}

	// Token: 0x060156A0 RID: 87712 RVA: 0x0056E198 File Offset: 0x0056C398
	public static explicit operator double(JsonData data)
	{
		if (data.type != JsonType.Double)
		{
			throw new InvalidCastException("Instance of JsonData doesn't hold a double");
		}
		return data.inst_double;
	}

	// Token: 0x060156A1 RID: 87713 RVA: 0x0056E1B8 File Offset: 0x0056C3B8
	public static explicit operator int(JsonData data)
	{
		if (data.type != JsonType.Int)
		{
			throw new InvalidCastException("Instance of JsonData doesn't hold an int");
		}
		return data.inst_int;
	}

	// Token: 0x060156A2 RID: 87714 RVA: 0x0056E1D8 File Offset: 0x0056C3D8
	public static explicit operator long(JsonData data)
	{
		if (data.type != JsonType.Long)
		{
			throw new InvalidCastException("Instance of JsonData doesn't hold an int");
		}
		return data.inst_long;
	}

	// Token: 0x060156A3 RID: 87715 RVA: 0x0056E1F8 File Offset: 0x0056C3F8
	public static explicit operator string(JsonData data)
	{
		if (data.type != JsonType.String)
		{
			throw new InvalidCastException("Instance of JsonData doesn't hold a string");
		}
		return data.inst_string;
	}

	// Token: 0x060156A4 RID: 87716 RVA: 0x0056E218 File Offset: 0x0056C418
	void ICollection.CopyTo(Array array, int index)
	{
		this.EnsureCollection().CopyTo(array, index);
	}

	// Token: 0x060156A5 RID: 87717 RVA: 0x0056E228 File Offset: 0x0056C428
	void IDictionary.Add(object key, object value)
	{
		JsonData value2 = this.ToJsonData(value);
		this.EnsureDictionary().Add(key, value2);
		KeyValuePair<string, JsonData> item = new KeyValuePair<string, JsonData>((string)key, value2);
		this.object_list.Add(item);
		this.json = null;
	}

	// Token: 0x060156A6 RID: 87718 RVA: 0x0056E26C File Offset: 0x0056C46C
	void IDictionary.Clear()
	{
		this.EnsureDictionary().Clear();
		this.object_list.Clear();
		this.json = null;
	}

	// Token: 0x060156A7 RID: 87719 RVA: 0x0056E28C File Offset: 0x0056C48C
	bool IDictionary.Contains(object key)
	{
		return this.EnsureDictionary().Contains(key);
	}

	// Token: 0x060156A8 RID: 87720 RVA: 0x0056E29C File Offset: 0x0056C49C
	IDictionaryEnumerator IDictionary.GetEnumerator()
	{
		return ((IOrderedDictionary)this).GetEnumerator();
	}

	// Token: 0x060156A9 RID: 87721 RVA: 0x0056E2A4 File Offset: 0x0056C4A4
	void IDictionary.Remove(object key)
	{
		this.EnsureDictionary().Remove(key);
		for (int i = 0; i < this.object_list.Count; i++)
		{
			if (this.object_list[i].Key == (string)key)
			{
				this.object_list.RemoveAt(i);
				break;
			}
		}
		this.json = null;
	}

	// Token: 0x060156AA RID: 87722 RVA: 0x0056E318 File Offset: 0x0056C518
	IEnumerator IEnumerable.GetEnumerator()
	{
		return this.EnsureCollection().GetEnumerator();
	}

	// Token: 0x060156AB RID: 87723 RVA: 0x0056E328 File Offset: 0x0056C528
	bool IJsonWrapper.GetBoolean()
	{
		if (this.type != JsonType.Boolean)
		{
			throw new InvalidOperationException("JsonData instance doesn't hold a boolean");
		}
		return this.inst_boolean;
	}

	// Token: 0x060156AC RID: 87724 RVA: 0x0056E348 File Offset: 0x0056C548
	double IJsonWrapper.GetDouble()
	{
		if (this.type != JsonType.Double)
		{
			throw new InvalidOperationException("JsonData instance doesn't hold a double");
		}
		return this.inst_double;
	}

	// Token: 0x060156AD RID: 87725 RVA: 0x0056E368 File Offset: 0x0056C568
	int IJsonWrapper.GetInt()
	{
		if (this.type != JsonType.Int)
		{
			throw new InvalidOperationException("JsonData instance doesn't hold an int");
		}
		return this.inst_int;
	}

	// Token: 0x060156AE RID: 87726 RVA: 0x0056E388 File Offset: 0x0056C588
	long IJsonWrapper.GetLong()
	{
		if (this.type != JsonType.Long)
		{
			throw new InvalidOperationException("JsonData instance doesn't hold a long");
		}
		return this.inst_long;
	}

	// Token: 0x060156AF RID: 87727 RVA: 0x0056E3A8 File Offset: 0x0056C5A8
	string IJsonWrapper.GetString()
	{
		if (this.type != JsonType.String)
		{
			throw new InvalidOperationException("JsonData instance doesn't hold a string");
		}
		return this.inst_string;
	}

	// Token: 0x060156B0 RID: 87728 RVA: 0x0056E3C8 File Offset: 0x0056C5C8
	void IJsonWrapper.SetBoolean(bool val)
	{
		this.type = JsonType.Boolean;
		this.inst_boolean = val;
		this.json = null;
	}

	// Token: 0x060156B1 RID: 87729 RVA: 0x0056E3E0 File Offset: 0x0056C5E0
	void IJsonWrapper.SetDouble(double val)
	{
		this.type = JsonType.Double;
		this.inst_double = val;
		this.json = null;
	}

	// Token: 0x060156B2 RID: 87730 RVA: 0x0056E3F8 File Offset: 0x0056C5F8
	void IJsonWrapper.SetInt(int val)
	{
		this.type = JsonType.Int;
		this.inst_int = val;
		this.json = null;
	}

	// Token: 0x060156B3 RID: 87731 RVA: 0x0056E410 File Offset: 0x0056C610
	void IJsonWrapper.SetLong(long val)
	{
		this.type = JsonType.Long;
		this.inst_long = val;
		this.json = null;
	}

	// Token: 0x060156B4 RID: 87732 RVA: 0x0056E428 File Offset: 0x0056C628
	void IJsonWrapper.SetString(string val)
	{
		this.type = JsonType.String;
		this.inst_string = val;
		this.json = null;
	}

	// Token: 0x060156B5 RID: 87733 RVA: 0x0056E440 File Offset: 0x0056C640
	string IJsonWrapper.ToJson()
	{
		return this.ToJson();
	}

	// Token: 0x060156B6 RID: 87734 RVA: 0x0056E448 File Offset: 0x0056C648
	void IJsonWrapper.ToJson(JsonWriter writer)
	{
		this.ToJson(writer);
	}

	// Token: 0x060156B7 RID: 87735 RVA: 0x0056E454 File Offset: 0x0056C654
	int IList.Add(object value)
	{
		return this.Add(value);
	}

	// Token: 0x060156B8 RID: 87736 RVA: 0x0056E460 File Offset: 0x0056C660
	void IList.Clear()
	{
		this.EnsureList().Clear();
		this.json = null;
	}

	// Token: 0x060156B9 RID: 87737 RVA: 0x0056E474 File Offset: 0x0056C674
	bool IList.Contains(object value)
	{
		return this.EnsureList().Contains(value);
	}

	// Token: 0x060156BA RID: 87738 RVA: 0x0056E484 File Offset: 0x0056C684
	int IList.IndexOf(object value)
	{
		return this.EnsureList().IndexOf(value);
	}

	// Token: 0x060156BB RID: 87739 RVA: 0x0056E494 File Offset: 0x0056C694
	void IList.Insert(int index, object value)
	{
		this.EnsureList().Insert(index, value);
		this.json = null;
	}

	// Token: 0x060156BC RID: 87740 RVA: 0x0056E4AC File Offset: 0x0056C6AC
	void IList.Remove(object value)
	{
		this.EnsureList().Remove(value);
		this.json = null;
	}

	// Token: 0x060156BD RID: 87741 RVA: 0x0056E4C4 File Offset: 0x0056C6C4
	void IList.RemoveAt(int index)
	{
		this.EnsureList().RemoveAt(index);
		this.json = null;
	}

	// Token: 0x060156BE RID: 87742 RVA: 0x0056E4DC File Offset: 0x0056C6DC
	IDictionaryEnumerator IOrderedDictionary.GetEnumerator()
	{
		this.EnsureDictionary();
		return new OrderedDictionaryEnumerator(this.object_list.GetEnumerator());
	}

	// Token: 0x060156BF RID: 87743 RVA: 0x0056E4F8 File Offset: 0x0056C6F8
	void IOrderedDictionary.Insert(int idx, object key, object value)
	{
		string text = (string)key;
		JsonData value2 = this.ToJsonData(value);
		this[text] = value2;
		KeyValuePair<string, JsonData> item = new KeyValuePair<string, JsonData>(text, value2);
		this.object_list.Insert(idx, item);
	}

	// Token: 0x060156C0 RID: 87744 RVA: 0x0056E534 File Offset: 0x0056C734
	void IOrderedDictionary.RemoveAt(int idx)
	{
		this.EnsureDictionary();
		this.inst_object.Remove(this.object_list[idx].Key);
		this.object_list.RemoveAt(idx);
	}

	// Token: 0x060156C1 RID: 87745 RVA: 0x0056E574 File Offset: 0x0056C774
	private ICollection EnsureCollection()
	{
		if (this.type == JsonType.Array)
		{
			return (ICollection)this.inst_array;
		}
		if (this.type == JsonType.Object)
		{
			return (ICollection)this.inst_object;
		}
		throw new InvalidOperationException("The JsonData instance has to be initialized first");
	}

	// Token: 0x060156C2 RID: 87746 RVA: 0x0056E5B0 File Offset: 0x0056C7B0
	private IDictionary EnsureDictionary()
	{
		if (this.type == JsonType.Object)
		{
			return (IDictionary)this.inst_object;
		}
		if (this.type != JsonType.None)
		{
			throw new InvalidOperationException("Instance of JsonData is not a dictionary");
		}
		this.type = JsonType.Object;
		this.inst_object = new Dictionary<string, JsonData>();
		this.object_list = new List<KeyValuePair<string, JsonData>>();
		return (IDictionary)this.inst_object;
	}

	// Token: 0x060156C3 RID: 87747 RVA: 0x0056E614 File Offset: 0x0056C814
	private IList EnsureList()
	{
		if (this.type == JsonType.Array)
		{
			return (IList)this.inst_array;
		}
		if (this.type != JsonType.None)
		{
			throw new InvalidOperationException("Instance of JsonData is not a list");
		}
		this.type = JsonType.Array;
		this.inst_array = new List<JsonData>();
		return (IList)this.inst_array;
	}

	// Token: 0x060156C4 RID: 87748 RVA: 0x0056E66C File Offset: 0x0056C86C
	private JsonData ToJsonData(object obj)
	{
		if (obj == null)
		{
			return null;
		}
		if (obj is JsonData)
		{
			return (JsonData)obj;
		}
		return new JsonData(obj);
	}

	// Token: 0x060156C5 RID: 87749 RVA: 0x0056E690 File Offset: 0x0056C890
	private static void WriteJson(IJsonWrapper obj, JsonWriter writer)
	{
		if (obj.IsString)
		{
			writer.Write(obj.GetString());
			return;
		}
		if (obj.IsBoolean)
		{
			writer.Write(obj.GetBoolean());
			return;
		}
		if (obj.IsDouble)
		{
			writer.Write(obj.GetDouble());
			return;
		}
		if (obj.IsInt)
		{
			writer.Write(obj.GetInt());
			return;
		}
		if (obj.IsLong)
		{
			writer.Write(obj.GetLong());
			return;
		}
		if (obj.IsArray)
		{
			writer.WriteArrayStart();
			IEnumerator enumerator = obj.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					object obj2 = enumerator.Current;
					JsonData.WriteJson((JsonData)obj2, writer);
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
			writer.WriteArrayEnd();
			return;
		}
		if (obj.IsObject)
		{
			writer.WriteObjectStart();
			IDictionaryEnumerator enumerator2 = obj.GetEnumerator();
			try
			{
				while (enumerator2.MoveNext())
				{
					object obj3 = enumerator2.Current;
					DictionaryEntry dictionaryEntry = (DictionaryEntry)obj3;
					writer.WritePropertyName((string)dictionaryEntry.Key);
					JsonData.WriteJson((JsonData)dictionaryEntry.Value, writer);
				}
			}
			finally
			{
				IDisposable disposable2;
				if ((disposable2 = (enumerator2 as IDisposable)) != null)
				{
					disposable2.Dispose();
				}
			}
			writer.WriteObjectEnd();
			return;
		}
	}

	// Token: 0x060156C6 RID: 87750 RVA: 0x0056E80C File Offset: 0x0056CA0C
	public int Add(object value)
	{
		JsonData value2 = this.ToJsonData(value);
		this.json = null;
		return this.EnsureList().Add(value2);
	}

	// Token: 0x060156C7 RID: 87751 RVA: 0x0056E834 File Offset: 0x0056CA34
	public void Clear()
	{
		if (this.IsObject)
		{
			((IDictionary)this).Clear();
			return;
		}
		if (this.IsArray)
		{
			((IList)this).Clear();
			return;
		}
	}

	// Token: 0x060156C8 RID: 87752 RVA: 0x0056E85C File Offset: 0x0056CA5C
	public bool Equals(JsonData x)
	{
		if (x == null)
		{
			return false;
		}
		if (x.type != this.type)
		{
			return false;
		}
		switch (this.type)
		{
		case JsonType.None:
			return true;
		case JsonType.Object:
			return this.inst_object.Equals(x.inst_object);
		case JsonType.Array:
			return this.inst_array.Equals(x.inst_array);
		case JsonType.String:
			return this.inst_string.Equals(x.inst_string);
		case JsonType.Int:
			return this.inst_int.Equals(x.inst_int);
		case JsonType.Long:
			return this.inst_long.Equals(x.inst_long);
		case JsonType.Double:
			return this.inst_double.Equals(x.inst_double);
		case JsonType.Boolean:
			return this.inst_boolean.Equals(x.inst_boolean);
		default:
			return false;
		}
	}

	// Token: 0x060156C9 RID: 87753 RVA: 0x0056E938 File Offset: 0x0056CB38
	public JsonType GetJsonType()
	{
		return this.type;
	}

	// Token: 0x060156CA RID: 87754 RVA: 0x0056E940 File Offset: 0x0056CB40
	public void SetJsonType(JsonType type)
	{
		if (this.type == type)
		{
			return;
		}
		switch (type)
		{
		case JsonType.Object:
			this.inst_object = new Dictionary<string, JsonData>();
			this.object_list = new List<KeyValuePair<string, JsonData>>();
			break;
		case JsonType.Array:
			this.inst_array = new List<JsonData>();
			break;
		case JsonType.String:
			this.inst_string = null;
			break;
		case JsonType.Int:
			this.inst_int = 0;
			break;
		case JsonType.Long:
			this.inst_long = 0L;
			break;
		case JsonType.Double:
			this.inst_double = 0.0;
			break;
		case JsonType.Boolean:
			this.inst_boolean = false;
			break;
		}
		this.type = type;
	}

	// Token: 0x060156CB RID: 87755 RVA: 0x0056EA04 File Offset: 0x0056CC04
	public string ToJson()
	{
		if (this.json != null)
		{
			return this.json;
		}
		StringWriter stringWriter = new StringWriter();
		JsonData.WriteJson(this, new JsonWriter(stringWriter)
		{
			Validate = false
		});
		this.json = stringWriter.ToString();
		return this.json;
	}

	// Token: 0x060156CC RID: 87756 RVA: 0x0056EA50 File Offset: 0x0056CC50
	public void ToJson(JsonWriter writer)
	{
		bool validate = writer.Validate;
		writer.Validate = false;
		JsonData.WriteJson(this, writer);
		writer.Validate = validate;
	}

	// Token: 0x060156CD RID: 87757 RVA: 0x0056EA7C File Offset: 0x0056CC7C
	public override string ToString()
	{
		switch (this.type)
		{
		case JsonType.Object:
			return "JsonData object";
		case JsonType.Array:
			return "JsonData array";
		case JsonType.String:
			return this.inst_string;
		case JsonType.Int:
			return this.inst_int.ToString();
		case JsonType.Long:
			return this.inst_long.ToString();
		case JsonType.Double:
			return this.inst_double.ToString();
		case JsonType.Boolean:
			return this.inst_boolean.ToString();
		default:
			return "Uninitialized JsonData";
		}
	}

	// Token: 0x0400BAAB RID: 47787
	private IList<JsonData> inst_array;

	// Token: 0x0400BAAC RID: 47788
	private bool inst_boolean;

	// Token: 0x0400BAAD RID: 47789
	private double inst_double;

	// Token: 0x0400BAAE RID: 47790
	private int inst_int;

	// Token: 0x0400BAAF RID: 47791
	private long inst_long;

	// Token: 0x0400BAB0 RID: 47792
	private IDictionary<string, JsonData> inst_object;

	// Token: 0x0400BAB1 RID: 47793
	private string inst_string;

	// Token: 0x0400BAB2 RID: 47794
	private string json;

	// Token: 0x0400BAB3 RID: 47795
	private JsonType type;

	// Token: 0x0400BAB4 RID: 47796
	private IList<KeyValuePair<string, JsonData>> object_list;
}
