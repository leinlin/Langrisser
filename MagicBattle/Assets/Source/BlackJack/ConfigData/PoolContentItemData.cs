using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x0200030B RID: 779
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "PoolContentItemData")]
	[Serializable]
	public class PoolContentItemData : IExtensible
	{
		// Token: 0x06002E91 RID: 11921 RVA: 0x000BA088 File Offset: 0x000B8288
		public PoolContentItemData()
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

		// Token: 0x17000D19 RID: 3353
		// (get) Token: 0x06002E92 RID: 11922 RVA: 0x000BA0F0 File Offset: 0x000B82F0
		// (set) Token: 0x06002E93 RID: 11923 RVA: 0x000BA0F8 File Offset: 0x000B82F8
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

		// Token: 0x17000D1A RID: 3354
		// (get) Token: 0x06002E94 RID: 11924 RVA: 0x000BA104 File Offset: 0x000B8304
		// (set) Token: 0x06002E95 RID: 11925 RVA: 0x000BA10C File Offset: 0x000B830C
		[ProtoMember(2, IsRequired = true, Name = "GoodsId", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17000D1B RID: 3355
		// (get) Token: 0x06002E96 RID: 11926 RVA: 0x000BA118 File Offset: 0x000B8318
		// (set) Token: 0x06002E97 RID: 11927 RVA: 0x000BA120 File Offset: 0x000B8320
		[ProtoMember(3, IsRequired = true, Name = "Rank", DataFormat = DataFormat.Default)]
		public string Rank
		{
			get
			{
				return this._Rank;
			}
			set
			{
				this._Rank = value;
			}
		}

		// Token: 0x06002E98 RID: 11928 RVA: 0x000BA12C File Offset: 0x000B832C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002E99 RID: 11929 RVA: 0x000BA13C File Offset: 0x000B833C
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

		// Token: 0x06002E9A RID: 11930 RVA: 0x000BA208 File Offset: 0x000B8408
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(PoolContentItemData));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040023B7 RID: 9143
		private int _GoodsType;

		// Token: 0x040023B8 RID: 9144
		private int _GoodsId;

		// Token: 0x040023B9 RID: 9145
		private string _Rank;

		// Token: 0x040023BA RID: 9146
		private IExtension extensionObject;

		// Token: 0x040023BB RID: 9147
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040023BC RID: 9148
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040023BD RID: 9149
		private LuaFunction m_ctor_hotfix;
	}
}
