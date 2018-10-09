using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200085A RID: 2138
	[ProtoContract(Name = "UnchartedScoreChallengeLevelBattleFinishedReq")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class UnchartedScoreChallengeLevelBattleFinishedReq : IExtensible
	{
		// Token: 0x06006AA1 RID: 27297 RVA: 0x001DF334 File Offset: 0x001DD534
		public UnchartedScoreChallengeLevelBattleFinishedReq()
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

		// Token: 0x17001B69 RID: 7017
		// (get) Token: 0x06006AA2 RID: 27298 RVA: 0x001DF39C File Offset: 0x001DD59C
		// (set) Token: 0x06006AA3 RID: 27299 RVA: 0x001DF3A4 File Offset: 0x001DD5A4
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

		// Token: 0x17001B6A RID: 7018
		// (get) Token: 0x06006AA4 RID: 27300 RVA: 0x001DF3B0 File Offset: 0x001DD5B0
		// (set) Token: 0x06006AA5 RID: 27301 RVA: 0x001DF3B8 File Offset: 0x001DD5B8
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

		// Token: 0x17001B6B RID: 7019
		// (get) Token: 0x06006AA6 RID: 27302 RVA: 0x001DF3C4 File Offset: 0x001DD5C4
		// (set) Token: 0x06006AA7 RID: 27303 RVA: 0x001DF3CC File Offset: 0x001DD5CC
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

		// Token: 0x06006AA8 RID: 27304 RVA: 0x001DF3D8 File Offset: 0x001DD5D8
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006AA9 RID: 27305 RVA: 0x001DF3E8 File Offset: 0x001DD5E8
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

		// Token: 0x06006AAA RID: 27306 RVA: 0x001DF4B4 File Offset: 0x001DD6B4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(UnchartedScoreChallengeLevelBattleFinishedReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04005227 RID: 21031
		private int _UnchartedScoreId;

		// Token: 0x04005228 RID: 21032
		private int _LevelId;

		// Token: 0x04005229 RID: 21033
		private ProBattleReport _BattleReport;

		// Token: 0x0400522A RID: 21034
		private IExtension extensionObject;

		// Token: 0x0400522B RID: 21035
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400522C RID: 21036
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400522D RID: 21037
		private LuaFunction m_ctor_hotfix;
	}
}
