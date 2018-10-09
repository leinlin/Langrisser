using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200080C RID: 2060
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "RealTimePVPWaitingForOpponentReq")]
	[Serializable]
	public class RealTimePVPWaitingForOpponentReq : IExtensible
	{
		// Token: 0x06006829 RID: 26665 RVA: 0x001D6398 File Offset: 0x001D4598
		public RealTimePVPWaitingForOpponentReq()
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

		// Token: 0x17001ABF RID: 6847
		// (get) Token: 0x0600682A RID: 26666 RVA: 0x001D6400 File Offset: 0x001D4600
		// (set) Token: 0x0600682B RID: 26667 RVA: 0x001D6408 File Offset: 0x001D4608
		[ProtoMember(1, IsRequired = true, Name = "Mode", DataFormat = DataFormat.TwosComplement)]
		public int Mode
		{
			get
			{
				return this._Mode;
			}
			set
			{
				this._Mode = value;
			}
		}

		// Token: 0x0600682C RID: 26668 RVA: 0x001D6414 File Offset: 0x001D4614
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600682D RID: 26669 RVA: 0x001D6424 File Offset: 0x001D4624
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

		// Token: 0x0600682E RID: 26670 RVA: 0x001D64F0 File Offset: 0x001D46F0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(RealTimePVPWaitingForOpponentReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04005045 RID: 20549
		private int _Mode;

		// Token: 0x04005046 RID: 20550
		private IExtension extensionObject;

		// Token: 0x04005047 RID: 20551
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04005048 RID: 20552
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04005049 RID: 20553
		private LuaFunction m_ctor_hotfix;
	}
}
