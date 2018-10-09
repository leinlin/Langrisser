using System;
using System.Collections.Generic;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200081B RID: 2075
	[ProtoContract(Name = "RiftLevelBattleFinishedAck")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class RiftLevelBattleFinishedAck : IExtensible
	{
		// Token: 0x06006896 RID: 26774 RVA: 0x001D7EB0 File Offset: 0x001D60B0
		public RiftLevelBattleFinishedAck()
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

		// Token: 0x17001AD9 RID: 6873
		// (get) Token: 0x06006897 RID: 26775 RVA: 0x001D7F38 File Offset: 0x001D6138
		// (set) Token: 0x06006898 RID: 26776 RVA: 0x001D7F40 File Offset: 0x001D6140
		[ProtoMember(1, IsRequired = true, Name = "Result", DataFormat = DataFormat.TwosComplement)]
		public int Result
		{
			get
			{
				return this._Result;
			}
			set
			{
				this._Result = value;
			}
		}

		// Token: 0x17001ADA RID: 6874
		// (get) Token: 0x06006899 RID: 26777 RVA: 0x001D7F4C File Offset: 0x001D614C
		// (set) Token: 0x0600689A RID: 26778 RVA: 0x001D7F54 File Offset: 0x001D6154
		[ProtoMember(2, IsRequired = true, Name = "RiftLevelId", DataFormat = DataFormat.TwosComplement)]
		public int RiftLevelId
		{
			get
			{
				return this._RiftLevelId;
			}
			set
			{
				this._RiftLevelId = value;
			}
		}

		// Token: 0x17001ADB RID: 6875
		// (get) Token: 0x0600689B RID: 26779 RVA: 0x001D7F60 File Offset: 0x001D6160
		[ProtoMember(3, Name = "AchievementIds", DataFormat = DataFormat.TwosComplement)]
		public List<int> AchievementIds
		{
			get
			{
				return this._AchievementIds;
			}
		}

		// Token: 0x17001ADC RID: 6876
		// (get) Token: 0x0600689C RID: 26780 RVA: 0x001D7F68 File Offset: 0x001D6168
		// (set) Token: 0x0600689D RID: 26781 RVA: 0x001D7F70 File Offset: 0x001D6170
		[ProtoMember(4, IsRequired = true, Name = "GainStars", DataFormat = DataFormat.TwosComplement)]
		public int GainStars
		{
			get
			{
				return this._GainStars;
			}
			set
			{
				this._GainStars = value;
			}
		}

		// Token: 0x17001ADD RID: 6877
		// (get) Token: 0x0600689E RID: 26782 RVA: 0x001D7F7C File Offset: 0x001D617C
		// (set) Token: 0x0600689F RID: 26783 RVA: 0x001D7F84 File Offset: 0x001D6184
		[DefaultValue(null)]
		[ProtoMember(5, IsRequired = false, Name = "Ntf", DataFormat = DataFormat.Default)]
		public ProChangedGoodsNtf Ntf
		{
			get
			{
				return this._Ntf;
			}
			set
			{
				this._Ntf = value;
			}
		}

		// Token: 0x17001ADE RID: 6878
		// (get) Token: 0x060068A0 RID: 26784 RVA: 0x001D7F90 File Offset: 0x001D6190
		// (set) Token: 0x060068A1 RID: 26785 RVA: 0x001D7F98 File Offset: 0x001D6198
		[DefaultValue(null)]
		[ProtoMember(6, IsRequired = false, Name = "Treasure", DataFormat = DataFormat.Default)]
		public ProChangedGoodsNtf Treasure
		{
			get
			{
				return this._Treasure;
			}
			set
			{
				this._Treasure = value;
			}
		}

		// Token: 0x17001ADF RID: 6879
		// (get) Token: 0x060068A2 RID: 26786 RVA: 0x001D7FA4 File Offset: 0x001D61A4
		[ProtoMember(7, Name = "NormalRewards", DataFormat = DataFormat.Default)]
		public List<ProGoods> NormalRewards
		{
			get
			{
				return this._NormalRewards;
			}
		}

		// Token: 0x17001AE0 RID: 6880
		// (get) Token: 0x060068A3 RID: 26787 RVA: 0x001D7FAC File Offset: 0x001D61AC
		[ProtoMember(8, Name = "BattleTreasures", DataFormat = DataFormat.TwosComplement)]
		public List<int> BattleTreasures
		{
			get
			{
				return this._BattleTreasures;
			}
		}

		// Token: 0x060068A4 RID: 26788 RVA: 0x001D7FB4 File Offset: 0x001D61B4
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060068A5 RID: 26789 RVA: 0x001D7FC4 File Offset: 0x001D61C4
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

		// Token: 0x060068A6 RID: 26790 RVA: 0x001D8090 File Offset: 0x001D6290
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(RiftLevelBattleFinishedAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400509B RID: 20635
		private int _Result;

		// Token: 0x0400509C RID: 20636
		private int _RiftLevelId;

		// Token: 0x0400509D RID: 20637
		private readonly List<int> _AchievementIds = new List<int>();

		// Token: 0x0400509E RID: 20638
		private int _GainStars;

		// Token: 0x0400509F RID: 20639
		private ProChangedGoodsNtf _Ntf;

		// Token: 0x040050A0 RID: 20640
		private ProChangedGoodsNtf _Treasure;

		// Token: 0x040050A1 RID: 20641
		private readonly List<ProGoods> _NormalRewards = new List<ProGoods>();

		// Token: 0x040050A2 RID: 20642
		private readonly List<int> _BattleTreasures = new List<int>();

		// Token: 0x040050A3 RID: 20643
		private IExtension extensionObject;

		// Token: 0x040050A4 RID: 20644
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040050A5 RID: 20645
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040050A6 RID: 20646
		private LuaFunction m_ctor_hotfix;
	}
}
