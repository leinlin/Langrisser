using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200065C RID: 1628
	[ProtoContract(Name = "ProBattleHero")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ProBattleHero : IExtensible
	{
		// Token: 0x060058C7 RID: 22727 RVA: 0x0019C060 File Offset: 0x0019A260
		public ProBattleHero()
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

		// Token: 0x17001619 RID: 5657
		// (get) Token: 0x060058C8 RID: 22728 RVA: 0x0019C0F4 File Offset: 0x0019A2F4
		// (set) Token: 0x060058C9 RID: 22729 RVA: 0x0019C0FC File Offset: 0x0019A2FC
		[ProtoMember(1, IsRequired = true, Name = "HeroId", DataFormat = DataFormat.TwosComplement)]
		public int HeroId
		{
			get
			{
				return this._HeroId;
			}
			set
			{
				this._HeroId = value;
			}
		}

		// Token: 0x1700161A RID: 5658
		// (get) Token: 0x060058CA RID: 22730 RVA: 0x0019C108 File Offset: 0x0019A308
		// (set) Token: 0x060058CB RID: 22731 RVA: 0x0019C110 File Offset: 0x0019A310
		[ProtoMember(2, IsRequired = true, Name = "ActionPositionIndex", DataFormat = DataFormat.TwosComplement)]
		public int ActionPositionIndex
		{
			get
			{
				return this._ActionPositionIndex;
			}
			set
			{
				this._ActionPositionIndex = value;
			}
		}

		// Token: 0x1700161B RID: 5659
		// (get) Token: 0x060058CC RID: 22732 RVA: 0x0019C11C File Offset: 0x0019A31C
		// (set) Token: 0x060058CD RID: 22733 RVA: 0x0019C124 File Offset: 0x0019A324
		[ProtoMember(3, IsRequired = true, Name = "ActionValue", DataFormat = DataFormat.TwosComplement)]
		public int ActionValue
		{
			get
			{
				return this._ActionValue;
			}
			set
			{
				this._ActionValue = value;
			}
		}

		// Token: 0x1700161C RID: 5660
		// (get) Token: 0x060058CE RID: 22734 RVA: 0x0019C130 File Offset: 0x0019A330
		// (set) Token: 0x060058CF RID: 22735 RVA: 0x0019C138 File Offset: 0x0019A338
		[ProtoMember(4, IsRequired = true, Name = "Level", DataFormat = DataFormat.TwosComplement)]
		public int Level
		{
			get
			{
				return this._Level;
			}
			set
			{
				this._Level = value;
			}
		}

		// Token: 0x1700161D RID: 5661
		// (get) Token: 0x060058D0 RID: 22736 RVA: 0x0019C144 File Offset: 0x0019A344
		// (set) Token: 0x060058D1 RID: 22737 RVA: 0x0019C14C File Offset: 0x0019A34C
		[ProtoMember(5, IsRequired = true, Name = "StarLevel", DataFormat = DataFormat.TwosComplement)]
		public int StarLevel
		{
			get
			{
				return this._StarLevel;
			}
			set
			{
				this._StarLevel = value;
			}
		}

		// Token: 0x1700161E RID: 5662
		// (get) Token: 0x060058D2 RID: 22738 RVA: 0x0019C158 File Offset: 0x0019A358
		// (set) Token: 0x060058D3 RID: 22739 RVA: 0x0019C160 File Offset: 0x0019A360
		[ProtoMember(6, IsRequired = true, Name = "ActiveHeroJobRelatedId", DataFormat = DataFormat.TwosComplement)]
		public int ActiveHeroJobRelatedId
		{
			get
			{
				return this._ActiveHeroJobRelatedId;
			}
			set
			{
				this._ActiveHeroJobRelatedId = value;
			}
		}

		// Token: 0x1700161F RID: 5663
		// (get) Token: 0x060058D4 RID: 22740 RVA: 0x0019C16C File Offset: 0x0019A36C
		[ProtoMember(7, Name = "Jobs", DataFormat = DataFormat.Default)]
		public List<ProBattleHeroJob> Jobs
		{
			get
			{
				return this._Jobs;
			}
		}

		// Token: 0x17001620 RID: 5664
		// (get) Token: 0x060058D5 RID: 22741 RVA: 0x0019C174 File Offset: 0x0019A374
		[ProtoMember(8, Name = "SelectedSkillList", DataFormat = DataFormat.TwosComplement)]
		public List<int> SelectedSkillList
		{
			get
			{
				return this._SelectedSkillList;
			}
		}

		// Token: 0x17001621 RID: 5665
		// (get) Token: 0x060058D6 RID: 22742 RVA: 0x0019C17C File Offset: 0x0019A37C
		// (set) Token: 0x060058D7 RID: 22743 RVA: 0x0019C184 File Offset: 0x0019A384
		[ProtoMember(9, IsRequired = true, Name = "SelectedSoldierId", DataFormat = DataFormat.TwosComplement)]
		public int SelectedSoldierId
		{
			get
			{
				return this._SelectedSoldierId;
			}
			set
			{
				this._SelectedSoldierId = value;
			}
		}

		// Token: 0x17001622 RID: 5666
		// (get) Token: 0x060058D8 RID: 22744 RVA: 0x0019C190 File Offset: 0x0019A390
		[ProtoMember(10, Name = "Equipments", DataFormat = DataFormat.Default)]
		public List<ProBattleHeroEquipment> Equipments
		{
			get
			{
				return this._Equipments;
			}
		}

		// Token: 0x17001623 RID: 5667
		// (get) Token: 0x060058D9 RID: 22745 RVA: 0x0019C198 File Offset: 0x0019A398
		[ProtoMember(11, Name = "Fetters", DataFormat = DataFormat.Default)]
		public List<ProHeroFetter> Fetters
		{
			get
			{
				return this._Fetters;
			}
		}

		// Token: 0x17001624 RID: 5668
		// (get) Token: 0x060058DA RID: 22746 RVA: 0x0019C1A0 File Offset: 0x0019A3A0
		// (set) Token: 0x060058DB RID: 22747 RVA: 0x0019C1A8 File Offset: 0x0019A3A8
		[ProtoMember(12, IsRequired = true, Name = "Power", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17001625 RID: 5669
		// (get) Token: 0x060058DC RID: 22748 RVA: 0x0019C1B4 File Offset: 0x0019A3B4
		// (set) Token: 0x060058DD RID: 22749 RVA: 0x0019C1BC File Offset: 0x0019A3BC
		[ProtoMember(13, IsRequired = true, Name = "ModelSkinId", DataFormat = DataFormat.TwosComplement)]
		public int ModelSkinId
		{
			get
			{
				return this._ModelSkinId;
			}
			set
			{
				this._ModelSkinId = value;
			}
		}

		// Token: 0x17001626 RID: 5670
		// (get) Token: 0x060058DE RID: 22750 RVA: 0x0019C1C8 File Offset: 0x0019A3C8
		// (set) Token: 0x060058DF RID: 22751 RVA: 0x0019C1D0 File Offset: 0x0019A3D0
		[ProtoMember(14, IsRequired = true, Name = "SelectedSoldierSkinId", DataFormat = DataFormat.TwosComplement)]
		public int SelectedSoldierSkinId
		{
			get
			{
				return this._SelectedSoldierSkinId;
			}
			set
			{
				this._SelectedSoldierSkinId = value;
			}
		}

		// Token: 0x17001627 RID: 5671
		// (get) Token: 0x060058E0 RID: 22752 RVA: 0x0019C1DC File Offset: 0x0019A3DC
		// (set) Token: 0x060058E1 RID: 22753 RVA: 0x0019C1E4 File Offset: 0x0019A3E4
		[ProtoMember(15, IsRequired = true, Name = "CharSkinId", DataFormat = DataFormat.TwosComplement)]
		public int CharSkinId
		{
			get
			{
				return this._CharSkinId;
			}
			set
			{
				this._CharSkinId = value;
			}
		}

		// Token: 0x060058E2 RID: 22754 RVA: 0x0019C1F0 File Offset: 0x0019A3F0
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060058E3 RID: 22755 RVA: 0x0019C200 File Offset: 0x0019A400
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

		// Token: 0x060058E4 RID: 22756 RVA: 0x0019C2CC File Offset: 0x0019A4CC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProBattleHero));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400429F RID: 17055
		private int _HeroId;

		// Token: 0x040042A0 RID: 17056
		private int _ActionPositionIndex;

		// Token: 0x040042A1 RID: 17057
		private int _ActionValue;

		// Token: 0x040042A2 RID: 17058
		private int _Level;

		// Token: 0x040042A3 RID: 17059
		private int _StarLevel;

		// Token: 0x040042A4 RID: 17060
		private int _ActiveHeroJobRelatedId;

		// Token: 0x040042A5 RID: 17061
		private readonly List<ProBattleHeroJob> _Jobs = new List<ProBattleHeroJob>();

		// Token: 0x040042A6 RID: 17062
		private readonly List<int> _SelectedSkillList = new List<int>();

		// Token: 0x040042A7 RID: 17063
		private int _SelectedSoldierId;

		// Token: 0x040042A8 RID: 17064
		private readonly List<ProBattleHeroEquipment> _Equipments = new List<ProBattleHeroEquipment>();

		// Token: 0x040042A9 RID: 17065
		private readonly List<ProHeroFetter> _Fetters = new List<ProHeroFetter>();

		// Token: 0x040042AA RID: 17066
		private int _Power;

		// Token: 0x040042AB RID: 17067
		private int _ModelSkinId;

		// Token: 0x040042AC RID: 17068
		private int _SelectedSoldierSkinId;

		// Token: 0x040042AD RID: 17069
		private int _CharSkinId;

		// Token: 0x040042AE RID: 17070
		private IExtension extensionObject;

		// Token: 0x040042AF RID: 17071
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040042B0 RID: 17072
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040042B1 RID: 17073
		private LuaFunction m_ctor_hotfix;
	}
}
