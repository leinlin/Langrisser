using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000806 RID: 2054
	[ProtoContract(Name = "RandomStoreGetReq")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class RandomStoreGetReq : IExtensible
	{
		// Token: 0x060067F3 RID: 26611 RVA: 0x001D5864 File Offset: 0x001D3A64
		public RandomStoreGetReq()
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

		// Token: 0x17001AB0 RID: 6832
		// (get) Token: 0x060067F4 RID: 26612 RVA: 0x001D58CC File Offset: 0x001D3ACC
		// (set) Token: 0x060067F5 RID: 26613 RVA: 0x001D58D4 File Offset: 0x001D3AD4
		[ProtoMember(1, IsRequired = true, Name = "StoreId", DataFormat = DataFormat.TwosComplement)]
		public int StoreId
		{
			get
			{
				return this._StoreId;
			}
			set
			{
				this._StoreId = value;
			}
		}

		// Token: 0x060067F6 RID: 26614 RVA: 0x001D58E0 File Offset: 0x001D3AE0
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060067F7 RID: 26615 RVA: 0x001D58F0 File Offset: 0x001D3AF0
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

		// Token: 0x060067F8 RID: 26616 RVA: 0x001D59BC File Offset: 0x001D3BBC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(RandomStoreGetReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400501E RID: 20510
		private int _StoreId;

		// Token: 0x0400501F RID: 20511
		private IExtension extensionObject;

		// Token: 0x04005020 RID: 20512
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04005021 RID: 20513
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04005022 RID: 20514
		private LuaFunction m_ctor_hotfix;
	}
}
