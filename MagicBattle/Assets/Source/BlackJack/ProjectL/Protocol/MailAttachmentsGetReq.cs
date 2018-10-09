using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020007ED RID: 2029
	[ProtoContract(Name = "MailAttachmentsGetReq")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class MailAttachmentsGetReq : IExtensible
	{
		// Token: 0x06006725 RID: 26405 RVA: 0x001CB648 File Offset: 0x001C9848
		public MailAttachmentsGetReq()
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

		// Token: 0x17001A79 RID: 6777
		// (get) Token: 0x06006726 RID: 26406 RVA: 0x001CB6B0 File Offset: 0x001C98B0
		// (set) Token: 0x06006727 RID: 26407 RVA: 0x001CB6B8 File Offset: 0x001C98B8
		[ProtoMember(1, IsRequired = true, Name = "InstanceId", DataFormat = DataFormat.TwosComplement)]
		public ulong InstanceId
		{
			get
			{
				return this._InstanceId;
			}
			set
			{
				this._InstanceId = value;
			}
		}

		// Token: 0x06006728 RID: 26408 RVA: 0x001CB6C4 File Offset: 0x001C98C4
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006729 RID: 26409 RVA: 0x001CB6D4 File Offset: 0x001C98D4
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

		// Token: 0x0600672A RID: 26410 RVA: 0x001CB7A0 File Offset: 0x001C99A0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(MailAttachmentsGetReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004D43 RID: 19779
		private ulong _InstanceId;

		// Token: 0x04004D44 RID: 19780
		private IExtension extensionObject;

		// Token: 0x04004D45 RID: 19781
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004D46 RID: 19782
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004D47 RID: 19783
		private LuaFunction m_ctor_hotfix;
	}
}
