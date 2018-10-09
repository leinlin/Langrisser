using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020007B7 RID: 1975
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "EquipmentWearReq")]
	[Serializable]
	public class EquipmentWearReq : IExtensible
	{
		// Token: 0x06006537 RID: 25911 RVA: 0x001C50BC File Offset: 0x001C32BC
		public EquipmentWearReq()
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

		// Token: 0x170019E9 RID: 6633
		// (get) Token: 0x06006538 RID: 25912 RVA: 0x001C5124 File Offset: 0x001C3324
		// (set) Token: 0x06006539 RID: 25913 RVA: 0x001C512C File Offset: 0x001C332C
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

		// Token: 0x170019EA RID: 6634
		// (get) Token: 0x0600653A RID: 25914 RVA: 0x001C5138 File Offset: 0x001C3338
		// (set) Token: 0x0600653B RID: 25915 RVA: 0x001C5140 File Offset: 0x001C3340
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

		// Token: 0x0600653C RID: 25916 RVA: 0x001C514C File Offset: 0x001C334C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600653D RID: 25917 RVA: 0x001C515C File Offset: 0x001C335C
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

		// Token: 0x0600653E RID: 25918 RVA: 0x001C5228 File Offset: 0x001C3428
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(EquipmentWearReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004BDB RID: 19419
		private int _HeroId;

		// Token: 0x04004BDC RID: 19420
		private ulong _InstanceId;

		// Token: 0x04004BDD RID: 19421
		private IExtension extensionObject;

		// Token: 0x04004BDE RID: 19422
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004BDF RID: 19423
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004BE0 RID: 19424
		private LuaFunction m_ctor_hotfix;
	}
}
