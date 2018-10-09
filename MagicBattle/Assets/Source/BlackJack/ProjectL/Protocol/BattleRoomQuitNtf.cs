using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200060C RID: 1548
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "BattleRoomQuitNtf")]
	[Serializable]
	public class BattleRoomQuitNtf : IExtensible
	{
		// Token: 0x060055A7 RID: 21927 RVA: 0x00192648 File Offset: 0x00190848
		public BattleRoomQuitNtf()
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

		// Token: 0x17001518 RID: 5400
		// (get) Token: 0x060055A8 RID: 21928 RVA: 0x001926B0 File Offset: 0x001908B0
		// (set) Token: 0x060055A9 RID: 21929 RVA: 0x001926B8 File Offset: 0x001908B8
		[ProtoMember(1, IsRequired = true, Name = "SessionId", DataFormat = DataFormat.TwosComplement)]
		public ulong SessionId
		{
			get
			{
				return this._SessionId;
			}
			set
			{
				this._SessionId = value;
			}
		}

		// Token: 0x17001519 RID: 5401
		// (get) Token: 0x060055AA RID: 21930 RVA: 0x001926C4 File Offset: 0x001908C4
		// (set) Token: 0x060055AB RID: 21931 RVA: 0x001926CC File Offset: 0x001908CC
		[ProtoMember(2, IsRequired = true, Name = "Reason", DataFormat = DataFormat.TwosComplement)]
		public int Reason
		{
			get
			{
				return this._Reason;
			}
			set
			{
				this._Reason = value;
			}
		}

		// Token: 0x060055AC RID: 21932 RVA: 0x001926D8 File Offset: 0x001908D8
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060055AD RID: 21933 RVA: 0x001926E8 File Offset: 0x001908E8
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

		// Token: 0x060055AE RID: 21934 RVA: 0x001927B4 File Offset: 0x001909B4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattleRoomQuitNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400405E RID: 16478
		private ulong _SessionId;

		// Token: 0x0400405F RID: 16479
		private int _Reason;

		// Token: 0x04004060 RID: 16480
		private IExtension extensionObject;

		// Token: 0x04004061 RID: 16481
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004062 RID: 16482
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004063 RID: 16483
		private LuaFunction m_ctor_hotfix;
	}
}
