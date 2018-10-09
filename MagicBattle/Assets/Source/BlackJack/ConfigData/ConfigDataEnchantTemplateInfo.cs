using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x0200022A RID: 554
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ConfigDataEnchantTemplateInfo")]
	[Serializable]
	public class ConfigDataEnchantTemplateInfo : IExtensible
	{
		// Token: 0x0600214A RID: 8522 RVA: 0x000A1DE0 File Offset: 0x0009FFE0
		public ConfigDataEnchantTemplateInfo()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ctor_hotfix != null)
			{
				this.m_ctor_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x17000750 RID: 1872
		// (get) Token: 0x0600214B RID: 8523 RVA: 0x000A1EF8 File Offset: 0x000A00F8
		// (set) Token: 0x0600214C RID: 8524 RVA: 0x000A1F00 File Offset: 0x000A0100
		[ProtoMember(2, IsRequired = true, Name = "ID", DataFormat = DataFormat.TwosComplement)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				this._ID = value;
			}
		}

		// Token: 0x17000751 RID: 1873
		// (get) Token: 0x0600214D RID: 8525 RVA: 0x000A1F0C File Offset: 0x000A010C
		// (set) Token: 0x0600214E RID: 8526 RVA: 0x000A1F14 File Offset: 0x000A0114
		[ProtoMember(3, IsRequired = true, Name = "Name", DataFormat = DataFormat.Default)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				this._Name = value;
			}
		}

		// Token: 0x17000752 RID: 1874
		// (get) Token: 0x0600214F RID: 8527 RVA: 0x000A1F20 File Offset: 0x000A0120
		// (set) Token: 0x06002150 RID: 8528 RVA: 0x000A1F28 File Offset: 0x000A0128
		[ProtoMember(4, IsRequired = true, Name = "Property1_ID", DataFormat = DataFormat.TwosComplement)]
		public PropertyModifyType Property1_ID
		{
			get
			{
				return this._Property1_ID;
			}
			set
			{
				this._Property1_ID = value;
			}
		}

		// Token: 0x17000753 RID: 1875
		// (get) Token: 0x06002151 RID: 8529 RVA: 0x000A1F34 File Offset: 0x000A0134
		[ProtoMember(5, Name = "ValueRange1", DataFormat = DataFormat.Default)]
		public List<EnchantPropertyValueInfo> ValueRange1
		{
			get
			{
				return this._ValueRange1;
			}
		}

		// Token: 0x17000754 RID: 1876
		// (get) Token: 0x06002152 RID: 8530 RVA: 0x000A1F3C File Offset: 0x000A013C
		// (set) Token: 0x06002153 RID: 8531 RVA: 0x000A1F44 File Offset: 0x000A0144
		[ProtoMember(6, IsRequired = true, Name = "Weight1", DataFormat = DataFormat.TwosComplement)]
		public int Weight1
		{
			get
			{
				return this._Weight1;
			}
			set
			{
				this._Weight1 = value;
			}
		}

		// Token: 0x17000755 RID: 1877
		// (get) Token: 0x06002154 RID: 8532 RVA: 0x000A1F50 File Offset: 0x000A0150
		// (set) Token: 0x06002155 RID: 8533 RVA: 0x000A1F58 File Offset: 0x000A0158
		[ProtoMember(7, IsRequired = true, Name = "Property2_ID", DataFormat = DataFormat.TwosComplement)]
		public PropertyModifyType Property2_ID
		{
			get
			{
				return this._Property2_ID;
			}
			set
			{
				this._Property2_ID = value;
			}
		}

		// Token: 0x17000756 RID: 1878
		// (get) Token: 0x06002156 RID: 8534 RVA: 0x000A1F64 File Offset: 0x000A0164
		[ProtoMember(8, Name = "ValueRange2", DataFormat = DataFormat.Default)]
		public List<EnchantPropertyValueInfo> ValueRange2
		{
			get
			{
				return this._ValueRange2;
			}
		}

		// Token: 0x17000757 RID: 1879
		// (get) Token: 0x06002157 RID: 8535 RVA: 0x000A1F6C File Offset: 0x000A016C
		// (set) Token: 0x06002158 RID: 8536 RVA: 0x000A1F74 File Offset: 0x000A0174
		[ProtoMember(9, IsRequired = true, Name = "Weight2", DataFormat = DataFormat.TwosComplement)]
		public int Weight2
		{
			get
			{
				return this._Weight2;
			}
			set
			{
				this._Weight2 = value;
			}
		}

		// Token: 0x17000758 RID: 1880
		// (get) Token: 0x06002159 RID: 8537 RVA: 0x000A1F80 File Offset: 0x000A0180
		// (set) Token: 0x0600215A RID: 8538 RVA: 0x000A1F88 File Offset: 0x000A0188
		[ProtoMember(10, IsRequired = true, Name = "Property3_ID", DataFormat = DataFormat.TwosComplement)]
		public PropertyModifyType Property3_ID
		{
			get
			{
				return this._Property3_ID;
			}
			set
			{
				this._Property3_ID = value;
			}
		}

		// Token: 0x17000759 RID: 1881
		// (get) Token: 0x0600215B RID: 8539 RVA: 0x000A1F94 File Offset: 0x000A0194
		[ProtoMember(11, Name = "ValueRange3", DataFormat = DataFormat.Default)]
		public List<EnchantPropertyValueInfo> ValueRange3
		{
			get
			{
				return this._ValueRange3;
			}
		}

		// Token: 0x1700075A RID: 1882
		// (get) Token: 0x0600215C RID: 8540 RVA: 0x000A1F9C File Offset: 0x000A019C
		// (set) Token: 0x0600215D RID: 8541 RVA: 0x000A1FA4 File Offset: 0x000A01A4
		[ProtoMember(12, IsRequired = true, Name = "Weight3", DataFormat = DataFormat.TwosComplement)]
		public int Weight3
		{
			get
			{
				return this._Weight3;
			}
			set
			{
				this._Weight3 = value;
			}
		}

		// Token: 0x1700075B RID: 1883
		// (get) Token: 0x0600215E RID: 8542 RVA: 0x000A1FB0 File Offset: 0x000A01B0
		// (set) Token: 0x0600215F RID: 8543 RVA: 0x000A1FB8 File Offset: 0x000A01B8
		[ProtoMember(13, IsRequired = true, Name = "Property4_ID", DataFormat = DataFormat.TwosComplement)]
		public PropertyModifyType Property4_ID
		{
			get
			{
				return this._Property4_ID;
			}
			set
			{
				this._Property4_ID = value;
			}
		}

		// Token: 0x1700075C RID: 1884
		// (get) Token: 0x06002160 RID: 8544 RVA: 0x000A1FC4 File Offset: 0x000A01C4
		[ProtoMember(14, Name = "ValueRange4", DataFormat = DataFormat.Default)]
		public List<EnchantPropertyValueInfo> ValueRange4
		{
			get
			{
				return this._ValueRange4;
			}
		}

		// Token: 0x1700075D RID: 1885
		// (get) Token: 0x06002161 RID: 8545 RVA: 0x000A1FCC File Offset: 0x000A01CC
		// (set) Token: 0x06002162 RID: 8546 RVA: 0x000A1FD4 File Offset: 0x000A01D4
		[ProtoMember(15, IsRequired = true, Name = "Weight4", DataFormat = DataFormat.TwosComplement)]
		public int Weight4
		{
			get
			{
				return this._Weight4;
			}
			set
			{
				this._Weight4 = value;
			}
		}

		// Token: 0x1700075E RID: 1886
		// (get) Token: 0x06002163 RID: 8547 RVA: 0x000A1FE0 File Offset: 0x000A01E0
		// (set) Token: 0x06002164 RID: 8548 RVA: 0x000A1FE8 File Offset: 0x000A01E8
		[ProtoMember(16, IsRequired = true, Name = "Property5_ID", DataFormat = DataFormat.TwosComplement)]
		public PropertyModifyType Property5_ID
		{
			get
			{
				return this._Property5_ID;
			}
			set
			{
				this._Property5_ID = value;
			}
		}

		// Token: 0x1700075F RID: 1887
		// (get) Token: 0x06002165 RID: 8549 RVA: 0x000A1FF4 File Offset: 0x000A01F4
		[ProtoMember(17, Name = "ValueRange5", DataFormat = DataFormat.Default)]
		public List<EnchantPropertyValueInfo> ValueRange5
		{
			get
			{
				return this._ValueRange5;
			}
		}

		// Token: 0x17000760 RID: 1888
		// (get) Token: 0x06002166 RID: 8550 RVA: 0x000A1FFC File Offset: 0x000A01FC
		// (set) Token: 0x06002167 RID: 8551 RVA: 0x000A2004 File Offset: 0x000A0204
		[ProtoMember(18, IsRequired = true, Name = "Weight5", DataFormat = DataFormat.TwosComplement)]
		public int Weight5
		{
			get
			{
				return this._Weight5;
			}
			set
			{
				this._Weight5 = value;
			}
		}

		// Token: 0x17000761 RID: 1889
		// (get) Token: 0x06002168 RID: 8552 RVA: 0x000A2010 File Offset: 0x000A0210
		// (set) Token: 0x06002169 RID: 8553 RVA: 0x000A2018 File Offset: 0x000A0218
		[ProtoMember(19, IsRequired = true, Name = "Property6_ID", DataFormat = DataFormat.TwosComplement)]
		public PropertyModifyType Property6_ID
		{
			get
			{
				return this._Property6_ID;
			}
			set
			{
				this._Property6_ID = value;
			}
		}

		// Token: 0x17000762 RID: 1890
		// (get) Token: 0x0600216A RID: 8554 RVA: 0x000A2024 File Offset: 0x000A0224
		[ProtoMember(20, Name = "ValueRange6", DataFormat = DataFormat.Default)]
		public List<EnchantPropertyValueInfo> ValueRange6
		{
			get
			{
				return this._ValueRange6;
			}
		}

		// Token: 0x17000763 RID: 1891
		// (get) Token: 0x0600216B RID: 8555 RVA: 0x000A202C File Offset: 0x000A022C
		// (set) Token: 0x0600216C RID: 8556 RVA: 0x000A2034 File Offset: 0x000A0234
		[ProtoMember(21, IsRequired = true, Name = "Weight6", DataFormat = DataFormat.TwosComplement)]
		public int Weight6
		{
			get
			{
				return this._Weight6;
			}
			set
			{
				this._Weight6 = value;
			}
		}

		// Token: 0x17000764 RID: 1892
		// (get) Token: 0x0600216D RID: 8557 RVA: 0x000A2040 File Offset: 0x000A0240
		// (set) Token: 0x0600216E RID: 8558 RVA: 0x000A2048 File Offset: 0x000A0248
		[ProtoMember(22, IsRequired = true, Name = "Property7_ID", DataFormat = DataFormat.TwosComplement)]
		public PropertyModifyType Property7_ID
		{
			get
			{
				return this._Property7_ID;
			}
			set
			{
				this._Property7_ID = value;
			}
		}

		// Token: 0x17000765 RID: 1893
		// (get) Token: 0x0600216F RID: 8559 RVA: 0x000A2054 File Offset: 0x000A0254
		[ProtoMember(23, Name = "ValueRange7", DataFormat = DataFormat.Default)]
		public List<EnchantPropertyValueInfo> ValueRange7
		{
			get
			{
				return this._ValueRange7;
			}
		}

		// Token: 0x17000766 RID: 1894
		// (get) Token: 0x06002170 RID: 8560 RVA: 0x000A205C File Offset: 0x000A025C
		// (set) Token: 0x06002171 RID: 8561 RVA: 0x000A2064 File Offset: 0x000A0264
		[ProtoMember(24, IsRequired = true, Name = "Weight7", DataFormat = DataFormat.TwosComplement)]
		public int Weight7
		{
			get
			{
				return this._Weight7;
			}
			set
			{
				this._Weight7 = value;
			}
		}

		// Token: 0x17000767 RID: 1895
		// (get) Token: 0x06002172 RID: 8562 RVA: 0x000A2070 File Offset: 0x000A0270
		// (set) Token: 0x06002173 RID: 8563 RVA: 0x000A2078 File Offset: 0x000A0278
		[ProtoMember(25, IsRequired = true, Name = "Property8_ID", DataFormat = DataFormat.TwosComplement)]
		public PropertyModifyType Property8_ID
		{
			get
			{
				return this._Property8_ID;
			}
			set
			{
				this._Property8_ID = value;
			}
		}

		// Token: 0x17000768 RID: 1896
		// (get) Token: 0x06002174 RID: 8564 RVA: 0x000A2084 File Offset: 0x000A0284
		[ProtoMember(26, Name = "ValueRange8", DataFormat = DataFormat.Default)]
		public List<EnchantPropertyValueInfo> ValueRange8
		{
			get
			{
				return this._ValueRange8;
			}
		}

		// Token: 0x17000769 RID: 1897
		// (get) Token: 0x06002175 RID: 8565 RVA: 0x000A208C File Offset: 0x000A028C
		// (set) Token: 0x06002176 RID: 8566 RVA: 0x000A2094 File Offset: 0x000A0294
		[ProtoMember(27, IsRequired = true, Name = "Weight8", DataFormat = DataFormat.TwosComplement)]
		public int Weight8
		{
			get
			{
				return this._Weight8;
			}
			set
			{
				this._Weight8 = value;
			}
		}

		// Token: 0x1700076A RID: 1898
		// (get) Token: 0x06002177 RID: 8567 RVA: 0x000A20A0 File Offset: 0x000A02A0
		// (set) Token: 0x06002178 RID: 8568 RVA: 0x000A20A8 File Offset: 0x000A02A8
		[ProtoMember(28, IsRequired = true, Name = "Property9_ID", DataFormat = DataFormat.TwosComplement)]
		public PropertyModifyType Property9_ID
		{
			get
			{
				return this._Property9_ID;
			}
			set
			{
				this._Property9_ID = value;
			}
		}

		// Token: 0x1700076B RID: 1899
		// (get) Token: 0x06002179 RID: 8569 RVA: 0x000A20B4 File Offset: 0x000A02B4
		[ProtoMember(29, Name = "ValueRange9", DataFormat = DataFormat.Default)]
		public List<EnchantPropertyValueInfo> ValueRange9
		{
			get
			{
				return this._ValueRange9;
			}
		}

		// Token: 0x1700076C RID: 1900
		// (get) Token: 0x0600217A RID: 8570 RVA: 0x000A20BC File Offset: 0x000A02BC
		// (set) Token: 0x0600217B RID: 8571 RVA: 0x000A20C4 File Offset: 0x000A02C4
		[ProtoMember(30, IsRequired = true, Name = "Weight9", DataFormat = DataFormat.TwosComplement)]
		public int Weight9
		{
			get
			{
				return this._Weight9;
			}
			set
			{
				this._Weight9 = value;
			}
		}

		// Token: 0x1700076D RID: 1901
		// (get) Token: 0x0600217C RID: 8572 RVA: 0x000A20D0 File Offset: 0x000A02D0
		// (set) Token: 0x0600217D RID: 8573 RVA: 0x000A20D8 File Offset: 0x000A02D8
		[ProtoMember(31, IsRequired = true, Name = "Property10_ID", DataFormat = DataFormat.TwosComplement)]
		public PropertyModifyType Property10_ID
		{
			get
			{
				return this._Property10_ID;
			}
			set
			{
				this._Property10_ID = value;
			}
		}

		// Token: 0x1700076E RID: 1902
		// (get) Token: 0x0600217E RID: 8574 RVA: 0x000A20E4 File Offset: 0x000A02E4
		[ProtoMember(32, Name = "ValueRange10", DataFormat = DataFormat.Default)]
		public List<EnchantPropertyValueInfo> ValueRange10
		{
			get
			{
				return this._ValueRange10;
			}
		}

		// Token: 0x1700076F RID: 1903
		// (get) Token: 0x0600217F RID: 8575 RVA: 0x000A20EC File Offset: 0x000A02EC
		// (set) Token: 0x06002180 RID: 8576 RVA: 0x000A20F4 File Offset: 0x000A02F4
		[ProtoMember(33, IsRequired = true, Name = "Weight10", DataFormat = DataFormat.TwosComplement)]
		public int Weight10
		{
			get
			{
				return this._Weight10;
			}
			set
			{
				this._Weight10 = value;
			}
		}

		// Token: 0x17000770 RID: 1904
		// (get) Token: 0x06002181 RID: 8577 RVA: 0x000A2100 File Offset: 0x000A0300
		// (set) Token: 0x06002182 RID: 8578 RVA: 0x000A2108 File Offset: 0x000A0308
		[ProtoMember(34, IsRequired = true, Name = "Property11_ID", DataFormat = DataFormat.TwosComplement)]
		public PropertyModifyType Property11_ID
		{
			get
			{
				return this._Property11_ID;
			}
			set
			{
				this._Property11_ID = value;
			}
		}

		// Token: 0x17000771 RID: 1905
		// (get) Token: 0x06002183 RID: 8579 RVA: 0x000A2114 File Offset: 0x000A0314
		[ProtoMember(35, Name = "ValueRange11", DataFormat = DataFormat.Default)]
		public List<EnchantPropertyValueInfo> ValueRange11
		{
			get
			{
				return this._ValueRange11;
			}
		}

		// Token: 0x17000772 RID: 1906
		// (get) Token: 0x06002184 RID: 8580 RVA: 0x000A211C File Offset: 0x000A031C
		// (set) Token: 0x06002185 RID: 8581 RVA: 0x000A2124 File Offset: 0x000A0324
		[ProtoMember(36, IsRequired = true, Name = "Weight11", DataFormat = DataFormat.TwosComplement)]
		public int Weight11
		{
			get
			{
				return this._Weight11;
			}
			set
			{
				this._Weight11 = value;
			}
		}

		// Token: 0x17000773 RID: 1907
		// (get) Token: 0x06002186 RID: 8582 RVA: 0x000A2130 File Offset: 0x000A0330
		// (set) Token: 0x06002187 RID: 8583 RVA: 0x000A2138 File Offset: 0x000A0338
		[ProtoMember(37, IsRequired = true, Name = "Property12_ID", DataFormat = DataFormat.TwosComplement)]
		public PropertyModifyType Property12_ID
		{
			get
			{
				return this._Property12_ID;
			}
			set
			{
				this._Property12_ID = value;
			}
		}

		// Token: 0x17000774 RID: 1908
		// (get) Token: 0x06002188 RID: 8584 RVA: 0x000A2144 File Offset: 0x000A0344
		[ProtoMember(38, Name = "ValueRange12", DataFormat = DataFormat.Default)]
		public List<EnchantPropertyValueInfo> ValueRange12
		{
			get
			{
				return this._ValueRange12;
			}
		}

		// Token: 0x17000775 RID: 1909
		// (get) Token: 0x06002189 RID: 8585 RVA: 0x000A214C File Offset: 0x000A034C
		// (set) Token: 0x0600218A RID: 8586 RVA: 0x000A2154 File Offset: 0x000A0354
		[ProtoMember(39, IsRequired = true, Name = "Weight12", DataFormat = DataFormat.TwosComplement)]
		public int Weight12
		{
			get
			{
				return this._Weight12;
			}
			set
			{
				this._Weight12 = value;
			}
		}

		// Token: 0x17000776 RID: 1910
		// (get) Token: 0x0600218B RID: 8587 RVA: 0x000A2160 File Offset: 0x000A0360
		// (set) Token: 0x0600218C RID: 8588 RVA: 0x000A2168 File Offset: 0x000A0368
		[ProtoMember(40, IsRequired = true, Name = "Property13_ID", DataFormat = DataFormat.TwosComplement)]
		public PropertyModifyType Property13_ID
		{
			get
			{
				return this._Property13_ID;
			}
			set
			{
				this._Property13_ID = value;
			}
		}

		// Token: 0x17000777 RID: 1911
		// (get) Token: 0x0600218D RID: 8589 RVA: 0x000A2174 File Offset: 0x000A0374
		[ProtoMember(41, Name = "ValueRange13", DataFormat = DataFormat.Default)]
		public List<EnchantPropertyValueInfo> ValueRange13
		{
			get
			{
				return this._ValueRange13;
			}
		}

		// Token: 0x17000778 RID: 1912
		// (get) Token: 0x0600218E RID: 8590 RVA: 0x000A217C File Offset: 0x000A037C
		// (set) Token: 0x0600218F RID: 8591 RVA: 0x000A2184 File Offset: 0x000A0384
		[ProtoMember(42, IsRequired = true, Name = "Weight13", DataFormat = DataFormat.TwosComplement)]
		public int Weight13
		{
			get
			{
				return this._Weight13;
			}
			set
			{
				this._Weight13 = value;
			}
		}

		// Token: 0x17000779 RID: 1913
		// (get) Token: 0x06002190 RID: 8592 RVA: 0x000A2190 File Offset: 0x000A0390
		// (set) Token: 0x06002191 RID: 8593 RVA: 0x000A2198 File Offset: 0x000A0398
		[ProtoMember(43, IsRequired = true, Name = "Property14_ID", DataFormat = DataFormat.TwosComplement)]
		public PropertyModifyType Property14_ID
		{
			get
			{
				return this._Property14_ID;
			}
			set
			{
				this._Property14_ID = value;
			}
		}

		// Token: 0x1700077A RID: 1914
		// (get) Token: 0x06002192 RID: 8594 RVA: 0x000A21A4 File Offset: 0x000A03A4
		[ProtoMember(44, Name = "ValueRange14", DataFormat = DataFormat.Default)]
		public List<EnchantPropertyValueInfo> ValueRange14
		{
			get
			{
				return this._ValueRange14;
			}
		}

		// Token: 0x1700077B RID: 1915
		// (get) Token: 0x06002193 RID: 8595 RVA: 0x000A21AC File Offset: 0x000A03AC
		// (set) Token: 0x06002194 RID: 8596 RVA: 0x000A21B4 File Offset: 0x000A03B4
		[ProtoMember(45, IsRequired = true, Name = "Weight14", DataFormat = DataFormat.TwosComplement)]
		public int Weight14
		{
			get
			{
				return this._Weight14;
			}
			set
			{
				this._Weight14 = value;
			}
		}

		// Token: 0x1700077C RID: 1916
		// (get) Token: 0x06002195 RID: 8597 RVA: 0x000A21C0 File Offset: 0x000A03C0
		// (set) Token: 0x06002196 RID: 8598 RVA: 0x000A21C8 File Offset: 0x000A03C8
		[ProtoMember(46, IsRequired = true, Name = "Property15_ID", DataFormat = DataFormat.TwosComplement)]
		public PropertyModifyType Property15_ID
		{
			get
			{
				return this._Property15_ID;
			}
			set
			{
				this._Property15_ID = value;
			}
		}

		// Token: 0x1700077D RID: 1917
		// (get) Token: 0x06002197 RID: 8599 RVA: 0x000A21D4 File Offset: 0x000A03D4
		[ProtoMember(47, Name = "ValueRange15", DataFormat = DataFormat.Default)]
		public List<EnchantPropertyValueInfo> ValueRange15
		{
			get
			{
				return this._ValueRange15;
			}
		}

		// Token: 0x1700077E RID: 1918
		// (get) Token: 0x06002198 RID: 8600 RVA: 0x000A21DC File Offset: 0x000A03DC
		// (set) Token: 0x06002199 RID: 8601 RVA: 0x000A21E4 File Offset: 0x000A03E4
		[ProtoMember(48, IsRequired = true, Name = "Weight15", DataFormat = DataFormat.TwosComplement)]
		public int Weight15
		{
			get
			{
				return this._Weight15;
			}
			set
			{
				this._Weight15 = value;
			}
		}

		// Token: 0x1700077F RID: 1919
		// (get) Token: 0x0600219A RID: 8602 RVA: 0x000A21F0 File Offset: 0x000A03F0
		// (set) Token: 0x0600219B RID: 8603 RVA: 0x000A21F8 File Offset: 0x000A03F8
		[ProtoMember(49, IsRequired = true, Name = "Property16_ID", DataFormat = DataFormat.TwosComplement)]
		public PropertyModifyType Property16_ID
		{
			get
			{
				return this._Property16_ID;
			}
			set
			{
				this._Property16_ID = value;
			}
		}

		// Token: 0x17000780 RID: 1920
		// (get) Token: 0x0600219C RID: 8604 RVA: 0x000A2204 File Offset: 0x000A0404
		[ProtoMember(50, Name = "ValueRange16", DataFormat = DataFormat.Default)]
		public List<EnchantPropertyValueInfo> ValueRange16
		{
			get
			{
				return this._ValueRange16;
			}
		}

		// Token: 0x17000781 RID: 1921
		// (get) Token: 0x0600219D RID: 8605 RVA: 0x000A220C File Offset: 0x000A040C
		// (set) Token: 0x0600219E RID: 8606 RVA: 0x000A2214 File Offset: 0x000A0414
		[ProtoMember(51, IsRequired = true, Name = "Weight16", DataFormat = DataFormat.TwosComplement)]
		public int Weight16
		{
			get
			{
				return this._Weight16;
			}
			set
			{
				this._Weight16 = value;
			}
		}

		// Token: 0x0600219F RID: 8607 RVA: 0x000A2220 File Offset: 0x000A0420
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060021A0 RID: 8608 RVA: 0x000A2230 File Offset: 0x000A0430
		private bool InitHotFix(LuaTable A_1)
		{
			this.m_luaObjHelper = new BJLuaObjHelper();
			this.m_luaObjHelper.InitInCS(this, A_1);
			LuaFunction luaFunction = A_1.RawGet("HotFixObject") as LuaFunction;
			bool result;
			if (luaFunction == null)
			{
				Debug.LogError("Can't find HotFixObject Func");
				result = false;
			}
			else
			{
				luaFunction.call(new object[]
				{
					this,
					this.m_luaObjHelper
				});
				LuaTable luaObj = this.m_luaObjHelper.GetLuaObj();
				if (luaObj == null)
				{
					result = false;
				}
				else
				{
					this.m_ctor_hotfix = (luaObj.RawGet("ctor") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060021A1 RID: 8609 RVA: 0x000A22FC File Offset: 0x000A04FC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataEnchantTemplateInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04001423 RID: 5155
		private int _ID;

		// Token: 0x04001424 RID: 5156
		private string _Name;

		// Token: 0x04001425 RID: 5157
		private PropertyModifyType _Property1_ID;

		// Token: 0x04001426 RID: 5158
		private readonly List<EnchantPropertyValueInfo> _ValueRange1 = new List<EnchantPropertyValueInfo>();

		// Token: 0x04001427 RID: 5159
		private int _Weight1;

		// Token: 0x04001428 RID: 5160
		private PropertyModifyType _Property2_ID;

		// Token: 0x04001429 RID: 5161
		private readonly List<EnchantPropertyValueInfo> _ValueRange2 = new List<EnchantPropertyValueInfo>();

		// Token: 0x0400142A RID: 5162
		private int _Weight2;

		// Token: 0x0400142B RID: 5163
		private PropertyModifyType _Property3_ID;

		// Token: 0x0400142C RID: 5164
		private readonly List<EnchantPropertyValueInfo> _ValueRange3 = new List<EnchantPropertyValueInfo>();

		// Token: 0x0400142D RID: 5165
		private int _Weight3;

		// Token: 0x0400142E RID: 5166
		private PropertyModifyType _Property4_ID;

		// Token: 0x0400142F RID: 5167
		private readonly List<EnchantPropertyValueInfo> _ValueRange4 = new List<EnchantPropertyValueInfo>();

		// Token: 0x04001430 RID: 5168
		private int _Weight4;

		// Token: 0x04001431 RID: 5169
		private PropertyModifyType _Property5_ID;

		// Token: 0x04001432 RID: 5170
		private readonly List<EnchantPropertyValueInfo> _ValueRange5 = new List<EnchantPropertyValueInfo>();

		// Token: 0x04001433 RID: 5171
		private int _Weight5;

		// Token: 0x04001434 RID: 5172
		private PropertyModifyType _Property6_ID;

		// Token: 0x04001435 RID: 5173
		private readonly List<EnchantPropertyValueInfo> _ValueRange6 = new List<EnchantPropertyValueInfo>();

		// Token: 0x04001436 RID: 5174
		private int _Weight6;

		// Token: 0x04001437 RID: 5175
		private PropertyModifyType _Property7_ID;

		// Token: 0x04001438 RID: 5176
		private readonly List<EnchantPropertyValueInfo> _ValueRange7 = new List<EnchantPropertyValueInfo>();

		// Token: 0x04001439 RID: 5177
		private int _Weight7;

		// Token: 0x0400143A RID: 5178
		private PropertyModifyType _Property8_ID;

		// Token: 0x0400143B RID: 5179
		private readonly List<EnchantPropertyValueInfo> _ValueRange8 = new List<EnchantPropertyValueInfo>();

		// Token: 0x0400143C RID: 5180
		private int _Weight8;

		// Token: 0x0400143D RID: 5181
		private PropertyModifyType _Property9_ID;

		// Token: 0x0400143E RID: 5182
		private readonly List<EnchantPropertyValueInfo> _ValueRange9 = new List<EnchantPropertyValueInfo>();

		// Token: 0x0400143F RID: 5183
		private int _Weight9;

		// Token: 0x04001440 RID: 5184
		private PropertyModifyType _Property10_ID;

		// Token: 0x04001441 RID: 5185
		private readonly List<EnchantPropertyValueInfo> _ValueRange10 = new List<EnchantPropertyValueInfo>();

		// Token: 0x04001442 RID: 5186
		private int _Weight10;

		// Token: 0x04001443 RID: 5187
		private PropertyModifyType _Property11_ID;

		// Token: 0x04001444 RID: 5188
		private readonly List<EnchantPropertyValueInfo> _ValueRange11 = new List<EnchantPropertyValueInfo>();

		// Token: 0x04001445 RID: 5189
		private int _Weight11;

		// Token: 0x04001446 RID: 5190
		private PropertyModifyType _Property12_ID;

		// Token: 0x04001447 RID: 5191
		private readonly List<EnchantPropertyValueInfo> _ValueRange12 = new List<EnchantPropertyValueInfo>();

		// Token: 0x04001448 RID: 5192
		private int _Weight12;

		// Token: 0x04001449 RID: 5193
		private PropertyModifyType _Property13_ID;

		// Token: 0x0400144A RID: 5194
		private readonly List<EnchantPropertyValueInfo> _ValueRange13 = new List<EnchantPropertyValueInfo>();

		// Token: 0x0400144B RID: 5195
		private int _Weight13;

		// Token: 0x0400144C RID: 5196
		private PropertyModifyType _Property14_ID;

		// Token: 0x0400144D RID: 5197
		private readonly List<EnchantPropertyValueInfo> _ValueRange14 = new List<EnchantPropertyValueInfo>();

		// Token: 0x0400144E RID: 5198
		private int _Weight14;

		// Token: 0x0400144F RID: 5199
		private PropertyModifyType _Property15_ID;

		// Token: 0x04001450 RID: 5200
		private readonly List<EnchantPropertyValueInfo> _ValueRange15 = new List<EnchantPropertyValueInfo>();

		// Token: 0x04001451 RID: 5201
		private int _Weight15;

		// Token: 0x04001452 RID: 5202
		private PropertyModifyType _Property16_ID;

		// Token: 0x04001453 RID: 5203
		private readonly List<EnchantPropertyValueInfo> _ValueRange16 = new List<EnchantPropertyValueInfo>();

		// Token: 0x04001454 RID: 5204
		private int _Weight16;

		// Token: 0x04001455 RID: 5205
		private IExtension extensionObject;

		// Token: 0x04001456 RID: 5206
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04001457 RID: 5207
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04001458 RID: 5208
		private LuaFunction m_ctor_hotfix;
	}
}
