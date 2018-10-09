using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020005B0 RID: 1456
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "AnikiGymLevelBattleFinishedReq")]
	[Serializable]
	public class AnikiGymLevelBattleFinishedReq : IExtensible
	{
		// Token: 0x0600529D RID: 21149 RVA: 0x00187B00 File Offset: 0x00185D00
		public AnikiGymLevelBattleFinishedReq()
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

		// Token: 0x17001438 RID: 5176
		// (get) Token: 0x0600529E RID: 21150 RVA: 0x00187B68 File Offset: 0x00185D68
		// (set) Token: 0x0600529F RID: 21151 RVA: 0x00187B70 File Offset: 0x00185D70
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

		// Token: 0x17001439 RID: 5177
		// (get) Token: 0x060052A0 RID: 21152 RVA: 0x00187B7C File Offset: 0x00185D7C
		// (set) Token: 0x060052A1 RID: 21153 RVA: 0x00187B84 File Offset: 0x00185D84
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

		// Token: 0x060052A2 RID: 21154 RVA: 0x00187B90 File Offset: 0x00185D90
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060052A3 RID: 21155 RVA: 0x00187BA0 File Offset: 0x00185DA0
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

		// Token: 0x060052A4 RID: 21156 RVA: 0x00187C6C File Offset: 0x00185E6C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(AnikiGymLevelBattleFinishedReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04003E0E RID: 15886
		private int _LevelId;

		// Token: 0x04003E0F RID: 15887
		private ProBattleReport _BattleReport;

		// Token: 0x04003E10 RID: 15888
		private IExtension extensionObject;

		// Token: 0x04003E11 RID: 15889
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04003E12 RID: 15890
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04003E13 RID: 15891
		private LuaFunction m_ctor_hotfix;
	}
}
