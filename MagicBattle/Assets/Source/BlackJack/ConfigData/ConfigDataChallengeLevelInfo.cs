using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x0200021D RID: 541
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ConfigDataChallengeLevelInfo")]
	[CustomLuaClass]
	[Serializable]
	public class ConfigDataChallengeLevelInfo : IExtensible
	{
		// Token: 0x06001FDE RID: 8158 RVA: 0x0009FB1C File Offset: 0x0009DD1C
		public ConfigDataChallengeLevelInfo()
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

		// Token: 0x170006A7 RID: 1703
		// (get) Token: 0x06001FDF RID: 8159 RVA: 0x0009FB90 File Offset: 0x0009DD90
		// (set) Token: 0x06001FE0 RID: 8160 RVA: 0x0009FB98 File Offset: 0x0009DD98
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

		// Token: 0x170006A8 RID: 1704
		// (get) Token: 0x06001FE1 RID: 8161 RVA: 0x0009FBA4 File Offset: 0x0009DDA4
		// (set) Token: 0x06001FE2 RID: 8162 RVA: 0x0009FBAC File Offset: 0x0009DDAC
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

		// Token: 0x170006A9 RID: 1705
		// (get) Token: 0x06001FE3 RID: 8163 RVA: 0x0009FBB8 File Offset: 0x0009DDB8
		// (set) Token: 0x06001FE4 RID: 8164 RVA: 0x0009FBC0 File Offset: 0x0009DDC0
		[ProtoMember(4, IsRequired = true, Name = "PrevLevelId", DataFormat = DataFormat.TwosComplement)]
		public int PrevLevelId
		{
			get
			{
				return this._PrevLevelId;
			}
			set
			{
				this._PrevLevelId = value;
			}
		}

		// Token: 0x170006AA RID: 1706
		// (get) Token: 0x06001FE5 RID: 8165 RVA: 0x0009FBCC File Offset: 0x0009DDCC
		// (set) Token: 0x06001FE6 RID: 8166 RVA: 0x0009FBD4 File Offset: 0x0009DDD4
		[ProtoMember(5, IsRequired = true, Name = "UnlockDaysDelay", DataFormat = DataFormat.TwosComplement)]
		public int UnlockDaysDelay
		{
			get
			{
				return this._UnlockDaysDelay;
			}
			set
			{
				this._UnlockDaysDelay = value;
			}
		}

		// Token: 0x170006AB RID: 1707
		// (get) Token: 0x06001FE7 RID: 8167 RVA: 0x0009FBE0 File Offset: 0x0009DDE0
		// (set) Token: 0x06001FE8 RID: 8168 RVA: 0x0009FBE8 File Offset: 0x0009DDE8
		[ProtoMember(6, IsRequired = true, Name = "EnergySuccess", DataFormat = DataFormat.TwosComplement)]
		public int EnergySuccess
		{
			get
			{
				return this._EnergySuccess;
			}
			set
			{
				this._EnergySuccess = value;
			}
		}

		// Token: 0x170006AC RID: 1708
		// (get) Token: 0x06001FE9 RID: 8169 RVA: 0x0009FBF4 File Offset: 0x0009DDF4
		// (set) Token: 0x06001FEA RID: 8170 RVA: 0x0009FBFC File Offset: 0x0009DDFC
		[ProtoMember(7, IsRequired = true, Name = "EnergyFail", DataFormat = DataFormat.TwosComplement)]
		public int EnergyFail
		{
			get
			{
				return this._EnergyFail;
			}
			set
			{
				this._EnergyFail = value;
			}
		}

		// Token: 0x170006AD RID: 1709
		// (get) Token: 0x06001FEB RID: 8171 RVA: 0x0009FC08 File Offset: 0x0009DE08
		// (set) Token: 0x06001FEC RID: 8172 RVA: 0x0009FC10 File Offset: 0x0009DE10
		[ProtoMember(8, IsRequired = true, Name = "MonsterLevel", DataFormat = DataFormat.TwosComplement)]
		public int MonsterLevel
		{
			get
			{
				return this._MonsterLevel;
			}
			set
			{
				this._MonsterLevel = value;
			}
		}

		// Token: 0x170006AE RID: 1710
		// (get) Token: 0x06001FED RID: 8173 RVA: 0x0009FC1C File Offset: 0x0009DE1C
		// (set) Token: 0x06001FEE RID: 8174 RVA: 0x0009FC24 File Offset: 0x0009DE24
		[ProtoMember(9, IsRequired = true, Name = "Battle_ID", DataFormat = DataFormat.TwosComplement)]
		public int Battle_ID
		{
			get
			{
				return this._Battle_ID;
			}
			set
			{
				this._Battle_ID = value;
			}
		}

		// Token: 0x170006AF RID: 1711
		// (get) Token: 0x06001FEF RID: 8175 RVA: 0x0009FC30 File Offset: 0x0009DE30
		// (set) Token: 0x06001FF0 RID: 8176 RVA: 0x0009FC38 File Offset: 0x0009DE38
		[ProtoMember(10, IsRequired = true, Name = "DialogBefore_ID", DataFormat = DataFormat.TwosComplement)]
		public int DialogBefore_ID
		{
			get
			{
				return this._DialogBefore_ID;
			}
			set
			{
				this._DialogBefore_ID = value;
			}
		}

		// Token: 0x170006B0 RID: 1712
		// (get) Token: 0x06001FF1 RID: 8177 RVA: 0x0009FC44 File Offset: 0x0009DE44
		// (set) Token: 0x06001FF2 RID: 8178 RVA: 0x0009FC4C File Offset: 0x0009DE4C
		[ProtoMember(11, IsRequired = true, Name = "DialogAfter_ID", DataFormat = DataFormat.TwosComplement)]
		public int DialogAfter_ID
		{
			get
			{
				return this._DialogAfter_ID;
			}
			set
			{
				this._DialogAfter_ID = value;
			}
		}

		// Token: 0x170006B1 RID: 1713
		// (get) Token: 0x06001FF3 RID: 8179 RVA: 0x0009FC58 File Offset: 0x0009DE58
		// (set) Token: 0x06001FF4 RID: 8180 RVA: 0x0009FC60 File Offset: 0x0009DE60
		[ProtoMember(12, IsRequired = true, Name = "PlayerExp", DataFormat = DataFormat.TwosComplement)]
		public int PlayerExp
		{
			get
			{
				return this._PlayerExp;
			}
			set
			{
				this._PlayerExp = value;
			}
		}

		// Token: 0x170006B2 RID: 1714
		// (get) Token: 0x06001FF5 RID: 8181 RVA: 0x0009FC6C File Offset: 0x0009DE6C
		// (set) Token: 0x06001FF6 RID: 8182 RVA: 0x0009FC74 File Offset: 0x0009DE74
		[ProtoMember(13, IsRequired = true, Name = "HeroExp", DataFormat = DataFormat.TwosComplement)]
		public int HeroExp
		{
			get
			{
				return this._HeroExp;
			}
			set
			{
				this._HeroExp = value;
			}
		}

		// Token: 0x170006B3 RID: 1715
		// (get) Token: 0x06001FF7 RID: 8183 RVA: 0x0009FC80 File Offset: 0x0009DE80
		// (set) Token: 0x06001FF8 RID: 8184 RVA: 0x0009FC88 File Offset: 0x0009DE88
		[ProtoMember(14, IsRequired = true, Name = "Gold", DataFormat = DataFormat.TwosComplement)]
		public int Gold
		{
			get
			{
				return this._Gold;
			}
			set
			{
				this._Gold = value;
			}
		}

		// Token: 0x170006B4 RID: 1716
		// (get) Token: 0x06001FF9 RID: 8185 RVA: 0x0009FC94 File Offset: 0x0009DE94
		// (set) Token: 0x06001FFA RID: 8186 RVA: 0x0009FC9C File Offset: 0x0009DE9C
		[ProtoMember(15, IsRequired = true, Name = "ScoreBase", DataFormat = DataFormat.TwosComplement)]
		public int ScoreBase
		{
			get
			{
				return this._ScoreBase;
			}
			set
			{
				this._ScoreBase = value;
			}
		}

		// Token: 0x170006B5 RID: 1717
		// (get) Token: 0x06001FFB RID: 8187 RVA: 0x0009FCA8 File Offset: 0x0009DEA8
		[ProtoMember(16, Name = "CommonRewardList", DataFormat = DataFormat.Default)]
		public List<Goods> CommonRewardList
		{
			get
			{
				return this._CommonRewardList;
			}
		}

		// Token: 0x170006B6 RID: 1718
		// (get) Token: 0x06001FFC RID: 8188 RVA: 0x0009FCB0 File Offset: 0x0009DEB0
		// (set) Token: 0x06001FFD RID: 8189 RVA: 0x0009FCB8 File Offset: 0x0009DEB8
		[ProtoMember(17, IsRequired = true, Name = "ItemDropCountDisplay", DataFormat = DataFormat.TwosComplement)]
		public int ItemDropCountDisplay
		{
			get
			{
				return this._ItemDropCountDisplay;
			}
			set
			{
				this._ItemDropCountDisplay = value;
			}
		}

		// Token: 0x06001FFE RID: 8190 RVA: 0x0009FCC4 File Offset: 0x0009DEC4
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x170006B7 RID: 1719
		// (get) Token: 0x06001FFF RID: 8191 RVA: 0x0009FCD4 File Offset: 0x0009DED4
		// (set) Token: 0x06002000 RID: 8192 RVA: 0x0009FCDC File Offset: 0x0009DEDC
		public ConfigDataBattleInfo BattleInfo { get; set; }

		// Token: 0x170006B8 RID: 1720
		// (get) Token: 0x06002001 RID: 8193 RVA: 0x0009FCE8 File Offset: 0x0009DEE8
		// (set) Token: 0x06002002 RID: 8194 RVA: 0x0009FCF0 File Offset: 0x0009DEF0
		public ConfigDataUnchartedScoreInfo UnchartedScoreInfo { get; set; }

		// Token: 0x06002003 RID: 8195 RVA: 0x0009FCFC File Offset: 0x0009DEFC
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

		// Token: 0x06002004 RID: 8196 RVA: 0x0009FDC8 File Offset: 0x0009DFC8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataChallengeLevelInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400133B RID: 4923
		private int _ID;

		// Token: 0x0400133C RID: 4924
		private string _Name;

		// Token: 0x0400133D RID: 4925
		private int _PrevLevelId;

		// Token: 0x0400133E RID: 4926
		private int _UnlockDaysDelay;

		// Token: 0x0400133F RID: 4927
		private int _EnergySuccess;

		// Token: 0x04001340 RID: 4928
		private int _EnergyFail;

		// Token: 0x04001341 RID: 4929
		private int _MonsterLevel;

		// Token: 0x04001342 RID: 4930
		private int _Battle_ID;

		// Token: 0x04001343 RID: 4931
		private int _DialogBefore_ID;

		// Token: 0x04001344 RID: 4932
		private int _DialogAfter_ID;

		// Token: 0x04001345 RID: 4933
		private int _PlayerExp;

		// Token: 0x04001346 RID: 4934
		private int _HeroExp;

		// Token: 0x04001347 RID: 4935
		private int _Gold;

		// Token: 0x04001348 RID: 4936
		private int _ScoreBase;

		// Token: 0x04001349 RID: 4937
		private readonly List<Goods> _CommonRewardList = new List<Goods>();

		// Token: 0x0400134A RID: 4938
		private int _ItemDropCountDisplay;

		// Token: 0x0400134B RID: 4939
		private IExtension extensionObject;

		// Token: 0x0400134E RID: 4942
		public ConfigDataDialogInfo m_dialogInfoBefore;

		// Token: 0x0400134F RID: 4943
		public ConfigDataDialogInfo m_dialogInfoAfter;

		// Token: 0x04001350 RID: 4944
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04001351 RID: 4945
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04001352 RID: 4946
		private LuaFunction m_ctor_hotfix;
	}
}
