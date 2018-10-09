using System;

// Token: 0x0200109B RID: 4251
public enum JsonToken
{
	// Token: 0x0400BAEA RID: 47850
	None,
	// Token: 0x0400BAEB RID: 47851
	ObjectStart,
	// Token: 0x0400BAEC RID: 47852
	PropertyName,
	// Token: 0x0400BAED RID: 47853
	ObjectEnd,
	// Token: 0x0400BAEE RID: 47854
	ArrayStart,
	// Token: 0x0400BAEF RID: 47855
	ArrayEnd,
	// Token: 0x0400BAF0 RID: 47856
	Int,
	// Token: 0x0400BAF1 RID: 47857
	Long,
	// Token: 0x0400BAF2 RID: 47858
	Double,
	// Token: 0x0400BAF3 RID: 47859
	String,
	// Token: 0x0400BAF4 RID: 47860
	Boolean,
	// Token: 0x0400BAF5 RID: 47861
	Null
}
