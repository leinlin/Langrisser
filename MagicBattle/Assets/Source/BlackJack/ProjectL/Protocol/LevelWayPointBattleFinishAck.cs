using System;
using System.Collections.Generic;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020007DE RID: 2014
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "LevelWayPointBattleFinishAck")]
	[Serializable]
	public class LevelWayPointBattleFinishAck : IExtensible
	{
		// Token: 0x060066A8 RID: 26280 RVA: 0x001C9A70 File Offset: 0x001C7C70
		public LevelWayPointBattleFinishAck()
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

		// Token: 0x17001A56 RID: 6742
		// (get) Token: 0x060066A9 RID: 26281 RVA: 0x001C9AEC File Offset: 0x001C7CEC
		// (set) Token: 0x060066AA RID: 26282 RVA: 0x001C9AF4 File Offset: 0x001C7CF4
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

		// Token: 0x17001A57 RID: 6743
		// (get) Token: 0x060066AB RID: 26283 RVA: 0x001C9B00 File Offset: 0x001C7D00
		// (set) Token: 0x060066AC RID: 26284 RVA: 0x001C9B08 File Offset: 0x001C7D08
		[ProtoMember(2, IsRequired = true, Name = "WayPointId", DataFormat = DataFormat.TwosComplement)]
		public int WayPointId
		{
			get
			{
				return this._WayPointId;
			}
			set
			{
				this._WayPointId = value;
			}
		}

		// Token: 0x17001A58 RID: 6744
		// (get) Token: 0x060066AD RID: 26285 RVA: 0x001C9B14 File Offset: 0x001C7D14
		// (set) Token: 0x060066AE RID: 26286 RVA: 0x001C9B1C File Offset: 0x001C7D1C
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

		// Token: 0x17001A59 RID: 6745
		// (get) Token: 0x060066AF RID: 26287 RVA: 0x001C9B28 File Offset: 0x001C7D28
		// (set) Token: 0x060066B0 RID: 26288 RVA: 0x001C9B30 File Offset: 0x001C7D30
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

		// Token: 0x17001A5A RID: 6746
		// (get) Token: 0x060066B1 RID: 26289 RVA: 0x001C9B3C File Offset: 0x001C7D3C
		// (set) Token: 0x060066B2 RID: 26290 RVA: 0x001C9B44 File Offset: 0x001C7D44
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

		// Token: 0x17001A5B RID: 6747
		// (get) Token: 0x060066B3 RID: 26291 RVA: 0x001C9B50 File Offset: 0x001C7D50
		[ProtoMember(6, Name = "NormalRewards", DataFormat = DataFormat.Default)]
		public List<ProGoods> NormalRewards
		{
			get
			{
				return this._NormalRewards;
			}
		}

		// Token: 0x17001A5C RID: 6748
		// (get) Token: 0x060066B4 RID: 26292 RVA: 0x001C9B58 File Offset: 0x001C7D58
		[ProtoMember(7, Name = "BattleTreasures", DataFormat = DataFormat.TwosComplement)]
		public List<int> BattleTreasures
		{
			get
			{
				return this._BattleTreasures;
			}
		}

		// Token: 0x060066B5 RID: 26293 RVA: 0x001C9B60 File Offset: 0x001C7D60
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060066B6 RID: 26294 RVA: 0x001C9B70 File Offset: 0x001C7D70
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

		// Token: 0x060066B7 RID: 26295 RVA: 0x001C9C3C File Offset: 0x001C7E3C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(LevelWayPointBattleFinishAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004CE4 RID: 19684
		private int _Result;

		// Token: 0x04004CE5 RID: 19685
		private int _WayPointId;

		// Token: 0x04004CE6 RID: 19686
		private bool _Win;

		// Token: 0x04004CE7 RID: 19687
		private ProChangedGoodsNtf _Ntf;

		// Token: 0x04004CE8 RID: 19688
		private ProChangedGoodsNtf _Treasure;

		// Token: 0x04004CE9 RID: 19689
		private readonly List<ProGoods> _NormalRewards = new List<ProGoods>();

		// Token: 0x04004CEA RID: 19690
		private readonly List<int> _BattleTreasures = new List<int>();

		// Token: 0x04004CEB RID: 19691
		private IExtension extensionObject;

		// Token: 0x04004CEC RID: 19692
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004CED RID: 19693
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004CEE RID: 19694
		private LuaFunction m_ctor_hotfix;
	}
}
