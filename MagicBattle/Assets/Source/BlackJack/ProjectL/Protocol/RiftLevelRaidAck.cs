using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200081D RID: 2077
	[ProtoContract(Name = "RiftLevelRaidAck")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class RiftLevelRaidAck : IExtensible
	{
		// Token: 0x060068AF RID: 26799 RVA: 0x001D82CC File Offset: 0x001D64CC
		public RiftLevelRaidAck()
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

		// Token: 0x17001AE3 RID: 6883
		// (get) Token: 0x060068B0 RID: 26800 RVA: 0x001D8348 File Offset: 0x001D6548
		// (set) Token: 0x060068B1 RID: 26801 RVA: 0x001D8350 File Offset: 0x001D6550
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

		// Token: 0x17001AE4 RID: 6884
		// (get) Token: 0x060068B2 RID: 26802 RVA: 0x001D835C File Offset: 0x001D655C
		// (set) Token: 0x060068B3 RID: 26803 RVA: 0x001D8364 File Offset: 0x001D6564
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

		// Token: 0x17001AE5 RID: 6885
		// (get) Token: 0x060068B4 RID: 26804 RVA: 0x001D8370 File Offset: 0x001D6570
		// (set) Token: 0x060068B5 RID: 26805 RVA: 0x001D8378 File Offset: 0x001D6578
		[ProtoMember(3, IsRequired = true, Name = "Nums", DataFormat = DataFormat.TwosComplement)]
		public int Nums
		{
			get
			{
				return this._Nums;
			}
			set
			{
				this._Nums = value;
			}
		}

		// Token: 0x17001AE6 RID: 6886
		// (get) Token: 0x060068B6 RID: 26806 RVA: 0x001D8384 File Offset: 0x001D6584
		// (set) Token: 0x060068B7 RID: 26807 RVA: 0x001D838C File Offset: 0x001D658C
		[ProtoMember(4, IsRequired = true, Name = "Ntf", DataFormat = DataFormat.Default)]
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

		// Token: 0x17001AE7 RID: 6887
		// (get) Token: 0x060068B8 RID: 26808 RVA: 0x001D8398 File Offset: 0x001D6598
		[ProtoMember(5, Name = "NormalRewards", DataFormat = DataFormat.Default)]
		public List<ProGoods> NormalRewards
		{
			get
			{
				return this._NormalRewards;
			}
		}

		// Token: 0x17001AE8 RID: 6888
		// (get) Token: 0x060068B9 RID: 26809 RVA: 0x001D83A0 File Offset: 0x001D65A0
		[ProtoMember(6, Name = "RaidRewards", DataFormat = DataFormat.Default)]
		public List<ProGoods> RaidRewards
		{
			get
			{
				return this._RaidRewards;
			}
		}

		// Token: 0x060068BA RID: 26810 RVA: 0x001D83A8 File Offset: 0x001D65A8
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060068BB RID: 26811 RVA: 0x001D83B8 File Offset: 0x001D65B8
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

		// Token: 0x060068BC RID: 26812 RVA: 0x001D8484 File Offset: 0x001D6684
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(RiftLevelRaidAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040050AD RID: 20653
		private int _Result;

		// Token: 0x040050AE RID: 20654
		private int _LevelId;

		// Token: 0x040050AF RID: 20655
		private int _Nums;

		// Token: 0x040050B0 RID: 20656
		private ProChangedGoodsNtf _Ntf;

		// Token: 0x040050B1 RID: 20657
		private readonly List<ProGoods> _NormalRewards = new List<ProGoods>();

		// Token: 0x040050B2 RID: 20658
		private readonly List<ProGoods> _RaidRewards = new List<ProGoods>();

		// Token: 0x040050B3 RID: 20659
		private IExtension extensionObject;

		// Token: 0x040050B4 RID: 20660
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040050B5 RID: 20661
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040050B6 RID: 20662
		private LuaFunction m_ctor_hotfix;
	}
}
