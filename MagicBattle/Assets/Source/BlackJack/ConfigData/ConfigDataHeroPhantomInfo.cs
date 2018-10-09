using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x0200024F RID: 591
	[ProtoContract(Name = "ConfigDataHeroPhantomInfo")]
	[CustomLuaClass]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ConfigDataHeroPhantomInfo : IExtensible
	{
		// Token: 0x060024C6 RID: 9414 RVA: 0x000A7D80 File Offset: 0x000A5F80
		public ConfigDataHeroPhantomInfo()
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

		// Token: 0x170008EF RID: 2287
		// (get) Token: 0x060024C7 RID: 9415 RVA: 0x000A7DF4 File Offset: 0x000A5FF4
		// (set) Token: 0x060024C8 RID: 9416 RVA: 0x000A7DFC File Offset: 0x000A5FFC
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

		// Token: 0x170008F0 RID: 2288
		// (get) Token: 0x060024C9 RID: 9417 RVA: 0x000A7E08 File Offset: 0x000A6008
		// (set) Token: 0x060024CA RID: 9418 RVA: 0x000A7E10 File Offset: 0x000A6010
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

		// Token: 0x170008F1 RID: 2289
		// (get) Token: 0x060024CB RID: 9419 RVA: 0x000A7E1C File Offset: 0x000A601C
		// (set) Token: 0x060024CC RID: 9420 RVA: 0x000A7E24 File Offset: 0x000A6024
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

		// Token: 0x170008F2 RID: 2290
		// (get) Token: 0x060024CD RID: 9421 RVA: 0x000A7E30 File Offset: 0x000A6030
		[ProtoMember(5, Name = "LevelList", DataFormat = DataFormat.TwosComplement)]
		public List<int> LevelList
		{
			get
			{
				return this._LevelList;
			}
		}

		// Token: 0x170008F3 RID: 2291
		// (get) Token: 0x060024CE RID: 9422 RVA: 0x000A7E38 File Offset: 0x000A6038
		// (set) Token: 0x060024CF RID: 9423 RVA: 0x000A7E40 File Offset: 0x000A6040
		[ProtoMember(6, IsRequired = true, Name = "OpenDateTime", DataFormat = DataFormat.Default)]
		public string OpenDateTime
		{
			get
			{
				return this._OpenDateTime;
			}
			set
			{
				this._OpenDateTime = value;
			}
		}

		// Token: 0x170008F4 RID: 2292
		// (get) Token: 0x060024D0 RID: 9424 RVA: 0x000A7E4C File Offset: 0x000A604C
		// (set) Token: 0x060024D1 RID: 9425 RVA: 0x000A7E54 File Offset: 0x000A6054
		[ProtoMember(7, IsRequired = true, Name = "CloseDateTime", DataFormat = DataFormat.Default)]
		public string CloseDateTime
		{
			get
			{
				return this._CloseDateTime;
			}
			set
			{
				this._CloseDateTime = value;
			}
		}

		// Token: 0x170008F5 RID: 2293
		// (get) Token: 0x060024D2 RID: 9426 RVA: 0x000A7E60 File Offset: 0x000A6060
		// (set) Token: 0x060024D3 RID: 9427 RVA: 0x000A7E68 File Offset: 0x000A6068
		[ProtoMember(8, IsRequired = true, Name = "ShowDateTime", DataFormat = DataFormat.Default)]
		public string ShowDateTime
		{
			get
			{
				return this._ShowDateTime;
			}
			set
			{
				this._ShowDateTime = value;
			}
		}

		// Token: 0x170008F6 RID: 2294
		// (get) Token: 0x060024D4 RID: 9428 RVA: 0x000A7E74 File Offset: 0x000A6074
		// (set) Token: 0x060024D5 RID: 9429 RVA: 0x000A7E7C File Offset: 0x000A607C
		[ProtoMember(9, IsRequired = true, Name = "HideDateTime", DataFormat = DataFormat.Default)]
		public string HideDateTime
		{
			get
			{
				return this._HideDateTime;
			}
			set
			{
				this._HideDateTime = value;
			}
		}

		// Token: 0x170008F7 RID: 2295
		// (get) Token: 0x060024D6 RID: 9430 RVA: 0x000A7E88 File Offset: 0x000A6088
		// (set) Token: 0x060024D7 RID: 9431 RVA: 0x000A7E90 File Offset: 0x000A6090
		[ProtoMember(10, IsRequired = true, Name = "Image", DataFormat = DataFormat.Default)]
		public string Image
		{
			get
			{
				return this._Image;
			}
			set
			{
				this._Image = value;
			}
		}

		// Token: 0x170008F8 RID: 2296
		// (get) Token: 0x060024D8 RID: 9432 RVA: 0x000A7E9C File Offset: 0x000A609C
		// (set) Token: 0x060024D9 RID: 9433 RVA: 0x000A7EA4 File Offset: 0x000A60A4
		[ProtoMember(11, IsRequired = true, Name = "Model", DataFormat = DataFormat.Default)]
		public string Model
		{
			get
			{
				return this._Model;
			}
			set
			{
				this._Model = value;
			}
		}

		// Token: 0x170008F9 RID: 2297
		// (get) Token: 0x060024DA RID: 9434 RVA: 0x000A7EB0 File Offset: 0x000A60B0
		// (set) Token: 0x060024DB RID: 9435 RVA: 0x000A7EB8 File Offset: 0x000A60B8
		[ProtoMember(12, IsRequired = true, Name = "UI_ModelScale", DataFormat = DataFormat.TwosComplement)]
		public int UI_ModelScale
		{
			get
			{
				return this._UI_ModelScale;
			}
			set
			{
				this._UI_ModelScale = value;
			}
		}

		// Token: 0x170008FA RID: 2298
		// (get) Token: 0x060024DC RID: 9436 RVA: 0x000A7EC4 File Offset: 0x000A60C4
		// (set) Token: 0x060024DD RID: 9437 RVA: 0x000A7ECC File Offset: 0x000A60CC
		[ProtoMember(13, IsRequired = true, Name = "UI_ModelOffsetX", DataFormat = DataFormat.TwosComplement)]
		public int UI_ModelOffsetX
		{
			get
			{
				return this._UI_ModelOffsetX;
			}
			set
			{
				this._UI_ModelOffsetX = value;
			}
		}

		// Token: 0x170008FB RID: 2299
		// (get) Token: 0x060024DE RID: 9438 RVA: 0x000A7ED8 File Offset: 0x000A60D8
		// (set) Token: 0x060024DF RID: 9439 RVA: 0x000A7EE0 File Offset: 0x000A60E0
		[ProtoMember(14, IsRequired = true, Name = "UI_ModelOffsetY", DataFormat = DataFormat.TwosComplement)]
		public int UI_ModelOffsetY
		{
			get
			{
				return this._UI_ModelOffsetY;
			}
			set
			{
				this._UI_ModelOffsetY = value;
			}
		}

		// Token: 0x060024E0 RID: 9440 RVA: 0x000A7EEC File Offset: 0x000A60EC
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060024E1 RID: 9441 RVA: 0x000A7EFC File Offset: 0x000A60FC
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

		// Token: 0x060024E2 RID: 9442 RVA: 0x000A7FC8 File Offset: 0x000A61C8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataHeroPhantomInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04001673 RID: 5747
		private int _ID;

		// Token: 0x04001674 RID: 5748
		private string _Name;

		// Token: 0x04001675 RID: 5749
		private string _Desc;

		// Token: 0x04001676 RID: 5750
		private readonly List<int> _LevelList = new List<int>();

		// Token: 0x04001677 RID: 5751
		private string _OpenDateTime;

		// Token: 0x04001678 RID: 5752
		private string _CloseDateTime;

		// Token: 0x04001679 RID: 5753
		private string _ShowDateTime;

		// Token: 0x0400167A RID: 5754
		private string _HideDateTime;

		// Token: 0x0400167B RID: 5755
		private string _Image;

		// Token: 0x0400167C RID: 5756
		private string _Model;

		// Token: 0x0400167D RID: 5757
		private int _UI_ModelScale;

		// Token: 0x0400167E RID: 5758
		private int _UI_ModelOffsetX;

		// Token: 0x0400167F RID: 5759
		private int _UI_ModelOffsetY;

		// Token: 0x04001680 RID: 5760
		private IExtension extensionObject;

		// Token: 0x04001681 RID: 5761
		public List<ConfigDataHeroPhantomLevelInfo> m_levels;

		// Token: 0x04001682 RID: 5762
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04001683 RID: 5763
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04001684 RID: 5764
		private LuaFunction m_ctor_hotfix;
	}
}
