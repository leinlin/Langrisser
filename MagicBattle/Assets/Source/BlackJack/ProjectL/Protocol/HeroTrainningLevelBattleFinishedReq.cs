using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020007D9 RID: 2009
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "HeroTrainningLevelBattleFinishedReq")]
	[Serializable]
	public class HeroTrainningLevelBattleFinishedReq : IExtensible
	{
		// Token: 0x06006674 RID: 26228 RVA: 0x001C90B0 File Offset: 0x001C72B0
		public HeroTrainningLevelBattleFinishedReq()
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

		// Token: 0x17001A44 RID: 6724
		// (get) Token: 0x06006675 RID: 26229 RVA: 0x001C9118 File Offset: 0x001C7318
		// (set) Token: 0x06006676 RID: 26230 RVA: 0x001C9120 File Offset: 0x001C7320
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

		// Token: 0x17001A45 RID: 6725
		// (get) Token: 0x06006677 RID: 26231 RVA: 0x001C912C File Offset: 0x001C732C
		// (set) Token: 0x06006678 RID: 26232 RVA: 0x001C9134 File Offset: 0x001C7334
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

		// Token: 0x06006679 RID: 26233 RVA: 0x001C9140 File Offset: 0x001C7340
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600667A RID: 26234 RVA: 0x001C9150 File Offset: 0x001C7350
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

		// Token: 0x0600667B RID: 26235 RVA: 0x001C921C File Offset: 0x001C741C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroTrainningLevelBattleFinishedReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004CBE RID: 19646
		private int _LevelId;

		// Token: 0x04004CBF RID: 19647
		private ProBattleReport _BattleReport;

		// Token: 0x04004CC0 RID: 19648
		private IExtension extensionObject;

		// Token: 0x04004CC1 RID: 19649
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004CC2 RID: 19650
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004CC3 RID: 19651
		private LuaFunction m_ctor_hotfix;
	}
}
