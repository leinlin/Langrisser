using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000248 RID: 584
	[ProtoContract(Name = "ConfigDataHeroFetterInfo")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ConfigDataHeroFetterInfo : IExtensible
	{
		// Token: 0x06002424 RID: 9252 RVA: 0x000A6ADC File Offset: 0x000A4CDC
		public ConfigDataHeroFetterInfo()
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

		// Token: 0x1700089F RID: 2207
		// (get) Token: 0x06002425 RID: 9253 RVA: 0x000A6B7C File Offset: 0x000A4D7C
		// (set) Token: 0x06002426 RID: 9254 RVA: 0x000A6B84 File Offset: 0x000A4D84
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

		// Token: 0x170008A0 RID: 2208
		// (get) Token: 0x06002427 RID: 9255 RVA: 0x000A6B90 File Offset: 0x000A4D90
		// (set) Token: 0x06002428 RID: 9256 RVA: 0x000A6B98 File Offset: 0x000A4D98
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

		// Token: 0x170008A1 RID: 2209
		// (get) Token: 0x06002429 RID: 9257 RVA: 0x000A6BA4 File Offset: 0x000A4DA4
		// (set) Token: 0x0600242A RID: 9258 RVA: 0x000A6BAC File Offset: 0x000A4DAC
		[ProtoMember(4, IsRequired = true, Name = "Icon", DataFormat = DataFormat.Default)]
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

		// Token: 0x170008A2 RID: 2210
		// (get) Token: 0x0600242B RID: 9259 RVA: 0x000A6BB8 File Offset: 0x000A4DB8
		// (set) Token: 0x0600242C RID: 9260 RVA: 0x000A6BC0 File Offset: 0x000A4DC0
		[ProtoMember(5, IsRequired = true, Name = "MaxLevel", DataFormat = DataFormat.TwosComplement)]
		public int MaxLevel
		{
			get
			{
				return this._MaxLevel;
			}
			set
			{
				this._MaxLevel = value;
			}
		}

		// Token: 0x170008A3 RID: 2211
		// (get) Token: 0x0600242D RID: 9261 RVA: 0x000A6BCC File Offset: 0x000A4DCC
		[ProtoMember(6, Name = "CompletionConditions", DataFormat = DataFormat.Default)]
		public List<HeroFetterCompletionCondition> CompletionConditions
		{
			get
			{
				return this._CompletionConditions;
			}
		}

		// Token: 0x170008A4 RID: 2212
		// (get) Token: 0x0600242E RID: 9262 RVA: 0x000A6BD4 File Offset: 0x000A4DD4
		[ProtoMember(7, Name = "Reward", DataFormat = DataFormat.Default)]
		public List<Goods> Reward
		{
			get
			{
				return this._Reward;
			}
		}

		// Token: 0x170008A5 RID: 2213
		// (get) Token: 0x0600242F RID: 9263 RVA: 0x000A6BDC File Offset: 0x000A4DDC
		[ProtoMember(8, Name = "GotSkills_ID", DataFormat = DataFormat.TwosComplement)]
		public List<int> GotSkills_ID
		{
			get
			{
				return this._GotSkills_ID;
			}
		}

		// Token: 0x170008A6 RID: 2214
		// (get) Token: 0x06002430 RID: 9264 RVA: 0x000A6BE4 File Offset: 0x000A4DE4
		[ProtoMember(9, Name = "LevelUpMaterials", DataFormat = DataFormat.Default)]
		public List<HeroFetterLevelUpCost> LevelUpMaterials
		{
			get
			{
				return this._LevelUpMaterials;
			}
		}

		// Token: 0x170008A7 RID: 2215
		// (get) Token: 0x06002431 RID: 9265 RVA: 0x000A6BEC File Offset: 0x000A4DEC
		[ProtoMember(10, Name = "LevelUpGold", DataFormat = DataFormat.TwosComplement)]
		public List<int> LevelUpGold
		{
			get
			{
				return this._LevelUpGold;
			}
		}

		// Token: 0x06002432 RID: 9266 RVA: 0x000A6BF4 File Offset: 0x000A4DF4
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002433 RID: 9267 RVA: 0x000A6C04 File Offset: 0x000A4E04
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

		// Token: 0x06002434 RID: 9268 RVA: 0x000A6CD0 File Offset: 0x000A4ED0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataHeroFetterInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040015FA RID: 5626
		private int _ID;

		// Token: 0x040015FB RID: 5627
		private string _Name;

		// Token: 0x040015FC RID: 5628
		private string _Icon;

		// Token: 0x040015FD RID: 5629
		private int _MaxLevel;

		// Token: 0x040015FE RID: 5630
		private readonly List<HeroFetterCompletionCondition> _CompletionConditions = new List<HeroFetterCompletionCondition>();

		// Token: 0x040015FF RID: 5631
		private readonly List<Goods> _Reward = new List<Goods>();

		// Token: 0x04001600 RID: 5632
		private readonly List<int> _GotSkills_ID = new List<int>();

		// Token: 0x04001601 RID: 5633
		private readonly List<HeroFetterLevelUpCost> _LevelUpMaterials = new List<HeroFetterLevelUpCost>();

		// Token: 0x04001602 RID: 5634
		private readonly List<int> _LevelUpGold = new List<int>();

		// Token: 0x04001603 RID: 5635
		private IExtension extensionObject;

		// Token: 0x04001604 RID: 5636
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04001605 RID: 5637
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04001606 RID: 5638
		private LuaFunction m_ctor_hotfix;
	}
}
