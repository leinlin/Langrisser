using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200070B RID: 1803
	[ProtoContract(Name = "RedeemInfoAck")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class RedeemInfoAck : IExtensible
	{
		// Token: 0x06005F93 RID: 24467 RVA: 0x001B1120 File Offset: 0x001AF320
		public RedeemInfoAck()
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

		// Token: 0x1700184E RID: 6222
		// (get) Token: 0x06005F94 RID: 24468 RVA: 0x001B1194 File Offset: 0x001AF394
		// (set) Token: 0x06005F95 RID: 24469 RVA: 0x001B119C File Offset: 0x001AF39C
		[ProtoMember(1, IsRequired = true, Name = "TotalRecharge", DataFormat = DataFormat.TwosComplement)]
		public int TotalRecharge
		{
			get
			{
				return this._TotalRecharge;
			}
			set
			{
				this._TotalRecharge = value;
			}
		}

		// Token: 0x1700184F RID: 6223
		// (get) Token: 0x06005F96 RID: 24470 RVA: 0x001B11A8 File Offset: 0x001AF3A8
		[ProtoMember(2, Name = "Crystals", DataFormat = DataFormat.Default)]
		public List<RedeemCrystalInfo> Crystals
		{
			get
			{
				return this._Crystals;
			}
		}

		// Token: 0x17001850 RID: 6224
		// (get) Token: 0x06005F97 RID: 24471 RVA: 0x001B11B0 File Offset: 0x001AF3B0
		// (set) Token: 0x06005F98 RID: 24472 RVA: 0x001B11B8 File Offset: 0x001AF3B8
		[ProtoMember(3, IsRequired = true, Name = "Bundle", DataFormat = DataFormat.Default)]
		public RedeemBundleInfo Bundle
		{
			get
			{
				return this._Bundle;
			}
			set
			{
				this._Bundle = value;
			}
		}

		// Token: 0x17001851 RID: 6225
		// (get) Token: 0x06005F99 RID: 24473 RVA: 0x001B11C4 File Offset: 0x001AF3C4
		// (set) Token: 0x06005F9A RID: 24474 RVA: 0x001B11CC File Offset: 0x001AF3CC
		[ProtoMember(4, IsRequired = true, Name = "Claimed", DataFormat = DataFormat.Default)]
		public bool Claimed
		{
			get
			{
				return this._Claimed;
			}
			set
			{
				this._Claimed = value;
			}
		}

		// Token: 0x17001852 RID: 6226
		// (get) Token: 0x06005F9B RID: 24475 RVA: 0x001B11D8 File Offset: 0x001AF3D8
		// (set) Token: 0x06005F9C RID: 24476 RVA: 0x001B11E0 File Offset: 0x001AF3E0
		[ProtoMember(5, IsRequired = true, Name = "StartDate", DataFormat = DataFormat.TwosComplement)]
		public long StartDate
		{
			get
			{
				return this._StartDate;
			}
			set
			{
				this._StartDate = value;
			}
		}

		// Token: 0x17001853 RID: 6227
		// (get) Token: 0x06005F9D RID: 24477 RVA: 0x001B11EC File Offset: 0x001AF3EC
		// (set) Token: 0x06005F9E RID: 24478 RVA: 0x001B11F4 File Offset: 0x001AF3F4
		[ProtoMember(6, IsRequired = true, Name = "EndDate", DataFormat = DataFormat.TwosComplement)]
		public long EndDate
		{
			get
			{
				return this._EndDate;
			}
			set
			{
				this._EndDate = value;
			}
		}

		// Token: 0x06005F9F RID: 24479 RVA: 0x001B1200 File Offset: 0x001AF400
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005FA0 RID: 24480 RVA: 0x001B1210 File Offset: 0x001AF410
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

		// Token: 0x06005FA1 RID: 24481 RVA: 0x001B12DC File Offset: 0x001AF4DC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(RedeemInfoAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004790 RID: 18320
		private int _TotalRecharge;

		// Token: 0x04004791 RID: 18321
		private readonly List<RedeemCrystalInfo> _Crystals = new List<RedeemCrystalInfo>();

		// Token: 0x04004792 RID: 18322
		private RedeemBundleInfo _Bundle;

		// Token: 0x04004793 RID: 18323
		private bool _Claimed;

		// Token: 0x04004794 RID: 18324
		private long _StartDate;

		// Token: 0x04004795 RID: 18325
		private long _EndDate;

		// Token: 0x04004796 RID: 18326
		private IExtension extensionObject;

		// Token: 0x04004797 RID: 18327
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004798 RID: 18328
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004799 RID: 18329
		private LuaFunction m_ctor_hotfix;
	}
}
