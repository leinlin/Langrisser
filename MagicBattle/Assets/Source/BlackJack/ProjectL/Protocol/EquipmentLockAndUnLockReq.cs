using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020005D2 RID: 1490
	[ProtoContract(Name = "EquipmentLockAndUnLockReq")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class EquipmentLockAndUnLockReq : IExtensible
	{
		// Token: 0x060053BF RID: 21439 RVA: 0x0018BA3C File Offset: 0x00189C3C
		public EquipmentLockAndUnLockReq()
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

		// Token: 0x1700148A RID: 5258
		// (get) Token: 0x060053C0 RID: 21440 RVA: 0x0018BAA4 File Offset: 0x00189CA4
		// (set) Token: 0x060053C1 RID: 21441 RVA: 0x0018BAAC File Offset: 0x00189CAC
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

		// Token: 0x060053C2 RID: 21442 RVA: 0x0018BAB8 File Offset: 0x00189CB8
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060053C3 RID: 21443 RVA: 0x0018BAC8 File Offset: 0x00189CC8
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

		// Token: 0x060053C4 RID: 21444 RVA: 0x0018BB94 File Offset: 0x00189D94
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(EquipmentLockAndUnLockReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04003EE8 RID: 16104
		private ulong _InstanceId;

		// Token: 0x04003EE9 RID: 16105
		private IExtension extensionObject;

		// Token: 0x04003EEA RID: 16106
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04003EEB RID: 16107
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04003EEC RID: 16108
		private LuaFunction m_ctor_hotfix;
	}
}
