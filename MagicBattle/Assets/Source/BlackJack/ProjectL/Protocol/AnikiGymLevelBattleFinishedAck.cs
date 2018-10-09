using System;
using System.Collections.Generic;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020005B1 RID: 1457
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "AnikiGymLevelBattleFinishedAck")]
	[Serializable]
	public class AnikiGymLevelBattleFinishedAck : IExtensible
	{
		// Token: 0x060052A5 RID: 21157 RVA: 0x00187CD4 File Offset: 0x00185ED4
		public AnikiGymLevelBattleFinishedAck()
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

		// Token: 0x1700143A RID: 5178
		// (get) Token: 0x060052A6 RID: 21158 RVA: 0x00187D5C File Offset: 0x00185F5C
		// (set) Token: 0x060052A7 RID: 21159 RVA: 0x00187D64 File Offset: 0x00185F64
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

		// Token: 0x1700143B RID: 5179
		// (get) Token: 0x060052A8 RID: 21160 RVA: 0x00187D70 File Offset: 0x00185F70
		// (set) Token: 0x060052A9 RID: 21161 RVA: 0x00187D78 File Offset: 0x00185F78
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

		// Token: 0x1700143C RID: 5180
		// (get) Token: 0x060052AA RID: 21162 RVA: 0x00187D84 File Offset: 0x00185F84
		// (set) Token: 0x060052AB RID: 21163 RVA: 0x00187D8C File Offset: 0x00185F8C
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

		// Token: 0x1700143D RID: 5181
		// (get) Token: 0x060052AC RID: 21164 RVA: 0x00187D98 File Offset: 0x00185F98
		// (set) Token: 0x060052AD RID: 21165 RVA: 0x00187DA0 File Offset: 0x00185FA0
		[ProtoMember(4, IsRequired = false, Name = "Ntf", DataFormat = DataFormat.Default)]
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

		// Token: 0x1700143E RID: 5182
		// (get) Token: 0x060052AE RID: 21166 RVA: 0x00187DAC File Offset: 0x00185FAC
		// (set) Token: 0x060052AF RID: 21167 RVA: 0x00187DB4 File Offset: 0x00185FB4
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

		// Token: 0x1700143F RID: 5183
		// (get) Token: 0x060052B0 RID: 21168 RVA: 0x00187DC0 File Offset: 0x00185FC0
		[ProtoMember(6, Name = "NormalRewards", DataFormat = DataFormat.Default)]
		public List<ProGoods> NormalRewards
		{
			get
			{
				return this._NormalRewards;
			}
		}

		// Token: 0x17001440 RID: 5184
		// (get) Token: 0x060052B1 RID: 21169 RVA: 0x00187DC8 File Offset: 0x00185FC8
		[ProtoMember(7, Name = "DailyRewards", DataFormat = DataFormat.Default)]
		public List<ProGoods> DailyRewards
		{
			get
			{
				return this._DailyRewards;
			}
		}

		// Token: 0x17001441 RID: 5185
		// (get) Token: 0x060052B2 RID: 21170 RVA: 0x00187DD0 File Offset: 0x00185FD0
		[ProtoMember(8, Name = "BattleTreasures", DataFormat = DataFormat.TwosComplement)]
		public List<int> BattleTreasures
		{
			get
			{
				return this._BattleTreasures;
			}
		}

		// Token: 0x060052B3 RID: 21171 RVA: 0x00187DD8 File Offset: 0x00185FD8
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060052B4 RID: 21172 RVA: 0x00187DE8 File Offset: 0x00185FE8
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

		// Token: 0x060052B5 RID: 21173 RVA: 0x00187EB4 File Offset: 0x001860B4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(AnikiGymLevelBattleFinishedAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04003E14 RID: 15892
		private int _Result;

		// Token: 0x04003E15 RID: 15893
		private int _LevelId;

		// Token: 0x04003E16 RID: 15894
		private bool _Win;

		// Token: 0x04003E17 RID: 15895
		private ProChangedGoodsNtf _Ntf;

		// Token: 0x04003E18 RID: 15896
		private ProChangedGoodsNtf _Treasure;

		// Token: 0x04003E19 RID: 15897
		private readonly List<ProGoods> _NormalRewards = new List<ProGoods>();

		// Token: 0x04003E1A RID: 15898
		private readonly List<ProGoods> _DailyRewards = new List<ProGoods>();

		// Token: 0x04003E1B RID: 15899
		private readonly List<int> _BattleTreasures = new List<int>();

		// Token: 0x04003E1C RID: 15900
		private IExtension extensionObject;

		// Token: 0x04003E1D RID: 15901
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04003E1E RID: 15902
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04003E1F RID: 15903
		private LuaFunction m_ctor_hotfix;
	}
}
