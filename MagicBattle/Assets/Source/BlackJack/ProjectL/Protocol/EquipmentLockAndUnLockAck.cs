using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020005D3 RID: 1491
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "EquipmentLockAndUnLockAck")]
	[Serializable]
	public class EquipmentLockAndUnLockAck : IExtensible
	{
		// Token: 0x060053C5 RID: 21445 RVA: 0x0018BBFC File Offset: 0x00189DFC
		public EquipmentLockAndUnLockAck()
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

		// Token: 0x1700148B RID: 5259
		// (get) Token: 0x060053C6 RID: 21446 RVA: 0x0018BC64 File Offset: 0x00189E64
		// (set) Token: 0x060053C7 RID: 21447 RVA: 0x0018BC6C File Offset: 0x00189E6C
		[ProtoMember(1, IsRequired = true, Name = "Result", DataFormat = DataFormat.TwosComplement)]
		public int Result
		{
			get
			{
				return this._Result;
			}
			set
			{
				this._Result = value;
			}
		}

		// Token: 0x1700148C RID: 5260
		// (get) Token: 0x060053C8 RID: 21448 RVA: 0x0018BC78 File Offset: 0x00189E78
		// (set) Token: 0x060053C9 RID: 21449 RVA: 0x0018BC80 File Offset: 0x00189E80
		[ProtoMember(2, IsRequired = true, Name = "InstanceId", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x060053CA RID: 21450 RVA: 0x0018BC8C File Offset: 0x00189E8C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060053CB RID: 21451 RVA: 0x0018BC9C File Offset: 0x00189E9C
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

		// Token: 0x060053CC RID: 21452 RVA: 0x0018BD68 File Offset: 0x00189F68
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(EquipmentLockAndUnLockAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04003EED RID: 16109
		private int _Result;

		// Token: 0x04003EEE RID: 16110
		private ulong _InstanceId;

		// Token: 0x04003EEF RID: 16111
		private IExtension extensionObject;

		// Token: 0x04003EF0 RID: 16112
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04003EF1 RID: 16113
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04003EF2 RID: 16114
		private LuaFunction m_ctor_hotfix;
	}
}
