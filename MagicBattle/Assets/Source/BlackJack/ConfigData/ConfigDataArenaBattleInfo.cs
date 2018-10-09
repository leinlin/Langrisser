using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x020001FB RID: 507
	[ProtoContract(Name = "ConfigDataArenaBattleInfo")]
	[HotFix(true, m_isCtorOnly = true)]
	[CustomLuaClass]
	[Serializable]
	public class ConfigDataArenaBattleInfo : IExtensible
	{
		// Token: 0x06001D00 RID: 7424 RVA: 0x0009A340 File Offset: 0x00098540
		public ConfigDataArenaBattleInfo()
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

		// Token: 0x17000566 RID: 1382
		// (get) Token: 0x06001D01 RID: 7425 RVA: 0x0009A3E0 File Offset: 0x000985E0
		// (set) Token: 0x06001D02 RID: 7426 RVA: 0x0009A3E8 File Offset: 0x000985E8
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

		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x06001D03 RID: 7427 RVA: 0x0009A3F4 File Offset: 0x000985F4
		// (set) Token: 0x06001D04 RID: 7428 RVA: 0x0009A3FC File Offset: 0x000985FC
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

		// Token: 0x17000568 RID: 1384
		// (get) Token: 0x06001D05 RID: 7429 RVA: 0x0009A408 File Offset: 0x00098608
		// (set) Token: 0x06001D06 RID: 7430 RVA: 0x0009A410 File Offset: 0x00098610
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

		// Token: 0x17000569 RID: 1385
		// (get) Token: 0x06001D07 RID: 7431 RVA: 0x0009A41C File Offset: 0x0009861C
		// (set) Token: 0x06001D08 RID: 7432 RVA: 0x0009A424 File Offset: 0x00098624
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

		// Token: 0x1700056A RID: 1386
		// (get) Token: 0x06001D09 RID: 7433 RVA: 0x0009A430 File Offset: 0x00098630
		// (set) Token: 0x06001D0A RID: 7434 RVA: 0x0009A438 File Offset: 0x00098638
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

		// Token: 0x1700056B RID: 1387
		// (get) Token: 0x06001D0B RID: 7435 RVA: 0x0009A444 File Offset: 0x00098644
		// (set) Token: 0x06001D0C RID: 7436 RVA: 0x0009A44C File Offset: 0x0009864C
		[ProtoMember(7, IsRequired = true, Name = "Battlefield_ID", DataFormat = DataFormat.TwosComplement)]
		public int Battlefield_ID
		{
			get
			{
				return this._Battlefield_ID;
			}
			set
			{
				this._Battlefield_ID = value;
			}
		}

		// Token: 0x1700056C RID: 1388
		// (get) Token: 0x06001D0D RID: 7437 RVA: 0x0009A458 File Offset: 0x00098658
		// (set) Token: 0x06001D0E RID: 7438 RVA: 0x0009A460 File Offset: 0x00098660
		[ProtoMember(8, IsRequired = true, Name = "CameraX", DataFormat = DataFormat.TwosComplement)]
		public int CameraX
		{
			get
			{
				return this._CameraX;
			}
			set
			{
				this._CameraX = value;
			}
		}

		// Token: 0x1700056D RID: 1389
		// (get) Token: 0x06001D0F RID: 7439 RVA: 0x0009A46C File Offset: 0x0009866C
		// (set) Token: 0x06001D10 RID: 7440 RVA: 0x0009A474 File Offset: 0x00098674
		[ProtoMember(9, IsRequired = true, Name = "CameraY", DataFormat = DataFormat.TwosComplement)]
		public int CameraY
		{
			get
			{
				return this._CameraY;
			}
			set
			{
				this._CameraY = value;
			}
		}

		// Token: 0x1700056E RID: 1390
		// (get) Token: 0x06001D11 RID: 7441 RVA: 0x0009A480 File Offset: 0x00098680
		// (set) Token: 0x06001D12 RID: 7442 RVA: 0x0009A488 File Offset: 0x00098688
		[ProtoMember(10, IsRequired = true, Name = "DefendCameraX", DataFormat = DataFormat.TwosComplement)]
		public int DefendCameraX
		{
			get
			{
				return this._DefendCameraX;
			}
			set
			{
				this._DefendCameraX = value;
			}
		}

		// Token: 0x1700056F RID: 1391
		// (get) Token: 0x06001D13 RID: 7443 RVA: 0x0009A494 File Offset: 0x00098694
		// (set) Token: 0x06001D14 RID: 7444 RVA: 0x0009A49C File Offset: 0x0009869C
		[ProtoMember(11, IsRequired = true, Name = "DefendCameraY", DataFormat = DataFormat.TwosComplement)]
		public int DefendCameraY
		{
			get
			{
				return this._DefendCameraY;
			}
			set
			{
				this._DefendCameraY = value;
			}
		}

		// Token: 0x17000570 RID: 1392
		// (get) Token: 0x06001D15 RID: 7445 RVA: 0x0009A4A8 File Offset: 0x000986A8
		// (set) Token: 0x06001D16 RID: 7446 RVA: 0x0009A4B0 File Offset: 0x000986B0
		[ProtoMember(12, IsRequired = true, Name = "PrepareMusic", DataFormat = DataFormat.Default)]
		public string PrepareMusic
		{
			get
			{
				return this._PrepareMusic;
			}
			set
			{
				this._PrepareMusic = value;
			}
		}

		// Token: 0x17000571 RID: 1393
		// (get) Token: 0x06001D17 RID: 7447 RVA: 0x0009A4BC File Offset: 0x000986BC
		// (set) Token: 0x06001D18 RID: 7448 RVA: 0x0009A4C4 File Offset: 0x000986C4
		[ProtoMember(13, IsRequired = true, Name = "BattleMusic", DataFormat = DataFormat.Default)]
		public string BattleMusic
		{
			get
			{
				return this._BattleMusic;
			}
			set
			{
				this._BattleMusic = value;
			}
		}

		// Token: 0x17000572 RID: 1394
		// (get) Token: 0x06001D19 RID: 7449 RVA: 0x0009A4D0 File Offset: 0x000986D0
		// (set) Token: 0x06001D1A RID: 7450 RVA: 0x0009A4D8 File Offset: 0x000986D8
		[ProtoMember(14, IsRequired = true, Name = "DefendBattleMusic", DataFormat = DataFormat.Default)]
		public string DefendBattleMusic
		{
			get
			{
				return this._DefendBattleMusic;
			}
			set
			{
				this._DefendBattleMusic = value;
			}
		}

		// Token: 0x17000573 RID: 1395
		// (get) Token: 0x06001D1B RID: 7451 RVA: 0x0009A4E4 File Offset: 0x000986E4
		// (set) Token: 0x06001D1C RID: 7452 RVA: 0x0009A4EC File Offset: 0x000986EC
		[ProtoMember(15, IsRequired = true, Name = "AttackNumber", DataFormat = DataFormat.TwosComplement)]
		public int AttackNumber
		{
			get
			{
				return this._AttackNumber;
			}
			set
			{
				this._AttackNumber = value;
			}
		}

		// Token: 0x17000574 RID: 1396
		// (get) Token: 0x06001D1D RID: 7453 RVA: 0x0009A4F8 File Offset: 0x000986F8
		[ProtoMember(16, Name = "AttackPositions", DataFormat = DataFormat.Default)]
		public List<ParamPosition> AttackPositions
		{
			get
			{
				return this._AttackPositions;
			}
		}

		// Token: 0x17000575 RID: 1397
		// (get) Token: 0x06001D1E RID: 7454 RVA: 0x0009A500 File Offset: 0x00098700
		[ProtoMember(17, Name = "AttackDirs", DataFormat = DataFormat.TwosComplement)]
		public List<int> AttackDirs
		{
			get
			{
				return this._AttackDirs;
			}
		}

		// Token: 0x17000576 RID: 1398
		// (get) Token: 0x06001D1F RID: 7455 RVA: 0x0009A508 File Offset: 0x00098708
		// (set) Token: 0x06001D20 RID: 7456 RVA: 0x0009A510 File Offset: 0x00098710
		[ProtoMember(18, IsRequired = true, Name = "DefendNumber", DataFormat = DataFormat.TwosComplement)]
		public int DefendNumber
		{
			get
			{
				return this._DefendNumber;
			}
			set
			{
				this._DefendNumber = value;
			}
		}

		// Token: 0x17000577 RID: 1399
		// (get) Token: 0x06001D21 RID: 7457 RVA: 0x0009A51C File Offset: 0x0009871C
		[ProtoMember(19, Name = "DefendPositions", DataFormat = DataFormat.Default)]
		public List<ParamPosition> DefendPositions
		{
			get
			{
				return this._DefendPositions;
			}
		}

		// Token: 0x17000578 RID: 1400
		// (get) Token: 0x06001D22 RID: 7458 RVA: 0x0009A524 File Offset: 0x00098724
		[ProtoMember(20, Name = "DefendDirs", DataFormat = DataFormat.TwosComplement)]
		public List<int> DefendDirs
		{
			get
			{
				return this._DefendDirs;
			}
		}

		// Token: 0x17000579 RID: 1401
		// (get) Token: 0x06001D23 RID: 7459 RVA: 0x0009A52C File Offset: 0x0009872C
		[ProtoMember(21, Name = "EventTriggers_ID", DataFormat = DataFormat.TwosComplement)]
		public List<int> EventTriggers_ID
		{
			get
			{
				return this._EventTriggers_ID;
			}
		}

		// Token: 0x1700057A RID: 1402
		// (get) Token: 0x06001D24 RID: 7460 RVA: 0x0009A534 File Offset: 0x00098734
		// (set) Token: 0x06001D25 RID: 7461 RVA: 0x0009A53C File Offset: 0x0009873C
		[ProtoMember(22, IsRequired = true, Name = "Image", DataFormat = DataFormat.Default)]
		public string Image
		{
			get
			{
				return this._Image;
			}
			set
			{
				this._Image = value;
			}
		}

		// Token: 0x06001D26 RID: 7462 RVA: 0x0009A548 File Offset: 0x00098748
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06001D27 RID: 7463 RVA: 0x0009A558 File Offset: 0x00098758
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

		// Token: 0x06001D28 RID: 7464 RVA: 0x0009A624 File Offset: 0x00098824
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataArenaBattleInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400114F RID: 4431
		private int _ID;

		// Token: 0x04001150 RID: 4432
		private string _Name;

		// Token: 0x04001151 RID: 4433
		private string _NameStrKey;

		// Token: 0x04001152 RID: 4434
		private string _Desc;

		// Token: 0x04001153 RID: 4435
		private string _DescStrKey;

		// Token: 0x04001154 RID: 4436
		private int _Battlefield_ID;

		// Token: 0x04001155 RID: 4437
		private int _CameraX;

		// Token: 0x04001156 RID: 4438
		private int _CameraY;

		// Token: 0x04001157 RID: 4439
		private int _DefendCameraX;

		// Token: 0x04001158 RID: 4440
		private int _DefendCameraY;

		// Token: 0x04001159 RID: 4441
		private string _PrepareMusic;

		// Token: 0x0400115A RID: 4442
		private string _BattleMusic;

		// Token: 0x0400115B RID: 4443
		private string _DefendBattleMusic;

		// Token: 0x0400115C RID: 4444
		private int _AttackNumber;

		// Token: 0x0400115D RID: 4445
		private readonly List<ParamPosition> _AttackPositions = new List<ParamPosition>();

		// Token: 0x0400115E RID: 4446
		private readonly List<int> _AttackDirs = new List<int>();

		// Token: 0x0400115F RID: 4447
		private int _DefendNumber;

		// Token: 0x04001160 RID: 4448
		private readonly List<ParamPosition> _DefendPositions = new List<ParamPosition>();

		// Token: 0x04001161 RID: 4449
		private readonly List<int> _DefendDirs = new List<int>();

		// Token: 0x04001162 RID: 4450
		private readonly List<int> _EventTriggers_ID = new List<int>();

		// Token: 0x04001163 RID: 4451
		private string _Image;

		// Token: 0x04001164 RID: 4452
		private IExtension extensionObject;

		// Token: 0x04001165 RID: 4453
		public ConfigDataBattlefieldInfo m_battlefieldInfo;

		// Token: 0x04001166 RID: 4454
		public ConfigDataBattleEventTriggerInfo[] m_battleEventTriggerInfos;

		// Token: 0x04001167 RID: 4455
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04001168 RID: 4456
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04001169 RID: 4457
		private LuaFunction m_ctor_hotfix;
	}
}
