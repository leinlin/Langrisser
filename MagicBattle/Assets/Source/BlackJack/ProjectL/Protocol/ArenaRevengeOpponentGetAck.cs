using System;
using System.Collections.Generic;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020005CA RID: 1482
	[ProtoContract(Name = "ArenaRevengeOpponentGetAck")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ArenaRevengeOpponentGetAck : IExtensible
	{
		// Token: 0x0600536D RID: 21357 RVA: 0x0018AAD4 File Offset: 0x00188CD4
		public ArenaRevengeOpponentGetAck()
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

		// Token: 0x17001470 RID: 5232
		// (get) Token: 0x0600536E RID: 21358 RVA: 0x0018AB48 File Offset: 0x00188D48
		// (set) Token: 0x0600536F RID: 21359 RVA: 0x0018AB50 File Offset: 0x00188D50
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

		// Token: 0x17001471 RID: 5233
		// (get) Token: 0x06005370 RID: 21360 RVA: 0x0018AB5C File Offset: 0x00188D5C
		// (set) Token: 0x06005371 RID: 21361 RVA: 0x0018AB64 File Offset: 0x00188D64
		[ProtoMember(2, IsRequired = true, Name = "ArenaBattleReportInstanceId", DataFormat = DataFormat.TwosComplement)]
		public ulong ArenaBattleReportInstanceId
		{
			get
			{
				return this._ArenaBattleReportInstanceId;
			}
			set
			{
				this._ArenaBattleReportInstanceId = value;
			}
		}

		// Token: 0x17001472 RID: 5234
		// (get) Token: 0x06005372 RID: 21362 RVA: 0x0018AB70 File Offset: 0x00188D70
		// (set) Token: 0x06005373 RID: 21363 RVA: 0x0018AB78 File Offset: 0x00188D78
		[ProtoMember(3, IsRequired = false, Name = "Opponent", DataFormat = DataFormat.Default)]
		[DefaultValue(null)]
		public ProArenaOpponent Opponent
		{
			get
			{
				return this._Opponent;
			}
			set
			{
				this._Opponent = value;
			}
		}

		// Token: 0x17001473 RID: 5235
		// (get) Token: 0x06005374 RID: 21364 RVA: 0x0018AB84 File Offset: 0x00188D84
		[ProtoMember(4, Name = "Heroes", DataFormat = DataFormat.Default)]
		public List<ProBattleHero> Heroes
		{
			get
			{
				return this._Heroes;
			}
		}

		// Token: 0x17001474 RID: 5236
		// (get) Token: 0x06005375 RID: 21365 RVA: 0x0018AB8C File Offset: 0x00188D8C
		// (set) Token: 0x06005376 RID: 21366 RVA: 0x0018AB94 File Offset: 0x00188D94
		[DefaultValue(0)]
		[ProtoMember(5, IsRequired = false, Name = "BattlePower", DataFormat = DataFormat.TwosComplement)]
		public int BattlePower
		{
			get
			{
				return this._BattlePower;
			}
			set
			{
				this._BattlePower = value;
			}
		}

		// Token: 0x06005377 RID: 21367 RVA: 0x0018ABA0 File Offset: 0x00188DA0
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005378 RID: 21368 RVA: 0x0018ABB0 File Offset: 0x00188DB0
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

		// Token: 0x06005379 RID: 21369 RVA: 0x0018AC7C File Offset: 0x00188E7C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ArenaRevengeOpponentGetAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04003EAE RID: 16046
		private int _Result;

		// Token: 0x04003EAF RID: 16047
		private ulong _ArenaBattleReportInstanceId;

		// Token: 0x04003EB0 RID: 16048
		private ProArenaOpponent _Opponent;

		// Token: 0x04003EB1 RID: 16049
		private readonly List<ProBattleHero> _Heroes = new List<ProBattleHero>();

		// Token: 0x04003EB2 RID: 16050
		private int _BattlePower;

		// Token: 0x04003EB3 RID: 16051
		private IExtension extensionObject;

		// Token: 0x04003EB4 RID: 16052
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04003EB5 RID: 16053
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04003EB6 RID: 16054
		private LuaFunction m_ctor_hotfix;
	}
}
