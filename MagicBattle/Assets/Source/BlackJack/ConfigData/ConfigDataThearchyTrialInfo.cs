using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x0200029E RID: 670
	[HotFix(true, m_isCtorOnly = true)]
	[CustomLuaClass]
	[ProtoContract(Name = "ConfigDataThearchyTrialInfo")]
	[Serializable]
	public class ConfigDataThearchyTrialInfo : IExtensible
	{
		// Token: 0x06002BE5 RID: 11237 RVA: 0x000B41BC File Offset: 0x000B23BC
		public ConfigDataThearchyTrialInfo()
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

		// Token: 0x17000C0B RID: 3083
		// (get) Token: 0x06002BE6 RID: 11238 RVA: 0x000B4244 File Offset: 0x000B2444
		// (set) Token: 0x06002BE7 RID: 11239 RVA: 0x000B424C File Offset: 0x000B244C
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

		// Token: 0x17000C0C RID: 3084
		// (get) Token: 0x06002BE8 RID: 11240 RVA: 0x000B4258 File Offset: 0x000B2458
		// (set) Token: 0x06002BE9 RID: 11241 RVA: 0x000B4260 File Offset: 0x000B2460
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

		// Token: 0x17000C0D RID: 3085
		// (get) Token: 0x06002BEA RID: 11242 RVA: 0x000B426C File Offset: 0x000B246C
		// (set) Token: 0x06002BEB RID: 11243 RVA: 0x000B4274 File Offset: 0x000B2474
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

		// Token: 0x17000C0E RID: 3086
		// (get) Token: 0x06002BEC RID: 11244 RVA: 0x000B4280 File Offset: 0x000B2480
		// (set) Token: 0x06002BED RID: 11245 RVA: 0x000B4288 File Offset: 0x000B2488
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

		// Token: 0x17000C0F RID: 3087
		// (get) Token: 0x06002BEE RID: 11246 RVA: 0x000B4294 File Offset: 0x000B2494
		[ProtoMember(6, Name = "LevelList", DataFormat = DataFormat.TwosComplement)]
		public List<int> LevelList
		{
			get
			{
				return this._LevelList;
			}
		}

		// Token: 0x17000C10 RID: 3088
		// (get) Token: 0x06002BEF RID: 11247 RVA: 0x000B429C File Offset: 0x000B249C
		[ProtoMember(7, Name = "StartTimeList", DataFormat = DataFormat.TwosComplement)]
		public List<int> StartTimeList
		{
			get
			{
				return this._StartTimeList;
			}
		}

		// Token: 0x17000C11 RID: 3089
		// (get) Token: 0x06002BF0 RID: 11248 RVA: 0x000B42A4 File Offset: 0x000B24A4
		[ProtoMember(8, Name = "Armys_ID", DataFormat = DataFormat.TwosComplement)]
		public List<int> Armys_ID
		{
			get
			{
				return this._Armys_ID;
			}
		}

		// Token: 0x17000C12 RID: 3090
		// (get) Token: 0x06002BF1 RID: 11249 RVA: 0x000B42AC File Offset: 0x000B24AC
		// (set) Token: 0x06002BF2 RID: 11250 RVA: 0x000B42B4 File Offset: 0x000B24B4
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

		// Token: 0x17000C13 RID: 3091
		// (get) Token: 0x06002BF3 RID: 11251 RVA: 0x000B42C0 File Offset: 0x000B24C0
		// (set) Token: 0x06002BF4 RID: 11252 RVA: 0x000B42C8 File Offset: 0x000B24C8
		[ProtoMember(10, IsRequired = true, Name = "Fx", DataFormat = DataFormat.Default)]
		public string Fx
		{
			get
			{
				return this._Fx;
			}
			set
			{
				this._Fx = value;
			}
		}

		// Token: 0x17000C14 RID: 3092
		// (get) Token: 0x06002BF5 RID: 11253 RVA: 0x000B42D4 File Offset: 0x000B24D4
		// (set) Token: 0x06002BF6 RID: 11254 RVA: 0x000B42DC File Offset: 0x000B24DC
		[ProtoMember(11, IsRequired = true, Name = "UI_ModelScale", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17000C15 RID: 3093
		// (get) Token: 0x06002BF7 RID: 11255 RVA: 0x000B42E8 File Offset: 0x000B24E8
		// (set) Token: 0x06002BF8 RID: 11256 RVA: 0x000B42F0 File Offset: 0x000B24F0
		[ProtoMember(12, IsRequired = true, Name = "UI_ModelOffsetX", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17000C16 RID: 3094
		// (get) Token: 0x06002BF9 RID: 11257 RVA: 0x000B42FC File Offset: 0x000B24FC
		// (set) Token: 0x06002BFA RID: 11258 RVA: 0x000B4304 File Offset: 0x000B2504
		[ProtoMember(13, IsRequired = true, Name = "UI_ModelOffsetY", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x06002BFB RID: 11259 RVA: 0x000B4310 File Offset: 0x000B2510
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002BFC RID: 11260 RVA: 0x000B4320 File Offset: 0x000B2520
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

		// Token: 0x06002BFD RID: 11261 RVA: 0x000B43EC File Offset: 0x000B25EC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataThearchyTrialInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04001B0B RID: 6923
		private int _ID;

		// Token: 0x04001B0C RID: 6924
		private string _Name;

		// Token: 0x04001B0D RID: 6925
		private string _Desc;

		// Token: 0x04001B0E RID: 6926
		private string _TeamName;

		// Token: 0x04001B0F RID: 6927
		private readonly List<int> _LevelList = new List<int>();

		// Token: 0x04001B10 RID: 6928
		private readonly List<int> _StartTimeList = new List<int>();

		// Token: 0x04001B11 RID: 6929
		private readonly List<int> _Armys_ID = new List<int>();

		// Token: 0x04001B12 RID: 6930
		private string _Model;

		// Token: 0x04001B13 RID: 6931
		private string _Fx;

		// Token: 0x04001B14 RID: 6932
		private int _UI_ModelScale;

		// Token: 0x04001B15 RID: 6933
		private int _UI_ModelOffsetX;

		// Token: 0x04001B16 RID: 6934
		private int _UI_ModelOffsetY;

		// Token: 0x04001B17 RID: 6935
		private IExtension extensionObject;

		// Token: 0x04001B18 RID: 6936
		public List<ConfigDataThearchyTrialLevelInfo> m_levelInfos;

		// Token: 0x04001B19 RID: 6937
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04001B1A RID: 6938
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04001B1B RID: 6939
		private LuaFunction m_ctor_hotfix;
	}
}
