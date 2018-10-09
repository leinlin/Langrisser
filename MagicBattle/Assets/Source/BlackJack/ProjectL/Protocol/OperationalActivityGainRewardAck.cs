using System;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020007FF RID: 2047
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "OperationalActivityGainRewardAck")]
	[Serializable]
	public class OperationalActivityGainRewardAck : IExtensible
	{
		// Token: 0x060067B2 RID: 26546 RVA: 0x001CD72C File Offset: 0x001CB92C
		public OperationalActivityGainRewardAck()
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

		// Token: 0x17001A9D RID: 6813
		// (get) Token: 0x060067B3 RID: 26547 RVA: 0x001CD794 File Offset: 0x001CB994
		// (set) Token: 0x060067B4 RID: 26548 RVA: 0x001CD79C File Offset: 0x001CB99C
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

		// Token: 0x17001A9E RID: 6814
		// (get) Token: 0x060067B5 RID: 26549 RVA: 0x001CD7A8 File Offset: 0x001CB9A8
		// (set) Token: 0x060067B6 RID: 26550 RVA: 0x001CD7B0 File Offset: 0x001CB9B0
		[ProtoMember(2, IsRequired = true, Name = "OperationalActivityInstanceId", DataFormat = DataFormat.TwosComplement)]
		public ulong OperationalActivityInstanceId
		{
			get
			{
				return this._OperationalActivityInstanceId;
			}
			set
			{
				this._OperationalActivityInstanceId = value;
			}
		}

		// Token: 0x17001A9F RID: 6815
		// (get) Token: 0x060067B7 RID: 26551 RVA: 0x001CD7BC File Offset: 0x001CB9BC
		// (set) Token: 0x060067B8 RID: 26552 RVA: 0x001CD7C4 File Offset: 0x001CB9C4
		[ProtoMember(3, IsRequired = true, Name = "RewardIndex", DataFormat = DataFormat.TwosComplement)]
		public int RewardIndex
		{
			get
			{
				return this._RewardIndex;
			}
			set
			{
				this._RewardIndex = value;
			}
		}

		// Token: 0x17001AA0 RID: 6816
		// (get) Token: 0x060067B9 RID: 26553 RVA: 0x001CD7D0 File Offset: 0x001CB9D0
		// (set) Token: 0x060067BA RID: 26554 RVA: 0x001CD7D8 File Offset: 0x001CB9D8
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

		// Token: 0x060067BB RID: 26555 RVA: 0x001CD7E4 File Offset: 0x001CB9E4
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060067BC RID: 26556 RVA: 0x001CD7F4 File Offset: 0x001CB9F4
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

		// Token: 0x060067BD RID: 26557 RVA: 0x001CD8C0 File Offset: 0x001CBAC0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(OperationalActivityGainRewardAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004DAF RID: 19887
		private int _Result;

		// Token: 0x04004DB0 RID: 19888
		private ulong _OperationalActivityInstanceId;

		// Token: 0x04004DB1 RID: 19889
		private int _RewardIndex;

		// Token: 0x04004DB2 RID: 19890
		private ProChangedGoodsNtf _Ntf;

		// Token: 0x04004DB3 RID: 19891
		private IExtension extensionObject;

		// Token: 0x04004DB4 RID: 19892
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004DB5 RID: 19893
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004DB6 RID: 19894
		private LuaFunction m_ctor_hotfix;
	}
}
