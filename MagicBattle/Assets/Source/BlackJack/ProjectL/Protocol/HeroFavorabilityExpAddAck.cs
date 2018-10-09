using System;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020007C4 RID: 1988
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "HeroFavorabilityExpAddAck")]
	[Serializable]
	public class HeroFavorabilityExpAddAck : IExtensible
	{
		// Token: 0x060065AC RID: 26028 RVA: 0x001C690C File Offset: 0x001C4B0C
		public HeroFavorabilityExpAddAck()
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

		// Token: 0x17001A0A RID: 6666
		// (get) Token: 0x060065AD RID: 26029 RVA: 0x001C6974 File Offset: 0x001C4B74
		// (set) Token: 0x060065AE RID: 26030 RVA: 0x001C697C File Offset: 0x001C4B7C
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

		// Token: 0x17001A0B RID: 6667
		// (get) Token: 0x060065AF RID: 26031 RVA: 0x001C6988 File Offset: 0x001C4B88
		// (set) Token: 0x060065B0 RID: 26032 RVA: 0x001C6990 File Offset: 0x001C4B90
		[ProtoMember(2, IsRequired = true, Name = "HeroId", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17001A0C RID: 6668
		// (get) Token: 0x060065B1 RID: 26033 RVA: 0x001C699C File Offset: 0x001C4B9C
		// (set) Token: 0x060065B2 RID: 26034 RVA: 0x001C69A4 File Offset: 0x001C4BA4
		[ProtoMember(3, IsRequired = true, Name = "GoodsTypeId", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17001A0D RID: 6669
		// (get) Token: 0x060065B3 RID: 26035 RVA: 0x001C69B0 File Offset: 0x001C4BB0
		// (set) Token: 0x060065B4 RID: 26036 RVA: 0x001C69B8 File Offset: 0x001C4BB8
		[ProtoMember(4, IsRequired = true, Name = "ContentId", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17001A0E RID: 6670
		// (get) Token: 0x060065B5 RID: 26037 RVA: 0x001C69C4 File Offset: 0x001C4BC4
		// (set) Token: 0x060065B6 RID: 26038 RVA: 0x001C69CC File Offset: 0x001C4BCC
		[ProtoMember(5, IsRequired = true, Name = "Nums", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17001A0F RID: 6671
		// (get) Token: 0x060065B7 RID: 26039 RVA: 0x001C69D8 File Offset: 0x001C4BD8
		// (set) Token: 0x060065B8 RID: 26040 RVA: 0x001C69E0 File Offset: 0x001C4BE0
		[ProtoMember(6, IsRequired = true, Name = "ReqNums", DataFormat = DataFormat.TwosComplement)]
		public int ReqNums
		{
			get
			{
				return this._ReqNums;
			}
			set
			{
				this._ReqNums = value;
			}
		}

		// Token: 0x17001A10 RID: 6672
		// (get) Token: 0x060065B9 RID: 26041 RVA: 0x001C69EC File Offset: 0x001C4BEC
		// (set) Token: 0x060065BA RID: 26042 RVA: 0x001C69F4 File Offset: 0x001C4BF4
		[DefaultValue(null)]
		[ProtoMember(7, IsRequired = false, Name = "Ntf", DataFormat = DataFormat.Default)]
		public ProChangedGoodsNtf Ntf
		{
			get
			{
				return this._Ntf;
			}
			set
			{
				this._Ntf = value;
			}
		}

		// Token: 0x060065BB RID: 26043 RVA: 0x001C6A00 File Offset: 0x001C4C00
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060065BC RID: 26044 RVA: 0x001C6A10 File Offset: 0x001C4C10
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

		// Token: 0x060065BD RID: 26045 RVA: 0x001C6ADC File Offset: 0x001C4CDC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroFavorabilityExpAddAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004C30 RID: 19504
		private int _Result;

		// Token: 0x04004C31 RID: 19505
		private int _HeroId;

		// Token: 0x04004C32 RID: 19506
		private int _GoodsTypeId;

		// Token: 0x04004C33 RID: 19507
		private int _ContentId;

		// Token: 0x04004C34 RID: 19508
		private int _Nums;

		// Token: 0x04004C35 RID: 19509
		private int _ReqNums;

		// Token: 0x04004C36 RID: 19510
		private ProChangedGoodsNtf _Ntf;

		// Token: 0x04004C37 RID: 19511
		private IExtension extensionObject;

		// Token: 0x04004C38 RID: 19512
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004C39 RID: 19513
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004C3A RID: 19514
		private LuaFunction m_ctor_hotfix;
	}
}
