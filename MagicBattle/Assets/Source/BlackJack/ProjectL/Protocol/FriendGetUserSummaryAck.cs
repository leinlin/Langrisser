using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020006CE RID: 1742
	[ProtoContract(Name = "FriendGetUserSummaryAck")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class FriendGetUserSummaryAck : IExtensible
	{
		// Token: 0x06005DBC RID: 23996 RVA: 0x001AA1B8 File Offset: 0x001A83B8
		public FriendGetUserSummaryAck()
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

		// Token: 0x170017D7 RID: 6103
		// (get) Token: 0x06005DBD RID: 23997 RVA: 0x001AA22C File Offset: 0x001A842C
		// (set) Token: 0x06005DBE RID: 23998 RVA: 0x001AA234 File Offset: 0x001A8434
		[ProtoMember(1, IsRequired = true, Name = "Req", DataFormat = DataFormat.Default)]
		public FriendGetUserSummaryReq Req
		{
			get
			{
				return this._Req;
			}
			set
			{
				this._Req = value;
			}
		}

		// Token: 0x170017D8 RID: 6104
		// (get) Token: 0x06005DBF RID: 23999 RVA: 0x001AA240 File Offset: 0x001A8440
		// (set) Token: 0x06005DC0 RID: 24000 RVA: 0x001AA248 File Offset: 0x001A8448
		[ProtoMember(2, IsRequired = true, Name = "Result", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x170017D9 RID: 6105
		// (get) Token: 0x06005DC1 RID: 24001 RVA: 0x001AA254 File Offset: 0x001A8454
		[ProtoMember(3, Name = "Users", DataFormat = DataFormat.Default)]
		public List<ProUserSummary> Users
		{
			get
			{
				return this._Users;
			}
		}

		// Token: 0x06005DC2 RID: 24002 RVA: 0x001AA25C File Offset: 0x001A845C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005DC3 RID: 24003 RVA: 0x001AA26C File Offset: 0x001A846C
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

		// Token: 0x06005DC4 RID: 24004 RVA: 0x001AA338 File Offset: 0x001A8538
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(FriendGetUserSummaryAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004625 RID: 17957
		private FriendGetUserSummaryReq _Req;

		// Token: 0x04004626 RID: 17958
		private int _Result;

		// Token: 0x04004627 RID: 17959
		private readonly List<ProUserSummary> _Users = new List<ProUserSummary>();

		// Token: 0x04004628 RID: 17960
		private IExtension extensionObject;

		// Token: 0x04004629 RID: 17961
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400462A RID: 17962
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400462B RID: 17963
		private LuaFunction m_ctor_hotfix;
	}
}
