using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000243 RID: 579
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ConfigDataHeroAssistantTaskScheduleInfo")]
	[Serializable]
	public class ConfigDataHeroAssistantTaskScheduleInfo : IExtensible
	{
		// Token: 0x060023B7 RID: 9143 RVA: 0x000A5E94 File Offset: 0x000A4094
		public ConfigDataHeroAssistantTaskScheduleInfo()
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

		// Token: 0x1700086C RID: 2156
		// (get) Token: 0x060023B8 RID: 9144 RVA: 0x000A5F28 File Offset: 0x000A4128
		// (set) Token: 0x060023B9 RID: 9145 RVA: 0x000A5F30 File Offset: 0x000A4130
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

		// Token: 0x1700086D RID: 2157
		// (get) Token: 0x060023BA RID: 9146 RVA: 0x000A5F3C File Offset: 0x000A413C
		// (set) Token: 0x060023BB RID: 9147 RVA: 0x000A5F44 File Offset: 0x000A4144
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

		// Token: 0x1700086E RID: 2158
		// (get) Token: 0x060023BC RID: 9148 RVA: 0x000A5F50 File Offset: 0x000A4150
		[ProtoMember(4, Name = "Resource", DataFormat = DataFormat.Default)]
		public List<string> Resource
		{
			get
			{
				return this._Resource;
			}
		}

		// Token: 0x1700086F RID: 2159
		// (get) Token: 0x060023BD RID: 9149 RVA: 0x000A5F58 File Offset: 0x000A4158
		[ProtoMember(5, Name = "TaskIDs", DataFormat = DataFormat.TwosComplement)]
		public List<int> TaskIDs
		{
			get
			{
				return this._TaskIDs;
			}
		}

		// Token: 0x17000870 RID: 2160
		// (get) Token: 0x060023BE RID: 9150 RVA: 0x000A5F60 File Offset: 0x000A4160
		// (set) Token: 0x060023BF RID: 9151 RVA: 0x000A5F68 File Offset: 0x000A4168
		[ProtoMember(6, IsRequired = true, Name = "Weekday", DataFormat = DataFormat.TwosComplement)]
		public int Weekday
		{
			get
			{
				return this._Weekday;
			}
			set
			{
				this._Weekday = value;
			}
		}

		// Token: 0x17000871 RID: 2161
		// (get) Token: 0x060023C0 RID: 9152 RVA: 0x000A5F74 File Offset: 0x000A4174
		[ProtoMember(7, Name = "RecommendHeroes", DataFormat = DataFormat.TwosComplement)]
		public List<int> RecommendHeroes
		{
			get
			{
				return this._RecommendHeroes;
			}
		}

		// Token: 0x17000872 RID: 2162
		// (get) Token: 0x060023C1 RID: 9153 RVA: 0x000A5F7C File Offset: 0x000A417C
		[ProtoMember(8, Name = "SoldierTypeList", DataFormat = DataFormat.TwosComplement)]
		public List<int> SoldierTypeList
		{
			get
			{
				return this._SoldierTypeList;
			}
		}

		// Token: 0x060023C2 RID: 9154 RVA: 0x000A5F84 File Offset: 0x000A4184
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060023C3 RID: 9155 RVA: 0x000A5F94 File Offset: 0x000A4194
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

		// Token: 0x060023C4 RID: 9156 RVA: 0x000A6060 File Offset: 0x000A4260
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataHeroAssistantTaskScheduleInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040015AE RID: 5550
		private int _ID;

		// Token: 0x040015AF RID: 5551
		private string _Name;

		// Token: 0x040015B0 RID: 5552
		private readonly List<string> _Resource = new List<string>();

		// Token: 0x040015B1 RID: 5553
		private readonly List<int> _TaskIDs = new List<int>();

		// Token: 0x040015B2 RID: 5554
		private int _Weekday;

		// Token: 0x040015B3 RID: 5555
		private readonly List<int> _RecommendHeroes = new List<int>();

		// Token: 0x040015B4 RID: 5556
		private readonly List<int> _SoldierTypeList = new List<int>();

		// Token: 0x040015B5 RID: 5557
		private IExtension extensionObject;

		// Token: 0x040015B6 RID: 5558
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040015B7 RID: 5559
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040015B8 RID: 5560
		private LuaFunction m_ctor_hotfix;
	}
}
