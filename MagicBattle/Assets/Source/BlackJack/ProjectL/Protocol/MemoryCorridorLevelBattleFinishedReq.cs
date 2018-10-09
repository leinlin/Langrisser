using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020007F3 RID: 2035
	[ProtoContract(Name = "MemoryCorridorLevelBattleFinishedReq")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class MemoryCorridorLevelBattleFinishedReq : IExtensible
	{
		// Token: 0x06006751 RID: 26449 RVA: 0x001CC118 File Offset: 0x001CA318
		public MemoryCorridorLevelBattleFinishedReq()
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

		// Token: 0x17001A83 RID: 6787
		// (get) Token: 0x06006752 RID: 26450 RVA: 0x001CC180 File Offset: 0x001CA380
		// (set) Token: 0x06006753 RID: 26451 RVA: 0x001CC188 File Offset: 0x001CA388
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

		// Token: 0x17001A84 RID: 6788
		// (get) Token: 0x06006754 RID: 26452 RVA: 0x001CC194 File Offset: 0x001CA394
		// (set) Token: 0x06006755 RID: 26453 RVA: 0x001CC19C File Offset: 0x001CA39C
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

		// Token: 0x06006756 RID: 26454 RVA: 0x001CC1A8 File Offset: 0x001CA3A8
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006757 RID: 26455 RVA: 0x001CC1B8 File Offset: 0x001CA3B8
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

		// Token: 0x06006758 RID: 26456 RVA: 0x001CC284 File Offset: 0x001CA484
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(MemoryCorridorLevelBattleFinishedReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004D65 RID: 19813
		private int _LevelId;

		// Token: 0x04004D66 RID: 19814
		private ProBattleReport _BattleReport;

		// Token: 0x04004D67 RID: 19815
		private IExtension extensionObject;

		// Token: 0x04004D68 RID: 19816
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004D69 RID: 19817
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004D6A RID: 19818
		private LuaFunction m_ctor_hotfix;
	}
}
