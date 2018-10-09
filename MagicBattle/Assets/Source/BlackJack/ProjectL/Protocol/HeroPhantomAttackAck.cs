using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020007A2 RID: 1954
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "HeroPhantomAttackAck")]
	[Serializable]
	public class HeroPhantomAttackAck : IExtensible
	{
		// Token: 0x06006478 RID: 25720 RVA: 0x001C2944 File Offset: 0x001C0B44
		public HeroPhantomAttackAck()
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

		// Token: 0x170019B1 RID: 6577
		// (get) Token: 0x06006479 RID: 25721 RVA: 0x001C29AC File Offset: 0x001C0BAC
		// (set) Token: 0x0600647A RID: 25722 RVA: 0x001C29B4 File Offset: 0x001C0BB4
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

		// Token: 0x170019B2 RID: 6578
		// (get) Token: 0x0600647B RID: 25723 RVA: 0x001C29C0 File Offset: 0x001C0BC0
		// (set) Token: 0x0600647C RID: 25724 RVA: 0x001C29C8 File Offset: 0x001C0BC8
		[ProtoMember(2, IsRequired = true, Name = "BattleBeginInfo", DataFormat = DataFormat.Default)]
		public ProBattleBeginInfo BattleBeginInfo
		{
			get
			{
				return this._BattleBeginInfo;
			}
			set
			{
				this._BattleBeginInfo = value;
			}
		}

		// Token: 0x170019B3 RID: 6579
		// (get) Token: 0x0600647D RID: 25725 RVA: 0x001C29D4 File Offset: 0x001C0BD4
		// (set) Token: 0x0600647E RID: 25726 RVA: 0x001C29DC File Offset: 0x001C0BDC
		[ProtoMember(3, IsRequired = true, Name = "Req", DataFormat = DataFormat.Default)]
		public HeroPhantomAttackReq Req
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

		// Token: 0x0600647F RID: 25727 RVA: 0x001C29E8 File Offset: 0x001C0BE8
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006480 RID: 25728 RVA: 0x001C29F8 File Offset: 0x001C0BF8
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

		// Token: 0x06006481 RID: 25729 RVA: 0x001C2AC4 File Offset: 0x001C0CC4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroPhantomAttackAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004B4F RID: 19279
		private int _Result;

		// Token: 0x04004B50 RID: 19280
		private ProBattleBeginInfo _BattleBeginInfo;

		// Token: 0x04004B51 RID: 19281
		private HeroPhantomAttackReq _Req;

		// Token: 0x04004B52 RID: 19282
		private IExtension extensionObject;

		// Token: 0x04004B53 RID: 19283
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004B54 RID: 19284
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004B55 RID: 19285
		private LuaFunction m_ctor_hotfix;
	}
}
