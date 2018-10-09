using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000219 RID: 537
	[ProtoContract(Name = "ConfigDataBuyArenaTicketInfo")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ConfigDataBuyArenaTicketInfo : IExtensible
	{
		// Token: 0x06001F8E RID: 8078 RVA: 0x0009F1D4 File Offset: 0x0009D3D4
		public ConfigDataBuyArenaTicketInfo()
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

		// Token: 0x17000687 RID: 1671
		// (get) Token: 0x06001F8F RID: 8079 RVA: 0x0009F23C File Offset: 0x0009D43C
		// (set) Token: 0x06001F90 RID: 8080 RVA: 0x0009F244 File Offset: 0x0009D444
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

		// Token: 0x17000688 RID: 1672
		// (get) Token: 0x06001F91 RID: 8081 RVA: 0x0009F250 File Offset: 0x0009D450
		// (set) Token: 0x06001F92 RID: 8082 RVA: 0x0009F258 File Offset: 0x0009D458
		[ProtoMember(3, IsRequired = true, Name = "Price", DataFormat = DataFormat.TwosComplement)]
		public int Price
		{
			get
			{
				return this._Price;
			}
			set
			{
				this._Price = value;
			}
		}

		// Token: 0x06001F93 RID: 8083 RVA: 0x0009F264 File Offset: 0x0009D464
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06001F94 RID: 8084 RVA: 0x0009F274 File Offset: 0x0009D474
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

		// Token: 0x06001F95 RID: 8085 RVA: 0x0009F340 File Offset: 0x0009D540
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataBuyArenaTicketInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04001308 RID: 4872
		private int _ID;

		// Token: 0x04001309 RID: 4873
		private int _Price;

		// Token: 0x0400130A RID: 4874
		private IExtension extensionObject;

		// Token: 0x0400130B RID: 4875
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400130C RID: 4876
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400130D RID: 4877
		private LuaFunction m_ctor_hotfix;
	}
}
