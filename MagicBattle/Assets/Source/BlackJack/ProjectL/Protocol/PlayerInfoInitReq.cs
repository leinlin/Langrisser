using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020006EC RID: 1772
	[ProtoContract(Name = "PlayerInfoInitReq")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class PlayerInfoInitReq : IExtensible
	{
		// Token: 0x06005E80 RID: 24192 RVA: 0x001AD734 File Offset: 0x001AB934
		public PlayerInfoInitReq()
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

		// Token: 0x17001801 RID: 6145
		// (get) Token: 0x06005E81 RID: 24193 RVA: 0x001AD79C File Offset: 0x001AB99C
		// (set) Token: 0x06005E82 RID: 24194 RVA: 0x001AD7A4 File Offset: 0x001AB9A4
		[ProtoMember(1, IsRequired = true, Name = "DSBasicInfoVersion", DataFormat = DataFormat.TwosComplement)]
		public uint DSBasicInfoVersion
		{
			get
			{
				return this._DSBasicInfoVersion;
			}
			set
			{
				this._DSBasicInfoVersion = value;
			}
		}

		// Token: 0x17001802 RID: 6146
		// (get) Token: 0x06005E83 RID: 24195 RVA: 0x001AD7B0 File Offset: 0x001AB9B0
		// (set) Token: 0x06005E84 RID: 24196 RVA: 0x001AD7B8 File Offset: 0x001AB9B8
		[ProtoMember(2, IsRequired = true, Name = "DSBagVersion", DataFormat = DataFormat.TwosComplement)]
		public uint DSBagVersion
		{
			get
			{
				return this._DSBagVersion;
			}
			set
			{
				this._DSBagVersion = value;
			}
		}

		// Token: 0x17001803 RID: 6147
		// (get) Token: 0x06005E85 RID: 24197 RVA: 0x001AD7C4 File Offset: 0x001AB9C4
		// (set) Token: 0x06005E86 RID: 24198 RVA: 0x001AD7CC File Offset: 0x001AB9CC
		[ProtoMember(3, IsRequired = true, Name = "DSHeroVersion", DataFormat = DataFormat.TwosComplement)]
		public uint DSHeroVersion
		{
			get
			{
				return this._DSHeroVersion;
			}
			set
			{
				this._DSHeroVersion = value;
			}
		}

		// Token: 0x17001804 RID: 6148
		// (get) Token: 0x06005E87 RID: 24199 RVA: 0x001AD7D8 File Offset: 0x001AB9D8
		// (set) Token: 0x06005E88 RID: 24200 RVA: 0x001AD7E0 File Offset: 0x001AB9E0
		[ProtoMember(4, IsRequired = true, Name = "DSLevelVersion", DataFormat = DataFormat.TwosComplement)]
		public uint DSLevelVersion
		{
			get
			{
				return this._DSLevelVersion;
			}
			set
			{
				this._DSLevelVersion = value;
			}
		}

		// Token: 0x17001805 RID: 6149
		// (get) Token: 0x06005E89 RID: 24201 RVA: 0x001AD7EC File Offset: 0x001AB9EC
		// (set) Token: 0x06005E8A RID: 24202 RVA: 0x001AD7F4 File Offset: 0x001AB9F4
		[ProtoMember(5, IsRequired = true, Name = "DSRiftVersion", DataFormat = DataFormat.TwosComplement)]
		public uint DSRiftVersion
		{
			get
			{
				return this._DSRiftVersion;
			}
			set
			{
				this._DSRiftVersion = value;
			}
		}

		// Token: 0x17001806 RID: 6150
		// (get) Token: 0x06005E8B RID: 24203 RVA: 0x001AD800 File Offset: 0x001ABA00
		// (set) Token: 0x06005E8C RID: 24204 RVA: 0x001AD808 File Offset: 0x001ABA08
		[ProtoMember(6, IsRequired = true, Name = "DSBattleVersion", DataFormat = DataFormat.TwosComplement)]
		public uint DSBattleVersion
		{
			get
			{
				return this._DSBattleVersion;
			}
			set
			{
				this._DSBattleVersion = value;
			}
		}

		// Token: 0x17001807 RID: 6151
		// (get) Token: 0x06005E8D RID: 24205 RVA: 0x001AD814 File Offset: 0x001ABA14
		// (set) Token: 0x06005E8E RID: 24206 RVA: 0x001AD81C File Offset: 0x001ABA1C
		[ProtoMember(7, IsRequired = true, Name = "DSMailVersion", DataFormat = DataFormat.TwosComplement)]
		public uint DSMailVersion
		{
			get
			{
				return this._DSMailVersion;
			}
			set
			{
				this._DSMailVersion = value;
			}
		}

		// Token: 0x17001808 RID: 6152
		// (get) Token: 0x06005E8F RID: 24207 RVA: 0x001AD828 File Offset: 0x001ABA28
		// (set) Token: 0x06005E90 RID: 24208 RVA: 0x001AD830 File Offset: 0x001ABA30
		[ProtoMember(8, IsRequired = true, Name = "DSFixedStoreVersion", DataFormat = DataFormat.TwosComplement)]
		public uint DSFixedStoreVersion
		{
			get
			{
				return this._DSFixedStoreVersion;
			}
			set
			{
				this._DSFixedStoreVersion = value;
			}
		}

		// Token: 0x17001809 RID: 6153
		// (get) Token: 0x06005E91 RID: 24209 RVA: 0x001AD83C File Offset: 0x001ABA3C
		// (set) Token: 0x06005E92 RID: 24210 RVA: 0x001AD844 File Offset: 0x001ABA44
		[ProtoMember(9, IsRequired = true, Name = "DSChatVersion", DataFormat = DataFormat.TwosComplement)]
		public uint DSChatVersion
		{
			get
			{
				return this._DSChatVersion;
			}
			set
			{
				this._DSChatVersion = value;
			}
		}

		// Token: 0x1700180A RID: 6154
		// (get) Token: 0x06005E93 RID: 24211 RVA: 0x001AD850 File Offset: 0x001ABA50
		// (set) Token: 0x06005E94 RID: 24212 RVA: 0x001AD858 File Offset: 0x001ABA58
		[ProtoMember(10, IsRequired = true, Name = "DSSelectCardVersion", DataFormat = DataFormat.TwosComplement)]
		public uint DSSelectCardVersion
		{
			get
			{
				return this._DSSelectCardVersion;
			}
			set
			{
				this._DSSelectCardVersion = value;
			}
		}

		// Token: 0x1700180B RID: 6155
		// (get) Token: 0x06005E95 RID: 24213 RVA: 0x001AD864 File Offset: 0x001ABA64
		// (set) Token: 0x06005E96 RID: 24214 RVA: 0x001AD86C File Offset: 0x001ABA6C
		[ProtoMember(11, IsRequired = true, Name = "DSMissionVersion", DataFormat = DataFormat.TwosComplement)]
		public uint DSMissionVersion
		{
			get
			{
				return this._DSMissionVersion;
			}
			set
			{
				this._DSMissionVersion = value;
			}
		}

		// Token: 0x1700180C RID: 6156
		// (get) Token: 0x06005E97 RID: 24215 RVA: 0x001AD878 File Offset: 0x001ABA78
		// (set) Token: 0x06005E98 RID: 24216 RVA: 0x001AD880 File Offset: 0x001ABA80
		[ProtoMember(12, IsRequired = true, Name = "DSThearchyTrialVersion", DataFormat = DataFormat.TwosComplement)]
		public uint DSThearchyTrialVersion
		{
			get
			{
				return this._DSThearchyTrialVersion;
			}
			set
			{
				this._DSThearchyTrialVersion = value;
			}
		}

		// Token: 0x1700180D RID: 6157
		// (get) Token: 0x06005E99 RID: 24217 RVA: 0x001AD88C File Offset: 0x001ABA8C
		// (set) Token: 0x06005E9A RID: 24218 RVA: 0x001AD894 File Offset: 0x001ABA94
		[ProtoMember(13, IsRequired = true, Name = "DSAnikiGymVersion", DataFormat = DataFormat.TwosComplement)]
		public uint DSAnikiGymVersion
		{
			get
			{
				return this._DSAnikiGymVersion;
			}
			set
			{
				this._DSAnikiGymVersion = value;
			}
		}

		// Token: 0x1700180E RID: 6158
		// (get) Token: 0x06005E9B RID: 24219 RVA: 0x001AD8A0 File Offset: 0x001ABAA0
		// (set) Token: 0x06005E9C RID: 24220 RVA: 0x001AD8A8 File Offset: 0x001ABAA8
		[ProtoMember(14, IsRequired = true, Name = "DSTrainingGroundVersion", DataFormat = DataFormat.TwosComplement)]
		public uint DSTrainingGroundVersion
		{
			get
			{
				return this._DSTrainingGroundVersion;
			}
			set
			{
				this._DSTrainingGroundVersion = value;
			}
		}

		// Token: 0x1700180F RID: 6159
		// (get) Token: 0x06005E9D RID: 24221 RVA: 0x001AD8B4 File Offset: 0x001ABAB4
		// (set) Token: 0x06005E9E RID: 24222 RVA: 0x001AD8BC File Offset: 0x001ABABC
		[ProtoMember(15, IsRequired = true, Name = "DSOperationalActivityVersion", DataFormat = DataFormat.TwosComplement)]
		public uint DSOperationalActivityVersion
		{
			get
			{
				return this._DSOperationalActivityVersion;
			}
			set
			{
				this._DSOperationalActivityVersion = value;
			}
		}

		// Token: 0x17001810 RID: 6160
		// (get) Token: 0x06005E9F RID: 24223 RVA: 0x001AD8C8 File Offset: 0x001ABAC8
		// (set) Token: 0x06005EA0 RID: 24224 RVA: 0x001AD8D0 File Offset: 0x001ABAD0
		[ProtoMember(16, IsRequired = true, Name = "ClientAnnouncementVersion", DataFormat = DataFormat.TwosComplement)]
		public uint ClientAnnouncementVersion
		{
			get
			{
				return this._ClientAnnouncementVersion;
			}
			set
			{
				this._ClientAnnouncementVersion = value;
			}
		}

		// Token: 0x17001811 RID: 6161
		// (get) Token: 0x06005EA1 RID: 24225 RVA: 0x001AD8DC File Offset: 0x001ABADC
		// (set) Token: 0x06005EA2 RID: 24226 RVA: 0x001AD8E4 File Offset: 0x001ABAE4
		[ProtoMember(17, IsRequired = true, Name = "DSRandomStoreVersion", DataFormat = DataFormat.TwosComplement)]
		public uint DSRandomStoreVersion
		{
			get
			{
				return this._DSRandomStoreVersion;
			}
			set
			{
				this._DSRandomStoreVersion = value;
			}
		}

		// Token: 0x17001812 RID: 6162
		// (get) Token: 0x06005EA3 RID: 24227 RVA: 0x001AD8F0 File Offset: 0x001ABAF0
		// (set) Token: 0x06005EA4 RID: 24228 RVA: 0x001AD8F8 File Offset: 0x001ABAF8
		[ProtoMember(18, IsRequired = true, Name = "DSArenaVersion", DataFormat = DataFormat.TwosComplement)]
		public uint DSArenaVersion
		{
			get
			{
				return this._DSArenaVersion;
			}
			set
			{
				this._DSArenaVersion = value;
			}
		}

		// Token: 0x17001813 RID: 6163
		// (get) Token: 0x06005EA5 RID: 24229 RVA: 0x001AD904 File Offset: 0x001ABB04
		// (set) Token: 0x06005EA6 RID: 24230 RVA: 0x001AD90C File Offset: 0x001ABB0C
		[ProtoMember(19, IsRequired = true, Name = "DSSurveyVersion", DataFormat = DataFormat.TwosComplement)]
		public uint DSSurveyVersion
		{
			get
			{
				return this._DSSurveyVersion;
			}
			set
			{
				this._DSSurveyVersion = value;
			}
		}

		// Token: 0x17001814 RID: 6164
		// (get) Token: 0x06005EA7 RID: 24231 RVA: 0x001AD918 File Offset: 0x001ABB18
		// (set) Token: 0x06005EA8 RID: 24232 RVA: 0x001AD920 File Offset: 0x001ABB20
		[ProtoMember(20, IsRequired = true, Name = "DSTreasureMapVersion", DataFormat = DataFormat.TwosComplement)]
		public uint DSTreasureMapVersion
		{
			get
			{
				return this._DSTreasureMapVersion;
			}
			set
			{
				this._DSTreasureMapVersion = value;
			}
		}

		// Token: 0x17001815 RID: 6165
		// (get) Token: 0x06005EA9 RID: 24233 RVA: 0x001AD92C File Offset: 0x001ABB2C
		// (set) Token: 0x06005EAA RID: 24234 RVA: 0x001AD934 File Offset: 0x001ABB34
		[ProtoMember(21, IsRequired = true, Name = "DSMemoryCorridorVersion", DataFormat = DataFormat.TwosComplement)]
		public uint DSMemoryCorridorVersion
		{
			get
			{
				return this._DSMemoryCorridorVersion;
			}
			set
			{
				this._DSMemoryCorridorVersion = value;
			}
		}

		// Token: 0x17001816 RID: 6166
		// (get) Token: 0x06005EAB RID: 24235 RVA: 0x001AD940 File Offset: 0x001ABB40
		// (set) Token: 0x06005EAC RID: 24236 RVA: 0x001AD948 File Offset: 0x001ABB48
		[ProtoMember(22, IsRequired = true, Name = "DSHeroDungeonVersion", DataFormat = DataFormat.TwosComplement)]
		public uint DSHeroDungeonVersion
		{
			get
			{
				return this._DSHeroDungeonVersion;
			}
			set
			{
				this._DSHeroDungeonVersion = value;
			}
		}

		// Token: 0x17001817 RID: 6167
		// (get) Token: 0x06005EAD RID: 24237 RVA: 0x001AD954 File Offset: 0x001ABB54
		// (set) Token: 0x06005EAE RID: 24238 RVA: 0x001AD95C File Offset: 0x001ABB5C
		[ProtoMember(23, IsRequired = true, Name = "DSHerotrainningVersion", DataFormat = DataFormat.TwosComplement)]
		public uint DSHerotrainningVersion
		{
			get
			{
				return this._DSHerotrainningVersion;
			}
			set
			{
				this._DSHerotrainningVersion = value;
			}
		}

		// Token: 0x17001818 RID: 6168
		// (get) Token: 0x06005EAF RID: 24239 RVA: 0x001AD968 File Offset: 0x001ABB68
		// (set) Token: 0x06005EB0 RID: 24240 RVA: 0x001AD970 File Offset: 0x001ABB70
		[ProtoMember(24, IsRequired = true, Name = "DSHeroAssistantsVersion", DataFormat = DataFormat.TwosComplement)]
		public uint DSHeroAssistantsVersion
		{
			get
			{
				return this._DSHeroAssistantsVersion;
			}
			set
			{
				this._DSHeroAssistantsVersion = value;
			}
		}

		// Token: 0x17001819 RID: 6169
		// (get) Token: 0x06005EB1 RID: 24241 RVA: 0x001AD97C File Offset: 0x001ABB7C
		// (set) Token: 0x06005EB2 RID: 24242 RVA: 0x001AD984 File Offset: 0x001ABB84
		[ProtoMember(25, IsRequired = true, Name = "DSFriendVersion", DataFormat = DataFormat.TwosComplement)]
		public uint DSFriendVersion
		{
			get
			{
				return this._DSFriendVersion;
			}
			set
			{
				this._DSFriendVersion = value;
			}
		}

		// Token: 0x1700181A RID: 6170
		// (get) Token: 0x06005EB3 RID: 24243 RVA: 0x001AD990 File Offset: 0x001ABB90
		// (set) Token: 0x06005EB4 RID: 24244 RVA: 0x001AD998 File Offset: 0x001ABB98
		[ProtoMember(26, IsRequired = true, Name = "DSHeroPhantomVersion", DataFormat = DataFormat.TwosComplement)]
		public uint DSHeroPhantomVersion
		{
			get
			{
				return this._DSHeroPhantomVersion;
			}
			set
			{
				this._DSHeroPhantomVersion = value;
			}
		}

		// Token: 0x1700181B RID: 6171
		// (get) Token: 0x06005EB5 RID: 24245 RVA: 0x001AD9A4 File Offset: 0x001ABBA4
		// (set) Token: 0x06005EB6 RID: 24246 RVA: 0x001AD9AC File Offset: 0x001ABBAC
		[ProtoMember(27, IsRequired = true, Name = "DSCooperateBattleVersion", DataFormat = DataFormat.TwosComplement)]
		public uint DSCooperateBattleVersion
		{
			get
			{
				return this._DSCooperateBattleVersion;
			}
			set
			{
				this._DSCooperateBattleVersion = value;
			}
		}

		// Token: 0x1700181C RID: 6172
		// (get) Token: 0x06005EB7 RID: 24247 RVA: 0x001AD9B8 File Offset: 0x001ABBB8
		// (set) Token: 0x06005EB8 RID: 24248 RVA: 0x001AD9C0 File Offset: 0x001ABBC0
		[ProtoMember(28, IsRequired = true, Name = "DSNoviceVersion", DataFormat = DataFormat.TwosComplement)]
		public uint DSNoviceVersion
		{
			get
			{
				return this._DSNoviceVersion;
			}
			set
			{
				this._DSNoviceVersion = value;
			}
		}

		// Token: 0x1700181D RID: 6173
		// (get) Token: 0x06005EB9 RID: 24249 RVA: 0x001AD9CC File Offset: 0x001ABBCC
		// (set) Token: 0x06005EBA RID: 24250 RVA: 0x001AD9D4 File Offset: 0x001ABBD4
		[ProtoMember(29, IsRequired = true, Name = "DSRechargeStoreVersion", DataFormat = DataFormat.TwosComplement)]
		public uint DSRechargeStoreVersion
		{
			get
			{
				return this._DSRechargeStoreVersion;
			}
			set
			{
				this._DSRechargeStoreVersion = value;
			}
		}

		// Token: 0x1700181E RID: 6174
		// (get) Token: 0x06005EBB RID: 24251 RVA: 0x001AD9E0 File Offset: 0x001ABBE0
		// (set) Token: 0x06005EBC RID: 24252 RVA: 0x001AD9E8 File Offset: 0x001ABBE8
		[ProtoMember(30, IsRequired = true, Name = "DSResourceVersion", DataFormat = DataFormat.TwosComplement)]
		public uint DSResourceVersion
		{
			get
			{
				return this._DSResourceVersion;
			}
			set
			{
				this._DSResourceVersion = value;
			}
		}

		// Token: 0x1700181F RID: 6175
		// (get) Token: 0x06005EBD RID: 24253 RVA: 0x001AD9F4 File Offset: 0x001ABBF4
		// (set) Token: 0x06005EBE RID: 24254 RVA: 0x001AD9FC File Offset: 0x001ABBFC
		[ProtoMember(31, IsRequired = true, Name = "DSRealTimePVPVersion", DataFormat = DataFormat.TwosComplement)]
		public uint DSRealTimePVPVersion
		{
			get
			{
				return this._DSRealTimePVPVersion;
			}
			set
			{
				this._DSRealTimePVPVersion = value;
			}
		}

		// Token: 0x17001820 RID: 6176
		// (get) Token: 0x06005EBF RID: 24255 RVA: 0x001ADA08 File Offset: 0x001ABC08
		// (set) Token: 0x06005EC0 RID: 24256 RVA: 0x001ADA10 File Offset: 0x001ABC10
		[ProtoMember(32, IsRequired = true, Name = "DSRaffleVersion", DataFormat = DataFormat.TwosComplement)]
		public uint DSRaffleVersion
		{
			get
			{
				return this._DSRaffleVersion;
			}
			set
			{
				this._DSRaffleVersion = value;
			}
		}

		// Token: 0x17001821 RID: 6177
		// (get) Token: 0x06005EC1 RID: 24257 RVA: 0x001ADA1C File Offset: 0x001ABC1C
		// (set) Token: 0x06005EC2 RID: 24258 RVA: 0x001ADA24 File Offset: 0x001ABC24
		[ProtoMember(33, IsRequired = true, Name = "DSRiftStoreVersion", DataFormat = DataFormat.TwosComplement)]
		public uint DSRiftStoreVersion
		{
			get
			{
				return this._DSRiftStoreVersion;
			}
			set
			{
				this._DSRiftStoreVersion = value;
			}
		}

		// Token: 0x17001822 RID: 6178
		// (get) Token: 0x06005EC3 RID: 24259 RVA: 0x001ADA30 File Offset: 0x001ABC30
		// (set) Token: 0x06005EC4 RID: 24260 RVA: 0x001ADA38 File Offset: 0x001ABC38
		[ProtoMember(34, IsRequired = true, Name = "DSUnchartedScoreVersion", DataFormat = DataFormat.TwosComplement)]
		public uint DSUnchartedScoreVersion
		{
			get
			{
				return this._DSUnchartedScoreVersion;
			}
			set
			{
				this._DSUnchartedScoreVersion = value;
			}
		}

		// Token: 0x17001823 RID: 6179
		// (get) Token: 0x06005EC5 RID: 24261 RVA: 0x001ADA44 File Offset: 0x001ABC44
		// (set) Token: 0x06005EC6 RID: 24262 RVA: 0x001ADA4C File Offset: 0x001ABC4C
		[ProtoMember(35, IsRequired = true, Name = "DSClimbTowerVersion", DataFormat = DataFormat.TwosComplement)]
		public uint DSClimbTowerVersion
		{
			get
			{
				return this._DSClimbTowerVersion;
			}
			set
			{
				this._DSClimbTowerVersion = value;
			}
		}

		// Token: 0x06005EC7 RID: 24263 RVA: 0x001ADA58 File Offset: 0x001ABC58
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005EC8 RID: 24264 RVA: 0x001ADA68 File Offset: 0x001ABC68
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

		// Token: 0x06005EC9 RID: 24265 RVA: 0x001ADB34 File Offset: 0x001ABD34
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(PlayerInfoInitReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040046C7 RID: 18119
		private uint _DSBasicInfoVersion;

		// Token: 0x040046C8 RID: 18120
		private uint _DSBagVersion;

		// Token: 0x040046C9 RID: 18121
		private uint _DSHeroVersion;

		// Token: 0x040046CA RID: 18122
		private uint _DSLevelVersion;

		// Token: 0x040046CB RID: 18123
		private uint _DSRiftVersion;

		// Token: 0x040046CC RID: 18124
		private uint _DSBattleVersion;

		// Token: 0x040046CD RID: 18125
		private uint _DSMailVersion;

		// Token: 0x040046CE RID: 18126
		private uint _DSFixedStoreVersion;

		// Token: 0x040046CF RID: 18127
		private uint _DSChatVersion;

		// Token: 0x040046D0 RID: 18128
		private uint _DSSelectCardVersion;

		// Token: 0x040046D1 RID: 18129
		private uint _DSMissionVersion;

		// Token: 0x040046D2 RID: 18130
		private uint _DSThearchyTrialVersion;

		// Token: 0x040046D3 RID: 18131
		private uint _DSAnikiGymVersion;

		// Token: 0x040046D4 RID: 18132
		private uint _DSTrainingGroundVersion;

		// Token: 0x040046D5 RID: 18133
		private uint _DSOperationalActivityVersion;

		// Token: 0x040046D6 RID: 18134
		private uint _ClientAnnouncementVersion;

		// Token: 0x040046D7 RID: 18135
		private uint _DSRandomStoreVersion;

		// Token: 0x040046D8 RID: 18136
		private uint _DSArenaVersion;

		// Token: 0x040046D9 RID: 18137
		private uint _DSSurveyVersion;

		// Token: 0x040046DA RID: 18138
		private uint _DSTreasureMapVersion;

		// Token: 0x040046DB RID: 18139
		private uint _DSMemoryCorridorVersion;

		// Token: 0x040046DC RID: 18140
		private uint _DSHeroDungeonVersion;

		// Token: 0x040046DD RID: 18141
		private uint _DSHerotrainningVersion;

		// Token: 0x040046DE RID: 18142
		private uint _DSHeroAssistantsVersion;

		// Token: 0x040046DF RID: 18143
		private uint _DSFriendVersion;

		// Token: 0x040046E0 RID: 18144
		private uint _DSHeroPhantomVersion;

		// Token: 0x040046E1 RID: 18145
		private uint _DSCooperateBattleVersion;

		// Token: 0x040046E2 RID: 18146
		private uint _DSNoviceVersion;

		// Token: 0x040046E3 RID: 18147
		private uint _DSRechargeStoreVersion;

		// Token: 0x040046E4 RID: 18148
		private uint _DSResourceVersion;

		// Token: 0x040046E5 RID: 18149
		private uint _DSRealTimePVPVersion;

		// Token: 0x040046E6 RID: 18150
		private uint _DSRaffleVersion;

		// Token: 0x040046E7 RID: 18151
		private uint _DSRiftStoreVersion;

		// Token: 0x040046E8 RID: 18152
		private uint _DSUnchartedScoreVersion;

		// Token: 0x040046E9 RID: 18153
		private uint _DSClimbTowerVersion;

		// Token: 0x040046EA RID: 18154
		private IExtension extensionObject;

		// Token: 0x040046EB RID: 18155
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040046EC RID: 18156
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040046ED RID: 18157
		private LuaFunction m_ctor_hotfix;
	}
}
