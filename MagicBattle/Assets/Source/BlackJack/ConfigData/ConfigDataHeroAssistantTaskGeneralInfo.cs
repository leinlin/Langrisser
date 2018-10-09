using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000241 RID: 577
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ConfigDataHeroAssistantTaskGeneralInfo")]
	[Serializable]
	public class ConfigDataHeroAssistantTaskGeneralInfo : IExtensible
	{
		// Token: 0x06002393 RID: 9107 RVA: 0x000A59E8 File Offset: 0x000A3BE8
		public ConfigDataHeroAssistantTaskGeneralInfo()
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

		// Token: 0x1700085D RID: 2141
		// (get) Token: 0x06002394 RID: 9108 RVA: 0x000A5A50 File Offset: 0x000A3C50
		// (set) Token: 0x06002395 RID: 9109 RVA: 0x000A5A58 File Offset: 0x000A3C58
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

		// Token: 0x1700085E RID: 2142
		// (get) Token: 0x06002396 RID: 9110 RVA: 0x000A5A64 File Offset: 0x000A3C64
		// (set) Token: 0x06002397 RID: 9111 RVA: 0x000A5A6C File Offset: 0x000A3C6C
		[ProtoMember(3, IsRequired = true, Name = "WorkSeconds1", DataFormat = DataFormat.TwosComplement)]
		public int WorkSeconds1
		{
			get
			{
				return this._WorkSeconds1;
			}
			set
			{
				this._WorkSeconds1 = value;
			}
		}

		// Token: 0x1700085F RID: 2143
		// (get) Token: 0x06002398 RID: 9112 RVA: 0x000A5A78 File Offset: 0x000A3C78
		// (set) Token: 0x06002399 RID: 9113 RVA: 0x000A5A80 File Offset: 0x000A3C80
		[ProtoMember(4, IsRequired = true, Name = "DropCount1", DataFormat = DataFormat.TwosComplement)]
		public int DropCount1
		{
			get
			{
				return this._DropCount1;
			}
			set
			{
				this._DropCount1 = value;
			}
		}

		// Token: 0x17000860 RID: 2144
		// (get) Token: 0x0600239A RID: 9114 RVA: 0x000A5A8C File Offset: 0x000A3C8C
		// (set) Token: 0x0600239B RID: 9115 RVA: 0x000A5A94 File Offset: 0x000A3C94
		[ProtoMember(5, IsRequired = true, Name = "WorkSeconds2", DataFormat = DataFormat.TwosComplement)]
		public int WorkSeconds2
		{
			get
			{
				return this._WorkSeconds2;
			}
			set
			{
				this._WorkSeconds2 = value;
			}
		}

		// Token: 0x17000861 RID: 2145
		// (get) Token: 0x0600239C RID: 9116 RVA: 0x000A5AA0 File Offset: 0x000A3CA0
		// (set) Token: 0x0600239D RID: 9117 RVA: 0x000A5AA8 File Offset: 0x000A3CA8
		[ProtoMember(6, IsRequired = true, Name = "DropCount2", DataFormat = DataFormat.TwosComplement)]
		public int DropCount2
		{
			get
			{
				return this._DropCount2;
			}
			set
			{
				this._DropCount2 = value;
			}
		}

		// Token: 0x17000862 RID: 2146
		// (get) Token: 0x0600239E RID: 9118 RVA: 0x000A5AB4 File Offset: 0x000A3CB4
		// (set) Token: 0x0600239F RID: 9119 RVA: 0x000A5ABC File Offset: 0x000A3CBC
		[ProtoMember(7, IsRequired = true, Name = "WorkSeconds3", DataFormat = DataFormat.TwosComplement)]
		public int WorkSeconds3
		{
			get
			{
				return this._WorkSeconds3;
			}
			set
			{
				this._WorkSeconds3 = value;
			}
		}

		// Token: 0x17000863 RID: 2147
		// (get) Token: 0x060023A0 RID: 9120 RVA: 0x000A5AC8 File Offset: 0x000A3CC8
		// (set) Token: 0x060023A1 RID: 9121 RVA: 0x000A5AD0 File Offset: 0x000A3CD0
		[ProtoMember(8, IsRequired = true, Name = "DropCount3", DataFormat = DataFormat.TwosComplement)]
		public int DropCount3
		{
			get
			{
				return this._DropCount3;
			}
			set
			{
				this._DropCount3 = value;
			}
		}

		// Token: 0x17000864 RID: 2148
		// (get) Token: 0x060023A2 RID: 9122 RVA: 0x000A5ADC File Offset: 0x000A3CDC
		// (set) Token: 0x060023A3 RID: 9123 RVA: 0x000A5AE4 File Offset: 0x000A3CE4
		[ProtoMember(9, IsRequired = true, Name = "RecommandHeroMultiply", DataFormat = DataFormat.TwosComplement)]
		public int RecommandHeroMultiply
		{
			get
			{
				return this._RecommandHeroMultiply;
			}
			set
			{
				this._RecommandHeroMultiply = value;
			}
		}

		// Token: 0x17000865 RID: 2149
		// (get) Token: 0x060023A4 RID: 9124 RVA: 0x000A5AF0 File Offset: 0x000A3CF0
		// (set) Token: 0x060023A5 RID: 9125 RVA: 0x000A5AF8 File Offset: 0x000A3CF8
		[ProtoMember(10, IsRequired = true, Name = "RecommandHeroAdd", DataFormat = DataFormat.TwosComplement)]
		public int RecommandHeroAdd
		{
			get
			{
				return this._RecommandHeroAdd;
			}
			set
			{
				this._RecommandHeroAdd = value;
			}
		}

		// Token: 0x060023A6 RID: 9126 RVA: 0x000A5B04 File Offset: 0x000A3D04
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060023A7 RID: 9127 RVA: 0x000A5B14 File Offset: 0x000A3D14
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

		// Token: 0x060023A8 RID: 9128 RVA: 0x000A5BE0 File Offset: 0x000A3DE0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataHeroAssistantTaskGeneralInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04001591 RID: 5521
		private int _ID;

		// Token: 0x04001592 RID: 5522
		private int _WorkSeconds1;

		// Token: 0x04001593 RID: 5523
		private int _DropCount1;

		// Token: 0x04001594 RID: 5524
		private int _WorkSeconds2;

		// Token: 0x04001595 RID: 5525
		private int _DropCount2;

		// Token: 0x04001596 RID: 5526
		private int _WorkSeconds3;

		// Token: 0x04001597 RID: 5527
		private int _DropCount3;

		// Token: 0x04001598 RID: 5528
		private int _RecommandHeroMultiply;

		// Token: 0x04001599 RID: 5529
		private int _RecommandHeroAdd;

		// Token: 0x0400159A RID: 5530
		private IExtension extensionObject;

		// Token: 0x0400159B RID: 5531
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400159C RID: 5532
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400159D RID: 5533
		private LuaFunction m_ctor_hotfix;
	}
}
