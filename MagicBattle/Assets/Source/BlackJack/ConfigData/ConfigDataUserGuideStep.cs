using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x020002B2 RID: 690
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ConfigDataUserGuideStep")]
	[CustomLuaClass]
	[Serializable]
	public class ConfigDataUserGuideStep : IExtensible
	{
		// Token: 0x06002D6E RID: 11630 RVA: 0x000B70A0 File Offset: 0x000B52A0
		public ConfigDataUserGuideStep()
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

		// Token: 0x17000CB5 RID: 3253
		// (get) Token: 0x06002D6F RID: 11631 RVA: 0x000B711C File Offset: 0x000B531C
		// (set) Token: 0x06002D70 RID: 11632 RVA: 0x000B7124 File Offset: 0x000B5324
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

		// Token: 0x17000CB6 RID: 3254
		// (get) Token: 0x06002D71 RID: 11633 RVA: 0x000B7130 File Offset: 0x000B5330
		// (set) Token: 0x06002D72 RID: 11634 RVA: 0x000B7138 File Offset: 0x000B5338
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

		// Token: 0x17000CB7 RID: 3255
		// (get) Token: 0x06002D73 RID: 11635 RVA: 0x000B7144 File Offset: 0x000B5344
		// (set) Token: 0x06002D74 RID: 11636 RVA: 0x000B714C File Offset: 0x000B534C
		[ProtoMember(4, IsRequired = true, Name = "NextUserGuide_ID", DataFormat = DataFormat.TwosComplement)]
		public int NextUserGuide_ID
		{
			get
			{
				return this._NextUserGuide_ID;
			}
			set
			{
				this._NextUserGuide_ID = value;
			}
		}

		// Token: 0x17000CB8 RID: 3256
		// (get) Token: 0x06002D75 RID: 11637 RVA: 0x000B7158 File Offset: 0x000B5358
		[ProtoMember(5, Name = "NextTrigger", DataFormat = DataFormat.TwosComplement)]
		public List<UserGuideTrigger> NextTrigger
		{
			get
			{
				return this._NextTrigger;
			}
		}

		// Token: 0x17000CB9 RID: 3257
		// (get) Token: 0x06002D76 RID: 11638 RVA: 0x000B7160 File Offset: 0x000B5360
		[ProtoMember(6, Name = "NTParam", DataFormat = DataFormat.Default)]
		public List<string> NTParam
		{
			get
			{
				return this._NTParam;
			}
		}

		// Token: 0x17000CBA RID: 3258
		// (get) Token: 0x06002D77 RID: 11639 RVA: 0x000B7168 File Offset: 0x000B5368
		// (set) Token: 0x06002D78 RID: 11640 RVA: 0x000B7170 File Offset: 0x000B5370
		[ProtoMember(7, IsRequired = true, Name = "UserGuideDialog_ID", DataFormat = DataFormat.TwosComplement)]
		public int UserGuideDialog_ID
		{
			get
			{
				return this._UserGuideDialog_ID;
			}
			set
			{
				this._UserGuideDialog_ID = value;
			}
		}

		// Token: 0x17000CBB RID: 3259
		// (get) Token: 0x06002D79 RID: 11641 RVA: 0x000B717C File Offset: 0x000B537C
		// (set) Token: 0x06002D7A RID: 11642 RVA: 0x000B7184 File Offset: 0x000B5384
		[ProtoMember(8, IsRequired = true, Name = "BattleDialog_ID", DataFormat = DataFormat.TwosComplement)]
		public int BattleDialog_ID
		{
			get
			{
				return this._BattleDialog_ID;
			}
			set
			{
				this._BattleDialog_ID = value;
			}
		}

		// Token: 0x17000CBC RID: 3260
		// (get) Token: 0x06002D7B RID: 11643 RVA: 0x000B7190 File Offset: 0x000B5390
		// (set) Token: 0x06002D7C RID: 11644 RVA: 0x000B7198 File Offset: 0x000B5398
		[ProtoMember(9, IsRequired = true, Name = "BattleMapX", DataFormat = DataFormat.TwosComplement)]
		public int BattleMapX
		{
			get
			{
				return this._BattleMapX;
			}
			set
			{
				this._BattleMapX = value;
			}
		}

		// Token: 0x17000CBD RID: 3261
		// (get) Token: 0x06002D7D RID: 11645 RVA: 0x000B71A4 File Offset: 0x000B53A4
		// (set) Token: 0x06002D7E RID: 11646 RVA: 0x000B71AC File Offset: 0x000B53AC
		[ProtoMember(10, IsRequired = true, Name = "BattleMapY", DataFormat = DataFormat.TwosComplement)]
		public int BattleMapY
		{
			get
			{
				return this._BattleMapY;
			}
			set
			{
				this._BattleMapY = value;
			}
		}

		// Token: 0x17000CBE RID: 3262
		// (get) Token: 0x06002D7F RID: 11647 RVA: 0x000B71B8 File Offset: 0x000B53B8
		// (set) Token: 0x06002D80 RID: 11648 RVA: 0x000B71C0 File Offset: 0x000B53C0
		[ProtoMember(11, IsRequired = true, Name = "ClickObjectPath", DataFormat = DataFormat.Default)]
		public string ClickObjectPath
		{
			get
			{
				return this._ClickObjectPath;
			}
			set
			{
				this._ClickObjectPath = value;
			}
		}

		// Token: 0x17000CBF RID: 3263
		// (get) Token: 0x06002D81 RID: 11649 RVA: 0x000B71CC File Offset: 0x000B53CC
		// (set) Token: 0x06002D82 RID: 11650 RVA: 0x000B71D4 File Offset: 0x000B53D4
		[ProtoMember(12, IsRequired = true, Name = "UserGuideTips", DataFormat = DataFormat.Default)]
		public string UserGuideTips
		{
			get
			{
				return this._UserGuideTips;
			}
			set
			{
				this._UserGuideTips = value;
			}
		}

		// Token: 0x17000CC0 RID: 3264
		// (get) Token: 0x06002D83 RID: 11651 RVA: 0x000B71E0 File Offset: 0x000B53E0
		// (set) Token: 0x06002D84 RID: 11652 RVA: 0x000B71E8 File Offset: 0x000B53E8
		[ProtoMember(13, IsRequired = true, Name = "FunctionOpenText", DataFormat = DataFormat.Default)]
		public string FunctionOpenText
		{
			get
			{
				return this._FunctionOpenText;
			}
			set
			{
				this._FunctionOpenText = value;
			}
		}

		// Token: 0x17000CC1 RID: 3265
		// (get) Token: 0x06002D85 RID: 11653 RVA: 0x000B71F4 File Offset: 0x000B53F4
		// (set) Token: 0x06002D86 RID: 11654 RVA: 0x000B71FC File Offset: 0x000B53FC
		[ProtoMember(14, IsRequired = true, Name = "FunctionOpenPrefab", DataFormat = DataFormat.Default)]
		public string FunctionOpenPrefab
		{
			get
			{
				return this._FunctionOpenPrefab;
			}
			set
			{
				this._FunctionOpenPrefab = value;
			}
		}

		// Token: 0x17000CC2 RID: 3266
		// (get) Token: 0x06002D87 RID: 11655 RVA: 0x000B7208 File Offset: 0x000B5408
		// (set) Token: 0x06002D88 RID: 11656 RVA: 0x000B7210 File Offset: 0x000B5410
		[ProtoMember(15, IsRequired = true, Name = "PagesPrefab", DataFormat = DataFormat.Default)]
		public string PagesPrefab
		{
			get
			{
				return this._PagesPrefab;
			}
			set
			{
				this._PagesPrefab = value;
			}
		}

		// Token: 0x17000CC3 RID: 3267
		// (get) Token: 0x06002D89 RID: 11657 RVA: 0x000B721C File Offset: 0x000B541C
		// (set) Token: 0x06002D8A RID: 11658 RVA: 0x000B7224 File Offset: 0x000B5424
		[ProtoMember(16, IsRequired = true, Name = "StartAction1", DataFormat = DataFormat.TwosComplement)]
		public UserGuideAction StartAction1
		{
			get
			{
				return this._StartAction1;
			}
			set
			{
				this._StartAction1 = value;
			}
		}

		// Token: 0x17000CC4 RID: 3268
		// (get) Token: 0x06002D8B RID: 11659 RVA: 0x000B7230 File Offset: 0x000B5430
		// (set) Token: 0x06002D8C RID: 11660 RVA: 0x000B7238 File Offset: 0x000B5438
		[ProtoMember(17, IsRequired = true, Name = "SAParam1", DataFormat = DataFormat.Default)]
		public string SAParam1
		{
			get
			{
				return this._SAParam1;
			}
			set
			{
				this._SAParam1 = value;
			}
		}

		// Token: 0x17000CC5 RID: 3269
		// (get) Token: 0x06002D8D RID: 11661 RVA: 0x000B7244 File Offset: 0x000B5444
		// (set) Token: 0x06002D8E RID: 11662 RVA: 0x000B724C File Offset: 0x000B544C
		[ProtoMember(18, IsRequired = true, Name = "StartAction2", DataFormat = DataFormat.TwosComplement)]
		public UserGuideAction StartAction2
		{
			get
			{
				return this._StartAction2;
			}
			set
			{
				this._StartAction2 = value;
			}
		}

		// Token: 0x17000CC6 RID: 3270
		// (get) Token: 0x06002D8F RID: 11663 RVA: 0x000B7258 File Offset: 0x000B5458
		// (set) Token: 0x06002D90 RID: 11664 RVA: 0x000B7260 File Offset: 0x000B5460
		[ProtoMember(19, IsRequired = true, Name = "SAParam2", DataFormat = DataFormat.Default)]
		public string SAParam2
		{
			get
			{
				return this._SAParam2;
			}
			set
			{
				this._SAParam2 = value;
			}
		}

		// Token: 0x17000CC7 RID: 3271
		// (get) Token: 0x06002D91 RID: 11665 RVA: 0x000B726C File Offset: 0x000B546C
		// (set) Token: 0x06002D92 RID: 11666 RVA: 0x000B7274 File Offset: 0x000B5474
		[ProtoMember(20, IsRequired = true, Name = "StartAction3", DataFormat = DataFormat.TwosComplement)]
		public UserGuideAction StartAction3
		{
			get
			{
				return this._StartAction3;
			}
			set
			{
				this._StartAction3 = value;
			}
		}

		// Token: 0x17000CC8 RID: 3272
		// (get) Token: 0x06002D93 RID: 11667 RVA: 0x000B7280 File Offset: 0x000B5480
		// (set) Token: 0x06002D94 RID: 11668 RVA: 0x000B7288 File Offset: 0x000B5488
		[ProtoMember(21, IsRequired = true, Name = "SAParam3", DataFormat = DataFormat.Default)]
		public string SAParam3
		{
			get
			{
				return this._SAParam3;
			}
			set
			{
				this._SAParam3 = value;
			}
		}

		// Token: 0x06002D95 RID: 11669 RVA: 0x000B7294 File Offset: 0x000B5494
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002D96 RID: 11670 RVA: 0x000B72A4 File Offset: 0x000B54A4
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

		// Token: 0x06002D97 RID: 11671 RVA: 0x000B7370 File Offset: 0x000B5570
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataUserGuideStep));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04001C17 RID: 7191
		private int _ID;

		// Token: 0x04001C18 RID: 7192
		private string _Name;

		// Token: 0x04001C19 RID: 7193
		private int _NextUserGuide_ID;

		// Token: 0x04001C1A RID: 7194
		private readonly List<UserGuideTrigger> _NextTrigger = new List<UserGuideTrigger>();

		// Token: 0x04001C1B RID: 7195
		private readonly List<string> _NTParam = new List<string>();

		// Token: 0x04001C1C RID: 7196
		private int _UserGuideDialog_ID;

		// Token: 0x04001C1D RID: 7197
		private int _BattleDialog_ID;

		// Token: 0x04001C1E RID: 7198
		private int _BattleMapX;

		// Token: 0x04001C1F RID: 7199
		private int _BattleMapY;

		// Token: 0x04001C20 RID: 7200
		private string _ClickObjectPath;

		// Token: 0x04001C21 RID: 7201
		private string _UserGuideTips;

		// Token: 0x04001C22 RID: 7202
		private string _FunctionOpenText;

		// Token: 0x04001C23 RID: 7203
		private string _FunctionOpenPrefab;

		// Token: 0x04001C24 RID: 7204
		private string _PagesPrefab;

		// Token: 0x04001C25 RID: 7205
		private UserGuideAction _StartAction1;

		// Token: 0x04001C26 RID: 7206
		private string _SAParam1;

		// Token: 0x04001C27 RID: 7207
		private UserGuideAction _StartAction2;

		// Token: 0x04001C28 RID: 7208
		private string _SAParam2;

		// Token: 0x04001C29 RID: 7209
		private UserGuideAction _StartAction3;

		// Token: 0x04001C2A RID: 7210
		private string _SAParam3;

		// Token: 0x04001C2B RID: 7211
		private IExtension extensionObject;

		// Token: 0x04001C2C RID: 7212
		public ConfigDataUserGuideStep m_nextUserGuideInfo;

		// Token: 0x04001C2D RID: 7213
		public ConfigDataBattleDialogInfo m_battleDialogInfo;

		// Token: 0x04001C2E RID: 7214
		public ConfigDataUserGuideDialogInfo m_userGuideDialogInfo;

		// Token: 0x04001C2F RID: 7215
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04001C30 RID: 7216
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04001C31 RID: 7217
		private LuaFunction m_ctor_hotfix;
	}
}
