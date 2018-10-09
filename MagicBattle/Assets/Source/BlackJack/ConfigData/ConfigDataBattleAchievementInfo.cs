using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000207 RID: 519
	[ProtoContract(Name = "ConfigDataBattleAchievementInfo")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ConfigDataBattleAchievementInfo : IExtensible
	{
		// Token: 0x06001DD4 RID: 7636 RVA: 0x0009BE00 File Offset: 0x0009A000
		public ConfigDataBattleAchievementInfo()
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

		// Token: 0x170005BC RID: 1468
		// (get) Token: 0x06001DD5 RID: 7637 RVA: 0x0009BE7C File Offset: 0x0009A07C
		// (set) Token: 0x06001DD6 RID: 7638 RVA: 0x0009BE84 File Offset: 0x0009A084
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

		// Token: 0x170005BD RID: 1469
		// (get) Token: 0x06001DD7 RID: 7639 RVA: 0x0009BE90 File Offset: 0x0009A090
		// (set) Token: 0x06001DD8 RID: 7640 RVA: 0x0009BE98 File Offset: 0x0009A098
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

		// Token: 0x170005BE RID: 1470
		// (get) Token: 0x06001DD9 RID: 7641 RVA: 0x0009BEA4 File Offset: 0x0009A0A4
		// (set) Token: 0x06001DDA RID: 7642 RVA: 0x0009BEAC File Offset: 0x0009A0AC
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

		// Token: 0x170005BF RID: 1471
		// (get) Token: 0x06001DDB RID: 7643 RVA: 0x0009BEB8 File Offset: 0x0009A0B8
		// (set) Token: 0x06001DDC RID: 7644 RVA: 0x0009BEC0 File Offset: 0x0009A0C0
		[ProtoMember(5, IsRequired = true, Name = "Desc", DataFormat = DataFormat.Default)]
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

		// Token: 0x170005C0 RID: 1472
		// (get) Token: 0x06001DDD RID: 7645 RVA: 0x0009BECC File Offset: 0x0009A0CC
		// (set) Token: 0x06001DDE RID: 7646 RVA: 0x0009BED4 File Offset: 0x0009A0D4
		[ProtoMember(6, IsRequired = true, Name = "DescStrKey", DataFormat = DataFormat.Default)]
		public string DescStrKey
		{
			get
			{
				return this._DescStrKey;
			}
			set
			{
				this._DescStrKey = value;
			}
		}

		// Token: 0x170005C1 RID: 1473
		// (get) Token: 0x06001DDF RID: 7647 RVA: 0x0009BEE0 File Offset: 0x0009A0E0
		// (set) Token: 0x06001DE0 RID: 7648 RVA: 0x0009BEE8 File Offset: 0x0009A0E8
		[ProtoMember(7, IsRequired = true, Name = "ConditionType", DataFormat = DataFormat.TwosComplement)]
		public BattleAchievementConditionType ConditionType
		{
			get
			{
				return this._ConditionType;
			}
			set
			{
				this._ConditionType = value;
			}
		}

		// Token: 0x170005C2 RID: 1474
		// (get) Token: 0x06001DE1 RID: 7649 RVA: 0x0009BEF4 File Offset: 0x0009A0F4
		// (set) Token: 0x06001DE2 RID: 7650 RVA: 0x0009BEFC File Offset: 0x0009A0FC
		[ProtoMember(8, IsRequired = true, Name = "TurnCount", DataFormat = DataFormat.TwosComplement)]
		public int TurnCount
		{
			get
			{
				return this._TurnCount;
			}
			set
			{
				this._TurnCount = value;
			}
		}

		// Token: 0x170005C3 RID: 1475
		// (get) Token: 0x06001DE3 RID: 7651 RVA: 0x0009BF08 File Offset: 0x0009A108
		[ProtoMember(9, Name = "ActorID", DataFormat = DataFormat.TwosComplement)]
		public List<int> ActorID
		{
			get
			{
				return this._ActorID;
			}
		}

		// Token: 0x170005C4 RID: 1476
		// (get) Token: 0x06001DE4 RID: 7652 RVA: 0x0009BF10 File Offset: 0x0009A110
		// (set) Token: 0x06001DE5 RID: 7653 RVA: 0x0009BF18 File Offset: 0x0009A118
		[ProtoMember(10, IsRequired = true, Name = "ConditionParam1", DataFormat = DataFormat.TwosComplement)]
		public int ConditionParam1
		{
			get
			{
				return this._ConditionParam1;
			}
			set
			{
				this._ConditionParam1 = value;
			}
		}

		// Token: 0x170005C5 RID: 1477
		// (get) Token: 0x06001DE6 RID: 7654 RVA: 0x0009BF24 File Offset: 0x0009A124
		[ProtoMember(11, Name = "ConditionParam2", DataFormat = DataFormat.Default)]
		public List<ParamPosition> ConditionParam2
		{
			get
			{
				return this._ConditionParam2;
			}
		}

		// Token: 0x170005C6 RID: 1478
		// (get) Token: 0x06001DE7 RID: 7655 RVA: 0x0009BF2C File Offset: 0x0009A12C
		// (set) Token: 0x06001DE8 RID: 7656 RVA: 0x0009BF34 File Offset: 0x0009A134
		[ProtoMember(12, IsRequired = true, Name = "Icon", DataFormat = DataFormat.Default)]
		public string Icon
		{
			get
			{
				return this._Icon;
			}
			set
			{
				this._Icon = value;
			}
		}

		// Token: 0x06001DE9 RID: 7657 RVA: 0x0009BF40 File Offset: 0x0009A140
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06001DEA RID: 7658 RVA: 0x0009BF50 File Offset: 0x0009A150
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

		// Token: 0x06001DEB RID: 7659 RVA: 0x0009C01C File Offset: 0x0009A21C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataBattleAchievementInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040011D9 RID: 4569
		private int _ID;

		// Token: 0x040011DA RID: 4570
		private string _Name;

		// Token: 0x040011DB RID: 4571
		private string _NameStrKey;

		// Token: 0x040011DC RID: 4572
		private string _Desc;

		// Token: 0x040011DD RID: 4573
		private string _DescStrKey;

		// Token: 0x040011DE RID: 4574
		private BattleAchievementConditionType _ConditionType;

		// Token: 0x040011DF RID: 4575
		private int _TurnCount;

		// Token: 0x040011E0 RID: 4576
		private readonly List<int> _ActorID = new List<int>();

		// Token: 0x040011E1 RID: 4577
		private int _ConditionParam1;

		// Token: 0x040011E2 RID: 4578
		private readonly List<ParamPosition> _ConditionParam2 = new List<ParamPosition>();

		// Token: 0x040011E3 RID: 4579
		private string _Icon;

		// Token: 0x040011E4 RID: 4580
		private IExtension extensionObject;

		// Token: 0x040011E5 RID: 4581
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040011E6 RID: 4582
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040011E7 RID: 4583
		private LuaFunction m_ctor_hotfix;
	}
}
