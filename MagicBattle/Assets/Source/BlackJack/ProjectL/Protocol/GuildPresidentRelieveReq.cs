using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200077D RID: 1917
	[ProtoContract(Name = "GuildPresidentRelieveReq")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class GuildPresidentRelieveReq : IExtensible
	{
		// Token: 0x06006353 RID: 25427 RVA: 0x001BE56C File Offset: 0x001BC76C
		public GuildPresidentRelieveReq()
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

		// Token: 0x17001964 RID: 6500
		// (get) Token: 0x06006354 RID: 25428 RVA: 0x001BE5D4 File Offset: 0x001BC7D4
		// (set) Token: 0x06006355 RID: 25429 RVA: 0x001BE5DC File Offset: 0x001BC7DC
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

		// Token: 0x06006356 RID: 25430 RVA: 0x001BE5E8 File Offset: 0x001BC7E8
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006357 RID: 25431 RVA: 0x001BE5F8 File Offset: 0x001BC7F8
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

		// Token: 0x06006358 RID: 25432 RVA: 0x001BE6C4 File Offset: 0x001BC8C4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GuildPresidentRelieveReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004A6E RID: 19054
		private string _UserId;

		// Token: 0x04004A6F RID: 19055
		private IExtension extensionObject;

		// Token: 0x04004A70 RID: 19056
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004A71 RID: 19057
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004A72 RID: 19058
		private LuaFunction m_ctor_hotfix;
	}
}
