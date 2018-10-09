using System;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000638 RID: 1592
	[ProtoContract(Name = "HeroCommentGetAck")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class HeroCommentGetAck : IExtensible
	{
		// Token: 0x06005728 RID: 22312 RVA: 0x00197898 File Offset: 0x00195A98
		public HeroCommentGetAck()
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

		// Token: 0x17001585 RID: 5509
		// (get) Token: 0x06005729 RID: 22313 RVA: 0x00197900 File Offset: 0x00195B00
		// (set) Token: 0x0600572A RID: 22314 RVA: 0x00197908 File Offset: 0x00195B08
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

		// Token: 0x17001586 RID: 5510
		// (get) Token: 0x0600572B RID: 22315 RVA: 0x00197914 File Offset: 0x00195B14
		// (set) Token: 0x0600572C RID: 22316 RVA: 0x0019791C File Offset: 0x00195B1C
		[ProtoMember(2, IsRequired = true, Name = "HeroId", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17001587 RID: 5511
		// (get) Token: 0x0600572D RID: 22317 RVA: 0x00197928 File Offset: 0x00195B28
		// (set) Token: 0x0600572E RID: 22318 RVA: 0x00197930 File Offset: 0x00195B30
		[DefaultValue(null)]
		[ProtoMember(3, IsRequired = false, Name = "HeroComment", DataFormat = DataFormat.Default)]
		public ProHeroComment HeroComment
		{
			get
			{
				return this._HeroComment;
			}
			set
			{
				this._HeroComment = value;
			}
		}

		// Token: 0x17001588 RID: 5512
		// (get) Token: 0x0600572F RID: 22319 RVA: 0x0019793C File Offset: 0x00195B3C
		// (set) Token: 0x06005730 RID: 22320 RVA: 0x00197944 File Offset: 0x00195B44
		[ProtoMember(4, IsRequired = false, Name = "PlayerCommentEntry", DataFormat = DataFormat.Default)]
		[DefaultValue(null)]
		public ProPlayerHeroCommentEntry PlayerCommentEntry
		{
			get
			{
				return this._PlayerCommentEntry;
			}
			set
			{
				this._PlayerCommentEntry = value;
			}
		}

		// Token: 0x06005731 RID: 22321 RVA: 0x00197950 File Offset: 0x00195B50
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005732 RID: 22322 RVA: 0x00197960 File Offset: 0x00195B60
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

		// Token: 0x06005733 RID: 22323 RVA: 0x00197A2C File Offset: 0x00195C2C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroCommentGetAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400417B RID: 16763
		private int _Result;

		// Token: 0x0400417C RID: 16764
		private int _HeroId;

		// Token: 0x0400417D RID: 16765
		private ProHeroComment _HeroComment;

		// Token: 0x0400417E RID: 16766
		private ProPlayerHeroCommentEntry _PlayerCommentEntry;

		// Token: 0x0400417F RID: 16767
		private IExtension extensionObject;

		// Token: 0x04004180 RID: 16768
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004181 RID: 16769
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004182 RID: 16770
		private LuaFunction m_ctor_hotfix;
	}
}
