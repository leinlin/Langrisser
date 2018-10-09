using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000713 RID: 1811
	[ProtoContract(Name = "UpdateServerTimeNtf")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class UpdateServerTimeNtf : IExtensible
	{
		// Token: 0x06005FD0 RID: 24528 RVA: 0x001B1FAC File Offset: 0x001B01AC
		public UpdateServerTimeNtf()
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

		// Token: 0x1700185D RID: 6237
		// (get) Token: 0x06005FD1 RID: 24529 RVA: 0x001B2014 File Offset: 0x001B0214
		// (set) Token: 0x06005FD2 RID: 24530 RVA: 0x001B201C File Offset: 0x001B021C
		[ProtoMember(1, IsRequired = true, Name = "ServerTime", DataFormat = DataFormat.TwosComplement)]
		public long ServerTime
		{
			get
			{
				return this._ServerTime;
			}
			set
			{
				this._ServerTime = value;
			}
		}

		// Token: 0x06005FD3 RID: 24531 RVA: 0x001B2028 File Offset: 0x001B0228
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005FD4 RID: 24532 RVA: 0x001B2038 File Offset: 0x001B0238
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

		// Token: 0x06005FD5 RID: 24533 RVA: 0x001B2104 File Offset: 0x001B0304
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(UpdateServerTimeNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040047BF RID: 18367
		private long _ServerTime;

		// Token: 0x040047C0 RID: 18368
		private IExtension extensionObject;

		// Token: 0x040047C1 RID: 18369
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040047C2 RID: 18370
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040047C3 RID: 18371
		private LuaFunction m_ctor_hotfix;
	}
}
