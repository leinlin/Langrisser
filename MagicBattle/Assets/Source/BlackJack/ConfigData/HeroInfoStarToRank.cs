using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000304 RID: 772
	[ProtoContract(Name = "HeroInfoStarToRank")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class HeroInfoStarToRank : IExtensible
	{
		// Token: 0x06002E4F RID: 11855 RVA: 0x000B9358 File Offset: 0x000B7558
		public HeroInfoStarToRank()
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

		// Token: 0x17000D06 RID: 3334
		// (get) Token: 0x06002E50 RID: 11856 RVA: 0x000B93C0 File Offset: 0x000B75C0
		// (set) Token: 0x06002E51 RID: 11857 RVA: 0x000B93C8 File Offset: 0x000B75C8
		[ProtoMember(1, IsRequired = true, Name = "Star", DataFormat = DataFormat.TwosComplement)]
		public int Star
		{
			get
			{
				return this._Star;
			}
			set
			{
				this._Star = value;
			}
		}

		// Token: 0x17000D07 RID: 3335
		// (get) Token: 0x06002E52 RID: 11858 RVA: 0x000B93D4 File Offset: 0x000B75D4
		// (set) Token: 0x06002E53 RID: 11859 RVA: 0x000B93DC File Offset: 0x000B75DC
		[ProtoMember(2, IsRequired = true, Name = "Rank", DataFormat = DataFormat.TwosComplement)]
		public int Rank
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

		// Token: 0x17000D08 RID: 3336
		// (get) Token: 0x06002E54 RID: 11860 RVA: 0x000B93E8 File Offset: 0x000B75E8
		// (set) Token: 0x06002E55 RID: 11861 RVA: 0x000B93F0 File Offset: 0x000B75F0
		[ProtoMember(3, IsRequired = true, Name = "CharImageId", DataFormat = DataFormat.TwosComplement)]
		public int CharImageId
		{
			get
			{
				return this._CharImageId;
			}
			set
			{
				this._CharImageId = value;
			}
		}

		// Token: 0x06002E56 RID: 11862 RVA: 0x000B93FC File Offset: 0x000B75FC
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002E57 RID: 11863 RVA: 0x000B940C File Offset: 0x000B760C
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

		// Token: 0x06002E58 RID: 11864 RVA: 0x000B94D8 File Offset: 0x000B76D8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroInfoStarToRank));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04002388 RID: 9096
		private int _Star;

		// Token: 0x04002389 RID: 9097
		private int _Rank;

		// Token: 0x0400238A RID: 9098
		private int _CharImageId;

		// Token: 0x0400238B RID: 9099
		private IExtension extensionObject;

		// Token: 0x0400238C RID: 9100
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400238D RID: 9101
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400238E RID: 9102
		private LuaFunction m_ctor_hotfix;
	}
}
