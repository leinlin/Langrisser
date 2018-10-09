using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200064E RID: 1614
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ProRandomStoreItem")]
	[Serializable]
	public class ProRandomStoreItem : IExtensible
	{
		// Token: 0x0600582E RID: 22574 RVA: 0x0019A4DC File Offset: 0x001986DC
		public ProRandomStoreItem()
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

		// Token: 0x170015E4 RID: 5604
		// (get) Token: 0x0600582F RID: 22575 RVA: 0x0019A544 File Offset: 0x00198744
		// (set) Token: 0x06005830 RID: 22576 RVA: 0x0019A54C File Offset: 0x0019874C
		[ProtoMember(1, IsRequired = true, Name = "Id", DataFormat = DataFormat.TwosComplement)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				this._Id = value;
			}
		}

		// Token: 0x170015E5 RID: 5605
		// (get) Token: 0x06005831 RID: 22577 RVA: 0x0019A558 File Offset: 0x00198758
		// (set) Token: 0x06005832 RID: 22578 RVA: 0x0019A560 File Offset: 0x00198760
		[ProtoMember(2, IsRequired = true, Name = "Bought", DataFormat = DataFormat.Default)]
		public bool Bought
		{
			get
			{
				return this._Bought;
			}
			set
			{
				this._Bought = value;
			}
		}

		// Token: 0x06005833 RID: 22579 RVA: 0x0019A56C File Offset: 0x0019876C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005834 RID: 22580 RVA: 0x0019A57C File Offset: 0x0019877C
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

		// Token: 0x06005835 RID: 22581 RVA: 0x0019A648 File Offset: 0x00198848
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProRandomStoreItem));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004232 RID: 16946
		private int _Id;

		// Token: 0x04004233 RID: 16947
		private bool _Bought;

		// Token: 0x04004234 RID: 16948
		private IExtension extensionObject;

		// Token: 0x04004235 RID: 16949
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004236 RID: 16950
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004237 RID: 16951
		private LuaFunction m_ctor_hotfix;
	}
}
