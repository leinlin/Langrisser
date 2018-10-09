using System;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020005BB RID: 1467
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ArenaOpponentRevengeAck")]
	[Serializable]
	public class ArenaOpponentRevengeAck : IExtensible
	{
		// Token: 0x060052F5 RID: 21237 RVA: 0x00188F40 File Offset: 0x00187140
		public ArenaOpponentRevengeAck()
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

		// Token: 0x17001450 RID: 5200
		// (get) Token: 0x060052F6 RID: 21238 RVA: 0x00188FA8 File Offset: 0x001871A8
		// (set) Token: 0x060052F7 RID: 21239 RVA: 0x00188FB0 File Offset: 0x001871B0
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

		// Token: 0x17001451 RID: 5201
		// (get) Token: 0x060052F8 RID: 21240 RVA: 0x00188FBC File Offset: 0x001871BC
		// (set) Token: 0x060052F9 RID: 21241 RVA: 0x00188FC4 File Offset: 0x001871C4
		[ProtoMember(2, IsRequired = true, Name = "BattleReportInstanceId", DataFormat = DataFormat.TwosComplement)]
		public ulong BattleReportInstanceId
		{
			get
			{
				return this._BattleReportInstanceId;
			}
			set
			{
				this._BattleReportInstanceId = value;
			}
		}

		// Token: 0x17001452 RID: 5202
		// (get) Token: 0x060052FA RID: 21242 RVA: 0x00188FD0 File Offset: 0x001871D0
		// (set) Token: 0x060052FB RID: 21243 RVA: 0x00188FD8 File Offset: 0x001871D8
		[ProtoMember(3, IsRequired = true, Name = "AutoBattle", DataFormat = DataFormat.Default)]
		public bool AutoBattle
		{
			get
			{
				return this._AutoBattle;
			}
			set
			{
				this._AutoBattle = value;
			}
		}

		// Token: 0x17001453 RID: 5203
		// (get) Token: 0x060052FC RID: 21244 RVA: 0x00188FE4 File Offset: 0x001871E4
		// (set) Token: 0x060052FD RID: 21245 RVA: 0x00188FEC File Offset: 0x001871EC
		[DefaultValue(null)]
		[ProtoMember(4, IsRequired = false, Name = "OpponentDefensiveBattleInfo", DataFormat = DataFormat.Default)]
		public ProArenaDefensiveBattleInfo OpponentDefensiveBattleInfo
		{
			get
			{
				return this._OpponentDefensiveBattleInfo;
			}
			set
			{
				this._OpponentDefensiveBattleInfo = value;
			}
		}

		// Token: 0x060052FE RID: 21246 RVA: 0x00188FF8 File Offset: 0x001871F8
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060052FF RID: 21247 RVA: 0x00189008 File Offset: 0x00187208
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

		// Token: 0x06005300 RID: 21248 RVA: 0x001890D4 File Offset: 0x001872D4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ArenaOpponentRevengeAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04003E52 RID: 15954
		private int _Result;

		// Token: 0x04003E53 RID: 15955
		private ulong _BattleReportInstanceId;

		// Token: 0x04003E54 RID: 15956
		private bool _AutoBattle;

		// Token: 0x04003E55 RID: 15957
		private ProArenaDefensiveBattleInfo _OpponentDefensiveBattleInfo;

		// Token: 0x04003E56 RID: 15958
		private IExtension extensionObject;

		// Token: 0x04003E57 RID: 15959
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04003E58 RID: 15960
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04003E59 RID: 15961
		private LuaFunction m_ctor_hotfix;
	}
}
