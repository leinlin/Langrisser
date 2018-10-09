using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020006CC RID: 1740
	[ProtoContract(Name = "FriendFindAck")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class FriendFindAck : IExtensible
	{
		// Token: 0x06005DAE RID: 23982 RVA: 0x001A9E10 File Offset: 0x001A8010
		public FriendFindAck()
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

		// Token: 0x170017D3 RID: 6099
		// (get) Token: 0x06005DAF RID: 23983 RVA: 0x001A9E84 File Offset: 0x001A8084
		// (set) Token: 0x06005DB0 RID: 23984 RVA: 0x001A9E8C File Offset: 0x001A808C
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

		// Token: 0x170017D4 RID: 6100
		// (get) Token: 0x06005DB1 RID: 23985 RVA: 0x001A9E98 File Offset: 0x001A8098
		[ProtoMember(2, Name = "Users", DataFormat = DataFormat.Default)]
		public List<ProUserSummary> Users
		{
			get
			{
				return this._Users;
			}
		}

		// Token: 0x06005DB2 RID: 23986 RVA: 0x001A9EA0 File Offset: 0x001A80A0
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005DB3 RID: 23987 RVA: 0x001A9EB0 File Offset: 0x001A80B0
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

		// Token: 0x06005DB4 RID: 23988 RVA: 0x001A9F7C File Offset: 0x001A817C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(FriendFindAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004619 RID: 17945
		private int _Result;

		// Token: 0x0400461A RID: 17946
		private readonly List<ProUserSummary> _Users = new List<ProUserSummary>();

		// Token: 0x0400461B RID: 17947
		private IExtension extensionObject;

		// Token: 0x0400461C RID: 17948
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400461D RID: 17949
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400461E RID: 17950
		private LuaFunction m_ctor_hotfix;
	}
}
