using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000302 RID: 770
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "RealTimePVPMatchmakingFailInfo")]
	[Serializable]
	public class RealTimePVPMatchmakingFailInfo : IExtensible
	{
		// Token: 0x06002E39 RID: 11833 RVA: 0x000B8F74 File Offset: 0x000B7174
		public RealTimePVPMatchmakingFailInfo()
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

		// Token: 0x17000CFF RID: 3327
		// (get) Token: 0x06002E3A RID: 11834 RVA: 0x000B8FDC File Offset: 0x000B71DC
		// (set) Token: 0x06002E3B RID: 11835 RVA: 0x000B8FE4 File Offset: 0x000B71E4
		[ProtoMember(1, IsRequired = true, Name = "DanMin", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17000D00 RID: 3328
		// (get) Token: 0x06002E3C RID: 11836 RVA: 0x000B8FF0 File Offset: 0x000B71F0
		// (set) Token: 0x06002E3D RID: 11837 RVA: 0x000B8FF8 File Offset: 0x000B71F8
		[ProtoMember(2, IsRequired = true, Name = "DanMax", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17000D01 RID: 3329
		// (get) Token: 0x06002E3E RID: 11838 RVA: 0x000B9004 File Offset: 0x000B7204
		// (set) Token: 0x06002E3F RID: 11839 RVA: 0x000B900C File Offset: 0x000B720C
		[ProtoMember(3, IsRequired = true, Name = "IsBot", DataFormat = DataFormat.Default)]
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

		// Token: 0x17000D02 RID: 3330
		// (get) Token: 0x06002E40 RID: 11840 RVA: 0x000B9018 File Offset: 0x000B7218
		// (set) Token: 0x06002E41 RID: 11841 RVA: 0x000B9020 File Offset: 0x000B7220
		[ProtoMember(4, IsRequired = true, Name = "BotLevelAdjustment", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x06002E42 RID: 11842 RVA: 0x000B902C File Offset: 0x000B722C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002E43 RID: 11843 RVA: 0x000B903C File Offset: 0x000B723C
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

		// Token: 0x06002E44 RID: 11844 RVA: 0x000B9108 File Offset: 0x000B7308
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(RealTimePVPMatchmakingFailInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04002379 RID: 9081
		private int _DanMin;

		// Token: 0x0400237A RID: 9082
		private int _DanMax;

		// Token: 0x0400237B RID: 9083
		private bool _IsBot;

		// Token: 0x0400237C RID: 9084
		private int _BotLevelAdjustment;

		// Token: 0x0400237D RID: 9085
		private IExtension extensionObject;

		// Token: 0x0400237E RID: 9086
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400237F RID: 9087
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04002380 RID: 9088
		private LuaFunction m_ctor_hotfix;
	}
}
