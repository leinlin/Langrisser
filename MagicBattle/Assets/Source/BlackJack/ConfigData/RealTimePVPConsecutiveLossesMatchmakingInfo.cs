using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000301 RID: 769
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "RealTimePVPConsecutiveLossesMatchmakingInfo")]
	[Serializable]
	public class RealTimePVPConsecutiveLossesMatchmakingInfo : IExtensible
	{
		// Token: 0x06002E2B RID: 11819 RVA: 0x000B8D64 File Offset: 0x000B6F64
		public RealTimePVPConsecutiveLossesMatchmakingInfo()
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

		// Token: 0x17000CFA RID: 3322
		// (get) Token: 0x06002E2C RID: 11820 RVA: 0x000B8DCC File Offset: 0x000B6FCC
		// (set) Token: 0x06002E2D RID: 11821 RVA: 0x000B8DD4 File Offset: 0x000B6FD4
		[ProtoMember(1, IsRequired = true, Name = "Count", DataFormat = DataFormat.TwosComplement)]
		public int Count
		{
			get
			{
				return this._Count;
			}
			set
			{
				this._Count = value;
			}
		}

		// Token: 0x17000CFB RID: 3323
		// (get) Token: 0x06002E2E RID: 11822 RVA: 0x000B8DE0 File Offset: 0x000B6FE0
		// (set) Token: 0x06002E2F RID: 11823 RVA: 0x000B8DE8 File Offset: 0x000B6FE8
		[ProtoMember(2, IsRequired = true, Name = "DanMin", DataFormat = DataFormat.TwosComplement)]
		public int DanMin
		{
			get
			{
				return this._DanMin;
			}
			set
			{
				this._DanMin = value;
			}
		}

		// Token: 0x17000CFC RID: 3324
		// (get) Token: 0x06002E30 RID: 11824 RVA: 0x000B8DF4 File Offset: 0x000B6FF4
		// (set) Token: 0x06002E31 RID: 11825 RVA: 0x000B8DFC File Offset: 0x000B6FFC
		[ProtoMember(3, IsRequired = true, Name = "DanMax", DataFormat = DataFormat.TwosComplement)]
		public int DanMax
		{
			get
			{
				return this._DanMax;
			}
			set
			{
				this._DanMax = value;
			}
		}

		// Token: 0x17000CFD RID: 3325
		// (get) Token: 0x06002E32 RID: 11826 RVA: 0x000B8E08 File Offset: 0x000B7008
		// (set) Token: 0x06002E33 RID: 11827 RVA: 0x000B8E10 File Offset: 0x000B7010
		[ProtoMember(4, IsRequired = true, Name = "IsBot", DataFormat = DataFormat.Default)]
		public bool IsBot
		{
			get
			{
				return this._IsBot;
			}
			set
			{
				this._IsBot = value;
			}
		}

		// Token: 0x17000CFE RID: 3326
		// (get) Token: 0x06002E34 RID: 11828 RVA: 0x000B8E1C File Offset: 0x000B701C
		// (set) Token: 0x06002E35 RID: 11829 RVA: 0x000B8E24 File Offset: 0x000B7024
		[ProtoMember(5, IsRequired = true, Name = "BotLevelAdjustment", DataFormat = DataFormat.TwosComplement)]
		public int BotLevelAdjustment
		{
			get
			{
				return this._BotLevelAdjustment;
			}
			set
			{
				this._BotLevelAdjustment = value;
			}
		}

		// Token: 0x06002E36 RID: 11830 RVA: 0x000B8E30 File Offset: 0x000B7030
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002E37 RID: 11831 RVA: 0x000B8E40 File Offset: 0x000B7040
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

		// Token: 0x06002E38 RID: 11832 RVA: 0x000B8F0C File Offset: 0x000B710C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(RealTimePVPConsecutiveLossesMatchmakingInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04002370 RID: 9072
		private int _Count;

		// Token: 0x04002371 RID: 9073
		private int _DanMin;

		// Token: 0x04002372 RID: 9074
		private int _DanMax;

		// Token: 0x04002373 RID: 9075
		private bool _IsBot;

		// Token: 0x04002374 RID: 9076
		private int _BotLevelAdjustment;

		// Token: 0x04002375 RID: 9077
		private IExtension extensionObject;

		// Token: 0x04002376 RID: 9078
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04002377 RID: 9079
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04002378 RID: 9080
		private LuaFunction m_ctor_hotfix;
	}
}
