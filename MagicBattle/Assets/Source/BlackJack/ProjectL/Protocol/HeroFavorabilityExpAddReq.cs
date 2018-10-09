using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020007C3 RID: 1987
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "HeroFavorabilityExpAddReq")]
	[Serializable]
	public class HeroFavorabilityExpAddReq : IExtensible
	{
		// Token: 0x060065A0 RID: 26016 RVA: 0x001C6710 File Offset: 0x001C4910
		public HeroFavorabilityExpAddReq()
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

		// Token: 0x17001A06 RID: 6662
		// (get) Token: 0x060065A1 RID: 26017 RVA: 0x001C6778 File Offset: 0x001C4978
		// (set) Token: 0x060065A2 RID: 26018 RVA: 0x001C6780 File Offset: 0x001C4980
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

		// Token: 0x17001A07 RID: 6663
		// (get) Token: 0x060065A3 RID: 26019 RVA: 0x001C678C File Offset: 0x001C498C
		// (set) Token: 0x060065A4 RID: 26020 RVA: 0x001C6794 File Offset: 0x001C4994
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

		// Token: 0x17001A08 RID: 6664
		// (get) Token: 0x060065A5 RID: 26021 RVA: 0x001C67A0 File Offset: 0x001C49A0
		// (set) Token: 0x060065A6 RID: 26022 RVA: 0x001C67A8 File Offset: 0x001C49A8
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

		// Token: 0x17001A09 RID: 6665
		// (get) Token: 0x060065A7 RID: 26023 RVA: 0x001C67B4 File Offset: 0x001C49B4
		// (set) Token: 0x060065A8 RID: 26024 RVA: 0x001C67BC File Offset: 0x001C49BC
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

		// Token: 0x060065A9 RID: 26025 RVA: 0x001C67C8 File Offset: 0x001C49C8
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060065AA RID: 26026 RVA: 0x001C67D8 File Offset: 0x001C49D8
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

		// Token: 0x060065AB RID: 26027 RVA: 0x001C68A4 File Offset: 0x001C4AA4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroFavorabilityExpAddReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004C28 RID: 19496
		private int _HeroId;

		// Token: 0x04004C29 RID: 19497
		private int _GoodsTypeId;

		// Token: 0x04004C2A RID: 19498
		private int _ContentId;

		// Token: 0x04004C2B RID: 19499
		private int _Nums;

		// Token: 0x04004C2C RID: 19500
		private IExtension extensionObject;

		// Token: 0x04004C2D RID: 19501
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004C2E RID: 19502
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004C2F RID: 19503
		private LuaFunction m_ctor_hotfix;
	}
}
