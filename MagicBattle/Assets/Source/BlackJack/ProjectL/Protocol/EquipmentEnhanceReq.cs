using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020005D4 RID: 1492
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "EquipmentEnhanceReq")]
	[Serializable]
	public class EquipmentEnhanceReq : IExtensible
	{
		// Token: 0x060053CD RID: 21453 RVA: 0x0018BDD0 File Offset: 0x00189FD0
		public EquipmentEnhanceReq()
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

		// Token: 0x1700148D RID: 5261
		// (get) Token: 0x060053CE RID: 21454 RVA: 0x0018BE44 File Offset: 0x0018A044
		// (set) Token: 0x060053CF RID: 21455 RVA: 0x0018BE4C File Offset: 0x0018A04C
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

		// Token: 0x1700148E RID: 5262
		// (get) Token: 0x060053D0 RID: 21456 RVA: 0x0018BE58 File Offset: 0x0018A058
		[ProtoMember(2, Name = "materialIds", DataFormat = DataFormat.TwosComplement)]
		public List<ulong> MaterialIds
		{
			get
			{
				return this._materialIds;
			}
		}

		// Token: 0x060053D1 RID: 21457 RVA: 0x0018BE60 File Offset: 0x0018A060
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060053D2 RID: 21458 RVA: 0x0018BE70 File Offset: 0x0018A070
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

		// Token: 0x060053D3 RID: 21459 RVA: 0x0018BF3C File Offset: 0x0018A13C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(EquipmentEnhanceReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04003EF3 RID: 16115
		private ulong _InstanceId;

		// Token: 0x04003EF4 RID: 16116
		private readonly List<ulong> _materialIds = new List<ulong>();

		// Token: 0x04003EF5 RID: 16117
		private IExtension extensionObject;

		// Token: 0x04003EF6 RID: 16118
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04003EF7 RID: 16119
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04003EF8 RID: 16120
		private LuaFunction m_ctor_hotfix;
	}
}
