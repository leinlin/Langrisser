using System;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x0200032D RID: 813
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "GDBSpaceStationInfo")]
	[Serializable]
	public class GDBSpaceStationInfo : IExtensible
	{
		// Token: 0x06003052 RID: 12370 RVA: 0x000BE668 File Offset: 0x000BC868
		public GDBSpaceStationInfo()
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

		// Token: 0x17000DBB RID: 3515
		// (get) Token: 0x06003053 RID: 12371 RVA: 0x000BE6E4 File Offset: 0x000BC8E4
		// (set) Token: 0x06003054 RID: 12372 RVA: 0x000BE6EC File Offset: 0x000BC8EC
		[ProtoMember(1, IsRequired = true, Name = "Id", DataFormat = DataFormat.TwosComplement)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				this._Id = value;
			}
		}

		// Token: 0x17000DBC RID: 3516
		// (get) Token: 0x06003055 RID: 12373 RVA: 0x000BE6F8 File Offset: 0x000BC8F8
		// (set) Token: 0x06003056 RID: 12374 RVA: 0x000BE700 File Offset: 0x000BC900
		[ProtoMember(2, IsRequired = true, Name = "ConfTempleteId", DataFormat = DataFormat.TwosComplement)]
		public int ConfTempleteId
		{
			get
			{
				return this._ConfTempleteId;
			}
			set
			{
				this._ConfTempleteId = value;
			}
		}

		// Token: 0x17000DBD RID: 3517
		// (get) Token: 0x06003057 RID: 12375 RVA: 0x000BE70C File Offset: 0x000BC90C
		// (set) Token: 0x06003058 RID: 12376 RVA: 0x000BE714 File Offset: 0x000BC914
		[ProtoMember(3, IsRequired = false, Name = "name", DataFormat = DataFormat.Default)]
		[DefaultValue("")]
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				this._name = value;
			}
		}

		// Token: 0x17000DBE RID: 3518
		// (get) Token: 0x06003059 RID: 12377 RVA: 0x000BE720 File Offset: 0x000BC920
		// (set) Token: 0x0600305A RID: 12378 RVA: 0x000BE728 File Offset: 0x000BC928
		[ProtoMember(4, IsRequired = true, Name = "locationX", DataFormat = DataFormat.TwosComplement)]
		public double LocationX
		{
			get
			{
				return this._locationX;
			}
			set
			{
				this._locationX = value;
			}
		}

		// Token: 0x17000DBF RID: 3519
		// (get) Token: 0x0600305B RID: 12379 RVA: 0x000BE734 File Offset: 0x000BC934
		// (set) Token: 0x0600305C RID: 12380 RVA: 0x000BE73C File Offset: 0x000BC93C
		[ProtoMember(5, IsRequired = true, Name = "locationZ", DataFormat = DataFormat.TwosComplement)]
		public double LocationZ
		{
			get
			{
				return this._locationZ;
			}
			set
			{
				this._locationZ = value;
			}
		}

		// Token: 0x17000DC0 RID: 3520
		// (get) Token: 0x0600305D RID: 12381 RVA: 0x000BE748 File Offset: 0x000BC948
		// (set) Token: 0x0600305E RID: 12382 RVA: 0x000BE750 File Offset: 0x000BC950
		[ProtoMember(6, IsRequired = true, Name = "rotationY", DataFormat = DataFormat.TwosComplement)]
		public uint RotationY
		{
			get
			{
				return this._rotationY;
			}
			set
			{
				this._rotationY = value;
			}
		}

		// Token: 0x17000DC1 RID: 3521
		// (get) Token: 0x0600305F RID: 12383 RVA: 0x000BE75C File Offset: 0x000BC95C
		// (set) Token: 0x06003060 RID: 12384 RVA: 0x000BE764 File Offset: 0x000BC964
		[ProtoMember(7, IsRequired = false, Name = "isDefault", DataFormat = DataFormat.Default)]
		[DefaultValue(false)]
		public bool IsDefault
		{
			get
			{
				return this._isDefault;
			}
			set
			{
				this._isDefault = value;
			}
		}

		// Token: 0x17000DC2 RID: 3522
		// (get) Token: 0x06003061 RID: 12385 RVA: 0x000BE770 File Offset: 0x000BC970
		// (set) Token: 0x06003062 RID: 12386 RVA: 0x000BE778 File Offset: 0x000BC978
		[ProtoMember(8, IsRequired = true, Name = "isNeedLocalization", DataFormat = DataFormat.Default)]
		public bool IsNeedLocalization
		{
			get
			{
				return this._isNeedLocalization;
			}
			set
			{
				this._isNeedLocalization = value;
			}
		}

		// Token: 0x17000DC3 RID: 3523
		// (get) Token: 0x06003063 RID: 12387 RVA: 0x000BE784 File Offset: 0x000BC984
		// (set) Token: 0x06003064 RID: 12388 RVA: 0x000BE78C File Offset: 0x000BC98C
		[DefaultValue("")]
		[ProtoMember(9, IsRequired = false, Name = "localizationKey", DataFormat = DataFormat.Default)]
		public string LocalizationKey
		{
			get
			{
				return this._localizationKey;
			}
			set
			{
				this._localizationKey = value;
			}
		}

		// Token: 0x06003065 RID: 12389 RVA: 0x000BE798 File Offset: 0x000BC998
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06003066 RID: 12390 RVA: 0x000BE7A8 File Offset: 0x000BC9A8
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

		// Token: 0x06003067 RID: 12391 RVA: 0x000BE874 File Offset: 0x000BCA74
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GDBSpaceStationInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040024E1 RID: 9441
		private int _Id;

		// Token: 0x040024E2 RID: 9442
		private int _ConfTempleteId;

		// Token: 0x040024E3 RID: 9443
		private string _name = string.Empty;

		// Token: 0x040024E4 RID: 9444
		private double _locationX;

		// Token: 0x040024E5 RID: 9445
		private double _locationZ;

		// Token: 0x040024E6 RID: 9446
		private uint _rotationY;

		// Token: 0x040024E7 RID: 9447
		private bool _isDefault;

		// Token: 0x040024E8 RID: 9448
		private bool _isNeedLocalization;

		// Token: 0x040024E9 RID: 9449
		private string _localizationKey = string.Empty;

		// Token: 0x040024EA RID: 9450
		private IExtension extensionObject;

		// Token: 0x040024EB RID: 9451
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040024EC RID: 9452
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040024ED RID: 9453
		private LuaFunction m_ctor_hotfix;
	}
}
