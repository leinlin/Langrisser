using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x0200025A RID: 602
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ConfigDataJobLevelInfo")]
	[CustomLuaClass]
	[Serializable]
	public class ConfigDataJobLevelInfo : IExtensible
	{
		// Token: 0x0600262D RID: 9773 RVA: 0x000A9D48 File Offset: 0x000A7F48
		public ConfigDataJobLevelInfo()
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

		// Token: 0x17000997 RID: 2455
		// (get) Token: 0x0600262E RID: 9774 RVA: 0x000A9DBC File Offset: 0x000A7FBC
		// (set) Token: 0x0600262F RID: 9775 RVA: 0x000A9DC4 File Offset: 0x000A7FC4
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

		// Token: 0x17000998 RID: 2456
		// (get) Token: 0x06002630 RID: 9776 RVA: 0x000A9DD0 File Offset: 0x000A7FD0
		// (set) Token: 0x06002631 RID: 9777 RVA: 0x000A9DD8 File Offset: 0x000A7FD8
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

		// Token: 0x17000999 RID: 2457
		// (get) Token: 0x06002632 RID: 9778 RVA: 0x000A9DE4 File Offset: 0x000A7FE4
		// (set) Token: 0x06002633 RID: 9779 RVA: 0x000A9DEC File Offset: 0x000A7FEC
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

		// Token: 0x1700099A RID: 2458
		// (get) Token: 0x06002634 RID: 9780 RVA: 0x000A9DF8 File Offset: 0x000A7FF8
		[ProtoMember(7, Name = "Materials", DataFormat = DataFormat.Default)]
		public List<Goods> Materials
		{
			get
			{
				return this._Materials;
			}
		}

		// Token: 0x1700099B RID: 2459
		// (get) Token: 0x06002635 RID: 9781 RVA: 0x000A9E00 File Offset: 0x000A8000
		// (set) Token: 0x06002636 RID: 9782 RVA: 0x000A9E08 File Offset: 0x000A8008
		[ProtoMember(8, IsRequired = true, Name = "JobLevelUpHeroLevel", DataFormat = DataFormat.TwosComplement)]
		public int JobLevelUpHeroLevel
		{
			get
			{
				return this._JobLevelUpHeroLevel;
			}
			set
			{
				this._JobLevelUpHeroLevel = value;
			}
		}

		// Token: 0x1700099C RID: 2460
		// (get) Token: 0x06002637 RID: 9783 RVA: 0x000A9E14 File Offset: 0x000A8014
		// (set) Token: 0x06002638 RID: 9784 RVA: 0x000A9E1C File Offset: 0x000A801C
		[ProtoMember(16, IsRequired = true, Name = "HP_INI", DataFormat = DataFormat.TwosComplement)]
		public int HP_INI
		{
			get
			{
				return this._HP_INI;
			}
			set
			{
				this._HP_INI = value;
			}
		}

		// Token: 0x1700099D RID: 2461
		// (get) Token: 0x06002639 RID: 9785 RVA: 0x000A9E28 File Offset: 0x000A8028
		// (set) Token: 0x0600263A RID: 9786 RVA: 0x000A9E30 File Offset: 0x000A8030
		[ProtoMember(17, IsRequired = true, Name = "HP_UP", DataFormat = DataFormat.TwosComplement)]
		public int HP_UP
		{
			get
			{
				return this._HP_UP;
			}
			set
			{
				this._HP_UP = value;
			}
		}

		// Token: 0x1700099E RID: 2462
		// (get) Token: 0x0600263B RID: 9787 RVA: 0x000A9E3C File Offset: 0x000A803C
		// (set) Token: 0x0600263C RID: 9788 RVA: 0x000A9E44 File Offset: 0x000A8044
		[ProtoMember(18, IsRequired = true, Name = "AT_INI", DataFormat = DataFormat.TwosComplement)]
		public int AT_INI
		{
			get
			{
				return this._AT_INI;
			}
			set
			{
				this._AT_INI = value;
			}
		}

		// Token: 0x1700099F RID: 2463
		// (get) Token: 0x0600263D RID: 9789 RVA: 0x000A9E50 File Offset: 0x000A8050
		// (set) Token: 0x0600263E RID: 9790 RVA: 0x000A9E58 File Offset: 0x000A8058
		[ProtoMember(19, IsRequired = true, Name = "AT_UP", DataFormat = DataFormat.TwosComplement)]
		public int AT_UP
		{
			get
			{
				return this._AT_UP;
			}
			set
			{
				this._AT_UP = value;
			}
		}

		// Token: 0x170009A0 RID: 2464
		// (get) Token: 0x0600263F RID: 9791 RVA: 0x000A9E64 File Offset: 0x000A8064
		// (set) Token: 0x06002640 RID: 9792 RVA: 0x000A9E6C File Offset: 0x000A806C
		[ProtoMember(20, IsRequired = true, Name = "Magic_INI", DataFormat = DataFormat.TwosComplement)]
		public int Magic_INI
		{
			get
			{
				return this._Magic_INI;
			}
			set
			{
				this._Magic_INI = value;
			}
		}

		// Token: 0x170009A1 RID: 2465
		// (get) Token: 0x06002641 RID: 9793 RVA: 0x000A9E78 File Offset: 0x000A8078
		// (set) Token: 0x06002642 RID: 9794 RVA: 0x000A9E80 File Offset: 0x000A8080
		[ProtoMember(21, IsRequired = true, Name = "Magic_UP", DataFormat = DataFormat.TwosComplement)]
		public int Magic_UP
		{
			get
			{
				return this._Magic_UP;
			}
			set
			{
				this._Magic_UP = value;
			}
		}

		// Token: 0x170009A2 RID: 2466
		// (get) Token: 0x06002643 RID: 9795 RVA: 0x000A9E8C File Offset: 0x000A808C
		// (set) Token: 0x06002644 RID: 9796 RVA: 0x000A9E94 File Offset: 0x000A8094
		[ProtoMember(22, IsRequired = true, Name = "DF_INI", DataFormat = DataFormat.TwosComplement)]
		public int DF_INI
		{
			get
			{
				return this._DF_INI;
			}
			set
			{
				this._DF_INI = value;
			}
		}

		// Token: 0x170009A3 RID: 2467
		// (get) Token: 0x06002645 RID: 9797 RVA: 0x000A9EA0 File Offset: 0x000A80A0
		// (set) Token: 0x06002646 RID: 9798 RVA: 0x000A9EA8 File Offset: 0x000A80A8
		[ProtoMember(23, IsRequired = true, Name = "DF_UP", DataFormat = DataFormat.TwosComplement)]
		public int DF_UP
		{
			get
			{
				return this._DF_UP;
			}
			set
			{
				this._DF_UP = value;
			}
		}

		// Token: 0x170009A4 RID: 2468
		// (get) Token: 0x06002647 RID: 9799 RVA: 0x000A9EB4 File Offset: 0x000A80B4
		// (set) Token: 0x06002648 RID: 9800 RVA: 0x000A9EBC File Offset: 0x000A80BC
		[ProtoMember(24, IsRequired = true, Name = "MagicDF_INI", DataFormat = DataFormat.TwosComplement)]
		public int MagicDF_INI
		{
			get
			{
				return this._MagicDF_INI;
			}
			set
			{
				this._MagicDF_INI = value;
			}
		}

		// Token: 0x170009A5 RID: 2469
		// (get) Token: 0x06002649 RID: 9801 RVA: 0x000A9EC8 File Offset: 0x000A80C8
		// (set) Token: 0x0600264A RID: 9802 RVA: 0x000A9ED0 File Offset: 0x000A80D0
		[ProtoMember(25, IsRequired = true, Name = "MagicDF_UP", DataFormat = DataFormat.TwosComplement)]
		public int MagicDF_UP
		{
			get
			{
				return this._MagicDF_UP;
			}
			set
			{
				this._MagicDF_UP = value;
			}
		}

		// Token: 0x170009A6 RID: 2470
		// (get) Token: 0x0600264B RID: 9803 RVA: 0x000A9EDC File Offset: 0x000A80DC
		// (set) Token: 0x0600264C RID: 9804 RVA: 0x000A9EE4 File Offset: 0x000A80E4
		[ProtoMember(26, IsRequired = true, Name = "DEX_INI", DataFormat = DataFormat.TwosComplement)]
		public int DEX_INI
		{
			get
			{
				return this._DEX_INI;
			}
			set
			{
				this._DEX_INI = value;
			}
		}

		// Token: 0x170009A7 RID: 2471
		// (get) Token: 0x0600264D RID: 9805 RVA: 0x000A9EF0 File Offset: 0x000A80F0
		// (set) Token: 0x0600264E RID: 9806 RVA: 0x000A9EF8 File Offset: 0x000A80F8
		[ProtoMember(27, IsRequired = true, Name = "DEX_UP", DataFormat = DataFormat.TwosComplement)]
		public int DEX_UP
		{
			get
			{
				return this._DEX_UP;
			}
			set
			{
				this._DEX_UP = value;
			}
		}

		// Token: 0x170009A8 RID: 2472
		// (get) Token: 0x0600264F RID: 9807 RVA: 0x000A9F04 File Offset: 0x000A8104
		// (set) Token: 0x06002650 RID: 9808 RVA: 0x000A9F0C File Offset: 0x000A810C
		[ProtoMember(28, IsRequired = true, Name = "GotSkill_ID", DataFormat = DataFormat.TwosComplement)]
		public int GotSkill_ID
		{
			get
			{
				return this._GotSkill_ID;
			}
			set
			{
				this._GotSkill_ID = value;
			}
		}

		// Token: 0x170009A9 RID: 2473
		// (get) Token: 0x06002651 RID: 9809 RVA: 0x000A9F18 File Offset: 0x000A8118
		// (set) Token: 0x06002652 RID: 9810 RVA: 0x000A9F20 File Offset: 0x000A8120
		[ProtoMember(29, IsRequired = true, Name = "GotSoldier_ID", DataFormat = DataFormat.TwosComplement)]
		public int GotSoldier_ID
		{
			get
			{
				return this._GotSoldier_ID;
			}
			set
			{
				this._GotSoldier_ID = value;
			}
		}

		// Token: 0x06002653 RID: 9811 RVA: 0x000A9F2C File Offset: 0x000A812C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002654 RID: 9812 RVA: 0x000A9F3C File Offset: 0x000A813C
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

		// Token: 0x06002655 RID: 9813 RVA: 0x000AA008 File Offset: 0x000A8208
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataJobLevelInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400175A RID: 5978
		private int _ID;

		// Token: 0x0400175B RID: 5979
		private string _Desc;

		// Token: 0x0400175C RID: 5980
		private string _DescStrKey;

		// Token: 0x0400175D RID: 5981
		private readonly List<Goods> _Materials = new List<Goods>();

		// Token: 0x0400175E RID: 5982
		private int _JobLevelUpHeroLevel;

		// Token: 0x0400175F RID: 5983
		private int _HP_INI;

		// Token: 0x04001760 RID: 5984
		private int _HP_UP;

		// Token: 0x04001761 RID: 5985
		private int _AT_INI;

		// Token: 0x04001762 RID: 5986
		private int _AT_UP;

		// Token: 0x04001763 RID: 5987
		private int _Magic_INI;

		// Token: 0x04001764 RID: 5988
		private int _Magic_UP;

		// Token: 0x04001765 RID: 5989
		private int _DF_INI;

		// Token: 0x04001766 RID: 5990
		private int _DF_UP;

		// Token: 0x04001767 RID: 5991
		private int _MagicDF_INI;

		// Token: 0x04001768 RID: 5992
		private int _MagicDF_UP;

		// Token: 0x04001769 RID: 5993
		private int _DEX_INI;

		// Token: 0x0400176A RID: 5994
		private int _DEX_UP;

		// Token: 0x0400176B RID: 5995
		private int _GotSkill_ID;

		// Token: 0x0400176C RID: 5996
		private int _GotSoldier_ID;

		// Token: 0x0400176D RID: 5997
		private IExtension extensionObject;

		// Token: 0x0400176E RID: 5998
		public int[] m_jobMaterialLevels;

		// Token: 0x0400176F RID: 5999
		public ConfigDataSkillInfo m_gotSkillInfo;

		// Token: 0x04001770 RID: 6000
		public ConfigDataSoldierInfo m_gotSoldierInfo;

		// Token: 0x04001771 RID: 6001
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04001772 RID: 6002
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04001773 RID: 6003
		private LuaFunction m_ctor_hotfix;
	}
}
