using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000700 RID: 1792
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "RankingListInfoQueryReq")]
	[Serializable]
	public class RankingListInfoQueryReq : IExtensible
	{
		// Token: 0x06005F47 RID: 24391 RVA: 0x001AFD7C File Offset: 0x001ADF7C
		public RankingListInfoQueryReq()
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

		// Token: 0x1700183E RID: 6206
		// (get) Token: 0x06005F48 RID: 24392 RVA: 0x001AFDE4 File Offset: 0x001ADFE4
		// (set) Token: 0x06005F49 RID: 24393 RVA: 0x001AFDEC File Offset: 0x001ADFEC
		[ProtoMember(1, IsRequired = true, Name = "RankingListType", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x1700183F RID: 6207
		// (get) Token: 0x06005F4A RID: 24394 RVA: 0x001AFDF8 File Offset: 0x001ADFF8
		// (set) Token: 0x06005F4B RID: 24395 RVA: 0x001AFE00 File Offset: 0x001AE000
		[ProtoMember(2, IsRequired = true, Name = "HeroId", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x06005F4C RID: 24396 RVA: 0x001AFE0C File Offset: 0x001AE00C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005F4D RID: 24397 RVA: 0x001AFE1C File Offset: 0x001AE01C
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

		// Token: 0x06005F4E RID: 24398 RVA: 0x001AFEE8 File Offset: 0x001AE0E8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(RankingListInfoQueryReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004754 RID: 18260
		private int _RankingListType;

		// Token: 0x04004755 RID: 18261
		private int _HeroId;

		// Token: 0x04004756 RID: 18262
		private IExtension extensionObject;

		// Token: 0x04004757 RID: 18263
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004758 RID: 18264
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004759 RID: 18265
		private LuaFunction m_ctor_hotfix;
	}
}
