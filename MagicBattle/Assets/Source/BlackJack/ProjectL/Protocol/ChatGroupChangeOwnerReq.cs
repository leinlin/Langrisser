using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200061A RID: 1562
	[ProtoContract(Name = "ChatGroupChangeOwnerReq")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ChatGroupChangeOwnerReq : IExtensible
	{
		// Token: 0x0600561A RID: 22042 RVA: 0x0019401C File Offset: 0x0019221C
		public ChatGroupChangeOwnerReq()
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

		// Token: 0x17001537 RID: 5431
		// (get) Token: 0x0600561B RID: 22043 RVA: 0x00194084 File Offset: 0x00192284
		// (set) Token: 0x0600561C RID: 22044 RVA: 0x0019408C File Offset: 0x0019228C
		[ProtoMember(1, IsRequired = true, Name = "TargetUserId", DataFormat = DataFormat.Default)]
		public string TargetUserId
		{
			get
			{
				return this._TargetUserId;
			}
			set
			{
				this._TargetUserId = value;
			}
		}

		// Token: 0x17001538 RID: 5432
		// (get) Token: 0x0600561D RID: 22045 RVA: 0x00194098 File Offset: 0x00192298
		// (set) Token: 0x0600561E RID: 22046 RVA: 0x001940A0 File Offset: 0x001922A0
		[ProtoMember(2, IsRequired = true, Name = "ChatGroupId", DataFormat = DataFormat.Default)]
		public string ChatGroupId
		{
			get
			{
				return this._ChatGroupId;
			}
			set
			{
				this._ChatGroupId = value;
			}
		}

		// Token: 0x0600561F RID: 22047 RVA: 0x001940AC File Offset: 0x001922AC
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005620 RID: 22048 RVA: 0x001940BC File Offset: 0x001922BC
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

		// Token: 0x06005621 RID: 22049 RVA: 0x00194188 File Offset: 0x00192388
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ChatGroupChangeOwnerReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040040B5 RID: 16565
		private string _TargetUserId;

		// Token: 0x040040B6 RID: 16566
		private string _ChatGroupId;

		// Token: 0x040040B7 RID: 16567
		private IExtension extensionObject;

		// Token: 0x040040B8 RID: 16568
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040040B9 RID: 16569
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040040BA RID: 16570
		private LuaFunction m_ctor_hotfix;
	}
}
