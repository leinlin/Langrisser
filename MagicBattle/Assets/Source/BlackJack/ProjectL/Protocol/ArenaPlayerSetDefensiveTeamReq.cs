using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020005C1 RID: 1473
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ArenaPlayerSetDefensiveTeamReq")]
	[Serializable]
	public class ArenaPlayerSetDefensiveTeamReq : IExtensible
	{
		// Token: 0x06005329 RID: 21289 RVA: 0x00189A74 File Offset: 0x00187C74
		public ArenaPlayerSetDefensiveTeamReq()
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

		// Token: 0x1700145F RID: 5215
		// (get) Token: 0x0600532A RID: 21290 RVA: 0x00189ADC File Offset: 0x00187CDC
		// (set) Token: 0x0600532B RID: 21291 RVA: 0x00189AE4 File Offset: 0x00187CE4
		[ProtoMember(1, IsRequired = true, Name = "DefensiveTeam", DataFormat = DataFormat.Default)]
		public ProArenaPlayerDefensiveTeam DefensiveTeam
		{
			get
			{
				return this._DefensiveTeam;
			}
			set
			{
				this._DefensiveTeam = value;
			}
		}

		// Token: 0x0600532C RID: 21292 RVA: 0x00189AF0 File Offset: 0x00187CF0
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600532D RID: 21293 RVA: 0x00189B00 File Offset: 0x00187D00
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

		// Token: 0x0600532E RID: 21294 RVA: 0x00189BCC File Offset: 0x00187DCC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ArenaPlayerSetDefensiveTeamReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04003E79 RID: 15993
		private ProArenaPlayerDefensiveTeam _DefensiveTeam;

		// Token: 0x04003E7A RID: 15994
		private IExtension extensionObject;

		// Token: 0x04003E7B RID: 15995
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04003E7C RID: 15996
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04003E7D RID: 15997
		private LuaFunction m_ctor_hotfix;
	}
}
