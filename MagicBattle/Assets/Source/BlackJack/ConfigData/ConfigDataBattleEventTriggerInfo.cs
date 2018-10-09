using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x0200020B RID: 523
	[ProtoContract(Name = "ConfigDataBattleEventTriggerInfo")]
	[HotFix(true, m_isCtorOnly = true)]
	[CustomLuaClass]
	[Serializable]
	public class ConfigDataBattleEventTriggerInfo : IExtensible
	{
		// Token: 0x06001E36 RID: 7734 RVA: 0x0009C920 File Offset: 0x0009AB20
		public ConfigDataBattleEventTriggerInfo()
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

		// Token: 0x170005E8 RID: 1512
		// (get) Token: 0x06001E37 RID: 7735 RVA: 0x0009C9B4 File Offset: 0x0009ABB4
		// (set) Token: 0x06001E38 RID: 7736 RVA: 0x0009C9BC File Offset: 0x0009ABBC
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

		// Token: 0x170005E9 RID: 1513
		// (get) Token: 0x06001E39 RID: 7737 RVA: 0x0009C9C8 File Offset: 0x0009ABC8
		// (set) Token: 0x06001E3A RID: 7738 RVA: 0x0009C9D0 File Offset: 0x0009ABD0
		[ProtoMember(3, IsRequired = true, Name = "Name", DataFormat = DataFormat.Default)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				this._Name = value;
			}
		}

		// Token: 0x170005EA RID: 1514
		// (get) Token: 0x06001E3B RID: 7739 RVA: 0x0009C9DC File Offset: 0x0009ABDC
		// (set) Token: 0x06001E3C RID: 7740 RVA: 0x0009C9E4 File Offset: 0x0009ABE4
		[ProtoMember(4, IsRequired = true, Name = "NameStrKey", DataFormat = DataFormat.Default)]
		public string NameStrKey
		{
			get
			{
				return this._NameStrKey;
			}
			set
			{
				this._NameStrKey = value;
			}
		}

		// Token: 0x170005EB RID: 1515
		// (get) Token: 0x06001E3D RID: 7741 RVA: 0x0009C9F0 File Offset: 0x0009ABF0
		// (set) Token: 0x06001E3E RID: 7742 RVA: 0x0009C9F8 File Offset: 0x0009ABF8
		[ProtoMember(5, IsRequired = true, Name = "TriggerType", DataFormat = DataFormat.TwosComplement)]
		public BattleEventTriggerType TriggerType
		{
			get
			{
				return this._TriggerType;
			}
			set
			{
				this._TriggerType = value;
			}
		}

		// Token: 0x170005EC RID: 1516
		// (get) Token: 0x06001E3F RID: 7743 RVA: 0x0009CA04 File Offset: 0x0009AC04
		[ProtoMember(6, Name = "Param1", DataFormat = DataFormat.TwosComplement)]
		public List<int> Param1
		{
			get
			{
				return this._Param1;
			}
		}

		// Token: 0x170005ED RID: 1517
		// (get) Token: 0x06001E40 RID: 7744 RVA: 0x0009CA0C File Offset: 0x0009AC0C
		[ProtoMember(7, Name = "Param2", DataFormat = DataFormat.TwosComplement)]
		public List<int> Param2
		{
			get
			{
				return this._Param2;
			}
		}

		// Token: 0x170005EE RID: 1518
		// (get) Token: 0x06001E41 RID: 7745 RVA: 0x0009CA14 File Offset: 0x0009AC14
		[ProtoMember(8, Name = "Param3", DataFormat = DataFormat.Default)]
		public List<ParamPosition> Param3
		{
			get
			{
				return this._Param3;
			}
		}

		// Token: 0x170005EF RID: 1519
		// (get) Token: 0x06001E42 RID: 7746 RVA: 0x0009CA1C File Offset: 0x0009AC1C
		[ProtoMember(9, Name = "Actions_ID", DataFormat = DataFormat.TwosComplement)]
		public List<int> Actions_ID
		{
			get
			{
				return this._Actions_ID;
			}
		}

		// Token: 0x170005F0 RID: 1520
		// (get) Token: 0x06001E43 RID: 7747 RVA: 0x0009CA24 File Offset: 0x0009AC24
		// (set) Token: 0x06001E44 RID: 7748 RVA: 0x0009CA2C File Offset: 0x0009AC2C
		[ProtoMember(10, IsRequired = true, Name = "CanRepeat", DataFormat = DataFormat.Default)]
		public bool CanRepeat
		{
			get
			{
				return this._CanRepeat;
			}
			set
			{
				this._CanRepeat = value;
			}
		}

		// Token: 0x06001E45 RID: 7749 RVA: 0x0009CA38 File Offset: 0x0009AC38
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06001E46 RID: 7750 RVA: 0x0009CA48 File Offset: 0x0009AC48
		public int Param1FirstValue()
		{
			if (this.Param1.Count > 0)
			{
				return this.Param1[0];
			}
			return 0;
		}

		// Token: 0x06001E47 RID: 7751 RVA: 0x0009CA6C File Offset: 0x0009AC6C
		public int Param2FirstValue()
		{
			if (this.Param2.Count > 0)
			{
				return this.Param2[0];
			}
			return 0;
		}

		// Token: 0x06001E48 RID: 7752 RVA: 0x0009CA90 File Offset: 0x0009AC90
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

		// Token: 0x06001E49 RID: 7753 RVA: 0x0009CB5C File Offset: 0x0009AD5C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataBattleEventTriggerInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400121B RID: 4635
		private int _ID;

		// Token: 0x0400121C RID: 4636
		private string _Name;

		// Token: 0x0400121D RID: 4637
		private string _NameStrKey;

		// Token: 0x0400121E RID: 4638
		private BattleEventTriggerType _TriggerType;

		// Token: 0x0400121F RID: 4639
		private readonly List<int> _Param1 = new List<int>();

		// Token: 0x04001220 RID: 4640
		private readonly List<int> _Param2 = new List<int>();

		// Token: 0x04001221 RID: 4641
		private readonly List<ParamPosition> _Param3 = new List<ParamPosition>();

		// Token: 0x04001222 RID: 4642
		private readonly List<int> _Actions_ID = new List<int>();

		// Token: 0x04001223 RID: 4643
		private bool _CanRepeat;

		// Token: 0x04001224 RID: 4644
		private IExtension extensionObject;

		// Token: 0x04001225 RID: 4645
		public ConfigDataBattleEventActionInfo[] m_battleEventActionInfos;

		// Token: 0x04001226 RID: 4646
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04001227 RID: 4647
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04001228 RID: 4648
		private LuaFunction m_ctor_hotfix;
	}
}
