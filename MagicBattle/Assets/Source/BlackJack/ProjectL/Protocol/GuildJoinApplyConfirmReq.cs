using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000759 RID: 1881
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "GuildJoinApplyConfirmReq")]
	[Serializable]
	public class GuildJoinApplyConfirmReq : IExtensible
	{
		// Token: 0x06006250 RID: 25168 RVA: 0x001BA478 File Offset: 0x001B8678
		public GuildJoinApplyConfirmReq()
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

		// Token: 0x17001928 RID: 6440
		// (get) Token: 0x06006251 RID: 25169 RVA: 0x001BA4E0 File Offset: 0x001B86E0
		// (set) Token: 0x06006252 RID: 25170 RVA: 0x001BA4E8 File Offset: 0x001B86E8
		[ProtoMember(1, IsRequired = true, Name = "UserId", DataFormat = DataFormat.Default)]
		public string UserId
		{
			get
			{
				return this._UserId;
			}
			set
			{
				this._UserId = value;
			}
		}

		// Token: 0x06006253 RID: 25171 RVA: 0x001BA4F4 File Offset: 0x001B86F4
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006254 RID: 25172 RVA: 0x001BA504 File Offset: 0x001B8704
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

		// Token: 0x06006255 RID: 25173 RVA: 0x001BA5D0 File Offset: 0x001B87D0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GuildJoinApplyConfirmReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040049A2 RID: 18850
		private string _UserId;

		// Token: 0x040049A3 RID: 18851
		private IExtension extensionObject;

		// Token: 0x040049A4 RID: 18852
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040049A5 RID: 18853
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040049A6 RID: 18854
		private LuaFunction m_ctor_hotfix;
	}
}
