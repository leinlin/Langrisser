using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020006AE RID: 1710
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ProGuildMassiveCombatStrongholdInfo")]
	[Serializable]
	public class ProGuildMassiveCombatStrongholdInfo : IExtensible
	{
		// Token: 0x06005CAA RID: 23722 RVA: 0x001A65BC File Offset: 0x001A47BC
		public ProGuildMassiveCombatStrongholdInfo()
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

		// Token: 0x17001783 RID: 6019
		// (get) Token: 0x06005CAB RID: 23723 RVA: 0x001A6630 File Offset: 0x001A4830
		// (set) Token: 0x06005CAC RID: 23724 RVA: 0x001A6638 File Offset: 0x001A4838
		[ProtoMember(1, IsRequired = true, Name = "ConfigId", DataFormat = DataFormat.TwosComplement)]
		public int ConfigId
		{
			get
			{
				return this._ConfigId;
			}
			set
			{
				this._ConfigId = value;
			}
		}

		// Token: 0x17001784 RID: 6020
		// (get) Token: 0x06005CAD RID: 23725 RVA: 0x001A6644 File Offset: 0x001A4844
		// (set) Token: 0x06005CAE RID: 23726 RVA: 0x001A664C File Offset: 0x001A484C
		[ProtoMember(2, IsRequired = true, Name = "LevelId", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17001785 RID: 6021
		// (get) Token: 0x06005CAF RID: 23727 RVA: 0x001A6658 File Offset: 0x001A4858
		// (set) Token: 0x06005CB0 RID: 23728 RVA: 0x001A6660 File Offset: 0x001A4860
		[ProtoMember(3, IsRequired = true, Name = "EnemyEliminated", DataFormat = DataFormat.TwosComplement)]
		public int EnemyEliminated
		{
			get
			{
				return this._EnemyEliminated;
			}
			set
			{
				this._EnemyEliminated = value;
			}
		}

		// Token: 0x17001786 RID: 6022
		// (get) Token: 0x06005CB1 RID: 23729 RVA: 0x001A666C File Offset: 0x001A486C
		// (set) Token: 0x06005CB2 RID: 23730 RVA: 0x001A6674 File Offset: 0x001A4874
		[ProtoMember(4, IsRequired = true, Name = "TakenOverTime", DataFormat = DataFormat.TwosComplement)]
		public long TakenOverTime
		{
			get
			{
				return this._TakenOverTime;
			}
			set
			{
				this._TakenOverTime = value;
			}
		}

		// Token: 0x17001787 RID: 6023
		// (get) Token: 0x06005CB3 RID: 23731 RVA: 0x001A6680 File Offset: 0x001A4880
		[ProtoMember(5, Name = "PreferredHeroTagIds", DataFormat = DataFormat.TwosComplement)]
		public List<int> PreferredHeroTagIds
		{
			get
			{
				return this._PreferredHeroTagIds;
			}
		}

		// Token: 0x17001788 RID: 6024
		// (get) Token: 0x06005CB4 RID: 23732 RVA: 0x001A6688 File Offset: 0x001A4888
		// (set) Token: 0x06005CB5 RID: 23733 RVA: 0x001A6690 File Offset: 0x001A4890
		[ProtoMember(6, IsRequired = true, Name = "RandomSeed", DataFormat = DataFormat.TwosComplement)]
		public int RandomSeed
		{
			get
			{
				return this._RandomSeed;
			}
			set
			{
				this._RandomSeed = value;
			}
		}

		// Token: 0x06005CB6 RID: 23734 RVA: 0x001A669C File Offset: 0x001A489C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005CB7 RID: 23735 RVA: 0x001A66AC File Offset: 0x001A48AC
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

		// Token: 0x06005CB8 RID: 23736 RVA: 0x001A6778 File Offset: 0x001A4978
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProGuildMassiveCombatStrongholdInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004551 RID: 17745
		private int _ConfigId;

		// Token: 0x04004552 RID: 17746
		private int _LevelId;

		// Token: 0x04004553 RID: 17747
		private int _EnemyEliminated;

		// Token: 0x04004554 RID: 17748
		private long _TakenOverTime;

		// Token: 0x04004555 RID: 17749
		private readonly List<int> _PreferredHeroTagIds = new List<int>();

		// Token: 0x04004556 RID: 17750
		private int _RandomSeed;

		// Token: 0x04004557 RID: 17751
		private IExtension extensionObject;

		// Token: 0x04004558 RID: 17752
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004559 RID: 17753
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400455A RID: 17754
		private LuaFunction m_ctor_hotfix;
	}
}
