using System;
using System.Collections.Generic;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020007F4 RID: 2036
	[ProtoContract(Name = "MemoryCorridorLevelBattleFinishedAck")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class MemoryCorridorLevelBattleFinishedAck : IExtensible
	{
		// Token: 0x06006759 RID: 26457 RVA: 0x001CC2EC File Offset: 0x001CA4EC
		public MemoryCorridorLevelBattleFinishedAck()
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

		// Token: 0x17001A85 RID: 6789
		// (get) Token: 0x0600675A RID: 26458 RVA: 0x001CC374 File Offset: 0x001CA574
		// (set) Token: 0x0600675B RID: 26459 RVA: 0x001CC37C File Offset: 0x001CA57C
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

		// Token: 0x17001A86 RID: 6790
		// (get) Token: 0x0600675C RID: 26460 RVA: 0x001CC388 File Offset: 0x001CA588
		// (set) Token: 0x0600675D RID: 26461 RVA: 0x001CC390 File Offset: 0x001CA590
		[ProtoMember(2, IsRequired = true, Name = "LevelId", DataFormat = DataFormat.TwosComplement)]
		public int LevelId
		{
			get
			{
				return this._LevelId;
			}
			set
			{
				this._LevelId = value;
			}
		}

		// Token: 0x17001A87 RID: 6791
		// (get) Token: 0x0600675E RID: 26462 RVA: 0x001CC39C File Offset: 0x001CA59C
		// (set) Token: 0x0600675F RID: 26463 RVA: 0x001CC3A4 File Offset: 0x001CA5A4
		[ProtoMember(3, IsRequired = true, Name = "Win", DataFormat = DataFormat.Default)]
		public bool Win
		{
			get
			{
				return this._Win;
			}
			set
			{
				this._Win = value;
			}
		}

		// Token: 0x17001A88 RID: 6792
		// (get) Token: 0x06006760 RID: 26464 RVA: 0x001CC3B0 File Offset: 0x001CA5B0
		// (set) Token: 0x06006761 RID: 26465 RVA: 0x001CC3B8 File Offset: 0x001CA5B8
		[DefaultValue(null)]
		[ProtoMember(4, IsRequired = false, Name = "Ntf", DataFormat = DataFormat.Default)]
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

		// Token: 0x17001A89 RID: 6793
		// (get) Token: 0x06006762 RID: 26466 RVA: 0x001CC3C4 File Offset: 0x001CA5C4
		// (set) Token: 0x06006763 RID: 26467 RVA: 0x001CC3CC File Offset: 0x001CA5CC
		[DefaultValue(null)]
		[ProtoMember(5, IsRequired = false, Name = "Treasure", DataFormat = DataFormat.Default)]
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

		// Token: 0x17001A8A RID: 6794
		// (get) Token: 0x06006764 RID: 26468 RVA: 0x001CC3D8 File Offset: 0x001CA5D8
		[ProtoMember(6, Name = "NormalRewards", DataFormat = DataFormat.Default)]
		public List<ProGoods> NormalRewards
		{
			get
			{
				return this._NormalRewards;
			}
		}

		// Token: 0x17001A8B RID: 6795
		// (get) Token: 0x06006765 RID: 26469 RVA: 0x001CC3E0 File Offset: 0x001CA5E0
		[ProtoMember(7, Name = "DailyRewards", DataFormat = DataFormat.Default)]
		public List<ProGoods> DailyRewards
		{
			get
			{
				return this._DailyRewards;
			}
		}

		// Token: 0x17001A8C RID: 6796
		// (get) Token: 0x06006766 RID: 26470 RVA: 0x001CC3E8 File Offset: 0x001CA5E8
		[ProtoMember(8, Name = "BattleTreasures", DataFormat = DataFormat.TwosComplement)]
		public List<int> BattleTreasures
		{
			get
			{
				return this._BattleTreasures;
			}
		}

		// Token: 0x06006767 RID: 26471 RVA: 0x001CC3F0 File Offset: 0x001CA5F0
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006768 RID: 26472 RVA: 0x001CC400 File Offset: 0x001CA600
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

		// Token: 0x06006769 RID: 26473 RVA: 0x001CC4CC File Offset: 0x001CA6CC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(MemoryCorridorLevelBattleFinishedAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004D6B RID: 19819
		private int _Result;

		// Token: 0x04004D6C RID: 19820
		private int _LevelId;

		// Token: 0x04004D6D RID: 19821
		private bool _Win;

		// Token: 0x04004D6E RID: 19822
		private ProChangedGoodsNtf _Ntf;

		// Token: 0x04004D6F RID: 19823
		private ProChangedGoodsNtf _Treasure;

		// Token: 0x04004D70 RID: 19824
		private readonly List<ProGoods> _NormalRewards = new List<ProGoods>();

		// Token: 0x04004D71 RID: 19825
		private readonly List<ProGoods> _DailyRewards = new List<ProGoods>();

		// Token: 0x04004D72 RID: 19826
		private readonly List<int> _BattleTreasures = new List<int>();

		// Token: 0x04004D73 RID: 19827
		private IExtension extensionObject;

		// Token: 0x04004D74 RID: 19828
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004D75 RID: 19829
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004D76 RID: 19830
		private LuaFunction m_ctor_hotfix;
	}
}
