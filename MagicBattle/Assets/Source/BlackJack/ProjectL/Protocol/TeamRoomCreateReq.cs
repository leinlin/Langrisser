using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000828 RID: 2088
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "TeamRoomCreateReq")]
	[Serializable]
	public class TeamRoomCreateReq : IExtensible
	{
		// Token: 0x06006911 RID: 26897 RVA: 0x001D9770 File Offset: 0x001D7970
		public TeamRoomCreateReq()
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

		// Token: 0x17001B00 RID: 6912
		// (get) Token: 0x06006912 RID: 26898 RVA: 0x001D97D8 File Offset: 0x001D79D8
		// (set) Token: 0x06006913 RID: 26899 RVA: 0x001D97E0 File Offset: 0x001D79E0
		[ProtoMember(1, IsRequired = true, Name = "Setting", DataFormat = DataFormat.Default)]
		public ProTeamRoomSetting Setting
		{
			get
			{
				return this._Setting;
			}
			set
			{
				this._Setting = value;
			}
		}

		// Token: 0x06006914 RID: 26900 RVA: 0x001D97EC File Offset: 0x001D79EC
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006915 RID: 26901 RVA: 0x001D97FC File Offset: 0x001D79FC
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

		// Token: 0x06006916 RID: 26902 RVA: 0x001D98C8 File Offset: 0x001D7AC8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(TeamRoomCreateReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040050F6 RID: 20726
		private ProTeamRoomSetting _Setting;

		// Token: 0x040050F7 RID: 20727
		private IExtension extensionObject;

		// Token: 0x040050F8 RID: 20728
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040050F9 RID: 20729
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040050FA RID: 20730
		private LuaFunction m_ctor_hotfix;
	}
}
