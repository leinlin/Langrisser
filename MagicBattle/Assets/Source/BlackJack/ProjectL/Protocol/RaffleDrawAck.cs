using System;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000805 RID: 2053
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "RaffleDrawAck")]
	[Serializable]
	public class RaffleDrawAck : IExtensible
	{
		// Token: 0x060067E1 RID: 26593 RVA: 0x001D562C File Offset: 0x001D382C
		public RaffleDrawAck()
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

		// Token: 0x17001AA9 RID: 6825
		// (get) Token: 0x060067E2 RID: 26594 RVA: 0x001D5694 File Offset: 0x001D3894
		// (set) Token: 0x060067E3 RID: 26595 RVA: 0x001D569C File Offset: 0x001D389C
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

		// Token: 0x17001AAA RID: 6826
		// (get) Token: 0x060067E4 RID: 26596 RVA: 0x001D56A8 File Offset: 0x001D38A8
		// (set) Token: 0x060067E5 RID: 26597 RVA: 0x001D56B0 File Offset: 0x001D38B0
		[ProtoMember(2, IsRequired = true, Name = "PoolId", DataFormat = DataFormat.TwosComplement)]
		public int PoolId
		{
			get
			{
				return this._PoolId;
			}
			set
			{
				this._PoolId = value;
			}
		}

		// Token: 0x17001AAB RID: 6827
		// (get) Token: 0x060067E6 RID: 26598 RVA: 0x001D56BC File Offset: 0x001D38BC
		// (set) Token: 0x060067E7 RID: 26599 RVA: 0x001D56C4 File Offset: 0x001D38C4
		[ProtoMember(3, IsRequired = true, Name = "DrawedRaffleId", DataFormat = DataFormat.TwosComplement)]
		public int DrawedRaffleId
		{
			get
			{
				return this._DrawedRaffleId;
			}
			set
			{
				this._DrawedRaffleId = value;
			}
		}

		// Token: 0x17001AAC RID: 6828
		// (get) Token: 0x060067E8 RID: 26600 RVA: 0x001D56D0 File Offset: 0x001D38D0
		// (set) Token: 0x060067E9 RID: 26601 RVA: 0x001D56D8 File Offset: 0x001D38D8
		[ProtoMember(4, IsRequired = true, Name = "FreeDrawedCount", DataFormat = DataFormat.TwosComplement)]
		public int FreeDrawedCount
		{
			get
			{
				return this._FreeDrawedCount;
			}
			set
			{
				this._FreeDrawedCount = value;
			}
		}

		// Token: 0x17001AAD RID: 6829
		// (get) Token: 0x060067EA RID: 26602 RVA: 0x001D56E4 File Offset: 0x001D38E4
		// (set) Token: 0x060067EB RID: 26603 RVA: 0x001D56EC File Offset: 0x001D38EC
		[ProtoMember(5, IsRequired = true, Name = "DrawedCount", DataFormat = DataFormat.TwosComplement)]
		public int DrawedCount
		{
			get
			{
				return this._DrawedCount;
			}
			set
			{
				this._DrawedCount = value;
			}
		}

		// Token: 0x17001AAE RID: 6830
		// (get) Token: 0x060067EC RID: 26604 RVA: 0x001D56F8 File Offset: 0x001D38F8
		// (set) Token: 0x060067ED RID: 26605 RVA: 0x001D5700 File Offset: 0x001D3900
		[DefaultValue(null)]
		[ProtoMember(6, IsRequired = false, Name = "Ntf", DataFormat = DataFormat.Default)]
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

		// Token: 0x17001AAF RID: 6831
		// (get) Token: 0x060067EE RID: 26606 RVA: 0x001D570C File Offset: 0x001D390C
		// (set) Token: 0x060067EF RID: 26607 RVA: 0x001D5714 File Offset: 0x001D3914
		[DefaultValue(null)]
		[ProtoMember(7, IsRequired = false, Name = "DrawedGoods", DataFormat = DataFormat.Default)]
		public ProGoods DrawedGoods
		{
			get
			{
				return this._DrawedGoods;
			}
			set
			{
				this._DrawedGoods = value;
			}
		}

		// Token: 0x060067F0 RID: 26608 RVA: 0x001D5720 File Offset: 0x001D3920
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060067F1 RID: 26609 RVA: 0x001D5730 File Offset: 0x001D3930
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

		// Token: 0x060067F2 RID: 26610 RVA: 0x001D57FC File Offset: 0x001D39FC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(RaffleDrawAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04005013 RID: 20499
		private int _Result;

		// Token: 0x04005014 RID: 20500
		private int _PoolId;

		// Token: 0x04005015 RID: 20501
		private int _DrawedRaffleId;

		// Token: 0x04005016 RID: 20502
		private int _FreeDrawedCount;

		// Token: 0x04005017 RID: 20503
		private int _DrawedCount;

		// Token: 0x04005018 RID: 20504
		private ProChangedGoodsNtf _Ntf;

		// Token: 0x04005019 RID: 20505
		private ProGoods _DrawedGoods;

		// Token: 0x0400501A RID: 20506
		private IExtension extensionObject;

		// Token: 0x0400501B RID: 20507
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400501C RID: 20508
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400501D RID: 20509
		private LuaFunction m_ctor_hotfix;
	}
}
