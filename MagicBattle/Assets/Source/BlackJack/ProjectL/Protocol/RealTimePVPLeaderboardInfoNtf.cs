using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000817 RID: 2071
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "RealTimePVPLeaderboardInfoNtf")]
	[Serializable]
	public class RealTimePVPLeaderboardInfoNtf : IExtensible
	{
		// Token: 0x06006878 RID: 26744 RVA: 0x001D7774 File Offset: 0x001D5974
		public RealTimePVPLeaderboardInfoNtf()
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

		// Token: 0x17001AD2 RID: 6866
		// (get) Token: 0x06006879 RID: 26745 RVA: 0x001D77DC File Offset: 0x001D59DC
		// (set) Token: 0x0600687A RID: 26746 RVA: 0x001D77E4 File Offset: 0x001D59E4
		[ProtoMember(1, IsRequired = true, Name = "Info", DataFormat = DataFormat.Default)]
		public ProRealTimePVPUserInfo Info
		{
			get
			{
				return this._Info;
			}
			set
			{
				this._Info = value;
			}
		}

		// Token: 0x0600687B RID: 26747 RVA: 0x001D77F0 File Offset: 0x001D59F0
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600687C RID: 26748 RVA: 0x001D7800 File Offset: 0x001D5A00
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

		// Token: 0x0600687D RID: 26749 RVA: 0x001D78CC File Offset: 0x001D5ACC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(RealTimePVPLeaderboardInfoNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04005084 RID: 20612
		private ProRealTimePVPUserInfo _Info;

		// Token: 0x04005085 RID: 20613
		private IExtension extensionObject;

		// Token: 0x04005086 RID: 20614
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04005087 RID: 20615
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04005088 RID: 20616
		private LuaFunction m_ctor_hotfix;
	}
}
