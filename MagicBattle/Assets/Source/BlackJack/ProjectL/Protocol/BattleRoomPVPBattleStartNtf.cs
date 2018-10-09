using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000604 RID: 1540
	[ProtoContract(Name = "BattleRoomPVPBattleStartNtf")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class BattleRoomPVPBattleStartNtf : IExtensible
	{
		// Token: 0x0600555B RID: 21851 RVA: 0x001916D4 File Offset: 0x0018F8D4
		public BattleRoomPVPBattleStartNtf()
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

		// Token: 0x170014FD RID: 5373
		// (get) Token: 0x0600555C RID: 21852 RVA: 0x00191748 File Offset: 0x0018F948
		[ProtoMember(1, Name = "All", DataFormat = DataFormat.Default)]
		public List<ProBattleHeroSetupInfo> All
		{
			get
			{
				return this._All;
			}
		}

		// Token: 0x0600555D RID: 21853 RVA: 0x00191750 File Offset: 0x0018F950
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600555E RID: 21854 RVA: 0x00191760 File Offset: 0x0018F960
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

		// Token: 0x0600555F RID: 21855 RVA: 0x0019182C File Offset: 0x0018FA2C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattleRoomPVPBattleStartNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004023 RID: 16419
		private readonly List<ProBattleHeroSetupInfo> _All = new List<ProBattleHeroSetupInfo>();

		// Token: 0x04004024 RID: 16420
		private IExtension extensionObject;

		// Token: 0x04004025 RID: 16421
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004026 RID: 16422
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004027 RID: 16423
		private LuaFunction m_ctor_hotfix;
	}
}
