using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000672 RID: 1650
	[ProtoContract(Name = "ProHeroDungeonChapter")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ProHeroDungeonChapter : IExtensible
	{
		// Token: 0x060059E6 RID: 23014 RVA: 0x0019EDD8 File Offset: 0x0019CFD8
		public ProHeroDungeonChapter()
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

		// Token: 0x17001687 RID: 5767
		// (get) Token: 0x060059E7 RID: 23015 RVA: 0x0019EE54 File Offset: 0x0019D054
		// (set) Token: 0x060059E8 RID: 23016 RVA: 0x0019EE5C File Offset: 0x0019D05C
		[ProtoMember(1, IsRequired = true, Name = "ChapterId", DataFormat = DataFormat.TwosComplement)]
		public int ChapterId
		{
			get
			{
				return this._ChapterId;
			}
			set
			{
				this._ChapterId = value;
			}
		}

		// Token: 0x17001688 RID: 5768
		// (get) Token: 0x060059E9 RID: 23017 RVA: 0x0019EE68 File Offset: 0x0019D068
		[ProtoMember(2, Name = "ChapterLevels", DataFormat = DataFormat.Default)]
		public List<ProHeroDungeonLevel> ChapterLevels
		{
			get
			{
				return this._ChapterLevels;
			}
		}

		// Token: 0x17001689 RID: 5769
		// (get) Token: 0x060059EA RID: 23018 RVA: 0x0019EE70 File Offset: 0x0019D070
		[ProtoMember(3, Name = "StarRewardIndexes", DataFormat = DataFormat.TwosComplement)]
		public List<int> StarRewardIndexes
		{
			get
			{
				return this._StarRewardIndexes;
			}
		}

		// Token: 0x060059EB RID: 23019 RVA: 0x0019EE78 File Offset: 0x0019D078
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060059EC RID: 23020 RVA: 0x0019EE88 File Offset: 0x0019D088
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

		// Token: 0x060059ED RID: 23021 RVA: 0x0019EF54 File Offset: 0x0019D154
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProHeroDungeonChapter));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004365 RID: 17253
		private int _ChapterId;

		// Token: 0x04004366 RID: 17254
		private readonly List<ProHeroDungeonLevel> _ChapterLevels = new List<ProHeroDungeonLevel>();

		// Token: 0x04004367 RID: 17255
		private readonly List<int> _StarRewardIndexes = new List<int>();

		// Token: 0x04004368 RID: 17256
		private IExtension extensionObject;

		// Token: 0x04004369 RID: 17257
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400436A RID: 17258
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400436B RID: 17259
		private LuaFunction m_ctor_hotfix;
	}
}
