using System;
using System.Collections.Generic;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000679 RID: 1657
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ProRankingListInfo")]
	[Serializable]
	public class ProRankingListInfo : IExtensible
	{
		// Token: 0x06005A49 RID: 23113 RVA: 0x0019FC6C File Offset: 0x0019DE6C
		public ProRankingListInfo()
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

		// Token: 0x170016AC RID: 5804
		// (get) Token: 0x06005A4A RID: 23114 RVA: 0x0019FCE0 File Offset: 0x0019DEE0
		// (set) Token: 0x06005A4B RID: 23115 RVA: 0x0019FCE8 File Offset: 0x0019DEE8
		[ProtoMember(1, IsRequired = true, Name = "Type", DataFormat = DataFormat.TwosComplement)]
		public int Type
		{
			get
			{
				return this._Type;
			}
			set
			{
				this._Type = value;
			}
		}

		// Token: 0x170016AD RID: 5805
		// (get) Token: 0x06005A4C RID: 23116 RVA: 0x0019FCF4 File Offset: 0x0019DEF4
		// (set) Token: 0x06005A4D RID: 23117 RVA: 0x0019FCFC File Offset: 0x0019DEFC
		[ProtoMember(2, IsRequired = true, Name = "Score", DataFormat = DataFormat.TwosComplement)]
		public int Score
		{
			get
			{
				return this._Score;
			}
			set
			{
				this._Score = value;
			}
		}

		// Token: 0x170016AE RID: 5806
		// (get) Token: 0x06005A4E RID: 23118 RVA: 0x0019FD08 File Offset: 0x0019DF08
		// (set) Token: 0x06005A4F RID: 23119 RVA: 0x0019FD10 File Offset: 0x0019DF10
		[ProtoMember(3, IsRequired = true, Name = "CurrRank", DataFormat = DataFormat.TwosComplement)]
		public int CurrRank
		{
			get
			{
				return this._CurrRank;
			}
			set
			{
				this._CurrRank = value;
			}
		}

		// Token: 0x170016AF RID: 5807
		// (get) Token: 0x06005A50 RID: 23120 RVA: 0x0019FD1C File Offset: 0x0019DF1C
		// (set) Token: 0x06005A51 RID: 23121 RVA: 0x0019FD24 File Offset: 0x0019DF24
		[ProtoMember(4, IsRequired = true, Name = "LastRank", DataFormat = DataFormat.TwosComplement)]
		public int LastRank
		{
			get
			{
				return this._LastRank;
			}
			set
			{
				this._LastRank = value;
			}
		}

		// Token: 0x170016B0 RID: 5808
		// (get) Token: 0x06005A52 RID: 23122 RVA: 0x0019FD30 File Offset: 0x0019DF30
		[ProtoMember(5, Name = "PlayerList", DataFormat = DataFormat.Default)]
		public List<ProRankingPlayerInfo> PlayerList
		{
			get
			{
				return this._PlayerList;
			}
		}

		// Token: 0x170016B1 RID: 5809
		// (get) Token: 0x06005A53 RID: 23123 RVA: 0x0019FD38 File Offset: 0x0019DF38
		// (set) Token: 0x06005A54 RID: 23124 RVA: 0x0019FD40 File Offset: 0x0019DF40
		[ProtoMember(6, IsRequired = false, Name = "ChampionHeroId", DataFormat = DataFormat.TwosComplement)]
		[DefaultValue(0)]
		public int ChampionHeroId
		{
			get
			{
				return this._ChampionHeroId;
			}
			set
			{
				this._ChampionHeroId = value;
			}
		}

		// Token: 0x06005A55 RID: 23125 RVA: 0x0019FD4C File Offset: 0x0019DF4C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005A56 RID: 23126 RVA: 0x0019FD5C File Offset: 0x0019DF5C
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

		// Token: 0x06005A57 RID: 23127 RVA: 0x0019FE28 File Offset: 0x0019E028
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProRankingListInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040043A6 RID: 17318
		private int _Type;

		// Token: 0x040043A7 RID: 17319
		private int _Score;

		// Token: 0x040043A8 RID: 17320
		private int _CurrRank;

		// Token: 0x040043A9 RID: 17321
		private int _LastRank;

		// Token: 0x040043AA RID: 17322
		private readonly List<ProRankingPlayerInfo> _PlayerList = new List<ProRankingPlayerInfo>();

		// Token: 0x040043AB RID: 17323
		private int _ChampionHeroId;

		// Token: 0x040043AC RID: 17324
		private IExtension extensionObject;

		// Token: 0x040043AD RID: 17325
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040043AE RID: 17326
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040043AF RID: 17327
		private LuaFunction m_ctor_hotfix;
	}
}
