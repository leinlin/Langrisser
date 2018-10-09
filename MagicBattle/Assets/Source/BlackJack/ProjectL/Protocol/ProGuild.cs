using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020006A5 RID: 1701
	[ProtoContract(Name = "ProGuild")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ProGuild : IExtensible
	{
		// Token: 0x06005C3E RID: 23614 RVA: 0x001A53A8 File Offset: 0x001A35A8
		public ProGuild()
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

		// Token: 0x1700175C RID: 5980
		// (get) Token: 0x06005C3F RID: 23615 RVA: 0x001A541C File Offset: 0x001A361C
		// (set) Token: 0x06005C40 RID: 23616 RVA: 0x001A5424 File Offset: 0x001A3624
		[ProtoMember(1, IsRequired = true, Name = "Id", DataFormat = DataFormat.Default)]
		public string Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				this._Id = value;
			}
		}

		// Token: 0x1700175D RID: 5981
		// (get) Token: 0x06005C41 RID: 23617 RVA: 0x001A5430 File Offset: 0x001A3630
		// (set) Token: 0x06005C42 RID: 23618 RVA: 0x001A5438 File Offset: 0x001A3638
		[ProtoMember(2, IsRequired = true, Name = "Name", DataFormat = DataFormat.Default)]
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

		// Token: 0x1700175E RID: 5982
		// (get) Token: 0x06005C43 RID: 23619 RVA: 0x001A5444 File Offset: 0x001A3644
		// (set) Token: 0x06005C44 RID: 23620 RVA: 0x001A544C File Offset: 0x001A364C
		[ProtoMember(3, IsRequired = true, Name = "Bulletin", DataFormat = DataFormat.Default)]
		public string Bulletin
		{
			get
			{
				return this._Bulletin;
			}
			set
			{
				this._Bulletin = value;
			}
		}

		// Token: 0x1700175F RID: 5983
		// (get) Token: 0x06005C45 RID: 23621 RVA: 0x001A5458 File Offset: 0x001A3658
		// (set) Token: 0x06005C46 RID: 23622 RVA: 0x001A5460 File Offset: 0x001A3660
		[ProtoMember(4, IsRequired = true, Name = "HiringDeclaration", DataFormat = DataFormat.Default)]
		public string HiringDeclaration
		{
			get
			{
				return this._HiringDeclaration;
			}
			set
			{
				this._HiringDeclaration = value;
			}
		}

		// Token: 0x17001760 RID: 5984
		// (get) Token: 0x06005C47 RID: 23623 RVA: 0x001A546C File Offset: 0x001A366C
		// (set) Token: 0x06005C48 RID: 23624 RVA: 0x001A5474 File Offset: 0x001A3674
		[ProtoMember(5, IsRequired = true, Name = "AutoJoin", DataFormat = DataFormat.Default)]
		public bool AutoJoin
		{
			get
			{
				return this._AutoJoin;
			}
			set
			{
				this._AutoJoin = value;
			}
		}

		// Token: 0x17001761 RID: 5985
		// (get) Token: 0x06005C49 RID: 23625 RVA: 0x001A5480 File Offset: 0x001A3680
		// (set) Token: 0x06005C4A RID: 23626 RVA: 0x001A5488 File Offset: 0x001A3688
		[ProtoMember(6, IsRequired = true, Name = "TotalActivities", DataFormat = DataFormat.TwosComplement)]
		public int TotalActivities
		{
			get
			{
				return this._TotalActivities;
			}
			set
			{
				this._TotalActivities = value;
			}
		}

		// Token: 0x17001762 RID: 5986
		// (get) Token: 0x06005C4B RID: 23627 RVA: 0x001A5494 File Offset: 0x001A3694
		// (set) Token: 0x06005C4C RID: 23628 RVA: 0x001A549C File Offset: 0x001A369C
		[ProtoMember(7, IsRequired = true, Name = "LastWeekActivities", DataFormat = DataFormat.TwosComplement)]
		public int LastWeekActivities
		{
			get
			{
				return this._LastWeekActivities;
			}
			set
			{
				this._LastWeekActivities = value;
			}
		}

		// Token: 0x17001763 RID: 5987
		// (get) Token: 0x06005C4D RID: 23629 RVA: 0x001A54A8 File Offset: 0x001A36A8
		// (set) Token: 0x06005C4E RID: 23630 RVA: 0x001A54B0 File Offset: 0x001A36B0
		[ProtoMember(8, IsRequired = true, Name = "Activities", DataFormat = DataFormat.TwosComplement)]
		public int Activities
		{
			get
			{
				return this._Activities;
			}
			set
			{
				this._Activities = value;
			}
		}

		// Token: 0x17001764 RID: 5988
		// (get) Token: 0x06005C4F RID: 23631 RVA: 0x001A54BC File Offset: 0x001A36BC
		[ProtoMember(9, Name = "Members", DataFormat = DataFormat.Default)]
		public List<ProGuildMember> Members
		{
			get
			{
				return this._Members;
			}
		}

		// Token: 0x17001765 RID: 5989
		// (get) Token: 0x06005C50 RID: 23632 RVA: 0x001A54C4 File Offset: 0x001A36C4
		// (set) Token: 0x06005C51 RID: 23633 RVA: 0x001A54CC File Offset: 0x001A36CC
		[ProtoMember(10, IsRequired = true, Name = "JoinLevel", DataFormat = DataFormat.TwosComplement)]
		public int JoinLevel
		{
			get
			{
				return this._JoinLevel;
			}
			set
			{
				this._JoinLevel = value;
			}
		}

		// Token: 0x17001766 RID: 5990
		// (get) Token: 0x06005C52 RID: 23634 RVA: 0x001A54D8 File Offset: 0x001A36D8
		// (set) Token: 0x06005C53 RID: 23635 RVA: 0x001A54E0 File Offset: 0x001A36E0
		[ProtoMember(11, IsRequired = true, Name = "TotalBattlePower", DataFormat = DataFormat.TwosComplement)]
		public int TotalBattlePower
		{
			get
			{
				return this._TotalBattlePower;
			}
			set
			{
				this._TotalBattlePower = value;
			}
		}

		// Token: 0x17001767 RID: 5991
		// (get) Token: 0x06005C54 RID: 23636 RVA: 0x001A54EC File Offset: 0x001A36EC
		// (set) Token: 0x06005C55 RID: 23637 RVA: 0x001A54F4 File Offset: 0x001A36F4
		[ProtoMember(12, IsRequired = true, Name = "CurrentWeekActivities", DataFormat = DataFormat.TwosComplement)]
		public int CurrentWeekActivities
		{
			get
			{
				return this._CurrentWeekActivities;
			}
			set
			{
				this._CurrentWeekActivities = value;
			}
		}

		// Token: 0x17001768 RID: 5992
		// (get) Token: 0x06005C56 RID: 23638 RVA: 0x001A5500 File Offset: 0x001A3700
		// (set) Token: 0x06005C57 RID: 23639 RVA: 0x001A5508 File Offset: 0x001A3708
		[ProtoMember(13, IsRequired = true, Name = "MassiveCombatInfo", DataFormat = DataFormat.Default)]
		public ProGuildMassiveCombatGeneralInfo MassiveCombatInfo
		{
			get
			{
				return this._MassiveCombatInfo;
			}
			set
			{
				this._MassiveCombatInfo = value;
			}
		}

		// Token: 0x06005C58 RID: 23640 RVA: 0x001A5514 File Offset: 0x001A3714
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005C59 RID: 23641 RVA: 0x001A5524 File Offset: 0x001A3724
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

		// Token: 0x06005C5A RID: 23642 RVA: 0x001A55F0 File Offset: 0x001A37F0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProGuild));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004506 RID: 17670
		private string _Id;

		// Token: 0x04004507 RID: 17671
		private string _Name;

		// Token: 0x04004508 RID: 17672
		private string _Bulletin;

		// Token: 0x04004509 RID: 17673
		private string _HiringDeclaration;

		// Token: 0x0400450A RID: 17674
		private bool _AutoJoin;

		// Token: 0x0400450B RID: 17675
		private int _TotalActivities;

		// Token: 0x0400450C RID: 17676
		private int _LastWeekActivities;

		// Token: 0x0400450D RID: 17677
		private int _Activities;

		// Token: 0x0400450E RID: 17678
		private readonly List<ProGuildMember> _Members = new List<ProGuildMember>();

		// Token: 0x0400450F RID: 17679
		private int _JoinLevel;

		// Token: 0x04004510 RID: 17680
		private int _TotalBattlePower;

		// Token: 0x04004511 RID: 17681
		private int _CurrentWeekActivities;

		// Token: 0x04004512 RID: 17682
		private ProGuildMassiveCombatGeneralInfo _MassiveCombatInfo;

		// Token: 0x04004513 RID: 17683
		private IExtension extensionObject;

		// Token: 0x04004514 RID: 17684
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004515 RID: 17685
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004516 RID: 17686
		private LuaFunction m_ctor_hotfix;
	}
}
