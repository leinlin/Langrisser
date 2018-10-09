using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000692 RID: 1682
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ProRealTimePVPUserInfo")]
	[Serializable]
	public class ProRealTimePVPUserInfo : IExtensible
	{
		// Token: 0x06005B55 RID: 23381 RVA: 0x001A2D3C File Offset: 0x001A0F3C
		public ProRealTimePVPUserInfo()
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

		// Token: 0x17001706 RID: 5894
		// (get) Token: 0x06005B56 RID: 23382 RVA: 0x001A2DA4 File Offset: 0x001A0FA4
		// (set) Token: 0x06005B57 RID: 23383 RVA: 0x001A2DAC File Offset: 0x001A0FAC
		[ProtoMember(1, IsRequired = true, Name = "UserId", DataFormat = DataFormat.Default)]
		public string UserId
		{
			get
			{
				return this._UserId;
			}
			set
			{
				this._UserId = value;
			}
		}

		// Token: 0x17001707 RID: 5895
		// (get) Token: 0x06005B58 RID: 23384 RVA: 0x001A2DB8 File Offset: 0x001A0FB8
		// (set) Token: 0x06005B59 RID: 23385 RVA: 0x001A2DC0 File Offset: 0x001A0FC0
		[ProtoMember(2, IsRequired = true, Name = "Score", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17001708 RID: 5896
		// (get) Token: 0x06005B5A RID: 23386 RVA: 0x001A2DCC File Offset: 0x001A0FCC
		// (set) Token: 0x06005B5B RID: 23387 RVA: 0x001A2DD4 File Offset: 0x001A0FD4
		[ProtoMember(3, IsRequired = true, Name = "LocalRank", DataFormat = DataFormat.TwosComplement)]
		public int LocalRank
		{
			get
			{
				return this._LocalRank;
			}
			set
			{
				this._LocalRank = value;
			}
		}

		// Token: 0x17001709 RID: 5897
		// (get) Token: 0x06005B5C RID: 23388 RVA: 0x001A2DE0 File Offset: 0x001A0FE0
		// (set) Token: 0x06005B5D RID: 23389 RVA: 0x001A2DE8 File Offset: 0x001A0FE8
		[ProtoMember(4, IsRequired = true, Name = "GlobalRank", DataFormat = DataFormat.TwosComplement)]
		public int GlobalRank
		{
			get
			{
				return this._GlobalRank;
			}
			set
			{
				this._GlobalRank = value;
			}
		}

		// Token: 0x1700170A RID: 5898
		// (get) Token: 0x06005B5E RID: 23390 RVA: 0x001A2DF4 File Offset: 0x001A0FF4
		// (set) Token: 0x06005B5F RID: 23391 RVA: 0x001A2DFC File Offset: 0x001A0FFC
		[ProtoMember(5, IsRequired = true, Name = "Dan", DataFormat = DataFormat.TwosComplement)]
		public int Dan
		{
			get
			{
				return this._Dan;
			}
			set
			{
				this._Dan = value;
			}
		}

		// Token: 0x06005B60 RID: 23392 RVA: 0x001A2E08 File Offset: 0x001A1008
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005B61 RID: 23393 RVA: 0x001A2E18 File Offset: 0x001A1018
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

		// Token: 0x06005B62 RID: 23394 RVA: 0x001A2EE4 File Offset: 0x001A10E4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProRealTimePVPUserInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004464 RID: 17508
		private string _UserId;

		// Token: 0x04004465 RID: 17509
		private int _Score;

		// Token: 0x04004466 RID: 17510
		private int _LocalRank;

		// Token: 0x04004467 RID: 17511
		private int _GlobalRank;

		// Token: 0x04004468 RID: 17512
		private int _Dan;

		// Token: 0x04004469 RID: 17513
		private IExtension extensionObject;

		// Token: 0x0400446A RID: 17514
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400446B RID: 17515
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400446C RID: 17516
		private LuaFunction m_ctor_hotfix;
	}
}
