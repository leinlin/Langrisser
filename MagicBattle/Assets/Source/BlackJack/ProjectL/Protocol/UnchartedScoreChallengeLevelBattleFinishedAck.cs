using System;
using System.Collections.Generic;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200085B RID: 2139
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "UnchartedScoreChallengeLevelBattleFinishedAck")]
	[Serializable]
	public class UnchartedScoreChallengeLevelBattleFinishedAck : IExtensible
	{
		// Token: 0x06006AAB RID: 27307 RVA: 0x001DF51C File Offset: 0x001DD71C
		public UnchartedScoreChallengeLevelBattleFinishedAck()
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

		// Token: 0x17001B6C RID: 7020
		// (get) Token: 0x06006AAC RID: 27308 RVA: 0x001DF5A4 File Offset: 0x001DD7A4
		// (set) Token: 0x06006AAD RID: 27309 RVA: 0x001DF5AC File Offset: 0x001DD7AC
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

		// Token: 0x17001B6D RID: 7021
		// (get) Token: 0x06006AAE RID: 27310 RVA: 0x001DF5B8 File Offset: 0x001DD7B8
		// (set) Token: 0x06006AAF RID: 27311 RVA: 0x001DF5C0 File Offset: 0x001DD7C0
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

		// Token: 0x17001B6E RID: 7022
		// (get) Token: 0x06006AB0 RID: 27312 RVA: 0x001DF5CC File Offset: 0x001DD7CC
		// (set) Token: 0x06006AB1 RID: 27313 RVA: 0x001DF5D4 File Offset: 0x001DD7D4
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

		// Token: 0x17001B6F RID: 7023
		// (get) Token: 0x06006AB2 RID: 27314 RVA: 0x001DF5E0 File Offset: 0x001DD7E0
		// (set) Token: 0x06006AB3 RID: 27315 RVA: 0x001DF5E8 File Offset: 0x001DD7E8
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

		// Token: 0x17001B70 RID: 7024
		// (get) Token: 0x06006AB4 RID: 27316 RVA: 0x001DF5F4 File Offset: 0x001DD7F4
		// (set) Token: 0x06006AB5 RID: 27317 RVA: 0x001DF5FC File Offset: 0x001DD7FC
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

		// Token: 0x17001B71 RID: 7025
		// (get) Token: 0x06006AB6 RID: 27318 RVA: 0x001DF608 File Offset: 0x001DD808
		[ProtoMember(6, Name = "NormalRewards", DataFormat = DataFormat.Default)]
		public List<ProGoods> NormalRewards
		{
			get
			{
				return this._NormalRewards;
			}
		}

		// Token: 0x17001B72 RID: 7026
		// (get) Token: 0x06006AB7 RID: 27319 RVA: 0x001DF610 File Offset: 0x001DD810
		[ProtoMember(7, Name = "BattleTreasures", DataFormat = DataFormat.TwosComplement)]
		public List<int> BattleTreasures
		{
			get
			{
				return this._BattleTreasures;
			}
		}

		// Token: 0x17001B73 RID: 7027
		// (get) Token: 0x06006AB8 RID: 27320 RVA: 0x001DF618 File Offset: 0x001DD818
		[ProtoMember(8, Name = "ScoreRewards", DataFormat = DataFormat.Default)]
		public List<ProGoods> ScoreRewards
		{
			get
			{
				return this._ScoreRewards;
			}
		}

		// Token: 0x17001B74 RID: 7028
		// (get) Token: 0x06006AB9 RID: 27321 RVA: 0x001DF620 File Offset: 0x001DD820
		// (set) Token: 0x06006ABA RID: 27322 RVA: 0x001DF628 File Offset: 0x001DD828
		[ProtoMember(9, IsRequired = false, Name = "Ntf", DataFormat = DataFormat.Default)]
		[DefaultValue(null)]
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

		// Token: 0x06006ABB RID: 27323 RVA: 0x001DF634 File Offset: 0x001DD834
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006ABC RID: 27324 RVA: 0x001DF644 File Offset: 0x001DD844
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

		// Token: 0x06006ABD RID: 27325 RVA: 0x001DF710 File Offset: 0x001DD910
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(UnchartedScoreChallengeLevelBattleFinishedAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400522E RID: 21038
		private int _Result;

		// Token: 0x0400522F RID: 21039
		private int _UnchartedScoreId;

		// Token: 0x04005230 RID: 21040
		private int _LevelId;

		// Token: 0x04005231 RID: 21041
		private bool _Win;

		// Token: 0x04005232 RID: 21042
		private ProChangedGoodsNtf _Treasure;

		// Token: 0x04005233 RID: 21043
		private readonly List<ProGoods> _NormalRewards = new List<ProGoods>();

		// Token: 0x04005234 RID: 21044
		private readonly List<int> _BattleTreasures = new List<int>();

		// Token: 0x04005235 RID: 21045
		private readonly List<ProGoods> _ScoreRewards = new List<ProGoods>();

		// Token: 0x04005236 RID: 21046
		private ProChangedGoodsNtf _Ntf;

		// Token: 0x04005237 RID: 21047
		private IExtension extensionObject;

		// Token: 0x04005238 RID: 21048
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04005239 RID: 21049
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400523A RID: 21050
		private LuaFunction m_ctor_hotfix;
	}
}
