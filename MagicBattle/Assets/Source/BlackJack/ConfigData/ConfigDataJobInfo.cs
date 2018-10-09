using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000259 RID: 601
	[CustomLuaClass]
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ConfigDataJobInfo")]
	[Serializable]
	public class ConfigDataJobInfo : IExtensible
	{
		// Token: 0x060025E2 RID: 9698 RVA: 0x000A98BC File Offset: 0x000A7ABC
		public ConfigDataJobInfo()
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

		// Token: 0x17000972 RID: 2418
		// (get) Token: 0x060025E3 RID: 9699 RVA: 0x000A9944 File Offset: 0x000A7B44
		// (set) Token: 0x060025E4 RID: 9700 RVA: 0x000A994C File Offset: 0x000A7B4C
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

		// Token: 0x17000973 RID: 2419
		// (get) Token: 0x060025E5 RID: 9701 RVA: 0x000A9958 File Offset: 0x000A7B58
		// (set) Token: 0x060025E6 RID: 9702 RVA: 0x000A9960 File Offset: 0x000A7B60
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

		// Token: 0x17000974 RID: 2420
		// (get) Token: 0x060025E7 RID: 9703 RVA: 0x000A996C File Offset: 0x000A7B6C
		// (set) Token: 0x060025E8 RID: 9704 RVA: 0x000A9974 File Offset: 0x000A7B74
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

		// Token: 0x17000975 RID: 2421
		// (get) Token: 0x060025E9 RID: 9705 RVA: 0x000A9980 File Offset: 0x000A7B80
		// (set) Token: 0x060025EA RID: 9706 RVA: 0x000A9988 File Offset: 0x000A7B88
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

		// Token: 0x17000976 RID: 2422
		// (get) Token: 0x060025EB RID: 9707 RVA: 0x000A9994 File Offset: 0x000A7B94
		// (set) Token: 0x060025EC RID: 9708 RVA: 0x000A999C File Offset: 0x000A7B9C
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

		// Token: 0x17000977 RID: 2423
		// (get) Token: 0x060025ED RID: 9709 RVA: 0x000A99A8 File Offset: 0x000A7BA8
		// (set) Token: 0x060025EE RID: 9710 RVA: 0x000A99B0 File Offset: 0x000A7BB0
		[ProtoMember(7, IsRequired = true, Name = "Name_Eng", DataFormat = DataFormat.Default)]
		public string Name_Eng
		{
			get
			{
				return this._Name_Eng;
			}
			set
			{
				this._Name_Eng = value;
			}
		}

		// Token: 0x17000978 RID: 2424
		// (get) Token: 0x060025EF RID: 9711 RVA: 0x000A99BC File Offset: 0x000A7BBC
		// (set) Token: 0x060025F0 RID: 9712 RVA: 0x000A99C4 File Offset: 0x000A7BC4
		[ProtoMember(8, IsRequired = true, Name = "Rank", DataFormat = DataFormat.TwosComplement)]
		public int Rank
		{
			get
			{
				return this._Rank;
			}
			set
			{
				this._Rank = value;
			}
		}

		// Token: 0x17000979 RID: 2425
		// (get) Token: 0x060025F1 RID: 9713 RVA: 0x000A99D0 File Offset: 0x000A7BD0
		[ProtoMember(9, Name = "JobLevels_ID_Old", DataFormat = DataFormat.TwosComplement)]
		public List<int> JobLevels_ID_Old
		{
			get
			{
				return this._JobLevels_ID_Old;
			}
		}

		// Token: 0x1700097A RID: 2426
		// (get) Token: 0x060025F2 RID: 9714 RVA: 0x000A99D8 File Offset: 0x000A7BD8
		// (set) Token: 0x060025F3 RID: 9715 RVA: 0x000A99E0 File Offset: 0x000A7BE0
		[ProtoMember(10, IsRequired = true, Name = "ChangeJobGold", DataFormat = DataFormat.TwosComplement)]
		public int ChangeJobGold
		{
			get
			{
				return this._ChangeJobGold;
			}
			set
			{
				this._ChangeJobGold = value;
			}
		}

		// Token: 0x1700097B RID: 2427
		// (get) Token: 0x060025F4 RID: 9716 RVA: 0x000A99EC File Offset: 0x000A7BEC
		// (set) Token: 0x060025F5 RID: 9717 RVA: 0x000A99F4 File Offset: 0x000A7BF4
		[ProtoMember(11, IsRequired = true, Name = "UnlockText", DataFormat = DataFormat.Default)]
		public string UnlockText
		{
			get
			{
				return this._UnlockText;
			}
			set
			{
				this._UnlockText = value;
			}
		}

		// Token: 0x1700097C RID: 2428
		// (get) Token: 0x060025F6 RID: 9718 RVA: 0x000A9A00 File Offset: 0x000A7C00
		// (set) Token: 0x060025F7 RID: 9719 RVA: 0x000A9A08 File Offset: 0x000A7C08
		[ProtoMember(12, IsRequired = true, Name = "Army_ID", DataFormat = DataFormat.TwosComplement)]
		public int Army_ID
		{
			get
			{
				return this._Army_ID;
			}
			set
			{
				this._Army_ID = value;
			}
		}

		// Token: 0x1700097D RID: 2429
		// (get) Token: 0x060025F8 RID: 9720 RVA: 0x000A9A14 File Offset: 0x000A7C14
		// (set) Token: 0x060025F9 RID: 9721 RVA: 0x000A9A1C File Offset: 0x000A7C1C
		[ProtoMember(13, IsRequired = true, Name = "IsMelee", DataFormat = DataFormat.Default)]
		public bool IsMelee
		{
			get
			{
				return this._IsMelee;
			}
			set
			{
				this._IsMelee = value;
			}
		}

		// Token: 0x1700097E RID: 2430
		// (get) Token: 0x060025FA RID: 9722 RVA: 0x000A9A28 File Offset: 0x000A7C28
		// (set) Token: 0x060025FB RID: 9723 RVA: 0x000A9A30 File Offset: 0x000A7C30
		[ProtoMember(14, IsRequired = true, Name = "MoveType", DataFormat = DataFormat.TwosComplement)]
		public MoveType MoveType
		{
			get
			{
				return this._MoveType;
			}
			set
			{
				this._MoveType = value;
			}
		}

		// Token: 0x1700097F RID: 2431
		// (get) Token: 0x060025FC RID: 9724 RVA: 0x000A9A3C File Offset: 0x000A7C3C
		// (set) Token: 0x060025FD RID: 9725 RVA: 0x000A9A44 File Offset: 0x000A7C44
		[ProtoMember(15, IsRequired = true, Name = "BF_AttackDistance", DataFormat = DataFormat.TwosComplement)]
		public int BF_AttackDistance
		{
			get
			{
				return this._BF_AttackDistance;
			}
			set
			{
				this._BF_AttackDistance = value;
			}
		}

		// Token: 0x17000980 RID: 2432
		// (get) Token: 0x060025FE RID: 9726 RVA: 0x000A9A50 File Offset: 0x000A7C50
		// (set) Token: 0x060025FF RID: 9727 RVA: 0x000A9A58 File Offset: 0x000A7C58
		[ProtoMember(16, IsRequired = true, Name = "MeleeATK_ID", DataFormat = DataFormat.TwosComplement)]
		public int MeleeATK_ID
		{
			get
			{
				return this._MeleeATK_ID;
			}
			set
			{
				this._MeleeATK_ID = value;
			}
		}

		// Token: 0x17000981 RID: 2433
		// (get) Token: 0x06002600 RID: 9728 RVA: 0x000A9A64 File Offset: 0x000A7C64
		// (set) Token: 0x06002601 RID: 9729 RVA: 0x000A9A6C File Offset: 0x000A7C6C
		[ProtoMember(17, IsRequired = true, Name = "RangeATK_ID", DataFormat = DataFormat.TwosComplement)]
		public int RangeATK_ID
		{
			get
			{
				return this._RangeATK_ID;
			}
			set
			{
				this._RangeATK_ID = value;
			}
		}

		// Token: 0x17000982 RID: 2434
		// (get) Token: 0x06002602 RID: 9730 RVA: 0x000A9A78 File Offset: 0x000A7C78
		// (set) Token: 0x06002603 RID: 9731 RVA: 0x000A9A80 File Offset: 0x000A7C80
		[ProtoMember(18, IsRequired = true, Name = "MoveSPD_INI", DataFormat = DataFormat.TwosComplement)]
		public int MoveSPD_INI
		{
			get
			{
				return this._MoveSPD_INI;
			}
			set
			{
				this._MoveSPD_INI = value;
			}
		}

		// Token: 0x17000983 RID: 2435
		// (get) Token: 0x06002604 RID: 9732 RVA: 0x000A9A8C File Offset: 0x000A7C8C
		// (set) Token: 0x06002605 RID: 9733 RVA: 0x000A9A94 File Offset: 0x000A7C94
		[ProtoMember(19, IsRequired = true, Name = "BF_MovePoint", DataFormat = DataFormat.TwosComplement)]
		public int BF_MovePoint
		{
			get
			{
				return this._BF_MovePoint;
			}
			set
			{
				this._BF_MovePoint = value;
			}
		}

		// Token: 0x17000984 RID: 2436
		// (get) Token: 0x06002606 RID: 9734 RVA: 0x000A9AA0 File Offset: 0x000A7CA0
		// (set) Token: 0x06002607 RID: 9735 RVA: 0x000A9AA8 File Offset: 0x000A7CA8
		[ProtoMember(20, IsRequired = true, Name = "BF_ActionValue", DataFormat = DataFormat.TwosComplement)]
		public int BF_ActionValue
		{
			get
			{
				return this._BF_ActionValue;
			}
			set
			{
				this._BF_ActionValue = value;
			}
		}

		// Token: 0x17000985 RID: 2437
		// (get) Token: 0x06002608 RID: 9736 RVA: 0x000A9AB4 File Offset: 0x000A7CB4
		// (set) Token: 0x06002609 RID: 9737 RVA: 0x000A9ABC File Offset: 0x000A7CBC
		[ProtoMember(21, IsRequired = true, Name = "Behavior", DataFormat = DataFormat.TwosComplement)]
		public int Behavior
		{
			get
			{
				return this._Behavior;
			}
			set
			{
				this._Behavior = value;
			}
		}

		// Token: 0x17000986 RID: 2438
		// (get) Token: 0x0600260A RID: 9738 RVA: 0x000A9AC8 File Offset: 0x000A7CC8
		// (set) Token: 0x0600260B RID: 9739 RVA: 0x000A9AD0 File Offset: 0x000A7CD0
		[ProtoMember(22, IsRequired = true, Name = "DieFlyDistanceMin", DataFormat = DataFormat.TwosComplement)]
		public int DieFlyDistanceMin
		{
			get
			{
				return this._DieFlyDistanceMin;
			}
			set
			{
				this._DieFlyDistanceMin = value;
			}
		}

		// Token: 0x17000987 RID: 2439
		// (get) Token: 0x0600260C RID: 9740 RVA: 0x000A9ADC File Offset: 0x000A7CDC
		// (set) Token: 0x0600260D RID: 9741 RVA: 0x000A9AE4 File Offset: 0x000A7CE4
		[ProtoMember(23, IsRequired = true, Name = "DieFlyDistanceMax", DataFormat = DataFormat.TwosComplement)]
		public int DieFlyDistanceMax
		{
			get
			{
				return this._DieFlyDistanceMax;
			}
			set
			{
				this._DieFlyDistanceMax = value;
			}
		}

		// Token: 0x17000988 RID: 2440
		// (get) Token: 0x0600260E RID: 9742 RVA: 0x000A9AF0 File Offset: 0x000A7CF0
		// (set) Token: 0x0600260F RID: 9743 RVA: 0x000A9AF8 File Offset: 0x000A7CF8
		[ProtoMember(24, IsRequired = true, Name = "Property1_ID", DataFormat = DataFormat.TwosComplement)]
		public PropertyModifyType Property1_ID
		{
			get
			{
				return this._Property1_ID;
			}
			set
			{
				this._Property1_ID = value;
			}
		}

		// Token: 0x17000989 RID: 2441
		// (get) Token: 0x06002610 RID: 9744 RVA: 0x000A9B04 File Offset: 0x000A7D04
		// (set) Token: 0x06002611 RID: 9745 RVA: 0x000A9B0C File Offset: 0x000A7D0C
		[ProtoMember(25, IsRequired = true, Name = "Property1_Value", DataFormat = DataFormat.TwosComplement)]
		public int Property1_Value
		{
			get
			{
				return this._Property1_Value;
			}
			set
			{
				this._Property1_Value = value;
			}
		}

		// Token: 0x1700098A RID: 2442
		// (get) Token: 0x06002612 RID: 9746 RVA: 0x000A9B18 File Offset: 0x000A7D18
		// (set) Token: 0x06002613 RID: 9747 RVA: 0x000A9B20 File Offset: 0x000A7D20
		[ProtoMember(26, IsRequired = true, Name = "Property2_ID", DataFormat = DataFormat.TwosComplement)]
		public PropertyModifyType Property2_ID
		{
			get
			{
				return this._Property2_ID;
			}
			set
			{
				this._Property2_ID = value;
			}
		}

		// Token: 0x1700098B RID: 2443
		// (get) Token: 0x06002614 RID: 9748 RVA: 0x000A9B2C File Offset: 0x000A7D2C
		// (set) Token: 0x06002615 RID: 9749 RVA: 0x000A9B34 File Offset: 0x000A7D34
		[ProtoMember(27, IsRequired = true, Name = "Property2_Value", DataFormat = DataFormat.TwosComplement)]
		public int Property2_Value
		{
			get
			{
				return this._Property2_Value;
			}
			set
			{
				this._Property2_Value = value;
			}
		}

		// Token: 0x1700098C RID: 2444
		// (get) Token: 0x06002616 RID: 9750 RVA: 0x000A9B40 File Offset: 0x000A7D40
		// (set) Token: 0x06002617 RID: 9751 RVA: 0x000A9B48 File Offset: 0x000A7D48
		[ProtoMember(28, IsRequired = true, Name = "Property3_ID", DataFormat = DataFormat.TwosComplement)]
		public PropertyModifyType Property3_ID
		{
			get
			{
				return this._Property3_ID;
			}
			set
			{
				this._Property3_ID = value;
			}
		}

		// Token: 0x1700098D RID: 2445
		// (get) Token: 0x06002618 RID: 9752 RVA: 0x000A9B54 File Offset: 0x000A7D54
		// (set) Token: 0x06002619 RID: 9753 RVA: 0x000A9B5C File Offset: 0x000A7D5C
		[ProtoMember(29, IsRequired = true, Name = "Property3_Value", DataFormat = DataFormat.TwosComplement)]
		public int Property3_Value
		{
			get
			{
				return this._Property3_Value;
			}
			set
			{
				this._Property3_Value = value;
			}
		}

		// Token: 0x1700098E RID: 2446
		// (get) Token: 0x0600261A RID: 9754 RVA: 0x000A9B68 File Offset: 0x000A7D68
		[ProtoMember(31, Name = "AdvantagePropertyIds", DataFormat = DataFormat.TwosComplement)]
		public List<int> AdvantagePropertyIds
		{
			get
			{
				return this._AdvantagePropertyIds;
			}
		}

		// Token: 0x1700098F RID: 2447
		// (get) Token: 0x0600261B RID: 9755 RVA: 0x000A9B70 File Offset: 0x000A7D70
		// (set) Token: 0x0600261C RID: 9756 RVA: 0x000A9B78 File Offset: 0x000A7D78
		[ProtoMember(32, IsRequired = true, Name = "JobIcon", DataFormat = DataFormat.Default)]
		public string JobIcon
		{
			get
			{
				return this._JobIcon;
			}
			set
			{
				this._JobIcon = value;
			}
		}

		// Token: 0x17000990 RID: 2448
		// (get) Token: 0x0600261D RID: 9757 RVA: 0x000A9B84 File Offset: 0x000A7D84
		// (set) Token: 0x0600261E RID: 9758 RVA: 0x000A9B8C File Offset: 0x000A7D8C
		[ProtoMember(33, IsRequired = true, Name = "BattlePowerHP", DataFormat = DataFormat.TwosComplement)]
		public int BattlePowerHP
		{
			get
			{
				return this._BattlePowerHP;
			}
			set
			{
				this._BattlePowerHP = value;
			}
		}

		// Token: 0x17000991 RID: 2449
		// (get) Token: 0x0600261F RID: 9759 RVA: 0x000A9B98 File Offset: 0x000A7D98
		// (set) Token: 0x06002620 RID: 9760 RVA: 0x000A9BA0 File Offset: 0x000A7DA0
		[ProtoMember(34, IsRequired = true, Name = "BattlePowerAT", DataFormat = DataFormat.TwosComplement)]
		public int BattlePowerAT
		{
			get
			{
				return this._BattlePowerAT;
			}
			set
			{
				this._BattlePowerAT = value;
			}
		}

		// Token: 0x17000992 RID: 2450
		// (get) Token: 0x06002621 RID: 9761 RVA: 0x000A9BAC File Offset: 0x000A7DAC
		// (set) Token: 0x06002622 RID: 9762 RVA: 0x000A9BB4 File Offset: 0x000A7DB4
		[ProtoMember(35, IsRequired = true, Name = "BattlePowerMagic", DataFormat = DataFormat.TwosComplement)]
		public int BattlePowerMagic
		{
			get
			{
				return this._BattlePowerMagic;
			}
			set
			{
				this._BattlePowerMagic = value;
			}
		}

		// Token: 0x17000993 RID: 2451
		// (get) Token: 0x06002623 RID: 9763 RVA: 0x000A9BC0 File Offset: 0x000A7DC0
		// (set) Token: 0x06002624 RID: 9764 RVA: 0x000A9BC8 File Offset: 0x000A7DC8
		[ProtoMember(36, IsRequired = true, Name = "BattlePowerDF", DataFormat = DataFormat.TwosComplement)]
		public int BattlePowerDF
		{
			get
			{
				return this._BattlePowerDF;
			}
			set
			{
				this._BattlePowerDF = value;
			}
		}

		// Token: 0x17000994 RID: 2452
		// (get) Token: 0x06002625 RID: 9765 RVA: 0x000A9BD4 File Offset: 0x000A7DD4
		// (set) Token: 0x06002626 RID: 9766 RVA: 0x000A9BDC File Offset: 0x000A7DDC
		[ProtoMember(37, IsRequired = true, Name = "BattlePowerMagicDF", DataFormat = DataFormat.TwosComplement)]
		public int BattlePowerMagicDF
		{
			get
			{
				return this._BattlePowerMagicDF;
			}
			set
			{
				this._BattlePowerMagicDF = value;
			}
		}

		// Token: 0x17000995 RID: 2453
		// (get) Token: 0x06002627 RID: 9767 RVA: 0x000A9BE8 File Offset: 0x000A7DE8
		// (set) Token: 0x06002628 RID: 9768 RVA: 0x000A9BF0 File Offset: 0x000A7DF0
		[ProtoMember(38, IsRequired = true, Name = "BattlePowerDEX", DataFormat = DataFormat.TwosComplement)]
		public int BattlePowerDEX
		{
			get
			{
				return this._BattlePowerDEX;
			}
			set
			{
				this._BattlePowerDEX = value;
			}
		}

		// Token: 0x17000996 RID: 2454
		// (get) Token: 0x06002629 RID: 9769 RVA: 0x000A9BFC File Offset: 0x000A7DFC
		[ProtoMember(39, Name = "Skills_ID", DataFormat = DataFormat.TwosComplement)]
		public List<int> Skills_ID
		{
			get
			{
				return this._Skills_ID;
			}
		}

		// Token: 0x0600262A RID: 9770 RVA: 0x000A9C04 File Offset: 0x000A7E04
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600262B RID: 9771 RVA: 0x000A9C14 File Offset: 0x000A7E14
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

		// Token: 0x0600262C RID: 9772 RVA: 0x000A9CE0 File Offset: 0x000A7EE0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataJobInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400172D RID: 5933
		private int _ID;

		// Token: 0x0400172E RID: 5934
		private string _Name;

		// Token: 0x0400172F RID: 5935
		private string _NameStrKey;

		// Token: 0x04001730 RID: 5936
		private string _Desc;

		// Token: 0x04001731 RID: 5937
		private string _DescStrKey;

		// Token: 0x04001732 RID: 5938
		private string _Name_Eng;

		// Token: 0x04001733 RID: 5939
		private int _Rank;

		// Token: 0x04001734 RID: 5940
		private readonly List<int> _JobLevels_ID_Old = new List<int>();

		// Token: 0x04001735 RID: 5941
		private int _ChangeJobGold;

		// Token: 0x04001736 RID: 5942
		private string _UnlockText;

		// Token: 0x04001737 RID: 5943
		private int _Army_ID;

		// Token: 0x04001738 RID: 5944
		private bool _IsMelee;

		// Token: 0x04001739 RID: 5945
		private MoveType _MoveType;

		// Token: 0x0400173A RID: 5946
		private int _BF_AttackDistance;

		// Token: 0x0400173B RID: 5947
		private int _MeleeATK_ID;

		// Token: 0x0400173C RID: 5948
		private int _RangeATK_ID;

		// Token: 0x0400173D RID: 5949
		private int _MoveSPD_INI;

		// Token: 0x0400173E RID: 5950
		private int _BF_MovePoint;

		// Token: 0x0400173F RID: 5951
		private int _BF_ActionValue;

		// Token: 0x04001740 RID: 5952
		private int _Behavior;

		// Token: 0x04001741 RID: 5953
		private int _DieFlyDistanceMin;

		// Token: 0x04001742 RID: 5954
		private int _DieFlyDistanceMax;

		// Token: 0x04001743 RID: 5955
		private PropertyModifyType _Property1_ID;

		// Token: 0x04001744 RID: 5956
		private int _Property1_Value;

		// Token: 0x04001745 RID: 5957
		private PropertyModifyType _Property2_ID;

		// Token: 0x04001746 RID: 5958
		private int _Property2_Value;

		// Token: 0x04001747 RID: 5959
		private PropertyModifyType _Property3_ID;

		// Token: 0x04001748 RID: 5960
		private int _Property3_Value;

		// Token: 0x04001749 RID: 5961
		private readonly List<int> _AdvantagePropertyIds = new List<int>();

		// Token: 0x0400174A RID: 5962
		private string _JobIcon;

		// Token: 0x0400174B RID: 5963
		private int _BattlePowerHP;

		// Token: 0x0400174C RID: 5964
		private int _BattlePowerAT;

		// Token: 0x0400174D RID: 5965
		private int _BattlePowerMagic;

		// Token: 0x0400174E RID: 5966
		private int _BattlePowerDF;

		// Token: 0x0400174F RID: 5967
		private int _BattlePowerMagicDF;

		// Token: 0x04001750 RID: 5968
		private int _BattlePowerDEX;

		// Token: 0x04001751 RID: 5969
		private readonly List<int> _Skills_ID = new List<int>();

		// Token: 0x04001752 RID: 5970
		private IExtension extensionObject;

		// Token: 0x04001753 RID: 5971
		public ConfigDataArmyInfo m_armyInfo;

		// Token: 0x04001754 RID: 5972
		public ConfigDataSkillInfo m_meleeSkillInfo;

		// Token: 0x04001755 RID: 5973
		public ConfigDataSkillInfo m_rangeSkillInfo;

		// Token: 0x04001756 RID: 5974
		public ConfigDataSkillInfo[] m_jobSkillInfos;

		// Token: 0x04001757 RID: 5975
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04001758 RID: 5976
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04001759 RID: 5977
		private LuaFunction m_ctor_hotfix;
	}
}
