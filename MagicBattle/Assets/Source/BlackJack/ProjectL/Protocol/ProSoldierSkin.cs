using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000640 RID: 1600
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ProSoldierSkin")]
	[Serializable]
	public class ProSoldierSkin : IExtensible
	{
		// Token: 0x06005794 RID: 22420 RVA: 0x00198924 File Offset: 0x00196B24
		public ProSoldierSkin()
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

		// Token: 0x170015AE RID: 5550
		// (get) Token: 0x06005795 RID: 22421 RVA: 0x0019898C File Offset: 0x00196B8C
		// (set) Token: 0x06005796 RID: 22422 RVA: 0x00198994 File Offset: 0x00196B94
		[ProtoMember(1, IsRequired = true, Name = "SkinId", DataFormat = DataFormat.TwosComplement)]
		public int SkinId
		{
			get
			{
				return this._SkinId;
			}
			set
			{
				this._SkinId = value;
			}
		}

		// Token: 0x170015AF RID: 5551
		// (get) Token: 0x06005797 RID: 22423 RVA: 0x001989A0 File Offset: 0x00196BA0
		// (set) Token: 0x06005798 RID: 22424 RVA: 0x001989A8 File Offset: 0x00196BA8
		[ProtoMember(2, IsRequired = true, Name = "SoldierId", DataFormat = DataFormat.TwosComplement)]
		public int SoldierId
		{
			get
			{
				return this._SoldierId;
			}
			set
			{
				this._SoldierId = value;
			}
		}

		// Token: 0x06005799 RID: 22425 RVA: 0x001989B4 File Offset: 0x00196BB4
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600579A RID: 22426 RVA: 0x001989C4 File Offset: 0x00196BC4
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

		// Token: 0x0600579B RID: 22427 RVA: 0x00198A90 File Offset: 0x00196C90
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProSoldierSkin));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040041C4 RID: 16836
		private int _SkinId;

		// Token: 0x040041C5 RID: 16837
		private int _SoldierId;

		// Token: 0x040041C6 RID: 16838
		private IExtension extensionObject;

		// Token: 0x040041C7 RID: 16839
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040041C8 RID: 16840
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040041C9 RID: 16841
		private LuaFunction m_ctor_hotfix;
	}
}
