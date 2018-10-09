using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000694 RID: 1684
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ProRealTimePVP")]
	[Serializable]
	public class ProRealTimePVP : IExtensible
	{
		// Token: 0x06005B6C RID: 23404 RVA: 0x001A3158 File Offset: 0x001A1358
		public ProRealTimePVP()
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

		// Token: 0x17001710 RID: 5904
		// (get) Token: 0x06005B6D RID: 23405 RVA: 0x001A31E0 File Offset: 0x001A13E0
		// (set) Token: 0x06005B6E RID: 23406 RVA: 0x001A31E8 File Offset: 0x001A13E8
		[ProtoMember(1, IsRequired = true, Name = "IsPromotion", DataFormat = DataFormat.Default)]
		public bool IsPromotion
		{
			get
			{
				return this._IsPromotion;
			}
			set
			{
				this._IsPromotion = value;
			}
		}

		// Token: 0x17001711 RID: 5905
		// (get) Token: 0x06005B6F RID: 23407 RVA: 0x001A31F4 File Offset: 0x001A13F4
		[ProtoMember(2, Name = "PromotionReports", DataFormat = DataFormat.Default)]
		public List<ProRealTimePVPBattleReport> PromotionReports
		{
			get
			{
				return this._PromotionReports;
			}
		}

		// Token: 0x17001712 RID: 5906
		// (get) Token: 0x06005B70 RID: 23408 RVA: 0x001A31FC File Offset: 0x001A13FC
		[ProtoMember(3, Name = "Reports", DataFormat = DataFormat.Default)]
		public List<ProRealTimePVPBattleReport> Reports
		{
			get
			{
				return this._Reports;
			}
		}

		// Token: 0x17001713 RID: 5907
		// (get) Token: 0x06005B71 RID: 23409 RVA: 0x001A3204 File Offset: 0x001A1404
		// (set) Token: 0x06005B72 RID: 23410 RVA: 0x001A320C File Offset: 0x001A140C
		[ProtoMember(4, IsRequired = true, Name = "FriendlyMatchStats", DataFormat = DataFormat.Default)]
		public ProRealTimePVPMatchStats FriendlyMatchStats
		{
			get
			{
				return this._FriendlyMatchStats;
			}
			set
			{
				this._FriendlyMatchStats = value;
			}
		}

		// Token: 0x17001714 RID: 5908
		// (get) Token: 0x06005B73 RID: 23411 RVA: 0x001A3218 File Offset: 0x001A1418
		// (set) Token: 0x06005B74 RID: 23412 RVA: 0x001A3220 File Offset: 0x001A1420
		[ProtoMember(5, IsRequired = true, Name = "LadderMatchStats", DataFormat = DataFormat.Default)]
		public ProRealTimePVPMatchStats LadderMatchStats
		{
			get
			{
				return this._LadderMatchStats;
			}
			set
			{
				this._LadderMatchStats = value;
			}
		}

		// Token: 0x17001715 RID: 5909
		// (get) Token: 0x06005B75 RID: 23413 RVA: 0x001A322C File Offset: 0x001A142C
		// (set) Token: 0x06005B76 RID: 23414 RVA: 0x001A3234 File Offset: 0x001A1434
		[ProtoMember(6, IsRequired = true, Name = "FriendlyCareerMatchStats", DataFormat = DataFormat.Default)]
		public ProRealTimePVPMatchStats FriendlyCareerMatchStats
		{
			get
			{
				return this._FriendlyCareerMatchStats;
			}
			set
			{
				this._FriendlyCareerMatchStats = value;
			}
		}

		// Token: 0x17001716 RID: 5910
		// (get) Token: 0x06005B77 RID: 23415 RVA: 0x001A3240 File Offset: 0x001A1440
		// (set) Token: 0x06005B78 RID: 23416 RVA: 0x001A3248 File Offset: 0x001A1448
		[ProtoMember(7, IsRequired = true, Name = "LadderCareerMatchStats", DataFormat = DataFormat.Default)]
		public ProRealTimePVPMatchStats LadderCareerMatchStats
		{
			get
			{
				return this._LadderCareerMatchStats;
			}
			set
			{
				this._LadderCareerMatchStats = value;
			}
		}

		// Token: 0x17001717 RID: 5911
		// (get) Token: 0x06005B79 RID: 23417 RVA: 0x001A3254 File Offset: 0x001A1454
		[ProtoMember(8, Name = "WinsBonusIdAcquired", DataFormat = DataFormat.TwosComplement)]
		public List<int> WinsBonusIdAcquired
		{
			get
			{
				return this._WinsBonusIdAcquired;
			}
		}

		// Token: 0x06005B7A RID: 23418 RVA: 0x001A325C File Offset: 0x001A145C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005B7B RID: 23419 RVA: 0x001A326C File Offset: 0x001A146C
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

		// Token: 0x06005B7C RID: 23420 RVA: 0x001A3338 File Offset: 0x001A1538
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProRealTimePVP));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004476 RID: 17526
		private bool _IsPromotion;

		// Token: 0x04004477 RID: 17527
		private readonly List<ProRealTimePVPBattleReport> _PromotionReports = new List<ProRealTimePVPBattleReport>();

		// Token: 0x04004478 RID: 17528
		private readonly List<ProRealTimePVPBattleReport> _Reports = new List<ProRealTimePVPBattleReport>();

		// Token: 0x04004479 RID: 17529
		private ProRealTimePVPMatchStats _FriendlyMatchStats;

		// Token: 0x0400447A RID: 17530
		private ProRealTimePVPMatchStats _LadderMatchStats;

		// Token: 0x0400447B RID: 17531
		private ProRealTimePVPMatchStats _FriendlyCareerMatchStats;

		// Token: 0x0400447C RID: 17532
		private ProRealTimePVPMatchStats _LadderCareerMatchStats;

		// Token: 0x0400447D RID: 17533
		private readonly List<int> _WinsBonusIdAcquired = new List<int>();

		// Token: 0x0400447E RID: 17534
		private IExtension extensionObject;

		// Token: 0x0400447F RID: 17535
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004480 RID: 17536
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004481 RID: 17537
		private LuaFunction m_ctor_hotfix;
	}
}
