using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200082F RID: 2095
	[ProtoContract(Name = "TeamRoomAutoMatchCancelAck")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class TeamRoomAutoMatchCancelAck : IExtensible
	{
		// Token: 0x0600694A RID: 26954 RVA: 0x001DA450 File Offset: 0x001D8650
		public TeamRoomAutoMatchCancelAck()
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

		// Token: 0x17001B0F RID: 6927
		// (get) Token: 0x0600694B RID: 26955 RVA: 0x001DA4B8 File Offset: 0x001D86B8
		// (set) Token: 0x0600694C RID: 26956 RVA: 0x001DA4C0 File Offset: 0x001D86C0
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

		// Token: 0x0600694D RID: 26957 RVA: 0x001DA4CC File Offset: 0x001D86CC
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600694E RID: 26958 RVA: 0x001DA4DC File Offset: 0x001D86DC
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

		// Token: 0x0600694F RID: 26959 RVA: 0x001DA5A8 File Offset: 0x001D87A8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(TeamRoomAutoMatchCancelAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04005121 RID: 20769
		private int _Result;

		// Token: 0x04005122 RID: 20770
		private IExtension extensionObject;

		// Token: 0x04005123 RID: 20771
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04005124 RID: 20772
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04005125 RID: 20773
		private LuaFunction m_ctor_hotfix;
	}
}
