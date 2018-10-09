using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000857 RID: 2135
	[ProtoContract(Name = "UnchartedScoreChallengeLevelAttackAck")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class UnchartedScoreChallengeLevelAttackAck : IExtensible
	{
		// Token: 0x06006A81 RID: 27265 RVA: 0x001DED68 File Offset: 0x001DCF68
		public UnchartedScoreChallengeLevelAttackAck()
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

		// Token: 0x17001B5F RID: 7007
		// (get) Token: 0x06006A82 RID: 27266 RVA: 0x001DEDD0 File Offset: 0x001DCFD0
		// (set) Token: 0x06006A83 RID: 27267 RVA: 0x001DEDD8 File Offset: 0x001DCFD8
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

		// Token: 0x17001B60 RID: 7008
		// (get) Token: 0x06006A84 RID: 27268 RVA: 0x001DEDE4 File Offset: 0x001DCFE4
		// (set) Token: 0x06006A85 RID: 27269 RVA: 0x001DEDEC File Offset: 0x001DCFEC
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

		// Token: 0x17001B61 RID: 7009
		// (get) Token: 0x06006A86 RID: 27270 RVA: 0x001DEDF8 File Offset: 0x001DCFF8
		// (set) Token: 0x06006A87 RID: 27271 RVA: 0x001DEE00 File Offset: 0x001DD000
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

		// Token: 0x17001B62 RID: 7010
		// (get) Token: 0x06006A88 RID: 27272 RVA: 0x001DEE0C File Offset: 0x001DD00C
		// (set) Token: 0x06006A89 RID: 27273 RVA: 0x001DEE14 File Offset: 0x001DD014
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

		// Token: 0x06006A8A RID: 27274 RVA: 0x001DEE20 File Offset: 0x001DD020
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006A8B RID: 27275 RVA: 0x001DEE30 File Offset: 0x001DD030
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

		// Token: 0x06006A8C RID: 27276 RVA: 0x001DEEFC File Offset: 0x001DD0FC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(UnchartedScoreChallengeLevelAttackAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04005211 RID: 21009
		private int _Result;

		// Token: 0x04005212 RID: 21010
		private int _UnchartedScoreId;

		// Token: 0x04005213 RID: 21011
		private int _LevelId;

		// Token: 0x04005214 RID: 21012
		private ProBattleBeginInfo _BattleBeginInfo;

		// Token: 0x04005215 RID: 21013
		private IExtension extensionObject;

		// Token: 0x04005216 RID: 21014
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04005217 RID: 21015
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04005218 RID: 21016
		private LuaFunction m_ctor_hotfix;
	}
}
