using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020006A7 RID: 1703
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ProUnchartedScore")]
	[Serializable]
	public class ProUnchartedScore : IExtensible
	{
		// Token: 0x06005C69 RID: 23657 RVA: 0x001A5868 File Offset: 0x001A3A68
		public ProUnchartedScore()
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

		// Token: 0x1700176E RID: 5998
		// (get) Token: 0x06005C6A RID: 23658 RVA: 0x001A58F0 File Offset: 0x001A3AF0
		// (set) Token: 0x06005C6B RID: 23659 RVA: 0x001A58F8 File Offset: 0x001A3AF8
		[ProtoMember(1, IsRequired = true, Name = "Id", DataFormat = DataFormat.TwosComplement)]
		public int Id
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

		// Token: 0x1700176F RID: 5999
		// (get) Token: 0x06005C6C RID: 23660 RVA: 0x001A5904 File Offset: 0x001A3B04
		// (set) Token: 0x06005C6D RID: 23661 RVA: 0x001A590C File Offset: 0x001A3B0C
		[ProtoMember(2, IsRequired = true, Name = "BonusCount", DataFormat = DataFormat.TwosComplement)]
		public int BonusCount
		{
			get
			{
				return this._BonusCount;
			}
			set
			{
				this._BonusCount = value;
			}
		}

		// Token: 0x17001770 RID: 6000
		// (get) Token: 0x06005C6E RID: 23662 RVA: 0x001A5918 File Offset: 0x001A3B18
		// (set) Token: 0x06005C6F RID: 23663 RVA: 0x001A5920 File Offset: 0x001A3B20
		[ProtoMember(3, IsRequired = true, Name = "Score", DataFormat = DataFormat.TwosComplement)]
		public int Score
		{
			get
			{
				return this._Score;
			}
			set
			{
				this._Score = value;
			}
		}

		// Token: 0x17001771 RID: 6001
		// (get) Token: 0x06005C70 RID: 23664 RVA: 0x001A592C File Offset: 0x001A3B2C
		[ProtoMember(4, Name = "RewardGains", DataFormat = DataFormat.TwosComplement)]
		public List<int> RewardGains
		{
			get
			{
				return this._RewardGains;
			}
		}

		// Token: 0x17001772 RID: 6002
		// (get) Token: 0x06005C71 RID: 23665 RVA: 0x001A5934 File Offset: 0x001A3B34
		[ProtoMember(5, Name = "SocreLevelCompleteIds", DataFormat = DataFormat.TwosComplement)]
		public List<int> SocreLevelCompleteIds
		{
			get
			{
				return this._SocreLevelCompleteIds;
			}
		}

		// Token: 0x17001773 RID: 6003
		// (get) Token: 0x06005C72 RID: 23666 RVA: 0x001A593C File Offset: 0x001A3B3C
		[ProtoMember(6, Name = "ChallengeLevelCompleteIds", DataFormat = DataFormat.TwosComplement)]
		public List<int> ChallengeLevelCompleteIds
		{
			get
			{
				return this._ChallengeLevelCompleteIds;
			}
		}

		// Token: 0x06005C73 RID: 23667 RVA: 0x001A5944 File Offset: 0x001A3B44
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005C74 RID: 23668 RVA: 0x001A5954 File Offset: 0x001A3B54
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

		// Token: 0x06005C75 RID: 23669 RVA: 0x001A5A20 File Offset: 0x001A3C20
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProUnchartedScore));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004520 RID: 17696
		private int _Id;

		// Token: 0x04004521 RID: 17697
		private int _BonusCount;

		// Token: 0x04004522 RID: 17698
		private int _Score;

		// Token: 0x04004523 RID: 17699
		private readonly List<int> _RewardGains = new List<int>();

		// Token: 0x04004524 RID: 17700
		private readonly List<int> _SocreLevelCompleteIds = new List<int>();

		// Token: 0x04004525 RID: 17701
		private readonly List<int> _ChallengeLevelCompleteIds = new List<int>();

		// Token: 0x04004526 RID: 17702
		private IExtension extensionObject;

		// Token: 0x04004527 RID: 17703
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004528 RID: 17704
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004529 RID: 17705
		private LuaFunction m_ctor_hotfix;
	}
}
