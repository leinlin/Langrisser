using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000815 RID: 2069
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "RealTimePVPAcquireWinsBonusReq")]
	[Serializable]
	public class RealTimePVPAcquireWinsBonusReq : IExtensible
	{
		// Token: 0x06006867 RID: 26727 RVA: 0x001D73B8 File Offset: 0x001D55B8
		public RealTimePVPAcquireWinsBonusReq()
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

		// Token: 0x17001ACD RID: 6861
		// (get) Token: 0x06006868 RID: 26728 RVA: 0x001D7420 File Offset: 0x001D5620
		// (set) Token: 0x06006869 RID: 26729 RVA: 0x001D7428 File Offset: 0x001D5628
		[ProtoMember(1, IsRequired = true, Name = "BonusId", DataFormat = DataFormat.TwosComplement)]
		public int BonusId
		{
			get
			{
				return this._BonusId;
			}
			set
			{
				this._BonusId = value;
			}
		}

		// Token: 0x0600686A RID: 26730 RVA: 0x001D7434 File Offset: 0x001D5634
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600686B RID: 26731 RVA: 0x001D7444 File Offset: 0x001D5644
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

		// Token: 0x0600686C RID: 26732 RVA: 0x001D7510 File Offset: 0x001D5710
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(RealTimePVPAcquireWinsBonusReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04005077 RID: 20599
		private int _BonusId;

		// Token: 0x04005078 RID: 20600
		private IExtension extensionObject;

		// Token: 0x04005079 RID: 20601
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400507A RID: 20602
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400507B RID: 20603
		private LuaFunction m_ctor_hotfix;
	}
}
