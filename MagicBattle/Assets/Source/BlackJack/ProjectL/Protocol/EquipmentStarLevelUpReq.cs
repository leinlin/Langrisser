using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020005D6 RID: 1494
	[ProtoContract(Name = "EquipmentStarLevelUpReq")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class EquipmentStarLevelUpReq : IExtensible
	{
		// Token: 0x060053DD RID: 21469 RVA: 0x0018C18C File Offset: 0x0018A38C
		public EquipmentStarLevelUpReq()
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

		// Token: 0x17001492 RID: 5266
		// (get) Token: 0x060053DE RID: 21470 RVA: 0x0018C1F4 File Offset: 0x0018A3F4
		// (set) Token: 0x060053DF RID: 21471 RVA: 0x0018C1FC File Offset: 0x0018A3FC
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

		// Token: 0x17001493 RID: 5267
		// (get) Token: 0x060053E0 RID: 21472 RVA: 0x0018C208 File Offset: 0x0018A408
		// (set) Token: 0x060053E1 RID: 21473 RVA: 0x0018C210 File Offset: 0x0018A410
		[ProtoMember(2, IsRequired = true, Name = "materialId", DataFormat = DataFormat.TwosComplement)]
		public ulong MaterialId
		{
			get
			{
				return this._materialId;
			}
			set
			{
				this._materialId = value;
			}
		}

		// Token: 0x060053E2 RID: 21474 RVA: 0x0018C21C File Offset: 0x0018A41C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060053E3 RID: 21475 RVA: 0x0018C22C File Offset: 0x0018A42C
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

		// Token: 0x060053E4 RID: 21476 RVA: 0x0018C2F8 File Offset: 0x0018A4F8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(EquipmentStarLevelUpReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04003F00 RID: 16128
		private ulong _InstanceId;

		// Token: 0x04003F01 RID: 16129
		private ulong _materialId;

		// Token: 0x04003F02 RID: 16130
		private IExtension extensionObject;

		// Token: 0x04003F03 RID: 16131
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04003F04 RID: 16132
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04003F05 RID: 16133
		private LuaFunction m_ctor_hotfix;
	}
}
