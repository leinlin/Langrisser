using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020007B5 RID: 1973
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "SetProtagonistReq")]
	[Serializable]
	public class SetProtagonistReq : IExtensible
	{
		// Token: 0x06006529 RID: 25897 RVA: 0x001C4D28 File Offset: 0x001C2F28
		public SetProtagonistReq()
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

		// Token: 0x170019E6 RID: 6630
		// (get) Token: 0x0600652A RID: 25898 RVA: 0x001C4D90 File Offset: 0x001C2F90
		// (set) Token: 0x0600652B RID: 25899 RVA: 0x001C4D98 File Offset: 0x001C2F98
		[ProtoMember(1, IsRequired = true, Name = "ProtagonistId", DataFormat = DataFormat.TwosComplement)]
		public int ProtagonistId
		{
			get
			{
				return this._ProtagonistId;
			}
			set
			{
				this._ProtagonistId = value;
			}
		}

		// Token: 0x0600652C RID: 25900 RVA: 0x001C4DA4 File Offset: 0x001C2FA4
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600652D RID: 25901 RVA: 0x001C4DB4 File Offset: 0x001C2FB4
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

		// Token: 0x0600652E RID: 25902 RVA: 0x001C4E80 File Offset: 0x001C3080
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(SetProtagonistReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004BD0 RID: 19408
		private int _ProtagonistId;

		// Token: 0x04004BD1 RID: 19409
		private IExtension extensionObject;

		// Token: 0x04004BD2 RID: 19410
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004BD3 RID: 19411
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004BD4 RID: 19412
		private LuaFunction m_ctor_hotfix;
	}
}
