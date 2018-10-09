using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000218 RID: 536
	[HotFix(true, m_isCtorOnly = true)]
	[CustomLuaClass]
	[ProtoContract(Name = "ConfigDataBuffInfo")]
	[Serializable]
	public class ConfigDataBuffInfo : IExtensible
	{
		// Token: 0x06001F40 RID: 8000 RVA: 0x0009ED04 File Offset: 0x0009CF04
		public ConfigDataBuffInfo()
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

		// Token: 0x17000661 RID: 1633
		// (get) Token: 0x06001F41 RID: 8001 RVA: 0x0009ED98 File Offset: 0x0009CF98
		// (set) Token: 0x06001F42 RID: 8002 RVA: 0x0009EDA0 File Offset: 0x0009CFA0
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

		// Token: 0x17000662 RID: 1634
		// (get) Token: 0x06001F43 RID: 8003 RVA: 0x0009EDAC File Offset: 0x0009CFAC
		// (set) Token: 0x06001F44 RID: 8004 RVA: 0x0009EDB4 File Offset: 0x0009CFB4
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

		// Token: 0x17000663 RID: 1635
		// (get) Token: 0x06001F45 RID: 8005 RVA: 0x0009EDC0 File Offset: 0x0009CFC0
		// (set) Token: 0x06001F46 RID: 8006 RVA: 0x0009EDC8 File Offset: 0x0009CFC8
		[ProtoMember(4, IsRequired = true, Name = "Desc", DataFormat = DataFormat.Default)]
		public string Desc
		{
			get
			{
				return this._Desc;
			}
			set
			{
				this._Desc = value;
			}
		}

		// Token: 0x17000664 RID: 1636
		// (get) Token: 0x06001F47 RID: 8007 RVA: 0x0009EDD4 File Offset: 0x0009CFD4
		// (set) Token: 0x06001F48 RID: 8008 RVA: 0x0009EDDC File Offset: 0x0009CFDC
		[ProtoMember(5, IsRequired = true, Name = "IsDebuff", DataFormat = DataFormat.Default)]
		public bool IsDebuff
		{
			get
			{
				return this._IsDebuff;
			}
			set
			{
				this._IsDebuff = value;
			}
		}

		// Token: 0x17000665 RID: 1637
		// (get) Token: 0x06001F49 RID: 8009 RVA: 0x0009EDE8 File Offset: 0x0009CFE8
		// (set) Token: 0x06001F4A RID: 8010 RVA: 0x0009EDF0 File Offset: 0x0009CFF0
		[ProtoMember(6, IsRequired = true, Name = "IsEnhance", DataFormat = DataFormat.Default)]
		public bool IsEnhance
		{
			get
			{
				return this._IsEnhance;
			}
			set
			{
				this._IsEnhance = value;
			}
		}

		// Token: 0x17000666 RID: 1638
		// (get) Token: 0x06001F4B RID: 8011 RVA: 0x0009EDFC File Offset: 0x0009CFFC
		// (set) Token: 0x06001F4C RID: 8012 RVA: 0x0009EE04 File Offset: 0x0009D004
		[ProtoMember(7, IsRequired = true, Name = "Time", DataFormat = DataFormat.TwosComplement)]
		public int Time
		{
			get
			{
				return this._Time;
			}
			set
			{
				this._Time = value;
			}
		}

		// Token: 0x17000667 RID: 1639
		// (get) Token: 0x06001F4D RID: 8013 RVA: 0x0009EE10 File Offset: 0x0009D010
		// (set) Token: 0x06001F4E RID: 8014 RVA: 0x0009EE18 File Offset: 0x0009D018
		[ProtoMember(8, IsRequired = true, Name = "Cond_HP_Target", DataFormat = DataFormat.TwosComplement)]
		public int Cond_HP_Target
		{
			get
			{
				return this._Cond_HP_Target;
			}
			set
			{
				this._Cond_HP_Target = value;
			}
		}

		// Token: 0x17000668 RID: 1640
		// (get) Token: 0x06001F4F RID: 8015 RVA: 0x0009EE24 File Offset: 0x0009D024
		// (set) Token: 0x06001F50 RID: 8016 RVA: 0x0009EE2C File Offset: 0x0009D02C
		[ProtoMember(9, IsRequired = true, Name = "Cond_HP_Operator", DataFormat = DataFormat.TwosComplement)]
		public int Cond_HP_Operator
		{
			get
			{
				return this._Cond_HP_Operator;
			}
			set
			{
				this._Cond_HP_Operator = value;
			}
		}

		// Token: 0x17000669 RID: 1641
		// (get) Token: 0x06001F51 RID: 8017 RVA: 0x0009EE38 File Offset: 0x0009D038
		// (set) Token: 0x06001F52 RID: 8018 RVA: 0x0009EE40 File Offset: 0x0009D040
		[ProtoMember(10, IsRequired = true, Name = "Cond_HP_Value", DataFormat = DataFormat.TwosComplement)]
		public int Cond_HP_Value
		{
			get
			{
				return this._Cond_HP_Value;
			}
			set
			{
				this._Cond_HP_Value = value;
			}
		}

		// Token: 0x1700066A RID: 1642
		// (get) Token: 0x06001F53 RID: 8019 RVA: 0x0009EE4C File Offset: 0x0009D04C
		// (set) Token: 0x06001F54 RID: 8020 RVA: 0x0009EE54 File Offset: 0x0009D054
		[ProtoMember(11, IsRequired = true, Name = "ConditionType", DataFormat = DataFormat.TwosComplement)]
		public BuffConditionType ConditionType
		{
			get
			{
				return this._ConditionType;
			}
			set
			{
				this._ConditionType = value;
			}
		}

		// Token: 0x1700066B RID: 1643
		// (get) Token: 0x06001F55 RID: 8021 RVA: 0x0009EE60 File Offset: 0x0009D060
		[ProtoMember(12, Name = "ConditionParam", DataFormat = DataFormat.TwosComplement)]
		public List<int> ConditionParam
		{
			get
			{
				return this._ConditionParam;
			}
		}

		// Token: 0x1700066C RID: 1644
		// (get) Token: 0x06001F56 RID: 8022 RVA: 0x0009EE68 File Offset: 0x0009D068
		// (set) Token: 0x06001F57 RID: 8023 RVA: 0x0009EE70 File Offset: 0x0009D070
		[ProtoMember(13, IsRequired = true, Name = "BuffType", DataFormat = DataFormat.TwosComplement)]
		public BuffType BuffType
		{
			get
			{
				return this._BuffType;
			}
			set
			{
				this._BuffType = value;
			}
		}

		// Token: 0x1700066D RID: 1645
		// (get) Token: 0x06001F58 RID: 8024 RVA: 0x0009EE7C File Offset: 0x0009D07C
		// (set) Token: 0x06001F59 RID: 8025 RVA: 0x0009EE84 File Offset: 0x0009D084
		[ProtoMember(14, IsRequired = true, Name = "BuffTypeParam1", DataFormat = DataFormat.TwosComplement)]
		public int BuffTypeParam1
		{
			get
			{
				return this._BuffTypeParam1;
			}
			set
			{
				this._BuffTypeParam1 = value;
			}
		}

		// Token: 0x1700066E RID: 1646
		// (get) Token: 0x06001F5A RID: 8026 RVA: 0x0009EE90 File Offset: 0x0009D090
		// (set) Token: 0x06001F5B RID: 8027 RVA: 0x0009EE98 File Offset: 0x0009D098
		[ProtoMember(15, IsRequired = true, Name = "BuffTypeParam2", DataFormat = DataFormat.TwosComplement)]
		public int BuffTypeParam2
		{
			get
			{
				return this._BuffTypeParam2;
			}
			set
			{
				this._BuffTypeParam2 = value;
			}
		}

		// Token: 0x1700066F RID: 1647
		// (get) Token: 0x06001F5C RID: 8028 RVA: 0x0009EEA4 File Offset: 0x0009D0A4
		// (set) Token: 0x06001F5D RID: 8029 RVA: 0x0009EEAC File Offset: 0x0009D0AC
		[ProtoMember(16, IsRequired = true, Name = "BuffTypeParam3", DataFormat = DataFormat.TwosComplement)]
		public int BuffTypeParam3
		{
			get
			{
				return this._BuffTypeParam3;
			}
			set
			{
				this._BuffTypeParam3 = value;
			}
		}

		// Token: 0x17000670 RID: 1648
		// (get) Token: 0x06001F5E RID: 8030 RVA: 0x0009EEB8 File Offset: 0x0009D0B8
		[ProtoMember(17, Name = "BuffTypeParam4", DataFormat = DataFormat.TwosComplement)]
		public List<int> BuffTypeParam4
		{
			get
			{
				return this._BuffTypeParam4;
			}
		}

		// Token: 0x17000671 RID: 1649
		// (get) Token: 0x06001F5F RID: 8031 RVA: 0x0009EEC0 File Offset: 0x0009D0C0
		// (set) Token: 0x06001F60 RID: 8032 RVA: 0x0009EEC8 File Offset: 0x0009D0C8
		[ProtoMember(18, IsRequired = true, Name = "BuffTypeParam5", DataFormat = DataFormat.TwosComplement)]
		public PropertyModifyType BuffTypeParam5
		{
			get
			{
				return this._BuffTypeParam5;
			}
			set
			{
				this._BuffTypeParam5 = value;
			}
		}

		// Token: 0x17000672 RID: 1650
		// (get) Token: 0x06001F61 RID: 8033 RVA: 0x0009EED4 File Offset: 0x0009D0D4
		[ProtoMember(19, Name = "BuffTypeParam6", DataFormat = DataFormat.TwosComplement)]
		public List<int> BuffTypeParam6
		{
			get
			{
				return this._BuffTypeParam6;
			}
		}

		// Token: 0x17000673 RID: 1651
		// (get) Token: 0x06001F62 RID: 8034 RVA: 0x0009EEDC File Offset: 0x0009D0DC
		// (set) Token: 0x06001F63 RID: 8035 RVA: 0x0009EEE4 File Offset: 0x0009D0E4
		[ProtoMember(20, IsRequired = true, Name = "SelfNoExtraTime", DataFormat = DataFormat.Default)]
		public bool SelfNoExtraTime
		{
			get
			{
				return this._SelfNoExtraTime;
			}
			set
			{
				this._SelfNoExtraTime = value;
			}
		}

		// Token: 0x17000674 RID: 1652
		// (get) Token: 0x06001F64 RID: 8036 RVA: 0x0009EEF0 File Offset: 0x0009D0F0
		// (set) Token: 0x06001F65 RID: 8037 RVA: 0x0009EEF8 File Offset: 0x0009D0F8
		[ProtoMember(21, IsRequired = true, Name = "SubType", DataFormat = DataFormat.TwosComplement)]
		public int SubType
		{
			get
			{
				return this._SubType;
			}
			set
			{
				this._SubType = value;
			}
		}

		// Token: 0x17000675 RID: 1653
		// (get) Token: 0x06001F66 RID: 8038 RVA: 0x0009EF04 File Offset: 0x0009D104
		// (set) Token: 0x06001F67 RID: 8039 RVA: 0x0009EF0C File Offset: 0x0009D10C
		[ProtoMember(22, IsRequired = true, Name = "ReplaceRule", DataFormat = DataFormat.TwosComplement)]
		public int ReplaceRule
		{
			get
			{
				return this._ReplaceRule;
			}
			set
			{
				this._ReplaceRule = value;
			}
		}

		// Token: 0x17000676 RID: 1654
		// (get) Token: 0x06001F68 RID: 8040 RVA: 0x0009EF18 File Offset: 0x0009D118
		// (set) Token: 0x06001F69 RID: 8041 RVA: 0x0009EF20 File Offset: 0x0009D120
		[ProtoMember(23, IsRequired = true, Name = "ReplacePriority", DataFormat = DataFormat.TwosComplement)]
		public int ReplacePriority
		{
			get
			{
				return this._ReplacePriority;
			}
			set
			{
				this._ReplacePriority = value;
			}
		}

		// Token: 0x17000677 RID: 1655
		// (get) Token: 0x06001F6A RID: 8042 RVA: 0x0009EF2C File Offset: 0x0009D12C
		[ProtoMember(24, Name = "FightTags", DataFormat = DataFormat.TwosComplement)]
		public List<FightTag> FightTags
		{
			get
			{
				return this._FightTags;
			}
		}

		// Token: 0x17000678 RID: 1656
		// (get) Token: 0x06001F6B RID: 8043 RVA: 0x0009EF34 File Offset: 0x0009D134
		// (set) Token: 0x06001F6C RID: 8044 RVA: 0x0009EF3C File Offset: 0x0009D13C
		[ProtoMember(25, IsRequired = true, Name = "Property1_ID", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17000679 RID: 1657
		// (get) Token: 0x06001F6D RID: 8045 RVA: 0x0009EF48 File Offset: 0x0009D148
		// (set) Token: 0x06001F6E RID: 8046 RVA: 0x0009EF50 File Offset: 0x0009D150
		[ProtoMember(26, IsRequired = true, Name = "Property1_Value", DataFormat = DataFormat.TwosComplement)]
		public int Property1_Value
		{
			get
			{
				return this._Property1_Value;
			}
			set
			{
				this._Property1_Value = value;
			}
		}

		// Token: 0x1700067A RID: 1658
		// (get) Token: 0x06001F6F RID: 8047 RVA: 0x0009EF5C File Offset: 0x0009D15C
		// (set) Token: 0x06001F70 RID: 8048 RVA: 0x0009EF64 File Offset: 0x0009D164
		[ProtoMember(27, IsRequired = true, Name = "Property2_ID", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x1700067B RID: 1659
		// (get) Token: 0x06001F71 RID: 8049 RVA: 0x0009EF70 File Offset: 0x0009D170
		// (set) Token: 0x06001F72 RID: 8050 RVA: 0x0009EF78 File Offset: 0x0009D178
		[ProtoMember(28, IsRequired = true, Name = "Property2_Value", DataFormat = DataFormat.TwosComplement)]
		public int Property2_Value
		{
			get
			{
				return this._Property2_Value;
			}
			set
			{
				this._Property2_Value = value;
			}
		}

		// Token: 0x1700067C RID: 1660
		// (get) Token: 0x06001F73 RID: 8051 RVA: 0x0009EF84 File Offset: 0x0009D184
		// (set) Token: 0x06001F74 RID: 8052 RVA: 0x0009EF8C File Offset: 0x0009D18C
		[ProtoMember(29, IsRequired = true, Name = "Property3_ID", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x1700067D RID: 1661
		// (get) Token: 0x06001F75 RID: 8053 RVA: 0x0009EF98 File Offset: 0x0009D198
		// (set) Token: 0x06001F76 RID: 8054 RVA: 0x0009EFA0 File Offset: 0x0009D1A0
		[ProtoMember(30, IsRequired = true, Name = "Property3_Value", DataFormat = DataFormat.TwosComplement)]
		public int Property3_Value
		{
			get
			{
				return this._Property3_Value;
			}
			set
			{
				this._Property3_Value = value;
			}
		}

		// Token: 0x1700067E RID: 1662
		// (get) Token: 0x06001F77 RID: 8055 RVA: 0x0009EFAC File Offset: 0x0009D1AC
		// (set) Token: 0x06001F78 RID: 8056 RVA: 0x0009EFB4 File Offset: 0x0009D1B4
		[ProtoMember(31, IsRequired = true, Name = "Property4_ID", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x1700067F RID: 1663
		// (get) Token: 0x06001F79 RID: 8057 RVA: 0x0009EFC0 File Offset: 0x0009D1C0
		// (set) Token: 0x06001F7A RID: 8058 RVA: 0x0009EFC8 File Offset: 0x0009D1C8
		[ProtoMember(32, IsRequired = true, Name = "Property4_Value", DataFormat = DataFormat.TwosComplement)]
		public int Property4_Value
		{
			get
			{
				return this._Property4_Value;
			}
			set
			{
				this._Property4_Value = value;
			}
		}

		// Token: 0x17000680 RID: 1664
		// (get) Token: 0x06001F7B RID: 8059 RVA: 0x0009EFD4 File Offset: 0x0009D1D4
		// (set) Token: 0x06001F7C RID: 8060 RVA: 0x0009EFDC File Offset: 0x0009D1DC
		[ProtoMember(33, IsRequired = true, Name = "CDBuff_ID", DataFormat = DataFormat.TwosComplement)]
		public int CDBuff_ID
		{
			get
			{
				return this._CDBuff_ID;
			}
			set
			{
				this._CDBuff_ID = value;
			}
		}

		// Token: 0x17000681 RID: 1665
		// (get) Token: 0x06001F7D RID: 8061 RVA: 0x0009EFE8 File Offset: 0x0009D1E8
		// (set) Token: 0x06001F7E RID: 8062 RVA: 0x0009EFF0 File Offset: 0x0009D1F0
		[ProtoMember(34, IsRequired = true, Name = "Effect_Attach", DataFormat = DataFormat.Default)]
		public string Effect_Attach
		{
			get
			{
				return this._Effect_Attach;
			}
			set
			{
				this._Effect_Attach = value;
			}
		}

		// Token: 0x17000682 RID: 1666
		// (get) Token: 0x06001F7F RID: 8063 RVA: 0x0009EFFC File Offset: 0x0009D1FC
		// (set) Token: 0x06001F80 RID: 8064 RVA: 0x0009F004 File Offset: 0x0009D204
		[ProtoMember(35, IsRequired = true, Name = "Effect_Process", DataFormat = DataFormat.Default)]
		public string Effect_Process
		{
			get
			{
				return this._Effect_Process;
			}
			set
			{
				this._Effect_Process = value;
			}
		}

		// Token: 0x17000683 RID: 1667
		// (get) Token: 0x06001F81 RID: 8065 RVA: 0x0009F010 File Offset: 0x0009D210
		// (set) Token: 0x06001F82 RID: 8066 RVA: 0x0009F018 File Offset: 0x0009D218
		[ProtoMember(36, IsRequired = true, Name = "Effect_Acting", DataFormat = DataFormat.Default)]
		public string Effect_Acting
		{
			get
			{
				return this._Effect_Acting;
			}
			set
			{
				this._Effect_Acting = value;
			}
		}

		// Token: 0x17000684 RID: 1668
		// (get) Token: 0x06001F83 RID: 8067 RVA: 0x0009F024 File Offset: 0x0009D224
		// (set) Token: 0x06001F84 RID: 8068 RVA: 0x0009F02C File Offset: 0x0009D22C
		[ProtoMember(37, IsRequired = true, Name = "Effect_ActingTarget", DataFormat = DataFormat.Default)]
		public string Effect_ActingTarget
		{
			get
			{
				return this._Effect_ActingTarget;
			}
			set
			{
				this._Effect_ActingTarget = value;
			}
		}

		// Token: 0x17000685 RID: 1669
		// (get) Token: 0x06001F85 RID: 8069 RVA: 0x0009F038 File Offset: 0x0009D238
		// (set) Token: 0x06001F86 RID: 8070 RVA: 0x0009F040 File Offset: 0x0009D240
		[ProtoMember(38, IsRequired = true, Name = "Icon", DataFormat = DataFormat.Default)]
		public string Icon
		{
			get
			{
				return this._Icon;
			}
			set
			{
				this._Icon = value;
			}
		}

		// Token: 0x17000686 RID: 1670
		// (get) Token: 0x06001F87 RID: 8071 RVA: 0x0009F04C File Offset: 0x0009D24C
		// (set) Token: 0x06001F88 RID: 8072 RVA: 0x0009F054 File Offset: 0x0009D254
		[ProtoMember(39, IsRequired = true, Name = "IconDisplay", DataFormat = DataFormat.Default)]
		public bool IconDisplay
		{
			get
			{
				return this._IconDisplay;
			}
			set
			{
				this._IconDisplay = value;
			}
		}

		// Token: 0x06001F89 RID: 8073 RVA: 0x0009F060 File Offset: 0x0009D260
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06001F8A RID: 8074 RVA: 0x0009F070 File Offset: 0x0009D270
		public bool IsAuraBuff()
		{
			return this.BuffType == BuffType.BuffType_HeroAura || this.BuffType == BuffType.BuffType_TagAura;
		}

		// Token: 0x06001F8B RID: 8075 RVA: 0x0009F08C File Offset: 0x0009D28C
		public bool IsInfiniteTime()
		{
			return this.Time >= 999;
		}

		// Token: 0x06001F8C RID: 8076 RVA: 0x0009F0A0 File Offset: 0x0009D2A0
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

		// Token: 0x06001F8D RID: 8077 RVA: 0x0009F16C File Offset: 0x0009D36C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataBuffInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040012DD RID: 4829
		private int _ID;

		// Token: 0x040012DE RID: 4830
		private string _Name;

		// Token: 0x040012DF RID: 4831
		private string _Desc;

		// Token: 0x040012E0 RID: 4832
		private bool _IsDebuff;

		// Token: 0x040012E1 RID: 4833
		private bool _IsEnhance;

		// Token: 0x040012E2 RID: 4834
		private int _Time;

		// Token: 0x040012E3 RID: 4835
		private int _Cond_HP_Target;

		// Token: 0x040012E4 RID: 4836
		private int _Cond_HP_Operator;

		// Token: 0x040012E5 RID: 4837
		private int _Cond_HP_Value;

		// Token: 0x040012E6 RID: 4838
		private BuffConditionType _ConditionType;

		// Token: 0x040012E7 RID: 4839
		private readonly List<int> _ConditionParam = new List<int>();

		// Token: 0x040012E8 RID: 4840
		private BuffType _BuffType;

		// Token: 0x040012E9 RID: 4841
		private int _BuffTypeParam1;

		// Token: 0x040012EA RID: 4842
		private int _BuffTypeParam2;

		// Token: 0x040012EB RID: 4843
		private int _BuffTypeParam3;

		// Token: 0x040012EC RID: 4844
		private readonly List<int> _BuffTypeParam4 = new List<int>();

		// Token: 0x040012ED RID: 4845
		private PropertyModifyType _BuffTypeParam5;

		// Token: 0x040012EE RID: 4846
		private readonly List<int> _BuffTypeParam6 = new List<int>();

		// Token: 0x040012EF RID: 4847
		private bool _SelfNoExtraTime;

		// Token: 0x040012F0 RID: 4848
		private int _SubType;

		// Token: 0x040012F1 RID: 4849
		private int _ReplaceRule;

		// Token: 0x040012F2 RID: 4850
		private int _ReplacePriority;

		// Token: 0x040012F3 RID: 4851
		private readonly List<FightTag> _FightTags = new List<FightTag>();

		// Token: 0x040012F4 RID: 4852
		private PropertyModifyType _Property1_ID;

		// Token: 0x040012F5 RID: 4853
		private int _Property1_Value;

		// Token: 0x040012F6 RID: 4854
		private PropertyModifyType _Property2_ID;

		// Token: 0x040012F7 RID: 4855
		private int _Property2_Value;

		// Token: 0x040012F8 RID: 4856
		private PropertyModifyType _Property3_ID;

		// Token: 0x040012F9 RID: 4857
		private int _Property3_Value;

		// Token: 0x040012FA RID: 4858
		private PropertyModifyType _Property4_ID;

		// Token: 0x040012FB RID: 4859
		private int _Property4_Value;

		// Token: 0x040012FC RID: 4860
		private int _CDBuff_ID;

		// Token: 0x040012FD RID: 4861
		private string _Effect_Attach;

		// Token: 0x040012FE RID: 4862
		private string _Effect_Process;

		// Token: 0x040012FF RID: 4863
		private string _Effect_Acting;

		// Token: 0x04001300 RID: 4864
		private string _Effect_ActingTarget;

		// Token: 0x04001301 RID: 4865
		private string _Icon;

		// Token: 0x04001302 RID: 4866
		private bool _IconDisplay;

		// Token: 0x04001303 RID: 4867
		private IExtension extensionObject;

		// Token: 0x04001304 RID: 4868
		public ConfigDataBuffInfo m_cdBuffInfo;

		// Token: 0x04001305 RID: 4869
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04001306 RID: 4870
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04001307 RID: 4871
		private LuaFunction m_ctor_hotfix;
	}
}
