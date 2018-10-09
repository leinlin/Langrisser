using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000204 RID: 516
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ConfigDataArmyRelation")]
	[Serializable]
	public class ConfigDataArmyRelation : IExtensible
	{
		// Token: 0x06001DA8 RID: 7592 RVA: 0x0009B7BC File Offset: 0x000999BC
		public ConfigDataArmyRelation()
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

		// Token: 0x170005AC RID: 1452
		// (get) Token: 0x06001DA9 RID: 7593 RVA: 0x0009B824 File Offset: 0x00099A24
		// (set) Token: 0x06001DAA RID: 7594 RVA: 0x0009B82C File Offset: 0x00099A2C
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

		// Token: 0x170005AD RID: 1453
		// (get) Token: 0x06001DAB RID: 7595 RVA: 0x0009B838 File Offset: 0x00099A38
		// (set) Token: 0x06001DAC RID: 7596 RVA: 0x0009B840 File Offset: 0x00099A40
		[ProtoMember(3, IsRequired = true, Name = "ArmyTagA", DataFormat = DataFormat.TwosComplement)]
		public ArmyTag ArmyTagA
		{
			get
			{
				return this._ArmyTagA;
			}
			set
			{
				this._ArmyTagA = value;
			}
		}

		// Token: 0x170005AE RID: 1454
		// (get) Token: 0x06001DAD RID: 7597 RVA: 0x0009B84C File Offset: 0x00099A4C
		// (set) Token: 0x06001DAE RID: 7598 RVA: 0x0009B854 File Offset: 0x00099A54
		[ProtoMember(4, IsRequired = true, Name = "ArmyTagB", DataFormat = DataFormat.TwosComplement)]
		public ArmyTag ArmyTagB
		{
			get
			{
				return this._ArmyTagB;
			}
			set
			{
				this._ArmyTagB = value;
			}
		}

		// Token: 0x170005AF RID: 1455
		// (get) Token: 0x06001DAF RID: 7599 RVA: 0x0009B860 File Offset: 0x00099A60
		// (set) Token: 0x06001DB0 RID: 7600 RVA: 0x0009B868 File Offset: 0x00099A68
		[ProtoMember(5, IsRequired = true, Name = "Attack", DataFormat = DataFormat.TwosComplement)]
		public int Attack
		{
			get
			{
				return this._Attack;
			}
			set
			{
				this._Attack = value;
			}
		}

		// Token: 0x170005B0 RID: 1456
		// (get) Token: 0x06001DB1 RID: 7601 RVA: 0x0009B874 File Offset: 0x00099A74
		// (set) Token: 0x06001DB2 RID: 7602 RVA: 0x0009B87C File Offset: 0x00099A7C
		[ProtoMember(6, IsRequired = true, Name = "Defend", DataFormat = DataFormat.TwosComplement)]
		public int Defend
		{
			get
			{
				return this._Defend;
			}
			set
			{
				this._Defend = value;
			}
		}

		// Token: 0x170005B1 RID: 1457
		// (get) Token: 0x06001DB3 RID: 7603 RVA: 0x0009B888 File Offset: 0x00099A88
		// (set) Token: 0x06001DB4 RID: 7604 RVA: 0x0009B890 File Offset: 0x00099A90
		[ProtoMember(7, IsRequired = true, Name = "Magic", DataFormat = DataFormat.TwosComplement)]
		public int Magic
		{
			get
			{
				return this._Magic;
			}
			set
			{
				this._Magic = value;
			}
		}

		// Token: 0x170005B2 RID: 1458
		// (get) Token: 0x06001DB5 RID: 7605 RVA: 0x0009B89C File Offset: 0x00099A9C
		// (set) Token: 0x06001DB6 RID: 7606 RVA: 0x0009B8A4 File Offset: 0x00099AA4
		[ProtoMember(8, IsRequired = true, Name = "MagicDefend", DataFormat = DataFormat.TwosComplement)]
		public int MagicDefend
		{
			get
			{
				return this._MagicDefend;
			}
			set
			{
				this._MagicDefend = value;
			}
		}

		// Token: 0x06001DB7 RID: 7607 RVA: 0x0009B8B0 File Offset: 0x00099AB0
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06001DB8 RID: 7608 RVA: 0x0009B8C0 File Offset: 0x00099AC0
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

		// Token: 0x06001DB9 RID: 7609 RVA: 0x0009B98C File Offset: 0x00099B8C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataArmyRelation));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040011BD RID: 4541
		private int _ID;

		// Token: 0x040011BE RID: 4542
		private ArmyTag _ArmyTagA;

		// Token: 0x040011BF RID: 4543
		private ArmyTag _ArmyTagB;

		// Token: 0x040011C0 RID: 4544
		private int _Attack;

		// Token: 0x040011C1 RID: 4545
		private int _Defend;

		// Token: 0x040011C2 RID: 4546
		private int _Magic;

		// Token: 0x040011C3 RID: 4547
		private int _MagicDefend;

		// Token: 0x040011C4 RID: 4548
		private IExtension extensionObject;

		// Token: 0x040011C5 RID: 4549
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040011C6 RID: 4550
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040011C7 RID: 4551
		private LuaFunction m_ctor_hotfix;
	}
}
