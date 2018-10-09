using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020007A5 RID: 1957
	[ProtoContract(Name = "HeroJobTransferReq")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class HeroJobTransferReq : IExtensible
	{
		// Token: 0x06006499 RID: 25753 RVA: 0x001C2F34 File Offset: 0x001C1134
		public HeroJobTransferReq()
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

		// Token: 0x170019BD RID: 6589
		// (get) Token: 0x0600649A RID: 25754 RVA: 0x001C2F9C File Offset: 0x001C119C
		// (set) Token: 0x0600649B RID: 25755 RVA: 0x001C2FA4 File Offset: 0x001C11A4
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

		// Token: 0x170019BE RID: 6590
		// (get) Token: 0x0600649C RID: 25756 RVA: 0x001C2FB0 File Offset: 0x001C11B0
		// (set) Token: 0x0600649D RID: 25757 RVA: 0x001C2FB8 File Offset: 0x001C11B8
		[ProtoMember(2, IsRequired = true, Name = "jobRelatedId", DataFormat = DataFormat.TwosComplement)]
		public int JobRelatedId
		{
			get
			{
				return this._jobRelatedId;
			}
			set
			{
				this._jobRelatedId = value;
			}
		}

		// Token: 0x0600649E RID: 25758 RVA: 0x001C2FC4 File Offset: 0x001C11C4
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600649F RID: 25759 RVA: 0x001C2FD4 File Offset: 0x001C11D4
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

		// Token: 0x060064A0 RID: 25760 RVA: 0x001C30A0 File Offset: 0x001C12A0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroJobTransferReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004B67 RID: 19303
		private int _HeroId;

		// Token: 0x04004B68 RID: 19304
		private int _jobRelatedId;

		// Token: 0x04004B69 RID: 19305
		private IExtension extensionObject;

		// Token: 0x04004B6A RID: 19306
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004B6B RID: 19307
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004B6C RID: 19308
		private LuaFunction m_ctor_hotfix;
	}
}
