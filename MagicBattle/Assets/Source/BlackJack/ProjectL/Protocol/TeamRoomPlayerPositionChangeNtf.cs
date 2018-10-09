using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000849 RID: 2121
	[ProtoContract(Name = "TeamRoomPlayerPositionChangeNtf")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class TeamRoomPlayerPositionChangeNtf : IExtensible
	{
		// Token: 0x060069FF RID: 27135 RVA: 0x001DD2E8 File Offset: 0x001DB4E8
		public TeamRoomPlayerPositionChangeNtf()
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

		// Token: 0x17001B37 RID: 6967
		// (get) Token: 0x06006A00 RID: 27136 RVA: 0x001DD35C File Offset: 0x001DB55C
		[ProtoMember(1, Name = "PositionInfos", DataFormat = DataFormat.Default)]
		public List<ProTeamRoomPlayerPositionInfo> PositionInfos
		{
			get
			{
				return this._PositionInfos;
			}
		}

		// Token: 0x06006A01 RID: 27137 RVA: 0x001DD364 File Offset: 0x001DB564
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006A02 RID: 27138 RVA: 0x001DD374 File Offset: 0x001DB574
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

		// Token: 0x06006A03 RID: 27139 RVA: 0x001DD440 File Offset: 0x001DB640
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(TeamRoomPlayerPositionChangeNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040051B1 RID: 20913
		private readonly List<ProTeamRoomPlayerPositionInfo> _PositionInfos = new List<ProTeamRoomPlayerPositionInfo>();

		// Token: 0x040051B2 RID: 20914
		private IExtension extensionObject;

		// Token: 0x040051B3 RID: 20915
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040051B4 RID: 20916
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040051B5 RID: 20917
		private LuaFunction m_ctor_hotfix;
	}
}
