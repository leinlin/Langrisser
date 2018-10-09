using System;
using ProtoBuf;

namespace BlackJack.ConfigData
{
	// Token: 0x020002CE RID: 718
	[ProtoContract(Name = "PropertyModifyType")]
	public enum PropertyModifyType
	{
		// Token: 0x04001FDB RID: 8155
		[ProtoEnum(Name = "PropertyModifyType_None", Value = 0)]
		PropertyModifyType_None,
		// Token: 0x04001FDC RID: 8156
		[ProtoEnum(Name = "PropertyModifyType_Hero1_HPAdd", Value = 1)]
		PropertyModifyType_Hero1_HPAdd,
		// Token: 0x04001FDD RID: 8157
		[ProtoEnum(Name = "PropertyModifyType_Hero1_ATAdd", Value = 2)]
		PropertyModifyType_Hero1_ATAdd,
		// Token: 0x04001FDE RID: 8158
		[ProtoEnum(Name = "PropertyModifyType_Hero1_DFAdd", Value = 3)]
		PropertyModifyType_Hero1_DFAdd,
		// Token: 0x04001FDF RID: 8159
		[ProtoEnum(Name = "PropertyModifyType_Hero1_MagicAdd", Value = 4)]
		PropertyModifyType_Hero1_MagicAdd,
		// Token: 0x04001FE0 RID: 8160
		[ProtoEnum(Name = "PropertyModifyType_Hero1_MagicDFAdd", Value = 5)]
		PropertyModifyType_Hero1_MagicDFAdd,
		// Token: 0x04001FE1 RID: 8161
		[ProtoEnum(Name = "PropertyModifyType_Hero1_DEXAdd", Value = 6)]
		PropertyModifyType_Hero1_DEXAdd,
		// Token: 0x04001FE2 RID: 8162
		[ProtoEnum(Name = "PropertyModifyType_Hero1_HPCmdAdd", Value = 7)]
		PropertyModifyType_Hero1_HPCmdAdd,
		// Token: 0x04001FE3 RID: 8163
		[ProtoEnum(Name = "PropertyModifyType_Hero1_ATCmdAdd", Value = 8)]
		PropertyModifyType_Hero1_ATCmdAdd,
		// Token: 0x04001FE4 RID: 8164
		[ProtoEnum(Name = "PropertyModifyType_Hero1_DFCmdAdd", Value = 9)]
		PropertyModifyType_Hero1_DFCmdAdd,
		// Token: 0x04001FE5 RID: 8165
		[ProtoEnum(Name = "PropertyModifyType_Hero1_MagicDFCmdAdd", Value = 10)]
		PropertyModifyType_Hero1_MagicDFCmdAdd,
		// Token: 0x04001FE6 RID: 8166
		[ProtoEnum(Name = "PropertyModifyType_Hero1_BFMovePointAdd", Value = 11)]
		PropertyModifyType_Hero1_BFMovePointAdd,
		// Token: 0x04001FE7 RID: 8167
		[ProtoEnum(Name = "PropertyModifyType_Hero1_BFAttackDistanceAdd", Value = 12)]
		PropertyModifyType_Hero1_BFAttackDistanceAdd,
		// Token: 0x04001FE8 RID: 8168
		[ProtoEnum(Name = "PropertyModifyType_Hero1_CriticalDamageAdd", Value = 13)]
		PropertyModifyType_Hero1_CriticalDamageAdd,
		// Token: 0x04001FE9 RID: 8169
		[ProtoEnum(Name = "PropertyModifyType_Hero1_CriticalRateAdd", Value = 14)]
		PropertyModifyType_Hero1_CriticalRateAdd,
		// Token: 0x04001FEA RID: 8170
		[ProtoEnum(Name = "PropertyModifyType_Hero1_HPMul", Value = 15)]
		PropertyModifyType_Hero1_HPMul,
		// Token: 0x04001FEB RID: 8171
		[ProtoEnum(Name = "PropertyModifyType_Hero1_ATMul", Value = 16)]
		PropertyModifyType_Hero1_ATMul,
		// Token: 0x04001FEC RID: 8172
		[ProtoEnum(Name = "PropertyModifyType_Hero1_DFMul", Value = 17)]
		PropertyModifyType_Hero1_DFMul,
		// Token: 0x04001FED RID: 8173
		[ProtoEnum(Name = "PropertyModifyType_Hero1_MagicMul", Value = 18)]
		PropertyModifyType_Hero1_MagicMul,
		// Token: 0x04001FEE RID: 8174
		[ProtoEnum(Name = "PropertyModifyType_Hero1_MagicDFMul", Value = 19)]
		PropertyModifyType_Hero1_MagicDFMul,
		// Token: 0x04001FEF RID: 8175
		[ProtoEnum(Name = "PropertyModifyType_Hero1_DEXMul", Value = 20)]
		PropertyModifyType_Hero1_DEXMul,
		// Token: 0x04001FF0 RID: 8176
		[ProtoEnum(Name = "PropertyModifyType_Hero2_HPAdd", Value = 21)]
		PropertyModifyType_Hero2_HPAdd,
		// Token: 0x04001FF1 RID: 8177
		[ProtoEnum(Name = "PropertyModifyType_Hero2_ATAdd", Value = 22)]
		PropertyModifyType_Hero2_ATAdd,
		// Token: 0x04001FF2 RID: 8178
		[ProtoEnum(Name = "PropertyModifyType_Hero2_DFAdd", Value = 23)]
		PropertyModifyType_Hero2_DFAdd,
		// Token: 0x04001FF3 RID: 8179
		[ProtoEnum(Name = "PropertyModifyType_Hero2_MagicAdd", Value = 24)]
		PropertyModifyType_Hero2_MagicAdd,
		// Token: 0x04001FF4 RID: 8180
		[ProtoEnum(Name = "PropertyModifyType_Hero2_MagicDFAdd", Value = 25)]
		PropertyModifyType_Hero2_MagicDFAdd,
		// Token: 0x04001FF5 RID: 8181
		[ProtoEnum(Name = "PropertyModifyType_Hero2_DEXAdd", Value = 26)]
		PropertyModifyType_Hero2_DEXAdd,
		// Token: 0x04001FF6 RID: 8182
		[ProtoEnum(Name = "PropertyModifyType_Hero2_HPCmdAdd", Value = 27)]
		PropertyModifyType_Hero2_HPCmdAdd,
		// Token: 0x04001FF7 RID: 8183
		[ProtoEnum(Name = "PropertyModifyType_Hero2_ATCmdAdd", Value = 28)]
		PropertyModifyType_Hero2_ATCmdAdd,
		// Token: 0x04001FF8 RID: 8184
		[ProtoEnum(Name = "PropertyModifyType_Hero2_DFCmdAdd", Value = 29)]
		PropertyModifyType_Hero2_DFCmdAdd,
		// Token: 0x04001FF9 RID: 8185
		[ProtoEnum(Name = "PropertyModifyType_Hero2_MagicDFCmdAdd", Value = 30)]
		PropertyModifyType_Hero2_MagicDFCmdAdd,
		// Token: 0x04001FFA RID: 8186
		[ProtoEnum(Name = "PropertyModifyType_Hero2_BFMovePointAdd", Value = 31)]
		PropertyModifyType_Hero2_BFMovePointAdd,
		// Token: 0x04001FFB RID: 8187
		[ProtoEnum(Name = "PropertyModifyType_Hero2_BFAttackDistanceAdd", Value = 32)]
		PropertyModifyType_Hero2_BFAttackDistanceAdd,
		// Token: 0x04001FFC RID: 8188
		[ProtoEnum(Name = "PropertyModifyType_Hero2_MagicDistanceAdd", Value = 33)]
		PropertyModifyType_Hero2_MagicDistanceAdd,
		// Token: 0x04001FFD RID: 8189
		[ProtoEnum(Name = "PropertyModifyType_Hero2_PsyDistanceAdd", Value = 34)]
		PropertyModifyType_Hero2_PsyDistanceAdd,
		// Token: 0x04001FFE RID: 8190
		[ProtoEnum(Name = "PropertyModifyType_Hero2_CriticalDamageAdd", Value = 35)]
		PropertyModifyType_Hero2_CriticalDamageAdd,
		// Token: 0x04001FFF RID: 8191
		[ProtoEnum(Name = "PropertyModifyType_Hero2_CriticalRateAdd", Value = 36)]
		PropertyModifyType_Hero2_CriticalRateAdd,
		// Token: 0x04002000 RID: 8192
		[ProtoEnum(Name = "PropertyModifyType_Hero2_RageEndTurnAdd", Value = 37)]
		PropertyModifyType_Hero2_RageEndTurnAdd,
		// Token: 0x04002001 RID: 8193
		[ProtoEnum(Name = "PropertyModifyType_Hero2_RageBeAttackAdd", Value = 38)]
		PropertyModifyType_Hero2_RageBeAttackAdd,
		// Token: 0x04002002 RID: 8194
		[ProtoEnum(Name = "PropertyModifyType_Hero2_RageKillAdd", Value = 39)]
		PropertyModifyType_Hero2_RageKillAdd,
		// Token: 0x04002003 RID: 8195
		[ProtoEnum(Name = "PropertyModifyType_Hero2_HPMul", Value = 40)]
		PropertyModifyType_Hero2_HPMul,
		// Token: 0x04002004 RID: 8196
		[ProtoEnum(Name = "PropertyModifyType_Hero2_ATMul", Value = 41)]
		PropertyModifyType_Hero2_ATMul,
		// Token: 0x04002005 RID: 8197
		[ProtoEnum(Name = "PropertyModifyType_Hero2_DFMul", Value = 42)]
		PropertyModifyType_Hero2_DFMul,
		// Token: 0x04002006 RID: 8198
		[ProtoEnum(Name = "PropertyModifyType_Hero2_MagicMul", Value = 43)]
		PropertyModifyType_Hero2_MagicMul,
		// Token: 0x04002007 RID: 8199
		[ProtoEnum(Name = "PropertyModifyType_Hero2_MagicDFMul", Value = 44)]
		PropertyModifyType_Hero2_MagicDFMul,
		// Token: 0x04002008 RID: 8200
		[ProtoEnum(Name = "PropertyModifyType_Hero2_DEXMul", Value = 45)]
		PropertyModifyType_Hero2_DEXMul,
		// Token: 0x04002009 RID: 8201
		[ProtoEnum(Name = "PropertyModifyType_Hero2_PsyDmgMul", Value = 46)]
		PropertyModifyType_Hero2_PsyDmgMul,
		// Token: 0x0400200A RID: 8202
		[ProtoEnum(Name = "PropertyModifyType_Hero2_PsyDmgRecvMul", Value = 47)]
		PropertyModifyType_Hero2_PsyDmgRecvMul,
		// Token: 0x0400200B RID: 8203
		[ProtoEnum(Name = "PropertyModifyType_Hero2_SuperPsyDmgRecvMul", Value = 48)]
		PropertyModifyType_Hero2_SuperPsyDmgRecvMul,
		// Token: 0x0400200C RID: 8204
		[ProtoEnum(Name = "PropertyModifyType_Hero2_HealMul", Value = 49)]
		PropertyModifyType_Hero2_HealMul,
		// Token: 0x0400200D RID: 8205
		[ProtoEnum(Name = "PropertyModifyType_Hero2_HealRecvMul", Value = 50)]
		PropertyModifyType_Hero2_HealRecvMul,
		// Token: 0x0400200E RID: 8206
		[ProtoEnum(Name = "PropertyModifyType_Hero2_MagicDmgMul", Value = 51)]
		PropertyModifyType_Hero2_MagicDmgMul,
		// Token: 0x0400200F RID: 8207
		[ProtoEnum(Name = "PropertyModifyType_Hero2_MagicDmgRecvMul", Value = 52)]
		PropertyModifyType_Hero2_MagicDmgRecvMul,
		// Token: 0x04002010 RID: 8208
		[ProtoEnum(Name = "PropertyModifyType_Hero2_SuperMagicDmgRecvMul", Value = 53)]
		PropertyModifyType_Hero2_SuperMagicDmgRecvMul,
		// Token: 0x04002011 RID: 8209
		[ProtoEnum(Name = "PropertyModifyType_Hero2_IgnoreDFMul", Value = 54)]
		PropertyModifyType_Hero2_IgnoreDFMul,
		// Token: 0x04002012 RID: 8210
		[ProtoEnum(Name = "PropertyModifyType_Hero2_SkillDmgMul", Value = 55)]
		PropertyModifyType_Hero2_SkillDmgMul,
		// Token: 0x04002013 RID: 8211
		[ProtoEnum(Name = "PropertyModifyType_Hero2_BFSkillDmgMul", Value = 56)]
		PropertyModifyType_Hero2_BFSkillDmgMul,
		// Token: 0x04002014 RID: 8212
		[ProtoEnum(Name = "PropertyModifyType_Soldier1_HPAdd", Value = 57)]
		PropertyModifyType_Soldier1_HPAdd,
		// Token: 0x04002015 RID: 8213
		[ProtoEnum(Name = "PropertyModifyType_Soldier1_ATAdd", Value = 58)]
		PropertyModifyType_Soldier1_ATAdd,
		// Token: 0x04002016 RID: 8214
		[ProtoEnum(Name = "PropertyModifyType_Soldier1_DFAdd", Value = 59)]
		PropertyModifyType_Soldier1_DFAdd,
		// Token: 0x04002017 RID: 8215
		[ProtoEnum(Name = "PropertyModifyType_Soldier1_MagicDFAdd", Value = 60)]
		PropertyModifyType_Soldier1_MagicDFAdd,
		// Token: 0x04002018 RID: 8216
		[ProtoEnum(Name = "PropertyModifyType_Soldier1_BFMovePointAdd", Value = 61)]
		PropertyModifyType_Soldier1_BFMovePointAdd,
		// Token: 0x04002019 RID: 8217
		[ProtoEnum(Name = "PropertyModifyType_Soldier1_BFAttackDistanceAdd", Value = 62)]
		PropertyModifyType_Soldier1_BFAttackDistanceAdd,
		// Token: 0x0400201A RID: 8218
		[ProtoEnum(Name = "PropertyModifyType_Soldier1_CriticalDamageAdd", Value = 63)]
		PropertyModifyType_Soldier1_CriticalDamageAdd,
		// Token: 0x0400201B RID: 8219
		[ProtoEnum(Name = "PropertyModifyType_Soldier1_CriticalRateAdd", Value = 64)]
		PropertyModifyType_Soldier1_CriticalRateAdd,
		// Token: 0x0400201C RID: 8220
		[ProtoEnum(Name = "PropertyModifyType_Soldier1_HPMul", Value = 65)]
		PropertyModifyType_Soldier1_HPMul,
		// Token: 0x0400201D RID: 8221
		[ProtoEnum(Name = "PropertyModifyType_Soldier1_ATMul", Value = 66)]
		PropertyModifyType_Soldier1_ATMul,
		// Token: 0x0400201E RID: 8222
		[ProtoEnum(Name = "PropertyModifyType_Soldier1_DFMul", Value = 67)]
		PropertyModifyType_Soldier1_DFMul,
		// Token: 0x0400201F RID: 8223
		[ProtoEnum(Name = "PropertyModifyType_Soldier1_MagicDFMul", Value = 68)]
		PropertyModifyType_Soldier1_MagicDFMul,
		// Token: 0x04002020 RID: 8224
		[ProtoEnum(Name = "PropertyModifyType_Soldier2_HPAdd", Value = 69)]
		PropertyModifyType_Soldier2_HPAdd,
		// Token: 0x04002021 RID: 8225
		[ProtoEnum(Name = "PropertyModifyType_Soldier2_ATAdd", Value = 70)]
		PropertyModifyType_Soldier2_ATAdd,
		// Token: 0x04002022 RID: 8226
		[ProtoEnum(Name = "PropertyModifyType_Soldier2_DFAdd", Value = 71)]
		PropertyModifyType_Soldier2_DFAdd,
		// Token: 0x04002023 RID: 8227
		[ProtoEnum(Name = "PropertyModifyType_Soldier2_MagicDFAdd", Value = 72)]
		PropertyModifyType_Soldier2_MagicDFAdd,
		// Token: 0x04002024 RID: 8228
		[ProtoEnum(Name = "PropertyModifyType_Soldier2_BFMovePointAdd", Value = 73)]
		PropertyModifyType_Soldier2_BFMovePointAdd,
		// Token: 0x04002025 RID: 8229
		[ProtoEnum(Name = "PropertyModifyType_Soldier2_BFAttackDistanceAdd", Value = 74)]
		PropertyModifyType_Soldier2_BFAttackDistanceAdd,
		// Token: 0x04002026 RID: 8230
		[ProtoEnum(Name = "PropertyModifyType_Soldier2_CriticalDamageAdd", Value = 75)]
		PropertyModifyType_Soldier2_CriticalDamageAdd,
		// Token: 0x04002027 RID: 8231
		[ProtoEnum(Name = "PropertyModifyType_Soldier2_CriticalRateAdd", Value = 76)]
		PropertyModifyType_Soldier2_CriticalRateAdd,
		// Token: 0x04002028 RID: 8232
		[ProtoEnum(Name = "PropertyModifyType_Soldier2_HPMul", Value = 77)]
		PropertyModifyType_Soldier2_HPMul,
		// Token: 0x04002029 RID: 8233
		[ProtoEnum(Name = "PropertyModifyType_Soldier2_ATMul", Value = 78)]
		PropertyModifyType_Soldier2_ATMul,
		// Token: 0x0400202A RID: 8234
		[ProtoEnum(Name = "PropertyModifyType_Soldier2_DFMul", Value = 79)]
		PropertyModifyType_Soldier2_DFMul,
		// Token: 0x0400202B RID: 8235
		[ProtoEnum(Name = "PropertyModifyType_Soldier2_MagicDFMul", Value = 80)]
		PropertyModifyType_Soldier2_MagicDFMul,
		// Token: 0x0400202C RID: 8236
		[ProtoEnum(Name = "PropertyModifyType_Soldier2_PsyDmgMul", Value = 81)]
		PropertyModifyType_Soldier2_PsyDmgMul,
		// Token: 0x0400202D RID: 8237
		[ProtoEnum(Name = "PropertyModifyType_Soldier2_PsyDmgRecvMul", Value = 82)]
		PropertyModifyType_Soldier2_PsyDmgRecvMul,
		// Token: 0x0400202E RID: 8238
		[ProtoEnum(Name = "PropertyModifyType_Soldier2_SuperPsyDmgRecvMul", Value = 83)]
		PropertyModifyType_Soldier2_SuperPsyDmgRecvMul,
		// Token: 0x0400202F RID: 8239
		[ProtoEnum(Name = "PropertyModifyType_Soldier2_MagicDmgRecvMul", Value = 84)]
		PropertyModifyType_Soldier2_MagicDmgRecvMul,
		// Token: 0x04002030 RID: 8240
		[ProtoEnum(Name = "PropertyModifyType_Soldier2_SuperMagicDmgRecvMul", Value = 85)]
		PropertyModifyType_Soldier2_SuperMagicDmgRecvMul,
		// Token: 0x04002031 RID: 8241
		[ProtoEnum(Name = "PropertyModifyType_Soldier2_IgnoreDFMul", Value = 86)]
		PropertyModifyType_Soldier2_IgnoreDFMul,
		// Token: 0x04002032 RID: 8242
		[ProtoEnum(Name = "PropertyModifyType_Hero3_HPAdd", Value = 87)]
		PropertyModifyType_Hero3_HPAdd,
		// Token: 0x04002033 RID: 8243
		[ProtoEnum(Name = "PropertyModifyType_Hero3_ATAdd", Value = 88)]
		PropertyModifyType_Hero3_ATAdd,
		// Token: 0x04002034 RID: 8244
		[ProtoEnum(Name = "PropertyModifyType_Hero3_DFAdd", Value = 89)]
		PropertyModifyType_Hero3_DFAdd,
		// Token: 0x04002035 RID: 8245
		[ProtoEnum(Name = "PropertyModifyType_Hero3_MagicAdd", Value = 90)]
		PropertyModifyType_Hero3_MagicAdd,
		// Token: 0x04002036 RID: 8246
		[ProtoEnum(Name = "PropertyModifyType_Hero3_MagicDFAdd", Value = 91)]
		PropertyModifyType_Hero3_MagicDFAdd,
		// Token: 0x04002037 RID: 8247
		[ProtoEnum(Name = "PropertyModifyType_Hero3_DEXAdd", Value = 92)]
		PropertyModifyType_Hero3_DEXAdd,
		// Token: 0x04002038 RID: 8248
		[ProtoEnum(Name = "PropertyModifyType_Hero3_HPCmdAdd", Value = 93)]
		PropertyModifyType_Hero3_HPCmdAdd,
		// Token: 0x04002039 RID: 8249
		[ProtoEnum(Name = "PropertyModifyType_Hero3_ATCmdAdd", Value = 94)]
		PropertyModifyType_Hero3_ATCmdAdd,
		// Token: 0x0400203A RID: 8250
		[ProtoEnum(Name = "PropertyModifyType_Hero3_DFCmdAdd", Value = 95)]
		PropertyModifyType_Hero3_DFCmdAdd,
		// Token: 0x0400203B RID: 8251
		[ProtoEnum(Name = "PropertyModifyType_Hero3_MagicDFCmdAdd", Value = 96)]
		PropertyModifyType_Hero3_MagicDFCmdAdd,
		// Token: 0x0400203C RID: 8252
		[ProtoEnum(Name = "PropertyModifyType_Hero3_CriticalDamageAdd", Value = 97)]
		PropertyModifyType_Hero3_CriticalDamageAdd,
		// Token: 0x0400203D RID: 8253
		[ProtoEnum(Name = "PropertyModifyType_Hero3_CriticalRateAdd", Value = 98)]
		PropertyModifyType_Hero3_CriticalRateAdd,
		// Token: 0x0400203E RID: 8254
		[ProtoEnum(Name = "PropertyModifyType_Hero3_HPMul", Value = 99)]
		PropertyModifyType_Hero3_HPMul,
		// Token: 0x0400203F RID: 8255
		[ProtoEnum(Name = "PropertyModifyType_Hero3_ATMul", Value = 100)]
		PropertyModifyType_Hero3_ATMul,
		// Token: 0x04002040 RID: 8256
		[ProtoEnum(Name = "PropertyModifyType_Hero3_DFMul", Value = 101)]
		PropertyModifyType_Hero3_DFMul,
		// Token: 0x04002041 RID: 8257
		[ProtoEnum(Name = "PropertyModifyType_Hero3_MagicMul", Value = 102)]
		PropertyModifyType_Hero3_MagicMul,
		// Token: 0x04002042 RID: 8258
		[ProtoEnum(Name = "PropertyModifyType_Hero3_MagicDFMul", Value = 103)]
		PropertyModifyType_Hero3_MagicDFMul,
		// Token: 0x04002043 RID: 8259
		[ProtoEnum(Name = "PropertyModifyType_Hero3_DEXMul", Value = 104)]
		PropertyModifyType_Hero3_DEXMul,
		// Token: 0x04002044 RID: 8260
		[ProtoEnum(Name = "PropertyModifyType_Hero2_RangeDmgRecvMul", Value = 105)]
		PropertyModifyType_Hero2_RangeDmgRecvMul,
		// Token: 0x04002045 RID: 8261
		[ProtoEnum(Name = "PropertyModifyType_Soldier2_RangeDmgRecvMul", Value = 106)]
		PropertyModifyType_Soldier2_RangeDmgRecvMul,
		// Token: 0x04002046 RID: 8262
		[ProtoEnum(Name = "PropertyModifyType_Hero2_RecvCriticalRateAdd", Value = 107)]
		PropertyModifyType_Hero2_RecvCriticalRateAdd,
		// Token: 0x04002047 RID: 8263
		[ProtoEnum(Name = "PropertyModifyType_Soldier2_RecvCriticalRateAdd", Value = 108)]
		PropertyModifyType_Soldier2_RecvCriticalRateAdd,
		// Token: 0x04002048 RID: 8264
		[ProtoEnum(Name = "PropertyModifyType_Soldier2_MagicDmgMul", Value = 109)]
		PropertyModifyType_Soldier2_MagicDmgMul,
		// Token: 0x04002049 RID: 8265
		[ProtoEnum(Name = "PropertyModifyType_Count", Value = 110)]
		PropertyModifyType_Count
	}
}
