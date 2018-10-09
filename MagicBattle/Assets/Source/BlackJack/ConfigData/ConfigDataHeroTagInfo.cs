using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000253 RID: 595
	[ProtoContract(Name = "ConfigDataHeroTagInfo")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ConfigDataHeroTagInfo : IExtensible
	{
		// Token: 0x0600252B RID: 9515 RVA: 0x000A87C0 File Offset: 0x000A69C0
		public ConfigDataHeroTagInfo()
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

		// Token: 0x1700091D RID: 2333
		// (get) Token: 0x0600252C RID: 9516 RVA: 0x000A8834 File Offset: 0x000A6A34
		// (set) Token: 0x0600252D RID: 9517 RVA: 0x000A883C File Offset: 0x000A6A3C
		[ProtoMember(2, IsRequired = true, Name = "ID", DataFormat = DataFormat.TwosComplement)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				this._ID = value;
			}
		}

		// Token: 0x1700091E RID: 2334
		// (get) Token: 0x0600252E RID: 9518 RVA: 0x000A8848 File Offset: 0x000A6A48
		// (set) Token: 0x0600252F RID: 9519 RVA: 0x000A8850 File Offset: 0x000A6A50
		[ProtoMember(3, IsRequired = true, Name = "Name", DataFormat = DataFormat.Default)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				this._Name = value;
			}
		}

		// Token: 0x1700091F RID: 2335
		// (get) Token: 0x06002530 RID: 9520 RVA: 0x000A885C File Offset: 0x000A6A5C
		// (set) Token: 0x06002531 RID: 9521 RVA: 0x000A8864 File Offset: 0x000A6A64
		[ProtoMember(4, IsRequired = true, Name = "Desc", DataFormat = DataFormat.Default)]
		public string Desc
		{
			get
			{
				return this._Desc;
			}
			set
			{
				this._Desc = value;
			}
		}

		// Token: 0x17000920 RID: 2336
		// (get) Token: 0x06002532 RID: 9522 RVA: 0x000A8870 File Offset: 0x000A6A70
		[ProtoMember(5, Name = "RelatedHeros_ID", DataFormat = DataFormat.TwosComplement)]
		public List<int> RelatedHeros_ID
		{
			get
			{
				return this._RelatedHeros_ID;
			}
		}

		// Token: 0x17000921 RID: 2337
		// (get) Token: 0x06002533 RID: 9523 RVA: 0x000A8878 File Offset: 0x000A6A78
		// (set) Token: 0x06002534 RID: 9524 RVA: 0x000A8880 File Offset: 0x000A6A80
		[ProtoMember(6, IsRequired = true, Name = "Icon", DataFormat = DataFormat.Default)]
		public string Icon
		{
			get
			{
				return this._Icon;
			}
			set
			{
				this._Icon = value;
			}
		}

		// Token: 0x06002535 RID: 9525 RVA: 0x000A888C File Offset: 0x000A6A8C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002536 RID: 9526 RVA: 0x000A889C File Offset: 0x000A6A9C
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

		// Token: 0x06002537 RID: 9527 RVA: 0x000A8968 File Offset: 0x000A6B68
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataHeroTagInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040016B6 RID: 5814
		private int _ID;

		// Token: 0x040016B7 RID: 5815
		private string _Name;

		// Token: 0x040016B8 RID: 5816
		private string _Desc;

		// Token: 0x040016B9 RID: 5817
		private readonly List<int> _RelatedHeros_ID = new List<int>();

		// Token: 0x040016BA RID: 5818
		private string _Icon;

		// Token: 0x040016BB RID: 5819
		private IExtension extensionObject;

		// Token: 0x040016BC RID: 5820
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040016BD RID: 5821
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040016BE RID: 5822
		private LuaFunction m_ctor_hotfix;
	}
}
