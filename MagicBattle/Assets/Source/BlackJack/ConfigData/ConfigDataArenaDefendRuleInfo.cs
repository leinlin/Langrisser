using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x020001FC RID: 508
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ConfigDataArenaDefendRuleInfo")]
	[CustomLuaClass]
	[Serializable]
	public class ConfigDataArenaDefendRuleInfo : IExtensible
	{
		// Token: 0x06001D29 RID: 7465 RVA: 0x0009A68C File Offset: 0x0009888C
		public ConfigDataArenaDefendRuleInfo()
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

		// Token: 0x1700057B RID: 1403
		// (get) Token: 0x06001D2A RID: 7466 RVA: 0x0009A708 File Offset: 0x00098908
		// (set) Token: 0x06001D2B RID: 7467 RVA: 0x0009A710 File Offset: 0x00098910
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

		// Token: 0x1700057C RID: 1404
		// (get) Token: 0x06001D2C RID: 7468 RVA: 0x0009A71C File Offset: 0x0009891C
		// (set) Token: 0x06001D2D RID: 7469 RVA: 0x0009A724 File Offset: 0x00098924
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

		// Token: 0x1700057D RID: 1405
		// (get) Token: 0x06001D2E RID: 7470 RVA: 0x0009A730 File Offset: 0x00098930
		// (set) Token: 0x06001D2F RID: 7471 RVA: 0x0009A738 File Offset: 0x00098938
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

		// Token: 0x1700057E RID: 1406
		// (get) Token: 0x06001D30 RID: 7472 RVA: 0x0009A744 File Offset: 0x00098944
		// (set) Token: 0x06001D31 RID: 7473 RVA: 0x0009A74C File Offset: 0x0009894C
		[ProtoMember(5, IsRequired = true, Name = "DefendWinDesc", DataFormat = DataFormat.Default)]
		public string DefendWinDesc
		{
			get
			{
				return this._DefendWinDesc;
			}
			set
			{
				this._DefendWinDesc = value;
			}
		}

		// Token: 0x1700057F RID: 1407
		// (get) Token: 0x06001D32 RID: 7474 RVA: 0x0009A758 File Offset: 0x00098958
		// (set) Token: 0x06001D33 RID: 7475 RVA: 0x0009A760 File Offset: 0x00098960
		[ProtoMember(6, IsRequired = true, Name = "DefendWinDescStrKey", DataFormat = DataFormat.Default)]
		public string DefendWinDescStrKey
		{
			get
			{
				return this._DefendWinDescStrKey;
			}
			set
			{
				this._DefendWinDescStrKey = value;
			}
		}

		// Token: 0x17000580 RID: 1408
		// (get) Token: 0x06001D34 RID: 7476 RVA: 0x0009A76C File Offset: 0x0009896C
		// (set) Token: 0x06001D35 RID: 7477 RVA: 0x0009A774 File Offset: 0x00098974
		[ProtoMember(7, IsRequired = true, Name = "DefendLoseDesc", DataFormat = DataFormat.Default)]
		public string DefendLoseDesc
		{
			get
			{
				return this._DefendLoseDesc;
			}
			set
			{
				this._DefendLoseDesc = value;
			}
		}

		// Token: 0x17000581 RID: 1409
		// (get) Token: 0x06001D36 RID: 7478 RVA: 0x0009A780 File Offset: 0x00098980
		// (set) Token: 0x06001D37 RID: 7479 RVA: 0x0009A788 File Offset: 0x00098988
		[ProtoMember(8, IsRequired = true, Name = "DefendLoseDescStrKey", DataFormat = DataFormat.Default)]
		public string DefendLoseDescStrKey
		{
			get
			{
				return this._DefendLoseDescStrKey;
			}
			set
			{
				this._DefendLoseDescStrKey = value;
			}
		}

		// Token: 0x17000582 RID: 1410
		// (get) Token: 0x06001D38 RID: 7480 RVA: 0x0009A794 File Offset: 0x00098994
		// (set) Token: 0x06001D39 RID: 7481 RVA: 0x0009A79C File Offset: 0x0009899C
		[ProtoMember(9, IsRequired = true, Name = "WinDesc", DataFormat = DataFormat.Default)]
		public string WinDesc
		{
			get
			{
				return this._WinDesc;
			}
			set
			{
				this._WinDesc = value;
			}
		}

		// Token: 0x17000583 RID: 1411
		// (get) Token: 0x06001D3A RID: 7482 RVA: 0x0009A7A8 File Offset: 0x000989A8
		// (set) Token: 0x06001D3B RID: 7483 RVA: 0x0009A7B0 File Offset: 0x000989B0
		[ProtoMember(10, IsRequired = true, Name = "WinDescStrKey", DataFormat = DataFormat.Default)]
		public string WinDescStrKey
		{
			get
			{
				return this._WinDescStrKey;
			}
			set
			{
				this._WinDescStrKey = value;
			}
		}

		// Token: 0x17000584 RID: 1412
		// (get) Token: 0x06001D3C RID: 7484 RVA: 0x0009A7BC File Offset: 0x000989BC
		// (set) Token: 0x06001D3D RID: 7485 RVA: 0x0009A7C4 File Offset: 0x000989C4
		[ProtoMember(11, IsRequired = true, Name = "LoseDesc", DataFormat = DataFormat.Default)]
		public string LoseDesc
		{
			get
			{
				return this._LoseDesc;
			}
			set
			{
				this._LoseDesc = value;
			}
		}

		// Token: 0x17000585 RID: 1413
		// (get) Token: 0x06001D3E RID: 7486 RVA: 0x0009A7D0 File Offset: 0x000989D0
		// (set) Token: 0x06001D3F RID: 7487 RVA: 0x0009A7D8 File Offset: 0x000989D8
		[ProtoMember(12, IsRequired = true, Name = "LoseDescStrKey", DataFormat = DataFormat.Default)]
		public string LoseDescStrKey
		{
			get
			{
				return this._LoseDescStrKey;
			}
			set
			{
				this._LoseDescStrKey = value;
			}
		}

		// Token: 0x17000586 RID: 1414
		// (get) Token: 0x06001D40 RID: 7488 RVA: 0x0009A7E4 File Offset: 0x000989E4
		// (set) Token: 0x06001D41 RID: 7489 RVA: 0x0009A7EC File Offset: 0x000989EC
		[ProtoMember(13, IsRequired = true, Name = "TurnMax", DataFormat = DataFormat.TwosComplement)]
		public int TurnMax
		{
			get
			{
				return this._TurnMax;
			}
			set
			{
				this._TurnMax = value;
			}
		}

		// Token: 0x17000587 RID: 1415
		// (get) Token: 0x06001D42 RID: 7490 RVA: 0x0009A7F8 File Offset: 0x000989F8
		[ProtoMember(14, Name = "WinConditions_ID", DataFormat = DataFormat.TwosComplement)]
		public List<int> WinConditions_ID
		{
			get
			{
				return this._WinConditions_ID;
			}
		}

		// Token: 0x17000588 RID: 1416
		// (get) Token: 0x06001D43 RID: 7491 RVA: 0x0009A800 File Offset: 0x00098A00
		[ProtoMember(15, Name = "LoseConditions_ID", DataFormat = DataFormat.TwosComplement)]
		public List<int> LoseConditions_ID
		{
			get
			{
				return this._LoseConditions_ID;
			}
		}

		// Token: 0x17000589 RID: 1417
		// (get) Token: 0x06001D44 RID: 7492 RVA: 0x0009A808 File Offset: 0x00098A08
		// (set) Token: 0x06001D45 RID: 7493 RVA: 0x0009A810 File Offset: 0x00098A10
		[ProtoMember(16, IsRequired = true, Name = "Icon", DataFormat = DataFormat.Default)]
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

		// Token: 0x06001D46 RID: 7494 RVA: 0x0009A81C File Offset: 0x00098A1C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06001D47 RID: 7495 RVA: 0x0009A82C File Offset: 0x00098A2C
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

		// Token: 0x06001D48 RID: 7496 RVA: 0x0009A8F8 File Offset: 0x00098AF8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataArenaDefendRuleInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400116A RID: 4458
		private int _ID;

		// Token: 0x0400116B RID: 4459
		private string _Name;

		// Token: 0x0400116C RID: 4460
		private string _NameStrKey;

		// Token: 0x0400116D RID: 4461
		private string _DefendWinDesc;

		// Token: 0x0400116E RID: 4462
		private string _DefendWinDescStrKey;

		// Token: 0x0400116F RID: 4463
		private string _DefendLoseDesc;

		// Token: 0x04001170 RID: 4464
		private string _DefendLoseDescStrKey;

		// Token: 0x04001171 RID: 4465
		private string _WinDesc;

		// Token: 0x04001172 RID: 4466
		private string _WinDescStrKey;

		// Token: 0x04001173 RID: 4467
		private string _LoseDesc;

		// Token: 0x04001174 RID: 4468
		private string _LoseDescStrKey;

		// Token: 0x04001175 RID: 4469
		private int _TurnMax;

		// Token: 0x04001176 RID: 4470
		private readonly List<int> _WinConditions_ID = new List<int>();

		// Token: 0x04001177 RID: 4471
		private readonly List<int> _LoseConditions_ID = new List<int>();

		// Token: 0x04001178 RID: 4472
		private string _Icon;

		// Token: 0x04001179 RID: 4473
		private IExtension extensionObject;

		// Token: 0x0400117A RID: 4474
		public ConfigDataBattleWinConditionInfo[] m_battleWinConditionInfos;

		// Token: 0x0400117B RID: 4475
		public ConfigDataBattleLoseConditionInfo[] m_battleLoseConditionInfos;

		// Token: 0x0400117C RID: 4476
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400117D RID: 4477
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400117E RID: 4478
		private LuaFunction m_ctor_hotfix;
	}
}
