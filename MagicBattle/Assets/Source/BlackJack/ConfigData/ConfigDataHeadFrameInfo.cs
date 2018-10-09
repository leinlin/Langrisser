using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000240 RID: 576
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ConfigDataHeadFrameInfo")]
	[Serializable]
	public class ConfigDataHeadFrameInfo : IExtensible
	{
		// Token: 0x0600237F RID: 9087 RVA: 0x000A579C File Offset: 0x000A399C
		public ConfigDataHeadFrameInfo()
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

		// Token: 0x17000855 RID: 2133
		// (get) Token: 0x06002380 RID: 9088 RVA: 0x000A5804 File Offset: 0x000A3A04
		// (set) Token: 0x06002381 RID: 9089 RVA: 0x000A580C File Offset: 0x000A3A0C
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

		// Token: 0x17000856 RID: 2134
		// (get) Token: 0x06002382 RID: 9090 RVA: 0x000A5818 File Offset: 0x000A3A18
		// (set) Token: 0x06002383 RID: 9091 RVA: 0x000A5820 File Offset: 0x000A3A20
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

		// Token: 0x17000857 RID: 2135
		// (get) Token: 0x06002384 RID: 9092 RVA: 0x000A582C File Offset: 0x000A3A2C
		// (set) Token: 0x06002385 RID: 9093 RVA: 0x000A5834 File Offset: 0x000A3A34
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

		// Token: 0x17000858 RID: 2136
		// (get) Token: 0x06002386 RID: 9094 RVA: 0x000A5840 File Offset: 0x000A3A40
		// (set) Token: 0x06002387 RID: 9095 RVA: 0x000A5848 File Offset: 0x000A3A48
		[ProtoMember(5, IsRequired = true, Name = "SortID", DataFormat = DataFormat.TwosComplement)]
		public int SortID
		{
			get
			{
				return this._SortID;
			}
			set
			{
				this._SortID = value;
			}
		}

		// Token: 0x17000859 RID: 2137
		// (get) Token: 0x06002388 RID: 9096 RVA: 0x000A5854 File Offset: 0x000A3A54
		// (set) Token: 0x06002389 RID: 9097 RVA: 0x000A585C File Offset: 0x000A3A5C
		[ProtoMember(6, IsRequired = true, Name = "ResourcePath", DataFormat = DataFormat.Default)]
		public string ResourcePath
		{
			get
			{
				return this._ResourcePath;
			}
			set
			{
				this._ResourcePath = value;
			}
		}

		// Token: 0x1700085A RID: 2138
		// (get) Token: 0x0600238A RID: 9098 RVA: 0x000A5868 File Offset: 0x000A3A68
		// (set) Token: 0x0600238B RID: 9099 RVA: 0x000A5870 File Offset: 0x000A3A70
		[ProtoMember(7, IsRequired = true, Name = "Source", DataFormat = DataFormat.Default)]
		public string Source
		{
			get
			{
				return this._Source;
			}
			set
			{
				this._Source = value;
			}
		}

		// Token: 0x1700085B RID: 2139
		// (get) Token: 0x0600238C RID: 9100 RVA: 0x000A587C File Offset: 0x000A3A7C
		// (set) Token: 0x0600238D RID: 9101 RVA: 0x000A5884 File Offset: 0x000A3A84
		[ProtoMember(8, IsRequired = true, Name = "Icon", DataFormat = DataFormat.Default)]
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

		// Token: 0x1700085C RID: 2140
		// (get) Token: 0x0600238E RID: 9102 RVA: 0x000A5890 File Offset: 0x000A3A90
		// (set) Token: 0x0600238F RID: 9103 RVA: 0x000A5898 File Offset: 0x000A3A98
		[ProtoMember(9, IsRequired = true, Name = "Rank", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x06002390 RID: 9104 RVA: 0x000A58A4 File Offset: 0x000A3AA4
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002391 RID: 9105 RVA: 0x000A58B4 File Offset: 0x000A3AB4
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

		// Token: 0x06002392 RID: 9106 RVA: 0x000A5980 File Offset: 0x000A3B80
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataHeadFrameInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04001585 RID: 5509
		private int _ID;

		// Token: 0x04001586 RID: 5510
		private string _Name;

		// Token: 0x04001587 RID: 5511
		private string _Desc;

		// Token: 0x04001588 RID: 5512
		private int _SortID;

		// Token: 0x04001589 RID: 5513
		private string _ResourcePath;

		// Token: 0x0400158A RID: 5514
		private string _Source;

		// Token: 0x0400158B RID: 5515
		private string _Icon;

		// Token: 0x0400158C RID: 5516
		private int _Rank;

		// Token: 0x0400158D RID: 5517
		private IExtension extensionObject;

		// Token: 0x0400158E RID: 5518
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400158F RID: 5519
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04001590 RID: 5520
		private LuaFunction m_ctor_hotfix;
	}
}
