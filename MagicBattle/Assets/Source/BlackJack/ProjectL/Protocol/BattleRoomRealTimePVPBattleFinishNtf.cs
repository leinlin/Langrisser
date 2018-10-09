using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000609 RID: 1545
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "BattleRoomRealTimePVPBattleFinishNtf")]
	[Serializable]
	public class BattleRoomRealTimePVPBattleFinishNtf : IExtensible
	{
		// Token: 0x06005584 RID: 21892 RVA: 0x00192054 File Offset: 0x00190254
		public BattleRoomRealTimePVPBattleFinishNtf()
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

		// Token: 0x1700150C RID: 5388
		// (get) Token: 0x06005585 RID: 21893 RVA: 0x001920BC File Offset: 0x001902BC
		// (set) Token: 0x06005586 RID: 21894 RVA: 0x001920C4 File Offset: 0x001902C4
		[ProtoMember(1, IsRequired = true, Name = "WinSessionId", DataFormat = DataFormat.TwosComplement)]
		public ulong WinSessionId
		{
			get
			{
				return this._WinSessionId;
			}
			set
			{
				this._WinSessionId = value;
			}
		}

		// Token: 0x1700150D RID: 5389
		// (get) Token: 0x06005587 RID: 21895 RVA: 0x001920D0 File Offset: 0x001902D0
		// (set) Token: 0x06005588 RID: 21896 RVA: 0x001920D8 File Offset: 0x001902D8
		[ProtoMember(2, IsRequired = true, Name = "Mode", DataFormat = DataFormat.TwosComplement)]
		public int Mode
		{
			get
			{
				return this._Mode;
			}
			set
			{
				this._Mode = value;
			}
		}

		// Token: 0x1700150E RID: 5390
		// (get) Token: 0x06005589 RID: 21897 RVA: 0x001920E4 File Offset: 0x001902E4
		// (set) Token: 0x0600558A RID: 21898 RVA: 0x001920EC File Offset: 0x001902EC
		[ProtoMember(3, IsRequired = true, Name = "DanDiff", DataFormat = DataFormat.TwosComplement)]
		public int DanDiff
		{
			get
			{
				return this._DanDiff;
			}
			set
			{
				this._DanDiff = value;
			}
		}

		// Token: 0x1700150F RID: 5391
		// (get) Token: 0x0600558B RID: 21899 RVA: 0x001920F8 File Offset: 0x001902F8
		// (set) Token: 0x0600558C RID: 21900 RVA: 0x00192100 File Offset: 0x00190300
		[ProtoMember(4, IsRequired = true, Name = "LocalRankDiff", DataFormat = DataFormat.TwosComplement)]
		public int LocalRankDiff
		{
			get
			{
				return this._LocalRankDiff;
			}
			set
			{
				this._LocalRankDiff = value;
			}
		}

		// Token: 0x17001510 RID: 5392
		// (get) Token: 0x0600558D RID: 21901 RVA: 0x0019210C File Offset: 0x0019030C
		// (set) Token: 0x0600558E RID: 21902 RVA: 0x00192114 File Offset: 0x00190314
		[ProtoMember(5, IsRequired = true, Name = "GlobalRankDiff", DataFormat = DataFormat.TwosComplement)]
		public int GlobalRankDiff
		{
			get
			{
				return this._GlobalRankDiff;
			}
			set
			{
				this._GlobalRankDiff = value;
			}
		}

		// Token: 0x17001511 RID: 5393
		// (get) Token: 0x0600558F RID: 21903 RVA: 0x00192120 File Offset: 0x00190320
		// (set) Token: 0x06005590 RID: 21904 RVA: 0x00192128 File Offset: 0x00190328
		[ProtoMember(6, IsRequired = true, Name = "IsPromotion", DataFormat = DataFormat.Default)]
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

		// Token: 0x17001512 RID: 5394
		// (get) Token: 0x06005591 RID: 21905 RVA: 0x00192134 File Offset: 0x00190334
		// (set) Token: 0x06005592 RID: 21906 RVA: 0x0019213C File Offset: 0x0019033C
		[ProtoMember(7, IsRequired = true, Name = "Report", DataFormat = DataFormat.Default)]
		public ProRealTimePVPBattleReport Report
		{
			get
			{
				return this._Report;
			}
			set
			{
				this._Report = value;
			}
		}

		// Token: 0x17001513 RID: 5395
		// (get) Token: 0x06005593 RID: 21907 RVA: 0x00192148 File Offset: 0x00190348
		// (set) Token: 0x06005594 RID: 21908 RVA: 0x00192150 File Offset: 0x00190350
		[ProtoMember(8, IsRequired = true, Name = "BattleInstanceId", DataFormat = DataFormat.TwosComplement)]
		public ulong BattleInstanceId
		{
			get
			{
				return this._BattleInstanceId;
			}
			set
			{
				this._BattleInstanceId = value;
			}
		}

		// Token: 0x06005595 RID: 21909 RVA: 0x0019215C File Offset: 0x0019035C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005596 RID: 21910 RVA: 0x0019216C File Offset: 0x0019036C
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

		// Token: 0x06005597 RID: 21911 RVA: 0x00192238 File Offset: 0x00190438
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattleRoomRealTimePVPBattleFinishNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004046 RID: 16454
		private ulong _WinSessionId;

		// Token: 0x04004047 RID: 16455
		private int _Mode;

		// Token: 0x04004048 RID: 16456
		private int _DanDiff;

		// Token: 0x04004049 RID: 16457
		private int _LocalRankDiff;

		// Token: 0x0400404A RID: 16458
		private int _GlobalRankDiff;

		// Token: 0x0400404B RID: 16459
		private bool _IsPromotion;

		// Token: 0x0400404C RID: 16460
		private ProRealTimePVPBattleReport _Report;

		// Token: 0x0400404D RID: 16461
		private ulong _BattleInstanceId;

		// Token: 0x0400404E RID: 16462
		private IExtension extensionObject;

		// Token: 0x0400404F RID: 16463
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004050 RID: 16464
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004051 RID: 16465
		private LuaFunction m_ctor_hotfix;
	}
}
