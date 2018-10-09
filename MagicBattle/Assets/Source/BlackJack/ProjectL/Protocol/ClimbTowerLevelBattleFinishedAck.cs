using System;
using System.Collections.Generic;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000634 RID: 1588
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ClimbTowerLevelBattleFinishedAck")]
	[Serializable]
	public class ClimbTowerLevelBattleFinishedAck : IExtensible
	{
		// Token: 0x06005701 RID: 22273 RVA: 0x001970E8 File Offset: 0x001952E8
		public ClimbTowerLevelBattleFinishedAck()
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

		// Token: 0x17001578 RID: 5496
		// (get) Token: 0x06005702 RID: 22274 RVA: 0x00197164 File Offset: 0x00195364
		// (set) Token: 0x06005703 RID: 22275 RVA: 0x0019716C File Offset: 0x0019536C
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

		// Token: 0x17001579 RID: 5497
		// (get) Token: 0x06005704 RID: 22276 RVA: 0x00197178 File Offset: 0x00195378
		// (set) Token: 0x06005705 RID: 22277 RVA: 0x00197180 File Offset: 0x00195380
		[ProtoMember(2, IsRequired = true, Name = "FloorId", DataFormat = DataFormat.TwosComplement)]
		public int FloorId
		{
			get
			{
				return this._FloorId;
			}
			set
			{
				this._FloorId = value;
			}
		}

		// Token: 0x1700157A RID: 5498
		// (get) Token: 0x06005706 RID: 22278 RVA: 0x0019718C File Offset: 0x0019538C
		// (set) Token: 0x06005707 RID: 22279 RVA: 0x00197194 File Offset: 0x00195394
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

		// Token: 0x1700157B RID: 5499
		// (get) Token: 0x06005708 RID: 22280 RVA: 0x001971A0 File Offset: 0x001953A0
		// (set) Token: 0x06005709 RID: 22281 RVA: 0x001971A8 File Offset: 0x001953A8
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

		// Token: 0x1700157C RID: 5500
		// (get) Token: 0x0600570A RID: 22282 RVA: 0x001971B4 File Offset: 0x001953B4
		[ProtoMember(6, Name = "NormalRewards", DataFormat = DataFormat.Default)]
		public List<ProGoods> NormalRewards
		{
			get
			{
				return this._NormalRewards;
			}
		}

		// Token: 0x1700157D RID: 5501
		// (get) Token: 0x0600570B RID: 22283 RVA: 0x001971BC File Offset: 0x001953BC
		[ProtoMember(7, Name = "BattleTreasures", DataFormat = DataFormat.TwosComplement)]
		public List<int> BattleTreasures
		{
			get
			{
				return this._BattleTreasures;
			}
		}

		// Token: 0x1700157E RID: 5502
		// (get) Token: 0x0600570C RID: 22284 RVA: 0x001971C4 File Offset: 0x001953C4
		// (set) Token: 0x0600570D RID: 22285 RVA: 0x001971CC File Offset: 0x001953CC
		[ProtoMember(8, IsRequired = false, Name = "Ntf", DataFormat = DataFormat.Default)]
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

		// Token: 0x0600570E RID: 22286 RVA: 0x001971D8 File Offset: 0x001953D8
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600570F RID: 22287 RVA: 0x001971E8 File Offset: 0x001953E8
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

		// Token: 0x06005710 RID: 22288 RVA: 0x001972B4 File Offset: 0x001954B4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ClimbTowerLevelBattleFinishedAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400415E RID: 16734
		private int _Result;

		// Token: 0x0400415F RID: 16735
		private int _FloorId;

		// Token: 0x04004160 RID: 16736
		private bool _Win;

		// Token: 0x04004161 RID: 16737
		private ProChangedGoodsNtf _Treasure;

		// Token: 0x04004162 RID: 16738
		private readonly List<ProGoods> _NormalRewards = new List<ProGoods>();

		// Token: 0x04004163 RID: 16739
		private readonly List<int> _BattleTreasures = new List<int>();

		// Token: 0x04004164 RID: 16740
		private ProChangedGoodsNtf _Ntf;

		// Token: 0x04004165 RID: 16741
		private IExtension extensionObject;

		// Token: 0x04004166 RID: 16742
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004167 RID: 16743
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004168 RID: 16744
		private LuaFunction m_ctor_hotfix;
	}
}
