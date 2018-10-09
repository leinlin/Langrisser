using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000695 RID: 1685
	[ProtoContract(Name = "ProRealTimePVPLeaderboardPlayerInfo")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ProRealTimePVPLeaderboardPlayerInfo : IExtensible
	{
		// Token: 0x06005B7D RID: 23421 RVA: 0x001A33A0 File Offset: 0x001A15A0
		public ProRealTimePVPLeaderboardPlayerInfo()
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

		// Token: 0x17001718 RID: 5912
		// (get) Token: 0x06005B7E RID: 23422 RVA: 0x001A3408 File Offset: 0x001A1608
		// (set) Token: 0x06005B7F RID: 23423 RVA: 0x001A3410 File Offset: 0x001A1610
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

		// Token: 0x17001719 RID: 5913
		// (get) Token: 0x06005B80 RID: 23424 RVA: 0x001A341C File Offset: 0x001A161C
		// (set) Token: 0x06005B81 RID: 23425 RVA: 0x001A3424 File Offset: 0x001A1624
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

		// Token: 0x1700171A RID: 5914
		// (get) Token: 0x06005B82 RID: 23426 RVA: 0x001A3430 File Offset: 0x001A1630
		// (set) Token: 0x06005B83 RID: 23427 RVA: 0x001A3438 File Offset: 0x001A1638
		[ProtoMember(3, IsRequired = true, Name = "Dan", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x1700171B RID: 5915
		// (get) Token: 0x06005B84 RID: 23428 RVA: 0x001A3444 File Offset: 0x001A1644
		// (set) Token: 0x06005B85 RID: 23429 RVA: 0x001A344C File Offset: 0x001A164C
		[ProtoMember(4, IsRequired = true, Name = "LocalRank", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x1700171C RID: 5916
		// (get) Token: 0x06005B86 RID: 23430 RVA: 0x001A3458 File Offset: 0x001A1658
		// (set) Token: 0x06005B87 RID: 23431 RVA: 0x001A3460 File Offset: 0x001A1660
		[ProtoMember(5, IsRequired = true, Name = "GlobalRank", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x06005B88 RID: 23432 RVA: 0x001A346C File Offset: 0x001A166C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005B89 RID: 23433 RVA: 0x001A347C File Offset: 0x001A167C
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

		// Token: 0x06005B8A RID: 23434 RVA: 0x001A3548 File Offset: 0x001A1748
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProRealTimePVPLeaderboardPlayerInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004482 RID: 17538
		private string _UserId;

		// Token: 0x04004483 RID: 17539
		private int _Score;

		// Token: 0x04004484 RID: 17540
		private int _Dan;

		// Token: 0x04004485 RID: 17541
		private int _LocalRank;

		// Token: 0x04004486 RID: 17542
		private int _GlobalRank;

		// Token: 0x04004487 RID: 17543
		private IExtension extensionObject;

		// Token: 0x04004488 RID: 17544
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004489 RID: 17545
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400448A RID: 17546
		private LuaFunction m_ctor_hotfix;
	}
}
