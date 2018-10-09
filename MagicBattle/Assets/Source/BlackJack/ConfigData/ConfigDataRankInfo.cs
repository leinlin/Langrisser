using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000276 RID: 630
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ConfigDataRankInfo")]
	[Serializable]
	public class ConfigDataRankInfo : IExtensible
	{
		// Token: 0x0600284E RID: 10318 RVA: 0x000ADDF4 File Offset: 0x000ABFF4
		public ConfigDataRankInfo()
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

		// Token: 0x17000A7D RID: 2685
		// (get) Token: 0x0600284F RID: 10319 RVA: 0x000ADE5C File Offset: 0x000AC05C
		// (set) Token: 0x06002850 RID: 10320 RVA: 0x000ADE64 File Offset: 0x000AC064
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

		// Token: 0x17000A7E RID: 2686
		// (get) Token: 0x06002851 RID: 10321 RVA: 0x000ADE70 File Offset: 0x000AC070
		// (set) Token: 0x06002852 RID: 10322 RVA: 0x000ADE78 File Offset: 0x000AC078
		[ProtoMember(3, IsRequired = true, Name = "Desc", DataFormat = DataFormat.Default)]
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

		// Token: 0x06002853 RID: 10323 RVA: 0x000ADE84 File Offset: 0x000AC084
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002854 RID: 10324 RVA: 0x000ADE94 File Offset: 0x000AC094
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

		// Token: 0x06002855 RID: 10325 RVA: 0x000ADF60 File Offset: 0x000AC160
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataRankInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040018C0 RID: 6336
		private int _ID;

		// Token: 0x040018C1 RID: 6337
		private string _Desc;

		// Token: 0x040018C2 RID: 6338
		private IExtension extensionObject;

		// Token: 0x040018C3 RID: 6339
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040018C4 RID: 6340
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040018C5 RID: 6341
		private LuaFunction m_ctor_hotfix;
	}
}
