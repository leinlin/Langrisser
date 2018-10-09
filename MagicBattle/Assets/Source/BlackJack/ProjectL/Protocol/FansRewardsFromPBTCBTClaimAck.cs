using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000711 RID: 1809
	[ProtoContract(Name = "FansRewardsFromPBTCBTClaimAck")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class FansRewardsFromPBTCBTClaimAck : IExtensible
	{
		// Token: 0x06005FC2 RID: 24514 RVA: 0x001B1C18 File Offset: 0x001AFE18
		public FansRewardsFromPBTCBTClaimAck()
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

		// Token: 0x1700185A RID: 6234
		// (get) Token: 0x06005FC3 RID: 24515 RVA: 0x001B1C80 File Offset: 0x001AFE80
		// (set) Token: 0x06005FC4 RID: 24516 RVA: 0x001B1C88 File Offset: 0x001AFE88
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

		// Token: 0x1700185B RID: 6235
		// (get) Token: 0x06005FC5 RID: 24517 RVA: 0x001B1C94 File Offset: 0x001AFE94
		// (set) Token: 0x06005FC6 RID: 24518 RVA: 0x001B1C9C File Offset: 0x001AFE9C
		[ProtoMember(2, IsRequired = true, Name = "SkinId", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x1700185C RID: 6236
		// (get) Token: 0x06005FC7 RID: 24519 RVA: 0x001B1CA8 File Offset: 0x001AFEA8
		// (set) Token: 0x06005FC8 RID: 24520 RVA: 0x001B1CB0 File Offset: 0x001AFEB0
		[ProtoMember(3, IsRequired = true, Name = "HeadFrameId", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x06005FC9 RID: 24521 RVA: 0x001B1CBC File Offset: 0x001AFEBC
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005FCA RID: 24522 RVA: 0x001B1CCC File Offset: 0x001AFECC
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

		// Token: 0x06005FCB RID: 24523 RVA: 0x001B1D98 File Offset: 0x001AFF98
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(FansRewardsFromPBTCBTClaimAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040047B4 RID: 18356
		private int _Result;

		// Token: 0x040047B5 RID: 18357
		private int _SkinId;

		// Token: 0x040047B6 RID: 18358
		private int _HeadFrameId;

		// Token: 0x040047B7 RID: 18359
		private IExtension extensionObject;

		// Token: 0x040047B8 RID: 18360
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040047B9 RID: 18361
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040047BA RID: 18362
		private LuaFunction m_ctor_hotfix;
	}
}
