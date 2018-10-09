using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x0200027A RID: 634
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ConfigDataRealTimePVPLocalRankingRewardInfo")]
	[Serializable]
	public class ConfigDataRealTimePVPLocalRankingRewardInfo : IExtensible
	{
		// Token: 0x060028BA RID: 10426 RVA: 0x000AE8B8 File Offset: 0x000ACAB8
		public ConfigDataRealTimePVPLocalRankingRewardInfo()
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

		// Token: 0x17000AB2 RID: 2738
		// (get) Token: 0x060028BB RID: 10427 RVA: 0x000AE920 File Offset: 0x000ACB20
		// (set) Token: 0x060028BC RID: 10428 RVA: 0x000AE928 File Offset: 0x000ACB28
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

		// Token: 0x17000AB3 RID: 2739
		// (get) Token: 0x060028BD RID: 10429 RVA: 0x000AE934 File Offset: 0x000ACB34
		// (set) Token: 0x060028BE RID: 10430 RVA: 0x000AE93C File Offset: 0x000ACB3C
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

		// Token: 0x17000AB4 RID: 2740
		// (get) Token: 0x060028BF RID: 10431 RVA: 0x000AE948 File Offset: 0x000ACB48
		// (set) Token: 0x060028C0 RID: 10432 RVA: 0x000AE950 File Offset: 0x000ACB50
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

		// Token: 0x17000AB5 RID: 2741
		// (get) Token: 0x060028C1 RID: 10433 RVA: 0x000AE95C File Offset: 0x000ACB5C
		// (set) Token: 0x060028C2 RID: 10434 RVA: 0x000AE964 File Offset: 0x000ACB64
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

		// Token: 0x17000AB6 RID: 2742
		// (get) Token: 0x060028C3 RID: 10435 RVA: 0x000AE970 File Offset: 0x000ACB70
		// (set) Token: 0x060028C4 RID: 10436 RVA: 0x000AE978 File Offset: 0x000ACB78
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

		// Token: 0x060028C5 RID: 10437 RVA: 0x000AE984 File Offset: 0x000ACB84
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060028C6 RID: 10438 RVA: 0x000AE994 File Offset: 0x000ACB94
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

		// Token: 0x060028C7 RID: 10439 RVA: 0x000AEA60 File Offset: 0x000ACC60
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataRealTimePVPLocalRankingRewardInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04001909 RID: 6409
		private int _ID;

		// Token: 0x0400190A RID: 6410
		private string _Name;

		// Token: 0x0400190B RID: 6411
		private int _HighRank;

		// Token: 0x0400190C RID: 6412
		private int _LowRank;

		// Token: 0x0400190D RID: 6413
		private int _RankingRewardMailTemplateId;

		// Token: 0x0400190E RID: 6414
		private IExtension extensionObject;

		// Token: 0x0400190F RID: 6415
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04001910 RID: 6416
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04001911 RID: 6417
		private LuaFunction m_ctor_hotfix;
	}
}
