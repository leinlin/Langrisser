using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200065B RID: 1627
	[ProtoContract(Name = "ProArenaDefensiveBattleInfo")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ProArenaDefensiveBattleInfo : IExtensible
	{
		// Token: 0x060058B5 RID: 22709 RVA: 0x0019BE18 File Offset: 0x0019A018
		public ProArenaDefensiveBattleInfo()
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

		// Token: 0x17001611 RID: 5649
		// (get) Token: 0x060058B6 RID: 22710 RVA: 0x0019BE94 File Offset: 0x0019A094
		// (set) Token: 0x060058B7 RID: 22711 RVA: 0x0019BE9C File Offset: 0x0019A09C
		[ProtoMember(1, IsRequired = true, Name = "BattleId", DataFormat = DataFormat.TwosComplement)]
		public int BattleId
		{
			get
			{
				return this._BattleId;
			}
			set
			{
				this._BattleId = value;
			}
		}

		// Token: 0x17001612 RID: 5650
		// (get) Token: 0x060058B8 RID: 22712 RVA: 0x0019BEA8 File Offset: 0x0019A0A8
		// (set) Token: 0x060058B9 RID: 22713 RVA: 0x0019BEB0 File Offset: 0x0019A0B0
		[ProtoMember(2, IsRequired = true, Name = "ArenaDefenderRuleId", DataFormat = DataFormat.TwosComplement)]
		public int ArenaDefenderRuleId
		{
			get
			{
				return this._ArenaDefenderRuleId;
			}
			set
			{
				this._ArenaDefenderRuleId = value;
			}
		}

		// Token: 0x17001613 RID: 5651
		// (get) Token: 0x060058BA RID: 22714 RVA: 0x0019BEBC File Offset: 0x0019A0BC
		// (set) Token: 0x060058BB RID: 22715 RVA: 0x0019BEC4 File Offset: 0x0019A0C4
		[ProtoMember(3, IsRequired = true, Name = "RandomSeed", DataFormat = DataFormat.TwosComplement)]
		public int RandomSeed
		{
			get
			{
				return this._RandomSeed;
			}
			set
			{
				this._RandomSeed = value;
			}
		}

		// Token: 0x17001614 RID: 5652
		// (get) Token: 0x060058BC RID: 22716 RVA: 0x0019BED0 File Offset: 0x0019A0D0
		// (set) Token: 0x060058BD RID: 22717 RVA: 0x0019BED8 File Offset: 0x0019A0D8
		[ProtoMember(4, IsRequired = true, Name = "BattleExpiredTime", DataFormat = DataFormat.TwosComplement)]
		public long BattleExpiredTime
		{
			get
			{
				return this._BattleExpiredTime;
			}
			set
			{
				this._BattleExpiredTime = value;
			}
		}

		// Token: 0x17001615 RID: 5653
		// (get) Token: 0x060058BE RID: 22718 RVA: 0x0019BEE4 File Offset: 0x0019A0E4
		[ProtoMember(5, Name = "DefenderHeroes", DataFormat = DataFormat.Default)]
		public List<ProBattleHero> DefenderHeroes
		{
			get
			{
				return this._DefenderHeroes;
			}
		}

		// Token: 0x17001616 RID: 5654
		// (get) Token: 0x060058BF RID: 22719 RVA: 0x0019BEEC File Offset: 0x0019A0EC
		// (set) Token: 0x060058C0 RID: 22720 RVA: 0x0019BEF4 File Offset: 0x0019A0F4
		[ProtoMember(6, IsRequired = true, Name = "ArenaOpponentPointZoneId", DataFormat = DataFormat.TwosComplement)]
		public int ArenaOpponentPointZoneId
		{
			get
			{
				return this._ArenaOpponentPointZoneId;
			}
			set
			{
				this._ArenaOpponentPointZoneId = value;
			}
		}

		// Token: 0x17001617 RID: 5655
		// (get) Token: 0x060058C1 RID: 22721 RVA: 0x0019BF00 File Offset: 0x0019A100
		[ProtoMember(7, Name = "Techs", DataFormat = DataFormat.Default)]
		public List<ProTrainingTech> Techs
		{
			get
			{
				return this._Techs;
			}
		}

		// Token: 0x17001618 RID: 5656
		// (get) Token: 0x060058C2 RID: 22722 RVA: 0x0019BF08 File Offset: 0x0019A108
		// (set) Token: 0x060058C3 RID: 22723 RVA: 0x0019BF10 File Offset: 0x0019A110
		[ProtoMember(8, IsRequired = true, Name = "PlayerLevel", DataFormat = DataFormat.TwosComplement)]
		public int PlayerLevel
		{
			get
			{
				return this._PlayerLevel;
			}
			set
			{
				this._PlayerLevel = value;
			}
		}

		// Token: 0x060058C4 RID: 22724 RVA: 0x0019BF1C File Offset: 0x0019A11C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060058C5 RID: 22725 RVA: 0x0019BF2C File Offset: 0x0019A12C
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

		// Token: 0x060058C6 RID: 22726 RVA: 0x0019BFF8 File Offset: 0x0019A1F8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProArenaDefensiveBattleInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004293 RID: 17043
		private int _BattleId;

		// Token: 0x04004294 RID: 17044
		private int _ArenaDefenderRuleId;

		// Token: 0x04004295 RID: 17045
		private int _RandomSeed;

		// Token: 0x04004296 RID: 17046
		private long _BattleExpiredTime;

		// Token: 0x04004297 RID: 17047
		private readonly List<ProBattleHero> _DefenderHeroes = new List<ProBattleHero>();

		// Token: 0x04004298 RID: 17048
		private int _ArenaOpponentPointZoneId;

		// Token: 0x04004299 RID: 17049
		private readonly List<ProTrainingTech> _Techs = new List<ProTrainingTech>();

		// Token: 0x0400429A RID: 17050
		private int _PlayerLevel;

		// Token: 0x0400429B RID: 17051
		private IExtension extensionObject;

		// Token: 0x0400429C RID: 17052
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400429D RID: 17053
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400429E RID: 17054
		private LuaFunction m_ctor_hotfix;
	}
}
