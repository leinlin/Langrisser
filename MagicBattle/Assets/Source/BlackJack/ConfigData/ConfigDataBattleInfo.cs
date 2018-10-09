using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x0200020D RID: 525
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ConfigDataBattleInfo")]
	[CustomLuaClass]
	[Serializable]
	public class ConfigDataBattleInfo : IExtensible
	{
		// Token: 0x06001E67 RID: 7783 RVA: 0x0009CE74 File Offset: 0x0009B074
		public ConfigDataBattleInfo()
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

		// Token: 0x170005FE RID: 1534
		// (get) Token: 0x06001E68 RID: 7784 RVA: 0x0009CFAC File Offset: 0x0009B1AC
		// (set) Token: 0x06001E69 RID: 7785 RVA: 0x0009CFB4 File Offset: 0x0009B1B4
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

		// Token: 0x170005FF RID: 1535
		// (get) Token: 0x06001E6A RID: 7786 RVA: 0x0009CFC0 File Offset: 0x0009B1C0
		// (set) Token: 0x06001E6B RID: 7787 RVA: 0x0009CFC8 File Offset: 0x0009B1C8
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

		// Token: 0x17000600 RID: 1536
		// (get) Token: 0x06001E6C RID: 7788 RVA: 0x0009CFD4 File Offset: 0x0009B1D4
		// (set) Token: 0x06001E6D RID: 7789 RVA: 0x0009CFDC File Offset: 0x0009B1DC
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

		// Token: 0x17000601 RID: 1537
		// (get) Token: 0x06001E6E RID: 7790 RVA: 0x0009CFE8 File Offset: 0x0009B1E8
		// (set) Token: 0x06001E6F RID: 7791 RVA: 0x0009CFF0 File Offset: 0x0009B1F0
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

		// Token: 0x17000602 RID: 1538
		// (get) Token: 0x06001E70 RID: 7792 RVA: 0x0009CFFC File Offset: 0x0009B1FC
		// (set) Token: 0x06001E71 RID: 7793 RVA: 0x0009D004 File Offset: 0x0009B204
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

		// Token: 0x17000603 RID: 1539
		// (get) Token: 0x06001E72 RID: 7794 RVA: 0x0009D010 File Offset: 0x0009B210
		// (set) Token: 0x06001E73 RID: 7795 RVA: 0x0009D018 File Offset: 0x0009B218
		[ProtoMember(7, IsRequired = true, Name = "WinDesc", DataFormat = DataFormat.Default)]
		public string WinDesc
		{
			get
			{
				return this._WinDesc;
			}
			set
			{
				this._WinDesc = value;
			}
		}

		// Token: 0x17000604 RID: 1540
		// (get) Token: 0x06001E74 RID: 7796 RVA: 0x0009D024 File Offset: 0x0009B224
		// (set) Token: 0x06001E75 RID: 7797 RVA: 0x0009D02C File Offset: 0x0009B22C
		[ProtoMember(8, IsRequired = true, Name = "WinDescStrKey", DataFormat = DataFormat.Default)]
		public string WinDescStrKey
		{
			get
			{
				return this._WinDescStrKey;
			}
			set
			{
				this._WinDescStrKey = value;
			}
		}

		// Token: 0x17000605 RID: 1541
		// (get) Token: 0x06001E76 RID: 7798 RVA: 0x0009D038 File Offset: 0x0009B238
		// (set) Token: 0x06001E77 RID: 7799 RVA: 0x0009D040 File Offset: 0x0009B240
		[ProtoMember(9, IsRequired = true, Name = "LoseDesc", DataFormat = DataFormat.Default)]
		public string LoseDesc
		{
			get
			{
				return this._LoseDesc;
			}
			set
			{
				this._LoseDesc = value;
			}
		}

		// Token: 0x17000606 RID: 1542
		// (get) Token: 0x06001E78 RID: 7800 RVA: 0x0009D04C File Offset: 0x0009B24C
		// (set) Token: 0x06001E79 RID: 7801 RVA: 0x0009D054 File Offset: 0x0009B254
		[ProtoMember(10, IsRequired = true, Name = "LoseDescStrKey", DataFormat = DataFormat.Default)]
		public string LoseDescStrKey
		{
			get
			{
				return this._LoseDescStrKey;
			}
			set
			{
				this._LoseDescStrKey = value;
			}
		}

		// Token: 0x17000607 RID: 1543
		// (get) Token: 0x06001E7A RID: 7802 RVA: 0x0009D060 File Offset: 0x0009B260
		// (set) Token: 0x06001E7B RID: 7803 RVA: 0x0009D068 File Offset: 0x0009B268
		[ProtoMember(11, IsRequired = true, Name = "Battlefield_ID", DataFormat = DataFormat.TwosComplement)]
		public int Battlefield_ID
		{
			get
			{
				return this._Battlefield_ID;
			}
			set
			{
				this._Battlefield_ID = value;
			}
		}

		// Token: 0x17000608 RID: 1544
		// (get) Token: 0x06001E7C RID: 7804 RVA: 0x0009D074 File Offset: 0x0009B274
		// (set) Token: 0x06001E7D RID: 7805 RVA: 0x0009D07C File Offset: 0x0009B27C
		[ProtoMember(12, IsRequired = true, Name = "CameraX", DataFormat = DataFormat.TwosComplement)]
		public int CameraX
		{
			get
			{
				return this._CameraX;
			}
			set
			{
				this._CameraX = value;
			}
		}

		// Token: 0x17000609 RID: 1545
		// (get) Token: 0x06001E7E RID: 7806 RVA: 0x0009D088 File Offset: 0x0009B288
		// (set) Token: 0x06001E7F RID: 7807 RVA: 0x0009D090 File Offset: 0x0009B290
		[ProtoMember(13, IsRequired = true, Name = "CameraY", DataFormat = DataFormat.TwosComplement)]
		public int CameraY
		{
			get
			{
				return this._CameraY;
			}
			set
			{
				this._CameraY = value;
			}
		}

		// Token: 0x1700060A RID: 1546
		// (get) Token: 0x06001E80 RID: 7808 RVA: 0x0009D09C File Offset: 0x0009B29C
		// (set) Token: 0x06001E81 RID: 7809 RVA: 0x0009D0A4 File Offset: 0x0009B2A4
		[ProtoMember(14, IsRequired = true, Name = "PrepareMusic", DataFormat = DataFormat.Default)]
		public string PrepareMusic
		{
			get
			{
				return this._PrepareMusic;
			}
			set
			{
				this._PrepareMusic = value;
			}
		}

		// Token: 0x1700060B RID: 1547
		// (get) Token: 0x06001E82 RID: 7810 RVA: 0x0009D0B0 File Offset: 0x0009B2B0
		// (set) Token: 0x06001E83 RID: 7811 RVA: 0x0009D0B8 File Offset: 0x0009B2B8
		[ProtoMember(15, IsRequired = true, Name = "BattleMusic", DataFormat = DataFormat.Default)]
		public string BattleMusic
		{
			get
			{
				return this._BattleMusic;
			}
			set
			{
				this._BattleMusic = value;
			}
		}

		// Token: 0x1700060C RID: 1548
		// (get) Token: 0x06001E84 RID: 7812 RVA: 0x0009D0C4 File Offset: 0x0009B2C4
		// (set) Token: 0x06001E85 RID: 7813 RVA: 0x0009D0CC File Offset: 0x0009B2CC
		[ProtoMember(16, IsRequired = true, Name = "EnemyBattleMusic", DataFormat = DataFormat.Default)]
		public string EnemyBattleMusic
		{
			get
			{
				return this._EnemyBattleMusic;
			}
			set
			{
				this._EnemyBattleMusic = value;
			}
		}

		// Token: 0x1700060D RID: 1549
		// (get) Token: 0x06001E86 RID: 7814 RVA: 0x0009D0D8 File Offset: 0x0009B2D8
		// (set) Token: 0x06001E87 RID: 7815 RVA: 0x0009D0E0 File Offset: 0x0009B2E0
		[ProtoMember(17, IsRequired = true, Name = "TurnMax", DataFormat = DataFormat.TwosComplement)]
		public int TurnMax
		{
			get
			{
				return this._TurnMax;
			}
			set
			{
				this._TurnMax = value;
			}
		}

		// Token: 0x1700060E RID: 1550
		// (get) Token: 0x06001E88 RID: 7816 RVA: 0x0009D0EC File Offset: 0x0009B2EC
		// (set) Token: 0x06001E89 RID: 7817 RVA: 0x0009D0F4 File Offset: 0x0009B2F4
		[ProtoMember(18, IsRequired = true, Name = "AllyNumber", DataFormat = DataFormat.TwosComplement)]
		public int AllyNumber
		{
			get
			{
				return this._AllyNumber;
			}
			set
			{
				this._AllyNumber = value;
			}
		}

		// Token: 0x1700060F RID: 1551
		// (get) Token: 0x06001E8A RID: 7818 RVA: 0x0009D100 File Offset: 0x0009B300
		[ProtoMember(19, Name = "AllyPositions", DataFormat = DataFormat.Default)]
		public List<ParamPosition> AllyPositions
		{
			get
			{
				return this._AllyPositions;
			}
		}

		// Token: 0x17000610 RID: 1552
		// (get) Token: 0x06001E8B RID: 7819 RVA: 0x0009D108 File Offset: 0x0009B308
		[ProtoMember(20, Name = "AllyDirs", DataFormat = DataFormat.TwosComplement)]
		public List<int> AllyDirs
		{
			get
			{
				return this._AllyDirs;
			}
		}

		// Token: 0x17000611 RID: 1553
		// (get) Token: 0x06001E8C RID: 7820 RVA: 0x0009D110 File Offset: 0x0009B310
		[ProtoMember(21, Name = "EnemyActors", DataFormat = DataFormat.Default)]
		public List<BattlePosActor> EnemyActors
		{
			get
			{
				return this._EnemyActors;
			}
		}

		// Token: 0x17000612 RID: 1554
		// (get) Token: 0x06001E8D RID: 7821 RVA: 0x0009D118 File Offset: 0x0009B318
		[ProtoMember(22, Name = "EnemyDirs", DataFormat = DataFormat.TwosComplement)]
		public List<int> EnemyDirs
		{
			get
			{
				return this._EnemyDirs;
			}
		}

		// Token: 0x17000613 RID: 1555
		// (get) Token: 0x06001E8E RID: 7822 RVA: 0x0009D120 File Offset: 0x0009B320
		[ProtoMember(23, Name = "EnemyActorsBehavior", DataFormat = DataFormat.TwosComplement)]
		public List<int> EnemyActorsBehavior
		{
			get
			{
				return this._EnemyActorsBehavior;
			}
		}

		// Token: 0x17000614 RID: 1556
		// (get) Token: 0x06001E8F RID: 7823 RVA: 0x0009D128 File Offset: 0x0009B328
		[ProtoMember(24, Name = "EnemyGroups", DataFormat = DataFormat.TwosComplement)]
		public List<int> EnemyGroups
		{
			get
			{
				return this._EnemyGroups;
			}
		}

		// Token: 0x17000615 RID: 1557
		// (get) Token: 0x06001E90 RID: 7824 RVA: 0x0009D130 File Offset: 0x0009B330
		[ProtoMember(25, Name = "EnemyGroupBehavior", DataFormat = DataFormat.TwosComplement)]
		public List<int> EnemyGroupBehavior
		{
			get
			{
				return this._EnemyGroupBehavior;
			}
		}

		// Token: 0x17000616 RID: 1558
		// (get) Token: 0x06001E91 RID: 7825 RVA: 0x0009D138 File Offset: 0x0009B338
		[ProtoMember(26, Name = "NpcActors", DataFormat = DataFormat.Default)]
		public List<BattlePosActor> NpcActors
		{
			get
			{
				return this._NpcActors;
			}
		}

		// Token: 0x17000617 RID: 1559
		// (get) Token: 0x06001E92 RID: 7826 RVA: 0x0009D140 File Offset: 0x0009B340
		[ProtoMember(27, Name = "NpcDirs", DataFormat = DataFormat.TwosComplement)]
		public List<int> NpcDirs
		{
			get
			{
				return this._NpcDirs;
			}
		}

		// Token: 0x17000618 RID: 1560
		// (get) Token: 0x06001E93 RID: 7827 RVA: 0x0009D148 File Offset: 0x0009B348
		[ProtoMember(28, Name = "NpcActorsBehavior", DataFormat = DataFormat.TwosComplement)]
		public List<int> NpcActorsBehavior
		{
			get
			{
				return this._NpcActorsBehavior;
			}
		}

		// Token: 0x17000619 RID: 1561
		// (get) Token: 0x06001E94 RID: 7828 RVA: 0x0009D150 File Offset: 0x0009B350
		[ProtoMember(29, Name = "NpcGroups", DataFormat = DataFormat.TwosComplement)]
		public List<int> NpcGroups
		{
			get
			{
				return this._NpcGroups;
			}
		}

		// Token: 0x1700061A RID: 1562
		// (get) Token: 0x06001E95 RID: 7829 RVA: 0x0009D158 File Offset: 0x0009B358
		[ProtoMember(30, Name = "NpcGroupBehavior", DataFormat = DataFormat.TwosComplement)]
		public List<int> NpcGroupBehavior
		{
			get
			{
				return this._NpcGroupBehavior;
			}
		}

		// Token: 0x1700061B RID: 1563
		// (get) Token: 0x06001E96 RID: 7830 RVA: 0x0009D160 File Offset: 0x0009B360
		[ProtoMember(31, Name = "WinConditions_ID", DataFormat = DataFormat.TwosComplement)]
		public List<int> WinConditions_ID
		{
			get
			{
				return this._WinConditions_ID;
			}
		}

		// Token: 0x1700061C RID: 1564
		// (get) Token: 0x06001E97 RID: 7831 RVA: 0x0009D168 File Offset: 0x0009B368
		[ProtoMember(32, Name = "LoseConditions_ID", DataFormat = DataFormat.TwosComplement)]
		public List<int> LoseConditions_ID
		{
			get
			{
				return this._LoseConditions_ID;
			}
		}

		// Token: 0x1700061D RID: 1565
		// (get) Token: 0x06001E98 RID: 7832 RVA: 0x0009D170 File Offset: 0x0009B370
		[ProtoMember(33, Name = "EventTriggers_ID", DataFormat = DataFormat.TwosComplement)]
		public List<int> EventTriggers_ID
		{
			get
			{
				return this._EventTriggers_ID;
			}
		}

		// Token: 0x1700061E RID: 1566
		// (get) Token: 0x06001E99 RID: 7833 RVA: 0x0009D178 File Offset: 0x0009B378
		[ProtoMember(34, Name = "BattleTreasures_ID", DataFormat = DataFormat.TwosComplement)]
		public List<int> BattleTreasures_ID
		{
			get
			{
				return this._BattleTreasures_ID;
			}
		}

		// Token: 0x1700061F RID: 1567
		// (get) Token: 0x06001E9A RID: 7834 RVA: 0x0009D180 File Offset: 0x0009B380
		// (set) Token: 0x06001E9B RID: 7835 RVA: 0x0009D188 File Offset: 0x0009B388
		[ProtoMember(35, IsRequired = true, Name = "BeforePerformBattle_ID", DataFormat = DataFormat.TwosComplement)]
		public int BeforePerformBattle_ID
		{
			get
			{
				return this._BeforePerformBattle_ID;
			}
			set
			{
				this._BeforePerformBattle_ID = value;
			}
		}

		// Token: 0x17000620 RID: 1568
		// (get) Token: 0x06001E9C RID: 7836 RVA: 0x0009D194 File Offset: 0x0009B394
		// (set) Token: 0x06001E9D RID: 7837 RVA: 0x0009D19C File Offset: 0x0009B39C
		[ProtoMember(36, IsRequired = true, Name = "AfterPerformBattle_ID", DataFormat = DataFormat.TwosComplement)]
		public int AfterPerformBattle_ID
		{
			get
			{
				return this._AfterPerformBattle_ID;
			}
			set
			{
				this._AfterPerformBattle_ID = value;
			}
		}

		// Token: 0x17000621 RID: 1569
		// (get) Token: 0x06001E9E RID: 7838 RVA: 0x0009D1A8 File Offset: 0x0009B3A8
		// (set) Token: 0x06001E9F RID: 7839 RVA: 0x0009D1B0 File Offset: 0x0009B3B0
		[ProtoMember(37, IsRequired = true, Name = "BattlePerform_ID", DataFormat = DataFormat.TwosComplement)]
		public int BattlePerform_ID
		{
			get
			{
				return this._BattlePerform_ID;
			}
			set
			{
				this._BattlePerform_ID = value;
			}
		}

		// Token: 0x17000622 RID: 1570
		// (get) Token: 0x06001EA0 RID: 7840 RVA: 0x0009D1BC File Offset: 0x0009B3BC
		[ProtoMember(38, Name = "BattleRandomEnemies_ID", DataFormat = DataFormat.TwosComplement)]
		public List<int> BattleRandomEnemies_ID
		{
			get
			{
				return this._BattleRandomEnemies_ID;
			}
		}

		// Token: 0x17000623 RID: 1571
		// (get) Token: 0x06001EA1 RID: 7841 RVA: 0x0009D1C4 File Offset: 0x0009B3C4
		// (set) Token: 0x06001EA2 RID: 7842 RVA: 0x0009D1CC File Offset: 0x0009B3CC
		[ProtoMember(39, IsRequired = true, Name = "BattleEnemyRandomRule", DataFormat = DataFormat.TwosComplement)]
		public BattleArmyRandomRuleType BattleEnemyRandomRule
		{
			get
			{
				return this._BattleEnemyRandomRule;
			}
			set
			{
				this._BattleEnemyRandomRule = value;
			}
		}

		// Token: 0x17000624 RID: 1572
		// (get) Token: 0x06001EA3 RID: 7843 RVA: 0x0009D1D8 File Offset: 0x0009B3D8
		// (set) Token: 0x06001EA4 RID: 7844 RVA: 0x0009D1E0 File Offset: 0x0009B3E0
		[ProtoMember(40, IsRequired = true, Name = "EnemyRandomTalent_ID", DataFormat = DataFormat.TwosComplement)]
		public int EnemyRandomTalent_ID
		{
			get
			{
				return this._EnemyRandomTalent_ID;
			}
			set
			{
				this._EnemyRandomTalent_ID = value;
			}
		}

		// Token: 0x17000625 RID: 1573
		// (get) Token: 0x06001EA5 RID: 7845 RVA: 0x0009D1EC File Offset: 0x0009B3EC
		[ProtoMember(41, Name = "EnemyRandomTalentProbilities", DataFormat = DataFormat.TwosComplement)]
		public List<int> EnemyRandomTalentProbilities
		{
			get
			{
				return this._EnemyRandomTalentProbilities;
			}
		}

		// Token: 0x17000626 RID: 1574
		// (get) Token: 0x06001EA6 RID: 7846 RVA: 0x0009D1F4 File Offset: 0x0009B3F4
		[ProtoMember(42, Name = "ImperativeBattleHeroes_ID", DataFormat = DataFormat.TwosComplement)]
		public List<int> ImperativeBattleHeroes_ID
		{
			get
			{
				return this._ImperativeBattleHeroes_ID;
			}
		}

		// Token: 0x06001EA7 RID: 7847 RVA: 0x0009D1FC File Offset: 0x0009B3FC
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06001EA8 RID: 7848 RVA: 0x0009D20C File Offset: 0x0009B40C
		public bool Initialize()
		{
			this.m_enemyGroupBehaviors = ConfigDataBattleEventActionInfo.ComputeGroupBehaviorDict(this.EnemyGroups, this.EnemyGroupBehavior);
			this.m_npcGroupBehaviors = ConfigDataBattleEventActionInfo.ComputeGroupBehaviorDict(this.NpcGroups, this.NpcGroupBehavior);
			return true;
		}

		// Token: 0x06001EA9 RID: 7849 RVA: 0x0009D240 File Offset: 0x0009B440
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

		// Token: 0x06001EAA RID: 7850 RVA: 0x0009D30C File Offset: 0x0009B50C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataBattleInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400123A RID: 4666
		private int _ID;

		// Token: 0x0400123B RID: 4667
		private string _Name;

		// Token: 0x0400123C RID: 4668
		private string _NameStrKey;

		// Token: 0x0400123D RID: 4669
		private string _Desc;

		// Token: 0x0400123E RID: 4670
		private string _DescStrKey;

		// Token: 0x0400123F RID: 4671
		private string _WinDesc;

		// Token: 0x04001240 RID: 4672
		private string _WinDescStrKey;

		// Token: 0x04001241 RID: 4673
		private string _LoseDesc;

		// Token: 0x04001242 RID: 4674
		private string _LoseDescStrKey;

		// Token: 0x04001243 RID: 4675
		private int _Battlefield_ID;

		// Token: 0x04001244 RID: 4676
		private int _CameraX;

		// Token: 0x04001245 RID: 4677
		private int _CameraY;

		// Token: 0x04001246 RID: 4678
		private string _PrepareMusic;

		// Token: 0x04001247 RID: 4679
		private string _BattleMusic;

		// Token: 0x04001248 RID: 4680
		private string _EnemyBattleMusic;

		// Token: 0x04001249 RID: 4681
		private int _TurnMax;

		// Token: 0x0400124A RID: 4682
		private int _AllyNumber;

		// Token: 0x0400124B RID: 4683
		private readonly List<ParamPosition> _AllyPositions = new List<ParamPosition>();

		// Token: 0x0400124C RID: 4684
		private readonly List<int> _AllyDirs = new List<int>();

		// Token: 0x0400124D RID: 4685
		private readonly List<BattlePosActor> _EnemyActors = new List<BattlePosActor>();

		// Token: 0x0400124E RID: 4686
		private readonly List<int> _EnemyDirs = new List<int>();

		// Token: 0x0400124F RID: 4687
		private readonly List<int> _EnemyActorsBehavior = new List<int>();

		// Token: 0x04001250 RID: 4688
		private readonly List<int> _EnemyGroups = new List<int>();

		// Token: 0x04001251 RID: 4689
		private readonly List<int> _EnemyGroupBehavior = new List<int>();

		// Token: 0x04001252 RID: 4690
		private readonly List<BattlePosActor> _NpcActors = new List<BattlePosActor>();

		// Token: 0x04001253 RID: 4691
		private readonly List<int> _NpcDirs = new List<int>();

		// Token: 0x04001254 RID: 4692
		private readonly List<int> _NpcActorsBehavior = new List<int>();

		// Token: 0x04001255 RID: 4693
		private readonly List<int> _NpcGroups = new List<int>();

		// Token: 0x04001256 RID: 4694
		private readonly List<int> _NpcGroupBehavior = new List<int>();

		// Token: 0x04001257 RID: 4695
		private readonly List<int> _WinConditions_ID = new List<int>();

		// Token: 0x04001258 RID: 4696
		private readonly List<int> _LoseConditions_ID = new List<int>();

		// Token: 0x04001259 RID: 4697
		private readonly List<int> _EventTriggers_ID = new List<int>();

		// Token: 0x0400125A RID: 4698
		private readonly List<int> _BattleTreasures_ID = new List<int>();

		// Token: 0x0400125B RID: 4699
		private int _BeforePerformBattle_ID;

		// Token: 0x0400125C RID: 4700
		private int _AfterPerformBattle_ID;

		// Token: 0x0400125D RID: 4701
		private int _BattlePerform_ID;

		// Token: 0x0400125E RID: 4702
		private readonly List<int> _BattleRandomEnemies_ID = new List<int>();

		// Token: 0x0400125F RID: 4703
		private BattleArmyRandomRuleType _BattleEnemyRandomRule;

		// Token: 0x04001260 RID: 4704
		private int _EnemyRandomTalent_ID;

		// Token: 0x04001261 RID: 4705
		private readonly List<int> _EnemyRandomTalentProbilities = new List<int>();

		// Token: 0x04001262 RID: 4706
		private readonly List<int> _ImperativeBattleHeroes_ID = new List<int>();

		// Token: 0x04001263 RID: 4707
		private IExtension extensionObject;

		// Token: 0x04001264 RID: 4708
		public ConfigDataBattlefieldInfo m_battlefieldInfo;

		// Token: 0x04001265 RID: 4709
		public ConfigDataBattleWinConditionInfo[] m_battleWinConditionInfos;

		// Token: 0x04001266 RID: 4710
		public ConfigDataBattleLoseConditionInfo[] m_battleLoseConditionInfos;

		// Token: 0x04001267 RID: 4711
		public ConfigDataBattleEventTriggerInfo[] m_battleEventTriggerInfos;

		// Token: 0x04001268 RID: 4712
		public ConfigDataBattleTreasureInfo[] m_battleTreasureInfos;

		// Token: 0x04001269 RID: 4713
		public ConfigDataBattleInfo m_beforePerformBattleInfo;

		// Token: 0x0400126A RID: 4714
		public ConfigDataBattleInfo m_afterPerformBattleInfo;

		// Token: 0x0400126B RID: 4715
		public ConfigDataBattlePerformInfo m_battlePerformInfo;

		// Token: 0x0400126C RID: 4716
		public Dictionary<int, int> m_enemyGroupBehaviors;

		// Token: 0x0400126D RID: 4717
		public Dictionary<int, int> m_npcGroupBehaviors;

		// Token: 0x0400126E RID: 4718
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400126F RID: 4719
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04001270 RID: 4720
		private LuaFunction m_ctor_hotfix;
	}
}
