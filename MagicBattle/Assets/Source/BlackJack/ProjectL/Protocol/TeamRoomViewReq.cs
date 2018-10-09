using System;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200082A RID: 2090
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "TeamRoomViewReq")]
	[Serializable]
	public class TeamRoomViewReq : IExtensible
	{
		// Token: 0x0600691F RID: 26911 RVA: 0x001D9B04 File Offset: 0x001D7D04
		public TeamRoomViewReq()
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

		// Token: 0x17001B03 RID: 6915
		// (get) Token: 0x06006920 RID: 26912 RVA: 0x001D9B6C File Offset: 0x001D7D6C
		// (set) Token: 0x06006921 RID: 26913 RVA: 0x001D9B74 File Offset: 0x001D7D74
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

		// Token: 0x17001B04 RID: 6916
		// (get) Token: 0x06006922 RID: 26914 RVA: 0x001D9B80 File Offset: 0x001D7D80
		// (set) Token: 0x06006923 RID: 26915 RVA: 0x001D9B88 File Offset: 0x001D7D88
		[DefaultValue(0)]
		[ProtoMember(2, IsRequired = false, Name = "ChapterId", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17001B05 RID: 6917
		// (get) Token: 0x06006924 RID: 26916 RVA: 0x001D9B94 File Offset: 0x001D7D94
		// (set) Token: 0x06006925 RID: 26917 RVA: 0x001D9B9C File Offset: 0x001D7D9C
		[DefaultValue(0)]
		[ProtoMember(3, IsRequired = false, Name = "LocationId", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x06006926 RID: 26918 RVA: 0x001D9BA8 File Offset: 0x001D7DA8
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006927 RID: 26919 RVA: 0x001D9BB8 File Offset: 0x001D7DB8
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

		// Token: 0x06006928 RID: 26920 RVA: 0x001D9C84 File Offset: 0x001D7E84
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(TeamRoomViewReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04005101 RID: 20737
		private int _GameFunctionTypeId;

		// Token: 0x04005102 RID: 20738
		private int _ChapterId;

		// Token: 0x04005103 RID: 20739
		private int _LocationId;

		// Token: 0x04005104 RID: 20740
		private IExtension extensionObject;

		// Token: 0x04005105 RID: 20741
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04005106 RID: 20742
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04005107 RID: 20743
		private LuaFunction m_ctor_hotfix;
	}
}
