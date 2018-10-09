using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020005C2 RID: 1474
	[ProtoContract(Name = "ArenaPlayerSetDefensiveTeamAck")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ArenaPlayerSetDefensiveTeamAck : IExtensible
	{
		// Token: 0x0600532F RID: 21295 RVA: 0x00189C34 File Offset: 0x00187E34
		public ArenaPlayerSetDefensiveTeamAck()
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

		// Token: 0x17001460 RID: 5216
		// (get) Token: 0x06005330 RID: 21296 RVA: 0x00189C9C File Offset: 0x00187E9C
		// (set) Token: 0x06005331 RID: 21297 RVA: 0x00189CA4 File Offset: 0x00187EA4
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

		// Token: 0x17001461 RID: 5217
		// (get) Token: 0x06005332 RID: 21298 RVA: 0x00189CB0 File Offset: 0x00187EB0
		// (set) Token: 0x06005333 RID: 21299 RVA: 0x00189CB8 File Offset: 0x00187EB8
		[ProtoMember(2, IsRequired = true, Name = "DefensiveTeam", DataFormat = DataFormat.Default)]
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

		// Token: 0x06005334 RID: 21300 RVA: 0x00189CC4 File Offset: 0x00187EC4
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005335 RID: 21301 RVA: 0x00189CD4 File Offset: 0x00187ED4
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

		// Token: 0x06005336 RID: 21302 RVA: 0x00189DA0 File Offset: 0x00187FA0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ArenaPlayerSetDefensiveTeamAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04003E7E RID: 15998
		private int _Result;

		// Token: 0x04003E7F RID: 15999
		private ProArenaPlayerDefensiveTeam _DefensiveTeam;

		// Token: 0x04003E80 RID: 16000
		private IExtension extensionObject;

		// Token: 0x04003E81 RID: 16001
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04003E82 RID: 16002
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04003E83 RID: 16003
		private LuaFunction m_ctor_hotfix;
	}
}
