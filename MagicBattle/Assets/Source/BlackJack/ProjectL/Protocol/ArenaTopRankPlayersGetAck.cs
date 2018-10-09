using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020005BD RID: 1469
	[ProtoContract(Name = "ArenaTopRankPlayersGetAck")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ArenaTopRankPlayersGetAck : IExtensible
	{
		// Token: 0x06005305 RID: 21253 RVA: 0x001892E8 File Offset: 0x001874E8
		public ArenaTopRankPlayersGetAck()
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

		// Token: 0x17001454 RID: 5204
		// (get) Token: 0x06005306 RID: 21254 RVA: 0x0018935C File Offset: 0x0018755C
		// (set) Token: 0x06005307 RID: 21255 RVA: 0x00189364 File Offset: 0x00187564
		[ProtoMember(1, IsRequired = true, Name = "Result", DataFormat = DataFormat.TwosComplement)]
		public int Result
		{
			get
			{
				return this._Result;
			}
			set
			{
				this._Result = value;
			}
		}

		// Token: 0x17001455 RID: 5205
		// (get) Token: 0x06005308 RID: 21256 RVA: 0x00189370 File Offset: 0x00187570
		// (set) Token: 0x06005309 RID: 21257 RVA: 0x00189378 File Offset: 0x00187578
		[ProtoMember(2, IsRequired = true, Name = "MineRank", DataFormat = DataFormat.TwosComplement)]
		public int MineRank
		{
			get
			{
				return this._MineRank;
			}
			set
			{
				this._MineRank = value;
			}
		}

		// Token: 0x17001456 RID: 5206
		// (get) Token: 0x0600530A RID: 21258 RVA: 0x00189384 File Offset: 0x00187584
		[ProtoMember(3, Name = "TopRankPlayers", DataFormat = DataFormat.Default)]
		public List<ProArenaTopRankPlayer> TopRankPlayers
		{
			get
			{
				return this._TopRankPlayers;
			}
		}

		// Token: 0x0600530B RID: 21259 RVA: 0x0018938C File Offset: 0x0018758C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600530C RID: 21260 RVA: 0x0018939C File Offset: 0x0018759C
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

		// Token: 0x0600530D RID: 21261 RVA: 0x00189468 File Offset: 0x00187668
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ArenaTopRankPlayersGetAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04003E5E RID: 15966
		private int _Result;

		// Token: 0x04003E5F RID: 15967
		private int _MineRank;

		// Token: 0x04003E60 RID: 15968
		private readonly List<ProArenaTopRankPlayer> _TopRankPlayers = new List<ProArenaTopRankPlayer>();

		// Token: 0x04003E61 RID: 15969
		private IExtension extensionObject;

		// Token: 0x04003E62 RID: 15970
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04003E63 RID: 15971
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04003E64 RID: 15972
		private LuaFunction m_ctor_hotfix;
	}
}
