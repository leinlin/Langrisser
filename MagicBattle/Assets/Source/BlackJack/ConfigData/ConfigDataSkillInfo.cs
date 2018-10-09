using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x0200028B RID: 651
	[HotFix(true, m_isCtorOnly = true)]
	[CustomLuaClass]
	[ProtoContract(Name = "ConfigDataSkillInfo")]
	[Serializable]
	public class ConfigDataSkillInfo : IExtensible
	{
		// Token: 0x06002A2F RID: 10799 RVA: 0x000B11C4 File Offset: 0x000AF3C4
		public ConfigDataSkillInfo()
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

		// Token: 0x17000B54 RID: 2900
		// (get) Token: 0x06002A30 RID: 10800 RVA: 0x000B1264 File Offset: 0x000AF464
		// (set) Token: 0x06002A31 RID: 10801 RVA: 0x000B126C File Offset: 0x000AF46C
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

		// Token: 0x17000B55 RID: 2901
		// (get) Token: 0x06002A32 RID: 10802 RVA: 0x000B1278 File Offset: 0x000AF478
		// (set) Token: 0x06002A33 RID: 10803 RVA: 0x000B1280 File Offset: 0x000AF480
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

		// Token: 0x17000B56 RID: 2902
		// (get) Token: 0x06002A34 RID: 10804 RVA: 0x000B128C File Offset: 0x000AF48C
		// (set) Token: 0x06002A35 RID: 10805 RVA: 0x000B1294 File Offset: 0x000AF494
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

		// Token: 0x17000B57 RID: 2903
		// (get) Token: 0x06002A36 RID: 10806 RVA: 0x000B12A0 File Offset: 0x000AF4A0
		// (set) Token: 0x06002A37 RID: 10807 RVA: 0x000B12A8 File Offset: 0x000AF4A8
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

		// Token: 0x17000B58 RID: 2904
		// (get) Token: 0x06002A38 RID: 10808 RVA: 0x000B12B4 File Offset: 0x000AF4B4
		// (set) Token: 0x06002A39 RID: 10809 RVA: 0x000B12BC File Offset: 0x000AF4BC
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

		// Token: 0x17000B59 RID: 2905
		// (get) Token: 0x06002A3A RID: 10810 RVA: 0x000B12C8 File Offset: 0x000AF4C8
		// (set) Token: 0x06002A3B RID: 10811 RVA: 0x000B12D0 File Offset: 0x000AF4D0
		[ProtoMember(7, IsRequired = true, Name = "IsMagic", DataFormat = DataFormat.Default)]
		public bool IsMagic
		{
			get
			{
				return this._IsMagic;
			}
			set
			{
				this._IsMagic = value;
			}
		}

		// Token: 0x17000B5A RID: 2906
		// (get) Token: 0x06002A3C RID: 10812 RVA: 0x000B12DC File Offset: 0x000AF4DC
		// (set) Token: 0x06002A3D RID: 10813 RVA: 0x000B12E4 File Offset: 0x000AF4E4
		[ProtoMember(8, IsRequired = true, Name = "IsActiveSkill", DataFormat = DataFormat.Default)]
		public bool IsActiveSkill
		{
			get
			{
				return this._IsActiveSkill;
			}
			set
			{
				this._IsActiveSkill = value;
			}
		}

		// Token: 0x17000B5B RID: 2907
		// (get) Token: 0x06002A3E RID: 10814 RVA: 0x000B12F0 File Offset: 0x000AF4F0
		// (set) Token: 0x06002A3F RID: 10815 RVA: 0x000B12F8 File Offset: 0x000AF4F8
		[ProtoMember(9, IsRequired = true, Name = "IsRangeSkill", DataFormat = DataFormat.Default)]
		public bool IsRangeSkill
		{
			get
			{
				return this._IsRangeSkill;
			}
			set
			{
				this._IsRangeSkill = value;
			}
		}

		// Token: 0x17000B5C RID: 2908
		// (get) Token: 0x06002A40 RID: 10816 RVA: 0x000B1304 File Offset: 0x000AF504
		// (set) Token: 0x06002A41 RID: 10817 RVA: 0x000B130C File Offset: 0x000AF50C
		[ProtoMember(10, IsRequired = true, Name = "AIIsRangeSkill", DataFormat = DataFormat.Default)]
		public bool AIIsRangeSkill
		{
			get
			{
				return this._AIIsRangeSkill;
			}
			set
			{
				this._AIIsRangeSkill = value;
			}
		}

		// Token: 0x17000B5D RID: 2909
		// (get) Token: 0x06002A42 RID: 10818 RVA: 0x000B1318 File Offset: 0x000AF518
		// (set) Token: 0x06002A43 RID: 10819 RVA: 0x000B1320 File Offset: 0x000AF520
		[ProtoMember(11, IsRequired = true, Name = "IsNewTurn", DataFormat = DataFormat.Default)]
		public bool IsNewTurn
		{
			get
			{
				return this._IsNewTurn;
			}
			set
			{
				this._IsNewTurn = value;
			}
		}

		// Token: 0x17000B5E RID: 2910
		// (get) Token: 0x06002A44 RID: 10820 RVA: 0x000B132C File Offset: 0x000AF52C
		[ProtoMember(12, Name = "LimitArmys_ID", DataFormat = DataFormat.TwosComplement)]
		public List<int> LimitArmys_ID
		{
			get
			{
				return this._LimitArmys_ID;
			}
		}

		// Token: 0x17000B5F RID: 2911
		// (get) Token: 0x06002A45 RID: 10821 RVA: 0x000B1334 File Offset: 0x000AF534
		[ProtoMember(13, Name = "PassiveBuffs_ID", DataFormat = DataFormat.TwosComplement)]
		public List<int> PassiveBuffs_ID
		{
			get
			{
				return this._PassiveBuffs_ID;
			}
		}

		// Token: 0x17000B60 RID: 2912
		// (get) Token: 0x06002A46 RID: 10822 RVA: 0x000B133C File Offset: 0x000AF53C
		[ProtoMember(14, Name = "SelfBuffs_ID", DataFormat = DataFormat.TwosComplement)]
		public List<int> SelfBuffs_ID
		{
			get
			{
				return this._SelfBuffs_ID;
			}
		}

		// Token: 0x17000B61 RID: 2913
		// (get) Token: 0x06002A47 RID: 10823 RVA: 0x000B1344 File Offset: 0x000AF544
		// (set) Token: 0x06002A48 RID: 10824 RVA: 0x000B134C File Offset: 0x000AF54C
		[ProtoMember(15, IsRequired = true, Name = "SkillAIType", DataFormat = DataFormat.TwosComplement)]
		public SkillAIType SkillAIType
		{
			get
			{
				return this._SkillAIType;
			}
			set
			{
				this._SkillAIType = value;
			}
		}

		// Token: 0x17000B62 RID: 2914
		// (get) Token: 0x06002A49 RID: 10825 RVA: 0x000B1358 File Offset: 0x000AF558
		// (set) Token: 0x06002A4A RID: 10826 RVA: 0x000B1360 File Offset: 0x000AF560
		[ProtoMember(16, IsRequired = true, Name = "SkillType", DataFormat = DataFormat.TwosComplement)]
		public SkillType SkillType
		{
			get
			{
				return this._SkillType;
			}
			set
			{
				this._SkillType = value;
			}
		}

		// Token: 0x17000B63 RID: 2915
		// (get) Token: 0x06002A4B RID: 10827 RVA: 0x000B136C File Offset: 0x000AF56C
		// (set) Token: 0x06002A4C RID: 10828 RVA: 0x000B1374 File Offset: 0x000AF574
		[ProtoMember(17, IsRequired = true, Name = "SkillTypeParam1", DataFormat = DataFormat.TwosComplement)]
		public int SkillTypeParam1
		{
			get
			{
				return this._SkillTypeParam1;
			}
			set
			{
				this._SkillTypeParam1 = value;
			}
		}

		// Token: 0x17000B64 RID: 2916
		// (get) Token: 0x06002A4D RID: 10829 RVA: 0x000B1380 File Offset: 0x000AF580
		// (set) Token: 0x06002A4E RID: 10830 RVA: 0x000B1388 File Offset: 0x000AF588
		[ProtoMember(18, IsRequired = true, Name = "SkillTypeParam2", DataFormat = DataFormat.TwosComplement)]
		public int SkillTypeParam2
		{
			get
			{
				return this._SkillTypeParam2;
			}
			set
			{
				this._SkillTypeParam2 = value;
			}
		}

		// Token: 0x17000B65 RID: 2917
		// (get) Token: 0x06002A4F RID: 10831 RVA: 0x000B1394 File Offset: 0x000AF594
		// (set) Token: 0x06002A50 RID: 10832 RVA: 0x000B139C File Offset: 0x000AF59C
		[ProtoMember(19, IsRequired = true, Name = "SkillTypeParam3", DataFormat = DataFormat.TwosComplement)]
		public int SkillTypeParam3
		{
			get
			{
				return this._SkillTypeParam3;
			}
			set
			{
				this._SkillTypeParam3 = value;
			}
		}

		// Token: 0x17000B66 RID: 2918
		// (get) Token: 0x06002A51 RID: 10833 RVA: 0x000B13A8 File Offset: 0x000AF5A8
		// (set) Token: 0x06002A52 RID: 10834 RVA: 0x000B13B0 File Offset: 0x000AF5B0
		[ProtoMember(20, IsRequired = true, Name = "Time_Sing", DataFormat = DataFormat.TwosComplement)]
		public int Time_Sing
		{
			get
			{
				return this._Time_Sing;
			}
			set
			{
				this._Time_Sing = value;
			}
		}

		// Token: 0x17000B67 RID: 2919
		// (get) Token: 0x06002A53 RID: 10835 RVA: 0x000B13BC File Offset: 0x000AF5BC
		// (set) Token: 0x06002A54 RID: 10836 RVA: 0x000B13C4 File Offset: 0x000AF5C4
		[ProtoMember(21, IsRequired = true, Name = "Power", DataFormat = DataFormat.TwosComplement)]
		public int Power
		{
			get
			{
				return this._Power;
			}
			set
			{
				this._Power = value;
			}
		}

		// Token: 0x17000B68 RID: 2920
		// (get) Token: 0x06002A55 RID: 10837 RVA: 0x000B13D0 File Offset: 0x000AF5D0
		// (set) Token: 0x06002A56 RID: 10838 RVA: 0x000B13D8 File Offset: 0x000AF5D8
		[ProtoMember(22, IsRequired = true, Name = "AttackDistance", DataFormat = DataFormat.TwosComplement)]
		public int AttackDistance
		{
			get
			{
				return this._AttackDistance;
			}
			set
			{
				this._AttackDistance = value;
			}
		}

		// Token: 0x17000B69 RID: 2921
		// (get) Token: 0x06002A57 RID: 10839 RVA: 0x000B13E4 File Offset: 0x000AF5E4
		// (set) Token: 0x06002A58 RID: 10840 RVA: 0x000B13EC File Offset: 0x000AF5EC
		[ProtoMember(23, IsRequired = true, Name = "HitCountMax", DataFormat = DataFormat.TwosComplement)]
		public int HitCountMax
		{
			get
			{
				return this._HitCountMax;
			}
			set
			{
				this._HitCountMax = value;
			}
		}

		// Token: 0x17000B6A RID: 2922
		// (get) Token: 0x06002A59 RID: 10841 RVA: 0x000B13F8 File Offset: 0x000AF5F8
		// (set) Token: 0x06002A5A RID: 10842 RVA: 0x000B1400 File Offset: 0x000AF600
		[ProtoMember(24, IsRequired = true, Name = "AttackCount", DataFormat = DataFormat.TwosComplement)]
		public int AttackCount
		{
			get
			{
				return this._AttackCount;
			}
			set
			{
				this._AttackCount = value;
			}
		}

		// Token: 0x17000B6B RID: 2923
		// (get) Token: 0x06002A5B RID: 10843 RVA: 0x000B140C File Offset: 0x000AF60C
		// (set) Token: 0x06002A5C RID: 10844 RVA: 0x000B1414 File Offset: 0x000AF614
		[ProtoMember(25, IsRequired = true, Name = "Time_NextAttack", DataFormat = DataFormat.TwosComplement)]
		public int Time_NextAttack
		{
			get
			{
				return this._Time_NextAttack;
			}
			set
			{
				this._Time_NextAttack = value;
			}
		}

		// Token: 0x17000B6C RID: 2924
		// (get) Token: 0x06002A5D RID: 10845 RVA: 0x000B1420 File Offset: 0x000AF620
		[ProtoMember(26, Name = "Buffs_ID", DataFormat = DataFormat.TwosComplement)]
		public List<int> Buffs_ID
		{
			get
			{
				return this._Buffs_ID;
			}
		}

		// Token: 0x17000B6D RID: 2925
		// (get) Token: 0x06002A5E RID: 10846 RVA: 0x000B1428 File Offset: 0x000AF628
		// (set) Token: 0x06002A5F RID: 10847 RVA: 0x000B1430 File Offset: 0x000AF630
		[ProtoMember(27, IsRequired = true, Name = "BuffRate", DataFormat = DataFormat.TwosComplement)]
		public int BuffRate
		{
			get
			{
				return this._BuffRate;
			}
			set
			{
				this._BuffRate = value;
			}
		}

		// Token: 0x17000B6E RID: 2926
		// (get) Token: 0x06002A60 RID: 10848 RVA: 0x000B143C File Offset: 0x000AF63C
		// (set) Token: 0x06002A61 RID: 10849 RVA: 0x000B1444 File Offset: 0x000AF644
		[ProtoMember(28, IsRequired = true, Name = "BuffNum", DataFormat = DataFormat.TwosComplement)]
		public int BuffNum
		{
			get
			{
				return this._BuffNum;
			}
			set
			{
				this._BuffNum = value;
			}
		}

		// Token: 0x17000B6F RID: 2927
		// (get) Token: 0x06002A62 RID: 10850 RVA: 0x000B1450 File Offset: 0x000AF650
		// (set) Token: 0x06002A63 RID: 10851 RVA: 0x000B1458 File Offset: 0x000AF658
		[ProtoMember(29, IsRequired = true, Name = "HeroMoveDelay", DataFormat = DataFormat.TwosComplement)]
		public int HeroMoveDelay
		{
			get
			{
				return this._HeroMoveDelay;
			}
			set
			{
				this._HeroMoveDelay = value;
			}
		}

		// Token: 0x17000B70 RID: 2928
		// (get) Token: 0x06002A64 RID: 10852 RVA: 0x000B1464 File Offset: 0x000AF664
		// (set) Token: 0x06002A65 RID: 10853 RVA: 0x000B146C File Offset: 0x000AF66C
		[ProtoMember(30, IsRequired = true, Name = "Time_EffCast1", DataFormat = DataFormat.TwosComplement)]
		public int Time_EffCast1
		{
			get
			{
				return this._Time_EffCast1;
			}
			set
			{
				this._Time_EffCast1 = value;
			}
		}

		// Token: 0x17000B71 RID: 2929
		// (get) Token: 0x06002A66 RID: 10854 RVA: 0x000B1478 File Offset: 0x000AF678
		// (set) Token: 0x06002A67 RID: 10855 RVA: 0x000B1480 File Offset: 0x000AF680
		[ProtoMember(31, IsRequired = true, Name = "Time_EffCast2", DataFormat = DataFormat.TwosComplement)]
		public int Time_EffCast2
		{
			get
			{
				return this._Time_EffCast2;
			}
			set
			{
				this._Time_EffCast2 = value;
			}
		}

		// Token: 0x17000B72 RID: 2930
		// (get) Token: 0x06002A68 RID: 10856 RVA: 0x000B148C File Offset: 0x000AF68C
		// (set) Token: 0x06002A69 RID: 10857 RVA: 0x000B1494 File Offset: 0x000AF694
		[ProtoMember(32, IsRequired = true, Name = "Time_EffMagic1", DataFormat = DataFormat.TwosComplement)]
		public int Time_EffMagic1
		{
			get
			{
				return this._Time_EffMagic1;
			}
			set
			{
				this._Time_EffMagic1 = value;
			}
		}

		// Token: 0x17000B73 RID: 2931
		// (get) Token: 0x06002A6A RID: 10858 RVA: 0x000B14A0 File Offset: 0x000AF6A0
		// (set) Token: 0x06002A6B RID: 10859 RVA: 0x000B14A8 File Offset: 0x000AF6A8
		[ProtoMember(33, IsRequired = true, Name = "Time_EffMagic2", DataFormat = DataFormat.TwosComplement)]
		public int Time_EffMagic2
		{
			get
			{
				return this._Time_EffMagic2;
			}
			set
			{
				this._Time_EffMagic2 = value;
			}
		}

		// Token: 0x17000B74 RID: 2932
		// (get) Token: 0x06002A6C RID: 10860 RVA: 0x000B14B4 File Offset: 0x000AF6B4
		// (set) Token: 0x06002A6D RID: 10861 RVA: 0x000B14BC File Offset: 0x000AF6BC
		[ProtoMember(34, IsRequired = true, Name = "Time_Hit", DataFormat = DataFormat.TwosComplement)]
		public int Time_Hit
		{
			get
			{
				return this._Time_Hit;
			}
			set
			{
				this._Time_Hit = value;
			}
		}

		// Token: 0x17000B75 RID: 2933
		// (get) Token: 0x06002A6E RID: 10862 RVA: 0x000B14C8 File Offset: 0x000AF6C8
		// (set) Token: 0x06002A6F RID: 10863 RVA: 0x000B14D0 File Offset: 0x000AF6D0
		[ProtoMember(35, IsRequired = true, Name = "Time_End", DataFormat = DataFormat.TwosComplement)]
		public int Time_End
		{
			get
			{
				return this._Time_End;
			}
			set
			{
				this._Time_End = value;
			}
		}

		// Token: 0x17000B76 RID: 2934
		// (get) Token: 0x06002A70 RID: 10864 RVA: 0x000B14DC File Offset: 0x000AF6DC
		[ProtoMember(36, Name = "Time_MultiHit", DataFormat = DataFormat.TwosComplement)]
		public List<int> Time_MultiHit
		{
			get
			{
				return this._Time_MultiHit;
			}
		}

		// Token: 0x17000B77 RID: 2935
		// (get) Token: 0x06002A71 RID: 10865 RVA: 0x000B14E4 File Offset: 0x000AF6E4
		// (set) Token: 0x06002A72 RID: 10866 RVA: 0x000B14EC File Offset: 0x000AF6EC
		[ProtoMember(37, IsRequired = true, Name = "Anim_Cast", DataFormat = DataFormat.Default)]
		public string Anim_Cast
		{
			get
			{
				return this._Anim_Cast;
			}
			set
			{
				this._Anim_Cast = value;
			}
		}

		// Token: 0x17000B78 RID: 2936
		// (get) Token: 0x06002A73 RID: 10867 RVA: 0x000B14F8 File Offset: 0x000AF6F8
		// (set) Token: 0x06002A74 RID: 10868 RVA: 0x000B1500 File Offset: 0x000AF700
		[ProtoMember(38, IsRequired = true, Name = "Effect_Sing", DataFormat = DataFormat.Default)]
		public string Effect_Sing
		{
			get
			{
				return this._Effect_Sing;
			}
			set
			{
				this._Effect_Sing = value;
			}
		}

		// Token: 0x17000B79 RID: 2937
		// (get) Token: 0x06002A75 RID: 10869 RVA: 0x000B150C File Offset: 0x000AF70C
		// (set) Token: 0x06002A76 RID: 10870 RVA: 0x000B1514 File Offset: 0x000AF714
		[ProtoMember(39, IsRequired = true, Name = "Effect_Cast1", DataFormat = DataFormat.Default)]
		public string Effect_Cast1
		{
			get
			{
				return this._Effect_Cast1;
			}
			set
			{
				this._Effect_Cast1 = value;
			}
		}

		// Token: 0x17000B7A RID: 2938
		// (get) Token: 0x06002A77 RID: 10871 RVA: 0x000B1520 File Offset: 0x000AF720
		// (set) Token: 0x06002A78 RID: 10872 RVA: 0x000B1528 File Offset: 0x000AF728
		[ProtoMember(40, IsRequired = true, Name = "Effect_Cast1_Far", DataFormat = DataFormat.Default)]
		public string Effect_Cast1_Far
		{
			get
			{
				return this._Effect_Cast1_Far;
			}
			set
			{
				this._Effect_Cast1_Far = value;
			}
		}

		// Token: 0x17000B7B RID: 2939
		// (get) Token: 0x06002A79 RID: 10873 RVA: 0x000B1534 File Offset: 0x000AF734
		// (set) Token: 0x06002A7A RID: 10874 RVA: 0x000B153C File Offset: 0x000AF73C
		[ProtoMember(41, IsRequired = true, Name = "Effect_Cast2", DataFormat = DataFormat.Default)]
		public string Effect_Cast2
		{
			get
			{
				return this._Effect_Cast2;
			}
			set
			{
				this._Effect_Cast2 = value;
			}
		}

		// Token: 0x17000B7C RID: 2940
		// (get) Token: 0x06002A7B RID: 10875 RVA: 0x000B1548 File Offset: 0x000AF748
		// (set) Token: 0x06002A7C RID: 10876 RVA: 0x000B1550 File Offset: 0x000AF750
		[ProtoMember(42, IsRequired = true, Name = "Effect_Cast2_Far", DataFormat = DataFormat.Default)]
		public string Effect_Cast2_Far
		{
			get
			{
				return this._Effect_Cast2_Far;
			}
			set
			{
				this._Effect_Cast2_Far = value;
			}
		}

		// Token: 0x17000B7D RID: 2941
		// (get) Token: 0x06002A7D RID: 10877 RVA: 0x000B155C File Offset: 0x000AF75C
		// (set) Token: 0x06002A7E RID: 10878 RVA: 0x000B1564 File Offset: 0x000AF764
		[ProtoMember(43, IsRequired = true, Name = "Effect_Magic1", DataFormat = DataFormat.Default)]
		public string Effect_Magic1
		{
			get
			{
				return this._Effect_Magic1;
			}
			set
			{
				this._Effect_Magic1 = value;
			}
		}

		// Token: 0x17000B7E RID: 2942
		// (get) Token: 0x06002A7F RID: 10879 RVA: 0x000B1570 File Offset: 0x000AF770
		// (set) Token: 0x06002A80 RID: 10880 RVA: 0x000B1578 File Offset: 0x000AF778
		[ProtoMember(44, IsRequired = true, Name = "Effect_Magic1_Far", DataFormat = DataFormat.Default)]
		public string Effect_Magic1_Far
		{
			get
			{
				return this._Effect_Magic1_Far;
			}
			set
			{
				this._Effect_Magic1_Far = value;
			}
		}

		// Token: 0x17000B7F RID: 2943
		// (get) Token: 0x06002A81 RID: 10881 RVA: 0x000B1584 File Offset: 0x000AF784
		// (set) Token: 0x06002A82 RID: 10882 RVA: 0x000B158C File Offset: 0x000AF78C
		[ProtoMember(45, IsRequired = true, Name = "Effect_Magic2", DataFormat = DataFormat.Default)]
		public string Effect_Magic2
		{
			get
			{
				return this._Effect_Magic2;
			}
			set
			{
				this._Effect_Magic2 = value;
			}
		}

		// Token: 0x17000B80 RID: 2944
		// (get) Token: 0x06002A83 RID: 10883 RVA: 0x000B1598 File Offset: 0x000AF798
		// (set) Token: 0x06002A84 RID: 10884 RVA: 0x000B15A0 File Offset: 0x000AF7A0
		[ProtoMember(46, IsRequired = true, Name = "Effect_Magic2_Far", DataFormat = DataFormat.Default)]
		public string Effect_Magic2_Far
		{
			get
			{
				return this._Effect_Magic2_Far;
			}
			set
			{
				this._Effect_Magic2_Far = value;
			}
		}

		// Token: 0x17000B81 RID: 2945
		// (get) Token: 0x06002A85 RID: 10885 RVA: 0x000B15AC File Offset: 0x000AF7AC
		// (set) Token: 0x06002A86 RID: 10886 RVA: 0x000B15B4 File Offset: 0x000AF7B4
		[ProtoMember(47, IsRequired = true, Name = "Effect_Hit", DataFormat = DataFormat.Default)]
		public string Effect_Hit
		{
			get
			{
				return this._Effect_Hit;
			}
			set
			{
				this._Effect_Hit = value;
			}
		}

		// Token: 0x17000B82 RID: 2946
		// (get) Token: 0x06002A87 RID: 10887 RVA: 0x000B15C0 File Offset: 0x000AF7C0
		// (set) Token: 0x06002A88 RID: 10888 RVA: 0x000B15C8 File Offset: 0x000AF7C8
		[ProtoMember(48, IsRequired = true, Name = "Effect_PreCast", DataFormat = DataFormat.Default)]
		public string Effect_PreCast
		{
			get
			{
				return this._Effect_PreCast;
			}
			set
			{
				this._Effect_PreCast = value;
			}
		}

		// Token: 0x17000B83 RID: 2947
		// (get) Token: 0x06002A89 RID: 10889 RVA: 0x000B15D4 File Offset: 0x000AF7D4
		// (set) Token: 0x06002A8A RID: 10890 RVA: 0x000B15DC File Offset: 0x000AF7DC
		[ProtoMember(49, IsRequired = true, Name = "CutsceneType", DataFormat = DataFormat.TwosComplement)]
		public int CutsceneType
		{
			get
			{
				return this._CutsceneType;
			}
			set
			{
				this._CutsceneType = value;
			}
		}

		// Token: 0x17000B84 RID: 2948
		// (get) Token: 0x06002A8B RID: 10891 RVA: 0x000B15E8 File Offset: 0x000AF7E8
		// (set) Token: 0x06002A8C RID: 10892 RVA: 0x000B15F0 File Offset: 0x000AF7F0
		[ProtoMember(50, IsRequired = true, Name = "DeadAnimType", DataFormat = DataFormat.TwosComplement)]
		public int DeadAnimType
		{
			get
			{
				return this._DeadAnimType;
			}
			set
			{
				this._DeadAnimType = value;
			}
		}

		// Token: 0x17000B85 RID: 2949
		// (get) Token: 0x06002A8D RID: 10893 RVA: 0x000B15FC File Offset: 0x000AF7FC
		// (set) Token: 0x06002A8E RID: 10894 RVA: 0x000B1604 File Offset: 0x000AF804
		[ProtoMember(51, IsRequired = true, Name = "BF_InitCooldown", DataFormat = DataFormat.TwosComplement)]
		public int BF_InitCooldown
		{
			get
			{
				return this._BF_InitCooldown;
			}
			set
			{
				this._BF_InitCooldown = value;
			}
		}

		// Token: 0x17000B86 RID: 2950
		// (get) Token: 0x06002A8F RID: 10895 RVA: 0x000B1610 File Offset: 0x000AF810
		// (set) Token: 0x06002A90 RID: 10896 RVA: 0x000B1618 File Offset: 0x000AF818
		[ProtoMember(52, IsRequired = true, Name = "BF_Cooldown", DataFormat = DataFormat.TwosComplement)]
		public int BF_Cooldown
		{
			get
			{
				return this._BF_Cooldown;
			}
			set
			{
				this._BF_Cooldown = value;
			}
		}

		// Token: 0x17000B87 RID: 2951
		// (get) Token: 0x06002A91 RID: 10897 RVA: 0x000B1624 File Offset: 0x000AF824
		// (set) Token: 0x06002A92 RID: 10898 RVA: 0x000B162C File Offset: 0x000AF82C
		[ProtoMember(53, IsRequired = true, Name = "BF_Distance", DataFormat = DataFormat.TwosComplement)]
		public int BF_Distance
		{
			get
			{
				return this._BF_Distance;
			}
			set
			{
				this._BF_Distance = value;
			}
		}

		// Token: 0x17000B88 RID: 2952
		// (get) Token: 0x06002A93 RID: 10899 RVA: 0x000B1638 File Offset: 0x000AF838
		// (set) Token: 0x06002A94 RID: 10900 RVA: 0x000B1640 File Offset: 0x000AF840
		[ProtoMember(54, IsRequired = true, Name = "BF_Range", DataFormat = DataFormat.TwosComplement)]
		public int BF_Range
		{
			get
			{
				return this._BF_Range;
			}
			set
			{
				this._BF_Range = value;
			}
		}

		// Token: 0x17000B89 RID: 2953
		// (get) Token: 0x06002A95 RID: 10901 RVA: 0x000B164C File Offset: 0x000AF84C
		// (set) Token: 0x06002A96 RID: 10902 RVA: 0x000B1654 File Offset: 0x000AF854
		[ProtoMember(55, IsRequired = true, Name = "BF_RangeShape", DataFormat = DataFormat.TwosComplement)]
		public int BF_RangeShape
		{
			get
			{
				return this._BF_RangeShape;
			}
			set
			{
				this._BF_RangeShape = value;
			}
		}

		// Token: 0x17000B8A RID: 2954
		// (get) Token: 0x06002A97 RID: 10903 RVA: 0x000B1660 File Offset: 0x000AF860
		// (set) Token: 0x06002A98 RID: 10904 RVA: 0x000B1668 File Offset: 0x000AF868
		[ProtoMember(56, IsRequired = true, Name = "BF_TargetFaction", DataFormat = DataFormat.TwosComplement)]
		public SkillTargetType BF_TargetFaction
		{
			get
			{
				return this._BF_TargetFaction;
			}
			set
			{
				this._BF_TargetFaction = value;
			}
		}

		// Token: 0x17000B8B RID: 2955
		// (get) Token: 0x06002A99 RID: 10905 RVA: 0x000B1674 File Offset: 0x000AF874
		// (set) Token: 0x06002A9A RID: 10906 RVA: 0x000B167C File Offset: 0x000AF87C
		[ProtoMember(57, IsRequired = true, Name = "BF_TargetType", DataFormat = DataFormat.TwosComplement)]
		public SkillTargetType BF_TargetType
		{
			get
			{
				return this._BF_TargetType;
			}
			set
			{
				this._BF_TargetType = value;
			}
		}

		// Token: 0x17000B8C RID: 2956
		// (get) Token: 0x06002A9B RID: 10907 RVA: 0x000B1688 File Offset: 0x000AF888
		// (set) Token: 0x06002A9C RID: 10908 RVA: 0x000B1690 File Offset: 0x000AF890
		[ProtoMember(58, IsRequired = true, Name = "CastSkillShape", DataFormat = DataFormat.TwosComplement)]
		public int CastSkillShape
		{
			get
			{
				return this._CastSkillShape;
			}
			set
			{
				this._CastSkillShape = value;
			}
		}

		// Token: 0x17000B8D RID: 2957
		// (get) Token: 0x06002A9D RID: 10909 RVA: 0x000B169C File Offset: 0x000AF89C
		// (set) Token: 0x06002A9E RID: 10910 RVA: 0x000B16A4 File Offset: 0x000AF8A4
		[ProtoMember(59, IsRequired = true, Name = "Icon", DataFormat = DataFormat.Default)]
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

		// Token: 0x17000B8E RID: 2958
		// (get) Token: 0x06002A9F RID: 10911 RVA: 0x000B16B0 File Offset: 0x000AF8B0
		// (set) Token: 0x06002AA0 RID: 10912 RVA: 0x000B16B8 File Offset: 0x000AF8B8
		[ProtoMember(60, IsRequired = true, Name = "SkillCost", DataFormat = DataFormat.TwosComplement)]
		public int SkillCost
		{
			get
			{
				return this._SkillCost;
			}
			set
			{
				this._SkillCost = value;
			}
		}

		// Token: 0x17000B8F RID: 2959
		// (get) Token: 0x06002AA1 RID: 10913 RVA: 0x000B16C4 File Offset: 0x000AF8C4
		// (set) Token: 0x06002AA2 RID: 10914 RVA: 0x000B16CC File Offset: 0x000AF8CC
		[ProtoMember(61, IsRequired = true, Name = "TypeText", DataFormat = DataFormat.Default)]
		public string TypeText
		{
			get
			{
				return this._TypeText;
			}
			set
			{
				this._TypeText = value;
			}
		}

		// Token: 0x17000B90 RID: 2960
		// (get) Token: 0x06002AA3 RID: 10915 RVA: 0x000B16D8 File Offset: 0x000AF8D8
		// (set) Token: 0x06002AA4 RID: 10916 RVA: 0x000B16E0 File Offset: 0x000AF8E0
		[ProtoMember(62, IsRequired = true, Name = "CDText", DataFormat = DataFormat.Default)]
		public string CDText
		{
			get
			{
				return this._CDText;
			}
			set
			{
				this._CDText = value;
			}
		}

		// Token: 0x17000B91 RID: 2961
		// (get) Token: 0x06002AA5 RID: 10917 RVA: 0x000B16EC File Offset: 0x000AF8EC
		// (set) Token: 0x06002AA6 RID: 10918 RVA: 0x000B16F4 File Offset: 0x000AF8F4
		[ProtoMember(63, IsRequired = true, Name = "DistanceText", DataFormat = DataFormat.Default)]
		public string DistanceText
		{
			get
			{
				return this._DistanceText;
			}
			set
			{
				this._DistanceText = value;
			}
		}

		// Token: 0x17000B92 RID: 2962
		// (get) Token: 0x06002AA7 RID: 10919 RVA: 0x000B1700 File Offset: 0x000AF900
		// (set) Token: 0x06002AA8 RID: 10920 RVA: 0x000B1708 File Offset: 0x000AF908
		[ProtoMember(64, IsRequired = true, Name = "RangeText", DataFormat = DataFormat.Default)]
		public string RangeText
		{
			get
			{
				return this._RangeText;
			}
			set
			{
				this._RangeText = value;
			}
		}

		// Token: 0x17000B93 RID: 2963
		// (get) Token: 0x06002AA9 RID: 10921 RVA: 0x000B1714 File Offset: 0x000AF914
		// (set) Token: 0x06002AAA RID: 10922 RVA: 0x000B171C File Offset: 0x000AF91C
		[ProtoMember(65, IsRequired = true, Name = "BattlePower", DataFormat = DataFormat.TwosComplement)]
		public int BattlePower
		{
			get
			{
				return this._BattlePower;
			}
			set
			{
				this._BattlePower = value;
			}
		}

		// Token: 0x06002AAB RID: 10923 RVA: 0x000B1728 File Offset: 0x000AF928
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002AAC RID: 10924 RVA: 0x000B1738 File Offset: 0x000AF938
		public bool IsNormalAttack()
		{
			return this.m_isNormalAttack;
		}

		// Token: 0x06002AAD RID: 10925 RVA: 0x000B1740 File Offset: 0x000AF940
		public bool IsBattlefieldSkill()
		{
			return this.SkillType == SkillType.SkillType_BF_Heal || this.SkillType == SkillType.SkillType_BF_HealRemoveCD || this.SkillType == SkillType.SkillType_BF_HealNewTurn || this.SkillType == SkillType.SkillType_BF_HealPercent || this.SkillType == SkillType.SkillType_BF_MagicDamage || this.SkillType == SkillType.SkillType_BF_DamageHeal || this.SkillType == SkillType.SkillType_BF_Summon || this.SkillType == SkillType.SkillType_BF_Teleport || this.SkillType == SkillType.SkillType_BF_AddBuff;
		}

		// Token: 0x06002AAE RID: 10926 RVA: 0x000B17C0 File Offset: 0x000AF9C0
		public bool IsDamageSkill()
		{
			return this.SkillType == SkillType.SkillType_Slash || this.SkillType == SkillType.SkillType_Shoot || this.SkillType == SkillType.SkillType_Charge || this.SkillType == SkillType.SkillType_MagicDamage || this.SkillType == SkillType.SkillType_BF_MagicDamage || this.SkillType == SkillType.SkillType_BF_DamageHeal;
		}

		// Token: 0x06002AAF RID: 10927 RVA: 0x000B1818 File Offset: 0x000AFA18
		public bool IsPhysicalDamageSkill()
		{
			return !this.IsMagic && this.IsDamageSkill();
		}

		// Token: 0x06002AB0 RID: 10928 RVA: 0x000B1830 File Offset: 0x000AFA30
		public bool IsMagicDamageSkill()
		{
			return this.IsMagic && this.IsDamageSkill();
		}

		// Token: 0x06002AB1 RID: 10929 RVA: 0x000B1848 File Offset: 0x000AFA48
		public bool IsHealSkill()
		{
			return (this.SkillType == SkillType.SkillType_BF_Heal && this.Power != -100) || this.SkillType == SkillType.SkillType_BF_HealRemoveCD || this.SkillType == SkillType.SkillType_BF_HealNewTurn || this.SkillType == SkillType.SkillType_BF_HealPercent;
		}

		// Token: 0x06002AB2 RID: 10930 RVA: 0x000B1888 File Offset: 0x000AFA88
		public bool IsBuffSkill()
		{
			return (this.SkillType == SkillType.SkillType_BF_Heal && this.Power == -100) || this.SkillType == SkillType.SkillType_BF_AddBuff;
		}

		// Token: 0x06002AB3 RID: 10931 RVA: 0x000B18B0 File Offset: 0x000AFAB0
		public bool IsSummonSkill()
		{
			return this.SkillType == SkillType.SkillType_BF_Summon;
		}

		// Token: 0x06002AB4 RID: 10932 RVA: 0x000B18BC File Offset: 0x000AFABC
		public bool IsTeleportSkill()
		{
			return this.SkillType == SkillType.SkillType_BF_Teleport;
		}

		// Token: 0x06002AB5 RID: 10933 RVA: 0x000B18C8 File Offset: 0x000AFAC8
		public bool IsPassiveSkill()
		{
			return this.SkillType == SkillType.SkillType_Passive;
		}

		// Token: 0x06002AB6 RID: 10934 RVA: 0x000B18D4 File Offset: 0x000AFAD4
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

		// Token: 0x06002AB7 RID: 10935 RVA: 0x000B19A0 File Offset: 0x000AFBA0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataSkillInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040019FF RID: 6655
		private int _ID;

		// Token: 0x04001A00 RID: 6656
		private string _Name;

		// Token: 0x04001A01 RID: 6657
		private string _NameStrKey;

		// Token: 0x04001A02 RID: 6658
		private string _Desc;

		// Token: 0x04001A03 RID: 6659
		private string _DescStrKey;

		// Token: 0x04001A04 RID: 6660
		private bool _IsMagic;

		// Token: 0x04001A05 RID: 6661
		private bool _IsActiveSkill;

		// Token: 0x04001A06 RID: 6662
		private bool _IsRangeSkill;

		// Token: 0x04001A07 RID: 6663
		private bool _AIIsRangeSkill;

		// Token: 0x04001A08 RID: 6664
		private bool _IsNewTurn;

		// Token: 0x04001A09 RID: 6665
		private readonly List<int> _LimitArmys_ID = new List<int>();

		// Token: 0x04001A0A RID: 6666
		private readonly List<int> _PassiveBuffs_ID = new List<int>();

		// Token: 0x04001A0B RID: 6667
		private readonly List<int> _SelfBuffs_ID = new List<int>();

		// Token: 0x04001A0C RID: 6668
		private SkillAIType _SkillAIType;

		// Token: 0x04001A0D RID: 6669
		private SkillType _SkillType;

		// Token: 0x04001A0E RID: 6670
		private int _SkillTypeParam1;

		// Token: 0x04001A0F RID: 6671
		private int _SkillTypeParam2;

		// Token: 0x04001A10 RID: 6672
		private int _SkillTypeParam3;

		// Token: 0x04001A11 RID: 6673
		private int _Time_Sing;

		// Token: 0x04001A12 RID: 6674
		private int _Power;

		// Token: 0x04001A13 RID: 6675
		private int _AttackDistance;

		// Token: 0x04001A14 RID: 6676
		private int _HitCountMax;

		// Token: 0x04001A15 RID: 6677
		private int _AttackCount;

		// Token: 0x04001A16 RID: 6678
		private int _Time_NextAttack;

		// Token: 0x04001A17 RID: 6679
		private readonly List<int> _Buffs_ID = new List<int>();

		// Token: 0x04001A18 RID: 6680
		private int _BuffRate;

		// Token: 0x04001A19 RID: 6681
		private int _BuffNum;

		// Token: 0x04001A1A RID: 6682
		private int _HeroMoveDelay;

		// Token: 0x04001A1B RID: 6683
		private int _Time_EffCast1;

		// Token: 0x04001A1C RID: 6684
		private int _Time_EffCast2;

		// Token: 0x04001A1D RID: 6685
		private int _Time_EffMagic1;

		// Token: 0x04001A1E RID: 6686
		private int _Time_EffMagic2;

		// Token: 0x04001A1F RID: 6687
		private int _Time_Hit;

		// Token: 0x04001A20 RID: 6688
		private int _Time_End;

		// Token: 0x04001A21 RID: 6689
		private readonly List<int> _Time_MultiHit = new List<int>();

		// Token: 0x04001A22 RID: 6690
		private string _Anim_Cast;

		// Token: 0x04001A23 RID: 6691
		private string _Effect_Sing;

		// Token: 0x04001A24 RID: 6692
		private string _Effect_Cast1;

		// Token: 0x04001A25 RID: 6693
		private string _Effect_Cast1_Far;

		// Token: 0x04001A26 RID: 6694
		private string _Effect_Cast2;

		// Token: 0x04001A27 RID: 6695
		private string _Effect_Cast2_Far;

		// Token: 0x04001A28 RID: 6696
		private string _Effect_Magic1;

		// Token: 0x04001A29 RID: 6697
		private string _Effect_Magic1_Far;

		// Token: 0x04001A2A RID: 6698
		private string _Effect_Magic2;

		// Token: 0x04001A2B RID: 6699
		private string _Effect_Magic2_Far;

		// Token: 0x04001A2C RID: 6700
		private string _Effect_Hit;

		// Token: 0x04001A2D RID: 6701
		private string _Effect_PreCast;

		// Token: 0x04001A2E RID: 6702
		private int _CutsceneType;

		// Token: 0x04001A2F RID: 6703
		private int _DeadAnimType;

		// Token: 0x04001A30 RID: 6704
		private int _BF_InitCooldown;

		// Token: 0x04001A31 RID: 6705
		private int _BF_Cooldown;

		// Token: 0x04001A32 RID: 6706
		private int _BF_Distance;

		// Token: 0x04001A33 RID: 6707
		private int _BF_Range;

		// Token: 0x04001A34 RID: 6708
		private int _BF_RangeShape;

		// Token: 0x04001A35 RID: 6709
		private SkillTargetType _BF_TargetFaction;

		// Token: 0x04001A36 RID: 6710
		private SkillTargetType _BF_TargetType;

		// Token: 0x04001A37 RID: 6711
		private int _CastSkillShape;

		// Token: 0x04001A38 RID: 6712
		private string _Icon;

		// Token: 0x04001A39 RID: 6713
		private int _SkillCost;

		// Token: 0x04001A3A RID: 6714
		private string _TypeText;

		// Token: 0x04001A3B RID: 6715
		private string _CDText;

		// Token: 0x04001A3C RID: 6716
		private string _DistanceText;

		// Token: 0x04001A3D RID: 6717
		private string _RangeText;

		// Token: 0x04001A3E RID: 6718
		private int _BattlePower;

		// Token: 0x04001A3F RID: 6719
		private IExtension extensionObject;

		// Token: 0x04001A40 RID: 6720
		public ConfigDataBuffInfo[] m_buffInfos;

		// Token: 0x04001A41 RID: 6721
		public ConfigDataBuffInfo[] m_passiveBuffInfos;

		// Token: 0x04001A42 RID: 6722
		public ConfigDataBuffInfo[] m_selfBuffInfos;

		// Token: 0x04001A43 RID: 6723
		public bool m_isNormalAttack;

		// Token: 0x04001A44 RID: 6724
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04001A45 RID: 6725
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04001A46 RID: 6726
		private LuaFunction m_ctor_hotfix;
	}
}
