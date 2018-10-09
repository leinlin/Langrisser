using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x0200021A RID: 538
	[ProtoContract(Name = "ConfigDataBuyEnergyInfo")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ConfigDataBuyEnergyInfo : IExtensible
	{
		// Token: 0x06001F96 RID: 8086 RVA: 0x0009F3A8 File Offset: 0x0009D5A8
		public ConfigDataBuyEnergyInfo()
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

		// Token: 0x17000689 RID: 1673
		// (get) Token: 0x06001F97 RID: 8087 RVA: 0x0009F410 File Offset: 0x0009D610
		// (set) Token: 0x06001F98 RID: 8088 RVA: 0x0009F418 File Offset: 0x0009D618
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

		// Token: 0x1700068A RID: 1674
		// (get) Token: 0x06001F99 RID: 8089 RVA: 0x0009F424 File Offset: 0x0009D624
		// (set) Token: 0x06001F9A RID: 8090 RVA: 0x0009F42C File Offset: 0x0009D62C
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

		// Token: 0x06001F9B RID: 8091 RVA: 0x0009F438 File Offset: 0x0009D638
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06001F9C RID: 8092 RVA: 0x0009F448 File Offset: 0x0009D648
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

		// Token: 0x06001F9D RID: 8093 RVA: 0x0009F514 File Offset: 0x0009D714
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataBuyEnergyInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400130E RID: 4878
		private int _ID;

		// Token: 0x0400130F RID: 4879
		private int _Price;

		// Token: 0x04001310 RID: 4880
		private IExtension extensionObject;

		// Token: 0x04001311 RID: 4881
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04001312 RID: 4882
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04001313 RID: 4883
		private LuaFunction m_ctor_hotfix;
	}
}
