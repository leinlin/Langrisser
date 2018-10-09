using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x020002F9 RID: 761
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "Goods")]
	[Serializable]
	public class Goods : IExtensible
	{
		// Token: 0x06002DE3 RID: 11747 RVA: 0x000B7E74 File Offset: 0x000B6074
		public Goods()
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

		// Token: 0x17000CE6 RID: 3302
		// (get) Token: 0x06002DE4 RID: 11748 RVA: 0x000B7EDC File Offset: 0x000B60DC
		// (set) Token: 0x06002DE5 RID: 11749 RVA: 0x000B7EE4 File Offset: 0x000B60E4
		[ProtoMember(1, IsRequired = true, Name = "GoodsType", DataFormat = DataFormat.TwosComplement)]
		public GoodsType GoodsType
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

		// Token: 0x17000CE7 RID: 3303
		// (get) Token: 0x06002DE6 RID: 11750 RVA: 0x000B7EF0 File Offset: 0x000B60F0
		// (set) Token: 0x06002DE7 RID: 11751 RVA: 0x000B7EF8 File Offset: 0x000B60F8
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

		// Token: 0x17000CE8 RID: 3304
		// (get) Token: 0x06002DE8 RID: 11752 RVA: 0x000B7F04 File Offset: 0x000B6104
		// (set) Token: 0x06002DE9 RID: 11753 RVA: 0x000B7F0C File Offset: 0x000B610C
		[ProtoMember(3, IsRequired = true, Name = "Count", DataFormat = DataFormat.TwosComplement)]
		public int Count
		{
			get
			{
				return this._Count;
			}
			set
			{
				this._Count = value;
			}
		}

		// Token: 0x06002DEA RID: 11754 RVA: 0x000B7F18 File Offset: 0x000B6118
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002DEB RID: 11755 RVA: 0x000B7F28 File Offset: 0x000B6128
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

		// Token: 0x06002DEC RID: 11756 RVA: 0x000B7FF4 File Offset: 0x000B61F4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(Goods));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400233C RID: 9020
		private GoodsType _GoodsType;

		// Token: 0x0400233D RID: 9021
		private int _Id;

		// Token: 0x0400233E RID: 9022
		private int _Count;

		// Token: 0x0400233F RID: 9023
		private IExtension extensionObject;

		// Token: 0x04002340 RID: 9024
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04002341 RID: 9025
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04002342 RID: 9026
		private LuaFunction m_ctor_hotfix;
	}
}
