using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000205 RID: 517
	[ProtoContract(Name = "ConfigDataAssetReplaceInfo")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ConfigDataAssetReplaceInfo : IExtensible
	{
		// Token: 0x06001DBA RID: 7610 RVA: 0x0009B9F4 File Offset: 0x00099BF4
		public ConfigDataAssetReplaceInfo()
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

		// Token: 0x170005B3 RID: 1459
		// (get) Token: 0x06001DBB RID: 7611 RVA: 0x0009BA5C File Offset: 0x00099C5C
		// (set) Token: 0x06001DBC RID: 7612 RVA: 0x0009BA64 File Offset: 0x00099C64
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

		// Token: 0x170005B4 RID: 1460
		// (get) Token: 0x06001DBD RID: 7613 RVA: 0x0009BA70 File Offset: 0x00099C70
		// (set) Token: 0x06001DBE RID: 7614 RVA: 0x0009BA78 File Offset: 0x00099C78
		[ProtoMember(3, IsRequired = true, Name = "OldPath", DataFormat = DataFormat.Default)]
		public string OldPath
		{
			get
			{
				return this._OldPath;
			}
			set
			{
				this._OldPath = value;
			}
		}

		// Token: 0x170005B5 RID: 1461
		// (get) Token: 0x06001DBF RID: 7615 RVA: 0x0009BA84 File Offset: 0x00099C84
		// (set) Token: 0x06001DC0 RID: 7616 RVA: 0x0009BA8C File Offset: 0x00099C8C
		[ProtoMember(4, IsRequired = true, Name = "NewPath", DataFormat = DataFormat.Default)]
		public string NewPath
		{
			get
			{
				return this._NewPath;
			}
			set
			{
				this._NewPath = value;
			}
		}

		// Token: 0x170005B6 RID: 1462
		// (get) Token: 0x06001DC1 RID: 7617 RVA: 0x0009BA98 File Offset: 0x00099C98
		// (set) Token: 0x06001DC2 RID: 7618 RVA: 0x0009BAA0 File Offset: 0x00099CA0
		[ProtoMember(5, IsRequired = true, Name = "Desc", DataFormat = DataFormat.Default)]
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

		// Token: 0x06001DC3 RID: 7619 RVA: 0x0009BAAC File Offset: 0x00099CAC
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06001DC4 RID: 7620 RVA: 0x0009BABC File Offset: 0x00099CBC
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

		// Token: 0x06001DC5 RID: 7621 RVA: 0x0009BB88 File Offset: 0x00099D88
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataAssetReplaceInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040011C8 RID: 4552
		private int _ID;

		// Token: 0x040011C9 RID: 4553
		private string _OldPath;

		// Token: 0x040011CA RID: 4554
		private string _NewPath;

		// Token: 0x040011CB RID: 4555
		private string _Desc;

		// Token: 0x040011CC RID: 4556
		private IExtension extensionObject;

		// Token: 0x040011CD RID: 4557
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040011CE RID: 4558
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040011CF RID: 4559
		private LuaFunction m_ctor_hotfix;
	}
}
