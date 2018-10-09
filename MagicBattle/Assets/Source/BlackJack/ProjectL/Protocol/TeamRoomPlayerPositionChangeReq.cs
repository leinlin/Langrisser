using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200083E RID: 2110
	[ProtoContract(Name = "TeamRoomPlayerPositionChangeReq")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class TeamRoomPlayerPositionChangeReq : IExtensible
	{
		// Token: 0x060069B6 RID: 27062 RVA: 0x001DBF58 File Offset: 0x001DA158
		public TeamRoomPlayerPositionChangeReq()
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

		// Token: 0x17001B28 RID: 6952
		// (get) Token: 0x060069B7 RID: 27063 RVA: 0x001DBFCC File Offset: 0x001DA1CC
		[ProtoMember(1, Name = "PositionInfos", DataFormat = DataFormat.Default)]
		public List<ProTeamRoomPlayerPositionInfo> PositionInfos
		{
			get
			{
				return this._PositionInfos;
			}
		}

		// Token: 0x060069B8 RID: 27064 RVA: 0x001DBFD4 File Offset: 0x001DA1D4
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060069B9 RID: 27065 RVA: 0x001DBFE4 File Offset: 0x001DA1E4
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

		// Token: 0x060069BA RID: 27066 RVA: 0x001DC0B0 File Offset: 0x001DA2B0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(TeamRoomPlayerPositionChangeReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04005176 RID: 20854
		private readonly List<ProTeamRoomPlayerPositionInfo> _PositionInfos = new List<ProTeamRoomPlayerPositionInfo>();

		// Token: 0x04005177 RID: 20855
		private IExtension extensionObject;

		// Token: 0x04005178 RID: 20856
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04005179 RID: 20857
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400517A RID: 20858
		private LuaFunction m_ctor_hotfix;
	}
}
