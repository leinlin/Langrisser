using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x0200022B RID: 555
	[HotFix(true, m_isCtorOnly = true)]
	[CustomLuaClass]
	[ProtoContract(Name = "ConfigDataEquipmentInfo")]
	[Serializable]
	public class ConfigDataEquipmentInfo : IExtensible
	{
		// Token: 0x060021A2 RID: 8610 RVA: 0x000A2364 File Offset: 0x000A0564
		public ConfigDataEquipmentInfo()
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

		// Token: 0x17000782 RID: 1922
		// (get) Token: 0x060021A3 RID: 8611 RVA: 0x000A2444 File Offset: 0x000A0644
		// (set) Token: 0x060021A4 RID: 8612 RVA: 0x000A244C File Offset: 0x000A064C
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

		// Token: 0x17000783 RID: 1923
		// (get) Token: 0x060021A5 RID: 8613 RVA: 0x000A2458 File Offset: 0x000A0658
		// (set) Token: 0x060021A6 RID: 8614 RVA: 0x000A2460 File Offset: 0x000A0660
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

		// Token: 0x17000784 RID: 1924
		// (get) Token: 0x060021A7 RID: 8615 RVA: 0x000A246C File Offset: 0x000A066C
		// (set) Token: 0x060021A8 RID: 8616 RVA: 0x000A2474 File Offset: 0x000A0674
		[ProtoMember(4, IsRequired = true, Name = "EquipmentType", DataFormat = DataFormat.TwosComplement)]
		public EquipmentType EquipmentType
		{
			get
			{
				return this._EquipmentType;
			}
			set
			{
				this._EquipmentType = value;
			}
		}

		// Token: 0x17000785 RID: 1925
		// (get) Token: 0x060021A9 RID: 8617 RVA: 0x000A2480 File Offset: 0x000A0680
		[ProtoMember(5, Name = "ArmyIds", DataFormat = DataFormat.TwosComplement)]
		public List<int> ArmyIds
		{
			get
			{
				return this._ArmyIds;
			}
		}

		// Token: 0x17000786 RID: 1926
		// (get) Token: 0x060021AA RID: 8618 RVA: 0x000A2488 File Offset: 0x000A0688
		// (set) Token: 0x060021AB RID: 8619 RVA: 0x000A2490 File Offset: 0x000A0690
		[ProtoMember(6, IsRequired = true, Name = "Desc", DataFormat = DataFormat.Default)]
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

		// Token: 0x17000787 RID: 1927
		// (get) Token: 0x060021AC RID: 8620 RVA: 0x000A249C File Offset: 0x000A069C
		[ProtoMember(7, Name = "JobIds", DataFormat = DataFormat.TwosComplement)]
		public List<int> JobIds
		{
			get
			{
				return this._JobIds;
			}
		}

		// Token: 0x17000788 RID: 1928
		// (get) Token: 0x060021AD RID: 8621 RVA: 0x000A24A4 File Offset: 0x000A06A4
		// (set) Token: 0x060021AE RID: 8622 RVA: 0x000A24AC File Offset: 0x000A06AC
		[ProtoMember(8, IsRequired = true, Name = "Rank", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17000789 RID: 1929
		// (get) Token: 0x060021AF RID: 8623 RVA: 0x000A24B8 File Offset: 0x000A06B8
		// (set) Token: 0x060021B0 RID: 8624 RVA: 0x000A24C0 File Offset: 0x000A06C0
		[ProtoMember(9, IsRequired = true, Name = "BornStarLevel", DataFormat = DataFormat.TwosComplement)]
		public int BornStarLevel
		{
			get
			{
				return this._BornStarLevel;
			}
			set
			{
				this._BornStarLevel = value;
			}
		}

		// Token: 0x1700078A RID: 1930
		// (get) Token: 0x060021B1 RID: 8625 RVA: 0x000A24CC File Offset: 0x000A06CC
		// (set) Token: 0x060021B2 RID: 8626 RVA: 0x000A24D4 File Offset: 0x000A06D4
		[ProtoMember(10, IsRequired = true, Name = "Property1_ID", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x1700078B RID: 1931
		// (get) Token: 0x060021B3 RID: 8627 RVA: 0x000A24E0 File Offset: 0x000A06E0
		// (set) Token: 0x060021B4 RID: 8628 RVA: 0x000A24E8 File Offset: 0x000A06E8
		[ProtoMember(11, IsRequired = true, Name = "Property1_Value", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x1700078C RID: 1932
		// (get) Token: 0x060021B5 RID: 8629 RVA: 0x000A24F4 File Offset: 0x000A06F4
		// (set) Token: 0x060021B6 RID: 8630 RVA: 0x000A24FC File Offset: 0x000A06FC
		[ProtoMember(12, IsRequired = true, Name = "Property1_LevelUpValue", DataFormat = DataFormat.TwosComplement)]
		public int Property1_LevelUpValue
		{
			get
			{
				return this._Property1_LevelUpValue;
			}
			set
			{
				this._Property1_LevelUpValue = value;
			}
		}

		// Token: 0x1700078D RID: 1933
		// (get) Token: 0x060021B7 RID: 8631 RVA: 0x000A2508 File Offset: 0x000A0708
		// (set) Token: 0x060021B8 RID: 8632 RVA: 0x000A2510 File Offset: 0x000A0710
		[ProtoMember(13, IsRequired = true, Name = "Property2_ID", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x1700078E RID: 1934
		// (get) Token: 0x060021B9 RID: 8633 RVA: 0x000A251C File Offset: 0x000A071C
		// (set) Token: 0x060021BA RID: 8634 RVA: 0x000A2524 File Offset: 0x000A0724
		[ProtoMember(14, IsRequired = true, Name = "Property2_Value", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x1700078F RID: 1935
		// (get) Token: 0x060021BB RID: 8635 RVA: 0x000A2530 File Offset: 0x000A0730
		// (set) Token: 0x060021BC RID: 8636 RVA: 0x000A2538 File Offset: 0x000A0738
		[ProtoMember(15, IsRequired = true, Name = "Property2_LevelUpValue", DataFormat = DataFormat.TwosComplement)]
		public int Property2_LevelUpValue
		{
			get
			{
				return this._Property2_LevelUpValue;
			}
			set
			{
				this._Property2_LevelUpValue = value;
			}
		}

		// Token: 0x17000790 RID: 1936
		// (get) Token: 0x060021BD RID: 8637 RVA: 0x000A2544 File Offset: 0x000A0744
		// (set) Token: 0x060021BE RID: 8638 RVA: 0x000A254C File Offset: 0x000A074C
		[ProtoMember(16, IsRequired = true, Name = "Exp", DataFormat = DataFormat.TwosComplement)]
		public int Exp
		{
			get
			{
				return this._Exp;
			}
			set
			{
				this._Exp = value;
			}
		}

		// Token: 0x17000791 RID: 1937
		// (get) Token: 0x060021BF RID: 8639 RVA: 0x000A2558 File Offset: 0x000A0758
		// (set) Token: 0x060021C0 RID: 8640 RVA: 0x000A2560 File Offset: 0x000A0760
		[ProtoMember(17, IsRequired = true, Name = "Icon", DataFormat = DataFormat.Default)]
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

		// Token: 0x17000792 RID: 1938
		// (get) Token: 0x060021C1 RID: 8641 RVA: 0x000A256C File Offset: 0x000A076C
		[ProtoMember(18, Name = "SkillIds", DataFormat = DataFormat.TwosComplement)]
		public List<int> SkillIds
		{
			get
			{
				return this._SkillIds;
			}
		}

		// Token: 0x17000793 RID: 1939
		// (get) Token: 0x060021C2 RID: 8642 RVA: 0x000A2574 File Offset: 0x000A0774
		[ProtoMember(19, Name = "SkillLevels", DataFormat = DataFormat.TwosComplement)]
		public List<int> SkillLevels
		{
			get
			{
				return this._SkillLevels;
			}
		}

		// Token: 0x17000794 RID: 1940
		// (get) Token: 0x060021C3 RID: 8643 RVA: 0x000A257C File Offset: 0x000A077C
		// (set) Token: 0x060021C4 RID: 8644 RVA: 0x000A2584 File Offset: 0x000A0784
		[ProtoMember(20, IsRequired = true, Name = "SkillHero", DataFormat = DataFormat.TwosComplement)]
		public int SkillHero
		{
			get
			{
				return this._SkillHero;
			}
			set
			{
				this._SkillHero = value;
			}
		}

		// Token: 0x17000795 RID: 1941
		// (get) Token: 0x060021C5 RID: 8645 RVA: 0x000A2590 File Offset: 0x000A0790
		// (set) Token: 0x060021C6 RID: 8646 RVA: 0x000A2598 File Offset: 0x000A0798
		[ProtoMember(21, IsRequired = true, Name = "SortIndex", DataFormat = DataFormat.TwosComplement)]
		public int SortIndex
		{
			get
			{
				return this._SortIndex;
			}
			set
			{
				this._SortIndex = value;
			}
		}

		// Token: 0x17000796 RID: 1942
		// (get) Token: 0x060021C7 RID: 8647 RVA: 0x000A25A4 File Offset: 0x000A07A4
		[ProtoMember(22, Name = "LevelUpGoods1", DataFormat = DataFormat.Default)]
		public List<Goods> LevelUpGoods1
		{
			get
			{
				return this._LevelUpGoods1;
			}
		}

		// Token: 0x17000797 RID: 1943
		// (get) Token: 0x060021C8 RID: 8648 RVA: 0x000A25AC File Offset: 0x000A07AC
		[ProtoMember(23, Name = "LevelUpGoods2", DataFormat = DataFormat.Default)]
		public List<Goods> LevelUpGoods2
		{
			get
			{
				return this._LevelUpGoods2;
			}
		}

		// Token: 0x17000798 RID: 1944
		// (get) Token: 0x060021C9 RID: 8649 RVA: 0x000A25B4 File Offset: 0x000A07B4
		[ProtoMember(24, Name = "LevelUpGoods3", DataFormat = DataFormat.Default)]
		public List<Goods> LevelUpGoods3
		{
			get
			{
				return this._LevelUpGoods3;
			}
		}

		// Token: 0x17000799 RID: 1945
		// (get) Token: 0x060021CA RID: 8650 RVA: 0x000A25BC File Offset: 0x000A07BC
		[ProtoMember(25, Name = "LevelUpGoods4", DataFormat = DataFormat.Default)]
		public List<Goods> LevelUpGoods4
		{
			get
			{
				return this._LevelUpGoods4;
			}
		}

		// Token: 0x1700079A RID: 1946
		// (get) Token: 0x060021CB RID: 8651 RVA: 0x000A25C4 File Offset: 0x000A07C4
		[ProtoMember(26, Name = "LevelUpGoods5", DataFormat = DataFormat.Default)]
		public List<Goods> LevelUpGoods5
		{
			get
			{
				return this._LevelUpGoods5;
			}
		}

		// Token: 0x1700079B RID: 1947
		// (get) Token: 0x060021CC RID: 8652 RVA: 0x000A25CC File Offset: 0x000A07CC
		[ProtoMember(28, Name = "GetPathList", DataFormat = DataFormat.Default)]
		public List<GetPathData> GetPathList
		{
			get
			{
				return this._GetPathList;
			}
		}

		// Token: 0x1700079C RID: 1948
		// (get) Token: 0x060021CD RID: 8653 RVA: 0x000A25D4 File Offset: 0x000A07D4
		// (set) Token: 0x060021CE RID: 8654 RVA: 0x000A25DC File Offset: 0x000A07DC
		[ProtoMember(29, IsRequired = true, Name = "GetPathDesc", DataFormat = DataFormat.Default)]
		public string GetPathDesc
		{
			get
			{
				return this._GetPathDesc;
			}
			set
			{
				this._GetPathDesc = value;
			}
		}

		// Token: 0x1700079D RID: 1949
		// (get) Token: 0x060021CF RID: 8655 RVA: 0x000A25E8 File Offset: 0x000A07E8
		// (set) Token: 0x060021D0 RID: 8656 RVA: 0x000A25F0 File Offset: 0x000A07F0
		[ProtoMember(30, IsRequired = true, Name = "AlchemyGold", DataFormat = DataFormat.TwosComplement)]
		public int AlchemyGold
		{
			get
			{
				return this._AlchemyGold;
			}
			set
			{
				this._AlchemyGold = value;
			}
		}

		// Token: 0x1700079E RID: 1950
		// (get) Token: 0x060021D1 RID: 8657 RVA: 0x000A25FC File Offset: 0x000A07FC
		// (set) Token: 0x060021D2 RID: 8658 RVA: 0x000A2604 File Offset: 0x000A0804
		[ProtoMember(31, IsRequired = true, Name = "RandomDropRewardID", DataFormat = DataFormat.TwosComplement)]
		public int RandomDropRewardID
		{
			get
			{
				return this._RandomDropRewardID;
			}
			set
			{
				this._RandomDropRewardID = value;
			}
		}

		// Token: 0x1700079F RID: 1951
		// (get) Token: 0x060021D3 RID: 8659 RVA: 0x000A2610 File Offset: 0x000A0810
		// (set) Token: 0x060021D4 RID: 8660 RVA: 0x000A2618 File Offset: 0x000A0818
		[ProtoMember(32, IsRequired = true, Name = "DisplayRewardCount", DataFormat = DataFormat.TwosComplement)]
		public int DisplayRewardCount
		{
			get
			{
				return this._DisplayRewardCount;
			}
			set
			{
				this._DisplayRewardCount = value;
			}
		}

		// Token: 0x170007A0 RID: 1952
		// (get) Token: 0x060021D5 RID: 8661 RVA: 0x000A2624 File Offset: 0x000A0824
		// (set) Token: 0x060021D6 RID: 8662 RVA: 0x000A262C File Offset: 0x000A082C
		[ProtoMember(33, IsRequired = true, Name = "ArchiveDisplay", DataFormat = DataFormat.Default)]
		public bool ArchiveDisplay
		{
			get
			{
				return this._ArchiveDisplay;
			}
			set
			{
				this._ArchiveDisplay = value;
			}
		}

		// Token: 0x170007A1 RID: 1953
		// (get) Token: 0x060021D7 RID: 8663 RVA: 0x000A2638 File Offset: 0x000A0838
		[ProtoMember(34, Name = "EnchantTemplateIds", DataFormat = DataFormat.TwosComplement)]
		public List<int> EnchantTemplateIds
		{
			get
			{
				return this._EnchantTemplateIds;
			}
		}

		// Token: 0x170007A2 RID: 1954
		// (get) Token: 0x060021D8 RID: 8664 RVA: 0x000A2640 File Offset: 0x000A0840
		// (set) Token: 0x060021D9 RID: 8665 RVA: 0x000A2648 File Offset: 0x000A0848
		[ProtoMember(35, IsRequired = true, Name = "EquipCoditionDesc", DataFormat = DataFormat.Default)]
		public string EquipCoditionDesc
		{
			get
			{
				return this._EquipCoditionDesc;
			}
			set
			{
				this._EquipCoditionDesc = value;
			}
		}

		// Token: 0x060021DA RID: 8666 RVA: 0x000A2654 File Offset: 0x000A0854
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060021DB RID: 8667 RVA: 0x000A2664 File Offset: 0x000A0864
		public int GetActiveSkillId(int equipmentLevel)
		{
			if (this.SkillLevels.Count == 0)
			{
				return 0;
			}
			int i;
			for (i = 0; i < this.SkillLevels.Count; i++)
			{
				if (equipmentLevel < this.SkillLevels[i])
				{
					break;
				}
			}
			if (i == 0)
			{
				return 0;
			}
			return this.SkillIds[i - 1];
		}

		// Token: 0x060021DC RID: 8668 RVA: 0x000A26CC File Offset: 0x000A08CC
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

		// Token: 0x060021DD RID: 8669 RVA: 0x000A2798 File Offset: 0x000A0998
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataEquipmentInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04001459 RID: 5209
		private int _ID;

		// Token: 0x0400145A RID: 5210
		private string _Name;

		// Token: 0x0400145B RID: 5211
		private EquipmentType _EquipmentType;

		// Token: 0x0400145C RID: 5212
		private readonly List<int> _ArmyIds = new List<int>();

		// Token: 0x0400145D RID: 5213
		private string _Desc;

		// Token: 0x0400145E RID: 5214
		private readonly List<int> _JobIds = new List<int>();

		// Token: 0x0400145F RID: 5215
		private int _Rank;

		// Token: 0x04001460 RID: 5216
		private int _BornStarLevel;

		// Token: 0x04001461 RID: 5217
		private PropertyModifyType _Property1_ID;

		// Token: 0x04001462 RID: 5218
		private int _Property1_Value;

		// Token: 0x04001463 RID: 5219
		private int _Property1_LevelUpValue;

		// Token: 0x04001464 RID: 5220
		private PropertyModifyType _Property2_ID;

		// Token: 0x04001465 RID: 5221
		private int _Property2_Value;

		// Token: 0x04001466 RID: 5222
		private int _Property2_LevelUpValue;

		// Token: 0x04001467 RID: 5223
		private int _Exp;

		// Token: 0x04001468 RID: 5224
		private string _Icon;

		// Token: 0x04001469 RID: 5225
		private readonly List<int> _SkillIds = new List<int>();

		// Token: 0x0400146A RID: 5226
		private readonly List<int> _SkillLevels = new List<int>();

		// Token: 0x0400146B RID: 5227
		private int _SkillHero;

		// Token: 0x0400146C RID: 5228
		private int _SortIndex;

		// Token: 0x0400146D RID: 5229
		private readonly List<Goods> _LevelUpGoods1 = new List<Goods>();

		// Token: 0x0400146E RID: 5230
		private readonly List<Goods> _LevelUpGoods2 = new List<Goods>();

		// Token: 0x0400146F RID: 5231
		private readonly List<Goods> _LevelUpGoods3 = new List<Goods>();

		// Token: 0x04001470 RID: 5232
		private readonly List<Goods> _LevelUpGoods4 = new List<Goods>();

		// Token: 0x04001471 RID: 5233
		private readonly List<Goods> _LevelUpGoods5 = new List<Goods>();

		// Token: 0x04001472 RID: 5234
		private readonly List<GetPathData> _GetPathList = new List<GetPathData>();

		// Token: 0x04001473 RID: 5235
		private string _GetPathDesc;

		// Token: 0x04001474 RID: 5236
		private int _AlchemyGold;

		// Token: 0x04001475 RID: 5237
		private int _RandomDropRewardID;

		// Token: 0x04001476 RID: 5238
		private int _DisplayRewardCount;

		// Token: 0x04001477 RID: 5239
		private bool _ArchiveDisplay;

		// Token: 0x04001478 RID: 5240
		private readonly List<int> _EnchantTemplateIds = new List<int>();

		// Token: 0x04001479 RID: 5241
		private string _EquipCoditionDesc;

		// Token: 0x0400147A RID: 5242
		private IExtension extensionObject;

		// Token: 0x0400147B RID: 5243
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400147C RID: 5244
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400147D RID: 5245
		private LuaFunction m_ctor_hotfix;
	}
}
