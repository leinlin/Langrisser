using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x0200023C RID: 572
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ConfigDataGuildMassiveCombatIndividualPointsRewardsInfo")]
	[Serializable]
	public class ConfigDataGuildMassiveCombatIndividualPointsRewardsInfo : IExtensible
	{
		// Token: 0x0600234C RID: 9036 RVA: 0x000A4F60 File Offset: 0x000A3160
		public ConfigDataGuildMassiveCombatIndividualPointsRewardsInfo()
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

		// Token: 0x17000841 RID: 2113
		// (get) Token: 0x0600234D RID: 9037 RVA: 0x000A4FD4 File Offset: 0x000A31D4
		// (set) Token: 0x0600234E RID: 9038 RVA: 0x000A4FDC File Offset: 0x000A31DC
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

		// Token: 0x17000842 RID: 2114
		// (get) Token: 0x0600234F RID: 9039 RVA: 0x000A4FE8 File Offset: 0x000A31E8
		// (set) Token: 0x06002350 RID: 9040 RVA: 0x000A4FF0 File Offset: 0x000A31F0
		[ProtoMember(3, IsRequired = true, Name = "RewardGroupID", DataFormat = DataFormat.TwosComplement)]
		public int RewardGroupID
		{
			get
			{
				return this._RewardGroupID;
			}
			set
			{
				this._RewardGroupID = value;
			}
		}

		// Token: 0x17000843 RID: 2115
		// (get) Token: 0x06002351 RID: 9041 RVA: 0x000A4FFC File Offset: 0x000A31FC
		[ProtoMember(4, Name = "RewardItems", DataFormat = DataFormat.Default)]
		public List<Goods> RewardItems
		{
			get
			{
				return this._RewardItems;
			}
		}

		// Token: 0x17000844 RID: 2116
		// (get) Token: 0x06002352 RID: 9042 RVA: 0x000A5004 File Offset: 0x000A3204
		// (set) Token: 0x06002353 RID: 9043 RVA: 0x000A500C File Offset: 0x000A320C
		[ProtoMember(5, IsRequired = true, Name = "Points", DataFormat = DataFormat.TwosComplement)]
		public int Points
		{
			get
			{
				return this._Points;
			}
			set
			{
				this._Points = value;
			}
		}

		// Token: 0x06002354 RID: 9044 RVA: 0x000A5018 File Offset: 0x000A3218
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002355 RID: 9045 RVA: 0x000A5028 File Offset: 0x000A3228
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

		// Token: 0x06002356 RID: 9046 RVA: 0x000A50F4 File Offset: 0x000A32F4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataGuildMassiveCombatIndividualPointsRewardsInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400155F RID: 5471
		private int _ID;

		// Token: 0x04001560 RID: 5472
		private int _RewardGroupID;

		// Token: 0x04001561 RID: 5473
		private readonly List<Goods> _RewardItems = new List<Goods>();

		// Token: 0x04001562 RID: 5474
		private int _Points;

		// Token: 0x04001563 RID: 5475
		private IExtension extensionObject;

		// Token: 0x04001564 RID: 5476
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04001565 RID: 5477
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04001566 RID: 5478
		private LuaFunction m_ctor_hotfix;
	}
}
