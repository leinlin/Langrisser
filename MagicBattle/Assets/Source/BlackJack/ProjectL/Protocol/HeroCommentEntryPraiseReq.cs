using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200063B RID: 1595
	[ProtoContract(Name = "HeroCommentEntryPraiseReq")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class HeroCommentEntryPraiseReq : IExtensible
	{
		// Token: 0x0600574A RID: 22346 RVA: 0x00197E78 File Offset: 0x00196078
		public HeroCommentEntryPraiseReq()
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

		// Token: 0x17001590 RID: 5520
		// (get) Token: 0x0600574B RID: 22347 RVA: 0x00197EE0 File Offset: 0x001960E0
		// (set) Token: 0x0600574C RID: 22348 RVA: 0x00197EE8 File Offset: 0x001960E8
		[ProtoMember(1, IsRequired = true, Name = "HeroId", DataFormat = DataFormat.TwosComplement)]
		public int HeroId
		{
			get
			{
				return this._HeroId;
			}
			set
			{
				this._HeroId = value;
			}
		}

		// Token: 0x17001591 RID: 5521
		// (get) Token: 0x0600574D RID: 22349 RVA: 0x00197EF4 File Offset: 0x001960F4
		// (set) Token: 0x0600574E RID: 22350 RVA: 0x00197EFC File Offset: 0x001960FC
		[ProtoMember(2, IsRequired = true, Name = "entryInstanceId", DataFormat = DataFormat.TwosComplement)]
		public ulong EntryInstanceId
		{
			get
			{
				return this._entryInstanceId;
			}
			set
			{
				this._entryInstanceId = value;
			}
		}

		// Token: 0x17001592 RID: 5522
		// (get) Token: 0x0600574F RID: 22351 RVA: 0x00197F08 File Offset: 0x00196108
		// (set) Token: 0x06005750 RID: 22352 RVA: 0x00197F10 File Offset: 0x00196110
		[ProtoMember(3, IsRequired = true, Name = "LastUpdateTime", DataFormat = DataFormat.TwosComplement)]
		public long LastUpdateTime
		{
			get
			{
				return this._LastUpdateTime;
			}
			set
			{
				this._LastUpdateTime = value;
			}
		}

		// Token: 0x06005751 RID: 22353 RVA: 0x00197F1C File Offset: 0x0019611C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005752 RID: 22354 RVA: 0x00197F2C File Offset: 0x0019612C
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

		// Token: 0x06005753 RID: 22355 RVA: 0x00197FF8 File Offset: 0x001961F8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroCommentEntryPraiseReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004192 RID: 16786
		private int _HeroId;

		// Token: 0x04004193 RID: 16787
		private ulong _entryInstanceId;

		// Token: 0x04004194 RID: 16788
		private long _LastUpdateTime;

		// Token: 0x04004195 RID: 16789
		private IExtension extensionObject;

		// Token: 0x04004196 RID: 16790
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004197 RID: 16791
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004198 RID: 16792
		private LuaFunction m_ctor_hotfix;
	}
}
