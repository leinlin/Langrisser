using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200072C RID: 1836
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "DSHeroDungeonNtf")]
	[Serializable]
	public class DSHeroDungeonNtf : IExtensible
	{
		// Token: 0x060060D5 RID: 24789 RVA: 0x001B50CC File Offset: 0x001B32CC
		public DSHeroDungeonNtf()
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

		// Token: 0x170018BC RID: 6332
		// (get) Token: 0x060060D6 RID: 24790 RVA: 0x001B5148 File Offset: 0x001B3348
		// (set) Token: 0x060060D7 RID: 24791 RVA: 0x001B5150 File Offset: 0x001B3350
		[ProtoMember(1, IsRequired = true, Name = "Version", DataFormat = DataFormat.TwosComplement)]
		public uint Version
		{
			get
			{
				return this._Version;
			}
			set
			{
				this._Version = value;
			}
		}

		// Token: 0x170018BD RID: 6333
		// (get) Token: 0x060060D8 RID: 24792 RVA: 0x001B515C File Offset: 0x001B335C
		[ProtoMember(2, Name = "AchievementRelationIds", DataFormat = DataFormat.TwosComplement)]
		public List<int> AchievementRelationIds
		{
			get
			{
				return this._AchievementRelationIds;
			}
		}

		// Token: 0x170018BE RID: 6334
		// (get) Token: 0x060060D9 RID: 24793 RVA: 0x001B5164 File Offset: 0x001B3364
		[ProtoMember(3, Name = "Chapters", DataFormat = DataFormat.Default)]
		public List<ProHeroDungeonChapter> Chapters
		{
			get
			{
				return this._Chapters;
			}
		}

		// Token: 0x170018BF RID: 6335
		// (get) Token: 0x060060DA RID: 24794 RVA: 0x001B516C File Offset: 0x001B336C
		// (set) Token: 0x060060DB RID: 24795 RVA: 0x001B5174 File Offset: 0x001B3374
		[ProtoMember(4, IsRequired = true, Name = "DailyChallengeNums", DataFormat = DataFormat.TwosComplement)]
		public int DailyChallengeNums
		{
			get
			{
				return this._DailyChallengeNums;
			}
			set
			{
				this._DailyChallengeNums = value;
			}
		}

		// Token: 0x060060DC RID: 24796 RVA: 0x001B5180 File Offset: 0x001B3380
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060060DD RID: 24797 RVA: 0x001B5190 File Offset: 0x001B3390
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

		// Token: 0x060060DE RID: 24798 RVA: 0x001B525C File Offset: 0x001B345C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(DSHeroDungeonNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004882 RID: 18562
		private uint _Version;

		// Token: 0x04004883 RID: 18563
		private readonly List<int> _AchievementRelationIds = new List<int>();

		// Token: 0x04004884 RID: 18564
		private readonly List<ProHeroDungeonChapter> _Chapters = new List<ProHeroDungeonChapter>();

		// Token: 0x04004885 RID: 18565
		private int _DailyChallengeNums;

		// Token: 0x04004886 RID: 18566
		private IExtension extensionObject;

		// Token: 0x04004887 RID: 18567
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004888 RID: 18568
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004889 RID: 18569
		private LuaFunction m_ctor_hotfix;
	}
}
