using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000859 RID: 2137
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "UnchartedScoreScoreLevelAttackAck")]
	[Serializable]
	public class UnchartedScoreScoreLevelAttackAck : IExtensible
	{
		// Token: 0x06006A95 RID: 27285 RVA: 0x001DF138 File Offset: 0x001DD338
		public UnchartedScoreScoreLevelAttackAck()
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

		// Token: 0x17001B65 RID: 7013
		// (get) Token: 0x06006A96 RID: 27286 RVA: 0x001DF1A0 File Offset: 0x001DD3A0
		// (set) Token: 0x06006A97 RID: 27287 RVA: 0x001DF1A8 File Offset: 0x001DD3A8
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

		// Token: 0x17001B66 RID: 7014
		// (get) Token: 0x06006A98 RID: 27288 RVA: 0x001DF1B4 File Offset: 0x001DD3B4
		// (set) Token: 0x06006A99 RID: 27289 RVA: 0x001DF1BC File Offset: 0x001DD3BC
		[ProtoMember(2, IsRequired = true, Name = "UnchartedScoreId", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17001B67 RID: 7015
		// (get) Token: 0x06006A9A RID: 27290 RVA: 0x001DF1C8 File Offset: 0x001DD3C8
		// (set) Token: 0x06006A9B RID: 27291 RVA: 0x001DF1D0 File Offset: 0x001DD3D0
		[ProtoMember(3, IsRequired = true, Name = "LevelId", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17001B68 RID: 7016
		// (get) Token: 0x06006A9C RID: 27292 RVA: 0x001DF1DC File Offset: 0x001DD3DC
		// (set) Token: 0x06006A9D RID: 27293 RVA: 0x001DF1E4 File Offset: 0x001DD3E4
		[ProtoMember(4, IsRequired = true, Name = "BattleBeginInfo", DataFormat = DataFormat.Default)]
		public ProBattleBeginInfo BattleBeginInfo
		{
			get
			{
				return this._BattleBeginInfo;
			}
			set
			{
				this._BattleBeginInfo = value;
			}
		}

		// Token: 0x06006A9E RID: 27294 RVA: 0x001DF1F0 File Offset: 0x001DD3F0
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006A9F RID: 27295 RVA: 0x001DF200 File Offset: 0x001DD400
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

		// Token: 0x06006AA0 RID: 27296 RVA: 0x001DF2CC File Offset: 0x001DD4CC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(UnchartedScoreScoreLevelAttackAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400521F RID: 21023
		private int _Result;

		// Token: 0x04005220 RID: 21024
		private int _UnchartedScoreId;

		// Token: 0x04005221 RID: 21025
		private int _LevelId;

		// Token: 0x04005222 RID: 21026
		private ProBattleBeginInfo _BattleBeginInfo;

		// Token: 0x04005223 RID: 21027
		private IExtension extensionObject;

		// Token: 0x04005224 RID: 21028
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04005225 RID: 21029
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04005226 RID: 21030
		private LuaFunction m_ctor_hotfix;
	}
}
