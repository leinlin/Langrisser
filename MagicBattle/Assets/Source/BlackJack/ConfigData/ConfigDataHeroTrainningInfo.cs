using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000254 RID: 596
	[HotFix(true, m_isCtorOnly = true)]
	[CustomLuaClass]
	[ProtoContract(Name = "ConfigDataHeroTrainningInfo")]
	[Serializable]
	public class ConfigDataHeroTrainningInfo : IExtensible
	{
		// Token: 0x06002538 RID: 9528 RVA: 0x000A89D0 File Offset: 0x000A6BD0
		public ConfigDataHeroTrainningInfo()
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

		// Token: 0x17000922 RID: 2338
		// (get) Token: 0x06002539 RID: 9529 RVA: 0x000A8A4C File Offset: 0x000A6C4C
		// (set) Token: 0x0600253A RID: 9530 RVA: 0x000A8A54 File Offset: 0x000A6C54
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

		// Token: 0x17000923 RID: 2339
		// (get) Token: 0x0600253B RID: 9531 RVA: 0x000A8A60 File Offset: 0x000A6C60
		// (set) Token: 0x0600253C RID: 9532 RVA: 0x000A8A68 File Offset: 0x000A6C68
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

		// Token: 0x17000924 RID: 2340
		// (get) Token: 0x0600253D RID: 9533 RVA: 0x000A8A74 File Offset: 0x000A6C74
		// (set) Token: 0x0600253E RID: 9534 RVA: 0x000A8A7C File Offset: 0x000A6C7C
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

		// Token: 0x17000925 RID: 2341
		// (get) Token: 0x0600253F RID: 9535 RVA: 0x000A8A88 File Offset: 0x000A6C88
		// (set) Token: 0x06002540 RID: 9536 RVA: 0x000A8A90 File Offset: 0x000A6C90
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

		// Token: 0x17000926 RID: 2342
		// (get) Token: 0x06002541 RID: 9537 RVA: 0x000A8A9C File Offset: 0x000A6C9C
		[ProtoMember(6, Name = "LevelList", DataFormat = DataFormat.TwosComplement)]
		public List<int> LevelList
		{
			get
			{
				return this._LevelList;
			}
		}

		// Token: 0x17000927 RID: 2343
		// (get) Token: 0x06002542 RID: 9538 RVA: 0x000A8AA4 File Offset: 0x000A6CA4
		[ProtoMember(7, Name = "StartTimeList", DataFormat = DataFormat.TwosComplement)]
		public List<int> StartTimeList
		{
			get
			{
				return this._StartTimeList;
			}
		}

		// Token: 0x17000928 RID: 2344
		// (get) Token: 0x06002543 RID: 9539 RVA: 0x000A8AAC File Offset: 0x000A6CAC
		// (set) Token: 0x06002544 RID: 9540 RVA: 0x000A8AB4 File Offset: 0x000A6CB4
		[ProtoMember(8, IsRequired = true, Name = "Icon", DataFormat = DataFormat.Default)]
		public string Icon
		{
			get
			{
				return this._Icon;
			}
			set
			{
				this._Icon = value;
			}
		}

		// Token: 0x17000929 RID: 2345
		// (get) Token: 0x06002545 RID: 9541 RVA: 0x000A8AC0 File Offset: 0x000A6CC0
		// (set) Token: 0x06002546 RID: 9542 RVA: 0x000A8AC8 File Offset: 0x000A6CC8
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

		// Token: 0x1700092A RID: 2346
		// (get) Token: 0x06002547 RID: 9543 RVA: 0x000A8AD4 File Offset: 0x000A6CD4
		// (set) Token: 0x06002548 RID: 9544 RVA: 0x000A8ADC File Offset: 0x000A6CDC
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

		// Token: 0x1700092B RID: 2347
		// (get) Token: 0x06002549 RID: 9545 RVA: 0x000A8AE8 File Offset: 0x000A6CE8
		// (set) Token: 0x0600254A RID: 9546 RVA: 0x000A8AF0 File Offset: 0x000A6CF0
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

		// Token: 0x1700092C RID: 2348
		// (get) Token: 0x0600254B RID: 9547 RVA: 0x000A8AFC File Offset: 0x000A6CFC
		// (set) Token: 0x0600254C RID: 9548 RVA: 0x000A8B04 File Offset: 0x000A6D04
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

		// Token: 0x0600254D RID: 9549 RVA: 0x000A8B10 File Offset: 0x000A6D10
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600254E RID: 9550 RVA: 0x000A8B20 File Offset: 0x000A6D20
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

		// Token: 0x0600254F RID: 9551 RVA: 0x000A8BEC File Offset: 0x000A6DEC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataHeroTrainningInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040016BF RID: 5823
		private int _ID;

		// Token: 0x040016C0 RID: 5824
		private string _Name;

		// Token: 0x040016C1 RID: 5825
		private string _Desc;

		// Token: 0x040016C2 RID: 5826
		private string _TeamName;

		// Token: 0x040016C3 RID: 5827
		private readonly List<int> _LevelList = new List<int>();

		// Token: 0x040016C4 RID: 5828
		private readonly List<int> _StartTimeList = new List<int>();

		// Token: 0x040016C5 RID: 5829
		private string _Icon;

		// Token: 0x040016C6 RID: 5830
		private string _Model;

		// Token: 0x040016C7 RID: 5831
		private int _UI_ModelScale;

		// Token: 0x040016C8 RID: 5832
		private int _UI_ModelOffsetX;

		// Token: 0x040016C9 RID: 5833
		private int _UI_ModelOffsetY;

		// Token: 0x040016CA RID: 5834
		private IExtension extensionObject;

		// Token: 0x040016CB RID: 5835
		public List<ConfigDataHeroTrainningLevelInfo> m_levelInfos;

		// Token: 0x040016CC RID: 5836
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040016CD RID: 5837
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040016CE RID: 5838
		private LuaFunction m_ctor_hotfix;
	}
}
