using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000263 RID: 611
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ConfigDataMonthCardInfo")]
	[Serializable]
	public class ConfigDataMonthCardInfo : IExtensible
	{
		// Token: 0x06002732 RID: 10034 RVA: 0x000AB56C File Offset: 0x000A976C
		public ConfigDataMonthCardInfo()
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

		// Token: 0x17000A0C RID: 2572
		// (get) Token: 0x06002733 RID: 10035 RVA: 0x000AB5E8 File Offset: 0x000A97E8
		// (set) Token: 0x06002734 RID: 10036 RVA: 0x000AB5F0 File Offset: 0x000A97F0
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

		// Token: 0x17000A0D RID: 2573
		// (get) Token: 0x06002735 RID: 10037 RVA: 0x000AB5FC File Offset: 0x000A97FC
		// (set) Token: 0x06002736 RID: 10038 RVA: 0x000AB604 File Offset: 0x000A9804
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

		// Token: 0x17000A0E RID: 2574
		// (get) Token: 0x06002737 RID: 10039 RVA: 0x000AB610 File Offset: 0x000A9810
		// (set) Token: 0x06002738 RID: 10040 RVA: 0x000AB618 File Offset: 0x000A9818
		[ProtoMember(4, IsRequired = true, Name = "ValidDays", DataFormat = DataFormat.TwosComplement)]
		public int ValidDays
		{
			get
			{
				return this._ValidDays;
			}
			set
			{
				this._ValidDays = value;
			}
		}

		// Token: 0x17000A0F RID: 2575
		// (get) Token: 0x06002739 RID: 10041 RVA: 0x000AB624 File Offset: 0x000A9824
		// (set) Token: 0x0600273A RID: 10042 RVA: 0x000AB62C File Offset: 0x000A982C
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

		// Token: 0x17000A10 RID: 2576
		// (get) Token: 0x0600273B RID: 10043 RVA: 0x000AB638 File Offset: 0x000A9838
		[ProtoMember(6, Name = "Reward", DataFormat = DataFormat.Default)]
		public List<Goods> Reward
		{
			get
			{
				return this._Reward;
			}
		}

		// Token: 0x17000A11 RID: 2577
		// (get) Token: 0x0600273C RID: 10044 RVA: 0x000AB640 File Offset: 0x000A9840
		// (set) Token: 0x0600273D RID: 10045 RVA: 0x000AB648 File Offset: 0x000A9848
		[ProtoMember(7, IsRequired = true, Name = "OpenEverydayTaskId", DataFormat = DataFormat.TwosComplement)]
		public int OpenEverydayTaskId
		{
			get
			{
				return this._OpenEverydayTaskId;
			}
			set
			{
				this._OpenEverydayTaskId = value;
			}
		}

		// Token: 0x17000A12 RID: 2578
		// (get) Token: 0x0600273E RID: 10046 RVA: 0x000AB654 File Offset: 0x000A9854
		// (set) Token: 0x0600273F RID: 10047 RVA: 0x000AB65C File Offset: 0x000A985C
		[ProtoMember(8, IsRequired = true, Name = "HeroExpAddRate", DataFormat = DataFormat.TwosComplement)]
		public int HeroExpAddRate
		{
			get
			{
				return this._HeroExpAddRate;
			}
			set
			{
				this._HeroExpAddRate = value;
			}
		}

		// Token: 0x17000A13 RID: 2579
		// (get) Token: 0x06002740 RID: 10048 RVA: 0x000AB668 File Offset: 0x000A9868
		// (set) Token: 0x06002741 RID: 10049 RVA: 0x000AB670 File Offset: 0x000A9870
		[ProtoMember(9, IsRequired = true, Name = "HeroFavourabilityExpAddRate", DataFormat = DataFormat.TwosComplement)]
		public int HeroFavourabilityExpAddRate
		{
			get
			{
				return this._HeroFavourabilityExpAddRate;
			}
			set
			{
				this._HeroFavourabilityExpAddRate = value;
			}
		}

		// Token: 0x17000A14 RID: 2580
		// (get) Token: 0x06002742 RID: 10050 RVA: 0x000AB67C File Offset: 0x000A987C
		[ProtoMember(10, Name = "DayBonusAdd", DataFormat = DataFormat.Default)]
		public List<GameFuncDayBonus> DayBonusAdd
		{
			get
			{
				return this._DayBonusAdd;
			}
		}

		// Token: 0x17000A15 RID: 2581
		// (get) Token: 0x06002743 RID: 10051 RVA: 0x000AB684 File Offset: 0x000A9884
		// (set) Token: 0x06002744 RID: 10052 RVA: 0x000AB68C File Offset: 0x000A988C
		[ProtoMember(11, IsRequired = true, Name = "OpenGameFunc", DataFormat = DataFormat.TwosComplement)]
		public GameFunctionType OpenGameFunc
		{
			get
			{
				return this._OpenGameFunc;
			}
			set
			{
				this._OpenGameFunc = value;
			}
		}

		// Token: 0x17000A16 RID: 2582
		// (get) Token: 0x06002745 RID: 10053 RVA: 0x000AB698 File Offset: 0x000A9898
		// (set) Token: 0x06002746 RID: 10054 RVA: 0x000AB6A0 File Offset: 0x000A98A0
		[ProtoMember(12, IsRequired = true, Name = "IsAppleSubscribe", DataFormat = DataFormat.Default)]
		public bool IsAppleSubscribe
		{
			get
			{
				return this._IsAppleSubscribe;
			}
			set
			{
				this._IsAppleSubscribe = value;
			}
		}

		// Token: 0x17000A17 RID: 2583
		// (get) Token: 0x06002747 RID: 10055 RVA: 0x000AB6AC File Offset: 0x000A98AC
		// (set) Token: 0x06002748 RID: 10056 RVA: 0x000AB6B4 File Offset: 0x000A98B4
		[ProtoMember(13, IsRequired = true, Name = "FightFailEnergyDecreaseRate", DataFormat = DataFormat.TwosComplement)]
		public int FightFailEnergyDecreaseRate
		{
			get
			{
				return this._FightFailEnergyDecreaseRate;
			}
			set
			{
				this._FightFailEnergyDecreaseRate = value;
			}
		}

		// Token: 0x17000A18 RID: 2584
		// (get) Token: 0x06002749 RID: 10057 RVA: 0x000AB6C0 File Offset: 0x000A98C0
		// (set) Token: 0x0600274A RID: 10058 RVA: 0x000AB6C8 File Offset: 0x000A98C8
		[ProtoMember(14, IsRequired = true, Name = "Icon", DataFormat = DataFormat.Default)]
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

		// Token: 0x0600274B RID: 10059 RVA: 0x000AB6D4 File Offset: 0x000A98D4
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600274C RID: 10060 RVA: 0x000AB6E4 File Offset: 0x000A98E4
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

		// Token: 0x0600274D RID: 10061 RVA: 0x000AB7B0 File Offset: 0x000A99B0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataMonthCardInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040017FF RID: 6143
		private int _ID;

		// Token: 0x04001800 RID: 6144
		private string _Name;

		// Token: 0x04001801 RID: 6145
		private int _ValidDays;

		// Token: 0x04001802 RID: 6146
		private string _Desc;

		// Token: 0x04001803 RID: 6147
		private readonly List<Goods> _Reward = new List<Goods>();

		// Token: 0x04001804 RID: 6148
		private int _OpenEverydayTaskId;

		// Token: 0x04001805 RID: 6149
		private int _HeroExpAddRate;

		// Token: 0x04001806 RID: 6150
		private int _HeroFavourabilityExpAddRate;

		// Token: 0x04001807 RID: 6151
		private readonly List<GameFuncDayBonus> _DayBonusAdd = new List<GameFuncDayBonus>();

		// Token: 0x04001808 RID: 6152
		private GameFunctionType _OpenGameFunc;

		// Token: 0x04001809 RID: 6153
		private bool _IsAppleSubscribe;

		// Token: 0x0400180A RID: 6154
		private int _FightFailEnergyDecreaseRate;

		// Token: 0x0400180B RID: 6155
		private string _Icon;

		// Token: 0x0400180C RID: 6156
		private IExtension extensionObject;

		// Token: 0x0400180D RID: 6157
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400180E RID: 6158
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400180F RID: 6159
		private LuaFunction m_ctor_hotfix;
	}
}
