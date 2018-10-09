using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x0200030D RID: 781
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "RaffleItem")]
	[Serializable]
	public class RaffleItem : IExtensible
	{
		// Token: 0x06002EA3 RID: 11939 RVA: 0x000BA444 File Offset: 0x000B8644
		public RaffleItem()
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

		// Token: 0x17000D1E RID: 3358
		// (get) Token: 0x06002EA4 RID: 11940 RVA: 0x000BA4AC File Offset: 0x000B86AC
		// (set) Token: 0x06002EA5 RID: 11941 RVA: 0x000BA4B4 File Offset: 0x000B86B4
		[ProtoMember(1, IsRequired = true, Name = "RaffleID", DataFormat = DataFormat.TwosComplement)]
		public int RaffleID
		{
			get
			{
				return this._RaffleID;
			}
			set
			{
				this._RaffleID = value;
			}
		}

		// Token: 0x17000D1F RID: 3359
		// (get) Token: 0x06002EA6 RID: 11942 RVA: 0x000BA4C0 File Offset: 0x000B86C0
		// (set) Token: 0x06002EA7 RID: 11943 RVA: 0x000BA4C8 File Offset: 0x000B86C8
		[ProtoMember(2, IsRequired = true, Name = "RaffleLevel", DataFormat = DataFormat.TwosComplement)]
		public int RaffleLevel
		{
			get
			{
				return this._RaffleLevel;
			}
			set
			{
				this._RaffleLevel = value;
			}
		}

		// Token: 0x17000D20 RID: 3360
		// (get) Token: 0x06002EA8 RID: 11944 RVA: 0x000BA4D4 File Offset: 0x000B86D4
		// (set) Token: 0x06002EA9 RID: 11945 RVA: 0x000BA4DC File Offset: 0x000B86DC
		[ProtoMember(3, IsRequired = true, Name = "GoodsType", DataFormat = DataFormat.TwosComplement)]
		public GoodsType GoodsType
		{
			get
			{
				return this._GoodsType;
			}
			set
			{
				this._GoodsType = value;
			}
		}

		// Token: 0x17000D21 RID: 3361
		// (get) Token: 0x06002EAA RID: 11946 RVA: 0x000BA4E8 File Offset: 0x000B86E8
		// (set) Token: 0x06002EAB RID: 11947 RVA: 0x000BA4F0 File Offset: 0x000B86F0
		[ProtoMember(4, IsRequired = true, Name = "ItemID", DataFormat = DataFormat.TwosComplement)]
		public int ItemID
		{
			get
			{
				return this._ItemID;
			}
			set
			{
				this._ItemID = value;
			}
		}

		// Token: 0x17000D22 RID: 3362
		// (get) Token: 0x06002EAC RID: 11948 RVA: 0x000BA4FC File Offset: 0x000B86FC
		// (set) Token: 0x06002EAD RID: 11949 RVA: 0x000BA504 File Offset: 0x000B8704
		[ProtoMember(5, IsRequired = true, Name = "ItemCount", DataFormat = DataFormat.TwosComplement)]
		public int ItemCount
		{
			get
			{
				return this._ItemCount;
			}
			set
			{
				this._ItemCount = value;
			}
		}

		// Token: 0x17000D23 RID: 3363
		// (get) Token: 0x06002EAE RID: 11950 RVA: 0x000BA510 File Offset: 0x000B8710
		// (set) Token: 0x06002EAF RID: 11951 RVA: 0x000BA518 File Offset: 0x000B8718
		[ProtoMember(6, IsRequired = true, Name = "Weight", DataFormat = DataFormat.TwosComplement)]
		public int Weight
		{
			get
			{
				return this._Weight;
			}
			set
			{
				this._Weight = value;
			}
		}

		// Token: 0x17000D24 RID: 3364
		// (get) Token: 0x06002EB0 RID: 11952 RVA: 0x000BA524 File Offset: 0x000B8724
		// (set) Token: 0x06002EB1 RID: 11953 RVA: 0x000BA52C File Offset: 0x000B872C
		[ProtoMember(7, IsRequired = true, Name = "UpperBound", DataFormat = DataFormat.TwosComplement)]
		public int UpperBound
		{
			get
			{
				return this._UpperBound;
			}
			set
			{
				this._UpperBound = value;
			}
		}

		// Token: 0x17000D25 RID: 3365
		// (get) Token: 0x06002EB2 RID: 11954 RVA: 0x000BA538 File Offset: 0x000B8738
		// (set) Token: 0x06002EB3 RID: 11955 RVA: 0x000BA540 File Offset: 0x000B8740
		[ProtoMember(8, IsRequired = true, Name = "LowerBound", DataFormat = DataFormat.TwosComplement)]
		public int LowerBound
		{
			get
			{
				return this._LowerBound;
			}
			set
			{
				this._LowerBound = value;
			}
		}

		// Token: 0x06002EB4 RID: 11956 RVA: 0x000BA54C File Offset: 0x000B874C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002EB5 RID: 11957 RVA: 0x000BA55C File Offset: 0x000B875C
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

		// Token: 0x06002EB6 RID: 11958 RVA: 0x000BA628 File Offset: 0x000B8828
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(RaffleItem));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040023C4 RID: 9156
		private int _RaffleID;

		// Token: 0x040023C5 RID: 9157
		private int _RaffleLevel;

		// Token: 0x040023C6 RID: 9158
		private GoodsType _GoodsType;

		// Token: 0x040023C7 RID: 9159
		private int _ItemID;

		// Token: 0x040023C8 RID: 9160
		private int _ItemCount;

		// Token: 0x040023C9 RID: 9161
		private int _Weight;

		// Token: 0x040023CA RID: 9162
		private int _UpperBound;

		// Token: 0x040023CB RID: 9163
		private int _LowerBound;

		// Token: 0x040023CC RID: 9164
		private IExtension extensionObject;

		// Token: 0x040023CD RID: 9165
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040023CE RID: 9166
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040023CF RID: 9167
		private LuaFunction m_ctor_hotfix;
	}
}
