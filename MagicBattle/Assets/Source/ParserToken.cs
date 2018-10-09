using System;

// Token: 0x020010A3 RID: 4259
internal enum ParserToken
{
	// Token: 0x0400BB49 RID: 47945
	None = 65536,
	// Token: 0x0400BB4A RID: 47946
	Number,
	// Token: 0x0400BB4B RID: 47947
	True,
	// Token: 0x0400BB4C RID: 47948
	False,
	// Token: 0x0400BB4D RID: 47949
	Null,
	// Token: 0x0400BB4E RID: 47950
	CharSeq,
	// Token: 0x0400BB4F RID: 47951
	Char,
	// Token: 0x0400BB50 RID: 47952
	Text,
	// Token: 0x0400BB51 RID: 47953
	Object,
	// Token: 0x0400BB52 RID: 47954
	ObjectPrime,
	// Token: 0x0400BB53 RID: 47955
	Pair,
	// Token: 0x0400BB54 RID: 47956
	PairRest,
	// Token: 0x0400BB55 RID: 47957
	Array,
	// Token: 0x0400BB56 RID: 47958
	ArrayPrime,
	// Token: 0x0400BB57 RID: 47959
	Value,
	// Token: 0x0400BB58 RID: 47960
	ValueRest,
	// Token: 0x0400BB59 RID: 47961
	String,
	// Token: 0x0400BB5A RID: 47962
	End,
	// Token: 0x0400BB5B RID: 47963
	Epsilon
}
