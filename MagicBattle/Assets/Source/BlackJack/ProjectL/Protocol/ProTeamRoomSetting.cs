using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000675 RID: 1653
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ProTeamRoomSetting")]
	[Serializable]
	public class ProTeamRoomSetting : IExtensible
	{
		// Token: 0x06005A0A RID: 23050 RVA: 0x0019F3DC File Offset: 0x0019D5DC
		public ProTeamRoomSetting()
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

		// Token: 0x17001694 RID: 5780
		// (get) Token: 0x06005A0B RID: 23051 RVA: 0x0019F444 File Offset: 0x0019D644
		// (set) Token: 0x06005A0C RID: 23052 RVA: 0x0019F44C File Offset: 0x0019D64C
		[ProtoMember(1, IsRequired = true, Name = "GameFunctionTypeId", DataFormat = DataFormat.TwosComplement)]
		public int GameFunctionTypeId
		{
			get
			{
				return this._GameFunctionTypeId;
			}
			set
			{
				this._GameFunctionTypeId = value;
			}
		}

		// Token: 0x17001695 RID: 5781
		// (get) Token: 0x06005A0D RID: 23053 RVA: 0x0019F458 File Offset: 0x0019D658
		// (set) Token: 0x06005A0E RID: 23054 RVA: 0x0019F460 File Offset: 0x0019D660
		[ProtoMember(2, IsRequired = true, Name = "LocationId", DataFormat = DataFormat.TwosComplement)]
		public int LocationId
		{
			get
			{
				return this._LocationId;
			}
			set
			{
				this._LocationId = value;
			}
		}

		// Token: 0x17001696 RID: 5782
		// (get) Token: 0x06005A0F RID: 23055 RVA: 0x0019F46C File Offset: 0x0019D66C
		// (set) Token: 0x06005A10 RID: 23056 RVA: 0x0019F474 File Offset: 0x0019D674
		[ProtoMember(3, IsRequired = true, Name = "JoinMinLevel", DataFormat = DataFormat.TwosComplement)]
		public int JoinMinLevel
		{
			get
			{
				return this._JoinMinLevel;
			}
			set
			{
				this._JoinMinLevel = value;
			}
		}

		// Token: 0x17001697 RID: 5783
		// (get) Token: 0x06005A11 RID: 23057 RVA: 0x0019F480 File Offset: 0x0019D680
		// (set) Token: 0x06005A12 RID: 23058 RVA: 0x0019F488 File Offset: 0x0019D688
		[ProtoMember(4, IsRequired = true, Name = "JoinMaxLevel", DataFormat = DataFormat.TwosComplement)]
		public int JoinMaxLevel
		{
			get
			{
				return this._JoinMaxLevel;
			}
			set
			{
				this._JoinMaxLevel = value;
			}
		}

		// Token: 0x17001698 RID: 5784
		// (get) Token: 0x06005A13 RID: 23059 RVA: 0x0019F494 File Offset: 0x0019D694
		// (set) Token: 0x06005A14 RID: 23060 RVA: 0x0019F49C File Offset: 0x0019D69C
		[ProtoMember(5, IsRequired = true, Name = "Authority", DataFormat = DataFormat.TwosComplement)]
		public int Authority
		{
			get
			{
				return this._Authority;
			}
			set
			{
				this._Authority = value;
			}
		}

		// Token: 0x06005A15 RID: 23061 RVA: 0x0019F4A8 File Offset: 0x0019D6A8
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005A16 RID: 23062 RVA: 0x0019F4B8 File Offset: 0x0019D6B8
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

		// Token: 0x06005A17 RID: 23063 RVA: 0x0019F584 File Offset: 0x0019D784
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProTeamRoomSetting));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400437E RID: 17278
		private int _GameFunctionTypeId;

		// Token: 0x0400437F RID: 17279
		private int _LocationId;

		// Token: 0x04004380 RID: 17280
		private int _JoinMinLevel;

		// Token: 0x04004381 RID: 17281
		private int _JoinMaxLevel;

		// Token: 0x04004382 RID: 17282
		private int _Authority;

		// Token: 0x04004383 RID: 17283
		private IExtension extensionObject;

		// Token: 0x04004384 RID: 17284
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004385 RID: 17285
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004386 RID: 17286
		private LuaFunction m_ctor_hotfix;
	}
}
