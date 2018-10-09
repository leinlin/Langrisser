using System;
using ProtoBuf;

namespace BlackJack.ConfigData
{
	// Token: 0x020002EB RID: 747
	[ProtoContract(Name = "HeroInteractionResultType")]
	public enum HeroInteractionResultType
	{
		// Token: 0x0400228B RID: 8843
		[ProtoEnum(Name = "HeroInteractionResultType_None", Value = 0)]
		HeroInteractionResultType_None,
		// Token: 0x0400228C RID: 8844
		[ProtoEnum(Name = "HeroInteractionResultType_Norml", Value = 1)]
		HeroInteractionResultType_Norml,
		// Token: 0x0400228D RID: 8845
		[ProtoEnum(Name = "HeroInteractionResultType_SmallUp", Value = 2)]
		HeroInteractionResultType_SmallUp,
		// Token: 0x0400228E RID: 8846
		[ProtoEnum(Name = "HeroInteractionResultType_BigUp", Value = 3)]
		HeroInteractionResultType_BigUp
	}
}
