using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x0200026A RID: 618
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ConfigDataPropertyModifyInfo")]
	[Serializable]
	public class ConfigDataPropertyModifyInfo : IExtensible
	{
		// Token: 0x0600279A RID: 10138 RVA: 0x000AC450 File Offset: 0x000AA650
		public ConfigDataPropertyModifyInfo()
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

		// Token: 0x17000A35 RID: 2613
		// (get) Token: 0x0600279B RID: 10139 RVA: 0x000AC4B8 File Offset: 0x000AA6B8
		// (set) Token: 0x0600279C RID: 10140 RVA: 0x000AC4C0 File Offset: 0x000AA6C0
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

		// Token: 0x17000A36 RID: 2614
		// (get) Token: 0x0600279D RID: 10141 RVA: 0x000AC4CC File Offset: 0x000AA6CC
		// (set) Token: 0x0600279E RID: 10142 RVA: 0x000AC4D4 File Offset: 0x000AA6D4
		[ProtoMember(3, IsRequired = true, Name = "PropertyModifyType", DataFormat = DataFormat.TwosComplement)]
		public PropertyModifyType PropertyModifyType
		{
			get
			{
				return this._PropertyModifyType;
			}
			set
			{
				this._PropertyModifyType = value;
			}
		}

		// Token: 0x17000A37 RID: 2615
		// (get) Token: 0x0600279F RID: 10143 RVA: 0x000AC4E0 File Offset: 0x000AA6E0
		// (set) Token: 0x060027A0 RID: 10144 RVA: 0x000AC4E8 File Offset: 0x000AA6E8
		[ProtoMember(4, IsRequired = true, Name = "Name", DataFormat = DataFormat.Default)]
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

		// Token: 0x17000A38 RID: 2616
		// (get) Token: 0x060027A1 RID: 10145 RVA: 0x000AC4F4 File Offset: 0x000AA6F4
		// (set) Token: 0x060027A2 RID: 10146 RVA: 0x000AC4FC File Offset: 0x000AA6FC
		[ProtoMember(5, IsRequired = true, Name = "IsAddType", DataFormat = DataFormat.Default)]
		public bool IsAddType
		{
			get
			{
				return this._IsAddType;
			}
			set
			{
				this._IsAddType = value;
			}
		}

		// Token: 0x17000A39 RID: 2617
		// (get) Token: 0x060027A3 RID: 10147 RVA: 0x000AC508 File Offset: 0x000AA708
		// (set) Token: 0x060027A4 RID: 10148 RVA: 0x000AC510 File Offset: 0x000AA710
		[ProtoMember(6, IsRequired = true, Name = "IsDynamic", DataFormat = DataFormat.Default)]
		public bool IsDynamic
		{
			get
			{
				return this._IsDynamic;
			}
			set
			{
				this._IsDynamic = value;
			}
		}

		// Token: 0x17000A3A RID: 2618
		// (get) Token: 0x060027A5 RID: 10149 RVA: 0x000AC51C File Offset: 0x000AA71C
		// (set) Token: 0x060027A6 RID: 10150 RVA: 0x000AC524 File Offset: 0x000AA724
		[ProtoMember(7, IsRequired = true, Name = "PropertyType", DataFormat = DataFormat.TwosComplement)]
		public PropertyType PropertyType
		{
			get
			{
				return this._PropertyType;
			}
			set
			{
				this._PropertyType = value;
			}
		}

		// Token: 0x060027A7 RID: 10151 RVA: 0x000AC530 File Offset: 0x000AA730
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060027A8 RID: 10152 RVA: 0x000AC540 File Offset: 0x000AA740
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

		// Token: 0x060027A9 RID: 10153 RVA: 0x000AC60C File Offset: 0x000AA80C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataPropertyModifyInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04001844 RID: 6212
		private int _ID;

		// Token: 0x04001845 RID: 6213
		private PropertyModifyType _PropertyModifyType;

		// Token: 0x04001846 RID: 6214
		private string _Name;

		// Token: 0x04001847 RID: 6215
		private bool _IsAddType;

		// Token: 0x04001848 RID: 6216
		private bool _IsDynamic;

		// Token: 0x04001849 RID: 6217
		private PropertyType _PropertyType;

		// Token: 0x0400184A RID: 6218
		private IExtension extensionObject;

		// Token: 0x0400184B RID: 6219
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400184C RID: 6220
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400184D RID: 6221
		private LuaFunction m_ctor_hotfix;
	}
}
