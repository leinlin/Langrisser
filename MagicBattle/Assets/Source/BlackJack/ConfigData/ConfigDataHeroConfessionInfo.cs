using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000245 RID: 581
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ConfigDataHeroConfessionInfo")]
	[Serializable]
	public class ConfigDataHeroConfessionInfo : IExtensible
	{
		// Token: 0x060023D0 RID: 9168 RVA: 0x000A62C4 File Offset: 0x000A44C4
		public ConfigDataHeroConfessionInfo()
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

		// Token: 0x17000877 RID: 2167
		// (get) Token: 0x060023D1 RID: 9169 RVA: 0x000A6340 File Offset: 0x000A4540
		// (set) Token: 0x060023D2 RID: 9170 RVA: 0x000A6348 File Offset: 0x000A4548
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

		// Token: 0x17000878 RID: 2168
		// (get) Token: 0x060023D3 RID: 9171 RVA: 0x000A6354 File Offset: 0x000A4554
		// (set) Token: 0x060023D4 RID: 9172 RVA: 0x000A635C File Offset: 0x000A455C
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

		// Token: 0x17000879 RID: 2169
		// (get) Token: 0x060023D5 RID: 9173 RVA: 0x000A6368 File Offset: 0x000A4568
		// (set) Token: 0x060023D6 RID: 9174 RVA: 0x000A6370 File Offset: 0x000A4570
		[ProtoMember(4, IsRequired = true, Name = "DialogID", DataFormat = DataFormat.TwosComplement)]
		public int DialogID
		{
			get
			{
				return this._DialogID;
			}
			set
			{
				this._DialogID = value;
			}
		}

		// Token: 0x1700087A RID: 2170
		// (get) Token: 0x060023D7 RID: 9175 RVA: 0x000A637C File Offset: 0x000A457C
		[ProtoMember(5, Name = "UnlockConditions", DataFormat = DataFormat.Default)]
		public List<HeroConfessionUnlockCondition> UnlockConditions
		{
			get
			{
				return this._UnlockConditions;
			}
		}

		// Token: 0x1700087B RID: 2171
		// (get) Token: 0x060023D8 RID: 9176 RVA: 0x000A6384 File Offset: 0x000A4584
		[ProtoMember(6, Name = "Reward", DataFormat = DataFormat.Default)]
		public List<Goods> Reward
		{
			get
			{
				return this._Reward;
			}
		}

		// Token: 0x060023D9 RID: 9177 RVA: 0x000A638C File Offset: 0x000A458C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060023DA RID: 9178 RVA: 0x000A639C File Offset: 0x000A459C
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

		// Token: 0x060023DB RID: 9179 RVA: 0x000A6468 File Offset: 0x000A4668
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataHeroConfessionInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040015C1 RID: 5569
		private int _ID;

		// Token: 0x040015C2 RID: 5570
		private string _Name;

		// Token: 0x040015C3 RID: 5571
		private int _DialogID;

		// Token: 0x040015C4 RID: 5572
		private readonly List<HeroConfessionUnlockCondition> _UnlockConditions = new List<HeroConfessionUnlockCondition>();

		// Token: 0x040015C5 RID: 5573
		private readonly List<Goods> _Reward = new List<Goods>();

		// Token: 0x040015C6 RID: 5574
		private IExtension extensionObject;

		// Token: 0x040015C7 RID: 5575
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040015C8 RID: 5576
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040015C9 RID: 5577
		private LuaFunction m_ctor_hotfix;
	}
}
