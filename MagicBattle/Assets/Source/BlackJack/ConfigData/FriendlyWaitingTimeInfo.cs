using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000303 RID: 771
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "FriendlyWaitingTimeInfo")]
	[Serializable]
	public class FriendlyWaitingTimeInfo : IExtensible
	{
		// Token: 0x06002E45 RID: 11845 RVA: 0x000B9170 File Offset: 0x000B7370
		public FriendlyWaitingTimeInfo()
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

		// Token: 0x17000D03 RID: 3331
		// (get) Token: 0x06002E46 RID: 11846 RVA: 0x000B91D8 File Offset: 0x000B73D8
		// (set) Token: 0x06002E47 RID: 11847 RVA: 0x000B91E0 File Offset: 0x000B73E0
		[ProtoMember(1, IsRequired = true, Name = "WaitingTime", DataFormat = DataFormat.TwosComplement)]
		public int WaitingTime
		{
			get
			{
				return this._WaitingTime;
			}
			set
			{
				this._WaitingTime = value;
			}
		}

		// Token: 0x17000D04 RID: 3332
		// (get) Token: 0x06002E48 RID: 11848 RVA: 0x000B91EC File Offset: 0x000B73EC
		// (set) Token: 0x06002E49 RID: 11849 RVA: 0x000B91F4 File Offset: 0x000B73F4
		[ProtoMember(2, IsRequired = true, Name = "TopBattlePowerMin", DataFormat = DataFormat.TwosComplement)]
		public int TopBattlePowerMin
		{
			get
			{
				return this._TopBattlePowerMin;
			}
			set
			{
				this._TopBattlePowerMin = value;
			}
		}

		// Token: 0x17000D05 RID: 3333
		// (get) Token: 0x06002E4A RID: 11850 RVA: 0x000B9200 File Offset: 0x000B7400
		// (set) Token: 0x06002E4B RID: 11851 RVA: 0x000B9208 File Offset: 0x000B7408
		[ProtoMember(3, IsRequired = true, Name = "TopBattlePowerMax", DataFormat = DataFormat.TwosComplement)]
		public int TopBattlePowerMax
		{
			get
			{
				return this._TopBattlePowerMax;
			}
			set
			{
				this._TopBattlePowerMax = value;
			}
		}

		// Token: 0x06002E4C RID: 11852 RVA: 0x000B9214 File Offset: 0x000B7414
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002E4D RID: 11853 RVA: 0x000B9224 File Offset: 0x000B7424
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

		// Token: 0x06002E4E RID: 11854 RVA: 0x000B92F0 File Offset: 0x000B74F0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(FriendlyWaitingTimeInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04002381 RID: 9089
		private int _WaitingTime;

		// Token: 0x04002382 RID: 9090
		private int _TopBattlePowerMin;

		// Token: 0x04002383 RID: 9091
		private int _TopBattlePowerMax;

		// Token: 0x04002384 RID: 9092
		private IExtension extensionObject;

		// Token: 0x04002385 RID: 9093
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04002386 RID: 9094
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04002387 RID: 9095
		private LuaFunction m_ctor_hotfix;
	}
}
