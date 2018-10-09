using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000773 RID: 1907
	[ProtoContract(Name = "GuildGetReq")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class GuildGetReq : IExtensible
	{
		// Token: 0x06006301 RID: 25345 RVA: 0x001BD310 File Offset: 0x001BB510
		public GuildGetReq()
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

		// Token: 0x1700194F RID: 6479
		// (get) Token: 0x06006302 RID: 25346 RVA: 0x001BD378 File Offset: 0x001BB578
		// (set) Token: 0x06006303 RID: 25347 RVA: 0x001BD380 File Offset: 0x001BB580
		[ProtoMember(1, IsRequired = true, Name = "GuildId", DataFormat = DataFormat.Default)]
		public string GuildId
		{
			get
			{
				return this._GuildId;
			}
			set
			{
				this._GuildId = value;
			}
		}

		// Token: 0x17001950 RID: 6480
		// (get) Token: 0x06006304 RID: 25348 RVA: 0x001BD38C File Offset: 0x001BB58C
		// (set) Token: 0x06006305 RID: 25349 RVA: 0x001BD394 File Offset: 0x001BB594
		[ProtoMember(2, IsRequired = true, Name = "LastUpdateTime", DataFormat = DataFormat.TwosComplement)]
		public long LastUpdateTime
		{
			get
			{
				return this._LastUpdateTime;
			}
			set
			{
				this._LastUpdateTime = value;
			}
		}

		// Token: 0x06006306 RID: 25350 RVA: 0x001BD3A0 File Offset: 0x001BB5A0
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006307 RID: 25351 RVA: 0x001BD3B0 File Offset: 0x001BB5B0
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

		// Token: 0x06006308 RID: 25352 RVA: 0x001BD47C File Offset: 0x001BB67C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GuildGetReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004A31 RID: 18993
		private string _GuildId;

		// Token: 0x04004A32 RID: 18994
		private long _LastUpdateTime;

		// Token: 0x04004A33 RID: 18995
		private IExtension extensionObject;

		// Token: 0x04004A34 RID: 18996
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004A35 RID: 18997
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004A36 RID: 18998
		private LuaFunction m_ctor_hotfix;
	}
}
