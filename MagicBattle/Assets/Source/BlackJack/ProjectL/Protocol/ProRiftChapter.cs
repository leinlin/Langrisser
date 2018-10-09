using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000644 RID: 1604
	[ProtoContract(Name = "ProRiftChapter")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ProRiftChapter : IExtensible
	{
		// Token: 0x060057C6 RID: 22470 RVA: 0x0019913C File Offset: 0x0019733C
		public ProRiftChapter()
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

		// Token: 0x170015C0 RID: 5568
		// (get) Token: 0x060057C7 RID: 22471 RVA: 0x001991B8 File Offset: 0x001973B8
		[ProtoMember(1, Name = "ChapterLevels", DataFormat = DataFormat.Default)]
		public List<ProRiftLevel> ChapterLevels
		{
			get
			{
				return this._ChapterLevels;
			}
		}

		// Token: 0x170015C1 RID: 5569
		// (get) Token: 0x060057C8 RID: 22472 RVA: 0x001991C0 File Offset: 0x001973C0
		[ProtoMember(2, Name = "StarRewardIndexes", DataFormat = DataFormat.TwosComplement)]
		public List<int> StarRewardIndexes
		{
			get
			{
				return this._StarRewardIndexes;
			}
		}

		// Token: 0x060057C9 RID: 22473 RVA: 0x001991C8 File Offset: 0x001973C8
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060057CA RID: 22474 RVA: 0x001991D8 File Offset: 0x001973D8
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

		// Token: 0x060057CB RID: 22475 RVA: 0x001992A4 File Offset: 0x001974A4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProRiftChapter));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040041E6 RID: 16870
		private readonly List<ProRiftLevel> _ChapterLevels = new List<ProRiftLevel>();

		// Token: 0x040041E7 RID: 16871
		private readonly List<int> _StarRewardIndexes = new List<int>();

		// Token: 0x040041E8 RID: 16872
		private IExtension extensionObject;

		// Token: 0x040041E9 RID: 16873
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040041EA RID: 16874
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040041EB RID: 16875
		private LuaFunction m_ctor_hotfix;
	}
}
