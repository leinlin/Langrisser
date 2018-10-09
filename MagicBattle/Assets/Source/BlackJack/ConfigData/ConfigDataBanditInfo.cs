using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000206 RID: 518
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ConfigDataBanditInfo")]
	[Serializable]
	public class ConfigDataBanditInfo : IExtensible
	{
		// Token: 0x06001DC6 RID: 7622 RVA: 0x0009BBF0 File Offset: 0x00099DF0
		public ConfigDataBanditInfo()
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

		// Token: 0x170005B7 RID: 1463
		// (get) Token: 0x06001DC7 RID: 7623 RVA: 0x0009BC58 File Offset: 0x00099E58
		// (set) Token: 0x06001DC8 RID: 7624 RVA: 0x0009BC60 File Offset: 0x00099E60
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

		// Token: 0x170005B8 RID: 1464
		// (get) Token: 0x06001DC9 RID: 7625 RVA: 0x0009BC6C File Offset: 0x00099E6C
		// (set) Token: 0x06001DCA RID: 7626 RVA: 0x0009BC74 File Offset: 0x00099E74
		[ProtoMember(3, IsRequired = true, Name = "HeroID", DataFormat = DataFormat.TwosComplement)]
		public int HeroID
		{
			get
			{
				return this._HeroID;
			}
			set
			{
				this._HeroID = value;
			}
		}

		// Token: 0x170005B9 RID: 1465
		// (get) Token: 0x06001DCB RID: 7627 RVA: 0x0009BC80 File Offset: 0x00099E80
		// (set) Token: 0x06001DCC RID: 7628 RVA: 0x0009BC88 File Offset: 0x00099E88
		[ProtoMember(4, IsRequired = true, Name = "Gold", DataFormat = DataFormat.TwosComplement)]
		public int Gold
		{
			get
			{
				return this._Gold;
			}
			set
			{
				this._Gold = value;
			}
		}

		// Token: 0x170005BA RID: 1466
		// (get) Token: 0x06001DCD RID: 7629 RVA: 0x0009BC94 File Offset: 0x00099E94
		// (set) Token: 0x06001DCE RID: 7630 RVA: 0x0009BC9C File Offset: 0x00099E9C
		[ProtoMember(5, IsRequired = true, Name = "Rarity", DataFormat = DataFormat.TwosComplement)]
		public int Rarity
		{
			get
			{
				return this._Rarity;
			}
			set
			{
				this._Rarity = value;
			}
		}

		// Token: 0x170005BB RID: 1467
		// (get) Token: 0x06001DCF RID: 7631 RVA: 0x0009BCA8 File Offset: 0x00099EA8
		// (set) Token: 0x06001DD0 RID: 7632 RVA: 0x0009BCB0 File Offset: 0x00099EB0
		[ProtoMember(6, IsRequired = true, Name = "IconResource", DataFormat = DataFormat.Default)]
		public string IconResource
		{
			get
			{
				return this._IconResource;
			}
			set
			{
				this._IconResource = value;
			}
		}

		// Token: 0x06001DD1 RID: 7633 RVA: 0x0009BCBC File Offset: 0x00099EBC
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06001DD2 RID: 7634 RVA: 0x0009BCCC File Offset: 0x00099ECC
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

		// Token: 0x06001DD3 RID: 7635 RVA: 0x0009BD98 File Offset: 0x00099F98
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataBanditInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040011D0 RID: 4560
		private int _ID;

		// Token: 0x040011D1 RID: 4561
		private int _HeroID;

		// Token: 0x040011D2 RID: 4562
		private int _Gold;

		// Token: 0x040011D3 RID: 4563
		private int _Rarity;

		// Token: 0x040011D4 RID: 4564
		private string _IconResource;

		// Token: 0x040011D5 RID: 4565
		private IExtension extensionObject;

		// Token: 0x040011D6 RID: 4566
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040011D7 RID: 4567
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040011D8 RID: 4568
		private LuaFunction m_ctor_hotfix;
	}
}
