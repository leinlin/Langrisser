using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x020001FA RID: 506
	[CustomLuaClass]
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ConfigDataAnikiLevelInfo")]
	[Serializable]
	public class ConfigDataAnikiLevelInfo : IExtensible
	{
		// Token: 0x06001CD2 RID: 7378 RVA: 0x00099FF0 File Offset: 0x000981F0
		public ConfigDataAnikiLevelInfo()
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

		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x06001CD3 RID: 7379 RVA: 0x0009A058 File Offset: 0x00098258
		// (set) Token: 0x06001CD4 RID: 7380 RVA: 0x0009A060 File Offset: 0x00098260
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

		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x06001CD5 RID: 7381 RVA: 0x0009A06C File Offset: 0x0009826C
		// (set) Token: 0x06001CD6 RID: 7382 RVA: 0x0009A074 File Offset: 0x00098274
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

		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x06001CD7 RID: 7383 RVA: 0x0009A080 File Offset: 0x00098280
		// (set) Token: 0x06001CD8 RID: 7384 RVA: 0x0009A088 File Offset: 0x00098288
		[ProtoMember(4, IsRequired = true, Name = "TeamName", DataFormat = DataFormat.Default)]
		public string TeamName
		{
			get
			{
				return this._TeamName;
			}
			set
			{
				this._TeamName = value;
			}
		}

		// Token: 0x17000554 RID: 1364
		// (get) Token: 0x06001CD9 RID: 7385 RVA: 0x0009A094 File Offset: 0x00098294
		// (set) Token: 0x06001CDA RID: 7386 RVA: 0x0009A09C File Offset: 0x0009829C
		[ProtoMember(5, IsRequired = true, Name = "PreLevel", DataFormat = DataFormat.TwosComplement)]
		public int PreLevel
		{
			get
			{
				return this._PreLevel;
			}
			set
			{
				this._PreLevel = value;
			}
		}

		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x06001CDB RID: 7387 RVA: 0x0009A0A8 File Offset: 0x000982A8
		// (set) Token: 0x06001CDC RID: 7388 RVA: 0x0009A0B0 File Offset: 0x000982B0
		[ProtoMember(6, IsRequired = true, Name = "TicketCost", DataFormat = DataFormat.TwosComplement)]
		public int TicketCost
		{
			get
			{
				return this._TicketCost;
			}
			set
			{
				this._TicketCost = value;
			}
		}

		// Token: 0x17000556 RID: 1366
		// (get) Token: 0x06001CDD RID: 7389 RVA: 0x0009A0BC File Offset: 0x000982BC
		// (set) Token: 0x06001CDE RID: 7390 RVA: 0x0009A0C4 File Offset: 0x000982C4
		[ProtoMember(7, IsRequired = true, Name = "EnergySuccess", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17000557 RID: 1367
		// (get) Token: 0x06001CDF RID: 7391 RVA: 0x0009A0D0 File Offset: 0x000982D0
		// (set) Token: 0x06001CE0 RID: 7392 RVA: 0x0009A0D8 File Offset: 0x000982D8
		[ProtoMember(8, IsRequired = true, Name = "EnergyFail", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17000558 RID: 1368
		// (get) Token: 0x06001CE1 RID: 7393 RVA: 0x0009A0E4 File Offset: 0x000982E4
		// (set) Token: 0x06001CE2 RID: 7394 RVA: 0x0009A0EC File Offset: 0x000982EC
		[ProtoMember(9, IsRequired = true, Name = "TeamEnergyCost", DataFormat = DataFormat.TwosComplement)]
		public int TeamEnergyCost
		{
			get
			{
				return this._TeamEnergyCost;
			}
			set
			{
				this._TeamEnergyCost = value;
			}
		}

		// Token: 0x17000559 RID: 1369
		// (get) Token: 0x06001CE3 RID: 7395 RVA: 0x0009A0F8 File Offset: 0x000982F8
		// (set) Token: 0x06001CE4 RID: 7396 RVA: 0x0009A100 File Offset: 0x00098300
		[ProtoMember(10, IsRequired = true, Name = "MonsterLevel", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x1700055A RID: 1370
		// (get) Token: 0x06001CE5 RID: 7397 RVA: 0x0009A10C File Offset: 0x0009830C
		// (set) Token: 0x06001CE6 RID: 7398 RVA: 0x0009A114 File Offset: 0x00098314
		[ProtoMember(11, IsRequired = true, Name = "Battle_ID", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x1700055B RID: 1371
		// (get) Token: 0x06001CE7 RID: 7399 RVA: 0x0009A120 File Offset: 0x00098320
		// (set) Token: 0x06001CE8 RID: 7400 RVA: 0x0009A128 File Offset: 0x00098328
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

		// Token: 0x1700055C RID: 1372
		// (get) Token: 0x06001CE9 RID: 7401 RVA: 0x0009A134 File Offset: 0x00098334
		// (set) Token: 0x06001CEA RID: 7402 RVA: 0x0009A13C File Offset: 0x0009833C
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

		// Token: 0x1700055D RID: 1373
		// (get) Token: 0x06001CEB RID: 7403 RVA: 0x0009A148 File Offset: 0x00098348
		// (set) Token: 0x06001CEC RID: 7404 RVA: 0x0009A150 File Offset: 0x00098350
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

		// Token: 0x1700055E RID: 1374
		// (get) Token: 0x06001CED RID: 7405 RVA: 0x0009A15C File Offset: 0x0009835C
		// (set) Token: 0x06001CEE RID: 7406 RVA: 0x0009A164 File Offset: 0x00098364
		[ProtoMember(15, IsRequired = true, Name = "Drop_ID", DataFormat = DataFormat.TwosComplement)]
		public int Drop_ID
		{
			get
			{
				return this._Drop_ID;
			}
			set
			{
				this._Drop_ID = value;
			}
		}

		// Token: 0x1700055F RID: 1375
		// (get) Token: 0x06001CEF RID: 7407 RVA: 0x0009A170 File Offset: 0x00098370
		// (set) Token: 0x06001CF0 RID: 7408 RVA: 0x0009A178 File Offset: 0x00098378
		[ProtoMember(16, IsRequired = true, Name = "TeamDrop_ID", DataFormat = DataFormat.TwosComplement)]
		public int TeamDrop_ID
		{
			get
			{
				return this._TeamDrop_ID;
			}
			set
			{
				this._TeamDrop_ID = value;
			}
		}

		// Token: 0x17000560 RID: 1376
		// (get) Token: 0x06001CF1 RID: 7409 RVA: 0x0009A184 File Offset: 0x00098384
		// (set) Token: 0x06001CF2 RID: 7410 RVA: 0x0009A18C File Offset: 0x0009838C
		[ProtoMember(17, IsRequired = true, Name = "OperationalActivityDrop_ID", DataFormat = DataFormat.TwosComplement)]
		public int OperationalActivityDrop_ID
		{
			get
			{
				return this._OperationalActivityDrop_ID;
			}
			set
			{
				this._OperationalActivityDrop_ID = value;
			}
		}

		// Token: 0x17000561 RID: 1377
		// (get) Token: 0x06001CF3 RID: 7411 RVA: 0x0009A198 File Offset: 0x00098398
		// (set) Token: 0x06001CF4 RID: 7412 RVA: 0x0009A1A0 File Offset: 0x000983A0
		[ProtoMember(18, IsRequired = true, Name = "DayBonusDrop_ID", DataFormat = DataFormat.TwosComplement)]
		public int DayBonusDrop_ID
		{
			get
			{
				return this._DayBonusDrop_ID;
			}
			set
			{
				this._DayBonusDrop_ID = value;
			}
		}

		// Token: 0x17000562 RID: 1378
		// (get) Token: 0x06001CF5 RID: 7413 RVA: 0x0009A1AC File Offset: 0x000983AC
		// (set) Token: 0x06001CF6 RID: 7414 RVA: 0x0009A1B4 File Offset: 0x000983B4
		[ProtoMember(19, IsRequired = true, Name = "DisplayRewardCount", DataFormat = DataFormat.TwosComplement)]
		public int DisplayRewardCount
		{
			get
			{
				return this._DisplayRewardCount;
			}
			set
			{
				this._DisplayRewardCount = value;
			}
		}

		// Token: 0x17000563 RID: 1379
		// (get) Token: 0x06001CF7 RID: 7415 RVA: 0x0009A1C0 File Offset: 0x000983C0
		// (set) Token: 0x06001CF8 RID: 7416 RVA: 0x0009A1C8 File Offset: 0x000983C8
		[ProtoMember(20, IsRequired = true, Name = "Icon1", DataFormat = DataFormat.Default)]
		public string Icon1
		{
			get
			{
				return this._Icon1;
			}
			set
			{
				this._Icon1 = value;
			}
		}

		// Token: 0x17000564 RID: 1380
		// (get) Token: 0x06001CF9 RID: 7417 RVA: 0x0009A1D4 File Offset: 0x000983D4
		// (set) Token: 0x06001CFA RID: 7418 RVA: 0x0009A1DC File Offset: 0x000983DC
		[ProtoMember(21, IsRequired = true, Name = "Icon2", DataFormat = DataFormat.Default)]
		public string Icon2
		{
			get
			{
				return this._Icon2;
			}
			set
			{
				this._Icon2 = value;
			}
		}

		// Token: 0x17000565 RID: 1381
		// (get) Token: 0x06001CFB RID: 7419 RVA: 0x0009A1E8 File Offset: 0x000983E8
		// (set) Token: 0x06001CFC RID: 7420 RVA: 0x0009A1F0 File Offset: 0x000983F0
		[ProtoMember(22, IsRequired = true, Name = "Strategy", DataFormat = DataFormat.Default)]
		public string Strategy
		{
			get
			{
				return this._Strategy;
			}
			set
			{
				this._Strategy = value;
			}
		}

		// Token: 0x06001CFD RID: 7421 RVA: 0x0009A1FC File Offset: 0x000983FC
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06001CFE RID: 7422 RVA: 0x0009A20C File Offset: 0x0009840C
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

		// Token: 0x06001CFF RID: 7423 RVA: 0x0009A2D8 File Offset: 0x000984D8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataAnikiLevelInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04001132 RID: 4402
		private int _ID;

		// Token: 0x04001133 RID: 4403
		private string _Name;

		// Token: 0x04001134 RID: 4404
		private string _TeamName;

		// Token: 0x04001135 RID: 4405
		private int _PreLevel;

		// Token: 0x04001136 RID: 4406
		private int _TicketCost;

		// Token: 0x04001137 RID: 4407
		private int _EnergySuccess;

		// Token: 0x04001138 RID: 4408
		private int _EnergyFail;

		// Token: 0x04001139 RID: 4409
		private int _TeamEnergyCost;

		// Token: 0x0400113A RID: 4410
		private int _MonsterLevel;

		// Token: 0x0400113B RID: 4411
		private int _Battle_ID;

		// Token: 0x0400113C RID: 4412
		private int _PlayerExp;

		// Token: 0x0400113D RID: 4413
		private int _HeroExp;

		// Token: 0x0400113E RID: 4414
		private int _Gold;

		// Token: 0x0400113F RID: 4415
		private int _Drop_ID;

		// Token: 0x04001140 RID: 4416
		private int _TeamDrop_ID;

		// Token: 0x04001141 RID: 4417
		private int _OperationalActivityDrop_ID;

		// Token: 0x04001142 RID: 4418
		private int _DayBonusDrop_ID;

		// Token: 0x04001143 RID: 4419
		private int _DisplayRewardCount;

		// Token: 0x04001144 RID: 4420
		private string _Icon1;

		// Token: 0x04001145 RID: 4421
		private string _Icon2;

		// Token: 0x04001146 RID: 4422
		private string _Strategy;

		// Token: 0x04001147 RID: 4423
		private IExtension extensionObject;

		// Token: 0x04001148 RID: 4424
		public ConfigDataBattleInfo m_battleInfo;

		// Token: 0x04001149 RID: 4425
		public ConfigDataAnikiGymInfo m_groupInfo;

		// Token: 0x0400114A RID: 4426
		public ConfigDataRandomDropRewardInfo m_randomDropInfo;

		// Token: 0x0400114B RID: 4427
		public ConfigDataRandomDropRewardInfo m_activityRandomDropInfo;

		// Token: 0x0400114C RID: 4428
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400114D RID: 4429
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400114E RID: 4430
		private LuaFunction m_ctor_hotfix;
	}
}
