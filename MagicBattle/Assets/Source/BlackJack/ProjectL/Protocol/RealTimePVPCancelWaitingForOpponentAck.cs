using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000810 RID: 2064
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "RealTimePVPCancelWaitingForOpponentAck")]
	[Serializable]
	public class RealTimePVPCancelWaitingForOpponentAck : IExtensible
	{
		// Token: 0x06006845 RID: 26693 RVA: 0x001D6AC0 File Offset: 0x001D4CC0
		public RealTimePVPCancelWaitingForOpponentAck()
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

		// Token: 0x17001AC5 RID: 6853
		// (get) Token: 0x06006846 RID: 26694 RVA: 0x001D6B28 File Offset: 0x001D4D28
		// (set) Token: 0x06006847 RID: 26695 RVA: 0x001D6B30 File Offset: 0x001D4D30
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

		// Token: 0x06006848 RID: 26696 RVA: 0x001D6B3C File Offset: 0x001D4D3C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006849 RID: 26697 RVA: 0x001D6B4C File Offset: 0x001D4D4C
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

		// Token: 0x0600684A RID: 26698 RVA: 0x001D6C18 File Offset: 0x001D4E18
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(RealTimePVPCancelWaitingForOpponentAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400505B RID: 20571
		private int _Result;

		// Token: 0x0400505C RID: 20572
		private IExtension extensionObject;

		// Token: 0x0400505D RID: 20573
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400505E RID: 20574
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400505F RID: 20575
		private LuaFunction m_ctor_hotfix;
	}
}
