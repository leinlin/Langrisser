using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200084C RID: 2124
	[ProtoContract(Name = "ThearchyTrialLevelBattleFinishedReq")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ThearchyTrialLevelBattleFinishedReq : IExtensible
	{
		// Token: 0x06006A14 RID: 27156 RVA: 0x001DD850 File Offset: 0x001DBA50
		public ThearchyTrialLevelBattleFinishedReq()
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

		// Token: 0x17001B3C RID: 6972
		// (get) Token: 0x06006A15 RID: 27157 RVA: 0x001DD8B8 File Offset: 0x001DBAB8
		// (set) Token: 0x06006A16 RID: 27158 RVA: 0x001DD8C0 File Offset: 0x001DBAC0
		[ProtoMember(1, IsRequired = true, Name = "LevelId", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17001B3D RID: 6973
		// (get) Token: 0x06006A17 RID: 27159 RVA: 0x001DD8CC File Offset: 0x001DBACC
		// (set) Token: 0x06006A18 RID: 27160 RVA: 0x001DD8D4 File Offset: 0x001DBAD4
		[ProtoMember(2, IsRequired = true, Name = "BattleReport", DataFormat = DataFormat.Default)]
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

		// Token: 0x06006A19 RID: 27161 RVA: 0x001DD8E0 File Offset: 0x001DBAE0
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006A1A RID: 27162 RVA: 0x001DD8F0 File Offset: 0x001DBAF0
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

		// Token: 0x06006A1B RID: 27163 RVA: 0x001DD9BC File Offset: 0x001DBBBC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ThearchyTrialLevelBattleFinishedReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040051C2 RID: 20930
		private int _LevelId;

		// Token: 0x040051C3 RID: 20931
		private ProBattleReport _BattleReport;

		// Token: 0x040051C4 RID: 20932
		private IExtension extensionObject;

		// Token: 0x040051C5 RID: 20933
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040051C6 RID: 20934
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040051C7 RID: 20935
		private LuaFunction m_ctor_hotfix;
	}
}
