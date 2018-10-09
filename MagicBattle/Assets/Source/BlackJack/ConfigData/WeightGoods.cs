using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000322 RID: 802
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "WeightGoods")]
	[Serializable]
	public class WeightGoods : IExtensible
	{
		// Token: 0x06002F73 RID: 12147 RVA: 0x000BCC38 File Offset: 0x000BAE38
		public WeightGoods()
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

		// Token: 0x17000D5C RID: 3420
		// (get) Token: 0x06002F74 RID: 12148 RVA: 0x000BCCA0 File Offset: 0x000BAEA0
		// (set) Token: 0x06002F75 RID: 12149 RVA: 0x000BCCA8 File Offset: 0x000BAEA8
		[ProtoMember(1, IsRequired = true, Name = "ItemType", DataFormat = DataFormat.TwosComplement)]
		public GoodsType ItemType
		{
			get
			{
				return this._ItemType;
			}
			set
			{
				this._ItemType = value;
			}
		}

		// Token: 0x17000D5D RID: 3421
		// (get) Token: 0x06002F76 RID: 12150 RVA: 0x000BCCB4 File Offset: 0x000BAEB4
		// (set) Token: 0x06002F77 RID: 12151 RVA: 0x000BCCBC File Offset: 0x000BAEBC
		[ProtoMember(2, IsRequired = true, Name = "ItemId", DataFormat = DataFormat.TwosComplement)]
		public int ItemId
		{
			get
			{
				return this._ItemId;
			}
			set
			{
				this._ItemId = value;
			}
		}

		// Token: 0x17000D5E RID: 3422
		// (get) Token: 0x06002F78 RID: 12152 RVA: 0x000BCCC8 File Offset: 0x000BAEC8
		// (set) Token: 0x06002F79 RID: 12153 RVA: 0x000BCCD0 File Offset: 0x000BAED0
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

		// Token: 0x17000D5F RID: 3423
		// (get) Token: 0x06002F7A RID: 12154 RVA: 0x000BCCDC File Offset: 0x000BAEDC
		// (set) Token: 0x06002F7B RID: 12155 RVA: 0x000BCCE4 File Offset: 0x000BAEE4
		[ProtoMember(4, IsRequired = true, Name = "Weight", DataFormat = DataFormat.TwosComplement)]
		public int Weight
		{
			get
			{
				return this._Weight;
			}
			set
			{
				this._Weight = value;
			}
		}

		// Token: 0x06002F7C RID: 12156 RVA: 0x000BCCF0 File Offset: 0x000BAEF0
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002F7D RID: 12157 RVA: 0x000BCD00 File Offset: 0x000BAF00
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

		// Token: 0x06002F7E RID: 12158 RVA: 0x000BCDCC File Offset: 0x000BAFCC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(WeightGoods));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04002456 RID: 9302
		private GoodsType _ItemType;

		// Token: 0x04002457 RID: 9303
		private int _ItemId;

		// Token: 0x04002458 RID: 9304
		private int _Count;

		// Token: 0x04002459 RID: 9305
		private int _Weight;

		// Token: 0x0400245A RID: 9306
		private IExtension extensionObject;

		// Token: 0x0400245B RID: 9307
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400245C RID: 9308
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400245D RID: 9309
		private LuaFunction m_ctor_hotfix;
	}
}
