using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x0200022F RID: 559
	[CustomLuaClass]
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ConfigDataEventInfo")]
	[Serializable]
	public class ConfigDataEventInfo : IExtensible
	{
		// Token: 0x060021F5 RID: 8693 RVA: 0x000A2D7C File Offset: 0x000A0F7C
		public ConfigDataEventInfo()
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

		// Token: 0x170007A9 RID: 1961
		// (get) Token: 0x060021F6 RID: 8694 RVA: 0x000A2DF8 File Offset: 0x000A0FF8
		// (set) Token: 0x060021F7 RID: 8695 RVA: 0x000A2E00 File Offset: 0x000A1000
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

		// Token: 0x170007AA RID: 1962
		// (get) Token: 0x060021F8 RID: 8696 RVA: 0x000A2E0C File Offset: 0x000A100C
		// (set) Token: 0x060021F9 RID: 8697 RVA: 0x000A2E14 File Offset: 0x000A1014
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

		// Token: 0x170007AB RID: 1963
		// (get) Token: 0x060021FA RID: 8698 RVA: 0x000A2E20 File Offset: 0x000A1020
		// (set) Token: 0x060021FB RID: 8699 RVA: 0x000A2E28 File Offset: 0x000A1028
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

		// Token: 0x170007AC RID: 1964
		// (get) Token: 0x060021FC RID: 8700 RVA: 0x000A2E34 File Offset: 0x000A1034
		// (set) Token: 0x060021FD RID: 8701 RVA: 0x000A2E3C File Offset: 0x000A103C
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

		// Token: 0x170007AD RID: 1965
		// (get) Token: 0x060021FE RID: 8702 RVA: 0x000A2E48 File Offset: 0x000A1048
		// (set) Token: 0x060021FF RID: 8703 RVA: 0x000A2E50 File Offset: 0x000A1050
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

		// Token: 0x170007AE RID: 1966
		// (get) Token: 0x06002200 RID: 8704 RVA: 0x000A2E5C File Offset: 0x000A105C
		// (set) Token: 0x06002201 RID: 8705 RVA: 0x000A2E64 File Offset: 0x000A1064
		[ProtoMember(7, IsRequired = true, Name = "FuncType", DataFormat = DataFormat.TwosComplement)]
		public EventFuncType FuncType
		{
			get
			{
				return this._FuncType;
			}
			set
			{
				this._FuncType = value;
			}
		}

		// Token: 0x170007AF RID: 1967
		// (get) Token: 0x06002202 RID: 8706 RVA: 0x000A2E70 File Offset: 0x000A1070
		// (set) Token: 0x06002203 RID: 8707 RVA: 0x000A2E78 File Offset: 0x000A1078
		[ProtoMember(8, IsRequired = true, Name = "EnergySuccess", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x170007B0 RID: 1968
		// (get) Token: 0x06002204 RID: 8708 RVA: 0x000A2E84 File Offset: 0x000A1084
		// (set) Token: 0x06002205 RID: 8709 RVA: 0x000A2E8C File Offset: 0x000A108C
		[ProtoMember(9, IsRequired = true, Name = "EnergyFail", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x170007B1 RID: 1969
		// (get) Token: 0x06002206 RID: 8710 RVA: 0x000A2E98 File Offset: 0x000A1098
		[ProtoMember(10, Name = "DisappearCondition", DataFormat = DataFormat.Default)]
		public List<EventInfoDisappearCondition> DisappearCondition
		{
			get
			{
				return this._DisappearCondition;
			}
		}

		// Token: 0x170007B2 RID: 1970
		// (get) Token: 0x06002207 RID: 8711 RVA: 0x000A2EA0 File Offset: 0x000A10A0
		// (set) Token: 0x06002208 RID: 8712 RVA: 0x000A2EA8 File Offset: 0x000A10A8
		[ProtoMember(11, IsRequired = true, Name = "MonsterLevel", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x170007B3 RID: 1971
		// (get) Token: 0x06002209 RID: 8713 RVA: 0x000A2EB4 File Offset: 0x000A10B4
		// (set) Token: 0x0600220A RID: 8714 RVA: 0x000A2EBC File Offset: 0x000A10BC
		[ProtoMember(12, IsRequired = true, Name = "Battle_ID", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x170007B4 RID: 1972
		// (get) Token: 0x0600220B RID: 8715 RVA: 0x000A2EC8 File Offset: 0x000A10C8
		// (set) Token: 0x0600220C RID: 8716 RVA: 0x000A2ED0 File Offset: 0x000A10D0
		[ProtoMember(13, IsRequired = true, Name = "DialogBefore_ID", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x170007B5 RID: 1973
		// (get) Token: 0x0600220D RID: 8717 RVA: 0x000A2EDC File Offset: 0x000A10DC
		// (set) Token: 0x0600220E RID: 8718 RVA: 0x000A2EE4 File Offset: 0x000A10E4
		[ProtoMember(14, IsRequired = true, Name = "DialogAfter_ID", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x170007B6 RID: 1974
		// (get) Token: 0x0600220F RID: 8719 RVA: 0x000A2EF0 File Offset: 0x000A10F0
		// (set) Token: 0x06002210 RID: 8720 RVA: 0x000A2EF8 File Offset: 0x000A10F8
		[ProtoMember(15, IsRequired = true, Name = "PlayerExpReward", DataFormat = DataFormat.TwosComplement)]
		public int PlayerExpReward
		{
			get
			{
				return this._PlayerExpReward;
			}
			set
			{
				this._PlayerExpReward = value;
			}
		}

		// Token: 0x170007B7 RID: 1975
		// (get) Token: 0x06002211 RID: 8721 RVA: 0x000A2F04 File Offset: 0x000A1104
		// (set) Token: 0x06002212 RID: 8722 RVA: 0x000A2F0C File Offset: 0x000A110C
		[ProtoMember(16, IsRequired = true, Name = "HeroExpReward", DataFormat = DataFormat.TwosComplement)]
		public int HeroExpReward
		{
			get
			{
				return this._HeroExpReward;
			}
			set
			{
				this._HeroExpReward = value;
			}
		}

		// Token: 0x170007B8 RID: 1976
		// (get) Token: 0x06002213 RID: 8723 RVA: 0x000A2F18 File Offset: 0x000A1118
		// (set) Token: 0x06002214 RID: 8724 RVA: 0x000A2F20 File Offset: 0x000A1120
		[ProtoMember(17, IsRequired = true, Name = "GoldReward", DataFormat = DataFormat.TwosComplement)]
		public int GoldReward
		{
			get
			{
				return this._GoldReward;
			}
			set
			{
				this._GoldReward = value;
			}
		}

		// Token: 0x170007B9 RID: 1977
		// (get) Token: 0x06002215 RID: 8725 RVA: 0x000A2F2C File Offset: 0x000A112C
		[ProtoMember(18, Name = "Reward", DataFormat = DataFormat.Default)]
		public List<Goods> Reward
		{
			get
			{
				return this._Reward;
			}
		}

		// Token: 0x170007BA RID: 1978
		// (get) Token: 0x06002216 RID: 8726 RVA: 0x000A2F34 File Offset: 0x000A1134
		// (set) Token: 0x06002217 RID: 8727 RVA: 0x000A2F3C File Offset: 0x000A113C
		[ProtoMember(19, IsRequired = true, Name = "Drop_ID", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x170007BB RID: 1979
		// (get) Token: 0x06002218 RID: 8728 RVA: 0x000A2F48 File Offset: 0x000A1148
		// (set) Token: 0x06002219 RID: 8729 RVA: 0x000A2F50 File Offset: 0x000A1150
		[ProtoMember(20, IsRequired = true, Name = "StyleType", DataFormat = DataFormat.TwosComplement)]
		public WaypointStyleType StyleType
		{
			get
			{
				return this._StyleType;
			}
			set
			{
				this._StyleType = value;
			}
		}

		// Token: 0x170007BC RID: 1980
		// (get) Token: 0x0600221A RID: 8730 RVA: 0x000A2F5C File Offset: 0x000A115C
		// (set) Token: 0x0600221B RID: 8731 RVA: 0x000A2F64 File Offset: 0x000A1164
		[ProtoMember(21, IsRequired = true, Name = "Model", DataFormat = DataFormat.Default)]
		public string Model
		{
			get
			{
				return this._Model;
			}
			set
			{
				this._Model = value;
			}
		}

		// Token: 0x170007BD RID: 1981
		// (get) Token: 0x0600221C RID: 8732 RVA: 0x000A2F70 File Offset: 0x000A1170
		// (set) Token: 0x0600221D RID: 8733 RVA: 0x000A2F78 File Offset: 0x000A1178
		[ProtoMember(22, IsRequired = true, Name = "ModelScale", DataFormat = DataFormat.TwosComplement)]
		public int ModelScale
		{
			get
			{
				return this._ModelScale;
			}
			set
			{
				this._ModelScale = value;
			}
		}

		// Token: 0x170007BE RID: 1982
		// (get) Token: 0x0600221E RID: 8734 RVA: 0x000A2F84 File Offset: 0x000A1184
		// (set) Token: 0x0600221F RID: 8735 RVA: 0x000A2F8C File Offset: 0x000A118C
		[ProtoMember(23, IsRequired = true, Name = "MapIcon", DataFormat = DataFormat.Default)]
		public string MapIcon
		{
			get
			{
				return this._MapIcon;
			}
			set
			{
				this._MapIcon = value;
			}
		}

		// Token: 0x170007BF RID: 1983
		// (get) Token: 0x06002220 RID: 8736 RVA: 0x000A2F98 File Offset: 0x000A1198
		// (set) Token: 0x06002221 RID: 8737 RVA: 0x000A2FA0 File Offset: 0x000A11A0
		[ProtoMember(24, IsRequired = true, Name = "MapIconY", DataFormat = DataFormat.TwosComplement)]
		public int MapIconY
		{
			get
			{
				return this._MapIconY;
			}
			set
			{
				this._MapIconY = value;
			}
		}

		// Token: 0x170007C0 RID: 1984
		// (get) Token: 0x06002222 RID: 8738 RVA: 0x000A2FAC File Offset: 0x000A11AC
		// (set) Token: 0x06002223 RID: 8739 RVA: 0x000A2FB4 File Offset: 0x000A11B4
		[ProtoMember(25, IsRequired = true, Name = "Icon", DataFormat = DataFormat.Default)]
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

		// Token: 0x170007C1 RID: 1985
		// (get) Token: 0x06002224 RID: 8740 RVA: 0x000A2FC0 File Offset: 0x000A11C0
		// (set) Token: 0x06002225 RID: 8741 RVA: 0x000A2FC8 File Offset: 0x000A11C8
		[ProtoMember(26, IsRequired = true, Name = "IsDanger", DataFormat = DataFormat.Default)]
		public bool IsDanger
		{
			get
			{
				return this._IsDanger;
			}
			set
			{
				this._IsDanger = value;
			}
		}

		// Token: 0x170007C2 RID: 1986
		// (get) Token: 0x06002226 RID: 8742 RVA: 0x000A2FD4 File Offset: 0x000A11D4
		// (set) Token: 0x06002227 RID: 8743 RVA: 0x000A2FDC File Offset: 0x000A11DC
		[ProtoMember(27, IsRequired = true, Name = "CharImage_ID", DataFormat = DataFormat.TwosComplement)]
		public int CharImage_ID
		{
			get
			{
				return this._CharImage_ID;
			}
			set
			{
				this._CharImage_ID = value;
			}
		}

		// Token: 0x170007C3 RID: 1987
		// (get) Token: 0x06002228 RID: 8744 RVA: 0x000A2FE8 File Offset: 0x000A11E8
		// (set) Token: 0x06002229 RID: 8745 RVA: 0x000A2FF0 File Offset: 0x000A11F0
		[ProtoMember(28, IsRequired = true, Name = "Strategy", DataFormat = DataFormat.Default)]
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

		// Token: 0x0600222A RID: 8746 RVA: 0x000A2FFC File Offset: 0x000A11FC
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600222B RID: 8747 RVA: 0x000A300C File Offset: 0x000A120C
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

		// Token: 0x0600222C RID: 8748 RVA: 0x000A30D8 File Offset: 0x000A12D8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataEventInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04001490 RID: 5264
		private int _ID;

		// Token: 0x04001491 RID: 5265
		private string _Name;

		// Token: 0x04001492 RID: 5266
		private string _NameStrKey;

		// Token: 0x04001493 RID: 5267
		private string _Desc;

		// Token: 0x04001494 RID: 5268
		private string _DescStrKey;

		// Token: 0x04001495 RID: 5269
		private EventFuncType _FuncType;

		// Token: 0x04001496 RID: 5270
		private int _EnergySuccess;

		// Token: 0x04001497 RID: 5271
		private int _EnergyFail;

		// Token: 0x04001498 RID: 5272
		private readonly List<EventInfoDisappearCondition> _DisappearCondition = new List<EventInfoDisappearCondition>();

		// Token: 0x04001499 RID: 5273
		private int _MonsterLevel;

		// Token: 0x0400149A RID: 5274
		private int _Battle_ID;

		// Token: 0x0400149B RID: 5275
		private int _DialogBefore_ID;

		// Token: 0x0400149C RID: 5276
		private int _DialogAfter_ID;

		// Token: 0x0400149D RID: 5277
		private int _PlayerExpReward;

		// Token: 0x0400149E RID: 5278
		private int _HeroExpReward;

		// Token: 0x0400149F RID: 5279
		private int _GoldReward;

		// Token: 0x040014A0 RID: 5280
		private readonly List<Goods> _Reward = new List<Goods>();

		// Token: 0x040014A1 RID: 5281
		private int _Drop_ID;

		// Token: 0x040014A2 RID: 5282
		private WaypointStyleType _StyleType;

		// Token: 0x040014A3 RID: 5283
		private string _Model;

		// Token: 0x040014A4 RID: 5284
		private int _ModelScale;

		// Token: 0x040014A5 RID: 5285
		private string _MapIcon;

		// Token: 0x040014A6 RID: 5286
		private int _MapIconY;

		// Token: 0x040014A7 RID: 5287
		private string _Icon;

		// Token: 0x040014A8 RID: 5288
		private bool _IsDanger;

		// Token: 0x040014A9 RID: 5289
		private int _CharImage_ID;

		// Token: 0x040014AA RID: 5290
		private string _Strategy;

		// Token: 0x040014AB RID: 5291
		private IExtension extensionObject;

		// Token: 0x040014AC RID: 5292
		public ConfigDataBattleInfo m_battleInfo;

		// Token: 0x040014AD RID: 5293
		public ConfigDataDialogInfo m_dialogInfoBefore;

		// Token: 0x040014AE RID: 5294
		public ConfigDataDialogInfo m_dialogInfoAfter;

		// Token: 0x040014AF RID: 5295
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040014B0 RID: 5296
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040014B1 RID: 5297
		private LuaFunction m_ctor_hotfix;
	}
}
