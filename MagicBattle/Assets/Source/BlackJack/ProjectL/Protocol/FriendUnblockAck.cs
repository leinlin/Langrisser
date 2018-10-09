using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020006CA RID: 1738
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "FriendUnblockAck")]
	[Serializable]
	public class FriendUnblockAck : IExtensible
	{
		// Token: 0x06005D9E RID: 23966 RVA: 0x001A9A68 File Offset: 0x001A7C68
		public FriendUnblockAck()
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

		// Token: 0x170017CF RID: 6095
		// (get) Token: 0x06005D9F RID: 23967 RVA: 0x001A9AD0 File Offset: 0x001A7CD0
		// (set) Token: 0x06005DA0 RID: 23968 RVA: 0x001A9AD8 File Offset: 0x001A7CD8
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

		// Token: 0x170017D0 RID: 6096
		// (get) Token: 0x06005DA1 RID: 23969 RVA: 0x001A9AE4 File Offset: 0x001A7CE4
		// (set) Token: 0x06005DA2 RID: 23970 RVA: 0x001A9AEC File Offset: 0x001A7CEC
		[ProtoMember(2, IsRequired = true, Name = "Req", DataFormat = DataFormat.Default)]
		public FriendUnblockReq Req
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

		// Token: 0x06005DA3 RID: 23971 RVA: 0x001A9AF8 File Offset: 0x001A7CF8
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005DA4 RID: 23972 RVA: 0x001A9B08 File Offset: 0x001A7D08
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

		// Token: 0x06005DA5 RID: 23973 RVA: 0x001A9BD4 File Offset: 0x001A7DD4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(FriendUnblockAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400460D RID: 17933
		private int _Result;

		// Token: 0x0400460E RID: 17934
		private FriendUnblockReq _Req;

		// Token: 0x0400460F RID: 17935
		private IExtension extensionObject;

		// Token: 0x04004610 RID: 17936
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004611 RID: 17937
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004612 RID: 17938
		private LuaFunction m_ctor_hotfix;
	}
}
