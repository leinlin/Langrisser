using System;
using System.Collections.Generic;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020007A4 RID: 1956
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "HeroPhantomBattleFinishedAck")]
	[Serializable]
	public class HeroPhantomBattleFinishedAck : IExtensible
	{
		// Token: 0x0600648A RID: 25738 RVA: 0x001C2D00 File Offset: 0x001C0F00
		public HeroPhantomBattleFinishedAck()
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

		// Token: 0x170019B6 RID: 6582
		// (get) Token: 0x0600648B RID: 25739 RVA: 0x001C2D88 File Offset: 0x001C0F88
		// (set) Token: 0x0600648C RID: 25740 RVA: 0x001C2D90 File Offset: 0x001C0F90
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

		// Token: 0x170019B7 RID: 6583
		// (get) Token: 0x0600648D RID: 25741 RVA: 0x001C2D9C File Offset: 0x001C0F9C
		// (set) Token: 0x0600648E RID: 25742 RVA: 0x001C2DA4 File Offset: 0x001C0FA4
		[ProtoMember(2, IsRequired = true, Name = "Req", DataFormat = DataFormat.Default)]
		public HeroPhantomBattleFinishedReq Req
		{
			get
			{
				return this._Req;
			}
			set
			{
				this._Req = value;
			}
		}

		// Token: 0x170019B8 RID: 6584
		// (get) Token: 0x0600648F RID: 25743 RVA: 0x001C2DB0 File Offset: 0x001C0FB0
		// (set) Token: 0x06006490 RID: 25744 RVA: 0x001C2DB8 File Offset: 0x001C0FB8
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

		// Token: 0x170019B9 RID: 6585
		// (get) Token: 0x06006491 RID: 25745 RVA: 0x001C2DC4 File Offset: 0x001C0FC4
		// (set) Token: 0x06006492 RID: 25746 RVA: 0x001C2DCC File Offset: 0x001C0FCC
		[DefaultValue(null)]
		[ProtoMember(4, IsRequired = false, Name = "Ntf", DataFormat = DataFormat.Default)]
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

		// Token: 0x170019BA RID: 6586
		// (get) Token: 0x06006493 RID: 25747 RVA: 0x001C2DD8 File Offset: 0x001C0FD8
		[ProtoMember(5, Name = "NormalRewards", DataFormat = DataFormat.Default)]
		public List<ProGoods> NormalRewards
		{
			get
			{
				return this._NormalRewards;
			}
		}

		// Token: 0x170019BB RID: 6587
		// (get) Token: 0x06006494 RID: 25748 RVA: 0x001C2DE0 File Offset: 0x001C0FE0
		[ProtoMember(6, Name = "Achievements", DataFormat = DataFormat.TwosComplement)]
		public List<int> Achievements
		{
			get
			{
				return this._Achievements;
			}
		}

		// Token: 0x170019BC RID: 6588
		// (get) Token: 0x06006495 RID: 25749 RVA: 0x001C2DE8 File Offset: 0x001C0FE8
		[ProtoMember(7, Name = "BattleTreasures", DataFormat = DataFormat.TwosComplement)]
		public List<int> BattleTreasures
		{
			get
			{
				return this._BattleTreasures;
			}
		}

		// Token: 0x06006496 RID: 25750 RVA: 0x001C2DF0 File Offset: 0x001C0FF0
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006497 RID: 25751 RVA: 0x001C2E00 File Offset: 0x001C1000
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

		// Token: 0x06006498 RID: 25752 RVA: 0x001C2ECC File Offset: 0x001C10CC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroPhantomBattleFinishedAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004B5C RID: 19292
		private int _Result;

		// Token: 0x04004B5D RID: 19293
		private HeroPhantomBattleFinishedReq _Req;

		// Token: 0x04004B5E RID: 19294
		private bool _Win;

		// Token: 0x04004B5F RID: 19295
		private ProChangedGoodsNtf _Ntf;

		// Token: 0x04004B60 RID: 19296
		private readonly List<ProGoods> _NormalRewards = new List<ProGoods>();

		// Token: 0x04004B61 RID: 19297
		private readonly List<int> _Achievements = new List<int>();

		// Token: 0x04004B62 RID: 19298
		private readonly List<int> _BattleTreasures = new List<int>();

		// Token: 0x04004B63 RID: 19299
		private IExtension extensionObject;

		// Token: 0x04004B64 RID: 19300
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004B65 RID: 19301
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004B66 RID: 19302
		private LuaFunction m_ctor_hotfix;
	}
}
