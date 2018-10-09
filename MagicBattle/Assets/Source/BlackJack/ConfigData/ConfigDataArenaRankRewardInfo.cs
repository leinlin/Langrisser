using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x020001FF RID: 511
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ConfigDataArenaRankRewardInfo")]
	[Serializable]
	public class ConfigDataArenaRankRewardInfo : IExtensible
	{
		// Token: 0x06001D6B RID: 7531 RVA: 0x0009ADBC File Offset: 0x00098FBC
		public ConfigDataArenaRankRewardInfo()
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

		// Token: 0x17000597 RID: 1431
		// (get) Token: 0x06001D6C RID: 7532 RVA: 0x0009AE24 File Offset: 0x00099024
		// (set) Token: 0x06001D6D RID: 7533 RVA: 0x0009AE2C File Offset: 0x0009902C
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

		// Token: 0x17000598 RID: 1432
		// (get) Token: 0x06001D6E RID: 7534 RVA: 0x0009AE38 File Offset: 0x00099038
		// (set) Token: 0x06001D6F RID: 7535 RVA: 0x0009AE40 File Offset: 0x00099040
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

		// Token: 0x17000599 RID: 1433
		// (get) Token: 0x06001D70 RID: 7536 RVA: 0x0009AE4C File Offset: 0x0009904C
		// (set) Token: 0x06001D71 RID: 7537 RVA: 0x0009AE54 File Offset: 0x00099054
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

		// Token: 0x1700059A RID: 1434
		// (get) Token: 0x06001D72 RID: 7538 RVA: 0x0009AE60 File Offset: 0x00099060
		// (set) Token: 0x06001D73 RID: 7539 RVA: 0x0009AE68 File Offset: 0x00099068
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

		// Token: 0x1700059B RID: 1435
		// (get) Token: 0x06001D74 RID: 7540 RVA: 0x0009AE74 File Offset: 0x00099074
		// (set) Token: 0x06001D75 RID: 7541 RVA: 0x0009AE7C File Offset: 0x0009907C
		[ProtoMember(6, IsRequired = true, Name = "RankRewardMailTemplateId", DataFormat = DataFormat.TwosComplement)]
		public int RankRewardMailTemplateId
		{
			get
			{
				return this._RankRewardMailTemplateId;
			}
			set
			{
				this._RankRewardMailTemplateId = value;
			}
		}

		// Token: 0x06001D76 RID: 7542 RVA: 0x0009AE88 File Offset: 0x00099088
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06001D77 RID: 7543 RVA: 0x0009AE98 File Offset: 0x00099098
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

		// Token: 0x06001D78 RID: 7544 RVA: 0x0009AF64 File Offset: 0x00099164
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataArenaRankRewardInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04001194 RID: 4500
		private int _ID;

		// Token: 0x04001195 RID: 4501
		private string _Name;

		// Token: 0x04001196 RID: 4502
		private int _HighRank;

		// Token: 0x04001197 RID: 4503
		private int _LowRank;

		// Token: 0x04001198 RID: 4504
		private int _RankRewardMailTemplateId;

		// Token: 0x04001199 RID: 4505
		private IExtension extensionObject;

		// Token: 0x0400119A RID: 4506
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400119B RID: 4507
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400119C RID: 4508
		private LuaFunction m_ctor_hotfix;
	}
}
