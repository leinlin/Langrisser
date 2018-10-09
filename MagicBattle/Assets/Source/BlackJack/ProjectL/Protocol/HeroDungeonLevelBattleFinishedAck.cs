using System;
using System.Collections.Generic;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200079C RID: 1948
	[ProtoContract(Name = "HeroDungeonLevelBattleFinishedAck")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class HeroDungeonLevelBattleFinishedAck : IExtensible
	{
		// Token: 0x06006436 RID: 25654 RVA: 0x001C1D64 File Offset: 0x001BFF64
		public HeroDungeonLevelBattleFinishedAck()
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

		// Token: 0x17001999 RID: 6553
		// (get) Token: 0x06006437 RID: 25655 RVA: 0x001C1DEC File Offset: 0x001BFFEC
		// (set) Token: 0x06006438 RID: 25656 RVA: 0x001C1DF4 File Offset: 0x001BFFF4
		[ProtoMember(1, IsRequired = true, Name = "Result", DataFormat = DataFormat.TwosComplement)]
		public int Result
		{
			get
			{
				return this._Result;
			}
			set
			{
				this._Result = value;
			}
		}

		// Token: 0x1700199A RID: 6554
		// (get) Token: 0x06006439 RID: 25657 RVA: 0x001C1E00 File Offset: 0x001C0000
		// (set) Token: 0x0600643A RID: 25658 RVA: 0x001C1E08 File Offset: 0x001C0008
		[ProtoMember(2, IsRequired = true, Name = "HeroDungeonLevelId", DataFormat = DataFormat.TwosComplement)]
		public int HeroDungeonLevelId
		{
			get
			{
				return this._HeroDungeonLevelId;
			}
			set
			{
				this._HeroDungeonLevelId = value;
			}
		}

		// Token: 0x1700199B RID: 6555
		// (get) Token: 0x0600643B RID: 25659 RVA: 0x001C1E14 File Offset: 0x001C0014
		[ProtoMember(3, Name = "AchievementIds", DataFormat = DataFormat.TwosComplement)]
		public List<int> AchievementIds
		{
			get
			{
				return this._AchievementIds;
			}
		}

		// Token: 0x1700199C RID: 6556
		// (get) Token: 0x0600643C RID: 25660 RVA: 0x001C1E1C File Offset: 0x001C001C
		// (set) Token: 0x0600643D RID: 25661 RVA: 0x001C1E24 File Offset: 0x001C0024
		[ProtoMember(4, IsRequired = true, Name = "GainStars", DataFormat = DataFormat.TwosComplement)]
		public int GainStars
		{
			get
			{
				return this._GainStars;
			}
			set
			{
				this._GainStars = value;
			}
		}

		// Token: 0x1700199D RID: 6557
		// (get) Token: 0x0600643E RID: 25662 RVA: 0x001C1E30 File Offset: 0x001C0030
		// (set) Token: 0x0600643F RID: 25663 RVA: 0x001C1E38 File Offset: 0x001C0038
		[DefaultValue(null)]
		[ProtoMember(5, IsRequired = false, Name = "Ntf", DataFormat = DataFormat.Default)]
		public ProChangedGoodsNtf Ntf
		{
			get
			{
				return this._Ntf;
			}
			set
			{
				this._Ntf = value;
			}
		}

		// Token: 0x1700199E RID: 6558
		// (get) Token: 0x06006440 RID: 25664 RVA: 0x001C1E44 File Offset: 0x001C0044
		// (set) Token: 0x06006441 RID: 25665 RVA: 0x001C1E4C File Offset: 0x001C004C
		[DefaultValue(null)]
		[ProtoMember(6, IsRequired = false, Name = "Treasure", DataFormat = DataFormat.Default)]
		public ProChangedGoodsNtf Treasure
		{
			get
			{
				return this._Treasure;
			}
			set
			{
				this._Treasure = value;
			}
		}

		// Token: 0x1700199F RID: 6559
		// (get) Token: 0x06006442 RID: 25666 RVA: 0x001C1E58 File Offset: 0x001C0058
		[ProtoMember(7, Name = "NormalRewards", DataFormat = DataFormat.Default)]
		public List<ProGoods> NormalRewards
		{
			get
			{
				return this._NormalRewards;
			}
		}

		// Token: 0x170019A0 RID: 6560
		// (get) Token: 0x06006443 RID: 25667 RVA: 0x001C1E60 File Offset: 0x001C0060
		[ProtoMember(8, Name = "BattleTreasures", DataFormat = DataFormat.TwosComplement)]
		public List<int> BattleTreasures
		{
			get
			{
				return this._BattleTreasures;
			}
		}

		// Token: 0x06006444 RID: 25668 RVA: 0x001C1E68 File Offset: 0x001C0068
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006445 RID: 25669 RVA: 0x001C1E78 File Offset: 0x001C0078
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

		// Token: 0x06006446 RID: 25670 RVA: 0x001C1F44 File Offset: 0x001C0144
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroDungeonLevelBattleFinishedAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004B1F RID: 19231
		private int _Result;

		// Token: 0x04004B20 RID: 19232
		private int _HeroDungeonLevelId;

		// Token: 0x04004B21 RID: 19233
		private readonly List<int> _AchievementIds = new List<int>();

		// Token: 0x04004B22 RID: 19234
		private int _GainStars;

		// Token: 0x04004B23 RID: 19235
		private ProChangedGoodsNtf _Ntf;

		// Token: 0x04004B24 RID: 19236
		private ProChangedGoodsNtf _Treasure;

		// Token: 0x04004B25 RID: 19237
		private readonly List<ProGoods> _NormalRewards = new List<ProGoods>();

		// Token: 0x04004B26 RID: 19238
		private readonly List<int> _BattleTreasures = new List<int>();

		// Token: 0x04004B27 RID: 19239
		private IExtension extensionObject;

		// Token: 0x04004B28 RID: 19240
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004B29 RID: 19241
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004B2A RID: 19242
		private LuaFunction m_ctor_hotfix;
	}
}
