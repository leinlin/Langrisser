using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x0200027C RID: 636
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ConfigDataRealTimePVPRankingRewardInfo")]
	[Serializable]
	public class ConfigDataRealTimePVPRankingRewardInfo : IExtensible
	{
		// Token: 0x060028D2 RID: 10450 RVA: 0x000AECB0 File Offset: 0x000ACEB0
		public ConfigDataRealTimePVPRankingRewardInfo()
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

		// Token: 0x17000ABA RID: 2746
		// (get) Token: 0x060028D3 RID: 10451 RVA: 0x000AED18 File Offset: 0x000ACF18
		// (set) Token: 0x060028D4 RID: 10452 RVA: 0x000AED20 File Offset: 0x000ACF20
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

		// Token: 0x17000ABB RID: 2747
		// (get) Token: 0x060028D5 RID: 10453 RVA: 0x000AED2C File Offset: 0x000ACF2C
		// (set) Token: 0x060028D6 RID: 10454 RVA: 0x000AED34 File Offset: 0x000ACF34
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

		// Token: 0x17000ABC RID: 2748
		// (get) Token: 0x060028D7 RID: 10455 RVA: 0x000AED40 File Offset: 0x000ACF40
		// (set) Token: 0x060028D8 RID: 10456 RVA: 0x000AED48 File Offset: 0x000ACF48
		[ProtoMember(4, IsRequired = true, Name = "HighRank", DataFormat = DataFormat.TwosComplement)]
		public int HighRank
		{
			get
			{
				return this._HighRank;
			}
			set
			{
				this._HighRank = value;
			}
		}

		// Token: 0x17000ABD RID: 2749
		// (get) Token: 0x060028D9 RID: 10457 RVA: 0x000AED54 File Offset: 0x000ACF54
		// (set) Token: 0x060028DA RID: 10458 RVA: 0x000AED5C File Offset: 0x000ACF5C
		[ProtoMember(5, IsRequired = true, Name = "LowRank", DataFormat = DataFormat.TwosComplement)]
		public int LowRank
		{
			get
			{
				return this._LowRank;
			}
			set
			{
				this._LowRank = value;
			}
		}

		// Token: 0x17000ABE RID: 2750
		// (get) Token: 0x060028DB RID: 10459 RVA: 0x000AED68 File Offset: 0x000ACF68
		// (set) Token: 0x060028DC RID: 10460 RVA: 0x000AED70 File Offset: 0x000ACF70
		[ProtoMember(6, IsRequired = true, Name = "RankingRewardMailTemplateId", DataFormat = DataFormat.TwosComplement)]
		public int RankingRewardMailTemplateId
		{
			get
			{
				return this._RankingRewardMailTemplateId;
			}
			set
			{
				this._RankingRewardMailTemplateId = value;
			}
		}

		// Token: 0x060028DD RID: 10461 RVA: 0x000AED7C File Offset: 0x000ACF7C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060028DE RID: 10462 RVA: 0x000AED8C File Offset: 0x000ACF8C
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

		// Token: 0x060028DF RID: 10463 RVA: 0x000AEE58 File Offset: 0x000AD058
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataRealTimePVPRankingRewardInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04001919 RID: 6425
		private int _ID;

		// Token: 0x0400191A RID: 6426
		private string _Name;

		// Token: 0x0400191B RID: 6427
		private int _HighRank;

		// Token: 0x0400191C RID: 6428
		private int _LowRank;

		// Token: 0x0400191D RID: 6429
		private int _RankingRewardMailTemplateId;

		// Token: 0x0400191E RID: 6430
		private IExtension extensionObject;

		// Token: 0x0400191F RID: 6431
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04001920 RID: 6432
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04001921 RID: 6433
		private LuaFunction m_ctor_hotfix;
	}
}
