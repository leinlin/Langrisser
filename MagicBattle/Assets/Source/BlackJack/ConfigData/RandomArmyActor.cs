using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000309 RID: 777
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "RandomArmyActor")]
	[Serializable]
	public class RandomArmyActor : IExtensible
	{
		// Token: 0x06002E7D RID: 11901 RVA: 0x000B9CB8 File Offset: 0x000B7EB8
		public RandomArmyActor()
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

		// Token: 0x17000D13 RID: 3347
		// (get) Token: 0x06002E7E RID: 11902 RVA: 0x000B9D20 File Offset: 0x000B7F20
		// (set) Token: 0x06002E7F RID: 11903 RVA: 0x000B9D28 File Offset: 0x000B7F28
		[ProtoMember(1, IsRequired = true, Name = "HeroID", DataFormat = DataFormat.TwosComplement)]
		public int HeroID
		{
			get
			{
				return this._HeroID;
			}
			set
			{
				this._HeroID = value;
			}
		}

		// Token: 0x17000D14 RID: 3348
		// (get) Token: 0x06002E80 RID: 11904 RVA: 0x000B9D34 File Offset: 0x000B7F34
		// (set) Token: 0x06002E81 RID: 11905 RVA: 0x000B9D3C File Offset: 0x000B7F3C
		[ProtoMember(2, IsRequired = true, Name = "Level", DataFormat = DataFormat.TwosComplement)]
		public int Level
		{
			get
			{
				return this._Level;
			}
			set
			{
				this._Level = value;
			}
		}

		// Token: 0x17000D15 RID: 3349
		// (get) Token: 0x06002E82 RID: 11906 RVA: 0x000B9D48 File Offset: 0x000B7F48
		// (set) Token: 0x06002E83 RID: 11907 RVA: 0x000B9D50 File Offset: 0x000B7F50
		[ProtoMember(3, IsRequired = true, Name = "AI", DataFormat = DataFormat.TwosComplement)]
		public int AI
		{
			get
			{
				return this._AI;
			}
			set
			{
				this._AI = value;
			}
		}

		// Token: 0x17000D16 RID: 3350
		// (get) Token: 0x06002E84 RID: 11908 RVA: 0x000B9D5C File Offset: 0x000B7F5C
		// (set) Token: 0x06002E85 RID: 11909 RVA: 0x000B9D64 File Offset: 0x000B7F64
		[ProtoMember(4, IsRequired = true, Name = "Weight", DataFormat = DataFormat.TwosComplement)]
		public int Weight
		{
			get
			{
				return this._Weight;
			}
			set
			{
				this._Weight = value;
			}
		}

		// Token: 0x06002E86 RID: 11910 RVA: 0x000B9D70 File Offset: 0x000B7F70
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002E87 RID: 11911 RVA: 0x000B9D80 File Offset: 0x000B7F80
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

		// Token: 0x06002E88 RID: 11912 RVA: 0x000B9E4C File Offset: 0x000B804C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(RandomArmyActor));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040023A9 RID: 9129
		private int _HeroID;

		// Token: 0x040023AA RID: 9130
		private int _Level;

		// Token: 0x040023AB RID: 9131
		private int _AI;

		// Token: 0x040023AC RID: 9132
		private int _Weight;

		// Token: 0x040023AD RID: 9133
		private IExtension extensionObject;

		// Token: 0x040023AE RID: 9134
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040023AF RID: 9135
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040023B0 RID: 9136
		private LuaFunction m_ctor_hotfix;
	}
}
