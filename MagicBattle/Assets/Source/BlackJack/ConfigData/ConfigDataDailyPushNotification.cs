using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000226 RID: 550
	[ProtoContract(Name = "ConfigDataDailyPushNotification")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ConfigDataDailyPushNotification : IExtensible
	{
		// Token: 0x060020C4 RID: 8388 RVA: 0x000A1238 File Offset: 0x0009F438
		public ConfigDataDailyPushNotification()
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

		// Token: 0x17000710 RID: 1808
		// (get) Token: 0x060020C5 RID: 8389 RVA: 0x000A12A0 File Offset: 0x0009F4A0
		// (set) Token: 0x060020C6 RID: 8390 RVA: 0x000A12A8 File Offset: 0x0009F4A8
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

		// Token: 0x17000711 RID: 1809
		// (get) Token: 0x060020C7 RID: 8391 RVA: 0x000A12B4 File Offset: 0x0009F4B4
		// (set) Token: 0x060020C8 RID: 8392 RVA: 0x000A12BC File Offset: 0x0009F4BC
		[ProtoMember(3, IsRequired = true, Name = "Title", DataFormat = DataFormat.Default)]
		public string Title
		{
			get
			{
				return this._Title;
			}
			set
			{
				this._Title = value;
			}
		}

		// Token: 0x17000712 RID: 1810
		// (get) Token: 0x060020C9 RID: 8393 RVA: 0x000A12C8 File Offset: 0x0009F4C8
		// (set) Token: 0x060020CA RID: 8394 RVA: 0x000A12D0 File Offset: 0x0009F4D0
		[ProtoMember(4, IsRequired = true, Name = "Content", DataFormat = DataFormat.Default)]
		public string Content
		{
			get
			{
				return this._Content;
			}
			set
			{
				this._Content = value;
			}
		}

		// Token: 0x17000713 RID: 1811
		// (get) Token: 0x060020CB RID: 8395 RVA: 0x000A12DC File Offset: 0x0009F4DC
		// (set) Token: 0x060020CC RID: 8396 RVA: 0x000A12E4 File Offset: 0x0009F4E4
		[ProtoMember(5, IsRequired = true, Name = "Hour", DataFormat = DataFormat.TwosComplement)]
		public int Hour
		{
			get
			{
				return this._Hour;
			}
			set
			{
				this._Hour = value;
			}
		}

		// Token: 0x17000714 RID: 1812
		// (get) Token: 0x060020CD RID: 8397 RVA: 0x000A12F0 File Offset: 0x0009F4F0
		// (set) Token: 0x060020CE RID: 8398 RVA: 0x000A12F8 File Offset: 0x0009F4F8
		[ProtoMember(6, IsRequired = true, Name = "Minute", DataFormat = DataFormat.TwosComplement)]
		public int Minute
		{
			get
			{
				return this._Minute;
			}
			set
			{
				this._Minute = value;
			}
		}

		// Token: 0x17000715 RID: 1813
		// (get) Token: 0x060020CF RID: 8399 RVA: 0x000A1304 File Offset: 0x0009F504
		// (set) Token: 0x060020D0 RID: 8400 RVA: 0x000A130C File Offset: 0x0009F50C
		[ProtoMember(7, IsRequired = true, Name = "PushCondition", DataFormat = DataFormat.TwosComplement)]
		public UserGuideCondition PushCondition
		{
			get
			{
				return this._PushCondition;
			}
			set
			{
				this._PushCondition = value;
			}
		}

		// Token: 0x17000716 RID: 1814
		// (get) Token: 0x060020D1 RID: 8401 RVA: 0x000A1318 File Offset: 0x0009F518
		// (set) Token: 0x060020D2 RID: 8402 RVA: 0x000A1320 File Offset: 0x0009F520
		[ProtoMember(8, IsRequired = true, Name = "PCParam", DataFormat = DataFormat.Default)]
		public string PCParam
		{
			get
			{
				return this._PCParam;
			}
			set
			{
				this._PCParam = value;
			}
		}

		// Token: 0x060020D3 RID: 8403 RVA: 0x000A132C File Offset: 0x0009F52C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060020D4 RID: 8404 RVA: 0x000A133C File Offset: 0x0009F53C
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

		// Token: 0x060020D5 RID: 8405 RVA: 0x000A1408 File Offset: 0x0009F608
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataDailyPushNotification));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040013D0 RID: 5072
		private int _ID;

		// Token: 0x040013D1 RID: 5073
		private string _Title;

		// Token: 0x040013D2 RID: 5074
		private string _Content;

		// Token: 0x040013D3 RID: 5075
		private int _Hour;

		// Token: 0x040013D4 RID: 5076
		private int _Minute;

		// Token: 0x040013D5 RID: 5077
		private UserGuideCondition _PushCondition;

		// Token: 0x040013D6 RID: 5078
		private string _PCParam;

		// Token: 0x040013D7 RID: 5079
		private IExtension extensionObject;

		// Token: 0x040013D8 RID: 5080
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040013D9 RID: 5081
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040013DA RID: 5082
		private LuaFunction m_ctor_hotfix;
	}
}
