using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020006BA RID: 1722
	[ProtoContract(Name = "FriendGetSocialRelationReq")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class FriendGetSocialRelationReq : IExtensible
	{
		// Token: 0x06005D2B RID: 23851 RVA: 0x001A7D44 File Offset: 0x001A5F44
		public FriendGetSocialRelationReq()
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

		// Token: 0x170017B0 RID: 6064
		// (get) Token: 0x06005D2C RID: 23852 RVA: 0x001A7DAC File Offset: 0x001A5FAC
		// (set) Token: 0x06005D2D RID: 23853 RVA: 0x001A7DB4 File Offset: 0x001A5FB4
		[ProtoMember(1, IsRequired = true, Name = "Flag", DataFormat = DataFormat.TwosComplement)]
		public int Flag
		{
			get
			{
				return this._Flag;
			}
			set
			{
				this._Flag = value;
			}
		}

		// Token: 0x06005D2E RID: 23854 RVA: 0x001A7DC0 File Offset: 0x001A5FC0
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005D2F RID: 23855 RVA: 0x001A7DD0 File Offset: 0x001A5FD0
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

		// Token: 0x06005D30 RID: 23856 RVA: 0x001A7E9C File Offset: 0x001A609C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(FriendGetSocialRelationReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040045AE RID: 17838
		private int _Flag;

		// Token: 0x040045AF RID: 17839
		private IExtension extensionObject;

		// Token: 0x040045B0 RID: 17840
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040045B1 RID: 17841
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040045B2 RID: 17842
		private LuaFunction m_ctor_hotfix;
	}
}
