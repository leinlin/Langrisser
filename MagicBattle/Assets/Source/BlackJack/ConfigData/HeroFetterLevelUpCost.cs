using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000318 RID: 792
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "HeroFetterLevelUpCost")]
	[Serializable]
	public class HeroFetterLevelUpCost : IExtensible
	{
		// Token: 0x06002F0F RID: 12047 RVA: 0x000BB928 File Offset: 0x000B9B28
		public HeroFetterLevelUpCost()
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

		// Token: 0x17000D3E RID: 3390
		// (get) Token: 0x06002F10 RID: 12048 RVA: 0x000BB990 File Offset: 0x000B9B90
		// (set) Token: 0x06002F11 RID: 12049 RVA: 0x000BB998 File Offset: 0x000B9B98
		[ProtoMember(1, IsRequired = true, Name = "Level", DataFormat = DataFormat.TwosComplement)]
		public int Level
		{
			get
			{
				return this._Level;
			}
			set
			{
				this._Level = value;
			}
		}

		// Token: 0x17000D3F RID: 3391
		// (get) Token: 0x06002F12 RID: 12050 RVA: 0x000BB9A4 File Offset: 0x000B9BA4
		// (set) Token: 0x06002F13 RID: 12051 RVA: 0x000BB9AC File Offset: 0x000B9BAC
		[ProtoMember(2, IsRequired = true, Name = "ItemType", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17000D40 RID: 3392
		// (get) Token: 0x06002F14 RID: 12052 RVA: 0x000BB9B8 File Offset: 0x000B9BB8
		// (set) Token: 0x06002F15 RID: 12053 RVA: 0x000BB9C0 File Offset: 0x000B9BC0
		[ProtoMember(3, IsRequired = true, Name = "ItemId", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17000D41 RID: 3393
		// (get) Token: 0x06002F16 RID: 12054 RVA: 0x000BB9CC File Offset: 0x000B9BCC
		// (set) Token: 0x06002F17 RID: 12055 RVA: 0x000BB9D4 File Offset: 0x000B9BD4
		[ProtoMember(4, IsRequired = true, Name = "Count", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x06002F18 RID: 12056 RVA: 0x000BB9E0 File Offset: 0x000B9BE0
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002F19 RID: 12057 RVA: 0x000BB9F0 File Offset: 0x000B9BF0
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

		// Token: 0x06002F1A RID: 12058 RVA: 0x000BBABC File Offset: 0x000B9CBC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroFetterLevelUpCost));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04002410 RID: 9232
		private int _Level;

		// Token: 0x04002411 RID: 9233
		private GoodsType _ItemType;

		// Token: 0x04002412 RID: 9234
		private int _ItemId;

		// Token: 0x04002413 RID: 9235
		private int _Count;

		// Token: 0x04002414 RID: 9236
		private IExtension extensionObject;

		// Token: 0x04002415 RID: 9237
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04002416 RID: 9238
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04002417 RID: 9239
		private LuaFunction m_ctor_hotfix;
	}
}
