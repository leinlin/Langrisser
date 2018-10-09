using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020007B1 RID: 1969
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "HeroExpAddReq")]
	[Serializable]
	public class HeroExpAddReq : IExtensible
	{
		// Token: 0x060064FB RID: 25851 RVA: 0x001C454C File Offset: 0x001C274C
		public HeroExpAddReq()
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

		// Token: 0x170019D7 RID: 6615
		// (get) Token: 0x060064FC RID: 25852 RVA: 0x001C45B4 File Offset: 0x001C27B4
		// (set) Token: 0x060064FD RID: 25853 RVA: 0x001C45BC File Offset: 0x001C27BC
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

		// Token: 0x170019D8 RID: 6616
		// (get) Token: 0x060064FE RID: 25854 RVA: 0x001C45C8 File Offset: 0x001C27C8
		// (set) Token: 0x060064FF RID: 25855 RVA: 0x001C45D0 File Offset: 0x001C27D0
		[ProtoMember(2, IsRequired = true, Name = "GoodsTypeId", DataFormat = DataFormat.TwosComplement)]
		public int GoodsTypeId
		{
			get
			{
				return this._GoodsTypeId;
			}
			set
			{
				this._GoodsTypeId = value;
			}
		}

		// Token: 0x170019D9 RID: 6617
		// (get) Token: 0x06006500 RID: 25856 RVA: 0x001C45DC File Offset: 0x001C27DC
		// (set) Token: 0x06006501 RID: 25857 RVA: 0x001C45E4 File Offset: 0x001C27E4
		[ProtoMember(3, IsRequired = true, Name = "ContentId", DataFormat = DataFormat.TwosComplement)]
		public int ContentId
		{
			get
			{
				return this._ContentId;
			}
			set
			{
				this._ContentId = value;
			}
		}

		// Token: 0x170019DA RID: 6618
		// (get) Token: 0x06006502 RID: 25858 RVA: 0x001C45F0 File Offset: 0x001C27F0
		// (set) Token: 0x06006503 RID: 25859 RVA: 0x001C45F8 File Offset: 0x001C27F8
		[ProtoMember(4, IsRequired = true, Name = "Nums", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x06006504 RID: 25860 RVA: 0x001C4604 File Offset: 0x001C2804
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006505 RID: 25861 RVA: 0x001C4614 File Offset: 0x001C2814
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

		// Token: 0x06006506 RID: 25862 RVA: 0x001C46E0 File Offset: 0x001C28E0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroExpAddReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004BB1 RID: 19377
		private int _HeroId;

		// Token: 0x04004BB2 RID: 19378
		private int _GoodsTypeId;

		// Token: 0x04004BB3 RID: 19379
		private int _ContentId;

		// Token: 0x04004BB4 RID: 19380
		private int _Nums;

		// Token: 0x04004BB5 RID: 19381
		private IExtension extensionObject;

		// Token: 0x04004BB6 RID: 19382
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004BB7 RID: 19383
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004BB8 RID: 19384
		private LuaFunction m_ctor_hotfix;
	}
}
