using System;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000642 RID: 1602
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ProGoods")]
	[Serializable]
	public class ProGoods : IExtensible
	{
		// Token: 0x060057A9 RID: 22441 RVA: 0x00198D08 File Offset: 0x00196F08
		public ProGoods()
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

		// Token: 0x170015B5 RID: 5557
		// (get) Token: 0x060057AA RID: 22442 RVA: 0x00198D70 File Offset: 0x00196F70
		// (set) Token: 0x060057AB RID: 22443 RVA: 0x00198D78 File Offset: 0x00196F78
		[ProtoMember(1, IsRequired = true, Name = "GoodsType", DataFormat = DataFormat.TwosComplement)]
		public int GoodsType
		{
			get
			{
				return this._GoodsType;
			}
			set
			{
				this._GoodsType = value;
			}
		}

		// Token: 0x170015B6 RID: 5558
		// (get) Token: 0x060057AC RID: 22444 RVA: 0x00198D84 File Offset: 0x00196F84
		// (set) Token: 0x060057AD RID: 22445 RVA: 0x00198D8C File Offset: 0x00196F8C
		[ProtoMember(2, IsRequired = true, Name = "Id", DataFormat = DataFormat.TwosComplement)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				this._Id = value;
			}
		}

		// Token: 0x170015B7 RID: 5559
		// (get) Token: 0x060057AE RID: 22446 RVA: 0x00198D98 File Offset: 0x00196F98
		// (set) Token: 0x060057AF RID: 22447 RVA: 0x00198DA0 File Offset: 0x00196FA0
		[ProtoMember(3, IsRequired = true, Name = "Nums", DataFormat = DataFormat.TwosComplement)]
		public int Nums
		{
			get
			{
				return this._Nums;
			}
			set
			{
				this._Nums = value;
			}
		}

		// Token: 0x170015B8 RID: 5560
		// (get) Token: 0x060057B0 RID: 22448 RVA: 0x00198DAC File Offset: 0x00196FAC
		// (set) Token: 0x060057B1 RID: 22449 RVA: 0x00198DB4 File Offset: 0x00196FB4
		[ProtoMember(4, IsRequired = false, Name = "InstanceId", DataFormat = DataFormat.TwosComplement)]
		[DefaultValue(0f)]
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

		// Token: 0x170015B9 RID: 5561
		// (get) Token: 0x060057B2 RID: 22450 RVA: 0x00198DC0 File Offset: 0x00196FC0
		// (set) Token: 0x060057B3 RID: 22451 RVA: 0x00198DC8 File Offset: 0x00196FC8
		[ProtoMember(5, IsRequired = false, Name = "Equipment", DataFormat = DataFormat.Default)]
		[DefaultValue(null)]
		public ProEquipment Equipment
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

		// Token: 0x060057B4 RID: 22452 RVA: 0x00198DD4 File Offset: 0x00196FD4
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060057B5 RID: 22453 RVA: 0x00198DE4 File Offset: 0x00196FE4
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

		// Token: 0x060057B6 RID: 22454 RVA: 0x00198EB0 File Offset: 0x001970B0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProGoods));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040041D3 RID: 16851
		private int _GoodsType;

		// Token: 0x040041D4 RID: 16852
		private int _Id;

		// Token: 0x040041D5 RID: 16853
		private int _Nums;

		// Token: 0x040041D6 RID: 16854
		private ulong _InstanceId;

		// Token: 0x040041D7 RID: 16855
		private ProEquipment _Equipment;

		// Token: 0x040041D8 RID: 16856
		private IExtension extensionObject;

		// Token: 0x040041D9 RID: 16857
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040041DA RID: 16858
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040041DB RID: 16859
		private LuaFunction m_ctor_hotfix;
	}
}
