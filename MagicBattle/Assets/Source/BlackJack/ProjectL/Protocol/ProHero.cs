using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200063F RID: 1599
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ProHero")]
	[Serializable]
	public class ProHero : IExtensible
	{
		// Token: 0x06005772 RID: 22386 RVA: 0x00198618 File Offset: 0x00196818
		public ProHero()
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

		// Token: 0x1700159C RID: 5532
		// (get) Token: 0x06005773 RID: 22387 RVA: 0x001986C0 File Offset: 0x001968C0
		// (set) Token: 0x06005774 RID: 22388 RVA: 0x001986C8 File Offset: 0x001968C8
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

		// Token: 0x1700159D RID: 5533
		// (get) Token: 0x06005775 RID: 22389 RVA: 0x001986D4 File Offset: 0x001968D4
		// (set) Token: 0x06005776 RID: 22390 RVA: 0x001986DC File Offset: 0x001968DC
		[ProtoMember(2, IsRequired = true, Name = "Level", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x1700159E RID: 5534
		// (get) Token: 0x06005777 RID: 22391 RVA: 0x001986E8 File Offset: 0x001968E8
		// (set) Token: 0x06005778 RID: 22392 RVA: 0x001986F0 File Offset: 0x001968F0
		[ProtoMember(3, IsRequired = true, Name = "Exp", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x1700159F RID: 5535
		// (get) Token: 0x06005779 RID: 22393 RVA: 0x001986FC File Offset: 0x001968FC
		// (set) Token: 0x0600577A RID: 22394 RVA: 0x00198704 File Offset: 0x00196904
		[ProtoMember(4, IsRequired = true, Name = "StarLevel", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x170015A0 RID: 5536
		// (get) Token: 0x0600577B RID: 22395 RVA: 0x00198710 File Offset: 0x00196910
		// (set) Token: 0x0600577C RID: 22396 RVA: 0x00198718 File Offset: 0x00196918
		[ProtoMember(5, IsRequired = true, Name = "ActiveJobRelatedId", DataFormat = DataFormat.TwosComplement)]
		public int ActiveJobRelatedId
		{
			get
			{
				return this._ActiveJobRelatedId;
			}
			set
			{
				this._ActiveJobRelatedId = value;
			}
		}

		// Token: 0x170015A1 RID: 5537
		// (get) Token: 0x0600577D RID: 22397 RVA: 0x00198724 File Offset: 0x00196924
		[ProtoMember(6, Name = "Jobs", DataFormat = DataFormat.Default)]
		public List<ProHeroJob> Jobs
		{
			get
			{
				return this._Jobs;
			}
		}

		// Token: 0x170015A2 RID: 5538
		// (get) Token: 0x0600577E RID: 22398 RVA: 0x0019872C File Offset: 0x0019692C
		[ProtoMember(7, Name = "SelectedSkills", DataFormat = DataFormat.TwosComplement)]
		public List<int> SelectedSkills
		{
			get
			{
				return this._SelectedSkills;
			}
		}

		// Token: 0x170015A3 RID: 5539
		// (get) Token: 0x0600577F RID: 22399 RVA: 0x00198734 File Offset: 0x00196934
		// (set) Token: 0x06005780 RID: 22400 RVA: 0x0019873C File Offset: 0x0019693C
		[ProtoMember(8, IsRequired = true, Name = "SelectedSoldierId", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x170015A4 RID: 5540
		// (get) Token: 0x06005781 RID: 22401 RVA: 0x00198748 File Offset: 0x00196948
		[ProtoMember(9, Name = "UnlockedJobs", DataFormat = DataFormat.TwosComplement)]
		public List<int> UnlockedJobs
		{
			get
			{
				return this._UnlockedJobs;
			}
		}

		// Token: 0x170015A5 RID: 5541
		// (get) Token: 0x06005782 RID: 22402 RVA: 0x00198750 File Offset: 0x00196950
		// (set) Token: 0x06005783 RID: 22403 RVA: 0x00198758 File Offset: 0x00196958
		[ProtoMember(10, IsRequired = true, Name = "FightNums", DataFormat = DataFormat.TwosComplement)]
		public int FightNums
		{
			get
			{
				return this._FightNums;
			}
			set
			{
				this._FightNums = value;
			}
		}

		// Token: 0x170015A6 RID: 5542
		// (get) Token: 0x06005784 RID: 22404 RVA: 0x00198764 File Offset: 0x00196964
		[ProtoMember(11, Name = "EquipmentIds", DataFormat = DataFormat.TwosComplement)]
		public List<ulong> EquipmentIds
		{
			get
			{
				return this._EquipmentIds;
			}
		}

		// Token: 0x170015A7 RID: 5543
		// (get) Token: 0x06005785 RID: 22405 RVA: 0x0019876C File Offset: 0x0019696C
		// (set) Token: 0x06005786 RID: 22406 RVA: 0x00198774 File Offset: 0x00196974
		[ProtoMember(12, IsRequired = true, Name = "FavorabilityLevel", DataFormat = DataFormat.TwosComplement)]
		public int FavorabilityLevel
		{
			get
			{
				return this._FavorabilityLevel;
			}
			set
			{
				this._FavorabilityLevel = value;
			}
		}

		// Token: 0x170015A8 RID: 5544
		// (get) Token: 0x06005787 RID: 22407 RVA: 0x00198780 File Offset: 0x00196980
		// (set) Token: 0x06005788 RID: 22408 RVA: 0x00198788 File Offset: 0x00196988
		[ProtoMember(13, IsRequired = true, Name = "FavorabilityExp", DataFormat = DataFormat.TwosComplement)]
		public int FavorabilityExp
		{
			get
			{
				return this._FavorabilityExp;
			}
			set
			{
				this._FavorabilityExp = value;
			}
		}

		// Token: 0x170015A9 RID: 5545
		// (get) Token: 0x06005789 RID: 22409 RVA: 0x00198794 File Offset: 0x00196994
		[ProtoMember(14, Name = "Fetters", DataFormat = DataFormat.Default)]
		public List<ProHeroFetter> Fetters
		{
			get
			{
				return this._Fetters;
			}
		}

		// Token: 0x170015AA RID: 5546
		// (get) Token: 0x0600578A RID: 22410 RVA: 0x0019879C File Offset: 0x0019699C
		// (set) Token: 0x0600578B RID: 22411 RVA: 0x001987A4 File Offset: 0x001969A4
		[ProtoMember(15, IsRequired = true, Name = "Confessed", DataFormat = DataFormat.Default)]
		public bool Confessed
		{
			get
			{
				return this._Confessed;
			}
			set
			{
				this._Confessed = value;
			}
		}

		// Token: 0x170015AB RID: 5547
		// (get) Token: 0x0600578C RID: 22412 RVA: 0x001987B0 File Offset: 0x001969B0
		// (set) Token: 0x0600578D RID: 22413 RVA: 0x001987B8 File Offset: 0x001969B8
		[ProtoMember(16, IsRequired = true, Name = "Power", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x170015AC RID: 5548
		// (get) Token: 0x0600578E RID: 22414 RVA: 0x001987C4 File Offset: 0x001969C4
		// (set) Token: 0x0600578F RID: 22415 RVA: 0x001987CC File Offset: 0x001969CC
		[ProtoMember(17, IsRequired = true, Name = "CharSkinId", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x170015AD RID: 5549
		// (get) Token: 0x06005790 RID: 22416 RVA: 0x001987D8 File Offset: 0x001969D8
		[ProtoMember(18, Name = "SoldierSkins", DataFormat = DataFormat.Default)]
		public List<ProSoldierSkin> SoldierSkins
		{
			get
			{
				return this._SoldierSkins;
			}
		}

		// Token: 0x06005791 RID: 22417 RVA: 0x001987E0 File Offset: 0x001969E0
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005792 RID: 22418 RVA: 0x001987F0 File Offset: 0x001969F0
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

		// Token: 0x06005793 RID: 22419 RVA: 0x001988BC File Offset: 0x00196ABC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProHero));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040041AE RID: 16814
		private int _HeroId;

		// Token: 0x040041AF RID: 16815
		private int _Level;

		// Token: 0x040041B0 RID: 16816
		private int _Exp;

		// Token: 0x040041B1 RID: 16817
		private int _StarLevel;

		// Token: 0x040041B2 RID: 16818
		private int _ActiveJobRelatedId;

		// Token: 0x040041B3 RID: 16819
		private readonly List<ProHeroJob> _Jobs = new List<ProHeroJob>();

		// Token: 0x040041B4 RID: 16820
		private readonly List<int> _SelectedSkills = new List<int>();

		// Token: 0x040041B5 RID: 16821
		private int _SelectedSoldierId;

		// Token: 0x040041B6 RID: 16822
		private readonly List<int> _UnlockedJobs = new List<int>();

		// Token: 0x040041B7 RID: 16823
		private int _FightNums;

		// Token: 0x040041B8 RID: 16824
		private readonly List<ulong> _EquipmentIds = new List<ulong>();

		// Token: 0x040041B9 RID: 16825
		private int _FavorabilityLevel;

		// Token: 0x040041BA RID: 16826
		private int _FavorabilityExp;

		// Token: 0x040041BB RID: 16827
		private readonly List<ProHeroFetter> _Fetters = new List<ProHeroFetter>();

		// Token: 0x040041BC RID: 16828
		private bool _Confessed;

		// Token: 0x040041BD RID: 16829
		private int _Power;

		// Token: 0x040041BE RID: 16830
		private int _CharSkinId;

		// Token: 0x040041BF RID: 16831
		private readonly List<ProSoldierSkin> _SoldierSkins = new List<ProSoldierSkin>();

		// Token: 0x040041C0 RID: 16832
		private IExtension extensionObject;

		// Token: 0x040041C1 RID: 16833
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040041C2 RID: 16834
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040041C3 RID: 16835
		private LuaFunction m_ctor_hotfix;
	}
}
