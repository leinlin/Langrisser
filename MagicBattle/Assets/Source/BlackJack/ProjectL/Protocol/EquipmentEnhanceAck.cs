using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020005D5 RID: 1493
	[ProtoContract(Name = "EquipmentEnhanceAck")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class EquipmentEnhanceAck : IExtensible
	{
		// Token: 0x060053D4 RID: 21460 RVA: 0x0018BFA4 File Offset: 0x0018A1A4
		public EquipmentEnhanceAck()
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

		// Token: 0x1700148F RID: 5263
		// (get) Token: 0x060053D5 RID: 21461 RVA: 0x0018C018 File Offset: 0x0018A218
		// (set) Token: 0x060053D6 RID: 21462 RVA: 0x0018C020 File Offset: 0x0018A220
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

		// Token: 0x17001490 RID: 5264
		// (get) Token: 0x060053D7 RID: 21463 RVA: 0x0018C02C File Offset: 0x0018A22C
		// (set) Token: 0x060053D8 RID: 21464 RVA: 0x0018C034 File Offset: 0x0018A234
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

		// Token: 0x17001491 RID: 5265
		// (get) Token: 0x060053D9 RID: 21465 RVA: 0x0018C040 File Offset: 0x0018A240
		[ProtoMember(3, Name = "materialIds", DataFormat = DataFormat.TwosComplement)]
		public List<ulong> MaterialIds
		{
			get
			{
				return this._materialIds;
			}
		}

		// Token: 0x060053DA RID: 21466 RVA: 0x0018C048 File Offset: 0x0018A248
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060053DB RID: 21467 RVA: 0x0018C058 File Offset: 0x0018A258
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

		// Token: 0x060053DC RID: 21468 RVA: 0x0018C124 File Offset: 0x0018A324
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(EquipmentEnhanceAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04003EF9 RID: 16121
		private int _Result;

		// Token: 0x04003EFA RID: 16122
		private ulong _InstanceId;

		// Token: 0x04003EFB RID: 16123
		private readonly List<ulong> _materialIds = new List<ulong>();

		// Token: 0x04003EFC RID: 16124
		private IExtension extensionObject;

		// Token: 0x04003EFD RID: 16125
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04003EFE RID: 16126
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04003EFF RID: 16127
		private LuaFunction m_ctor_hotfix;
	}
}
