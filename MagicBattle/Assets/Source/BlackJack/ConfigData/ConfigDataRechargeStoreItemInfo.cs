using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x0200027F RID: 639
	[ProtoContract(Name = "ConfigDataRechargeStoreItemInfo")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ConfigDataRechargeStoreItemInfo : IExtensible
	{
		// Token: 0x060028F5 RID: 10485 RVA: 0x000AF2A4 File Offset: 0x000AD4A4
		public ConfigDataRechargeStoreItemInfo()
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

		// Token: 0x17000AC6 RID: 2758
		// (get) Token: 0x060028F6 RID: 10486 RVA: 0x000AF30C File Offset: 0x000AD50C
		// (set) Token: 0x060028F7 RID: 10487 RVA: 0x000AF314 File Offset: 0x000AD514
		[ProtoMember(2, IsRequired = true, Name = "ID", DataFormat = DataFormat.TwosComplement)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				this._ID = value;
			}
		}

		// Token: 0x17000AC7 RID: 2759
		// (get) Token: 0x060028F8 RID: 10488 RVA: 0x000AF320 File Offset: 0x000AD520
		// (set) Token: 0x060028F9 RID: 10489 RVA: 0x000AF328 File Offset: 0x000AD528
		[ProtoMember(3, IsRequired = true, Name = "Price", DataFormat = DataFormat.TwosComplement)]
		public int Price
		{
			get
			{
				return this._Price;
			}
			set
			{
				this._Price = value;
			}
		}

		// Token: 0x17000AC8 RID: 2760
		// (get) Token: 0x060028FA RID: 10490 RVA: 0x000AF334 File Offset: 0x000AD534
		// (set) Token: 0x060028FB RID: 10491 RVA: 0x000AF33C File Offset: 0x000AD53C
		[ProtoMember(4, IsRequired = true, Name = "GotCrystalNums", DataFormat = DataFormat.TwosComplement)]
		public int GotCrystalNums
		{
			get
			{
				return this._GotCrystalNums;
			}
			set
			{
				this._GotCrystalNums = value;
			}
		}

		// Token: 0x17000AC9 RID: 2761
		// (get) Token: 0x060028FC RID: 10492 RVA: 0x000AF348 File Offset: 0x000AD548
		// (set) Token: 0x060028FD RID: 10493 RVA: 0x000AF350 File Offset: 0x000AD550
		[ProtoMember(5, IsRequired = true, Name = "FirstBoughtReward", DataFormat = DataFormat.TwosComplement)]
		public int FirstBoughtReward
		{
			get
			{
				return this._FirstBoughtReward;
			}
			set
			{
				this._FirstBoughtReward = value;
			}
		}

		// Token: 0x17000ACA RID: 2762
		// (get) Token: 0x060028FE RID: 10494 RVA: 0x000AF35C File Offset: 0x000AD55C
		// (set) Token: 0x060028FF RID: 10495 RVA: 0x000AF364 File Offset: 0x000AD564
		[ProtoMember(6, IsRequired = true, Name = "RepeatlyBoughtReward", DataFormat = DataFormat.TwosComplement)]
		public int RepeatlyBoughtReward
		{
			get
			{
				return this._RepeatlyBoughtReward;
			}
			set
			{
				this._RepeatlyBoughtReward = value;
			}
		}

		// Token: 0x17000ACB RID: 2763
		// (get) Token: 0x06002900 RID: 10496 RVA: 0x000AF370 File Offset: 0x000AD570
		// (set) Token: 0x06002901 RID: 10497 RVA: 0x000AF378 File Offset: 0x000AD578
		[ProtoMember(7, IsRequired = true, Name = "Icon", DataFormat = DataFormat.Default)]
		public string Icon
		{
			get
			{
				return this._Icon;
			}
			set
			{
				this._Icon = value;
			}
		}

		// Token: 0x06002902 RID: 10498 RVA: 0x000AF384 File Offset: 0x000AD584
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002903 RID: 10499 RVA: 0x000AF394 File Offset: 0x000AD594
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

		// Token: 0x06002904 RID: 10500 RVA: 0x000AF460 File Offset: 0x000AD660
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataRechargeStoreItemInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04001931 RID: 6449
		private int _ID;

		// Token: 0x04001932 RID: 6450
		private int _Price;

		// Token: 0x04001933 RID: 6451
		private int _GotCrystalNums;

		// Token: 0x04001934 RID: 6452
		private int _FirstBoughtReward;

		// Token: 0x04001935 RID: 6453
		private int _RepeatlyBoughtReward;

		// Token: 0x04001936 RID: 6454
		private string _Icon;

		// Token: 0x04001937 RID: 6455
		private IExtension extensionObject;

		// Token: 0x04001938 RID: 6456
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04001939 RID: 6457
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400193A RID: 6458
		private LuaFunction m_ctor_hotfix;
	}
}
