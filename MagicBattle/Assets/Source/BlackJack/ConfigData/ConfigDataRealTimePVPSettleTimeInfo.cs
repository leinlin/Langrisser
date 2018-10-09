using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x0200027D RID: 637
	[ProtoContract(Name = "ConfigDataRealTimePVPSettleTimeInfo")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ConfigDataRealTimePVPSettleTimeInfo : IExtensible
	{
		// Token: 0x060028E0 RID: 10464 RVA: 0x000AEEC0 File Offset: 0x000AD0C0
		public ConfigDataRealTimePVPSettleTimeInfo()
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

		// Token: 0x17000ABF RID: 2751
		// (get) Token: 0x060028E1 RID: 10465 RVA: 0x000AEF28 File Offset: 0x000AD128
		// (set) Token: 0x060028E2 RID: 10466 RVA: 0x000AEF30 File Offset: 0x000AD130
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

		// Token: 0x17000AC0 RID: 2752
		// (get) Token: 0x060028E3 RID: 10467 RVA: 0x000AEF3C File Offset: 0x000AD13C
		// (set) Token: 0x060028E4 RID: 10468 RVA: 0x000AEF44 File Offset: 0x000AD144
		[ProtoMember(3, IsRequired = true, Name = "Desc", DataFormat = DataFormat.Default)]
		public string Desc
		{
			get
			{
				return this._Desc;
			}
			set
			{
				this._Desc = value;
			}
		}

		// Token: 0x17000AC1 RID: 2753
		// (get) Token: 0x060028E5 RID: 10469 RVA: 0x000AEF50 File Offset: 0x000AD150
		// (set) Token: 0x060028E6 RID: 10470 RVA: 0x000AEF58 File Offset: 0x000AD158
		[ProtoMember(4, IsRequired = true, Name = "SettleStartTime", DataFormat = DataFormat.TwosComplement)]
		public int SettleStartTime
		{
			get
			{
				return this._SettleStartTime;
			}
			set
			{
				this._SettleStartTime = value;
			}
		}

		// Token: 0x17000AC2 RID: 2754
		// (get) Token: 0x060028E7 RID: 10471 RVA: 0x000AEF64 File Offset: 0x000AD164
		// (set) Token: 0x060028E8 RID: 10472 RVA: 0x000AEF6C File Offset: 0x000AD16C
		[ProtoMember(5, IsRequired = true, Name = "SettleEndTime", DataFormat = DataFormat.TwosComplement)]
		public int SettleEndTime
		{
			get
			{
				return this._SettleEndTime;
			}
			set
			{
				this._SettleEndTime = value;
			}
		}

		// Token: 0x060028E9 RID: 10473 RVA: 0x000AEF78 File Offset: 0x000AD178
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060028EA RID: 10474 RVA: 0x000AEF88 File Offset: 0x000AD188
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

		// Token: 0x060028EB RID: 10475 RVA: 0x000AF054 File Offset: 0x000AD254
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataRealTimePVPSettleTimeInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04001922 RID: 6434
		private int _ID;

		// Token: 0x04001923 RID: 6435
		private string _Desc;

		// Token: 0x04001924 RID: 6436
		private int _SettleStartTime;

		// Token: 0x04001925 RID: 6437
		private int _SettleEndTime;

		// Token: 0x04001926 RID: 6438
		private IExtension extensionObject;

		// Token: 0x04001927 RID: 6439
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04001928 RID: 6440
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04001929 RID: 6441
		private LuaFunction m_ctor_hotfix;
	}
}
