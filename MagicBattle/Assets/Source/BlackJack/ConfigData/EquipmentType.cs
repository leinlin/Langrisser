using System;
using ProtoBuf;

namespace BlackJack.ConfigData
{
	// Token: 0x020002EC RID: 748
	[ProtoContract(Name = "EquipmentType")]
	public enum EquipmentType
	{
		// Token: 0x04002290 RID: 8848
		[ProtoEnum(Name = "EquipmentType_Weapon", Value = 0)]
		EquipmentType_Weapon,
		// Token: 0x04002291 RID: 8849
		[ProtoEnum(Name = "EquipmentType_Armor", Value = 1)]
		EquipmentType_Armor,
		// Token: 0x04002292 RID: 8850
		[ProtoEnum(Name = "EquipmentType_Helmet", Value = 2)]
		EquipmentType_Helmet,
		// Token: 0x04002293 RID: 8851
		[ProtoEnum(Name = "EquipmentType_Ornament", Value = 3)]
		EquipmentType_Ornament,
		// Token: 0x04002294 RID: 8852
		[ProtoEnum(Name = "EquipmentType_Enhancement", Value = 4)]
		EquipmentType_Enhancement,
		// Token: 0x04002295 RID: 8853
		[ProtoEnum(Name = "EquipmentType_LevelUpStar", Value = 5)]
		EquipmentType_LevelUpStar
	}
}
