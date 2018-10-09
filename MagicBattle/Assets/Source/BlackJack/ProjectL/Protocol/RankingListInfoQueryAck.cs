using System;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000701 RID: 1793
	[ProtoContract(Name = "RankingListInfoQueryAck")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class RankingListInfoQueryAck : IExtensible
	{
		// Token: 0x06005F4F RID: 24399 RVA: 0x001AFF50 File Offset: 0x001AE150
		public RankingListInfoQueryAck()
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

		// Token: 0x17001840 RID: 6208
		// (get) Token: 0x06005F50 RID: 24400 RVA: 0x001AFFB8 File Offset: 0x001AE1B8
		// (set) Token: 0x06005F51 RID: 24401 RVA: 0x001AFFC0 File Offset: 0x001AE1C0
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

		// Token: 0x17001841 RID: 6209
		// (get) Token: 0x06005F52 RID: 24402 RVA: 0x001AFFCC File Offset: 0x001AE1CC
		// (set) Token: 0x06005F53 RID: 24403 RVA: 0x001AFFD4 File Offset: 0x001AE1D4
		[ProtoMember(2, IsRequired = false, Name = "RankingListType", DataFormat = DataFormat.TwosComplement)]
		[DefaultValue(0)]
		public int RankingListType
		{
			get
			{
				return this._RankingListType;
			}
			set
			{
				this._RankingListType = value;
			}
		}

		// Token: 0x17001842 RID: 6210
		// (get) Token: 0x06005F54 RID: 24404 RVA: 0x001AFFE0 File Offset: 0x001AE1E0
		// (set) Token: 0x06005F55 RID: 24405 RVA: 0x001AFFE8 File Offset: 0x001AE1E8
		[DefaultValue(0)]
		[ProtoMember(3, IsRequired = false, Name = "HeroId", DataFormat = DataFormat.TwosComplement)]
		public int HeroId
		{
			get
			{
				return this._HeroId;
			}
			set
			{
				this._HeroId = value;
			}
		}

		// Token: 0x17001843 RID: 6211
		// (get) Token: 0x06005F56 RID: 24406 RVA: 0x001AFFF4 File Offset: 0x001AE1F4
		// (set) Token: 0x06005F57 RID: 24407 RVA: 0x001AFFFC File Offset: 0x001AE1FC
		[DefaultValue(null)]
		[ProtoMember(4, IsRequired = false, Name = "ListInfo", DataFormat = DataFormat.Default)]
		public ProRankingListInfo ListInfo
		{
			get
			{
				return this._ListInfo;
			}
			set
			{
				this._ListInfo = value;
			}
		}

		// Token: 0x06005F58 RID: 24408 RVA: 0x001B0008 File Offset: 0x001AE208
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005F59 RID: 24409 RVA: 0x001B0018 File Offset: 0x001AE218
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

		// Token: 0x06005F5A RID: 24410 RVA: 0x001B00E4 File Offset: 0x001AE2E4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(RankingListInfoQueryAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400475A RID: 18266
		private int _Result;

		// Token: 0x0400475B RID: 18267
		private int _RankingListType;

		// Token: 0x0400475C RID: 18268
		private int _HeroId;

		// Token: 0x0400475D RID: 18269
		private ProRankingListInfo _ListInfo;

		// Token: 0x0400475E RID: 18270
		private IExtension extensionObject;

		// Token: 0x0400475F RID: 18271
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004760 RID: 18272
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004761 RID: 18273
		private LuaFunction m_ctor_hotfix;
	}
}
