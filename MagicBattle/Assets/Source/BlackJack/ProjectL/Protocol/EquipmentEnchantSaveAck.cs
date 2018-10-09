using System;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020005DB RID: 1499
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "EquipmentEnchantSaveAck")]
	[Serializable]
	public class EquipmentEnchantSaveAck : IExtensible
	{
		// Token: 0x06005408 RID: 21512 RVA: 0x0018CAD8 File Offset: 0x0018ACD8
		public EquipmentEnchantSaveAck()
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

		// Token: 0x1700149E RID: 5278
		// (get) Token: 0x06005409 RID: 21513 RVA: 0x0018CB40 File Offset: 0x0018AD40
		// (set) Token: 0x0600540A RID: 21514 RVA: 0x0018CB48 File Offset: 0x0018AD48
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

		// Token: 0x1700149F RID: 5279
		// (get) Token: 0x0600540B RID: 21515 RVA: 0x0018CB54 File Offset: 0x0018AD54
		// (set) Token: 0x0600540C RID: 21516 RVA: 0x0018CB5C File Offset: 0x0018AD5C
		[DefaultValue(null)]
		[ProtoMember(2, IsRequired = false, Name = "Equipment", DataFormat = DataFormat.Default)]
		public ProGoods Equipment
		{
			get
			{
				return this._Equipment;
			}
			set
			{
				this._Equipment = value;
			}
		}

		// Token: 0x0600540D RID: 21517 RVA: 0x0018CB68 File Offset: 0x0018AD68
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600540E RID: 21518 RVA: 0x0018CB78 File Offset: 0x0018AD78
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

		// Token: 0x0600540F RID: 21519 RVA: 0x0018CC44 File Offset: 0x0018AE44
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(EquipmentEnchantSaveAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04003F20 RID: 16160
		private int _Result;

		// Token: 0x04003F21 RID: 16161
		private ProGoods _Equipment;

		// Token: 0x04003F22 RID: 16162
		private IExtension extensionObject;

		// Token: 0x04003F23 RID: 16163
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04003F24 RID: 16164
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04003F25 RID: 16165
		private LuaFunction m_ctor_hotfix;
	}
}
