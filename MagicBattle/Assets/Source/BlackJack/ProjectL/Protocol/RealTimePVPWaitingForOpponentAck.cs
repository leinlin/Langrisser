using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200080D RID: 2061
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "RealTimePVPWaitingForOpponentAck")]
	[Serializable]
	public class RealTimePVPWaitingForOpponentAck : IExtensible
	{
		// Token: 0x0600682F RID: 26671 RVA: 0x001D6558 File Offset: 0x001D4758
		public RealTimePVPWaitingForOpponentAck()
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

		// Token: 0x17001AC0 RID: 6848
		// (get) Token: 0x06006830 RID: 26672 RVA: 0x001D65C0 File Offset: 0x001D47C0
		// (set) Token: 0x06006831 RID: 26673 RVA: 0x001D65C8 File Offset: 0x001D47C8
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

		// Token: 0x17001AC1 RID: 6849
		// (get) Token: 0x06006832 RID: 26674 RVA: 0x001D65D4 File Offset: 0x001D47D4
		// (set) Token: 0x06006833 RID: 26675 RVA: 0x001D65DC File Offset: 0x001D47DC
		[ProtoMember(2, IsRequired = true, Name = "ExpectedWaitingTime", DataFormat = DataFormat.TwosComplement)]
		public int ExpectedWaitingTime
		{
			get
			{
				return this._ExpectedWaitingTime;
			}
			set
			{
				this._ExpectedWaitingTime = value;
			}
		}

		// Token: 0x17001AC2 RID: 6850
		// (get) Token: 0x06006834 RID: 26676 RVA: 0x001D65E8 File Offset: 0x001D47E8
		// (set) Token: 0x06006835 RID: 26677 RVA: 0x001D65F0 File Offset: 0x001D47F0
		[ProtoMember(3, IsRequired = true, Name = "Req", DataFormat = DataFormat.Default)]
		public RealTimePVPWaitingForOpponentReq Req
		{
			get
			{
				return this._Req;
			}
			set
			{
				this._Req = value;
			}
		}

		// Token: 0x06006836 RID: 26678 RVA: 0x001D65FC File Offset: 0x001D47FC
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006837 RID: 26679 RVA: 0x001D660C File Offset: 0x001D480C
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

		// Token: 0x06006838 RID: 26680 RVA: 0x001D66D8 File Offset: 0x001D48D8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(RealTimePVPWaitingForOpponentAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400504A RID: 20554
		private int _Result;

		// Token: 0x0400504B RID: 20555
		private int _ExpectedWaitingTime;

		// Token: 0x0400504C RID: 20556
		private RealTimePVPWaitingForOpponentReq _Req;

		// Token: 0x0400504D RID: 20557
		private IExtension extensionObject;

		// Token: 0x0400504E RID: 20558
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400504F RID: 20559
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04005050 RID: 20560
		private LuaFunction m_ctor_hotfix;
	}
}
