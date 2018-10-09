using System;
using System.Collections.Generic;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020007DA RID: 2010
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "HeroTrainningLevelBattleFinishedAck")]
	[Serializable]
	public class HeroTrainningLevelBattleFinishedAck : IExtensible
	{
		// Token: 0x0600667C RID: 26236 RVA: 0x001C9284 File Offset: 0x001C7484
		public HeroTrainningLevelBattleFinishedAck()
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

		// Token: 0x17001A46 RID: 6726
		// (get) Token: 0x0600667D RID: 26237 RVA: 0x001C930C File Offset: 0x001C750C
		// (set) Token: 0x0600667E RID: 26238 RVA: 0x001C9314 File Offset: 0x001C7514
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

		// Token: 0x17001A47 RID: 6727
		// (get) Token: 0x0600667F RID: 26239 RVA: 0x001C9320 File Offset: 0x001C7520
		// (set) Token: 0x06006680 RID: 26240 RVA: 0x001C9328 File Offset: 0x001C7528
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

		// Token: 0x17001A48 RID: 6728
		// (get) Token: 0x06006681 RID: 26241 RVA: 0x001C9334 File Offset: 0x001C7534
		// (set) Token: 0x06006682 RID: 26242 RVA: 0x001C933C File Offset: 0x001C753C
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

		// Token: 0x17001A49 RID: 6729
		// (get) Token: 0x06006683 RID: 26243 RVA: 0x001C9348 File Offset: 0x001C7548
		// (set) Token: 0x06006684 RID: 26244 RVA: 0x001C9350 File Offset: 0x001C7550
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

		// Token: 0x17001A4A RID: 6730
		// (get) Token: 0x06006685 RID: 26245 RVA: 0x001C935C File Offset: 0x001C755C
		// (set) Token: 0x06006686 RID: 26246 RVA: 0x001C9364 File Offset: 0x001C7564
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

		// Token: 0x17001A4B RID: 6731
		// (get) Token: 0x06006687 RID: 26247 RVA: 0x001C9370 File Offset: 0x001C7570
		[ProtoMember(6, Name = "NormalRewards", DataFormat = DataFormat.Default)]
		public List<ProGoods> NormalRewards
		{
			get
			{
				return this._NormalRewards;
			}
		}

		// Token: 0x17001A4C RID: 6732
		// (get) Token: 0x06006688 RID: 26248 RVA: 0x001C9378 File Offset: 0x001C7578
		[ProtoMember(7, Name = "DailyRewards", DataFormat = DataFormat.Default)]
		public List<ProGoods> DailyRewards
		{
			get
			{
				return this._DailyRewards;
			}
		}

		// Token: 0x17001A4D RID: 6733
		// (get) Token: 0x06006689 RID: 26249 RVA: 0x001C9380 File Offset: 0x001C7580
		[ProtoMember(8, Name = "BattleTreasures", DataFormat = DataFormat.TwosComplement)]
		public List<int> BattleTreasures
		{
			get
			{
				return this._BattleTreasures;
			}
		}

		// Token: 0x0600668A RID: 26250 RVA: 0x001C9388 File Offset: 0x001C7588
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600668B RID: 26251 RVA: 0x001C9398 File Offset: 0x001C7598
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

		// Token: 0x0600668C RID: 26252 RVA: 0x001C9464 File Offset: 0x001C7664
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroTrainningLevelBattleFinishedAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004CC4 RID: 19652
		private int _Result;

		// Token: 0x04004CC5 RID: 19653
		private int _LevelId;

		// Token: 0x04004CC6 RID: 19654
		private bool _Win;

		// Token: 0x04004CC7 RID: 19655
		private ProChangedGoodsNtf _Ntf;

		// Token: 0x04004CC8 RID: 19656
		private ProChangedGoodsNtf _Treasure;

		// Token: 0x04004CC9 RID: 19657
		private readonly List<ProGoods> _NormalRewards = new List<ProGoods>();

		// Token: 0x04004CCA RID: 19658
		private readonly List<ProGoods> _DailyRewards = new List<ProGoods>();

		// Token: 0x04004CCB RID: 19659
		private readonly List<int> _BattleTreasures = new List<int>();

		// Token: 0x04004CCC RID: 19660
		private IExtension extensionObject;

		// Token: 0x04004CCD RID: 19661
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004CCE RID: 19662
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004CCF RID: 19663
		private LuaFunction m_ctor_hotfix;
	}
}
