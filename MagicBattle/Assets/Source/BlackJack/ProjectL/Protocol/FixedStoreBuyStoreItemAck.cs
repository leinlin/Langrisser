using System;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020006B9 RID: 1721
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "FixedStoreBuyStoreItemAck")]
	[Serializable]
	public class FixedStoreBuyStoreItemAck : IExtensible
	{
		// Token: 0x06005D19 RID: 23833 RVA: 0x001A7B0C File Offset: 0x001A5D0C
		public FixedStoreBuyStoreItemAck()
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

		// Token: 0x170017A9 RID: 6057
		// (get) Token: 0x06005D1A RID: 23834 RVA: 0x001A7B74 File Offset: 0x001A5D74
		// (set) Token: 0x06005D1B RID: 23835 RVA: 0x001A7B7C File Offset: 0x001A5D7C
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

		// Token: 0x170017AA RID: 6058
		// (get) Token: 0x06005D1C RID: 23836 RVA: 0x001A7B88 File Offset: 0x001A5D88
		// (set) Token: 0x06005D1D RID: 23837 RVA: 0x001A7B90 File Offset: 0x001A5D90
		[ProtoMember(2, IsRequired = true, Name = "StoreId", DataFormat = DataFormat.TwosComplement)]
		public int StoreId
		{
			get
			{
				return this._StoreId;
			}
			set
			{
				this._StoreId = value;
			}
		}

		// Token: 0x170017AB RID: 6059
		// (get) Token: 0x06005D1E RID: 23838 RVA: 0x001A7B9C File Offset: 0x001A5D9C
		// (set) Token: 0x06005D1F RID: 23839 RVA: 0x001A7BA4 File Offset: 0x001A5DA4
		[ProtoMember(3, IsRequired = true, Name = "GoodsId", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x170017AC RID: 6060
		// (get) Token: 0x06005D20 RID: 23840 RVA: 0x001A7BB0 File Offset: 0x001A5DB0
		// (set) Token: 0x06005D21 RID: 23841 RVA: 0x001A7BB8 File Offset: 0x001A5DB8
		[ProtoMember(4, IsRequired = true, Name = "SelectedIndex", DataFormat = DataFormat.TwosComplement)]
		public int SelectedIndex
		{
			get
			{
				return this._SelectedIndex;
			}
			set
			{
				this._SelectedIndex = value;
			}
		}

		// Token: 0x170017AD RID: 6061
		// (get) Token: 0x06005D22 RID: 23842 RVA: 0x001A7BC4 File Offset: 0x001A5DC4
		// (set) Token: 0x06005D23 RID: 23843 RVA: 0x001A7BCC File Offset: 0x001A5DCC
		[DefaultValue(0L)]
		[ProtoMember(5, IsRequired = false, Name = "GoodsNextFlushTime", DataFormat = DataFormat.TwosComplement)]
		public long GoodsNextFlushTime
		{
			get
			{
				return this._GoodsNextFlushTime;
			}
			set
			{
				this._GoodsNextFlushTime = value;
			}
		}

		// Token: 0x170017AE RID: 6062
		// (get) Token: 0x06005D24 RID: 23844 RVA: 0x001A7BD8 File Offset: 0x001A5DD8
		// (set) Token: 0x06005D25 RID: 23845 RVA: 0x001A7BE0 File Offset: 0x001A5DE0
		[ProtoMember(6, IsRequired = false, Name = "IsResetNextFlushTime", DataFormat = DataFormat.Default)]
		[DefaultValue(false)]
		public bool IsResetNextFlushTime
		{
			get
			{
				return this._IsResetNextFlushTime;
			}
			set
			{
				this._IsResetNextFlushTime = value;
			}
		}

		// Token: 0x170017AF RID: 6063
		// (get) Token: 0x06005D26 RID: 23846 RVA: 0x001A7BEC File Offset: 0x001A5DEC
		// (set) Token: 0x06005D27 RID: 23847 RVA: 0x001A7BF4 File Offset: 0x001A5DF4
		[DefaultValue(null)]
		[ProtoMember(7, IsRequired = false, Name = "Ntf", DataFormat = DataFormat.Default)]
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

		// Token: 0x06005D28 RID: 23848 RVA: 0x001A7C00 File Offset: 0x001A5E00
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005D29 RID: 23849 RVA: 0x001A7C10 File Offset: 0x001A5E10
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

		// Token: 0x06005D2A RID: 23850 RVA: 0x001A7CDC File Offset: 0x001A5EDC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(FixedStoreBuyStoreItemAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040045A3 RID: 17827
		private int _Result;

		// Token: 0x040045A4 RID: 17828
		private int _StoreId;

		// Token: 0x040045A5 RID: 17829
		private int _GoodsId;

		// Token: 0x040045A6 RID: 17830
		private int _SelectedIndex;

		// Token: 0x040045A7 RID: 17831
		private long _GoodsNextFlushTime;

		// Token: 0x040045A8 RID: 17832
		private bool _IsResetNextFlushTime;

		// Token: 0x040045A9 RID: 17833
		private ProChangedGoodsNtf _Ntf;

		// Token: 0x040045AA RID: 17834
		private IExtension extensionObject;

		// Token: 0x040045AB RID: 17835
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040045AC RID: 17836
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040045AD RID: 17837
		private LuaFunction m_ctor_hotfix;
	}
}
