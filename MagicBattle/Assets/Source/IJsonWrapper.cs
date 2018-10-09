using System;
using System.Collections;
using System.Collections.Specialized;

// Token: 0x0200108C RID: 4236
public interface IJsonWrapper : IList, IOrderedDictionary, ICollection, IEnumerable, IDictionary
{
	// Token: 0x17003E6A RID: 15978
	// (get) Token: 0x0601565C RID: 87644
	bool IsArray { get; }

	// Token: 0x17003E6B RID: 15979
	// (get) Token: 0x0601565D RID: 87645
	bool IsBoolean { get; }

	// Token: 0x17003E6C RID: 15980
	// (get) Token: 0x0601565E RID: 87646
	bool IsDouble { get; }

	// Token: 0x17003E6D RID: 15981
	// (get) Token: 0x0601565F RID: 87647
	bool IsInt { get; }

	// Token: 0x17003E6E RID: 15982
	// (get) Token: 0x06015660 RID: 87648
	bool IsLong { get; }

	// Token: 0x17003E6F RID: 15983
	// (get) Token: 0x06015661 RID: 87649
	bool IsObject { get; }

	// Token: 0x17003E70 RID: 15984
	// (get) Token: 0x06015662 RID: 87650
	bool IsString { get; }

	// Token: 0x06015663 RID: 87651
	bool GetBoolean();

	// Token: 0x06015664 RID: 87652
	double GetDouble();

	// Token: 0x06015665 RID: 87653
	int GetInt();

	// Token: 0x06015666 RID: 87654
	JsonType GetJsonType();

	// Token: 0x06015667 RID: 87655
	long GetLong();

	// Token: 0x06015668 RID: 87656
	string GetString();

	// Token: 0x06015669 RID: 87657
	void SetBoolean(bool val);

	// Token: 0x0601566A RID: 87658
	void SetDouble(double val);

	// Token: 0x0601566B RID: 87659
	void SetInt(int val);

	// Token: 0x0601566C RID: 87660
	void SetJsonType(JsonType type);

	// Token: 0x0601566D RID: 87661
	void SetLong(long val);

	// Token: 0x0601566E RID: 87662
	void SetString(string val);

	// Token: 0x0601566F RID: 87663
	string ToJson();

	// Token: 0x06015670 RID: 87664
	void ToJson(JsonWriter writer);
}
