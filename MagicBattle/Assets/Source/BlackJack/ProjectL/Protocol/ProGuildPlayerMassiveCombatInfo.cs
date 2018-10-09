using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020006B2 RID: 1714
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ProGuildPlayerMassiveCombatInfo")]
	[Serializable]
	public class ProGuildPlayerMassiveCombatInfo : IExtensible
	{
		// Token: 0x06005CDA RID: 23770 RVA: 0x001A6DD0 File Offset: 0x001A4FD0
		public ProGuildPlayerMassiveCombatInfo()
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

		// Token: 0x17001795 RID: 6037
		// (get) Token: 0x06005CDB RID: 23771 RVA: 0x001A6E4C File Offset: 0x001A504C
		// (set) Token: 0x06005CDC RID: 23772 RVA: 0x001A6E54 File Offset: 0x001A5054
		[ProtoMember(1, IsRequired = true, Name = "BindedGuildId", DataFormat = DataFormat.Default)]
		public string BindedGuildId
		{
			get
			{
				return this._BindedGuildId;
			}
			set
			{
				this._BindedGuildId = value;
			}
		}

		// Token: 0x17001796 RID: 6038
		// (get) Token: 0x06005CDD RID: 23773 RVA: 0x001A6E60 File Offset: 0x001A5060
		[ProtoMember(2, Name = "UsedHeroIds", DataFormat = DataFormat.TwosComplement)]
		public List<int> UsedHeroIds
		{
			get
			{
				return this._UsedHeroIds;
			}
		}

		// Token: 0x17001797 RID: 6039
		// (get) Token: 0x06005CDE RID: 23774 RVA: 0x001A6E68 File Offset: 0x001A5068
		// (set) Token: 0x06005CDF RID: 23775 RVA: 0x001A6E70 File Offset: 0x001A5070
		[ProtoMember(3, IsRequired = true, Name = "Points", DataFormat = DataFormat.TwosComplement)]
		public int Points
		{
			get
			{
				return this._Points;
			}
			set
			{
				this._Points = value;
			}
		}

		// Token: 0x17001798 RID: 6040
		// (get) Token: 0x06005CE0 RID: 23776 RVA: 0x001A6E7C File Offset: 0x001A507C
		[ProtoMember(4, Name = "PointsRewardsClaimed", DataFormat = DataFormat.TwosComplement)]
		public List<int> PointsRewardsClaimed
		{
			get
			{
				return this._PointsRewardsClaimed;
			}
		}

		// Token: 0x06005CE1 RID: 23777 RVA: 0x001A6E84 File Offset: 0x001A5084
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005CE2 RID: 23778 RVA: 0x001A6E94 File Offset: 0x001A5094
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

		// Token: 0x06005CE3 RID: 23779 RVA: 0x001A6F60 File Offset: 0x001A5160
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProGuildPlayerMassiveCombatInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004573 RID: 17779
		private string _BindedGuildId;

		// Token: 0x04004574 RID: 17780
		private readonly List<int> _UsedHeroIds = new List<int>();

		// Token: 0x04004575 RID: 17781
		private int _Points;

		// Token: 0x04004576 RID: 17782
		private readonly List<int> _PointsRewardsClaimed = new List<int>();

		// Token: 0x04004577 RID: 17783
		private IExtension extensionObject;

		// Token: 0x04004578 RID: 17784
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004579 RID: 17785
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400457A RID: 17786
		private LuaFunction m_ctor_hotfix;
	}
}
