using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200085C RID: 2140
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "UnchartedScoreScoreLevelBattleFinishedReq")]
	[Serializable]
	public class UnchartedScoreScoreLevelBattleFinishedReq : IExtensible
	{
		// Token: 0x06006ABE RID: 27326 RVA: 0x001DF778 File Offset: 0x001DD978
		public UnchartedScoreScoreLevelBattleFinishedReq()
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

		// Token: 0x17001B75 RID: 7029
		// (get) Token: 0x06006ABF RID: 27327 RVA: 0x001DF7E0 File Offset: 0x001DD9E0
		// (set) Token: 0x06006AC0 RID: 27328 RVA: 0x001DF7E8 File Offset: 0x001DD9E8
		[ProtoMember(1, IsRequired = true, Name = "UnchartedScoreId", DataFormat = DataFormat.TwosComplement)]
		public int UnchartedScoreId
		{
			get
			{
				return this._UnchartedScoreId;
			}
			set
			{
				this._UnchartedScoreId = value;
			}
		}

		// Token: 0x17001B76 RID: 7030
		// (get) Token: 0x06006AC1 RID: 27329 RVA: 0x001DF7F4 File Offset: 0x001DD9F4
		// (set) Token: 0x06006AC2 RID: 27330 RVA: 0x001DF7FC File Offset: 0x001DD9FC
		[ProtoMember(2, IsRequired = true, Name = "LevelId", DataFormat = DataFormat.TwosComplement)]
		public int LevelId
		{
			get
			{
				return this._LevelId;
			}
			set
			{
				this._LevelId = value;
			}
		}

		// Token: 0x17001B77 RID: 7031
		// (get) Token: 0x06006AC3 RID: 27331 RVA: 0x001DF808 File Offset: 0x001DDA08
		// (set) Token: 0x06006AC4 RID: 27332 RVA: 0x001DF810 File Offset: 0x001DDA10
		[ProtoMember(3, IsRequired = true, Name = "BattleReport", DataFormat = DataFormat.Default)]
		public ProBattleReport BattleReport
		{
			get
			{
				return this._BattleReport;
			}
			set
			{
				this._BattleReport = value;
			}
		}

		// Token: 0x06006AC5 RID: 27333 RVA: 0x001DF81C File Offset: 0x001DDA1C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006AC6 RID: 27334 RVA: 0x001DF82C File Offset: 0x001DDA2C
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

		// Token: 0x06006AC7 RID: 27335 RVA: 0x001DF8F8 File Offset: 0x001DDAF8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(UnchartedScoreScoreLevelBattleFinishedReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400523B RID: 21051
		private int _UnchartedScoreId;

		// Token: 0x0400523C RID: 21052
		private int _LevelId;

		// Token: 0x0400523D RID: 21053
		private ProBattleReport _BattleReport;

		// Token: 0x0400523E RID: 21054
		private IExtension extensionObject;

		// Token: 0x0400523F RID: 21055
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04005240 RID: 21056
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04005241 RID: 21057
		private LuaFunction m_ctor_hotfix;
	}
}
