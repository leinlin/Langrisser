using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200082C RID: 2092
	[ProtoContract(Name = "TeamRoomAutoMatchReq")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class TeamRoomAutoMatchReq : IExtensible
	{
		// Token: 0x06006930 RID: 26928 RVA: 0x001D9EC0 File Offset: 0x001D80C0
		public TeamRoomAutoMatchReq()
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

		// Token: 0x17001B08 RID: 6920
		// (get) Token: 0x06006931 RID: 26929 RVA: 0x001D9F28 File Offset: 0x001D8128
		// (set) Token: 0x06006932 RID: 26930 RVA: 0x001D9F30 File Offset: 0x001D8130
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

		// Token: 0x17001B09 RID: 6921
		// (get) Token: 0x06006933 RID: 26931 RVA: 0x001D9F3C File Offset: 0x001D813C
		// (set) Token: 0x06006934 RID: 26932 RVA: 0x001D9F44 File Offset: 0x001D8144
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

		// Token: 0x06006935 RID: 26933 RVA: 0x001D9F50 File Offset: 0x001D8150
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006936 RID: 26934 RVA: 0x001D9F60 File Offset: 0x001D8160
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

		// Token: 0x06006937 RID: 26935 RVA: 0x001DA02C File Offset: 0x001D822C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(TeamRoomAutoMatchReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400510E RID: 20750
		private int _GameFunctionTypeId;

		// Token: 0x0400510F RID: 20751
		private int _LocationId;

		// Token: 0x04005110 RID: 20752
		private IExtension extensionObject;

		// Token: 0x04005111 RID: 20753
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04005112 RID: 20754
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04005113 RID: 20755
		private LuaFunction m_ctor_hotfix;
	}
}
