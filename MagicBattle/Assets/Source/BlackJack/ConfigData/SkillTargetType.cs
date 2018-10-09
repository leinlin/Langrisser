using System;
using ProtoBuf;

namespace BlackJack.ConfigData
{
	// Token: 0x020002D8 RID: 728
	[ProtoContract(Name = "SkillTargetType")]
	public enum SkillTargetType
	{
		// Token: 0x040021FF RID: 8703
		[ProtoEnum(Name = "SkillTargetType_None", Value = 0)]
		SkillTargetType_None,
		// Token: 0x04002200 RID: 8704
		[ProtoEnum(Name = "SkillTargetType_Enemy", Value = 1)]
		SkillTargetType_Enemy,
		// Token: 0x04002201 RID: 8705
		[ProtoEnum(Name = "SkillTargetType_Ally", Value = 2)]
		SkillTargetType_Ally,
		// Token: 0x04002202 RID: 8706
		[ProtoEnum(Name = "SkillTargetType_Any", Value = 3)]
		SkillTargetType_Any,
		// Token: 0x04002203 RID: 8707
		[ProtoEnum(Name = "SkillTargetType_Position", Value = 4)]
		SkillTargetType_Position,
		// Token: 0x04002204 RID: 8708
		[ProtoEnum(Name = "SkillTargetType_EmptyPosition", Value = 5)]
		SkillTargetType_EmptyPosition,
		// Token: 0x04002205 RID: 8709
		[ProtoEnum(Name = "SkillTargetType_NoNpcAlly", Value = 6)]
		SkillTargetType_NoNpcAlly,
		// Token: 0x04002206 RID: 8710
		[ProtoEnum(Name = "SkillTargetType_NoSelfNpcAlly", Value = 7)]
		SkillTargetType_NoSelfNpcAlly
	}
}
