using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000242 RID: 578
	[HotFix(true, m_isCtorOnly = true)]
	[CustomLuaClass]
	[ProtoContract(Name = "ConfigDataHeroAssistantTaskInfo")]
	[Serializable]
	public class ConfigDataHeroAssistantTaskInfo : IExtensible
	{
		// Token: 0x060023A9 RID: 9129 RVA: 0x000A5C48 File Offset: 0x000A3E48
		public ConfigDataHeroAssistantTaskInfo()
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

		// Token: 0x17000866 RID: 2150
		// (get) Token: 0x060023AA RID: 9130 RVA: 0x000A5CF0 File Offset: 0x000A3EF0
		// (set) Token: 0x060023AB RID: 9131 RVA: 0x000A5CF8 File Offset: 0x000A3EF8
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

		// Token: 0x17000867 RID: 2151
		// (get) Token: 0x060023AC RID: 9132 RVA: 0x000A5D04 File Offset: 0x000A3F04
		// (set) Token: 0x060023AD RID: 9133 RVA: 0x000A5D0C File Offset: 0x000A3F0C
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

		// Token: 0x17000868 RID: 2152
		// (get) Token: 0x060023AE RID: 9134 RVA: 0x000A5D18 File Offset: 0x000A3F18
		[ProtoMember(4, Name = "Resource", DataFormat = DataFormat.Default)]
		public List<string> Resource
		{
			get
			{
				return this._Resource;
			}
		}

		// Token: 0x17000869 RID: 2153
		// (get) Token: 0x060023AF RID: 9135 RVA: 0x000A5D20 File Offset: 0x000A3F20
		// (set) Token: 0x060023B0 RID: 9136 RVA: 0x000A5D28 File Offset: 0x000A3F28
		[ProtoMember(5, IsRequired = true, Name = "RequiredUserLevel", DataFormat = DataFormat.TwosComplement)]
		public int RequiredUserLevel
		{
			get
			{
				return this._RequiredUserLevel;
			}
			set
			{
				this._RequiredUserLevel = value;
			}
		}

		// Token: 0x1700086A RID: 2154
		// (get) Token: 0x060023B1 RID: 9137 RVA: 0x000A5D34 File Offset: 0x000A3F34
		// (set) Token: 0x060023B2 RID: 9138 RVA: 0x000A5D3C File Offset: 0x000A3F3C
		[ProtoMember(6, IsRequired = true, Name = "CompletePoints", DataFormat = DataFormat.TwosComplement)]
		public int CompletePoints
		{
			get
			{
				return this._CompletePoints;
			}
			set
			{
				this._CompletePoints = value;
			}
		}

		// Token: 0x1700086B RID: 2155
		// (get) Token: 0x060023B3 RID: 9139 RVA: 0x000A5D48 File Offset: 0x000A3F48
		[ProtoMember(7, Name = "Rewards", DataFormat = DataFormat.Default)]
		public List<CompleteValueDropID> Rewards
		{
			get
			{
				return this._Rewards;
			}
		}

		// Token: 0x060023B4 RID: 9140 RVA: 0x000A5D50 File Offset: 0x000A3F50
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060023B5 RID: 9141 RVA: 0x000A5D60 File Offset: 0x000A3F60
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

		// Token: 0x060023B6 RID: 9142 RVA: 0x000A5E2C File Offset: 0x000A402C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataHeroAssistantTaskInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400159E RID: 5534
		private int _ID;

		// Token: 0x0400159F RID: 5535
		private string _Name;

		// Token: 0x040015A0 RID: 5536
		private readonly List<string> _Resource = new List<string>();

		// Token: 0x040015A1 RID: 5537
		private int _RequiredUserLevel;

		// Token: 0x040015A2 RID: 5538
		private int _CompletePoints;

		// Token: 0x040015A3 RID: 5539
		private readonly List<CompleteValueDropID> _Rewards = new List<CompleteValueDropID>();

		// Token: 0x040015A4 RID: 5540
		private IExtension extensionObject;

		// Token: 0x040015A5 RID: 5541
		public ConfigDataHeroAssistantTaskScheduleInfo m_schedule;

		// Token: 0x040015A6 RID: 5542
		public ConfigDataHeroAssistantTaskGeneralInfo m_general;

		// Token: 0x040015A7 RID: 5543
		public List<int> m_rewardCompleteRate = new List<int>();

		// Token: 0x040015A8 RID: 5544
		public List<int> m_rewardDropId = new List<int>();

		// Token: 0x040015A9 RID: 5545
		public List<int> m_rewardWorkSeconds = new List<int>();

		// Token: 0x040015AA RID: 5546
		public List<int> m_rewardDropCount = new List<int>();

		// Token: 0x040015AB RID: 5547
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040015AC RID: 5548
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040015AD RID: 5549
		private LuaFunction m_ctor_hotfix;
	}
}
