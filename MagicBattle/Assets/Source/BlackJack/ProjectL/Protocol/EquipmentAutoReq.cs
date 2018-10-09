using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020007BB RID: 1979
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "EquipmentAutoReq")]
	[Serializable]
	public class EquipmentAutoReq : IExtensible
	{
		// Token: 0x0600655B RID: 25947 RVA: 0x001C5834 File Offset: 0x001C3A34
		public EquipmentAutoReq()
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

		// Token: 0x170019F3 RID: 6643
		// (get) Token: 0x0600655C RID: 25948 RVA: 0x001C589C File Offset: 0x001C3A9C
		// (set) Token: 0x0600655D RID: 25949 RVA: 0x001C58A4 File Offset: 0x001C3AA4
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

		// Token: 0x0600655E RID: 25950 RVA: 0x001C58B0 File Offset: 0x001C3AB0
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600655F RID: 25951 RVA: 0x001C58C0 File Offset: 0x001C3AC0
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

		// Token: 0x06006560 RID: 25952 RVA: 0x001C598C File Offset: 0x001C3B8C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(EquipmentAutoReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004BF5 RID: 19445
		private int _HeroId;

		// Token: 0x04004BF6 RID: 19446
		private IExtension extensionObject;

		// Token: 0x04004BF7 RID: 19447
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004BF8 RID: 19448
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004BF9 RID: 19449
		private LuaFunction m_ctor_hotfix;
	}
}
