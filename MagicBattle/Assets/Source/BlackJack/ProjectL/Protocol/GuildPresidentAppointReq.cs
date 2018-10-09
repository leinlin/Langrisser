using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000783 RID: 1923
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "GuildPresidentAppointReq")]
	[Serializable]
	public class GuildPresidentAppointReq : IExtensible
	{
		// Token: 0x0600637C RID: 25468 RVA: 0x001BF028 File Offset: 0x001BD228
		public GuildPresidentAppointReq()
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

		// Token: 0x1700196D RID: 6509
		// (get) Token: 0x0600637D RID: 25469 RVA: 0x001BF090 File Offset: 0x001BD290
		// (set) Token: 0x0600637E RID: 25470 RVA: 0x001BF098 File Offset: 0x001BD298
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

		// Token: 0x0600637F RID: 25471 RVA: 0x001BF0A4 File Offset: 0x001BD2A4
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006380 RID: 25472 RVA: 0x001BF0B4 File Offset: 0x001BD2B4
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

		// Token: 0x06006381 RID: 25473 RVA: 0x001BF180 File Offset: 0x001BD380
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GuildPresidentAppointReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004A8F RID: 19087
		private string _UserId;

		// Token: 0x04004A90 RID: 19088
		private IExtension extensionObject;

		// Token: 0x04004A91 RID: 19089
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004A92 RID: 19090
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004A93 RID: 19091
		private LuaFunction m_ctor_hotfix;
	}
}
