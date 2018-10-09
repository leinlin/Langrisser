using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000835 RID: 2101
	[ProtoContract(Name = "TeamRoomQuitAck")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class TeamRoomQuitAck : IExtensible
	{
		// Token: 0x06006976 RID: 26998 RVA: 0x001DAF20 File Offset: 0x001D9120
		public TeamRoomQuitAck()
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

		// Token: 0x17001B19 RID: 6937
		// (get) Token: 0x06006977 RID: 26999 RVA: 0x001DAF88 File Offset: 0x001D9188
		// (set) Token: 0x06006978 RID: 27000 RVA: 0x001DAF90 File Offset: 0x001D9190
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

		// Token: 0x06006979 RID: 27001 RVA: 0x001DAF9C File Offset: 0x001D919C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600697A RID: 27002 RVA: 0x001DAFAC File Offset: 0x001D91AC
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

		// Token: 0x0600697B RID: 27003 RVA: 0x001DB078 File Offset: 0x001D9278
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(TeamRoomQuitAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04005143 RID: 20803
		private int _Result;

		// Token: 0x04005144 RID: 20804
		private IExtension extensionObject;

		// Token: 0x04005145 RID: 20805
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04005146 RID: 20806
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04005147 RID: 20807
		private LuaFunction m_ctor_hotfix;
	}
}
