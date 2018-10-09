using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000265 RID: 613
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ConfigDataOperationalActivityInfo")]
	[Serializable]
	public class ConfigDataOperationalActivityInfo : IExtensible
	{
		// Token: 0x06002757 RID: 10071 RVA: 0x000ABA00 File Offset: 0x000A9C00
		public ConfigDataOperationalActivityInfo()
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

		// Token: 0x17000A1C RID: 2588
		// (get) Token: 0x06002758 RID: 10072 RVA: 0x000ABA74 File Offset: 0x000A9C74
		// (set) Token: 0x06002759 RID: 10073 RVA: 0x000ABA7C File Offset: 0x000A9C7C
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

		// Token: 0x17000A1D RID: 2589
		// (get) Token: 0x0600275A RID: 10074 RVA: 0x000ABA88 File Offset: 0x000A9C88
		// (set) Token: 0x0600275B RID: 10075 RVA: 0x000ABA90 File Offset: 0x000A9C90
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

		// Token: 0x17000A1E RID: 2590
		// (get) Token: 0x0600275C RID: 10076 RVA: 0x000ABA9C File Offset: 0x000A9C9C
		// (set) Token: 0x0600275D RID: 10077 RVA: 0x000ABAA4 File Offset: 0x000A9CA4
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

		// Token: 0x17000A1F RID: 2591
		// (get) Token: 0x0600275E RID: 10078 RVA: 0x000ABAB0 File Offset: 0x000A9CB0
		// (set) Token: 0x0600275F RID: 10079 RVA: 0x000ABAB8 File Offset: 0x000A9CB8
		[ProtoMember(5, IsRequired = true, Name = "ActivityType", DataFormat = DataFormat.TwosComplement)]
		public OperationalActivityType ActivityType
		{
			get
			{
				return this._ActivityType;
			}
			set
			{
				this._ActivityType = value;
			}
		}

		// Token: 0x17000A20 RID: 2592
		// (get) Token: 0x06002760 RID: 10080 RVA: 0x000ABAC4 File Offset: 0x000A9CC4
		[ProtoMember(6, Name = "OperationalActivityParms", DataFormat = DataFormat.Default)]
		public List<ActivityParam> OperationalActivityParms
		{
			get
			{
				return this._OperationalActivityParms;
			}
		}

		// Token: 0x17000A21 RID: 2593
		// (get) Token: 0x06002761 RID: 10081 RVA: 0x000ABACC File Offset: 0x000A9CCC
		// (set) Token: 0x06002762 RID: 10082 RVA: 0x000ABAD4 File Offset: 0x000A9CD4
		[ProtoMember(7, IsRequired = true, Name = "SkipPageID", DataFormat = DataFormat.TwosComplement)]
		public int SkipPageID
		{
			get
			{
				return this._SkipPageID;
			}
			set
			{
				this._SkipPageID = value;
			}
		}

		// Token: 0x17000A22 RID: 2594
		// (get) Token: 0x06002763 RID: 10083 RVA: 0x000ABAE0 File Offset: 0x000A9CE0
		// (set) Token: 0x06002764 RID: 10084 RVA: 0x000ABAE8 File Offset: 0x000A9CE8
		[ProtoMember(8, IsRequired = true, Name = "SortID", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17000A23 RID: 2595
		// (get) Token: 0x06002765 RID: 10085 RVA: 0x000ABAF4 File Offset: 0x000A9CF4
		// (set) Token: 0x06002766 RID: 10086 RVA: 0x000ABAFC File Offset: 0x000A9CFC
		[ProtoMember(9, IsRequired = true, Name = "Image", DataFormat = DataFormat.Default)]
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

		// Token: 0x17000A24 RID: 2596
		// (get) Token: 0x06002767 RID: 10087 RVA: 0x000ABB08 File Offset: 0x000A9D08
		// (set) Token: 0x06002768 RID: 10088 RVA: 0x000ABB10 File Offset: 0x000A9D10
		[ProtoMember(10, IsRequired = true, Name = "AdvertisingImage", DataFormat = DataFormat.Default)]
		public string AdvertisingImage
		{
			get
			{
				return this._AdvertisingImage;
			}
			set
			{
				this._AdvertisingImage = value;
			}
		}

		// Token: 0x17000A25 RID: 2597
		// (get) Token: 0x06002769 RID: 10089 RVA: 0x000ABB1C File Offset: 0x000A9D1C
		// (set) Token: 0x0600276A RID: 10090 RVA: 0x000ABB24 File Offset: 0x000A9D24
		[ProtoMember(11, IsRequired = true, Name = "Desc", DataFormat = DataFormat.Default)]
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

		// Token: 0x17000A26 RID: 2598
		// (get) Token: 0x0600276B RID: 10091 RVA: 0x000ABB30 File Offset: 0x000A9D30
		// (set) Token: 0x0600276C RID: 10092 RVA: 0x000ABB38 File Offset: 0x000A9D38
		[ProtoMember(12, IsRequired = true, Name = "DaysAfterServerOpen", DataFormat = DataFormat.TwosComplement)]
		public int DaysAfterServerOpen
		{
			get
			{
				return this._DaysAfterServerOpen;
			}
			set
			{
				this._DaysAfterServerOpen = value;
			}
		}

		// Token: 0x17000A27 RID: 2599
		// (get) Token: 0x0600276D RID: 10093 RVA: 0x000ABB44 File Offset: 0x000A9D44
		// (set) Token: 0x0600276E RID: 10094 RVA: 0x000ABB4C File Offset: 0x000A9D4C
		[ProtoMember(13, IsRequired = true, Name = "DaysAfterPlayerCreated", DataFormat = DataFormat.TwosComplement)]
		public int DaysAfterPlayerCreated
		{
			get
			{
				return this._DaysAfterPlayerCreated;
			}
			set
			{
				this._DaysAfterPlayerCreated = value;
			}
		}

		// Token: 0x0600276F RID: 10095 RVA: 0x000ABB58 File Offset: 0x000A9D58
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002770 RID: 10096 RVA: 0x000ABB68 File Offset: 0x000A9D68
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

		// Token: 0x06002771 RID: 10097 RVA: 0x000ABC34 File Offset: 0x000A9E34
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataOperationalActivityInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04001817 RID: 6167
		private int _ID;

		// Token: 0x04001818 RID: 6168
		private string _Title;

		// Token: 0x04001819 RID: 6169
		private string _Content;

		// Token: 0x0400181A RID: 6170
		private OperationalActivityType _ActivityType;

		// Token: 0x0400181B RID: 6171
		private readonly List<ActivityParam> _OperationalActivityParms = new List<ActivityParam>();

		// Token: 0x0400181C RID: 6172
		private int _SkipPageID;

		// Token: 0x0400181D RID: 6173
		private int _SortID;

		// Token: 0x0400181E RID: 6174
		private string _Image;

		// Token: 0x0400181F RID: 6175
		private string _AdvertisingImage;

		// Token: 0x04001820 RID: 6176
		private string _Desc;

		// Token: 0x04001821 RID: 6177
		private int _DaysAfterServerOpen;

		// Token: 0x04001822 RID: 6178
		private int _DaysAfterPlayerCreated;

		// Token: 0x04001823 RID: 6179
		private IExtension extensionObject;

		// Token: 0x04001824 RID: 6180
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04001825 RID: 6181
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04001826 RID: 6182
		private LuaFunction m_ctor_hotfix;
	}
}
