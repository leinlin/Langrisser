using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200069C RID: 1692
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ProGiftStoreOperationalGoods")]
	[Serializable]
	public class ProGiftStoreOperationalGoods : IExtensible
	{
		// Token: 0x06005BDB RID: 23515 RVA: 0x001A4208 File Offset: 0x001A2408
		public ProGiftStoreOperationalGoods()
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

		// Token: 0x1700173B RID: 5947
		// (get) Token: 0x06005BDC RID: 23516 RVA: 0x001A4270 File Offset: 0x001A2470
		// (set) Token: 0x06005BDD RID: 23517 RVA: 0x001A4278 File Offset: 0x001A2478
		[ProtoMember(1, IsRequired = true, Name = "GoodsId", DataFormat = DataFormat.TwosComplement)]
		public int GoodsId
		{
			get
			{
				return this._GoodsId;
			}
			set
			{
				this._GoodsId = value;
			}
		}

		// Token: 0x1700173C RID: 5948
		// (get) Token: 0x06005BDE RID: 23518 RVA: 0x001A4284 File Offset: 0x001A2484
		// (set) Token: 0x06005BDF RID: 23519 RVA: 0x001A428C File Offset: 0x001A248C
		[ProtoMember(2, IsRequired = true, Name = "SaleStartTime", DataFormat = DataFormat.TwosComplement)]
		public long SaleStartTime
		{
			get
			{
				return this._SaleStartTime;
			}
			set
			{
				this._SaleStartTime = value;
			}
		}

		// Token: 0x1700173D RID: 5949
		// (get) Token: 0x06005BE0 RID: 23520 RVA: 0x001A4298 File Offset: 0x001A2498
		// (set) Token: 0x06005BE1 RID: 23521 RVA: 0x001A42A0 File Offset: 0x001A24A0
		[ProtoMember(3, IsRequired = true, Name = "SaleEndTime", DataFormat = DataFormat.TwosComplement)]
		public long SaleEndTime
		{
			get
			{
				return this._SaleEndTime;
			}
			set
			{
				this._SaleEndTime = value;
			}
		}

		// Token: 0x06005BE2 RID: 23522 RVA: 0x001A42AC File Offset: 0x001A24AC
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005BE3 RID: 23523 RVA: 0x001A42BC File Offset: 0x001A24BC
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

		// Token: 0x06005BE4 RID: 23524 RVA: 0x001A4388 File Offset: 0x001A2588
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProGiftStoreOperationalGoods));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040044C1 RID: 17601
		private int _GoodsId;

		// Token: 0x040044C2 RID: 17602
		private long _SaleStartTime;

		// Token: 0x040044C3 RID: 17603
		private long _SaleEndTime;

		// Token: 0x040044C4 RID: 17604
		private IExtension extensionObject;

		// Token: 0x040044C5 RID: 17605
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040044C6 RID: 17606
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040044C7 RID: 17607
		private LuaFunction m_ctor_hotfix;
	}
}
