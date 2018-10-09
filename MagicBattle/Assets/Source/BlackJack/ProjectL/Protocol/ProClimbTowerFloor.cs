using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020006A9 RID: 1705
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ProClimbTowerFloor")]
	[Serializable]
	public class ProClimbTowerFloor : IExtensible
	{
		// Token: 0x06005C7D RID: 23677 RVA: 0x001A5C5C File Offset: 0x001A3E5C
		public ProClimbTowerFloor()
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

		// Token: 0x17001776 RID: 6006
		// (get) Token: 0x06005C7E RID: 23678 RVA: 0x001A5CC4 File Offset: 0x001A3EC4
		// (set) Token: 0x06005C7F RID: 23679 RVA: 0x001A5CCC File Offset: 0x001A3ECC
		[ProtoMember(1, IsRequired = true, Name = "LevelId", DataFormat = DataFormat.TwosComplement)]
		public int LevelId
		{
			get
			{
				return this._LevelId;
			}
			set
			{
				this._LevelId = value;
			}
		}

		// Token: 0x17001777 RID: 6007
		// (get) Token: 0x06005C80 RID: 23680 RVA: 0x001A5CD8 File Offset: 0x001A3ED8
		// (set) Token: 0x06005C81 RID: 23681 RVA: 0x001A5CE0 File Offset: 0x001A3EE0
		[ProtoMember(2, IsRequired = true, Name = "RuleId", DataFormat = DataFormat.TwosComplement)]
		public int RuleId
		{
			get
			{
				return this._RuleId;
			}
			set
			{
				this._RuleId = value;
			}
		}

		// Token: 0x17001778 RID: 6008
		// (get) Token: 0x06005C82 RID: 23682 RVA: 0x001A5CEC File Offset: 0x001A3EEC
		// (set) Token: 0x06005C83 RID: 23683 RVA: 0x001A5CF4 File Offset: 0x001A3EF4
		[ProtoMember(3, IsRequired = true, Name = "ArmyRandomSeed", DataFormat = DataFormat.TwosComplement)]
		public int ArmyRandomSeed
		{
			get
			{
				return this._ArmyRandomSeed;
			}
			set
			{
				this._ArmyRandomSeed = value;
			}
		}

		// Token: 0x17001779 RID: 6009
		// (get) Token: 0x06005C84 RID: 23684 RVA: 0x001A5D00 File Offset: 0x001A3F00
		// (set) Token: 0x06005C85 RID: 23685 RVA: 0x001A5D08 File Offset: 0x001A3F08
		[ProtoMember(4, IsRequired = true, Name = "BonusHeroGroupId", DataFormat = DataFormat.TwosComplement)]
		public int BonusHeroGroupId
		{
			get
			{
				return this._BonusHeroGroupId;
			}
			set
			{
				this._BonusHeroGroupId = value;
			}
		}

		// Token: 0x06005C86 RID: 23686 RVA: 0x001A5D14 File Offset: 0x001A3F14
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005C87 RID: 23687 RVA: 0x001A5D24 File Offset: 0x001A3F24
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

		// Token: 0x06005C88 RID: 23688 RVA: 0x001A5DF0 File Offset: 0x001A3FF0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProClimbTowerFloor));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004530 RID: 17712
		private int _LevelId;

		// Token: 0x04004531 RID: 17713
		private int _RuleId;

		// Token: 0x04004532 RID: 17714
		private int _ArmyRandomSeed;

		// Token: 0x04004533 RID: 17715
		private int _BonusHeroGroupId;

		// Token: 0x04004534 RID: 17716
		private IExtension extensionObject;

		// Token: 0x04004535 RID: 17717
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004536 RID: 17718
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004537 RID: 17719
		private LuaFunction m_ctor_hotfix;
	}
}
