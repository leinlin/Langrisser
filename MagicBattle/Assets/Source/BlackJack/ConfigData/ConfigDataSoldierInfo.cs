using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x0200028D RID: 653
	[HotFix(true, m_isCtorOnly = true)]
	[CustomLuaClass]
	[ProtoContract(Name = "ConfigDataSoldierInfo")]
	[Serializable]
	public class ConfigDataSoldierInfo : IExtensible
	{
		// Token: 0x06002AC0 RID: 10944 RVA: 0x000B1BDC File Offset: 0x000AFDDC
		public ConfigDataSoldierInfo()
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

		// Token: 0x17000B96 RID: 2966
		// (get) Token: 0x06002AC1 RID: 10945 RVA: 0x000B1C7C File Offset: 0x000AFE7C
		// (set) Token: 0x06002AC2 RID: 10946 RVA: 0x000B1C84 File Offset: 0x000AFE84
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

		// Token: 0x17000B97 RID: 2967
		// (get) Token: 0x06002AC3 RID: 10947 RVA: 0x000B1C90 File Offset: 0x000AFE90
		// (set) Token: 0x06002AC4 RID: 10948 RVA: 0x000B1C98 File Offset: 0x000AFE98
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

		// Token: 0x17000B98 RID: 2968
		// (get) Token: 0x06002AC5 RID: 10949 RVA: 0x000B1CA4 File Offset: 0x000AFEA4
		// (set) Token: 0x06002AC6 RID: 10950 RVA: 0x000B1CAC File Offset: 0x000AFEAC
		[ProtoMember(4, IsRequired = true, Name = "NameStrKey", DataFormat = DataFormat.Default)]
		public string NameStrKey
		{
			get
			{
				return this._NameStrKey;
			}
			set
			{
				this._NameStrKey = value;
			}
		}

		// Token: 0x17000B99 RID: 2969
		// (get) Token: 0x06002AC7 RID: 10951 RVA: 0x000B1CB8 File Offset: 0x000AFEB8
		// (set) Token: 0x06002AC8 RID: 10952 RVA: 0x000B1CC0 File Offset: 0x000AFEC0
		[ProtoMember(5, IsRequired = true, Name = "Desc", DataFormat = DataFormat.Default)]
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

		// Token: 0x17000B9A RID: 2970
		// (get) Token: 0x06002AC9 RID: 10953 RVA: 0x000B1CCC File Offset: 0x000AFECC
		// (set) Token: 0x06002ACA RID: 10954 RVA: 0x000B1CD4 File Offset: 0x000AFED4
		[ProtoMember(6, IsRequired = true, Name = "DescStrKey", DataFormat = DataFormat.Default)]
		public string DescStrKey
		{
			get
			{
				return this._DescStrKey;
			}
			set
			{
				this._DescStrKey = value;
			}
		}

		// Token: 0x17000B9B RID: 2971
		// (get) Token: 0x06002ACB RID: 10955 RVA: 0x000B1CE0 File Offset: 0x000AFEE0
		// (set) Token: 0x06002ACC RID: 10956 RVA: 0x000B1CE8 File Offset: 0x000AFEE8
		[ProtoMember(7, IsRequired = true, Name = "Strong", DataFormat = DataFormat.Default)]
		public string Strong
		{
			get
			{
				return this._Strong;
			}
			set
			{
				this._Strong = value;
			}
		}

		// Token: 0x17000B9C RID: 2972
		// (get) Token: 0x06002ACD RID: 10957 RVA: 0x000B1CF4 File Offset: 0x000AFEF4
		// (set) Token: 0x06002ACE RID: 10958 RVA: 0x000B1CFC File Offset: 0x000AFEFC
		[ProtoMember(8, IsRequired = true, Name = "StrongStrKey", DataFormat = DataFormat.Default)]
		public string StrongStrKey
		{
			get
			{
				return this._StrongStrKey;
			}
			set
			{
				this._StrongStrKey = value;
			}
		}

		// Token: 0x17000B9D RID: 2973
		// (get) Token: 0x06002ACF RID: 10959 RVA: 0x000B1D08 File Offset: 0x000AFF08
		// (set) Token: 0x06002AD0 RID: 10960 RVA: 0x000B1D10 File Offset: 0x000AFF10
		[ProtoMember(9, IsRequired = true, Name = "Weak", DataFormat = DataFormat.Default)]
		public string Weak
		{
			get
			{
				return this._Weak;
			}
			set
			{
				this._Weak = value;
			}
		}

		// Token: 0x17000B9E RID: 2974
		// (get) Token: 0x06002AD1 RID: 10961 RVA: 0x000B1D1C File Offset: 0x000AFF1C
		// (set) Token: 0x06002AD2 RID: 10962 RVA: 0x000B1D24 File Offset: 0x000AFF24
		[ProtoMember(10, IsRequired = true, Name = "WeakStrKey", DataFormat = DataFormat.Default)]
		public string WeakStrKey
		{
			get
			{
				return this._WeakStrKey;
			}
			set
			{
				this._WeakStrKey = value;
			}
		}

		// Token: 0x17000B9F RID: 2975
		// (get) Token: 0x06002AD3 RID: 10963 RVA: 0x000B1D30 File Offset: 0x000AFF30
		// (set) Token: 0x06002AD4 RID: 10964 RVA: 0x000B1D38 File Offset: 0x000AFF38
		[ProtoMember(11, IsRequired = true, Name = "Radius", DataFormat = DataFormat.TwosComplement)]
		public int Radius
		{
			get
			{
				return this._Radius;
			}
			set
			{
				this._Radius = value;
			}
		}

		// Token: 0x17000BA0 RID: 2976
		// (get) Token: 0x06002AD5 RID: 10965 RVA: 0x000B1D44 File Offset: 0x000AFF44
		// (set) Token: 0x06002AD6 RID: 10966 RVA: 0x000B1D4C File Offset: 0x000AFF4C
		[ProtoMember(12, IsRequired = true, Name = "Height", DataFormat = DataFormat.TwosComplement)]
		public int Height
		{
			get
			{
				return this._Height;
			}
			set
			{
				this._Height = value;
			}
		}

		// Token: 0x17000BA1 RID: 2977
		// (get) Token: 0x06002AD7 RID: 10967 RVA: 0x000B1D58 File Offset: 0x000AFF58
		// (set) Token: 0x06002AD8 RID: 10968 RVA: 0x000B1D60 File Offset: 0x000AFF60
		[ProtoMember(13, IsRequired = true, Name = "FootHeight", DataFormat = DataFormat.TwosComplement)]
		public int FootHeight
		{
			get
			{
				return this._FootHeight;
			}
			set
			{
				this._FootHeight = value;
			}
		}

		// Token: 0x17000BA2 RID: 2978
		// (get) Token: 0x06002AD9 RID: 10969 RVA: 0x000B1D6C File Offset: 0x000AFF6C
		[ProtoMember(14, Name = "Skills_ID", DataFormat = DataFormat.TwosComplement)]
		public List<int> Skills_ID
		{
			get
			{
				return this._Skills_ID;
			}
		}

		// Token: 0x17000BA3 RID: 2979
		// (get) Token: 0x06002ADA RID: 10970 RVA: 0x000B1D74 File Offset: 0x000AFF74
		[ProtoMember(15, Name = "Old_Buffs_ID", DataFormat = DataFormat.TwosComplement)]
		public List<int> Old_Buffs_ID
		{
			get
			{
				return this._Old_Buffs_ID;
			}
		}

		// Token: 0x17000BA4 RID: 2980
		// (get) Token: 0x06002ADB RID: 10971 RVA: 0x000B1D7C File Offset: 0x000AFF7C
		// (set) Token: 0x06002ADC RID: 10972 RVA: 0x000B1D84 File Offset: 0x000AFF84
		[ProtoMember(16, IsRequired = true, Name = "Army_ID", DataFormat = DataFormat.TwosComplement)]
		public int Army_ID
		{
			get
			{
				return this._Army_ID;
			}
			set
			{
				this._Army_ID = value;
			}
		}

		// Token: 0x17000BA5 RID: 2981
		// (get) Token: 0x06002ADD RID: 10973 RVA: 0x000B1D90 File Offset: 0x000AFF90
		// (set) Token: 0x06002ADE RID: 10974 RVA: 0x000B1D98 File Offset: 0x000AFF98
		[ProtoMember(17, IsRequired = true, Name = "IsMelee", DataFormat = DataFormat.Default)]
		public bool IsMelee
		{
			get
			{
				return this._IsMelee;
			}
			set
			{
				this._IsMelee = value;
			}
		}

		// Token: 0x17000BA6 RID: 2982
		// (get) Token: 0x06002ADF RID: 10975 RVA: 0x000B1DA4 File Offset: 0x000AFFA4
		// (set) Token: 0x06002AE0 RID: 10976 RVA: 0x000B1DAC File Offset: 0x000AFFAC
		[ProtoMember(18, IsRequired = true, Name = "MoveType", DataFormat = DataFormat.TwosComplement)]
		public MoveType MoveType
		{
			get
			{
				return this._MoveType;
			}
			set
			{
				this._MoveType = value;
			}
		}

		// Token: 0x17000BA7 RID: 2983
		// (get) Token: 0x06002AE1 RID: 10977 RVA: 0x000B1DB8 File Offset: 0x000AFFB8
		// (set) Token: 0x06002AE2 RID: 10978 RVA: 0x000B1DC0 File Offset: 0x000AFFC0
		[ProtoMember(19, IsRequired = true, Name = "BF_AttackDistance", DataFormat = DataFormat.TwosComplement)]
		public int BF_AttackDistance
		{
			get
			{
				return this._BF_AttackDistance;
			}
			set
			{
				this._BF_AttackDistance = value;
			}
		}

		// Token: 0x17000BA8 RID: 2984
		// (get) Token: 0x06002AE3 RID: 10979 RVA: 0x000B1DCC File Offset: 0x000AFFCC
		// (set) Token: 0x06002AE4 RID: 10980 RVA: 0x000B1DD4 File Offset: 0x000AFFD4
		[ProtoMember(20, IsRequired = true, Name = "MeleeATK_ID", DataFormat = DataFormat.TwosComplement)]
		public int MeleeATK_ID
		{
			get
			{
				return this._MeleeATK_ID;
			}
			set
			{
				this._MeleeATK_ID = value;
			}
		}

		// Token: 0x17000BA9 RID: 2985
		// (get) Token: 0x06002AE5 RID: 10981 RVA: 0x000B1DE0 File Offset: 0x000AFFE0
		// (set) Token: 0x06002AE6 RID: 10982 RVA: 0x000B1DE8 File Offset: 0x000AFFE8
		[ProtoMember(21, IsRequired = true, Name = "RangeATK_ID", DataFormat = DataFormat.TwosComplement)]
		public int RangeATK_ID
		{
			get
			{
				return this._RangeATK_ID;
			}
			set
			{
				this._RangeATK_ID = value;
			}
		}

		// Token: 0x17000BAA RID: 2986
		// (get) Token: 0x06002AE7 RID: 10983 RVA: 0x000B1DF4 File Offset: 0x000AFFF4
		// (set) Token: 0x06002AE8 RID: 10984 RVA: 0x000B1DFC File Offset: 0x000AFFFC
		[ProtoMember(22, IsRequired = true, Name = "AttackSPD_INI", DataFormat = DataFormat.TwosComplement)]
		public int AttackSPD_INI
		{
			get
			{
				return this._AttackSPD_INI;
			}
			set
			{
				this._AttackSPD_INI = value;
			}
		}

		// Token: 0x17000BAB RID: 2987
		// (get) Token: 0x06002AE9 RID: 10985 RVA: 0x000B1E08 File Offset: 0x000B0008
		// (set) Token: 0x06002AEA RID: 10986 RVA: 0x000B1E10 File Offset: 0x000B0010
		[ProtoMember(23, IsRequired = true, Name = "MoveSPD_INI", DataFormat = DataFormat.TwosComplement)]
		public int MoveSPD_INI
		{
			get
			{
				return this._MoveSPD_INI;
			}
			set
			{
				this._MoveSPD_INI = value;
			}
		}

		// Token: 0x17000BAC RID: 2988
		// (get) Token: 0x06002AEB RID: 10987 RVA: 0x000B1E1C File Offset: 0x000B001C
		// (set) Token: 0x06002AEC RID: 10988 RVA: 0x000B1E24 File Offset: 0x000B0024
		[ProtoMember(24, IsRequired = true, Name = "HP_INI", DataFormat = DataFormat.TwosComplement)]
		public int HP_INI
		{
			get
			{
				return this._HP_INI;
			}
			set
			{
				this._HP_INI = value;
			}
		}

		// Token: 0x17000BAD RID: 2989
		// (get) Token: 0x06002AED RID: 10989 RVA: 0x000B1E30 File Offset: 0x000B0030
		// (set) Token: 0x06002AEE RID: 10990 RVA: 0x000B1E38 File Offset: 0x000B0038
		[ProtoMember(25, IsRequired = true, Name = "AT_INI", DataFormat = DataFormat.TwosComplement)]
		public int AT_INI
		{
			get
			{
				return this._AT_INI;
			}
			set
			{
				this._AT_INI = value;
			}
		}

		// Token: 0x17000BAE RID: 2990
		// (get) Token: 0x06002AEF RID: 10991 RVA: 0x000B1E44 File Offset: 0x000B0044
		// (set) Token: 0x06002AF0 RID: 10992 RVA: 0x000B1E4C File Offset: 0x000B004C
		[ProtoMember(26, IsRequired = true, Name = "DF_INI", DataFormat = DataFormat.TwosComplement)]
		public int DF_INI
		{
			get
			{
				return this._DF_INI;
			}
			set
			{
				this._DF_INI = value;
			}
		}

		// Token: 0x17000BAF RID: 2991
		// (get) Token: 0x06002AF1 RID: 10993 RVA: 0x000B1E58 File Offset: 0x000B0058
		// (set) Token: 0x06002AF2 RID: 10994 RVA: 0x000B1E60 File Offset: 0x000B0060
		[ProtoMember(27, IsRequired = true, Name = "MagicDF_INI", DataFormat = DataFormat.TwosComplement)]
		public int MagicDF_INI
		{
			get
			{
				return this._MagicDF_INI;
			}
			set
			{
				this._MagicDF_INI = value;
			}
		}

		// Token: 0x17000BB0 RID: 2992
		// (get) Token: 0x06002AF3 RID: 10995 RVA: 0x000B1E6C File Offset: 0x000B006C
		// (set) Token: 0x06002AF4 RID: 10996 RVA: 0x000B1E74 File Offset: 0x000B0074
		[ProtoMember(28, IsRequired = true, Name = "HP_UP", DataFormat = DataFormat.TwosComplement)]
		public int HP_UP
		{
			get
			{
				return this._HP_UP;
			}
			set
			{
				this._HP_UP = value;
			}
		}

		// Token: 0x17000BB1 RID: 2993
		// (get) Token: 0x06002AF5 RID: 10997 RVA: 0x000B1E80 File Offset: 0x000B0080
		// (set) Token: 0x06002AF6 RID: 10998 RVA: 0x000B1E88 File Offset: 0x000B0088
		[ProtoMember(29, IsRequired = true, Name = "AT_UP", DataFormat = DataFormat.TwosComplement)]
		public int AT_UP
		{
			get
			{
				return this._AT_UP;
			}
			set
			{
				this._AT_UP = value;
			}
		}

		// Token: 0x17000BB2 RID: 2994
		// (get) Token: 0x06002AF7 RID: 10999 RVA: 0x000B1E94 File Offset: 0x000B0094
		// (set) Token: 0x06002AF8 RID: 11000 RVA: 0x000B1E9C File Offset: 0x000B009C
		[ProtoMember(30, IsRequired = true, Name = "DF_UP", DataFormat = DataFormat.TwosComplement)]
		public int DF_UP
		{
			get
			{
				return this._DF_UP;
			}
			set
			{
				this._DF_UP = value;
			}
		}

		// Token: 0x17000BB3 RID: 2995
		// (get) Token: 0x06002AF9 RID: 11001 RVA: 0x000B1EA8 File Offset: 0x000B00A8
		// (set) Token: 0x06002AFA RID: 11002 RVA: 0x000B1EB0 File Offset: 0x000B00B0
		[ProtoMember(31, IsRequired = true, Name = "MagicDF_UP", DataFormat = DataFormat.TwosComplement)]
		public int MagicDF_UP
		{
			get
			{
				return this._MagicDF_UP;
			}
			set
			{
				this._MagicDF_UP = value;
			}
		}

		// Token: 0x17000BB4 RID: 2996
		// (get) Token: 0x06002AFB RID: 11003 RVA: 0x000B1EBC File Offset: 0x000B00BC
		// (set) Token: 0x06002AFC RID: 11004 RVA: 0x000B1EC4 File Offset: 0x000B00C4
		[ProtoMember(32, IsRequired = true, Name = "CriticalDamage", DataFormat = DataFormat.TwosComplement)]
		public int CriticalDamage
		{
			get
			{
				return this._CriticalDamage;
			}
			set
			{
				this._CriticalDamage = value;
			}
		}

		// Token: 0x17000BB5 RID: 2997
		// (get) Token: 0x06002AFD RID: 11005 RVA: 0x000B1ED0 File Offset: 0x000B00D0
		// (set) Token: 0x06002AFE RID: 11006 RVA: 0x000B1ED8 File Offset: 0x000B00D8
		[ProtoMember(33, IsRequired = true, Name = "CriticalRate", DataFormat = DataFormat.TwosComplement)]
		public int CriticalRate
		{
			get
			{
				return this._CriticalRate;
			}
			set
			{
				this._CriticalRate = value;
			}
		}

		// Token: 0x17000BB6 RID: 2998
		// (get) Token: 0x06002AFF RID: 11007 RVA: 0x000B1EE4 File Offset: 0x000B00E4
		// (set) Token: 0x06002B00 RID: 11008 RVA: 0x000B1EEC File Offset: 0x000B00EC
		[ProtoMember(34, IsRequired = true, Name = "BF_MovePoint", DataFormat = DataFormat.TwosComplement)]
		public int BF_MovePoint
		{
			get
			{
				return this._BF_MovePoint;
			}
			set
			{
				this._BF_MovePoint = value;
			}
		}

		// Token: 0x17000BB7 RID: 2999
		// (get) Token: 0x06002B01 RID: 11009 RVA: 0x000B1EF8 File Offset: 0x000B00F8
		// (set) Token: 0x06002B02 RID: 11010 RVA: 0x000B1F00 File Offset: 0x000B0100
		[ProtoMember(35, IsRequired = true, Name = "BattlePowerHP", DataFormat = DataFormat.TwosComplement)]
		public int BattlePowerHP
		{
			get
			{
				return this._BattlePowerHP;
			}
			set
			{
				this._BattlePowerHP = value;
			}
		}

		// Token: 0x17000BB8 RID: 3000
		// (get) Token: 0x06002B03 RID: 11011 RVA: 0x000B1F0C File Offset: 0x000B010C
		// (set) Token: 0x06002B04 RID: 11012 RVA: 0x000B1F14 File Offset: 0x000B0114
		[ProtoMember(36, IsRequired = true, Name = "BattlePowerAT", DataFormat = DataFormat.TwosComplement)]
		public int BattlePowerAT
		{
			get
			{
				return this._BattlePowerAT;
			}
			set
			{
				this._BattlePowerAT = value;
			}
		}

		// Token: 0x17000BB9 RID: 3001
		// (get) Token: 0x06002B05 RID: 11013 RVA: 0x000B1F20 File Offset: 0x000B0120
		// (set) Token: 0x06002B06 RID: 11014 RVA: 0x000B1F28 File Offset: 0x000B0128
		[ProtoMember(37, IsRequired = true, Name = "BattlePowerDF", DataFormat = DataFormat.TwosComplement)]
		public int BattlePowerDF
		{
			get
			{
				return this._BattlePowerDF;
			}
			set
			{
				this._BattlePowerDF = value;
			}
		}

		// Token: 0x17000BBA RID: 3002
		// (get) Token: 0x06002B07 RID: 11015 RVA: 0x000B1F34 File Offset: 0x000B0134
		// (set) Token: 0x06002B08 RID: 11016 RVA: 0x000B1F3C File Offset: 0x000B013C
		[ProtoMember(38, IsRequired = true, Name = "BattlePowerMagicDF", DataFormat = DataFormat.TwosComplement)]
		public int BattlePowerMagicDF
		{
			get
			{
				return this._BattlePowerMagicDF;
			}
			set
			{
				this._BattlePowerMagicDF = value;
			}
		}

		// Token: 0x17000BBB RID: 3003
		// (get) Token: 0x06002B09 RID: 11017 RVA: 0x000B1F48 File Offset: 0x000B0148
		// (set) Token: 0x06002B0A RID: 11018 RVA: 0x000B1F50 File Offset: 0x000B0150
		[ProtoMember(39, IsRequired = true, Name = "DieFlyDistanceMin", DataFormat = DataFormat.TwosComplement)]
		public int DieFlyDistanceMin
		{
			get
			{
				return this._DieFlyDistanceMin;
			}
			set
			{
				this._DieFlyDistanceMin = value;
			}
		}

		// Token: 0x17000BBC RID: 3004
		// (get) Token: 0x06002B0B RID: 11019 RVA: 0x000B1F5C File Offset: 0x000B015C
		// (set) Token: 0x06002B0C RID: 11020 RVA: 0x000B1F64 File Offset: 0x000B0164
		[ProtoMember(40, IsRequired = true, Name = "DieFlyDistanceMax", DataFormat = DataFormat.TwosComplement)]
		public int DieFlyDistanceMax
		{
			get
			{
				return this._DieFlyDistanceMax;
			}
			set
			{
				this._DieFlyDistanceMax = value;
			}
		}

		// Token: 0x17000BBD RID: 3005
		// (get) Token: 0x06002B0D RID: 11021 RVA: 0x000B1F70 File Offset: 0x000B0170
		// (set) Token: 0x06002B0E RID: 11022 RVA: 0x000B1F78 File Offset: 0x000B0178
		[ProtoMember(41, IsRequired = true, Name = "Model", DataFormat = DataFormat.Default)]
		public string Model
		{
			get
			{
				return this._Model;
			}
			set
			{
				this._Model = value;
			}
		}

		// Token: 0x17000BBE RID: 3006
		// (get) Token: 0x06002B0F RID: 11023 RVA: 0x000B1F84 File Offset: 0x000B0184
		// (set) Token: 0x06002B10 RID: 11024 RVA: 0x000B1F8C File Offset: 0x000B018C
		[ProtoMember(42, IsRequired = true, Name = "Model2", DataFormat = DataFormat.Default)]
		public string Model2
		{
			get
			{
				return this._Model2;
			}
			set
			{
				this._Model2 = value;
			}
		}

		// Token: 0x17000BBF RID: 3007
		// (get) Token: 0x06002B11 RID: 11025 RVA: 0x000B1F98 File Offset: 0x000B0198
		// (set) Token: 0x06002B12 RID: 11026 RVA: 0x000B1FA0 File Offset: 0x000B01A0
		[ProtoMember(43, IsRequired = true, Name = "CombatModel", DataFormat = DataFormat.Default)]
		public string CombatModel
		{
			get
			{
				return this._CombatModel;
			}
			set
			{
				this._CombatModel = value;
			}
		}

		// Token: 0x17000BC0 RID: 3008
		// (get) Token: 0x06002B13 RID: 11027 RVA: 0x000B1FAC File Offset: 0x000B01AC
		// (set) Token: 0x06002B14 RID: 11028 RVA: 0x000B1FB4 File Offset: 0x000B01B4
		[ProtoMember(44, IsRequired = true, Name = "CombatModel2", DataFormat = DataFormat.Default)]
		public string CombatModel2
		{
			get
			{
				return this._CombatModel2;
			}
			set
			{
				this._CombatModel2 = value;
			}
		}

		// Token: 0x17000BC1 RID: 3009
		// (get) Token: 0x06002B15 RID: 11029 RVA: 0x000B1FC0 File Offset: 0x000B01C0
		[ProtoMember(45, Name = "ReplaceAnims", DataFormat = DataFormat.Default)]
		public List<ReplaceAnim> ReplaceAnims
		{
			get
			{
				return this._ReplaceAnims;
			}
		}

		// Token: 0x17000BC2 RID: 3010
		// (get) Token: 0x06002B16 RID: 11030 RVA: 0x000B1FC8 File Offset: 0x000B01C8
		// (set) Token: 0x06002B17 RID: 11031 RVA: 0x000B1FD0 File Offset: 0x000B01D0
		[ProtoMember(46, IsRequired = true, Name = "ModelScale", DataFormat = DataFormat.TwosComplement)]
		public int ModelScale
		{
			get
			{
				return this._ModelScale;
			}
			set
			{
				this._ModelScale = value;
			}
		}

		// Token: 0x17000BC3 RID: 3011
		// (get) Token: 0x06002B18 RID: 11032 RVA: 0x000B1FDC File Offset: 0x000B01DC
		// (set) Token: 0x06002B19 RID: 11033 RVA: 0x000B1FE4 File Offset: 0x000B01E4
		[ProtoMember(47, IsRequired = true, Name = "BF_ModelScale", DataFormat = DataFormat.TwosComplement)]
		public int BF_ModelScale
		{
			get
			{
				return this._BF_ModelScale;
			}
			set
			{
				this._BF_ModelScale = value;
			}
		}

		// Token: 0x17000BC4 RID: 3012
		// (get) Token: 0x06002B1A RID: 11034 RVA: 0x000B1FF0 File Offset: 0x000B01F0
		// (set) Token: 0x06002B1B RID: 11035 RVA: 0x000B1FF8 File Offset: 0x000B01F8
		[ProtoMember(48, IsRequired = true, Name = "UI_ModelScale", DataFormat = DataFormat.TwosComplement)]
		public int UI_ModelScale
		{
			get
			{
				return this._UI_ModelScale;
			}
			set
			{
				this._UI_ModelScale = value;
			}
		}

		// Token: 0x17000BC5 RID: 3013
		// (get) Token: 0x06002B1C RID: 11036 RVA: 0x000B2004 File Offset: 0x000B0204
		// (set) Token: 0x06002B1D RID: 11037 RVA: 0x000B200C File Offset: 0x000B020C
		[ProtoMember(49, IsRequired = true, Name = "UI_ModelOffsetX", DataFormat = DataFormat.TwosComplement)]
		public int UI_ModelOffsetX
		{
			get
			{
				return this._UI_ModelOffsetX;
			}
			set
			{
				this._UI_ModelOffsetX = value;
			}
		}

		// Token: 0x17000BC6 RID: 3014
		// (get) Token: 0x06002B1E RID: 11038 RVA: 0x000B2018 File Offset: 0x000B0218
		// (set) Token: 0x06002B1F RID: 11039 RVA: 0x000B2020 File Offset: 0x000B0220
		[ProtoMember(50, IsRequired = true, Name = "UI_ModelOffsetY", DataFormat = DataFormat.TwosComplement)]
		public int UI_ModelOffsetY
		{
			get
			{
				return this._UI_ModelOffsetY;
			}
			set
			{
				this._UI_ModelOffsetY = value;
			}
		}

		// Token: 0x17000BC7 RID: 3015
		// (get) Token: 0x06002B20 RID: 11040 RVA: 0x000B202C File Offset: 0x000B022C
		// (set) Token: 0x06002B21 RID: 11041 RVA: 0x000B2034 File Offset: 0x000B0234
		[ProtoMember(51, IsRequired = true, Name = "Sound_Enter", DataFormat = DataFormat.Default)]
		public string Sound_Enter
		{
			get
			{
				return this._Sound_Enter;
			}
			set
			{
				this._Sound_Enter = value;
			}
		}

		// Token: 0x17000BC8 RID: 3016
		// (get) Token: 0x06002B22 RID: 11042 RVA: 0x000B2040 File Offset: 0x000B0240
		// (set) Token: 0x06002B23 RID: 11043 RVA: 0x000B2048 File Offset: 0x000B0248
		[ProtoMember(52, IsRequired = true, Name = "Sound_Die", DataFormat = DataFormat.Default)]
		public string Sound_Die
		{
			get
			{
				return this._Sound_Die;
			}
			set
			{
				this._Sound_Die = value;
			}
		}

		// Token: 0x17000BC9 RID: 3017
		// (get) Token: 0x06002B24 RID: 11044 RVA: 0x000B2054 File Offset: 0x000B0254
		// (set) Token: 0x06002B25 RID: 11045 RVA: 0x000B205C File Offset: 0x000B025C
		[ProtoMember(53, IsRequired = true, Name = "Rank", DataFormat = DataFormat.TwosComplement)]
		public int Rank
		{
			get
			{
				return this._Rank;
			}
			set
			{
				this._Rank = value;
			}
		}

		// Token: 0x17000BCA RID: 3018
		// (get) Token: 0x06002B26 RID: 11046 RVA: 0x000B2068 File Offset: 0x000B0268
		// (set) Token: 0x06002B27 RID: 11047 RVA: 0x000B2070 File Offset: 0x000B0270
		[ProtoMember(54, IsRequired = true, Name = "IsEnemy", DataFormat = DataFormat.Default)]
		public bool IsEnemy
		{
			get
			{
				return this._IsEnemy;
			}
			set
			{
				this._IsEnemy = value;
			}
		}

		// Token: 0x17000BCB RID: 3019
		// (get) Token: 0x06002B28 RID: 11048 RVA: 0x000B207C File Offset: 0x000B027C
		// (set) Token: 0x06002B29 RID: 11049 RVA: 0x000B2084 File Offset: 0x000B0284
		[ProtoMember(55, IsRequired = true, Name = "GetSoldierDesc", DataFormat = DataFormat.Default)]
		public string GetSoldierDesc
		{
			get
			{
				return this._GetSoldierDesc;
			}
			set
			{
				this._GetSoldierDesc = value;
			}
		}

		// Token: 0x17000BCC RID: 3020
		// (get) Token: 0x06002B2A RID: 11050 RVA: 0x000B2090 File Offset: 0x000B0290
		[ProtoMember(56, Name = "GetSoldierHeros_ID", DataFormat = DataFormat.TwosComplement)]
		public List<int> GetSoldierHeros_ID
		{
			get
			{
				return this._GetSoldierHeros_ID;
			}
		}

		// Token: 0x17000BCD RID: 3021
		// (get) Token: 0x06002B2B RID: 11051 RVA: 0x000B2098 File Offset: 0x000B0298
		// (set) Token: 0x06002B2C RID: 11052 RVA: 0x000B20A0 File Offset: 0x000B02A0
		[ProtoMember(57, IsRequired = true, Name = "GetSoldierTechId", DataFormat = DataFormat.TwosComplement)]
		public int GetSoldierTechId
		{
			get
			{
				return this._GetSoldierTechId;
			}
			set
			{
				this._GetSoldierTechId = value;
			}
		}

		// Token: 0x17000BCE RID: 3022
		// (get) Token: 0x06002B2D RID: 11053 RVA: 0x000B20AC File Offset: 0x000B02AC
		[ProtoMember(58, Name = "SoldierSkins_ID", DataFormat = DataFormat.TwosComplement)]
		public List<int> SoldierSkins_ID
		{
			get
			{
				return this._SoldierSkins_ID;
			}
		}

		// Token: 0x06002B2E RID: 11054 RVA: 0x000B20B4 File Offset: 0x000B02B4
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002B2F RID: 11055 RVA: 0x000B20C4 File Offset: 0x000B02C4
		public ConfigDataSkillInfo GetLevelUpSkillInfo(int skillLevelUp)
		{
			if (this.m_skillInfos != null && this.m_skillInfos.Length > 0)
			{
				int num = skillLevelUp - 1;
				if (num < 0)
				{
					num = 0;
				}
				if (num >= this.m_skillInfos.Length)
				{
					num = this.m_skillInfos.Length - 1;
				}
				return this.m_skillInfos[num];
			}
			return null;
		}

		// Token: 0x06002B30 RID: 11056 RVA: 0x000B211C File Offset: 0x000B031C
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

		// Token: 0x06002B31 RID: 11057 RVA: 0x000B21E8 File Offset: 0x000B03E8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataSoldierInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04001A4D RID: 6733
		private int _ID;

		// Token: 0x04001A4E RID: 6734
		private string _Name;

		// Token: 0x04001A4F RID: 6735
		private string _NameStrKey;

		// Token: 0x04001A50 RID: 6736
		private string _Desc;

		// Token: 0x04001A51 RID: 6737
		private string _DescStrKey;

		// Token: 0x04001A52 RID: 6738
		private string _Strong;

		// Token: 0x04001A53 RID: 6739
		private string _StrongStrKey;

		// Token: 0x04001A54 RID: 6740
		private string _Weak;

		// Token: 0x04001A55 RID: 6741
		private string _WeakStrKey;

		// Token: 0x04001A56 RID: 6742
		private int _Radius;

		// Token: 0x04001A57 RID: 6743
		private int _Height;

		// Token: 0x04001A58 RID: 6744
		private int _FootHeight;

		// Token: 0x04001A59 RID: 6745
		private readonly List<int> _Skills_ID = new List<int>();

		// Token: 0x04001A5A RID: 6746
		private readonly List<int> _Old_Buffs_ID = new List<int>();

		// Token: 0x04001A5B RID: 6747
		private int _Army_ID;

		// Token: 0x04001A5C RID: 6748
		private bool _IsMelee;

		// Token: 0x04001A5D RID: 6749
		private MoveType _MoveType;

		// Token: 0x04001A5E RID: 6750
		private int _BF_AttackDistance;

		// Token: 0x04001A5F RID: 6751
		private int _MeleeATK_ID;

		// Token: 0x04001A60 RID: 6752
		private int _RangeATK_ID;

		// Token: 0x04001A61 RID: 6753
		private int _AttackSPD_INI;

		// Token: 0x04001A62 RID: 6754
		private int _MoveSPD_INI;

		// Token: 0x04001A63 RID: 6755
		private int _HP_INI;

		// Token: 0x04001A64 RID: 6756
		private int _AT_INI;

		// Token: 0x04001A65 RID: 6757
		private int _DF_INI;

		// Token: 0x04001A66 RID: 6758
		private int _MagicDF_INI;

		// Token: 0x04001A67 RID: 6759
		private int _HP_UP;

		// Token: 0x04001A68 RID: 6760
		private int _AT_UP;

		// Token: 0x04001A69 RID: 6761
		private int _DF_UP;

		// Token: 0x04001A6A RID: 6762
		private int _MagicDF_UP;

		// Token: 0x04001A6B RID: 6763
		private int _CriticalDamage;

		// Token: 0x04001A6C RID: 6764
		private int _CriticalRate;

		// Token: 0x04001A6D RID: 6765
		private int _BF_MovePoint;

		// Token: 0x04001A6E RID: 6766
		private int _BattlePowerHP;

		// Token: 0x04001A6F RID: 6767
		private int _BattlePowerAT;

		// Token: 0x04001A70 RID: 6768
		private int _BattlePowerDF;

		// Token: 0x04001A71 RID: 6769
		private int _BattlePowerMagicDF;

		// Token: 0x04001A72 RID: 6770
		private int _DieFlyDistanceMin;

		// Token: 0x04001A73 RID: 6771
		private int _DieFlyDistanceMax;

		// Token: 0x04001A74 RID: 6772
		private string _Model;

		// Token: 0x04001A75 RID: 6773
		private string _Model2;

		// Token: 0x04001A76 RID: 6774
		private string _CombatModel;

		// Token: 0x04001A77 RID: 6775
		private string _CombatModel2;

		// Token: 0x04001A78 RID: 6776
		private readonly List<ReplaceAnim> _ReplaceAnims = new List<ReplaceAnim>();

		// Token: 0x04001A79 RID: 6777
		private int _ModelScale;

		// Token: 0x04001A7A RID: 6778
		private int _BF_ModelScale;

		// Token: 0x04001A7B RID: 6779
		private int _UI_ModelScale;

		// Token: 0x04001A7C RID: 6780
		private int _UI_ModelOffsetX;

		// Token: 0x04001A7D RID: 6781
		private int _UI_ModelOffsetY;

		// Token: 0x04001A7E RID: 6782
		private string _Sound_Enter;

		// Token: 0x04001A7F RID: 6783
		private string _Sound_Die;

		// Token: 0x04001A80 RID: 6784
		private int _Rank;

		// Token: 0x04001A81 RID: 6785
		private bool _IsEnemy;

		// Token: 0x04001A82 RID: 6786
		private string _GetSoldierDesc;

		// Token: 0x04001A83 RID: 6787
		private readonly List<int> _GetSoldierHeros_ID = new List<int>();

		// Token: 0x04001A84 RID: 6788
		private int _GetSoldierTechId;

		// Token: 0x04001A85 RID: 6789
		private readonly List<int> _SoldierSkins_ID = new List<int>();

		// Token: 0x04001A86 RID: 6790
		private IExtension extensionObject;

		// Token: 0x04001A87 RID: 6791
		public ConfigDataArmyInfo m_armyInfo;

		// Token: 0x04001A88 RID: 6792
		public ConfigDataSkillInfo m_meleeSkillInfo;

		// Token: 0x04001A89 RID: 6793
		public ConfigDataSkillInfo m_rangeSkillInfo;

		// Token: 0x04001A8A RID: 6794
		public ConfigDataSkillInfo[] m_skillInfos;

		// Token: 0x04001A8B RID: 6795
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04001A8C RID: 6796
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04001A8D RID: 6797
		private LuaFunction m_ctor_hotfix;
	}
}
