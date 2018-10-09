using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x020002AD RID: 685
	[HotFix(true, m_isCtorOnly = true)]
	[CustomLuaClass]
	[ProtoContract(Name = "ConfigDataUnchartedScoreInfo")]
	[Serializable]
	public class ConfigDataUnchartedScoreInfo : IExtensible
	{
		// Token: 0x06002CF8 RID: 11512 RVA: 0x000B63FC File Offset: 0x000B45FC
		public ConfigDataUnchartedScoreInfo()
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

		// Token: 0x17000C80 RID: 3200
		// (get) Token: 0x06002CF9 RID: 11513 RVA: 0x000B64BC File Offset: 0x000B46BC
		// (set) Token: 0x06002CFA RID: 11514 RVA: 0x000B64C4 File Offset: 0x000B46C4
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

		// Token: 0x17000C81 RID: 3201
		// (get) Token: 0x06002CFB RID: 11515 RVA: 0x000B64D0 File Offset: 0x000B46D0
		// (set) Token: 0x06002CFC RID: 11516 RVA: 0x000B64D8 File Offset: 0x000B46D8
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

		// Token: 0x17000C82 RID: 3202
		// (get) Token: 0x06002CFD RID: 11517 RVA: 0x000B64E4 File Offset: 0x000B46E4
		// (set) Token: 0x06002CFE RID: 11518 RVA: 0x000B64EC File Offset: 0x000B46EC
		[ProtoMember(4, IsRequired = true, Name = "PageImage", DataFormat = DataFormat.Default)]
		public string PageImage
		{
			get
			{
				return this._PageImage;
			}
			set
			{
				this._PageImage = value;
			}
		}

		// Token: 0x17000C83 RID: 3203
		// (get) Token: 0x06002CFF RID: 11519 RVA: 0x000B64F8 File Offset: 0x000B46F8
		// (set) Token: 0x06002D00 RID: 11520 RVA: 0x000B6500 File Offset: 0x000B4700
		[ProtoMember(5, IsRequired = true, Name = "UIState", DataFormat = DataFormat.Default)]
		public string UIState
		{
			get
			{
				return this._UIState;
			}
			set
			{
				this._UIState = value;
			}
		}

		// Token: 0x17000C84 RID: 3204
		// (get) Token: 0x06002D01 RID: 11521 RVA: 0x000B650C File Offset: 0x000B470C
		// (set) Token: 0x06002D02 RID: 11522 RVA: 0x000B6514 File Offset: 0x000B4714
		[ProtoMember(6, IsRequired = true, Name = "ScoreName", DataFormat = DataFormat.Default)]
		public string ScoreName
		{
			get
			{
				return this._ScoreName;
			}
			set
			{
				this._ScoreName = value;
			}
		}

		// Token: 0x17000C85 RID: 3205
		// (get) Token: 0x06002D03 RID: 11523 RVA: 0x000B6520 File Offset: 0x000B4720
		[ProtoMember(7, Name = "BonusHeroIdList", DataFormat = DataFormat.Default)]
		public List<Int32Pair> BonusHeroIdList
		{
			get
			{
				return this._BonusHeroIdList;
			}
		}

		// Token: 0x17000C86 RID: 3206
		// (get) Token: 0x06002D04 RID: 11524 RVA: 0x000B6528 File Offset: 0x000B4728
		// (set) Token: 0x06002D05 RID: 11525 RVA: 0x000B6530 File Offset: 0x000B4730
		[ProtoMember(8, IsRequired = true, Name = "UnchartedScoreRewardGroupId", DataFormat = DataFormat.TwosComplement)]
		public int UnchartedScoreRewardGroupId
		{
			get
			{
				return this._UnchartedScoreRewardGroupId;
			}
			set
			{
				this._UnchartedScoreRewardGroupId = value;
			}
		}

		// Token: 0x17000C87 RID: 3207
		// (get) Token: 0x06002D06 RID: 11526 RVA: 0x000B653C File Offset: 0x000B473C
		// (set) Token: 0x06002D07 RID: 11527 RVA: 0x000B6544 File Offset: 0x000B4744
		[ProtoMember(9, IsRequired = true, Name = "ScoreItemId", DataFormat = DataFormat.TwosComplement)]
		public int ScoreItemId
		{
			get
			{
				return this._ScoreItemId;
			}
			set
			{
				this._ScoreItemId = value;
			}
		}

		// Token: 0x17000C88 RID: 3208
		// (get) Token: 0x06002D08 RID: 11528 RVA: 0x000B6550 File Offset: 0x000B4750
		[ProtoMember(10, Name = "ChallengeLevelIdList", DataFormat = DataFormat.TwosComplement)]
		public List<int> ChallengeLevelIdList
		{
			get
			{
				return this._ChallengeLevelIdList;
			}
		}

		// Token: 0x17000C89 RID: 3209
		// (get) Token: 0x06002D09 RID: 11529 RVA: 0x000B6558 File Offset: 0x000B4758
		[ProtoMember(11, Name = "ScoreLevelIdList", DataFormat = DataFormat.TwosComplement)]
		public List<int> ScoreLevelIdList
		{
			get
			{
				return this._ScoreLevelIdList;
			}
		}

		// Token: 0x17000C8A RID: 3210
		// (get) Token: 0x06002D0A RID: 11530 RVA: 0x000B6560 File Offset: 0x000B4760
		// (set) Token: 0x06002D0B RID: 11531 RVA: 0x000B6568 File Offset: 0x000B4768
		[ProtoMember(12, IsRequired = true, Name = "ScoreLevelBonusCount", DataFormat = DataFormat.TwosComplement)]
		public int ScoreLevelBonusCount
		{
			get
			{
				return this._ScoreLevelBonusCount;
			}
			set
			{
				this._ScoreLevelBonusCount = value;
			}
		}

		// Token: 0x17000C8B RID: 3211
		// (get) Token: 0x06002D0C RID: 11532 RVA: 0x000B6574 File Offset: 0x000B4774
		// (set) Token: 0x06002D0D RID: 11533 RVA: 0x000B657C File Offset: 0x000B477C
		[ProtoMember(13, IsRequired = true, Name = "ScoreLevelBonus", DataFormat = DataFormat.TwosComplement)]
		public int ScoreLevelBonus
		{
			get
			{
				return this._ScoreLevelBonus;
			}
			set
			{
				this._ScoreLevelBonus = value;
			}
		}

		// Token: 0x17000C8C RID: 3212
		// (get) Token: 0x06002D0E RID: 11534 RVA: 0x000B6588 File Offset: 0x000B4788
		[ProtoMember(14, Name = "ModelIdList", DataFormat = DataFormat.TwosComplement)]
		public List<int> ModelIdList
		{
			get
			{
				return this._ModelIdList;
			}
		}

		// Token: 0x06002D0F RID: 11535 RVA: 0x000B6590 File Offset: 0x000B4790
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002D10 RID: 11536 RVA: 0x000B65A0 File Offset: 0x000B47A0
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

		// Token: 0x06002D11 RID: 11537 RVA: 0x000B666C File Offset: 0x000B486C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataUnchartedScoreInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04001BC7 RID: 7111
		private int _ID;

		// Token: 0x04001BC8 RID: 7112
		private string _Name;

		// Token: 0x04001BC9 RID: 7113
		private string _PageImage;

		// Token: 0x04001BCA RID: 7114
		private string _UIState;

		// Token: 0x04001BCB RID: 7115
		private string _ScoreName;

		// Token: 0x04001BCC RID: 7116
		private readonly List<Int32Pair> _BonusHeroIdList = new List<Int32Pair>();

		// Token: 0x04001BCD RID: 7117
		private int _UnchartedScoreRewardGroupId;

		// Token: 0x04001BCE RID: 7118
		private int _ScoreItemId;

		// Token: 0x04001BCF RID: 7119
		private readonly List<int> _ChallengeLevelIdList = new List<int>();

		// Token: 0x04001BD0 RID: 7120
		private readonly List<int> _ScoreLevelIdList = new List<int>();

		// Token: 0x04001BD1 RID: 7121
		private int _ScoreLevelBonusCount;

		// Token: 0x04001BD2 RID: 7122
		private int _ScoreLevelBonus;

		// Token: 0x04001BD3 RID: 7123
		private readonly List<int> _ModelIdList = new List<int>();

		// Token: 0x04001BD4 RID: 7124
		private IExtension extensionObject;

		// Token: 0x04001BD5 RID: 7125
		public Dictionary<int, int> HeroId2Bonus = new Dictionary<int, int>();

		// Token: 0x04001BD6 RID: 7126
		public Dictionary<int, ConfigDataChallengeLevelInfo> Id2ChallengeLevelInfos = new Dictionary<int, ConfigDataChallengeLevelInfo>();

		// Token: 0x04001BD7 RID: 7127
		public Dictionary<int, ConfigDataScoreLevelInfo> Id2ScoreLevelInfos = new Dictionary<int, ConfigDataScoreLevelInfo>();

		// Token: 0x04001BD8 RID: 7128
		public Dictionary<int, List<Goods>> Score2GoodsList = new Dictionary<int, List<Goods>>();

		// Token: 0x04001BD9 RID: 7129
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04001BDA RID: 7130
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04001BDB RID: 7131
		private LuaFunction m_ctor_hotfix;
	}
}
