using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200070F RID: 1807
	[ProtoContract(Name = "FansRewardsFromPBTCBTInfoAck")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class FansRewardsFromPBTCBTInfoAck : IExtensible
	{
		// Token: 0x06005FB0 RID: 24496 RVA: 0x001B185C File Offset: 0x001AFA5C
		public FansRewardsFromPBTCBTInfoAck()
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

		// Token: 0x17001855 RID: 6229
		// (get) Token: 0x06005FB1 RID: 24497 RVA: 0x001B18C4 File Offset: 0x001AFAC4
		// (set) Token: 0x06005FB2 RID: 24498 RVA: 0x001B18CC File Offset: 0x001AFACC
		[ProtoMember(1, IsRequired = true, Name = "SkinId", DataFormat = DataFormat.TwosComplement)]
		public int SkinId
		{
			get
			{
				return this._SkinId;
			}
			set
			{
				this._SkinId = value;
			}
		}

		// Token: 0x17001856 RID: 6230
		// (get) Token: 0x06005FB3 RID: 24499 RVA: 0x001B18D8 File Offset: 0x001AFAD8
		// (set) Token: 0x06005FB4 RID: 24500 RVA: 0x001B18E0 File Offset: 0x001AFAE0
		[ProtoMember(2, IsRequired = true, Name = "HeadFrameId", DataFormat = DataFormat.TwosComplement)]
		public int HeadFrameId
		{
			get
			{
				return this._HeadFrameId;
			}
			set
			{
				this._HeadFrameId = value;
			}
		}

		// Token: 0x17001857 RID: 6231
		// (get) Token: 0x06005FB5 RID: 24501 RVA: 0x001B18EC File Offset: 0x001AFAEC
		// (set) Token: 0x06005FB6 RID: 24502 RVA: 0x001B18F4 File Offset: 0x001AFAF4
		[ProtoMember(3, IsRequired = true, Name = "Claimed", DataFormat = DataFormat.Default)]
		public bool Claimed
		{
			get
			{
				return this._Claimed;
			}
			set
			{
				this._Claimed = value;
			}
		}

		// Token: 0x17001858 RID: 6232
		// (get) Token: 0x06005FB7 RID: 24503 RVA: 0x001B1900 File Offset: 0x001AFB00
		// (set) Token: 0x06005FB8 RID: 24504 RVA: 0x001B1908 File Offset: 0x001AFB08
		[ProtoMember(4, IsRequired = true, Name = "StartDate", DataFormat = DataFormat.TwosComplement)]
		public long StartDate
		{
			get
			{
				return this._StartDate;
			}
			set
			{
				this._StartDate = value;
			}
		}

		// Token: 0x17001859 RID: 6233
		// (get) Token: 0x06005FB9 RID: 24505 RVA: 0x001B1914 File Offset: 0x001AFB14
		// (set) Token: 0x06005FBA RID: 24506 RVA: 0x001B191C File Offset: 0x001AFB1C
		[ProtoMember(5, IsRequired = true, Name = "EndDate", DataFormat = DataFormat.TwosComplement)]
		public long EndDate
		{
			get
			{
				return this._EndDate;
			}
			set
			{
				this._EndDate = value;
			}
		}

		// Token: 0x06005FBB RID: 24507 RVA: 0x001B1928 File Offset: 0x001AFB28
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005FBC RID: 24508 RVA: 0x001B1938 File Offset: 0x001AFB38
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

		// Token: 0x06005FBD RID: 24509 RVA: 0x001B1A04 File Offset: 0x001AFC04
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(FansRewardsFromPBTCBTInfoAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040047A7 RID: 18343
		private int _SkinId;

		// Token: 0x040047A8 RID: 18344
		private int _HeadFrameId;

		// Token: 0x040047A9 RID: 18345
		private bool _Claimed;

		// Token: 0x040047AA RID: 18346
		private long _StartDate;

		// Token: 0x040047AB RID: 18347
		private long _EndDate;

		// Token: 0x040047AC RID: 18348
		private IExtension extensionObject;

		// Token: 0x040047AD RID: 18349
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040047AE RID: 18350
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040047AF RID: 18351
		private LuaFunction m_ctor_hotfix;
	}
}
