using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020005D7 RID: 1495
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "EquipmentStarLevelUpAck")]
	[Serializable]
	public class EquipmentStarLevelUpAck : IExtensible
	{
		// Token: 0x060053E5 RID: 21477 RVA: 0x0018C360 File Offset: 0x0018A560
		public EquipmentStarLevelUpAck()
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

		// Token: 0x17001494 RID: 5268
		// (get) Token: 0x060053E6 RID: 21478 RVA: 0x0018C3C8 File Offset: 0x0018A5C8
		// (set) Token: 0x060053E7 RID: 21479 RVA: 0x0018C3D0 File Offset: 0x0018A5D0
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

		// Token: 0x17001495 RID: 5269
		// (get) Token: 0x060053E8 RID: 21480 RVA: 0x0018C3DC File Offset: 0x0018A5DC
		// (set) Token: 0x060053E9 RID: 21481 RVA: 0x0018C3E4 File Offset: 0x0018A5E4
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

		// Token: 0x17001496 RID: 5270
		// (get) Token: 0x060053EA RID: 21482 RVA: 0x0018C3F0 File Offset: 0x0018A5F0
		// (set) Token: 0x060053EB RID: 21483 RVA: 0x0018C3F8 File Offset: 0x0018A5F8
		[ProtoMember(3, IsRequired = true, Name = "materialId", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x060053EC RID: 21484 RVA: 0x0018C404 File Offset: 0x0018A604
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060053ED RID: 21485 RVA: 0x0018C414 File Offset: 0x0018A614
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

		// Token: 0x060053EE RID: 21486 RVA: 0x0018C4E0 File Offset: 0x0018A6E0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(EquipmentStarLevelUpAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04003F06 RID: 16134
		private int _Result;

		// Token: 0x04003F07 RID: 16135
		private ulong _InstanceId;

		// Token: 0x04003F08 RID: 16136
		private ulong _materialId;

		// Token: 0x04003F09 RID: 16137
		private IExtension extensionObject;

		// Token: 0x04003F0A RID: 16138
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04003F0B RID: 16139
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04003F0C RID: 16140
		private LuaFunction m_ctor_hotfix;
	}
}
