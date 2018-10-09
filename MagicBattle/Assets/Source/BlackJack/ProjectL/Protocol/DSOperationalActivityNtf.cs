using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000724 RID: 1828
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "DSOperationalActivityNtf")]
	[Serializable]
	public class DSOperationalActivityNtf : IExtensible
	{
		// Token: 0x06006093 RID: 24723 RVA: 0x001B41A8 File Offset: 0x001B23A8
		public DSOperationalActivityNtf()
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

		// Token: 0x170018A5 RID: 6309
		// (get) Token: 0x06006094 RID: 24724 RVA: 0x001B425C File Offset: 0x001B245C
		// (set) Token: 0x06006095 RID: 24725 RVA: 0x001B4264 File Offset: 0x001B2464
		[ProtoMember(1, IsRequired = true, Name = "Version", DataFormat = DataFormat.TwosComplement)]
		public uint Version
		{
			get
			{
				return this._Version;
			}
			set
			{
				this._Version = value;
			}
		}

		// Token: 0x170018A6 RID: 6310
		// (get) Token: 0x06006096 RID: 24726 RVA: 0x001B4270 File Offset: 0x001B2470
		[ProtoMember(2, Name = "PlayerLevelUpAwardOperationalActivities", DataFormat = DataFormat.Default)]
		public List<ProPlayerLevelUpOperationalActivity> PlayerLevelUpAwardOperationalActivities
		{
			get
			{
				return this._PlayerLevelUpAwardOperationalActivities;
			}
		}

		// Token: 0x170018A7 RID: 6311
		// (get) Token: 0x06006097 RID: 24727 RVA: 0x001B4278 File Offset: 0x001B2478
		[ProtoMember(3, Name = "SpecificDaysLoginAwardOperationalActivities", DataFormat = DataFormat.Default)]
		public List<ProSpecificDaysLoginOperationalActivity> SpecificDaysLoginAwardOperationalActivities
		{
			get
			{
				return this._SpecificDaysLoginAwardOperationalActivities;
			}
		}

		// Token: 0x170018A8 RID: 6312
		// (get) Token: 0x06006098 RID: 24728 RVA: 0x001B4280 File Offset: 0x001B2480
		[ProtoMember(4, Name = "AccumulateLoginAwardOperationalActivities", DataFormat = DataFormat.Default)]
		public List<ProAccumulateLoginOperationalActivity> AccumulateLoginAwardOperationalActivities
		{
			get
			{
				return this._AccumulateLoginAwardOperationalActivities;
			}
		}

		// Token: 0x170018A9 RID: 6313
		// (get) Token: 0x06006099 RID: 24729 RVA: 0x001B4288 File Offset: 0x001B2488
		[ProtoMember(5, Name = "LimitedTimeExchangeOperationActivities", DataFormat = DataFormat.Default)]
		public List<ProLimitedTimeExchangeOperationActivity> LimitedTimeExchangeOperationActivities
		{
			get
			{
				return this._LimitedTimeExchangeOperationActivities;
			}
		}

		// Token: 0x170018AA RID: 6314
		// (get) Token: 0x0600609A RID: 24730 RVA: 0x001B4290 File Offset: 0x001B2490
		[ProtoMember(6, Name = "EffectOperationActivities", DataFormat = DataFormat.Default)]
		public List<ProEffectOperationActivity> EffectOperationActivities
		{
			get
			{
				return this._EffectOperationActivities;
			}
		}

		// Token: 0x170018AB RID: 6315
		// (get) Token: 0x0600609B RID: 24731 RVA: 0x001B4298 File Offset: 0x001B2498
		[ProtoMember(7, Name = "AccumulateRechargeOperationalActivities", DataFormat = DataFormat.Default)]
		public List<ProAccumulateRechargeOperationalActivity> AccumulateRechargeOperationalActivities
		{
			get
			{
				return this._AccumulateRechargeOperationalActivities;
			}
		}

		// Token: 0x170018AC RID: 6316
		// (get) Token: 0x0600609C RID: 24732 RVA: 0x001B42A0 File Offset: 0x001B24A0
		[ProtoMember(8, Name = "AccumulateConsumeCrystalOperationalActivitites", DataFormat = DataFormat.Default)]
		public List<ProAccumulateConsumeCrystalOperationalActivity> AccumulateConsumeCrystalOperationalActivitites
		{
			get
			{
				return this._AccumulateConsumeCrystalOperationalActivitites;
			}
		}

		// Token: 0x0600609D RID: 24733 RVA: 0x001B42A8 File Offset: 0x001B24A8
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600609E RID: 24734 RVA: 0x001B42B8 File Offset: 0x001B24B8
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

		// Token: 0x0600609F RID: 24735 RVA: 0x001B4384 File Offset: 0x001B2584
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(DSOperationalActivityNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400484B RID: 18507
		private uint _Version;

		// Token: 0x0400484C RID: 18508
		private readonly List<ProPlayerLevelUpOperationalActivity> _PlayerLevelUpAwardOperationalActivities = new List<ProPlayerLevelUpOperationalActivity>();

		// Token: 0x0400484D RID: 18509
		private readonly List<ProSpecificDaysLoginOperationalActivity> _SpecificDaysLoginAwardOperationalActivities = new List<ProSpecificDaysLoginOperationalActivity>();

		// Token: 0x0400484E RID: 18510
		private readonly List<ProAccumulateLoginOperationalActivity> _AccumulateLoginAwardOperationalActivities = new List<ProAccumulateLoginOperationalActivity>();

		// Token: 0x0400484F RID: 18511
		private readonly List<ProLimitedTimeExchangeOperationActivity> _LimitedTimeExchangeOperationActivities = new List<ProLimitedTimeExchangeOperationActivity>();

		// Token: 0x04004850 RID: 18512
		private readonly List<ProEffectOperationActivity> _EffectOperationActivities = new List<ProEffectOperationActivity>();

		// Token: 0x04004851 RID: 18513
		private readonly List<ProAccumulateRechargeOperationalActivity> _AccumulateRechargeOperationalActivities = new List<ProAccumulateRechargeOperationalActivity>();

		// Token: 0x04004852 RID: 18514
		private readonly List<ProAccumulateConsumeCrystalOperationalActivity> _AccumulateConsumeCrystalOperationalActivitites = new List<ProAccumulateConsumeCrystalOperationalActivity>();

		// Token: 0x04004853 RID: 18515
		private IExtension extensionObject;

		// Token: 0x04004854 RID: 18516
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004855 RID: 18517
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004856 RID: 18518
		private LuaFunction m_ctor_hotfix;
	}
}
