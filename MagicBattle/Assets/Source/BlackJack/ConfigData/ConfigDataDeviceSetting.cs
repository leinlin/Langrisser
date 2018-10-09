using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000227 RID: 551
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ConfigDataDeviceSetting")]
	[Serializable]
	public class ConfigDataDeviceSetting : IExtensible
	{
		// Token: 0x060020D6 RID: 8406 RVA: 0x000A1470 File Offset: 0x0009F670
		public ConfigDataDeviceSetting()
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

		// Token: 0x17000717 RID: 1815
		// (get) Token: 0x060020D7 RID: 8407 RVA: 0x000A14D8 File Offset: 0x0009F6D8
		// (set) Token: 0x060020D8 RID: 8408 RVA: 0x000A14E0 File Offset: 0x0009F6E0
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

		// Token: 0x17000718 RID: 1816
		// (get) Token: 0x060020D9 RID: 8409 RVA: 0x000A14EC File Offset: 0x0009F6EC
		// (set) Token: 0x060020DA RID: 8410 RVA: 0x000A14F4 File Offset: 0x0009F6F4
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

		// Token: 0x17000719 RID: 1817
		// (get) Token: 0x060020DB RID: 8411 RVA: 0x000A1500 File Offset: 0x0009F700
		// (set) Token: 0x060020DC RID: 8412 RVA: 0x000A1508 File Offset: 0x0009F708
		[ProtoMember(4, IsRequired = true, Name = "DeviceModel", DataFormat = DataFormat.Default)]
		public string DeviceModel
		{
			get
			{
				return this._DeviceModel;
			}
			set
			{
				this._DeviceModel = value;
			}
		}

		// Token: 0x1700071A RID: 1818
		// (get) Token: 0x060020DD RID: 8413 RVA: 0x000A1514 File Offset: 0x0009F714
		// (set) Token: 0x060020DE RID: 8414 RVA: 0x000A151C File Offset: 0x0009F71C
		[ProtoMember(5, IsRequired = true, Name = "MarginFixHorizontal", DataFormat = DataFormat.Default)]
		public bool MarginFixHorizontal
		{
			get
			{
				return this._MarginFixHorizontal;
			}
			set
			{
				this._MarginFixHorizontal = value;
			}
		}

		// Token: 0x1700071B RID: 1819
		// (get) Token: 0x060020DF RID: 8415 RVA: 0x000A1528 File Offset: 0x0009F728
		// (set) Token: 0x060020E0 RID: 8416 RVA: 0x000A1530 File Offset: 0x0009F730
		[ProtoMember(6, IsRequired = true, Name = "MarginFixVertical", DataFormat = DataFormat.Default)]
		public bool MarginFixVertical
		{
			get
			{
				return this._MarginFixVertical;
			}
			set
			{
				this._MarginFixVertical = value;
			}
		}

		// Token: 0x060020E1 RID: 8417 RVA: 0x000A153C File Offset: 0x0009F73C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060020E2 RID: 8418 RVA: 0x000A154C File Offset: 0x0009F74C
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

		// Token: 0x060020E3 RID: 8419 RVA: 0x000A1618 File Offset: 0x0009F818
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataDeviceSetting));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040013DB RID: 5083
		private int _ID;

		// Token: 0x040013DC RID: 5084
		private string _Name;

		// Token: 0x040013DD RID: 5085
		private string _DeviceModel;

		// Token: 0x040013DE RID: 5086
		private bool _MarginFixHorizontal;

		// Token: 0x040013DF RID: 5087
		private bool _MarginFixVertical;

		// Token: 0x040013E0 RID: 5088
		private IExtension extensionObject;

		// Token: 0x040013E1 RID: 5089
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040013E2 RID: 5090
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040013E3 RID: 5091
		private LuaFunction m_ctor_hotfix;
	}
}
