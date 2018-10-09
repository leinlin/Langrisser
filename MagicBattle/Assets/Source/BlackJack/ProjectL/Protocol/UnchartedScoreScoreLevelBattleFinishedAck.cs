using System;
using System.Collections.Generic;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200085D RID: 2141
	[ProtoContract(Name = "UnchartedScoreScoreLevelBattleFinishedAck")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class UnchartedScoreScoreLevelBattleFinishedAck : IExtensible
	{
		// Token: 0x06006AC8 RID: 27336 RVA: 0x001DF960 File Offset: 0x001DDB60
		public UnchartedScoreScoreLevelBattleFinishedAck()
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

		// Token: 0x17001B78 RID: 7032
		// (get) Token: 0x06006AC9 RID: 27337 RVA: 0x001DF9F4 File Offset: 0x001DDBF4
		// (set) Token: 0x06006ACA RID: 27338 RVA: 0x001DF9FC File Offset: 0x001DDBFC
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

		// Token: 0x17001B79 RID: 7033
		// (get) Token: 0x06006ACB RID: 27339 RVA: 0x001DFA08 File Offset: 0x001DDC08
		// (set) Token: 0x06006ACC RID: 27340 RVA: 0x001DFA10 File Offset: 0x001DDC10
		[ProtoMember(2, IsRequired = true, Name = "UnchartedScoreId", DataFormat = DataFormat.TwosComplement)]
		public int UnchartedScoreId
		{
			get
			{
				return this._UnchartedScoreId;
			}
			set
			{
				this._UnchartedScoreId = value;
			}
		}

		// Token: 0x17001B7A RID: 7034
		// (get) Token: 0x06006ACD RID: 27341 RVA: 0x001DFA1C File Offset: 0x001DDC1C
		// (set) Token: 0x06006ACE RID: 27342 RVA: 0x001DFA24 File Offset: 0x001DDC24
		[ProtoMember(3, IsRequired = true, Name = "LevelId", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17001B7B RID: 7035
		// (get) Token: 0x06006ACF RID: 27343 RVA: 0x001DFA30 File Offset: 0x001DDC30
		// (set) Token: 0x06006AD0 RID: 27344 RVA: 0x001DFA38 File Offset: 0x001DDC38
		[ProtoMember(4, IsRequired = true, Name = "Win", DataFormat = DataFormat.Default)]
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

		// Token: 0x17001B7C RID: 7036
		// (get) Token: 0x06006AD1 RID: 27345 RVA: 0x001DFA44 File Offset: 0x001DDC44
		// (set) Token: 0x06006AD2 RID: 27346 RVA: 0x001DFA4C File Offset: 0x001DDC4C
		[ProtoMember(5, IsRequired = false, Name = "Treasure", DataFormat = DataFormat.Default)]
		[DefaultValue(null)]
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

		// Token: 0x17001B7D RID: 7037
		// (get) Token: 0x06006AD3 RID: 27347 RVA: 0x001DFA58 File Offset: 0x001DDC58
		[ProtoMember(6, Name = "NormalRewards", DataFormat = DataFormat.Default)]
		public List<ProGoods> NormalRewards
		{
			get
			{
				return this._NormalRewards;
			}
		}

		// Token: 0x17001B7E RID: 7038
		// (get) Token: 0x06006AD4 RID: 27348 RVA: 0x001DFA60 File Offset: 0x001DDC60
		[ProtoMember(7, Name = "DailyRewards", DataFormat = DataFormat.Default)]
		public List<ProGoods> DailyRewards
		{
			get
			{
				return this._DailyRewards;
			}
		}

		// Token: 0x17001B7F RID: 7039
		// (get) Token: 0x06006AD5 RID: 27349 RVA: 0x001DFA68 File Offset: 0x001DDC68
		[ProtoMember(8, Name = "ScoreRewards", DataFormat = DataFormat.Default)]
		public List<ProGoods> ScoreRewards
		{
			get
			{
				return this._ScoreRewards;
			}
		}

		// Token: 0x17001B80 RID: 7040
		// (get) Token: 0x06006AD6 RID: 27350 RVA: 0x001DFA70 File Offset: 0x001DDC70
		[ProtoMember(9, Name = "BattleTreasures", DataFormat = DataFormat.TwosComplement)]
		public List<int> BattleTreasures
		{
			get
			{
				return this._BattleTreasures;
			}
		}

		// Token: 0x17001B81 RID: 7041
		// (get) Token: 0x06006AD7 RID: 27351 RVA: 0x001DFA78 File Offset: 0x001DDC78
		// (set) Token: 0x06006AD8 RID: 27352 RVA: 0x001DFA80 File Offset: 0x001DDC80
		[DefaultValue(null)]
		[ProtoMember(10, IsRequired = false, Name = "Ntf", DataFormat = DataFormat.Default)]
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

		// Token: 0x06006AD9 RID: 27353 RVA: 0x001DFA8C File Offset: 0x001DDC8C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006ADA RID: 27354 RVA: 0x001DFA9C File Offset: 0x001DDC9C
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

		// Token: 0x06006ADB RID: 27355 RVA: 0x001DFB68 File Offset: 0x001DDD68
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(UnchartedScoreScoreLevelBattleFinishedAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04005242 RID: 21058
		private int _Result;

		// Token: 0x04005243 RID: 21059
		private int _UnchartedScoreId;

		// Token: 0x04005244 RID: 21060
		private int _LevelId;

		// Token: 0x04005245 RID: 21061
		private bool _Win;

		// Token: 0x04005246 RID: 21062
		private ProChangedGoodsNtf _Treasure;

		// Token: 0x04005247 RID: 21063
		private readonly List<ProGoods> _NormalRewards = new List<ProGoods>();

		// Token: 0x04005248 RID: 21064
		private readonly List<ProGoods> _DailyRewards = new List<ProGoods>();

		// Token: 0x04005249 RID: 21065
		private readonly List<ProGoods> _ScoreRewards = new List<ProGoods>();

		// Token: 0x0400524A RID: 21066
		private readonly List<int> _BattleTreasures = new List<int>();

		// Token: 0x0400524B RID: 21067
		private ProChangedGoodsNtf _Ntf;

		// Token: 0x0400524C RID: 21068
		private IExtension extensionObject;

		// Token: 0x0400524D RID: 21069
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400524E RID: 21070
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400524F RID: 21071
		private LuaFunction m_ctor_hotfix;
	}
}
