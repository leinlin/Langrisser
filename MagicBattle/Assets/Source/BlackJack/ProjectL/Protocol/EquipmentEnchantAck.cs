using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020005D9 RID: 1497
	[ProtoContract(Name = "EquipmentEnchantAck")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class EquipmentEnchantAck : IExtensible
	{
		// Token: 0x060053F7 RID: 21495 RVA: 0x0018C71C File Offset: 0x0018A91C
		public EquipmentEnchantAck()
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

		// Token: 0x17001499 RID: 5273
		// (get) Token: 0x060053F8 RID: 21496 RVA: 0x0018C790 File Offset: 0x0018A990
		// (set) Token: 0x060053F9 RID: 21497 RVA: 0x0018C798 File Offset: 0x0018A998
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

		// Token: 0x1700149A RID: 5274
		// (get) Token: 0x060053FA RID: 21498 RVA: 0x0018C7A4 File Offset: 0x0018A9A4
		// (set) Token: 0x060053FB RID: 21499 RVA: 0x0018C7AC File Offset: 0x0018A9AC
		[ProtoMember(2, IsRequired = true, Name = "EquipmentInstanceId", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x1700149B RID: 5275
		// (get) Token: 0x060053FC RID: 21500 RVA: 0x0018C7B8 File Offset: 0x0018A9B8
		// (set) Token: 0x060053FD RID: 21501 RVA: 0x0018C7C0 File Offset: 0x0018A9C0
		[ProtoMember(3, IsRequired = true, Name = "EnchantStoneInstanceId", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x1700149C RID: 5276
		// (get) Token: 0x060053FE RID: 21502 RVA: 0x0018C7CC File Offset: 0x0018A9CC
		// (set) Token: 0x060053FF RID: 21503 RVA: 0x0018C7D4 File Offset: 0x0018A9D4
		[ProtoMember(4, IsRequired = true, Name = "NewResonanceId", DataFormat = DataFormat.TwosComplement)]
		public int NewResonanceId
		{
			get
			{
				return this._NewResonanceId;
			}
			set
			{
				this._NewResonanceId = value;
			}
		}

		// Token: 0x1700149D RID: 5277
		// (get) Token: 0x06005400 RID: 21504 RVA: 0x0018C7E0 File Offset: 0x0018A9E0
		[ProtoMember(5, Name = "NewEnchantProperties", DataFormat = DataFormat.Default)]
		public List<ProCommonBattleProperty> NewEnchantProperties
		{
			get
			{
				return this._NewEnchantProperties;
			}
		}

		// Token: 0x06005401 RID: 21505 RVA: 0x0018C7E8 File Offset: 0x0018A9E8
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005402 RID: 21506 RVA: 0x0018C7F8 File Offset: 0x0018A9F8
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

		// Token: 0x06005403 RID: 21507 RVA: 0x0018C8C4 File Offset: 0x0018AAC4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(EquipmentEnchantAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04003F13 RID: 16147
		private int _Result;

		// Token: 0x04003F14 RID: 16148
		private ulong _EquipmentInstanceId;

		// Token: 0x04003F15 RID: 16149
		private ulong _EnchantStoneInstanceId;

		// Token: 0x04003F16 RID: 16150
		private int _NewResonanceId;

		// Token: 0x04003F17 RID: 16151
		private readonly List<ProCommonBattleProperty> _NewEnchantProperties = new List<ProCommonBattleProperty>();

		// Token: 0x04003F18 RID: 16152
		private IExtension extensionObject;

		// Token: 0x04003F19 RID: 16153
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04003F1A RID: 16154
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04003F1B RID: 16155
		private LuaFunction m_ctor_hotfix;
	}
}
