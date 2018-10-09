using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x0200025E RID: 606
	[ProtoContract(Name = "ConfigDataMemoryCorridorInfo")]
	[CustomLuaClass]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ConfigDataMemoryCorridorInfo : IExtensible
	{
		// Token: 0x060026A8 RID: 9896 RVA: 0x000AA854 File Offset: 0x000A8A54
		public ConfigDataMemoryCorridorInfo()
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

		// Token: 0x170009CF RID: 2511
		// (get) Token: 0x060026A9 RID: 9897 RVA: 0x000AA8D0 File Offset: 0x000A8AD0
		// (set) Token: 0x060026AA RID: 9898 RVA: 0x000AA8D8 File Offset: 0x000A8AD8
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

		// Token: 0x170009D0 RID: 2512
		// (get) Token: 0x060026AB RID: 9899 RVA: 0x000AA8E4 File Offset: 0x000A8AE4
		// (set) Token: 0x060026AC RID: 9900 RVA: 0x000AA8EC File Offset: 0x000A8AEC
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

		// Token: 0x170009D1 RID: 2513
		// (get) Token: 0x060026AD RID: 9901 RVA: 0x000AA8F8 File Offset: 0x000A8AF8
		// (set) Token: 0x060026AE RID: 9902 RVA: 0x000AA900 File Offset: 0x000A8B00
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

		// Token: 0x170009D2 RID: 2514
		// (get) Token: 0x060026AF RID: 9903 RVA: 0x000AA90C File Offset: 0x000A8B0C
		// (set) Token: 0x060026B0 RID: 9904 RVA: 0x000AA914 File Offset: 0x000A8B14
		[ProtoMember(5, IsRequired = true, Name = "TeamName", DataFormat = DataFormat.Default)]
		public string TeamName
		{
			get
			{
				return this._TeamName;
			}
			set
			{
				this._TeamName = value;
			}
		}

		// Token: 0x170009D3 RID: 2515
		// (get) Token: 0x060026B1 RID: 9905 RVA: 0x000AA920 File Offset: 0x000A8B20
		[ProtoMember(6, Name = "LevelList", DataFormat = DataFormat.TwosComplement)]
		public List<int> LevelList
		{
			get
			{
				return this._LevelList;
			}
		}

		// Token: 0x170009D4 RID: 2516
		// (get) Token: 0x060026B2 RID: 9906 RVA: 0x000AA928 File Offset: 0x000A8B28
		[ProtoMember(7, Name = "StartTimeList", DataFormat = DataFormat.TwosComplement)]
		public List<int> StartTimeList
		{
			get
			{
				return this._StartTimeList;
			}
		}

		// Token: 0x170009D5 RID: 2517
		// (get) Token: 0x060026B3 RID: 9907 RVA: 0x000AA930 File Offset: 0x000A8B30
		// (set) Token: 0x060026B4 RID: 9908 RVA: 0x000AA938 File Offset: 0x000A8B38
		[ProtoMember(8, IsRequired = true, Name = "Background", DataFormat = DataFormat.Default)]
		public string Background
		{
			get
			{
				return this._Background;
			}
			set
			{
				this._Background = value;
			}
		}

		// Token: 0x170009D6 RID: 2518
		// (get) Token: 0x060026B5 RID: 9909 RVA: 0x000AA944 File Offset: 0x000A8B44
		// (set) Token: 0x060026B6 RID: 9910 RVA: 0x000AA94C File Offset: 0x000A8B4C
		[ProtoMember(9, IsRequired = true, Name = "Model", DataFormat = DataFormat.Default)]
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

		// Token: 0x170009D7 RID: 2519
		// (get) Token: 0x060026B7 RID: 9911 RVA: 0x000AA958 File Offset: 0x000A8B58
		// (set) Token: 0x060026B8 RID: 9912 RVA: 0x000AA960 File Offset: 0x000A8B60
		[ProtoMember(10, IsRequired = true, Name = "UI_ModelScale", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x170009D8 RID: 2520
		// (get) Token: 0x060026B9 RID: 9913 RVA: 0x000AA96C File Offset: 0x000A8B6C
		// (set) Token: 0x060026BA RID: 9914 RVA: 0x000AA974 File Offset: 0x000A8B74
		[ProtoMember(11, IsRequired = true, Name = "UI_ModelOffsetX", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x170009D9 RID: 2521
		// (get) Token: 0x060026BB RID: 9915 RVA: 0x000AA980 File Offset: 0x000A8B80
		// (set) Token: 0x060026BC RID: 9916 RVA: 0x000AA988 File Offset: 0x000A8B88
		[ProtoMember(12, IsRequired = true, Name = "UI_ModelOffsetY", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x060026BD RID: 9917 RVA: 0x000AA994 File Offset: 0x000A8B94
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060026BE RID: 9918 RVA: 0x000AA9A4 File Offset: 0x000A8BA4
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

		// Token: 0x060026BF RID: 9919 RVA: 0x000AAA70 File Offset: 0x000A8C70
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataMemoryCorridorInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040017A5 RID: 6053
		private int _ID;

		// Token: 0x040017A6 RID: 6054
		private string _Name;

		// Token: 0x040017A7 RID: 6055
		private string _Desc;

		// Token: 0x040017A8 RID: 6056
		private string _TeamName;

		// Token: 0x040017A9 RID: 6057
		private readonly List<int> _LevelList = new List<int>();

		// Token: 0x040017AA RID: 6058
		private readonly List<int> _StartTimeList = new List<int>();

		// Token: 0x040017AB RID: 6059
		private string _Background;

		// Token: 0x040017AC RID: 6060
		private string _Model;

		// Token: 0x040017AD RID: 6061
		private int _UI_ModelScale;

		// Token: 0x040017AE RID: 6062
		private int _UI_ModelOffsetX;

		// Token: 0x040017AF RID: 6063
		private int _UI_ModelOffsetY;

		// Token: 0x040017B0 RID: 6064
		private IExtension extensionObject;

		// Token: 0x040017B1 RID: 6065
		public List<ConfigDataMemoryCorridorLevelInfo> m_levelInfos;

		// Token: 0x040017B2 RID: 6066
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040017B3 RID: 6067
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040017B4 RID: 6068
		private LuaFunction m_ctor_hotfix;
	}
}
