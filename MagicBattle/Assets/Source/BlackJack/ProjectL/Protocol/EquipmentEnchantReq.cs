using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020005D8 RID: 1496
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "EquipmentEnchantReq")]
	[Serializable]
	public class EquipmentEnchantReq : IExtensible
	{
		// Token: 0x060053EF RID: 21487 RVA: 0x0018C548 File Offset: 0x0018A748
		public EquipmentEnchantReq()
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

		// Token: 0x17001497 RID: 5271
		// (get) Token: 0x060053F0 RID: 21488 RVA: 0x0018C5B0 File Offset: 0x0018A7B0
		// (set) Token: 0x060053F1 RID: 21489 RVA: 0x0018C5B8 File Offset: 0x0018A7B8
		[ProtoMember(1, IsRequired = true, Name = "EquipmentInstanceId", DataFormat = DataFormat.TwosComplement)]
		public ulong EquipmentInstanceId
		{
			get
			{
				return this._EquipmentInstanceId;
			}
			set
			{
				this._EquipmentInstanceId = value;
			}
		}

		// Token: 0x17001498 RID: 5272
		// (get) Token: 0x060053F2 RID: 21490 RVA: 0x0018C5C4 File Offset: 0x0018A7C4
		// (set) Token: 0x060053F3 RID: 21491 RVA: 0x0018C5CC File Offset: 0x0018A7CC
		[ProtoMember(2, IsRequired = true, Name = "EnchantStoneInstanceId", DataFormat = DataFormat.TwosComplement)]
		public ulong EnchantStoneInstanceId
		{
			get
			{
				return this._EnchantStoneInstanceId;
			}
			set
			{
				this._EnchantStoneInstanceId = value;
			}
		}

		// Token: 0x060053F4 RID: 21492 RVA: 0x0018C5D8 File Offset: 0x0018A7D8
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060053F5 RID: 21493 RVA: 0x0018C5E8 File Offset: 0x0018A7E8
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

		// Token: 0x060053F6 RID: 21494 RVA: 0x0018C6B4 File Offset: 0x0018A8B4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(EquipmentEnchantReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04003F0D RID: 16141
		private ulong _EquipmentInstanceId;

		// Token: 0x04003F0E RID: 16142
		private ulong _EnchantStoneInstanceId;

		// Token: 0x04003F0F RID: 16143
		private IExtension extensionObject;

		// Token: 0x04003F10 RID: 16144
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04003F11 RID: 16145
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04003F12 RID: 16146
		private LuaFunction m_ctor_hotfix;
	}
}
