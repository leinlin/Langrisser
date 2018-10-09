using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200074E RID: 1870
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "BoughtRechargeStoreItemNtf")]
	[Serializable]
	public class BoughtRechargeStoreItemNtf : IExtensible
	{
		// Token: 0x060061F2 RID: 25074 RVA: 0x001B9014 File Offset: 0x001B7214
		public BoughtRechargeStoreItemNtf()
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

		// Token: 0x1700190F RID: 6415
		// (get) Token: 0x060061F3 RID: 25075 RVA: 0x001B907C File Offset: 0x001B727C
		// (set) Token: 0x060061F4 RID: 25076 RVA: 0x001B9084 File Offset: 0x001B7284
		[ProtoMember(1, IsRequired = true, Name = "GoodsId", DataFormat = DataFormat.TwosComplement)]
		public int GoodsId
		{
			get
			{
				return this._GoodsId;
			}
			set
			{
				this._GoodsId = value;
			}
		}

		// Token: 0x17001910 RID: 6416
		// (get) Token: 0x060061F5 RID: 25077 RVA: 0x001B9090 File Offset: 0x001B7290
		// (set) Token: 0x060061F6 RID: 25078 RVA: 0x001B9098 File Offset: 0x001B7298
		[ProtoMember(2, IsRequired = true, Name = "RechargeCrystal", DataFormat = DataFormat.TwosComplement)]
		public int RechargeCrystal
		{
			get
			{
				return this._RechargeCrystal;
			}
			set
			{
				this._RechargeCrystal = value;
			}
		}

		// Token: 0x17001911 RID: 6417
		// (get) Token: 0x060061F7 RID: 25079 RVA: 0x001B90A4 File Offset: 0x001B72A4
		// (set) Token: 0x060061F8 RID: 25080 RVA: 0x001B90AC File Offset: 0x001B72AC
		[ProtoMember(3, IsRequired = true, Name = "Ntf", DataFormat = DataFormat.Default)]
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

		// Token: 0x17001912 RID: 6418
		// (get) Token: 0x060061F9 RID: 25081 RVA: 0x001B90B8 File Offset: 0x001B72B8
		// (set) Token: 0x060061FA RID: 25082 RVA: 0x001B90C0 File Offset: 0x001B72C0
		[ProtoMember(4, IsRequired = true, Name = "Reward", DataFormat = DataFormat.Default)]
		public ProOrderReward Reward
		{
			get
			{
				return this._Reward;
			}
			set
			{
				this._Reward = value;
			}
		}

		// Token: 0x060061FB RID: 25083 RVA: 0x001B90CC File Offset: 0x001B72CC
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060061FC RID: 25084 RVA: 0x001B90DC File Offset: 0x001B72DC
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

		// Token: 0x060061FD RID: 25085 RVA: 0x001B91A8 File Offset: 0x001B73A8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BoughtRechargeStoreItemNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400495D RID: 18781
		private int _GoodsId;

		// Token: 0x0400495E RID: 18782
		private int _RechargeCrystal;

		// Token: 0x0400495F RID: 18783
		private ProChangedGoodsNtf _Ntf;

		// Token: 0x04004960 RID: 18784
		private ProOrderReward _Reward;

		// Token: 0x04004961 RID: 18785
		private IExtension extensionObject;

		// Token: 0x04004962 RID: 18786
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004963 RID: 18787
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004964 RID: 18788
		private LuaFunction m_ctor_hotfix;
	}
}
