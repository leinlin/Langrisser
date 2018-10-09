using System;
using ProtoBuf;

namespace BlackJack.ConfigData
{
	// Token: 0x020002CB RID: 715
	[ProtoContract(Name = "GoddessDialogFuncType")]
	public enum GoddessDialogFuncType
	{
		// Token: 0x04001DDB RID: 7643
		[ProtoEnum(Name = "GoddessDialogFuncType_None", Value = 0)]
		GoddessDialogFuncType_None,
		// Token: 0x04001DDC RID: 7644
		[ProtoEnum(Name = "GoddessDialogFuncType_Start", Value = 1)]
		GoddessDialogFuncType_Start,
		// Token: 0x04001DDD RID: 7645
		[ProtoEnum(Name = "GoddessDialogFuncType_QuestionStart", Value = 2)]
		GoddessDialogFuncType_QuestionStart,
		// Token: 0x04001DDE RID: 7646
		[ProtoEnum(Name = "GoddessDialogFuncType_Result", Value = 3)]
		GoddessDialogFuncType_Result,
		// Token: 0x04001DDF RID: 7647
		[ProtoEnum(Name = "GoddessDialogFuncType_Select", Value = 4)]
		GoddessDialogFuncType_Select,
		// Token: 0x04001DE0 RID: 7648
		[ProtoEnum(Name = "GoddessDialogFuncType_Final", Value = 5)]
		GoddessDialogFuncType_Final
	}
}
