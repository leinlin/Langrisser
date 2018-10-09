using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200079E RID: 1950
	[ProtoContract(Name = "HeroDungeonLevelRaidAck")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class HeroDungeonLevelRaidAck : IExtensible
	{
		// Token: 0x0600644F RID: 25679 RVA: 0x001C2180 File Offset: 0x001C0380
		public HeroDungeonLevelRaidAck()
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

		// Token: 0x170019A3 RID: 6563
		// (get) Token: 0x06006450 RID: 25680 RVA: 0x001C21FC File Offset: 0x001C03FC
		// (set) Token: 0x06006451 RID: 25681 RVA: 0x001C2204 File Offset: 0x001C0404
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

		// Token: 0x170019A4 RID: 6564
		// (get) Token: 0x06006452 RID: 25682 RVA: 0x001C2210 File Offset: 0x001C0410
		// (set) Token: 0x06006453 RID: 25683 RVA: 0x001C2218 File Offset: 0x001C0418
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

		// Token: 0x170019A5 RID: 6565
		// (get) Token: 0x06006454 RID: 25684 RVA: 0x001C2224 File Offset: 0x001C0424
		// (set) Token: 0x06006455 RID: 25685 RVA: 0x001C222C File Offset: 0x001C042C
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

		// Token: 0x170019A6 RID: 6566
		// (get) Token: 0x06006456 RID: 25686 RVA: 0x001C2238 File Offset: 0x001C0438
		// (set) Token: 0x06006457 RID: 25687 RVA: 0x001C2240 File Offset: 0x001C0440
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

		// Token: 0x170019A7 RID: 6567
		// (get) Token: 0x06006458 RID: 25688 RVA: 0x001C224C File Offset: 0x001C044C
		[ProtoMember(5, Name = "NormalRewards", DataFormat = DataFormat.Default)]
		public List<ProGoods> NormalRewards
		{
			get
			{
				return this._NormalRewards;
			}
		}

		// Token: 0x170019A8 RID: 6568
		// (get) Token: 0x06006459 RID: 25689 RVA: 0x001C2254 File Offset: 0x001C0454
		[ProtoMember(6, Name = "RaidRewards", DataFormat = DataFormat.Default)]
		public List<ProGoods> RaidRewards
		{
			get
			{
				return this._RaidRewards;
			}
		}

		// Token: 0x0600645A RID: 25690 RVA: 0x001C225C File Offset: 0x001C045C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600645B RID: 25691 RVA: 0x001C226C File Offset: 0x001C046C
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

		// Token: 0x0600645C RID: 25692 RVA: 0x001C2338 File Offset: 0x001C0538
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroDungeonLevelRaidAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004B31 RID: 19249
		private int _Result;

		// Token: 0x04004B32 RID: 19250
		private int _LevelId;

		// Token: 0x04004B33 RID: 19251
		private int _Nums;

		// Token: 0x04004B34 RID: 19252
		private ProChangedGoodsNtf _Ntf;

		// Token: 0x04004B35 RID: 19253
		private readonly List<ProGoods> _NormalRewards = new List<ProGoods>();

		// Token: 0x04004B36 RID: 19254
		private readonly List<ProGoods> _RaidRewards = new List<ProGoods>();

		// Token: 0x04004B37 RID: 19255
		private IExtension extensionObject;

		// Token: 0x04004B38 RID: 19256
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004B39 RID: 19257
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004B3A RID: 19258
		private LuaFunction m_ctor_hotfix;
	}
}
