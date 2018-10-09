using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000602 RID: 1538
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "BattleRoomHeroSetupNtf")]
	[Serializable]
	public class BattleRoomHeroSetupNtf : IExtensible
	{
		// Token: 0x06005552 RID: 21842 RVA: 0x00191368 File Offset: 0x0018F568
		public BattleRoomHeroSetupNtf()
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

		// Token: 0x170014FC RID: 5372
		// (get) Token: 0x06005553 RID: 21843 RVA: 0x001913DC File Offset: 0x0018F5DC
		[ProtoMember(1, Name = "ChangedInfos", DataFormat = DataFormat.Default)]
		public List<ProBattleHeroSetupInfo> ChangedInfos
		{
			get
			{
				return this._ChangedInfos;
			}
		}

		// Token: 0x06005554 RID: 21844 RVA: 0x001913E4 File Offset: 0x0018F5E4
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005555 RID: 21845 RVA: 0x001913F4 File Offset: 0x0018F5F4
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

		// Token: 0x06005556 RID: 21846 RVA: 0x001914C0 File Offset: 0x0018F6C0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattleRoomHeroSetupNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400401A RID: 16410
		private readonly List<ProBattleHeroSetupInfo> _ChangedInfos = new List<ProBattleHeroSetupInfo>();

		// Token: 0x0400401B RID: 16411
		private IExtension extensionObject;

		// Token: 0x0400401C RID: 16412
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400401D RID: 16413
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400401E RID: 16414
		private LuaFunction m_ctor_hotfix;
	}
}
