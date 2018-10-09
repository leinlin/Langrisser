using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020006A3 RID: 1699
	[ProtoContract(Name = "ProGuildSearchInfo")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ProGuildSearchInfo : IExtensible
	{
		// Token: 0x06005C10 RID: 23568 RVA: 0x001A4ED4 File Offset: 0x001A30D4
		public ProGuildSearchInfo()
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

		// Token: 0x17001749 RID: 5961
		// (get) Token: 0x06005C11 RID: 23569 RVA: 0x001A4F3C File Offset: 0x001A313C
		// (set) Token: 0x06005C12 RID: 23570 RVA: 0x001A4F44 File Offset: 0x001A3144
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

		// Token: 0x1700174A RID: 5962
		// (get) Token: 0x06005C13 RID: 23571 RVA: 0x001A4F50 File Offset: 0x001A3150
		// (set) Token: 0x06005C14 RID: 23572 RVA: 0x001A4F58 File Offset: 0x001A3158
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

		// Token: 0x1700174B RID: 5963
		// (get) Token: 0x06005C15 RID: 23573 RVA: 0x001A4F64 File Offset: 0x001A3164
		// (set) Token: 0x06005C16 RID: 23574 RVA: 0x001A4F6C File Offset: 0x001A316C
		[ProtoMember(3, IsRequired = true, Name = "Level", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x1700174C RID: 5964
		// (get) Token: 0x06005C17 RID: 23575 RVA: 0x001A4F78 File Offset: 0x001A3178
		// (set) Token: 0x06005C18 RID: 23576 RVA: 0x001A4F80 File Offset: 0x001A3180
		[ProtoMember(4, IsRequired = true, Name = "JoinLevel", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x1700174D RID: 5965
		// (get) Token: 0x06005C19 RID: 23577 RVA: 0x001A4F8C File Offset: 0x001A318C
		// (set) Token: 0x06005C1A RID: 23578 RVA: 0x001A4F94 File Offset: 0x001A3194
		[ProtoMember(5, IsRequired = true, Name = "LastWeekActivities", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x1700174E RID: 5966
		// (get) Token: 0x06005C1B RID: 23579 RVA: 0x001A4FA0 File Offset: 0x001A31A0
		// (set) Token: 0x06005C1C RID: 23580 RVA: 0x001A4FA8 File Offset: 0x001A31A8
		[ProtoMember(6, IsRequired = true, Name = "HiringDeclaration", DataFormat = DataFormat.Default)]
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

		// Token: 0x1700174F RID: 5967
		// (get) Token: 0x06005C1D RID: 23581 RVA: 0x001A4FB4 File Offset: 0x001A31B4
		// (set) Token: 0x06005C1E RID: 23582 RVA: 0x001A4FBC File Offset: 0x001A31BC
		[ProtoMember(7, IsRequired = true, Name = "PresidentMemberInfo", DataFormat = DataFormat.Default)]
		public ProGuildMember PresidentMemberInfo
		{
			get
			{
				return this._PresidentMemberInfo;
			}
			set
			{
				this._PresidentMemberInfo = value;
			}
		}

		// Token: 0x17001750 RID: 5968
		// (get) Token: 0x06005C1F RID: 23583 RVA: 0x001A4FC8 File Offset: 0x001A31C8
		// (set) Token: 0x06005C20 RID: 23584 RVA: 0x001A4FD0 File Offset: 0x001A31D0
		[ProtoMember(8, IsRequired = true, Name = "HaveSendJoinReq", DataFormat = DataFormat.Default)]
		public bool HaveSendJoinReq
		{
			get
			{
				return this._HaveSendJoinReq;
			}
			set
			{
				this._HaveSendJoinReq = value;
			}
		}

		// Token: 0x17001751 RID: 5969
		// (get) Token: 0x06005C21 RID: 23585 RVA: 0x001A4FDC File Offset: 0x001A31DC
		// (set) Token: 0x06005C22 RID: 23586 RVA: 0x001A4FE4 File Offset: 0x001A31E4
		[ProtoMember(9, IsRequired = true, Name = "MemberCount", DataFormat = DataFormat.TwosComplement)]
		public int MemberCount
		{
			get
			{
				return this._MemberCount;
			}
			set
			{
				this._MemberCount = value;
			}
		}

		// Token: 0x06005C23 RID: 23587 RVA: 0x001A4FF0 File Offset: 0x001A31F0
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005C24 RID: 23588 RVA: 0x001A5000 File Offset: 0x001A3200
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

		// Token: 0x06005C25 RID: 23589 RVA: 0x001A50CC File Offset: 0x001A32CC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProGuildSearchInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040044EB RID: 17643
		private string _Id;

		// Token: 0x040044EC RID: 17644
		private string _Name;

		// Token: 0x040044ED RID: 17645
		private int _Level;

		// Token: 0x040044EE RID: 17646
		private int _JoinLevel;

		// Token: 0x040044EF RID: 17647
		private int _LastWeekActivities;

		// Token: 0x040044F0 RID: 17648
		private string _HiringDeclaration;

		// Token: 0x040044F1 RID: 17649
		private ProGuildMember _PresidentMemberInfo;

		// Token: 0x040044F2 RID: 17650
		private bool _HaveSendJoinReq;

		// Token: 0x040044F3 RID: 17651
		private int _MemberCount;

		// Token: 0x040044F4 RID: 17652
		private IExtension extensionObject;

		// Token: 0x040044F5 RID: 17653
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040044F6 RID: 17654
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040044F7 RID: 17655
		private LuaFunction m_ctor_hotfix;
	}
}
