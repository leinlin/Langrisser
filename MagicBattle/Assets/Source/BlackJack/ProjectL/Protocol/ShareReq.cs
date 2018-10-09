using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000708 RID: 1800
	[ProtoContract(Name = "ShareReq")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ShareReq : IExtensible
	{
		// Token: 0x06005F83 RID: 24451 RVA: 0x001B0BF4 File Offset: 0x001AEDF4
		public ShareReq()
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

		// Token: 0x1700184C RID: 6220
		// (get) Token: 0x06005F84 RID: 24452 RVA: 0x001B0C5C File Offset: 0x001AEE5C
		// (set) Token: 0x06005F85 RID: 24453 RVA: 0x001B0C64 File Offset: 0x001AEE64
		[ProtoMember(1, IsRequired = true, Name = "HeroId", DataFormat = DataFormat.TwosComplement)]
		public int HeroId
		{
			get
			{
				return this._HeroId;
			}
			set
			{
				this._HeroId = value;
			}
		}

		// Token: 0x1700184D RID: 6221
		// (get) Token: 0x06005F86 RID: 24454 RVA: 0x001B0C70 File Offset: 0x001AEE70
		// (set) Token: 0x06005F87 RID: 24455 RVA: 0x001B0C78 File Offset: 0x001AEE78
		[ProtoMember(2, IsRequired = true, Name = "ArchiveId", DataFormat = DataFormat.TwosComplement)]
		public int ArchiveId
		{
			get
			{
				return this._ArchiveId;
			}
			set
			{
				this._ArchiveId = value;
			}
		}

		// Token: 0x06005F88 RID: 24456 RVA: 0x001B0C84 File Offset: 0x001AEE84
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005F89 RID: 24457 RVA: 0x001B0C94 File Offset: 0x001AEE94
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

		// Token: 0x06005F8A RID: 24458 RVA: 0x001B0D60 File Offset: 0x001AEF60
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ShareReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004782 RID: 18306
		private int _HeroId;

		// Token: 0x04004783 RID: 18307
		private int _ArchiveId;

		// Token: 0x04004784 RID: 18308
		private IExtension extensionObject;

		// Token: 0x04004785 RID: 18309
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004786 RID: 18310
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004787 RID: 18311
		private LuaFunction m_ctor_hotfix;
	}
}
