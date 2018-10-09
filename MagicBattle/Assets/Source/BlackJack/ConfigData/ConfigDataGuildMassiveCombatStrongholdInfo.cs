using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x0200023F RID: 575
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ConfigDataGuildMassiveCombatStrongholdInfo")]
	[Serializable]
	public class ConfigDataGuildMassiveCombatStrongholdInfo : IExtensible
	{
		// Token: 0x0600236A RID: 9066 RVA: 0x000A552C File Offset: 0x000A372C
		public ConfigDataGuildMassiveCombatStrongholdInfo()
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

		// Token: 0x1700084B RID: 2123
		// (get) Token: 0x0600236B RID: 9067 RVA: 0x000A55B4 File Offset: 0x000A37B4
		// (set) Token: 0x0600236C RID: 9068 RVA: 0x000A55BC File Offset: 0x000A37BC
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

		// Token: 0x1700084C RID: 2124
		// (get) Token: 0x0600236D RID: 9069 RVA: 0x000A55C8 File Offset: 0x000A37C8
		// (set) Token: 0x0600236E RID: 9070 RVA: 0x000A55D0 File Offset: 0x000A37D0
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

		// Token: 0x1700084D RID: 2125
		// (get) Token: 0x0600236F RID: 9071 RVA: 0x000A55DC File Offset: 0x000A37DC
		// (set) Token: 0x06002370 RID: 9072 RVA: 0x000A55E4 File Offset: 0x000A37E4
		[ProtoMember(4, IsRequired = true, Name = "Resources", DataFormat = DataFormat.Default)]
		public string Resources
		{
			get
			{
				return this._Resources;
			}
			set
			{
				this._Resources = value;
			}
		}

		// Token: 0x1700084E RID: 2126
		// (get) Token: 0x06002371 RID: 9073 RVA: 0x000A55F0 File Offset: 0x000A37F0
		[ProtoMember(5, Name = "LevelList", DataFormat = DataFormat.TwosComplement)]
		public List<int> LevelList
		{
			get
			{
				return this._LevelList;
			}
		}

		// Token: 0x1700084F RID: 2127
		// (get) Token: 0x06002372 RID: 9074 RVA: 0x000A55F8 File Offset: 0x000A37F8
		// (set) Token: 0x06002373 RID: 9075 RVA: 0x000A5600 File Offset: 0x000A3800
		[ProtoMember(6, IsRequired = true, Name = "EnemyLevel", DataFormat = DataFormat.TwosComplement)]
		public int EnemyLevel
		{
			get
			{
				return this._EnemyLevel;
			}
			set
			{
				this._EnemyLevel = value;
			}
		}

		// Token: 0x17000850 RID: 2128
		// (get) Token: 0x06002374 RID: 9076 RVA: 0x000A560C File Offset: 0x000A380C
		// (set) Token: 0x06002375 RID: 9077 RVA: 0x000A5614 File Offset: 0x000A3814
		[ProtoMember(7, IsRequired = true, Name = "EnemyCount", DataFormat = DataFormat.TwosComplement)]
		public int EnemyCount
		{
			get
			{
				return this._EnemyCount;
			}
			set
			{
				this._EnemyCount = value;
			}
		}

		// Token: 0x17000851 RID: 2129
		// (get) Token: 0x06002376 RID: 9078 RVA: 0x000A5620 File Offset: 0x000A3820
		// (set) Token: 0x06002377 RID: 9079 RVA: 0x000A5628 File Offset: 0x000A3828
		[ProtoMember(8, IsRequired = true, Name = "EnemyPoints", DataFormat = DataFormat.TwosComplement)]
		public int EnemyPoints
		{
			get
			{
				return this._EnemyPoints;
			}
			set
			{
				this._EnemyPoints = value;
			}
		}

		// Token: 0x17000852 RID: 2130
		// (get) Token: 0x06002378 RID: 9080 RVA: 0x000A5634 File Offset: 0x000A3834
		[ProtoMember(9, Name = "Bonus", DataFormat = DataFormat.Default)]
		public List<Goods> Bonus
		{
			get
			{
				return this._Bonus;
			}
		}

		// Token: 0x17000853 RID: 2131
		// (get) Token: 0x06002379 RID: 9081 RVA: 0x000A563C File Offset: 0x000A383C
		[ProtoMember(10, Name = "UpHeroTag_IDS", DataFormat = DataFormat.TwosComplement)]
		public List<int> UpHeroTag_IDS
		{
			get
			{
				return this._UpHeroTag_IDS;
			}
		}

		// Token: 0x17000854 RID: 2132
		// (get) Token: 0x0600237A RID: 9082 RVA: 0x000A5644 File Offset: 0x000A3844
		// (set) Token: 0x0600237B RID: 9083 RVA: 0x000A564C File Offset: 0x000A384C
		[ProtoMember(11, IsRequired = true, Name = "UpSkill_ID", DataFormat = DataFormat.TwosComplement)]
		public int UpSkill_ID
		{
			get
			{
				return this._UpSkill_ID;
			}
			set
			{
				this._UpSkill_ID = value;
			}
		}

		// Token: 0x0600237C RID: 9084 RVA: 0x000A5658 File Offset: 0x000A3858
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600237D RID: 9085 RVA: 0x000A5668 File Offset: 0x000A3868
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

		// Token: 0x0600237E RID: 9086 RVA: 0x000A5734 File Offset: 0x000A3934
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataGuildMassiveCombatStrongholdInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04001577 RID: 5495
		private int _ID;

		// Token: 0x04001578 RID: 5496
		private string _Name;

		// Token: 0x04001579 RID: 5497
		private string _Resources;

		// Token: 0x0400157A RID: 5498
		private readonly List<int> _LevelList = new List<int>();

		// Token: 0x0400157B RID: 5499
		private int _EnemyLevel;

		// Token: 0x0400157C RID: 5500
		private int _EnemyCount;

		// Token: 0x0400157D RID: 5501
		private int _EnemyPoints;

		// Token: 0x0400157E RID: 5502
		private readonly List<Goods> _Bonus = new List<Goods>();

		// Token: 0x0400157F RID: 5503
		private readonly List<int> _UpHeroTag_IDS = new List<int>();

		// Token: 0x04001580 RID: 5504
		private int _UpSkill_ID;

		// Token: 0x04001581 RID: 5505
		private IExtension extensionObject;

		// Token: 0x04001582 RID: 5506
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04001583 RID: 5507
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04001584 RID: 5508
		private LuaFunction m_ctor_hotfix;
	}
}
